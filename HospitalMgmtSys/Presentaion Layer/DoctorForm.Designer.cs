namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panleTitle = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.panelButtonHolder = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDoctorInfo = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panleTitle.SuspendLayout();
            this.panelButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.panleTitle);
            this.panel1.Controls.Add(this.panelButtonHolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 673);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(162, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1100, 623);
            this.panelMain.TabIndex = 3;
            // 
            // panleTitle
            // 
            this.panleTitle.Controls.Add(this.lblDate);
            this.panleTitle.Controls.Add(this.lblTitle);
            this.panleTitle.Controls.Add(this.lblClock);
            this.panleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panleTitle.Location = new System.Drawing.Point(162, 0);
            this.panleTitle.Name = "panleTitle";
            this.panleTitle.Size = new System.Drawing.Size(1100, 50);
            this.panleTitle.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.lblDate.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(769, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 34);
            this.lblDate.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 29);
            this.lblTitle.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.lblClock.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(924, 4);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 34);
            this.lblClock.TabIndex = 11;
            // 
            // panelButtonHolder
            // 
            this.panelButtonHolder.BackColor = System.Drawing.Color.DarkGreen;
            this.panelButtonHolder.Controls.Add(this.btnLogout);
            this.panelButtonHolder.Controls.Add(this.btnDoctorInfo);
            this.panelButtonHolder.Controls.Add(this.btnPatients);
            this.panelButtonHolder.Controls.Add(this.btnAppointments);
            this.panelButtonHolder.Controls.Add(this.panelUsername);
            this.panelButtonHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonHolder.Location = new System.Drawing.Point(0, 0);
            this.panelButtonHolder.Name = "panelButtonHolder";
            this.panelButtonHolder.Size = new System.Drawing.Size(162, 673);
            this.panelButtonHolder.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(3, 602);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 59);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDoctorInfo
            // 
            this.btnDoctorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorInfo.Location = new System.Drawing.Point(4, 537);
            this.btnDoctorInfo.Name = "btnDoctorInfo";
            this.btnDoctorInfo.Size = new System.Drawing.Size(155, 59);
            this.btnDoctorInfo.TabIndex = 3;
            this.btnDoctorInfo.Text = "&My Info";
            this.btnDoctorInfo.UseVisualStyleBackColor = true;
            this.btnDoctorInfo.Click += new System.EventHandler(this.btnDoctorInfo_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatients.Location = new System.Drawing.Point(3, 157);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(155, 59);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "&Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointments.Location = new System.Drawing.Point(3, 92);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(155, 59);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "&Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(162, 50);
            this.panelUsername.TabIndex = 0;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panleTitle.ResumeLayout(false);
            this.panleTitle.PerformLayout();
            this.panelButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtonHolder;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDoctorInfo;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panleTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
    }
}