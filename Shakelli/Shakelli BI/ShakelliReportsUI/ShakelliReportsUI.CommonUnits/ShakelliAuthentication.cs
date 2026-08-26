using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ShakelliReportsUI.DataLayer;
using ShakelliReportsUI.DataLayer.Models;


namespace ShakelliReportsUI.CommonUnits
{
    public class ShakelliAuthentication
    {
        public string OpenConnection()
        {
            string strRes = "";

            try
            {
                ShakelliDWEntities db = new ShakelliDWEntities();

                db.Database.Connection.Open();
                strRes = "OK";
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("The server was not found or was not accessible"))
                    strRes = "سرور در دسترس نیست";
                else if (ex.Message.Contains("Connection Timeout Expired"))
                    strRes = "خطای زمان طولانی ارتباط";
                else if (ex.Message.Contains("Login failed for user"))
                    strRes = "خطای راهبری: شناسه کاربری و یا رمز داخلی اشتباه است";
                else
                    strRes = ex.Message;
            }

            return strRes;
        }
        public string AuthenticateUser(string strUserId, string strPassword)
        {
            string strRes = "";

            try
            {
                strRes = OpenConnection();
                if (strRes == "OK")
                {
                    ShakelliDWEntities db = new ShakelliDWEntities();


                    List<AppUser> myUsers = db.AppUser.Where(u => u.UserName.ToLower() == strUserId.ToLower()).Where(u => u.Password.ToLower() == strPassword.ToLower()).ToList();

                    if (myUsers.Count == 0)
                        strRes = "کاربر نامعتبر است";
                    else
                        strRes = "OK";
                }

            }

            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        public string AuthorizeUser(string strUserId, string strPassword)
        {
            string strRes = "";

            return strRes;
            
        }




    }
}
