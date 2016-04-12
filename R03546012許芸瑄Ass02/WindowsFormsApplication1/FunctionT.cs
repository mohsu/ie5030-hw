using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class FunctionT
    {
        public double[] parameters;
        public string[] parNames;
        //constructor 建構函式初始化
        public FunctionT()
        {
            parameters = new double[3];
            parameters[0] = -5.0; //a
            parameters[1] = 0.0 ; //b
            parameters[2] = 5.0; //c

            parNames = new string[3];
            parNames[0] = "a=";
            parNames[1] = "b=";
            parNames[2] = "c=";
        }
        public double GetFuctionValue(double x)
        {
            double y = 0.0; //不能沒有初始化，因為會記憶上次的，很耗記憶體很危險
            if (x <= parameters[0])
                y = 0.0;
            else if (x <= parameters[1])
                y = (x - parameters[0]) / (parameters[1] - parameters[0]);
            else if (x <= parameters[2])
                y = (parameters[2] - x) / (parameters[2]- parameters[1]);
            else y = 0.0;
             return y;
        }
    }
}
