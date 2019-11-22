namespace HospitalMgmtSys.Presentaion_Layer
{
    partial class UpdateAppointment
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
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.appointmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblAptDate = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentid,
            this.personid,
            this.patientName,
            this.date,
            this.starttime,
            this.doctorId,
            this.doctorName,
            this.specialty,
            this.availableDays});
            this.dgvAppointment.Location = new System.Drawing.Point(3, 3);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowTemplate.Height = 24;
            this.dgvAppointment.Size = new System.Drawing.Size(1060, 290);
            this.dgvAppointment.TabIndex = 0;
            this.dgvAppointment.TabStop = false;
            this.dgvAppointment.DoubleClick += new System.EventHandler(this.dgvAppointment_DoubleClick);
            // 
            // appointmentid
            // 
            this.appointmentid.DataPropertyName = "appointmentid";
            this.appointmentid.HeaderText = "Appointment ID";
            this.appointmentid.Name = "appointmentid";
            this.appointmentid.ReadOnly = true;
            this.appointmentid.Visible = false;
            // 
            // personid
            // 
            this.personid.DataPropertyName = "personid";
            this.personid.HeaderText = "Person ID";
            this.personid.Name = "personid";
            this.personid.ReadOnly = true;
            this.personid.Visible = false;
            // 
            // patientName
            // 
            this.patientName.DataPropertyName = "pname";
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Appointment Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // starttime
            // 
            this.starttime.DataPropertyName = "starttime";
            this.starttime.HeaderText = "Appointment Time";
            this.starttime.Name = "starttime";
            this.starttime.ReadOnly = true;
            // 
            // doctorId
            // 
            this.doctorId.DataPropertyName = "doctorid";
            this.doctorId.HeaderText = "Doctor ID";
            this.doctorId.Name = "doctorId";
            this.doctorId.ReadOnly = true;
            this.doctorId.Visible = false;
            // 
            // doctorName
            // 
            this.doctorName.DataPropertyName = "dname";
            this.doctorName.HeaderText = "Doctor\'s Name";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Doctor\'s Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // availableDays
            // 
            this.availableDays.DataPropertyName = "availabledays";
            this.availableDays.HeaderText = "Doctor\'s Available Days";
            this.availableDays.Name = "availableDays";
            this.availableDays.ReadOnly = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.dgvAppointment, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(19, 310);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1066, 296);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(6, 28);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(160, 25);
            this.lblAppointmentID.TabIndex = 7;
            this.lblAppointmentID.Text = "Appointment ID";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(6, 72);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(102, 25);
            this.lblDoctorID.TabIndex = 7;
            this.lblDoctorID.Text = "Doctor ID";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(6, 116);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(106, 25);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "Patient ID";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Enabled = false;
            this.txtAppointmentID.Location = new System.Drawing.Point(205, 29);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(223, 22);
            this.txtAppointmentID.TabIndex = 8;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Enabled = false;
            this.txtDoctorID.Location = new System.Drawing.Point(205, 73);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(223, 22);
            this.txtDoctorID.TabIndex = 8;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Enabled = false;
            this.txtPatientID.Location = new System.Drawing.Point(205, 117);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(223, 22);
            this.txtPatientID.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(855, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(6, 182);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(112, 25);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblAptDate
            // 
            this.lblAptDate.AutoSize = true;
            this.lblAptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptDate.Location = new System.Drawing.Point(6, 130);
            this.lblAptDate.Name = "lblAptDate";
            this.lblAptDate.Size = new System.Drawing.Size(184, 25);
            this.lblAptDate.TabIndex = 7;
            this.lblAptDate.Text = "Appointment Date";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpAppointmentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(236, 130);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(314, 27);
            this.dtpAppointmentDate.TabIndex = 6;
            // 
            // cmbAppointmentTime
            // 
            this.cmbAppointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbAppointmentTime.Location = new System.Drawing.Point(236, 182);
            this.cmbAppointmentTime.Name = "cmbAppointmentTime";
            this.cmbAppointmentTime.Size = new System.Drawing.Size(168, 24);
            this.cmbAppointmentTime.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(738, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(403, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(19, 275);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(378, 27);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(972, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor\'s Name";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(236, 79);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(223, 30);
            this.txtDoctorName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient\'s Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(236, 32);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(223, 30);
            this.txtPatientName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAppointmentTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAptDate);
            this.groupBox1.Controls.Add(this.lblStartTime);
            this.groupBox1.Controls.Add(this.dtpAppointmentDate);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 241);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPatientID);
            this.groupBox2.Controls.Add(this.txtDoctorID);
            this.groupBox2.Controls.Add(this.txtAppointmentID);
            this.groupBox2.Controls.Add(this.lblPatientID);
            this.groupBox2.Controls.Add(this.lblDoctorID);
            this.groupBox2.Controls.Add(this.lblAppointmentID);
            this.groupBox2.Location = new System.Drawing.Point(619, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 174);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reference Info";
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "UpdateAppointment";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Size = new System.Drawing.Size(1100, 623);
            this.Load += new System.EventHandler(this.CancelAppointment_Load);
            this.VisibleChanged += new System.EventHandler(this.UpdateAppointment_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblAptDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbAppointmentTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn personid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDays;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
