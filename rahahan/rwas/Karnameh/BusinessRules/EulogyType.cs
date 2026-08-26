using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class EulogyType
    {
        #region Method

        public static DataView GetEulogyType()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_tbl_EulogyType", "*", "", "EulogyTypeId").DefaultView;
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
                objSqlParameters[0] = new SqlParameter("@EulogyTypeId", m_nEulogyTypeId);
                objSqlParameters[1] = new SqlParameter("@EulogyTypeDescription", m_strEulogyTypeName);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_EulogyType_Insert", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@EulogyTypeId", m_nEulogyTypeId);
                objSqlParameters[1] = new SqlParameter("@EulogyTypeDescription", m_strEulogyTypeName);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_EulogyType_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@EulogyTypeId", m_nEulogyTypeId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_EulogyType_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public short EulogyTypeId
        {
            get
            {
                return (m_nEulogyTypeId);
            }

            set
            {
                m_nEulogyTypeId = value;
            }
        }

        public string EulogyTypeName
        {
            get
            {
                return (m_strEulogyTypeName);
            }

            set
            {
                m_strEulogyTypeName = value;
            }
        }

        #endregion

        #region Private

        private short m_nEulogyTypeId;
        private string m_strEulogyTypeName;

        #endregion
    }
}
