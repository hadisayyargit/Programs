using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GlobalUnits;
using CommonUnits;

namespace EmdadMainServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GuaranteeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GuaranteeService.svc or GuaranteeService.svc.cs at the Solution Explorer and start debugging.
    public class GuaranteeService : IGuaranteeService
    {

        /// <summary>
        /// وب سرویس گارانتی بدنه
        /// </summary>
        /// <param name="strUserId">user id</param>
        /// <param name="strPassword"></param>
        /// <param name="strRequisition_Activity">مقادیر رکوردها با@ و فیلدها با ;  از هم جدا میگردند مانند 11;1134;567.89;33;1392/09/16;999@12;1234;567.89;33;1392/09/17;999</param>
        /// <param name="strRequisition_SparePart">Requisition_SparePart</param>
        /// <param name="strDamageFinalRep"></param>
        /// <returns></returns>
        public string PostGuaranteeBadaneh(string strUserId, string strPassword, string strRequisition_Activity, string strRequisition_SparePart, string strDamageFinalRep)
        {
            string strRes = "";

            DataSet dsRequisition_Activity = new DataSet(), dsRequisition_SparePart = new DataSet(), dsDamageFinalRep = new DataSet();

            dsRequisition_Activity.Tables.Add("post_REQUISITION_ACTIVITY");
            dsRequisition_SparePart.Tables.Add("post_REQUISITION_SPAREPART");
            dsDamageFinalRep.Tables.Add("post_DAMAGEFINALREP");

            dsRequisition_Activity.Tables[0].Columns.Add("REQUISITIONNO", Type.GetType("System.Int32"));
            dsRequisition_Activity.Tables[0].Columns.Add("ACTIVITYCODE", Type.GetType("System.String"));
            dsRequisition_Activity.Tables[0].Columns.Add("PRICE", Type.GetType("System.Single"));
            dsRequisition_Activity.Tables[0].Columns.Add("ACTIVITYCOUNT", Type.GetType("System.Int32"));
            dsRequisition_Activity.Tables[0].Columns.Add("InvoiceJdate", Type.GetType("System.String"));
            dsRequisition_Activity.Tables[0].Columns.Add("InvoiceStatus", Type.GetType("System.String"));
            dsRequisition_Activity.Tables[0].Columns.Add("RecordTime", Type.GetType("System.DateTime"));
            dsRequisition_Activity.Tables[0].Columns.Add("ChassisNo", Type.GetType("System.String"));
            dsRequisition_Activity.Tables[0].PrimaryKey = new DataColumn[] { dsRequisition_Activity.Tables[0].Columns["Id"] };

            dsRequisition_SparePart.Tables[0].Columns.Add("REQUISITIONNO", Type.GetType("System.Int32"));
            dsRequisition_SparePart.Tables[0].Columns.Add("SPAREPARTSERIAL", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].Columns.Add("MARQUE", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].Columns.Add("SPAREPARTCOUNT", Type.GetType("System.Int32"));
            dsRequisition_SparePart.Tables[0].Columns.Add("PRICE", Type.GetType("System.Single"));
            //dsRequisition_SparePart.Tables[0].Columns.Add("STORAGE", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].Columns.Add("InvoiceJdate", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].Columns.Add("InvoiceStatus", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].Columns.Add("RecordTime", Type.GetType("System.DateTime"));
            dsRequisition_SparePart.Tables[0].Columns.Add("ChassisNo", Type.GetType("System.String"));
            dsRequisition_SparePart.Tables[0].PrimaryKey = new DataColumn[] { dsRequisition_SparePart.Tables[0].Columns["Id"] };

            dsDamageFinalRep.Tables[0].Columns.Add("REQUISITIONNO", Type.GetType("System.Int32"));
            dsDamageFinalRep.Tables[0].Columns.Add("REFERSTATIONDATE", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].Columns.Add("FINALDATE", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].Columns.Add("InvoiceJdate", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].Columns.Add("InvoiceStatus", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].Columns.Add("RecordTime", Type.GetType("System.DateTime"));
            dsDamageFinalRep.Tables[0].Columns.Add("ChassisNo", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].Columns.Add("ADDMISSIONNO", Type.GetType("System.String"));
            dsDamageFinalRep.Tables[0].PrimaryKey = new DataColumn[] { dsDamageFinalRep.Tables[0].Columns["Id"] };

            string strRequisition_Activity1, strRequisition_SparePart1, strDamageFinalRep1;
            strRequisition_Activity1 = strRequisition_Activity;
            strRequisition_SparePart1 = strRequisition_SparePart;
            strDamageFinalRep1 = strDamageFinalRep;

            //strRequisition_Activity1 = "11;1134;567.89;33;1392/09/16;999@12;1234;567.89;33;1392/09/17;999";

            try
            {
                if (strRequisition_Activity1 != null && strRequisition_Activity1.Length > 0)
                {
                    try
                    {
                        string[] myRecordArray = strRequisition_Activity1.Split(new string[] { "@" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < myRecordArray.Count(); i++)
                        {
                            string[] myFieldArray = myRecordArray[i].Split(new string[] { ";" }, StringSplitOptions.None);

                            DataRow dr = dsRequisition_Activity.Tables[0].NewRow();

                            dr["REQUISITIONNO"] = myFieldArray[0];
                            dr["ACTIVITYCODE"] = myFieldArray[1];
                            dr["Price"] = myFieldArray[2];
                            dr["ACTIVITYCOUNT"] = myFieldArray[3];
                            dr["InvoiceJdate"] = myFieldArray[4];
                            dr["InvoiceStatus"] = myFieldArray[5];
                            dr["ChassisNo"] = myFieldArray[6];

                            if (dr["InvoiceJdate"] == "" || dr["InvoiceStatus"] == "")
                            {
                                break;
                            }

                            dsRequisition_Activity.Tables[0].Rows.Add(dr);
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.Source = "post_REQUISITION_ACTIVITY";
                        throw ex;
                    }
                }


                ///strRequisition_SparePart1=2960620;501011;500;2;500;1392/12/10;3;NAS411100D1264408@
                if (strRequisition_SparePart1 != null && strRequisition_SparePart1.Length > 0)
                {
                    try
                    {
                        string[] myRecordArray = strRequisition_SparePart1.Split(new string[] { "@" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < myRecordArray.Count(); i++)
                        {
                            //length
                            string[] myFieldArray = myRecordArray[i].Split(new string[] { ";" }, StringSplitOptions.None);

                            DataRow dr = dsRequisition_SparePart.Tables[0].NewRow();

                            dr["REQUISITIONNO"] = myFieldArray[0];
                            dr["SPAREPARTSERIAL"] = myFieldArray[1];
                            dr["MARQUE"] = myFieldArray[2];
                            dr["SPAREPARTCOUNT"] = myFieldArray[3];
                            dr["PRICE"] = myFieldArray[4];
                            //dr["STORAGE"] = myFieldArray[5];
                            dr["InvoiceJdate"] = myFieldArray[5];
                            dr["InvoiceStatus"] = myFieldArray[6];
                            dr["ChassisNo"] = myFieldArray[7];

                            if (dr["InvoiceJdate"] == "" || dr["InvoiceStatus"] == "")
                            {
                                break;
                            }

                            dsRequisition_SparePart.Tables[0].Rows.Add(dr);
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.Source = "post_REQUISITION_SPAREPART";
                        throw ex;
                    }

                }

                if (strDamageFinalRep1 != null && strDamageFinalRep1.Length > 0)
                {
                    try
                    {
                        string[] myRecordArray = strDamageFinalRep1.Split(new string[] { "@" }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < myRecordArray.Count(); i++)
                        {
                            //length
                            string[] myFieldArray = myRecordArray[i].Split(new string[] { ";" }, StringSplitOptions.None);

                            DataRow dr = dsDamageFinalRep.Tables[0].NewRow();

                            dr["REQUISITIONNO"] = myFieldArray[0];
                            dr["REFERSTATIONDATE"] = myFieldArray[1];
                            dr["FINALDATE"] = myFieldArray[2];
                            dr["InvoiceJdate"] = myFieldArray[3];
                            dr["InvoiceStatus"] = myFieldArray[4];                            
                            dr["ChassisNo"] = myFieldArray[5];
                            dr["ADDMISSIONNO"] = myFieldArray[6];
                            
                            if (dr["InvoiceJdate"] == "" || dr["InvoiceStatus"] == "")
                            {
                                break;
                            }

                            dsDamageFinalRep.Tables[0].Rows.Add(dr);
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.Source = "post_DAMAGEFINALREP";
                        throw ex;
                    }

                }

                strRes = PostGuaranteeBadaneh2(strUserId, strPassword, dsRequisition_Activity.Tables[0].DataSet, dsRequisition_SparePart.Tables[0].DataSet, dsDamageFinalRep.Tables[0].DataSet);
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format"))
                    strRes = "-4;" + "قالب رشته ورودی اشتباه است" + ";" + ex.Message;
                else
                    strRes = "-5;" + strRes + ";" + ex.Message;
            }

            return strRes;

        }

        public string PostGuaranteeBadaneh2(string strUserId, string strPassword, DataSet dsRequisition_Activity, DataSet dsRequisition_SparePart, DataSet dsDamageFinalRep)
        {
            string strRes = "";
            List<SqlParameter> myParameters = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["GuaranteeConnection"].ConnectionString;

            Authentication objAuthentication = new Authentication();
            strRes = objAuthentication.IsValidUser(strUserId, strPassword, conn.ConnectionString);
            if (strRes == "ok")
            {
                strRes = "";

                //writeLog("", "");

                try
                {
                    if (dsRequisition_Activity.Tables.Count > 0)
                    {
                        string s = "";

                        foreach (DataRow dr in dsRequisition_Activity.Tables[0].Rows)
                        {
                            s += "," + dr["REQUISITIONNO"];
                        }

                        if (s.StartsWith(","))
                            s = s.Remove(0, 1);

                        try
                        {
                            DatasetClass.ExecuteMyQuery(conn, "delete from post_REQUISITION_ACTIVITY where REQUISITIONNO in (" + s + ")");
                        }
                        catch
                        {
                        }

                        int nRes = DatasetClass.UpdateBatch(conn, "post_REQUISITION_ACTIVITY", dsRequisition_Activity);
                        strRes = "0;" + strRes + "; post_REQUISITION_ACTIVITY :" + nRes.ToString() + " رکورد افزوده شد";
                    }

                    if (dsRequisition_SparePart.Tables.Count > 0)
                    {
                        string s = "";

                        foreach (DataRow dr in dsRequisition_SparePart.Tables[0].Rows)
                        {
                            s += "," + dr["REQUISITIONNO"];
                        }

                        if (s.StartsWith(","))
                            s = s.Remove(0, 1);

                        try
                        {
                            DatasetClass.ExecuteMyQuery(conn, "delete from post_REQUISITION_SPAREPART where REQUISITIONNO in (" + s + ")");
                        }
                        catch
                        {
                        }

                        int nRes = DatasetClass.UpdateBatch(conn, "post_REQUISITION_SPAREPART", dsRequisition_SparePart);
                        strRes = "0;" + strRes + "; post_REQUISITION_SPAREPART :" + nRes.ToString() + " رکورد افزوده شد";
                    }

                    if (dsDamageFinalRep.Tables.Count > 0)
                    {
                        string s = "";

                        foreach (DataRow dr in dsDamageFinalRep.Tables[0].Rows)
                        {
                            s += "," + dr["REQUISITIONNO"];
                        }

                        if (s.StartsWith(","))
                            s = s.Remove(0, 1);

                        try
                        {
                            DatasetClass.ExecuteMyQuery(conn, "delete from post_DAMAGEFINALREP where REQUISITIONNO in (" + s + ")");
                        }
                        catch
                        {
                        }
                        int nRes = DatasetClass.UpdateBatch(conn, "post_DAMAGEFINALREP", dsDamageFinalRep);
                        strRes = "0;" + strRes + "; post_DAMAGEFINALREP :" + nRes.ToString() + " رکورد افزوده شد";
                    }
                }

                catch (Exception ex)
                {
                    strRes = "-5;" + strRes + ";" + ex.Message;
                }
            }

            return strRes;

        }

        public void writeLog(string strUserId, string strPassword)
        {

            string strRes = "None";
            List<SqlParameter> myParameters = new List<SqlParameter>();

            //string strValid = IsValidUser(strUserId, strPassword,conn.ConnectionString);

            DataSet myDataset = new DataSet();

            //XmlDocument myXml = new XmlDocument();
            //myXml.LoadXml(xmlsubscriptionlist);

            //
            //if (dsInput.Tables.Count > 0)
            if (true)
            {


                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GuaranteeConnection"].ConnectionString;

                try
                {
                    conn.Open();
                }
                catch
                {
                }

                myDataset.Tables.Add();
                myDataset.Tables[0].TableName = "post_Log";

                myDataset.Tables[0].Columns.Add("RequisitionNo", Type.GetType("System.Int32"));
                myDataset.Tables[0].Columns.Add("ChassisNo", Type.GetType("System.String"));
                myDataset.Tables[0].Columns.Add("FactorJDate", Type.GetType("System.String"));
                myDataset.Tables[0].Columns.Add("Timestamp", Type.GetType("System.Byte[]"));

                DataRow dr;
                dr = myDataset.Tables[0].NewRow();

                dr["RequisitionNo"] = 12;
                dr["ChassisNo"] = "";
                dr["FactorJDate"] = "";

                myDataset.Tables[0].Rows.Add(dr);


                myParameters.Add(new SqlParameter("@RequisitionNo", SqlDbType.Int, 0, "RequisitionNo"));
                myParameters.Add(new SqlParameter("@ChassisNo", SqlDbType.VarChar, 20, "ChassisNo"));
                myParameters.Add(new SqlParameter("@FactorJDate", SqlDbType.NVarChar, 10, "FactorJDate"));
                myParameters.Add(new SqlParameter("@Timestamp", SqlDbType.VarBinary, 8, "Timestamp"));

                try
                {
                    int nRes = DatasetClass.UpdateBatch(conn, "post_Log", myDataset, "spInsert_post_Log", myParameters);

                    strRes = nRes.ToString() + " رکورد افزوده شد";


                }

                catch (Exception ex)
                {
                    throw ex;
                }

            }

            //return strRes;             
            //http://46.32.24.36:7003/EmdadMainServices.BankPasargadService.svc
            //http://46.32.24.36:7003/EmdadMainServices.GuaranteeService.svc
            //http://46.32.24.36:7003/EmdadMainServices.EcommerceService.svc
        }

    }
}
