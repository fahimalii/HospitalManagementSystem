using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMgmtSys.Data_Layer;


namespace HospitalMgmtSys.Presentaion_Layer
{
    public partial class ManagerForm : Form
    {
        private Timer timer = new Timer();

        HireEmployee hireEmployee;
        FireEmployee fireEmployee;
        CreateUser createUser;
        MyInformation myInformation;


        public ManagerForm()
        {
            this.InitializeUserControls();
            InitializeComponent();
        }

        private void InitializeUserControls()
        {
            if (hireEmployee == null || hireEmployee.IsDisposed)
                hireEmployee = new HireEmployee();
            if (fireEmployee == null || fireEmployee.IsDisposed)
                fireEmployee = new FireEmployee();
            if (createUser == null || createUser.IsDisposed)
                createUser = new CreateUser();
            if (myInformation == null || myInformation.IsDisposed)
                myInformation = new MyInformation();
        }

        private void btnHireEmployee_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.fireEmployee.Hide();
            this.createUser.Hide();
            this.myInformation.Hide();

            this.lblTitle.Text = "Hire Employee".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            hireEmployee.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hireEmployee);
            hireEmployee.Show();
            

        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.hireEmployee.Hide();
            this.createUser.Hide();
            this.myInformation.Hide();

            this.lblTitle.Text = "Fire Employee".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            fireEmployee.Dock = DockStyle.Fill;
            panelMain.Controls.Add(fireEmployee);
            fireEmployee.Show();
           
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.fireEmployee.Hide();
            this.hireEmployee.Hide();
            this.myInformation.Hide();

            this.lblTitle.Text = "Create User".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            createUser.Dock = DockStyle.Fill;
            panelMain.Controls.Add(createUser);
            createUser.Show();
           
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.fireEmployee.Hide();
            this.hireEmployee.Hide();
            this.createUser.Hide();

            this.lblTitle.Text = this.btnMyInfo.Text.ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);


            this.myInformation.Refresh();
            this.myInformation.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(myInformation);
            this.myInformation.Show();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            DataAccess.CloseConnection();
            this.Close();
            LoginForm.GetLoginForm().Visible = true;
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccess.CloseConnection();
            LoginForm.GetLoginForm().Visible = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            lblClock.Text = clock;
            lblDate.Text = date;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000; // in ms
            timer.Tick += new EventHandler(this.timer1_Tick);
            timer.Start();
        }
    }
}
