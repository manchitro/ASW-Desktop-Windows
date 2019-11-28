using DataLayer.Models;
using GUI.Controllers;
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
                Console.WriteLine(allClassesList.Count + " improper classes");
                List<ProperClassModel> properClassList = new List<ProperClassModel>();
                foreach(ClassModel model in allClassesList)
                {
                    ProperClassModel properModel = new ProperClassModel();
                    properModel.ClassDate = model.ClassDate;
                    properModel.ClassType = model.ClassType;
                    properModel.EndTimeId = model.EndTimeId;
                    properModel.Id = model.Id;
                    properModel.RoomNo = model.RoomNo;
                    properModel.SectionID = model.SectionID;
                    properModel.StartTimeId = model.StartTimeId;

                    Console.WriteLine("improper date: " + model.ClassDate + " | proper date: " + properModel.ClassDate);

                    SectionController scontroller = new SectionController();
                    properModel.SectionName = scontroller.Get(model.SectionID).SectionName;

                    ClassTimeController ctcontroller = new ClassTimeController();
                    properModel.Time = ctcontroller.Get(model.StartTimeId).ClassTimeText + " - " + ctcontroller.Get(model.EndTimeId).ClassTimeText;

                    properClassList.Add(properModel);
                }
                MySortableBindingList<ProperClassModel> bindingClassesList = new MySortableBindingList<ProperClassModel>(properClassList);
                Console.WriteLine(bindingClassesList.Count + " classes found");
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
                Console.WriteLine("Right mouse click");
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
    }

    class ProperClassModel : ClassModel
    {
        public string SectionName { set; get; }
        public string Time { set; get; }
    }
}
