using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class SigmoidalFuzzySet : FuzzySet
    {
        static int count = 0;
        public SigmoidalFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = 1.0; //  a
            parameters[1] = 0.0; // c
            parNames = new string[2];
            parNames[0] = "a";
            parNames[1] = "c";
            type =  " Sigmoidal FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            return 1 / (1 + Math.Exp(-parameters[0] * (x - parameters[1])));
        }

    }
}
