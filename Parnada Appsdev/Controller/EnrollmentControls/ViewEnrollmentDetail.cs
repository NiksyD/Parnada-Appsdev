using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parnada_Appsdev.Repository;

namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    public partial class ViewEnrollmentDetail : UserControl
    {
        private long studentId;

        public ViewEnrollmentDetail(long studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            Theme.ApplyDataGridViewTheme(dgvEnrolledSubjects);
            LoadEnrolledSubjects();
        }

        private void LoadEnrolledSubjects()
        {
            var repo = new RepositoryEnrollmentHeaderFile();
            var dt = repo.GetEnrolledSubjects(studentId);
            dgvEnrolledSubjects.DataSource = dt;
            dgvEnrolledSubjects.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
