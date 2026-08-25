using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shahriarco.Anbar.Models;

namespace shahriarco.Anbar.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult ReportMaster(string reportname)
        {
            ReportModel myReportModel = new ReportModel();
            //myReportModel.IsEnabledParameterDialog = false;
            myReportModel.ReportName = reportname;

            switch (reportname.ToLower())
            {
                case "rptanbar":
                    
                    myReportModel.UrlPath = "Views\\Reports\\rptAnbar.rdlc";                    
                    break;
                case "rptkala":
                    myReportModel.UrlPath = "Views\\Reports\\rptKala.rdlc";
                    break;
            }

            Session[shahriarco.CommonUnit.GeneralModule.m_ReportModel] = myReportModel;

            return View(myReportModel);
        }

      
    }
}