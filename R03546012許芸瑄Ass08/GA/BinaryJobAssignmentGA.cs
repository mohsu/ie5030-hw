using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GA
{
    class BinaryJobAssignment : JobshopGA
    {
        //stochastic
        Random rand = new Random(Guid.NewGuid().GetHashCode());

        //binary GA
        protected byte[][] tempChromosomes;
        
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
            switch (binaryCrossoverType)
            {
                case BinaryCrossoverMode.OnePointCut:
                    break;
                case BinaryCrossoverMode.TwoPointCut:
                    break;
            }
        }

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

        public override void initializePopulation() //private
        {
            for (int r = 0; r < populationSize; r++)
            {
                for (int c = 0; c < numberofJobs*numberofJobs; c++)
                {
                    binaryChromesomes[r][c] = (rand.Next() % 2 == 0 ? (byte)1 : (byte)0);
                }
                objectives[r] = computeObjValue(binaryChromesomes[r]);
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
                binarySoFarBestSol[c] = binaryChromesomes[tempIDs[0]][c];
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
                    shortestTime += binarySoFarBestSol[r * numberofJobs + (c - 1)] * setupTime[r, c];
                    if (binarySoFarBestSol[r * numberofJobs + (c - 1)] == 1)
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

        public override void selectionOperation() //三種最好的結果存回chromesome[i][]
        {
            Array.Sort(tempObjs, tempIDs, 0, populationSize*3); //sort 0~(populationsize+crossover + mutation)
            for (int r = 0; r < populationSize; r++) //裝進temp
            {
                for (int c = 0; c < numberofJobs*numberofJobs; c++)
                    tempChromosomes[r][c] = binaryChromesomes[tempIDs[r]][c];
            }
            for (int r = 0; r < populationSize; r++) //裝回chromesome
            {
                objectives[r] = tempObjs[r];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    binaryChromesomes[r][c] = tempChromosomes[r][c];
            }
            iterationBestObj = tempObjs[0];
             //裝入so far the best 系列
            if(iteCount==1)
                soFarBestObj = tempObjs[0];
            else if (iterationBestObj <= soFarBestObj)
            {
                soFarBestObj = iterationBestObj;
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    binarySoFarBestSol[c] = tempChromosomes[0][c];
            }
            countViolationAndShortestTime();
            //shuffle
            shuffleIntegerArray(tempIDs,populationSize);
            for (int r = 0; r < populationSize; r++)
            {
                tempObjs[r] = objectives[tempIDs[r]];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    tempChromosomes[r][c] = binaryChromesomes[tempIDs[r]][c];
            }
            for (int r = 0; r < populationSize; r++)
            {
                objectives[r] = tempObjs[r];
                for (int c = 0; c < numberofJobs * numberofJobs; c++)
                    binaryChromesomes[r][c] = tempChromosomes[r][c];
            }
        }

        public override void crossoverOperation() //利用chromesome[population+i][]存放交換後的chromesome~~
        {
            crossSize = Convert.ToInt32(crossoverRate * populationSize);
            int cut1 = 0;
            int cut2 = 0;
            if (binaryCrossoverType == BinaryCrossoverMode.OnePointCut)
            {
                cut1 = rand.Next(numberofJobs * numberofJobs);
                cut2 = numberofJobs * numberofJobs;
            }
            if (binaryCrossoverType == BinaryCrossoverMode.TwoPointCut)
            {
                cut1 = rand.Next(numberofJobs * numberofJobs);
                cut2 = cut1 + rand.Next(numberofJobs * numberofJobs - cut1+1);
            }
            for(int i = 0; i<crossSize+1; i+=2) //若是奇數也算的到
            {
                for (int r = 0; r < cut1; r++) //裝進去
                {
                    binaryChromesomes[populationSize + i][r] = binaryChromesomes[i][r];
                    binaryChromesomes[populationSize + (i + 1)][r] = binaryChromesomes[i + 1][r];
                }
                for (int r = cut1; r < cut2; r++) //換的
                {
                    binaryChromesomes[populationSize + i][r] = binaryChromesomes[i + 1][r];
                    binaryChromesomes[populationSize + (i + 1)][r] = binaryChromesomes[i][r];
                }
                for (int r = cut2; r < numberofJobs * numberofJobs; r++)//裝進去
                {
                    binaryChromesomes[populationSize + i][r] = binaryChromesomes[i][r];
                    binaryChromesomes[populationSize + (i + 1)][r] = binaryChromesomes[i+1][r];
                }
                objectives[populationSize + i] = computeObjValue(binaryChromesomes[populationSize + i]);
                objectives[populationSize + (i + 1)] = computeObjValue(binaryChromesomes[populationSize + (i + 1)]);
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
                tempObjs[i] = 10000000;
            }
        }

        public override void mutationOperation() //利用chromesome[population*2+i][]存放mutation結果
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
                    binaryChromesomes[populationSize * 2 + row][c] = binaryChromesomes[row][c];
                //mutation
                if (binaryChromesomes[row][col] == 0) //若是0就換1
                    binaryChromesomes[populationSize * 2 + row][col] = 1;
                else //若是1就換成0
                    binaryChromesomes[populationSize * 2 + row][col] = 0;
            }
            mutationSize = row; //共有幾行
            for (int i = populationSize * 2; i < populationSize * 2 + mutationSize; i++)
            {
                objectives[i] = computeObjValue(binaryChromesomes[i]);
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //沒裝滿的
                for (int i = populationSize * 2 + mutationSize; i < populationSize * 3; i++)
                {
                    tempIDs[i] = i;
                    tempObjs[i] = 10000000;
                }
        }

        public override void Reset()
        {
            iteCount = 0;
            shortestTime = 0;
            int temp = populationSize * 4;
            //allocate memory
            binaryChromesomes = new byte[populationSize * 4][];
            for (int i = 0; i < binaryChromesomes.GetLength(0); i++)
                binaryChromesomes[i] = new byte[numberofJobs * numberofJobs];
            objectives = new double[temp];
            tempIDs = new int[temp];
            tempObjs = new double[temp];
            binarySoFarBestSol = new byte[numberofJobs * numberofJobs];
            violations_rows = new int[numberofJobs];
            violations_cols = new int[numberofJobs];
            tempChromosomes = new byte[populationSize][];
            for (int i = 0; i < populationSize; i++)
                tempChromosomes[i] = new byte[numberofJobs * numberofJobs];
            //line
            averageLine = new Series();
            averageLine.ChartType = SeriesChartType.Line;
            averageLine.Name = "Average";
            averageLine.BorderWidth = 1;
            iterationBestLine = new Series();
            iterationBestLine.ChartType = SeriesChartType.Line;
            iterationBestLine.Name = "Iteration Best";
            iterationBestLine.BorderWidth = 1;
            soFarTheBestLine = new Series();
            soFarTheBestLine.ChartType = SeriesChartType.Line;
            soFarTheBestLine.Name = "So far the Best";
            soFarTheBestLine.BorderWidth = 3;
            //do
            initializePopulation();
        }

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

       public void readInputFile(string path)
       {
           //problems
           //set int numberOfJobs
           //set double[,] setupTimes
       }
    }
}
