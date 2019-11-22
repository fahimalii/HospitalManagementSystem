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
    class PersonAppointmentRepo
    {
        public static DataTable GetAllDoctorAppointmentInfo(int doctorid)
        {
            DataTable allDoctorAppointmentsTable = DataAccess.GetDataTable(@"select appointment.appointmentid,person.personid, person.name, person.age,person.bloodgroup,person.gender,person.phone
, appointment.date, appointment.starttime from appointment, person person where person.personid= appointment.personid and appointment.doctorid=" + doctorid + " and complete=0;");
            return allDoctorAppointmentsTable;
        }
        public static DataTable GetDoctorAppointmentSearch(int doctorid, string name)
        {
            DataTable doctorSearchTable = DataAccess.GetDataTable(@"select appointment.appointmentid,person.personid, person.name, person.age,person.bloodgroup,person.gender,person.phone
, appointment.date, appointment.starttime from appointment, person person where person.personid= appointment.personid and  complete=0 and appointment.doctorid=" + doctorid + " and person.name like '" + name + "%'; ");
            return doctorSearchTable;

        }

        public static DataTable GetAllDoctorCompleteAppointmentInfo(int doctorid)
        {
            DataTable allDoctorAppointmentsTable = DataAccess.GetDataTable(@"select appointment.appointmentid,person.personid, person.name, person.age,person.bloodgroup,person.gender,person.phone
, appointment.date, appointment.starttime from appointment, person person where person.personid= appointment.personid and appointment.doctorid=" + doctorid + " and complete=1;");
            return allDoctorAppointmentsTable;
        }
        public static DataTable GetDoctorCompleteAppointmentSearch(int doctorid, string name)
        {
            DataTable doctorSearchTable = DataAccess.GetDataTable(@"select appointment.appointmentid,person.personid, person.name, person.age,person.bloodgroup,person.gender,person.phone
, appointment.date, appointment.starttime from appointment, person person where person.personid= appointment.personid and  complete=1 and appointment.doctorid=" + doctorid + " and person.name like '" + name + "%'; ");
            return doctorSearchTable;

        }
    }
}
