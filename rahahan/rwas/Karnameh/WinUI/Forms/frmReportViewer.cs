using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RWAS.Common;
using RWAS.BusinessRules;
using Microsoft.Reporting.WinForms;
using Microsoft.SqlServer.Server;

using RWAS.DataAccess;

namespace RWAS.WinUI
{
    public partial class frmReportViewer : Form
    {
        ArrayList arrValues;
        DS_Rep_WorkBookPersonelAccident ocDS_Rep_WorkBookPersonelAccident;
        bool m_IsPersonnelListReport = false;
        DataView m_dvEulogy = new DataView();
        DataView m_dvChastise = new DataView();
        DataView m_dvTraining = new DataView();
        DataView m_dvBodily = new DataView();
        DataView m_dvOperation = new DataView();
        DataView m_dvAccident = new DataView();
        DataView m_dvScore = new DataView();
        DataView m_dvJobStatus = new DataView();
        DataView m_dvPreferment = new DataView();

        public frmReportViewer()
        {
            InitializeComponent();
        }

        public frmReportViewer(ArrayList arrLstValues)
        {
            InitializeComponent();

            arrValues = new ArrayList();
            this.arrValues = arrLstValues;

        }

        public frmReportViewer(bool IsPersonnelListReport)
        {
            InitializeComponent();

            m_IsPersonnelListReport = IsPersonnelListReport;
        }

        string[] GetStringArray(Array myArray)
        {
            string[] arrayResult = null;

            if (myArray != null)
            {
                arrayResult = new string[myArray.Length];

                int i = 0;
                foreach (object myelement in myArray)
                {
                    arrayResult.SetValue(myelement.ToString(), i);
                    i++;
                }
            }

            return arrayResult;
        }

        void initializeReport()
        {
            clsBRReportHandler objBRReportHandler = new clsBRReportHandler();

            string[] arrayRegion = null;
            string[] arraySubContractor = null;
            string[] arrayEmployeeStatus = null;
            string[] arrayStudyStatus = null;
            string[] arrayOrgUnit = null;
            string[] arrayJob = null;
            string strBeginDate = "", strEndDate = "";
            string strFilter="";

            try
            {
                arrayRegion = GetStringArray((object[])arrValues[0]);
                arraySubContractor = GetStringArray((object[])arrValues[4]);
                arrayEmployeeStatus = GetStringArray((object[])arrValues[5]);
                arrayStudyStatus = GetStringArray((object[])arrValues[6]);
                arrayOrgUnit = GetStringArray((object[])arrValues[7]);
                arrayJob = GetStringArray((object[])arrValues[8]);

                strBeginDate = arrValues[9].ToString();
                strEndDate = arrValues[10].ToString();
            }
            catch
            {
            }

            switch (Program.m_objReport.ReportId)
            {
                case classReport.ReportIdType.reportAccident:
                    ocDS_Rep_WorkBookPersonelAccident = objBRReportHandler.SearchDataWorkBookPersonelAccident(
                        (int)enumRepKind.Rep_WorkBook_Accident, arrayRegion
                        , Convert.ToInt32(arrValues[1]),
                        arrValues[2].ToString(),
                        arrValues[3].ToString(),
                        arraySubContractor,
                        arrayEmployeeStatus,
                        arrayStudyStatus,
                        arrayOrgUnit,
                        arrayJob,
                        0, //Convert.ToByte(arrValues[9]),
                        strBeginDate,
                        strEndDate
                        );
                    m_dvAccident = CommonClass.m_PostTable.DefaultView;

                    break;
                case classReport.ReportIdType.reportTrainingTerm:
                    m_dvTraining = dpHadiBusiness.GetPersonnelTraining(Convert.ToInt32(arrValues[1])).Table.DefaultView;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_FromDate>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_FromDate<='" + strEndDate + "'";

                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);

                    m_dvTraining.RowFilter = strFilter;

                    break;
                case classReport.ReportIdType.reportEulogy:


                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_Date>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_Date<='" + strEndDate + "'";

                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);

                    m_dvEulogy.RowFilter = strFilter;

                    m_dvEulogy = dpHadiBusiness.GetPersonnelEulogy(Convert.ToInt32(arrValues[1])).Table.DefaultView;

                    break;
                case classReport.ReportIdType.reportChastise:
                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_Date>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_Date<='" + strEndDate + "'";

                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);

                    m_dvChastise.RowFilter = strFilter;

