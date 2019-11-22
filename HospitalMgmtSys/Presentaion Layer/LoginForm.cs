using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using HospitalMgmtSys.Data_Layer;
using HospitalMgmtSys.Repository_Layer;

namespace HospitalMgmtSys.Presentaion_Layer
{
    public partial class LoginForm : Form
    {
        private static LoginForm loginForm = null;
        private SqlConnection sqlConnection;

        private Timer timer = new Timer();

        private LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to create only one instance of this class
        /// Singleton Pattern
        /// </summary>
        /// <returns></returns>
        public static LoginForm GetLoginForm()
        {
            if(loginForm == null)
            {
                loginForm = new LoginForm();
            }
            return loginForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.sqlConnection = DataAccess.Sqlcon;
            bool credentialsMatched = LoginVerification.VerifyLogin(this.txtUsername.Text, this.txtPassword.Text);
            if (credentialsMatched)
            {
                switch (UserLoginInfo.Designation)
                {
                    case "Manager":
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new ManagerForm().Visible = true;
                            break;
                        }
                        
                    case "Doctor":
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new DoctorForm().Visible = true;
                            break;
                        }
                        
                    case "Receptionist":
                        {
                            this.txtUsername.Text = string.Empty;
                            this.txtPassword.Text = string.Empty;
                            this.Visible = false;
                            new ReceptionistForm().Visible = true;
                            break;
                        }        
                    default:
                        break;
                }
                
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
            this.SetUpButton();
            timer.Interval = 1000; // in ms
            timer.Tick += new EventHandler(this.timer1_Tick);
            timer.Start();
        }

        // Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            lblClock.Text = clock;
            lblDate.Text = date;
        }

        private void SetUpButton()
        {
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }
    }
}
