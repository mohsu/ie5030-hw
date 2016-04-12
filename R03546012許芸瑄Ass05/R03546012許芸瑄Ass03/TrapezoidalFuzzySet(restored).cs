using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass06
{
    class TrapezoidalFuzzySet : FuzzySet //繼承
    {
        [Category("Parameter")]
        public double a
        {
            set { parameters[0] = value; updateDataPoints(); }
            get {  return parameters[0];}
        }
        [Category("Parameter")]
        public double b
        {
            set { parameters[1] = value; updateDataPoints(); }
            get {return parameters[1];}
        }
        [Category("Parameter")]
        public double c
        {
            set { parameters[2] = value; updateDataPoints(); }
            get {return parameters[2];}
        }
        [Category("Parameter")]
        public double d
        {
            set { parameters[3] = value; updateDataPoints(); }
            get {return parameters[3];}
        }
        static int count = 0;
        public TrapezoidalFuzzySet(Universe u)  : base(u)
        {
            parameters = new double[4];
            parameters[0] = -2.0; //a
            parameters[1] = -1.0; //b
            parameters[2] = 0.0; //c
            parameters[3] = 1.0; //d
            parNames = new string[4];
            parNames[0] = "a";
            parNames[1] = "b";
            parNames[2] = "c";
            parNames[3] = "d";
            type =  " Trapezoidal FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double y = 0.0;
            if (x <= parameters[0])
                y = 0.0;
            else  if (x <= parameters[1])
                y = (x - parameters[0]) / (parameters[1] - parameters[0]);
            else if (x <= parameters[2])
                y = 1.0;
            else if (x <= parameters[3])
                y = (parameters[3] - x) / (parameters[3] - parameters[2]);
            else
                y = 0.0;
            return y;
        }

    }
}
