using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class UserAccessRight
    {
        #region static

        public static void DeleteAllAccess(int groupid, string userid)
        {
            string strQuery;
            string strFilter;

            try
            {
                if (userid == "")
                    strFilter = "Acc_Tbl_ApplicationObject.ApplicationId='" + Common.CommonClass.m_ApplicationId + "' and GroupId=" + groupid.ToString() + " and UserId Is Null";
                else
                    strFilter = "Acc_Tbl_ApplicationObject.ApplicationId='" + Common.CommonClass.m_ApplicationId + "' and GroupId=" + groupid.ToString() + " and UserId='" + userid + "'";

                strQuery = "delete Acc_Tbl_UserAccessRight FROM Acc_Tbl_UserAccessRight LEFT OUTER JOIN Acc_Tbl_ApplicationObject ON Acc_Tbl_UserAccessRight.ObjectId = Acc_Tbl_ApplicationObject.ObjectId"
                        + " WHERE " + strFilter;

                dpHadiData.ExecuteNonQuery(dpHadiData.m_PrimaryConnection, strQuery);
            }

            catch(Exception ex)
            {
            }

           
        }

        public static void BindAccessRight(System.Windows.Forms.DataGridView workListControl)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "view_UserAccessRight", "*", "ApplicationId='" + Common.CommonClass.m_ApplicationId + "'", "GroupId,UserId,ObjectType,ParentObjectId,ObjectId");
                workListControl.DataSource = dtInput;
            }
            catch
            {
            }

        }

        public static DataTable GetAccessRight(int myGroupId, string myUserId)
        {
            DataTable dtResult = new DataTable();
            string strFilter = "";
            try
            {
                strFilter = "ApplicationId='" + Common.CommonClass.m_ApplicationId + "'";

                if (myGroupId != -1)
                    strFilter += " AND GroupId=" + myGroupId.ToString();
                if (myUserId != null)
                    strFilter += " AND UserId='" + myUserId + "'";
                else if (myUserId == null && myGroupId != -1)
                    strFilter += " AND UserId IS NULL";

                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "view_UserAccessRight", "*", strFilter, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtResult;
        }

        public static string UpdateAccess(DataTable myTable)
        {
            string strRes = "";

            SqlCommand c1 = new SqlCommand("select * from Acc_Tbl_UserAccessRight", dpHadiData.m_PrimaryConnection);

            SqlCommand c2 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Insert", dpHadiData.m_PrimaryConnection);
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("@GroupId", SqlDbType.Int, 4, "GroupId");
            c2.Parameters.Add("@UserId", SqlDbType.VarChar, 16, "UserId");
            c2.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c2.Parameters.Add("@IsVisible", SqlDbType.Bit, 1, "IsVisible");
            c2.Parameters.Add("@IsEnable", SqlDbType.Bit, 1, "IsEnable");
            c2.Parameters.Add("@GrantSelect", SqlDbType.Bit, 1, "GrantSelect");
            c2.Parameters.Add("@GrantInsert", SqlDbType.Bit, 1, "GrantInsert");
            c2.Parameters.Add("@GrantUpdate", SqlDbType.Bit, 1, "GrantUpdate");
            c2.Parameters.Add("@GrantDelete", SqlDbType.Bit, 1, "GrantDelete");
            c2.Parameters.Add("@GrantExecute", SqlDbType.Bit, 1, "GrantExecute");

            SqlCommand c3 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Update", dpHadiData.m_PrimaryConnection);
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("@AccessId", SqlDbType.UniqueIdentifier, 16, "AccessId");
            c3.Parameters.Add("@GroupId", SqlDbType.Int, 4, "GroupId");
            c3.Parameters.Add("@UserId", SqlDbType.VarChar, 16, "UserId");
            c3.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c3.Parameters.Add("@IsVisible", SqlDbType.Bit, 1, "IsVisible");
            c3.Parameters.Add("@IsEnable", SqlDbType.Bit, 1, "IsEnable");
            c3.Parameters.Add("@GrantSelect", SqlDbType.Bit, 1, "GrantSelect");
            c3.Parameters.Add("@GrantInsert", SqlDbType.Bit, 1, "GrantInsert");
            c3.Parameters.Add("@GrantUpdate", SqlDbType.Bit, 1, "GrantUpdate");
            c3.Parameters.Add("@GrantDelete", SqlDbType.Bit, 1, "GrantDelete");
            c3.Parameters.Add("@GrantExecute", SqlDbType.Bit, 1, "GrantExecute");

            SqlCommand c4 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Delete", dpHadiData.m_PrimaryConnection);
            c4.CommandType = CommandType.StoredProcedure;
            c4.Parameters.Add("@AccessId", SqlDbType.UniqueIdentifier, 16, "AccessId");

            strRes = RWAS.DataAccess.dpHadiData.UpdateDataSource(RWAS.DataAccess.dpHadiData.m_PrimaryConnection, myTable, c1, c2, c3, c4);


            return strRes;
        }

        #endregion

        #region Method

        public string  dbInsert()
        {
            string strRes = "";
            
            SqlParameter[] objSqlParameters = new SqlParameter[11];

            try
            {
                objSqlParameters[0] = new SqlParameter("@MachineName", m_strMachineName);
                objSqlParameters[1] = new SqlParameter("@GroupId", m_nGroupId);
                objSqlParameters[2] = new SqlParameter("@UserId", m_strUserId);
                objSqlParameters[3] = new SqlParameter("@ObjectId", m_strObjectId);
                objSqlParameters[4] = new SqlParameter("@IsVisible", m_bIsVisible);                
                objSqlParameters[5] = new SqlParameter("@IsEnable", m_bIsEnable);
                objSqlParameters[6] = new SqlParameter("@GrantSelect", m_bGrantSelect);
                objSqlParameters[7] = new SqlParameter("@GrantInsert", m_bGrantInsert);
                objSqlParameters[8] = new SqlParameter("@GrantUpdate", m_bGrantUpdate);
                objSqlParameters[9] = new SqlParameter("@GrantDelete", m_bGrantDelete);
                objSqlParameters[10] = new SqlParameter("@GrantExecute", m_bGrantExecute);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_UserAccessRight_Insert", objSqlParameters);
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

            SqlParameter[] objSqlParameters = new SqlParameter[12];

            try
            {
                objSqlParameters[0] = new SqlParameter("@AccessId", m_strAccessId);
                objSqlParameters[1] = new SqlParameter("@MachineName", m_strMachineName);
                objSqlParameters[2] = new SqlParameter("@GroupId", m_nGroupId);
                objSqlParameters[3] = new SqlParameter("@UserId", m_strUserId);
                objSqlParameters[4] = new SqlParameter("@ObjectId", m_strObjectId);
                objSqlParameters[5] = new SqlParameter("@IsVisible", m_bIsVisible);
                objSqlParameters[6] = new SqlParameter("@IsEnable", m_bIsEnable);
                objSqlParameters[7] = new SqlParameter("@GrantSelect", m_bGrantSelect);
                objSqlParameters[8] = new SqlParameter("@GrantInsert", m_bGrantInsert);
                objSqlParameters[9] = new SqlParameter("@GrantUpdate", m_bGrantUpdate);
                objSqlParameters[10] = new SqlParameter("@GrantDelete", m_bGrantDelete);
                objSqlParameters[11] = new SqlParameter("@GrantExecute", m_bGrantExecute);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_UserAccessRight_Update", objSqlParameters);
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
                objSqlParameters[0] = new SqlParameter("@AccessId", m_strAccessId);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Acc_Tbl_UserAccessRight_Delete", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        #endregion

        #region Public

        public string dbGetId()
        {
            string strRes = "";
            string strFilter = "";


            strRes = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "Acc_Tbl_UserAccessRight", "AccessId", strFilter).ToString();
            return strRes;
        }


        #endregion

        #region Property

        public string AccessId
        {
            get
            {
                return (m_strAccessId);
            }

            set
            {
                m_strAccessId = value;
            }
        }

        public string UID
        {
            get
            {
                return (m_strUserId);
            }
            set
            {
                m_strUserId = value;
            }
        }

        public string MachineName
        {
            get
            {
                return (m_strMachineName);
            }

            set
            {
                m_strMachineName = value;
            }
        }

        public int GroupId
        {
            get
            {
                return (m_nGroupId);
            }

            set
            {
                m_nGroupId = value;
            }
        }


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


        public bool IsVisible
        {
            get
            {
                return (m_bIsVisible);
            }

            set
            {
                m_bIsVisible = value;
            }
        }

        public bool IsEnable
        {
            get
            {
                return (m_bIsEnable);
            }

            set
            {
                m_bIsEnable = value;
            }
        }

        public bool GrantSelect
        {
            get
            {
                return (m_bGrantSelect);
            }

            set
            {
                m_bGrantSelect = value;
            }
        }
        public bool GrantInsert
        {
            get
            {
                return (m_bGrantInsert);
            }

            set
            {
                m_bGrantInsert = value;
            }
        }
        public bool GrantUpdate
        {
            get
            {
                return (m_bGrantUpdate);
            }

            set
            {
                m_bGrantUpdate = value;
            }
        }
        public bool GrantDelete
        {
            get
            {
                return (m_bGrantDelete);
            }

            set
            {
                m_bGrantDelete = value;
            }
        }
        public bool GrantExecute
        {
            get
            {
                return (m_bGrantExecute);
            }

            set
            {
                m_bGrantExecute = value;
            }
        }

        #endregion

        #region Private

        private string m_strAccessId;
        private string m_strMachineName;
        private int m_nGroupId;
        private string m_strUserId;
        private string m_strObjectId;
        private bool m_bIsVisible;
        private bool m_bIsEnable;
        private bool m_bGrantSelect;
        private bool m_bGrantInsert;
        private bool m_bGrantUpdate;
        private bool m_bGrantDelete;
        private bool m_bGrantExecute;
        #endregion
    }
}
