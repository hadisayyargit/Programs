using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace footballcup.Models
{
    public class MessageModel
    {
        [Key]
        public int MessageId { get; set; }


        /// <summary>
        /// Success
        /// Info
        /// Warning
        /// Error
        /// </summary>
        public string MessageType { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string MessageBody { get; set; }

        /// <summary>
        /// 0: OwnerView
        /// 1:MessageView
        /// </summary>
        public byte ShowMessagePlace { get; set; }
        public string BackUrl { get; set; }


        public static string GetErrorMessage(Exception myException)
        {
            string strRes = "";

            if (myException != null)
            {
                if (myException.InnerException == null)
                {
                    strRes = myException.Message;
                    if (strRes.ToLower().Contains("validation failed"))
                        strRes = "خطای اعتبارسنجی داده‌های ورودی" + "\n" + strRes;
                }

                else if (myException.InnerException.InnerException == null)
                    strRes = myException.InnerException.Message;
                else
                    strRes = myException.InnerException.InnerException.Message;
            }
        

            strRes = strRes.Replace("<NULL>","NULL");

            /*
             CultureInfo ci = new CultureInfo("fa-IR");
             Thread.CurrentThread.CurrentCulture = ci;
             Thread.CurrentThread.CurrentUICulture = ci;


             if (myModel.MessageBody.Contains("The server was not found or was not accessible"))
                 myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_server_not_accessible", ci);
             else if (myModel.MessageBody.Contains("timeout"))
                 myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_timeout", ci);

             */

            return strRes;
        }
    }


}