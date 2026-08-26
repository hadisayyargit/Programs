using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class PersonnelStatus
    {
        #region Method

        public static DataView GetPersonnelStatus()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_PrefermentHistory", "*", "", "Rws_Fld_UniqueCode, Rws_Fld_Row").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public DataView GetPersonnelJobStatusOfPersonnel(bool ispreferment)
        {
            DataView dvResult = new DataView();
                      SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                dvResult = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Sp_GetPersonnelJobStatus", objSqlParameters).DefaultView;
                dvResult.RowFilter = ispreferment ? "JobStatusId=0" : "JobStatusId<>0";
                dvResult.Sort = "Rws_Fld_FromDate,Rws_Fld_ToDate";
            }
            catch
            {
            }

            return dvResult;
        }

        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[7];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Row", m_nRow);

                if (m_strBeginDate == "")
                    objSqlParameters[2] = new SqlParameter("@Rws_Fld_FromDate", DBNull.Value);
                else
                    objSqlParameters[2] = new SqlParameter("@Rws_Fld_FromDate", m_strBeginDate);

                if (m_strEndDate == "")
                    objSqlParameters[3] = new SqlParameter("@Rws_Fld_ToDate", DBNull.Value);
                else
                    objSqlParameters[3] = new SqlParameter("@Rws_Fld_ToDate", m_strEndDate);

                objSqlParameters[4] = new SqlParameter("@JobStatusId", m_nJobStatusId);
                objSqlParameters[5] = new SqlParameter("@Rws_Fld_fk_Region", m_nRegionCode);
                objSqlParameters[6] = new SqlParameter("@Rws_Fld_fk_Job", m_strJobId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_Sp_Ins_PrefermentHistory", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[7];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", m_nUniqueCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Row", m_nRow);

                if (m_strBeginDate == "")
                    objSqlParameters[2] = new SqlParameter("@Rws_Fld_FromDate", DBNull.Value);
                else
                    objSqlParameters[2] = new SqlParameter("@Rws_Fld_FromDate", m_strBeginDate);

                if (m_strEndDate == "")
                    objSqlParameters[3] = new SqlParameter("@Rws_Fld_ToDate", DBNull.Value);
                else
                    objSqlParameters[3] = new SqlParameter("@Rws_Fld_ToDate", m_strEndDate);

                objSqlParameters[4] = new SqlParameter("@JobStatusId", m_nJobStatusId);
                objSqlParameters[5] = new SqlParameter("@Rws_Fld_fk_Region", m_nRegionCode);

                if (m_strJobId != null)
                    objSqlParameters[6] = new SqlParameter("@Rws_Fld_fk_Job", m_strJobId);
                else
                    objSqlParameters[6] = new SqlParameter("@Rws_Fld_fk_Job", null);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_Sp_upd_PrefermentHistory", objSqlParameters);
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

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_Sp_del_PrefermentHistory", objSqlParameters);
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

        public string BeginDate
        {
            get
            {
                return (m_strBeginDate);
            }

            set
            {
                m_strBeginDate = value;
            }
        }


        public string EndDate
        {
            get
            {
                return (m_strEndDate);
            }

            set
            {
                m_strEndDate = value;
            }
        }


        public byte JobStatusId
        {
            get
            {
                return (m_nJobStatusId);
            }

            set
            {
                  m_nJobStatusId = value;
            }
        }

        public int RegionCode
        {
            get
            {
                return (m_nRegionCode);
            }

            set
            {
                m_nRegionCode = value;
            }
        }

        public string JobId
        {
            get
            {
                return (m_strJobId);
            }

            set
            {
                m_strJobId = value;
            }
        }



        #endregion

        #region Private

        private int m_nUniqueCode;
        private byte m_nRow;
        private string m_strBeginDate;
        private string m_strEndDate;
        private byte m_nJobStatusId;
        private int m_nRegionCode;
        private string m_strJobId;

        #endregion
    }
}
