using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class GaussianFuzzySet : FuzzySet //繼承Fuzzy Set
    {
        static int count = 0;
        public double Center
        {
            set  //set center
            {
                parameters[0] = value;
                updateFuzzySet();
            }
            get
            {
                return parameters[0];
            }
        }
        public double STD
        {
            set  //set STD
            {
                if (value >=0.0) //check
                    parameters[1] = value;
            }
            get
            {
                return parameters[1];
            }
        }
        public GaussianFuzzySet(Universe u) : base(u)//ctor+tab+tab自動準備constructor
                                                                                                            //base(u)透過子類別把副類別fuzzySet
        {
            parameters = new double[2];
            parameters[0] = 0.0; //center
            parameters[1] = 1.0; //std
            parNames = new string[2];
            parNames[0] = "Center";
            parNames[1] = "Standard Deviation";
            type = " Guassuan FS " + count.ToString();
            NameTitle();
            count++;
            updateDataPoints();
        }

        public override double GetMembershipDegree(double x)
        {
            return Math.Exp(-0.5*(x-parameters[0]) * (x-parameters[0]) / parameters[1] / parameters[1]);
        }

    }
}
