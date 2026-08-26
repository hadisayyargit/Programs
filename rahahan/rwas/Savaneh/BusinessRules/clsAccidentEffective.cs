using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class clsAccidentEffective
    {
        #region static

        public static DataView GetAllAccidentEffectives()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_AccidentEffective", "*", "", "Rws_Fld_Code").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        #endregion

        #region Method
        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Describe", m_strName);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_Sp_Ins_AccidentEffective", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nCode);
                objSqlParameters[1] = new SqlParameter("@Rws_Fld_Describe", m_strName);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_SP_Upd_AccidentEffective", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_Code", m_nCode);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Rws_SP_Del_AccidentEffective", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public byte AccidentEffectiveCode
        {
            get
            {
                return (m_nCode);
            }

            set
            {
                m_nCode = value;
            }
        }

        public string AccidentEffectiveName
        {
            get
            {
                return (m_strName);
            }

            set
            {
                m_strName = value;
            }
        }


        #endregion

        #region Private

        private byte m_nCode;
        private string m_strName;

        #endregion
    }
}
