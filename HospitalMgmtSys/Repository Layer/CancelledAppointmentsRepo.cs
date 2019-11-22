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
    class CancelledAppointmentsRepo
    {
        public static int CreateCancelledAppointment(string starttime, string date, int personid, int doctorid)
        {
            string sql = @"insert into cancelledappointments (starttime,date,personid,doctorid) values('" + starttime + "', '" + date + "',  '" + personid + "', '" + doctorid + "')";
            return DataAccess.ExecuteQuery(sql);
        }

        public static DataTable GetAllCancelledAppointmentInformation(string sql = "select * from cancelledappointments")
        {
            DataSet dataSet = DataAccess.GetDataSet(sql);
            return dataSet.Tables[0];
        }

        public static int RemoveCancelledAppointment(int id)
        {
            string sql = "DELETE FROM cancelledappointments WHERE appointmentid = '" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        public static int RemoveParticularDoctorsAppointments(int doctorID)
        {
            string sql = "DELETE FROM cancelledappointments WHERE doctorid = '" + doctorID + "';";
            return DataAccess.ExecuteQuery(sql);
        }

    }
}
