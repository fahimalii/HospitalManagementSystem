using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMgmtSys.Data_Layer;

namespace HospitalMgmtSys.Repository_Layer
{
    public class EmployeeRepo
    {
        public int EmpID { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }


        /// <summary>
        /// Insert information of new employee
        /// </summary>
        /// <param name="designation">designation of the employee</param>
        /// <param name="salary">salary of the employee</param>
        /// <param name="personid">personid of the employee which is retrived from person table</param>
        /// <returns></returns>
        public int CreateEmployee(string designation, int salary, int personid)
        {
            string sql = @"insert into employee values('" + designation + "', '" + salary + "', '" + personid + "' )";
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// The designation or salary of the employee can be updated in this one
        /// </summary>
        /// <param name="id">employee id of the employee</param>
        /// <param name="designation">designation of the employee</param>
        /// <param name="salary">salary of the employee</param>
        /// <returns>1 if updated otherwise 0</returns>
        public int UpdateEmployee(int id, string designation, int salary)
        {
            string sql = @"update employee
                            set designation = '" + designation + @"',
                            salary = '" + salary + @"'
                            where empid = '" + id + "';";
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Delete an employee info from employy table whose id matches the id passed
        /// </summary>
        /// <param name="id">The employee ID</param>
        /// <returns>1 if deleted otherwise 0</returns>
        public int DeleteEmployee(int id)
        {
            string sql = string.Format(@"DELETE FROM employee WHERE empid = '" + id + "'; ");
            return DataAccess.ExecuteQuery(sql);
        }

        /// <summary>
        /// Get info of the last employee inserted into the employee table
        /// </summary>
        /// <returns>Datatable containing one row only</returns>
        public DataTable GetLastEmployee()
        {
            DataSet data = DataAccess.GetDataSet("SELECT TOP 1 * FROM EMPLOYEE ORDER BY personid DESC");
            return data.Tables[0];
        }
    }
}
