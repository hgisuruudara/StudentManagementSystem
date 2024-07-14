namespace WindowsFormsApplication1
{
    partial class ViewSudent_Details
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearchStud = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunViewStudDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.AddminNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FathersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatheContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewStudDetails)).BeginInit();
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(781, 49);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Student Records";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         
            // 
            // txtSearchStud
            // 
            this.txtSearchStud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStud.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchStud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchStud.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchStud.HintText = "ENTER STUDENT NAME OR ADDMISSION ";
            this.txtSearchStud.isPassword = false;
            this.txtSearchStud.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchStud.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchStud.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchStud.LineThickness = 3;
            this.txtSearchStud.Location = new System.Drawing.Point(5, 64);
            this.txtSearchStud.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStud.Name = "txtSearchStud";
            this.txtSearchStud.Size = new System.Drawing.Size(259, 44);
            this.txtSearchStud.TabIndex = 4;
            this.txtSearchStud.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchStud.OnValueChanged += new System.EventHandler(this.txtSearchStud_OnValueChanged);
            // 
            // bunViewStudDetails
            // 
            this.bunViewStudDetails.AllowUserToAddRows = false;
            this.bunViewStudDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewStudDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewStudDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewStudDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewStudDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewStudDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewStudDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddminNo,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.DOB,
            this.Address1,
            this.Address2,
            this.FathersName,
            this.FatheContact,
            this.RegDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewStudDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewStudDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewStudDetails.DoubleBuffered = true;
            this.bunViewStudDetails.EnableHeadersVisualStyles = false;
            this.bunViewStudDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewStudDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewStudDetails.Location = new System.Drawing.Point(0, 124);
            this.bunViewStudDetails.Name = "bunViewStudDetails";
            this.bunViewStudDetails.ReadOnly = true;
            this.bunViewStudDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewStudDetails.Size = new System.Drawing.Size(781, 476);
            this.bunViewStudDetails.TabIndex = 6;
            // 
            // AddminNo
            // 
            this.AddminNo.DataPropertyName = "AddminNo";
            this.AddminNo.HeaderText = "Addmission No";
            this.AddminNo.Name = "AddminNo";
            this.AddminNo.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
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
            // Address1
            // 
            this.Address1.DataPropertyName = "Address1";
            this.Address1.HeaderText = "Address";
            this.Address1.Name = "Address1";
            this.Address1.ReadOnly = true;
            // 
            // Address2
            // 
            this.Address2.DataPropertyName = "Address2";
            this.Address2.HeaderText = "City";
            this.Address2.Name = "Address2";
            this.Address2.ReadOnly = true;
            // 
            // FathersName
            // 
            this.FathersName.DataPropertyName = "FathersName";
            this.FathersName.HeaderText = "Parent Name";
            this.FathersName.Name = "FathersName";
            this.FathersName.ReadOnly = true;
            // 
            // FatheContact
            // 
            this.FatheContact.DataPropertyName = "FatheContact";
            this.FatheContact.HeaderText = "Parent Contact";
            this.FatheContact.Name = "FatheContact";
            this.FatheContact.ReadOnly = true;
            // 
            // RegDate
            // 
            this.RegDate.DataPropertyName = "RegDate";
            this.RegDate.HeaderText = "Register Date";
            this.RegDate.Name = "RegDate";
            this.RegDate.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.icons8_office_160;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_office_1601;
            this.pictureBox1.Location = new System.Drawing.Point(271, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;

            // 
            // ViewSudent_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 600);
            this.Controls.Add(this.bunViewStudDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearchStud);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "ViewSudent_Details";
            this.Text = "ViewSudent_Details";
            this.Load += new System.EventHandler(this.ViewSudent_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewStudDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchStud;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewStudDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddminNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FathersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatheContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
    }
}