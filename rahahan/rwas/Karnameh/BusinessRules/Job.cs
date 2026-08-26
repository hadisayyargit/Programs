using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class Job
    {
        #region Method

        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[3];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_Code", m_strJobId);
                objSqlParameters[1] = new SqlParameter("@Prs_Fld_Describe", m_strJobName);
                objSqlParameters[2] = new SqlParameter("@JobGroup", m_stJobGroup);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Prs_Tbl_Job_Insert", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[3];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_Code", m_strJobId);
                objSqlParameters[1] = new SqlParameter("@Prs_Fld_Describe", m_strJobName);
                objSqlParameters[2] = new SqlParameter("@JobGroup", m_stJobGroup);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Prs_Tbl_Job_Update", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_Code", m_strJobId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Prs_Tbl_Job_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

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

        public string JobName
        {
            get
            {
                return (m_strJobName);
            }

            set
            {
                m_strJobName = value;
            }
        }


        public string JobGroup
        {
            get
            {
                return (m_stJobGroup);
            }

            set
            {
                m_stJobGroup = value;
            }
        }




        #endregion

        #region Private

        private string m_strJobId;
        private string m_strJobName;
        private string m_stJobGroup;

        #endregion
    }
}
