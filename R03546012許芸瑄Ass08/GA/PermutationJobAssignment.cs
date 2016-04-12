using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GA
{
    class PermutationJobAssignment : JobshopGA
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());

        //Permutation GA
        protected int[][] tempChromosomes;

        //methods
        public override void initializePopulation()
        {
            for (int r = 0; r < populationSize; r++)
            {
                for (int c = 1; c < numberofJobs+1; c++)
                {
                    permutationChromesomes[r][c] = c;
                }
                shuffleIntegerArray(permutationChromesomes[r], numberofJobs + 1, 1);
                objectives[r] = computeObjValue(permutationChromesomes[r]);
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
            for (int c = 1; c < numberofJobs+1; c++)
                permutationSoFarBestSol[c] = permutationChromesomes[tempIDs[0]][c];
        }
        public override void Reset()
        {
            iteCount = 0;
            int temp = populationSize * 4;
            //allocate memory
            permutationChromesomes = new int[populationSize * 4][];
            for (int i = 0; i < permutationChromesomes.GetLength(0); i++)
                permutationChromesomes[i] = new int[numberofJobs+1];
            objectives = new double[temp];
            tempIDs = new int[temp];
            tempObjs = new double[temp];
            permutationSoFarBestSol = new int[numberofJobs+1];
            tempChromosomes = new int[populationSize][];
            for (int i = 0; i < populationSize; i++)
                tempChromosomes[i] = new int[numberofJobs+1];
            //line
            averageLine = new Series();
            averageLine.ChartType = SeriesChartType.Line;
            averageLine.Name = "Average";
            averageLine.BorderWidth = 1;
            iterationBestLine = new Series();
            iterationBestLine.ChartType = SeriesChartType.Line;
            iterationBestLine.Name = "Iteration Best";
            iterationBestLine.BorderWidth = 3;
            soFarTheBestLine = new Series();
            soFarTheBestLine.ChartType = SeriesChartType.Line;
            soFarTheBestLine.Name = "So far the Best";
            soFarTheBestLine.BorderWidth = 3;
            //do
            initializePopulation();
        }
        double computeObjValue(int[] x)
        {
            double objective = 0;
            for (int r = 0; r < numberofJobs; r++)
            {
                int c = x[r+1]; //c=1~numberofJobs+1
                objective += x[r] * setupTime[r, c];
            }
            return Math.Round(objective,3);
        }
        public override void crossoverOperation()
        {
            int cut1 = rand.Next(numberofJobs)+1;
            int cut2 = cut1 + rand.Next(numberofJobs  - cut1+1);
            crossSize = Convert.ToInt32( populationSize * crossoverRate);
            //PMX mode
            if (permutationCrossoverType == PermutationCrossoverMode.PMX)
            {
                for (int i = 0; i < crossSize + 1; i += 2) //若是奇數也算的到
                {
                    for (int r = 1; r < cut1; r++) //裝進去
                    {
                        permutationChromesomes[populationSize + i][r] = permutationChromesomes[i][r];
                        permutationChromesomes[populationSize + (i + 1)][r] = permutationChromesomes[i + 1][r];
                    }
                    for (int r = cut1; r < cut2; r++) //換
                    {
                        permutationChromesomes[populationSize + i][r] = permutationChromesomes[i + 1][r];
                        permutationChromesomes[populationSize + (i + 1)][r] = permutationChromesomes[i][r];
                    }
                    for (int r = cut2; r < numberofJobs + 1; r++)//裝進去
                    {
                        permutationChromesomes[populationSize + i][r] = permutationChromesomes[i][r];
                        permutationChromesomes[populationSize + (i + 1)][r] = permutationChromesomes[(i + 1)][r];
                    }
                    ///////( i )檢查重複的///////
                    for (int r = cut1; r < cut2; r++)
                    {
                        int out_index = 1;
                        while (out_index < numberofJobs + 1)
                        {
                            if (out_index == cut1)
                                out_index = cut2;
                            else if (permutationChromesomes[populationSize + i][r] != permutationChromesomes[populationSize + i][out_index])
                                out_index++; //檢查跟(0~cut-1)沒有一樣->檢查下一個
                            else //發現一樣
                            {
                                int temp = permutationChromesomes[populationSize + (i + 1)][r];
                                int j = cut1;
                                int count = 0;
                                while (j < cut2 && count < (cut2-cut1))//直到找不到一樣為止
                                {
                                    if (permutationChromesomes[populationSize + i][j] == temp) //對到一樣的就換
                                    {
                                        temp = permutationChromesomes[populationSize + (i + 1)][j]; //對的那個
                                        j = cut1; //有換的話就重新對
                                        count++; //最多換(cut2-cut1)次
                                    }
                                    else
                                        j++;
                                }
                                permutationChromesomes[populationSize + i][out_index] = temp;
                            }
                        }
                    }
                    ///////(i+1)檢查重複的//////
                    for (int r = cut1; r < cut2; r++)
                    {
                        int out_index = 1;
                        while (out_index < numberofJobs + 1)
                        {
                            if (out_index == cut1)
                                out_index = cut2;
                            else if (permutationChromesomes[populationSize + (i + 1)][r] != permutationChromesomes[populationSize + (i + 1)][out_index])
                                out_index++; //檢查跟(0~cut-1)沒有一樣->檢查下一個
                            else //發現一樣
                            {
                                int temp = permutationChromesomes[populationSize + (i)][r];
                                int j = cut1;
                                int count = 0;
                                while (j < cut2&&count <(cut2-cut1))//直到找不到一樣為止
                                {
                                    if (permutationChromesomes[populationSize + (i + 1)][j] == temp) //對到一樣的就換
                                    {
                                        temp = permutationChromesomes[populationSize + (i)][j]; //對的那個
                                        j = cut1; //有換的話就重新對
                                        count++;
                                    }
                                    else
                                        j++;
                                }
                                permutationChromesomes[populationSize + (i + 1)][out_index] = temp;
                            }
                        }
                    }
                }
            }
            //order-mode
            if (permutationCrossoverType == PermutationCrossoverMode.ORDER)
            {
                //裝進去(多裝一個)
                for (int r = 0; r < crossSize +1; r++ )
                    for (int c = 1; c < numberofJobs + 1; c++)
                    {
                        permutationChromesomes[populationSize + r][c] = permutationChromesomes[r][c];
                        tempChromosomes[r][c] = permutationChromesomes[r][c];
                    }
                //crossover
                //i//
                for (int r = populationSize; r < populationSize+ crossSize; r+=2) 
                {
                    int c2 = 1;
                    int out_index = 1;
                    while(c2 < numberofJobs+1 && out_index < numberofJobs+1)
                    {
                        if (out_index == cut1)
                            out_index = cut2;
                        int c1 = cut1;
                        while (c1 < cut2 && c2 < numberofJobs + 1) //找c2 index
                        {
                            if (permutationChromesomes[r][c1] == permutationChromesomes[r+1][c2])
                            {
                                c2++;
                                c1 = cut1;
                            }
                            c1++;
                        }
                        if (c2 == numberofJobs + 1)
                            break;
                        //取代
                        permutationChromesomes[r][out_index] = permutationChromesomes[r + 1][c2];
                        //下一個
                        c2++;
                        out_index++;
                    }
                }
                //i+1//偶數
                for (int r = populationSize+1; r < populationSize + crossSize; r += 2)
                {
                    int c2 = 1;
                    int out_index = 1;
                    while (c2 < numberofJobs + 1 && out_index < numberofJobs + 1)
                    {
                        if (out_index == cut1)
                            out_index = cut2;
                        int c1 = cut1;
                        while (c1 < cut2 && c2 < numberofJobs + 1) //找c2 index
                        {
                            if (tempChromosomes[r-1-populationSize][c1] == permutationChromesomes[r][c2])
                            {
                                c2++;
                                c1 = cut1;
                            }
                            c1++;
                        }
                        if (c2 == numberofJobs + 1)
                            break;
                        //取代
                        permutationChromesomes[r][out_index] = tempChromosomes[r-1-populationSize][c2];
                        //下一個
                        c2++;
                        out_index++;
                    }
                }
            }
            for (int i = 0; i < crossSize; i++)
            {
                //算objective
                objectives[populationSize + i] = computeObjValue(permutationChromesomes[populationSize + i]);
            }
            for (int i = populationSize; i < populationSize + crossSize; i++)
            {
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //沒裝到的
            for (int r = populationSize + crossSize; r < populationSize * 2; r++)
            {
                tempIDs[r] = r;
                tempObjs[r] = 100000000;
            }
        }
        public override void mutationOperation()
        {
            mutationSize = Convert.ToInt32(populationSize * mutationRate);
            //裝進去
            for (int r = 0; r < mutationSize; r++)
                for (int c = 1; c < numberofJobs + 1; c++)
                    permutationChromesomes[populationSize * 2 + r][c] = permutationChromesomes[r][c];
            if (mutationType == PermutationMutationMode.INVERSE)
            {
                int cut1 = rand.Next(numberofJobs) + 1;
                int cut2 = cut1 + rand.Next(numberofJobs - cut1 + 1);
                int[] temp1 = new int[cut2 - cut1];
                for (int r = populationSize * 2; r < populationSize * 2 + mutationSize; r++)
                {
                    for (int c = cut1; c < cut2; c++) //裝進去
                        temp1[c - cut1] = permutationChromesomes[r][c]; //temp[0] = chromosomes[r][cut1]
                    Array.Reverse(temp1);//倒過來
                    for (int c = cut1; c < cut2; c++) //裝回去
                        permutationChromesomes[r][c] = temp1[c - cut1];
                } 
            }                                   
            //insertion mode
            if (mutationType == PermutationMutationMode.INSERTION)
            {
                int index = rand.Next(numberofJobs ) + 1; //1~5
                int cut = rand.Next(numberofJobs) + 1; //1~5
                for (int r = populationSize * 2; r < populationSize * 2 + mutationSize; r++)
                {
                    int temp = permutationChromesomes[r][index];
                    for (int c = index; c < numberofJobs ; c++)//抽掉 index之後往前一位
                        permutationChromesomes[r][c] = permutationChromesomes[r][c + 1];
                    for (int c = numberofJobs; c > cut; c--) //cut之後往後一位
                        permutationChromesomes[r][c] = permutationChromesomes[r][c-1];
                    permutationChromesomes[r][cut] = temp; //temp插進去
                }
            }
            //算objective
            for (int i = populationSize * 2; i < populationSize * 2 + mutationSize; i++)
            {
                objectives[i] = computeObjValue(permutationChromesomes[i]);
                tempIDs[i] = i;
                tempObjs[i] = objectives[i];
            }
            //沒裝到的
            for (int r = populationSize *2 +mutationSize; r < populationSize * 3; r++)
            {
                tempIDs[r] = r;
                tempObjs[r] = 100000000;
            }
        }
        public override void selectionOperation()
        {
            //if (selectionType == SelectionMode.Deterministic)
            //{
                Array.Sort(tempObjs, tempIDs, 0, populationSize * 3); //sort 0~(populationsize+crossover + mutation)
                for (int r = 0; r < populationSize; r++) //前10名裝進temp
                {
                    for (int c = 1; c < numberofJobs + 1; c++)
                        tempChromosomes[r][c] = permutationChromesomes[tempIDs[r]][c];
                }
                for (int r = 0; r < populationSize; r++) //temp裝回chromesome
                {
                    objectives[r] = tempObjs[r];
                    for (int c = 1; c < numberofJobs + 1; c++)
                        permutationChromesomes[r][c] = tempChromosomes[r][c];
                }
                //裝入so far the best 系列
                iterationBestObj = tempObjs[0];
                if (iteCount == 1) //第一次就直接裝進去
                    soFarBestObj = tempObjs[0];
                else if (iterationBestObj <= soFarBestObj)
                {
                    soFarBestObj = iterationBestObj;
                    for (int c = 1; c < numberofJobs + 1; c++)
                        permutationSoFarBestSol[c] = tempChromosomes[0][c];
                }
                //shuffle
                //shuffleIntegerArray(tempIDs,populationSize,0);
                for (int r = 0; r < populationSize; r++)
                {
                    tempObjs[r] = objectives[tempIDs[r]];
                    for (int c = 1; c < numberofJobs + 1; c++)
                        tempChromosomes[r][c] = permutationChromesomes[tempIDs[r]][c];
                }
                for (int r = 0; r < populationSize; r++)
                {
                    objectives[r] = tempObjs[r];
                    for (int c = 1; c < numberofJobs + 1; c++)
                        permutationChromesomes[r][c] = tempChromosomes[r][c];
                }
           // }
            //else //stochastic
            //{
            //    int total = populationSize + crossSize + mutationSize;
            //    for (int r = 0; r < mutationSize; r++)
            //    {
            //        objectives[populationSize+crossSize+r] = objectives[populationSize*2+r];
            //        for (int c = 1; c < numberofJobs; c++)
            //            permutationChromesomes[populationSize + crossSize + r][c] = permutationChromesomes[populationSize * 2 + r][c]; //裝過去...
            //    }
            //    //double[] q = new double[total];
            //    double sum =0;
            //    double[] p = new double[total];
            //    for (int r = 0; r < total;r++ )
            //        sum += objectives[r];
            //    for (int r = 0; r < total; r++)
            //        p[r] = sum-objectives[r];
            //    sum = 0;
            //    for (int r = 0; r < total; r++ )
            //        sum += p[r];
            //    for (int r = 1; r < total; r++) //累積
            //        p[r] += p[r - 1];
            //    //隨機選出populationSize個放進temp
            //    int[][] temp = new int[populationSize][];
            //    for (int i = 0; i < populationSize; i++)
            //        temp[i] = new int[numberofJobs + 1];
            //    for (int r = 0; r < populationSize; r++)
            //    {
            //        double u  = rand.NextDouble()*sum; 
            //        int k =0;
            //        while(u > p[k]) k++;
            //        tempObjs[r] = objectives[k];
            //        for (int c = 1; c < numberofJobs + 1;c++ )
            //            temp[r][c] = permutationChromesomes[k][c];
            //    }
            //    //裝進去
            //    for (int r = 0; r < populationSize; r++)
            //    {
            //        objectives[r] = tempObjs[r];
            //        for (int c = 1; c < numberofJobs + 1; c++)
            //            permutationChromesomes[r][c] = temp[r][c];
            //    }
            //    //再Sort一次裝入soFartheBest
            //    iterationBestObj = 100000000;
            //    int best_index = 0 ;
            //    for (int r = 0; r < total; r++)
            //    {
            //        if (objectives[r] < iterationBestObj)
            //        {
            //            iterationBestObj = objectives[r];
            //            best_index = r;
            //        }
            //    }
            //    if (iteCount == 1)
            //        soFarBestObj = iterationBestObj;
            //    else if (iterationBestObj <= soFarBestObj)
            //    {
            //        for (int c = 1; c < numberofJobs + 1; c++)
            //            permutationSoFarBestSol[c] = permutationChromesomes[best_index][c];
            //    }
            //}
        }
        private void shuffleIntegerArray(int[] crms, int length,int start)
        {
            //shuffle the values
            for (int i = start; i < length; i++)
            {
                int RndIndex = rand.Next(length);
                if (RndIndex != start-1)
                {
                    int temp = crms[i];
                    crms[i] = crms[RndIndex];
                    crms[RndIndex] = temp;
                }
            }
        }
    }
}
