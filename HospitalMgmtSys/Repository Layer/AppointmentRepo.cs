using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMgmtSys.Data_Layer;

namespace HospitalMgmtSys.Repository_Layer
{
    public class AppointmentRepo
    {
        public int AppointmentID { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }

        public DataTable GetAllAppointmentInformation(string sql = "select * from appointment")
        {
            DataSet personDataTable = DataAccess.GetDataSet(sql);
            return personDataTable.Tables[0];
        }

        public int CreateAppointment(string starttime, string date, int personid, int doctorid)
        {
            string sql = @"insert into appointment values('" + starttime + "', '" + date + "',  '" + personid + "', '" + doctorid + "' , '" + Convert.ToInt32(0) + "')";
            return DataAccess.ExecuteQuery(sql);
        }

        
        public int UpdateAppointment(int id, string starttime, string date, int personid, int doctorid)
        {
            string sql = @"update appointment
                            set starttime = '" + starttime + @"',
                            date = '" + date + @"',
                            personid = '" + personid + @"',
                            doctorid = '" + doctorid + @"'
                            where appointmentid = '" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        
        public int DeleteAppointment(int appoointmentID)
        {
            string sql = "DELETE FROM appointment WHERE appointmentid = '" + appoointmentID + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// This method is used to find out if a particular doctor has an appointment on a particular day
        /// at aparticular time 
        /// Used to avoid clash appointment of a doctor on same day and same time
        /// </summary>
        /// <param name="starttime">start time of appointment</param>
        /// <param name="date">date of appointment</param>
        /// <param name="doctorid">doctor id</param>
        /// <returns></returns>
        public DataTable GetIndividualAppointment(string starttime, string date, int doctorid)
        {
            string sql = "select * from appointment where starttime = '"+starttime+"' and date = '"+date+"' and doctorid = '"+doctorid+"'";
            DataSet data = DataAccess.GetDataSet(sql);
            return data.Tables[0];
        }

        public bool RowExits(string starttime, string date, int doctorid)
        {
            string sql = "select * from appointment where starttime = '" + starttime + "' and date = '" + date + "' and doctorid = '" + doctorid + "'";
            bool result = DataAccess.RowExists(sql);
            return result;
        }

        public static int RemoveParticularDoctorsAppointments(int doctorID)
        {
            string sql = "DELETE FROM appointment WHERE doctorid = '" + doctorID + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        public static DataTable GetSpecificDoctorAppointments(int doctorid)
        {
            DataTable appointmentTable;
            string sql = "select * from appointment where date='" + DateTime.Today.ToString("d") + "' and doctorid=" + doctorid + ";";
            appointmentTable = DataAccess.GetDataTable(sql);
            return appointmentTable;
        }
        public static void DeleteAllToday(int doctorid)
        {
            DataAccess.ExecuteQuery("delete from appointment where doctorid=" + doctorid + " and date ='" + DateTime.Today.ToString("d") + "';");
        }

        public static void DeleteCompletedAppointment(int personid)
        {
            DataAccess.ExecuteQuery("delete from appointment where personid=" + personid + ";");

        }

        public static void DeleteByPatient(int personid,int doctorid)
        {
            DataAccess.ExecuteQuery("delete from appointment where personid="+personid+" and doctorid="+doctorid+";");
        }
        
    }
}
