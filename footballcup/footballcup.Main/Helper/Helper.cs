using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using footballcup.Models;
using CommonUnit;
using System.IO;
using System.Drawing;
using System.Data;


namespace footballcup
{
    public class Helper
    {

        public static byte[] GetImage(string strSourceFileName, System.Drawing.Imaging.ImageFormat imgFormat, int thumbWidth=0, int thumbHeight=0)
        {
            MemoryStream ms = new MemoryStream();
           
            try
            {
                Image img1 = Image.FromFile(strSourceFileName);

                if (thumbWidth == 0 && thumbHeight == 0)
                    img1.Save(ms, imgFormat);
                else
                    img1.GetThumbnailImage(thumbWidth, thumbHeight, null, new System.IntPtr()).Save(ms, imgFormat);

                img1.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return ms.ToArray();
        }
        
        public static void SaveImage(byte[] myImageData, string strTargetFilename, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            try
            {
                MemoryStream ms = new MemoryStream(myImageData);
                Image img1 = Image.FromStream(ms);
                img1.Save(strTargetFilename, imgFormat);
            }
            catch(Exception ex)
            {
                throw;
                //Response.Redirect("http://www.google.com/" + ex.Message);
               
            }
        }

        public static void UploadFile(HttpPostedFileBase UrlUpload, string strPhysicalFilename)
        {
            if (UrlUpload != null && UrlUpload.ContentLength > 0)
            {
                try
                {
                    UrlUpload.SaveAs(strPhysicalFilename);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
            }
        }


    }
}