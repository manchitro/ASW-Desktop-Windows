using DataLayer.Models;
using DataLayer.Utils;
using GUI.Controllers;
using GUI.Controllers.BaseController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class EditSectionForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        SectionModel section = new SectionModel();
        List<SectionTimeModel> sectionTimes = new List<SectionTimeModel>();
        public EditSectionForm(FacultyUserModel gotFaculty, SectionModel gotSection, List<SectionTimeModel> gotSectionTimes)
        {
            InitializeComponent();
            faculty = gotFaculty;
            section = gotSection;
            sectionTimes = gotSectionTimes;
            labelWelcome.Text = faculty.FullName;
            labelEditSection.Text = "Edit section: " + section.SectionName;
            textBoxSectionName.Text = section.SectionName;

            List<WeekDayModel> dayList1 = new List<WeekDayModel>();
            WeekDayController dayController1 = new WeekDayController();
            dayList1 = dayController1.Get();

            comboBoxWeekDay1.DataSource = dayList1;
            comboBoxWeekDay1.DisplayMember = "WeekDayText";
            comboBoxWeekDay1.ValueMember = "Id";

            comboBoxWeekDay1.SelectedIndex = sectionTimes[0].WeekDayID - 1;

            List<WeekDayModel> dayList2 = new List<WeekDayModel>();
            WeekDayController dayController2 = new WeekDayController();
            dayList2 = dayController2.Get();

            comboBoxWeekDay2.DataSource = dayList2;
            comboBoxWeekDay2.DisplayMember = "WeekDayText";
            comboBoxWeekDay2.ValueMember = "Id";

            if(!(sectionTimes.Count == 1))
                comboBoxWeekDay2.SelectedIndex = sectionTimes[1].WeekDayID - 1;

            List<ClassTimeModel> timeListStart1 = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart1 = new ClassTimeController();
            timeListStart1 = timeControllerStart1.Get();

            comboBoxStartTime1.DataSource = timeListStart1;
            comboBoxStartTime1.DisplayMember = "ClassTimeText";
            comboBoxStartTime1.ValueMember = "Id";

            comboBoxStartTime1.SelectedIndex = sectionTimes[0].StartTimeId - 1;

            List<ClassTimeModel> timeListStart2 = new List<ClassTimeModel>();
            ClassTimeController timeControllerStart2 = new ClassTimeController();
            timeListStart2 = timeControllerStart2.Get();

            comboBoxStartTime2.DataSource = timeListStart2;
            comboBoxStartTime2.DisplayMember = "ClassTimeText";
            comboBoxStartTime2.ValueMember = "Id";
            if (!(sectionTimes.Count == 1))
                comboBoxStartTime2.SelectedIndex = sectionTimes[1].StartTimeId - 1;

            List<ClassTimeModel> timeListEnd1 = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd1 = new ClassTimeController();
            timeListEnd1 = timeControllerEnd1.Get();

            comboBoxEndTime1.DataSource = timeListEnd1;
            comboBoxEndTime1.DisplayMember = "ClassTimeText";
            comboBoxEndTime1.ValueMember = "Id";

            comboBoxEndTime1.SelectedIndex = sectionTimes[0].EndTimeId - 1;

            List<ClassTimeModel> timeListEnd2 = new List<ClassTimeModel>();
            ClassTimeController timeControllerEnd2 = new ClassTimeController();
            timeListEnd2 = timeControllerEnd2.Get();

            comboBoxEndTime2.DataSource = timeListEnd2;
            comboBoxEndTime2.DisplayMember = "ClassTimeText";
            comboBoxEndTime2.ValueMember = "Id";
            if (!(sectionTimes.Count == 1))
                comboBoxEndTime2.SelectedIndex = sectionTimes[1].EndTimeId - 1;

            comboBoxClassType1.DataSource = Enum.GetValues(typeof(ClassTypes));
            comboBoxClassType2.DataSource = Enum.GetValues(typeof(ClassTypes));

            comboBoxClassType1.SelectedItem = sectionTimes[0].ClassType;
            if (!(sectionTimes.Count == 1))
                comboBoxClassType2.SelectedItem = sectionTimes[1].ClassType;

            textBoxRoomNo1.Text = sectionTimes[0].RoomNo;
            if (!(sectionTimes.Count == 1))
                textBoxRoomNo2.Text = sectionTimes[1].RoomNo;
            //if (!(sectionTimes.Count == 1))
                //Console.WriteLine(sectionTimes[0].Id + " " + sectionTimes[1].Id);

            if ((sectionTimes.Count == 1))
            {
                checkBoxIgnore.Checked = true;
                panel3.Controls.Remove(comboBoxWeekDay2);
                panel3.Controls.Remove(labelTime2);
                panel3.Controls.Remove(labelFrom2);
                panel3.Controls.Remove(comboBoxStartTime2);
                panel3.Controls.Remove(labelTo2);
                panel3.Controls.Remove(comboBoxEndTime2);
                panel3.Controls.Remove(labelClassType2);
                panel3.Controls.Remove(comboBoxClassType2);
                panel3.Controls.Remove(labelRoomNo2);
                panel3.Controls.Remove(panelRoomNo2BG);
                panel3.Controls.Remove(textBoxRoomNo2);
                panel3.Controls.Remove(labelCheck);
                panel3.Controls.Remove(checkBoxIgnore);
            }
            else
            {
                panel3.Controls.Remove(labelCheck);
                panel3.Controls.Remove(checkBoxIgnore);
            }
        }

        private void buttonBack_Click(object sender, System.EventArgs e)
        {
            var yourSections = new YourSectionsForm(faculty);
            yourSections.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            yourSections.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void labelTitle_Click(object sender, System.EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void textBoxSectionName_Click(object sender, System.EventArgs e)
        {
            if (textBoxSectionName.Text == "Course [Section]")
            {
                textBoxSectionName.Clear();
                textBoxSectionName.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
        }

        private void textBoxSectionName_Leave(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSectionName.Text))
            {
                textBoxSectionName.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxSectionName.Text = "Course [Section]";
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SectionModel editedSection = section;
            editedSection.SectionName = textBoxSectionName.Text.Trim();
            editedSection.FacultyId = faculty.Id;

            SectionTimeController stcontroller = new SectionTimeController();
            List<SectionTimeModel> allSectionTimes = stcontroller.GetByFaculty(faculty.Id);

            try
            {
                editedSection.IsValid();

                //Console.WriteLine("Section name: " + section.SectionName);
                //Console.WriteLine("Section facultyID: " + section.FacultyId);

                SectionTimeModel editedSectionTime1 = sectionTimes[0];
                if (comboBoxClassType1.SelectedIndex == 0)
                {
                    editedSectionTime1.ClassType = ClassTypes.Lab;
                }
                else if (comboBoxClassType1.SelectedIndex == 1)
                {
                    editedSectionTime1.ClassType = ClassTypes.Theory;
                }

                editedSectionTime1.RoomNo = textBoxRoomNo1.Text;
                editedSectionTime1.StartTimeId = comboBoxStartTime1.SelectedIndex + 1;
                editedSectionTime1.EndTimeId = comboBoxEndTime1.SelectedIndex + 1;
                editedSectionTime1.WeekDayID = comboBoxWeekDay1.SelectedIndex + 1;

                //Console.WriteLine("Section Time 1 info:");
                //Console.WriteLine("Start Id: " + editedSectionTime1.StartTimeId);
                //Console.WriteLine("End Id: " + editedSectionTime1.EndTimeId);
                //Console.WriteLine("Day Id: " + editedSectionTime1.WeekDayID);
                //Console.WriteLine("Room no: " + editedSectionTime1.RoomNo);
                //Console.WriteLine("Class type: " + editedSectionTime1.ClassType.ToString());
                //Console.WriteLine("Class length: " + (editedSectionTime1.EndTimeId - editedSectionTime1.StartTimeId).ToString());

                try
                {
                    editedSectionTime1.IsValid();

                    foreach (SectionTimeModel model in allSectionTimes)
                    {
                        if(model.Id != editedSectionTime1.Id)
                        {
                            if (model.WeekDayID == editedSectionTime1.WeekDayID)
                            {
                                if (editedSectionTime1.StartTimeId < model.EndTimeId && editedSectionTime1.StartTimeId >= model.StartTimeId)
                                {
                                    //Console.WriteLine("Clash with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                    throw new Exception("Section 1 time clashes with another section. Please choose a different time");

                                }
                                if (editedSectionTime1.EndTimeId <= model.EndTimeId && editedSectionTime1.EndTimeId > model.StartTimeId)
                                {
                                    //Console.WriteLine("Clash with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                    throw new Exception("Section 1 time clashes with another section. Please choose a different time");
                                }
                                if(editedSectionTime1.StartTimeId < model.StartTimeId && editedSectionTime1.EndTimeId > model.EndTimeId)
                                {
                                    //Console.WriteLine("Clash with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                    throw new Exception("Section 1 time clashes with another section. Please choose a different time");
                                }
                            }
                        }
                    }

                    SectionTimeModel editedSectionTime2 = new SectionTimeModel();
                    if (!(sectionTimes.Count == 1))
                        editedSectionTime2 = sectionTimes[1];

                    if (comboBoxClassType2.SelectedIndex == 0)
                    {
                        editedSectionTime2.ClassType = ClassTypes.Lab;
                    }
                    else if (comboBoxClassType2.SelectedIndex == 1)
                    {
                        editedSectionTime2.ClassType = ClassTypes.Theory;
                    }
                    editedSectionTime2.RoomNo = textBoxRoomNo2.Text;
                    editedSectionTime2.StartTimeId = comboBoxStartTime2.SelectedIndex + 1;
                    editedSectionTime2.EndTimeId = comboBoxEndTime2.SelectedIndex + 1;
                    editedSectionTime2.WeekDayID = comboBoxWeekDay2.SelectedIndex + 1;

                    //Console.WriteLine("Section Time 2 info:");
                    //Console.WriteLine("Start Id: " + editedSectionTime2.StartTimeId);
                    //Console.WriteLine("End Id: " + editedSectionTime2.EndTimeId);
                    //Console.WriteLine("Day Id: " + editedSectionTime2.WeekDayID);
                    //Console.WriteLine("Room no: " + editedSectionTime2.RoomNo);
                    //Console.WriteLine("Class type: " + editedSectionTime2.ClassType.ToString());
                    //Console.WriteLine("Class length: " + (editedSectionTime2.EndTimeId - editedSectionTime2.StartTimeId).ToString());

                    SectionModel editedSectionRetured = new SectionModel();
                    try
                    {
                        if (!checkBoxIgnore.Checked)
                        {
                            editedSectionTime2.IsValid();

                            foreach (SectionTimeModel model in allSectionTimes)
                            {
                                if(model.Id != editedSectionTime2.Id)
                                {
                                    if (model.WeekDayID == editedSectionTime2.WeekDayID)
                                    {
                                        if (editedSectionTime2.StartTimeId < model.EndTimeId && editedSectionTime2.StartTimeId >= model.StartTimeId)
                                        {
                                            throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                        }
                                        if (editedSectionTime2.EndTimeId <= model.EndTimeId && editedSectionTime2.EndTimeId > model.StartTimeId)
                                        {
                                            throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                        }
                                        if (editedSectionTime2.StartTimeId < model.StartTimeId && editedSectionTime2.EndTimeId > model.EndTimeId)
                                        {
                                            //Console.WriteLine("Clash with\nstart id: " + model.StartTimeId + "\nend id: " + model.EndTimeId);
                                            throw new Exception("Section 2 time clashes with another section. Please choose a different time");
                                        }
                                    }
                                }
                            }
                        }
                        SectionController controller = new SectionController();

                        try
                        {
                            //Console.WriteLine("Updating with name and id: " + editedSection.SectionName + " " + editedSection.Id);
                            editedSectionRetured = controller.Update(section);

                            //Console.WriteLine("Edited section id: " + editedSection.Id);

                            editedSectionTime1.SectionId = editedSectionRetured.Id;
                            if (!checkBoxIgnore.Checked)
                                editedSectionTime2.SectionId = editedSectionRetured.Id;

                            SectionTimeController controller2 = new SectionTimeController();

                            try
                            {
                                controller2.Update(editedSectionTime1);
                                if (!checkBoxIgnore.Checked)
                                    controller2.Update(editedSectionTime2);

                                MessageBox.Show(editedSectionRetured.SectionName + " edited!");
                                buttonBack.PerformClick();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + section.SectionName + "? Student list, classes and attendance data of this section will be permanently deleted", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SectionController scontroller = new SectionController();
                SectionTimeController stcontroller = new SectionTimeController();
                SectionStudentController sscontroller = new SectionStudentController();
                try
                {
                    ClassController ccontroller = new ClassController();
                    List<ClassModel> classList = ccontroller.GetBySectionId(section.Id);
                    AttendanceController acontroller = new AttendanceController();

                    foreach(ClassModel Class in classList)
                    {
                        acontroller.DeleteAllByClass(Class.Id);
                    }

                    ccontroller.DeleteAllBySection(section.Id);
                    sscontroller.RemoveAllBySection(section.Id);
                    stcontroller.RemoveAllBySection(section.Id);
                    scontroller.Delete(section);
                    MessageBox.Show("Deleted!");
                    buttonBack.PerformClick();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
