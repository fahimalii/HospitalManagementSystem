using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSys.Data_Layer
{
    public class DataAccess
    {
        private static SqlConnection sqlcon;

        public static SqlConnection Sqlcon
        {
            get
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\C# Final Project\HMSFinal\HospitalMgmtSys\HospitalMgmtSys\hms.mdf;Integrated Security=True");
                }
                else if (sqlcon.State != ConnectionState.Open)
                {
                    sqlcon.Open();
                }
                return sqlcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqlcon);
            return sqcom.ExecuteNonQuery();
        }

        /// <summary>
        /// Checks if a row exists in a table
        /// </summary>
        /// <param name="query"></param>
        /// <returns>true if row exits, otherwise false</returns>
        public static bool RowExists(string query)
        {
            SqlCommand sqcom = new SqlCommand(query,Sqlcon);
            SqlDataReader dr = sqcom.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            dr.Close();    
            return false;
        }

        public static void CloseConnection()
        {
            if(sqlcon != null)
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
                sqlcon = null;
            }
        }
    }
}
