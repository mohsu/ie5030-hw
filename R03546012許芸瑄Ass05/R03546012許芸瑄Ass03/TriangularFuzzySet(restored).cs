﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass06
{
    class TriangularFuzzySet : FuzzySet //繼承
    {
        [Category("Parameter")]
        public double a
        {
            set { parameters[0] = value; updateDataPoints(); }
            get { return parameters[0]; }
        }
        [Category("Parameter")]
        public double b
        {
            set
            { parameters[1] = value; updateDataPoints(); }
            get { return parameters[1]; }
        }
        [Category("Parameter")]
        public double c
        {
            set { parameters[2] = value; updateDataPoints(); }
            get {return parameters[2];}
        }
        static int count = 0;
        public TriangularFuzzySet(Universe u) : base(u)
        {
            parameters = new double[3];
            parameters[0] = -5.0; // a
            parameters[1]  =0.0; //b
            parameters[2] = 5.0; //c
            parNames = new string[3];
            parNames[0] = "a";
            parNames[1] = "b";
            parNames[2] = "c";
            type =   " Triangular FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double y = 0.0;
            if (x <= parameters[0])
                y = 0.0;
            else if(x <= parameters[1])
                y = (x - parameters[0]) /  (parameters[1]  - parameters[0]);
            else  if (x <= parameters[2])
                y = (parameters[2] - x) / (parameters[2] - parameters[1]);
            else
                y = 0.0;
            return y;
        }

    }
}
