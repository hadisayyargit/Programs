using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class EducationDegree
    {
        #region Method



        public string dbUpdate()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_Code", m_nEducationCode);
                objSqlParameters[1] = new SqlParameter("@IsActive", m_bIsActive);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Prs_Tbl_StudyStatus_Update", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }



        #endregion

        #region Property

        public int EducationCode
        {
            get
            {
                return (m_nEducationCode);
            }

            set
            {
                m_nEducationCode = value;
            }
        }

        public string EducationName
        {
            get
            {
                return (m_strEducationName);
            }

            set
            {
                m_strEducationName = value;
            }
        }


        public bool IsActive
        {
            get
            {
                return (m_bIsActive);
            }

            set
            {
                m_bIsActive = value;
            }
        }




        #endregion

        #region Private

        private int m_nEducationCode;
        private string m_strEducationName;
        private bool m_bIsActive;

        #endregion
    }
}
