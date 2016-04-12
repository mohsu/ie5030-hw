﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class BellFuzzySet : FuzzySet
    {
        static int count = 0;
        public BellFuzzySet(Universe u): base(u)
        {
            parameters = new double[3];
            parameters[0] = 3.0; //a
            parameters[1] = 2.0; //b
            parameters[2] = 1.0; //c
            parNames = new string[3];
            parNames[0] = "a";
            parNames[1] = "b";
            parNames[2] = "c";
            type =  " Bell FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            return 1/(1+(Math.Pow(Math.Abs((x-parameters[2])/parameters[0]),2*parameters[1]))); //1/(1+(|(x-c)/a|)^2b)
        }

    }
}
