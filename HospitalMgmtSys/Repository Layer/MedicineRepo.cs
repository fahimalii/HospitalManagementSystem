using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMgmtSys.Data_Layer;
using System.Data;

namespace HospitalMgmtSys.Repository_Layer
{
    public class MedicineRepo
    {
        public static DataTable GetAllMedicine(string sql = "select * from medicine;")
        {
            DataTable medicineTable = DataAccess.GetDataTable(sql);
            return medicineTable;
        }
    }
}
