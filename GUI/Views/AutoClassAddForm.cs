using DataLayer.Models;
using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class AutoClassAddForm : Form
    {
        SectionModel section = new SectionModel();
        List<SectionTimeModel> sectionTimes = new List<SectionTimeModel>();
        List<ClassModel> classesToBeAdded = new List<ClassModel>();
        public AutoClassAddForm(SectionModel gotSection)
        {
            InitializeComponent();
            section = gotSection;

            SectionTimeController stcontroller = new SectionTimeController();
            sectionTimes = stcontroller.GetBySection(section);
        }

        private void AutoClassAddForm_Load(object sender, EventArgs e)
        {
            ClassTimeController ctcontroller = new ClassTimeController();
            List<ClassTimeModel> classTimes = ctcontroller.Get();
            classesToBeAdded = new List<ClassModel>();
            int classNo = 0;

            DateTime today = DateTime.Today;
            if (sectionTimes.Count == 2)
            {
                int daysUntilNextST1day = sectionTimes[0].WeekDayID - (int)today.DayOfWeek;
                int daysUntilNextST2day = sectionTimes[1].WeekDayID - (int)today.DayOfWeek;
                for (int week = 0; week < 12; week++)
                {
                    ClassModel class1 = new ClassModel();
                    class1.ClassDate = today.AddDays(daysUntilNextST1day+(week*7)).ToString("yyyy-MM-dd");
                    class1.ClassType = sectionTimes[0].ClassType;
                    class1.StartTimeId = sectionTimes[0].StartTimeId;
                    class1.EndTimeId = sectionTimes[0].EndTimeId;
                    class1.RoomNo = sectionTimes[0].RoomNo;
                    class1.SectionID = section.Id;

                    FlowLayoutPanel flowClass = new FlowLayoutPanel();
                    flowClass.Location = new System.Drawing.Point(46, 462);
                    flowClass.Margin = new System.Windows.Forms.Padding(0);
                    flowClass.Name = "flowClass";
                    flowClass.Size = new System.Drawing.Size(483, 42);
                    flowClass.TabIndex = 3;
                    flowClass.BackColor = Color.FromArgb(48,48,48);
                    flowClass.WrapContents = false;

                    CheckBox check = new CheckBox();
                    check.AutoSize = true;
                    check.Font = new System.Drawing.Font("Arial", 12F);
                    check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    check.Location = new System.Drawing.Point(6, 6);
                    check.Margin = new System.Windows.Forms.Padding(6);
                    check.Name = "checkBox1";
                    check.Size = new System.Drawing.Size(98, 31);
                    check.TabIndex = 3;
                    check.Text = class1.ClassType + " :- " + class1.ClassDate + "(" + DateTime.Parse(class1.ClassDate).DayOfWeek + ") at " + classTimes[class1.StartTimeId].ClassTimeText;
                    check.Checked = true;
                    check.UseVisualStyleBackColor = true;
                    check.CheckedChanged += delegate (object s, EventArgs ev) { Check_CheckedChanged(sender, e, check.Text); };

                    flowClass.Controls.Add(check);
                    classesToBeAdded.Add(class1);
                    classNo++;

                    ClassModel class2 = new ClassModel();
                    class2.ClassDate = today.AddDays(daysUntilNextST2day + (week * 7)).ToString("yyyy-MM-dd");
                    class2.ClassType = sectionTimes[1].ClassType;
                    class2.StartTimeId = sectionTimes[1].StartTimeId;
                    class2.EndTimeId = sectionTimes[1].EndTimeId;
                    class2.RoomNo = sectionTimes[1].RoomNo;
                    class2.SectionID = section.Id;

                    FlowLayoutPanel flowClass2 = new FlowLayoutPanel();
                    flowClass2.Location = new System.Drawing.Point(46, 462);
                    flowClass2.Margin = new System.Windows.Forms.Padding(0);
                    flowClass2.Name = "flowClass";
                    flowClass2.Size = new System.Drawing.Size(483, 42);
                    flowClass2.TabIndex = 3;
                    flowClass2.WrapContents = false;

                    CheckBox check2 = new CheckBox();
                    check2.AutoSize = true;
                    check2.Font = new System.Drawing.Font("Arial", 12F);
                    check2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    check2.Location = new System.Drawing.Point(6, 6);
                    check2.Margin = new System.Windows.Forms.Padding(6);
                    check2.Name = "checkBox1";
                    check2.Size = new System.Drawing.Size(98, 31);
                    check2.TabIndex = 3;
                    check2.Text = class2.ClassType + " :- " + class2.ClassDate + "(" + DateTime.Parse(class2.ClassDate).DayOfWeek + ") at " + classTimes[class2.StartTimeId].ClassTimeText;
                    check2.Checked = true;
                    check2.UseVisualStyleBackColor = true;
                    check2.CheckedChanged += delegate (object s, EventArgs ev) { Check_CheckedChanged(sender, e, check.Text); };

                    flowClass2.Controls.Add(check2);
                    classesToBeAdded.Add(class2);
                    classNo++;

                    flowClassList.Controls.Add(flowClass);
                    flowClassList.Controls.Add(flowClass2);
                }

                labelClassesSelected.Text = classesToBeAdded.Count + " classes selected";
            }
            else if(sectionTimes.Count == 1)
            {
                int daysUntilNextST1day = sectionTimes[0].WeekDayID - (int)today.DayOfWeek;
                for (int week = 0; week < 12; week++)
                {
                    ClassModel class1 = new ClassModel();
                    class1.ClassDate = today.AddDays(daysUntilNextST1day + (week * 7)).ToString("yyyy-MM-dd");
                    class1.ClassType = sectionTimes[0].ClassType;
                    class1.StartTimeId = sectionTimes[0].StartTimeId;
                    class1.EndTimeId = sectionTimes[0].EndTimeId;
                    class1.RoomNo = sectionTimes[0].RoomNo;
                    class1.SectionID = section.Id;

                    FlowLayoutPanel flowClass = new FlowLayoutPanel();
                    flowClass.Location = new System.Drawing.Point(46, 462);
                    flowClass.Margin = new System.Windows.Forms.Padding(0);
                    flowClass.Name = "flowClass";
                    flowClass.Size = new System.Drawing.Size(483, 42);
                    flowClass.TabIndex = 3;
                    flowClass.BackColor = Color.FromArgb(48, 48, 48);
                    flowClass.WrapContents = false;

                    CheckBox check = new CheckBox();
                    check.AutoSize = true;
                    check.Font = new System.Drawing.Font("Arial", 12F);
                    check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                    check.Location = new System.Drawing.Point(6, 6);
                    check.Margin = new System.Windows.Forms.Padding(6);
                    check.Name = "checkBox1";
                    check.Size = new System.Drawing.Size(98, 31);
                    check.TabIndex = 3;
                    check.Text = week + 1 + ": " + class1.ClassType + " :- " + class1.ClassDate + "(" + DateTime.Parse(class1.ClassDate).DayOfWeek + ") at " + classTimes[class1.StartTimeId].ClassTimeText;
                    check.Checked = true;
                    check.UseVisualStyleBackColor = true;
                    check.CheckedChanged += delegate (object s, EventArgs ev) { Check_CheckedChanged(sender, e, check.Text); };

                    flowClass.Controls.Add(check);
                    classesToBeAdded.Add(class1);
                    classNo++;

                    flowClassList.Controls.Add(flowClass);
                }
            }
            
        }

        private void Check_CheckedChanged(object sender, EventArgs e, string text)
        {
            //Console.WriteLine("Recieved text: " + text);

            labelClassesSelected.Text = classesToBeAdded.Count + " classes selected";
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AutoClassAddForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                            this.DisplayRectangle);
        }
    }
}
