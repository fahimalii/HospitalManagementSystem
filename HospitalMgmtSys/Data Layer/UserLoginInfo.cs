using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSys.Data_Layer
{
    /// <summary>
    /// A Class with some auto implemented property to keep some info required
    /// of the current user
    /// </summary>
    public class UserLoginInfo
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Designation { get; set; }
        public static int EmployeeID { get; set; }
        public static int PersonID { get; set; }
    }
}
