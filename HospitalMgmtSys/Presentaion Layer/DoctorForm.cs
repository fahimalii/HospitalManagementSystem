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
    public partial class DoctorForm : Form
    {
        private Timer timer = new Timer();

        DoctorAppointment doctorAppointment;
        MyInformation myInformation;
        PatientView patientView;


        public DoctorForm()
        {
            InitializeUserControls();
            InitializeComponent();
        }

        private void InitializeUserControls()
        {
           
            if(doctorAppointment==null || doctorAppointment.IsDisposed)
                doctorAppointment = new DoctorAppointment();
            if (patientView == null || patientView.IsDisposed)
                patientView = new PatientView();
            if (myInformation == null || myInformation.IsDisposed)
                myInformation = new MyInformation();

        }


        private void btnAppointments_Click(object sender, EventArgs e)
        {
            InitializeUserControls();
            patientView.Hide();
            myInformation.Hide();

            this.lblTitle.Text = "Appointments".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            doctorAppointment.Refresh();
            doctorAppointment.Dock = DockStyle.Fill;
            panelMain.Controls.Add(doctorAppointment);
            doctorAppointment.Show();
           

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
         
            InitializeUserControls();
            doctorAppointment.Hide();
            myInformation.Hide();

            this.lblTitle.Text = "Patients".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            patientView.Refresh();
            patientView.Dock = DockStyle.Fill;
            panelMain.Controls.Add(patientView);
            patientView.Show();
            

        }

        private void btnDoctorInfo_Click(object sender, EventArgs e)
        {
            InitializeUserControls();
            doctorAppointment.Hide();
            patientView.Hide();

            this.lblTitle.Text = "My Info".ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            myInformation.Refresh();
            this.myInformation.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(myInformation);
            this.myInformation.Show();
            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DataAccess.CloseConnection();
            this.Close();
            LoginForm.GetLoginForm().Visible = true;
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000; // in ms
            timer.Tick += new EventHandler(this.timer1_Tick);
            timer.Start();
        }
    }
}
