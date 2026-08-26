using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using ProgLib.Configuration.Event;
using ProgLib;
using ProgLib.Configuration.Login;
using ProgLib.Configuration;
using ProgLib.Classes;
using RWAS.Common;
using RWAS.BusinessRules;
using RWAS.WinUI;

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
                myRows =CommonClass.m_dtUserAccess.Select("ObjectId='" + Common.CommonClass.m_ApplicationId + "_"  + myItem.Name + "'");

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

            tsbtnAccidentPrimaryReport.Enabled = false;
            tsbtnEditAccident.Enabled = false;
            tsbtnAccidentPrimaryReportDetail.Enabled = false;
            tsbtnAccidentSecondaryReport.Enabled = false;
            tsbtnAccidentSecondaryReportDetail.Enabled = false;
            tsbtnRpt_Accident_Detail.Enabled = false;


            mniAddUser.Visible = false;
            mniAddUser.Enabled = false;
            mniAccessRight.Visible = false;
            mniAccessRight.Enabled = false;
            mniAppObject.Visible = false;
            mniAppObject.Enabled = false;
            

            for (int i = 0; i < menuStrip.Items.Count; i++)
                CheckMenuItemAccess((ToolStripMenuItem)menuStrip.Items[i]);

            tsbtnAccidentPrimaryReport.Enabled = (mniAccidentPrimaryReport.Enabled);
            tsbtnEditAccident.Enabled = mniEditAccident.Enabled;
            tsbtnAccidentPrimaryReportDetail.Enabled = mniAccidentPrimaryReportDetail.Enabled;
            tsbtnAccidentSecondaryReport.Enabled = mniAccidentSecondaryReport.Enabled;
            tsbtnAccidentSecondaryReportDetail.Enabled = mniAccidentSecondaryReportDetail.Enabled;
            tsbtnRpt_Accident_Detail.Enabled = mniRptGeneral_Primary.Enabled;
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
            try
            {
                tsbtnAccidentPrimaryReport.Image = imageList1.Images["Icon28.png"];
                mniAccidentPrimaryReport.Image = imageList1.Images["clipboard.bmp"];
                tsbtnContent.Image = imageList1.Images["help2.gif"];
                mniContents.Image = imageList1.Images["help2.gif"];
                tsbtnExit.Image = imageList1.Images["exit.ico"];
                tsbtnAccidentPrimaryReportDetail.Image = imglstEarlyAccident.Images[0];
                tsbtnAccidentSecondaryReport.Image = imglstSecondaryAccident.Images[1];
                tsbtnAccidentSecondaryReportDetail.Image = imglstEarlyAccident.Images[1];
                tsbtnAccidentDelinquent.Image = imglstSecondaryAccident.Images[0];

                if (Program.m_UserId == "admin")
                    tslbUser.Text = "راهبر سیستم";
                else
                    tslbUser.Text = Program.m_UserPersonnelName;

                tslbDate.Text = Program.m_strCurrentPDate;
                tslbServer.Text = "اتصال به سرور: " + Properties.Settings.Default.ServerName;
                tslbDatabase.Text = "پایگاه داده‌ها: " + Properties.Settings.Default.DatabaseName;
                tslbVersion.Text = "شماره نگارش: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();


                CheckAccess();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mniReport_Accident_Click(object sender, EventArgs e)
        {

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

                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, this.Name);

            }

        }

        private void mniAccidentReason_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmAccidentReason objChild = new FrmAccidentReason();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniAccidentPrimaryReport_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild == null)
            {
                FrmEarlyAccidentReport objChild = new FrmEarlyAccidentReport();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniAccidentPrimaryReportDetail_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmLoadAccidentReport objChild = new FrmLoadAccidentReport((int)AccidentReportKind.SupplementalAccident);

                objChild.MdiParent = this;
                objChild.Show();

            }

        }

        private void mniAccidentSecondaryReport_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmLoadAccidentReport objChild = new FrmLoadAccidentReport((int)AccidentReportKind.SecondaryAccident);
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniAccidentSecondaryReportDetail_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmLoadAccidentReport objChild = new FrmLoadAccidentReport((int)AccidentReportKind.SecondaryDetailAccident);
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniEditAccident_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                //resetFlafs();
                //setFlafs((int)FormID.FrmEarlyAccidentReport);

                FrmLoadAccidentReport objChild = new FrmLoadAccidentReport((int)AccidentReportKind.EarlyAccident);
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            frmAboutBox objChild = new frmAboutBox();
            objChild.MdiParent = this;
            objChild.Show();
        }

        private void mniAccidentCategory_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmAccidentCategory objChild = new FrmAccidentCategory();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniAccidentDegree_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                FrmAccidentDegree objChild = new FrmAccidentDegree();
                objChild.MdiParent = this;
                objChild.Show();
            }
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

        private void mniReport_Accident_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        private void mniWebReport_Click(object sender, EventArgs e)
        {
            //WebBrowser.Navigate@"C:\Hadi\Documents\Projects\Programs\rahahan\rwas\RWAS\WinUI\Help\ADMIN.htm", ref obj, ref obj, ref obj, ref obj);
            string strUrl = Properties.Settings.Default.ReportPath;
            System.Diagnostics.Process.Start(strUrl);            
        }

        private void mniRptCroquis_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                Program.m_objReport.ReportId = classReport.ReportIdType.reportCroquis;
                Program.m_objReport.Titr = mniRptCroquis.Text;
                frmDialogReport objChild = new frmDialogReport();
                objChild.MdiParent = this;
                objChild.Show();
            }

        }

        private void mniRptArrangementCroquis_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                Program.m_objReport.ReportId = classReport.ReportIdType.reportTrainArrangement;
                Program.m_objReport.Titr = mniRptArrangementCroquis.Text;
                frmDialogReport objChild = new frmDialogReport();
                objChild.MdiParent = this;
                objChild.Show();
            }
        }

        private void mniRelogin_Click(object sender, EventArgs e)
        {

        }

         private void mniRptGeneral_Primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAccident;
                 //Program.m_objReport.ReportId = classReport.ReportIdType.reportTest;
                 Program.m_objReport.Titr = "گزارش کلی - اختصاصی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
            
         }

         private void mniRptGeneral_Statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAccidentStatistics;
                 Program.m_objReport.Titr = "گزارش کلی - مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptHumanDelinquent_Primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportHumanDelinquent;
                 Program.m_objReport.Titr = "گزارش مسئولین و مقصرین حادثه - اختصاصی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptHumanDelinquent_Statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportHumanDelinquentStatistics;
                 Program.m_objReport.Titr = "گزارش مسئولین و مقصرین حادثه - مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptWagonDelinquent_primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportWagonDelinquent;
                 Program.m_objReport.Titr = "گزارش وسایل ریلی عامل حادثه-اختصاصی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptWagonDelinquent_statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportWagonDelinquentStatistics;
                 Program.m_objReport.Titr = "گزارش وسایل ریلی عامل حادثه-مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptLoss_Primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportLoss;
                 Program.m_objReport.Titr = "گزارش خسارات مالی - اختصاصی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptLoss_Statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportLossStatistics;
                 Program.m_objReport.Titr = "گزارش خسارات مالی - مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptDieAndAfoul_primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportDieAndAfoul;
                 Program.m_objReport.Titr = "گزارش تلفات جانی - اختصاصی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
         }

         private void mniRptDieAndAfoul_statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportDieAndAfoulStatistics;
                 Program.m_objReport.Titr = "گزارش تلفات جانی - مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptAgentDieAndAfoul_primary_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAgentDieAndAfoul;
                 Program.m_objReport.Titr = mniRptAgentDieAndAfoul.Text;
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
         }

         private void mniRptAgentDieAndAfoul_statistics_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAgentDieAndAfoulStatistics;
                 Program.m_objReport.Titr = mniRptAgentDieAndAfoul.Text + "-" + "مجموع";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
         }

         private void mniRptGeneral_StatisticsBlock_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAccidentBlockStatistics;
                 Program.m_objReport.Titr = "گزارش مجموع بر اساس بلاکهای حادثه خیز";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
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

         private void mniAccidentKind_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 frmAccidentKind objChild = new frmAccidentKind();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniEffective_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 frmEffective objChild = new frmEffective();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void mniRptGeneral_Statistics_Matrix_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAccidentStatistics_Matrix;
                 Program.m_objReport.Titr = "گزارش کلی - مجموع ماتریسی";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
         }

         private void mniReport_Seir_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportSeir;
                 Program.m_objReport.Titr = "گزارش سیر و حرکت";
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }
         }

         private void mniRptMedia_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 Program.m_objReport.ReportId = classReport.ReportIdType.reportAccidentMedia;
                 Program.m_objReport.Titr = mniRptMedia.Text;
                 frmDialogReport objChild = new frmDialogReport();
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }

         private void button1_Click(object sender, EventArgs e)
         {
             frmPersonnelSearch frm1 = new frmPersonnelSearch();
             frm1.Show();
         }

         private void tsbtnAccidentDelinquent_Click(object sender, EventArgs e)
         {
             if (this.ActiveMdiChild == null)
             {
                 FrmLoadAccidentReport objChild = new FrmLoadAccidentReport((int)AccidentReportKind.Delinquent);
                 objChild.MdiParent = this;
                 objChild.Show();
             }

         }


    }
}
