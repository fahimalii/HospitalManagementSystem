namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class CreateUser
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
            this.dgvEmpInfo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpInfo
            // 
            this.dgvEmpInfo.AllowUserToAddRows = false;
            this.dgvEmpInfo.AllowUserToDeleteRows = false;
            this.dgvEmpInfo.AllowUserToResizeColumns = false;
            this.dgvEmpInfo.AllowUserToResizeRows = false;
            this.dgvEmpInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.gender,
            this.age,
            this.bloodgrp,
            this.phone,
            this.empId,
            this.salary,
            this.Designation,
            this.docid,
            this.specialty,
            this.availableday});
            this.dgvEmpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpInfo.Location = new System.Drawing.Point(3, 2);
            this.dgvEmpInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpInfo.MultiSelect = false;
            this.dgvEmpInfo.Name = "dgvEmpInfo";
            this.dgvEmpInfo.ReadOnly = true;
            this.dgvEmpInfo.RowTemplate.Height = 28;
            this.dgvEmpInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmpInfo.Size = new System.Drawing.Size(1056, 250);
            this.dgvEmpInfo.TabIndex = 1;
            this.dgvEmpInfo.TabStop = false;
            this.dgvEmpInfo.DoubleClick += new System.EventHandler(this.dgvEmpInfo_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEmpInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 352);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 254);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credentials";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(313, 195);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 36);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Cre&ate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(162, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 30);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(162, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 30);
            this.txtUsername.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesignation);
            this.groupBox2.Controls.Add(this.txtEmployeeID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(619, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Info";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Enabled = false;
            this.txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(182, 50);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(249, 30);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(182, 127);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(249, 30);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Designation";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(957, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "personid";
            this.pid.HeaderText = "Person ID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Visible = false;
            this.pid.Width = 99;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "name";
            this.pname.HeaderText = "Name";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 74;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 85;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 62;
            // 
            // bloodgrp
            // 
            this.bloodgrp.DataPropertyName = "bloodgroup";
            this.bloodgrp.HeaderText = "BloodGroup";
            this.bloodgrp.Name = "bloodgrp";
            this.bloodgrp.ReadOnly = true;
            this.bloodgrp.Width = 113;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "PhoneNumber";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 128;
            // 
            // empId
            // 
            this.empId.DataPropertyName = "empid";
            this.empId.HeaderText = "EmpID";
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Visible = false;
            this.empId.Width = 78;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 77;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "designation";
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            this.Designation.Width = 112;
            // 
            // docid
            // 
            this.docid.DataPropertyName = "doctorid";
            this.docid.HeaderText = "DocID";
            this.docid.Name = "docid";
            this.docid.ReadOnly = true;
            this.docid.Visible = false;
            this.docid.Width = 75;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            this.specialty.Width = 94;
            // 
            // availableday
            // 
            this.availableday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availableday.DataPropertyName = "availabledays";
            this.availableday.HeaderText = "AvailableDays";
            this.availableday.Name = "availableday";
            this.availableday.ReadOnly = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(1100, 623);
            this.VisibleChanged += new System.EventHandler(this.CreateUser_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn docid;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableday;
    }
}
