namespace GUI.Views
{
    partial class FormAddSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSection));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAddSection = new System.Windows.Forms.Label();
            this.buttonCreateManually = new System.Windows.Forms.Button();
            this.buttonImportSpreadsheet = new System.Windows.Forms.Button();
            this.openFileDialogSpreadsheet = new System.Windows.Forms.OpenFileDialog();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelYourSections.SuspendLayout();
            this.SuspendLayout();
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
            this.labelWelcome.Size = new System.Drawing.Size(549, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.flowTodaysClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 188);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(250, 340);
            this.flowTodaysClass.TabIndex = 11;
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
            this.labelSubtitle.Click += new System.EventHandler(this.ButtonBack_Click);
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
            this.labelTitle.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panelYourSections);
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Controls.Add(this.buttonCreateManually);
            this.panel3.Controls.Add(this.buttonImportSpreadsheet);
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 521);
            this.panel3.TabIndex = 10;
            // 
            // panelYourSections
            // 
            this.panelYourSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(164)))), ((int)(((byte)(106)))));
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelAddSection);
            this.panelYourSections.Location = new System.Drawing.Point(0, 64);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(623, 75);
            this.panelYourSections.TabIndex = 7;
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
            // labelAddSection
            // 
            this.labelAddSection.AutoSize = true;
            this.labelAddSection.Font = new System.Drawing.Font("Arial", 17F);
            this.labelAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelAddSection.Location = new System.Drawing.Point(81, 25);
            this.labelAddSection.Name = "labelAddSection";
            this.labelAddSection.Size = new System.Drawing.Size(133, 26);
            this.labelAddSection.TabIndex = 0;
            this.labelAddSection.Text = "Add Section";
            // 
            // buttonCreateManually
            // 
            this.buttonCreateManually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonCreateManually.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateManually.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonCreateManually.FlatAppearance.BorderSize = 20;
            this.buttonCreateManually.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonCreateManually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonCreateManually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateManually.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateManually.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonCreateManually.Location = new System.Drawing.Point(38, 170);
            this.buttonCreateManually.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.buttonCreateManually.Name = "buttonCreateManually";
            this.buttonCreateManually.Size = new System.Drawing.Size(267, 103);
            this.buttonCreateManually.TabIndex = 23;
            this.buttonCreateManually.Text = "Create Manually";
            this.buttonCreateManually.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateManually.UseVisualStyleBackColor = false;
            this.buttonCreateManually.Click += new System.EventHandler(this.buttonCreateManually_Click);
            // 
            // buttonImportSpreadsheet
            // 
            this.buttonImportSpreadsheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonImportSpreadsheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImportSpreadsheet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonImportSpreadsheet.FlatAppearance.BorderSize = 20;
            this.buttonImportSpreadsheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonImportSpreadsheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(52)))), ((int)(((byte)(158)))));
            this.buttonImportSpreadsheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportSpreadsheet.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonImportSpreadsheet.Location = new System.Drawing.Point(308, 170);
            this.buttonImportSpreadsheet.Margin = new System.Windows.Forms.Padding(3, 0, 30, 0);
            this.buttonImportSpreadsheet.Name = "buttonImportSpreadsheet";
            this.buttonImportSpreadsheet.Size = new System.Drawing.Size(267, 103);
            this.buttonImportSpreadsheet.TabIndex = 26;
            this.buttonImportSpreadsheet.Text = "Import Spreadsheet";
            this.buttonImportSpreadsheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportSpreadsheet.UseVisualStyleBackColor = false;
            this.buttonImportSpreadsheet.Click += new System.EventHandler(this.buttonImportSpreadsheet_Click);
            // 
            // openFileDialogSpreadsheet
            // 
            this.openFileDialogSpreadsheet.Filter = "Excel files (*.xls or .xlsx)|.xls;*.xlsx";
            this.openFileDialogSpreadsheet.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)";
            this.openFileDialogSpreadsheet.RestoreDirectory = true;
            this.openFileDialogSpreadsheet.Title = "Open Spreadsheet";
            // 
            // FormAddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "FormAddSection";
            this.Text = "Attendance Scanning Wizard";
            this.Load += new System.EventHandler(this.FormAddSection_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelYourSections.ResumeLayout(false);
            this.panelYourSections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAddSection;
        private System.Windows.Forms.Button buttonCreateManually;
        private System.Windows.Forms.Button buttonImportSpreadsheet;
        private System.Windows.Forms.OpenFileDialog openFileDialogSpreadsheet;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
    }
}