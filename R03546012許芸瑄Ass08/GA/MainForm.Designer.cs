namespace GA
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Problem = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dataGridViewJM = new System.Windows.Forms.DataGridView();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxJobNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GASettings = new System.Windows.Forms.TabPage();
            this.groupBoxGA = new System.Windows.Forms.GroupBox();
            this.comboBoxMutaion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPermutaionCrossover = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBinaryCrossover = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnPermutation = new System.Windows.Forms.RadioButton();
            this.radiobtnBinary = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtInterationLimit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radioBtnDeterministic = new System.Windows.Forms.RadioButton();
            this.radioBtnStochastic = new System.Windows.Forms.RadioButton();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBestObj = new System.Windows.Forms.TextBox();
            this.listBoxBestObj = new System.Windows.Forms.ListBox();
            this.listBoxHardestConstraint = new System.Windows.Forms.ListBox();
            this.txtShortestTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPopulation = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Problem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJM)).BeginInit();
            this.GASettings.SuspendLayout();
            this.groupBoxGA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripBtnOpen,
            this.toolStripBtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1444, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnNew
            // 
            this.toolStripBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNew.Image")));
            this.toolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Size = new System.Drawing.Size(36, 36);
            this.toolStripBtnNew.Text = "New";
            // 
            // toolStripBtnOpen
            // 
            this.toolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpen.Image")));
            this.toolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpen.Name = "toolStripBtnOpen";
            this.toolStripBtnOpen.Size = new System.Drawing.Size(36, 36);
            this.toolStripBtnOpen.Text = "Open";
            this.toolStripBtnOpen.Click += new System.EventHandler(this.toolStripBtnOpen_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSave.Image")));
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(36, 36);
            this.toolStripBtnSave.Text = "Save";
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Problem);
            this.tabControl1.Controls.Add(this.GASettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 674);
            this.tabControl1.TabIndex = 2;
            // 
            // Problem
            // 
            this.Problem.BackColor = System.Drawing.Color.Thistle;
            this.Problem.Controls.Add(this.btnGenerate);
            this.Problem.Controls.Add(this.dataGridViewJM);
            this.Problem.Controls.Add(this.txtMax);
            this.Problem.Controls.Add(this.txtMin);
            this.Problem.Controls.Add(this.label7);
            this.Problem.Controls.Add(this.label2);
            this.Problem.Controls.Add(this.comboBoxJobNumber);
            this.Problem.Controls.Add(this.label1);
            this.Problem.Location = new System.Drawing.Point(4, 23);
            this.Problem.Name = "Problem";
            this.Problem.Padding = new System.Windows.Forms.Padding(3);
            this.Problem.Size = new System.Drawing.Size(329, 647);
            this.Problem.TabIndex = 0;
            this.Problem.Text = "Problem";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(211, 72);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(83, 41);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridViewJM
            // 
            this.dataGridViewJM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJM.Location = new System.Drawing.Point(6, 133);
            this.dataGridViewJM.Name = "dataGridViewJM";
            this.dataGridViewJM.RowTemplate.Height = 24;
            this.dataGridViewJM.Size = new System.Drawing.Size(311, 204);
            this.dataGridViewJM.TabIndex = 10;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(88, 96);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(57, 22);
            this.txtMax.TabIndex = 9;
            this.txtMax.Text = "10.0";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(88, 57);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(57, 22);
            this.txtMin.TabIndex = 8;
            this.txtMin.Text = "1.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maximum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum";
            // 
            // comboBoxJobNumber
            // 
            this.comboBoxJobNumber.FormattingEnabled = true;
            this.comboBoxJobNumber.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboBoxJobNumber.Location = new System.Drawing.Point(183, 24);
            this.comboBoxJobNumber.Name = "comboBoxJobNumber";
            this.comboBoxJobNumber.Size = new System.Drawing.Size(83, 22);
            this.comboBoxJobNumber.TabIndex = 1;
            this.comboBoxJobNumber.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Jobs/Machines";
            // 
            // GASettings
            // 
            this.GASettings.BackColor = System.Drawing.Color.LightPink;
            this.GASettings.Controls.Add(this.groupBoxGA);
            this.GASettings.Controls.Add(this.btnRun);
            this.GASettings.Controls.Add(this.btnOneIteration);
            this.GASettings.Controls.Add(this.btnReset);
            this.GASettings.Controls.Add(this.txtInterationLimit);
            this.GASettings.Controls.Add(this.label15);
            this.GASettings.Controls.Add(this.radioBtnDeterministic);
            this.GASettings.Controls.Add(this.radioBtnStochastic);
            this.GASettings.Controls.Add(this.txtMutationRate);
            this.GASettings.Controls.Add(this.label14);
            this.GASettings.Controls.Add(this.txtCrossoverRate);
            this.GASettings.Controls.Add(this.label13);
            this.GASettings.Controls.Add(this.txtPopulationSize);
            this.GASettings.Controls.Add(this.label12);
            this.GASettings.Location = new System.Drawing.Point(4, 23);
            this.GASettings.Name = "GASettings";
            this.GASettings.Padding = new System.Windows.Forms.Padding(3);
            this.GASettings.Size = new System.Drawing.Size(329, 647);
            this.GASettings.TabIndex = 1;
            this.GASettings.Text = "GA settings";
            // 
            // groupBoxGA
            // 
            this.groupBoxGA.Controls.Add(this.comboBoxMutaion);
            this.groupBoxGA.Controls.Add(this.label11);
            this.groupBoxGA.Controls.Add(this.comboBoxPermutaionCrossover);
            this.groupBoxGA.Controls.Add(this.label10);
            this.groupBoxGA.Controls.Add(this.txtPenalty);
            this.groupBoxGA.Controls.Add(this.label8);
            this.groupBoxGA.Controls.Add(this.comboBoxBinaryCrossover);
            this.groupBoxGA.Controls.Add(this.label9);
            this.groupBoxGA.Controls.Add(this.radioBtnPermutation);
            this.groupBoxGA.Controls.Add(this.radiobtnBinary);
            this.groupBoxGA.Location = new System.Drawing.Point(17, 17);
            this.groupBoxGA.Name = "groupBoxGA";
            this.groupBoxGA.Size = new System.Drawing.Size(290, 204);
            this.groupBoxGA.TabIndex = 30;
            this.groupBoxGA.TabStop = false;
            this.groupBoxGA.Text = "GA encoding";
            // 
            // comboBoxMutaion
            // 
            this.comboBoxMutaion.FormattingEnabled = true;
            this.comboBoxMutaion.Items.AddRange(new object[] {
            "INVERSE",
            "INSERTION"});
            this.comboBoxMutaion.Location = new System.Drawing.Point(124, 162);
            this.comboBoxMutaion.Name = "comboBoxMutaion";
            this.comboBoxMutaion.Size = new System.Drawing.Size(120, 22);
            this.comboBoxMutaion.TabIndex = 26;
            this.comboBoxMutaion.Text = "INVERSE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mutation";
            // 
            // comboBoxPermutaionCrossover
            // 
            this.comboBoxPermutaionCrossover.FormattingEnabled = true;
            this.comboBoxPermutaionCrossover.Items.AddRange(new object[] {
            "PMX",
            "ORDER"});
            this.comboBoxPermutaionCrossover.Location = new System.Drawing.Point(124, 134);
            this.comboBoxPermutaionCrossover.Name = "comboBoxPermutaionCrossover";
            this.comboBoxPermutaionCrossover.Size = new System.Drawing.Size(120, 22);
            this.comboBoxPermutaionCrossover.TabIndex = 24;
            this.comboBoxPermutaionCrossover.Text = "PMX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 14);
            this.label10.TabIndex = 23;
            this.label10.Text = "Crossover";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(144, 81);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(100, 22);
            this.txtPenalty.TabIndex = 22;
            this.txtPenalty.Text = "100.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Penalty Factor";
            // 
            // comboBoxBinaryCrossover
            // 
            this.comboBoxBinaryCrossover.FormattingEnabled = true;
            this.comboBoxBinaryCrossover.Items.AddRange(new object[] {
            "One-Point Cut",
            "Two-Point Cut"});
            this.comboBoxBinaryCrossover.Location = new System.Drawing.Point(124, 51);
            this.comboBoxBinaryCrossover.Name = "comboBoxBinaryCrossover";
            this.comboBoxBinaryCrossover.Size = new System.Drawing.Size(120, 22);
            this.comboBoxBinaryCrossover.TabIndex = 20;
            this.comboBoxBinaryCrossover.Text = "One-Point Cut";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Crossover";
            // 
            // radioBtnPermutation
            // 
            this.radioBtnPermutation.AutoSize = true;
            this.radioBtnPermutation.Location = new System.Drawing.Point(12, 108);
            this.radioBtnPermutation.Name = "radioBtnPermutation";
            this.radioBtnPermutation.Size = new System.Drawing.Size(102, 18);
            this.radioBtnPermutation.TabIndex = 18;
            this.radioBtnPermutation.Text = "Permutation";
            this.radioBtnPermutation.UseVisualStyleBackColor = true;
            // 
            // radiobtnBinary
            // 
            this.radiobtnBinary.AutoSize = true;
            this.radiobtnBinary.Checked = true;
            this.radiobtnBinary.Location = new System.Drawing.Point(11, 24);
            this.radiobtnBinary.Name = "radiobtnBinary";
            this.radiobtnBinary.Size = new System.Drawing.Size(64, 18);
            this.radiobtnBinary.TabIndex = 17;
            this.radiobtnBinary.TabStop = true;
            this.radiobtnBinary.Text = "Binary";
            this.radiobtnBinary.UseVisualStyleBackColor = true;
            this.radiobtnBinary.CheckedChanged += new System.EventHandler(this.radiobtnBinary_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(230, 489);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(93, 40);
            this.btnRun.TabIndex = 29;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOneIteration
            // 
            this.btnOneIteration.Location = new System.Drawing.Point(108, 489);
            this.btnOneIteration.Name = "btnOneIteration";
            this.btnOneIteration.Size = new System.Drawing.Size(116, 40);
            this.btnOneIteration.TabIndex = 28;
            this.btnOneIteration.Text = "One Iteration";
            this.btnOneIteration.UseVisualStyleBackColor = true;
            this.btnOneIteration.Click += new System.EventHandler(this.btnOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 489);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtInterationLimit
            // 
            this.txtInterationLimit.Location = new System.Drawing.Point(121, 411);
            this.txtInterationLimit.Name = "txtInterationLimit";
            this.txtInterationLimit.Size = new System.Drawing.Size(48, 22);
            this.txtInterationLimit.TabIndex = 26;
            this.txtInterationLimit.Text = "100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Iteration Limit";
            // 
            // radioBtnDeterministic
            // 
            this.radioBtnDeterministic.AutoSize = true;
            this.radioBtnDeterministic.Location = new System.Drawing.Point(9, 366);
            this.radioBtnDeterministic.Name = "radioBtnDeterministic";
            this.radioBtnDeterministic.Size = new System.Drawing.Size(167, 18);
            this.radioBtnDeterministic.TabIndex = 24;
            this.radioBtnDeterministic.Text = "Deterministic Selection";
            this.radioBtnDeterministic.UseVisualStyleBackColor = true;
            // 
            // radioBtnStochastic
            // 
            this.radioBtnStochastic.AutoSize = true;
            this.radioBtnStochastic.Location = new System.Drawing.Point(9, 342);
            this.radioBtnStochastic.Name = "radioBtnStochastic";
            this.radioBtnStochastic.Size = new System.Drawing.Size(150, 18);
            this.radioBtnStochastic.TabIndex = 23;
            this.radioBtnStochastic.Text = "Stochastic Selection";
            this.radioBtnStochastic.UseVisualStyleBackColor = true;
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(121, 283);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(48, 22);
            this.txtMutationRate.TabIndex = 22;
            this.txtMutationRate.Text = "0.5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 14);
            this.label14.TabIndex = 21;
            this.label14.Text = "Mutation Rate";
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Location = new System.Drawing.Point(121, 255);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(48, 22);
            this.txtCrossoverRate.TabIndex = 20;
            this.txtCrossoverRate.Text = "0.8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Crossover Rate";
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(121, 227);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(48, 22);
            this.txtPopulationSize.TabIndex = 18;
            this.txtPopulationSize.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "Population Size";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Best Objective Value";
            // 
            // txtBestObj
            // 
            this.txtBestObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBestObj.Location = new System.Drawing.Point(346, 92);
            this.txtBestObj.Name = "txtBestObj";
            this.txtBestObj.Size = new System.Drawing.Size(189, 22);
            this.txtBestObj.TabIndex = 4;
            // 
            // listBoxBestObj
            // 
            this.listBoxBestObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBestObj.FormattingEnabled = true;
            this.listBoxBestObj.ItemHeight = 14;
            this.listBoxBestObj.Location = new System.Drawing.Point(346, 119);
            this.listBoxBestObj.Name = "listBoxBestObj";
            this.listBoxBestObj.Size = new System.Drawing.Size(189, 116);
            this.listBoxBestObj.TabIndex = 5;
            // 
            // listBoxHardestConstraint
            // 
            this.listBoxHardestConstraint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxHardestConstraint.FormattingEnabled = true;
            this.listBoxHardestConstraint.ItemHeight = 14;
            this.listBoxHardestConstraint.Location = new System.Drawing.Point(346, 315);
            this.listBoxHardestConstraint.Name = "listBoxHardestConstraint";
            this.listBoxHardestConstraint.Size = new System.Drawing.Size(189, 144);
            this.listBoxHardestConstraint.TabIndex = 8;
            // 
            // txtShortestTime
            // 
            this.txtShortestTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortestTime.Location = new System.Drawing.Point(346, 267);
            this.txtShortestTime.Name = "txtShortestTime";
            this.txtShortestTime.Size = new System.Drawing.Size(189, 22);
            this.txtShortestTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shortest Time";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hardest Constraint Violations";
            // 
            // listBoxPopulation
            // 
            this.listBoxPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPopulation.FormattingEnabled = true;
            this.listBoxPopulation.ItemHeight = 14;
            this.listBoxPopulation.Location = new System.Drawing.Point(541, 91);
            this.listBoxPopulation.Name = "listBoxPopulation";
            this.listBoxPopulation.Size = new System.Drawing.Size(891, 368);
            this.listBoxPopulation.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Population";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.PowderBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal;
            this.chart1.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            this.chart1.BorderlineWidth = 3;
            chartArea4.AxisX.Title = "Iteration";
            chartArea4.AxisY.Title = "Objective";
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(346, 465);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Average";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "IterationBest";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "SoFarTheBest";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(1086, 275);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1444, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel1.Text = "After Mutation Operation";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Gold;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "Iteration: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1444, 762);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBoxPopulation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxHardestConstraint);
            this.Controls.Add(this.txtShortestTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxBestObj);
            this.Controls.Add(this.txtBestObj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Gene Algorithm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Problem.ResumeLayout(false);
            this.Problem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJM)).EndInit();
            this.GASettings.ResumeLayout(false);
            this.GASettings.PerformLayout();
            this.groupBoxGA.ResumeLayout(false);
            this.groupBoxGA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpen;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Problem;
        private System.Windows.Forms.DataGridView dataGridViewJM;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxJobNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage GASettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBestObj;
        private System.Windows.Forms.ListBox listBoxBestObj;
        private System.Windows.Forms.ListBox listBoxHardestConstraint;
        private System.Windows.Forms.TextBox txtShortestTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPopulation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtInterationLimit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioBtnDeterministic;
        private System.Windows.Forms.RadioButton radioBtnStochastic;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCrossoverRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxGA;
        private System.Windows.Forms.ComboBox comboBoxMutaion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPermutaionCrossover;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBinaryCrossover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnPermutation;
        private System.Windows.Forms.RadioButton radiobtnBinary;
    }
}

