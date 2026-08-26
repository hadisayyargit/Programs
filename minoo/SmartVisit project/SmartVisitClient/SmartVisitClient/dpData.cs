using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SmartVisitClient
{
    public class dpData
    {
        public static SqlConnection m_PrimaryConnection = new SqlConnection();
        public static SqlDataAdapter m_MyAdapter = new SqlDataAdapter();

        public static DataTable GetDataTable(SqlConnection cnn, string source, string fieldList, string filter, string sortFields)
        {
            DataTable myTable = new DataTable();
            
            SqlCommand objCommand = new SqlCommand();
            

            try
            {
                try
                {
                    m_PrimaryConnection.Open();
                }
               catch (Exception ex)
            {
                                   throw;
            }
                    
             

                objCommand.Connection = cnn;
                objCommand.CommandType = CommandType.Text;
                m_MyAdapter.SelectCommand = objCommand;
                objCommand.CommandText = "select " + fieldList + " From " + source;
                if (filter != "")
                    objCommand.CommandText += " Where " + filter;
                if (sortFields != "")
                    objCommand.CommandText += " Order By " + sortFields;

                m_MyAdapter.Fill(myTable);

            }
            catch
            {
            }

            return myTable;
        }

        public static DataTable GetDataTable(SqlConnection cnn, string source, SqlParameter[] myParameters)
        {
            DataTable myTable = new DataTable();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandTimeout = 300;

            try
            {
                try
                {
                    m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = cnn;
                objCommand.CommandType = CommandType.StoredProcedure;
                m_MyAdapter.SelectCommand = objCommand;
                objCommand.CommandText = source;
                objCommand.Parameters.AddRange(myParameters);

                m_MyAdapter.Fill(myTable);

            }
            catch
            {
                throw;
            }

            return myTable;
        }

        public static object GetFieldValue(SqlConnection cnn, string source, string fieldName, string filter)
        {
            object objRes = null;
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    m_PrimaryConnection.Open();
                }
                catch
                {
                }
                objCommand.Connection = cnn;
                objCommand.CommandType = CommandType.Text;
                m_MyAdapter.SelectCommand = objCommand;
                objCommand.CommandText = "select " + fieldName + " From " + source;
                if (filter != "")
                    objCommand.CommandText += " Where " + filter;

                objRes = objCommand.ExecuteScalar();
            }
            catch
            {
            }



            return objRes;
        }

        public static void ExecuteNonQuery(SqlConnection cnn, string strQuery)
        {
            SqlCommand objCommand = new SqlCommand();
            try
            {
                try
                {
                    m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = cnn;
                objCommand.CommandType = CommandType.Text;
                m_MyAdapter.SelectCommand = objCommand;
                objCommand.CommandText = strQuery;

                int n = objCommand.ExecuteNonQuery();
                //strRes = n.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
