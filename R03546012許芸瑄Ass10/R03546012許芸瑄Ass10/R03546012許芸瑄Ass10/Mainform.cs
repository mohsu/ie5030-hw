using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COPBenchmark;
using Steema.TeeChart.Styles;

namespace R03546012許芸瑄Ass10
{
    public partial class Mainform : Form
    {
        COPBenchmarkProblem theProblem = null;
        double[] soFarTheBestSol; //所有particle最好的點(x,z) GBEST
        double soFarTheBestObj;
        int bestIteration;
        double[][] particles; //particle目前的點(x,z)
        double[][] particleBestSol; //每個particle最好的點(x,z) PBEST
        double[][] particlev; //每個particle的velocity(x,z)
        double[] objectives; //y
        int numberOfParticles = 20;
        double selfFactor=0.5; //c1
        double socialFactor=0.5; //c2
        double frictionFactor = 0.5; //W
        
        Random rnd = new Random();

        //counts
        int iterationCount;
        int noImprovementCount;
        int evoCount;
        
        //limits
        int iterationLimit = 100;
        int noImprovementIterationLimit = 100;
        int evoCountLimit = 10000;

        public Mainform()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnOneIteration.Enabled = false;
            btnRunToEnd.Enabled = false;
        }

        private void OpenABenchMark(object sender, EventArgs e)
        {
            theProblem = COPBenchmarkProblem.LoadAProblem();
            COPBenchmarkProblem.DisplayAProblemOnPanel(theProblem, tabProblemInfo);
            if (theProblem.Dimension == 2)
            {
                double xinc = (theProblem.UpperBound[0] - theProblem.LowerBound[0]) / 100;
                for (double x = theProblem.LowerBound[0]; x <= theProblem.UpperBound[0]; x += xinc)
                {
                    double zinc = (theProblem.UpperBound[1] - theProblem.LowerBound[1]) / 100;
                    for (double z = theProblem.LowerBound[1]; z <= theProblem.UpperBound[1]; z += zinc)
                    {
                        double y = theProblem.GetObjectiveValue(x, z);
                        surface1.Add(x, y, z);
                    }
                }
            }
            btnReset.Enabled = true;
        }

        void Initialization()
        {
            //歸零
            points3D1.Clear();
            iterationCount = 0;
            noImprovementCount = 0;
            evoCount = 0;
            bestIteration = 0;
            soFarTheBestObj = double.MaxValue;

            tChart2.Series[0].XValues.Clear();
            tChart2.Series[0].YValues.Clear();
            tChart2.Series[1].XValues.Clear();
            tChart2.Series[1].YValues.Clear();
            tChart2.Series[2].XValues.Clear();
            tChart2.Series[2].YValues.Clear();

            if(checkBoxNumberOfSolutionAgent.Checked==true)
                numberOfParticles = Convert.ToInt16(numericUpDownNumberOfSolutionAgents.Value);

            particles = new double[numberOfParticles][];
            particleBestSol = new double[numberOfParticles][];
            particlev = new double[numberOfParticles][];
            objectives = new double[numberOfParticles];
            soFarTheBestSol = new double[theProblem.Dimension];
            for (int i = 0; i < numberOfParticles; i++)
            {
                particles[i] = new double[theProblem.Dimension];
                particleBestSol[i] = new double[theProblem.Dimension];
                particlev[i] = new double[theProblem.Dimension];
            }

            for (int j = 0; j < numberOfParticles; j++)
            {
                
                for (int i = 0; i < theProblem.Dimension; i++) //randomize particles
                {
                    particles[j][i] = theProblem.LowerBound[i] + rnd.NextDouble() *
                        (theProblem.UpperBound[i] - theProblem.LowerBound[i]);
                    particlev[j][i] = (theProblem.UpperBound[i] - theProblem.LowerBound[i])  *rnd.NextDouble(); //初始一個vo
                    particleBestSol[j][i] = particles[j][i]; // 直接assign給particleBest
                }
                objectives[j] = theProblem.GetObjectiveValue(particles[j]);
                if( theProblem.Dimension == 2 )
                {
                    points3D1.Add( particles[j][0], theProblem.GetObjectiveValue( particles[j] ) , particles[j][1] );
                 }
            }
            //so far the best
            double best = double.MaxValue;
            for (int j = 0; j < numberOfParticles; j++)
            {
                if (theProblem.GetObjectiveValue(particles[j]) < best)
                {
                    best = theProblem.GetObjectiveValue(particles[j]);
                    for (int i = 0; i < theProblem.Dimension; i++)
                        soFarTheBestSol[i] = particles[j][i];
                }
            }
            soFarTheBestObj = best;
            txtSoFarTheBest.Text = soFarTheBestObj.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnRunToEnd.Enabled = true;
            btnOneIteration.Enabled = true;

            Initialization();

        }

