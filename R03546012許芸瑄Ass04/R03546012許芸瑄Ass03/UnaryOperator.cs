using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class UnaryOperator
    {
        public string type;
        public virtual double GetOperatorValue(double value)
        {
            double newValue = 0.0;
            return newValue;
        }
    }
    // varoius unary operators....
    class Not: UnaryOperator
    {
        public Not ()
	    {
            type = "Not/";
	    }
        public override double GetOperatorValue(double value)
        {
            return 1.0 - value;
        }
    }
    class ValueScale : UnaryOperator
    {
        
        double Scale = 0.7;
        public ValueScale(double scale)
        {
            Scale = scale;
            type = "Value Scale(" + Scale.ToString() + ")/";
        }
        public ValueScale()
        {
            type = "Value Scale(" + Scale.ToString() + ")/";
        }
        public override double GetOperatorValue(double value)
        {
               value *= Scale;
               return value;
        }
    }
    class ValueCut : UnaryOperator
    {
        double Cutvalue = 0.7;
        public ValueCut()
        {
            type = "Value cut(" + Cutvalue.ToString() + ")/";
        }
        public ValueCut(double cutValue)
        {
            type = "Value cut(" + cutValue.ToString() + ")/";
        }
        public override double GetOperatorValue(double value)
        {
            return value > Cutvalue ? Cutvalue : value;
        }
    }
    class Very : UnaryOperator
    {
            public Very()
            {
                type = "Very/";
            }
            public override double GetOperatorValue(double value)
            {
                return value * value;
            }
       }
    class VeryVery : UnaryOperator
        {
            public VeryVery()
            {
                type = "VeryVery/";
            }
            public override double GetOperatorValue(double value)
            {
                return value * value * value;
            }
        }
    class Extremely : UnaryOperator
     {
            public Extremely()
            {
                type = "Extremely/";
            }
            public override double GetOperatorValue(double value)
            {
                return Math.Pow(value, 8);
            }
        }
    class MoreOrLess : UnaryOperator
        {
            public MoreOrLess()
            {
                type = "MoreOrLess/";
            }
            public override double GetOperatorValue(double value)
            {
                return Math.Sqrt(value);
            }
        }
    class Intensify : UnaryOperator
        {
            public Intensify()
            {
                type = "Intensify/";
            }
            public override double GetOperatorValue(double value)
            {
                if (value <= 0.5)
                    return 2 * value * value;
                else
                    return 1 - 2 * value * value;
            }
        }
    class Diminisher : UnaryOperator
     {
            public Diminisher()
            {
                type = "Diminisher/";
            }
            public override double GetOperatorValue(double value)
            {
                if (value <= 0.5)
                    return Math.Sqrt(value / 2);
                else
                    return Math.Sqrt((value - 1) / 2);
            }
        }
        class SugenoNot : UnaryOperator
        {
            double s = 0.7;
            public SugenoNot()
            {
                type = "SugeonoNot/";
            }
            public SugenoNot(double s)
            {
                type = "SugeonoNot/";
                if(this.s > -1)
                    s = this.s;
            }
            public override double GetOperatorValue(double value)
            {
                    return 1 - (1 - value) / (1 + s * value); //1-(1-a)/(1-s*a)
            }
        }
        class YagerNot : UnaryOperator
        {
            double w = 0.7;
            public YagerNot(double w)
            {
                type = "YagerNot/";
                if(w > 0)
                    w = this.w;
            }
            public override double GetOperatorValue(double value)
            {
                return 1 - Math.Pow((1 - Math.Pow(value, w)), (1 - w));  //1-(1-a^w)^(1/w)
            }
        }
}
