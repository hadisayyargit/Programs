using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using OpenNETCF.Desktop.Communication;

namespace SmartVisitClient
{
    public partial class frmSynchronize : Form
    {        
        bool m_TransferFlag=false;        

        public frmSynchronize()
        {
            InitializeComponent();
        }

        void WriteLog(string strMessage, Color pencolor)
        {
            txtLog.SelectionCharOffset = 0;
            txtLog.SelectionColor = pencolor;
            txtLog.SelectedText = DateTime.Now.ToString()+"\t"+ strMessage + "\r\n" + txtLog.SelectedText;
            txtLog.Refresh();
        }

        void InitDeviceConnection()
        {                        
            RAPI objRapi = new RAPI();
            try
            {
                objRapi.Connect();

                //objRapi.Disconnect();
                lbActiveSyncStatus.Text = "اتصال";
                lbActiveSyncVersion.Text = objRapi.ActiveSync.Version;
            }
            catch
            {
                throw;
            }
        }

        void PrepareTransfer()
        {
            try
            {
                InitDeviceConnection();
                WriteLog("دریافت بانک دستگاه...", Color.Black);
                SmartBusiness.ReceiveDbFile();
                WriteLog("دریافت بانک با موفقیت انجام شد", Color.Black);
                WriteLog("باز کردن بانک دستگاه...", Color.Black);
                SmartBusiness.PrepareMainConnection();
                SmartBusiness.ReadVisitorInfo();

                try
                {
                    cboVisitor.SelectedValue = SmartBusiness.m_Visitorsn;
                }
                catch
                {
                    SmartBusiness.m_Visitorsn = 0;
                }

                if (cboVisitor.SelectedValue == null)
                    SmartBusiness.m_Visitorsn = 0;        

                m_TransferFlag = true;
                CheckTransferFlag();
            }
            catch
            {
                m_TransferFlag = false;
                throw;
            }

        }

        void TransferData()
        {
            try
            {
                if (SmartBusiness.m_Visitorsn == 0)
                {
                    WriteLog("کد فروشنده نامعتبر است", Color.Red);
                }

                else
                {
                    WriteLog("خواندن اطلاعات درخواستها ...", Color.Black);
                    SmartBusiness.ReadDarkhast();
                    //WriteLog("خواندن اطلاعات درخواستها با موفقیت انجام شد", Color.Black);

                    WriteLog("نوشتن اطلاعات درخواستها در بانک اصلی ...", Color.Black);
                    SmartBusiness.WriteDarkhast();
                    WriteLog("تعداد سربرگ=" + SmartBusiness.dtDarkhast.Rows.Count.ToString(), Color.Black);
                    WriteLog("تعداد سربرگ تکراری=" + SmartBusiness.m_Repeated.ToString(), Color.Red);

                    WriteLog("نوشتن اطلاعات درخواستهای مرجوعی در بانک اصلی ...", Color.Black);
                    SmartBusiness.WriteDarkhastMarjoo();
                    WriteLog("تعداد سربرگ مرجوع=" + SmartBusiness.dtDarkhastMarjoo.Rows.Count.ToString(), Color.Black);
                    WriteLog("تعداد سربرگ مرجوع تکراری=" + SmartBusiness.m_Repeated.ToString(), Color.Red);


                    WriteLog("حذف داده‌های قدیمی ...", Color.Black);
                    SmartBusiness.DeleteData("pdDarkhastha");
                    SmartBusiness.DeleteData("pdDarkhast");
                    SmartBusiness.DeleteData("pdDarkhastMarjooha");
                    SmartBusiness.DeleteData("pdDarkhastMarjoo");
                    SmartBusiness.DeleteData("pdKalaPayam");
                    SmartBusiness.DeleteData("pdKalaInfo");
                    SmartBusiness.DeleteData("pdKala");
                    SmartBusiness.DeleteData("pdGorooheKala");
                    SmartBusiness.DeleteData("pdKanaleForoosh");
                    SmartBusiness.DeleteData("pdMoshtari");
                    SmartBusiness.DeleteData("pdNoeTahvil");
                    SmartBusiness.DeleteData("pdTaminKonandeh");
                    SmartBusiness.DeleteData("pdVahedeTejari");
                    SmartBusiness.DeleteData("pdVisitor");
                    SmartBusiness.DeleteData("pdUser");

                    //WriteLog("حذف داده‌های قدیمی با موفقیت انجام شد", Color.Black);

                    WriteLog("بارگذاری اطلاعات پایه واحد تجاری", Color.Black);
                    SmartBusiness.Upload_VahedeTejari();
                    WriteLog("بارگذاری اطلاعات پایه نوع تحویل...", Color.Black);
                    SmartBusiness.Upload_NoeTahvil();
                    WriteLog("بارگذاری اطلاعات پایه تأمین کننده...", Color.Black);
                    SmartBusiness.Upload_TaminKonandeh();
                    WriteLog("بارگذاری اطلاعات پایه کانال فروش...", Color.Black);
                    SmartBusiness.Upload_KanaleForoosh();
                    WriteLog("بارگذاری اطلاعات پایه گروه کالا...", Color.Black);
                    SmartBusiness.Upload_GorooheKala();
                    WriteLog("بارگذاری اطلاعات پایه کالا...", Color.Black);
                    SmartBusiness.Upload_Kala();
                    WriteLog("بارگذاری اطلاعات ریز کالا", Color.Black);
                    SmartBusiness.Upload_KalaInfo();
                    WriteLog("بارگذاری اطلاعات پایه پیام", Color.Black);
                    SmartBusiness.Upload_KalaPayam();
                    WriteLog("بارگذاری اطلاعات پایه فروشنده", Color.Black);
                    SmartBusiness.Upload_Visitor();
                    WriteLog("بارگذاری جدول کاربر...", Color.Black);
                    SmartBusiness.Upload_User();
                    WriteLog("بارگذاری اطلاعات پایه مشتری...", Color.Black);
                    SmartBusiness.Upload_Moshtari();

                    //WriteLog("بارگذاری اطلاعات پایه با موفقیت انجام شد", Color.Black);

                    WriteLog("فشرده سازی و بازسازی بانک اطلاعات...", Color.Black);
                    SqlMobile.RepairDatabase();
                    //WriteLog("فشرده سازی و بازسازی بانک اطلاعات با موفقیت انجام شد", Color.Black);

                    WriteLog("ارسال اطلاعات به دستگاه...", Color.Black);
                    SmartBusiness.SendDbFile();
                    WriteLog("ارسال اطلاعات با موفقیت انجام شد", Color.Black);
                }
            }

            catch
            {
                throw;
            }
        }

