using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Java.Net;
using Java.IO;
using System.IO;


namespace Tosanroid
{
    public class commonclass
    {
        public static string Internet_Server = "176.9.190.52";
        public static string Local_Server = "192.168.101.213";

        public static string currentlocale = "en";
        public static string currentuser = "";
        //public static string currentuser = "mobilebi1";
        public static string currentuserpassword = "";
        //public static string currentuserpassword = "123";

        public static string presenter_server = Internet_Server;
        public static string presenter_port = "80";
        public static string connectionchannel = "gprs";
        public static string mobilebiserviceurl = "http://192.168.101.215:8600/MobileBIServices.svc";
        
        ///سرویس خودم
        //url = new URL("http://192.168.101.31/MobileBIServices/MobileBIServices.MobileBiService.svc");
        
        
        public static String authenticateuser(String uid, String pass)
        {
            String strRes = "";
            string myurl = "";

            URL url;
            try
            {
                myurl = mobilebiserviceurl + "/ValidateUser?username=" + uid + "&Password=" + pass;

                url = new URL(myurl);

                URLConnection connection = url.OpenConnection();
                HttpURLConnection httpConnection = (HttpURLConnection)connection;
                // httpConnection.connect();

                //int responseCode = httpConnection.getResponseCode();            

                //if (responseCode == HttpURLConnection.HTTP_OK) 
                //if (httpConnection.ResponseCode == HttpURLConnection.HttpAccepted)
                if (httpConnection.ResponseCode == HttpStatus.Ok)
                {
                    //InputStream in = httpConnection.getInputStream();

                    Stream myinputstream = httpConnection.InputStream;


                    strRes = convertStreamToString(myinputstream);

                    /*
				  
                      DocumentBuilderFactory dbf =
                      DocumentBuilderFactory.newInstance(); DocumentBuilder db =
                      dbf.newDocumentBuilder(); Document dom = db.parse(in);
                      Element docEle = dom.getDocumentElement();
				  
                      strRes=docEle.getTextContent(); //NodeList nl =
                      docEle.getElementsByTagName("entry");
                     */


                }
                else
                {
                    strRes = "bad url";
                }
            }

            
            catch (Exception ex)
            {
                strRes = "error:" + ex.Message;
            }
            

            return strRes;
        }

        public static String changepassword(String uid, String oldpass, String newpass)
        {
            String strRes = "";
            string myurl = "";

            URL url;
            try
            {
                myurl = mobilebiserviceurl + "/ChangePassword?username=" + uid + "&oldPassword=" + oldpass + "&newPassword=" + newpass;

                url = new URL(myurl);


                URLConnection connection = url.OpenConnection();
                HttpURLConnection httpConnection = (HttpURLConnection)connection;

                //int responseCode = httpConnection.getResponseCode();
                //if (responseCode == HttpURLConnection.HTTP_OK) 

                if (httpConnection.ResponseCode == HttpStatus.Accepted)
                {
                    Stream myinputstream = httpConnection.InputStream;
                    strRes = convertStreamToString(myinputstream);

                }
                else
                {
                    strRes = "bad url";
                }

            }
            catch (Exception ex)
            {
                strRes = "error:" + ex.Message;
            }

            return strRes;
        }

        /*
	String gethttprequest2() 
	{
		String strRes = "";
		try {
			DefaultHttpClient client = new DefaultHttpClient();
			HttpGet request = new HttpGet(
					"http://192.168.101.213/MobileBIServices/MobileBIServices.MobileBiService.svc/GetPass?userid=ss");
			request.setHeader("Content-type", "application/json");
			HttpResponse response = client.execute(request);

			HttpEntity entity = response.getEntity();

			if (entity.getContentLength() != 0) {
				Reader employeeReader = new InputStreamReader(response
						.getEntity().getContent());
				char[] buffer = new char[(int) response.getEntity()
						.getContentLength()];
				employeeReader.read(buffer);
				employeeReader.close();
				JSONObject employee = new JSONObject(new String(buffer));
				strRes = employee.getString("userid");
			} else {
				strRes = "empty content";
			}

		} 
		catch (Exception e) {
			strRes = e.getMessage();
		}

		return strRes;

	}
    
         */

        public static String convertStreamToString(Stream myinputstream)
        {
            BufferedReader reader = new BufferedReader(new InputStreamReader(myinputstream));
            StringBuilder sb = new StringBuilder();

            string line = "";

            try
            {
                while ((line = reader.ReadLine()) != null)
                {
                    sb.Append(line + "\n");
                }
            }
            catch (Java.IO.IOException e)
            {
                e.PrintStackTrace();
            }

            finally
            {
                try
                {
                    myinputstream.Close();
                }
                catch (Java.IO.IOException e)
                {
                    e.PrintStackTrace();
                }
            }
            
            return sb.ToString();
        }

    }
}