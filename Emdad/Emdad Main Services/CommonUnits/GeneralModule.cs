using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Resources;
using System.Web;

namespace CommonUnits
{
    public class GeneralModule
    {
        public const int transition_Begin = 0;
        public const int transition_Error = -1;
        public const int transition_Fail = -2;
        public const int transition_Success = 100;
        public const int transition_MainMenu = 9;
        public const int transition_KharidMenu = 1;
        public const int transition_GetNationalCode = 2;        
        public const int transition_Hint = 3;
        public const int transition_InvalidNationalCode = 4;
        public const int transition_PayRequest = 5;
        public const int transition_CustomerExists = 6;
        public const int transition_CpError = 7;
        public const int transition_Notify = 8;
        public const int transition_RequisitionSuccess = 11;

        public const int UssdState_NonUSSD = 0;
        public const int UssdState_Begin = 1;
        public const int UssdState_Continue = 2;
        public const int UssdState_End = 3;
        public const int UssdState_Abort = 4;

        public static string m_KharidMenu = "";
        public static string m_KharidMenu_Finglish = "";

        public static List<string> m_mpaadcodeList = new List<string>();
        public static List<string> m_FinalPriceList = new List<string>();
        public static List<string> m_PackageIdList = new List<string>();

        public static string m_UserId = "";
        public static string m_Password = "";
        public static string m_msgActivate = "";

        public static SqlConnection m_EcommerceConnection = new SqlConnection();
        public static SqlConnection m_Total85Connection = new SqlConnection();

        /// <summary>
        /// 
        /// </summary>
        /// <author>Hadi</author> 
        /// <param name="strFilename"></param>
        /// <param name="strInput"></param>
        public static void writeLog(string strFilename, string strInput)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(strFilename, true))
                {
                    try
                    {
                        sw.WriteLine(strInput);
                    }
                    catch
                    {
                        throw;
                    }
                    finally
                    {
                        sw.Close();
                    }
                }
            }

            catch
            {
                throw;
            }

        }

        public static bool CheckCodeMelli(string strCode)
        {
            Code_meli objCodeMelli = new Code_meli();
            return objCodeMelli.chek(strCode);
            
        }

    }
}