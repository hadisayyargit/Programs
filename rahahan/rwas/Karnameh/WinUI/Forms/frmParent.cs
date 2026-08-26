using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProgLib.Configuration.Event;
using ProgLib;
using ProgLib.Configuration.Login;
using ProgLib.Configuration;
using ProgLib.Classes;
using RWAS.Common;
using RWAS.BusinessRules;
using RWAS.WinUI;
using System.Reflection;

namespace RWAS.WinUI
{
    public partial class frmParent : Form
    {
        private int childFormNumber = 0;

        public static string strUserRegion;


        #region const

        enum eFeloatMenuItem
        {
            efmSurvey = 0,
            efmWorkBook = 1,
            efmAccident = 2,
            efmEdit = 3,
            efmBase = 4,
            efmManagement = 5,
            efmHelp = 6,
            efmTools = 7
        }
        #endregion const


        public frmParent()
        {
            InitializeComponent();
        }


        void CheckMenuItemAccess(ToolStripMenuItem myItem)
        {
            DataRow[] myRows;

            if (myItem.CanSelect)
            {
                myRows = CommonClass.m_dtUserAccess.Select("ObjectId='" + Common.CommonClass.m_ApplicationId + "_"  + myItem.Name + "'");

                if (myRows.Length == 0)
                    myRows = CommonClass.m_dtGroupAccess.Select("ObjectId='" + Common.CommonClass.m_ApplicationId + "_"  + myItem.Name + "'");

                if (myRows.Length == 0)
                {
                    //myItem.Visible = false;
                    myItem.Enabled = false;
                }
                else
                {
                    //myItem.Visible = (bool)myRows[0]["IsVisible"];
                    myItem.Visible = true;
                    myItem.Enabled = (bool)myRows[0]["IsEnable"];
                }


                for (int i = 0; i < myItem.DropDownItems.Count; i++)
                {
                    if (myItem.DropDownItems[i].CanSelect)
                        CheckMenuItemAccess((ToolStripMenuItem)myItem.DropDownItems[i]);
                }
            }

        }

        private void CheckAccess()
        {
            if (Program.m_UserId.ToLower() == "admin")
            {
                return;
            }

            CommonClass.m_dtGroupAccess = UserAccessRight.GetAccessRight(Program.m_UserGroupId, null);
            CommonClass.m_dtUserAccess = UserAccessRight.GetAccessRight(-1, Program.m_UserId);

            for (int i = 0; i < menuStrip.Items.Count; i++)
            {
                ((ToolStripMenuItem)menuStrip.Items[i]).Enabled = false;
            }

            tsbtnWorkBook.Enabled = false;

            mniAdmin.Visible = false;
            mniAdmin.Enabled = false;
            mniAddUser.Visible = false;
            mniAddUser.Enabled = false;
            mniAccessRight.Visible = false;
            mniAccessRight.Enabled = false;
            mniAppObject.Visible = false;
            mniAppObject.Enabled = false;


            for (int i = 0; i < menuStrip.Items.Count; i++)
                CheckMenuItemAccess((ToolStripMenuItem)menuStrip.Items[i]);

            tsbtnWorkBook.Enabled = mniWorkBook.Enabled;
            tsbtnReport.Enabled = mniReports_Karnameh.Enabled;

            mniRelogin.Visible = false;

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void mniContents_Click(object sender, EventArgs e)
        {
            FrmHelp objChild = new FrmHelp();
            objChild.MdiParent = this;
            objChild.Show();
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            mniWorkBook.Image = imageList1.Images["hat.jpg"];
            tsbtnWorkBook.Image = imageList1.Images["hat.jpg"];
            tsbtnContent.Image = imageList1.Images["help2.gif"];
            mniContents.Image = imageList1.Images["help2.gif"];
            tsbtnExit.Image = imageList1.Images["exit.ico"];
            tsbtnReport.Image = imageList1.Images["chart.gif"];

            if (Program.m_UserId == "admin")
                tslbUser.Text = "راهبر سیستم";
            else
                tslbUser.Text = Program.m_UserPersonnelName;

            tslbDate.Text = Program.m_strCurrentPDate;
            tslbServer.Text = "اتصال به سرور: " + Properties.Settings.Default.ServerName;
            tslbDatabase.Text = "پایگاه داده‌ها: " + Properties.Settings.Default.DatabaseName;
            tslbVersion.Text = "شماره نگارش: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            CheckAccess();
            mniViewData.Visible = false;
        }

        private void frmParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mniReport_Accident_Click(object sender, EventArgs e)
        {

        }

        private void mniWorkBook_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmWorkBook objChild = new frmWorkBook();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniSubContractor_Click(object sender, EventArgs e)
        {
            try
            {
                //resetFlafs();
                //setFlafs((int)FormID.FrmSubContractor);

                //FrmSubContractor objFrmSubContractor = new FrmSubContractor(picMain.Width, picMain.Height, blnIns, blnUpd, blnDel);
                frmSubContractor objFrmSubContractor = new frmSubContractor();
                objFrmSubContractor.StartPosition = FormStartPosition.CenterScreen;

                //objMenu.Location = new Point(this.Width, 30);

                objFrmSubContractor.ShowDialog(this);
            }
            catch (System.Exception ocException)
            {

                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 14), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, this.Name);

            }

        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox objChild = new frmAboutBox();
            objChild.MdiParent = this;
            objChild.Show();

        }


        private void mniRegion_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmRegion objChild = new FrmRegion();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniStations_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmStation objChild = new FrmStation();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniPersonnel_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmPersonnel objChild = new frmPersonnel();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniChastiseReason_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmChastiseReason objChild = new FrmChastiseReason();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniHealthItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmHealthItem objChild = new FrmHealthItem();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }


        private void mniWebReport_Click(object sender, EventArgs e)
        {
            string strUrl = Properties.Settings.Default.ReportPath;
            System.Diagnostics.Process.Start(strUrl);

        }


        private void mniRelogin_Click(object sender, EventArgs e)
        {

        }

        private void mniEncouragement_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmEncouragement objChild = new frmEncouragement();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniErrorLog_Click(object sender, EventArgs e)
        {

        }

        private void mniAddUser_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmUserDefine objChild = new FrmUserDefine();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniChangePassword_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmPasswordChange objChild = new frmPasswordChange();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniAccessRight_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmUserAccess objChild = new frmUserAccess();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniAppObject_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmAppObject objChild = new frmAppObject();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniViewData_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmViewData objChild = new frmViewData();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniJob_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmJob objChild = new frmJob();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void mniTerm_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmTrainingTerm objChild = new frmTrainingTerm();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniAccidentPenalty_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmForfeitKind objChild = new frmForfeitKind();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniDonor_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                frmDonor objChild = new frmDonor();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniReports_Operation_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportOperation;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();

        }

        private void mniReports_Accident_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportAccident;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_Eulogy_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportEulogy;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_Chastise_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportChastise;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_TrainingTerm_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportTrainingTerm;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_Bodily_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportBodily;
            FrmWorkBookRep objChild = new FrmWorkBookRep();
            //FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_Karnameh_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportWorkBook;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniReports_DataEntry_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportDataEntry;
            //frmReportViewer objChild = new frmReportViewer();
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();

        }

        private void mniReports_Score_Click(object sender, EventArgs e)
        {
            Program.m_objReport.ReportId = classReport.ReportIdType.reportScore;
            FrmWorkBookRep objChild = new FrmWorkBookRep();

            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniCalculateScore_Click(object sender, EventArgs e)
        {
            frmScore_Calculate objChild = new frmScore_Calculate();

            objChild.MdiParent = this;
            objChild.Show();

        }



    }
}
