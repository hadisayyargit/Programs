using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using OpenNETCF.Desktop.Communication;

namespace SmartVisitClient
{
    public class SmartBusiness
    {
        public static decimal m_Visitorsn = 0;
        public static string m_VisitorPassword = "";
        public static decimal m_Usersn = 0;

        public static DataSet dsOrder = new DataSet();
        public static DataTable dtDarkhast = new DataTable("pdDarkhast");
        public static DataTable dtDarkhastha = new DataTable("pdDarkhastha");
        public static DataTable dtDarkhastMarjoo = new DataTable("pdDarkhastMarjoo");
        public static DataTable dtDarkhastMarjooha = new DataTable("pdDarkhastMarjooha");


        public static string m_DeviceDbPath = "";
        public static string m_ClientTempDbPath = "";
        public static int m_Repeated = 0;

        public static void ReceiveDbFile()
        {
            RAPI objRapi = new RAPI();


            try
            {
                //System.IO.File.Copy(txtDbPath.Text + "\\DigitalVisit.sdf", "\\DigitalVisit.sdf");

                string strSrc = m_DeviceDbPath + "\\DigitalVisit.sdf";
                string strTarget = m_ClientTempDbPath + "\\DigitalVisit.sdf";

                objRapi.Connect();

                while (!objRapi.DevicePresent)
                {
                    //MessageBox.Show("لطفا اتصالات دستگاه را بررسی نمایید", "قطع اتصال");
                   
                    objRapi.Connect();
                }

                objRapi.CopyFileFromDevice(strTarget, strSrc, true);
                //objRapi.Disconnect();


            }

            catch
            {
                throw;
            }

        }

        public static void SendDbFile()
        {
            RAPI objRapi = new RAPI();


            try
            {
                string strSrc = m_DeviceDbPath + "\\DigitalVisit.sdf";
                string strTarget = m_ClientTempDbPath + "\\DigitalVisit.sdf";

                objRapi.Connect();

                while (!objRapi.DevicePresent)
                {
                    //MessageBox.Show("لطفا اتصالات دستگاه را بررسی نمایید", "قطع اتصال");
                    objRapi.Connect();
                }

                objRapi.CopyFileToDevice(strTarget, strSrc, true);
                //objRapi.Disconnect();
            }

            catch
            {
                throw;
            }

        }
  
        public static void ReadDarkhast()
        {
            dtDarkhast.Rows.Clear();
            dtDarkhastha.Rows.Clear();
            dtDarkhastMarjoo.Rows.Clear();
            dtDarkhastMarjooha.Rows.Clear();

            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = SqlMobile.GetResultSet("pdDarkhast", "*", "", "");

            

            dtDarkhast.Load(objSqlceResultset, LoadOption.Upsert);

            objSqlceResultset = SqlMobile.GetResultSet("pdDarkhastha", "*", "", "");
            dtDarkhastha.Load(objSqlceResultset, LoadOption.Upsert);

            

            objSqlceResultset = SqlMobile.GetResultSet("pdDarkhastMarjoo", "*", "", "");
            dtDarkhastMarjoo.Load(objSqlceResultset, LoadOption.Upsert);

            objSqlceResultset = SqlMobile.GetResultSet("pdDarkhastMarjooha", "*", "", "");
            dtDarkhastMarjooha.Load(objSqlceResultset, LoadOption.Upsert);

            //SqlMobile.CloseSqlCompactConnection();
        }

        public static void PrepareMainConnection()
        {
            try
            {
                string strPath;

                //strPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\DigitalVisit.sdf";
                strPath = m_ClientTempDbPath + "\\DigitalVisit.sdf";

                ////strPath=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                SqlMobile.InitConnection(strPath, "7");
                SqlMobile.OpenSqlCompactConnection();
                SqlMobile.CloseSqlCompactConnection();

            }
            catch
            {
                throw;
            }

        }

        public static void ReadVisitorInfo()
        {
            try
            {
                m_Visitorsn = Convert.ToDecimal(SqlMobile.GetFieldValue("pdVisitor", "visitorsn", ""));
                m_Usersn = Convert.ToDecimal(SqlMobile.GetFieldValue("pdVisitor", "usersn", ""));
            }
            catch
            {
            }

            try
            {
                m_VisitorPassword = SqlMobile.GetFieldValue("pdUser", "password", "").ToString();
            }
            catch
            {
            }
        }

