using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMgmtSys.Data_Layer;

namespace HospitalMgmtSys.Repository_Layer
{
    public class PatientDiseaseRepo
    {

        /// <summary>
        /// Delete All info which has reference of a doctor
        /// Called when a doctor is fired
        /// </summary>
        /// <param name="doctorID">ID of doctor</param>
        /// <returns>1 if executed successfully, otherwise 0</returns>
        public static int DeleteInfoBasedOnDoctor(int doctorID)
        {
            string sql = string.Format(@"DELETE FROM patientdisease WHERE doctorid = '" + doctorID + "'; ");
            return DataAccess.ExecuteQuery(sql);
        }

        public static void InsertPresonDisease(List<string> diseaseList, List<string> medicineList, int personid, int doctorid)
        {
            string diseaseName, medicineName;
            try
            {
                for (int ax = 0, bx = 0; ax < diseaseList.Count || bx < medicineList.Count; ax++, bx++)
                {
                    if (ax >= diseaseList.Count)
                    {
                        diseaseName = "";
                    }

                    else
                        diseaseName = diseaseList[ax];
                    if (bx >= medicineList.Count)
                        medicineName = "";
                    else
                        medicineName = medicineList[bx];
                    DataAccess.ExecuteQuery("insert into patientdisease values(" + personid + ",'" + diseaseName + "','" + medicineName + "'," + doctorid + ");");
                    DataAccess.ExecuteQuery("update appointment set complete=1 where personid=" + personid + ";");


                }
                MessageBox.Show("Saved SuccessFully");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        public static DataTable GetIndividualMedicine(int personid)
        {
            var medicineTable = DataAccess.GetDataTable("select medicinename from patientdisease where personid=" + personid + ";");
            return medicineTable;
        }
        public static DataTable GetIndividualDisease(int personid)
        {
            var diseaseTable = DataAccess.GetDataTable("select diseasename from patientdisease where personid=" + personid + ";");
            return diseaseTable;
        }
        public static void DeletePatientDisease(int personid)
        {
            DataAccess.ExecuteQuery("delete from patientdisease where personid=" + personid + ";");
        }
    }
}