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
    public partial class ReceptionistForm : Form
    {

        private Timer timer = new Timer();

        UpdateAppointment updateAppointment;
        AddAppointment addAppointment;
        MyInformation myInformation;
        CancelledAppointment cancelledAppointment;

        public ReceptionistForm()
        {
            this.InitializeUserControls();
            InitializeComponent();
        }

        private void InitializeUserControls()
        {
            if (this.addAppointment == null || this.addAppointment.IsDisposed)
                this.addAppointment = new AddAppointment();
            if (this.updateAppointment == null || this.updateAppointment.IsDisposed)
                this.updateAppointment = new UpdateAppointment();
            if(this.myInformation == null || this.myInformation.IsDisposed)
                this.myInformation = new MyInformation();
            if (this.cancelledAppointment == null || this.cancelledAppointment.IsDisposed)
                this.cancelledAppointment = new CancelledAppointment();

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.updateAppointment.Hide();
            this.myInformation.Hide();
            this.cancelledAppointment.Hide();

            this.lblTitle.Text = this.btnAddAppointment.Text.ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);

            this.addAppointment.Refresh();
            this.addAppointment.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(this.addAppointment);
            this.addAppointment.Show();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.addAppointment.Hide();
            this.myInformation.Hide();
            this.cancelledAppointment.Hide();

            this.lblTitle.Text = this.btnUpdateAppointment.Text.ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);


            this.updateAppointment.Refresh();
            this.updateAppointment.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(updateAppointment);
            this.updateAppointment.Refresh();
            this.updateAppointment.Show();
            
        }


        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.addAppointment.Hide();
            this.updateAppointment.Hide();
            this.cancelledAppointment.Hide();


            this.lblTitle.Text = this.btnMyInfo.Text.ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);


            this.myInformation.Refresh();
            this.myInformation.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(myInformation);
            this.myInformation.Show();
        }

        private void btnCancelledAppointment_Click(object sender, EventArgs e)
        {
            this.InitializeUserControls();
            this.addAppointment.Hide();
            this.updateAppointment.Hide();
            this.myInformation.Hide();

            this.lblTitle.Text = this.btnCancelledAppointment.Text.ToUpper();
            this.lblTitle.Font = new Font("Monotype Corsiva", lblTitle.Font.Size);


            this.cancelledAppointment.Refresh();
            this.cancelledAppointment.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(cancelledAppointment);
            this.cancelledAppointment.Show();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DataAccess.CloseConnection(); // close the connection
            this.Close();
            LoginForm.GetLoginForm().Visible = true;
        }

        private void ReceptionistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccess.CloseConnection();
            LoginForm.GetLoginForm().Visible = true;
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000; // in ms
            timer.Tick += new EventHandler(this.timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            lblClock.Text = clock;
            lblDate.Text = date;
        }
    }
}
