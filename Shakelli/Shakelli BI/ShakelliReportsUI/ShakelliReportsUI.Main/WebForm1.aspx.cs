using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShakelliReportsUI.DataLayer.Models;
using GlobalUnits;
using Microsoft.Reporting.WebForms;

namespace ShakelliReportsUI.Main
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //ReportParameter pTitle = new ReportParameter("pTitle", "از ناریخ93/01/31  تا تاریخ: 93/01/31");
                //ReportParameter pAnbarid = new ReportParameter("Anbarid", "1030");
                //ReportParameter pSTOCKREF = new ReportParameter("STOCKREF", "52");
                //ReportParameter pIsOkPishnahad = new ReportParameter("IsOkPishnahad", "0");
                //ReportParameter pFdate = new ReportParameter("Fdate", "93/01/01");
                //ReportParameter pTodate = new ReportParameter("Todate", "93/01/31");


                //    ReportViewerControl1.ProcessingMode = ProcessingMode.Remote;
                //    ReportViewerControl1.ServerReport.ReportServerUrl = new Uri(@"http://pooyeshdbtest/ReportServer_MSSQLSERVER2012");

                //    ReportViewerControl1.ServerReport.ReportPath = "/ShakelliReports/rptKardex";
                //    ReportViewerControl1.ShowParameterPrompts = true;
                //    ReportViewerControl1.ServerReport.ReportServerCredentials = new ReportServerCredentials(@"hadi", "hx_1323027");

                //   ReportViewerControl1.ServerReport.SetParameters(new ReportParameter[] { pTitle, pAnbarid, pSTOCKREF, pIsOkPishnahad, pFdate, pTodate });


            }
        }
    }
}