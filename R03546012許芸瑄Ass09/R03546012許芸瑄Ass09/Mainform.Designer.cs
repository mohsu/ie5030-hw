namespace R03546012許芸瑄Ass09
{
    partial class ASForTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASForTSP));
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
            this.txtDroppingAmount = new System.Windows.Forms.TextBox();
            this.txtEvaporationRate = new System.Windows.Forms.TextBox();
            this.labDropAmount = new System.Windows.Forms.Label();
            this.labEva = new System.Windows.Forms.Label();
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.radiobtnDeterministic = new System.Windows.Forms.RadioButton();
            this.radiobtnStochastic = new System.Windows.Forms.RadioButton();
            this.txtInitialPheromoneValue = new System.Windows.Forms.TextBox();
            this.txtHeuristicFactor = new System.Windows.Forms.TextBox();
            this.labInitialPheromoneValue = new System.Windows.Forms.Label();
            this.txtPheromoneFacter = new System.Windows.Forms.TextBox();
            this.labHeuristicFactor = new System.Windows.Forms.Label();
            this.labPheromoneFacter = new System.Windows.Forms.Label();
            this.txtNumberOfAnts = new System.Windows.Forms.TextBox();
            this.labNumberOfAnts = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.btnRunOneIteration = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.GroupBoxStoppingCritia = new System.Windows.Forms.GroupBox();
            this.txtIterationWithoutImprovement = new System.Windows.Forms.TextBox();
            this.txtObjLimit = new System.Windows.Forms.TextBox();
            this.checkboxIterationWithoutImprove = new System.Windows.Forms.CheckBox();
            this.txtIterationLimit = new System.Windows.Forms.TextBox();
            this.checkboxObjLimit = new System.Windows.Forms.CheckBox();
            this.checkboxIterationLimit = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chartObj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtKnownOptimalObj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labComputationalResults = new System.Windows.Forms.Label();
            this.labNumberOFFunctionCalls = new System.Windows.Forms.Label();
            this.txtNumberOfFunctionCalls = new System.Windows.Forms.TextBox();
            this.txtAtIteration = new System.Windows.Forms.TextBox();
            this.labAtIteration = new System.Windows.Forms.Label();
            this.txtSoFarTheBest = new System.Windows.Forms.TextBox();
            this.labIterationID = new System.Windows.Forms.Label();
            this.txtIterationID = new System.Windows.Forms.TextBox();
            this.labBestObjsoFar = new System.Windows.Forms.Label();
            this.labBestRoute = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ACOSettings.SuspendLayout();
            this.groupBoxSelection.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.ACOSettings.Controls.Add(this.txtDroppingAmount);
            this.ACOSettings.Controls.Add(this.txtEvaporationRate);
            this.ACOSettings.Controls.Add(this.labDropAmount);
            this.ACOSettings.Controls.Add(this.labEva);
            this.ACOSettings.Controls.Add(this.groupBoxSelection);
            this.ACOSettings.Controls.Add(this.txtInitialPheromoneValue);
            this.ACOSettings.Controls.Add(this.txtHeuristicFactor);
            this.ACOSettings.Controls.Add(this.labInitialPheromoneValue);
            this.ACOSettings.Controls.Add(this.txtPheromoneFacter);
            this.ACOSettings.Controls.Add(this.labHeuristicFactor);
            this.ACOSettings.Controls.Add(this.labPheromoneFacter);
            this.ACOSettings.Controls.Add(this.txtNumberOfAnts);
            this.ACOSettings.Controls.Add(this.labNumberOfAnts);
            this.ACOSettings.Location = new System.Drawing.Point(4, 23);
            this.ACOSettings.Name = "ACOSettings";
            this.ACOSettings.Padding = new System.Windows.Forms.Padding(3);
            this.ACOSettings.Size = new System.Drawing.Size(270, 581);
            this.ACOSettings.TabIndex = 0;
            this.ACOSettings.Text = "ACO settings";
            // 
            // txtDroppingAmount
            // 
            this.txtDroppingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDroppingAmount.Location = new System.Drawing.Point(171, 160);
            this.txtDroppingAmount.Name = "txtDroppingAmount";
            this.txtDroppingAmount.Size = new System.Drawing.Size(88, 22);
            this.txtDroppingAmount.TabIndex = 20;
            this.txtDroppingAmount.Text = "0.01";
            // 
            // txtEvaporationRate
            // 
            this.txtEvaporationRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvaporationRate.Location = new System.Drawing.Point(171, 131);
            this.txtEvaporationRate.Name = "txtEvaporationRate";
            this.txtEvaporationRate.Size = new System.Drawing.Size(88, 22);
            this.txtEvaporationRate.TabIndex = 21;
            this.txtEvaporationRate.Text = "0.95";
            // 
            // labDropAmount
            // 
            this.labDropAmount.AutoSize = true;
            this.labDropAmount.Location = new System.Drawing.Point(8, 163);
            this.labDropAmount.Name = "labDropAmount";
            this.labDropAmount.Size = new System.Drawing.Size(116, 14);
            this.labDropAmount.TabIndex = 18;
            this.labDropAmount.Text = "Dropping Amount";
            // 
            // labEva
            // 
            this.labEva.AutoSize = true;
            this.labEva.Location = new System.Drawing.Point(8, 134);
            this.labEva.Name = "labEva";
            this.labEva.Size = new System.Drawing.Size(116, 14);
            this.labEva.TabIndex = 19;
            this.labEva.Text = "Evaporation Rate";
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelection.Controls.Add(this.radiobtnDeterministic);
            this.groupBoxSelection.Controls.Add(this.radiobtnStochastic);
            this.groupBoxSelection.Location = new System.Drawing.Point(8, 204);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(253, 81);
            this.groupBoxSelection.TabIndex = 17;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Selection Mode";
            // 
            // radiobtnDeterministic
            // 
            this.radiobtnDeterministic.AutoSize = true;
            this.radiobtnDeterministic.Location = new System.Drawing.Point(18, 49);
            this.radiobtnDeterministic.Name = "radiobtnDeterministic";
            this.radiobtnDeterministic.Size = new System.Drawing.Size(106, 18);
            this.radiobtnDeterministic.TabIndex = 0;
            this.radiobtnDeterministic.TabStop = true;
            this.radiobtnDeterministic.Text = "Deterministic";
            this.radiobtnDeterministic.UseVisualStyleBackColor = true;
            // 
            // radiobtnStochastic
            // 
            this.radiobtnStochastic.AutoSize = true;
            this.radiobtnStochastic.Checked = true;
            this.radiobtnStochastic.Location = new System.Drawing.Point(18, 23);
            this.radiobtnStochastic.Name = "radiobtnStochastic";
            this.radiobtnStochastic.Size = new System.Drawing.Size(89, 18);
            this.radiobtnStochastic.TabIndex = 0;
            this.radiobtnStochastic.TabStop = true;
            this.radiobtnStochastic.Text = "Stochastic";
            this.radiobtnStochastic.UseVisualStyleBackColor = true;
            // 
            // txtInitialPheromoneValue
            // 
            this.txtInitialPheromoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitialPheromoneValue.Location = new System.Drawing.Point(171, 102);
            this.txtInitialPheromoneValue.Name = "txtInitialPheromoneValue";
            this.txtInitialPheromoneValue.Size = new System.Drawing.Size(88, 22);
            this.txtInitialPheromoneValue.TabIndex = 14;
            this.txtInitialPheromoneValue.Text = "0.05";
            // 
            // txtHeuristicFactor
            // 
            this.txtHeuristicFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeuristicFactor.Location = new System.Drawing.Point(171, 73);
            this.txtHeuristicFactor.Name = "txtHeuristicFactor";
            this.txtHeuristicFactor.Size = new System.Drawing.Size(88, 22);
            this.txtHeuristicFactor.TabIndex = 15;
            this.txtHeuristicFactor.Text = "3.0";
            // 
            // labInitialPheromoneValue
            // 
            this.labInitialPheromoneValue.AutoSize = true;
            this.labInitialPheromoneValue.Location = new System.Drawing.Point(8, 105);
            this.labInitialPheromoneValue.Name = "labInitialPheromoneValue";
            this.labInitialPheromoneValue.Size = new System.Drawing.Size(157, 14);
            this.labInitialPheromoneValue.TabIndex = 11;
            this.labInitialPheromoneValue.Text = "Initial Pheromone Value";
            // 
            // txtPheromoneFacter
            // 
            this.txtPheromoneFacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPheromoneFacter.Location = new System.Drawing.Point(171, 44);
            this.txtPheromoneFacter.Name = "txtPheromoneFacter";
            this.txtPheromoneFacter.Size = new System.Drawing.Size(88, 22);
            this.txtPheromoneFacter.TabIndex = 16;
            this.txtPheromoneFacter.Text = "1.0";
            // 
            // labHeuristicFactor
            // 
            this.labHeuristicFactor.AutoSize = true;
            this.labHeuristicFactor.Location = new System.Drawing.Point(8, 76);
            this.labHeuristicFactor.Name = "labHeuristicFactor";
            this.labHeuristicFactor.Size = new System.Drawing.Size(115, 14);
            this.labHeuristicFactor.TabIndex = 12;
            this.labHeuristicFactor.Text = "Heuristic Factor β";
            // 
            // labPheromoneFacter
            // 
            this.labPheromoneFacter.AutoSize = true;
            this.labPheromoneFacter.Location = new System.Drawing.Point(8, 47);
            this.labPheromoneFacter.Name = "labPheromoneFacter";
            this.labPheromoneFacter.Size = new System.Drawing.Size(134, 14);
            this.labPheromoneFacter.TabIndex = 13;
            this.labPheromoneFacter.Text = "Pheromone Facter α";
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
            this.labNumberOfAnts.Size = new System.Drawing.Size(104, 14);
            this.labNumberOfAnts.TabIndex = 9;
            this.labNumberOfAnts.Text = "Number of Ants";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.btnRunToEnd);
            this.tabPage2.Controls.Add(this.btnRunOneIteration);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.GroupBoxStoppingCritia);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(270, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Execution";
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunToEnd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunToEnd.Location = new System.Drawing.Point(184, 511);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(84, 37);
            this.btnRunToEnd.TabIndex = 5;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnRunOneIteration
            // 
            this.btnRunOneIteration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunOneIteration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunOneIteration.Location = new System.Drawing.Point(85, 511);
            this.btnRunOneIteration.Name = "btnRunOneIteration";
            this.btnRunOneIteration.Size = new System.Drawing.Size(93, 37);
            this.btnRunOneIteration.TabIndex = 4;
            this.btnRunOneIteration.Text = "Run One Iteration";
            this.btnRunOneIteration.UseVisualStyleBackColor = true;
            this.btnRunOneIteration.Click += new System.EventHandler(this.btnRunOneIteration_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(4, 511);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GroupBoxStoppingCritia
            // 
            this.GroupBoxStoppingCritia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxStoppingCritia.Controls.Add(this.txtIterationWithoutImprovement);
            this.GroupBoxStoppingCritia.Controls.Add(this.txtObjLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.checkboxIterationWithoutImprove);
            this.GroupBoxStoppingCritia.Controls.Add(this.txtIterationLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.checkboxObjLimit);
            this.GroupBoxStoppingCritia.Controls.Add(this.checkboxIterationLimit);
            this.GroupBoxStoppingCritia.Location = new System.Drawing.Point(4, 19);
            this.GroupBoxStoppingCritia.Name = "GroupBoxStoppingCritia";
            this.GroupBoxStoppingCritia.Size = new System.Drawing.Size(260, 119);
            this.GroupBoxStoppingCritia.TabIndex = 1;
            this.GroupBoxStoppingCritia.TabStop = false;
            this.GroupBoxStoppingCritia.Text = "Stopping Criteria";
            // 
            // txtIterationWithoutImprovement
            // 
            this.txtIterationWithoutImprovement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIterationWithoutImprovement.Location = new System.Drawing.Point(220, 79);
            this.txtIterationWithoutImprovement.Name = "txtIterationWithoutImprovement";
            this.txtIterationWithoutImprovement.Size = new System.Drawing.Size(34, 22);
            this.txtIterationWithoutImprovement.TabIndex = 2;
            this.txtIterationWithoutImprovement.Text = "50";
            // 
            // txtObjLimit
            // 
            this.txtObjLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjLimit.Location = new System.Drawing.Point(157, 50);
            this.txtObjLimit.Name = "txtObjLimit";
            this.txtObjLimit.Size = new System.Drawing.Size(97, 22);
            this.txtObjLimit.TabIndex = 2;
            this.txtObjLimit.Text = "100000";
            // 
            // checkboxIterationWithoutImprove
            // 
            this.checkboxIterationWithoutImprove.AutoSize = true;
            this.checkboxIterationWithoutImprove.Location = new System.Drawing.Point(7, 81);
            this.checkboxIterationWithoutImprove.Name = "checkboxIterationWithoutImprove";
            this.checkboxIterationWithoutImprove.Size = new System.Drawing.Size(213, 18);
            this.checkboxIterationWithoutImprove.TabIndex = 0;
            this.checkboxIterationWithoutImprove.Text = "Iteration without Improvment";
            this.checkboxIterationWithoutImprove.UseVisualStyleBackColor = true;
            // 
            // txtIterationLimit
            // 
            this.txtIterationLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIterationLimit.Location = new System.Drawing.Point(157, 20);
            this.txtIterationLimit.Name = "txtIterationLimit";
            this.txtIterationLimit.Size = new System.Drawing.Size(97, 22);
            this.txtIterationLimit.TabIndex = 2;
            this.txtIterationLimit.Text = "300";
            // 
            // checkboxObjLimit
            // 
            this.checkboxObjLimit.AutoSize = true;
            this.checkboxObjLimit.Location = new System.Drawing.Point(7, 52);
            this.checkboxObjLimit.Name = "checkboxObjLimit";
            this.checkboxObjLimit.Size = new System.Drawing.Size(145, 18);
            this.checkboxObjLimit.TabIndex = 0;
            this.checkboxObjLimit.Text = "Objective Call Limit";
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
            this.splitContainer3.Panel2.Controls.Add(this.txtNumberOfFunctionCalls);
            this.splitContainer3.Panel2.Controls.Add(this.txtAtIteration);
            this.splitContainer3.Panel2.Controls.Add(this.labAtIteration);
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
            this.txtKnownOptimalObj.Location = new System.Drawing.Point(192, 105);
            this.txtKnownOptimalObj.Name = "txtKnownOptimalObj";
            this.txtKnownOptimalObj.Size = new System.Drawing.Size(103, 22);
            this.txtKnownOptimalObj.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(5, 108);
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
            this.labNumberOFFunctionCalls.Size = new System.Drawing.Size(163, 14);
            this.labNumberOFFunctionCalls.TabIndex = 19;
            this.labNumberOFFunctionCalls.Text = "Number of Function Calls";
            // 
            // txtNumberOfFunctionCalls
            // 
            this.txtNumberOfFunctionCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfFunctionCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumberOfFunctionCalls.Enabled = false;
            this.txtNumberOfFunctionCalls.Location = new System.Drawing.Point(192, 71);
            this.txtNumberOfFunctionCalls.Name = "txtNumberOfFunctionCalls";
            this.txtNumberOfFunctionCalls.Size = new System.Drawing.Size(103, 22);
            this.txtNumberOfFunctionCalls.TabIndex = 18;
            this.txtNumberOfFunctionCalls.Text = "0";
            // 
            // txtAtIteration
            // 
            this.txtAtIteration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtIteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAtIteration.Enabled = false;
            this.txtAtIteration.Location = new System.Drawing.Point(192, 176);
            this.txtAtIteration.Name = "txtAtIteration";
            this.txtAtIteration.Size = new System.Drawing.Size(103, 22);
            this.txtAtIteration.TabIndex = 17;
            this.txtAtIteration.Text = "0";
            // 
            // labAtIteration
            // 
            this.labAtIteration.AutoSize = true;
            this.labAtIteration.ForeColor = System.Drawing.Color.Sienna;
            this.labAtIteration.Location = new System.Drawing.Point(89, 179);
            this.labAtIteration.Name = "labAtIteration";
            this.labAtIteration.Size = new System.Drawing.Size(79, 14);
            this.labAtIteration.TabIndex = 16;
            this.labAtIteration.Text = "At Iteration";
            // 
            // txtSoFarTheBest
            // 
            this.txtSoFarTheBest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoFarTheBest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoFarTheBest.Enabled = false;
            this.txtSoFarTheBest.Location = new System.Drawing.Point(192, 140);
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
            this.labBestObjsoFar.Location = new System.Drawing.Point(5, 143);
            this.labBestObjsoFar.Name = "labBestObjsoFar";
            this.labBestObjsoFar.Size = new System.Drawing.Size(136, 14);
            this.labBestObjsoFar.TabIndex = 12;
            this.labBestObjsoFar.Text = "Best objective so far";
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
            // ASForTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ASForTSP";
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
            this.groupBoxSelection.ResumeLayout(false);
            this.groupBoxSelection.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtDroppingAmount;
        private System.Windows.Forms.TextBox txtEvaporationRate;
        private System.Windows.Forms.Label labDropAmount;
        private System.Windows.Forms.Label labEva;
        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.RadioButton radiobtnDeterministic;
        private System.Windows.Forms.RadioButton radiobtnStochastic;
        private System.Windows.Forms.TextBox txtInitialPheromoneValue;
        private System.Windows.Forms.TextBox txtHeuristicFactor;
        private System.Windows.Forms.Label labInitialPheromoneValue;
        private System.Windows.Forms.TextBox txtPheromoneFacter;
        private System.Windows.Forms.Label labHeuristicFactor;
        private System.Windows.Forms.Label labPheromoneFacter;
        private System.Windows.Forms.TextBox txtNumberOfAnts;
        private System.Windows.Forms.Label labNumberOfAnts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.Button btnRunOneIteration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox GroupBoxStoppingCritia;
        private System.Windows.Forms.TextBox txtIterationWithoutImprovement;
        private System.Windows.Forms.TextBox txtObjLimit;
        private System.Windows.Forms.CheckBox checkboxIterationWithoutImprove;
        private System.Windows.Forms.TextBox txtIterationLimit;
        private System.Windows.Forms.CheckBox checkboxObjLimit;
        private System.Windows.Forms.CheckBox checkboxIterationLimit;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObj;
        private System.Windows.Forms.TextBox txtKnownOptimalObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labComputationalResults;
        private System.Windows.Forms.Label labNumberOFFunctionCalls;
        private System.Windows.Forms.TextBox txtNumberOfFunctionCalls;
        private System.Windows.Forms.TextBox txtAtIteration;
        private System.Windows.Forms.Label labAtIteration;
        private System.Windows.Forms.TextBox txtSoFarTheBest;
        private System.Windows.Forms.Label labIterationID;
        private System.Windows.Forms.TextBox txtIterationID;
        private System.Windows.Forms.Label labBestObjsoFar;
        private System.Windows.Forms.Label labBestRoute;
    }
}

