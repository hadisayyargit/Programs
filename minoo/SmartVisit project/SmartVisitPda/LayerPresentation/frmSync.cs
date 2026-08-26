using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using layerBusiness;
using GlobalUnit;
using Common;

namespace layerPresentation
{
    public partial class frmSync : Form
    {
        decimal m_nDarkhastSN = 0;
        bool m_IsOrder;
        byte m_nSendingType = 0;
        MinooWcfServiceLibrary.MessageService m_MinooWcfService = new layerPresentation.MinooWcfServiceLibrary.MessageService();

        public frmSync()
        {
            InitializeComponent();
        }

        public frmSync(decimal nDarkhastsn, bool IsOrder, byte SendingType)
        {
            InitializeComponent();
            m_IsOrder = IsOrder;
            m_nDarkhastSN = nDarkhastsn;
            m_nSendingType = SendingType;
        }

        void WriteLog(string strMessage)
        {
            txtLog.Text = txtLog.Text + "\r\n" + strMessage + "\t" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
            txtLog.Refresh();
        }

        void ReceiveViaGprs()
        {
            string[] mySplit = new string[] { };

            try
            {                
                Synchronize objSynchronize = new Synchronize();
                WriteLog("در حال دریافت بسته موجودی کالا...");
                objSynchronize.PacketString = m_MinooWcfService.GetPacketInQueue((decimal)MainCommon.PacketType.KalaMojoodi, true, MainCommon.m_Sim);
                if (objSynchronize.PacketString.Length > 0)
                {
                    Synchronize.UnPack(out mySplit, objSynchronize.PacketString, ';');
                    WriteLog("تعداد کالا=" + mySplit.Length.ToString());

                    Synchronize.SyncKalaMojoodi(mySplit);
                }

                objSynchronize = new Synchronize();
                WriteLog("در حال دریافت بسته نرخ کالا...");
                objSynchronize.PacketString = m_MinooWcfService.GetPacketInQueue((decimal)MainCommon.PacketType.KalaNerkh, true, MainCommon.m_Sim);
                if (objSynchronize.PacketString.Length > 0)
                {
                    Synchronize.UnPack(out mySplit, objSynchronize.PacketString, ';');
                    WriteLog("تعداد کالا=" + mySplit.Length.ToString());
                    Synchronize.SyncKalaNerkh(mySplit);
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        void SendViaGprs(decimal darkhastsn,bool isorder)
        {
            long nSerialId = -1;
            bool flag = true;

            if (darkhastsn != 0)
            {                
                WriteLog("در حال ساخت بسته...");
                WriteLog("شماره درخواست: " + darkhastsn.ToString());
                Synchronize objSynchronize = new Synchronize();
                objSynchronize.Darkhastsn = darkhastsn;

                Darkhast objOrder = new Darkhast();
                objOrder.Darkhastsn = darkhastsn;

                if (isorder)
                {
                    objOrder.FetchDarkhast();
                    objSynchronize.Pack_Darkhast();
                }
                else
                {
                    objOrder.FetchDarkhastMarjoo();
                    objSynchronize.Pack_Marjoo();
                }

                //Gprs.ConnectGPRS(",,,");

                try
                {
                    WriteLog("در حال ارسال بسته...");
                    if (isorder)
                        m_MinooWcfService.SendPacket(ref nSerialId, ref flag, (decimal)MainCommon.PacketType.Darkhast, true, (decimal)MainCommon.SendType.GPRS, true, MainCommon.m_Sim, objSynchronize.PacketString,objOrder.VahedeTejariNo);
                    else
                        m_MinooWcfService.SendPacket(ref nSerialId, ref flag, (decimal)MainCommon.PacketType.Marjoo, true, (decimal)MainCommon.SendType.GPRS, true, MainCommon.m_Sim, objSynchronize.PacketString, objOrder.VahedeTejariNo);

                    
                    WriteLog("شماره سریال ارسال: " + nSerialId.ToString());
                    
                    if (isorder)
                    {
                        objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.SendedToVDS;
                        objOrder.dbUpdateStatus();
                    }
                    else
                    {
                        objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.SendedToVDS;
                        objOrder.dbUpdateMarjooStatus();
                    }                    
                }
                catch (Exception ex)
                {
                    WriteLog(ex.Message);
                }
            }
            else
            {
                //for all darkhast
            }

        }

        void SendViaSms()
        {
            long nSerialId = -1;
            bool flag = true;


            if (m_nDarkhastSN != 0)
            {
                WriteLog("در حال ساخت بسته...");
                WriteLog("شماره درخواست: " + m_nDarkhastSN.ToString());
                Synchronize objSynchronize = new Synchronize();
                objSynchronize.Darkhastsn = m_nDarkhastSN;

                if (m_IsOrder)
                    objSynchronize.Pack_Darkhast();
                else
                    objSynchronize.Pack_Marjoo();


                try
                {
                    Sms objSms = new Sms();
                    objSms.Phone = MainCommon.m_SmsPhone;
                    objSms.Body = objSynchronize.PacketString;
                    objSms.SendSMS();
                    //WriteLog("شماره سریال ارسال: " + nSerialId.ToString());

                    Darkhast objOrder = new Darkhast();
                    objOrder.Darkhastsn = m_nDarkhastSN;

                    if (m_IsOrder)
                    {
                        objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.Sending;
                        objOrder.dbUpdateStatus();
                    }
                    else
                    {
                        objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.Sending;
                        objOrder.dbUpdateMarjooStatus();
                    }

                    //WriteLog("شماره سریال ارسال اقلام: " + nSerialId.ToString());
                    WriteLog("اطلاعات ارسال شد");
                }

                catch (Exception ex)
                {
                    WriteLog(ex.Message);
                }
            }
        }

        private void frmSync_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (m_nDarkhastSN>0)
            {
                ibtnSyncAll.Visible = false;
                ibtnSyncBasic.Visible = false;
                lbAll.Visible = false;
                lbBasic.Visible = false;
            }
            else
            {
                m_nSendingType = (byte)MainCommon.SendType.GPRS;
            }

            ibtnSyncAll.Image = imageList1.Images[1];
            //ibtnNotSended.Image = imageList1.Images[0];
            ibtnSyncBasic.Image = imageList1.Images[2];

            PdaSetting objPdaSetting = new PdaSetting();
            objPdaSetting.FetchSetting();

            try
            {
                MainCommon.m_ServerIp = objPdaSetting.ServerIP;

                if (MainCommon.m_TestMod)
                    MainCommon.m_ServerIp = "sayyar7-gh-it";

                MainCommon.m_SmsPhone = objPdaSetting.SmsPhone;
                MainCommon.m_Sim = objPdaSetting.Sim;
            }
            catch
            {
            }

            if (m_nSendingType == (byte)MainCommon.SendType.GPRS)
            {
                txtServerIp.Text = "ارسال به سرور: " + MainCommon.m_ServerIp;
            }
            else if (m_nSendingType == (byte)MainCommon.SendType.SMS)
            {
                txtServerIp.Text = "ارسال پیامک به شماره: " + MainCommon.m_SmsPhone;
            }

            try
            {
                if (m_nSendingType == (byte)MainCommon.SendType.GPRS)
                {
                    WriteLog("در حال برقراری ارتباط با سرور...");                    
                    m_MinooWcfService.Url = "http://" + MainCommon.m_ServerIp + "/MinooWcfServiceLibrary/MessageService.svc";
                    WriteLog("ارتباط برقرار شد");                    
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }

        }


        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height + 40 : this.Height;
        }

        private void ibtnSyncAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("همه برگه‌های بانک اطلاعات ارسال شوند؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                Cursor.Show();

                progressBar1.Value = 0;

                txtLog.Text = "";
                WriteLog("شروع");

                ibtnNotSended.Enabled = false;
                ibtnSyncAll.Enabled = false;
                ibtnSyncBasic.Enabled = false;

                WriteLog("ارسال همه سربرگها");

                SqlCeResultSet objDarkhastResultset;
                objDarkhastResultset = Darkhast.GetDarkhast();

                int nRowCount = 0;

                while (objDarkhastResultset.Read())
                {
                    nRowCount++;
                }

                WriteLog("تعداد درخواست=" + nRowCount.ToString());
                progressBar1.Maximum = nRowCount;                

                if (objDarkhastResultset.HasRows)
                {
                    objDarkhastResultset.ReadFirst();
                    do
                    {
                        SendViaGprs(objDarkhastResultset.GetDecimal(objDarkhastResultset.GetOrdinal("darkhastsn")), true);
                        progressBar1.Value++;

                    }
                    while (objDarkhastResultset.Read());
                }

                SqlCeResultSet objMarjooResultset;
                objMarjooResultset = Darkhast.GetDarkhastMarjoo();
                nRowCount = 0;

                while (objMarjooResultset.Read())
                {
                    nRowCount++;
                }

                WriteLog(" تعداد درخواست مرجوعی=" + nRowCount.ToString());
                progressBar1.Maximum = nRowCount;
                progressBar1.Value = 0;

                if (objMarjooResultset.HasRows)
                {
                    objMarjooResultset.ReadFirst();
                    do
                    {
                        SendViaGprs(objMarjooResultset.GetDecimal(objMarjooResultset.GetOrdinal("darkhastmarjoosn")), false);
                        progressBar1.Value++;
                    }
                    while (objMarjooResultset.Read());
                }
                WriteLog("پایان");

                ibtnNotSended.Enabled = true;
                ibtnSyncAll.Enabled = true;
                ibtnSyncBasic.Enabled = true;

                Cursor.Current = Cursors.Default;
                Cursor.Hide();
            }
        }
        private void ibtnNotSended_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();

            progressBar1.Value = 0;

            txtLog.Text = "";
            WriteLog("شروع");

            ibtnNotSended.Enabled = false;
            ibtnSyncAll.Enabled = false;
            ibtnSyncBasic.Enabled = false;

            if (m_nDarkhastSN > 0)
            {
                WriteLog("ارسال سربرگ");
                /// ُSync Current Order

                if (m_nSendingType == (byte)MainCommon.SendType.GPRS)
                    SendViaGprs(m_nDarkhastSN, m_IsOrder);
                else if (m_nSendingType == (byte)MainCommon.SendType.SMS)
                    SendViaSms();

            }

            else
            {
                WriteLog("ارسال برگه‌های ارسال نشده");
                /// ُSync not sended

                SqlCeResultSet objDarkhastResultset;
                objDarkhastResultset = Darkhast.GetNotSendedDarkhast();

                int nRowCount = 0;

                while (objDarkhastResultset.Read())
                {
                    nRowCount++;
                }

                WriteLog("تعداد درخواست=" + nRowCount.ToString());
                progressBar1.Maximum = nRowCount;
                if (objDarkhastResultset.HasRows)
                {
                    objDarkhastResultset.ReadFirst();
                    do
                    {
                        SendViaGprs(objDarkhastResultset.GetDecimal(objDarkhastResultset.GetOrdinal("darkhastsn")), true);
                        progressBar1.Value++;
                    }

                    while (objDarkhastResultset.Read());
                }

                SqlCeResultSet objMarjooResultset;
                objMarjooResultset = Darkhast.GetNotSendedMarjoo();
                nRowCount = 0;

                while (objMarjooResultset.Read())
                {
                    nRowCount++;
                }

                WriteLog(" تعداد درخواست مرجوعی=" + nRowCount.ToString());
                progressBar1.Maximum = nRowCount;
                progressBar1.Value = 0;

                if (objMarjooResultset.HasRows)
                {
                    objMarjooResultset.ReadFirst();
                    do
                    {
                        SendViaGprs(objMarjooResultset.GetDecimal(objMarjooResultset.GetOrdinal("darkhastmarjoosn")), false);
                        progressBar1.Value++;
                    }
                    while (objMarjooResultset.Read());
                }
            }

            WriteLog("پایان");

            ibtnNotSended.Enabled = true;
            ibtnSyncAll.Enabled = true;
            ibtnSyncBasic.Enabled = true;

            Cursor.Current = Cursors.Default;
            Cursor.Hide();

        }

