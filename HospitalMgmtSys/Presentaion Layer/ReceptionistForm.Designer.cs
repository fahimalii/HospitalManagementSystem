namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class ReceptionistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistForm));
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panleTitle = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelButtonHolder = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnCancelledAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelParent.SuspendLayout();
            this.panleTitle.SuspendLayout();
            this.panelButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.panelMain);
            this.panelParent.Controls.Add(this.panleTitle);
            this.panelParent.Controls.Add(this.panelButtonHolder);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1262, 673);
            this.panelParent.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(162, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1100, 623);
            this.panelMain.TabIndex = 2;
            // 
            // panleTitle
            // 
            this.panleTitle.Controls.Add(this.lblDate);
            this.panleTitle.Controls.Add(this.lblClock);
            this.panleTitle.Controls.Add(this.lblTitle);
            this.panleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panleTitle.Location = new System.Drawing.Point(162, 0);
            this.panleTitle.Name = "panleTitle";
            this.panleTitle.Size = new System.Drawing.Size(1100, 50);
            this.panleTitle.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.lblDate.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(769, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 34);
            this.lblDate.TabIndex = 8;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.lblClock.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(924, 4);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 34);
            this.lblClock.TabIndex = 7;
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
            // panelButtonHolder
            // 
            this.panelButtonHolder.BackColor = System.Drawing.Color.DarkGreen;
            this.panelButtonHolder.Controls.Add(this.btnLogout);
            this.panelButtonHolder.Controls.Add(this.btnMyInfo);
            this.panelButtonHolder.Controls.Add(this.btnCancelledAppointment);
            this.panelButtonHolder.Controls.Add(this.btnUpdateAppointment);
            this.panelButtonHolder.Controls.Add(this.btnAddAppointment);
            this.panelButtonHolder.Controls.Add(this.panelUsername);
            this.panelButtonHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonHolder.Location = new System.Drawing.Point(0, 0);
            this.panelButtonHolder.Name = "panelButtonHolder";
            this.panelButtonHolder.Size = new System.Drawing.Size(162, 673);
            this.panelButtonHolder.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(3, 602);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 59);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyInfo.Location = new System.Drawing.Point(4, 537);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(155, 59);
            this.btnMyInfo.TabIndex = 4;
            this.btnMyInfo.Text = "&My Info";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
            // 
            // btnCancelledAppointment
            // 
            this.btnCancelledAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelledAppointment.Location = new System.Drawing.Point(3, 222);
            this.btnCancelledAppointment.Name = "btnCancelledAppointment";
            this.btnCancelledAppointment.Size = new System.Drawing.Size(155, 59);
            this.btnCancelledAppointment.TabIndex = 3;
            this.btnCancelledAppointment.Text = "&Cancelled Appointment";
            this.btnCancelledAppointment.UseVisualStyleBackColor = true;
            this.btnCancelledAppointment.Click += new System.EventHandler(this.btnCancelledAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAppointment.Location = new System.Drawing.Point(3, 157);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(155, 59);
            this.btnUpdateAppointment.TabIndex = 2;
            this.btnUpdateAppointment.Text = "&Update Appointment";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.Location = new System.Drawing.Point(3, 92);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(155, 59);
            this.btnAddAppointment.TabIndex = 1;
            this.btnAddAppointment.Text = "&Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(162, 50);
            this.panelUsername.TabIndex = 0;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceptionistForm_FormClosed);
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.panelParent.ResumeLayout(false);
            this.panleTitle.ResumeLayout(false);
            this.panleTitle.PerformLayout();
            this.panelButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panleTitle;
        private System.Windows.Forms.Panel panelButtonHolder;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnCancelledAppointment;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
    }
}