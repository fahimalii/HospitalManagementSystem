using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMgmtSys.Data_Layer;

using HospitalMgmtSys.Repository_Layer;


namespace HospitalMgmtSys.Presentaion_Layer
{
    public partial class FireEmployee : UserControl
    {
        public FireEmployee()
        {
            InitializeComponent();
            this.PopulatePersonTable();
        }

      
        private const string sql = @"select person.personid, person.name, person.age, person.gender, person.bloodgroup, person.phone, 
                                        employee.empid, employee.designation, employee.salary, doctor.doctorid, doctor.availabledays, doctor.specialty
                                        from person, employee
                                        FULL OUTER JOIN doctor
                                        on employee.empid = doctor.empid
                                        where employee.personid = person.personid and employee.designation != 'Manager'";

        private void PopulatePersonTable(string query = sql)
        {
            DataSet data = DataAccess.GetDataSet(query);
            this.dgvFireEmp.AutoGenerateColumns = false;
            this.dgvFireEmp.DataSource = data.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            PersonRepo p1 = new PersonRepo();
            p1.PersonID = Convert.ToInt32(this.txtPID.Text);

            DoctorRepo dr = new DoctorRepo();

            if (this.txtDoctorId.Text != "" && this.txtDoctorId.Text != null)
            {
                dr.DoctorID = Convert.ToInt32(this.txtDoctorId.Text);
            }
            
            EmployeeRepo er = new EmployeeRepo();
            er.EmpID = Convert.ToInt32(this.txtEmpId.Text);

            try
            {
                if (this.cmbDesignation.Text == "Doctor")
                {
                    // IF DOCTOR -> Delete from all table that contains doctor's reference first
                    CancelledAppointmentsRepo.RemoveParticularDoctorsAppointments(dr.DoctorID);
                    AppointmentRepo.RemoveParticularDoctorsAppointments(dr.DoctorID);
                    PatientDiseaseRepo.DeleteInfoBasedOnDoctor(dr.DoctorID);
                    LoginVerification.DeleteLoginInfo(er.EmpID);
                    // Afterwards delete from doctor table
                    dr.DeleteDoctor(dr.DoctorID);
                }

                int empdelete = er.DeleteEmployee(er.EmpID);
                int persondeleted = p1.DeletePerson(p1.PersonID);

                this.PopulatePersonTable();
                MessageBox.Show("Successfully deleted!");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("error!" + exc);
            }

        }

