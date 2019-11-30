using DataLayer.Models;
using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormAddClass : Form
    {
        public FacultyUserModel faculty = new FacultyUserModel();
        public FormAddClass(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = gotFaculty.FullName;

            SectionController controller = new SectionController();
            try
            {
                List<SectionModel> sectionList = controller.GetByFaculty(faculty);
                if (sectionList.Count == 0)
                {
                    Label noSections = new Label();
                    noSections.Text = "You have no sections added. To add a section,";
                    noSections.Font = new Font("Arial", 12, FontStyle.Regular);
                    noSections.TextAlign = ContentAlignment.MiddleCenter;
                    noSections.ForeColor = Color.FromArgb(217, 217, 217);
                    noSections.AutoSize = true;
                    noSections.Margin = new Padding(3, 3, 0, 3);

                    flowLayoutPanelSections.Controls.Add(noSections);

                    Label clickHere = new Label();
                    clickHere.Text = "click here";
                    clickHere.Font = new Font("Arial", 12, FontStyle.Underline);
                    clickHere.ForeColor = Color.FromArgb(217, 217, 217);
                    clickHere.Margin = new Padding(0, 3, 3, 3);
                    clickHere.Cursor = Cursors.Hand;
                    clickHere.Click += new System.EventHandler(this.ClickHere_Click); ;

                    flowLayoutPanelSections.Controls.Add(clickHere);
                }
                int r = 129;
                int g = 74;
                int b = 36;
                int i = 0;
                foreach (SectionModel model in sectionList)
                {
                    //Console.WriteLine("Name: " + model.SectionName);
                    FlowLayoutPanel sectionPanel = new FlowLayoutPanel();
                    sectionPanel.Width = 188;
                    sectionPanel.Height = 110;
                    sectionPanel.BorderStyle = BorderStyle.None;
                    sectionPanel.Margin = new Padding(0, 3, 7, 5);
                    sectionPanel.BackColor = Color.FromArgb(r,g,b);
                    sectionPanel.FlowDirection = FlowDirection.LeftToRight;
                    sectionPanel.WrapContents = true;
                    sectionPanel.AutoScroll = false;
                    sectionPanel.VerticalScroll.Visible = false;
                    sectionPanel.HorizontalScroll.Enabled = false;
                    flowLayoutPanelSections.Controls.Add(sectionPanel);

                    Label labelSectionName = new Label();
                    labelSectionName.Text = model.SectionName;
                    labelSectionName.Font = new Font("Arial", 10, FontStyle.Regular);
                    labelSectionName.ForeColor = Color.FromArgb(217, 217, 217);
                    labelSectionName.AutoSize = false;
                    labelSectionName.Size = new Size(sectionPanel.Width - 4, 32);
                    labelSectionName.Margin = new Padding(5, 8, 0, 3);
                    labelSectionName.UseMnemonic = false;

                    sectionPanel.Controls.Add(labelSectionName);

                    SectionTimeController timeController = new SectionTimeController();
                    List<SectionTimeModel> sectionTimes = timeController.GetBySection(model);

                    foreach (SectionTimeModel timeModel in sectionTimes)
                    {
                        WeekDayController dayCon = new WeekDayController();
                        ClassTimeController classCon = new ClassTimeController();

                        Label sectionTimeText1 = new Label();
                        sectionTimeText1.Text = timeModel.ClassType + ": " + dayCon.Get(timeModel.WeekDayID).WeekDayText.Substring(0, 3) + " " + classCon.Get(timeModel.StartTimeId).ClassTimeText + " - " + classCon.Get(timeModel.EndTimeId).ClassTimeText + " [" + timeModel.RoomNo + "]";
                        if (sectionTimes.Count == 2)
                            sectionTimeText1.AutoSize = true;
                        else
                            sectionTimeText1.Size = new Size(sectionPanel.Width - 4, 32);
                        sectionTimeText1.Font = new Font("Arial", 8, FontStyle.Italic);
                        sectionTimeText1.ForeColor = Color.FromArgb(217, 217, 217);

                        if (timeModel == sectionTimes[0])
                            sectionTimeText1.Margin = new Padding(4, 0, 0, 0);
                        else
                            sectionTimeText1.Margin = new Padding(4, 0, 0, 4);

                        sectionPanel.Controls.Add(sectionTimeText1);
                    }

                    Button addClassButton = new Button();
                    addClassButton.Text = "Add a Class";
                    addClassButton.BackColor = Color.FromArgb(149, 94, 56);
                    addClassButton.Cursor = Cursors.Hand;
                    addClassButton.FlatAppearance.BorderSize = 0;
                    addClassButton.FlatStyle = FlatStyle.Flat;
                    addClassButton.Font = new Font("Arial", 10F);
                    addClassButton.ForeColor = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    addClassButton.AutoSize = false;
                    addClassButton.Size = new Size(172, 25);
                    addClassButton.Margin = new Padding(8, 2, 0, 0);
                    addClassButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                    //addClassButton.Dock = DockStyle.Bottom | DockStyle.Left;
                    addClassButton.Click += delegate (object sender, EventArgs e) { addClassButton_Click(sender, e, model); };

                    sectionPanel.Controls.Add(addClassButton);

                    if (i % 3 == 0)
                    {
                        r -= 5; g -= 5;b -= 5;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addClassButton_Click(object sender, EventArgs e, SectionModel section)
        {
            //Console.WriteLine("add class clicked on " + section.SectionName);
            var addclass = new AddClassPopupForm(faculty, section);
            addclass.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addclass.ShowDialog();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            var addSection = new FormAddSection(faculty);
            addSection.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            addSection.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
