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

namespace R03546012許芸瑄Ass06
{
    public partial class MainForm : Form
    {
        Universe myUniverse;
        TreeNode SelectedNode;
        List<Universe> InputUniverses = new List<Universe>(); //dynamic
        List<FuzzySet> InputfuzzySetObjects = new List<FuzzySet>();//動態
        List<List<FuzzySet>> allInputFuzzySets = new List<List<FuzzySet>>(); //fuzzyset list 的list
        Universe OutputUniverse;
        List<FuzzySet> OutputFuzzySets = new List<FuzzySet>();
        List<IfThenRule> RuleList = new List<IfThenRule>();
        List<DataGridViewComboBoxColumn> inputCols1 = new List<DataGridViewComboBoxColumn>();
        List<DataGridViewComboBoxColumn> inputCols2 = new List<DataGridViewComboBoxColumn>();
        DataGridViewComboBoxColumn outputCol1 = new DataGridViewComboBoxColumn();
        DataGridViewComboBoxColumn outputCol2 = new DataGridViewComboBoxColumn();
        int count = 1; //count for input universe
        static int countInf = 0; //count for inference
        public MainForm()
        {
            InitializeComponent();
            btnAddFuzzy.Enabled = false; //還沒有universe不能add fuzzy set
            radioBtnInputU.Checked = true; //default
        }
        private void btnCreateUniverse_Click(object sender, EventArgs e) //按下之後產生新的treenode 和chart
        {
            if (radioBtnInputU.Checked == true) //加入universe
            {
                txtTitle.Text = "X" + count;
                 // 讀進universe textbox的東西加入新的universe
                string t = txtTitle.Text; //title
                double s = Convert.ToDouble(txtMin.Text); //min
                double l = Convert.ToDouble(txtMax.Text); //max
                double c = Convert.ToDouble(txtInc.Text); //increment
                myUniverse = new Universe(t, s, l, c);
                InputUniverses.Add(myUniverse);
                chartInput.ChartAreas.Add(myUniverse.chartarea);  //Add a new chart to chartarea
                //add a new node to TreeView
                TreeNode tn = new TreeNode(myUniverse.title);
                treeViewInputUniverse.Nodes.Add(tn); //加進treeview裡
                tn.ImageIndex = 0; //加圖示
                tn.SelectedImageIndex = 0;
                //添加一個universe時候，分別new出input/output的Column到dataGridView
                DataGridViewComboBoxColumn dgc1 = new DataGridViewComboBoxColumn( );
                DataGridViewComboBoxColumn dgc2 = new DataGridViewComboBoxColumn();
                dgc1.HeaderText = myUniverse.Title + " is";
                dgc2.HeaderText = myUniverse.Title + " is";
                dgc1.Name = "Input" + inputCols1.Count;
                dgc2.Name = "Input" + inputCols2.Count;
                // 設定ComboBox 內的 item 表面顯示的文案
                dgc1.DisplayMember = "Title"; // FuzzySet 須提供名為 Title 的 property 送出他的 title 字串
                dgc2.DisplayMember = "Title";
                // 設定ComboBox 內的 item 拾級儲存的 Value 
                dgc1.ValueMember = "Itself";    //  FuzzySet 須提供名為 Itself 的 property 送出他本身
                dgc2.ValueMember = "Itself";
                dataGridView1st.Columns.Add(dgc1);
                dataGridView2nd.Columns.Add(dgc2);
                inputCols1.Add( dgc1 );
                inputCols2.Add(dgc2);
                treeViewInputUniverse.SelectedNode = tn;
                SelectedNode = tn;
                lsbOptions.SelectedItem = "Triangular FS"; //default TriangularFS
                //加入universe的時候就加入sugeno的datagridview
                DataGridViewTextBoxColumn dgt1 = new DataGridViewTextBoxColumn();
                dgt1.HeaderText = myUniverse.Title;
                dgt1.Name = "Input" + inputCols1.Count;
                dataGridViewSugenoX.Columns.Add(dgt1);
                DataGridViewTextBoxColumn dgt2 = new DataGridViewTextBoxColumn();
                dgt2.HeaderText = myUniverse.Title;
                dgt2.Name = "Input" + inputCols1.Count;
                dataGridViewSugenoZ.Columns.Add(dgt2);

               
                //加入universe的時候就加入tsukamoto的datagridview
                DataGridViewTextBoxColumn dgt3 = new DataGridViewTextBoxColumn();
                dgt3.HeaderText = myUniverse.Title;
                dgt3.Name = "Input" + inputCols1.Count;
                dataGridViewTsukamoto.Columns.Add(dgt3);
               
                //Add a list of FuzzySet for the new universe
                allInputFuzzySets.Add(new List<FuzzySet>());

                chartInput.ChartAreas[0].AxisX.Maximum = myUniverse.max;
                chartInput.ChartAreas[0].AxisX.Minimum = myUniverse.min;
                chartInput.ChartAreas[0].AxisX.Title = myUniverse.title;
                chartInput.ChartAreas[0].AxisY.Maximum = 1.0;
                chartInput.ChartAreas[0].AxisY.Minimum = 0.0;
                chartInput.Enabled = true;
                btnAddFuzzy.Enabled = true; //有universe才能加入fuzzy set
                ptgProperty.SelectedObject = myUniverse;
                count++;
                txtTitle.Text = "X" + count;
            }
            //output universe
            if (radioBtnOutputU.Checked == true)
            {
                if (OutputUniverse != null) //只能有一個output universe
                {
                    MessageBox.Show("Output Universe already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtTitle.Text = "Y";
                    // 讀進universe textbox的東西加入新的universe
                    string t = txtTitle.Text; //title
                    double s = Convert.ToDouble(txtMin.Text); //min
                    double l = Convert.ToDouble(txtMax.Text); //max
                    double c = Convert.ToDouble(txtInc.Text); //increment
                    OutputUniverse = new Universe(t, s, l, c);
                    chartOutput.ChartAreas.Add(OutputUniverse.chartarea);  //Add a new chart to chartarea
                    //add a new node to TreeView
                    TreeNode tn = new TreeNode(OutputUniverse.title);
                    treeViewOutputU.Nodes.Add(tn); //加進treeview裡
                    tn.ImageIndex = 0; //加圖示
                    tn.SelectedImageIndex = 0;

                    treeViewOutputU.Select();
                    SelectedNode = treeViewOutputU.SelectedNode;
                    lsbOptions.SelectedItem = "Triangular FS"; //default TriangularFS

                    chartOutput.ChartAreas[0].AxisX.Maximum = OutputUniverse.max;
                    chartOutput.ChartAreas[0].AxisX.Minimum = OutputUniverse.min;
                    chartOutput.ChartAreas[0].AxisX.Title = OutputUniverse.title;
                    chartOutput.ChartAreas[0].AxisY.Maximum = 1.0;
                    chartOutput.ChartAreas[0].AxisY.Minimum = 0.0;
                    chartOutput.Enabled = true;
                    btnAddFuzzy.Enabled = true; //有universe才能加入fuzzy set
                    ptgProperty.SelectedObject = OutputUniverse;

                    //添加一個universe時候，分別new出output的Column到dataGridView
                    DataGridViewComboBoxColumn dgc1 = new DataGridViewComboBoxColumn();
                    DataGridViewComboBoxColumn dgc2 = new DataGridViewComboBoxColumn();
                    dgc1.HeaderText = OutputUniverse.Title + " is";
                    dgc2.HeaderText = OutputUniverse.Title + " is";
                    dgc1.Name = "Output";
                    dgc2.Name = "Output";
                    // 設定ComboBox 內的 item 表面顯示的文案
                    dgc1.DisplayMember = "Title"; // FuzzySet 須提供名為 Title 的 property 送出他的 title 字串
                    dgc2.DisplayMember = "Title";
                    // 設定ComboBox 內的 item 拾級儲存的 Value 
                    dgc1.ValueMember = "Itself";    //  FuzzySet 須提供名為 Itself 的 property 送出他本身
                    dgc2.ValueMember = "Itself";
                    dataGridView1st.Columns.Add(dgc1);
                    dataGridView2nd.Columns.Add(dgc2);
                    outputCol1 = dgc1;
                    outputCol2 = dgc2;
                }
            }
        }
        private void btnAddFuzzy_Click(object sender, EventArgs e)
        {
            FuzzySet fs = null; //local variable default
            if (ptgProperty.SelectedObject is FuzzySet)
            {
                 MessageBox.Show("You must select a universe", "No Universe selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            Universe uu = (Universe)ptgProperty.SelectedObject;
            switch (lsbOptions.SelectedIndex)
            {
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
                    fs = new LeftRightFuzzySet(uu);
                    break;
                case 4://Sigmoodal
                    fs = new SigmoidalFuzzySet(uu);
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
            if (SelectedNode.TreeView == treeViewInputUniverse)
            {
                //fuzzySetObjects.Add(fs);
                allInputFuzzySets[SelectedNode.Index].Add(fs);
                //加入comboBox
                comboBoxBinary1stFS.Items.Add(fs);
                comboBoxBinary2ndFS.Items.Add(fs);
                //add a node to represent the fuzzyset
                TreeNode tnn = new TreeNode(fs.title);
                treeViewInputUniverse.Nodes[SelectedNode.Index].Nodes.Add(tnn);
                tnn.ImageIndex = 1;
                tnn.SelectedImageIndex = 1;
                inputCols1[SelectedNode.Index].Items.Add(fs);
                inputCols2[SelectedNode.Index].Items.Add(fs);
                treeViewInputUniverse.ExpandAll();
                chartInput.Series.Add(fs.line);
            }
            else //output universe
            {
                OutputFuzzySets.Add(fs);
                comboBoxBinary1stFS.Items.Add(fs);
                comboBoxBinary2ndFS.Items.Add(fs);
                //add a node to represent the fuzzyset
                TreeNode tnn = new TreeNode(fs.title);
                treeViewOutputU.Nodes[SelectedNode.Index].Nodes.Add(tnn);
                tnn.ImageIndex = 1;
                tnn.SelectedImageIndex = 1;
                outputCol1.Items.Add(fs);
                outputCol2.Items.Add(fs);
                treeViewOutputU.ExpandAll();
                chartOutput.Series.Add(fs.line);
            }

        }
        //加入unary fuzzy set
        private void btnAddUnary_Click(object sender, EventArgs e)
        {
            UnaryOperator op = null; //local variable default
            TreeNode tn = treeViewInputUniverse.SelectedNode;
            int level = tn.Level;
            int idx = tn.Index;
            FuzzySet SelectedFS;
            if (level == 1 && tn != null) //選到FS
            {
                SelectedFS = allInputFuzzySets[tn.Parent.Index][tn.Index];
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
                case 6://more or less
                    op = new MoreOrLess();
                    break;
                case 7://Intensify
                    op = new Intensify();
                    break;
                case 8: //Diminisher
                    op = new Diminisher();
                    break;
                case 9: //Sugeno Not
                    op = new SugenoNot(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
                case 10: //Yager Not
                    op = new YagerNot(Convert.ToDouble(txtUnaryParameter.Text));
                    break;
            }
            //加入各清單之中
            UnaryOperatedFuzzySet UFS = new UnaryOperatedFuzzySet(op, SelectedFS);
            InputfuzzySetObjects.Add(UFS);
            allInputFuzzySets[tn.Parent.Index].Add(UFS);
            comboBoxBinary1stFS.Items.Add(UFS);
            comboBoxBinary2ndFS.Items.Add(UFS);
            //add a node to represent the fuzzyset
            TreeNode tnn = new TreeNode(UFS.title);
            tnn.ImageIndex = 1;
            tnn.SelectedImageIndex = 1;
            treeViewInputUniverse.Nodes[tn.Parent.Index].Nodes.Add(tnn);
            chartInput.Series.Add(UFS.line);
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

        private void btnAddBinary_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeViewInputUniverse.SelectedNode;
            if (tn.Level == 0)
            {
                BinaryOperator op = null; //local variable default
                FuzzySet SelectedFS1 = (FuzzySet)comboBoxBinary1stFS.SelectedItem; //透過cast轉型
                FuzzySet SelectedFS2 = (FuzzySet)comboBoxBinary2ndFS.SelectedItem;
                if (SelectedFS1 == null || SelectedFS2 == null) //有一格沒選到
                {
                    MessageBox.Show("one of fuzzy sets is not selected", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (listBoxBinary.SelectedIndex < 0)
                {
                    MessageBox.Show("binary operator is not selected", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (SelectedFS1.universe != SelectedFS2.universe) //一定要屬於同個universe
                {
                    MessageBox.Show("the fuzzy sets must belong to the same universe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    switch (listBoxBinary.SelectedIndex)
                    {
                        case 0: //Intersect
                            op = new Intersect();
                            break;
                        case 1: //Alegraic Product
                            op = new AlegraicProduct();
                            break;
                        case 2://BoundedProduct
                            op = new BoundedProduct();
                            break;
                        case 3://DrasticProduct
                            op = new DrasticProduct();
                            break;
                        case 4://Union
                            op = new Union();
                            break;
                        case 5://AlgebraicSum
                            op = new AlgebraicSum();
                            break;
                        case 6://BoundedSum
                            op = new BoundedSum();
                            break;
                        case 7: //DrasticSum
                            op = new DrasticSum();
                            break;
                        case 8: //SugenoT
                            MessageBox.Show("Sugeno T-norm is not implemented yet!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            //op = new SugenoTNorm();
                        case 9: //SugenoS
                            //op = new SugenoSNorm();
                            MessageBox.Show("Sugeno S-norm is not implemented yet!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        case 10: //YagerT
                            //op = new YagerTNom();
                            MessageBox.Show("Yager T-norm is not implemented yet!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        case 11: //YagerS
                            //op = new YagerSNorm();
                            MessageBox.Show("Yager S-norm is not implemented yet!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    //加入各清單之中
                    BinaryOperatedFuzzySet BFS = new BinaryOperatedFuzzySet(op, SelectedFS1, SelectedFS2);
                    InputfuzzySetObjects.Add(BFS);
                    comboBoxBinary1stFS.Items.Add(BFS);
                    comboBoxBinary2ndFS.Items.Add(BFS);
                    int idx = 0;
                    for (int i = 0; i < InputUniverses.Count; i++) //找是屬於treeview上哪個node
                    {
                        if (SelectedFS1.universe.title != InputUniverses[i].title)
                            idx++;
                        else
                            break;
                    }
                    allInputFuzzySets[tn.Index].Add(BFS);
                    //add a node to represent the fuzzyset
                    TreeNode tnn = new TreeNode(BFS.title);
                    tnn.ImageIndex = 1;
                    tnn.SelectedImageIndex = 1;
                    treeViewInputUniverse.Nodes[tn.Index].Nodes.Add(tnn);
                    chartInput.Series.Add(BFS.line);
                }
            }
            else
            {
                MessageBox.Show("You must select a universe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //update treeview
        private void ptgProperty_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            TreeNode tn = treeViewInputUniverse.SelectedNode;
            if (tn.Level == 0) //universe
            {
                Universe SelectedU = InputUniverses[tn.Index];
                tn.Text = SelectedU.Title;
            }
            if (tn.Level == 1)//fuzzySet
            {
                FuzzySet SelectedFS = allInputFuzzySets[tn.Parent.Index][tn.Index];
                tn.Text = SelectedFS.Title;
            }
        }
        //加入rule
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            List<FuzzySet> fslist = new List<FuzzySet>();
            if (OutputUniverse == null || OutputFuzzySets.Count==0)
            {
                MessageBox.Show("Output Universe doesn' t exist or Output Fuzzy Set doen't exist ", "No Ouput Universe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for(int i = 0; i < InputUniverses.Count; i++)
            {
                if(allInputFuzzySets[i].Count ==0) //如果沒有就不要加
                {
                    MessageBox.Show("Fuzzy Set doesn' t exist", "No fuzzy set exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                }
                fslist.Add(allInputFuzzySets[i][0]); //預設是把全部universe的第一個加入
            }
            IfThenRule rule = new IfThenRule(fslist, OutputFuzzySets[0]);
            RuleList.Add(rule);
            listBoxIfThenRule.Items.Add(rule);
        }

        private void listBoxIfThenRule_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = listBoxIfThenRule.SelectedIndex;
             if( idx < 0 ) return;
            dataGridView1st.Rows.Clear( );
            dataGridView2nd.Rows.Clear();
            IfThenRule itr = (IfThenRule)  listBoxIfThenRule.SelectedItem;
            dataGridView1st.Rows.Add();
            dataGridView2nd.Rows.Add();
            for( int i = 0; i < inputCols1.Count; i++ )
            {
               dataGridView1st.Rows[0].Cells["Input" + i].Value = itr.inputFuzzySets[i];
               dataGridView2nd.Rows[0].Cells["Input" + i].Value = itr.inputFuzzySets[i];
            }
            dataGridView1st.Rows[0].Cells["Output"].Value = itr.outputFuzzySet;
        }

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {
            if(  listBoxIfThenRule.SelectedIndex < 0 ) return;
            int idx =  listBoxIfThenRule.SelectedIndex;
            IfThenRule itr = (IfThenRule)  listBoxIfThenRule.SelectedItem;
            for( int i = 0; i < itr.inputFuzzySets.Count; i++ )
            {
                itr.inputFuzzySets[i] = (FuzzySet)dataGridView1st.Rows[0].Cells["Input" + i].Value;
            }
            itr.outputFuzzySet = (FuzzySet) dataGridView1st.Rows[0].Cells["Output"].Value;
            // 將清單內容更新
            listBoxIfThenRule.SelectedIndex = -1;// 先移開
            listBoxIfThenRule.Items[idx] = ""; // 清空該項
            listBoxIfThenRule.Items[idx] = itr;// 重設回來讓他更新內容
            listBoxIfThenRule.SelectedIndex = idx;// 移回本rule
			// 清除此  row
            dataGridView1st.Rows.Clear();
        }

        //選到intput treeview的點
        private void treeViewInputUniverse_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int idx = e.Node.Index;
            SelectedNode = e.Node;
            if (SelectedNode.Level == 0) //選到universe->可以更新universe
            {
                Universe selectedU = InputUniverses[idx];
                txtTitle.Text = selectedU.title;
                txtMax.Text = selectedU.max.ToString();
                txtMin.Text = selectedU.min.ToString();
                txtInc.Text = selectedU.inc.ToString();
                ptgProperty.SelectedObject = selectedU;
            }
            if (SelectedNode.Level == 1) //選到fuzzy set->可以更新變數-->準備可用欄位
            {
                int idxParent = SelectedNode.Parent.Index;
                FuzzySet selectedFS = allInputFuzzySets[idxParent][idx]; //選到"那個"fuzzy set
                txtUnaryTarget.Text = selectedFS.title; //加到Unary
                ptgProperty.SelectedObject = selectedFS;
            }
        }
        //選到output treeview的點
        private void treeViewOutputU_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
             int idx = e.Node.Index;
            SelectedNode = e.Node;
            if (SelectedNode.Level == 0) //選到universe->可以更新universe
            {
                Universe selectedU = OutputUniverse;
                txtTitle.Text = selectedU.title;
                txtMax.Text = selectedU.max.ToString();
                txtMin.Text = selectedU.min.ToString();
                txtInc.Text = selectedU.inc.ToString();
                ptgProperty.SelectedObject = selectedU;
            }
            if (SelectedNode.Level == 1) //選到fuzzy set->可以更新變數-->準備可用欄位
            {
                FuzzySet selectedFS = OutputFuzzySets[idx]; //選到"那個"fuzzy set
                txtUnaryTarget.Text = selectedFS.title; //加到Unary
                ptgProperty.SelectedObject = selectedFS;
            }
        }

        private void btnSugenoInference_Click(object sender, EventArgs e)
        {
            double[] x = new double[InputUniverses.Count]; //x值
            double[] w = new double[RuleList.Count]; //weight
            double totalWeight = 0.0;
            double[] zcoe = new double[InputUniverses.Count]; //z的coefficent
            double[] x_zcoe = new double[InputUniverses.Count]; //zceo[i] * x[i]
            double[] z = new double[RuleList.Count];
            double wa = 0.0;
            double ws = 0.0;
            for (int i = 0; i < InputUniverses.Count; i++)
            {
                x[i] = Convert.ToDouble(dataGridViewSugenoX.Rows[0].Cells[i].Value); //讀進來
                zcoe[i] = Convert.ToDouble(dataGridViewSugenoZ.Rows[0].Cells[i].Value);
                x_zcoe[i] = x[i] * zcoe[i];
            }
            for (int r = 0; r < RuleList.Count; r++) //計算w
            {
                w[r] = 1.0;
                for (int j = 0; j < InputUniverses.Count; j++)
                {
                    z[r] += x_zcoe[j]; //計算z[r]值
                    double temp = RuleList[r].inputFuzzySets[j].GetMembershipDegree(x[j]);
                    if (temp < w[r]) //取min
                        w[r] = temp;
                }
                totalWeight += w[r];
                ws += z[r] * w[r]; //weighted sum
                wa += z[r] * w[r] / totalWeight;  //weighted average
            }
            txtSugenoWA.Text = wa.ToString();
            txtSugenoWS.Text = ws.ToString();
        }

        private void btnTsukamotoInf_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtTsukamotoA.Text);
            double c = Convert.ToDouble(txtTsukamotoC.Text);
            FuzzySet sig = new SigmoidalFuzzySet(new Universe());
            sig.Parameters[0] = a;
            sig.Parameters[1] = c;
            double[] x = new double[InputUniverses.Count]; //x值
            double[] w = new double[RuleList.Count]; //weight
            double totalWeight = 0.0;
            double[] z = new double[RuleList.Count];
            double wa = 0.0;
            double ws = 0.0;
            for (int i = 0; i < InputUniverses.Count; i++)
            {
                x[i] = Convert.ToDouble(dataGridViewTsukamoto.Rows[0].Cells[i].Value); //讀進來
            }
            for (int r = 0; r < RuleList.Count; r++) //計算w
            {
                w[r] = 1.0;
                for (int j = 0; j < InputUniverses.Count; j++)
                {
                    double temp = RuleList[r].inputFuzzySets[j].GetMembershipDegree(x[j]);
                    if (temp < w[r]) //取min
                        w[r] = temp;
                }
                totalWeight += w[r];
                z[r] = sig.GetMembershipDegree(w[r]);
                ws += z[r] * w[r]; //weighted sum
                wa += z[r] * w[r] / totalWeight;  //weighted average
            }
            txtTsukamotoWA.Text = wa.ToString();
            txtTsukamotoWS.Text = ws.ToString();
        }


        private void btnMamdaniInference_Click(object sender, EventArgs e)
        {
            if (OutputUniverse == null || OutputFuzzySets.Count == 0) //至少要有output universe
            {
                MessageBox.Show("Output Universe doesn' t exist", "No Ouput Universe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //inference calculation
            List<FuzzySet> conditionFSlist = new List<FuzzySet>();
            IfThenRule SelectedRule = (IfThenRule)listBoxIfThenRule.SelectedItem;
            FuzzySet result = null;
            for (int i = 0; i < RuleList.Count; i++)
            {
                for (int j = 0; j < InputUniverses.Count; j++)
                {
                    if (dataGridView2nd.Rows[0].Cells["Input" + j].Value != null)
                        conditionFSlist.Add((FuzzySet)dataGridView2nd.Rows[i].Cells["Input" + j].Value);
                }
                if (i == 0)// 第一個
                    result = RuleList[i].MamdaniInference(conditionFSlist);
                FuzzySet temp = RuleList[i].MamdaniInference(conditionFSlist);
                result = new BinaryOperatedFuzzySet(new Union(), temp, result);
            }
            result.Title = "Mamdani Inference result " + countInf;
            result.line.ChartType = SeriesChartType.Area;
            chartOutput.Series.Add(result.line);
            countInf++;

            //defuzzification
            txtBOA.Text = result.BOA.ToString();
            txtCOA.Text = result.COA.ToString();
            txtLOM.Text = result.LOM.ToString();
            txtMOM.Text = result.MOM.ToString();
            txtSOM.Text = result.SOM.ToString();
        }


    }
}

