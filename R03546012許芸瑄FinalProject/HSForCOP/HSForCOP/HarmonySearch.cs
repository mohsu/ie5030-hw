using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass10
{
    class HarmonySearch
    {
        Random rnd = new Random();
        public int numberOfHM;
        public int numberOfInstrument;
        public double[] evaluation;
        public double[][] HM;
        public int BestID;
        public int WorstID;

        public int NoImprovementCount = 0;

        public double HMCR;
        public double PAR;

        public HarmonySearch(int numberOfHMm, int numberOfInstrumentt)
        {
            numberOfHM = numberOfHMm;
            numberOfInstrument = numberOfInstrumentt;
            HM = new double[numberOfHM][];
            for(int i = 0; i < numberOfHM; i++)
                HM[i] = new double[numberOfInstrument];
            evaluation = new double[numberOfHM];
        }
        public void Sort()
        {
            //best
            double iterationBestObj = double.MaxValue;
            for (int i = 0; i < numberOfHM; i++)
            {
                if (evaluation[i] < iterationBestObj)
                {
                    iterationBestObj = evaluation[i];
                    BestID = i;
                }
            }
            //worst
            double iterationWorstObj = iterationBestObj;
            for (int i = 0; i < numberOfHM; i++)
            {
                if (evaluation[i] > iterationWorstObj)
                {
                    iterationWorstObj = evaluation[i];
                    WorstID = i;
                }
            }
        }
        public void UpdateHM(double[] newV, double newVEvaluation)
        {
            //如果有比較好就取代
            if (newVEvaluation < evaluation[WorstID])
            {
                evaluation[WorstID] = newVEvaluation;
                for (int j = 0; j < numberOfInstrument; j++)
                    HM[WorstID][j] = newV[j];
                NoImprovementCount = 0;
            }
            else
                NoImprovementCount++;
            Sort();
        }
        public void CountPenalty(double penalty)
        {
            for (int i = 0; i < numberOfHM; i++)
                for (int j = 0; j < numberOfInstrument-1; j++)
                    if (HM[i][j] == HM[i][j + 1])
                        evaluation[i] += penalty;
        }
    }
}
