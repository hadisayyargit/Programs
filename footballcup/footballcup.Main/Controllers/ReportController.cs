using footballcup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommonUnit;

namespace footballcup.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult ReportMaster(string reportname="")
        {
            ReportModel myReportModel = new ReportModel();
            myReportModel.ReportName = reportname;            

            Session[GlobalModule.m_ReportModel] = myReportModel;

            return View(myReportModel);


            /*
      Warning[] warnings;
            string mimeType;
            string[] streamids;
            string encoding;
            string filenameExtension;


            var viewer = new Microsoft.Reporting.WebForms.ReportViewer();

            
            viewer.LocalReport.ReportPath = @"\Report1.rdlc";


            var bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

            return new FileContentResult(bytes, mimeType);
             */

        }
    }
}