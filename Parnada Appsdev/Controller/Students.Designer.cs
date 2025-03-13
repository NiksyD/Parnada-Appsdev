namespace Parnada_Appsdev.Controller
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enrollmentImgList = new System.Windows.Forms.ImageList(this.components);
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.studentDelete = new MaterialSkin.Controls.MaterialButton();
            this.studentEdit = new MaterialSkin.Controls.MaterialButton();
            this.searchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.studentAdd = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrollmentImgList
            // 
            this.enrollmentImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.enrollmentImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.enrollmentImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvStudents.Location = new System.Drawing.Point(41, 190);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(912, 424);
            this.dgvStudents.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.studentDelete);
            this.flowLayoutPanel1.Controls.Add(this.studentEdit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(663, 125);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // studentDelete
            // 
            this.studentDelete.AutoSize = false;
            this.studentDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.studentDelete.Depth = 0;
            this.studentDelete.DrawShadows = false;
            this.studentDelete.HighEmphasis = false;
            this.studentDelete.Icon = global::Parnada_Appsdev.Properties.Resources.remove_user;
            this.studentDelete.Location = new System.Drawing.Point(155, 0);
            this.studentDelete.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.studentDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentDelete.Name = "studentDelete";
            this.studentDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.studentDelete.Size = new System.Drawing.Size(135, 32);
            this.studentDelete.TabIndex = 15;
            this.studentDelete.Text = "Delete";
            this.studentDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.studentDelete.UseAccentColor = false;
            this.studentDelete.UseVisualStyleBackColor = true;
            this.studentDelete.Click += new System.EventHandler(this.studentDelete_Click);
            // 
            // studentEdit
            // 
            this.studentEdit.AutoSize = false;
            this.studentEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.studentEdit.Depth = 0;
            this.studentEdit.DrawShadows = false;
            this.studentEdit.HighEmphasis = false;
            this.studentEdit.Icon = global::Parnada_Appsdev.Properties.Resources.edit_user;
            this.studentEdit.Location = new System.Drawing.Point(0, 0);
            this.studentEdit.Margin = new System.Windows.Forms.Padding(0);
            this.studentEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentEdit.Name = "studentEdit";
            this.studentEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.studentEdit.Size = new System.Drawing.Size(135, 32);
            this.studentEdit.TabIndex = 16;
            this.studentEdit.Text = "Edit";
            this.studentEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.studentEdit.UseAccentColor = false;
            this.studentEdit.UseVisualStyleBackColor = true;
            this.studentEdit.Click += new System.EventHandler(this.studentEdit_Click);
            // 
            // searchBox
            // 
            this.searchBox.AnimateReadOnly = false;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Depth = 0;
            this.searchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.Hint = "Search for a student";
            this.searchBox.LeadingIcon = null;
            this.searchBox.Location = new System.Drawing.Point(19, 50);
            this.searchBox.MaxLength = 50;
            this.searchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(960, 50);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "";
            this.searchBox.TrailingIcon = global::Parnada_Appsdev.Properties.Resources.search;
            // 
            // studentAdd
            // 
            this.studentAdd.AutoSize = false;
            this.studentAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.studentAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.studentAdd.Depth = 0;
            this.studentAdd.HighEmphasis = false;
            this.studentAdd.Icon = global::Parnada_Appsdev.Properties.Resources.add_user;
            this.studentAdd.Location = new System.Drawing.Point(41, 121);
            this.studentAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.studentAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentAdd.Name = "studentAdd";
            this.studentAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.studentAdd.Size = new System.Drawing.Size(135, 36);
            this.studentAdd.TabIndex = 1;
            this.studentAdd.Text = "Add";
            this.studentAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.studentAdd.UseAccentColor = false;
            this.studentAdd.UseVisualStyleBackColor = true;
            this.studentAdd.Click += new System.EventHandler(this.studentAdd_Click);
            // 
            // Students
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.studentAdd);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(994, 676);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Students_ControlRemoved);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton studentAdd;
        private System.Windows.Forms.ImageList enrollmentImgList;
        private MaterialSkin.Controls.MaterialTextBox searchBox;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton studentDelete;
        private MaterialSkin.Controls.MaterialButton studentEdit;
    }
}
