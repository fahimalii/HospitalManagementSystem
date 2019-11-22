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
    public partial class MyInformation : UserControl
    {
        public MyInformation()
        {
            InitializeComponent();
          //  SetData();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var name = this.txtUsername.Text;
            var oldPass = this.txtOldPassword.Text;
            var newPass = this.txtNewPassword.Text;
            var newPassCheck = this.txtConfirmNewPassword.Text;
            if (newPass.Equals(newPassCheck))
            {
                bool check = LoginVerification.UpdatePassword(name,oldPass,newPass);
                if (check)
                {
                    MessageBox.Show("Password Updated");
                    UserLoginInfo.Password = newPass;
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("New Password doesn't match");
            }
        }

        private void MyInformation_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = UserLoginInfo.Username;
            SetData();
        }

        
        private void SetData()
        {            
            try
            {
                DataTable dp = DataAccess.GetDataTable("select * from person where personid = '"+ UserLoginInfo.PersonID +"' ");
                DataTable de = DataAccess.GetDataTable("select * from employee where empid = '" + UserLoginInfo.EmployeeID + "'");
                DataTable dd = DataAccess.GetDataTable("select * from doctor where doctor.empid = '" + UserLoginInfo.EmployeeID + "' ");

                if(dp != null)
                {
                    this.txtPersonID.Text = UserLoginInfo.PersonID.ToString();
                    this.txtName.Text = dp.Rows[0]["name"].ToString();
                    this.txtAge.Text = dp.Rows[0]["age"].ToString();
                    this.cmbGender.Text = dp.Rows[0]["gender"].ToString();
                    this.cmbBloodGroup.Text = dp.Rows[0]["bloodgroup"].ToString();
                    this.txtPhone.Text = dp.Rows[0]["phone"].ToString();

                }

                if(de != null)
                {
                    this.txtEmpID.Text = UserLoginInfo.EmployeeID.ToString();
                    this.txtDesignation.Text = de.Rows[0]["designation"].ToString();
                    this.txtSalary.Text = de.Rows[0]["salary"].ToString();
                }

                if (UserLoginInfo.Designation.Equals("Doctor"))
                {
                    groupBoxDoctorInfo.Show();
                    if (dd != null)
                    {
                        this.txtDoctorID.Text = dd.Rows[0]["doctorid"].ToString();
                        this.txtSpecialty.Text = dd.Rows[0]["specialty"].ToString();
                        this.cmbAvailableDays.Text = dd.Rows[0]["availabledays"].ToString();
                    }
                }
                else
                {
                    groupBoxDoctorInfo.Hide();
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdateBasicInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.CheckIfEmpty();
                PersonRepo person = new PersonRepo();
                person.PersonID = Convert.ToInt32(this.txtPersonID.Text.ToString());
                person.Name = this.txtName.Text;
                person.Age = Convert.ToInt32(this.txtAge.Text.ToString());
                person.Gender = this.cmbGender.Text.ToString();
                person.BloodGroup = this.cmbBloodGroup.Text.ToString();
                person.Phone = this.txtPhone.Text;

                int check = person.UpdatePerson(person.PersonID, person.Name, person.Age, person.Gender, person.BloodGroup, person.Phone);
                if(check == 1)
                {
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnUpdateDays_Click(object sender, EventArgs e)
        {
            DoctorRepo dr = new DoctorRepo();
            dr.DoctorID = Convert.ToInt32(this.txtDoctorID.Text);
            dr.Specialty = this.txtSpecialty.Text;
            dr.AvailableDays = this.cmbAvailableDays.Text.ToString();
            int check = dr.UpdateDoctor(dr.DoctorID, dr.Specialty, dr.AvailableDays);
            if(check == 1)
            {
                MessageBox.Show("Data Updated");
            }
        }

        #region Validation

        private void CheckIfEmpty()
        {
            if (String.IsNullOrWhiteSpace(this.txtName.Text))
                throw new Exception("Required Field empty");
            if (String.IsNullOrWhiteSpace(this.txtAge.Text))
                throw new Exception("Required Field empty");

            if (Convert.ToInt32(this.txtAge.Text.ToString()) < 0 || Convert.ToInt32(this.txtAge.Text.ToString()) > 130)
                throw new Exception("Please enter valid age");

            if (String.IsNullOrWhiteSpace(this.txtPhone.Text))
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
                MessageBox.Show("Please enter only numbers.");
                this.txtAge.Text = this.txtAge.Text.Remove(this.txtAge.Text.Length - 1);

                this.txtAge.SelectionStart = this.txtPhone.Text.Length;
                this.txtAge.SelectionLength = 0;
            }
        }

        #endregion
    }
}
