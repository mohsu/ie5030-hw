namespace R03546012許芸瑄Ass10
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.labComputationalResults = new System.Windows.Forms.Label();
            this.labNumberOFFunctionCalls = new System.Windows.Forms.Label();
            this.txtNumberOfFunctionCalls = new System.Windows.Forms.TextBox();
            this.txtAtIteration = new System.Windows.Forms.TextBox();
            this.labAtIteration = new System.Windows.Forms.Label();
            this.txtSoFarTheBest = new System.Windows.Forms.TextBox();
            this.labIterationID = new System.Windows.Forms.Label();
            this.txtIterationID = new System.Windows.Forms.TextBox();
            this.labBestObjsoFar = new System.Windows.Forms.Label();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.points3D1 = new Steema.TeeChart.Styles.Points3D();
            this.surface1 = new Steema.TeeChart.Styles.Surface();
            this.chartController1 = new Steema.TeeChart.ChartController();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProblemInfo = new System.Windows.Forms.TabPage();
            this.tabSolEvo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownNumberOfSolutionAgents = new System.Windows.Forms.NumericUpDown();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.checkBoxNumberOfSolutionAgent = new System.Windows.Forms.CheckBox();
            this.btnOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxUserInput = new System.Windows.Forms.GroupBox();
            this.numericUpDownEvalutionCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEvalutionCounts = new System.Windows.Forms.CheckBox();
            this.numericUpDownNoImprovement = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNoImprovement = new System.Windows.Forms.CheckBox();
            this.numericUpDownIterationLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIterationLimit = new System.Windows.Forms.CheckBox();
            this.numericUpDownFrictionFactor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSocialFactor = new System.Windows.Forms.NumericUpDown();
            this.labSocialFactor = new System.Windows.Forms.Label();
            this.numericUpDownSelfFactor = new System.Windows.Forms.NumericUpDown();
            this.labSelfFactor = new System.Windows.Forms.Label();
            this.sofarthebest = new Steema.TeeChart.Styles.Line();
            this.Iterationbest = new Steema.TeeChart.Styles.Line();
            this.Average = new Steema.TeeChart.Styles.Line();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSolEvo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSolutionAgents)).BeginInit();
            this.groupBoxUserInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvalutionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoImprovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrictionFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSocialFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelfFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenABenchMark);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1359, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.OpenABenchMark);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1359, 526);
            this.splitContainer1.SplitterDistance = 939;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tChart1);
            this.splitContainer3.Panel2.Controls.Add(this.chartController1);
            this.splitContainer3.Size = new System.Drawing.Size(939, 526);
            this.splitContainer3.SplitterDistance = 257;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tChart2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.labComputationalResults);
            this.splitContainer4.Panel2.Controls.Add(this.labNumberOFFunctionCalls);
            this.splitContainer4.Panel2.Controls.Add(this.txtNumberOfFunctionCalls);
            this.splitContainer4.Panel2.Controls.Add(this.txtAtIteration);
            this.splitContainer4.Panel2.Controls.Add(this.labAtIteration);
            this.splitContainer4.Panel2.Controls.Add(this.txtSoFarTheBest);
            this.splitContainer4.Panel2.Controls.Add(this.labIterationID);
            this.splitContainer4.Panel2.Controls.Add(this.txtIterationID);
            this.splitContainer4.Panel2.Controls.Add(this.labBestObjsoFar);
            this.splitContainer4.Size = new System.Drawing.Size(939, 257);
            this.splitContainer4.SplitterDistance = 665;
            this.splitContainer4.TabIndex = 0;
            // 
            // labComputationalResults
            // 
            this.labComputationalResults.AutoSize = true;
            this.labComputationalResults.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComputationalResults.Location = new System.Drawing.Point(3, 26);
            this.labComputationalResults.Name = "labComputationalResults";
            this.labComputationalResults.Size = new System.Drawing.Size(195, 18);
            this.labComputationalResults.TabIndex = 31;
            this.labComputationalResults.Text = "Computational Results";
            // 
            // labNumberOFFunctionCalls
            // 
            this.labNumberOFFunctionCalls.AutoSize = true;
            this.labNumberOFFunctionCalls.ForeColor = System.Drawing.Color.Sienna;
            this.labNumberOFFunctionCalls.Location = new System.Drawing.Point(3, 100);
            this.labNumberOFFunctionCalls.Name = "labNumberOFFunctionCalls";
            this.labNumberOFFunctionCalls.Size = new System.Drawing.Size(163, 14);
            this.labNumberOFFunctionCalls.TabIndex = 30;
            this.labNumberOFFunctionCalls.Text = "Number of Function Calls";
            // 
            // txtNumberOfFunctionCalls
            // 
            this.txtNumberOfFunctionCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfFunctionCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumberOfFunctionCalls.Enabled = false;
            this.txtNumberOfFunctionCalls.Location = new System.Drawing.Point(181, 96);
            this.txtNumberOfFunctionCalls.Name = "txtNumberOfFunctionCalls";
            this.txtNumberOfFunctionCalls.Size = new System.Drawing.Size(77, 22);
            this.txtNumberOfFunctionCalls.TabIndex = 29;
            this.txtNumberOfFunctionCalls.Text = "0";
            // 
            // txtAtIteration
            // 
            this.txtAtIteration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAtIteration.Enabled = false;
            this.txtAtIteration.Location = new System.Drawing.Point(181, 166);
            this.txtAtIteration.Name = "txtAtIteration";
            this.txtAtIteration.Size = new System.Drawing.Size(77, 22);
            this.txtAtIteration.TabIndex = 28;
            this.txtAtIteration.Text = "0";
            // 
            // labAtIteration
            // 
            this.labAtIteration.AutoSize = true;
            this.labAtIteration.ForeColor = System.Drawing.Color.Sienna;
            this.labAtIteration.Location = new System.Drawing.Point(59, 169);
            this.labAtIteration.Name = "labAtIteration";
            this.labAtIteration.Size = new System.Drawing.Size(79, 14);
            this.labAtIteration.TabIndex = 27;
            this.labAtIteration.Text = "At Iteration";
            // 
            // txtSoFarTheBest
            // 
            this.txtSoFarTheBest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoFarTheBest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoFarTheBest.Enabled = false;
            this.txtSoFarTheBest.Location = new System.Drawing.Point(181, 136);
            this.txtSoFarTheBest.Name = "txtSoFarTheBest";
            this.txtSoFarTheBest.Size = new System.Drawing.Size(77, 22);
            this.txtSoFarTheBest.TabIndex = 26;
            // 
            // labIterationID
            // 
            this.labIterationID.AutoSize = true;
            this.labIterationID.ForeColor = System.Drawing.Color.Sienna;
            this.labIterationID.Location = new System.Drawing.Point(3, 62);
            this.labIterationID.Name = "labIterationID";
            this.labIterationID.Size = new System.Drawing.Size(80, 14);
            this.labIterationID.TabIndex = 25;
            this.labIterationID.Text = "Iteration ID";
            // 
            // txtIterationID
            // 
            this.txtIterationID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIterationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIterationID.Enabled = false;
            this.txtIterationID.Location = new System.Drawing.Point(181, 59);
            this.txtIterationID.Name = "txtIterationID";
            this.txtIterationID.Size = new System.Drawing.Size(77, 22);
            this.txtIterationID.TabIndex = 24;
            this.txtIterationID.Text = "0";
            // 
            // labBestObjsoFar
            // 
            this.labBestObjsoFar.AutoSize = true;
            this.labBestObjsoFar.ForeColor = System.Drawing.Color.Sienna;
            this.labBestObjsoFar.Location = new System.Drawing.Point(3, 139);
            this.labBestObjsoFar.Name = "labBestObjsoFar";
            this.labBestObjsoFar.Size = new System.Drawing.Size(136, 14);
            this.labBestObjsoFar.TabIndex = 23;
            this.labBestObjsoFar.Text = "Best objective so far";
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Caption = "x";
            this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "x"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Caption = "y";
            this.tChart1.Axes.Depth.Title.Lines = new string[] {
        "y"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Caption = "objective";
            this.tChart1.Axes.Left.Title.Lines = new string[] {
        "objective"};
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tChart1.Header.AdjustFrame = false;
            this.tChart1.Header.Lines = new string[] {
        ""};
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(24, 0);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.points3D1);
            this.tChart1.Series.Add(this.surface1);
            this.tChart1.Size = new System.Drawing.Size(915, 265);
            this.tChart1.TabIndex = 2;
            // 
            // points3D1
            // 
            this.points3D1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.points3D1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3D1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.points3D1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.points3D1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.points3D1.Pointer.SizeDouble = 0D;
            this.points3D1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points3D1.Title = "point3D1";
            // 
            // 
            // 
            this.points3D1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.points3D1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.points3D1.ZValues.DataMember = "Z";
            // 
            // surface1
            // 
            // 
            // 
            // 
            this.surface1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.surface1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.surface1.ColorEach = false;
            this.surface1.PaletteMin = 0D;
            this.surface1.PaletteStep = 0D;
            this.surface1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            this.surface1.Title = "surface1";
            // 
            // 
            // 
            this.surface1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.surface1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.surface1.ZValues.DataMember = "Z";
            // 
            // chartController1
            // 
            this.chartController1.AutoSize = false;
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.tChart1;
            this.chartController1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 0);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(24, 265);
            this.chartController1.TabIndex = 1;
            this.chartController1.Text = "chartController1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProblemInfo);
            this.tabControl1.Controls.Add(this.tabSolEvo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProblemInfo
            // 
            this.tabProblemInfo.BackColor = System.Drawing.Color.Gray;
            this.tabProblemInfo.Location = new System.Drawing.Point(4, 23);
            this.tabProblemInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProblemInfo.Name = "tabProblemInfo";
            this.tabProblemInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProblemInfo.Size = new System.Drawing.Size(407, 499);
            this.tabProblemInfo.TabIndex = 0;
            this.tabProblemInfo.Text = "Problem Info";
            // 
            // tabSolEvo
            // 
            this.tabSolEvo.Controls.Add(this.splitContainer2);
            this.tabSolEvo.Location = new System.Drawing.Point(4, 23);
            this.tabSolEvo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSolEvo.Name = "tabSolEvo";
            this.tabSolEvo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabSolEvo.Size = new System.Drawing.Size(407, 499);
            this.tabSolEvo.TabIndex = 1;
            this.tabSolEvo.Text = "Solution Evolution";
            this.tabSolEvo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownNumberOfSolutionAgents);
            this.splitContainer2.Panel1.Controls.Add(this.btnRunToEnd);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxNumberOfSolutionAgent);
            this.splitContainer2.Panel1.Controls.Add(this.btnOneIteration);
            this.splitContainer2.Panel1.Controls.Add(this.btnReset);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxUserInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownFrictionFactor);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownSocialFactor);
            this.splitContainer2.Panel2.Controls.Add(this.labSocialFactor);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownSelfFactor);
            this.splitContainer2.Panel2.Controls.Add(this.labSelfFactor);
            this.splitContainer2.Size = new System.Drawing.Size(399, 493);
            this.splitContainer2.SplitterDistance = 345;
            this.splitContainer2.TabIndex = 0;
            // 
            // numericUpDownNumberOfSolutionAgents
            // 
            this.numericUpDownNumberOfSolutionAgents.Location = new System.Drawing.Point(217, 198);
            this.numericUpDownNumberOfSolutionAgents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNumberOfSolutionAgents.Name = "numericUpDownNumberOfSolutionAgents";
            this.numericUpDownNumberOfSolutionAgents.Size = new System.Drawing.Size(175, 22);
            this.numericUpDownNumberOfSolutionAgents.TabIndex = 11;
            this.numericUpDownNumberOfSolutionAgents.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Location = new System.Drawing.Point(266, 141);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(126, 37);
            this.btnRunToEnd.TabIndex = 8;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // checkBoxNumberOfSolutionAgent
            // 
            this.checkBoxNumberOfSolutionAgent.AutoSize = true;
            this.checkBoxNumberOfSolutionAgent.Location = new System.Drawing.Point(15, 200);
            this.checkBoxNumberOfSolutionAgent.Name = "checkBoxNumberOfSolutionAgent";
            this.checkBoxNumberOfSolutionAgent.Size = new System.Drawing.Size(196, 18);
            this.checkBoxNumberOfSolutionAgent.TabIndex = 10;
            this.checkBoxNumberOfSolutionAgent.Text = "Number Of Solution Agents";
            this.checkBoxNumberOfSolutionAgent.UseVisualStyleBackColor = true;
            // 
            // btnOneIteration
            // 
            this.btnOneIteration.Location = new System.Drawing.Point(120, 141);
            this.btnOneIteration.Name = "btnOneIteration";
            this.btnOneIteration.Size = new System.Drawing.Size(140, 37);
            this.btnOneIteration.TabIndex = 7;
            this.btnOneIteration.Text = "One Iteration";
            this.btnOneIteration.UseVisualStyleBackColor = true;
            this.btnOneIteration.Click += new System.EventHandler(this.btnOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBoxUserInput
            // 
            this.groupBoxUserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUserInput.Controls.Add(this.numericUpDownEvalutionCount);
            this.groupBoxUserInput.Controls.Add(this.checkBoxEvalutionCounts);
            this.groupBoxUserInput.Controls.Add(this.numericUpDownNoImprovement);
            this.groupBoxUserInput.Controls.Add(this.checkBoxNoImprovement);
            this.groupBoxUserInput.Controls.Add(this.numericUpDownIterationLimit);
            this.groupBoxUserInput.Controls.Add(this.checkBoxIterationLimit);
            this.groupBoxUserInput.Location = new System.Drawing.Point(8, 3);
            this.groupBoxUserInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUserInput.Name = "groupBoxUserInput";
            this.groupBoxUserInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUserInput.Size = new System.Drawing.Size(386, 119);
            this.groupBoxUserInput.TabIndex = 5;
            this.groupBoxUserInput.TabStop = false;
            this.groupBoxUserInput.Text = "Stop Conditions";
            // 
            // numericUpDownEvalutionCount
            // 
            this.numericUpDownEvalutionCount.Location = new System.Drawing.Point(146, 73);
            this.numericUpDownEvalutionCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownEvalutionCount.Name = "numericUpDownEvalutionCount";
            this.numericUpDownEvalutionCount.Size = new System.Drawing.Size(237, 22);
            this.numericUpDownEvalutionCount.TabIndex = 9;
            this.numericUpDownEvalutionCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // checkBoxEvalutionCounts
            // 
            this.checkBoxEvalutionCounts.AutoSize = true;
            this.checkBoxEvalutionCounts.Location = new System.Drawing.Point(7, 74);
            this.checkBoxEvalutionCounts.Name = "checkBoxEvalutionCounts";
            this.checkBoxEvalutionCounts.Size = new System.Drawing.Size(133, 18);
            this.checkBoxEvalutionCounts.TabIndex = 8;
            this.checkBoxEvalutionCounts.Text = "Evalution Counts";
            this.checkBoxEvalutionCounts.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNoImprovement
            // 
            this.numericUpDownNoImprovement.Location = new System.Drawing.Point(196, 46);
            this.numericUpDownNoImprovement.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNoImprovement.Name = "numericUpDownNoImprovement";
            this.numericUpDownNoImprovement.Size = new System.Drawing.Size(187, 22);
            this.numericUpDownNoImprovement.TabIndex = 7;
            this.numericUpDownNoImprovement.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxNoImprovement
            // 
            this.checkBoxNoImprovement.AutoSize = true;
            this.checkBoxNoImprovement.Location = new System.Drawing.Point(7, 47);
            this.checkBoxNoImprovement.Name = "checkBoxNoImprovement";
            this.checkBoxNoImprovement.Size = new System.Drawing.Size(190, 18);
            this.checkBoxNoImprovement.TabIndex = 6;
            this.checkBoxNoImprovement.Text = "No Improvement Iteration";
            this.checkBoxNoImprovement.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIterationLimit
            // 
            this.numericUpDownIterationLimit.Location = new System.Drawing.Point(128, 18);
            this.numericUpDownIterationLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIterationLimit.Name = "numericUpDownIterationLimit";
            this.numericUpDownIterationLimit.Size = new System.Drawing.Size(255, 22);
            this.numericUpDownIterationLimit.TabIndex = 4;
            this.numericUpDownIterationLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxIterationLimit
            // 
            this.checkBoxIterationLimit.AutoSize = true;
            this.checkBoxIterationLimit.Checked = true;
            this.checkBoxIterationLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIterationLimit.Location = new System.Drawing.Point(8, 22);
            this.checkBoxIterationLimit.Name = "checkBoxIterationLimit";
            this.checkBoxIterationLimit.Size = new System.Drawing.Size(114, 18);
            this.checkBoxIterationLimit.TabIndex = 0;
            this.checkBoxIterationLimit.Text = "Iteration Limit";
            this.checkBoxIterationLimit.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFrictionFactor
            // 
            this.numericUpDownFrictionFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownFrictionFactor.DecimalPlaces = 2;
            this.numericUpDownFrictionFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownFrictionFactor.Location = new System.Drawing.Point(106, 13);
            this.numericUpDownFrictionFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFrictionFactor.Name = "numericUpDownFrictionFactor";
            this.numericUpDownFrictionFactor.Size = new System.Drawing.Size(285, 22);
            this.numericUpDownFrictionFactor.TabIndex = 14;
            this.numericUpDownFrictionFactor.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Friction Factor";
            // 
            // numericUpDownSocialFactor
            // 
            this.numericUpDownSocialFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownSocialFactor.DecimalPlaces = 2;
            this.numericUpDownSocialFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSocialFactor.Location = new System.Drawing.Point(97, 78);
            this.numericUpDownSocialFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSocialFactor.Name = "numericUpDownSocialFactor";
            this.numericUpDownSocialFactor.Size = new System.Drawing.Size(294, 22);
            this.numericUpDownSocialFactor.TabIndex = 12;
            this.numericUpDownSocialFactor.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // labSocialFactor
            // 
            this.labSocialFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labSocialFactor.AutoSize = true;
            this.labSocialFactor.Location = new System.Drawing.Point(5, 80);
            this.labSocialFactor.Name = "labSocialFactor";
            this.labSocialFactor.Size = new System.Drawing.Size(86, 14);
            this.labSocialFactor.TabIndex = 11;
            this.labSocialFactor.Text = "Social Factor";
            // 
            // numericUpDownSelfFactor
            // 
            this.numericUpDownSelfFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownSelfFactor.DecimalPlaces = 2;
            this.numericUpDownSelfFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSelfFactor.Location = new System.Drawing.Point(84, 45);
            this.numericUpDownSelfFactor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSelfFactor.Name = "numericUpDownSelfFactor";
            this.numericUpDownSelfFactor.Size = new System.Drawing.Size(307, 22);
            this.numericUpDownSelfFactor.TabIndex = 10;
            this.numericUpDownSelfFactor.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // labSelfFactor
            // 
            this.labSelfFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labSelfFactor.AutoSize = true;
            this.labSelfFactor.Location = new System.Drawing.Point(5, 47);
            this.labSelfFactor.Name = "labSelfFactor";
            this.labSelfFactor.Size = new System.Drawing.Size(73, 14);
            this.labSelfFactor.TabIndex = 0;
            this.labSelfFactor.Text = "Self Factor";
            // 
            // sofarthebest
            // 
            // 
            // 
            // 
            this.sofarthebest.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.sofarthebest.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.sofarthebest.ColorEach = false;
            // 
            // 
            // 
            this.sofarthebest.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
            this.sofarthebest.LinePen.Width = 3;
            // 
            // 
            // 
            this.sofarthebest.Pointer.SizeDouble = 0D;
            this.sofarthebest.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.sofarthebest.SeriesData = resources.GetString("sofarthebest.SeriesData");
            this.sofarthebest.Title = "So far the best";
            // 
            // 
            // 
            this.sofarthebest.XValues.DataMember = "X";
            this.sofarthebest.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.sofarthebest.YValues.DataMember = "Y";
            // 
            // Iterationbest
            // 
            // 
            // 
            // 
            this.Iterationbest.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.Iterationbest.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.Iterationbest.ColorEach = false;
            // 
            // 
            // 
            this.Iterationbest.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            this.Iterationbest.Pointer.SizeDouble = 0D;
            this.Iterationbest.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.Iterationbest.SeriesData = resources.GetString("Iterationbest.SeriesData");
            this.Iterationbest.Title = "Iteration Best";
            // 
            // 
            // 
            this.Iterationbest.XValues.DataMember = "X";
            this.Iterationbest.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.Iterationbest.YValues.DataMember = "Y";
            // 
            // Average
            // 
            // 
            // 
            // 
            this.Average.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.Average.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.Average.ColorEach = false;
            // 
            // 
            // 
            this.Average.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            // 
            // 
            // 
            this.Average.Pointer.SizeDouble = 0D;
            this.Average.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.Average.SeriesData = resources.GetString("Average.SeriesData");
            this.Average.Title = "Average";
            // 
            // 
            // 
            this.Average.XValues.DataMember = "X";
            this.Average.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.Average.YValues.DataMember = "Y";
            // 
            // tChart2
            // 
            // 
            // 
            // 
            this.tChart2.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Caption = "x";
            this.tChart2.Axes.Bottom.Title.Lines = new string[] {
        "x"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Caption = "y";
            this.tChart2.Axes.Left.Title.Lines = new string[] {
        "y"};
            this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tChart2.Header.Lines = new string[] {
        "Countour"};
            this.tChart2.Header.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // 
            // 
            this.tChart2.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            this.tChart2.Legend.TopLeftPos = 7;
            this.tChart2.Legend.VertMargin = 1;
            this.tChart2.Location = new System.Drawing.Point(0, 0);
            this.tChart2.Name = "tChart2";
            this.tChart2.Series.Add(this.Average);
            this.tChart2.Series.Add(this.Iterationbest);
            this.tChart2.Series.Add(this.sofarthebest);
            this.tChart2.Size = new System.Drawing.Size(665, 257);
            this.tChart2.TabIndex = 1;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 575);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Mainform";
            this.Text = "PSO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSolEvo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfSolutionAgents)).EndInit();
            this.groupBoxUserInput.ResumeLayout(false);
            this.groupBoxUserInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEvalutionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoImprovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrictionFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSocialFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelfFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProblemInfo;
        private System.Windows.Forms.TabPage tabSolEvo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfSolutionAgents;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.CheckBox checkBoxNumberOfSolutionAgent;
        private System.Windows.Forms.Button btnOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxUserInput;
        private System.Windows.Forms.NumericUpDown numericUpDownEvalutionCount;
        private System.Windows.Forms.CheckBox checkBoxEvalutionCounts;
        private System.Windows.Forms.NumericUpDown numericUpDownNoImprovement;
        private System.Windows.Forms.CheckBox checkBoxNoImprovement;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationLimit;
        private System.Windows.Forms.CheckBox checkBoxIterationLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownSocialFactor;
        private System.Windows.Forms.Label labSocialFactor;
        private System.Windows.Forms.NumericUpDown numericUpDownSelfFactor;
        private System.Windows.Forms.Label labSelfFactor;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points3D points3D1;
        private Steema.TeeChart.Styles.Surface surface1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label labComputationalResults;
        private System.Windows.Forms.Label labNumberOFFunctionCalls;
        private System.Windows.Forms.TextBox txtNumberOfFunctionCalls;
        private System.Windows.Forms.TextBox txtAtIteration;
        private System.Windows.Forms.Label labAtIteration;
        private System.Windows.Forms.TextBox txtSoFarTheBest;
        private System.Windows.Forms.Label labIterationID;
        private System.Windows.Forms.TextBox txtIterationID;
        private System.Windows.Forms.Label labBestObjsoFar;
        private System.Windows.Forms.NumericUpDown numericUpDownFrictionFactor;
        private System.Windows.Forms.Label label2;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.Styles.Line Average;
        private Steema.TeeChart.Styles.Line Iterationbest;
        private Steema.TeeChart.Styles.Line sofarthebest;
    }
}

