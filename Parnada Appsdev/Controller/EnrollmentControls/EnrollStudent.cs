using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Parnada_Appsdev.Repository;
using Parnada_Appsdev.Models;

namespace Parnada_Appsdev.Controller.EnrollmentControls
{
    public partial class EnrollStudent : UserControl
    {
        private long studentId;
        private Random random;

        public EnrollStudent(long studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.random = new Random(); // Initialize Random once at class level
            SubjectReader();

            tbStudentID.Text = studentId.ToString();
        }


        public void SubjectReader()
        {
            var repo = new RepositorySubjectFile();
            var subjects = repo.GetSubjects(); // Fetch subjects from database

            clbSubjects.Items.Clear(); // Clear existing items

            foreach (DataRow row in subjects.Rows)
            {
                string subjectCode = row["SFSUBJCODE"].ToString();
                string subjectDesc = row["SFSUBJDESC"].ToString();

                // Store both the subject code and description
                clbSubjects.Items.Add($"{subjectCode} - {subjectDesc}");
            }

            clbSubjects.Refresh(); // Refresh UI
        }

        private static readonly Dictionary<string, string> EnrollmentStatusMap = new Dictionary<string, string>
            {
                { "Enrolled", "EN" },
                { "Unenrolled", "UN" }
            };

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var selectedSubjects = GetSelectedSubjects();
            if (selectedSubjects.Count == 0)
            {
                MessageBox.Show("Please select at least one subject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 1: Save Enrollment Header (Main Record)
            var repoHeader = new RepositoryEnrollmentHeaderFile(); // Assuming you have this repository
            var enrollmentHeader = new EnrollmentHeaderFile
            {
                ENRHFSTUDID = studentId,
                ENRHFSTUDDATEENROLL = dtpDateEnroll.Value,
                ENRHFSTUDSCHLYR = dtpYear.Value.Year.ToString(), // Assuming dtpYear is a DateTimePicker
                ENRHFSTUDENCODER = cboEncoder.Text,
                ENRHFSTUDTOTALUNITS = CalculateTotalUnits(selectedSubjects), // Implement this function
                ENRHFSTUDSTATUS = EnrollmentStatusMap.ContainsKey(cboStatus.Text) ? EnrollmentStatusMap[cboStatus.Text] : "UN" // EN (Enrolled) or UN (Unenrolled)
            };

            var resultHeader = repoHeader.AddEnrollmentHeader(enrollmentHeader);
            if (!resultHeader.Success)
            {
                MessageBox.Show($"Enrollment failed: {resultHeader.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 2: Save Enrollment Details (Subjects)
            var repoDetail = new RepositoryEnrollmentDetailFile();
            foreach (var subject in selectedSubjects)
            {
                string[] subjectParts = subject.Split('-');
                if (subjectParts.Length < 2) continue;
                string subjectCode = subjectParts[0].Trim();

                var enrollmentDetail = new EnrollmentDetailFile
                {
                    ENRDFSTUDID = studentId,
                    ENRDFSTUDSUBJCDE = subjectCode,
                    ENRDFSTUDEDPCODE = GenerateEdpCode(), // Assign appropriate EDPCODE value
                    ENRDFSTUDSTATUS = "EN" // Default status for enrolled
                };

                var resultDetail = repoDetail.AddEnrollmentDetail(enrollmentDetail);
                if (!resultDetail.Success)
                {
                    MessageBox.Show($"Enrollment failed: {resultDetail.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            resetListBox();
            MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<string> GetSelectedSubjects()
        {
            List<string> selectedSubjects = new List<string>();

            // Debugging: Check if the items are populated
            Console.WriteLine($"Total items in CheckedListBox: {clbSubjects.Items.Count}");

            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                // Check if the item is checked
                var itemState = clbSubjects.GetItemCheckState(i);
                Console.WriteLine($"Item {i}: {clbSubjects.Items[i]}, State: {itemState}");

                if (itemState == CheckState.Checked)
                {
                    selectedSubjects.Add(clbSubjects.Items[i].ToString());
                }
            }

            // Check if the list is empty and log the result
            Console.WriteLine($"Selected Subjects: {selectedSubjects.Count}");
            return selectedSubjects;
        }

        private int CalculateTotalUnits(List<string> selectedSubjects)
        {
            var repo = new RepositorySubjectFile();
            var subjects = repo.GetSubjects(); // Fetch subjects from database

            int totalUnits = 0;

            foreach (var subject in selectedSubjects)
            {
                string[] subjectParts = subject.Split('-');
                if (subjectParts.Length < 2) continue;
                string subjectCode = subjectParts[0].Trim();

                // Find the subject in the DataTable and get its unit value
                var subjectRow = subjects.AsEnumerable().FirstOrDefault(row => row["SFSUBJCODE"].ToString() == subjectCode);
                if (subjectRow != null)
                {
                    int units = Convert.ToInt32(subjectRow["SFSUBJUNITS"]);
                    totalUnits += units;
                }
            }

            return totalUnits;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private string GenerateEdpCode()
        {
            int randomDigits = random.Next(100000, 999999); // Ensure exactly 6 digits
            return "6" + randomDigits.ToString(); // Always starts with "6" and is 7 characters total
        }

        // unchecked all items
        private void resetListBox()
        {
            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                clbSubjects.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

    }
}