                    m_dvChastise = dpHadiBusiness.GetPersonnelChastise(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    break;
                case classReport.ReportIdType.reportScore:
                    m_dvScore = Score.GetPersonnelScore(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    break;
                case classReport.ReportIdType.reportWorkBook:
                    ocDS_Rep_WorkBookPersonelAccident = objBRReportHandler.SearchDataWorkBookPersonelAccident(
                        (int)enumRepKind.Rep_WorkBook_Accident, arrayRegion
                        , Convert.ToInt32(arrValues[1]),
                        arrValues[2].ToString(),
                        arrValues[3].ToString(),
                        arraySubContractor,
                        arrayEmployeeStatus,
                        arrayStudyStatus,
                        arrayOrgUnit,
                        arrayJob,
                        0,
                        strBeginDate,
                        strEndDate
                        );
                    m_dvAccident = CommonClass.m_PostTable.DefaultView;

                    m_dvEulogy = dpHadiBusiness.GetPersonnelEulogy(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    m_dvChastise = dpHadiBusiness.GetPersonnelChastise(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    m_dvScore = Score.GetPersonnelScore(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    m_dvTraining = dpHadiBusiness.GetPersonnelTraining(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    m_dvBodily = dpHadiBusiness.GetPersonnelBodily(Convert.ToInt32(arrValues[1])).Table.DefaultView;
                    m_dvOperation = dpHadiBusiness.GetReportPersonnelOperation(Convert.ToInt32(arrValues[1])).Table.DefaultView;

                    PersonnelStatus objPersonnelJobStatus = new PersonnelStatus();
                    objPersonnelJobStatus.UniqueCode = Convert.ToInt32(arrValues[1]);
                    m_dvJobStatus = objPersonnelJobStatus.GetPersonnelJobStatusOfPersonnel(false).Table.DefaultView;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_FromDate>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_FromDate<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvTraining.RowFilter = strFilter;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_Date>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_Date<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvEulogy.RowFilter = strFilter;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_Date>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_Date<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvChastise.RowFilter = strFilter;


                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_CheckupDate>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_CheckupDate<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvBodily.RowFilter = strFilter;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "BeginDate>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And EndDate<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvJobStatus.RowFilter = strFilter;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_FromDate>='" + strBeginDate + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_ToDate<='" + strEndDate + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvPreferment.RowFilter = strFilter;

                    strFilter = "";
                    if (strBeginDate != "")
                        strFilter += "Rws_Fld_MonthYear>='" + strBeginDate.Substring(0,6) + "'";
                    if (strEndDate != "")
                        strFilter += " And Rws_Fld_MonthYear<='" + strEndDate.Substring(0,6) + "'";
                    if (strFilter.StartsWith(" And "))
                        strFilter = strFilter.Remove(0, 5);
                    m_dvOperation.RowFilter = strFilter;



                    break;
            }
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Height = this.MdiParent.Height - 150;
            this.Width = this.MdiParent.Width - 30;
            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            //this.reportViewer1.ZoomMode = ZoomMode.FullPage;


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            List<ReportParameter> paramList = new List<ReportParameter>();

            string strReportServer = Properties.Settings.Default.ReportServer;
            string strReportServerPort = Properties.Settings.Default.ReportServerPort;
            //reportViewer1.ServerReport.ReportServerUrl = new Uri(@"http://" + strReportServer + ":"+strReportServerPort+"/reportserver");

            if (m_IsPersonnelListReport)
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelList.rdlc";

                Prs_Sp_Sel_PersonelTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnel"));
                reportViewer1.LocalReport.DataSources[0].Value = CommonClass.m_PostTable;
                
                Cursor = Cursors.Default;

                return;
            }

            try
            {
                switch (Program.m_objReport.ReportId)
                {
                    case classReport.ReportIdType.reportAccident:
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelAccidents.rdlc";

                        Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        initializeReport();

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelAccident"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvAccident;
                        //Rws_Sp_Rep_WorkBookPersonelAccident_NewTableAdapter.Fill(dsPrimary.Rws_Sp_Rep_WorkBookPersonelAccident_New, 1033, "", "", new List<SqlDataRecord>(), new List<SqlDataRecord>(), new List<SqlDataRecord>(), new List<SqlDataRecord>(), new List<SqlDataRecord>(), new List<SqlDataRecord>(), 0, "", "");

                        /*
                     
                this.BagLabelDataSet.vBag_Parcel.DefaultView.RowFilter = "Parcel_Code='" + Program.m_objReport.ParcelCode + "'";
                        DataTable ss2;
                        ss2 = this.BagLabelDataSet.vBag_Parcel.DefaultView.ToTable();
                        this.BagLabelDataSet.vBag_Parcel.Clear();
                        this.BagLabelDataSet.vBag_Parcel.Merge(ss2);
                     
                         */
                        break;

                    case classReport.ReportIdType.reportBodily:

                        break;
                    case classReport.ReportIdType.reportTrainingTerm:
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelTraining.rdlc";

                        Rws_Sp_Rep_PersonelTrainingTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        initializeReport();

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelTraining"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvTraining;

                        break;
                    case classReport.ReportIdType.reportEulogy:
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelEulogy.rdlc";

                        Rws_Sp_Rep_EulogyTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        paramList.Add(new ReportParameter("pPDate", Program.m_strCurrentPDate));

                        initializeReport();

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelEulogy"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvEulogy;


                        this.reportViewer1.LocalReport.SetParameters(paramList);

                        break;

                    case classReport.ReportIdType.reportChastise:
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelChastise.rdlc";

                        Rws_Sp_Rep_ChastiseTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        initializeReport();

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetChastise"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvChastise;

                        break;
                    case classReport.ReportIdType.reportScore:
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptScore.rdlc";

                        sp_GetPersonnelScoreTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        //paramList.Add(new ReportParameter("pUniqueCode", arrValues[1].ToString()));
                        //this.reportViewer1.LocalReport.SetParameters(paramList);


                        initializeReport();

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetScore"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvScore;

                        break;
                    case classReport.ReportIdType.reportDataEntry:
                        paramList.Add(new ReportParameter("pPDate", Program.m_strCurrentPDate));
                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptDataEntry.rdlc";

                        //vw_Rep_DataEntryTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetDataEntry"));
                        reportViewer1.LocalReport.DataSources[0].Value = CommonClass.m_PostTable.DefaultView;
                        this.reportViewer1.LocalReport.SetParameters(paramList);

                        break;
                    case classReport.ReportIdType.reportWorkBook:

                        reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptWorkBook.rdlc";

                        initializeReport();

                        paramList.Add(new ReportParameter("pPDate", Program.m_strCurrentPDate));
                        paramList.Add(new ReportParameter("pUniqueCode", Program.m_objReport.StringParam));
                        paramList.Add(new ReportParameter("pPersonName", Program.m_objReport.PersonName));
                        paramList.Add(new ReportParameter("pRegionDesc", Program.m_objReport.RegionDesc));
                        paramList.Add(new ReportParameter("pJobDesc", Program.m_objReport.JobDesc));

                        reportViewer1.LocalReport.DataSources.Clear();

                        Rws_Sp_Rep_EulogyTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        Rws_Sp_Rep_ChastiseTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        Rws_Sp_Rep_PersonelTrainingTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        sp_GetPersonnelScoreTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        Rws_Sp_Rep_BodilyMentalStatusTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        sp_Rep_GetPersonnelOperationTableAdapter.Connection = dpHadiData.m_PrimaryConnection;
                        Sp_GetPersonnelJobStatusTableAdapter.Connection = dpHadiData.m_PrimaryConnection;

                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelEulogy"));
                        reportViewer1.LocalReport.DataSources[0].Value = m_dvEulogy;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetChastise"));
                        reportViewer1.LocalReport.DataSources[1].Value = m_dvChastise;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelAccident"));
                        reportViewer1.LocalReport.DataSources[2].Value = m_dvAccident;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelTraining"));
                        reportViewer1.LocalReport.DataSources[3].Value = m_dvTraining;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetScore"));
                        reportViewer1.LocalReport.DataSources[4].Value = m_dvScore;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetBodily"));
                        reportViewer1.LocalReport.DataSources[5].Value = m_dvBodily;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPersonnelOperation"));
                        reportViewer1.LocalReport.DataSources[6].Value = m_dvOperation;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPreferment"));
                        reportViewer1.LocalReport.DataSources[7].Value = m_dvPreferment;
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetJobStatus"));
                        reportViewer1.LocalReport.DataSources[8].Value = m_dvJobStatus;

                        this.reportViewer1.LocalReport.SetParameters(paramList);

                        break;
                }

            }
            catch
            {
            }
            Cursor = Cursors.Default;

        }
    }
}
