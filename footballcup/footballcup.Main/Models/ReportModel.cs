using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace footballcup.Models
{
    public class ReportModel
    {
        public string ReportName { get; set; }
        public string ReportTitle { get; set; }

        public string SubTitle { get; set; }

        public string UrlPath { get; set; }

        //public List<ReportParameter> ReportParameters { get; set; }

        public string ReportDate { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public bool IsEnabledParameterDialog { get; set; }

        //public int KalaCode { get; set; }

        public string StoredProcedure { get; set; }
        public string StoredProcedureParameterName { get; set; }
    }
}