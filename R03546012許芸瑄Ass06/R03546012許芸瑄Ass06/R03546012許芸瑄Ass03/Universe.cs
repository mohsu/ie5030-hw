using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R03546012許芸瑄Ass06
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
        [Category("\tTitle"), ]
        public string Title
        {
            get { return title; }
            set { title = value; updateChartArea(); }
        }
        [Category("Bound")]
        public double Max
        {
            get { return max; }
            set { max = value; updateChartArea();}
        }
        [Category("Bound")]
        public double Min
        {
            get { return min; }
            set { if (max > value) { min = value; updateChartArea(); } }
        }
        [Category("Increment")]
        public double Resolution
        {
            get { return inc; }
            set { if (value > 0) { inc = value; updateChartArea(); } }
        }
        public ChartArea chartarea = new ChartArea();

        public void updateChartArea()
        {
            chartarea.AxisX.Minimum = min;
            chartarea.AxisX.Maximum = max;
            chartarea.AxisX.Title = title;
           // chartarea.AxisX.Enabled = true;
           // chartarea.AxisY.Enabled = true;
            OnParamterChanged();
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
            chartarea = new ChartArea();
            updateChartArea();
        }
    }
}
