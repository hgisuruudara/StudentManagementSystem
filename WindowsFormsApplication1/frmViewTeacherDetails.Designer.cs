namespace WindowsFormsApplication1
{
    partial class frmViewTeacherDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunViewTeacherDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.EmployeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTeacherStud = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewTeacherDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunViewTeacherDetails
            // 
            this.bunViewTeacherDetails.AllowUserToAddRows = false;
            this.bunViewTeacherDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewTeacherDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewTeacherDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewTeacherDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewTeacherDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewTeacherDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewTeacherDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNo,
            this.RegDate,
            this.Title,
            this.FirstName,
            this.LastName,
            this.DOB,
            this.MobileNo,
            this.LandLine,
            this.Qualification,
            this.YearOfExp,
            this.Address,
            this.City,
            this.State});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewTeacherDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewTeacherDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewTeacherDetails.DoubleBuffered = true;
            this.bunViewTeacherDetails.EnableHeadersVisualStyles = false;
            this.bunViewTeacherDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewTeacherDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewTeacherDetails.Location = new System.Drawing.Point(0, 131);
            this.bunViewTeacherDetails.Name = "bunViewTeacherDetails";
            this.bunViewTeacherDetails.ReadOnly = true;
            this.bunViewTeacherDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewTeacherDetails.Size = new System.Drawing.Size(803, 423);
            this.bunViewTeacherDetails.TabIndex = 10;
            // 
            // EmployeeNo
            // 
            this.EmployeeNo.DataPropertyName = "EmployeeNo";
            this.EmployeeNo.HeaderText = "Employee No";
            this.EmployeeNo.Name = "EmployeeNo";
            this.EmployeeNo.ReadOnly = true;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            this.RegDate.HeaderText = "Joined Date";
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // LandLine
            // 
            this.LandLine.DataPropertyName = "LandLine";
            this.LandLine.HeaderText = "Land Line";
            this.LandLine.Name = "LandLine";
            this.LandLine.ReadOnly = true;
            // 
            // Qualification
            // 
            this.Qualification.DataPropertyName = "Qualification";
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            // 
            // YearOfExp
            // 
            this.YearOfExp.DataPropertyName = "YearOfExp";
            this.YearOfExp.HeaderText = "Experince Years";
            this.YearOfExp.Name = "YearOfExp";
            this.YearOfExp.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // txtTeacherStud
            // 
            this.txtTeacherStud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeacherStud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTeacherStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTeacherStud.HintForeColor = System.Drawing.Color.Empty;
            this.txtTeacherStud.HintText = "ENTER TEACHER NAME OR EMPLOYEE NO ";
            this.txtTeacherStud.isPassword = false;
            this.txtTeacherStud.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTeacherStud.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTeacherStud.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTeacherStud.LineThickness = 3;
            this.txtTeacherStud.Location = new System.Drawing.Point(5, 64);
            this.txtTeacherStud.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacherStud.Name = "txtTeacherStud";
            this.txtTeacherStud.Size = new System.Drawing.Size(286, 44);
            this.txtTeacherStud.TabIndex = 8;
            this.txtTeacherStud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTeacherStud.OnValueChanged += new System.EventHandler(this.txtSearchStud_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.icons8_office_160;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_office_1601;
            this.pictureBox1.Location = new System.Drawing.Point(298, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(803, 49);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Teacher Records";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmViewTeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.bunViewTeacherDetails);
            this.Controls.Add(this.txtTeacherStud);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmViewTeacherDetails";
            this.Text = "frmViewTeacherDetails";
            this.Load += new System.EventHandler(this.frmViewTeacherDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewTeacherDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewTeacherDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTeacherStud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}