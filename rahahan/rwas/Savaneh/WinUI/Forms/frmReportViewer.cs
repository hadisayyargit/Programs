using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.Common;
using Microsoft.Reporting.WinForms;

namespace RWAS.WinUI
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Height = this.MdiParent.Height - 150;
            this.Width = this.MdiParent.Width - 30;
            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            //this.reportViewer1.ZoomMode = ZoomMode.FullPage;

            reportViewer1.ProcessingMode = ProcessingMode.Remote;

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string strReportServer = Properties.Settings.Default.ReportServer;
                string strReportServerPort = Properties.Settings.Default.ReportServerPort;
                reportViewer1.ServerReport.ReportServerUrl = new Uri(@"http://" + strReportServer + ":" + strReportServerPort + "/reportserver");
                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = new System.Net.NetworkCredential("ssrs", "ssrs", "");

                
                //reportViewer1.ShowCredentialPrompts = false;

                /*
                DataSourceCredentials objDC=new DataSourceCredentials();
                objDC.Name = "datasourceRWAS";
                objDC.UserId="savanehowner";
                objDC.UserId="savaneh8888";

                reportViewer1.ServerReport.SetDataSourceCredentials(new DataSourceCredentials[] { objDC });
            
                 */

                List<ReportParameter> paramList = new List<ReportParameter>();
                //paramList.RemoveAll();


                switch (Program.m_objReport.ReportId)
                {
                    case classReport.ReportIdType.reportTest:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/Report1";
                        break;
                    case classReport.ReportIdType.reportAccident:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccident";
                        break;
                    case classReport.ReportIdType.reportHumanDelinquent:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentBlameful";
                        break;
                    case classReport.ReportIdType.reportWagonDelinquent:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportRailVehicleBlameful";
                        break;
                    case classReport.ReportIdType.reportLoss:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportLoss";
                        break;
                    case classReport.ReportIdType.reportDieAndAfoul:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportDieAndAfoul";
                        break;
                    case classReport.ReportIdType.reportAgentDieAndAfoul:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAgentDieAndAfoul";
                        break;
                    case classReport.ReportIdType.reportAccidentStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentStatistics";
                        break;
                    case classReport.ReportIdType.reportAccidentStatistics_Matrix:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentStatisticsMatrix";
                        break;
                    case classReport.ReportIdType.reportAccidentBlockStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentStatistics";
                        break;
                    case classReport.ReportIdType.reportHumanDelinquentStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentBlamefulStatistics";
                        break;
                    case classReport.ReportIdType.reportWagonDelinquentStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportRailVehicleBlamefulStatistics";
                        break;
                    case classReport.ReportIdType.reportLossStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportLossStatistics";
                        break;
                    case classReport.ReportIdType.reportDieAndAfoulStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportDieAndAfoulStatistics";
                        break;
                    case classReport.ReportIdType.reportAgentDieAndAfoulStatistics:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAgentDieAndAfoulStatistics";
                        break;
                    case classReport.ReportIdType.reportSeir:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/ReportSeir";
                        break;


                }
                switch (Program.m_objReport.ReportId)
                {
                    case classReport.ReportIdType.reportTest:
                        paramList.Add(new ReportParameter("pMyArray", new string[] { "a", "b" }));
                        this.reportViewer1.ServerReport.SetParameters(paramList);

                        break;

                    case classReport.ReportIdType.reportAccident:
                    case classReport.ReportIdType.reportHumanDelinquent:
                    case classReport.ReportIdType.reportWagonDelinquent:
                    case classReport.ReportIdType.reportLoss:
                    case classReport.ReportIdType.reportDieAndAfoul:
                    case classReport.ReportIdType.reportAgentDieAndAfoul:
                        paramList.Add(new ReportParameter("pPDate", Program.m_objReport.PrintPDate));
                        paramList.Add(new ReportParameter("pTitr", Program.m_objReport.Titr));
                        paramList.Add(new ReportParameter("pTitle", Program.m_objReport.SubTitle));
                        paramList.Add(new ReportParameter("pFooterTitle", Program.m_objReport.Footer));

                        paramList.Add(new ReportParameter("pBeginDate", CommonClass.GetDateWithoutSlash(Program.m_objReport.BeginDate)));
                        paramList.Add(new ReportParameter("pEndDate", CommonClass.GetDateWithoutSlash(Program.m_objReport.EndDate)));
                        
                        paramList.Add(new ReportParameter("pCategory", Program.m_objReport.CategoryList));
                        paramList.Add(new ReportParameter("pRegion", Program.m_objReport.RegionList));
                        paramList.Add(new ReportParameter("pRailwayVehicleKind", Program.m_objReport.RailWayVehicleKindList));
                        paramList.Add(new ReportParameter("pReason", Program.m_objReport.ReasonList));
                        paramList.Add(new ReportParameter("pAccidentKind", Program.m_objReport.AccidentKindList));
                        paramList.Add(new ReportParameter("pEffective", Program.m_objReport.EffectiveList));
                        paramList.Add(new ReportParameter("pDegree", Program.m_objReport.DegreeList));
                        paramList.Add(new ReportParameter("pLocation", Program.m_objReport.LocationList));
                        
                        paramList.Add(new ReportParameter("pHasLoss", Program.m_objReport.HasLoss.ToString()));
                        paramList.Add(new ReportParameter("pHasAfoul", Program.m_objReport.HasAfoul.ToString()));
                        paramList.Add(new ReportParameter("pHasBlameful", Program.m_objReport.HasBlameful.ToString()));
                        paramList.Add(new ReportParameter("pHasDie", Program.m_objReport.HasDie.ToString()));
                        paramList.Add(new ReportParameter("pHasBarred", Program.m_objReport.HasBarred.ToString()));
                        paramList.Add(new ReportParameter("pHasManouver", (Program.m_objReport.HasManouver == -1) ? null : Program.m_objReport.HasManouver.ToString()));

                        paramList.Add(new ReportParameter("pShowColumn", Program.m_objReport.ShowColumn.ToString()));
                        paramList.Add(new ReportParameter("pSortColumn", Program.m_objReport.SortColumn1));

                        this.reportViewer1.ServerReport.SetParameters(paramList);

                        break;
                    case classReport.ReportIdType.reportAccidentStatistics:
                    case classReport.ReportIdType.reportAccidentStatistics_Matrix:
                    case classReport.ReportIdType.reportAccidentBlockStatistics:
                    case classReport.ReportIdType.reportHumanDelinquentStatistics:
                    case classReport.ReportIdType.reportWagonDelinquentStatistics:
                    case classReport.ReportIdType.reportLossStatistics:
                    case classReport.ReportIdType.reportDieAndAfoulStatistics:
                    case classReport.ReportIdType.reportAgentDieAndAfoulStatistics:
                        paramList.Add(new ReportParameter("pPDate", Program.m_objReport.PrintPDate));
                        paramList.Add(new ReportParameter("pTitr", Program.m_objReport.Titr));
                        paramList.Add(new ReportParameter("pTitle", Program.m_objReport.SubTitle));
                        paramList.Add(new ReportParameter("pFooterTitle", Program.m_objReport.Footer));

                        paramList.Add(new ReportParameter("pBeginDate", CommonClass.GetDateWithoutSlash(Program.m_objReport.BeginDate)));
                        paramList.Add(new ReportParameter("pEndDate", CommonClass.GetDateWithoutSlash(Program.m_objReport.EndDate)));
                        
                        paramList.Add(new ReportParameter("pCategory", Program.m_objReport.CategoryList));
                        paramList.Add(new ReportParameter("pRegion", Program.m_objReport.RegionList));
                        paramList.Add(new ReportParameter("pRailwayVehicleKind", Program.m_objReport.RailWayVehicleKindList));
                        paramList.Add(new ReportParameter("pReason", Program.m_objReport.ReasonList));
                        paramList.Add(new ReportParameter("pAccidentKind", Program.m_objReport.AccidentKindList));
                        paramList.Add(new ReportParameter("pEffective", Program.m_objReport.EffectiveList));
                        paramList.Add(new ReportParameter("pDegree", Program.m_objReport.DegreeList));
                        paramList.Add(new ReportParameter("pLocation", Program.m_objReport.LocationList));
                        
                        paramList.Add(new ReportParameter("pHasLoss", Program.m_objReport.HasLoss.ToString()));
                        paramList.Add(new ReportParameter("pHasAfoul", Program.m_objReport.HasAfoul.ToString()));
                        paramList.Add(new ReportParameter("pHasBlameful", Program.m_objReport.HasBlameful.ToString()));
                        paramList.Add(new ReportParameter("pHasDie", Program.m_objReport.HasDie.ToString()));
                        paramList.Add(new ReportParameter("pHasBarred", Program.m_objReport.HasBarred.ToString()));
                        //paramList.Add(new ReportParameter("pHasManouver", Program.m_objReport.HasManouver.ToString()));
                        paramList.Add(new ReportParameter("pHasManouver", (Program.m_objReport.HasManouver == -1) ? null : Program.m_objReport.HasManouver.ToString()));

                        paramList.Add(new ReportParameter("pShowColumn", Program.m_objReport.ShowColumn.ToString()));
                        paramList.Add(new ReportParameter("pSortColumn", Program.m_objReport.SortColumn1));
                        paramList.Add(new ReportParameter("pGroupName1", Program.m_objReport.GroupColumn1));
                        paramList.Add(new ReportParameter("pGroupName2", Program.m_objReport.GroupColumn2));
                        paramList.Add(new ReportParameter("pGroupName3", Program.m_objReport.GroupColumn3));
                        paramList.Add(new ReportParameter("pGroupName4", Program.m_objReport.GroupColumn4));
                        paramList.Add(new ReportParameter("pGroupDesc1", Program.m_objReport.GroupDesc1));
                        paramList.Add(new ReportParameter("pGroupDesc2", Program.m_objReport.GroupDesc2));
                        paramList.Add(new ReportParameter("pGroupDesc3", Program.m_objReport.GroupDesc3));
                        paramList.Add(new ReportParameter("pGroupDesc4", Program.m_objReport.GroupDesc4));
                        this.reportViewer1.ServerReport.SetParameters(paramList);
                        break;
                    case classReport.ReportIdType.reportCroquis:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/reportAccidentLocation";
                        paramList.Add(new ReportParameter("pTitle", Program.m_objReport.SubTitle));
                        paramList.Add(new ReportParameter("pPDate", Program.m_objReport.PrintPDate));
                        paramList.Add(new ReportParameter("pPKEarlyAccident", Program.m_objReport.PKEarlyAccident.ToString()));
                        this.reportViewer1.ServerReport.SetParameters(paramList);
                        break;
                    case classReport.ReportIdType.reportTrainArrangement:
                        reportViewer1.ServerReport.ReportPath = "/RwasReport/ReportTrainArrangement";
                        paramList.Add(new ReportParameter("pTitle", Program.m_objReport.SubTitle));
                        paramList.Add(new ReportParameter("pPDate", Program.m_objReport.PrintPDate));
                        paramList.Add(new ReportParameter("pPKEarlyAccident", Program.m_objReport.PKEarlyAccident.ToString()));
                        this.reportViewer1.ServerReport.SetParameters(paramList);

                        break;
                    case classReport.ReportIdType.reportSeir:
                        paramList.Add(new ReportParameter("pTitr", Program.m_objReport.Titr));
                        paramList.Add(new ReportParameter("pTitle", Program.m_objReport.SubTitle));
                        paramList.Add(new ReportParameter("pPDate", Program.m_objReport.PrintPDate));
                        paramList.Add(new ReportParameter("pBeginDate", Program.m_objReport.BeginDate));
                        paramList.Add(new ReportParameter("pTrainNo", Program.m_objReport.TrainNo.ToString()));
                        this.reportViewer1.ServerReport.SetParameters(paramList);

                        break;

                }

                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    
    }
}
