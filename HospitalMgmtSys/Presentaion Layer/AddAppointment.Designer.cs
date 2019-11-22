namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class AddAppointment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersonView = new System.Windows.Forms.DataGridView();
            this.personid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDoctorView = new System.Windows.Forms.DataGridView();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabledays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnSearchDoctor = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConfirmAppointment = new System.Windows.Forms.Button();
            this.cmbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPersonPhone = new System.Windows.Forms.Label();
            this.lblPersonBloodGroup = new System.Windows.Forms.Label();
            this.lblPersonGender = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPersonAge = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.grpBoxPatientInfo = new System.Windows.Forms.GroupBox();
            this.grpBoxAppointmentInfo = new System.Windows.Forms.GroupBox();
            this.grpBoxDoctorInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorView)).BeginInit();
            this.grpBoxPatientInfo.SuspendLayout();
            this.grpBoxAppointmentInfo.SuspendLayout();
            this.grpBoxDoctorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.12477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.87523F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPersonView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDoctorView, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 349);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 264);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPersonView
            // 
            this.dgvPersonView.AllowUserToAddRows = false;
            this.dgvPersonView.AllowUserToDeleteRows = false;
            this.dgvPersonView.AllowUserToResizeColumns = false;
            this.dgvPersonView.AllowUserToResizeRows = false;
            this.dgvPersonView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personid,
            this.pname,
            this.age,
            this.gender,
            this.bloodgroup,
            this.phone});
            this.dgvPersonView.Location = new System.Drawing.Point(3, 3);
            this.dgvPersonView.Name = "dgvPersonView";
            this.dgvPersonView.ReadOnly = true;
            this.dgvPersonView.RowTemplate.Height = 24;
            this.dgvPersonView.Size = new System.Drawing.Size(629, 258);
            this.dgvPersonView.TabIndex = 0;
            this.dgvPersonView.TabStop = false;
            this.dgvPersonView.DoubleClick += new System.EventHandler(this.dgvPersonView_DoubleClick);
            // 
            // personid
            // 
            this.personid.DataPropertyName = "personid";
            this.personid.HeaderText = "Person ID";
            this.personid.Name = "personid";
            this.personid.ReadOnly = true;
            this.personid.Visible = false;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "name";
            this.pname.HeaderText = "Person Name";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
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
            this.bloodgroup.HeaderText = "Blood Group";
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // dgvDoctorView
            // 
            this.dgvDoctorView.AllowUserToAddRows = false;
            this.dgvDoctorView.AllowUserToDeleteRows = false;
            this.dgvDoctorView.AllowUserToResizeColumns = false;
            this.dgvDoctorView.AllowUserToResizeRows = false;
            this.dgvDoctorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorid,
            this.dname,
            this.specialty,
            this.availabledays});
            this.dgvDoctorView.Location = new System.Drawing.Point(638, 3);
            this.dgvDoctorView.MultiSelect = false;
            this.dgvDoctorView.Name = "dgvDoctorView";
            this.dgvDoctorView.ReadOnly = true;
            this.dgvDoctorView.RowTemplate.Height = 24;
            this.dgvDoctorView.Size = new System.Drawing.Size(433, 258);
            this.dgvDoctorView.TabIndex = 0;
            this.dgvDoctorView.TabStop = false;
            this.dgvDoctorView.DoubleClick += new System.EventHandler(this.dgvDoctorView_DoubleClick);
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor ID";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Visible = false;
            // 
            // dname
            // 
            this.dname.DataPropertyName = "name";
            this.dname.HeaderText = "Doctor Name";
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
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
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDoctor.Location = new System.Drawing.Point(708, 316);
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(257, 30);
            this.txtSearchDoctor.TabIndex = 17;
            this.txtSearchDoctor.TextChanged += new System.EventHandler(this.txtSearchDoctor_TextChanged);
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPerson.Location = new System.Drawing.Point(13, 316);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(306, 30);
            this.txtSearchPerson.TabIndex = 15;
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A +ve",
            "A -ve",
            "B +ve",
            "B -ve",
            "O +ve",
            "O -ve"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(163, 183);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(357, 28);
            this.cmbBloodGroup.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(163, 145);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(357, 28);
            this.cmbGender.TabIndex = 8;
            // 
            // btnSearchDoctor
            // 
            this.btnSearchDoctor.Location = new System.Drawing.Point(971, 316);
            this.btnSearchDoctor.Name = "btnSearchDoctor";
            this.btnSearchDoctor.Size = new System.Drawing.Size(113, 30);
            this.btnSearchDoctor.TabIndex = 18;
            this.btnSearchDoctor.Text = "Search &Doctor";
            this.btnSearchDoctor.UseVisualStyleBackColor = true;
            this.btnSearchDoctor.Click += new System.EventHandler(this.btnSearchDoctor_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(325, 316);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(113, 30);
            this.btnSearchPerson.TabIndex = 16;
            this.btnSearchPerson.Text = "Search &Person";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(997, 277);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(87, 30);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "Clea&r";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConfirmAppointment
            // 
            this.btnConfirmAppointment.Location = new System.Drawing.Point(823, 277);
            this.btnConfirmAppointment.Name = "btnConfirmAppointment";
            this.btnConfirmAppointment.Size = new System.Drawing.Size(156, 30);
            this.btnConfirmAppointment.TabIndex = 13;
            this.btnConfirmAppointment.Text = "C&onfirm Appointment";
            this.btnConfirmAppointment.UseVisualStyleBackColor = true;
            this.btnConfirmAppointment.Click += new System.EventHandler(this.btnConfirmAppointment_Click);
            // 
            // cmbAppointmentTime
            // 
            this.cmbAppointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAppointmentTime.FormattingEnabled = true;
            this.cmbAppointmentTime.Items.AddRange(new object[] {
            "16:00:00",
            "16:30:00",
            "17:00:00",
            "17:30:00",
            "18:00:00",
            "18:30:00",
            "19:00:00",
            "19:30:00",
            "20:00:00",
            "20:30:00",
            "21:00:00",
            "21:30:00",
            "22:00:00",
            "22:30:00"});
            this.cmbAppointmentTime.Location = new System.Drawing.Point(100, 67);
            this.cmbAppointmentTime.Name = "cmbAppointmentTime";
            this.cmbAppointmentTime.Size = new System.Drawing.Size(168, 28);
            this.cmbAppointmentTime.TabIndex = 12;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(100, 24);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(380, 27);
            this.dtpAppointmentDate.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(163, 220);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(357, 30);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPersonPhone
            // 
            this.lblPersonPhone.AutoSize = true;
            this.lblPersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonPhone.Location = new System.Drawing.Point(17, 225);
            this.lblPersonPhone.Name = "lblPersonPhone";
            this.lblPersonPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPersonPhone.TabIndex = 20;
            this.lblPersonPhone.Text = "Phone";
            // 
            // lblPersonBloodGroup
            // 
            this.lblPersonBloodGroup.AutoSize = true;
            this.lblPersonBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonBloodGroup.Location = new System.Drawing.Point(15, 187);
            this.lblPersonBloodGroup.Name = "lblPersonBloodGroup";
            this.lblPersonBloodGroup.Size = new System.Drawing.Size(114, 20);
            this.lblPersonBloodGroup.TabIndex = 19;
            this.lblPersonBloodGroup.Text = "Blood Group";
            // 
            // lblPersonGender
            // 
            this.lblPersonGender.AutoSize = true;
            this.lblPersonGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonGender.Location = new System.Drawing.Point(15, 149);
            this.lblPersonGender.Name = "lblPersonGender";
            this.lblPersonGender.Size = new System.Drawing.Size(70, 20);
            this.lblPersonGender.TabIndex = 10;
            this.lblPersonGender.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(161, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(359, 30);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // lblPersonAge
            // 
            this.lblPersonAge.AutoSize = true;
            this.lblPersonAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonAge.Location = new System.Drawing.Point(15, 111);
            this.lblPersonAge.Name = "lblPersonAge";
            this.lblPersonAge.Size = new System.Drawing.Size(41, 20);
            this.lblPersonAge.TabIndex = 18;
            this.lblPersonAge.Text = "Age";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Enabled = false;
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(162, 27);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(359, 30);
            this.txtPersonID.TabIndex = 5;
            this.txtPersonID.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 75);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(16, 30);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(33, 25);
            this.lblPersonID.TabIndex = 14;
            this.lblPersonID.Text = "ID";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Enabled = false;
            this.txtDoctorID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.Location = new System.Drawing.Point(159, 68);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(273, 30);
            this.txtDoctorID.TabIndex = 14;
            this.txtDoctorID.TabStop = false;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(7, 73);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(91, 20);
            this.lblDoctorID.TabIndex = 13;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(159, 22);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(273, 30);
            this.txtDoctorName.TabIndex = 13;
            this.txtDoctorName.TabStop = false;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(7, 27);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(120, 20);
            this.lblDoctorName.TabIndex = 12;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(161, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 30);
            this.txtName.TabIndex = 6;
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.Location = new System.Drawing.Point(15, 73);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(57, 20);
            this.lblPersonName.TabIndex = 21;
            this.lblPersonName.Text = "Name";
            // 
            // grpBoxPatientInfo
            // 
            this.grpBoxPatientInfo.Controls.Add(this.cmbBloodGroup);
            this.grpBoxPatientInfo.Controls.Add(this.cmbGender);
            this.grpBoxPatientInfo.Controls.Add(this.txtPhone);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonPhone);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonBloodGroup);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonGender);
            this.grpBoxPatientInfo.Controls.Add(this.txtAge);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonAge);
            this.grpBoxPatientInfo.Controls.Add(this.txtPersonID);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonID);
            this.grpBoxPatientInfo.Controls.Add(this.txtName);
            this.grpBoxPatientInfo.Controls.Add(this.lblPersonName);
            this.grpBoxPatientInfo.Location = new System.Drawing.Point(16, 18);
            this.grpBoxPatientInfo.Name = "grpBoxPatientInfo";
            this.grpBoxPatientInfo.Size = new System.Drawing.Size(551, 278);
            this.grpBoxPatientInfo.TabIndex = 22;
            this.grpBoxPatientInfo.TabStop = false;
            this.grpBoxPatientInfo.Text = "Patient\'s Information";
            // 
            // grpBoxAppointmentInfo
            // 
            this.grpBoxAppointmentInfo.Controls.Add(this.cmbAppointmentTime);
            this.grpBoxAppointmentInfo.Controls.Add(this.dtpAppointmentDate);
            this.grpBoxAppointmentInfo.Controls.Add(this.lblTime);
            this.grpBoxAppointmentInfo.Controls.Add(this.lblDate);
            this.grpBoxAppointmentInfo.Location = new System.Drawing.Point(597, 139);
            this.grpBoxAppointmentInfo.Name = "grpBoxAppointmentInfo";
            this.grpBoxAppointmentInfo.Size = new System.Drawing.Size(486, 112);
            this.grpBoxAppointmentInfo.TabIndex = 23;
            this.grpBoxAppointmentInfo.TabStop = false;
            this.grpBoxAppointmentInfo.Text = "Appointment\'s Information";
            // 
            // grpBoxDoctorInfo
            // 
            this.grpBoxDoctorInfo.Controls.Add(this.txtDoctorID);
            this.grpBoxDoctorInfo.Controls.Add(this.lblDoctorID);
            this.grpBoxDoctorInfo.Controls.Add(this.txtDoctorName);
            this.grpBoxDoctorInfo.Controls.Add(this.lblDoctorName);
            this.grpBoxDoctorInfo.Location = new System.Drawing.Point(597, 18);
            this.grpBoxDoctorInfo.Name = "grpBoxDoctorInfo";
            this.grpBoxDoctorInfo.Size = new System.Drawing.Size(486, 115);
            this.grpBoxDoctorInfo.TabIndex = 24;
            this.grpBoxDoctorInfo.TabStop = false;
            this.grpBoxDoctorInfo.Text = "Doctor\'s Information";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBoxDoctorInfo);
            this.Controls.Add(this.grpBoxAppointmentInfo);
            this.Controls.Add(this.grpBoxPatientInfo);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.btnSearchDoctor);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnConfirmAppointment);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddAppointment";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Size = new System.Drawing.Size(1100, 623);
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.VisibleChanged += new System.EventHandler(this.AddAppointment_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorView)).EndInit();
            this.grpBoxPatientInfo.ResumeLayout(false);
            this.grpBoxPatientInfo.PerformLayout();
            this.grpBoxAppointmentInfo.ResumeLayout(false);
            this.grpBoxAppointmentInfo.PerformLayout();
            this.grpBoxDoctorInfo.ResumeLayout(false);
            this.grpBoxDoctorInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvPersonView;
        private System.Windows.Forms.DataGridView dgvDoctorView;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnSearchDoctor;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnConfirmAppointment;
        private System.Windows.Forms.ComboBox cmbAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPersonPhone;
        private System.Windows.Forms.Label lblPersonBloodGroup;
        private System.Windows.Forms.Label lblPersonGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPersonAge;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabledays;
        private System.Windows.Forms.DataGridViewTextBoxColumn personid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.GroupBox grpBoxPatientInfo;
        private System.Windows.Forms.GroupBox grpBoxAppointmentInfo;
        private System.Windows.Forms.GroupBox grpBoxDoctorInfo;
    }
}
