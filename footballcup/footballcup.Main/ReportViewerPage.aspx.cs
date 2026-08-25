using footballcup.Models;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonUnit;

namespace footballcup
{
    public partial class ReportViewerPage : System.Web.UI.Page
    {

        footballcupDbContext db = new footballcupDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReportModel myReportModel = new ReportModel();

                try
                {
                    myReportModel = (ReportModel)Session[GlobalModule.m_ReportModel];
                    ReportViewer1.ProcessingMode = ProcessingMode.Local;                    
                    ReportViewer1.LocalReport.DataSources.Clear();

                    myReportModel.ReportName = "rptParticipantRanking";
                   // myReportModel.ReportName = "rptparticipant";
           

                    switch (myReportModel.ReportName.ToLower())
                    {
                        case "rptparticipant":
                            myReportModel.UrlPath = "Views\\Report\\rptParticipant.rdlc";
                            ReportViewer1.LocalReport.ReportPath = myReportModel.UrlPath;
                            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetPrediction"));
                            var myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0},@matchstate=1", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).OrderBy(m=>m.MatchNo).ToList();
                            foreach (PredictionView item in myPredictionList)
                            {
                                try
                                {
                                    System.Globalization.PersianCalendar myCalendar = new System.Globalization.PersianCalendar();
                                    item.JMatchTime = myCalendar.GetYear(@item.MatchTime).ToString() + "/" + myCalendar.GetMonth(@item.MatchTime).ToString() + "/" + myCalendar.GetDayOfMonth(@item.MatchTime).ToString() + " " + @item.MatchTime.ToShortTimeString();
                                    item.JPredictTime = myCalendar.GetYear(@item.PredictTime.Value).ToString() + "/" + myCalendar.GetMonth(@item.PredictTime.Value).ToString() + "/" + myCalendar.GetDayOfMonth(@item.PredictTime.Value).ToString() + " " + @item.PredictTime.Value.ToShortTimeString();                                    
                                }
                                catch
                                {
                                }
                            }

                            ReportViewer1.LocalReport.DataSources[0].Value = myPredictionList;

                            break;

                            case "rptparticipantranking":
                            myReportModel.UrlPath = "Views\\Report\\rptParticipantRanking.rdlc";
                           // myReportModel.UrlPath = "Views\\Report\\rptParticipant22.rdlc";
                            ReportViewer1.LocalReport.ReportPath = myReportModel.UrlPath;

                            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetRanking"));
                            var myCompetitorList = db.Database.SqlQuery<CompetitorView>("spGetRanking @cupid = {0}", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).ToList();

                            //ReportViewer1.LocalReport.SetParameters(new ReportParameter("pCupId", "1"));


                            ReportViewer1.LocalReport.DataSources[0].Value = myCompetitorList;

                            ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);

                            break;
                        case "rptCompetitorPredictions":
                             ReportViewer1.LocalReport.DataSources.Clear();
                               ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("datasetGetPredictions"));
                                var myPredictionList3 = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid =1 ,@competitorid=5").OrderBy(m => m.MatchNo).ToList();


                                ReportViewer1.LocalReport.DataSources[0].Value = myPredictionList3;

                            myReportModel.UrlPath = "Views\\Report\\rptCompetitorPredictions.rdlc";
                            ReportViewer1.LocalReport.ReportPath = myReportModel.UrlPath;
                            break;
                    }


                    this.ReportViewer1.DataBind();

                }
                catch (Exception ex)
                {

                }

            }
        }

        
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Clear();
            e.DataSources.Add(new ReportDataSource("datasetGetPredictions"));
           int competitorid= int.Parse( e.Parameters["pCompetitorId"].Values[0].ToString());

            var myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0},@matchstate=1,@competitorid={1}", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId ,competitorid }).OrderBy(m => m.MatchNo).ToList();
            foreach (PredictionView item in myPredictionList)
            {
                try
                {
                    System.Globalization.PersianCalendar myCalendar = new System.Globalization.PersianCalendar();
                    item.JMatchTime = myCalendar.GetYear(@item.MatchTime).ToString() + "/" + myCalendar.GetMonth(@item.MatchTime).ToString() + "/" + myCalendar.GetDayOfMonth(@item.MatchTime).ToString() + " " + @item.MatchTime.ToShortTimeString();
                    item.JPredictTime = myCalendar.GetYear(@item.PredictTime.Value).ToString() + "/" + myCalendar.GetMonth(@item.PredictTime.Value).ToString() + "/" + myCalendar.GetDayOfMonth(@item.PredictTime.Value).ToString() + " " + @item.PredictTime.Value.ToShortTimeString();
                }
                catch
                {
                }
            }
            


            e.DataSources[0].Value = myPredictionList;
        }
        



    }
}