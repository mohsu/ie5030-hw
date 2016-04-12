namespace R03546012許芸瑄Ass03
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.treeViewUniverse = new System.Windows.Forms.TreeView();
            this.imageListNode = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Create = new System.Windows.Forms.SplitContainer();
            this.labUniverse = new System.Windows.Forms.Label();
            this.btnCreateUniverse = new System.Windows.Forms.Button();
            this.txtInc = new System.Windows.Forms.TextBox();
            this.btnUpdateUniverse = new System.Windows.Forms.Button();
            this.labMin = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.labInc = new System.Windows.Forms.Label();
            this.labtxt = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labFuzzySetTitle = new System.Windows.Forms.Label();
            this.txtFuzzySetTitle = new System.Windows.Forms.TextBox();
            this.labFuzzySet = new System.Windows.Forms.Label();
            this.labP1 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.labP4 = new System.Windows.Forms.Label();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.labP3 = new System.Windows.Forms.Label();
            this.btnUpdateFuzzySet = new System.Windows.Forms.Button();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.labP2 = new System.Windows.Forms.Label();
            this.chartUniverse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.FuzzytabControl = new System.Windows.Forms.TabControl();
            this.tabPrimary = new System.Windows.Forms.TabPage();
            this.labFuzzySetSelection = new System.Windows.Forms.Label();
            this.lsbOptions = new System.Windows.Forms.ListBox();
            this.btnAddFuzzy = new System.Windows.Forms.Button();
            this.tabUnary = new System.Windows.Forms.TabPage();
            this.btnAddUnary = new System.Windows.Forms.Button();
            this.txtUnaryParameter = new System.Windows.Forms.TextBox();
            this.labUnaryParameter = new System.Windows.Forms.Label();
            this.txtUnaryTarget = new System.Windows.Forms.TextBox();
            this.labUnaryTarget = new System.Windows.Forms.Label();
            this.labUnarySelection = new System.Windows.Forms.Label();
            this.listBoxUnary = new System.Windows.Forms.ListBox();
            this.tabBinary = new System.Windows.Forms.TabPage();
            this.btnAddBinary = new System.Windows.Forms.Button();
            this.comboBoxBinary2ndFS = new System.Windows.Forms.ComboBox();
            this.comboBoxBinary1stFS = new System.Windows.Forms.ComboBox();
            this.labBinary2ndFS = new System.Windows.Forms.Label();
            this.labBinary1stFS = new System.Windows.Forms.Label();
            this.labBinarySelection = new System.Windows.Forms.Label();
            this.listBoxBinary = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Create)).BeginInit();
            this.Create.Panel1.SuspendLayout();
            this.Create.Panel2.SuspendLayout();
            this.Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUniverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.FuzzytabControl.SuspendLayout();
            this.tabPrimary.SuspendLayout();
            this.tabUnary.SuspendLayout();
            this.tabBinary.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewUniverse
            // 
            this.treeViewUniverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewUniverse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.treeViewUniverse.HideSelection = false;
            this.treeViewUniverse.ImageIndex = 0;
            this.treeViewUniverse.ImageList = this.imageListNode;
            this.treeViewUniverse.Indent = 33;
            this.treeViewUniverse.ItemHeight = 30;
            this.treeViewUniverse.Location = new System.Drawing.Point(2, 3);
            this.treeViewUniverse.Name = "treeViewUniverse";
            this.treeViewUniverse.SelectedImageIndex = 0;
            this.treeViewUniverse.Size = new System.Drawing.Size(325, 248);
            this.treeViewUniverse.TabIndex = 17;
            this.treeViewUniverse.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewUniverse_AfterSelect);
            // 
            // imageListNode
            // 
            this.imageListNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNode.ImageStream")));
            this.imageListNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNode.Images.SetKeyName(0, "ABC_alphabet_letter_font_graphic_language_text_U-128.png");
            this.imageListNode.Images.SetKeyName(1, "ABC_alphabet_letter_font_graphic_language_text_F-128.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Location = new System.Drawing.Point(12, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(893, 497);
            this.splitContainer1.SplitterDistance = 559;
            this.splitContainer1.TabIndex = 18;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Create);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer2.Panel2.Controls.Add(this.chartUniverse);
            this.splitContainer2.Size = new System.Drawing.Size(559, 497);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Create.Location = new System.Drawing.Point(0, 0);
            this.Create.Name = "Create";
            this.Create.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Create.Panel1
            // 
            this.Create.Panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.Create.Panel1.Controls.Add(this.labUniverse);
            this.Create.Panel1.Controls.Add(this.btnCreateUniverse);
            this.Create.Panel1.Controls.Add(this.txtInc);
            this.Create.Panel1.Controls.Add(this.btnUpdateUniverse);
            this.Create.Panel1.Controls.Add(this.labMin);
            this.Create.Panel1.Controls.Add(this.labMax);
            this.Create.Panel1.Controls.Add(this.labInc);
            this.Create.Panel1.Controls.Add(this.labtxt);
            this.Create.Panel1.Controls.Add(this.txtMin);
            this.Create.Panel1.Controls.Add(this.txtMax);
            this.Create.Panel1.Controls.Add(this.txtTitle);
            // 
            // Create.Panel2
            // 
            this.Create.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Create.Panel2.Controls.Add(this.labFuzzySetTitle);
            this.Create.Panel2.Controls.Add(this.txtFuzzySetTitle);
            this.Create.Panel2.Controls.Add(this.labFuzzySet);
            this.Create.Panel2.Controls.Add(this.labP1);
            this.Create.Panel2.Controls.Add(this.txtP1);
            this.Create.Panel2.Controls.Add(this.labP4);
            this.Create.Panel2.Controls.Add(this.txtP4);
            this.Create.Panel2.Controls.Add(this.labP3);
            this.Create.Panel2.Controls.Add(this.btnUpdateFuzzySet);
            this.Create.Panel2.Controls.Add(this.txtP3);
            this.Create.Panel2.Controls.Add(this.txtP2);
            this.Create.Panel2.Controls.Add(this.labP2);
            this.Create.Size = new System.Drawing.Size(559, 253);
            this.Create.SplitterDistance = 130;
            this.Create.TabIndex = 0;
            // 
            // labUniverse
            // 
            this.labUniverse.AutoSize = true;
            this.labUniverse.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUniverse.ForeColor = System.Drawing.Color.Purple;
            this.labUniverse.Location = new System.Drawing.Point(3, 4);
            this.labUniverse.Name = "labUniverse";
            this.labUniverse.Size = new System.Drawing.Size(140, 18);
            this.labUniverse.TabIndex = 25;
            this.labUniverse.Text = "Selected Universe";
            // 
            // btnCreateUniverse
            // 
            this.btnCreateUniverse.Location = new System.Drawing.Point(399, 40);
            this.btnCreateUniverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateUniverse.Name = "btnCreateUniverse";
            this.btnCreateUniverse.Size = new System.Drawing.Size(136, 27);
            this.btnCreateUniverse.TabIndex = 23;
            this.btnCreateUniverse.Text = "Create Universe";
            this.btnCreateUniverse.UseVisualStyleBackColor = true;
            this.btnCreateUniverse.Click += new System.EventHandler(this.btnCreateUniverse_Click);
            // 
            // txtInc
            // 
            this.txtInc.Location = new System.Drawing.Point(267, 79);
            this.txtInc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInc.Name = "txtInc";
            this.txtInc.Size = new System.Drawing.Size(75, 22);
            this.txtInc.TabIndex = 18;
            this.txtInc.Text = "0.1";
            this.txtInc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateUniverse
            // 
            this.btnUpdateUniverse.Location = new System.Drawing.Point(399, 74);
            this.btnUpdateUniverse.Name = "btnUpdateUniverse";
            this.btnUpdateUniverse.Size = new System.Drawing.Size(136, 27);
            this.btnUpdateUniverse.TabIndex = 24;
            this.btnUpdateUniverse.Text = "Update Universe";
            this.btnUpdateUniverse.UseVisualStyleBackColor = true;
            this.btnUpdateUniverse.Click += new System.EventHandler(this.btnUpdateUniverse_Click);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(154, 36);
            this.labMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(105, 14);
            this.labMin.TabIndex = 19;
            this.labMin.Text = "Minimum Bound";
            this.labMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Location = new System.Drawing.Point(150, 59);
            this.labMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(109, 14);
            this.labMax.TabIndex = 21;
            this.labMax.Text = "Maximum Bound";
            this.labMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labInc
            // 
            this.labInc.AutoSize = true;
            this.labInc.Location = new System.Drawing.Point(188, 82);
            this.labInc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInc.Name = "labInc";
            this.labInc.Size = new System.Drawing.Size(71, 14);
            this.labInc.TabIndex = 17;
            this.labInc.Text = "Increment";
            // 
            // labtxt
            // 
            this.labtxt.AutoSize = true;
            this.labtxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtxt.Location = new System.Drawing.Point(27, 39);
            this.labtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labtxt.Name = "labtxt";
            this.labtxt.Size = new System.Drawing.Size(99, 14);
            this.labtxt.TabIndex = 15;
            this.labtxt.Text = "Universe Title";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(267, 33);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(75, 22);
            this.txtMin.TabIndex = 20;
            this.txtMin.Text = "-10.0";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(267, 56);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(75, 22);
            this.txtMax.TabIndex = 22;
            this.txtMax.Text = "10.0";
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(17, 59);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(117, 22);
            this.txtTitle.TabIndex = 16;
            this.txtTitle.Text = "Age";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labFuzzySetTitle
            // 
            this.labFuzzySetTitle.AutoSize = true;
            this.labFuzzySetTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFuzzySetTitle.Location = new System.Drawing.Point(27, 35);
            this.labFuzzySetTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFuzzySetTitle.Name = "labFuzzySetTitle";
            this.labFuzzySetTitle.Size = new System.Drawing.Size(99, 14);
            this.labFuzzySetTitle.TabIndex = 27;
            this.labFuzzySetTitle.Text = "Universe Title";
            // 
            // txtFuzzySetTitle
            // 
            this.txtFuzzySetTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuzzySetTitle.Location = new System.Drawing.Point(17, 52);
            this.txtFuzzySetTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFuzzySetTitle.Name = "txtFuzzySetTitle";
            this.txtFuzzySetTitle.Size = new System.Drawing.Size(117, 22);
            this.txtFuzzySetTitle.TabIndex = 28;
            this.txtFuzzySetTitle.Text = "Group 1";
            this.txtFuzzySetTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labFuzzySet
            // 
            this.labFuzzySet.AutoSize = true;
            this.labFuzzySet.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFuzzySet.ForeColor = System.Drawing.Color.Purple;
            this.labFuzzySet.Location = new System.Drawing.Point(3, 6);
            this.labFuzzySet.Name = "labFuzzySet";
            this.labFuzzySet.Size = new System.Drawing.Size(151, 18);
            this.labFuzzySet.TabIndex = 26;
            this.labFuzzySet.Text = "Selected Fuzzy Set";
            // 
            // labP1
            // 
            this.labP1.AutoSize = true;
            this.labP1.Location = new System.Drawing.Point(174, 21);
            this.labP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labP1.Name = "labP1";
            this.labP1.Size = new System.Drawing.Size(85, 14);
            this.labP1.TabIndex = 17;
            this.labP1.Text = "parameter 1";
            this.labP1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(267, 18);
            this.txtP1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(75, 22);
            this.txtP1.TabIndex = 18;
            this.txtP1.Text = "n/a";
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labP4
            // 
            this.labP4.AutoSize = true;
            this.labP4.Location = new System.Drawing.Point(174, 91);
            this.labP4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labP4.Name = "labP4";
            this.labP4.Size = new System.Drawing.Size(85, 14);
            this.labP4.TabIndex = 19;
            this.labP4.Text = "parameter 4";
            this.labP4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtP4
            // 
            this.txtP4.Location = new System.Drawing.Point(267, 88);
            this.txtP4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(75, 22);
            this.txtP4.TabIndex = 20;
            this.txtP4.Text = "n/a";
            this.txtP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labP3
            // 
            this.labP3.AutoSize = true;
            this.labP3.Location = new System.Drawing.Point(174, 68);
            this.labP3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labP3.Name = "labP3";
            this.labP3.Size = new System.Drawing.Size(85, 14);
            this.labP3.TabIndex = 21;
            this.labP3.Text = "parameter 3";
            this.labP3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdateFuzzySet
            // 
            this.btnUpdateFuzzySet.Location = new System.Drawing.Point(399, 47);
            this.btnUpdateFuzzySet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateFuzzySet.Name = "btnUpdateFuzzySet";
            this.btnUpdateFuzzySet.Size = new System.Drawing.Size(136, 30);
            this.btnUpdateFuzzySet.TabIndex = 25;
            this.btnUpdateFuzzySet.Text = "Update Fuzzy Set";
            this.btnUpdateFuzzySet.UseVisualStyleBackColor = true;
            this.btnUpdateFuzzySet.Click += new System.EventHandler(this.btnUpdateFuzzySet_Click);
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(267, 65);
            this.txtP3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(75, 22);
            this.txtP3.TabIndex = 22;
            this.txtP3.Text = "n/a";
            this.txtP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(267, 42);
            this.txtP2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(75, 22);
            this.txtP2.TabIndex = 24;
            this.txtP2.Text = "n/a";
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labP2
            // 
            this.labP2.AutoSize = true;
            this.labP2.Location = new System.Drawing.Point(174, 45);
            this.labP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labP2.Name = "labP2";
            this.labP2.Size = new System.Drawing.Size(85, 14);
            this.labP2.TabIndex = 23;
            this.labP2.Text = "parameter 2";
            this.labP2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chartUniverse
            // 
            this.chartUniverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartUniverse.BackColor = System.Drawing.Color.DimGray;
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BackColor = System.Drawing.Color.DimGray;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartUniverse.Legends.Add(legend2);
            this.chartUniverse.Location = new System.Drawing.Point(1, 3);
            this.chartUniverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartUniverse.Name = "chartUniverse";
            this.chartUniverse.Size = new System.Drawing.Size(554, 234);
            this.chartUniverse.TabIndex = 10;
            this.chartUniverse.Text = "chart1";
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
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer3.Panel1.Controls.Add(this.treeViewUniverse);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.splitContainer3.Panel2.Controls.Add(this.FuzzytabControl);
            this.splitContainer3.Size = new System.Drawing.Size(330, 497);
            this.splitContainer3.SplitterDistance = 254;
            this.splitContainer3.TabIndex = 0;
            // 
            // FuzzytabControl
            // 
            this.FuzzytabControl.Controls.Add(this.tabPrimary);
            this.FuzzytabControl.Controls.Add(this.tabUnary);
            this.FuzzytabControl.Controls.Add(this.tabBinary);
            this.FuzzytabControl.Location = new System.Drawing.Point(3, 3);
            this.FuzzytabControl.Name = "FuzzytabControl";
            this.FuzzytabControl.SelectedIndex = 0;
            this.FuzzytabControl.Size = new System.Drawing.Size(324, 233);
            this.FuzzytabControl.TabIndex = 16;
            // 
            // tabPrimary
            // 
            this.tabPrimary.BackColor = System.Drawing.Color.Turquoise;
            this.tabPrimary.Controls.Add(this.labFuzzySetSelection);
            this.tabPrimary.Controls.Add(this.lsbOptions);
            this.tabPrimary.Controls.Add(this.btnAddFuzzy);
            this.tabPrimary.Location = new System.Drawing.Point(4, 23);
            this.tabPrimary.Name = "tabPrimary";
            this.tabPrimary.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimary.Size = new System.Drawing.Size(316, 206);
            this.tabPrimary.TabIndex = 0;
            this.tabPrimary.Text = "Primary";
            // 
            // labFuzzySetSelection
            // 
            this.labFuzzySetSelection.AutoSize = true;
            this.labFuzzySetSelection.Location = new System.Drawing.Point(6, 11);
            this.labFuzzySetSelection.Name = "labFuzzySetSelection";
            this.labFuzzySetSelection.Size = new System.Drawing.Size(162, 14);
            this.labFuzzySetSelection.TabIndex = 15;
            this.labFuzzySetSelection.Text = "Fuzzy Set Type Selection";
            // 
            // lsbOptions
            // 
            this.lsbOptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsbOptions.FormattingEnabled = true;
            this.lsbOptions.ItemHeight = 14;
            this.lsbOptions.Items.AddRange(new object[] {
            "Triangular FS",
            "Guassian FS",
            "Bell FS",
            "LeftRight FS",
            "Sigmoidal FS",
            "Trapezoidal FS",
            "S-shaped FS",
            "Z-shaped FS",
            "Pi-shaped FS"});
            this.lsbOptions.Location = new System.Drawing.Point(9, 27);
            this.lsbOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsbOptions.Name = "lsbOptions";
            this.lsbOptions.Size = new System.Drawing.Size(204, 130);
            this.lsbOptions.TabIndex = 13;
            this.lsbOptions.Tag = "";
            // 
            // btnAddFuzzy
            // 
            this.btnAddFuzzy.Location = new System.Drawing.Point(233, 52);
            this.btnAddFuzzy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddFuzzy.Name = "btnAddFuzzy";
            this.btnAddFuzzy.Size = new System.Drawing.Size(64, 70);
            this.btnAddFuzzy.TabIndex = 14;
            this.btnAddFuzzy.Text = "Add Fuzzy Set";
            this.btnAddFuzzy.UseVisualStyleBackColor = true;
            this.btnAddFuzzy.Click += new System.EventHandler(this.btnAddFuzzy_Click);
            // 
            // tabUnary
            // 
            this.tabUnary.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabUnary.Controls.Add(this.btnAddUnary);
            this.tabUnary.Controls.Add(this.txtUnaryParameter);
            this.tabUnary.Controls.Add(this.labUnaryParameter);
            this.tabUnary.Controls.Add(this.txtUnaryTarget);
            this.tabUnary.Controls.Add(this.labUnaryTarget);
            this.tabUnary.Controls.Add(this.labUnarySelection);
            this.tabUnary.Controls.Add(this.listBoxUnary);
            this.tabUnary.Location = new System.Drawing.Point(4, 23);
            this.tabUnary.Name = "tabUnary";
            this.tabUnary.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnary.Size = new System.Drawing.Size(316, 206);
            this.tabUnary.TabIndex = 1;
            this.tabUnary.Text = "Unary-Operations";
            // 
            // btnAddUnary
            // 
            this.btnAddUnary.Location = new System.Drawing.Point(150, 154);
            this.btnAddUnary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddUnary.Name = "btnAddUnary";
            this.btnAddUnary.Size = new System.Drawing.Size(137, 32);
            this.btnAddUnary.TabIndex = 21;
            this.btnAddUnary.Text = "Add Fuzzy Set";
            this.btnAddUnary.UseVisualStyleBackColor = true;
            this.btnAddUnary.Click += new System.EventHandler(this.btnAddUnary_Click);
            // 
            // txtUnaryParameter
            // 
            this.txtUnaryParameter.Location = new System.Drawing.Point(129, 113);
            this.txtUnaryParameter.Name = "txtUnaryParameter";
            this.txtUnaryParameter.Size = new System.Drawing.Size(181, 22);
            this.txtUnaryParameter.TabIndex = 20;
            this.txtUnaryParameter.Text = "0.7";
            // 
            // labUnaryParameter
            // 
            this.labUnaryParameter.AutoSize = true;
            this.labUnaryParameter.Location = new System.Drawing.Point(126, 96);
            this.labUnaryParameter.Name = "labUnaryParameter";
            this.labUnaryParameter.Size = new System.Drawing.Size(140, 14);
            this.labUnaryParameter.TabIndex = 19;
            this.labUnaryParameter.Text = "Operation parameter";
            // 
            // txtUnaryTarget
            // 
            this.txtUnaryTarget.Location = new System.Drawing.Point(129, 56);
            this.txtUnaryTarget.Name = "txtUnaryTarget";
            this.txtUnaryTarget.Size = new System.Drawing.Size(181, 22);
            this.txtUnaryTarget.TabIndex = 18;
            // 
            // labUnaryTarget
            // 
            this.labUnaryTarget.AutoSize = true;
            this.labUnaryTarget.Location = new System.Drawing.Point(126, 38);
            this.labUnaryTarget.Name = "labUnaryTarget";
            this.labUnaryTarget.Size = new System.Drawing.Size(108, 14);
            this.labUnaryTarget.TabIndex = 17;
            this.labUnaryTarget.Text = "Target fuzzy set";
            // 
            // labUnarySelection
            // 
            this.labUnarySelection.AutoSize = true;
            this.labUnarySelection.Location = new System.Drawing.Point(6, 11);
            this.labUnarySelection.Name = "labUnarySelection";
            this.labUnarySelection.Size = new System.Drawing.Size(172, 14);
            this.labUnarySelection.TabIndex = 16;
            this.labUnarySelection.Text = "Unary Operation Selection";
            // 
            // listBoxUnary
            // 
            this.listBoxUnary.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxUnary.FormattingEnabled = true;
            this.listBoxUnary.ItemHeight = 14;
            this.listBoxUnary.Items.AddRange(new object[] {
            "Not",
            "Value Scale",
            "Value Cut",
            "Very",
            "VeryVery",
            "Extremely",
            "More or less",
            "Intensify",
            "Diminisher",
            "Sugeno Not",
            "Yager Not"});
            this.listBoxUnary.Location = new System.Drawing.Point(9, 28);
            this.listBoxUnary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxUnary.Name = "listBoxUnary";
            this.listBoxUnary.Size = new System.Drawing.Size(98, 158);
            this.listBoxUnary.TabIndex = 14;
            this.listBoxUnary.Tag = "";
            this.listBoxUnary.SelectedIndexChanged += new System.EventHandler(this.listBoxUnary_SelectedIndexChanged);
            // 
            // tabBinary
            // 
            this.tabBinary.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabBinary.Controls.Add(this.btnAddBinary);
            this.tabBinary.Controls.Add(this.comboBoxBinary2ndFS);
            this.tabBinary.Controls.Add(this.comboBoxBinary1stFS);
            this.tabBinary.Controls.Add(this.labBinary2ndFS);
            this.tabBinary.Controls.Add(this.labBinary1stFS);
            this.tabBinary.Controls.Add(this.labBinarySelection);
            this.tabBinary.Controls.Add(this.listBoxBinary);
            this.tabBinary.Location = new System.Drawing.Point(4, 22);
            this.tabBinary.Name = "tabBinary";
            this.tabBinary.Size = new System.Drawing.Size(316, 207);
            this.tabBinary.TabIndex = 2;
            this.tabBinary.Text = "Binary-Operation";
            // 
            // btnAddBinary
            // 
            this.btnAddBinary.Location = new System.Drawing.Point(155, 148);
            this.btnAddBinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBinary.Name = "btnAddBinary";
            this.btnAddBinary.Size = new System.Drawing.Size(137, 32);
            this.btnAddBinary.TabIndex = 23;
            this.btnAddBinary.Text = "Add Fuzzy Set";
            this.btnAddBinary.UseVisualStyleBackColor = true;
            // 
            // comboBoxBinary2ndFS
            // 
            this.comboBoxBinary2ndFS.FormattingEnabled = true;
            this.comboBoxBinary2ndFS.Location = new System.Drawing.Point(133, 109);
            this.comboBoxBinary2ndFS.Name = "comboBoxBinary2ndFS";
            this.comboBoxBinary2ndFS.Size = new System.Drawing.Size(180, 22);
            this.comboBoxBinary2ndFS.TabIndex = 22;
            // 
            // comboBoxBinary1stFS
            // 
            this.comboBoxBinary1stFS.FormattingEnabled = true;
            this.comboBoxBinary1stFS.Location = new System.Drawing.Point(133, 56);
            this.comboBoxBinary1stFS.Name = "comboBoxBinary1stFS";
            this.comboBoxBinary1stFS.Size = new System.Drawing.Size(180, 22);
            this.comboBoxBinary1stFS.TabIndex = 21;
            // 
            // labBinary2ndFS
            // 
            this.labBinary2ndFS.AutoSize = true;
            this.labBinary2ndFS.Location = new System.Drawing.Point(130, 92);
            this.labBinary2ndFS.Name = "labBinary2ndFS";
            this.labBinary2ndFS.Size = new System.Drawing.Size(118, 14);
            this.labBinary2ndFS.TabIndex = 20;
            this.labBinary2ndFS.Text = "Second Fuzzy Set";
            // 
            // labBinary1stFS
            // 
            this.labBinary1stFS.AutoSize = true;
            this.labBinary1stFS.Location = new System.Drawing.Point(130, 39);
            this.labBinary1stFS.Name = "labBinary1stFS";
            this.labBinary1stFS.Size = new System.Drawing.Size(99, 14);
            this.labBinary1stFS.TabIndex = 19;
            this.labBinary1stFS.Text = "First Fuzzy Set";
            // 
            // labBinarySelection
            // 
            this.labBinarySelection.AutoSize = true;
            this.labBinarySelection.Location = new System.Drawing.Point(7, 11);
            this.labBinarySelection.Name = "labBinarySelection";
            this.labBinarySelection.Size = new System.Drawing.Size(174, 14);
            this.labBinarySelection.TabIndex = 18;
            this.labBinarySelection.Text = "Binary Operation Selection";
            // 
            // listBoxBinary
            // 
            this.listBoxBinary.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxBinary.FormattingEnabled = true;
            this.listBoxBinary.ItemHeight = 14;
            this.listBoxBinary.Items.AddRange(new object[] {
            "Intersect",
            "Algerbraic Sum",
            "Bounded Sum",
            "Drastic Sum",
            "Sugeno T-norm",
            "Sugeno S-norm",
            "Yager T-norm",
            "Yager S-norm"});
            this.listBoxBinary.Location = new System.Drawing.Point(10, 28);
            this.listBoxBinary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxBinary.Name = "listBoxBinary";
            this.listBoxBinary.Size = new System.Drawing.Size(113, 116);
            this.listBoxBinary.TabIndex = 17;
            this.listBoxBinary.Tag = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 534);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universe and Fuzzy Sets Creation";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Create.Panel1.ResumeLayout(false);
            this.Create.Panel1.PerformLayout();
            this.Create.Panel2.ResumeLayout(false);
            this.Create.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Create)).EndInit();
            this.Create.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartUniverse)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.FuzzytabControl.ResumeLayout(false);
            this.tabPrimary.ResumeLayout(false);
            this.tabPrimary.PerformLayout();
            this.tabUnary.ResumeLayout(false);
            this.tabUnary.PerformLayout();
            this.tabBinary.ResumeLayout(false);
            this.tabBinary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewUniverse;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer Create;
        private System.Windows.Forms.Label labUniverse;
        private System.Windows.Forms.Button btnCreateUniverse;
        private System.Windows.Forms.TextBox txtInc;
        private System.Windows.Forms.Button btnUpdateUniverse;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labMax;
        private System.Windows.Forms.Label labInc;
        private System.Windows.Forms.Label labtxt;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labFuzzySetTitle;
        private System.Windows.Forms.TextBox txtFuzzySetTitle;
        private System.Windows.Forms.Label labFuzzySet;
        private System.Windows.Forms.Label labP1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label labP4;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.Label labP3;
        private System.Windows.Forms.Button btnUpdateFuzzySet;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label labP2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUniverse;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label labFuzzySetSelection;
        private System.Windows.Forms.ListBox lsbOptions;
        private System.Windows.Forms.Button btnAddFuzzy;
        private System.Windows.Forms.ImageList imageListNode;
        private System.Windows.Forms.TabControl FuzzytabControl;
        private System.Windows.Forms.TabPage tabPrimary;
        private System.Windows.Forms.TabPage tabUnary;
        private System.Windows.Forms.Label labUnarySelection;
        private System.Windows.Forms.ListBox listBoxUnary;
        private System.Windows.Forms.TabPage tabBinary;
        private System.Windows.Forms.Label labBinarySelection;
        private System.Windows.Forms.ListBox listBoxBinary;
        private System.Windows.Forms.Label labUnaryTarget;
        private System.Windows.Forms.TextBox txtUnaryParameter;
        private System.Windows.Forms.Label labUnaryParameter;
        private System.Windows.Forms.TextBox txtUnaryTarget;
        private System.Windows.Forms.ComboBox comboBoxBinary2ndFS;
        private System.Windows.Forms.ComboBox comboBoxBinary1stFS;
        private System.Windows.Forms.Label labBinary2ndFS;
        private System.Windows.Forms.Label labBinary1stFS;
        private System.Windows.Forms.Button btnAddUnary;
        private System.Windows.Forms.Button btnAddBinary;

    }
}

