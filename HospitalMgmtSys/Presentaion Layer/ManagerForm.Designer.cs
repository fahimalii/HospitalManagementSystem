namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panleTitle = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelButtonHolder = new System.Windows.Forms.Panel();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHireEmployee = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
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
            this.lblDate.TabIndex = 10;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.lblClock.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(924, 4);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 34);
            this.lblClock.TabIndex = 9;
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
            this.lblTitle.TabIndex = 1;
            // 
            // panelButtonHolder
            // 
            this.panelButtonHolder.BackColor = System.Drawing.Color.DarkGreen;
            this.panelButtonHolder.Controls.Add(this.btnMyInfo);
            this.panelButtonHolder.Controls.Add(this.btnLogout);
            this.panelButtonHolder.Controls.Add(this.btnHireEmployee);
            this.panelButtonHolder.Controls.Add(this.btnCreateUser);
            this.panelButtonHolder.Controls.Add(this.btnFireEmployee);
            this.panelButtonHolder.Controls.Add(this.panelUsername);
            this.panelButtonHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonHolder.Location = new System.Drawing.Point(0, 0);
            this.panelButtonHolder.Name = "panelButtonHolder";
            this.panelButtonHolder.Size = new System.Drawing.Size(162, 673);
            this.panelButtonHolder.TabIndex = 0;
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyInfo.Location = new System.Drawing.Point(3, 537);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(155, 59);
            this.btnMyInfo.TabIndex = 4;
            this.btnMyInfo.Text = "&My Info";
            this.btnMyInfo.UseVisualStyleBackColor = true;
            this.btnMyInfo.Click += new System.EventHandler(this.btnMyInfo_Click);
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
            // btnHireEmployee
            // 
            this.btnHireEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHireEmployee.Location = new System.Drawing.Point(3, 92);
            this.btnHireEmployee.Name = "btnHireEmployee";
            this.btnHireEmployee.Size = new System.Drawing.Size(155, 59);
            this.btnHireEmployee.TabIndex = 1;
            this.btnHireEmployee.Text = "&Hire Employee";
            this.btnHireEmployee.UseVisualStyleBackColor = true;
            this.btnHireEmployee.Click += new System.EventHandler(this.btnHireEmployee_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.Location = new System.Drawing.Point(3, 222);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(155, 59);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "&Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFireEmployee.Location = new System.Drawing.Point(3, 157);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(155, 59);
            this.btnFireEmployee.TabIndex = 2;
            this.btnFireEmployee.Text = "&Fire Employee";
            this.btnFireEmployee.UseVisualStyleBackColor = true;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(162, 50);
            this.panelUsername.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panleTitle.ResumeLayout(false);
            this.panleTitle.PerformLayout();
            this.panelButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panleTitle;
        private System.Windows.Forms.Panel panelButtonHolder;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Button btnHireEmployee;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClock;
    }
}