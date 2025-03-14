namespace Parnada_Appsdev
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.tabPageSubjects = new System.Windows.Forms.TabPage();
            this.tabPageSubjectScheduleEntry = new System.Windows.Forms.TabPage();
            this.tabPageLogout = new System.Windows.Forms.TabPage();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.tabPageStudentEnrollmentEntry = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPageHome);
            this.tcMain.Controls.Add(this.tabPageStudent);
            this.tcMain.Controls.Add(this.tabPageSubjects);
            this.tcMain.Controls.Add(this.tabPageSubjectScheduleEntry);
            this.tcMain.Controls.Add(this.tabPageStudentEnrollmentEntry);
            this.tcMain.Controls.Add(this.tabPageLogout);
            this.tcMain.Depth = 0;
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tcMain.ImageList = this.imageListMain;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(30, 3);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1060, 680);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.pictureBox1);
            this.tabPageHome.ImageKey = "home.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 58);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1052, 618);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Parnada_Appsdev.Properties.Resources.main_bg;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.BackColor = System.Drawing.Color.White;
            this.tabPageStudent.ImageKey = "group.png";
            this.tabPageStudent.Location = new System.Drawing.Point(4, 31);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(1052, 645);
            this.tabPageStudent.TabIndex = 1;
            this.tabPageStudent.Text = "Student Database";
            // 
            // tabPageSubjects
            // 
            this.tabPageSubjects.BackColor = System.Drawing.Color.White;
            this.tabPageSubjects.ImageKey = "books-stack-of-three.png";
            this.tabPageSubjects.Location = new System.Drawing.Point(4, 31);
            this.tabPageSubjects.Name = "tabPageSubjects";
            this.tabPageSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubjects.Size = new System.Drawing.Size(1052, 645);
            this.tabPageSubjects.TabIndex = 2;
            this.tabPageSubjects.Text = "Subject Entry";
            // 
            // tabPageSubjectScheduleEntry
            // 
            this.tabPageSubjectScheduleEntry.BackColor = System.Drawing.Color.White;
            this.tabPageSubjectScheduleEntry.ImageKey = "books-stack-of-three - 1.png";
            this.tabPageSubjectScheduleEntry.Location = new System.Drawing.Point(4, 31);
            this.tabPageSubjectScheduleEntry.Name = "tabPageSubjectScheduleEntry";
            this.tabPageSubjectScheduleEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubjectScheduleEntry.Size = new System.Drawing.Size(1052, 645);
            this.tabPageSubjectScheduleEntry.TabIndex = 4;
            this.tabPageSubjectScheduleEntry.Text = "Subject Schedule Entry";
            // 
            // tabPageLogout
            // 
            this.tabPageLogout.BackColor = System.Drawing.Color.White;
            this.tabPageLogout.ImageKey = "logout.png";
            this.tabPageLogout.Location = new System.Drawing.Point(4, 58);
            this.tabPageLogout.Name = "tabPageLogout";
            this.tabPageLogout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogout.Size = new System.Drawing.Size(1052, 618);
            this.tabPageLogout.TabIndex = 3;
            this.tabPageLogout.Text = "Logout";
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "group.png");
            this.imageListMain.Images.SetKeyName(1, "home.png");
            this.imageListMain.Images.SetKeyName(2, "books-stack-of-three.png");
            this.imageListMain.Images.SetKeyName(3, "logout.png");
            this.imageListMain.Images.SetKeyName(4, "books-stack-of-three - 1.png");
            this.imageListMain.Images.SetKeyName(5, "contract.png");
            // 
            // tabPageStudentEnrollmentEntry
            // 
            this.tabPageStudentEnrollmentEntry.BackColor = System.Drawing.Color.White;
            this.tabPageStudentEnrollmentEntry.ImageKey = "contract.png";
            this.tabPageStudentEnrollmentEntry.Location = new System.Drawing.Point(4, 58);
            this.tabPageStudentEnrollmentEntry.Name = "tabPageStudentEnrollmentEntry";
            this.tabPageStudentEnrollmentEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentEnrollmentEntry.Size = new System.Drawing.Size(1052, 618);
            this.tabPageStudentEnrollmentEntry.TabIndex = 5;
            this.tabPageStudentEnrollmentEntry.Text = "Student Enrollment Entry";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 680);
            this.Controls.Add(this.tcMain);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tcMain;
            this.DrawerUseColors = true;
            this.DrawerWidth = 250;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 680);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tcMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.TabPage tabPageSubjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageLogout;
        private System.Windows.Forms.TabPage tabPageSubjectScheduleEntry;
        private System.Windows.Forms.TabPage tabPageStudentEnrollmentEntry;
    }
}