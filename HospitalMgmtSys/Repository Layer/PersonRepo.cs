using System.Collections.Generic;
using System.Data.SqlClient;
using HospitalMgmtSys.Data_Layer;
using System.Data;

namespace HospitalMgmtSys.Repository_Layer
{
    public class PersonRepo
    {
        private SqlConnection sqlConnection = DataAccess.Sqlcon;

        public int PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Phone { get; set; }

        /// <summary>
        /// Returns Datatable of all the person
        /// </summary>
        /// <param name="sql">query</param>
        /// <returns>Datatable</returns>
        public DataTable GetAllPersons(string sql = "select * from person")
        {
            DataSet personDataTable = DataAccess.GetDataSet(sql);
            return personDataTable.Tables[0];
        }
        
        /// <summary>
        /// Get info of a person based on id
        /// </summary>
        /// <param name="id">Id of the person</param>
        /// <returns></returns>
        public DataTable GetIndividualPerson(int id)
        {
            DataSet data = DataAccess.GetDataSet("select * from person where personid = '" + id + "' ");
            return data.Tables[0];
        }

        /// <summary>
        /// Insert information of new person
        /// </summary>
        /// <param name="name">Name of the perosn</param>
        /// <param name="age">Age of the person</param>
        /// <param name="gender">Gender of the person</param>
        /// <param name="bloodgroup">Blood Group of the person</param>
        /// <param name="phone">Phone number of the person</param>
        /// <returns>1 if created or 0</returns>
        public int CreatePerson(string name, int age, string gender, string bloodgroup, string phone)
        {
            string sql = @"insert into person values('" + name + "', '" + age + "', '" + gender + "', '" + bloodgroup + "', '" + phone + "') ";
            //string sql2 = @"insert into person values('" + name + "', '" + age + "',  '" + gender + "', '" + bloodgroup + "')";
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Updates the information of a person
        /// </summary>
        /// <param name="id">id of the person to be updated</param>
        /// <param name="name">Name of the perosn</param>
        /// <param name="age">Age of the person</param>
        /// <param name="gender">Gender of the person</param>
        /// <param name="bloodgroup">Blood Group of the person</param>
        /// <param name="phone">Phone number of the person</param>
        /// <returns>1 if updated otherwise 0</returns>
        public int UpdatePerson(int id, string name, int age, string gender, string bloodgroup, string phone)
        {
            string sql = @"update person
                            set name = '" + name + @"',
                            age = '" + age + @"',
                            gender = '" + gender + @"',
                            bloodgroup = '" + bloodgroup + @"',
                            phone = '" + phone + @"'
                            where personid = '" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Delete a persons info from person table whose id matches the id passed
        /// </summary>
        /// <param name="id">The Person ID</param>
        /// <returns>1 if deleted otherwise 0</returns>
        public int DeletePerson(int id)
        {
            string sql = string.Format(@"DELETE FROM person WHERE personid = '" + id + "'; ");
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Get info of the last person inserted into the person table
        /// </summary>
        /// <returns>Datatable containing one row only</returns>
        public DataTable GetLastPerson()
        {
            DataSet data = DataAccess.GetDataSet("SELECT TOP 1 * FROM PERSON ORDER BY personid DESC");
            return data.Tables[0];
        }
    }
}
