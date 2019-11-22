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
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
            PopulateEmpTable();
        }

        private const string sql = @"select * from person, employee
                                        FULL OUTER JOIN doctor
                                        on employee.empid = doctor.empid
                                        where employee.personid = person.personid and employee.designation != 'Manager'
                                        and employee.empid not in (select login.empid from login)";
        private void PopulateEmpTable(string query = sql)
        {
            DataSet dataSet = DataAccess.GetDataSet(sql);
            this.dgvEmpInfo.AutoGenerateColumns = false;
            this.dgvEmpInfo.DataSource = dataSet.Tables[0];
        }

        private void dgvEmpInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeID.Text = this.dgvEmpInfo.CurrentRow.Cells["empId"].Value.ToString();
            this.txtDesignation.Text = this.dgvEmpInfo.CurrentRow.Cells["Designation"].Value.ToString();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CheckIfValuePresentInTextField();
            int empId = Convert.ToInt32(this.txtEmployeeID.Text);
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            string designation = this.txtDesignation.Text;

            try
            {
                LoginVerification.CreateLogin(username, password, designation, empId);
                MessageBox.Show("Account created");
                this.PopulateEmpTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void ClearAll()
        {
            this.txtUsername.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtEmployeeID.Text = string.Empty;
            this.txtDesignation.Text = string.Empty;
        }

        private void CheckIfValuePresentInTextField()
        {
            try
            {
                if (this.txtUsername.Text == string.Empty)
                    throw new Exception("Username Empty");
                if (this.txtPassword.Text == string.Empty)
                    throw new Exception("Password Empty");
                if (this.txtDesignation.Text == string.Empty)
                    throw new Exception("Select Employee from table");
                if (this.txtEmployeeID.Text == string.Empty)
                    throw new Exception("Select Employee from table");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void CreateUser_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateEmpTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
