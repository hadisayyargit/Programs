using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.PocketOutlook;
using MAPIdotnet;

namespace layerBusiness
{
    public class Sms
    {
        #region Method

        public void SendSMS()
        {
            try
            {
                //Microsoft.WindowsMobile.PocketOutlook.SmsAccount s1;
                Microsoft.WindowsMobile.PocketOutlook.SmsMessage m1 = new Microsoft.WindowsMobile.PocketOutlook.SmsMessage(m_strPhone, m_strBody);

                m1.Send();
                /*
                Microsoft.WindowsMobile.PocketOutlook.SmsAccount s1;
                s1.Send(
                Microsoft.WindowsMobile.Telephony.Phone p1;
            
                 */
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ReceiveSMS()
        {
            MAPIdotnet.MAPI objMapi = new MAPIdotnet.MAPI();
            IMAPIMsgStore[] stores;
            stores = objMapi.MesssageStores;
            int smsindex=0;

            try
            {
                //folder.SortMessagesByDeliveryTime(TableSortOrder.TABLE_SORT_DESCEND);                
                for (int i = 0; i < stores.Length; i++)
                {
                    if (stores[i].DisplayName.ToLower() == "sms")
                        smsindex = i;
                }

                IMAPIMessage[] myMessages = stores[smsindex].ReceiveFolder.GetNextMessages((int)stores[smsindex].ReceiveFolder.NumSubItems);

                int nTotal = myMessages.Length;

                if (nTotal > 0)
                {
                    m_strPhone = myMessages[nTotal - 1].Sender.Name;
                    m_strBody = myMessages[nTotal - 1].Subject;
                    m_dtmSmsTime = myMessages[nTotal - 1].LocalDeliveryTime;
                    m_strSmsStatus = myMessages[nTotal - 1].Flags.ToString();
                }
            }
            catch
            {
            }
        }

        #endregion

        #region property

        public string Phone
        {
            get
            {
                return m_strPhone;
            }

            set
            {
                m_strPhone = value;
            }
        }

        public string Body
        {
            get
            {
                return m_strBody;
            }

            set
            {
                m_strBody = value;
            }
        }

        public DateTime SmsTime
        {
            get
            {
                return m_dtmSmsTime;
            }

            set
            {
                m_dtmSmsTime = value;
            }
        }

        public string SmsStatus
        {
            get
            {
                return m_strSmsStatus;
            }

            set
            {
                m_strSmsStatus = value;
            }
        }
        
        #endregion

        #region private

        string m_strPhone;
        string m_strBody;
        DateTime m_dtmSmsTime;
        string m_strSmsStatus;

        #endregion
    }
}
