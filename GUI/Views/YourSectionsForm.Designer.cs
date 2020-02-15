﻿namespace GUI.Views
{
    partial class YourSectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourSectionsForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.flowTodaysClass = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTodaysClasses = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSections = new System.Windows.Forms.FlowLayoutPanel();
            this.panelYourSections = new System.Windows.Forms.Panel();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelYourSections = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelYourSections.SuspendLayout();
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
            this.panelLeft.TabIndex = 4;
            // 
            // flowTodaysClass
            // 
            this.flowTodaysClass.AutoScroll = true;
            this.flowTodaysClass.Location = new System.Drawing.Point(0, 188);
            this.flowTodaysClass.Margin = new System.Windows.Forms.Padding(0);
            this.flowTodaysClass.Name = "flowTodaysClass";
            this.flowTodaysClass.Size = new System.Drawing.Size(250, 322);
            this.flowTodaysClass.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.labelTodaysClasses);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 50);
            this.panel2.TabIndex = 4;
            // 
            // labelTodaysClasses
            // 
            this.labelTodaysClasses.AutoSize = true;
            this.labelTodaysClasses.Font = new System.Drawing.Font("Arial", 13F);
            this.labelTodaysClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelTodaysClasses.Location = new System.Drawing.Point(12, 15);
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
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelWelcome.Location = new System.Drawing.Point(35, 16);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(10, 10, 30, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(548, 33);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Faculty";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.flowLayoutPanelSections);
            this.panel3.Controls.Add(this.panelYourSections);
            this.panel3.Controls.Add(this.labelWelcome);
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 521);
            this.panel3.TabIndex = 6;
            // 
            // flowLayoutPanelSections
            // 
            this.flowLayoutPanelSections.AutoScroll = true;
            this.flowLayoutPanelSections.Location = new System.Drawing.Point(11, 146);
            this.flowLayoutPanelSections.Margin = new System.Windows.Forms.Padding(11, 8, 0, 0);
            this.flowLayoutPanelSections.Name = "flowLayoutPanelSections";
            this.flowLayoutPanelSections.Size = new System.Drawing.Size(605, 362);
            this.flowLayoutPanelSections.TabIndex = 8;
            // 
            // panelYourSections
            // 
            this.panelYourSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelYourSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.panelYourSections.Controls.Add(this.buttonAddSection);
            this.panelYourSections.Controls.Add(this.buttonBack);
            this.panelYourSections.Controls.Add(this.labelYourSections);
            this.panelYourSections.Location = new System.Drawing.Point(0, 63);
            this.panelYourSections.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelYourSections.Name = "panelYourSections";
            this.panelYourSections.Size = new System.Drawing.Size(616, 75);
            this.panelYourSections.TabIndex = 7;
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(143)))), ((int)(((byte)(164)))));
            this.buttonAddSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSection.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonAddSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAddSection.Location = new System.Drawing.Point(502, 26);
            this.buttonAddSection.Margin = new System.Windows.Forms.Padding(55, 26, 0, 0);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(75, 27);
            this.buttonAddSection.TabIndex = 9;
            this.buttonAddSection.Text = "Add";
            this.buttonAddSection.UseVisualStyleBackColor = false;
            this.buttonAddSection.Click += new System.EventHandler(this.ButtonAddSection_Click);
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
            // labelYourSections
            // 
            this.labelYourSections.AutoSize = true;
            this.labelYourSections.Font = new System.Drawing.Font("Arial", 17F);
            this.labelYourSections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.labelYourSections.Location = new System.Drawing.Point(81, 25);
            this.labelYourSections.Name = "labelYourSections";
            this.labelYourSections.Size = new System.Drawing.Size(151, 26);
            this.labelYourSections.TabIndex = 0;
            this.labelYourSections.Text = "Your Sections";
            // 
            // YourSectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "YourSectionsForm";
            this.Text = "Attendance Scanning Wizard";
            this.Load += new System.EventHandler(this.FormYourSections_Load);
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

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTodaysClasses;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelYourSections;
        private System.Windows.Forms.Label labelYourSections;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSections;
        private System.Windows.Forms.FlowLayoutPanel flowTodaysClass;
        private System.Windows.Forms.Button buttonAddSection;
    }
}