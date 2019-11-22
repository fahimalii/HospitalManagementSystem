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
    public partial class DoctorAppointment : UserControl
    {
        private int Doctorid
        {
            set; get;
        }

        public DoctorAppointment()
        {
            InitializeComponent();
            PopulateCLBMedicine();
            PopulateClbDisease();
            GetDoctorID();
            PopulateGridView();
           
        }
        private void GetDoctorID()
        {
            if (UserLoginInfo.Designation.Equals("Doctor"))
            {
                this.Doctorid = DoctorRepo.GetDoctorID(Convert.ToInt32(UserLoginInfo.EmployeeID.ToString()));
            }
        }
        private void PopulateCLBMedicine()
        {
            DataTable medicineTable = MedicineRepo.GetAllMedicine();
            for (int ax = 1; ax < medicineTable.Rows.Count; ax++)
            {
                clbMedicine.Items.Add(medicineTable.Rows[ax]["medicinename"].ToString());
            }

        }

        private void PopulateClbDisease()
        {
            DataTable diseaseTable = DiseaseRepo.GetAllDisease();
            for (int ax = 1; ax < diseaseTable.Rows.Count; ax++)
            {
                clbDisease.Items.Add(diseaseTable.Rows[ax]["diseasename"].ToString());
            }
        }

        private void ClearInfo()
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtPersonID.Text = "";
            txtPhone.Text = "";
            txtSearchPerson.Text = "";
            dtpAppointmentDate.Value = DateTime.Today;
            cmbAppointmentTime.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            clbDisease.Items.Clear();
            PopulateClbDisease();
            clbMedicine.Items.Clear();
            PopulateCLBMedicine();
            PopulateGridView();
        }

        
        private void PopulateGridView()
        {
            dgvAppointmentView.DataSource = PersonAppointmentRepo.GetAllDoctorAppointmentInfo(Doctorid);

        }

        private List<string> GetCheckedDiseases()
        {
            var diseaseList = new List<string>();
            foreach (string ax in clbDisease.CheckedItems)
            {
                diseaseList.Add(ax);
            }
            return diseaseList;
        }
        private List<string> GetCheckedMedicine()
        {
            var medicineList = new List<string>();
            foreach (string ax in clbMedicine.CheckedItems)
            {
                medicineList.Add(ax);
            }
            return medicineList;
        }



        private void txtSearchPerson_TextChanged_1(object sender, EventArgs e)
        {
            dgvAppointmentView.DataSource = PersonAppointmentRepo.GetDoctorAppointmentSearch(Doctorid, txtSearchPerson.Text);

        }

        private void btnClearAll_Click_1(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
           
            if (txtPersonID.Text != "")
               {
                var answer = MessageBox.Show("Cancel Appointment", "Cancel", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                 {
                    AppointmentRepo appointmentRepo = new AppointmentRepo();
                    DataGridViewRow dataRow = dgvAppointmentView.CurrentRow;
                    DateTime.Parse(dtpAppointmentDate.Text);
                    CancelledAppointmentsRepo.CreateCancelledAppointment(cmbAppointmentTime.Text.ToString(), DateTime.Parse(dtpAppointmentDate.Text).ToString("d"), Convert.ToInt32(txtPersonID.Text), Doctorid);
                    AppointmentRepo.DeleteByPatient(Convert.ToInt32(txtPersonID.Text), Doctorid);
                    MessageBox.Show("Appointment cancelled successfully");
                    PopulateGridView();
                    ClearInfo();
                 }
             }
             else
                MessageBox.Show("NO appointment is selected");
            

        }

        private void btnCancelAllToday_Click(object sender, EventArgs e)
        {
           
                DataTable appointmentTable = AppointmentRepo.GetSpecificDoctorAppointments(Doctorid);
                if (appointmentTable.Rows.Count > 0)
                {
                    var answer = MessageBox.Show("Cancel All Today's Appointment", "Cancel", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {

                    for (int ax = 0; ax < appointmentTable.Rows.Count; ax++)
                    {
                        AppointmentRepo.DeleteAllToday(Doctorid);
                        CancelledAppointmentsRepo.CreateCancelledAppointment(appointmentTable.Rows[ax]["starttime"].ToString(), appointmentTable.Rows[ax]["date"].ToString(), Convert.ToInt32(appointmentTable.Rows[ax]["personid"].ToString()), Doctorid);

                    }
                    MessageBox.Show("All appointments cancelled successfully");

                    PopulateGridView();
                    ClearInfo();
                }
                }
                else
                    MessageBox.Show("NO appointments to cancel today");
            
        }

        private void btnConfirmAppointment_Click_1(object sender, EventArgs e)
        {
            dynamic diseaseList = GetCheckedDiseases();
            dynamic medicineList = GetCheckedMedicine();
            if (txtPersonID.Text != "")
            {
                var answer = MessageBox.Show("Confirm Medicines", "Confirm", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    PatientDiseaseRepo.InsertPresonDisease(diseaseList, medicineList, Convert.ToInt32(txtPersonID.Text), Doctorid);
                    ClearInfo();
                    PopulateGridView();
                }
            }
            else
            {
                MessageBox.Show("No Patient is Selected");
            }
            
        }

        private void dgvAppointmentView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dataRow = dgvAppointmentView.CurrentRow;
                txtPersonID.Text = dataRow.Cells[1].Value.ToString();
                txtAge.Text = dataRow.Cells[3].Value.ToString();
                txtName.Text = dataRow.Cells[2].Value.ToString();
                txtPhone.Text = dataRow.Cells[6].Value.ToString();
                dtpAppointmentDate.Text = dataRow.Cells[7].Value.ToString();
                cmbAppointmentTime.Text = dataRow.Cells[8].Value.ToString();
                cmbBloodGroup.Text = dataRow.Cells[4].Value.ToString();
                cmbGender.Text = dataRow.Cells[5].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DoctorAppointment_VisibleChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.ClearInfo();
        }
    }
}
