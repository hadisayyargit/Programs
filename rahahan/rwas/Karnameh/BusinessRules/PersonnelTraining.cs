using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class PersonnelTraining
    {
        #region Method

        public static DataView GetPersonnelTraining()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwPersonnelTraining_Full", "*", "", "Uniq_Code, Row").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public DataView GetPersonnelTrainingOfPersonnel()
        {
            DataView dvResult = new DataView();
                      SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwPersonnelTraining_Full", "*", "Uniq_Code="+m_nUniqueCode.ToString(), "Uniq_Code, Row").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[4];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Row", m_nRow);
                objSqlParameters[2] = new SqlParameter("@Rws_Fld_TrainingLocation", m_strLocation);
                objSqlParameters[3] = new SqlParameter("@Rws_Fld_Degree", m_nDegree);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_PersonnelTraining_Insert", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        public string dbUpdate()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[4];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Row", m_nRow);
                objSqlParameters[2] = new SqlParameter("@Rws_Fld_TrainingLocation", m_strLocation);
                objSqlParameters[3] = new SqlParameter("@Rws_Fld_Degree", m_nDegree);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_PersonnelTraining_Update", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        public string dbDelete()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Row", m_nRow);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_PersonnelTraining_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public int UniqueCode
        {
            get
            {
                return (m_nUniqueCode);
            }

            set
            {
                m_nUniqueCode = value;
            }
        }

        public byte Row
        {
            get
            {
                return (m_nRow);
            }

            set
            {
                m_nRow = value;
            }
        }

        public string Rws_Fld_TrainingLocation
        {
            get
            {
                return (m_strLocation);
            }

            set
            {
                m_strLocation = value;
            }
        }

        public short Rws_Fld_Degree
        {
            get
            {
                return (m_nDegree);
            }

            set
            {
                m_nDegree = value;
            }
        }




        #endregion

        #region Private

        private int m_nUniqueCode;
        private byte m_nRow;
        private string m_strLocation;
        private short m_nDegree;

        #endregion
    }
}
