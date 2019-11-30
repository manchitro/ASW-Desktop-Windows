using DataLayer.Models;
using GUI.Controllers;
using GUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class SearchForm : Form
    {
        FacultyUserModel faculty = new FacultyUserModel();
        public SearchForm(FacultyUserModel gotFaculty)
        {
            InitializeComponent();
            faculty = gotFaculty;
            labelWelcome.Text = faculty.FullName;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var dash = new FormDashboard(faculty);
            dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
            dash.Show();
            this.Hide();
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "Search")
            {
                textBoxSearch.Clear();
                textBoxSearch.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search";
                textBoxSearch.ForeColor = Color.FromArgb(156,156,156);
            }
        }

        private void dataGridViewStudentList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridViewStudentList.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridViewStudentList.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dataGridViewStudentList.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dataGridViewStudentList.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SectionController scontroller = new SectionController();
            List<SectionModel> sectionList = scontroller.GetByFaculty(faculty);

            dataGridViewSerial.ScrollBars = ScrollBars.None;

            MySortableBindingList<ProperStudentUserModel> properStudentList = new MySortableBindingList<ProperStudentUserModel>();
            foreach (SectionModel model in sectionList)
            {
                UserController ucontroller = new UserController();
                List<StudentUserModel> studentListByAcademicId = ucontroller.SearchByAcademidIdAndSectionId(textBoxSearch.Text, model.Id);
                //Console.WriteLine(studentListByAcademicId.Count + " student found in " + model.SectionName);
                foreach (StudentUserModel smodel in studentListByAcademicId)
                {
                    ProperStudentUserModel properStudentModel = new ProperStudentUserModel();
                    properStudentModel.AcademicId = smodel.AcademicId;
                    properStudentModel.FirstName = smodel.FirstName;
                    properStudentModel.Id = smodel.Id;
                    properStudentModel.LastName = smodel.LastName;

                    properStudentModel.SectionName = model.SectionName;

                    properStudentList.Add(properStudentModel);
                }
                List<StudentUserModel> studentListByName = ucontroller.SearchByNameAndSectionId(textBoxSearch.Text, model.Id);
                //Console.WriteLine(studentListByName.Count + " student found in " + model.SectionName);
                foreach (StudentUserModel smodel in studentListByName)
                {
                    ProperStudentUserModel properStudentModel = new ProperStudentUserModel();
                    properStudentModel.AcademicId = smodel.AcademicId;
                    properStudentModel.FirstName = smodel.FirstName;
                    properStudentModel.Id = smodel.Id;
                    properStudentModel.LastName = smodel.LastName;

                    properStudentModel.SectionName = model.SectionName;

                    properStudentList.Add(properStudentModel);
                }
            }

            foreach(ProperStudentUserModel student in properStudentList)
            {
                dataGridViewSerial.Rows.Add();
            }

            dataGridViewStudentList.DataBindingComplete += (o, ev) =>
            {
                foreach (DataGridViewRow row in dataGridViewSerial.Rows)
                {
                    row.Cells["sln"].Value = (row.Index + 1).ToString();
                }
                foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            };

            dataGridViewStudentList.AutoGenerateColumns = false;
            dataGridViewStudentList.DataSource = properStudentList;

            dataGridViewStudentList.Update();
            dataGridViewStudentList.Refresh();

            dataGridViewSerial.Update();
            dataGridViewSerial.Refresh();

            foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }

        private void dataGridViewStudentList_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridViewSerial.FirstDisplayedScrollingRowIndex = dataGridViewStudentList.FirstDisplayedScrollingRowIndex;
        }
    }

    public class ProperStudentUserModel : StudentUserModel
    {
        public string SectionName { set; get; }
    }
}
