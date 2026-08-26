using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;
using GlobalUnits;

namespace CommonUnits
{
    public class Subscription
    {
        public string SubscriptionCode { get; set; }//
        public string ChassisNo { get; set; }
        public string SUBSCRIPTIONYEAR { get; set; }//
        public string SUBSCRIPTIONPassWord { get; set; }//
        public string AUTOCODE { get; set; }
        public string LICENSEPLATE { get; set; }
        public string VIN { get; set; }
        public string SUBSCRIPTIONDATE { get; set; }//
        public string EXPIRATIONDATE { get; set; }//
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string TEL { get; set; }
        public string ADDRESS { get; set; }
        public string CREDIT { get; set; }//
        public string FACNO { get; set; }//
        public string NATIONALNO { get; set; }
        public string FACDATE { get; set; }//
        public string Mobile { get; set; }
        public int Sex { get; set; }
        public int City { get; set; }

        public string ExternalCode { get; set; }

        public void InsertSubscription(SqlConnection cn, SqlTransaction myTransaction, out string strResult)
            {
                try
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    this.SubscriptionCode = "0";
                    parameters.Add(new SqlParameter("@SUBSCRIPTIONCODE", this.SubscriptionCode));
                    parameters.Add(new SqlParameter("@ResultString", ""));
                    
                    parameters.Add(new SqlParameter("@AUTOCODE", this.AUTOCODE));
                    parameters.Add(new SqlParameter("@FIRSTNAME", this.FIRSTNAME));
                    parameters.Add(new SqlParameter("@LASTNAME", this.LASTNAME));
                    parameters.Add(new SqlParameter("@TEL", this.TEL));
                    parameters.Add(new SqlParameter("@ADDRESS", this.ADDRESS));
                    parameters.Add(new SqlParameter("@Mobile", this.Mobile));
                    parameters.Add(new SqlParameter("@NATIONALNO", this.NATIONALNO));
                    parameters.Add(new SqlParameter("@Sex", this.Sex));
                    parameters.Add(new SqlParameter("@City", this.City));
                    parameters.Add(new SqlParameter("@ChassisNo", this.ChassisNo));
                    parameters.Add(new SqlParameter("@LICENSEPLATE", this.LICENSEPLATE));
                    parameters.Add(new SqlParameter("@VIN", this.VIN));
                    
                    parameters[0].Direction = ParameterDirection.Output;
                    parameters[1].Direction = ParameterDirection.Output;

                    parameters[1].SqlDbType = SqlDbType.NVarChar;
                    parameters[1].Size = 100;

                    DatasetClass.ExecuteStoredProcedure(cn, "Site_InsSUBSCRIPTION_ws", parameters.ToArray<SqlParameter>(), myTransaction);

                    strResult = parameters[1].Value.ToString();

                }
                catch
                {
                    throw;
                }

            }
        }

    public class SaleInvoice
        {
            public long InvoiceId { get; set; }
            public string ChassisNo { get; set; }//
            public string AgencyCode { get; set; }
            public string InvoiceJdate { get; set; }

            //public int PayType { get; set; }
            public long Price { get; set; }
            public long Tax { get; set; }
            public long Toll { get; set; }
            public long Discount { get; set; }

            public string ExternalCode { get; set; }

            public void InsertInvoice(SqlConnection cn, SqlTransaction myTransaction)
            {
                try
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    parameters.Add(new SqlParameter("@InvoiceId", this.InvoiceId));
                    parameters.Add(new SqlParameter("@ChassisNo", this.ChassisNo));
                    parameters.Add(new SqlParameter("@AgencyCode", this.AgencyCode));
                    parameters.Add(new SqlParameter("@Price", this.Price));
                    parameters.Add(new SqlParameter("@InvoiceJdate", this.InvoiceJdate));
                    parameters.Add(new SqlParameter("@Tax", this.Tax));
                    parameters.Add(new SqlParameter("@Toll", this.Toll));
                    parameters.Add(new SqlParameter("@Discount", this.Discount));

                    parameters[0].Direction = ParameterDirection.Output;

                    DatasetClass.ExecuteStoredProcedure(cn, "spInsertSaleInvoice_ws", parameters.ToArray<SqlParameter>(), myTransaction);

                    this.InvoiceId = long.Parse(parameters[0].Value.ToString());
                }
                catch
                {
                    throw;
                }

            }
        }

    public class SaleInvoiceItem
        {
            public long InvoiceItemId { get; set; }//
            public long InvoiceId { get; set; }//
            public int PackageId { get; set; }
            public long Fee { get; set; }
            public long Tax { get; set; }
            public long Toll { get; set; }
            public long Discount { get; set; }

            public string ExternalCode { get; set; }

            public void InsertInvoiceItem(SqlConnection cn, SqlTransaction myTransaction)
            {
                try
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    parameters.Add(new SqlParameter("@InvoiceItemId", this.InvoiceItemId));
                    parameters.Add(new SqlParameter("@InvoiceId", this.InvoiceId));
                    parameters.Add(new SqlParameter("@PackageId", this.PackageId));
                    parameters.Add(new SqlParameter("@Fee", this.Fee));
                    parameters.Add(new SqlParameter("@Tax", this.Tax));
                    parameters.Add(new SqlParameter("@Toll", this.Toll));
                    parameters.Add(new SqlParameter("@Discount", this.Discount));

                    parameters[0].Direction = ParameterDirection.Output;

                    DatasetClass.ExecuteStoredProcedure(cn, "spInsertSaleInvoiceItem_ws", parameters.ToArray<SqlParameter>(), myTransaction);

                    this.InvoiceItemId = long.Parse(parameters[0].Value.ToString());
                }
                catch
                {
                    throw;
                }

            }
        }

    public class SaleBankPayment
        {
            public long BankPayId { get; set; }//
            //public string invoiceCode { get; set; }
            public string terminalCode { get; set; }//
            public string merchantCode { get; set; }//
            public string trace { get; set; }//
            public string trDate { get; set; }
            public string cardNumber { get; set; }
            public string tref { get; set; }
            public long PaymentPrice { get; set; }
            public string status { get; set; }
            public string ExternalCode { get; set; }

            public void InsertBankPayment(SqlConnection cn, SqlTransaction myTransaction, out string strResult)
            {
                try
                {
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    parameters.Add(new SqlParameter("@BankPayId", this.BankPayId));
                    parameters.Add(new SqlParameter("@ResultString", ""));
                    //parameters.Add(new SqlParameter("@invoiceCode", this.invoiceCode));
                    parameters.Add(new SqlParameter("@terminalCode", this.terminalCode));
                    parameters.Add(new SqlParameter("@merchantCode", this.merchantCode));
                    parameters.Add(new SqlParameter("@trace", this.trace));
                    parameters.Add(new SqlParameter("@trDate", this.trDate));
                    parameters.Add(new SqlParameter("@cardNumber", this.cardNumber));
                    parameters.Add(new SqlParameter("@tref", this.tref));
                    parameters.Add(new SqlParameter("@PaymentPrice", this.PaymentPrice));
                    parameters.Add(new SqlParameter("@status", this.status));

                    parameters[0].Direction = ParameterDirection.Output;
                    parameters[1].Direction = ParameterDirection.Output;
                    parameters[1].Size = 250;

                    DatasetClass.ExecuteStoredProcedure(cn, "spInsertSaleBankPayment_ws", parameters.ToArray<SqlParameter>(), myTransaction);

                    strResult = parameters[1].Value.ToString();
                    this.BankPayId = long.Parse(parameters[0].Value.ToString());

                }

                catch
                {
                    throw;
                }

            }
        }

    public class SaleCoupon
    {
        public long CouponId { get; set; }
        public long Price { get; set; }
        public string DueJdate { get; set; }
        public long BankPayId { get; set; }

        public string ExternalCode { get; set; }

        public void InsertCoupon(SqlConnection cn, SqlTransaction myTransaction)
        {
            try
            {
                cn.Open();
            }
            catch
            {
            }

            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@CouponId", this.CouponId));
                parameters.Add(new SqlParameter("@DueJdate", this.DueJdate));
                parameters.Add(new SqlParameter("@Price", this.Price));
                parameters.Add(new SqlParameter("@BankPayId", this.BankPayId));

                parameters[0].Direction = ParameterDirection.Output;

                DatasetClass.ExecuteStoredProcedure(cn, "spInsertSaleCoupon_ws", parameters.ToArray(), myTransaction);

                this.CouponId = long.Parse(parameters[0].Value.ToString());
            }

            catch
            {
                throw;
            }

        }

        public void UpdateCoupon(SqlConnection cn, SqlTransaction myTransaction)
        {
            try
            {
                cn.Open();
            }
            catch
            {
            }

            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@CouponId", this.CouponId));
                parameters.Add(new SqlParameter("@BankPayId", this.BankPayId));

                DatasetClass.ExecuteStoredProcedure(cn, "spUpdateCoupon", parameters.ToArray(), myTransaction);
                //ExecuteStoredProcedure(cn, "spUpdateCoupon", parameters.ToArray<SqlParameter>(), myTransaction);
            }

            catch
            {
                throw;
            }
        }
    }

    public class SaleInvoiceCoupon
    {

        public long Id { get; set; }
        public long CouponId { get; set; }
        public long InvoiceId { get; set; }

        public string ExternalCode { get; set; }

        public void InsertInvoiceCoupon(SqlConnection cn, SqlTransaction myTransaction)
        {
            try
            {
                cn.Open();
            }
            catch
            {
            }

            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@Id", this.Id));
                parameters.Add(new SqlParameter("@InvoiceId", this.InvoiceId));
                parameters.Add(new SqlParameter("@CouponId", this.CouponId));

                parameters[0].Direction = ParameterDirection.Output;

                DatasetClass.ExecuteStoredProcedure(cn, "spInsertSaleInvoiceCoupon", parameters.ToArray(), myTransaction);

                this.Id = long.Parse(parameters[0].Value.ToString());
            }

            catch
            {
                throw;
            }

        }
    }

        /*                    

        //Paypaad utility class for payment process
        public class PaypaadUtil
        {

            //get payment trace
            private static XmlDocument getResp(string postData)
            {

                if (WebConfigurationManager.AppSettings["payment_trace_url"] != null)
                {
                    // Create the request using payment trace URL
                    WebRequest request = WebRequest.Create(WebConfigurationManager.AppSettings["payment_trace_url"]);
                    // using POST method
                    request.Method = "POST";
                    // Create POST data and convert it to a byte array.
                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    // Set WebRequest properties
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = byteArray.Length;
                    // Get the request stream.
                    Stream dataStream = request.GetRequestStream();
                    // Write the post data
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    // Close the Stream object
                    dataStream.Close();
                    // Get the response.
                    WebResponse response = request.GetResponse();
                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(responseFromServer);
                    return xml;
                }
                else
                {
                    return new XmlDocument();
                }
            }
        }

        public class RemotePost
        {
            /*مثال
        //ساخت ایکس ام ال از کارت خرید
        string content = PasargadUtil.createXML(myCart);
        //امضا و تصدیق اعتبار اطلاعات وارد شده
        string sign = Pasargad.PasargadUtil.sign(content);
        Pasargad.RemotePost myremotepost = new Pasargad.RemotePost(content, sign);
        myremotepost.Url = "https://paypaad.bankpasargad.com/PaymentController";

        //Session["cartObject"] = myCart;


        //ارسال اطلاعات به سامانه پرداخت امن
        myremotepost.Post();             
             */

        /*
            public RemotePost(string _content, string _sign)
            {
                content = _content;
                sign = _sign;
            }

            public string Url = "";
            public string Method = "post";
            public string FormName = "form1";
            public string content = "";
            public string sign = "";

            public void Post()
            {
                System.Web.HttpContext.Current.Response.Clear();

                System.Web.HttpContext.Current.Response.Write("<html><head>");

                System.Web.HttpContext.Current.Response.Write(string.Format("</head><body onload=\"document.{0}.submit()\">", FormName));
                System.Web.HttpContext.Current.Response.Write(string.Format("<form name=\"{0}\" method=\"{1}\" action=\"{2}\" >", FormName, Method, Url));

                System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"content\" type=\"hidden\" value='{0}'>", content));
                System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"sign\" type=\"hidden\" value=\"{0}\">", sign));

                System.Web.HttpContext.Current.Response.Write("</form>");
                System.Web.HttpContext.Current.Response.Write("</body></html>");
                System.Web.HttpContext.Current.Response.End();


            }
        

        }
         * */

   
}