using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Collections;
using System.Xml;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security;
using System.Web.Configuration;

namespace Pasargad
{
   

    /*
    public static string GetInvoiceSerial(string invoice_date, DateTime timeout, string invoice_number, long _amount, long fee, int count)
    {
        PaypaadCart NewCart = new PaypaadCart();
        NewCart.invoice_date = invoice_date;
        NewCart.invoice_number = invoice_number;
        NewCart.time_stamp = DateTime.Now;
        NewCart.buyer_name = "حسن";
        NewCart.buyer_tel = "02122336655";
        NewCart.timeout = timeout;

        PaypaadItem newItem = new PaypaadItem();
        newItem.content = "رادیو";
        newItem.amount = _amount;
        newItem.count = count;
        newItem.fee = fee;
        newItem.description = "توضیحات مرتبط با کالا";
        NewCart.addProductItem(newItem);

        string strcontent = PaypaadUtil.createXML(NewCart);
        string strbuyerMediaId = "";
        string strData = strbuyerMediaId + strcontent;
        string strsign = "";
        try
        {
            ServicesPaypaad.PaypaadWSClient svcPaypaad = new ServicesPaypaad.PaypaadWSClient();
          
            ServicesPaypaad.ServiceResult svcServiceResult = new ServicesPaypaad.ServiceResult();
            strsign = PaypaadUtil.sign(strData);
            svcServiceResult = svcPaypaad.submitInvoice(strbuyerMediaId, strcontent, strData, strsign);
            string[] words = svcServiceResult.data.Split(',');
            // int length = words.Length;

            string[] invoiceNumber = words[2].Split('=');
            string[] invoiceCode = words[3].Split('=');
            string[] amount = words[4].Split('=');

            long total_amount = NewCart.get_total_amount();
            if (invoice_number == invoiceNumber[1])//&& (string)total_amount   == amount[1])
            {
                string strinvoiceCode = invoiceCode[1];
                return strinvoiceCode;
            }
            return "";
        }
        catch
        {
            throw;
        }

    }



     */
    

    public class PasargadItem
    {
        public String content;
        public int count;
        public int fee;
        public int amount;
        public String description;
        // default values
        public PasargadItem(String _content = "" , int _count = 0 , int _fee = 0 , string _description = "", int _amount = 0)
        {
            content = _content;
            count = _count < 0 ? 0 : _count;
            fee = _fee;
            description = _description;
            amount = _amount < 0 ? 0 : _amount;
        }
    }

    public class PasargadCart
    {
        public PasargadCart()
        {
            cart = new ArrayList();
            if (WebConfigurationManager.AppSettings["merchant_code"] != null)
                merchant_code = WebConfigurationManager.AppSettings["merchant_code"];
            if (WebConfigurationManager.AppSettings["terminal_code"] != null )
                terminal_code = WebConfigurationManager.AppSettings["terminal_code"];
            if (WebConfigurationManager.AppSettings["delivery_days"] != null )
                delivery_days = WebConfigurationManager.AppSettings["delivery_days"];
            if (WebConfigurationManager.AppSettings["redirect_address"] != null)
                redirect_address = WebConfigurationManager.AppSettings["redirect_address"];
            if (WebConfigurationManager.AppSettings["referrer_address"] != null)
                referrer_address = WebConfigurationManager.AppSettings["referrer_address"];  
            total_amount = 0;
        }
        public DateTime time_stamp;
        public String invoice_date;
        public String invoice_number;
        public String merchant_code;
        public String terminal_code;
        public String redirect_address;
        public String referrer_address;
        public String delivery_days;
        private int total_amount;
        public int get_total_amount()
        {
            return total_amount;
        }
        public String buyer_name;
        public String buyer_tel;
        public String delivery_address;
        public ArrayList cart;  


        public void addProductItem(PasargadItem newItem) //add an Item to cart
        {
            cart.Add(newItem);
            total_amount += newItem.amount;  // mention the price!
        }
    }

