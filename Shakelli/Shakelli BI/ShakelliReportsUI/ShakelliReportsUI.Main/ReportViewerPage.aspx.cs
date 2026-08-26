using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using ShakelliReportsUI.DataLayer.Models;
using GlobalUnits;

namespace ShakelliReportsUI.Main
{
    public partial class ReportViewerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportModel myReportModel = new ReportModel();

                try
                {
                    myReportModel = (ReportModel)Session[CommonUnits.GeneralModule.m_ReportModel];

                    //List<postReportData> myReportData = ViewBag.ReportData;
                    //List<postReportData> myReportData = (List<postReportData>)Session[CommonUnits.GeneralModule.m_postReportData];

                    if (myReportModel.HasServerReport)
                    {
                        ReportViewerControl1.ProcessingMode = ProcessingMode.Remote;
                        //ReportViewerControl1.ServerReport.ReportServerUrl = new Uri(@"http://172.20.4.2/ReportServer");

                        ReportViewerControl1.ServerReport.ReportServerUrl = new Uri(System.Configuration.ConfigurationManager.AppSettings["MvcReportViewer.ReportServerUrl"]);

                        ReportViewerControl1.ServerReport.ReportPath = myReportModel.UrlPath;
                        ReportViewerControl1.ShowParameterPrompts = false;

                        //ReportViewerControl1.ServerReport.ReportServerCredentials = new ReportServerCredentials(@"WIN-5UCN71M9VO2\ssrs", "bokhari#63");
                        ReportViewerControl1.ServerReport.ReportServerCredentials = new ReportServerCredentials(System.Configuration.ConfigurationManager.AppSettings["MvcReportViewer.Username"], System.Configuration.ConfigurationManager.AppSettings["MvcReportViewer.Password"]);

                        ReportParameterInfoCollection myParameters = ReportViewerControl1.ServerReport.GetParameters();

                        if (myReportModel.ReportParameters != null && myReportModel.ReportParameters.Count() > 0)
                            ReportViewerControl1.ServerReport.SetParameters(myReportModel.ReportParameters);
                        /*
                            ReportParameter pTitle = new ReportParameter("pTitle", (myReportModel.ReportTitle) == null ? string.Empty : myReportModel.ReportTitle);
                            ReportParameter pReportDate = new ReportParameter("pReportDate", myReportModel.ReportDate);
                            ReportViewerControl1.LocalReport.SetParameters(new ReportParameter[] { pTitle, pReportDate });
                         */

                        Session["localreport"] = ReportViewerControl1.ServerReport;

                    }

                    else
                    {
                        DataTable myReportData = ((DataSet)Session[CommonUnits.GeneralModule.m_postReportData]).Tables[0];

                        ///for local reports
                        ReportViewerControl1.ProcessingMode = ProcessingMode.Local;
                        //ReportViewerControl1.LocalReport.ReportPath = "rptGauge.rdlc";
                        ReportViewerControl1.LocalReport.ReportPath = myReportModel.UrlPath;

                        ReportViewerControl1.LocalReport.DataSources.Clear();
                        ReportViewerControl1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1"));
                        ReportViewerControl1.LocalReport.DataSources[0].Value = myReportData;


                        this.ReportViewerControl1.DataBind();
                        

                        ReportParameterInfoCollection myParameters = ReportViewerControl1.LocalReport.GetParameters();
                        if (myParameters.Count() > 0)
                                ReportViewerControl1.LocalReport.SetParameters(myReportModel.ReportParameters);
                        /*
                            ReportParameter pTitle = new ReportParameter("pTitle", (myReportModel.ReportTitle) == null ? string.Empty : myReportModel.ReportTitle);
                            ReportParameter pReportDate = new ReportParameter("pReportDate", myReportModel.ReportDate);
                            ReportViewerControl1.LocalReport.SetParameters(new ReportParameter[] { pTitle, pReportDate });
                         */

                        //    }

                        Session["localreport"] = ReportViewerControl1.LocalReport;
                    }

                    /*
                           /// Exporting
                           byte[] pdfContent=ReportViewerControl1.LocalReport.Render("PDF");
                           System.IO.FileStream  pdffile=new System.IO.FileStream("d:\\ss2.pdf", System.IO.FileMode.Create);
                           pdffile.Write(pdfContent, 0, pdfContent.Length);
                           pdffile.Close();
                           */
                }


                catch (Exception ex)
                {
                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "گزارش", MessageType = "Error", CallerAction = "ReportMaster", CallerController = "Reports" };
                    //Response.Redirect("/home/HandleError?MessageBody=" + ex.Message + "&MessageType=Error&CallerAction=ReportMaster&CallerController=Reports");
                    //RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
                }



            }
        }
    }

}