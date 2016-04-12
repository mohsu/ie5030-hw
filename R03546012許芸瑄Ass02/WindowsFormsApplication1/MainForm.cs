using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FunctionSig sig;
        FunctionB b;
        FunctionG g;
        FunctionT t;
        public Form1()
        {
            InitializeComponent();
            //initialize sig,t,g,b objects
            sig = new FunctionSig();
            b = new FunctionB();
            g = new FunctionG();
            t = new FunctionT();
            //update UI controls(sig, t, g, b)
            labSigC.Text = sig.parNames[0];
            labSigA.Text = sig.parNames[1];
            txtSigC.Text = Convert.ToString(sig.parameters[0]);
            txtSigA.Text = Convert.ToString(sig.parameters[1]);

            labT_a.Text = t.parNames[0];
            labT_b.Text = t.parNames[1];
            labT_c.Text = t.parNames[2];
            txt_a.Text = Convert.ToString(t.parameters[0]);
            txt_b.Text = Convert.ToString(t.parameters[1]);
            txt_c.Text = Convert.ToString(t.parameters[2]);

            labG_c.Text =g.parNames[0];
            labG_sigma.Text = g.parNames[1];
            txt_g_c.Text = Convert.ToString(g.parameters[0]);
            txt_sigma.Text = Convert.ToString(g.parameters[1]);

            labB_a.Text = b.parNames[0];
            labB_b.Text = b.parNames[1];
            labB_c.Text = b.parNames[2];
            txt_fb_a.Text = Convert.ToString(b.parameters[0]);
            txt_fb_b.Text = Convert.ToString(b.parameters[1]);
            txt_fb_c.Text = Convert.ToString(b.parameters[2]);
        }

        private void btn_Sig_Click(object sender, EventArgs e)
        {
            //先get Textbox 文字
            sig.parameters[0] = Convert.ToDouble(txtSigC.Text);
            sig.parameters[1] = Convert.ToDouble(txtSigA.Text);
            chart1.Series[3].Points.Clear();
            //畫圖
            for (double x = -10.0; x <= 10.0; x += 0.1)
            {
                double y;
                y = sig.GetFuctionValue(x);
                chart1.Series[3].Points.AddXY(x, y);
            }
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            t.parameters[0] = Convert.ToDouble(txt_a.Text);
            t.parameters[1] = Convert.ToDouble(txt_b.Text);
            t.parameters[2] = Convert.ToDouble(txt_c.Text);

            chart1.Series[0].Points.Clear();

            for (double x = -10.0; x <= 10.0; x = x + 0.1)
            {
                double y = t.GetFuctionValue(x);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            g.parameters[0] = Convert.ToDouble(txt_g_c.Text);
            g.parameters[1] = Convert.ToDouble(txt_sigma.Text);
            txt_g_c.Text = Convert.ToString(Convert.ToDouble(trackBar1.Value));
            txt_sigma.Text = Convert.ToString(Convert.ToDouble(trackBar2.Value));

            for (double x = -10.0; x <= 10.0; x = x + 0.1)
            {
                double y;
                y = g.GetFuctionValue(x);
                chart1.Series[1].Points.AddXY(x, y);
            }
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            g.parameters[0] = Convert.ToDouble(txt_g_c.Text);
            g.parameters[1] = Convert.ToDouble(txt_sigma.Text);
            txt_g_c.Text = Convert.ToString(Convert.ToDouble(trackBar1.Value));
            txt_sigma.Text = Convert.ToString(Convert.ToDouble(trackBar2.Value));
            for (double x = -10.0; x <= 10.0; x = x + 0.1)
            {
                double y;
                y = g.GetFuctionValue(x);
                chart1.Series[1].Points.AddXY(x, y);
            }
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            g.parameters[0] = Convert.ToDouble(txt_g_c.Text);
            g.parameters[1] = Convert.ToDouble(txt_sigma.Text);
            for (double x = -10.0; x <= 10.0; x = x + 0.1)
            {
                double y;
                y = g.GetFuctionValue(x);
                chart1.Series[1].Points.AddXY(x, y);
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            b.parameters[0] = Convert.ToDouble(txt_fb_a.Text);
            b.parameters[1] = Convert.ToDouble(txt_fb_b.Text);
            b.parameters[2] = Convert.ToDouble(txt_fb_c.Text);
            chart1.Series[2].Points.Clear();
            for (double x = -10.0; x <= 10.0; x = x + 0.1)
            {
                double y;
                y = b.GetFuctionValue(x);
                chart1.Series[2].Points.AddXY(x, y);
            }
        }
    }
}
