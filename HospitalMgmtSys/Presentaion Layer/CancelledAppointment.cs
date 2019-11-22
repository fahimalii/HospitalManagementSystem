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
    public partial class CancelledAppointment : UserControl
    {
        public CancelledAppointment()
        {
            InitializeComponent();
            this.PopulateCancelledTable();
        }

        private const string sql = @"SELECT p.name as 'pname' ,cancelledappointments.appointmentid, cancelledappointments.starttime, cancelledappointments.date, cancelledappointments.personid, cancelledappointments.doctorid
                                        , doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, cancelledappointments
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = cancelledappointments.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where cancelledappointments.personid = p.personid and cancelledappointments.complete = 0";
        private void PopulateCancelledTable(string query = sql)
        {
            this.dgvCancelledAppointment.AutoGenerateColumns = false;
            this.dgvCancelledAppointment.DataSource = CancelledAppointmentsRepo.GetAllCancelledAppointmentInformation(query);
        }

        private void dgvCancelledAppointment_DoubleClick(object sender, EventArgs e)
        {
            this.txtAppointmentID.Text = this.dgvCancelledAppointment.CurrentRow.Cells["appointmentid"].Value.ToString();
            this.txtDoctorID.Text = this.dgvCancelledAppointment.CurrentRow.Cells["doctorid"].Value.ToString();
            this.txtPatientID.Text = this.dgvCancelledAppointment.CurrentRow.Cells["personid"].Value.ToString();
            this.txtPatientName.Text = this.dgvCancelledAppointment.CurrentRow.Cells["patientName"].Value.ToString();
            this.txtDoctorName.Text = this.dgvCancelledAppointment.CurrentRow.Cells["doctorName"].Value.ToString();
            this.cmbAppointmentTime.Text = this.dgvCancelledAppointment.CurrentRow.Cells["starttime"].Value.ToString();
            this.dtpAppointmentDate.Value = Convert.ToDateTime(this.dgvCancelledAppointment.CurrentRow.Cells["date"].Value.ToString());
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
                int appointmentCreated = ap.CreateAppointment(ap.Time, ap.Date, ap.PatientID, ap.DoctorID);
                if (appointmentCreated == 1)
                {
                    // Must remove it from cancelled appointment now since reassigned
                    CancelledAppointmentsRepo.RemoveCancelledAppointment(ap.AppointmentID);
                    MessageBox.Show("Appointment  reassigned");
                    // refresh the table
                    this.PopulateCancelledTable();
                    this.ClearAll();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();

        }

        private void ClearAll()
        {
            this.txtAppointmentID.Text = string.Empty;
            this.txtDoctorID.Text = string.Empty;
            this.txtPatientID.Text = string.Empty;
            this.cmbAppointmentTime.SelectedIndex = -1;
            this.dtpAppointmentDate.Value = DateTime.Today;
            this.txtPatientName.Text = string.Empty;
            this.txtDoctorName.Text = string.Empty;
            this.txtSearchPerson.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtAppointmentID.Text == string.Empty)
                    throw new Exception("Select appointment you want to delete.");
                int result = CancelledAppointmentsRepo.RemoveCancelledAppointment(Convert.ToInt32(this.txtAppointmentID.Text.ToString()));
                if (result == 1)
                {
                    MessageBox.Show("Appointment Cancelled");
                    this.ClearAll();
                    this.PopulateCancelledTable();
                }
                else
                {
                    MessageBox.Show("Appointment not found", "Message");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Erros: " + exc.Message);
            }
            
        }

        #region Search

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            string query = @" SELECT p.name as 'pname' ,cancelledappointments.appointmentid, cancelledappointments.starttime, cancelledappointments.date,
										cancelledappointments.personid, cancelledappointments.doctorid,
                                         doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, cancelledappointments
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = cancelledappointments.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where cancelledappointments.personid = p.personid and cancelledappointments.complete = 0
										and p.name like '%" + this.txtSearchPerson.Text + "%' ";

            this.PopulateCancelledTable(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = @" SELECT p.name as 'pname' ,cancelledappointments.appointmentid, cancelledappointments.starttime, cancelledappointments.date,
										cancelledappointments.personid, cancelledappointments.doctorid,
                                         doctor.specialty, doctor.availabledays , person.name as 'dname'
                                        FROM person as p, cancelledappointments
                                            RIGHT JOIN doctor
                                                ON doctor.doctorid = cancelledappointments.doctorid
                                            RIGHT OUTER JOIN employee
                                                ON employee.empid = doctor.empid
                                            RIGHT OUTER JOIN person
                                                ON person.personid = employee.personid
                                        where cancelledappointments.personid = p.personid and cancelledappointments.complete = 0
										and p.name = '%" + this.txtSearchPerson.Text + "%' ";

            this.PopulateCancelledTable(query);
        }

        #endregion

        private void CancelledAppointment_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateCancelledTable();
        }
    }
}
