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
    public partial class COP : Form
    {
        HarmonySearch HSForCOP;
        COPBenchmarkProblem theProblem = null;
        double[] soFarTheBestSol; //所有particle最好的點(x,z) GBEST
        double soFarTheBestObj;
        int numberOfHM = 20;
        int numberOfInstrument;
        double HMCR=0.99; 
        double PAR=0.05;
        
        Random rnd = new Random();

        //counts
        int iterationCount;
        int noImprovementCount;
        
        //limits
        int iterationLimit = 10000;
        int noImprovementLimit = 1000;

        public COP()
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
            if(theProblem.OptimalSolutionsKnown == true)
                txtKnownBestObj.Text = theProblem.BestObjectiveValue.ToString();
            else
                txtKnownBestObj.Text = "n/a";
            btnReset.Enabled = true;
        }

        void Initialization()
        {
            //歸零
            points3D1.Clear();
            iterationCount = 0;
            noImprovementCount = 0;
            soFarTheBestObj = double.MaxValue;
            progressBar1.Value = 0;
            if(theProblem.OptimalSolutionsKnown == true)
                tChart2.Axes[1].Minimum = theProblem.BestObjectiveValue;
            tChart2.Series[0].XValues.Clear();
            tChart2.Series[0].YValues.Clear();
            tChart2.Series[1].XValues.Clear();
            tChart2.Series[1].YValues.Clear();

            if(checkBoxNumberOfHM.Checked==true)
                numberOfHM = Convert.ToInt16(numericUpDownNumberOfHM.Value);

            numberOfInstrument = theProblem.Dimension;
            HSForCOP = new HarmonySearch(numberOfHM, numberOfInstrument);
            HSForCOP.NoImprovementCount = 0;

            soFarTheBestSol = new double[theProblem.Dimension];

            for (int j = 0; j < numberOfHM; j++)
            {
                for (int i = 0; i < theProblem.Dimension; i++) //HM
                {
                    HSForCOP.HM[j][i] = theProblem.LowerBound[i] + rnd.NextDouble() *
                        (theProblem.UpperBound[i] - theProblem.LowerBound[i]);
                }
                HSForCOP.evaluation[j] = theProblem.GetObjectiveValue(HSForCOP.HM[j]);
                HSForCOP.Sort();
                if( theProblem.Dimension == 2 )
                {
                    points3D1.Add( HSForCOP.HM[j][0], theProblem.GetObjectiveValue( HSForCOP.HM[j] ) , HSForCOP.HM[j][1] );
                 }
            }
            //裝入soFartheBest
            for (int i = 0; i < numberOfInstrument; i++)
                soFarTheBestSol[i] = HSForCOP.HM[HSForCOP.BestID][i];
            soFarTheBestObj = HSForCOP.evaluation[HSForCOP.BestID];
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
            HMCR = Convert.ToDouble(numericUpDownHMCR.Value);
            PAR = Convert.ToDouble(numericUpDownPAR.Value);
            //Step2: new vector
            double[] NewV = new double[numberOfInstrument];
            double evalutionOfNewV = 0;
            for (int j = 0; j < numberOfInstrument; j++)
            {
                if (rnd.NextDouble() < HMCR) //有0.99的機會從中選一個
                {
                    int selectedHM = rnd.Next(numberOfHM); //0~20
                    if (rnd.NextDouble() < (1 - PAR))//有0.95的機率選一個
                        NewV[j] = HSForCOP.HM[selectedHM][j];
                    else//有0.05的機率往上/往下
                    {
                        if (rnd.NextDouble() < 0.5)//有一半機率往下
                        {
                            if (selectedHM == 0)
                                selectedHM = numberOfHM - 1;
                            else
                                selectedHM--;
                        }
                        else//有一半機率往上
                        {
                            if (selectedHM == numberOfHM - 1)
                                selectedHM = 0;
                            else
                                selectedHM++;
                        }
                        NewV[j] = HSForCOP.HM[selectedHM][j];
                    }
                }
                else //0.01的機會從可行解範圍random one
                    NewV[j] = theProblem.LowerBound[j] + rnd.NextDouble() * (theProblem.UpperBound[j] - theProblem.LowerBound[j]);
            }
            evalutionOfNewV = theProblem.GetObjectiveValue(NewV);
            //Step 3: update
            HSForCOP.UpdateHM(NewV, evalutionOfNewV);

            //average
            double averageObj = 0;
            for (int j = 0; j < numberOfHM; j++)
                averageObj += HSForCOP.evaluation[j];
            averageObj = averageObj / numberOfHM;
            //update so far the best
            soFarTheBestObj = HSForCOP.evaluation[HSForCOP.BestID];
            soFarTheBestSol = HSForCOP.HM[HSForCOP.BestID];

            noImprovementCount = HSForCOP.NoImprovementCount;
            //to UI
            txtIterationID.Text = iterationCount.ToString();
            txtNumberOfIterationWithoutImprovement.Text = noImprovementCount.ToString();
            txtSoFarTheBest.Text = soFarTheBestObj.ToString();
            progressBar1.Value = iterationCount;
            //畫圖
            points3D1.Clear();
            if (theProblem.Dimension == 2)
                for(int j = 0; j < numberOfHM;j++)
                    points3D1.Add(HSForCOP.HM[j][0], theProblem.GetObjectiveValue(HSForCOP.HM[j]), HSForCOP.HM[j][1]);
            Average.Add(iterationCount, averageObj);
            sofarthebest.Add(iterationCount, soFarTheBestObj);
            
            if (checkBoxShowAnimation.Checked == true)
            {
                txtIterationID.Refresh();
                txtNumberOfIterationWithoutImprovement.Refresh();
                txtSoFarTheBest.Refresh();
                tChart1.Refresh();
                tChart2.Refresh();
            }
        }

        private bool CheckLimits()
        {
            iterationLimit = Convert.ToInt32(numericUpDownIterationLimit.Value);
            noImprovementLimit = Convert.ToInt32(numericUpDownIterationWithoutImprovement.Value);
            bool OK = true;
            if (checkBoxIterationLimit.Checked == true)
            {
                if (iterationCount > iterationLimit)
                    OK = false;
                progressBar1.Maximum = iterationLimit;
            }
            if (checkBoxIterationWithoutImprovement.Checked == true)
            {
                if (noImprovementCount > noImprovementLimit)
                    OK = false;
            }
            return OK;
        }
   }
}
