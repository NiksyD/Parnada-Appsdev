namespace Parnada_Appsdev.Controller.EntryControls
{
    partial class StudentEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEdit));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboSemester = new MaterialSkin.Controls.MaterialComboBox();
            this.cboRemarks = new MaterialSkin.Controls.MaterialComboBox();
            this.cboStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCourse = new MaterialSkin.Controls.MaterialComboBox();
            this.cboCurriculumYear = new MaterialSkin.Controls.MaterialComboBox();
            this.cboYear = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbMiddleName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel4);
            this.materialCard1.Controls.Add(this.flowLayoutPanel3);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.flowLayoutPanel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(954, 636);
            this.materialCard1.TabIndex = 39;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(40, 252);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(188, 24);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Course Management";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(40, 103);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 24);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Student Information";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(37, 26);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(419, 41);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Update Student Information";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.cboSemester);
            this.flowLayoutPanel4.Controls.Add(this.cboRemarks);
            this.flowLayoutPanel4.Controls.Add(this.cboStatus);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(44, 423);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(820, 49);
            this.flowLayoutPanel4.TabIndex = 8;
            this.flowLayoutPanel4.TabStop = true;
            // 
            // cboSemester
            // 
            this.cboSemester.AutoResize = false;
            this.cboSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboSemester.Depth = 0;
            this.cboSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboSemester.DropDownHeight = 174;
            this.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemester.DropDownWidth = 121;
            this.cboSemester.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Hint = "Semester";
            this.cboSemester.IntegralHeight = false;
            this.cboSemester.ItemHeight = 43;
            this.cboSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboSemester.Location = new System.Drawing.Point(0, 0);
            this.cboSemester.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboSemester.MaxDropDownItems = 4;
            this.cboSemester.MouseState = MaterialSkin.MouseState.OUT;
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(240, 49);
            this.cboSemester.StartIndex = -1;
            this.cboSemester.TabIndex = 8;
            // 
            // cboRemarks
            // 
            this.cboRemarks.AutoResize = false;
            this.cboRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRemarks.Depth = 0;
            this.cboRemarks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboRemarks.DropDownHeight = 174;
            this.cboRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemarks.DropDownWidth = 121;
            this.cboRemarks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboRemarks.FormattingEnabled = true;
            this.cboRemarks.Hint = "Remarks";
            this.cboRemarks.IntegralHeight = false;
            this.cboRemarks.ItemHeight = 43;
            this.cboRemarks.Items.AddRange(new object[] {
            "RETURNEE",
            "NEW STUDENT",
            "OLD STUDENT",
            "CROSS ENROLLEE",
            "SHIFTEE",
            "TRANSFEREE"});
            this.cboRemarks.Location = new System.Drawing.Point(290, 0);
            this.cboRemarks.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboRemarks.MaxDropDownItems = 4;
            this.cboRemarks.MouseState = MaterialSkin.MouseState.OUT;
            this.cboRemarks.Name = "cboRemarks";
            this.cboRemarks.Size = new System.Drawing.Size(240, 49);
            this.cboRemarks.StartIndex = -1;
            this.cboRemarks.TabIndex = 39;
            // 
            // cboStatus
            // 
            this.cboStatus.AutoResize = false;
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboStatus.Depth = 0;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboStatus.DropDownHeight = 174;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.DropDownWidth = 121;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Hint = "Status";
            this.cboStatus.IntegralHeight = false;
            this.cboStatus.ItemHeight = 43;
            this.cboStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cboStatus.Location = new System.Drawing.Point(580, 0);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.MaxDropDownItems = 4;
            this.cboStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 49);
            this.cboStatus.StartIndex = -1;
            this.cboStatus.TabIndex = 40;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.cboCourse);
            this.flowLayoutPanel3.Controls.Add(this.cboCurriculumYear);
            this.flowLayoutPanel3.Controls.Add(this.cboYear);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(44, 332);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(820, 50);
            this.flowLayoutPanel3.TabIndex = 2;
            this.flowLayoutPanel3.TabStop = true;
            // 
            // cboCourse
            // 
            this.cboCourse.AutoCompleteCustomSource.AddRange(new string[] {
            "BSA",
            "BSBA",
            "BSEd-Bio Sci",
            "BSEd-English",
            "BSEd-Filipino",
            "BSEd-Math",
            "BSEd-MAPEH",
            "BSEd-Physical Sci",
            "BSEd-Social Studies",
            "BSCE",
            "BSC",
            "BSCpE",
            "BSCrim",
            "BSCA",
            "BSEE",
            "BSECE",
            "BEEd",
            "BSHRM",
            "AHRM",
            "BSIE",
            "BSIT",
            "BSME",
            "BSNAME",
            "BSOA",
            "BSREM",
            "BSSW",
            "BSN",
            "BSMT",
            "BSMarE",
            "BSCS",
            "ACS",
            "ACT"});
            this.cboCourse.AutoResize = false;
            this.cboCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCourse.Depth = 0;
            this.cboCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCourse.DropDownHeight = 174;
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.DropDownWidth = 121;
            this.cboCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Hint = "Course";
            this.cboCourse.IntegralHeight = false;
            this.cboCourse.ItemHeight = 43;
            this.cboCourse.Items.AddRange(new object[] {
            "BSIT"});
            this.cboCourse.Location = new System.Drawing.Point(0, 0);
            this.cboCourse.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboCourse.MaxDropDownItems = 4;
            this.cboCourse.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(240, 49);
            this.cboCourse.StartIndex = -1;
            this.cboCourse.TabIndex = 5;
            // 
            // cboCurriculumYear
            // 
            this.cboCurriculumYear.AutoResize = false;
            this.cboCurriculumYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCurriculumYear.Depth = 0;
            this.cboCurriculumYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCurriculumYear.DropDownHeight = 174;
            this.cboCurriculumYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurriculumYear.DropDownWidth = 121;
            this.cboCurriculumYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboCurriculumYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCurriculumYear.FormattingEnabled = true;
            this.cboCurriculumYear.Hint = "Curriculum Year";
            this.cboCurriculumYear.IntegralHeight = false;
            this.cboCurriculumYear.ItemHeight = 43;
            this.cboCurriculumYear.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024"});
            this.cboCurriculumYear.Location = new System.Drawing.Point(290, 0);
            this.cboCurriculumYear.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.cboCurriculumYear.MaxDropDownItems = 4;
            this.cboCurriculumYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCurriculumYear.Name = "cboCurriculumYear";
            this.cboCurriculumYear.Size = new System.Drawing.Size(240, 49);
            this.cboCurriculumYear.StartIndex = -1;
            this.cboCurriculumYear.TabIndex = 6;
            // 
            // cboYear
            // 
            this.cboYear.AutoResize = false;
            this.cboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboYear.Depth = 0;
            this.cboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboYear.DropDownHeight = 174;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.DropDownWidth = 121;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Hint = "Year";
            this.cboYear.IntegralHeight = false;
            this.cboYear.ItemHeight = 43;
            this.cboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboYear.Location = new System.Drawing.Point(580, 0);
            this.cboYear.Margin = new System.Windows.Forms.Padding(0);
            this.cboYear.MaxDropDownItems = 4;
            this.cboYear.MouseState = MaterialSkin.MouseState.OUT;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(240, 49);
            this.cboYear.StartIndex = -1;
            this.cboYear.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(676, 545);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 36);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(97, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.tbFirstName);
            this.flowLayoutPanel2.Controls.Add(this.tbMiddleName);
            this.flowLayoutPanel2.Controls.Add(this.tbLastName);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 165);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(820, 48);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.TabStop = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.AnimateReadOnly = false;
            this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFirstName.Depth = 0;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFirstName.HideSelection = true;
            this.tbFirstName.Hint = "First Name";
            this.tbFirstName.LeadingIcon = null;
            this.tbFirstName.Location = new System.Drawing.Point(0, 0);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.tbFirstName.MaxLength = 32767;
            this.tbFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PrefixSuffixText = null;
            this.tbFirstName.ReadOnly = false;
            this.tbFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.SelectionLength = 0;
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.ShortcutsEnabled = true;
            this.tbFirstName.Size = new System.Drawing.Size(240, 48);
            this.tbFirstName.TabIndex = 42;
            this.tbFirstName.TabStop = false;
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFirstName.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("tbFirstName.TrailingIcon")));
            this.tbFirstName.UseSystemPasswordChar = false;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.AnimateReadOnly = false;
            this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMiddleName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMiddleName.Depth = 0;
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMiddleName.HideSelection = true;
            this.tbMiddleName.Hint = "Middle Name";
            this.tbMiddleName.LeadingIcon = null;
            this.tbMiddleName.Location = new System.Drawing.Point(290, 0);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.tbMiddleName.MaxLength = 32767;
            this.tbMiddleName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.PasswordChar = '\0';
            this.tbMiddleName.PrefixSuffixText = null;
            this.tbMiddleName.ReadOnly = false;
            this.tbMiddleName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMiddleName.SelectedText = "";
            this.tbMiddleName.SelectionLength = 0;
            this.tbMiddleName.SelectionStart = 0;
            this.tbMiddleName.ShortcutsEnabled = true;
            this.tbMiddleName.Size = new System.Drawing.Size(240, 48);
            this.tbMiddleName.TabIndex = 43;
            this.tbMiddleName.TabStop = false;
            this.tbMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMiddleName.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("tbMiddleName.TrailingIcon")));
            this.tbMiddleName.UseSystemPasswordChar = false;
            // 
            // tbLastName
            // 
            this.tbLastName.AnimateReadOnly = false;
            this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLastName.Depth = 0;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLastName.HideSelection = true;
            this.tbLastName.Hint = "Last Name";
            this.tbLastName.LeadingIcon = null;
            this.tbLastName.Location = new System.Drawing.Point(580, 0);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(0);
            this.tbLastName.MaxLength = 32767;
            this.tbLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PrefixSuffixText = null;
            this.tbLastName.ReadOnly = false;
            this.tbLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLastName.SelectedText = "";
            this.tbLastName.SelectionLength = 0;
            this.tbLastName.SelectionStart = 0;
            this.tbLastName.ShortcutsEnabled = true;
            this.tbLastName.Size = new System.Drawing.Size(240, 48);
            this.tbLastName.TabIndex = 44;
            this.tbLastName.TabStop = false;
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLastName.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("tbLastName.TrailingIcon")));
            this.tbLastName.UseSystemPasswordChar = false;
            // 
            // StudentEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StudentEdit";
            this.Size = new System.Drawing.Size(994, 676);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MaterialSkin.Controls.MaterialComboBox cboSemester;
        private MaterialSkin.Controls.MaterialComboBox cboRemarks;
        private MaterialSkin.Controls.MaterialComboBox cboStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialComboBox cboCourse;
        private MaterialSkin.Controls.MaterialComboBox cboCurriculumYear;
        private MaterialSkin.Controls.MaterialComboBox cboYear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox2 tbFirstName;
        private MaterialSkin.Controls.MaterialTextBox2 tbMiddleName;
        private MaterialSkin.Controls.MaterialTextBox2 tbLastName;
    }
}
