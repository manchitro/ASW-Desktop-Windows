﻿using DataLayer.Models;
using GUI.Controllers;
using GUI.Properties;
using GUI.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AllClassesForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public AllClassesForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;

            try
            {
                ClassController ccontroller = new ClassController();
                List<ClassModel> allClassesList = ccontroller.GetByFacultyId(faculty.Id);
                //Console.WriteLine(allClassesList.Count + " improper classes");
                List<ProperClassModel> properClassList = new List<ProperClassModel>();
                foreach (ClassModel model in allClassesList)
                {
                    ProperClassModel properModel = new ProperClassModel();
                    properModel.ClassDate = model.ClassDate;
                    properModel.ClassType = model.ClassType;
                    properModel.EndTimeId = model.EndTimeId;
                    properModel.Id = model.Id;
                    properModel.RoomNo = model.RoomNo;
                    properModel.SectionID = model.SectionID;
                    properModel.StartTimeId = model.StartTimeId;

                    //Console.WriteLine("improper date: " + model.ClassDate + " | proper date: " + properModel.ClassDate);

                    SectionController scontroller = new SectionController();
                    properModel.SectionName = scontroller.Get(model.SectionID).SectionName;

                    ClassTimeController ctcontroller = new ClassTimeController();
                    properModel.Time = ctcontroller.Get(model.StartTimeId).ClassTimeText + " - " + ctcontroller.Get(model.EndTimeId).ClassTimeText;

                    properClassList.Add(properModel);
                }
                MySortableBindingList<ProperClassModel> bindingClassesList = new MySortableBindingList<ProperClassModel>(properClassList);
                //Console.WriteLine(bindingClassesList.Count + " classes found");
                dataGridViewClassList.AutoGenerateColumns = false;
                dataGridViewClassList.DataSource = bindingClassesList;
                dataGridViewSerial.AutoGenerateColumns = false;
                dataGridViewSerial.DataSource = bindingClassesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridViewSerial.DataBindingComplete += (o, e) =>
            {
                foreach (DataGridViewRow row in dataGridViewSerial.Rows)
                {
                    row.Cells["sln"].Value = (row.Index + 1).ToString();
                }
            };
        }

        private void dataGridViewClassList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Console.WriteLine("Right mouse click");
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dataGridViewClassList.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverColumn = dataGridViewClassList.HitTest(e.X, e.Y).ColumnIndex;

                //if (currentMouseOverRow >= 0)
                {
                    var edit = new MenuItem(string.Format("Edit"));
                    var delete = new MenuItem(string.Format("Delete"));
                    m.MenuItems.Add(edit);
                    m.MenuItems.Add(delete);
                    ClassModel model = (ClassModel)dataGridViewClassList.Rows[currentMouseOverRow].DataBoundItem;
                    edit.Click += delegate (object s, EventArgs ev) { Edit_Click(sender, e, model); };
                    delete.Click += delegate (object s, EventArgs ev) { Delete_Click(sender, e, model); };
                }

                m.Show(dataGridViewClassList, new Point(e.X, e.Y));
            }
        }

        private void Delete_Click(object sender, MouseEventArgs e, ClassModel model)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this class?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClassController ccontroller = new ClassController();
                try
                {
                    AttendanceController acontroller = new AttendanceController();
                    acontroller.DeleteAllByClass(model.Id);

                    ccontroller.Delete(model);
                    MessageBox.Show("Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e, ClassModel model)
        {
            if (DateTime.Parse(model.ClassDate) >= DateTime.Today)
            {
                var editClass = new EditClassPopupForm(faculty, model);
                editClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                editClass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Can't edit past classes");
            }
        }

        private void ButtonBack_Click(object sender, System.EventArgs e)
        {
            var yourClasses = new YourClassesForm(faculty);
            yourClasses.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourClasses.Show();
            this.Hide();
        }
        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LabelSubtitle_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            var allClass = new AllClassesForm(faculty);
            allClass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            allClass.Show();
            this.Hide();
        }

        private void AllClassesForm_Load(object sender, EventArgs e)
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

        class ProperClassModel : ClassModel
        {
            public string SectionName { set; get; }
            public string Time { set; get; }
        }
    }
}
