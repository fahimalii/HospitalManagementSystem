namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class FireEmployee
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
            this.FirePanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAvailableDays = new System.Windows.Forms.ComboBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.lblAvailableDays = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblDoctorId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBloodGrp = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBloodGrp = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFireEmp = new System.Windows.Forms.DataGridView();
            this.personid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabledays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirePanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFireEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // FirePanel
            // 
            this.FirePanel.Controls.Add(this.groupBox3);
            this.FirePanel.Controls.Add(this.groupBox2);
            this.FirePanel.Controls.Add(this.groupBox1);
            this.FirePanel.Controls.Add(this.btnClear);
            this.FirePanel.Controls.Add(this.label1);
            this.FirePanel.Controls.Add(this.txtSearch);
            this.FirePanel.Controls.Add(this.btnUpdate);
            this.FirePanel.Controls.Add(this.btnDelete);
            this.FirePanel.Controls.Add(this.tableLayoutPanel1);
            this.FirePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirePanel.Location = new System.Drawing.Point(0, 0);
            this.FirePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirePanel.Name = "FirePanel";
            this.FirePanel.Size = new System.Drawing.Size(1100, 623);
            this.FirePanel.TabIndex = 0;
            this.FirePanel.VisibleChanged += new System.EventHandler(this.FirePanel_VisibleChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAvailableDays);
            this.groupBox3.Controls.Add(this.txtSpecialty);
            this.groupBox3.Controls.Add(this.txtDoctorId);
            this.groupBox3.Controls.Add(this.lblAvailableDays);
            this.groupBox3.Controls.Add(this.lblSpecialty);
            this.groupBox3.Controls.Add(this.lblDoctorId);
            this.groupBox3.Location = new System.Drawing.Point(578, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 149);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doctor\'s Information";
            // 
            // cmbAvailableDays
            // 
            this.cmbAvailableDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableDays.FormattingEnabled = true;
            this.cmbAvailableDays.Items.AddRange(new object[] {
            "Sat Mon Wed Fri",
            "Sun Tue Thu"});
            this.cmbAvailableDays.Location = new System.Drawing.Point(160, 111);
            this.cmbAvailableDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAvailableDays.Name = "cmbAvailableDays";
            this.cmbAvailableDays.Size = new System.Drawing.Size(241, 24);
            this.cmbAvailableDays.TabIndex = 14;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(160, 70);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(241, 22);
            this.txtSpecialty.TabIndex = 13;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Enabled = false;
            this.txtDoctorId.Location = new System.Drawing.Point(160, 30);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(241, 22);
            this.txtDoctorId.TabIndex = 2;
            this.txtDoctorId.TabStop = false;
            // 
            // lblAvailableDays
            // 
            this.lblAvailableDays.AutoSize = true;
            this.lblAvailableDays.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableDays.Location = new System.Drawing.Point(15, 115);
            this.lblAvailableDays.Name = "lblAvailableDays";
            this.lblAvailableDays.Size = new System.Drawing.Size(123, 17);
            this.lblAvailableDays.TabIndex = 1;
            this.lblAvailableDays.Text = "Available Days :";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.Location = new System.Drawing.Point(15, 73);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(82, 17);
            this.lblSpecialty.TabIndex = 1;
            this.lblSpecialty.Text = "Specialty :";
            // 
            // lblDoctorId
            // 
            this.lblDoctorId.AutoSize = true;
            this.lblDoctorId.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorId.Location = new System.Drawing.Point(15, 33);
            this.lblDoctorId.Name = "lblDoctorId";
            this.lblDoctorId.Size = new System.Drawing.Size(89, 17);
            this.lblDoctorId.TabIndex = 1;
            this.lblDoctorId.Text = "Doctor ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDesignation);
            this.groupBox2.Controls.Add(this.txtSalary);
            this.groupBox2.Controls.Add(this.txtEmpId);
            this.groupBox2.Controls.Add(this.lblSalary);
            this.groupBox2.Controls.Add(this.lblDesignation);
            this.groupBox2.Controls.Add(this.lblEmpId);
            this.groupBox2.Location = new System.Drawing.Point(578, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 153);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee\'s Information";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Enabled = false;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Receptionist",
            "Doctor"});
            this.cmbDesignation.Location = new System.Drawing.Point(160, 70);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(241, 24);
            this.cmbDesignation.TabIndex = 11;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(160, 107);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(241, 22);
            this.txtSalary.TabIndex = 12;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Location = new System.Drawing.Point(160, 32);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(241, 22);
            this.txtEmpId.TabIndex = 2;
            this.txtEmpId.TabStop = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(15, 110);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(63, 17);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary :";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(15, 75);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(102, 17);
            this.lblDesignation.TabIndex = 1;
            this.lblDesignation.Text = "Designation :";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(15, 35);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(72, 17);
            this.lblEmpId.TabIndex = 1;
            this.lblEmpId.Text = "Emp ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.cmbBloodGrp);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblBloodGrp);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 323);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person\'s Information";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(49, 248);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 17);
            this.lblSearch.TabIndex = 7;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(158, 204);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(281, 24);
            this.cmbGender.TabIndex = 9;
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
            this.cmbBloodGrp.Location = new System.Drawing.Point(158, 241);
            this.cmbBloodGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBloodGrp.Name = "cmbBloodGrp";
            this.cmbBloodGrp.Size = new System.Drawing.Size(281, 24);
            this.cmbBloodGrp.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(158, 166);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(281, 22);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(158, 114);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(281, 22);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(158, 38);
            this.txtPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(281, 22);
            this.txtPID.TabIndex = 2;
            this.txtPID.TabStop = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(22, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 17);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender :";
            // 
            // lblBloodGrp
            // 
            this.lblBloodGrp.AutoSize = true;
            this.lblBloodGrp.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGrp.Location = new System.Drawing.Point(22, 240);
            this.lblBloodGrp.Name = "lblBloodGrp";
            this.lblBloodGrp.Size = new System.Drawing.Size(102, 17);
            this.lblBloodGrp.TabIndex = 1;
            this.lblBloodGrp.Text = "BloodGroup :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(22, 117);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(61, 17);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Phone :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(22, 169);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 17);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(22, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(976, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 29);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(108, 382);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(738, 372);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 27);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(862, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.dgvFireEmp, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 406);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvFireEmp
            // 
            this.dgvFireEmp.AllowUserToAddRows = false;
            this.dgvFireEmp.AllowUserToDeleteRows = false;
            this.dgvFireEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFireEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personid,
            this.name,
            this.age,
            this.gender,
            this.bloodgroup,
            this.phone,
            this.designation,
            this.salary,
            this.empid,
            this.doctorid,
            this.specialty,
            this.availabledays});
            this.dgvFireEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFireEmp.Location = new System.Drawing.Point(3, 3);
            this.dgvFireEmp.Name = "dgvFireEmp";
            this.dgvFireEmp.ReadOnly = true;
            this.dgvFireEmp.RowTemplate.Height = 24;
            this.dgvFireEmp.Size = new System.Drawing.Size(1064, 200);
            this.dgvFireEmp.TabIndex = 0;
            this.dgvFireEmp.TabStop = false;
            this.dgvFireEmp.DoubleClick += new System.EventHandler(this.dgvFireEmp_DoubleClick);
            // 
            // personid
            // 
            this.personid.DataPropertyName = "personid";
            this.personid.HeaderText = "pid";
            this.personid.Name = "personid";
            this.personid.ReadOnly = true;
            this.personid.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // bloodgroup
            // 
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "Bloodgroup";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // designation
            // 
            this.designation.DataPropertyName = "designation";
            this.designation.HeaderText = "Designation";
            this.designation.Name = "designation";
            this.designation.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // empid
            // 
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "empid";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Visible = false;
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "doctorid";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Visible = false;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // availabledays
            // 
            this.availabledays.DataPropertyName = "availabledays";
            this.availabledays.HeaderText = "Available Days";
            this.availabledays.Name = "availabledays";
            this.availabledays.ReadOnly = true;
            // 
            // FireEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FirePanel);
            this.Name = "FireEmployee";
            this.Size = new System.Drawing.Size(1100, 623);
            this.Load += new System.EventHandler(this.FireEmployee_Load);
            this.FirePanel.ResumeLayout(false);
            this.FirePanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFireEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FirePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAvailableDays;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBloodGrp;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbAvailableDays;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBloodGrp;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFireEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn personid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabledays;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
