using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMgmtSys.Presentaion_Layer;

namespace HospitalMgmtSys
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TODO : MAKE SURE EVERY FORM IS REFRESHED ON BUTTON CLICKS, SEE RECEPTIONIST FORM CODES
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(LoginForm.GetLoginForm());
        }
    }
}
