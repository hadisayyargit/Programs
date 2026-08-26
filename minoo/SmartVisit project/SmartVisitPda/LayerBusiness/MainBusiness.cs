using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;
using Common;

namespace layerBusiness
{
    public class MainBusiness
    {
        public static void PrepareMainConnection()
        {
            try
            {
                MainCommon.m_TestMod = true;

                MainCommon.m_DbPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

                if (MainCommon.m_TestMod)
                    MainCommon.m_DbPath = @"\Storage card\Data";
                 
                MainCommon.m_BackupPath = @"\Storage card";
                ////m_DbPath=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                dpDataAccess.InitConnection(MainCommon.m_DbPath + @"\DigitalVisit.sdf", "7");
                dpDataAccess.OpenSqlCompactConnection();
                dpDataAccess.CloseSqlCompactConnection();

            }
            catch
            {
                throw;
            }

        }

        public static void RestoreDb(string backupfilename)
        {
            try
            {
                dpDataAccess.CloseSqlCompactConnection();
                System.IO.File.Copy(backupfilename, MainCommon.m_DbPath + "\\DigitalVisit.sdf",true);
            }
            catch
            {
                throw;
            }
        }

        public static SqlCeResultSet GetAllNoeTahvil()
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSet("pdNoeTahvil", "*", "", "");

            return objSqlceResultset;

        }

        public static SqlCeResultSet GetAllKanaleForoosh()
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSet("pdKanaleForoosh", "*", "", "");

            return objSqlceResultset;

        }

        public static int GetUserNo()
        {
            int nResult = -1;
      
            try
            {
                nResult = Convert.ToInt32(dpDataAccess.GetFieldValue("pdUser", "userno", ""));
            }
            catch
            {
            }

            return nResult;

        }

        public static string GetUserPhone()
        {
            string strResult = "";

            try
            {
                strResult = dpDataAccess.GetFieldValue("pdVisitor", "mobilephone", "visitorsn=" + MainCommon.m_VisitorSN.ToString()).ToString();
            }
            catch
            {
            }

            return strResult;

        }

        public static void ChangePassword(decimal myUsersn, string myPassword)
        {
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[2];

            try
            {
                objSqlCeParameters[0] = new SqlCeParameter("@usersn", myUsersn);
                objSqlCeParameters[1] = new SqlCeParameter("@password", myPassword);
                dpDataAccess.ExecuteNonQuery("update pdUser set password=@password where usersn=@usersn", objSqlCeParameters);
            }
            catch
            {
                throw;
            }

        }

        public static string FetchVisitorInfo(int userno, string password)
        {
            string strResult = "";
            string strQuery = "";
            SqlCeResultSet objSqlceResultset = null;

            try
            {
                strQuery = "select pdUser.usersn,pdUser.username,pdUser.password,pdUser.userstatus,pdVisitor.visitorsn,pdVisitor.vahedetejarisn from pdUser inner join pdVisitor on pdUser.usersn=pdVisitor.usersn where pdUser.userno=" + userno.ToString() + " and pdUser.password='" + password+"'";
                objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);
                if ((objSqlceResultset != null) && (objSqlceResultset.HasRows))
                {
                    objSqlceResultset.Read();
                    MainCommon.m_VisitorSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("visitorsn"));
                    MainCommon.m_UserSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("usersn"));
                    MainCommon.m_VahedeTejariSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("vahedetejarisn"));
                }
                else
                {
                    strResult = "کد کاربری یا گذرواژه نامعتبر است";
                }
            }
            catch(Exception ex)
            {
                strResult = "error";
            }

            return strResult;
        }

    }
}
