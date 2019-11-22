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
    public partial class PatientView : UserControl
    {
        private int Doctorid
        {
            set; get;
        }
        public PatientView()
        {
            InitializeComponent();
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

        #region Populate CheckListBox

        private void PopulateCLBMedicine()
        {
            DataTable medicineTable = MedicineRepo.GetAllMedicine();
            for (int ax = 1; ax < medicineTable.Rows.Count; ax++)
            {
                clbMedicine.Items.Add(medicineTable.Rows[ax]["medicinename"].ToString());
            }

            DataTable allMedicineTable = PatientDiseaseRepo.GetIndividualMedicine(Convert.ToInt32( txtPersonID.Text));
            for(int ax=0; ax<allMedicineTable.Rows.Count; ax++ )
            {
                if(clbMedicine.Items.Contains(allMedicineTable.Rows[ax]["medicinename"].ToString()))
                {
                    clbMedicine.SetItemChecked( clbMedicine.Items.IndexOf(allMedicineTable.Rows[ax]["medicinename"].ToString()), true);
                }
            }

        }
        private void PopulateClbDisease()
        {
            DataTable diseaseTable = DiseaseRepo.GetAllDisease();
            for (int ax = 1; ax < diseaseTable.Rows.Count; ax++)
            {
                clbDisease.Items.Add(diseaseTable.Rows[ax]["diseasename"].ToString());
            }
            DataTable allDiseaseTable = PatientDiseaseRepo.GetIndividualDisease(Convert.ToInt32(txtPersonID.Text));
            for (int ax = 0; ax < allDiseaseTable.Rows.Count; ax++)
            {
                if (clbDisease.Items.Contains(allDiseaseTable.Rows[ax]["diseasename"].ToString()))
                {
                    clbDisease.SetItemChecked(clbDisease.Items.IndexOf(allDiseaseTable.Rows[ax]["diseasename"].ToString()), true);
                }
            }
        }

        #endregion

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
            cmbGender.SelectedIndex = -1; ;
            
            
            clbDisease.Items.Clear();
            clbMedicine.Items.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }
        private void PopulateGridView()
        {
            dgvAppointmentView.DataSource = PersonAppointmentRepo.GetAllDoctorCompleteAppointmentInfo(Doctorid);

        }

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            dgvAppointmentView.DataSource = PersonAppointmentRepo.GetDoctorCompleteAppointmentSearch(Doctorid, txtSearchPerson.Text);
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

        

        private void dgvAppointmentView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                clbMedicine.Items.Clear();
                clbDisease.Items.Clear();
                PopulateClbDisease();
                PopulateCLBMedicine();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnConfirmAppointment_Click(object sender, EventArgs e)
        {
            dynamic diseaseList = GetCheckedDiseases();
            dynamic medicineList = GetCheckedMedicine();
            if (txtPersonID.Text != "")
            {
                if (txtPersonID.Text != "")
                {
                    var answer = MessageBox.Show("Confirm Update?", "Confirm", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        PatientDiseaseRepo.DeletePatientDisease(Convert.ToInt32(txtPersonID.Text));
                        PatientDiseaseRepo.InsertPresonDisease(diseaseList, medicineList, Convert.ToInt32(txtPersonID.Text), Doctorid);
                        ClearInfo();
                        PopulateGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("No Patient is Selected");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtPersonID.Text!="")
            {
                var answer = MessageBox.Show("Delete Appointment", "Delete", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    AppointmentRepo.DeleteCompletedAppointment(Convert.ToInt32(txtPersonID.Text));
                    MessageBox.Show("Deleted Successfully");
                    ClearInfo();
                    PopulateGridView();
                }
            }
            else
                MessageBox.Show("No Patient is Selected");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        { 
            var answer = MessageBox.Show("Delete All entry", "Delete All", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                AppointmentRepo.RemoveParticularDoctorsAppointments(Doctorid);
                MessageBox.Show("All entries deleted Successfully ");
                PopulateGridView();
                ClearInfo();
            }
        }

        private void PatientView_VisibleChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.ClearInfo();
        }
    }
}
