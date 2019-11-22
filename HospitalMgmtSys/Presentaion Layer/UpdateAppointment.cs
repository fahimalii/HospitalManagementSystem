using HospitalMgmtSys.Repository_Layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace HospitalMgmtSys.Presentaion_Layer
{
    public partial class UpdateAppointment : UserControl
    {
        public UpdateAppointment()
        {
            InitializeComponent();
            this.PopulateAppointmentTable();           
        }

        private const string sql = @"SELECT p.name as 'pname' ,appointment.appointmentid, appointment.starttime, appointment.date, appointment.personid, appointment.doctorid
                                        , doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, appointment
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = appointment.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where appointment.personid = p.personid and appointment.complete = 0";
        private void PopulateAppointmentTable(string query = sql)
        {
            AppointmentRepo appointment = new AppointmentRepo(); 
            this.dgvAppointment.AutoGenerateColumns = false;
            this.dgvAppointment.DataSource = appointment.GetAllAppointmentInformation(query);
        }

        private void dgvAppointment_DoubleClick(object sender, EventArgs e)
        {
            this.txtAppointmentID.Text = this.dgvAppointment.CurrentRow.Cells["appointmentid"].Value.ToString();
            this.txtDoctorID.Text = this.dgvAppointment.CurrentRow.Cells["doctorid"].Value.ToString();
            this.txtPatientID.Text = this.dgvAppointment.CurrentRow.Cells["personid"].Value.ToString();
            this.txtPatientName.Text = this.dgvAppointment.CurrentRow.Cells["patientName"].Value.ToString();
            this.txtDoctorName.Text = this.dgvAppointment.CurrentRow.Cells["doctorName"].Value.ToString();
            this.cmbAppointmentTime.Text = this.dgvAppointment.CurrentRow.Cells["starttime"].Value.ToString();
            this.dtpAppointmentDate.Value = Convert.ToDateTime(this.dgvAppointment.CurrentRow.Cells["date"].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtAppointmentID.Text))
                    throw new Exception("Select Appointment you want to cancel");
                var ask = MessageBox.Show("Do you want to cancel this appointment?", "Querstion", MessageBoxButtons.YesNo);
                if(ask == DialogResult.Yes)
                {
                    AppointmentRepo ap = new AppointmentRepo();
                    int result = ap.DeleteAppointment(Convert.ToInt32(this.txtAppointmentID.Text));
                    if (result == 1)
                    {
                        MessageBox.Show("Appointment deleted successfully");
                        this.PopulateAppointmentTable();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Appointment not found");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
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
                //string selectedDay = dtpAppointmentDate.Value.DayOfWeek.ToString().Substring(0, 3).ToLower();
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

                AppointmentRepo ap = new AppointmentRepo();
                ap.AppointmentID = Convert.ToInt32(this.txtAppointmentID.Text);
                ap.Time = this.cmbAppointmentTime.Text.ToString();
                ap.Date = this.dtpAppointmentDate.Value.ToString("MM/dd/yyyy");
                ap.DoctorID = Convert.ToInt32(this.txtDoctorID.Text);
                ap.PatientID = Convert.ToInt32(this.txtPatientID.Text);
                // Check if clash appointment
                if (ap.RowExits(ap.Time, ap.Date, ap.DoctorID))
                {
                    throw new Exception("Clash Appointment");
                }
                // If no clash appointment then proceed
                var ask = MessageBox.Show("Confirm appointment update?", "Question", MessageBoxButtons.YesNo);
                if(ask == DialogResult.Yes)
                {
                    int appointmentUpdated = ap.UpdateAppointment(ap.AppointmentID, ap.Time, ap.Date, ap.PatientID, ap.DoctorID);
                    if (appointmentUpdated == 1)
                    {
                        MessageBox.Show("Appointment Updated");
                        this.PopulateAppointmentTable();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ClearAll()
        {
            this.txtAppointmentID.Text = string.Empty;
            this.txtDoctorID.Text = string.Empty;
            this.txtPatientID.Text = string.Empty;
            this.cmbAppointmentTime.SelectedIndex = -1;
            this.txtPatientName.Text = string.Empty;
            this.txtDoctorName.Text = string.Empty;
            this.dtpAppointmentDate.Value = DateTime.Today;
        }


        private void CancelAppointment_Load(object sender, EventArgs e)
        {
            this.PopulateAppointmentTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void UpdateAppointment_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateAppointmentTable();
        }

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"SELECT p.name as 'pname' ,appointment.appointmentid, appointment.starttime, appointment.date, appointment.personid, appointment.doctorid
                                        , doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, appointment
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = appointment.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where appointment.personid = p.personid and appointment.complete = 0 and
                                        p.name like '%" + this.txtSearch.Text + @"%'";
            this.PopulateAppointmentTable(sql);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT p.name as 'pname' ,appointment.appointmentid, appointment.starttime, appointment.date, appointment.personid, appointment.doctorid
                                        , doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, appointment
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = appointment.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where appointment.personid = p.personid and appointment.complete = 0 and
                                        p.name = '" + this.txtSearch.Text + "' ";
            this.PopulateAppointmentTable(sql);
        }

        #endregion
    }
}
