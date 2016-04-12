using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GA
{
    class JobshopGA 
    {
        public enum Mode { Binary, Permutation };
        public enum SelectionMode { Stochastic, Deterministic };
        public enum BinaryCrossoverMode { OnePointCut, TwoPointCut };
        public enum PermutationCrossoverMode { PMX, ORDER };
        public enum PermutationMutationMode { INVERSE, INSERTION };

        protected int numberofJobs;
        protected double[,] setupTime;
        protected int[][] permutationChromesomes;
        protected byte[][] binaryChromesomes;
        protected double crossoverRate = 0.7;
        protected double mutationRate = 0.05;
        protected int iterationLimit = 10000;
        protected  int populationSize = 100;
        protected int crossSize; //memory used
        protected int mutationSize;
        protected double[] objectives;

        protected double penaltyFactor;
        protected double shortestTime;
        protected int[] violations_rows;
        protected int[] violations_cols;
        //for new generation assignment
        
        protected  int[] tempIDs; //排序用
        protected double[] tempObjs;
        protected byte[] binarySoFarBestSol;
        protected int[] permutationSoFarBestSol;
        protected double soFarBestObj; //迄今最佳解
        protected double iterationBestObj;
        protected int iteCount;
        public Series averageLine;
        public Series soFarTheBestLine;
        public Series iterationBestLine;

        //default mode
        public SelectionMode selectionType = SelectionMode.Deterministic; //by default
        public BinaryCrossoverMode binaryCrossoverType = BinaryCrossoverMode.OnePointCut;
        public PermutationCrossoverMode permutationCrossoverType = PermutationCrossoverMode.PMX;
        public PermutationMutationMode mutationType = PermutationMutationMode.INVERSE;
        public Mode modeType = Mode.Binary;

        //控制項
        public int[][] PermutationChromesomes
        {
            get { return permutationChromesomes; }
        }
        public byte[][] BinaryChromesomes
        {
            get { return binaryChromesomes; }
        }
        public byte[] BinarySoFarBestSol
        {
            get { return binarySoFarBestSol; }
        }
        public int[] PermutationSoFarBestSol
        {
            get { return permutationSoFarBestSol; }
        }
        public double CrossoverRate
        {
            get { return crossoverRate; }
            set { crossoverRate = value; }
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
        public double IterationBestObj 
        {
            get { return iterationBestObj; }
            set { iterationBestObj = value; }
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

        public double ShortestTime
        {
            get { return shortestTime; }
            set { shortestTime = value; }
        }
        public double PenaltyFactor
        {
            get { return penaltyFactor; }
            set { penaltyFactor = value; }
        }
        public int[] Violation_rows
        {
            get { return violations_rows; }
        }
        public int[] Violation_cols
        {
            get { return violations_cols; }
        }
        
        //methods
        public virtual void initializePopulation()
        {

        }

        public virtual void Reset()
        {
        }

        public virtual void runOneIteration()
        {
            crossoverOperation();
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
            iterationBestLine.Points.AddXY(iteCount, iterationBestObj);
        }

        public virtual void selectionOperation()
        {

        }

        public virtual void mutationOperation()
        {

        }

        public virtual void crossoverOperation()
        {
        }

        ///<summary>
        ///run to the end
        ///</summary>
        public virtual void runToEND()
        {
            while (iteCount < iterationLimit)
            {
                runOneIteration();
            }
        }
    }
}
