using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Controller.EntryControls;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller
{
    public partial class Students: UserControl
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string course;
        public string curriculumYear;
        public int yearLevel;
        public int semester;
        public string remarks;
        public string status;

        public Students()
        {
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvStudents);
            StudentsReader();
        }

        public void StudentsReader()
        {
            var repo = new RepositoryStudent();
            dgvStudents.DataSource = repo.GetStudents();
            dgvStudents.Refresh();
        }

        private void studentRefresh_Click(object sender, EventArgs e)
        {
            StudentsReader();
            RemoveUnnecessaryColumn();
        }

        private void studentAdd_Click(object sender, EventArgs e)
        {
            ShowUserControl(new StudentAdd());
        }

        private void studentEdit_Click(object sender, EventArgs e)
        {
            if (NoSelection()) return;

            try
            {
                firstName = dgvStudents.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
                middleName = dgvStudents.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
                lastName = dgvStudents.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
                course = dgvStudents.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
                curriculumYear = dgvStudents.SelectedRows[0].Cells[5].Value?.ToString() ?? "";

                // Use TryParse to avoid format exceptions
                yearLevel = int.TryParse(dgvStudents.SelectedRows[0].Cells[6].Value?.ToString(), out int yl) ? yl : 0;
                semester = int.TryParse(dgvStudents.SelectedRows[0].Cells[7].Value?.ToString(), out int sem) ? sem : 0;

                remarks = dgvStudents.SelectedRows[0].Cells[8].Value?.ToString() ?? "";
                status = dgvStudents.SelectedRows[0].Cells[9].Value?.ToString() ?? "";

                StudentEdit studentEdit = new StudentEdit(firstName, middleName, lastName, course, curriculumYear, yearLevel, semester, remarks, status);
                ShowUserControl(studentEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentDelete_Click(object sender, EventArgs e)
        {
            // if no row is selected, return
            if (NoSelection())
                return;
            // Logic to delete a student
            var confirmation = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var repo = new RepositoryStudent();
                var studentId = (int)dgvStudents.SelectedRows[0].Cells[0].Value;
                repo.DeleteStudent(studentId);
                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentsReader();
            }

        }

        // Helper method to add and show a UserControl
        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            this.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private bool NoSelection()
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void RemoveUnnecessaryColumn()
        {
            dgvStudents.Columns[4].Visible = false;
        }

    }
}
