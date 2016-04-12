using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R03546012許芸瑄Ass03
{
    class FuzzySet //continuous
    {
        protected double[] parameters;
         //property
        public double[] Parameters //控制項
        {
            get //像函式
            {
                return parameters;
            }
            set 
            {
                parameters = value; //value是一個KEY word
            }
        }
        public string[] parNames;
        public Universe universe;
        public string fname;
        public string type;
        public string title;
        public Series line;


        public FuzzySet(Universe theUniverse)
        {
            universe = theUniverse;
            fname = "Group 1";
            type = "Triangular FS";
            NameTitle();
            line = new Series();
            line.ChartArea = theUniverse.chartarea.Name;
            line.ChartType = SeriesChartType.Line;
            line.BorderWidth = 2;
            line.LegendText = title;
            universe.ParameterChanged +=universe_ParameterChanged;
        }
        public void universe_ParameterChanged()
        {
            updateDataPoints();
        }
        protected void updateDataPoints() //要在參數new出來之後才能update
        {
            for (double x = universe.min; x <= universe.max; x = x + universe.inc)
            {
                double y;
                y = GetMembershipDegree(x);
                line.Points.AddXY(x, y);
                line.LegendText = title;
            }
        }
       virtual  public double GetMembershipDegree(double x) { //virtual實踐子類別override
            double y = 0.0;
            return y;
        }
       public void NameTitle()
       {
           title = fname + type;
       }
       public void updateFuzzySet()
       {
           line.Points.Clear();
           updateDataPoints();
       }
        //old-fashioned!
       //public double[] GetParameters()
       //{
       //    return parameters;
       //}
       //public void SetParameters(double[] p)
       //{
       //    parameters = p;
       //}
       public override string ToString()
       {
           return title;
       }
    }
}
