using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CommonUnits
{
    public class Authentication 
    {
        public string IsValidUser(string strUserId, string strPassword, string strConnectionString)
        {
            string strRes = "";

            try
            {
                WindowsFormsApplication1.ManegUsers objUser = new WindowsFormsApplication1.ManegUsers();

                //objUser.Con(ConfigurationManager.ConnectionStrings[strConnectionName].ConnectionString);
                objUser.Con(strConnectionString);

                int nRes = objUser.Login(strUserId, strPassword);

                if (nRes == 1)
                {
                    strRes = "ok";
                }
                else
                {
                    strRes ="-1;"+ "شناسه کاربری و یا رمز آن اشتباه است";
                }
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("The server was not found or was not accessible"))
                    strRes ="-2;"+ "سرور در دسترس نیست";
                else if (ex.Message.Contains("Connection Timeout Expired"))
                    strRes ="-3;"+ "خطای زمان طولانی ارتباط";
                else if (ex.Message.Contains("Login failed for user"))
                    strRes = "-1;"+"شناسه کاربری و یا رمز آن اشتباه است";
            }

            return strRes;
        }

    }
}