    //Pasargad utility class for payment process
    public class PasargadUtil
    {
        //convert cart to xml representation suitable for paymnet gateway
        public static String createXML(PasargadCart cart)
        {
            if (cart == null)
                return "Cart is Null";
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("invoice");
            root.SetAttribute("time_stamp", cart.time_stamp.ToString("yyyy/MM/dd hh:mm:ss"));
            root.SetAttribute("invoice_date", cart.invoice_date);
            root.SetAttribute("invoice_number", cart.invoice_number);
            root.SetAttribute("terminal_code", cart.terminal_code);
            root.SetAttribute("merchant_code", cart.merchant_code);
            root.SetAttribute("redirect_address", cart.redirect_address);
            root.SetAttribute("referrer_address", cart.referrer_address);
            root.SetAttribute("delivery_days", cart.delivery_days);
            root.SetAttribute("total_amount", cart.get_total_amount().ToString());
            root.SetAttribute("buyer_name", cart.buyer_name);
            root.SetAttribute("buyer_tel", cart.buyer_tel);
            root.SetAttribute("delivery_address", cart.delivery_address);
            document.AppendChild(root);
            int index = 1;
            foreach (PasargadItem item in cart.cart) //add items
            {
                XmlElement pelement = document.CreateElement("item");
                pelement.SetAttribute("number", index.ToString());
                ++index;
                XmlElement contentElement = document.CreateElement("content");
                XmlElement countElement = document.CreateElement("count");
                XmlElement feeElement = document.CreateElement("fee");
                XmlElement amountElement = document.CreateElement("amount");
                XmlElement descriptionElement = document.CreateElement("description");
                XmlText contentText = document.CreateTextNode(item.content);
                XmlText countText = document.CreateTextNode(item.count.ToString());
                XmlText feeText = document.CreateTextNode(item.fee.ToString());
                XmlText amountText = document.CreateTextNode(item.amount.ToString());
                XmlText descriptionText = document.CreateTextNode(item.description);
                contentElement.AppendChild(contentText);
                countElement.AppendChild(countText);
                feeElement.AppendChild(feeText);
                amountElement.AppendChild(amountText);
                descriptionElement.AppendChild(descriptionText);
                pelement.AppendChild(contentElement);
                pelement.AppendChild(countElement);
                pelement.AppendChild(feeElement);
                pelement.AppendChild(amountElement);
                pelement.AppendChild(descriptionElement);
                root.AppendChild(pelement);
            }
            return document.InnerXml; //return string 
        }
        public static string sign(string xml) //sign the contents with private key
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //use xml representation of an unencrypted pkcs8 private key
            if (WebConfigurationManager.AppSettings["key_file"] != null)
            {
                string xmlStr = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath(WebConfigurationManager.AppSettings["key_file"]));
                rsa.FromXmlString(xmlStr);
                //sign with SHA1
                byte[] sign = rsa.SignData(Encoding.UTF8.GetBytes(xml), new SHA1CryptoServiceProvider());
                //convert to base64
                return Convert.ToBase64String(sign);
            }
            else
            {
                return String.Empty;
            }
        }
        //get payment trace using tref number
        public static XmlDocument getResponse(string tref)
        {
            string postData = "tref=" + tref;
            return getResp(postData);
        }
        //get payment trace using cart information
        public static XmlDocument getResponse(PasargadCart cart)
        {
            string postData = "invoice_number=" + cart.invoice_number +
                        "&invoice_date=" + cart.invoice_date +
                        "&merchant_code=" + cart.merchant_code +
                        "&terminal_code=" + cart.terminal_code;
            return getResp(postData);

        }
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
        public RemotePost( string _content , string _sign )
        {
            content = _content;
            sign = _sign ;
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

            System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"content\" type=\"hidden\" value='{0}'>",  content));
            System.Web.HttpContext.Current.Response.Write(string.Format("<input name=\"sign\" type=\"hidden\" value=\"{0}\">", sign ));
            
            System.Web.HttpContext.Current.Response.Write("</form>");
            System.Web.HttpContext.Current.Response.Write("</body></html>");
            System.Web.HttpContext.Current.Response.End();


        }
        
    }
}