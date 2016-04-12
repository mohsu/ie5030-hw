using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03546012許芸瑄Ass03
{
    class BinaryOperator
    {
        public string type;
        public virtual double GetOperatorValue(double value1, double value2)
        {
            double newValue = 0.0;
            return newValue;
        }
    }
    class Intersect : BinaryOperator
    {
        public Intersect()
        {
            type = " /Intersect/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            if (value1 >= value2)
                return value2;
            else
                return value1;
        }
    }
    class AlegraicProduct : BinaryOperator
    {
        public AlegraicProduct()
        {
            type = " /AlgeraicProduct/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            return value1*value2;
        }
    }
    class BoundedProduct : BinaryOperator
    {
        public BoundedProduct()
        {
            type = " /BoundedProduct/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            return Math.Max(0, (value1 + value2 - 1));
        }
    }
    class DrasticProduct : BinaryOperator
    {
        public DrasticProduct()
        {
            type = " /DrasticProduct/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            if (value1 == 1)
                return value2;
            if (value2 == 2)
                return value1;
            else
                return 0.0;
        }
    }
    class Union : BinaryOperator
    {
        public Union()
        {
            type = " /Union/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            if (value1 >= value2)
                return value1;
            else
                return value2;
        }
    }
    class AlgebraicSum : BinaryOperator
    {
        public AlgebraicSum()
        {
            type = " /AlgebraicSum/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            return value1 + value2 - value1 * value2;
        }
    }
    class BoundedSum : BinaryOperator
    {
        public BoundedSum()
        {
            type = " /BoundedSum/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            return Math.Min(1, (value1 + value2));
        }
    }
    class DrasticSum : BinaryOperator
    {
        public DrasticSum()
        {
            type = " /DrasticSum/ ";
        }
        public override double GetOperatorValue(double value1, double value2)
        {
            if (value1 == 0)
                return value2;
            if (value2 == 0)
                return value1;
            else
                return 1.0;
        }
    }
    class SugenoTNorm : BinaryOperator
    {
        public SugenoTNorm()
        {
            type = " /SugenoTnorm/ ";
        }
    }
    class SugenoSNorm : BinaryOperator
    {
        public SugenoSNorm()
        {
            type = " /SugenoNorm/ ";
        }
    }
    class YagerTNom : BinaryOperator
    {
        public YagerTNom()
        {
            type = " /YagerTNorm/ ";
        }
    }
    class YagerSNorm : BinaryOperator
    {
        public YagerSNorm()
        {
            type = " /YagerSNorm/ ";
        }
    }
}