        private void btnOneIteration_Click(object sender, EventArgs e)
        {
            if (CheckLimits() == true)
            {
                RunOneIteration();
                iterationCount++;
            }
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            while (CheckLimits() == true)
            {
                RunOneIteration();
                iterationCount++;
            }
        }

        private void RunOneIteration()
        {
            //get UI
            selfFactor = Convert.ToDouble(numericUpDownSelfFactor.Value);
            socialFactor = Convert.ToDouble(numericUpDownSocialFactor.Value);
            frictionFactor = Convert.ToDouble(numericUpDownFrictionFactor.Value);
            //update particles
            for (int j = 0; j < numberOfParticles; j++)
            {
                for (int i = 0; i < theProblem.Dimension;i++ )
                {
                    particlev[j][i] =  particlev[j][i]*frictionFactor + selfFactor * rnd.NextDouble() * (particleBestSol[j][i] - particles[j][i])
                                             + selfFactor * rnd.NextDouble() * (soFarTheBestSol[i] - particles[j][i]); //v(t+1)=v(t)*W + c1*rnd*(pbest-x)+c2*rnd*(gbest-x)
                    particles[j][i] += particlev[j][i]; // x(t+1) = x(t) + v(t+1)
                    if (particles[j][i] > theProblem.UpperBound[i])
                        particles[j][i] = theProblem.UpperBound[i];
                    else if (particles[j][i] < theProblem.LowerBound[i])
                        particles[j][i] = theProblem.LowerBound[i];
                }
                //算objective
                objectives[j] = theProblem.GetObjectiveValue(particles[j]);
                evoCount++;
            }
            //iteration best & particle best
            double iterationBestObj = double.MaxValue;
            double averageObj = 0;
            int iterationBestID = 0;
            for (int j = 0; j < numberOfParticles; j++)
            {
                //compute average
                averageObj += objectives[j];
                //update particle best
                if (objectives[j] < theProblem.GetObjectiveValue(particleBestSol[j]))
                {
                    for (int i = 0; i < theProblem.Dimension; i++)
                        particleBestSol[j][i] = particles[j][i];
                }
                //update iteration best 
                if (objectives[j] < iterationBestObj)
                {
                    iterationBestObj = objectives[j];
                    iterationBestID = j;
                }
            }
            averageObj = averageObj / numberOfParticles;
            //update so far the best
            if (iterationBestObj < soFarTheBestObj)
            {
                soFarTheBestObj = iterationBestObj;
                for (int i = 0; i < theProblem.Dimension; i++)
                    soFarTheBestSol[i] = particles[iterationBestID][i];
                bestIteration = iterationCount;
            }
            else
                noImprovementCount++;
            //to UI
            txtIterationID.Text = iterationCount.ToString();
            txtNumberOfFunctionCalls.Text = evoCount.ToString();
            txtAtIteration.Text = bestIteration.ToString();
            txtSoFarTheBest.Text = soFarTheBestObj.ToString();
            //畫圖
            points3D1.Clear();
            if (theProblem.Dimension == 2)
                for(int j = 0; j < numberOfParticles;j++)
                    points3D1.Add(particles[j][0], theProblem.GetObjectiveValue(particles[j]), particles[j][1]);
            Average.Add(iterationCount, averageObj);
            Iterationbest.Add(iterationCount, iterationBestObj);
            sofarthebest.Add(iterationCount, soFarTheBestObj);
        }

        private bool CheckLimits()
        {
            iterationLimit = Convert.ToInt16(numericUpDownIterationLimit.Value);
            noImprovementIterationLimit = Convert.ToInt16(numericUpDownNoImprovement.Value);
            evoCountLimit = Convert.ToInt16(numericUpDownEvalutionCount.Value);
            bool OK = true;
            if (checkBoxIterationLimit.Checked == true)
            {
                if (iterationCount > iterationLimit)
                    OK = false;
            }
            if (checkBoxNoImprovement.Checked == true)
            {
                if (noImprovementCount > noImprovementIterationLimit)
                    OK = false;
            }
            if (checkBoxEvalutionCounts.Checked == true)
            {
                if (evoCount > evoCountLimit)
                    OK = false;
            }
            return OK;
        }
   }
}
