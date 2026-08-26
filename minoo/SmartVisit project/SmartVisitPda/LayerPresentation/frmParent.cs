using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.WindowsMobile;
using Microsoft.WindowsMobile.PocketOutlook;
using Microsoft.WindowsMobile.PocketOutlook.MessageInterception;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Data.SqlServerCe;
using layerBusiness;
using GlobalUnit;
using Common;

namespace layerPresentation
{
    public partial class frmParent : Form
    {
        /*
        [DllImport("coredll.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

         */

        MessageInterceptor _smsInterceptor=null;
        delegate void MethodInvoker();
            
        decimal m_nDarkhastSN;

        /*
        enum DarkhastColumns
        {
            colDarkhastsn_Ordinal = 0,
            colDarkhastDate_Ordinal = 1,
            colMoshtarids_Ordinal = 2,
            colMoshtarino_Ordinal = 3,
            colMoshtarisn_Ordinal = 4
        }
        */

        public frmParent()
        {
            InitializeComponent();
        }

        void MessageReceived_OnThread(object sender, MessageInterceptorEventArgs e)
        {
            Sms objSms = new Sms();
            string[] mySplit;

            try
            {
                SmsMessage newMessage = e.Message as SmsMessage;
                if (newMessage != null)
                {
                    objSms.Body = newMessage.Body;
                    objSms.Phone = newMessage.From.Name.Replace("+","").Replace("98","");

                    if (objSms.Phone == MainCommon.m_SmsPhone)
                    {
                        MessageBox.Show("پیامک جدید از مرکز\n");

                        Synchronize objSynchronize = new Synchronize();
                        objSynchronize.PacketString = objSms.Body;

                        Synchronize.UnPack(out mySplit, objSynchronize.PacketString, ',');


                        if (mySplit[0] == ((byte)MainCommon.PacketType.Feedback).ToString() && (mySplit[1] == ((byte)MainCommon.PacketType.Darkhast).ToString() || mySplit[1] == ((byte)MainCommon.PacketType.Marjoo).ToString()))
                        {
                            Darkhast objDarkhast = new Darkhast();
                            Darkhast objOrder = new Darkhast();
                            objOrder.Darkhastsn = decimal.Parse(mySplit[2]);
                            if (mySplit[1] == ((byte)MainCommon.PacketType.Darkhast).ToString())
                            {
                                objOrder.DarkhastStatus = byte.Parse(mySplit[3]);
                                objOrder.dbUpdateStatus();
                            }
                            else
                            {
                                objOrder.DarkhastStatus = byte.Parse(mySplit[3]);
                                //objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.Sending;
                                objOrder.dbUpdateMarjooStatus();
                            }

                            newMessage.Read = true;
                            MessageBox.Show("وضعيت درخواست بروز شد");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"خطا در بروزرساني درخواست", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }

        }

        private void ClearMasterBoxes()
        {
            txtMoshtarino.Text = "";
            txtMoshtarids.Text = "";
            rdoPayType0.Checked = true;
            cboNoeTahvil.SelectedIndex = 0;
            txtOrderType.Text = "";
            txtDalilMarjoo.Text = "";
            txtFactorMarjoo.Text = "";
            lbItemCount.Text = "0";

            txtPdate.Text = MainCommon.m_CurrentPDate;

            if (panMarjooee.Visible == false)
                txtTotalOrder.Text = Darkhast.GetCountOfDarkhast(txtPdate.Text).ToString();
            else
                txtTotalOrder.Text = Darkhast.GetCountOfMarjoo(txtPdate.Text).ToString();
        }

        void HandleNew()
        {
            panelPayType.Show();
            panMarjooee.Hide();
            ClearMasterBoxes();
            m_nDarkhastSN = 1 + Darkhast.GetLastDarkhastSN();
            txtOrderId.Text = m_nDarkhastSN.ToString("###");
            txtOrderType.Text = "ف";
        }

        void HandleUpdate()
        {            
            try
            {
                Darkhast objOrder = new Darkhast();
                bool ExistFlag=true;

                if (panMarjooee.Visible == false)
                {
                    objOrder.Darkhastsn = decimal.Parse(txtOrderId.Text);
                    objOrder.FetchDarkhast();

                    if (objOrder.Darkhastsn == -1)
                        ExistFlag = false;

                    objOrder.Darkhastsn = decimal.Parse(txtOrderId.Text);
                    objOrder.Moshtariinfosn = decimal.Parse(txtMoshtariInfosn.Text);
                    objOrder.DarkhastDate = txtPdate.Text;
                    objOrder.Visitorsn = MainCommon.m_VisitorSN;
                    objOrder.KanaleForooshsn = decimal.Parse(cboKanalForoosh.SelectedValue.ToString());
                    objOrder.VahedeTejarisn = MainCommon.m_VahedeTejariSN;
                    objOrder.NoePardakhtsn = (rdoPayType0.Checked) ? 0 : 1;
                    objOrder.NoeTahvilsn = decimal.Parse(cboNoeTahvil.SelectedValue.ToString());
                    objOrder.ModatVosool = short.Parse(txtModatvosool.Text);
                    objOrder.DarkhastStatus =(byte) MainCommon.PacketStatus.New;

                    if (ExistFlag)
                        objOrder.dbUpdate();
                    else
                        objOrder.dbInsert();

                }

                else
                ///مرجوعی
                {
                    objOrder.Darkhastsn = decimal.Parse(txtOrderId.Text);
                    objOrder.FetchDarkhastMarjoo();
                    if (objOrder.Darkhastsn == -1)
                        ExistFlag = false;

                    objOrder.Darkhastsn = decimal.Parse(txtOrderId.Text);
                    objOrder.Moshtariinfosn = decimal.Parse(txtMoshtariInfosn.Text);
                    objOrder.DarkhastDate = txtPdate.Text;
                    objOrder.Visitorsn = MainCommon.m_VisitorSN;
                    objOrder.KanaleForooshsn = decimal.Parse(cboKanalForoosh.SelectedValue.ToString());
                    objOrder.VahedeTejarisn = MainCommon.m_VahedeTejariSN;

                    objOrder.DalilMarjoo = txtDalilMarjoo.Text;
                    objOrder.FactorMarjoono = txtFactorMarjoo.Text;

                    objOrder.DarkhastStatus = (byte)MainCommon.PacketStatus.New;

                    if (ExistFlag)

                        objOrder.dbUpdateMarjoo();
                    else
                        objOrder.dbInsertMarjoo();
                }
            }
            catch
            {
                throw;
            }
        }

        bool IsValidata()
        {
            bool bResult = true;

            if (!GeneralClass.IsNumeric(txtOrderId.Text))
            {
                bResult = false;
                MessageBox.Show("کد سفارش نامعتبر است");
                txtOrderId.Focus();
                return bResult;
            }

            if (txtMoshtarids.Text == "" || !GeneralClass.IsNumeric(txtMoshtarino.Text))
            {
                bResult = false;
                MessageBox.Show("کد مشتری نامعتبر است");
                txtMoshtarino.Focus();
                return bResult;
            }

            if (panMarjooee.Visible == false)
            {
                if (!GeneralClass.IsNumeric(txtModatvosool.Text))
                {
                    bResult = false;
                    MessageBox.Show("لطفا مقدار عددی وارد نمایید");
                    txtModatvosool.Focus();
                    return bResult;
                }
            }
            else
                ///مرجوعی
            {
                if (txtDalilMarjoo.Text == "")
                {
                    bResult = false;
                    MessageBox.Show("لطفا علت مرجوعی را وارد نمایید");
                    txtDalilMarjoo.Focus();
                    return bResult;
                }

                if (txtFactorMarjoo.Text == "")
                {
                    bResult = false;
                    MessageBox.Show("لطفا فاکتور مرجوعی را وارد نمایید");
                    txtFactorMarjoo.Focus();
                    return bResult;
                }

            }

            return bResult;
        }

        void BindMaster()
        {
            try
            {
                Darkhast objOrders = new Darkhast();
                if (panMarjooee.Visible == false)
                {
                    objOrders.Darkhastsn = m_nDarkhastSN;
                    objOrders.FetchDarkhast();

                    if (objOrders.Darkhastsn != -1)
                    {
                        txtOrderType.Text = "ف";
                        txtOrderId.Text = m_nDarkhastSN.ToString("###");
                        txtPdate.Text = objOrders.DarkhastDate;
                        lbItemCount.Text = objOrders.GetCountOfItems().ToString();
                        /*
                        Customer objMoshtari = new Customer();
                        objMoshtari.FetchMoshtari(objOrders.Moshtariinfosn);
                        txtMoshtariInfosn.Text = objOrders.Moshtariinfosn.ToString();
                        txtMoshtarino.Text = objMoshtari.Moshtarino;
                        txtMoshtarids.Text = objMoshtari.Moshtarids;
                        */

                        txtMoshtariInfosn.Text = objOrders.Moshtariinfosn.ToString();
                        txtMoshtarino.Text = objOrders.MoshtariNo;
                        txtMoshtarids.Text = objOrders.MoshtariDs;

                        cboKanalForoosh.SelectedValue = objOrders.KanaleForooshsn;

                        txtModatvosool.Text = objOrders.ModatVosool.ToString();                                               
                        cboNoeTahvil.SelectedValue = objOrders.NoeTahvilsn;
                        if (objOrders.NoePardakhtsn == 0)
                            rdoPayType0.Checked = true;
                        else
                            rdoPayType1.Checked = true;
                    }
                    else
                    {
                        //MessageBox.Show("سربرگ مورد نظر پیدا نشد");
                        ClearMasterBoxes();
                    }
                }
                else  
                    ///مرجوعی
                {
                    objOrders.Darkhastsn = m_nDarkhastSN;
                    objOrders.FetchDarkhastMarjoo();

                    if (objOrders.Darkhastsn != -1)
                    {
                        txtOrderId.Text = m_nDarkhastSN.ToString("###");
                        txtOrderType.Text = "ب";
                        txtPdate.Text = objOrders.DarkhastDate;
                        cboKanalForoosh.SelectedValue = objOrders.KanaleForooshsn;

                        lbItemCount.Text = objOrders.GetCountOfMarjooItems().ToString();
                        txtMoshtariInfosn.Text = objOrders.Moshtariinfosn.ToString();
                        txtMoshtarino.Text = objOrders.MoshtariNo;
                        txtMoshtarids.Text = objOrders.MoshtariDs;

                        txtDalilMarjoo.Text = objOrders.DalilMarjoo;
                        txtFactorMarjoo.Text = objOrders.FactorMarjoono;                        
                    }

                    else
                    {
                        ClearMasterBoxes();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            _smsInterceptor = new MessageInterceptor(InterceptionAction.Notify);
            _smsInterceptor.MessageReceived += new MessageInterceptorEventHandler(MessageReceived_OnThread);
            //_smsInterceptor.MessageReceived += MessageReceived_OnThread;


            lbTitr.Text = ((AssemblyTitleAttribute)(Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0])).Title;
            lbVersion.Text = "نسخه: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            tabControlMain.SelectedIndex = 3;

            openFileDialog1.InitialDirectory = MainCommon.m_BackupPath;

            FillNoeTahvilCombo();
            FillKanaleForooshCombo();

            ClearMasterBoxes();

            ibtnNew.Image = imageList1.Images[0];
            ibtnSave.Image = imageList1.Images[1];
            ibtnDelete.Image = imageList1.Images[2];
            ibtnGprs.Image = imageList1.Images[3];
            ibtnSms.Image = imageList1.Images[4];
            ibtnMarjooee.Image = imageList1.Images[5];
            ibtnSearchMoshtari.Image = imageList1.Images[6];

            
            //ibtnInfoMoshtari.Image = imageList1.Images[7];
            //ibtnDetail.Image = imageList1.Images[10];
            
            PDateTime objPdate = new PDateTime();
            objPdate.AsDateTime = DateTime.Today;
            MainCommon.m_CurrentPDate = objPdate.AsPDate10;
            HandleNew();
                     
        }

        private void frmParent_Closed(object sender, EventArgs e)
        {
            if (_smsInterceptor != null)
            {
                // Remove event handler to assure proper registry cleanup
                _smsInterceptor.MessageReceived -= MessageReceived_OnThread;
                _smsInterceptor.Dispose();
            }
            Application.Exit();
        }    

        void FillNoeTahvilCombo()
        {
            try
            {
                SqlCeResultSet objSqlceResultset = null;

                objSqlceResultset = MainBusiness.GetAllNoeTahvil();

                if ((objSqlceResultset != null) && (objSqlceResultset.HasRows))
                {
                    cboNoeTahvil.DataSource = objSqlceResultset;
                    cboNoeTahvil.ValueMember = "noetahvilsn";
                    cboNoeTahvil.DisplayMember = "noetahvilds";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillKanaleForooshCombo()
        {
            try
            {
                SqlCeResultSet objSqlceResultset = null;

                objSqlceResultset = MainBusiness.GetAllKanaleForoosh();

                if ((objSqlceResultset != null) && (objSqlceResultset.HasRows))
                {
                    cboKanalForoosh.DataSource = objSqlceResultset;
                    cboKanalForoosh.ValueMember = "kanaleforooshsn";
                    cboKanalForoosh.DisplayMember = "kanaleforooshds";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                PDateTime objPdate = new PDateTime();
                objPdate.AsDateTime = DateTime.Today;

                string strTargetFileName = "DV" + objPdate.PYear.ToString() + objPdate.PMonth.ToString() + objPdate.PDay.ToString() +"_"+DateTime.Now.ToString("HHmm") +".sdf";
                //string strTargetFileName="DigitalVisit_" + DateTime.Now.ToString("yyyyddMM_HHmmtt") + ".sdf";
                System.IO.File.Copy(MainCommon.m_DbPath + "\\DigitalVisit.sdf", MainCommon.m_BackupPath + "\\" + strTargetFileName);
                MessageBox.Show("پشتیبانگیری با موفقیت انجام شد");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


     
        private void treeReport_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            switch (e.Node.Tag.ToString())
            {
                case "nodKala":
                    grdDarkhast.Hide();
                    break;
                case "nodMoshtari":
                    grdDarkhast.Hide();
                    break;
                case "nodOrder":
                    grdDarkhast.Show();
                    grdDarkhast.DataSource = null;
                    break;
                case "nodMarjoo":
                    grdDarkhast.DataSource = null;
                    grdDarkhast.Show();
                    break;
            }
            
        }

        private void grdDarkhast_DoubleClick(object sender, EventArgs e)
        {
            if (grdDarkhast.CurrentRowIndex >= 0)
            {
                    if (treeReport.SelectedNode.Tag.ToString() == "nodOrder")
                    {
                        m_nDarkhastSN = decimal.Parse(grdDarkhast[grdDarkhast.CurrentRowIndex, 0].ToString());
                        
                        panMarjooee.Hide();
                        panelPayType.Show();
                    }
                    else
                    {
                        m_nDarkhastSN = decimal.Parse(grdDarkhast[grdDarkhast.CurrentRowIndex, 0].ToString());
                        panMarjooee.Show();
                        panelPayType.Hide();
                    }

                    BindMaster();
                    tabControlMain.SelectedIndex = 3;
                    panelMaster.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SqlCeResultSet objSqlceResultset = null;

            grdDarkhast.DataSource = null;

            if (treeReport.SelectedNode == null)
            {
                MessageBox.Show("یکی از گزینه های گزارش را انتخاب کنید");
            }
            else
            {
                switch (treeReport.SelectedNode.Tag.ToString())
                {
                    case "nodKala":
                        Cursor.Current = Cursors.WaitCursor;
                        Cursor.Show();
                        frmKala objChild = new frmKala();
                        objChild.Show();
                        Cursor.Current = Cursors.Default;
                        Cursor.Hide();
                        break;
                    case "nodMoshtari":
                        Cursor.Current = Cursors.WaitCursor;
                        Cursor.Show();
                        frmMoshtari objFrmMoshtari = new frmMoshtari(true);
                        objFrmMoshtari.Show();
                        Cursor.Current = Cursors.Default;
                        Cursor.Hide();
                        break;
                    case "nodOrder":
                        objSqlceResultset = Darkhast.GetDarkhast();
                        colDarkhastSn.MappingName = "darkhastsn";
                        colDarkhastDate.MappingName = "darkhastdate";
                        grdDarkhast.DataSource = objSqlceResultset;
                        break;
                    case "nodMarjoo":
                        objSqlceResultset = Darkhast.GetDarkhastMarjoo();
                        colDarkhastSn.MappingName = "darkhastmarjoosn";
                        colDarkhastDate.MappingName = "darkhastmarjoodate";
                        grdDarkhast.DataSource = objSqlceResultset;
                        break;
                }
            }
        }

        private void ibtnNew_Click(object sender, EventArgs e)
        {
            HandleNew();
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidata())
            {
                try
                {
                    HandleUpdate();
                    MessageBox.Show("اطلاعات سربرگ با موفقیت ذخیره شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ibtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا درخواست حذف شود؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Darkhast objOrder = new Darkhast();
                objOrder.Darkhastsn = decimal.Parse(txtOrderId.Text);


                try
                {
                    if (panMarjooee.Visible == false)
                    {
                        objOrder.dbDeleteDetails();
                        objOrder.dbDelete();
                    }
                    else
                    {
                        objOrder.dbDeleteDetailsMarjoo();
                        objOrder.dbDeleteMarjoo();
                    }

                    MessageBox.Show("اطلاعات با موفقیت حذف شد");
                    ClearMasterBoxes();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ibtnGprs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا بسته داده‌ها ارسال شود؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lbItemCount.Text == "0")
                {
                    MessageBox.Show("سفارش هیچ کالایی ندارد");
                }
                else
                {
                    bool bIsOrder = (panMarjooee.Visible == false);
                    frmSync objChild = new frmSync(m_nDarkhastSN, bIsOrder, (byte)MainCommon.SendType.GPRS);
                    objChild.Show();
                }
            }
        }

        private void ibtnSms_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا پیامک ارسال شود؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lbItemCount.Text == "0")
                {
                    MessageBox.Show("سفارش هیچ کالایی ندارد");
                }
                else
                {

                    bool bIsOrder = (panMarjooee.Visible == false);
                    frmSync objChild = new frmSync(m_nDarkhastSN, bIsOrder, (byte)MainCommon.SendType.SMS);
                    objChild.Show();
                }
            }
        }

        private void ibtnMarjooee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا درخواست فعلی لغو شود و درخواست مرجوعی ثبت شود؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelPayType.Hide();
                panMarjooee.Show();
                ClearMasterBoxes();
                m_nDarkhastSN = 1 + Darkhast.GetLastMarjooSN();
                txtOrderId.Text = m_nDarkhastSN.ToString("###");
                txtOrderType.Text = "ب";
            }

        }

        private void ibtnDetail_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();

            if (txtOrderId.Text == "")
            {
                MessageBox.Show("درخواست مورد نظر وجود ندارد");
            }
            else
            {
                try
                {
                    if (IsValidata())
                    {
                        HandleUpdate();

                        m_nDarkhastSN = decimal.Parse(txtOrderId.Text);

                        if (panMarjooee.Visible == false)
                        {
                            frmDetail objChild = new frmDetail(m_nDarkhastSN, true);
                            objChild.Show();                            
                        }
                        else
                        ///مرجوعی
                        {
                            frmDetail objChild = new frmDetail(m_nDarkhastSN, false);
                            objChild.Show();
                        }                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Cursor.Current = Cursors.Default;
            Cursor.Hide();
        }

        private void ibtnSearchMoshtari_Click(object sender, EventArgs e)
        {
            if (txtMoshtarino.Text == "")
            {
                frmMoshtari objChild = new frmMoshtari();
                objChild.ShowDialog();
                txtMoshtarino.Text = objChild.MoshtariNo;
                txtMoshtarids.Text = objChild.MoshtariDs;
                txtMoshtariInfosn.Text = objChild.MoshtariInfosn.ToString();
            }
            else
            {
                if (GeneralClass.IsNumeric(txtMoshtarino.Text))
                {
                    Customer objMoshtari = new Customer();
                    objMoshtari.FetchMoshtariByMoshtariNo(txtMoshtarino.Text);
                    if (objMoshtari.MoshtariInfosn == -1)
                    {
                        MessageBox.Show("مشتری مورد نظر وجود ندارد");
                        txtMoshtarids.Text = "";
                        txtMoshtariInfosn.Text = "";
                    }
                    else
                    {
                        txtMoshtariInfosn.Text = objMoshtari.MoshtariInfosn.ToString();
                        txtMoshtarids.Text = objMoshtari.Moshtarids;
                    }
                }
                else
                    txtMoshtarids.Text = "";

            }

        }

        private void ibtnInfoMoshtari_Click(object sender, EventArgs e)
        {
            if (txtMoshtarino.Text != "")
            {
                frmMoshtari objChild = new frmMoshtari(txtMoshtarino.Text);
                objChild.ShowDialog();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                try
                {
                    MainBusiness.RestoreDb(openFileDialog1.FileName);
                    MessageBox.Show("بازیابی بانک انجام شد. لطفا از برنامه خارج و مجددا وارد شوید");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmPassword objChild = new frmPassword();
            objChild.Show();
        }

        private void inputPanel1_EnabledChanged(object sender, EventArgs e)
        {
            panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height  : this.Height;
            //panelMain.Height = inputPanel1.Enabled ? inputPanel1.VisibleDesktop.Height + 40 : this.Height;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از برنامه خارج می شوید؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            this.Close();
        }

        private void frmParent_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void frmParent_GotFocus(object sender, EventArgs e)
        {
            inputPanel1.Enabled = false;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting objChild = new frmSetting();
            objChild.Show();
        }

        private void rdoPayType1_CheckedChanged(object sender, EventArgs e)
        {
            txtModatvosool.Enabled = rdoPayType1.Checked;
        }

        private void rdoPayType0_CheckedChanged(object sender, EventArgs e)
        {
            txtModatvosool.Enabled = rdoPayType1.Checked;
            if (rdoPayType0.Checked)
            {
                txtModatvosool.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            frmSync objChild = new frmSync();
            objChild.Show();
        }

        private void frmParent_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("آیا از برنامه خارج می شوید؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
                //this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmParent_Activated(object sender, EventArgs e)
        {
            if (m_nDarkhastSN != -1)
            {
                Darkhast objOrders = new Darkhast();
                objOrders.Darkhastsn = m_nDarkhastSN;

                if (panMarjooee.Visible==false)
                    lbItemCount.Text = objOrders.GetCountOfItems().ToString();
                else
                    lbItemCount.Text = objOrders.GetCountOfMarjooItems().ToString();
            }
        }

        private void btnReadSms_Click(object sender, EventArgs e)
        {
            Sms objSms = new Sms();

            objSms.ReceiveSMS();
            MessageBox.Show(objSms.Phone);
            MessageBox.Show(objSms.Body);

        }

        private void linkHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(MainCommon.m_DbPath+"\\smartvisit_UserManual.mht", "");
        }

        private void txtMoshtarino_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        ///bind کردن یک کنترل به dataset
        /*
        
       private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (Program.m_PrgMod != Program.PrgMod.BindingData)
           {
               //Program.m_PrgMod = Program.PrgMod.BindingData;

               if (cboCustomer.SelectedIndex > -1)
               {
                   txtMoshtarino.Text = cboCustomer.SelectedValue.ToString();

                   ResultSetView myView = ((SqlCeResultSet)cboCustomer.DataSource).ResultSetView;
                    
                   txtMoshtarino.DataBindings.Clear();
                   txtMoshtarino.DataBindings.Add("Text", myView, "moshtarino");
                   txtMoshtarino.BindingContext[myView].Position += cboCustomer.SelectedIndex;
               }

               //Program.m_PrgMod = Program.PrgMod.Normal;
           }
       }
        */
   
    }
}