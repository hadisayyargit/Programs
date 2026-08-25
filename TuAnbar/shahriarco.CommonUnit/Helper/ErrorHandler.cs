using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shahriarco.CommonUnit
{
    public class ErrorHandler
    {
        public static string GetErrorMessage(Exception ex)
        {
            string strMessage = ex.Message;
            if (ex.InnerException != null)
            {
                strMessage = ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    strMessage = ex.InnerException.InnerException.Message;
                }
            }


            return strMessage;
        }
    }
}