        void CheckTransferFlag()
        {
            if (!m_TransferFlag)
                btnSync.Text = "آماده سازی";
            else
                btnSync.Text = "تبادل داده‌ها";
        }

        private void frmSynchronize_Load(object sender, EventArgs e)
        {
            lbActiveSyncVersion.Text = "";
            SmartBusiness.dsOrder.Tables.Add(SmartBusiness.dtDarkhast);
            SmartBusiness.dsOrder.Tables.Add(SmartBusiness.dtDarkhastha);
            SmartBusiness.dsOrder.Tables.Add(SmartBusiness.dtDarkhastMarjoo);
            SmartBusiness.dsOrder.Tables.Add(SmartBusiness.dtDarkhastMarjooha);

            SmartBusiness.m_ClientTempDbPath = Application.ExecutablePath;

            //dpData.m_PrimaryConnection = new SqlConnection("Data Source=ags;Initial Catalog=mis;Integrated Security=True");
            try
            {
                dpData.m_PrimaryConnection = new SqlConnection("Data Source=Tehrnoffices;Initial Catalog=MIS;Persist Security Info=True;User ID=vdigital;password=vdigital");

            }
            catch
            {
            }

            DataView myView = SmartBusiness.GetAllVisitor();
            cboVisitor.DataSource = myView;
            cboVisitor.ValueMember = "VisitorSn";
            cboVisitor.DisplayMember = "VisitorName";
            cboVisitor.SelectedIndex = -1;


            SmartBusiness.m_DeviceDbPath = @"\Storage Card\SmartVisit";

            txtDbPath.Text = SmartBusiness.m_DeviceDbPath;

            CheckTransferFlag();
        } 

        private void btnDbSetting_Click(object sender, EventArgs e)
        {
            gbCommand.Enabled = false;
            gbSetting.Show();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            btnSync.Enabled = false;
            txtLog.Clear();
            WriteLog("شروع",Color.Blue);

            try
            {
                if (!m_TransferFlag)
                    PrepareTransfer();
                else
                    TransferData();
            }

            catch (Exception ex)
            {
                WriteLog(ex.Message, Color.Red);
            }

        
            try
            {
                SqlMobile.CloseSqlCompactConnection();
            }
            catch
            {
            }

            WriteLog("پایان",Color.Blue);
            btnSync.Enabled = true;
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SmartBusiness.m_DeviceDbPath = txtDbPath.Text;

                if (cboVisitor.SelectedValue != null)
                {
                    SmartBusiness.m_Visitorsn = Convert.ToDecimal(cboVisitor.SelectedValue);
                }
            }
            catch
            {
            }

            gbSetting.Hide();
            gbCommand.Enabled = true;
        }  
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            RAPI objRapi = new RAPI();
            try
            {
                objRapi.Connect();                
            }
            catch
            {
            }

            if (objRapi.Connected)
            {
                lbActiveSyncStatus.Text = "اتصال";
                lbActiveSyncVersion.Text = objRapi.ActiveSync.Version;
            }
            else
            {
                lbActiveSyncStatus.Text = "قطع اتصال";
            }
        }


        private void cboVisitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                cboVisitor.SelectedIndex = -1;
            }
        }
    }
}
