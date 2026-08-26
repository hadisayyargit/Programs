using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using GlobalUnits;
using CommonUnits;

namespace EmdadMainServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EcommerceService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EcommerceService.svc or EcommerceService.svc.cs at the Solution Explorer and start debugging.
    public class EcommerceService : IEcommerceService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// فهرست سرویسهای ارائه شده برای مشتری مثلا به عنوان منو در جیپاد پاسارگاد
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public DataSet GetServices(string strUserId, string strPassword)
        {
            DataSet ds = new DataSet();

            List<SqlParameter> myparameters = new List<SqlParameter>();

            Authentication objAuthentication = new Authentication();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceConnection"].ConnectionString;

            string strValid = objAuthentication.IsValidUser(strUserId, strPassword, conn.ConnectionString);

            if (strValid == "ok")
            {
                myparameters.Add(new SqlParameter("@AgencyCode", strUserId));


                try
                {
                    conn.Open();
                }
                catch
                {
                }

                try
                {
                    DatasetClass.ExecuteStoredProcedure(conn, "spGetService_ws", myparameters.ToArray<SqlParameter>(), ds);
                }

                catch
                {
                    throw;
                }
            }

            return (ds);
        }

        public DataSet GetFinalPrice(string strUserId, string strPassword)
        {
            DataSet ds = new DataSet();

            List<SqlParameter> myparameters = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceConnection"].ConnectionString;


            Authentication objAuthentication = new Authentication();
            string strValid = objAuthentication.IsValidUser(strUserId, strPassword, conn.ConnectionString);

            if (strValid == "ok")
            {
                myparameters.Add(new SqlParameter("@AgencyCode", strUserId));


                try
                {
                    conn.Open();
                }
                catch
                {
                }

                try
                {
                    DatasetClass.ExecuteStoredProcedure(conn, "Site_GetFinalPrice_WS", myparameters.ToArray<SqlParameter>(), ds);
                }

                catch
                {
                    throw;
                }
            }

            return (ds);
        }

        public string SubmitInvoice(string strUserId, string strPassword, string xmlInvoice)
        {
            string strRes = "";

            XmlDocument myxml = new XmlDocument();

            List<Subscription> mySubscriptionList = new List<Subscription>();
            List<SaleInvoice> mySaleInvoiceList = new List<SaleInvoice>();
            List<SaleInvoiceItem> mySaleInvoiceItemList = new List<SaleInvoiceItem>();
            List<SaleBankPayment> mySaleBankPaymentList = new List<SaleBankPayment>();
            List<SaleCoupon> mySaleCouponList = new List<SaleCoupon>();

            string strxml1 = xmlInvoice;

            ///for testing
            /*
            strxml1 = "<root>"
                    + "<subscription chassisno='c1' mobile='091273310' nationalno='00457' autocode='25' licenseplate='25ج9-22' vin='8456546'  firstname='سورنا' lastname='زهرایی' tel='0216651'  address='خ آزادی' sex='1' city='100' invoicejdate='1392/09/06' agencycode='1' price='123456' tax='12345' toll='1234' discount='123'>100"
                    + "<invoiceitem packageid='31' fee='41' tax ='51' toll ='1' discount='61'></invoiceitem>"
                    + "<invoiceitem packageid='44'></invoiceitem>"
                    + "<payment terminalCode='18' trace='40' trdate='2013/09/09' cardnumber='9876' tref='13' paymentprice='120000' duejdate='1392/09/12' />"
                    + "<payment terminalCode='19' trace='41' trdate='2013/09/09' cardnumber='9876' tref='13'>p2</payment>"
                    + "</subscription>"

                    + "<subscription chassisno='c2' mobile='09192510' nationalno='003962557' firstname='پروین' lastname='محمودی' invoicejdate='1392/09/06' agencycode='15' price='8765'>101"
                    + "<invoiceitem packageid='44' fee='0'></invoiceitem>"
                    + "<invoiceitem packageid='33' fee='0' tax ='1' toll ='1' discount='1'></invoiceitem>"
                    + "<payment terminalCode='20' trace='42' trdate='2013/09/05' cardnumber='5678' tref='13' paymentprice='6543' duejdate='1392/09/12' />"
                    + "</subscription>"

                    + "</root>";
            */

            //strxml1 = "<root><subscription chassisno='c11' mobile='09192510' nationalno='003962557' firstname='پروین' lastname='محمودی' invoicejdate='1392/09/06' agencycode='15' price='8765'>101<payment terminalCode='22' trace='22' trdate='2013/09/05' cardnumber='5678' tref='13' paymentprice='6543' duejdate='1392/09/12' /></subscription></root>";

            SqlConnection websaleconnection = new SqlConnection();
            websaleconnection.ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceConnection"].ConnectionString;

            Authentication objAuthentication = new Authentication();
            string strValid = objAuthentication.IsValidUser(strUserId, strPassword, websaleconnection.ConnectionString);

            if (strValid == "ok")
            {

                xmlToList(strxml1, out mySubscriptionList, out mySaleInvoiceList, out mySaleInvoiceItemList, out mySaleBankPaymentList, out mySaleCouponList, out strRes);

                if (strRes == "")
                {

                    try
                    {
                        websaleconnection.Open();
                    }
                    catch
                    {
                    }

                    SqlTransaction myTransaction = websaleconnection.BeginTransaction();

                    try
                    {
                        ///insert subscription
                        InsertSubscription(websaleconnection, myTransaction, mySubscriptionList, mySaleInvoiceList, out strRes);

                        if (strRes == "")
                            InsertInvoiceItem(websaleconnection, myTransaction, mySaleInvoiceList, mySaleInvoiceItemList, out strRes);

                        if (strRes == "")
                            InsertBankPayment(websaleconnection, myTransaction, mySaleInvoiceList, mySaleBankPaymentList, mySaleCouponList, out strRes);

                        if (strRes == "")
                            myTransaction.Commit();
                        else
                            myTransaction.Rollback();

                        ///construction of output xml
                        if (strRes == "")
                            buildXml(mySaleInvoiceList, out strRes);
                    }

                    catch (Exception ex)
                    {
                        strRes = ex.Message;
                        myTransaction.Rollback();
                    }
                }
            }

            else
            {
                strRes = "کاربر نامعتبر است";
            }


            return strRes;
        }


        /// <summary>
        /// جداسازی گزینه ها از xml و تبدیل آنها به لیست
        /// </summary>
        /// <param name="xmlInvoice"></param>
        /// <param name="mySubscriptionList"></param>
        /// <param name="mySaleInvoiceList"></param>
        /// <param name="mySaleInvoiceItemList"></param>
        /// <param name="mySaleBankPaymentList"></param>
        /// <param name="mySaleCouponList"></param>
        /// <param name="myResultString"></param>
        private void xmlToList(string xmlInvoice, out  List<Subscription> mySubscriptionList, out List<SaleInvoice> mySaleInvoiceList, out List<SaleInvoiceItem> mySaleInvoiceItemList, out List<SaleBankPayment> mySaleBankPaymentList, out List<SaleCoupon> mySaleCouponList, out string myResultString)
        {
            myResultString = "";
            mySubscriptionList = new List<Subscription>();
            mySaleInvoiceList = new List<SaleInvoice>();
            mySaleInvoiceItemList = new List<SaleInvoiceItem>();
            mySaleBankPaymentList = new List<SaleBankPayment>();
            mySaleCouponList = new List<SaleCoupon>();

            XmlDocument myxml = new XmlDocument();

            try
            {
                ///checking format
                //myxml.Validate()

                myxml.LoadXml(xmlInvoice);

                XmlNodeList subscriptionNodeList;

                subscriptionNodeList = myxml.GetElementsByTagName("subscription");

                ///invoice
                foreach (XmlNode subscriptionnode in subscriptionNodeList)
                {
                    Subscription objSubscription = new Subscription();
                    SaleInvoice objSaleInvoice = new SaleInvoice();

                    ///tag content
                    objSubscription.ExternalCode = subscriptionnode.FirstChild.Value;
                    objSaleInvoice.ExternalCode = subscriptionnode.FirstChild.Value;

                    objSubscription.ChassisNo = subscriptionnode.Attributes["chassisno"].Value;
                    objSubscription.Mobile = subscriptionnode.Attributes["mobile"].Value;
                    objSubscription.NATIONALNO = subscriptionnode.Attributes["nationalno"].Value;

                    if (subscriptionnode.Attributes["autocode"] != null) objSubscription.AUTOCODE = subscriptionnode.Attributes["autocode"].Value;
                    if (subscriptionnode.Attributes["licenseplate"] != null) objSubscription.LICENSEPLATE = subscriptionnode.Attributes["licenseplate"].Value;
                    if (subscriptionnode.Attributes["vin"] != null) objSubscription.VIN = subscriptionnode.Attributes["vin"].Value;
                    if (subscriptionnode.Attributes["firstname"] != null) objSubscription.FIRSTNAME = subscriptionnode.Attributes["firstname"].Value;
                    if (subscriptionnode.Attributes["lastname"] != null) objSubscription.LASTNAME = subscriptionnode.Attributes["lastname"].Value;
                    if (subscriptionnode.Attributes["tel"] != null) objSubscription.TEL = subscriptionnode.Attributes["tel"].Value;
                    if (subscriptionnode.Attributes["address"] != null) objSubscription.ADDRESS = subscriptionnode.Attributes["address"].Value;
                    if (subscriptionnode.Attributes["sex"] != null) objSubscription.Sex = int.Parse(subscriptionnode.Attributes["sex"].Value);
                    if (subscriptionnode.Attributes["city"] != null) objSubscription.City = int.Parse(subscriptionnode.Attributes["city"].Value);

                    objSaleInvoice.InvoiceJdate = subscriptionnode.Attributes["invoicejdate"].Value;
                    objSaleInvoice.AgencyCode = subscriptionnode.Attributes["agencycode"].Value;

                    if (subscriptionnode.Attributes["price"] != null) objSaleInvoice.Price = long.Parse(subscriptionnode.Attributes["price"].Value);
                    if (subscriptionnode.Attributes["tax"] != null) objSaleInvoice.Tax = long.Parse(subscriptionnode.Attributes["tax"].Value);
                    if (subscriptionnode.Attributes["toll"] != null) objSaleInvoice.Toll = long.Parse(subscriptionnode.Attributes["toll"].Value);
                    if (subscriptionnode.Attributes["discount"] != null) objSaleInvoice.Discount = long.Parse(subscriptionnode.Attributes["discount"].Value);

                    mySubscriptionList.Add(objSubscription);
                    mySaleInvoiceList.Add(objSaleInvoice);

                    XmlNodeList InvoiceItemNodeList = subscriptionnode.SelectNodes("descendant::invoiceitem");
                    XmlNodeList paymentNodelist = subscriptionnode.SelectNodes("descendant::payment");

                    foreach (XmlNode invoiceItemNode in InvoiceItemNodeList)
                    {
                        SaleInvoiceItem objSaleInvoiceItem = new SaleInvoiceItem();
                        objSaleInvoiceItem.PackageId = int.Parse(invoiceItemNode.Attributes["packageid"].Value);

                        if (invoiceItemNode.Attributes["fee"] != null && invoiceItemNode.Attributes["fee"].Value != "") objSaleInvoiceItem.Fee = long.Parse(invoiceItemNode.Attributes["fee"].Value);
                        if (invoiceItemNode.Attributes["tax"] != null && invoiceItemNode.Attributes["tax"].Value != "") objSaleInvoiceItem.Tax = long.Parse(invoiceItemNode.Attributes["tax"].Value);
                        if (invoiceItemNode.Attributes["toll"] != null && invoiceItemNode.Attributes["toll"].Value != "") objSaleInvoiceItem.Toll = long.Parse(invoiceItemNode.Attributes["toll"].Value);
                        if (invoiceItemNode.Attributes["discount"] != null && invoiceItemNode.Attributes["discount"].Value != "") objSaleInvoiceItem.Discount = long.Parse(invoiceItemNode.Attributes["discount"].Value);

                        objSaleInvoiceItem.ExternalCode = objSubscription.ExternalCode;
                        mySaleInvoiceItemList.Add(objSaleInvoiceItem);
                    }

                    ///payment
                    foreach (XmlNode paymentNode in paymentNodelist)
                    {
                        SaleBankPayment objSaleBankPayment = new SaleBankPayment();
                        SaleCoupon objSaleCoupon = new SaleCoupon();

                        objSaleBankPayment.terminalCode = paymentNode.Attributes["terminalCode"].Value;
                        objSaleBankPayment.merchantCode = paymentNode.Attributes["merchantCode"].Value;
                        objSaleBankPayment.trace = paymentNode.Attributes["trace"].Value;
                        objSaleBankPayment.trDate = paymentNode.Attributes["trdate"].Value;
                        objSaleBankPayment.status = paymentNode.Attributes["status"].Value;

                        if (paymentNode.Attributes["cardNumber"] != null) objSaleBankPayment.cardNumber = paymentNode.Attributes["cardNumber"].Value;
                        if (paymentNode.Attributes["tref"] != null) objSaleBankPayment.tref = paymentNode.Attributes["tref"].Value;
                        if (paymentNode.Attributes["paymentprice"] != null) objSaleBankPayment.PaymentPrice = long.Parse(paymentNode.Attributes["paymentprice"].Value);

                        if (paymentNode.Attributes["duejdate"] != null) objSaleCoupon.DueJdate = paymentNode.Attributes["duejdate"].Value;
                        ///tag content
                        //strRes = invoiceItemNode.InnerText;

                        objSaleBankPayment.ExternalCode = objSubscription.ExternalCode;
                        mySaleBankPaymentList.Add(objSaleBankPayment);

                        objSaleCoupon.ExternalCode = objSubscription.ExternalCode;
                        mySaleCouponList.Add(objSaleCoupon);

                    }
                }
            }
            catch (Exception ex)
            {
                myResultString = "قالب xml ورودی اشتباه است" + "\n" + ex.Message;
            }

        }

        private void buildXml(List<SaleInvoice> mySaleInvoiceList, out string myResultString)
        {
            /*
            <Root><Invoice ExternalCode="100">9280</Invoice><Invoice ExternalCode="101">9281</Invoice></Root>
            */

            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("Root");
            document.AppendChild(root);

            foreach (SaleInvoice myInvoice in mySaleInvoiceList)
            {
                XmlElement pelement = document.CreateElement("Invoice");

                pelement.SetAttribute("ExternalCode", myInvoice.ExternalCode.Replace("\n", ""));

                XmlText contentText = document.CreateTextNode(myInvoice.InvoiceId.ToString());
                pelement.AppendChild(contentText);
                root.AppendChild(pelement);
            }

            myResultString = document.InnerXml;
        }

        private void InsertSubscription(SqlConnection websaleconnection, SqlTransaction myTransaction, List<Subscription> mySubscriptionList, List<SaleInvoice> mySaleInvoiceList, out string myResultString)
        {
            bool errorflag = false;
            myResultString = "";
            Subscription mySubscription = new Subscription();

            try
            {
                foreach (Subscription Subscription1 in mySubscriptionList)
                {
                    mySubscription = Subscription1;

                    mySubscription.InsertSubscription(websaleconnection, myTransaction, out myResultString);

                    if (myResultString != "" && myResultString.Replace('ي', 'ی').StartsWith("شاسی تکراری") == false)
                    {
                        errorflag = true;
                        break;
                    }

                    myResultString = "";
                    string strExternalCode = mySubscription.ExternalCode;

                    SaleInvoice myInvoice = new SaleInvoice();
                    //myInvoice = mySaleInvoiceList.Find(FindInvoice);

                    myInvoice = mySaleInvoiceList.Find(delegate(SaleInvoice invoice1)
                    {
                        return (invoice1.ExternalCode == strExternalCode);
                    }
                        );

                    myInvoice.ChassisNo = mySubscription.ChassisNo;

                    /// insert of invoice
                    myInvoice.InsertInvoice(websaleconnection, myTransaction);

                    if (myInvoice.InvoiceId <= 0)
                    {
                        myResultString = "خطا در درج فاکتور";
                        errorflag = true;
                        break;
                    }

                }

                if (!errorflag)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                //throw;
                if (ex.Message.Contains("truncate"))
                {
                    ex = new Exception("خطا در ورودی مربوط بهtag: chassisno=" + mySubscription.ChassisNo);
                }

                throw (ex);
            }


        }

        private void InsertInvoiceItem(SqlConnection websaleconnection, SqlTransaction myTransaction, List<SaleInvoice> mySaleInvoiceList, List<SaleInvoiceItem> mySaleInvoiceItemList, out string myResultString)
        {
            bool errorflag = false;
            myResultString = "";

            try
            {
                foreach (SaleInvoiceItem myInvoiceItem in mySaleInvoiceItemList)
                {

                    string strExternalCode = myInvoiceItem.ExternalCode;

                    SaleInvoice myInvoice = new SaleInvoice();
                    //myInvoice = mySaleInvoiceList.Find(FindInvoice);

                    myInvoice = mySaleInvoiceList.Find(delegate(SaleInvoice invoice1)
                    {
                        return (invoice1.ExternalCode == strExternalCode);
                    }
                        );


                    myInvoiceItem.InvoiceId = myInvoice.InvoiceId;

                    myInvoiceItem.InsertInvoiceItem(websaleconnection, myTransaction);

                    if (myInvoiceItem.InvoiceItemId <= 0)
                    {
                        myResultString = "خطا در درج قلم فاکتور";
                        errorflag = true;
                        break;
                    }

                }

                if (!errorflag)
                {
                    return;
                }
            }
            catch
            {
                throw;
            }

        }

        private void InsertBankPayment(SqlConnection websaleconnection, SqlTransaction myTransaction, List<SaleInvoice> mySaleInvoiceList, List<SaleBankPayment> mySaleBankPaymentList, List<SaleCoupon> mySaleCouponList, out string myResultString)
        {
            bool errorflag = false;
            myResultString = "";

            try
            {
                foreach (SaleBankPayment myBankPayment in mySaleBankPaymentList)
                {
                    string strExternalCode = myBankPayment.ExternalCode;

                    SaleCoupon myCoupon = new SaleCoupon();

                    myBankPayment.InsertBankPayment(websaleconnection, myTransaction, out myResultString);

                    if (myBankPayment.BankPayId <= 0)
                    {

                        myResultString = "خطا در درج پرداخت کوپن-شماره پیگیری قبلا ثبت گردیده است:";
                        myResultString += "\n" + "terminalCode:" + myBankPayment.terminalCode;
                        myResultString += "\n" + "trace:" + myBankPayment.trace;
                        errorflag = true;
                        break;
                    }

                    myCoupon = mySaleCouponList.Find(delegate(SaleCoupon coupon1)
                    {
                        return (coupon1.ExternalCode == strExternalCode);
                    }
                        );

                    myCoupon.BankPayId = myBankPayment.BankPayId;
                    myCoupon.Price = myBankPayment.PaymentPrice;
                    myCoupon.InsertCoupon(websaleconnection, myTransaction);


                    if (myCoupon.CouponId <= 0)
                    {
                        myResultString = "خطا در درج کوپن";
                        errorflag = true;
                        break;
                    }

                    ///invoice_coupon
                    ///
                    SaleInvoice myInvoice = new SaleInvoice();
                    myInvoice = mySaleInvoiceList.Find(delegate(SaleInvoice invoice1)
                    {
                        return (invoice1.ExternalCode == strExternalCode);
                    }
                        );


                    SaleInvoiceCoupon myInvoiceCoupon = new SaleInvoiceCoupon();
                    myInvoiceCoupon.CouponId = myCoupon.CouponId;
                    myInvoiceCoupon.InvoiceId = myInvoice.InvoiceId;

                    myInvoiceCoupon.InsertInvoiceCoupon(websaleconnection, myTransaction);

                    if (myInvoiceCoupon.Id <= 0)
                    {
                        myResultString = "خطا در درج کوپن-فاکتور";
                        errorflag = true;
                        break;
                    }
                }

                if (!errorflag)
                {
                    return;
                }
            }
            catch
            {
                throw;
            }
        }

        /// Explicit predicate delegate. 
        private static bool FindInvoice(SaleInvoice invoice)
        {
            return (invoice.ExternalCode == "");
        }

        public void InsertUssdReq(SqlConnection cn, string strMobileno, string strDesc, out string strResult)
        {
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Id", 0));
                parameters.Add(new SqlParameter("@Mobile", strMobileno));
                parameters.Add(new SqlParameter("@Desc", strDesc));

                parameters[0].SqlDbType = SqlDbType.Int;
                parameters[0].Direction = ParameterDirection.Output;

                DatasetClass.ExecuteStoredProcedure(cn, "spInsert_Aid_AmadehBaresi", parameters.ToArray<SqlParameter>(), null);

                strResult = parameters[0].Value.ToString();

            }
            catch(Exception ex)
            {
                //throw;
                strResult = ex.Message;
            }

        }
    }

}
