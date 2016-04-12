using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA
{
    public partial class MainForm : Form
    {
        jobAssignmentGA job = new jobAssignmentGA();
        public MainForm()
        {
            InitializeComponent();
            radioBtnStochastic.Checked = true;
            radiobtnBinary.Checked = true;
            btnReset.Enabled = false;
            btnOneIteration.Enabled = false;
            btnRun.Enabled = false;
        }
        //open a GA file
        private void toolStripBtnOpen_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog opneFile = new OpenFileDialog();
            opneFile.Title = "Open a GA file";
            opneFile.InitialDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\JobAssignmentLIB";
            opneFile.Filter = "aop file(*.aop)|*.aop|All files(*.*)|*.*";
            opneFile.FilterIndex = 1;
            MessageBox.Show(opneFile.InitialDirectory);
            opneFile.FileName = "*.aop";
            opneFile.RestoreDirectory = true;
            if (opneFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = opneFile.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            //read stream
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message); }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog opneFile = new OpenFileDialog();
            opneFile.Title = "Open a GA file";
            opneFile.InitialDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\JobAssignmentLIB";
            opneFile.Filter = "aop file(*.aop)|*.aop|All files(*.*)|*.*";
            opneFile.FilterIndex = 1;
            MessageBox.Show(opneFile.InitialDirectory);
            opneFile.FileName = "*.aop";
            opneFile.RestoreDirectory = true;
            if (opneFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = opneFile.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            //read stream
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message); }
            }
        }

        //save a GA.aop file
        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a GA file";
            saveFile.Filter = "aop file(*.aop)|*.aop|All files(*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((mystream = saveFile.OpenFile()) != null)
                {
                    //save file
                    mystream.Close();
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a GA file";
            saveFile.Filter = "aop file(*.aop)|*.aop|All files(*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((mystream = saveFile.OpenFile()) != null)
                {
                    //save file
                    mystream.Close();
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dataGridViewJM.Columns.Clear();
            dataGridViewJM.Rows.Clear();
            job.NumberOfJobs = Convert.ToInt16(comboBoxJobNumber.Text);
            double min = Convert.ToDouble(txtMin.Text);
            double max = Convert.ToDouble(txtMax.Text);
            //List<DataGridTextBoxColumn> machines = new List<DataGridTextBoxColumn>();
            dataGridViewJM.Columns.Add("J/M", "Jobs/Machines");
            dataGridViewJM.Rows.Add(job.NumberOfJobs - 1);
            job.SetupTime = new double[job.NumberOfJobs, job.NumberOfJobs + 1];
            for (int i = 0; i < job.NumberOfJobs; i++)
            {  
                dataGridViewJM.Columns.Add("m", "M" + (i+1));
                dataGridViewJM.Rows[i].Cells[0].Value = "J" + (i + 1);
            }
            for (int i = 0; i < job.NumberOfJobs; i++) //rows
            {
                for (int j = 1; j < job.NumberOfJobs + 1; j++) //columns
                {
                    Random rand = new Random(Guid.NewGuid().GetHashCode());
                    double r = min + (max - min) * rand.NextDouble();
                    dataGridViewJM.Rows[i].Cells[j].Value = Math.Round(r,3);
                    job.SetupTime[i, j] = Math.Round(r, 3);
                    if ((i + 1) == j)
                    {
                        dataGridViewJM.Rows[i].Cells[j].Value = 0;
                        job.SetupTime[i, j] = 0;
                    }
                }
                btnReset.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listBoxBestObj.Items.Clear();
            listBoxPopulation.Items.Clear();
            listBoxHardestConstraint.Items.Clear();
            btnRun.Enabled = true;
            btnOneIteration.Enabled = true;
            toolStripStatusLabel1.Text = "After Initialization";
            
            job.PopulationSize = Convert.ToInt32(txtPopulationSize.Text);
            job.PenaltyFactor = Convert.ToDouble(txtPenalty.Text);
            //binary
            job.Reset();
            for (int i = 0; i < job.PopulationSize; i++)
            {
                string s = "P" + (i + 1).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r*job.NumberOfJobs+c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            //輸出
            txtBestObj.Text = job.SoFarTheBestObj.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s1 = "";
                for (int c = 0; c < job.NumberOfJobs; c++)
                    s1 += job.SoFarTheBestSol[r * job.NumberOfJobs + c] + " ";
                listBoxBestObj.Items.Add(s1);
            }
            txtShortestTime.Text = job.ShortestTime.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s = "Row " + (r+1) + ": " + job.Violation_rows[r];
                listBoxHardestConstraint.Items.Add(s);
            }
            for (int c = 0; c < job.NumberOfJobs; c++)
            {
                string s = "Col " + (c+1) + ": " + job.Violation_cols[c];
                listBoxHardestConstraint.Items.Add(s);
            }
        }

        private void btnOneIteration_Click(object sender, EventArgs e)
        {
            job.CrossoverRate = Convert.ToDouble(txtCrossoverRate.Text);
            job.MutationRate = Convert.ToDouble(txtMutationRate.Text);
            toolStripStatusLabel1.Text = "After Mutation Operation";
            toolStripStatusLabel2.Text = "Iteration: " + job.IteCount;
            listBoxPopulation.Items.Clear();
            listBoxBestObj.Items.Clear();
            listBoxHardestConstraint.Items.Clear();
            chart1.Series[0] = job.averageLine;
            chart1.Series[2] = job.soFarTheBestLine;
            if (comboBoxBinaryCrossover.SelectedIndex == 0)
                job.crossOverType = jobAssignmentGA.BinaryCrossOverMode.OnePointCut;
            if (comboBoxBinaryCrossover.SelectedIndex == 1)
                job.crossOverType = jobAssignmentGA.BinaryCrossOverMode.TwoPointCut;
            for (int i = 0; i < job.PopulationSize; i++)
            {
                string s = "P" + (i + 1).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            job.runOneInteration();
            //crossover加進LISTBOX
            string blank = "\n";
            listBoxPopulation.Items.Add(blank);
            for (int i = job.PopulationSize; i < job.PopulationSize+job.CrossSize; i++)
            {
                string s = "C" + (i + 1).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            listBoxPopulation.Items.Add(blank);
            //mutation-> listbox
            for (int i = job.PopulationSize * 2; i < job.PopulationSize*2 + job.MutationSize; i++)
            {
                string s = "M" + (i + 1 - (job.PopulationSize - job.CrossSize)).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            //輸出
            txtBestObj.Text = job.SoFarTheBestObj.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s1 = "";
                for (int c = 0; c < job.NumberOfJobs; c++)
                    s1 += job.SoFarTheBestSol[r * job.NumberOfJobs + c] + " ";
                listBoxBestObj.Items.Add(s1);
            }
            txtShortestTime.Text = job.ShortestTime.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s = "Row " + (r + 1) + ": " + job.Violation_rows[r];
                listBoxHardestConstraint.Items.Add(s);
            }
            for (int c = 0; c < job.NumberOfJobs; c++)
            {
                string s = "Col " + (c + 1) + ": " + job.Violation_cols[c];
                listBoxHardestConstraint.Items.Add(s);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            job.CrossoverRate = Convert.ToDouble(txtCrossoverRate.Text);
            job.MutationRate = Convert.ToDouble(txtMutationRate.Text);
            job.IterationLimilt = Convert.ToInt32(txtInterationLimit.Text);  
            listBoxPopulation.Items.Clear();
            listBoxBestObj.Items.Clear();
            listBoxHardestConstraint.Items.Clear();
            if (comboBoxBinaryCrossover.SelectedIndex == 0)
                job.crossOverType = jobAssignmentGA.BinaryCrossOverMode.OnePointCut;
            if (comboBoxBinaryCrossover.SelectedIndex == 1)
                job.crossOverType = jobAssignmentGA.BinaryCrossOverMode.TwoPointCut;
            chart1.Series[0] = job.averageLine;
            chart1.Series[2] = job.soFarTheBestLine;

            job.runToEND();
           
            for (int i = 0; i < job.PopulationSize; i++)
            {
                string s = "P" + (i + 1).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            //crossover加進LISTBOX
            string blank = "\n";
            listBoxPopulation.Items.Add(blank);
            toolStripStatusLabel1.Text = "Before Crossover Operation";
            for (int i = job.PopulationSize; i < job.PopulationSize + job.CrossSize; i++)
            {
                string s = "C" + (i + 1).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            toolStripStatusLabel1.Text = "After Crossover Operation";
            listBoxPopulation.Items.Add(blank);
            //mutation-> listbox
            toolStripStatusLabel1.Text = "Before Mutation Operation";
            for (int i = job.PopulationSize * 2; i < job.PopulationSize * 2 + job.MutationSize; i++)
            {
                string s = "M" + (i + 1-(job.PopulationSize-job.CrossSize)).ToString("000") + "  ";
                for (int r = 0; r < job.NumberOfJobs; r++)
                {
                    s += " ";
                    for (int c = 0; c < job.NumberOfJobs; c++)
                        s += job.Chromesomes[i][r * job.NumberOfJobs + c] + " ";
                }
                s += "  obj: " + job.Objectives[i];
                listBoxPopulation.Items.Add(s);
            }
            //輸出
            txtBestObj.Text = job.SoFarTheBestObj.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s1 = "";
                for (int c = 0; c < job.NumberOfJobs; c++)
                    s1 += job.SoFarTheBestSol[r * job.NumberOfJobs + c] + " ";
                listBoxBestObj.Items.Add(s1);
            }
            txtShortestTime.Text = job.ShortestTime.ToString();
            for (int r = 0; r < job.NumberOfJobs; r++)
            {
                string s = "Row " + (r + 1) + ": " + job.Violation_rows[r];
                listBoxHardestConstraint.Items.Add(s);
            }
            for (int c = 0; c < job.NumberOfJobs; c++)
            {
                string s = "Col " + (c + 1) + ": " + job.Violation_cols[c];
                listBoxHardestConstraint.Items.Add(s);
            }
            toolStripStatusLabel1.Text = "After Mutation Operation";
            toolStripStatusLabel2.Text = "Iteration: " + job.IteCount;
        }
    }
}
