using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class FunctionSig
    {
        public double[] parameters;
        public string[] parNames;
        //constructor 建構函式初始化
        public FunctionSig()
        {
            parameters = new double[2];
            parameters[0] = 0.0; //c
            parameters[1] = 0.3; //a

            parNames = new string[2];
            parNames[0] = "c=";
            parNames[1] = "a=";
        }
        public double GetFuctionValue(double x)
        {
            double y = 0.0; //不能沒有初始化，因為會記憶上次的，很耗記憶體很危險
            y = 1.0 / (1.0 + Math.Exp(-parameters[1] * (x - parameters[0])));
            return y;
        }

    }
}
