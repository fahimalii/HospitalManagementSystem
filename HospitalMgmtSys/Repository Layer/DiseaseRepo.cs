using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalMgmtSys.Data_Layer;
using System.Data;

namespace HospitalMgmtSys.Repository_Layer
{
    public class DiseaseRepo
    {
        public static DataTable GetAllDisease(string sql = "select * from disease;")
        {
            DataTable diseaseTable = DataAccess.GetDataTable(sql);
            return diseaseTable;
        }
    }
}
