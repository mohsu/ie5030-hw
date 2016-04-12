using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R03546012許芸瑄Ass06
{
     class UnaryOperatedFuzzySet  : FuzzySet
    {
        UnaryOperator theUO;
        FuzzySet theFS;
        public UnaryOperatedFuzzySet(UnaryOperator uo, FuzzySet fs) : base(fs.universe) //繼承需要universe但這裡的universe是原本fuzzyset來的
        {
            theFS = fs;
            theUO = uo;
            title = uo.type + fs.title;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double targetDegree;
            targetDegree = theFS.GetMembershipDegree(x);
            return theUO.GetOperatorValue(targetDegree);
        }
    }
}
