namespace WindowsFormsApplication1
{
    partial class viewNonAcademicDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunViewNonAcadeDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtNonAcadeStud = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmployeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewNonAcadeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Non Academic Staff Records";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunViewNonAcadeDetails
            // 
            this.bunViewNonAcadeDetails.AllowUserToAddRows = false;
            this.bunViewNonAcadeDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunViewNonAcadeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunViewNonAcadeDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewNonAcadeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewNonAcadeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewNonAcadeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunViewNonAcadeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNo,
            this.RegDate,
            this.Title,
            this.FirstName,
            this.LastName,
            this.DOB,
            this.MobileNo,
            this.LandLine,
            this.Address,
            this.City,
            this.State});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewNonAcadeDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunViewNonAcadeDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewNonAcadeDetails.DoubleBuffered = true;
            this.bunViewNonAcadeDetails.EnableHeadersVisualStyles = false;
            this.bunViewNonAcadeDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewNonAcadeDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewNonAcadeDetails.Location = new System.Drawing.Point(0, 131);
            this.bunViewNonAcadeDetails.Name = "bunViewNonAcadeDetails";
            this.bunViewNonAcadeDetails.ReadOnly = true;
            this.bunViewNonAcadeDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewNonAcadeDetails.Size = new System.Drawing.Size(803, 423);
            this.bunViewNonAcadeDetails.TabIndex = 13;
            // 
            // txtNonAcadeStud
            // 
            this.txtNonAcadeStud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNonAcadeStud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNonAcadeStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNonAcadeStud.HintForeColor = System.Drawing.Color.Empty;
            this.txtNonAcadeStud.HintText = "ENTER NAME OR EMPLOYEE NO ";
            this.txtNonAcadeStud.isPassword = false;
            this.txtNonAcadeStud.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNonAcadeStud.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNonAcadeStud.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNonAcadeStud.LineThickness = 3;
            this.txtNonAcadeStud.Location = new System.Drawing.Point(65, 66);
            this.txtNonAcadeStud.Margin = new System.Windows.Forms.Padding(4);
            this.txtNonAcadeStud.Name = "txtNonAcadeStud";
            this.txtNonAcadeStud.Size = new System.Drawing.Size(215, 44);
            this.txtNonAcadeStud.TabIndex = 11;
            this.txtNonAcadeStud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNonAcadeStud.OnValueChanged += new System.EventHandler(this.txtTeacherStud_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.icons8_office_160;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_office_1601;
            this.pictureBox1.Location = new System.Drawing.Point(13, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            // viewNonAcademicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.bunViewNonAcadeDetails);
            this.Controls.Add(this.txtNonAcadeStud);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "viewNonAcademicDetails";
            this.Text = "viewNonAcademicDetails";
            this.Load += new System.EventHandler(this.viewNonAcademicDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewNonAcadeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewNonAcadeDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNonAcadeStud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}