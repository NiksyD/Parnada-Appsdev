using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Models;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EntryControls
{
    public partial class StudentAdd: UserControl
    {
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateControls(this))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var repo = new RepositoryStudent();


            ModelStudent student = new ModelStudent
            {
                FirstName = tbFirstName.Text,
                MiddleName = tbMiddleName.Text,
                LastName = tbLastName.Text,
                Course = cboCourse.Text,
                CurriculumYear = cboCurriculumYear.Text,
                YearLevel = int.Parse(cboYear.Text),
                Semester = int.Parse(cboSemester.Text),
                Remarks = cboRemarks.Text,
                Status = cboStatus.Text,

                FullName = $"{tbFirstName.Text} {tbMiddleName.Text} {tbLastName.Text}"
            };

            repo.CreateStudent(student);
            MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Validator.ClearControls(this);
            this.Parent.Controls.Remove(this);
        }

    }
}
