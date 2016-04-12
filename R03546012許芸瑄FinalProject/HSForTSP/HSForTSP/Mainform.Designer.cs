namespace R03546012許芸瑄Ass09
{
    partial class HSForTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HSForTSP));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ACOSettings = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.GroupBoxStoppingCritia = new System.Windows.Forms.GroupBox();
            this.txtObjLimit = new System.Windows.Forms.TextBox();
            this.txtIterationLimit = new System.Windows.Forms.TextBox();
            this.checkboxObjLimit = new System.Windows.Forms.CheckBox();
            this.checkboxIterationLimit = new System.Windows.Forms.CheckBox();
            this.txtPAR = new System.Windows.Forms.TextBox();
            this.txtHMCR = new System.Windows.Forms.TextBox();
            this.labHeuristicFactor = new System.Windows.Forms.Label();
            this.labPheromoneFacter = new System.Windows.Forms.Label();
            this.txtNumberOfAnts = new System.Windows.Forms.TextBox();
            this.labNumberOfAnts = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labBestRoute = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chartObj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtKnownOptimalObj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labComputationalResults = new System.Windows.Forms.Label();
            this.labNumberOFFunctionCalls = new System.Windows.Forms.Label();
            this.txtNumberOfIterationWithoutImprovement = new System.Windows.Forms.TextBox();
            this.txtSoFarTheBest = new System.Windows.Forms.TextBox();
            this.labIterationID = new System.Windows.Forms.Label();
            this.txtIterationID = new System.Windows.Forms.TextBox();
            this.labBestObjsoFar = new System.Windows.Forms.Label();
            this.checkBoxShowAnimation = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ACOSettings.SuspendLayout();
            this.GroupBoxStoppingCritia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartObj)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(36, 36);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 594);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ACOSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 594);
            this.tabControl1.TabIndex = 3;
            // 
            // ACOSettings
            // 
            this.ACOSettings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ACOSettings.Controls.Add(this.checkBoxShowAnimation);
            this.ACOSettings.Controls.Add(this.progressBar1);
            this.ACOSettings.Controls.Add(this.btnRunToEnd);
            this.ACOSettings.Controls.Add(this.btnRunOneIteration);
            this.ACOSettings.Controls.Add(this.btnReset);
            this.ACOSettings.Controls.Add(this.GroupBoxStoppingCritia);
            this.ACOSettings.Controls.Add(this.txtPAR);
            this.ACOSettings.Controls.Add(this.txtHMCR);
            this.ACOSettings.Controls.Add(this.labHeuristicFactor);
            this.ACOSettings.Controls.Add(this.labPheromoneFacter);
            this.ACOSettings.Controls.Add(this.txtNumberOfAnts);
            this.ACOSettings.Controls.Add(this.labNumberOfAnts);
            this.ACOSettings.Location = new System.Drawing.Point(4, 23);
            this.ACOSettings.Name = "ACOSettings";
            this.ACOSettings.Padding = new System.Windows.Forms.Padding(3);
            this.ACOSettings.Size = new System.Drawing.Size(270, 567);
            this.ACOSettings.TabIndex = 0;
            this.ACOSettings.Text = "ACO settings";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 267);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 33);
            this.progressBar1.TabIndex = 21;
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunToEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunToEnd.Location = new System.Drawing.Point(183, 311);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(84, 37);
            this.btnRunToEnd.TabIndex = 20;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunOneIteration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunOneIteration.Location = new System.Drawing.Point(84, 311);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(93, 37);
            this.btnRunOneIteration.TabIndex = 19;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = true;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 311);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GroupBoxStoppingCritia
            // 
            this.GroupBoxStoppingCritia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxStoppingCritia.Controls.Add(this.txtObjLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.txtIterationLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.checkboxObjLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.checkboxIterationLimit);
            this.GroupBoxStoppingCritia.Location = new System.Drawing.Point(6, 124);
            this.GroupBoxStoppingCritia.Name = "GroupBoxStoppingCritia";
            this.GroupBoxStoppingCritia.Size = new System.Drawing.Size(260, 101);
            this.GroupBoxStoppingCritia.TabIndex = 17;
            this.GroupBoxStoppingCritia.TabStop = false;
            this.GroupBoxStoppingCritia.Text = "Stopping Criteria";
            // 
            // txtObjLimit
            // 
            this.txtObjLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjLimit.Location = new System.Drawing.Point(157, 73);
            this.txtObjLimit.Name = "txtObjLimit";
            this.txtObjLimit.Size = new System.Drawing.Size(96, 22);
            this.txtObjLimit.TabIndex = 2;
            this.txtObjLimit.Text = "1000";
            // 
            // txtIterationLimit
            // 
            this.txtIterationLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIterationLimit.Location = new System.Drawing.Point(157, 20);
            this.txtIterationLimit.Name = "txtIterationLimit";
            this.txtIterationLimit.Size = new System.Drawing.Size(97, 22);
            this.txtIterationLimit.TabIndex = 2;
            this.txtIterationLimit.Text = "30000";
            // 
            // checkboxObjLimit
            // 
            this.checkboxObjLimit.AutoSize = true;
            this.checkboxObjLimit.Location = new System.Drawing.Point(7, 52);
            this.checkboxObjLimit.Name = "checkboxObjLimit";
            this.checkboxObjLimit.Size = new System.Drawing.Size(223, 18);
            this.checkboxObjLimit.TabIndex = 0;
            this.checkboxObjLimit.Text = "Iteration Without Improvement";
            this.checkboxObjLimit.UseVisualStyleBackColor = true;
            // 
            // checkboxIterationLimit
            // 
            this.checkboxIterationLimit.AutoSize = true;
            this.checkboxIterationLimit.Checked = true;
            this.checkboxIterationLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxIterationLimit.Location = new System.Drawing.Point(7, 23);
            this.checkboxIterationLimit.Name = "checkboxIterationLimit";
            this.checkboxIterationLimit.Size = new System.Drawing.Size(114, 18);
            this.checkboxIterationLimit.TabIndex = 0;
            this.checkboxIterationLimit.Text = "Iteration Limit";
            this.checkboxIterationLimit.UseVisualStyleBackColor = true;
            // 
            // txtPAR
            // 
            this.txtPAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPAR.Location = new System.Drawing.Point(171, 73);
            this.txtPAR.Name = "txtPAR";
            this.txtPAR.Size = new System.Drawing.Size(88, 22);
            this.txtPAR.TabIndex = 15;
            this.txtPAR.Text = "0.05";
            // 
            // txtHMCR
            // 
            this.txtHMCR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHMCR.Location = new System.Drawing.Point(171, 44);
            this.txtHMCR.Name = "txtHMCR";
            this.txtHMCR.Size = new System.Drawing.Size(88, 22);
            this.txtHMCR.TabIndex = 16;
            this.txtHMCR.Text = "0.99";
            // 
            // labHeuristicFactor
            // 
            this.labHeuristicFactor.AutoSize = true;
            this.labHeuristicFactor.Location = new System.Drawing.Point(8, 76);
            this.labHeuristicFactor.Name = "labHeuristicFactor";
            this.labHeuristicFactor.Size = new System.Drawing.Size(31, 14);
            this.labHeuristicFactor.TabIndex = 12;
            this.labHeuristicFactor.Text = "PAR";
            // 
            // labPheromoneFacter
            // 
            this.labPheromoneFacter.AutoSize = true;
            this.labPheromoneFacter.Location = new System.Drawing.Point(8, 47);
            this.labPheromoneFacter.Name = "labPheromoneFacter";
            this.labPheromoneFacter.Size = new System.Drawing.Size(43, 14);
            this.labPheromoneFacter.TabIndex = 13;
            this.labPheromoneFacter.Text = "HMCR";
            // 
            // txtNumberOfAnts
            // 
            this.txtNumberOfAnts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfAnts.Location = new System.Drawing.Point(171, 15);
            this.txtNumberOfAnts.Name = "txtNumberOfAnts";
            this.txtNumberOfAnts.Size = new System.Drawing.Size(88, 22);
            this.txtNumberOfAnts.TabIndex = 10;
            this.txtNumberOfAnts.Text = "20";
            // 
            // labNumberOfAnts
            // 
            this.labNumberOfAnts.AutoSize = true;
            this.labNumberOfAnts.Location = new System.Drawing.Point(8, 18);
            this.labNumberOfAnts.Name = "labNumberOfAnts";
            this.labNumberOfAnts.Size = new System.Drawing.Size(95, 14);
            this.labNumberOfAnts.TabIndex = 9;
            this.labNumberOfAnts.Text = "Number of HM";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer2.Panel1.Controls.Add(this.labBestRoute);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(902, 594);
            this.splitContainer2.SplitterDistance = 320;
            this.splitContainer2.TabIndex = 0;
            // 
            // labBestRoute
            // 
            this.labBestRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labBestRoute.AutoSize = true;
            this.labBestRoute.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBestRoute.Location = new System.Drawing.Point(13, 12);
            this.labBestRoute.Name = "labBestRoute";
            this.labBestRoute.Size = new System.Drawing.Size(76, 14);
            this.labBestRoute.TabIndex = 0;
            this.labBestRoute.Text = "Best Route";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chartObj);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtKnownOptimalObj);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Panel2.Controls.Add(this.labComputationalResults);
            this.splitContainer3.Panel2.Controls.Add(this.labNumberOFFunctionCalls);
            this.splitContainer3.Panel2.Controls.Add(this.txtNumberOfIterationWithoutImprovement);
            this.splitContainer3.Panel2.Controls.Add(this.txtSoFarTheBest);
            this.splitContainer3.Panel2.Controls.Add(this.labIterationID);
            this.splitContainer3.Panel2.Controls.Add(this.txtIterationID);
            this.splitContainer3.Panel2.Controls.Add(this.labBestObjsoFar);
            this.splitContainer3.Size = new System.Drawing.Size(902, 270);
            this.splitContainer3.SplitterDistance = 591;
            this.splitContainer3.TabIndex = 0;
            // 
            // chartObj
            // 
            this.chartObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chartObj.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Weave;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Iteration";
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Objective";
            chartArea1.BackColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chartObj.ChartAreas.Add(chartArea1);
            this.chartObj.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartObj.Legends.Add(legend1);
            this.chartObj.Location = new System.Drawing.Point(0, 0);
            this.chartObj.Name = "chartObj";
            this.chartObj.Size = new System.Drawing.Size(591, 270);
            this.chartObj.TabIndex = 1;
            this.chartObj.Text = "chartObj";
            // 
            // txtKnownOptimalObj
            // 
            this.txtKnownOptimalObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKnownOptimalObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtKnownOptimalObj.Enabled = false;
            this.txtKnownOptimalObj.Location = new System.Drawing.Point(192, 130);
            this.txtKnownOptimalObj.Name = "txtKnownOptimalObj";
            this.txtKnownOptimalObj.Size = new System.Drawing.Size(103, 22);
            this.txtKnownOptimalObj.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(5, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Known optimal objective";
            // 
            // labComputationalResults
            // 
            this.labComputationalResults.AutoSize = true;
            this.labComputationalResults.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labComputationalResults.Location = new System.Drawing.Point(3, 10);
            this.labComputationalResults.Name = "labComputationalResults";
            this.labComputationalResults.Size = new System.Drawing.Size(195, 18);
            this.labComputationalResults.TabIndex = 20;
            this.labComputationalResults.Text = "Computational Results";
            // 
            // labNumberOFFunctionCalls
            // 
            this.labNumberOFFunctionCalls.AutoSize = true;
            this.labNumberOFFunctionCalls.ForeColor = System.Drawing.Color.Sienna;
            this.labNumberOFFunctionCalls.Location = new System.Drawing.Point(5, 74);
            this.labNumberOFFunctionCalls.Name = "labNumberOFFunctionCalls";
            this.labNumberOFFunctionCalls.Size = new System.Drawing.Size(273, 14);
            this.labNumberOFFunctionCalls.TabIndex = 19;
            this.labNumberOFFunctionCalls.Text = "Number of Iteration Without Improvement";
            // 
            // txtNumberOfIterationWithoutImprovement
            // 
            this.txtNumberOfIterationWithoutImprovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfIterationWithoutImprovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumberOfIterationWithoutImprovement.Enabled = false;
            this.txtNumberOfIterationWithoutImprovement.Location = new System.Drawing.Point(192, 91);
            this.txtNumberOfIterationWithoutImprovement.Name = "txtNumberOfIterationWithoutImprovement";
            this.txtNumberOfIterationWithoutImprovement.Size = new System.Drawing.Size(103, 22);
            this.txtNumberOfIterationWithoutImprovement.TabIndex = 18;
            this.txtNumberOfIterationWithoutImprovement.Text = "0";
            // 
            // txtSoFarTheBest
            // 
            this.txtSoFarTheBest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoFarTheBest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoFarTheBest.Enabled = false;
            this.txtSoFarTheBest.Location = new System.Drawing.Point(192, 165);
            this.txtSoFarTheBest.Name = "txtSoFarTheBest";
            this.txtSoFarTheBest.Size = new System.Drawing.Size(103, 22);
            this.txtSoFarTheBest.TabIndex = 15;
            // 
            // labIterationID
            // 
            this.labIterationID.AutoSize = true;
            this.labIterationID.ForeColor = System.Drawing.Color.Sienna;
            this.labIterationID.Location = new System.Drawing.Point(5, 43);
            this.labIterationID.Name = "labIterationID";
            this.labIterationID.Size = new System.Drawing.Size(80, 14);
            this.labIterationID.TabIndex = 14;
            this.labIterationID.Text = "Iteration ID";
            // 
            // txtIterationID
            // 
            this.txtIterationID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIterationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIterationID.Enabled = false;
            this.txtIterationID.Location = new System.Drawing.Point(192, 35);
            this.txtIterationID.Name = "txtIterationID";
            this.txtIterationID.Size = new System.Drawing.Size(103, 22);
            this.txtIterationID.TabIndex = 13;
            this.txtIterationID.Text = "0";
            // 
            // labBestObjsoFar
            // 
            this.labBestObjsoFar.AutoSize = true;
            this.labBestObjsoFar.ForeColor = System.Drawing.Color.Sienna;
            this.labBestObjsoFar.Location = new System.Drawing.Point(5, 168);
            this.labBestObjsoFar.Name = "labBestObjsoFar";
            this.labBestObjsoFar.Size = new System.Drawing.Size(136, 14);
            this.labBestObjsoFar.TabIndex = 12;
            this.labBestObjsoFar.Text = "Best objective so far";
            // 
            // checkBoxShowAnimation
            // 
            this.checkBoxShowAnimation.AutoSize = true;
            this.checkBoxShowAnimation.Location = new System.Drawing.Point(6, 243);
            this.checkBoxShowAnimation.Name = "checkBoxShowAnimation";
            this.checkBoxShowAnimation.Size = new System.Drawing.Size(127, 18);
            this.checkBoxShowAnimation.TabIndex = 22;
            this.checkBoxShowAnimation.Text = "Show Animation";
            this.checkBoxShowAnimation.UseVisualStyleBackColor = true;
            // 
            // HSForTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HSForTSP";
            this.Text = "TSP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ACOSettings.ResumeLayout(false);
            this.ACOSettings.PerformLayout();
            this.GroupBoxStoppingCritia.ResumeLayout(false);
            this.GroupBoxStoppingCritia.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ACOSettings;
        private System.Windows.Forms.TextBox txtPAR;
        private System.Windows.Forms.TextBox txtHMCR;
        private System.Windows.Forms.Label labHeuristicFactor;
        private System.Windows.Forms.Label labPheromoneFacter;
        private System.Windows.Forms.TextBox txtNumberOfAnts;
        private System.Windows.Forms.Label labNumberOfAnts;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObj;
        private System.Windows.Forms.TextBox txtKnownOptimalObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labComputationalResults;
        private System.Windows.Forms.Label labNumberOFFunctionCalls;
        private System.Windows.Forms.TextBox txtNumberOfIterationWithoutImprovement;
        private System.Windows.Forms.TextBox txtSoFarTheBest;
        private System.Windows.Forms.Label labIterationID;
        private System.Windows.Forms.TextBox txtIterationID;
        private System.Windows.Forms.Label labBestObjsoFar;
        private System.Windows.Forms.Label labBestRoute;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.Button btnRunOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox GroupBoxStoppingCritia;
        private System.Windows.Forms.TextBox txtObjLimit;
        private System.Windows.Forms.TextBox txtIterationLimit;
        private System.Windows.Forms.CheckBox checkboxObjLimit;
        private System.Windows.Forms.CheckBox checkboxIterationLimit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBoxShowAnimation;
    }
}

