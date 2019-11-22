using System;
using HospitalMgmtSys.Data_Layer;
using System.Data;
using System.Windows.Forms;

namespace HospitalMgmtSys.Repository_Layer
{
    class LoginVerification
    {
        /// <summary>
        /// Verfiy Login based on username and password
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>true if credential matches, otherwise false</returns>
        public static bool VerifyLogin(string username, string password)
        {
            try
            {
                string sql = @"select * from login where username = '" + username + "' and password = '" + password + "'";
                DataSet ds = DataAccess.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Verification Successful");
                    UserLoginInfo.Username = ds.Tables[0].Rows[0]["username"].ToString();
                    UserLoginInfo.Password = ds.Tables[0].Rows[0]["password"].ToString();
                    UserLoginInfo.Designation = ds.Tables[0].Rows[0]["designation"].ToString();
                    UserLoginInfo.EmployeeID = Convert.ToInt32(ds.Tables[0].Rows[0]["empid"].ToString());
                    DataSet dt = DataAccess.GetDataSet("select * from person, employee where " +
                        "employee.empid = '" + UserLoginInfo.EmployeeID + "' and employee.personid = person.personid");
                    UserLoginInfo.PersonID = Convert.ToInt32(dt.Tables[0].Rows[0]["personid"].ToString());
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                    return false;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return false;
            }
            
        }

        /// <summary>
        /// Update Password of the suer
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="oldPassword">Old Password</param>
        /// <param name="newPassword">New Password</param>
        /// <returns></returns>
        public static bool UpdatePassword(string username, string oldPassword, string newPassword)
        {
            string sql = @"update login
                            set password = '" + newPassword + @"'
                            where username = '" + username + "' and password = '"+ oldPassword +"';";
            int result = DataAccess.ExecuteQuery(sql);
            if (result == 1)
            {
                return true;
            }
            else
                return false;
        }

        public static int CreateLogin(string username, string password, string designation, int empId)
        {
            string sql = @"insert into login values('" + username + "', '" + password + "', '" + designation + "', '" + empId + "') ";
            return DataAccess.ExecuteQuery(sql);
        }

        public static int DeleteLoginInfo(int empID)
        {
            string sql = string.Format(@"DELETE FROM login WHERE empid = '" + empID + "'; ");
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Checks if an employee already has login credentials
        /// </summary>
        /// <param name="empID">employee id</param>
        /// <returns></returns>
        public static bool CheckIfLoginCredAvailableForEmp(int empID)
        {
            string sql = @"select * from login where empid = '" + empID + "' ";
            return DataAccess.RowExists(sql);
        }
    }

    
}
