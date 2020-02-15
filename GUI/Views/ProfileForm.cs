﻿using DataLayer.Models;
using DataLayer.Models.BaseModels;
using GUI.Controllers;
using GUI.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class ProfileForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public ProfileForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;
            textBoxFirstName.Text = faculty.FirstName;
            textBoxLastName.Text = faculty.LastName;
            textBoxEmail.Text = faculty.Email;
            labelId.Text = faculty.AcademicId;
            //faculty.
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            dash.Left = this.Left;
            dash.Top = this.Top;
            dash.Size = this.Size;
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var pass = new ChangePasswordForm(faculty);
            pass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            pass.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                FacultyUserModel updatedModel = new FacultyUserModel();
                updatedModel.AcademicId = faculty.AcademicId;
                updatedModel.FirstName = textBoxFirstName.Text.Trim();
                updatedModel.LastName = textBoxLastName.Text.Trim();
                updatedModel.Email = textBoxEmail.Text.ToLower().Trim();
                updatedModel.Id = faculty.Id;
                updatedModel.Password = faculty.Password;

                try
                {
                    updatedModel.IsValid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (MessageBox.Show("Save changes?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var controller = new UserController();
                        faculty = controller.Update(updatedModel);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset all fields?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                textBoxFirstName.Text = faculty.FirstName;
                textBoxLastName.Text = faculty.LastName;
                textBoxEmail.Text = faculty.Email;
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            flowTodaysClass.Width = panelLeft.Width + SystemInformation.VerticalScrollBarWidth;
            ClassController ccontroller = new ClassController();
            ClassTimeController classTimeController = new ClassTimeController();
            List<ClassModel> todaysClasses = ccontroller.GetByDateAndFacultyId(DateTime.Today.ToString("yyyy-MM-dd"), faculty.Id);
            int i = 0;
            foreach (ClassModel Class in todaysClasses)
            {
                FlowLayoutPanel todaysClassPanel = new FlowLayoutPanel();
                todaysClassPanel.Size = new System.Drawing.Size(250, 80);
                todaysClassPanel.Margin = new Padding(0, 0, 0, 0);
                if (i % 2 == 0)
                {
                    todaysClassPanel.BackColor = Color.FromArgb(59, 59, 59);
                }
                else
                {
                    todaysClassPanel.BackColor = Color.FromArgb(48, 48, 48);
                }

                SectionController scontroller = new SectionController();

                Label sectionName = new Label();
                sectionName.Font = new Font("Arial", 9.5F, System.Drawing.FontStyle.Bold);
                sectionName.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                sectionName.Location = new Point(8, 8);
                sectionName.Margin = new Padding(8, 5, 4, 4);
                sectionName.Size = new Size(188, 36);
                sectionName.TabIndex = 0;
                sectionName.Text = scontroller.Get(Class.SectionID).SectionName;
                sectionName.TextAlign = ContentAlignment.MiddleLeft;

                Button qr = new Button();
                qr.BackgroundImage = Resources.qr;
                qr.BackgroundImageLayout = ImageLayout.Stretch;
                qr.FlatAppearance.BorderSize = 0;
                qr.Cursor = Cursors.Hand;
                qr.FlatStyle = FlatStyle.Flat;
                qr.Location = new Point(202, 8);
                qr.Margin = new Padding(2, 8, 2, 2);
                qr.Size = new Size(33, 33);
                qr.TabIndex = 4;
                qr.UseVisualStyleBackColor = true;

                qr.Click += delegate (object s, EventArgs ev) { qrButton_Click(sender, e, Class); };

                Label classType = new Label();
                classType.Font = new Font("Arial", 10.2F);
                classType.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                classType.Location = new Point(8, 48);
                classType.Margin = new Padding(8, 0, 4, 4);
                classType.Name = "label2";
                classType.Size = new Size(53, 28);
                classType.TabIndex = 1;
                classType.Text = Class.ClassType.ToString();
                classType.TextAlign = ContentAlignment.MiddleLeft;

                Label time = new Label();
                time.Font = new Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                time.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                time.Location = new Point(69, 48);
                time.Margin = new Padding(4, 0, 4, 4);
                time.Size = new Size(104, 28);
                time.TabIndex = 2;
                time.Text = classTimeController.Get(Class.StartTimeId).ClassTimeText + " - " + classTimeController.Get(Class.EndTimeId).ClassTimeText;
                time.TextAlign = ContentAlignment.MiddleCenter;

                Label room = new Label();
                room.Font = new Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                room.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                room.Location = new Point(181, 48);
                room.Margin = new Padding(4, 0, 4, 4);
                room.Size = new Size(52, 28);
                room.TabIndex = 3;
                room.Text = Class.RoomNo;
                room.TextAlign = ContentAlignment.MiddleRight;

                todaysClassPanel.Controls.Add(sectionName);
                todaysClassPanel.Controls.Add(qr);
                todaysClassPanel.Controls.Add(classType);
                todaysClassPanel.Controls.Add(time);
                todaysClassPanel.Controls.Add(room);

                flowTodaysClass.Controls.Add(todaysClassPanel);
                i++;
            }
        }

        private void qrButton_Click(object sender, EventArgs e, ClassModel Class)
        {
            if (Class.QRDisplayStartTime == null)
            {
                //Console.WriteLine("Clicked class QR: " + Encoding.UTF8.GetString(Convert.FromBase64String(Class.QRCode)));
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData data = qRCodeGenerator.CreateQrCode(Class.QRCode, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                Bitmap image = code.GetGraphic(50);

                ClassController classController = new ClassController();
                try
                {
                    var updatedClass = classController.InsertQRDisplayStartTime(Class.Id, DateTime.Now.ToString());

                    var qrForm = new QRdisplayForm(Class, image);
                    qrForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to show QR again? Previous display time will be overwritten!",
                                     "Confirm",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //Console.WriteLine("Clicked class QR: " + Encoding.UTF8.GetString(Convert.FromBase64String(Class.QRCode)));
                    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                    QRCodeData data = qRCodeGenerator.CreateQrCode(Class.QRCode, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    Bitmap image = code.GetGraphic(50);

                    ClassController classController = new ClassController();
                    try
                    {
                        //var updatedClass = classController.InsertQRDisplayStartTime(Class.Id, DateTime.Now.ToString());

                        var qrForm = new QRdisplayForm(Class, image);
                        qrForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}