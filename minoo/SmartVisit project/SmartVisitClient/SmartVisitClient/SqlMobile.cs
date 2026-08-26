using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace SmartVisitClient
{
    public class SqlMobile
    {
        public static SqlCeConnection m_mySqlCeConnection = null;

        public static void InitConnection(string DatabasefilePath, string password)
        {
            string strConnectionString;

            ResultSetOptions rso = System.Data.SqlServerCe.ResultSetOptions.Scrollable | System.Data.SqlServerCe.ResultSetOptions.Sensitive | System.Data.SqlServerCe.ResultSetOptions.Updatable;

            strConnectionString = "Data Source =" + DatabasefilePath + ";Password=" + password + ";Persist Security Info=True";

            try
            {
                m_mySqlCeConnection = new SqlCeConnection(strConnectionString);
            }

            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public static void OpenSqlCompactConnection()
        {
            try
            {
                m_mySqlCeConnection.Open();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void CloseSqlCompactConnection()
        {
            try
            {
                m_mySqlCeConnection.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static SqlCeResultSet GetResultSet(string source, string fieldList, string filter, string sortFields)
        {
            SqlCeResultSet objSqlceResultset = null;

            try
            {
                m_mySqlCeConnection.Open();
            }
            catch
            {
            }

            try
            {
                SqlCeCommand sqlCeSelectCommand = null;

                sqlCeSelectCommand = m_mySqlCeConnection.CreateCommand();
                sqlCeSelectCommand.CommandType = System.Data.CommandType.Text;
                sqlCeSelectCommand.Prepare();


                sqlCeSelectCommand.CommandText = "select " + fieldList + " From " + source;
                if (filter != "")
                    sqlCeSelectCommand.CommandText += " Where " + filter;
                if (sortFields != "")
                    sqlCeSelectCommand.CommandText += " Order By " + sortFields;


                //sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable, objSqlceResultset);


                objSqlceResultset = sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable);
                //m_mySqlCeConnection.Close();

            }
            catch (Exception ex)
            {
                objSqlceResultset = null;
            }

            return objSqlceResultset;
        }

        public static SqlCeResultSet GetResultSetOfQuery(string strQuery)
        {
            SqlCeResultSet objSqlceResultset = null;

            try
            {
                m_mySqlCeConnection.Open();
            }
            catch
            {
            }

            try
            {
                SqlCeCommand sqlCeSelectCommand = null;

                sqlCeSelectCommand = m_mySqlCeConnection.CreateCommand();
                sqlCeSelectCommand.CommandType = System.Data.CommandType.Text;
                sqlCeSelectCommand.CommandText = strQuery;
                objSqlceResultset = sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable);

            }
            catch (Exception ex)
            {
            }

            return objSqlceResultset;
        }


        public static void ExecuteNonQuery(string strQuery, SqlCeParameter[] myParameters)
        {

            try
            {
                m_mySqlCeConnection.Open();
            }
            catch
            {
            }

            try
            {
                SqlCeCommand myCommand = null;
                myCommand = m_mySqlCeConnection.CreateCommand();
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandText = strQuery;
                myCommand.Parameters.AddRange(myParameters);
                //sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable, objSqlceResultset);
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void ExecuteNonQuery2(string strQuery)
        {

            try
            {
                m_mySqlCeConnection.Open();
            }
            catch
            {
            }

            try
            {
                SqlCeCommand myCommand = null;
                myCommand = m_mySqlCeConnection.CreateCommand();
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandText = strQuery;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public static object GetFieldValue(string source, string fieldName, string filter)
        {
            object objRes = null;

            try
            {
                m_mySqlCeConnection.Open();
            }
            catch
            {
            }

            try
            {
                SqlCeCommand sqlCeSelectCommand = null;

                sqlCeSelectCommand = m_mySqlCeConnection.CreateCommand();
                sqlCeSelectCommand.CommandType = System.Data.CommandType.Text;
                sqlCeSelectCommand.CommandText = "select " + fieldName + " From " + source;
                if (filter != "")
                    sqlCeSelectCommand.CommandText += " Where " + filter;

                objRes = sqlCeSelectCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                objRes = null;
            }

            return objRes;

        }

        public static void RepairDatabase()
        {
            try
            {
                CloseSqlCompactConnection();
            }
            catch
            {
            }

            SqlCeEngine myEngine = new SqlCeEngine(m_mySqlCeConnection.ConnectionString);
            myEngine.Repair(m_mySqlCeConnection.ConnectionString, RepairOption.DeleteCorruptedRows);
            myEngine.Compact(m_mySqlCeConnection.ConnectionString);
            
        }


    }
}
