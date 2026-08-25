using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shahriarco.Anbar.Models
{
    public class ReportModel
    {
        [Key]
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string ReportTitle { get; set; }

        public string SubTitle { get; set; }

        public string UrlPath { get; set; }

        //public List<ReportParameter> ReportParameters { get; set; }

        public string ReportDate { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }

        public bool IsEnabledParameterDialog { get; set; }

        public bool IsEnabledAnbar { get; set; }
        public bool IsEnabledKala { get; set; }

        public Nullable<int> AnbarCode { get; set; }
        public int KalaCode { get; set; }

        public string StoredProcedure { get; set; }
        public string StoredProcedureParameterName { get; set; }
    }
}