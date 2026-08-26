using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class ForfeitKind
    {
        #region Method

        public static DataView GetForfeitKind()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_tbl_ForfeitKind", "*", "", "Rws_Fld_Code").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nForfeitKindId);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Describe", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_ForfeitKind_Insert", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nForfeitKindId);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Describe", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_ForfeitKind_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nForfeitKindId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_ForfeitKind_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public byte ForfeitKindId
        {
            get
            {
                return (m_nForfeitKindId);
            }

            set
            {
                m_nForfeitKindId = value;
            }
        }

        public string Pname
        {
            get
            {
                return (m_strPname);
            }

            set
            {
                m_strPname = value;
            }
        }


        #endregion

        #region Private

        private byte m_nForfeitKindId;
        private string m_strPname;

        #endregion
    }
}
