using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class ApplicationObject
    {
        #region static
        
        public static DataTable GetApplicationObject()
        {
            DataTable dtResult = new DataTable();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Acc_Tbl_ApplicationObject", "*", "ApplicationId='" + Common.CommonClass.m_ApplicationId + "'", "ObjectId");
            }
            catch
            {
            }

            return dtResult;
        }

        public static string UpdateApplicationObject(DataTable myTable)
        {
            string strRes = "";

            SqlCommand c1 = new SqlCommand("select * from Acc_Tbl_ApplicationObject", dpHadiData.m_PrimaryConnection);

            SqlCommand c2 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Insert", dpHadiData.m_PrimaryConnection);
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c2.Parameters.Add("@ParentObjectId", SqlDbType.VarChar, 50, "ParentObjectId");
            c2.Parameters.Add("@ObjectType", SqlDbType.VarChar, 20, "ObjectType");
            c2.Parameters.Add("@Pname", SqlDbType.NVarChar, 50, "Pname");
            c2.Parameters.Add("@IsSecurable", SqlDbType.Bit, 1, "IsSecurable");
            c2.Parameters.Add("@ApplicationId", SqlDbType.VarChar, 20, "ApplicationId");

            SqlCommand c3 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Update", dpHadiData.m_PrimaryConnection);
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c3.Parameters.Add("@ParentObjectId", SqlDbType.VarChar, 50, "ParentObjectId");
            c3.Parameters.Add("@ObjectType", SqlDbType.VarChar, 20, "ObjectType");
            c3.Parameters.Add("@Pname", SqlDbType.NVarChar, 50, "Pname");
            c3.Parameters.Add("@IsSecurable", SqlDbType.Bit, 1, "IsSecurable");
            c3.Parameters.Add("@ApplicationId", SqlDbType.VarChar, 20, "ApplicationId");

            SqlCommand c4 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Delete", dpHadiData.m_PrimaryConnection);
            c4.CommandType = CommandType.StoredProcedure;
            c4.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");

            strRes = RWAS.DataAccess.dpHadiData.UpdateDataSource(RWAS.DataAccess.dpHadiData.m_PrimaryConnection, myTable, c1, c2, c3, c4);


            return strRes;
        }

        #endregion

        #region Method

        public string dbInsert()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[6];

            try
            {
                objSqlParameters[0] = new SqlParameter("@ObjectId", m_strObjectId);
                objSqlParameters[1] = new SqlParameter("@ParentObjectId", m_strParentObjectId);
                objSqlParameters[2] = new SqlParameter("@ObjectType", m_strObjectType);
                objSqlParameters[3] = new SqlParameter("@Pname", m_strPname);
                objSqlParameters[4] = new SqlParameter("@IsSecurable", m_bIsSecurable);
                objSqlParameters[5] = new SqlParameter("@ApplicationId", m_strApplicationId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_ApplicationObject_Insert", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[6];

            try
            {
                objSqlParameters[0] = new SqlParameter("@ObjectId", m_strObjectId);
                objSqlParameters[1] = new SqlParameter("@ParentObjectId", m_strParentObjectId);
                objSqlParameters[2] = new SqlParameter("@ObjectType", m_strObjectType);
                objSqlParameters[3] = new SqlParameter("@Pname", m_strPname);
                objSqlParameters[4] = new SqlParameter("@IsSecurable", m_bIsSecurable);
                objSqlParameters[5] = new SqlParameter("@ApplicationId", m_strApplicationId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_ApplicationObject_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@ObjectId", m_strObjectId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_ApplicationObject_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Property


        public string ObjectId
        {
            get
            {
                return (m_strObjectId);
            }

            set
            {
                m_strObjectId = value;
            }
        }

        public string ParentObjectId
        {
            get
            {
                return (m_strParentObjectId);
            }

            set
            {
                m_strParentObjectId = value;
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

        public string ObjectType
        {
            get
            {
                return (m_strObjectType);
            }

            set
            {
                m_strObjectType = value;
            }
        }

        public bool IsSecurable
        {
            get
            {
                return (m_bIsSecurable);
            }

            set
            {
                m_bIsSecurable = value;
            }
        }

        public string ApplicationId
        {
            get
            {
                return (m_strApplicationId);
            }

            set
            {
                m_strApplicationId = value;
            }
        }

        #endregion

        #region Private

        private string m_strObjectId;
        private string m_strParentObjectId;
        private string m_strPname;
        private string m_strObjectType;
        private string m_strApplicationId;
        private bool m_bIsSecurable;

        #endregion
    }
}
