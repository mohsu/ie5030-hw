using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R03546012許芸瑄Ass03
{
    public partial class MainForm : Form
    {
        Universe myUniverse;
        List<Universe> allUniverses = new List<Universe>(); //dynamic
        List<FuzzySet> fuzzySetObjects = new List<FuzzySet>();//動態
        List<List<FuzzySet>> allFuzzySets = new List<List<FuzzySet>>(); //fuzzyset list 的list
        public MainForm()
        {
            InitializeComponent();
           btnUpdateFuzzySet.Enabled = false; //還沒有fuzzy set 不能更新
            btnUpdateUniverse.Enabled = false; // 還沒有 universe 不能更新
        }
        private void btnCreateUniverse_Click(object sender, EventArgs e) //按下之後產生新的treenode 和chart
        {
            // 讀進universe textbox的東西加入新的universe
            string t = txtTitle.Text; //title
            double s = Convert.ToDouble(txtMin.Text); //min
            double l = Convert.ToDouble(txtMax.Text); //max
            double c = Convert.ToDouble(txtInc.Text); //increment
            myUniverse = new Universe(t, s, l, c);
            allUniverses.Add(myUniverse);
            chartUniverse.ChartAreas.Add(myUniverse.chartarea);  //Add a new chart to chartarea
            //add a new node to TreeView
            TreeNode tn = new TreeNode(myUniverse.title);
            treeViewUniverse.Nodes.Add(tn); //加進treeview裡
            tn.ImageIndex = 0; //加圖示
            tn.SelectedImageIndex = 0;
            
            treeViewUniverse.Select();
            lsbOptions.SelectedItem = "Triangular FS"; //default TriangularFS

            //Add a list of FuzzySet for the new universe
            allFuzzySets.Add(new List<FuzzySet>());
           
            chartUniverse.ChartAreas[0].AxisX.Maximum = myUniverse.max;
            chartUniverse.ChartAreas[0].AxisX.Minimum = myUniverse.min;
            chartUniverse.ChartAreas[0].AxisX.Title = myUniverse.title;
            chartUniverse.Enabled = true;
        }

        private void btnAddFuzzy_Click(object sender, EventArgs e)
        {
           FuzzySet fs = null; //local variable default
           TreeNode tn =  treeViewUniverse.SelectedNode;
            Universe uu;
            if (tn.Level == 0 && tn != null)
            {
                int level = tn.Level;
                int idx = tn.Index;
                uu = allUniverses[idx];
            }
            else //exception
            {
                MessageBox.Show("You must select a universe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch(lsbOptions.SelectedIndex){
                case 0: //Triangular
                        fs = new TriangularFuzzySet(uu);
                        break;
                case 1: //Gaussian
                        fs = new GaussianFuzzySet(uu);
                        break;
                case 2://Bell
                        fs = new BellFuzzySet(uu);
                        break;
                case 3://LeftRight
                        fs =new LeftRightFuzzySet(uu);
                        break;
                case 4://Sigmoodal
                        fs =new SigmoidalFuzzySet(uu);
                        break;
                case 5://Trapezoidal
                        fs = new TrapezoidalFuzzySet(uu);
                        break;
                case 6://Sshape
                        fs = new SshapeFuzzySet(uu);
                        break;
                case 7:
                        fs = new ZshapeFuzzySet(uu);
                        break;
                case 8:
                        fs = new PishapeFuzzySet(uu);
                        break;
            }
            //fuzzySetObjects.Add(fs);
            allFuzzySets[tn.Index].Add(fs);
            //add a node to represent the fuzzyset
            TreeNode tnn = new TreeNode(fs.title);
            treeViewUniverse.Nodes[tn.Index].Nodes.Add(tnn);
            tnn.ImageIndex = 1;
            tnn.SelectedImageIndex = 1;
            treeViewUniverse.ExpandAll();
            chartUniverse.Series.Add(fs.line);
        }

        private void btnUpdateUniverse_Click(object sender, EventArgs e)
        {
            if (treeViewUniverse.SelectedNode.Level != 0) //沒選到universe
            {
                MessageBox.Show("You must select a universe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //讀入變數
            {
                int idx = treeViewUniverse.SelectedNode.Index;
                Universe selectedU = allUniverses[idx]; //選到"那個"universe
                selectedU.title = txtTitle.Text;
                selectedU.max = Convert.ToDouble(txtMax.Text);
                selectedU.min = Convert.ToDouble(txtMin.Text);
                selectedU.inc = Convert.ToDouble(txtInc.Text);
                treeViewUniverse.SelectedNode.Text = selectedU.title;
                //更新chart
                selectedU.updateChartArea();
                //更新fuzzy set
                for (int i = 0; i < allFuzzySets[idx].Count(); i++)
                {
                    FuzzySet selectedFS = allFuzzySets[idx][i];
                    selectedFS.updateFuzzySet();
                }
            }
            //btnUpdateUniverse.Enabled = false; //結束後改成不能更改universe
        }
        private void btnUpdateFuzzySet_Click(object sender, EventArgs e)
        {
            if (treeViewUniverse.SelectedNode.Level != 1) //沒選到fuzzy set
            {
                MessageBox.Show("You must select a fuzzy set", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;           
            }
            else //讀入變數
            {
                int idxParent = treeViewUniverse.SelectedNode.Parent.Index;
                int idx = treeViewUniverse.SelectedNode.Index;
                FuzzySet selectedFS = allFuzzySets[idxParent][idx]; //選到"那個"fuzzy set
                selectedFS.fname = txtFuzzySetTitle.Text;
                selectedFS.NameTitle();
                if (selectedFS.Parameters.Length == 2)
                {
                    selectedFS.Parameters[0] = Convert.ToDouble(txtP1.Text);
                    selectedFS.Parameters[1] = Convert.ToDouble(txtP2.Text);
                }
                if (selectedFS.Parameters.Length == 3)
                {
                    selectedFS.Parameters[0] = Convert.ToDouble(txtP1.Text);
                    selectedFS.Parameters[1] = Convert.ToDouble(txtP2.Text);
                    selectedFS.Parameters[2] = Convert.ToDouble(txtP3.Text);
                }
                if (selectedFS.Parameters.Length == 4)
                {
                    selectedFS.Parameters[0] = Convert.ToDouble(txtP1.Text);
                    selectedFS.Parameters[1] = Convert.ToDouble(txtP2.Text);
                    selectedFS.Parameters[2] = Convert.ToDouble(txtP3.Text);
                    selectedFS.Parameters[3] = Convert.ToDouble(txtP4.Text);
                }
                //更新chart, treeview
                selectedFS.updateFuzzySet();
                treeViewUniverse.SelectedNode.Text = selectedFS.title;
                //btnUpdateFuzzySet.Enabled = false; //結束後改回不能改FS
            }
        }

        private void treeViewUniverse_AfterSelect(object sender, TreeViewEventArgs e)
        {
             int idx = treeViewUniverse.SelectedNode.Index;
            if (treeViewUniverse.SelectedNode.Level == 0) //選到universe->可以更新universe
            {
                Universe selectedU = allUniverses[idx];
                btnUpdateUniverse.Enabled = true;
                txtTitle.Text = selectedU.title;
                txtMax.Text = selectedU.max.ToString();
                txtMin.Text = selectedU.min.ToString();
                txtInc.Text = selectedU.inc.ToString();
            }
            if (treeViewUniverse.SelectedNode.Level == 1) //選到fuzzy set->可以更新變數-->準備可用欄位
            {
                int idxParent = treeViewUniverse.SelectedNode.Parent.Index;
                FuzzySet selectedFS = allFuzzySets[idxParent][idx]; //選到"那個"fuzzy set
                btnUpdateFuzzySet.Enabled = true;
                txtFuzzySetTitle.Text = selectedFS.fname;
                txtUnaryTarget.Text = selectedFS.title; //加到Unary

                if (selectedFS.Parameters.Length == 2) //2個變數 其他兩個設為不顯示
                {
                    labP1.Text = selectedFS.parNames[0];
                    labP2.Text = selectedFS.parNames[1];
                    labP1.Visible = true;
                    labP2.Visible = true;
                    labP3.Visible = false;
                    labP4.Visible = false;
                    txtP1.Text = selectedFS.Parameters[0].ToString();
                    txtP2.Text = selectedFS.Parameters[1].ToString();
                    txtP1.Visible = true;
                    txtP2.Visible = true;
                    txtP3.Visible = false;
                    txtP4.Visible = false;
                }
                if (selectedFS.Parameters.Length == 3) //3個變數 一個設為不顯示
                {
                    labP1.Text = selectedFS.parNames[0];
                    labP2.Text = selectedFS.parNames[1];
                    labP3.Text = selectedFS.parNames[2];
                    labP1.Visible = true;
                    labP2.Visible = true;
                    labP3.Visible = true;
                    labP4.Visible = false;
                    txtP1.Text = selectedFS.Parameters[0].ToString();
                    txtP2.Text = selectedFS.Parameters[1].ToString();
                    txtP3.Text = selectedFS.Parameters[2].ToString();
                    txtP1.Visible = true;
                    txtP2.Visible = true;
                    txtP3.Visible = true;
                    txtP4.Visible = false;
                }
                if (selectedFS.Parameters.Length == 4) //4個變數
                {
                    labP1.Text = selectedFS.parNames[0];
                    labP2.Text = selectedFS.parNames[1];
                    labP3.Text = selectedFS.parNames[2];
                    labP4.Text = selectedFS.parNames[3];
                    labP1.Visible = true;
                    labP2.Visible = true;
                    labP3.Visible = true;
                    labP4.Visible = true;
                    txtP1.Text = selectedFS.Parameters[0].ToString();
                    txtP2.Text = selectedFS.Parameters[1].ToString();
                    txtP3.Text = selectedFS.Parameters[2].ToString();
                    txtP4.Text = selectedFS.Parameters[3].ToString();
                    txtP1.Visible = true;
                    txtP2.Visible = true;
                    txtP3.Visible = true;
                    txtP4.Visible = true;
                }
            }
        }
        //加入unary fuzzy set
        private void btnAddUnary_Click(object sender, EventArgs e) 
        {
            UnaryOperator op = null; //local variable default
            TreeNode tn = treeViewUniverse.SelectedNode;
            int level = tn.Level;
            int idx = tn.Index;
            FuzzySet SelectedFS;
            if (level == 1 && tn != null)
            {
                SelectedFS = allFuzzySets[tn.Parent.Index][tn.Index];
            }
            else //exception
            {
                MessageBox.Show("You must select a fuzzy set", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (listBoxUnary.SelectedIndex)
            {
                case 0: //Not
                   op = new Not();
                    break;
                case 1: //Value Scale
                    op = new ValueScale(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
                case 2://Value Cut
                    op = new ValueCut(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
                case 3://Very
                    op = new Very();
                    break;
                case 4://Very Very
                    op = new VeryVery();
                    break;
                case 5://Extremely
                    op = new Extremely();
                    break;
                case 6://Intensify
                    op = new Intensify();
                    break;
                case 7: //Diminisher
                    op = new Diminisher();
                    break;
                case 8: //Sugeno Not
                    op = new SugenoNot(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
                case 9: //Yager Not
                    op = new YagerNot(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
            }
            //加入各清單之中
            UnaryOperatedFuzzySet UFS = new UnaryOperatedFuzzySet(op, SelectedFS);
            fuzzySetObjects.Add(UFS);
            allFuzzySets[tn.Parent.Index].Add(UFS);
            //add a node to represent the fuzzyset
            TreeNode tnn = new TreeNode(UFS.fname);
            tnn.ImageIndex = 1;
            tnn.SelectedImageIndex = 1;
            treeViewUniverse.Nodes[tn.Parent.Index].Nodes.Add(tnn);
            chartUniverse.Series.Add(UFS.line);
        }
        //如果選到的unary operator不用更改parameter 就隱藏parameter的格子
        private void listBoxUnary_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxUnary.SelectedIndex)
            {
                case 0: //not
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 1: //value scale
                   labUnaryParameter.Visible = true;
                   txtUnaryParameter.Visible = true;
                   break;
                case 2: //value cut
                   labUnaryParameter.Visible = true;
                   txtUnaryParameter.Visible = true;
                   break;
                case 3: //very
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 4://veryvery
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 5://extremely
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 6://more or less
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 7: //intensify
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 8://diminisher
                   labUnaryParameter.Visible = false;
                   txtUnaryParameter.Visible = false;
                   break;
                case 9: //sugeno not
                   labUnaryParameter.Visible = true;
                   txtUnaryParameter.Visible = true;
                   break;
                case 10: //yager not
                   labUnaryParameter.Visible = true;
                   txtUnaryParameter.Visible = true;
                   break;
            }
        }
    }
}
