using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TSPBenchmark;

namespace R03546012許芸瑄Ass09
{
    public partial class ASForTSP : Form
    {
        //暫放
        int[] soFarTheBestRoute = null;
        double soFarTheBestObj;
        double iterationBestObj;
        Random rnd = new Random();
        int[][] ants;
        double[] objectives;
        double[,] pheromones;
        int numberOfAnts =10;
        //UI related
        double initialValueOfPheromome = 0.05;
        double alpha;
        double beta;
        int[] candidates;
        int candidateNumber;
        double[] probability;
        double droppingAmount;
        double evaporateRate;
        int funtionCallCount;

        int iterationCount = 0;
        int iterationLimit;
        int iterationWithoutImprovement;
        int iterationWithoutImprovementCount;
        int soFarTheBestInterationID;

        Series averageLine;
        Series iterationBestLine;
        Series soFarTheBestLine;

        public ASForTSP()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunToEnd.Enabled = false;
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            TSPBenchmarkProblem.ImportATSPFile(true, true); //from reference imported
            splitContainer2.Panel1.Invalidate();//or refresh
            //reset pheromone map allocate memory
            pheromones = new double[TSPBenchmarkProblem.numberOfObjects, TSPBenchmarkProblem.numberOfObjects]; //numberOfObjects = cities
            probability = new double[TSPBenchmarkProblem.numberOfObjects];
            candidates = new int[TSPBenchmarkProblem.numberOfObjects];
            txtKnownOptimalObj.Text = TSPBenchmarkProblem.minimalDistance.ToString();
            labBestRoute.Text = "Best Route ( Number of cities: " + TSPBenchmarkProblem.numberOfObjects + " )";
            btnReset.Enabled = true;
        }
        
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e) //事件
        {
            TSPBenchmarkProblem.DrawCitiesOptimalRouteAndARoute(e.Graphics, e.ClipRectangle.Width, e.ClipRectangle.Height, soFarTheBestRoute); //都藏在e裡
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetACO();
            btnRunOneIteration.Enabled = true;
            btnRunToEnd.Enabled = true;
        }

        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            iterationLimit = Convert.ToInt16(txtIterationLimit.Text);
            iterationWithoutImprovement = Convert.ToInt16(txtIterationWithoutImprovement.Text);
            if (checkboxIterationLimit.Checked == true && checkboxIterationWithoutImprove.Checked == true)
            {
                if (iterationCount < iterationLimit && iterationWithoutImprovementCount < iterationWithoutImprovement)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            }
            else if (checkboxIterationLimit.Checked == true)
            {
                if (iterationCount < iterationLimit)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            }
            else if (checkboxIterationWithoutImprove.Checked == true)
            {
                if (iterationWithoutImprovementCount < iterationWithoutImprovement)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            }
            else
            {
                RunOneIteration();
                iterationCount++;
                txtIterationID.Text = iterationCount.ToString();
            }

            txtAtIteration.Text = soFarTheBestInterationID.ToString();
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            iterationLimit = Convert.ToInt16(txtIterationLimit.Text);
            iterationWithoutImprovement = Convert.ToInt16(txtIterationWithoutImprovement.Text);
            if (checkboxIterationLimit.Checked == true && checkboxIterationWithoutImprove.Checked == false)
            {
                while (iterationCount < iterationLimit)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            }
            else if (checkboxIterationWithoutImprove.Checked == true && checkboxIterationLimit.Checked == false)
                while (iterationWithoutImprovementCount < iterationWithoutImprovement)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            else if (checkboxIterationLimit.Checked == true && checkboxIterationWithoutImprove.Checked == true)
                while (iterationCount < iterationLimit && iterationWithoutImprovementCount < iterationWithoutImprovement)
                {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
                }
            else
                while (true)
                { RunOneIteration(); iterationCount++; txtIterationID.Text = iterationCount.ToString(); }
            
            //UI
            txtSoFarTheBest.Text = soFarTheBestObj.ToString();
        }

        void ResetACO()
        {
            //clear
            iterationCount = 0;
            iterationWithoutImprovementCount = 0;
            funtionCallCount = 0;
            chartObj.Series.Clear();

            //get UI
            numberOfAnts = Convert.ToInt16(txtNumberOfAnts.Text);
            alpha = Convert.ToDouble(txtPheromoneFacter.Text);
            beta = Convert.ToDouble(txtHeuristicFactor.Text);
            initialValueOfPheromome = Convert.ToDouble(txtInitialPheromoneValue.Text);
            evaporateRate = Convert.ToDouble(txtEvaporationRate.Text);
            droppingAmount = Convert.ToDouble(txtDroppingAmount.Text);

            //setUI
            txtSoFarTheBest.Text = "";
            txtIterationID.Text = "0";
            txtNumberOfFunctionCalls.Text = "0";
            txtAtIteration.Text = "0";
            txtNumberOfFunctionCalls.Text = "0";

            //initailize pheromone map
            for (int i = 0; i < pheromones.GetLength(0); i++)
                for (int j = 0; j < pheromones.GetLength(1); j++)
                    pheromones[i, j] = initialValueOfPheromome;

            //allocate ants
            ants = new int[numberOfAnts][];
            objectives = new double[numberOfAnts];
            for (int i = 0; i < numberOfAnts; i++)
            {
                ants[i] = new int[TSPBenchmarkProblem.numberOfObjects];
                for (int j = 0; j < TSPBenchmarkProblem.numberOfObjects; j++)
                    ants[i][j] = j;
                shuffleRoute(ants[i]);
                objectives[i] = TSPBenchmarkProblem.ComputeObjectiveValue(ants[i]);
            }

            //so far the best route
            iterationBestObj = 100000000;
            int bestID = 0;
            for (int i = 0; i < numberOfAnts; i++)
            {
                if (objectives[i] < iterationBestObj)
                {
                    objectives[i] = iterationBestObj;
                    bestID = i;
                }
            }
            soFarTheBestObj = iterationBestObj;
            soFarTheBestRoute = new int[TSPBenchmarkProblem.numberOfObjects];
            for (int j = 0; j < TSPBenchmarkProblem.numberOfObjects; j++)
                soFarTheBestRoute[j] = ants[bestID][j];
            //txtSoFarTheBest.Text = soFarTheBestObj.ToString();

            //chart setting
            averageLine = new Series();
            averageLine.ChartType = SeriesChartType.Line;
            averageLine.Name = "Average";
            iterationBestLine = new Series();
            iterationBestLine.ChartType = SeriesChartType.Line;
            iterationBestLine.Name = "Iteration Best";
            soFarTheBestLine = new Series();
            soFarTheBestLine.ChartType = SeriesChartType.Line;
            soFarTheBestLine.Name = "So Far the Best";
            soFarTheBestLine.BorderWidth = 3;
            chartObj.Series.Add(averageLine);
            chartObj.Series.Add(iterationBestLine);
            chartObj.Series.Add(soFarTheBestLine);

            //protection
            btnRunOneIteration.Enabled = true;
            btnRunToEnd.Enabled = true;
        }

        void shuffleRoute(int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                int pos = rnd.Next(p.Length);
                int temp = p[i];
                p[i] = p[pos];
                p[pos] = temp;
            }
        }

        private void RunOneIteration()
        {
           
            iterationBestObj = 1000000000;
            double iterationAverageObj = 0.0;
            int iterationBestAnt = 0;
            // all ants create their solution
            for (int k = 0; k < numberOfAnts; k++)
            {
                // initialize candidate set
                for (int j = 0; j < candidates.Length; j++)
                    candidates[j] = j;
                candidateNumber = TSPBenchmarkProblem.numberOfObjects;
                // First city is randomly selected
                ants[k][0] = rnd.Next(TSPBenchmarkProblem.numberOfObjects);
                int istar = ants[k][0];
                int istarID = 0;
                // remove istar from candidates and pack candidates 
                    //find istar ID
                for (int i = 0; i < candidateNumber; i++)
                    if (istar == candidates[i])
                        istarID = i;
                   //istar ID 後的全部往前移
                for (int i = istarID; i < candidateNumber - 1; i++)
                    candidates[i] = candidates[i + 1];
                candidateNumber--;
                //往下走
                int jstar = istar;
                for (int j = 1; j < TSPBenchmarkProblem.numberOfObjects; j++)
                {
                    for (int i = 0; i < candidateNumber; i++)
                    {
                        probability[i] = Math.Pow(pheromones[jstar, candidates[i]], alpha) *
                            Math.Pow(1.0 / TSPBenchmarkProblem.fromToMatrix[jstar, candidates[i]], beta);
                    }
                    // get next jstar
                    int candidateID = 0;
                    if (radiobtnDeterministic.Checked == true)
                        candidateID =  DeterministicSelect(probability, candidateNumber);
                    else if(radiobtnStochastic.Checked == true)
                        candidateID = StochasticSelect(probability, candidateNumber);
                    jstar = candidates[candidateID];
                    ants[k][j] = jstar;
                   int jstarID = 0;
                    // remove jstar from candidates and pack candidates 
                        //find jstar ID
                    for (int i = 0; i < candidateNumber; i++)
                        if (jstar == candidates[i])
                            jstarID = i;
                        //jstar ID 後的全部往前移
                    for (int i = jstarID; i < candidateNumber-1; i++)
                        candidates[i] = candidates[i + 1];
                    candidateNumber--;
                }

                // evaluate objectives
                objectives[k] = TSPBenchmarkProblem.ComputeObjectiveValue(ants[k]);
                iterationAverageObj += objectives[k];

                // update iteration best
                if (objectives[k] < iterationBestObj)
                {
                    iterationBestObj = objectives[k];
                    iterationBestAnt = k;
                }

                // update pheromone map
                for (int j = 0; j < TSPBenchmarkProblem.numberOfObjects - 1; j++)
                {
                    int r = ants[k][j];
                    int c = ants[k][j + 1];
                    pheromones[r, c] += droppingAmount / objectives[k];
                }
                for (int r = 0; r < TSPBenchmarkProblem.numberOfObjects; r++)
                    for (int c = 0; c < TSPBenchmarkProblem.numberOfObjects; c++)
                        pheromones[r, c] *= evaporateRate;
                funtionCallCount++;
                txtNumberOfFunctionCalls.Text = funtionCallCount.ToString();
            }

            //update so far the best
            if (iterationBestObj < soFarTheBestObj)
            {
                soFarTheBestObj = iterationBestObj;
                for (int j = 0; j < TSPBenchmarkProblem.numberOfObjects; j++)
                    soFarTheBestRoute[j] = ants[iterationBestAnt][j];
                soFarTheBestInterationID = iterationCount;
                txtSoFarTheBest.Text = soFarTheBestObj.ToString();

                //畫圖
                splitContainer2.Panel1.Refresh();
            }
            else
                iterationWithoutImprovementCount++;

            //畫線
            iterationAverageObj /= numberOfAnts;
            averageLine.Points.AddXY(iterationCount, iterationAverageObj);
            iterationBestLine.Points.AddXY(iterationCount, iterationBestObj);
            soFarTheBestLine.Points.AddXY(iterationCount, soFarTheBestObj);

        }
        int DeterministicSelect(double[] p, int number)
        {
            double largest = p[0];
            int hit= 0;
            for (int i = 0; i < number; i++)
                if (p[i] > largest)
                    hit = i;
            return hit;
        }
        int StochasticSelect(double[] p, int number)
        {
            double sum = 0.0;
            double[] cum =new  double[number];
            cum[0] = p[0];
            sum = p[0];
            for (int i = 1; i < number; i++)
            {
                sum +=p[i];
                cum[i] = cum[i - 1] + p[i];
            } 
           double hit = rnd.NextDouble() * sum;
           for (int i = 0; i < number; i++)
               if (cum[i] >= hit) return i;
           return number - 1;
        }

    }
}
