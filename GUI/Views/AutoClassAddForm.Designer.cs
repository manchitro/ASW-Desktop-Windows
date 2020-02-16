namespace GUI.Views
{
    partial class AutoClassAddForm
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
            this.labelYourClasses = new System.Windows.Forms.Label();
            this.flowClassList = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelClassesSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelYourClasses
            // 
            this.labelYourClasses.AutoSize = true;
            this.labelYourClasses.Font = new System.Drawing.Font("Arial", 14F);
            this.labelYourClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourClasses.Location = new System.Drawing.Point(40, 41);
            this.labelYourClasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYourClasses.Name = "labelYourClasses";
            this.labelYourClasses.Size = new System.Drawing.Size(343, 32);
            this.labelYourClasses.TabIndex = 1;
            this.labelYourClasses.Text = "Create Classes for Section";
            // 
            // flowClassList
            // 
            this.flowClassList.AutoScroll = true;
            this.flowClassList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.flowClassList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowClassList.Location = new System.Drawing.Point(46, 99);
            this.flowClassList.Name = "flowClassList";
            this.flowClassList.Size = new System.Drawing.Size(550, 342);
            this.flowClassList.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonLogin.Location = new System.Drawing.Point(484, 473);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(82, 40, 0, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 42);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Skip";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(76)))), ((int)(((byte)(83)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button1.Location = new System.Drawing.Point(351, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(82, 40, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelClassesSelected
            // 
            this.labelClassesSelected.AutoSize = true;
            this.labelClassesSelected.Font = new System.Drawing.Font("Arial", 10F);
            this.labelClassesSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelClassesSelected.Location = new System.Drawing.Point(42, 483);
            this.labelClassesSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassesSelected.Name = "labelClassesSelected";
            this.labelClassesSelected.Size = new System.Drawing.Size(184, 23);
            this.labelClassesSelected.TabIndex = 9;
            this.labelClassesSelected.Text = "24 classes selected";
            // 
            // AutoClassAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(651, 546);
            this.Controls.Add(this.labelClassesSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.flowClassList);
            this.Controls.Add(this.labelYourClasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoClassAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AutoClassAddForm";
            this.Load += new System.EventHandler(this.AutoClassAddForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AutoClassAddForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourClasses;
        private System.Windows.Forms.FlowLayoutPanel flowClassList;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelClassesSelected;
    }
}