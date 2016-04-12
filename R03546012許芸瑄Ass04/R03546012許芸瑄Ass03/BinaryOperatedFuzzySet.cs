using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class BinaryOperatedFuzzySet : FuzzySet
    {
        BinaryOperator theBO;
        FuzzySet theFS1;
        FuzzySet theFS2;
        public BinaryOperatedFuzzySet(BinaryOperator bo, FuzzySet fs1, FuzzySet fs2) : base(fs1.universe) //繼承需要universe但這裡的universe是原本fuzzyset來的
        {
            theFS1 = fs1;
            theFS2 = fs2;
            theBO = bo;
            title = theFS1.title + theBO.type + theFS2.title;
            updateDataPoints();
        }
        public override double GetMembershipDegree(double x)
        {
            double Degree1;
            double Degree2;
            Degree1 = theFS1.GetMembershipDegree(x);
            Degree2 = theFS2.GetMembershipDegree(x);
            return theBO.GetOperatorValue(Degree1, Degree2);
        }
    }
}
