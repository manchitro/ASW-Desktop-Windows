namespace GUI.Views
{
    partial class AllClassesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllClassesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelYourClasses = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.dataGridViewSerial = new System.Windows.Forms.DataGridView();
            this.sln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewClassList = new System.Windows.Forms.DataGridView();
            this.SectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelYourSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelLeft.Controls.Add(this.flowTodaysClass);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.labelSubtitle);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 521);
            this.panelLeft.TabIndex = 9;
            // 
            // flowTodaysClass
            // 
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 188);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(250, 334);
            this.flowTodaysClass.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelTodaysClasses);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 51);
            this.panel2.TabIndex = 4;
            // 
            // labelTodaysClasses
            // 
            this.labelTodaysClasses.AutoSize = true;
            this.labelTodaysClasses.Font = new System.Drawing.Font("Arial", 13F);
            this.labelTodaysClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelTodaysClasses.Location = new System.Drawing.Point(12, 14);
            this.labelTodaysClasses.Name = "labelTodaysClasses";
            this.labelTodaysClasses.Size = new System.Drawing.Size(140, 21);
            this.labelTodaysClasses.TabIndex = 0;
            this.labelTodaysClasses.Text = "Today\'s Classes";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSubtitle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelSubtitle.Location = new System.Drawing.Point(59, 88);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(52, 20, 0, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(126, 20);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "Automate Your Class";
            this.labelSubtitle.Click += new System.EventHandler(this.LabelSubtitle_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelTitle.Location = new System.Drawing.Point(53, 30);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 62);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "ASW";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.LabelSubtitle_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridViewSerial);
            this.panel3.Controls.Add(this.dataGridViewClassList);
            this.panel3.Controls.Add(this.panelYourSections);
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 528);
            this.panel3.TabIndex = 10;
            // 
            // panelYourSections
            // 
            this.panelYourSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.panelYourSections.Controls.Add(this.buttonDeleteAll);
            this.panelYourSections.Controls.Add(this.buttonRefresh);
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelYourClasses);
            this.panelYourSections.Location = new System.Drawing.Point(0, 64);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(637, 75);
            this.panelYourSections.TabIndex = 7;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAll.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonDeleteAll.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteAll.Location = new System.Drawing.Point(396, 25);
            this.buttonDeleteAll.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(98, 27);
            this.buttonDeleteAll.TabIndex = 10;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonRefresh.Location = new System.Drawing.Point(512, 25);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 27);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // labelYourClasses
            // 
            this.labelYourClasses.AutoSize = true;
            this.labelYourClasses.Font = new System.Drawing.Font("Arial", 17F);
            this.labelYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourClasses.Location = new System.Drawing.Point(81, 25);
            this.labelYourClasses.Name = "labelYourClasses";
            this.labelYourClasses.Size = new System.Drawing.Size(124, 26);
            this.labelYourClasses.TabIndex = 0;
            this.labelYourClasses.Text = "All Classes";
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(35, 16);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(10, 10, 30, 10);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(552, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewSerial
            // 
            this.dataGridViewSerial.AllowUserToAddRows = false;
            this.dataGridViewSerial.AllowUserToDeleteRows = false;
            this.dataGridViewSerial.AllowUserToOrderColumns = true;
            this.dataGridViewSerial.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSerial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSerial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridViewSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSerial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSerial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSerial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSerial.ColumnHeadersHeight = 21;
            this.dataGridViewSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSerial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sln});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSerial.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewSerial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSerial.EnableHeadersVisualStyles = false;
            this.dataGridViewSerial.Location = new System.Drawing.Point(0, 139);
            this.dataGridViewSerial.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSerial.MultiSelect = false;
            this.dataGridViewSerial.Name = "dataGridViewSerial";
            this.dataGridViewSerial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSerial.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewSerial.RowHeadersVisible = false;
            this.dataGridViewSerial.RowHeadersWidth = 51;
            this.dataGridViewSerial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSerial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSerial.Size = new System.Drawing.Size(34, 383);
            this.dataGridViewSerial.StandardTab = true;
            this.dataGridViewSerial.TabIndex = 15;
            // 
            // sln
            // 
            this.sln.HeaderText = "#";
            this.sln.MinimumWidth = 6;
            this.sln.Name = "sln";
            this.sln.ReadOnly = true;
            this.sln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sln.Width = 35;
            // 
            // dataGridViewClassList
            // 
            this.dataGridViewClassList.AllowUserToAddRows = false;
            this.dataGridViewClassList.AllowUserToDeleteRows = false;
            this.dataGridViewClassList.AllowUserToOrderColumns = true;
            this.dataGridViewClassList.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewClassList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewClassList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.dataGridViewClassList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewClassList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClassList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewClassList.ColumnHeadersHeight = 21;
            this.dataGridViewClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionName,
            this.ClassDate,
            this.ClassTime,
            this.RoomNo,
            this.ClassType});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClassList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewClassList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClassList.EnableHeadersVisualStyles = false;
            this.dataGridViewClassList.Location = new System.Drawing.Point(34, 139);
            this.dataGridViewClassList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewClassList.MultiSelect = false;
            this.dataGridViewClassList.Name = "dataGridViewClassList";
            this.dataGridViewClassList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClassList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewClassList.RowHeadersVisible = false;
            this.dataGridViewClassList.RowHeadersWidth = 51;
            this.dataGridViewClassList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClassList.Size = new System.Drawing.Size(592, 383);
            this.dataGridViewClassList.StandardTab = true;
            this.dataGridViewClassList.TabIndex = 16;
            // 
            // SectionName
            // 
            this.SectionName.DataPropertyName = "SectionName";
            this.SectionName.HeaderText = "Section";
            this.SectionName.MinimumWidth = 6;
            this.SectionName.Name = "SectionName";
            this.SectionName.Width = 250;
            // 
            // ClassDate
            // 
            this.ClassDate.DataPropertyName = "ClassDate";
            this.ClassDate.HeaderText = "Date";
            this.ClassDate.MinimumWidth = 6;
            this.ClassDate.Name = "ClassDate";
            this.ClassDate.Width = 125;
            // 
            // ClassTime
            // 
            this.ClassTime.DataPropertyName = "Time";
            this.ClassTime.HeaderText = "Time";
            this.ClassTime.MinimumWidth = 6;
            this.ClassTime.Name = "ClassTime";
            this.ClassTime.Width = 125;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "Room No";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Width = 80;
            // 
            // ClassType
            // 
            this.ClassType.DataPropertyName = "ClassType";
            this.ClassType.HeaderText = "Class Type";
            this.ClassType.MinimumWidth = 6;
            this.ClassType.Name = "ClassType";
            this.ClassType.Width = 125;
            // 
            // AllClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "AllClassesForm";
            this.Text = "Attendance Scanning Wizard";
            this.Load += new System.EventHandler(this.AllClassesForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelYourSections.ResumeLayout(false);
            this.panelYourSections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSerial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelYourClasses;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.DataGridView dataGridViewSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn sln;
        private System.Windows.Forms.DataGridView dataGridViewClassList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassType;
    }
}