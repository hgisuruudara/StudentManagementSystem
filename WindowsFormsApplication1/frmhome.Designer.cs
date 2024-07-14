namespace WindowsFormsApplication1
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblNonAcadeAmount = new System.Windows.Forms.Label();
            this.lblTeacherAmount = new System.Windows.Forms.Label();
            this.lblStudAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblhrs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblNonAcadeAmount);
            this.bunifuGradientPanel1.Controls.Add(this.lblTeacherAmount);
            this.bunifuGradientPanel1.Controls.Add(this.lblStudAmount);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lblday);
            this.bunifuGradientPanel1.Controls.Add(this.lbldate);
            this.bunifuGradientPanel1.Controls.Add(this.lblhrs);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(795, 549);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // lblNonAcadeAmount
            // 
            this.lblNonAcadeAmount.AutoSize = true;
            this.lblNonAcadeAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblNonAcadeAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblNonAcadeAmount.ForeColor = System.Drawing.Color.White;
            this.lblNonAcadeAmount.Location = new System.Drawing.Point(714, 492);
            this.lblNonAcadeAmount.Name = "lblNonAcadeAmount";
            this.lblNonAcadeAmount.Size = new System.Drawing.Size(22, 23);
            this.lblNonAcadeAmount.TabIndex = 15;
            this.lblNonAcadeAmount.Text = "0";
            // 
            // lblTeacherAmount
            // 
            this.lblTeacherAmount.AutoSize = true;
            this.lblTeacherAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTeacherAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblTeacherAmount.ForeColor = System.Drawing.Color.White;
            this.lblTeacherAmount.Location = new System.Drawing.Point(714, 456);
            this.lblTeacherAmount.Name = "lblTeacherAmount";
            this.lblTeacherAmount.Size = new System.Drawing.Size(22, 23);
            this.lblTeacherAmount.TabIndex = 14;
            this.lblTeacherAmount.Text = "0";
            // 
            // lblStudAmount
            // 
            this.lblStudAmount.AutoSize = true;
            this.lblStudAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblStudAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblStudAmount.ForeColor = System.Drawing.Color.White;
            this.lblStudAmount.Location = new System.Drawing.Point(714, 414);
            this.lblStudAmount.Name = "lblStudAmount";
            this.lblStudAmount.Size = new System.Drawing.Size(22, 23);
            this.lblStudAmount.TabIndex = 13;
            this.lblStudAmount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(325, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Number of Non Academic Staff :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(425, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Number of Teachers : -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Number of Students :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 33F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "School Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._145;
            this.pictureBox1.Location = new System.Drawing.Point(323, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.Transparent;
            this.lblday.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.White;
            this.lblday.Location = new System.Drawing.Point(609, 90);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(127, 32);
            this.lblday.TabIndex = 0;
            this.lblday.Text = "Saturday";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(435, 90);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(179, 32);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Mar 09 2020,";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.BackColor = System.Drawing.Color.Transparent;
            this.lblhrs.Font = new System.Drawing.Font("Times New Roman", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.ForeColor = System.Drawing.Color.White;
            this.lblhrs.Location = new System.Drawing.Point(399, 4);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(364, 98);
            this.lblhrs.TabIndex = 7;
            this.lblhrs.Text = "00:00:00";
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 549);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmhome";
            this.Text = "frmhome";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblday;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblhrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNonAcadeAmount;
        private System.Windows.Forms.Label lblTeacherAmount;
        private System.Windows.Forms.Label lblStudAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}