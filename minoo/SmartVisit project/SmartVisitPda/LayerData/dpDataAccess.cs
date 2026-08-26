using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.ComponentModel;
using System.Reflection;

namespace layerData
{
    public class dpDataAccess
    {

        #region Database

        
        public static SqlCeConnection m_mySqlCeConnection=null;
                         
        public static void InitConnection(string DatabasefilePath, string password)
        {
            string strConnectionString;

            ResultSetOptions rso = System.Data.SqlServerCe.ResultSetOptions.Scrollable | System.Data.SqlServerCe.ResultSetOptions.Sensitive | System.Data.SqlServerCe.ResultSetOptions.Updatable;

            strConnectionString = "Data Source =" + DatabasefilePath + ";Password=" + password + ";Persist Security Info=True";

            try
            {
                m_mySqlCeConnection = new SqlCeConnection(strConnectionString);
            }
            
            catch(Exception ex)            
            {
                throw (ex);
            }            
        }

        public static void OpenSqlCompactConnection()
        {
            if (m_mySqlCeConnection.State == ConnectionState.Closed)
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
        }

        public static void CloseSqlCompactConnection()
        {
            if (m_mySqlCeConnection.State != ConnectionState.Closed)
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
        }

        public static SqlCeResultSet GetResultSet(string source, string fieldList, string filter, string sortFields)
        {
            SqlCeResultSet objSqlceResultset=null;

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

        public static SqlCeDataReader GetReaderOfQuery(string strQuery)
        {
            SqlCeDataReader dr1 = null;
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
                dr1 = sqlCeSelectCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
            }

            return dr1;
        }

        public static void ExecuteNonQuery(string strQuery, SqlCeParameter[] myParameters )
        {
            string strRes = "";

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
                myCommand.CommandText =strQuery;
                myCommand.Parameters.AddRange( myParameters);
                //sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable, objSqlceResultset);
                myCommand.ExecuteNonQuery();
                
            }
            catch
            {
                throw;
            }

        }

        public static void ExecuteNonQuery(string strQuery)
        {
            string strRes = "";

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
            catch
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
               
        #endregion
    }
}
