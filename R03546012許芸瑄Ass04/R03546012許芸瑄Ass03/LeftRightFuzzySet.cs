using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class LeftRightFuzzySet  : FuzzySet //繼承
    {
        static int count = 0;
        public LeftRightFuzzySet(Universe u): base(u)
        {
            parameters = new double[3];
            parameters[0] = 0.0; //c
            parameters[1] = 1.0;//alpha
            parameters[2] = 1.0; //beta
            parNames = new string[3];
            parNames[0] = "c";
            parNames[1] = "alpha";
            parNames[2] = "beta";
            type =  " LeftRightFS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double y = 0;
            if (x <= parameters[0])
            {
                double z = (parameters[0] - x) / parameters[1]; //(c-x)/alpha
               y =  Math.Sqrt(Math.Max(0, (1 - z * z)));
            }
            else
            {
                double z = (x - parameters[0]) / parameters[2]; //(x-c)/beta
                y = Math.Exp(-Math.Abs(z * z * z));
            }
            return y;
        }
    }
}