        private void ibtnSyncBasic_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();

            ibtnSyncAll.Enabled = false;
            ibtnNotSended.Enabled = false;
            ibtnSyncBasic.Enabled = false;
            m_nSendingType = (byte)MainCommon.SendType.GPRS;
            progressBar1.Value = 0;

            txtLog.Text = "";
            WriteLog("شروع");
            WriteLog("دریافت اطلاعات پایه");
            ReceiveViaGprs();

            WriteLog("پایان");
            ibtnSyncAll.Enabled = true;
            ibtnNotSended.Enabled = true;
            ibtnSyncBasic.Enabled = true;

            Cursor.Current = Cursors.Default;
            Cursor.Hide();

        }

        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnSaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                PDateTime objPdate = new PDateTime();
                objPdate.AsDateTime = DateTime.Today;

                string strTargetFileName = "Log" + objPdate.PYear.ToString() + objPdate.PMonth.ToString() + objPdate.PDay.ToString() + ".txt";
                //if (!File.Exists(MainCommon.m_BackupPath +"\\"+strTargetFileName)) 

                StreamWriter sw=System.IO.File.CreateText(MainCommon.m_BackupPath +"\\"+strTargetFileName);
                sw.Write(txtLog.Text);
                sw.Close();
                MessageBox.Show("فایل فعالیتها ذخیره شد");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

   

    }
}