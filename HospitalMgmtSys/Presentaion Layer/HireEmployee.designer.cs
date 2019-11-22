namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class HireEmployee
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
            this.HirePanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHireEmp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBloodGrp = new System.Windows.Forms.ComboBox();
            this.cmbAvailableDays = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBloodGrp = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAvailableDays = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblheading2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HirePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHireEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // HirePanel
            // 
            this.HirePanel.Controls.Add(this.btnClear);
            this.HirePanel.Controls.Add(this.tableLayoutPanel1);
            this.HirePanel.Controls.Add(this.btnSave);
            this.HirePanel.Controls.Add(this.cmbBloodGrp);
            this.HirePanel.Controls.Add(this.cmbAvailableDays);
            this.HirePanel.Controls.Add(this.cmbDesignation);
            this.HirePanel.Controls.Add(this.cmbGender);
            this.HirePanel.Controls.Add(this.txtPhoneNumber);
            this.HirePanel.Controls.Add(this.txtAge);
            this.HirePanel.Controls.Add(this.txtEmpId);
            this.HirePanel.Controls.Add(this.txtSalary);
            this.HirePanel.Controls.Add(this.txtSpecialty);
            this.HirePanel.Controls.Add(this.txtFullName);
            this.HirePanel.Controls.Add(this.txtId);
            this.HirePanel.Controls.Add(this.lblPhoneNumber);
            this.HirePanel.Controls.Add(this.lblBloodGrp);
            this.HirePanel.Controls.Add(this.lblGender);
            this.HirePanel.Controls.Add(this.lblAge);
            this.HirePanel.Controls.Add(this.lblFullName);
            this.HirePanel.Controls.Add(this.lblAvailableDays);
            this.HirePanel.Controls.Add(this.lblSpecialty);
            this.HirePanel.Controls.Add(this.lblDesignation);
            this.HirePanel.Controls.Add(this.lblSalary);
            this.HirePanel.Controls.Add(this.lblEmpId);
            this.HirePanel.Controls.Add(this.lblId);
            this.HirePanel.Controls.Add(this.lblheading2);
            this.HirePanel.Controls.Add(this.label1);
            this.HirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HirePanel.Location = new System.Drawing.Point(0, 0);
            this.HirePanel.Name = "HirePanel";
            this.HirePanel.Size = new System.Drawing.Size(1100, 623);
            this.HirePanel.TabIndex = 0;
            this.HirePanel.VisibleChanged += new System.EventHandler(this.HirePanel_VisibleChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(985, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 29);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.dgvHireEmp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 367);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 240);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvHireEmp
            // 
            this.dgvHireEmp.AllowUserToAddRows = false;
            this.dgvHireEmp.AllowUserToDeleteRows = false;
            this.dgvHireEmp.AllowUserToResizeColumns = false;
            this.dgvHireEmp.AllowUserToResizeRows = false;
            this.dgvHireEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHireEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHireEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHireEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column12});
            this.dgvHireEmp.Location = new System.Drawing.Point(3, 2);
            this.dgvHireEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHireEmp.Name = "dgvHireEmp";
            this.dgvHireEmp.ReadOnly = true;
            this.dgvHireEmp.RowTemplate.Height = 28;
            this.dgvHireEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHireEmp.Size = new System.Drawing.Size(1065, 236);
            this.dgvHireEmp.TabIndex = 0;
            this.dgvHireEmp.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "personid";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 48;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "age";
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 62;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gender";
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 85;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "bloodgroup";
            this.Column5.HeaderText = "BloodGroup";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 113;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "phone";
            this.Column6.HeaderText = "Phone";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 78;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "salary";
            this.Column7.HeaderText = "Salary";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 77;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "designation";
            this.Column8.HeaderText = "Designation";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 112;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "specialty";
            this.Column11.HeaderText = "Specialty";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 94;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "availabledays";
            this.Column12.HeaderText = "AvailableDays";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(864, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 27);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBloodGrp
            // 
            this.cmbBloodGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGrp.FormattingEnabled = true;
            this.cmbBloodGrp.Items.AddRange(new object[] {
            "A +ve",
            "A -ve",
            "B +ve",
            "B -ve",
            "O +ve",
            "O -ve"});
            this.cmbBloodGrp.Location = new System.Drawing.Point(775, 60);
            this.cmbBloodGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBloodGrp.Name = "cmbBloodGrp";
            this.cmbBloodGrp.Size = new System.Drawing.Size(302, 24);
            this.cmbBloodGrp.TabIndex = 8;
            // 
            // cmbAvailableDays
            // 
            this.cmbAvailableDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableDays.FormattingEnabled = true;
            this.cmbAvailableDays.Items.AddRange(new object[] {
            "Sat Mon Wed Fri",
            "Sun Tue Thu"});
            this.cmbAvailableDays.Location = new System.Drawing.Point(775, 284);
            this.cmbAvailableDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAvailableDays.Name = "cmbAvailableDays";
            this.cmbAvailableDays.Size = new System.Drawing.Size(302, 24);
            this.cmbAvailableDays.TabIndex = 14;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Receptionist",
            "Doctor"});
            this.cmbDesignation.Location = new System.Drawing.Point(157, 316);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(273, 24);
            this.cmbDesignation.TabIndex = 12;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(775, 97);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(302, 24);
            this.cmbGender.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(775, 137);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(302, 22);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(128, 139);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(302, 22);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(157, 247);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(273, 22);
            this.txtEmpId.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(157, 284);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(273, 22);
            this.txtSalary.TabIndex = 11;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(775, 248);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(302, 22);
            this.txtSpecialty.TabIndex = 13;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(128, 102);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(302, 22);
            this.txtFullName.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(128, 66);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(302, 22);
            this.txtId.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(632, 138);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(120, 17);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblBloodGrp
            // 
            this.lblBloodGrp.AutoSize = true;
            this.lblBloodGrp.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGrp.Location = new System.Drawing.Point(632, 65);
            this.lblBloodGrp.Name = "lblBloodGrp";
            this.lblBloodGrp.Size = new System.Drawing.Size(107, 17);
            this.lblBloodGrp.TabIndex = 3;
            this.lblBloodGrp.Text = "Blood Group :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(632, 101);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 17);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(23, 139);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 17);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age :";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(23, 102);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 17);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name :";
            // 
            // lblAvailableDays
            // 
            this.lblAvailableDays.AutoSize = true;
            this.lblAvailableDays.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableDays.Location = new System.Drawing.Point(632, 287);
            this.lblAvailableDays.Name = "lblAvailableDays";
            this.lblAvailableDays.Size = new System.Drawing.Size(118, 17);
            this.lblAvailableDays.TabIndex = 1;
            this.lblAvailableDays.Text = "AvailableDays :";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.Location = new System.Drawing.Point(632, 252);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(82, 17);
            this.lblSpecialty.TabIndex = 1;
            this.lblSpecialty.Text = "Specialty :";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(23, 318);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(102, 17);
            this.lblDesignation.TabIndex = 1;
            this.lblDesignation.Text = "Designation :";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(24, 282);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 17);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary :";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(24, 249);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(72, 17);
            this.lblEmpId.TabIndex = 1;
            this.lblEmpId.Text = "Emp ID :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(23, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID :";
            // 
            // lblheading2
            // 
            this.lblheading2.AutoSize = true;
            this.lblheading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading2.Location = new System.Drawing.Point(22, 205);
            this.lblheading2.Name = "lblheading2";
            this.lblheading2.Size = new System.Drawing.Size(213, 24);
            this.lblheading2.TabIndex = 0;
            this.lblheading2.Text = "Employee Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Personal Information";
            // 
            // HireEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HirePanel);
            this.Name = "HireEmployee";
            this.Size = new System.Drawing.Size(1100, 623);
            this.HirePanel.ResumeLayout(false);
            this.HirePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHireEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HirePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblBloodGrp;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbBloodGrp;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblheading2;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Label lblAvailableDays;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cmbAvailableDays;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvHireEmp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnClear;
    }
}
