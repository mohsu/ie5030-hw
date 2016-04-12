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
    public partial class HSForTSP : Form
    {
        HarmonySearch HSforTSP;
        int numberOfCities;
        int[][] realRoute;
        int[] soFarTheBestRoute = null;
        double soFarTheBestObj;
        Random rnd = new Random();

        int numberOfHM =10;
        //UI related
        double HMCR;
        double PAR;

        int NoImprovementCount;
        int NoImprovenmentLimit;
        int iterationCount = 0;
        int iterationLimit;

        Series averageLine;
        Series soFarTheBestLine;

        public HSForTSP()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnRunOneIteration.Enabled = false;
            btnRunToEnd.Enabled = false;
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            TSPBenchmarkProblem.ImportATSPFile(true, true); //from reference imported
            soFarTheBestRoute = new int[TSPBenchmarkProblem.numberOfObjects];
            splitContainer2.Panel1.Invalidate();//or refresh
            numberOfCities = TSPBenchmarkProblem.numberOfObjects;
            if (TSPBenchmarkProblem.minimalDistance == 0)
                txtKnownOptimalObj.Text = "n/a";
            else
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
            if (CheckLimits()==true)
            {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
            }
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            while (CheckLimits()==true)
            {
                    RunOneIteration();
                    iterationCount++;
                    txtIterationID.Text = iterationCount.ToString();
            }
            
            //UI
            txtSoFarTheBest.Text = HSforTSP.evaluation[HSforTSP.BestID].ToString();
            splitContainer2.Panel1.Refresh();
        }

        void ResetACO()
        {
            //clear
            iterationCount = 0;
            NoImprovementCount = 0;
            chartObj.Series.Clear();

            //get UI
            numberOfHM = Convert.ToInt16(txtNumberOfAnts.Text);
            HMCR = Convert.ToDouble(txtHMCR.Text);
            PAR = Convert.ToDouble(txtPAR.Text);

            //setUI
            txtSoFarTheBest.Text = "";
            txtIterationID.Text = "0";
            txtNumberOfIterationWithoutImprovement.Text = "0";
            progressBar1.Value = 0;

            //allocate HM
            HSforTSP = new HarmonySearch(numberOfHM, numberOfCities);
            HSforTSP.iterationWithoutImprovementCount = 0;
            for (int i = 0; i < numberOfHM; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                    HSforTSP.HM[i][j] = rnd.NextDouble(); //random 0~1
            }
            //temp = 排序用
            double[][] temp = new double[numberOfHM][];
            for(int i =0; i < numberOfHM; i++)
            {
                temp[i] = new double[numberOfCities];
                for (int j = 0; j < numberOfCities; j++)
                    temp[i][j] = HSforTSP.HM[i][j];
             }
            //initialize realRoute
            realRoute = new int[numberOfHM][];
            for (int i = 0; i < numberOfHM; i++)
            {
                realRoute[i] = new int[numberOfCities];
                for (int j = 0; j < numberOfCities; j++)
                    realRoute[i][j] = j;
            }
            //convert to real route and calculate evaluation in this step
            for (int i = 0; i < numberOfHM; i++)
            {
                Array.Sort(temp[i], realRoute[i]);
                HSforTSP.evaluation[i] = TSPBenchmarkProblem.ComputeObjectiveValue(realRoute[i]);
            }
            HSforTSP.CountPenalty(500);

            //so far the best route
            HSforTSP.Sort();
            soFarTheBestObj = HSforTSP.evaluation[HSforTSP.BestID];
            soFarTheBestRoute = new int[TSPBenchmarkProblem.numberOfObjects];
            for (int j = 0; j < TSPBenchmarkProblem.numberOfObjects; j++)
                soFarTheBestRoute[j] = realRoute[HSforTSP.BestID][j];

            //chart setting
            averageLine = new Series();
            averageLine.ChartType = SeriesChartType.Line;
            averageLine.Name = "Average";
            soFarTheBestLine = new Series();
            soFarTheBestLine.ChartType = SeriesChartType.Line;
            soFarTheBestLine.Name = "So Far the Best";
            soFarTheBestLine.BorderWidth = 3;
            chartObj.Series.Add(averageLine);
            chartObj.Series.Add(soFarTheBestLine);

            //protection
            btnRunOneIteration.Enabled = true;
            btnRunToEnd.Enabled = true;
        }

        private void RunOneIteration()
        {
            //Step2 : improvise new vector
            double[] newV = new double[numberOfCities];
            for (int j = 0; j < numberOfCities; j++)
            {
                if (rnd.NextDouble() < HMCR) //有0.99的機會從中選一個
                {
                    int selectedHM = rnd.Next(numberOfHM); //0~20
                    if (rnd.NextDouble() < (1 - PAR)) //有0.95的機率選一個
                        newV[j] = HSforTSP.HM[selectedHM][j];
                    else //有0.05的機率往上/往下
                    {
                        if (rnd.NextDouble() < 0.5) //有一半機率往上
                            newV[j] = HSforTSP.HM[selectedHM][j] + 1.0 / numberOfCities;
                        else //一半機率往下
                            newV[j] = HSforTSP.HM[selectedHM][j] - 1.0 / numberOfCities;
                    }
                }
                else
                    newV[j] = rnd.NextDouble();
            }
            //calculate the evaluation of newVector
            double[] temp = new double[numberOfCities]; //排序用
            int[] realRouteOfNewV = new int[numberOfCities];
            for (int j = 0; j < numberOfCities; j++)
            {
                temp[j] = newV[j];
                realRouteOfNewV[j] = j;
            }
            Array.Sort(temp, realRouteOfNewV);
            double evaluationOfNewV = TSPBenchmarkProblem.ComputeObjectiveValue(realRouteOfNewV);
            //Step 3: update HM
            HSforTSP.UpdateHM(newV, evaluationOfNewV);
            HSforTSP.CountPenalty(500);

            //average
            double iterationAverageObj = 0;
            for (int i = 0; i < numberOfHM; i++)
                iterationAverageObj += HSforTSP.evaluation[i];
            iterationAverageObj /= numberOfHM;

            //update so far the best
            for (int j = 0; j < numberOfCities; j++)
            {
                temp[j] = HSforTSP.HM[HSforTSP.BestID][j];
                soFarTheBestRoute[j] = j;
            }
            Array.Sort(temp, soFarTheBestRoute);
            soFarTheBestObj = HSforTSP.evaluation[HSforTSP.BestID];

            //UI
            progressBar1.Value = iterationCount;
            NoImprovementCount = HSforTSP.iterationWithoutImprovementCount;
            txtNumberOfIterationWithoutImprovement.Text = NoImprovementCount.ToString();
            txtIterationID.Text = iterationCount.ToString();
            txtNumberOfIterationWithoutImprovement.Text = HSforTSP.iterationWithoutImprovementCount.ToString();
            txtSoFarTheBest.Text = soFarTheBestObj.ToString();
            
            //畫線
            averageLine.Points.AddXY(iterationCount, iterationAverageObj);
            soFarTheBestLine.Points.AddXY(iterationCount, HSforTSP.evaluation[HSforTSP.BestID]);
            if (checkBoxShowAnimation.Checked == true)
            {
                if(iterationCount%100 == 0)
                    splitContainer2.Panel1.Refresh();
                txtNumberOfIterationWithoutImprovement.Refresh();
                txtIterationID.Refresh();
                txtSoFarTheBest.Refresh();
                chartObj.Update();
            }
        }
        private bool CheckLimits()
        {
            iterationLimit = Convert.ToInt32(txtIterationLimit.Text);
             NoImprovenmentLimit = Convert.ToInt32(txtObjLimit.Text);
            bool OK = true;
            if ( checkboxIterationLimit.Checked == true)
            {
                if (iterationCount >= iterationLimit)
                    OK = false;
                progressBar1.Maximum = iterationLimit;
            }
           if (checkboxObjLimit.Checked == true)
            {
                if (NoImprovementCount > NoImprovenmentLimit)
                    OK = false;
            }
            return OK;
        }
    }
}
