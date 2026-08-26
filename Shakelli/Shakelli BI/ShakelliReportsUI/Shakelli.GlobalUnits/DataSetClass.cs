using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace GlobalUnits
{
    public class DatasetClass
    {

        public static void ExecuteMyQuery(SqlConnection myConnection, string strQuery, SqlTransaction trans = null)
        {
            SqlCommand myCommand = new SqlCommand(strQuery, myConnection, trans);

            myCommand.CommandTimeout = 300;

            try
            {
                try
                {
                    myConnection.Open();
                }
                catch
                {
                }

                int n = myCommand.ExecuteNonQuery();

                ///نباید بسته شود به دلیل باز بودن تراکنش
                //CloseConnection();
            }

            catch
            {
                throw;
            }

        }

        public static void FillDataSet(SqlConnection myConnection, DataTable dt, string strQuery)
        {
            SqlCommand myCommand = new SqlCommand();
            SqlDataAdapter myAdapter = new SqlDataAdapter();

            try
            {
                myConnection.Open();
            }
            catch
            {
            }

            myCommand.CommandText = strQuery;
            myCommand.Connection = myConnection;
            myAdapter.SelectCommand = myCommand;
            myAdapter.Fill(dt);
        }

        public static void FillDataSetFromXmlStatement(DataSet ds, string XmlStatement)
        {
            XmlReader myXmlReader;
            StringReader myStringReader = new StringReader(XmlStatement);

            myXmlReader = XmlReader.Create(myStringReader);

            ds.ReadXml(myXmlReader);

        }

        /// <summary>
        /// stored proc which no value returns
        /// </summary>
        /// <param name="myConnection"></param>
        /// <param name="ProcedureName"></param>
        /// <param name="myParameters"></param>
        /// <param name="trans"></param>
        public static void ExecuteStoredProcedure(SqlConnection myConnection, string ProcedureName, SqlParameter[] myParameters, SqlTransaction trans = null)
        {
            SqlCommand myCommand = new SqlCommand(ProcedureName, myConnection);

            if (trans != null)
                myCommand = new SqlCommand(ProcedureName, myConnection, trans);

            myCommand.CommandTimeout = 300;
            myCommand.CommandType = CommandType.StoredProcedure;

            if (myParameters != null)
                myCommand.Parameters.AddRange(myParameters);

            try
            {

                try
                {
                    myConnection.Open();
                }
                catch
                {
                }

                int n = myCommand.ExecuteNonQuery();

                if (trans == null)
                    try
                    {
                        myConnection.Close();
                    }
                    catch
                    {
                    }
            }

            catch
            {
                throw;
            }
        }

        /// <summary>
        /// stored proc which returns table
        /// </summary>
        /// <param name="myConnection"></param>
        /// <param name="ProcedureName"></param>
        /// <param name="myParameters"></param>
        /// <param name="ds"></param>
        /// <param name="trans"></param>
        public static void ExecuteStoredProcedure(SqlConnection myConnection, string ProcedureName, SqlParameter[] myParameters, DataSet ds, SqlTransaction trans = null)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Transaction = trans;

            SqlDataAdapter myAdapter = new SqlDataAdapter();

            try
            {
                myConnection.Open();
            }
            catch
            {
            }

            myCommand.CommandTimeout = 300;
            myCommand.CommandText = ProcedureName;
            myCommand.Connection = myConnection;
            if (myParameters != null)
                myCommand.Parameters.AddRange(myParameters);

            myAdapter.SelectCommand = myCommand;

            myCommand.CommandType = CommandType.StoredProcedure;

            myAdapter.Fill(ds);

        }

        /// <summary>
        /// Hadi
        /// 
        /// </summary>
        /// <param name="myConnection"></param>
        /// <param name="sourceTableName"></param>
        /// <param name="myDataset"></param>
        /// <param name="procedureName"></param>
        /// <param name="myParameters"></param>
        public static int UpdateBatch(SqlConnection myConnection, string sourceTableName, DataSet myDataset, string procedureName = null, List<SqlParameter> myParameters = null)
        {
            int nRes = 0;

            SqlDataAdapter myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();

            try
            {
                myConnection.Open();
            }
            catch
            {
            }

            myCommand.Connection = myConnection;

            ///mapping between DataTable and database table
            myAdapter.TableMappings.Add(sourceTableName, myDataset.Tables[0].TableName);

            for (int i = 0; i < myDataset.Tables[0].Columns.Count; i++)
                myAdapter.TableMappings[0].ColumnMappings.Add(myDataset.Tables[0].Columns[i].ColumnName, myDataset.Tables[0].Columns[i].ColumnName);


            try
            {
                foreach (DataRow r in myDataset.Tables[0].Rows)
                    r.SetAdded();
            }
            catch
            {
            }

            /// if we have stored procedure: 
            if (procedureName != null)
            {
                myCommand.CommandText = procedureName;
                myCommand.CommandType = CommandType.StoredProcedure;
                ///parameters without value
                myCommand.Parameters.AddRange(myParameters.ToArray<SqlParameter>());
                myAdapter.InsertCommand = myCommand;

            }
            else
            {
                /// if we dont have stored procedure: 
                myAdapter.SelectCommand = new SqlCommand("select * from " + sourceTableName, myConnection);
                myAdapter.InsertCommand = (new SqlCommandBuilder(myAdapter)).GetInsertCommand(true);
            }

            try
            {
                nRes = myAdapter.Update(myDataset, sourceTableName);
            }
            catch
            {
                throw;
            }

            return nRes;

        }

    }
}


