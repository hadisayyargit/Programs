using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;


namespace RWAS.BusinessRules
{
    public class Setad
    {
        #region Method

        public static DataView GetSetad()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_tbl_Setad", "*", "", "SetadId").DefaultView;
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
                objSqlParameters[0] = new SqlParameter("@SetadId", m_nSetadId);
                objSqlParameters[1] = new SqlParameter("@Pname", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Setad_Insert", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@SetadId", m_nSetadId);
                objSqlParameters[1] = new SqlParameter("@Pname", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Setad_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@SetadId", m_nSetadId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Setad_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public short SetadId
        {
            get
            {
                return (m_nSetadId);
            }

            set
            {
                m_nSetadId = value;
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

        private short m_nSetadId;
        private string m_strPname;

        #endregion
    }
}
