using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace R03546012許芸瑄Ass06
{
    delegate void FuzzySetParameterChangedHandlingFuction(double e);
    class FuzzySet //continuous
    {
        public static FuzzySet operator!(FuzzySet operand)//static->不屬於物件
        {
            FuzzySet fs = null;
            fs = new UnaryOperatedFuzzySet(new Not(), operand);
            return fs;
        }
        public static FuzzySet operator &(FuzzySet operand1, FuzzySet operand2)//static->不屬於物件
        {
            FuzzySet fs = null;
            fs = new BinaryOperatedFuzzySet(new Union(), operand1, operand2);
            return fs;
        }
        public static double operator &(double crispValue, FuzzySet operand)//static->不屬於物件
        {
            return operand.GetMembershipDegree(crispValue);
        }
        public double getMaxDegree()
        {
            double maxDegree = 0;
            for (double x = universe.min; x < universe.Max; x += universe.inc)
            {
                double y = GetMembershipDegree(x);
                if (y > maxDegree)
                    maxDegree = y;
            }
            return maxDegree;
        }
        [Description("sum/area"), Category("Crisp Value")]
        public virtual double COA 
        {
            get 
            {
                double  area = 0, sum = 0;
                foreach (DataPoint dp in line.Points)
                {
                    sum += dp.XValue * dp.YValues[0] * universe.inc;
                    area += universe.inc * dp.YValues[0];
                }
                return Math.Round(sum / area,2);
            }
        }
        [Description("area相等時的x值"), Category("Crisp Value")]
        public virtual double BOA //area相等
        {
            get
            {
                double x = 0, area = 0,  half = 0;
                foreach (DataPoint dp in line.Points)
                {
                    area += universe.inc * dp.YValues[0];
                }
                half = area / 2;
                area = 0; //reset
                foreach (DataPoint dp in line.Points)
                {
                    if (area >= half)
                        area += universe.inc * dp.YValues[0];
                    x = dp.XValue;
                }
                return Math.Round(x,2);
            }
        }
        [Description("smallest x of largest y"), Category("Crisp Value")]
        public virtual double SOM //smallest
        {
            get
            {
                double max = 0, x_max = 0;
                foreach (DataPoint dp in line.Points) //find max
                {
                    if (dp.YValues[0] > max) //除非大於不然不取代
                    {
                        max = dp.YValues[0];
                        x_max = dp.XValue;
                    }
                }
                return Math.Round(x_max,2);
            }
        }
        [Description("largest x of largest y"), Category("Crisp Value")]
        public virtual double LOM //largest
        {
            get
            {
                double max = 0;
                double x_max=0.0;
                foreach (DataPoint dp in line.Points) //find max
                {
                    if (dp.YValues[0] >= max) //若等於就取代
                    {
                        max = dp.YValues[0];
                        x_max = dp.XValue;
                    }
                        
                }
                return Math.Round(x_max,2);
            }
        }
        [Description("midium x of largest y"), Category("Crisp Value")]
        public virtual double MOM //mean of maximum
        { 
            get { return (SOM + LOM) / 2; }
        }
        protected double[] parameters;
         //property
        [Browsable(false)]
        public double[] Parameters //控制項
        {//像函式
            get  {return parameters;}
            set { parameters = value; } //value是一個KEY word
        }
        [Category("\tTitle")]
        public string Title
        {
            get { return title; }
            set { title = value; line.Name = value; }
        }
        [Browsable(false)]
        public FuzzySet Itself
        {
            get { return this; }
        }
        public event FuzzySetParameterChangedHandlingFuction ParameterChanged;
        protected void OnParameterChanged()
        {
            if (ParameterChanged != null)
                ParameterChanged(1.0); 
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
            fname = "";
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
            line.Points.Clear();
            line.Name = title;
            for (double x = universe.min; x <= universe.max; x = x + universe.inc)
            {
                double y;
                y = GetMembershipDegree(x);
                line.Points.AddXY(x, y);
                line.LegendText = title;
            }
            OnParameterChanged();
        }
       virtual  public double GetMembershipDegree(double x) { //virtual實踐子類別override
            double y = 0.0;
            return y;
        }
       public void NameTitle()
       {
           title = fname + type;
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
       public override string ToString() //轉成正常的名字
       {return title;}
    }
}
