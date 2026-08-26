using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using RWAS.WinUI;
using RWAS.Common;

namespace RWAS.WinUI
{
    static class Program
    {
        #region public

        /// <summary>
        ///    روالها و توابع و متغيرهاي سراسري 
        /// </summary>		
        /// 
        public enum PrgMod { MainForm, Normal, NewRecord, EditRecord, FormLoading, BindingData };

        public static PrgMod m_PrgMod;

        public static string m_UserId;
        public static int m_UserGroupId;
        public static int m_UserRegion;
        public static int m_UserPersonnelID;                      
        public static string m_UserPersonnelName;        

        public static ProgLib.Configuration.SystemID m_System;

        public static string m_strCurrentPDate;
        public static string m_strCurrentPDateNoneSlash;
        public static DateTime m_dtmCurrentTime;

        public static classReport m_objReport = new classReport();

        public static void ExitApplication()
        {
            //dpDataLayer.m_dbConnection.Close();
            Application.Exit();
        }


        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;


            m_dtmCurrentTime = DateTime.Now;
            PersianCalendar objPersianCalendar = new PersianCalendar();
            int nYear, nMonth, nDay;


            m_System = ProgLib.Configuration.SystemID.idWorkbook;
            nYear = objPersianCalendar.GetYear(DateTime.Now);
            nMonth = objPersianCalendar.GetMonth(DateTime.Now);
            //s1 = objPersianCalendar.GetDayOfWeek(DateTime.Now).ToString();
            nDay = objPersianCalendar.GetDayOfMonth(DateTime.Now);
            m_strCurrentPDate = nYear.ToString()+"/"+nMonth.ToString("00")+"/"+nDay.ToString("00");
            m_strCurrentPDateNoneSlash = CommonClass.GetDateWithoutSlash(m_strCurrentPDate);

            //GlobalUnit.MakeColumnsTable();
            ///<Hadi>
            //Program.m_bISApplicationTest = true;
            ///</Hadi>
            try
            {
                DataAccess.dpHadiData.m_CommandTimeout = int.Parse(Properties.Settings.Default.CommandTimeout);
                if (DataAccess.dpHadiData.m_CommandTimeout < 30)
                    DataAccess.dpHadiData.m_CommandTimeout = 30;                
            }
            catch
            {
                MessageBox.Show("خطا در خواندن متغیر CommandTimeout", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataAccess.dpHadiData.m_CommandTimeout = 30;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
