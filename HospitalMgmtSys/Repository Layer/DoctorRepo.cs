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
    public class DoctorRepo
    {
        public int DoctorID { get; set; }
        public string Specialty { get; set; }
        public string AvailableDays { get; set; }
        public int EmployeeIdOfDoctor { get; set; }

        public int CreateDoctor(string specialty, string availableDays, int empIdOfDoctor)
        {
            string sql = @"insert into doctor values('" + specialty + "', '" + availableDays + "', '" + empIdOfDoctor + "' )";
            return DataAccess.ExecuteQuery(sql);
        }

        public DataTable GetIndividualDoctorsInfo(int id)
        {
            DataSet data = DataAccess.GetDataSet("select * from doctor where doctorid = '" + id + "' ");
            return data.Tables[0];
        }

        public int DeleteDoctor(int id)
        {
            string sql = @"DELETE FROM doctor WHERE doctorid = '" + id + "'; ";
            return DataAccess.ExecuteQuery(sql);
        }

        public int UpdateDoctor(int id, string specialty, string availableDays)
        {
            string sql = @"update doctor
                            set specialty = '" + specialty + @"',
                            availableDays = '" + availableDays + @"'
                            where doctorid = '" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }


        public static  int GetDoctorID(int employeeID)
        {
            string sql = "select doctorid from doctor where empid="+employeeID+";";
            DataTable doctorTable = DataAccess.GetDataTable(sql);
            return Convert.ToInt32(doctorTable.Rows[0][0].ToString());
        }
    }
}