        public static void WriteDarkhast()
        {

            try
            {
                try
                {
                    dpData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                SqlDataAdapter objDataAdapter = new SqlDataAdapter();
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = dpData.m_PrimaryConnection;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "_pdSP_Darkhast_Insert";
                m_Repeated = 0;

                for (int i = 0; i < dtDarkhast.Rows.Count; i++)
                {
                    objCommand.Parameters.Clear();
                    SqlParameter objSqlParameter = new SqlParameter("@SerialId", SqlDbType.BigInt);
                    objSqlParameter.Direction = ParameterDirection.Output;
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@DarkhastSn", dtDarkhast.Rows[i]["DarkhastSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@VisitorSn", dtDarkhast.Rows[i]["VisitorSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@NoetahvilSn", dtDarkhast.Rows[i]["NoetahvilSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@NoepardakhtSn", dtDarkhast.Rows[i]["NoepardakhtSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@MoshtariInfoSn", dtDarkhast.Rows[i]["MoshtariInfoSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@DarkhastDate", dtDarkhast.Rows[i]["DarkhastDate"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@VahedetejariSn", dtDarkhast.Rows[i]["VahedetejariSn"]);
                    objCommand.Parameters.Add(objSqlParameter);


                    objCommand.ExecuteNonQuery();

                    long nDarkhastSerialId = Convert.ToInt64(objCommand.Parameters["@SerialId"].Value);

                    if (nDarkhastSerialId == 0)
                    {
                        m_Repeated++;

                    }
                    else
                    {
                        WriteDarkhastha(Convert.ToDecimal(dtDarkhast.Rows[i]["DarkhastSn"]), nDarkhastSerialId);
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void WriteDarkhastha(decimal darkhastsn, long darkhastserialid)
        {

            try
            {
                try
                {
                    dpData.m_PrimaryConnection.Open();
                }
                catch
                {
                }
                SqlDataAdapter objDataAdapter = new SqlDataAdapter();


                ///بهتر است از این دستور استفاده کنیم
                ///dtDarkhastha.Select("DarkhastSn=" + darkhastsn.ToString());

                dtDarkhastha.DefaultView.RowFilter = "DarkhastSn=" + darkhastsn.ToString();
                DataView dv1 = dtDarkhastha.DefaultView;
                DataTable dt1 = new DataTable("pdDarkhastha");
                dt1 = dv1.ToTable();

                //dt1.Columns.Add("darkhastserialid", System.Type.GetType("System.Int64"));


                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = dpData.m_PrimaryConnection;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "_pdSP_Darkhastha_Insert";
                objDataAdapter.TableMappings.Add("pdDarkhastha", "pdDarkhastha");

                SqlParameter objSqlParameter = new SqlParameter("@SerialId", SqlDbType.BigInt);
                objSqlParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlParameter("@DarkhastSerialId", SqlDbType.BigInt);
                objSqlParameter.Value = darkhastserialid;
                //objSqlParameter.SourceColumn = "DarkhastSerialId";
                objCommand.Parameters.Add(objSqlParameter);
                objSqlParameter = new SqlParameter("@KalaSn", SqlDbType.Decimal, 18, "KalaSn");
                objCommand.Parameters.Add(objSqlParameter);
                objSqlParameter = new SqlParameter("@Tedad", SqlDbType.Int);
                objSqlParameter.SourceColumn = "tedad";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(dt1);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void WriteDarkhastMarjoo()
        {

            try
            {
                try
                {
                    dpData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                SqlDataAdapter objDataAdapter = new SqlDataAdapter();
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = dpData.m_PrimaryConnection;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "_pdSP_Darkhast_Insert";
                m_Repeated = 0;

                for (int i = 0; i < dtDarkhastMarjoo.Rows.Count; i++)
                {
                    objCommand.Parameters.Clear();
                    SqlParameter objSqlParameter = new SqlParameter("@SerialId", SqlDbType.BigInt);
                    objSqlParameter.Direction = ParameterDirection.Output;
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@DarkhastSn", dtDarkhastMarjoo.Rows[i]["DarkhastMarjooSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@VisitorSn", dtDarkhastMarjoo.Rows[i]["VisitorSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@factormarjoono", dtDarkhastMarjoo.Rows[i]["factormarjoono"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@dalilmarjoo", dtDarkhastMarjoo.Rows[i]["dalilmarjoo"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@MoshtariInfoSn", dtDarkhastMarjoo.Rows[i]["MoshtariInfoSn"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@DarkhastDate", dtDarkhastMarjoo.Rows[i]["DarkhastMarjooDate"]);
                    objCommand.Parameters.Add(objSqlParameter);
                    objSqlParameter = new SqlParameter("@VahedetejariSn", dtDarkhastMarjoo.Rows[i]["VahedetejariSn"]);
                    objCommand.Parameters.Add(objSqlParameter);


                    objCommand.ExecuteNonQuery();

                    long nDarkhastSerialId = Convert.ToInt64(objCommand.Parameters["@SerialId"].Value);

                    if (nDarkhastSerialId == 0)
                    {
                        m_Repeated++;

                    }
                    else
                    {
                        WriteDarkhastMarjooha(Convert.ToDecimal(dtDarkhastMarjoo.Rows[i]["DarkhastMarjooSn"]), nDarkhastSerialId);
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void WriteDarkhastMarjooha(decimal darkhastmarjoosn, long darkhastserialid)
        {

            try
            {
                try
                {
                    dpData.m_PrimaryConnection.Open();
                }
                catch
                {
                }
                SqlDataAdapter objDataAdapter = new SqlDataAdapter();

                dtDarkhastMarjooha.DefaultView.RowFilter = "DarkhastMarjooSn=" + darkhastmarjoosn.ToString();
                DataView dv1 = dtDarkhastMarjooha.DefaultView;
                DataTable dt1 = new DataTable("pdDarkhastMarjooha");
                dt1 = dv1.ToTable();

                //dt1.Columns.Add("darkhastserialid", System.Type.GetType("System.Int64"));


                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = dpData.m_PrimaryConnection;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "_pdSP_Darkhastha_Insert";
                objDataAdapter.TableMappings.Add("pdDarkhastha", "pdDarkhastMarjooha");

                SqlParameter objSqlParameter = new SqlParameter("@SerialId", SqlDbType.BigInt);
                objSqlParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlParameter("@DarkhastSerialId", SqlDbType.BigInt);
                objSqlParameter.Value = darkhastserialid;
                //objSqlParameter.SourceColumn = "DarkhastSerialId";
                objCommand.Parameters.Add(objSqlParameter);
                objSqlParameter = new SqlParameter("@KalaSn", SqlDbType.Decimal, 18, "KalaSn");
                objCommand.Parameters.Add(objSqlParameter);
                objSqlParameter = new SqlParameter("@Tedad", SqlDbType.Int);
                objSqlParameter.SourceColumn = "tedad";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(dt1);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void Upload_VahedeTejari()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdVahedetejari");
            
            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_VahedeTejari", "*", "", "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdVahedetejari", "pdVahedetejari");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdVahedetejari(vahedetejarisn,vahedetejarids) Values(@vahedetejarisn,@vahedetejarids)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@vahedetejarisn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "vahedetejarisn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@vahedetejarids", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "vahedetejarids";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_NoeTahvil()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdNoeTahvil");

            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_NoeTahvil", "*", "", "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter = new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdNoeTahvil", "pdNoeTahvil");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdNoeTahvil(noetahvilsn,noetahvilds) Values(@noetahvilsn,@noetahvilds)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@noetahvilsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "noetahvilsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@noetahvilds", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "noetahvilds";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_TaminKonandeh()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdTaminKonandeh");

            try
            {
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("@Visitorsn", m_Visitorsn);

                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "_pdSPG_TaminKonandeh", myParameters).DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter = new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdTaminKonandeh", "pdTaminKonandeh");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdTaminKonandeh(taminkonandehsn,taminkonandehds) Values(@taminkonandehsn,@taminkonandehds)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@taminkonandehsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "taminkonandehsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@taminkonandehds", SqlDbType.NVarChar, 100);
                objSqlParameter.SourceColumn = "taminkonandehds";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_KanaleForoosh()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdKanaleForoosh");

            try
            {
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("@Visitorsn", m_Visitorsn);

                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "_pdSPG_KanaleForoosh", myParameters).DefaultView;
                
                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter = new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdKanaleForoosh", "pdKanaleForoosh");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdKanaleForoosh(kanaleforooshsn,kanaleforooshds,kanaleforooshno) Values(@kanaleforooshsn,@kanaleforooshds,@kanaleforooshno)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@kanaleforooshsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "kanaleforooshsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@kanaleforooshds", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "kanaleforooshds";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@kanaleforooshno", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "kanaleforooshno";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_GorooheKala()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdGorooheKala");
            
            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_GorooheKala", "*", "", "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdGorooheKala", "pdGorooheKala");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdGorooheKala(goroohekalasn,goroohekalads) Values(@goroohekalasn,@goroohekalads)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@goroohekalasn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "goroohekalasn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@goroohekalads", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "goroohekalads";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_Kala()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdKala");
            
            try
            {
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("@Visitorsn", m_Visitorsn);

                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "_pdSPG_Kala", myParameters).DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdKala", "pdKala");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdKala(kalasn,kalads,forooshcode,taminkonandehsn,imagepath,goroohekalasn) Values(@kalasn,@kalads,@forooshcode,@taminkonandehsn,@imagepath,@goroohekalasn)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@kalasn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "kalasn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@kalads", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "kalads";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@forooshcode", SqlDbType.Int);
                objSqlParameter.SourceColumn = "forooshcode";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@taminkonandehsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "taminkonandehsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@imagepath", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "imagepath";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@goroohekalasn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "goroohekalasn";
                objCommand.Parameters.Add(objSqlParameter);
                
                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_KalaInfo()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdKalaInfo");
            
            try
            {
                SqlParameter[] myParameters=new SqlParameter[1];
                myParameters[0] = new SqlParameter("@Visitorsn", m_Visitorsn);

                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "_pdSPG_KalaInfo",myParameters).DefaultView;
                

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdKalaInfo", "pdKalaInfo");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdKalaInfo( kalasn, nerkheforoosh, nerkhemasraf, mindarkhastkala, mojoodi, kalastatus, vahedesanjeshds)"
                        + " Values(@kalasn, @nerkheforoosh, @nerkhemasraf, @mindarkhastkala, @mojoodi, @kalastatus, @VahedeSanjeshDs)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@kalasn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "kalasn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@nerkheforoosh", SqlDbType.Int);
                objSqlParameter.SourceColumn = "nerkheforoosh";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@nerkhemasraf", SqlDbType.Int);
                objSqlParameter.SourceColumn = "nerkhemasraf";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mindarkhastkala", SqlDbType.Int);
                objSqlParameter.SourceColumn = "mindarkhastkala";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mojoodi", SqlDbType.Int);
                objSqlParameter.SourceColumn = "mojoodi";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@kalastatus", SqlDbType.TinyInt);
                objSqlParameter.SourceColumn = "kalastatus";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@VahedeSanjeshDs", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "vahedesanjeshds";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_KalaPayam()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdKalaPayam");
            
            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_KalaPayam", "*", "", "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdKalaPayam", "pdKalaPayam");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdKalaPayam(kalasn,payamds) Values(@kalasn,@payamds)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@kalasn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "kalasn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@payamds", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "payamds";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_Visitor()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdVisitor");
            
            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_Visitor", "*", "visitorsn=" + m_Visitorsn.ToString(), "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter=new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdVisitor", "pdVisitor");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdVisitor(visitorsn,usersn,mobilephone,vahedetejarisn) Values(@visitorsn,@usersn,@mobilephone,@vahedetejarisn)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@visitorsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "visitorsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@usersn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "usersn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mobilephone", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "mobilephone";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@vahedetejarisn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "vahedetejarisn";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_User()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdUser");

            try
            {
                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_Visitor", "*", "visitorsn=" + m_Visitorsn.ToString(), "").DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter = new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdUser", "pdUser");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                objCommand.CommandText = "insert into pdUser(usersn,username,userno,password,userstatus,usertypesn) Values(@usersn,@username,@userno,'" + m_VisitorPassword + "',1,1)";

                SqlCeParameter objSqlParameter = new SqlCeParameter("@usersn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "usersn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@username", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "visitorname";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@userno", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "visitorno";
                objCommand.Parameters.Add(objSqlParameter);


                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static void Upload_Moshtari()
        {
            DataView myView = new DataView();
            DataTable myTable = new DataTable("pdMoshtari");

            try
            {
                SqlParameter[] myParameters = new SqlParameter[1];
                myParameters[0] = new SqlParameter("@Visitorsn", m_Visitorsn);

                myView = dpData.GetDataTable(dpData.m_PrimaryConnection, "_pdSPG_Moshtari", myParameters).DefaultView;

                myTable = myView.ToTable();
                SqlCeDataAdapter objDataAdapter = new SqlCeDataAdapter();

                try
                {
                    SqlMobile.OpenSqlCompactConnection();
                }
                catch
                {
                }

                objDataAdapter.TableMappings.Add("pdMoshtari", "pdMoshtari");
                SqlCeCommand objCommand = new SqlCeCommand();
                objCommand.Connection = SqlMobile.m_mySqlCeConnection;
                
                objCommand.CommandText = "insert into pdMoshtari(moshtariinfosn,moshtarids,moshtarino,vahedetejarisn,kanaleforooshsn,countbargashti,mandehmoavagh"
                                    + ",countmoavagh,mandehetebar,mandehbargashti,mandehasnadi,masirno,moshtaristatus,latitude,longitude,usersn,address,tel,mobilephone)"
                                    + " Values(@moshtariinfosn,@moshtarids,@moshtarino,@vahedetejarisn,@kanaleforooshsn,@countbargashti,@mandehmoavagh"
                                    + ",@countmoavagh,@mandehetebar,@mandehbargashti,@mandehasnadi,@masirno,@moshtaristatus,@latitude,@longitude"
                                    + ",@usersn,@address,@tel,@mobilephone)";

                

                SqlCeParameter objSqlParameter = new SqlCeParameter("@moshtariinfosn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "moshtariinfosn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@moshtarids", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "moshtarids";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@moshtarino", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "moshtarino";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@vahedetejarisn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "vahedetejarisn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@kanaleforooshsn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "kanaleforooshsn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@masirno", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "masirno";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@moshtaristatus", SqlDbType.TinyInt);
                objSqlParameter.SourceColumn = "moshtaristatus";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@latitude", SqlDbType.Float);
                objSqlParameter.SourceColumn = "latitude";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@longitude", SqlDbType.Float);
                objSqlParameter.SourceColumn = "longitude";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@usersn", SqlDbType.Decimal);
                objSqlParameter.SourceColumn = "usersn";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@address", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "address";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@tel", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "tel";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mobilephone", SqlDbType.NVarChar);
                objSqlParameter.SourceColumn = "mblphone";
                objCommand.Parameters.Add(objSqlParameter);
                
                objSqlParameter = new SqlCeParameter("@countbargashti", SqlDbType.Int);
                objSqlParameter.SourceColumn = "countbargashti";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@countmoavagh", SqlDbType.Int);
                objSqlParameter.SourceColumn = "countmoavagh";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mandehmoavagh", SqlDbType.BigInt);
                objSqlParameter.SourceColumn = "mandehmoavagh";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mandehetebar", SqlDbType.BigInt);
                objSqlParameter.SourceColumn = "mandehetebar";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mandehbargashti", SqlDbType.BigInt);
                objSqlParameter.SourceColumn = "mandehbargashti";
                objCommand.Parameters.Add(objSqlParameter);

                objSqlParameter = new SqlCeParameter("@mandehasnadi", SqlDbType.BigInt);
                objSqlParameter.SourceColumn = "mandehasnadi";
                objCommand.Parameters.Add(objSqlParameter);

                objDataAdapter.InsertCommand = objCommand;
                objDataAdapter.Update(myTable);

            }

            catch
            {
                throw;
            }
        }

        public static DataView GetAllVisitor()
        {
            DataView myView = new DataView();
            myView=dpData.GetDataTable(dpData.m_PrimaryConnection, "pdVw_Visitor", "*", "", "").DefaultView;

            return myView;
        }

        public static void DeleteData(string tablename)
        {
            try
            {
                SqlMobile.ExecuteNonQuery2("delete " + tablename);

            }
            catch
            {
                throw;
            }
        }

    }
}
