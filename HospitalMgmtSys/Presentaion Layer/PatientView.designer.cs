namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class PatientView
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
            this.pnlAppointmentInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPersonAge = new System.Windows.Forms.Label();
            this.lblPersonPhone = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPersonGender = new System.Windows.Forms.Label();
            this.lblPersonBloodGroup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAppointmentView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clbMedicine = new System.Windows.Forms.CheckedListBox();
            this.clbDisease = new System.Windows.Forms.CheckedListBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConfirmAppointment = new System.Windows.Forms.Button();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.cmbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAppointmentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAppointmentInfo
            // 
            this.pnlAppointmentInfo.Controls.Add(this.groupBox1);
            this.pnlAppointmentInfo.Controls.Add(this.tableLayoutPanel1);
            this.pnlAppointmentInfo.Controls.Add(this.btnDeleteAll);
            this.pnlAppointmentInfo.Controls.Add(this.btnDelete);
            this.pnlAppointmentInfo.Controls.Add(this.clbMedicine);
            this.pnlAppointmentInfo.Controls.Add(this.clbDisease);
            this.pnlAppointmentInfo.Controls.Add(this.btnClearAll);
            this.pnlAppointmentInfo.Controls.Add(this.btnConfirmAppointment);
            this.pnlAppointmentInfo.Controls.Add(this.label1);
            this.pnlAppointmentInfo.Controls.Add(this.lblMedicine);
            this.pnlAppointmentInfo.Controls.Add(this.lblDisease);
            this.pnlAppointmentInfo.Controls.Add(this.cmbAppointmentTime);
            this.pnlAppointmentInfo.Controls.Add(this.dtpAppointmentDate);
            this.pnlAppointmentInfo.Controls.Add(this.lblTime);
            this.pnlAppointmentInfo.Controls.Add(this.lblDate);
            this.pnlAppointmentInfo.Controls.Add(this.txtSearchPerson);
            this.pnlAppointmentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppointmentInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlAppointmentInfo.Name = "pnlAppointmentInfo";
            this.pnlAppointmentInfo.Size = new System.Drawing.Size(1100, 623);
            this.pnlAppointmentInfo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBloodGroup);
            this.groupBox1.Controls.Add(this.txtPersonID);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblPersonAge);
            this.groupBox1.Controls.Add(this.lblPersonPhone);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.lblPersonGender);
            this.groupBox1.Controls.Add(this.lblPersonBloodGroup);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 257);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s Information";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Enabled = false;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A +ve",
            "A -ve",
            "B +ve",
            "B -ve",
            "O +ve",
            "O -ve"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(157, 181);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(246, 28);
            this.cmbBloodGroup.TabIndex = 69;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Enabled = false;
            this.txtPersonID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.Location = new System.Drawing.Point(157, 36);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(246, 30);
            this.txtPersonID.TabIndex = 51;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmbGender.Location = new System.Drawing.Point(157, 147);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(246, 24);
            this.cmbGender.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(157, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 30);
            this.txtName.TabIndex = 52;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(157, 216);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(246, 30);
            this.txtPhone.TabIndex = 49;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(15, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 23);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "ID";
            // 
            // lblPersonAge
            // 
            this.lblPersonAge.AutoSize = true;
            this.lblPersonAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonAge.Location = new System.Drawing.Point(15, 112);
            this.lblPersonAge.Name = "lblPersonAge";
            this.lblPersonAge.Size = new System.Drawing.Size(40, 23);
            this.lblPersonAge.TabIndex = 44;
            this.lblPersonAge.Text = "Age";
            // 
            // lblPersonPhone
            // 
            this.lblPersonPhone.AutoSize = true;
            this.lblPersonPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonPhone.Location = new System.Drawing.Point(15, 220);
            this.lblPersonPhone.Name = "lblPersonPhone";
            this.lblPersonPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPersonPhone.TabIndex = 41;
            this.lblPersonPhone.Text = "Phone";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(157, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(246, 30);
            this.txtAge.TabIndex = 50;
            // 
            // lblPersonGender
            // 
            this.lblPersonGender.AutoSize = true;
            this.lblPersonGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonGender.Location = new System.Drawing.Point(15, 148);
            this.lblPersonGender.Name = "lblPersonGender";
            this.lblPersonGender.Size = new System.Drawing.Size(66, 23);
            this.lblPersonGender.TabIndex = 43;
            this.lblPersonGender.Text = "Gender";
            // 
            // lblPersonBloodGroup
            // 
            this.lblPersonBloodGroup.AutoSize = true;
            this.lblPersonBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonBloodGroup.Location = new System.Drawing.Point(15, 184);
            this.lblPersonBloodGroup.Name = "lblPersonBloodGroup";
            this.lblPersonBloodGroup.Size = new System.Drawing.Size(107, 23);
            this.lblPersonBloodGroup.TabIndex = 42;
            this.lblPersonBloodGroup.Text = "Blood Group";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.96801F));
            this.tableLayoutPanel1.Controls.Add(this.dgvAppointmentView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 340);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.23927F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvAppointmentView
            // 
            this.dgvAppointmentView.AllowUserToAddRows = false;
            this.dgvAppointmentView.AllowUserToDeleteRows = false;
            this.dgvAppointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvAppointmentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointmentView.Location = new System.Drawing.Point(3, 3);
            this.dgvAppointmentView.Name = "dgvAppointmentView";
            this.dgvAppointmentView.ReadOnly = true;
            this.dgvAppointmentView.RowTemplate.Height = 24;
            this.dgvAppointmentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentView.Size = new System.Drawing.Size(1069, 264);
            this.dgvAppointmentView.TabIndex = 3;
            this.dgvAppointmentView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointmentView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "appointmentid";
            this.dataGridViewTextBoxColumn1.HeaderText = "appointmentid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personid";
            this.dataGridViewTextBoxColumn2.HeaderText = "personid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn4.HeaderText = "age";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bloodgroup";
            this.dataGridViewTextBoxColumn5.HeaderText = "bloodgroup";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn8.HeaderText = "date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "starttime";
            this.dataGridViewTextBoxColumn9.HeaderText = "starttime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Location = new System.Drawing.Point(997, 304);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(87, 30);
            this.btnDeleteAll.TabIndex = 68;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(895, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clbMedicine
            // 
            this.clbMedicine.FormattingEnabled = true;
            this.clbMedicine.Location = new System.Drawing.Point(881, 122);
            this.clbMedicine.Name = "clbMedicine";
            this.clbMedicine.Size = new System.Drawing.Size(203, 140);
            this.clbMedicine.TabIndex = 66;
            // 
            // clbDisease
            // 
            this.clbDisease.FormattingEnabled = true;
            this.clbDisease.Location = new System.Drawing.Point(542, 122);
            this.clbDisease.Name = "clbDisease";
            this.clbDisease.Size = new System.Drawing.Size(197, 140);
            this.clbDisease.TabIndex = 65;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(779, 304);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(87, 30);
            this.btnClearAll.TabIndex = 63;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConfirmAppointment
            // 
            this.btnConfirmAppointment.Location = new System.Drawing.Point(651, 304);
            this.btnConfirmAppointment.Name = "btnConfirmAppointment";
            this.btnConfirmAppointment.Size = new System.Drawing.Size(87, 30);
            this.btnConfirmAppointment.TabIndex = 64;
            this.btnConfirmAppointment.Text = "Confirm";
            this.btnConfirmAppointment.UseVisualStyleBackColor = true;
            this.btnConfirmAppointment.Click += new System.EventHandler(this.btnConfirmAppointment_Click);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(793, 137);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(79, 23);
            this.lblMedicine.TabIndex = 62;
            this.lblMedicine.Text = "Medicine";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisease.Location = new System.Drawing.Point(452, 137);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(67, 23);
            this.lblDisease.TabIndex = 61;
            this.lblDisease.Text = "Disease";
            // 
            // cmbAppointmentTime
            // 
            this.cmbAppointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentTime.Enabled = false;
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
            this.cmbAppointmentTime.Location = new System.Drawing.Point(542, 67);
            this.cmbAppointmentTime.Name = "cmbAppointmentTime";
            this.cmbAppointmentTime.Size = new System.Drawing.Size(168, 24);
            this.cmbAppointmentTime.TabIndex = 60;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Enabled = false;
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(542, 28);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(273, 27);
            this.dtpAppointmentDate.TabIndex = 59;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(452, 68);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 23);
            this.lblTime.TabIndex = 57;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(452, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 23);
            this.lblDate.TabIndex = 58;
            this.lblDate.Text = "Date";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPerson.Location = new System.Drawing.Point(115, 303);
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(302, 30);
            this.txtSearchPerson.TabIndex = 56;
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search";
            // 
            // PatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAppointmentInfo);
            this.Name = "PatientView";
            this.Size = new System.Drawing.Size(1100, 623);
            this.VisibleChanged += new System.EventHandler(this.PatientView_VisibleChanged);
            this.pnlAppointmentInfo.ResumeLayout(false);
            this.pnlAppointmentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAppointmentInfo;
        private System.Windows.Forms.CheckedListBox clbMedicine;
        private System.Windows.Forms.CheckedListBox clbDisease;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnConfirmAppointment;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.ComboBox cmbAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPersonPhone;
        private System.Windows.Forms.Label lblPersonBloodGroup;
        private System.Windows.Forms.Label lblPersonGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPersonAge;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvAppointmentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
    }
}
