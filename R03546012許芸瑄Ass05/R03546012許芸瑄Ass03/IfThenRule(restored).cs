using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass06
{
    class IfThenRule
    {
        public List<FuzzySet> inputFuzzySets = new List<FuzzySet>();
        public FuzzySet outputFuzzySet;
        public IfThenRule (List<FuzzySet> inputFS, FuzzySet outputFS)
	{
            if(inputFS ==null || inputFS.Count==0)
                throw new Exception("xxx");
            inputFuzzySets = inputFS;
            outputFuzzySet = outputFS;
	}
    //    delegate void 
        //public double MaximumDegree()
        //{
 
        //}
        public FuzzySet MamdaniInference(List<FuzzySet> condition)
        {
            FuzzySet result = null;
            double fireStrength = 1.0;
            for (int i = 0; i < inputFuzzySets.Count; i++)
            {
                double temp = ((inputFuzzySets[i]) & (condition[i])).getMaxDegree(); //交集取最大值
                if (temp < fireStrength) //取最小值
                    fireStrength = temp;
                result = new UnaryOperatedFuzzySet(new ValueCut(fireStrength), outputFuzzySet); //cut value
            }
            return result;
        }
        public double SugenoInference(double[] x, double[] z)
        {
            double wa = 0.0;

            return wa;
        }
         public override string ToString()
        {
            string s = "If ";
            for (int i = 0; i < inputFuzzySets.Count; i++)
            {
                s += " " + inputFuzzySets[i].universe.title + " is " + inputFuzzySets[i].title;
                if(i >= 1)
                    s += " and ";
            }
             s += " then " + outputFuzzySet.universe.title + outputFuzzySet.title;
            return s;
        }
    }
}
