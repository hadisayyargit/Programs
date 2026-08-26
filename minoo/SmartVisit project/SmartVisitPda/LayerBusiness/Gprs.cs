using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace layerBusiness
{
    public class Gprs
    {
        public static void ConnectGPRS(string strBody)
        {
            try
            {
                //vds.MabnaSMSService objMabna = new vds.MabnaSMSService();

                ////objMabna.Url = "http:/VDS/MabnaSMSService/MabnaSMSService.asmx";

                //objMabna.Url = "http://213.207.204.5/MabnaSMSService/MabnaSMSService.asmx";

                //objMabna.SendMessage(6, 1, strBody, 1, 1, "");
                //MessageBox.Show("ارسال انجام شد");
            }
            catch(Exception ex)
            {
                //MessageBox.Show("سرویس GPRS قطع می باشد و یا سرویس در دسترس نیست");
                throw ex;
            }

        }

        /*
         http://msdn.microsoft.com/en-us/library/ee496858.aspx
         * 
ConnectionManager connMgr = new ConnectionManager(); // open connection manager

public void connectGPRS()

{

DestinationInfoCollection DIC = connMgr.EnumDestinations(); // look the different types of connection

long startTime;

try

{

foreach (DestinationInfo di in DIC)

{

if (di.description == "Internet") // for the connection "Internet" or what you want (it can be "The Internet), it depends on your smartphone

{

connMgr.Connect(di.guid, true, ConnectionMode.Asynchronous); // try to connect

}        
         */

        /*
 public static bool IsWebAccessible() // Call this class as follows: bool bResponse = Net.IsWebAccessible();
  {
   HttpWebRequest hwrRequest;
   HttpWebResponse hwrResponse;

   string strUrl = @"http://www.bing.com/";
   bool bConnected = false;

   try
   {
    hwrRequest = (HttpWebRequest)WebRequest.Create(strUrl);
    hwrResponse = (HttpWebResponse)hwrRequest.GetResponse();

    if (hwrResponse.StatusCode == HttpStatusCode.OK)
    {
     bConnected = true;
    }
   }
   catch (WebException we)
   {
    bConnected = false;
   }
   catch (Exception ex)
   {
    bConnected = false;
   }
   finally 
   {
    hwrRequest = null;
    hwrResponse = null;
   }

   return bConnected;
  }
 
         
        */

    }
}
