using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R03546012許芸瑄Ass03
{
    delegate void UniverseParameterChangedFunction();
    class Universe
    {
        public event UniverseParameterChangedFunction ParameterChanged;
        void OnParamterChanged()
        {
            if (ParameterChanged != null)
            {
                ParameterChanged();
            }
        }
        public string title ;
        public double min ;
        public double max ; //o-o design does not use public 
        public double inc ; //increment
        public double Max
        {
            get { return max; }
            set { max = value; }
        }
        public ChartArea chartarea = new ChartArea();

        public void updateChartArea()
        {
            chartarea.AxisX.Minimum = min;
            chartarea.AxisX.Maximum = max;
            chartarea.AxisX.Title = title;
           // chartarea.AxisX.Enabled = true;
           // chartarea.AxisY.Enabled = true;
        }
        public Universe() { //在建構函式裡初始
            updateChartArea();
            title = "X";
            min = -10.0;
            max = 10.0;
            inc = 0.05;
           
        }
        public Universe(string UniverseTitle, double lowerValue, double upperValue, double increment) {
            title = UniverseTitle;
            min = lowerValue;
            max = upperValue;
            inc = increment;
            updateChartArea();
        }
    }
}
