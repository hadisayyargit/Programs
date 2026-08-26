using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using GlobalUnits;

namespace CommonUnits
{
    public class SmsClass
    {
       public static int SendEmdadSms(string[] MobileNoList, string strMessage)
        {

            RahyabService.Send mySms = new RahyabService.Send();

            long[] rec = null;
            byte[] status = null;
            int retval = -1;

            retval = mySms.SendSms("websale", "websale!@#$", MobileNoList, "100096550", strMessage, false, "", ref rec, ref status);

            return retval;
        }

        public static void InsertEmdadSms(string strMobileNo, string strMessage, long nMsgId, int MsgType)
        {

            try
            {
                GeneralModule.m_EcommerceConnection.Open();
            }

            catch
            {
            }
            try
            {

                List<SqlParameter> myParameters = new List<SqlParameter>();

                myParameters.Add(new SqlParameter("@MsgId", SqlDbType.BigInt));
                myParameters.Add(new SqlParameter("@RefMsgID", nMsgId));
                myParameters.Add(new SqlParameter("@Body", strMessage));
                myParameters.Add(new SqlParameter("@Sender", "100096550"));
                myParameters.Add(new SqlParameter("@MsgType", MsgType));
                myParameters.Add(new SqlParameter("@Receiver", strMobileNo));
                myParameters[0].Direction = ParameterDirection.Output;

                GlobalUnits.DatasetClass.ExecuteStoredProcedure(GeneralModule.m_EcommerceConnection, "spInserttblMessageOutbox", myParameters.ToArray(), null);
            }
            catch
            {
                throw;
            }

        }
    }

}