using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMgmtSys.Repository_Layer;
using HospitalMgmtSys.Data_Layer;

namespace HospitalMgmtSys.Presentaion_Layer
{
    public partial class AddAppointment : UserControl
    {
        private int PatientID { get; set; }

        public AddAppointment()
        {
            InitializeComponent();
            this.PopulateDoctorTable();
            this.PopulatePersonTable();
        }

        #region Datagrid View

        private void PopulatePersonTable(string query = "select * from person")
        {
            PersonRepo p = new PersonRepo();
            this.dgvPersonView.AutoGenerateColumns = false;
            this.dgvPersonView.DataSource = p.GetAllPersons(query);
        }

        private void dgvPersonView_DoubleClick(object sender, EventArgs e)
        {
            this.txtPersonID.Text = this.dgvPersonView.CurrentRow.Cells["personid"].Value.ToString();
            this.txtName.Text = this.dgvPersonView.CurrentRow.Cells["pname"].Value.ToString();
            this.txtAge.Text = this.dgvPersonView.CurrentRow.Cells["age"].Value.ToString();
            this.cmbGender.Text = this.dgvPersonView.CurrentRow.Cells["gender"].Value.ToString();
            this.cmbBloodGroup.Text = this.dgvPersonView.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.txtPhone.Text = this.dgvPersonView.CurrentRow.Cells["phone"].Value.ToString();
        }

        // Query to Populate Doctor's Table
        private const string doctorPopulateSql = @"select person.*, employee.*, doctor.*
                        from person, employee, doctor
                        where doctor.empid = employee.empid and person.personid = employee.personid";
        private void PopulateDoctorTable(string sql = doctorPopulateSql)
        {
            DataSet personDataTable = DataAccess.GetDataSet(sql);
            this.dgvDoctorView.AutoGenerateColumns = false;
            this.dgvDoctorView.DataSource = personDataTable.Tables[0];
        }

        private void dgvDoctorView_DoubleClick(object sender, EventArgs e)
        {
            this.txtDoctorName.Text = this.dgvDoctorView.CurrentRow.Cells["dname"].Value.ToString();
            this.txtDoctorID.Text = this.dgvDoctorView.CurrentRow.Cells["doctorid"].Value.ToString();
        }

        #endregion

        #region Table Refresh

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            this.txtName.Focus();
            this.PopulateDoctorTable();
            this.PopulatePersonTable();
        }

        private void AddAppointment_VisibleChanged(object sender, EventArgs e)
        {
            this.CLearAll();
            this.txtName.Focus();
            this.PopulatePersonTable();
            this.PopulateDoctorTable();
        }

        #endregion

        private void btnConfirmAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if text field contains value
                this.CheckTextField();

                if (this.dtpAppointmentDate.Value.Date < DateTime.Today)
                    throw new Exception("Selected date must be of today or future");

                DoctorRepo doctorRepo = new DoctorRepo();
                DataTable doctorData = doctorRepo.GetIndividualDoctorsInfo(Convert.ToInt32(this.txtDoctorID.Text));
                doctorRepo.DoctorID = Convert.ToInt32(doctorData.Rows[0]["doctorid"].ToString());
                doctorRepo.Specialty = doctorData.Rows[0]["specialty"].ToString();
                doctorRepo.AvailableDays = doctorData.Rows[0]["availabledays"].ToString();
                doctorRepo.EmployeeIdOfDoctor = Convert.ToInt32(doctorData.Rows[0]["empid"].ToString());

                // Check if available day of doctor matches with appointment day
                string[] daysAvailabe = doctorRepo.AvailableDays.Split(' ');
                bool checkValidDay = false;
                string selectedDay = dtpAppointmentDate.Value.DayOfWeek.ToString().Substring(0, 3);

                foreach (string days in daysAvailabe)
                {
                    if (days.Equals(selectedDay))
                    {
                        checkValidDay = true;
                        break;
                    }
                    else
                        checkValidDay = false;
                }
                // If its a invalid day
                if (!checkValidDay)
                    throw new Exception("Doctor not available on this day. Check Available days");

                // Get the person id of the doctor
                string sql = @"select employee.personid from employee 
                        where employee.empid = '" + doctorRepo.EmployeeIdOfDoctor + "' ";

                DataTable data = DataAccess.GetDataTable(sql);
                int id = Convert.ToInt32(data.Rows[0]["personid"].ToString());
                PersonRepo p = new PersonRepo();
                DataTable ds = p.GetIndividualPerson(id);
                string a = ds.Rows[0]["personid"].ToString();

                // should not be able to confirm appointment if doctor and patient are same person
                if (a.Equals(this.txtPersonID.Text))
                {
                    throw (new Exception("Doctor and patient cannot be the same person"));
                }

                AppointmentRepo ap = new AppointmentRepo();
                string apTime = this.cmbAppointmentTime.Text.ToString();
                string apDate = this.dtpAppointmentDate.Value.ToString("MM/dd/yyyy");
                int apDoctorid = Convert.ToInt32(this.txtDoctorID.Text);

                if (ap.RowExits(apTime, apDate, apDoctorid))
                {
                    throw new Exception("Clash Appointment");
                }

