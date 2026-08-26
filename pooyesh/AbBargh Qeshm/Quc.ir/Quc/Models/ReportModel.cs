using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quc.Models
{
    public class ReportModel
    {
        public string ReportName { get; set; }
        public string ReportTitle { get; set; }
        public string UrlPath { get; set; }
        public int ZoomPercent { get; set; }

        public bool HasDirectPath { get; set; }
    }
}