        private void FireEmployee_Load(object sender, EventArgs e)
        {
            PopulatePersonTable(sql);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {           
            try
            {
                CheckIfFieldEmpty();

                PersonRepo p1 = new PersonRepo();
                p1.PersonID = Convert.ToInt32(this.txtPID.Text);

                p1.Name = this.txtName.Text;
                p1.Age = Convert.ToInt32(this.txtAge.Text);
                p1.Phone = this.txtNumber.Text;
                p1.Gender = this.cmbGender.Text;
                p1.BloodGroup = this.cmbBloodGrp.Text;

                DoctorRepo dr = new DoctorRepo();
                dr.DoctorID = Convert.ToInt32(this.txtDoctorId.Text);
                dr.Specialty = this.txtSpecialty.Text;
                dr.AvailableDays = this.cmbAvailableDays.Text;


                EmployeeRepo er = new EmployeeRepo();
                er.EmpID = Convert.ToInt32(this.txtEmpId.Text);
                er.Salary = Convert.ToInt32(this.txtSalary.Text);
                er.Designation = this.cmbDesignation.Text;

                int personupdate = p1.UpdatePerson(p1.PersonID, p1.Name,  p1.Age ,p1.Gender, p1.BloodGroup,p1.Phone);
                int empupdate = er.UpdateEmployee(er.EmpID, er.Designation, er.Salary);
                int doctorupdate = dr.UpdateDoctor(dr.DoctorID,dr.Specialty,dr.AvailableDays);
                PopulatePersonTable();
                MessageBox.Show("Successfully updated!");
                this.ClearAll();
            }

            catch (Exception exc)
            {
                MessageBox.Show("error" + exc);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = @"select person.personid, person.name, person.age, person.gender, person.bloodgroup, person.phone, 
                            employee.empid, employee.designation, employee.salary, doctor.doctorid, doctor.availabledays, doctor.specialty
                            from person, employee
                            FULL OUTER JOIN doctor
                            on employee.empid = doctor.empid
                            where employee.personid = person.personid and employee.designation != 'Manager'
                            and name like '"+this.txtSearch.Text+"%'";
                                    
            PopulatePersonTable(query);
        }

        private void dgvFireEmp_DoubleClick(object sender, EventArgs e)
        {
            this.txtName.Text = this.dgvFireEmp.CurrentRow.Cells["name"].Value.ToString();
            this.cmbDesignation.Text = this.dgvFireEmp.CurrentRow.Cells["designation"].Value.ToString();
            this.txtSalary.Text = this.dgvFireEmp.CurrentRow.Cells["salary"].Value.ToString();
            this.txtPID.Text = this.dgvFireEmp.CurrentRow.Cells["personid"].Value.ToString();
            this.txtEmpId.Text = this.dgvFireEmp.CurrentRow.Cells["empid"].Value.ToString();
            this.txtDoctorId.Text = this.dgvFireEmp.CurrentRow.Cells["doctorid"].Value.ToString();
            this.txtNumber.Text = this.dgvFireEmp.CurrentRow.Cells["phone"].Value.ToString();
            this.txtSpecialty.Text = this.dgvFireEmp.CurrentRow.Cells["specialty"].Value.ToString();
            this.txtAge.Text = this.dgvFireEmp.CurrentRow.Cells["age"].Value.ToString();
            this.cmbGender.Text = this.dgvFireEmp.CurrentRow.Cells["gender"].Value.ToString();
            this.cmbBloodGrp.Text = this.dgvFireEmp.CurrentRow.Cells["bloodgroup"].Value.ToString();
            this.cmbAvailableDays.Text = this.dgvFireEmp.CurrentRow.Cells["availabledays"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }


        // Clears all fields
        private void ClearAll()
        {
            this.txtPID.Clear();
            this.txtDoctorId.Clear();
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtEmpId.Clear();
            this.txtNumber.Clear();
            this.txtSalary.Clear();
            this.txtSpecialty.Clear();
            this.txtSearch.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbBloodGrp.SelectedIndex = -1;
            this.cmbAvailableDays.SelectedIndex = -1;
            this.cmbDesignation.SelectedIndex = -1;
        }

        private void FirePanel_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulatePersonTable();
        }

        #region Validation

        private void CheckIfFieldEmpty()
        {
            if (this.txtAge.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtName.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtNumber.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtSalary.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtSpecialty.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.cmbAvailableDays.SelectedItem == null)
                throw new Exception("Field empty");
            if (this.cmbBloodGrp.SelectedItem == null)
                throw new Exception("Field Empty");
            if (this.cmbDesignation.SelectedItem == null)
                throw new Exception("Field Empty");
            if (this.cmbGender.SelectedItem == null)
                throw new Exception("Field Empty");

            if (Convert.ToInt32(this.txtAge.Text.ToString()) < 0 || Convert.ToInt32(this.txtAge.Text.ToString()) > 130)
                throw new Exception("Please enter valid age");
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.txtNumber.Text = this.txtNumber.Text.Remove(this.txtNumber.Text.Length - 1);

                // Set cursor at the end of the current text in the textbox
                this.txtNumber.SelectionStart = this.txtNumber.Text.Length;
                this.txtNumber.SelectionLength = 0;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtAge.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.txtAge.Text = this.txtAge.Text.Remove(this.txtAge.Text.Length - 1);

                // Set cursor at the end of the current text in the textbox
                this.txtAge.SelectionStart = this.txtAge.Text.Length;
                this.txtAge.SelectionLength = 0;
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtSalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                this.txtSalary.Text = this.txtSalary.Text.Remove(this.txtSalary.Text.Length - 1);

                // Set cursor at the end of the current text in the textbox
                this.txtSalary.SelectionStart = this.txtSalary.Text.Length;
                this.txtSalary.SelectionLength = 0;
            }
        }

        #endregion
    }
}
