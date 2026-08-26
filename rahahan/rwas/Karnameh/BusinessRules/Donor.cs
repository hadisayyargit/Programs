using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class Donor
    {
        #region Method

        public static DataView GetDonor()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_tbl_Donor", "*", "", "DonorId").DefaultView;
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
                objSqlParameters[0] = new SqlParameter("@DonorId", m_nDonorId);
                objSqlParameters[1] = new SqlParameter("@Pname", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Donor_Insert", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@DonorId", m_nDonorId);
                objSqlParameters[1] = new SqlParameter("@Pname", m_strPname);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Donor_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@DonorId", m_nDonorId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_Donor_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property

        public short DonorId
        {
            get
            {
                return (m_nDonorId);
            }

            set
            {
                m_nDonorId = value;
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

        private short m_nDonorId;
        private string m_strPname;

        #endregion
    }
}
