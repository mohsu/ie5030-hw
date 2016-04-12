namespace R03546012許芸瑄Ass10
{
    partial class COP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COP));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.Average = new Steema.TeeChart.Styles.Line();
            this.sofarthebest = new Steema.TeeChart.Styles.Line();
            this.txtKnownBestObj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labComputationalResults = new System.Windows.Forms.Label();
            this.labNumberOFFunctionCalls = new System.Windows.Forms.Label();
            this.txtNumberOfIterationWithoutImprovement = new System.Windows.Forms.TextBox();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDownNumberOfHM = new System.Windows.Forms.NumericUpDown();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.checkBoxNumberOfHM = new System.Windows.Forms.CheckBox();
            this.btnOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxUserInput = new System.Windows.Forms.GroupBox();
            this.numericUpDownIterationWithoutImprovement = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIterationWithoutImprovement = new System.Windows.Forms.CheckBox();
            this.numericUpDownIterationLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIterationLimit = new System.Windows.Forms.CheckBox();
            this.numericUpDownHMCR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPAR = new System.Windows.Forms.NumericUpDown();
            this.labSelfFactor = new System.Windows.Forms.Label();
            this.checkBoxShowAnimation = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfHM)).BeginInit();
            this.groupBoxUserInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationWithoutImprovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHMCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPAR)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1359, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.OpenABenchMark);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
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
            this.splitContainer1.Size = new System.Drawing.Size(1359, 514);
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
            this.splitContainer3.Size = new System.Drawing.Size(939, 514);
            this.splitContainer3.SplitterDistance = 251;
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
            this.splitContainer4.Panel2.Controls.Add(this.txtKnownBestObj);
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.Controls.Add(this.labComputationalResults);
            this.splitContainer4.Panel2.Controls.Add(this.labNumberOFFunctionCalls);
            this.splitContainer4.Panel2.Controls.Add(this.txtNumberOfIterationWithoutImprovement);
            this.splitContainer4.Panel2.Controls.Add(this.txtSoFarTheBest);
            this.splitContainer4.Panel2.Controls.Add(this.labIterationID);
            this.splitContainer4.Panel2.Controls.Add(this.txtIterationID);
            this.splitContainer4.Panel2.Controls.Add(this.labBestObjsoFar);
            this.splitContainer4.Size = new System.Drawing.Size(939, 251);
            this.splitContainer4.SplitterDistance = 665;
            this.splitContainer4.TabIndex = 0;
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
            this.tChart2.Series.Add(this.sofarthebest);
            this.tChart2.Size = new System.Drawing.Size(665, 251);
            this.tChart2.TabIndex = 1;
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
            // txtKnownBestObj
            // 
            this.txtKnownBestObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKnownBestObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKnownBestObj.Enabled = false;
            this.txtKnownBestObj.Location = new System.Drawing.Point(181, 187);
            this.txtKnownBestObj.Name = "txtKnownBestObj";
            this.txtKnownBestObj.Size = new System.Drawing.Size(77, 22);
            this.txtKnownBestObj.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Known Best Objective";
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
            this.labNumberOFFunctionCalls.Size = new System.Drawing.Size(273, 14);
            this.labNumberOFFunctionCalls.TabIndex = 30;
            this.labNumberOFFunctionCalls.Text = "Number of Iteration Without Improvement";
            // 
            // txtNumberOfIterationWithoutImprovement
            // 
            this.txtNumberOfIterationWithoutImprovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfIterationWithoutImprovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumberOfIterationWithoutImprovement.Enabled = false;
            this.txtNumberOfIterationWithoutImprovement.Location = new System.Drawing.Point(181, 117);
            this.txtNumberOfIterationWithoutImprovement.Name = "txtNumberOfIterationWithoutImprovement";
            this.txtNumberOfIterationWithoutImprovement.Size = new System.Drawing.Size(77, 22);
            this.txtNumberOfIterationWithoutImprovement.TabIndex = 29;
            this.txtNumberOfIterationWithoutImprovement.Text = "0";
            // 
            // txtSoFarTheBest
            // 
            this.txtSoFarTheBest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoFarTheBest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoFarTheBest.Enabled = false;
            this.txtSoFarTheBest.Location = new System.Drawing.Point(181, 155);
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
            this.labBestObjsoFar.Location = new System.Drawing.Point(3, 158);
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
            this.tChart1.Size = new System.Drawing.Size(915, 259);
            this.tChart1.TabIndex = 2;
            // 
            // points3D1
            // 
            this.points3D1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points3D1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3D1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.chartController1.Size = new System.Drawing.Size(24, 259);
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
            this.tabControl1.Size = new System.Drawing.Size(415, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProblemInfo
            // 
            this.tabProblemInfo.BackColor = System.Drawing.Color.Gray;
            this.tabProblemInfo.Location = new System.Drawing.Point(4, 23);
            this.tabProblemInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProblemInfo.Name = "tabProblemInfo";
            this.tabProblemInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabProblemInfo.Size = new System.Drawing.Size(407, 487);
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
            this.tabSolEvo.Size = new System.Drawing.Size(407, 487);
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
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxShowAnimation);
            this.splitContainer2.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownNumberOfHM);
            this.splitContainer2.Panel1.Controls.Add(this.btnRunToEnd);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxNumberOfHM);
            this.splitContainer2.Panel1.Controls.Add(this.btnOneIteration);
            this.splitContainer2.Panel1.Controls.Add(this.btnReset);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxUserInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownHMCR);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.numericUpDownPAR);
            this.splitContainer2.Panel2.Controls.Add(this.labSelfFactor);
            this.splitContainer2.Size = new System.Drawing.Size(399, 481);
            this.splitContainer2.SplitterDistance = 334;
            this.splitContainer2.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(383, 21);
            this.progressBar1.TabIndex = 12;
            // 
            // numericUpDownNumberOfHM
            // 
            this.numericUpDownNumberOfHM.Location = new System.Drawing.Point(232, 205);
            this.numericUpDownNumberOfHM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownNumberOfHM.Name = "numericUpDownNumberOfHM";
            this.numericUpDownNumberOfHM.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownNumberOfHM.TabIndex = 11;
            this.numericUpDownNumberOfHM.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Location = new System.Drawing.Point(266, 159);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(126, 37);
            this.btnRunToEnd.TabIndex = 8;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // checkBoxNumberOfHM
            // 
            this.checkBoxNumberOfHM.AutoSize = true;
            this.checkBoxNumberOfHM.Location = new System.Drawing.Point(15, 207);
            this.checkBoxNumberOfHM.Name = "checkBoxNumberOfHM";
            this.checkBoxNumberOfHM.Size = new System.Drawing.Size(217, 18);
            this.checkBoxNumberOfHM.TabIndex = 10;
            this.checkBoxNumberOfHM.Text = "Number Of Harmony Memories";
            this.checkBoxNumberOfHM.UseVisualStyleBackColor = true;
            // 
            // btnOneIteration
            // 
            this.btnOneIteration.Location = new System.Drawing.Point(120, 159);
            this.btnOneIteration.Name = "btnOneIteration";
            this.btnOneIteration.Size = new System.Drawing.Size(140, 37);
            this.btnOneIteration.TabIndex = 7;
            this.btnOneIteration.Text = "One Iteration";
            this.btnOneIteration.UseVisualStyleBackColor = true;
            this.btnOneIteration.Click += new System.EventHandler(this.btnOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 159);
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
            this.groupBoxUserInput.Controls.Add(this.numericUpDownIterationWithoutImprovement);
            this.groupBoxUserInput.Controls.Add(this.checkBoxIterationWithoutImprovement);
            this.groupBoxUserInput.Controls.Add(this.numericUpDownIterationLimit);
            this.groupBoxUserInput.Controls.Add(this.checkBoxIterationLimit);
            this.groupBoxUserInput.Location = new System.Drawing.Point(8, 3);
            this.groupBoxUserInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUserInput.Name = "groupBoxUserInput";
            this.groupBoxUserInput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUserInput.Size = new System.Drawing.Size(386, 85);
            this.groupBoxUserInput.TabIndex = 5;
            this.groupBoxUserInput.TabStop = false;
            this.groupBoxUserInput.Text = "Stop Conditions";
            // 
            // numericUpDownIterationWithoutImprovement
            // 
            this.numericUpDownIterationWithoutImprovement.Location = new System.Drawing.Point(236, 45);
            this.numericUpDownIterationWithoutImprovement.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownIterationWithoutImprovement.Name = "numericUpDownIterationWithoutImprovement";
            this.numericUpDownIterationWithoutImprovement.Size = new System.Drawing.Size(147, 22);
            this.numericUpDownIterationWithoutImprovement.TabIndex = 9;
            this.numericUpDownIterationWithoutImprovement.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // checkBoxIterationWithoutImprovement
            // 
            this.checkBoxIterationWithoutImprovement.AutoSize = true;
            this.checkBoxIterationWithoutImprovement.Location = new System.Drawing.Point(7, 46);
            this.checkBoxIterationWithoutImprovement.Name = "checkBoxIterationWithoutImprovement";
            this.checkBoxIterationWithoutImprovement.Size = new System.Drawing.Size(223, 18);
            this.checkBoxIterationWithoutImprovement.TabIndex = 8;
            this.checkBoxIterationWithoutImprovement.Text = "Iteration Without Improvement";
            this.checkBoxIterationWithoutImprovement.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIterationLimit
            // 
            this.numericUpDownIterationLimit.Location = new System.Drawing.Point(128, 18);
            this.numericUpDownIterationLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIterationLimit.Name = "numericUpDownIterationLimit";
            this.numericUpDownIterationLimit.Size = new System.Drawing.Size(255, 22);
            this.numericUpDownIterationLimit.TabIndex = 4;
            this.numericUpDownIterationLimit.Value = new decimal(new int[] {
            10000,
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
            // numericUpDownHMCR
            // 
            this.numericUpDownHMCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownHMCR.DecimalPlaces = 2;
            this.numericUpDownHMCR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownHMCR.Location = new System.Drawing.Point(84, 12);
            this.numericUpDownHMCR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHMCR.Name = "numericUpDownHMCR";
            this.numericUpDownHMCR.Size = new System.Drawing.Size(307, 22);
            this.numericUpDownHMCR.TabIndex = 14;
            this.numericUpDownHMCR.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "HMCR";
            // 
            // numericUpDownPAR
            // 
            this.numericUpDownPAR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownPAR.DecimalPlaces = 2;
            this.numericUpDownPAR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPAR.Location = new System.Drawing.Point(84, 44);
            this.numericUpDownPAR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPAR.Name = "numericUpDownPAR";
            this.numericUpDownPAR.Size = new System.Drawing.Size(307, 22);
            this.numericUpDownPAR.TabIndex = 10;
            this.numericUpDownPAR.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // labSelfFactor
            // 
            this.labSelfFactor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labSelfFactor.AutoSize = true;
            this.labSelfFactor.Location = new System.Drawing.Point(5, 46);
            this.labSelfFactor.Name = "labSelfFactor";
            this.labSelfFactor.Size = new System.Drawing.Size(31, 14);
            this.labSelfFactor.TabIndex = 0;
            this.labSelfFactor.Text = "PAR";
            // 
            // checkBoxShowAnimation
            // 
            this.checkBoxShowAnimation.AutoSize = true;
            this.checkBoxShowAnimation.Location = new System.Drawing.Point(15, 101);
            this.checkBoxShowAnimation.Name = "checkBoxShowAnimation";
            this.checkBoxShowAnimation.Size = new System.Drawing.Size(127, 18);
            this.checkBoxShowAnimation.TabIndex = 13;
            this.checkBoxShowAnimation.Text = "Show Animation";
            this.checkBoxShowAnimation.UseVisualStyleBackColor = true;
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
            this.Text = "HS";
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfHM)).EndInit();
            this.groupBoxUserInput.ResumeLayout(false);
            this.groupBoxUserInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationWithoutImprovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHMCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPAR)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfHM;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.CheckBox checkBoxNumberOfHM;
        private System.Windows.Forms.Button btnOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxUserInput;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationWithoutImprovement;
        private System.Windows.Forms.CheckBox checkBoxIterationWithoutImprovement;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationLimit;
        private System.Windows.Forms.CheckBox checkBoxIterationLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownPAR;
        private System.Windows.Forms.Label labSelfFactor;
        private Steema.TeeChart.ChartController chartController1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points3D points3D1;
        private Steema.TeeChart.Styles.Surface surface1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label labComputationalResults;
        private System.Windows.Forms.Label labNumberOFFunctionCalls;
        private System.Windows.Forms.TextBox txtNumberOfIterationWithoutImprovement;
        private System.Windows.Forms.TextBox txtSoFarTheBest;
        private System.Windows.Forms.Label labIterationID;
        private System.Windows.Forms.TextBox txtIterationID;
        private System.Windows.Forms.Label labBestObjsoFar;
        private System.Windows.Forms.NumericUpDown numericUpDownHMCR;
        private System.Windows.Forms.Label label2;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.Styles.Line Average;
        private Steema.TeeChart.Styles.Line sofarthebest;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtKnownBestObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShowAnimation;
    }
}

