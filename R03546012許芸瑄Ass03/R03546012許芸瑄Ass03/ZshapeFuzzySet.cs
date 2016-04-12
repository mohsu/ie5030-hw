using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class ZshapeFuzzySet : FuzzySet
    {
        static int count = 0;
        public ZshapeFuzzySet(Universe u) : base(u)
        {
            parameters = new double[2];
            parameters[0] = -5.0; // l
            parameters[1] = 0.0; //r
            parNames = new string[2];
            parNames[0] = "l";
            parNames[1] = "r";
            type = " Z-shaped FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double y = 0.0;
            if (x <= parameters[0])
                y = 1.0;
            else if (x <= ((parameters[0] + parameters[1] )/ 2))
                y = 1-2*(x - parameters[0]) * (x - parameters[0]) / (parameters[1] - parameters[0]) / (parameters[1] - parameters[0]);
            else if (x <= parameters[1])
                y = 2 * (parameters[1] - x) * (parameters[1] - x) / (parameters[1] - parameters[0]) / (parameters[1] - parameters[0]);
            else
                y = 0;
            return y;
        }
    }
}
