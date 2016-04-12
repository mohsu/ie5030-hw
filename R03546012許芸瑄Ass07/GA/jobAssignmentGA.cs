using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GA
{
    class jobAssignmentGA
    {
        public enum SelectionMode { Stochastic, Deterministic };
        public enum BinaryCrossOverMode { OnePointCut, TwoPointCut };
        //stochastic
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        //problem
        int numberofJobs;
        double[,] setupTime;

        public SelectionMode selectionType = SelectionMode.Deterministic; //by default
        public BinaryCrossOverMode crossOverType = BinaryCrossOverMode.OnePointCut;
        
         //GA
        double crossoverRate = 0.7;
        double mutationRate = 0.05;
        int iterationLimit = 10000;
        int populationSize = 100;
        int crossSize; //memory used
        int mutationSize;
        byte[][] chromesomes;  //chromesomes[0~population]裝原本的 [population~2*population]裝crossover[2*~3*]裝mutation
        double[] objectives;
        //for new generation assignment
        byte[][] tempChromosomes;
        int[] tempIDs; //排序用
        double[] tempObjs;
        double soFarBestObj; //迄今最佳解
        byte[] soFarBestSolution;
        double penaltyFactor;
        double shortestTime;
        int[] violations_rows;
        int[] violations_cols;
        public Series averageLine;
        public Series soFarTheBestLine;
        //控制項
        public double CrossoverRate
        {
            get { return crossoverRate;}
            set { crossoverRate = value; }
        }
        public byte[][] Chromesomes
        {
            get { return chromesomes; }
            //set { chromesomes = value; }
        }
        public int NumberOfJobs
        {
            get { return numberofJobs; }
            set { numberofJobs = value; }
        }
        public int PopulationSize
        {
            get { return populationSize; }
            set { populationSize = value; }
        }
        public double PenaltyFactor
        {
            get { return penaltyFactor; }
            set { penaltyFactor = value; }
        }
        public double[] Objectives
        {
            get { return objectives; }
            set { objectives = value; }
        }
        public double[,] SetupTime
        {
            get { return setupTime; }
            set { setupTime = value; }
        }
        public double SoFarTheBestObj
        {
            get { return soFarBestObj; }
            set { soFarBestObj = value; }
        }
        public double ShortestTime
        {
            get { return shortestTime; }
            set { shortestTime = value; }
        }
        public byte[] SoFarTheBestSol
        {
            get { return soFarBestSolution; }
            set { soFarBestSolution = value; }
        }
        public int[] Violation_rows
        {
            get { return violations_rows; }
        }
        public int[] Violation_cols
        {
            get { return violations_cols; }
        }
        public double MutationRate
        {
            get { return mutationRate; }
            set { mutationRate = value; }
        }
        public int CrossSize
        {
            get { return crossSize; }
            set { crossSize = value; }
        }
        public int MutationSize
        {
            get { return mutationSize; }
            set { mutationSize = value; }
        }
        public int IteCount
        {
            get { return iteCount; }
        }
        public int IterationLimilt
        {
            get { return iterationLimit; }
            set { iterationLimit = value; }
        }
        //mode selection
        private void ModeselectionOperation()
        {
            switch (selectionType)
            {
                case SelectionMode.Deterministic:
                    break;
                case SelectionMode.Stochastic:
                    break;
            }
        }
        private void SelectionBinaryMode()
        {
            switch (crossOverType)
            {
                case BinaryCrossOverMode.OnePointCut:
                    break;
                case BinaryCrossOverMode.TwoPointCut:
                    break;
            }
        }

        //Find the so-far-the-best solution and value
        
        //evoulution
        int iteCount;

        double computeObjValue(byte[] x)
        {
            double objective = 0;
            for (int c = 1; c < numberofJobs + 1; c++)
                violations_cols[c - 1] = -1;
            for (int r = 0; r < numberofJobs; r++)
            {
                violations_rows[r] = -1;
                for (int c = 1; c < numberofJobs + 1; c++)
                {
                    objective += x[(c-1)+r*numberofJobs] * setupTime[r, c];
                    if (x[(c - 1) + r * numberofJobs] == 1) //penalty count
                    {
                        violations_rows[r]++;
                        violations_cols[c-1]++;
                    }
                }
                objective += Math.Abs(violations_rows[r]) * penaltyFactor;
            }
            for (int c = 1; c < numberofJobs + 1; c++)
                objective += Math.Abs(violations_cols[c - 1]) * penaltyFactor;
             return objective;
        }
        void initializePopulation() //private
        {
            for (int r = 0; r < populationSize; r++)
            {
                for (int c = 0; c < numberofJobs*numberofJobs; c++)
                {
                    chromesomes[r][c] = (rand.Next() % 2 == 0 ? (byte)1 : (byte)0);
                }
                objectives[r] = computeObjValue(chromesomes[r]);
            }
            for (int i = 0; i < populationSize; i++)
            {
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //sort ids and tempObjs
            Array.Sort(tempObjs, tempIDs, 0, populationSize); //sort 0~(populationsize-1)
            //set soFarBestSolution and soFarBestObj
            soFarBestObj = objectives[tempIDs[0]];
            for (int c = 0; c < numberofJobs*numberofJobs; c++)
                soFarBestSolution[c] = chromesomes[tempIDs[0]][c];
            countViolationAndShortestTime();
        }
        public void countViolationAndShortestTime()
        {
            shortestTime = 0;
            for (int c = 0; c < numberofJobs; c++)
                violations_cols[c] = -1;
            for (int r = 0; r < numberofJobs; r++)
            {
                violations_rows[r] = -1;
                for (int c = 1; c < numberofJobs + 1; c++)
                {
                    shortestTime += soFarBestSolution[r * numberofJobs + (c - 1)] * setupTime[r, c];
                    if (soFarBestSolution[r * numberofJobs + (c - 1)] == 1)
                    {
                        violations_rows[r]++;
                        violations_cols[c - 1]++;
                    }
                }
                violations_rows[r] = Math.Abs(violations_rows[r]);
            }
            for (int c = 0; c < numberofJobs; c++)
                violations_cols[c] = Math.Abs(violations_cols[c]);   
        }
        public void runOneInteration()
        { 
            crossOperation();
            mutationOperation();
            selectionOperation();
            iteCount++;
            //畫圖
            double average = 0;
            for (int i = 0; i < populationSize; i++)
                average += objectives[i];
            for (int i = populationSize; i < populationSize + crossSize; i++)
                average += objectives[i];
            for (int i = populationSize * 2; i < populationSize * 2 + mutationSize; i++)
                average += objectives[i];
            average = average / (populationSize + crossSize + mutationSize);
            averageLine.Points.AddXY(iteCount, average);
            soFarTheBestLine.Points.AddXY(iteCount, SoFarTheBestObj);
        }

        private void selectionOperation() //三種最好的結果存回chromesome[i][]
        {
            Array.Sort(tempObjs, tempIDs, 0, populationSize*3); //sort 0~(populationsize+crossover + mutation)
            for (int r = 0; r < populationSize; r++) //裝進temp
            {
                for (int c = 0; c < numberofJobs*numberofJobs; c++)
                    tempChromosomes[r][c] = chromesomes[tempIDs[r]][c];
            }
            for (int r = 0; r < populationSize; r++) //裝回chromesome
            {
                objectives[r] = tempObjs[r];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    chromesomes[r][c] = tempChromosomes[r][c];
            }
             //裝入so far the best 系列
            soFarBestObj = tempObjs[0];
            for(int c = 0; c < numberofJobs*numberofJobs; c++)
                soFarBestSolution[c] = tempChromosomes[0][c];
            countViolationAndShortestTime();
            //shuffle
            shuffleIntegerArray(tempIDs,populationSize);
            for (int r = 0; r < populationSize; r++)
            {
                tempObjs[r] = objectives[tempIDs[r]];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    tempChromosomes[r][c] = chromesomes[tempIDs[r]][c];
            }
            for (int r = 0; r < populationSize; r++)
            {
                objectives[r] = tempObjs[r];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    chromesomes[r][c] = tempChromosomes[r][c];
            }
        }

        private void crossOperation() //利用chromesome[population+i][]存放交換後的chromesome~~
        {
            crossSize = Convert.ToInt32(crossoverRate * populationSize);
            int cut1 = 0;
            int cut2 = 0;
            if (crossOverType == BinaryCrossOverMode.OnePointCut)
            {
                cut1 = rand.Next(numberofJobs * numberofJobs);
                cut2 = numberofJobs * numberofJobs;
            }
            if (crossOverType == BinaryCrossOverMode.TwoPointCut)
            {
                cut1 = rand.Next(numberofJobs * numberofJobs);
                cut2 = cut1 + rand.Next(numberofJobs * numberofJobs - cut1+1);
            }
            for(int i = 0; i<crossSize+1; i+=2) //若是奇數也算的到
            {
                for (int r = 0; r < cut1; r++)
                {
                    chromesomes[populationSize + i][r] = chromesomes[i][r];
                    chromesomes[populationSize + (i+1)][r] = chromesomes[i+1][r];
                }
                for (int r = cut1; r < cut2; r++)
                {
                    chromesomes[populationSize + i][r] = chromesomes[i + 1][r];
                    chromesomes[populationSize + (i + 1)][r] = chromesomes[i][r];
                }
                objectives[populationSize + i] = computeObjValue(chromesomes[populationSize + i]);
                objectives[populationSize + (i + 1)] = computeObjValue(chromesomes[populationSize + (i + 1)]);
            }
            for (int i = populationSize; i < populationSize+crossSize; i++)
            {
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //沒有裝滿的
            for (int i = populationSize + crossSize; i < populationSize * 2; i++)
            {
                tempIDs[i] = i;
                tempObjs[i] = 1000000;
            }
            //sort ids and tempObjs
            //Array.Sort(tempObjs, tempIDs, 0, populationSize+crossSize); //sort 0~(populationsize+crossSize-1)
        }

        private void mutationOperation() //利用chromesome[population*2+i][]存放mutation結果
        {
            int mutationGeneSize = Convert.ToInt32(mutationRate * populationSize * numberofJobs*numberofJobs);
            int[] random = new int[mutationGeneSize];
            for (int i = 0; i < mutationGeneSize; i++)
                random[i] = rand.Next(populationSize * numberofJobs * numberofJobs);
            Array.Sort(random);
             //mutation
            int row = -1;
            for (int i = 0; i < mutationGeneSize; i++)
            {
                if (random[i] / numberofJobs / numberofJobs != row)
                    row++;
                int col = random[i] / populationSize;
                //裝進去
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    chromesomes[populationSize * 2 + row][c] = chromesomes[row][c];
                //mutation
                if (chromesomes[row][col] == 0) //若是0就換1
                    chromesomes[populationSize * 2 + row][col] = 1;
                else //若是1就換成0
                    chromesomes[populationSize * 2 + row][col] = 0;
            }
            mutationSize = row; //共有幾行
            for (int i = populationSize * 2; i < populationSize * 2 + mutationSize; i++)
            {
                objectives[i] = computeObjValue(chromesomes[i]);
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //沒裝滿的
                for (int i = populationSize * 2 + mutationSize; i < populationSize * 3; i++)
                {
                    tempIDs[i] = i;
                    tempObjs[i] = 1000000000;
                }
        }
        //helping method
        private void shuffleIntegerArray(int[] ary, int length)
        {
            //assign sequencing number to ary
            for (int i = 0; i < length; i++)
                ary[i] = i;
            //shuffle the values
            while (length > 1)
            {
                length--;
                int rr = rand.Next(length + 1);
                int temp = ary[rr];
                ary[rr] = ary[length];
                ary[length] = temp;
            }
        }
        ///<summary>
        ///run to the end
        ///</summary>
       public void runToEND()
       {
           while (iteCount < iterationLimit)
           {
               runOneInteration();
           }
       }
       public void Reset()
       {
           iteCount = 0;
           shortestTime = 0;
           int temp = populationSize * 4;
           //allocate memory
           chromesomes= new byte[populationSize * 4][];
           for (int i = 0; i < chromesomes.GetLength(0); i++)
               chromesomes[i] = new byte[numberofJobs*numberofJobs];
           objectives = new double[temp];
           tempIDs = new int[temp];
           tempObjs= new double[temp];
           soFarBestSolution = new byte[numberofJobs*numberofJobs];
           violations_rows = new int[numberofJobs];
           violations_cols = new int[numberofJobs];
           tempChromosomes = new byte[populationSize][];
           for (int i = 0; i < populationSize; i++ )
               tempChromosomes[i]  = new byte[numberofJobs*numberofJobs];
           //line
           averageLine = new Series();
           averageLine.ChartType = SeriesChartType.Line;
           averageLine.Name = "Average";
           averageLine.BorderWidth = 3;
           soFarTheBestLine = new Series();
           soFarTheBestLine.ChartType = SeriesChartType.Line;
           soFarTheBestLine.Name = "So far the Best";
           soFarTheBestLine.BorderWidth = 3;
           //do
           initializePopulation();
       }
       public void readInputFile(string path)
       {
           //problems
           //set int numberOfJobs
           //set double[,] setupTimes
       }
    }
}
