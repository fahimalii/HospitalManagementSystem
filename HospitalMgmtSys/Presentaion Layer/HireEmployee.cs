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
    public partial class HireEmployee : UserControl
    {
        int personID;
        int empID;
        public HireEmployee()
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
            this.dgvHireEmp.AutoGenerateColumns = false;
            this.dgvHireEmp.DataSource = DataAccess.GetDataTable(query);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.CheckIfFieldEmpty();

                PersonRepo p = new PersonRepo();
                p.Name = this.txtFullName.Text;
                p.Age = Convert.ToInt32( this.txtAge.Text);
                p.Gender = this.cmbGender.Text;
                p.BloodGroup = this.cmbBloodGrp.Text;
                p.Phone = this.txtPhoneNumber.Text;


                EmployeeRepo e1 = new EmployeeRepo();

                e1.Salary = Convert.ToInt32( this.txtSalary.Text);
                e1.Designation = this.cmbDesignation.Text;

                DoctorRepo dr = new DoctorRepo();
                dr.Specialty = this.txtSpecialty.Text;
                dr.AvailableDays = this.cmbAvailableDays.Text;
       
                //person created
                p.CreatePerson(p.Name, p.Age, p.Gender, p.BloodGroup, p.Phone);
                this.PopulatePersonTable();
                //refrsh

                //get last person
                DataTable lastperson = p.GetLastPerson();

                //DataTable lastperson = p.GetLastPerson();
                this.personID = Convert.ToInt32(lastperson.Rows[0]["personid"].ToString());

                //getpersonid 
                //this.personID = Convert.ToInt32(lastperson.Rows[0]["personid"].ToString());
                //create emplyee
                e1.CreateEmployee(e1.Designation, e1.Salary, this.personID);
                if (this.cmbDesignation.Text == "Doctor")
                {
                    DataTable lastemp = e1.GetLastEmployee();
                    this.empID = Convert.ToInt32(lastemp.Rows[0]["empid"].ToString());

                    //create doctor
                    dr.CreateDoctor(dr.Specialty, dr.AvailableDays, empID);

                }

                MessageBox.Show("Successfully added!");
                this.PopulatePersonTable();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("error!"+ exc);
            }
        }

        private void ClearAll()
        {
            this.txtAge.Clear();
            this.txtEmpId.Clear();
            this.txtFullName.Clear();
            this.txtId.Clear();
            this.txtPhoneNumber.Clear();
            this.txtSalary.Clear();
            this.txtSpecialty.Clear();
            this.cmbAvailableDays.SelectedIndex = -1;
            this.cmbBloodGrp.SelectedIndex = -1;
            this.cmbDesignation.SelectedIndex = -1;
            this.cmbGender.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void HirePanel_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulatePersonTable();
        }


        #region Validation


        private void CheckIfFieldEmpty()
        {
            if (this.txtAge.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtFullName.Text == string.Empty)
                throw new Exception("Field Empty");
            if (this.txtPhoneNumber.Text == string.Empty)
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.txtPhoneNumber.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numbers.");
                this.txtPhoneNumber.Text = this.txtPhoneNumber.Text.Remove(this.txtPhoneNumber.Text.Length - 1);

                this.txtPhoneNumber.SelectionStart = this.txtPhoneNumber.Text.Length;
                this.txtPhoneNumber.SelectionLength = 0;
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