                var result = MessageBox.Show("Confirm appointment?", "Confirm", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (this.txtPersonID.Text == string.Empty)
                    {
                        p.Name = this.txtName.Text;
                        p.Age = Int32.Parse(this.txtAge.Text);
                        p.Gender = this.cmbGender.Text;
                        p.BloodGroup = this.cmbBloodGroup.Text;
                        p.Phone = this.txtPhone.Text;

                        // Create a new person
                        int personCreated = p.CreatePerson(p.Name, p.Age, p.Gender, p.BloodGroup, p.Phone);

                        // Refresh the person table
                        this.PopulatePersonTable();

                        // If person created successfully get his/her id to insert into appointment table
                        if (personCreated == 1)
                        {
                            DataTable lastPersonInsertedDT = p.GetLastPerson();
                            this.PatientID = Convert.ToInt32(lastPersonInsertedDT.Rows[0]["personid"].ToString());
                            int appointmentCreated = ap.CreateAppointment(this.cmbAppointmentTime.Text.ToString(), this.dtpAppointmentDate.Value.ToString("MM/dd/yyyy"), this.PatientID, Convert.ToInt32(this.txtDoctorID.Text));
                            if (appointmentCreated == 1)
                            {
                                MessageBox.Show("Appointment Confirmed");
                                this.CLearAll();
                            }
                        }
                    }
                    else
                    {
                        // Person already exists in database, so no need to create newly 
                        this.PatientID = Convert.ToInt32(txtPersonID.Text);
                        int appointmentCreated = ap.CreateAppointment(apTime, apDate, this.PatientID, apDoctorid);
                        if (appointmentCreated == 1)
                        {
                            MessageBox.Show("Appointment Confirmed");
                            this.CLearAll();
                        }
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "ERROR");
            }

        }

        #region Search Methods

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from person where name like '%" + this.txtSearchPerson.Text + @"%'
                            or phone like '%" + this.txtSearchPerson.Text + @"%';";
            this.PopulatePersonTable(sql);
        }

        private void txtSearchDoctor_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select person.*, employee.*, doctor.*
                        from person, employee, doctor
                        where doctor.empid = employee.empid and person.personid = employee.personid
                        and (name like '%" + this.txtSearchDoctor.Text + @"%'
                        or specialty like '%" + this.txtSearchDoctor.Text + @"%');";
            this.PopulateDoctorTable(sql);
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            string sql = "select * from person where name = '%" + this.txtSearchPerson.Text + @"%' 
                        or phone like '%" + this.txtSearchPerson.Text + @"%';";
            this.PopulatePersonTable(sql);
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            string sql = @"select person.*, employee.*, doctor.*
                        from person, employee, doctor
                        where doctor.empid = employee.empid and person.personid = employee.personid
                        and ( name like '%" + this.txtSearchDoctor.Text + @"%'
                        or specialty like '%" + this.txtSearchDoctor.Text + @"%');";
            this.PopulateDoctorTable(sql);
        }
        #endregion

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.CLearAll();
        }

        private void CLearAll()
        {

            this.txtPersonID.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtAge.Text = string.Empty;
            this.txtPhone.Text = string.Empty;

            this.cmbBloodGroup.SelectedIndex = -1;
            this.cmbGender.SelectedIndex = -1;
            this.cmbAppointmentTime.SelectedIndex = -1;
            this.txtDoctorID.Text = string.Empty;
            this.txtDoctorName.Text = string.Empty;

            this.txtSearchDoctor.Text = string.Empty;
            this.txtSearchPerson.Text = string.Empty;
            this.dtpAppointmentDate.Value = DateTime.Today;
        }

        #region Validation


        private void CheckTextField()
        {

            if (String.IsNullOrWhiteSpace(this.txtName.Text))
                throw new Exception("Required Field empty");
            if (String.IsNullOrWhiteSpace(this.txtAge.Text))
                throw new Exception("Required Field empty");

            if(Convert.ToInt32(this.txtAge.Text.ToString()) < 0  || Convert.ToInt32(this.txtAge.Text.ToString()) > 130)
                throw new Exception("Please enter valid age");

            if (String.IsNullOrWhiteSpace(this.txtPhone.Text))
                throw new Exception("Required Field empty");
            if (cmbGender.SelectedItem == null)
                throw new Exception("Required Field empty");
            if (cmbBloodGroup.SelectedItem == null)
                throw new Exception("Required Field empty");

            if (cmbAppointmentTime.SelectedItem == null)
                throw new Exception("Required Field empty");
            if (String.IsNullOrWhiteSpace(this.txtDoctorID.Text))
                throw new Exception("Required Field empty");
            if (String.IsNullOrWhiteSpace(this.txtDoctorName.Text))
                throw new Exception("Required Field empty");
        }

        

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtPhone.Text, "[^0-9]"))
            {
                // IF we enter any character other than digit then shows error message
                // and removes the wrong character 
                MessageBox.Show("Please enter only numbers.");
                this.txtPhone.Text = this.txtPhone.Text.Remove(this.txtPhone.Text.Length - 1);

                this.txtPhone.SelectionStart = this.txtPhone.Text.Length;
                this.txtPhone.SelectionLength = 0;
            }
        }



        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtAge.Text, "[^0-9]"))
            {
                // IF we enter any character other than digit then shows error message
                // and removes the wrong character 
                MessageBox.Show("Please enter only numbers.");
                this.txtAge.Text = this.txtAge.Text.Remove(this.txtAge.Text.Length - 1);

                this.txtAge.SelectionStart = this.txtPhone.Text.Length;
                this.txtAge.SelectionLength = 0;
            }
        }

        #endregion

    }
}
