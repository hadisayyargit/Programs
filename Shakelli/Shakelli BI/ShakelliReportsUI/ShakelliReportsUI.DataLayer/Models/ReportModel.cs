using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShakelliReportsUI.DataLayer.Models
{
    public enum ReportFormatEnum
    {
        Grid=1,
        ReportViewer=2,        
        DirectLink=3,
        Excel=4,
        PDF = 5,
    }

    public enum RunStatusEnum
    {
        Started = 1,
        NotStarted = 0,
        Finish = 2,
    }

    public class ReportModel
    {
        [Key]
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string ReportTitle { get; set; }

        public string SubTitle { get; set; }
        

        public ReportFormatEnum ReportDisplayMode { get; set; }

        public bool HasServerReport { get; set; }
        public bool HasDirectPath { get; set; }
        public bool HasOwnGrid { get; set; }
        public string UrlPath { get; set; }

        

        public List<ReportParameter> ReportParameters { get; set; }

        //public List<WorkListModel> ReportList { get; set; }

        public string ReportDate { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ContollerName { get; set; }

        public string ContollerAction { get; set; }

        public RunStatusEnum RunStatus { get; set; }

        public bool IsEnabledReportContainer { get; set; }
        public bool IsEnabledParameterDialog { get; set; }
                
        public bool IsEnabledAnbar { get; set; }
        public bool IsEnabledKala { get; set; }
        public bool IsEnabledSeller { get; set; }

        public bool IsEnabledDate { get; set; }
        public bool IsEnabledFromDate { get; set; }

        public bool IsEnabledToDate { get; set; }

        public bool IsEnabledCustomer { get; set; }

        public bool IsEnabledBranch { get; set; }

        public bool IsEnabledCity { get; set; }
        public bool IsEnabledState { get; set; }
        public bool IsEnabledDistrict { get; set; }
        public bool IsEnabledKanalTozi { get; set; }
        public bool IsEnabledKalaGroup { get; set; }
        public bool IsEnabledKalaSubGroup { get; set; }
        public bool IsEnabledClassTakhfif { get; set; }

        public bool IsEnabledSupervisor { get; set; }
        public bool IsEnabledWeek { get; set; }

        public bool IsEnabledTradingGrp { get; set; }

        public bool IsEnabledUserId { get; set; }
        public string SalesmanCode { get; set; }

        public string SupervisorCode { get; set; }
        public int CustomerId { get; set; }
        public int StockRef { get; set; }
        public Nullable<int> AnbarId { get; set; }
        public Nullable<int> Branch { get; set; }

        public string StateCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string KalaGroupCode { get; set; }
        public string KalaSubGroupCode { get; set; }
        public string KanalTozi { get; set; }
        public string ClassTakhfif { get; set; }

        public int WeekId { get; set; }

        public string tradinggrp { get; set; }


        /// <summary>
        /// پارامترهای غیر شناخته شده
        /// </summary>
        public string NonTipParameters1_Name { get; set; }
        public string NonTipParameters1_Value { get; set; }
        public string NonTipParameters1_Ds { get; set; }
        public string NonTipParameters2_Name { get; set; }
        public string NonTipParameters2_Value { get; set; }
        public string NonTipParameters2_Ds { get; set; }
        public string NonTipParameters3_Name { get; set; }
        public string NonTipParameters3_Value { get; set; }
        public string NonTipParameters3_Ds { get; set; }
        public string NonTipParameters4_Name { get; set; }
        public string NonTipParameters4_Value { get; set; }
        public string NonTipParameters4_Ds { get; set; }
        public string NonTipParameters5_Name { get; set; }
        public string NonTipParameters5_Value { get; set; }
        public string NonTipParameters5_Ds { get; set; }

        public string StoredProcedure { get; set; }
        public string StoredProcedureParameterName { get; set; }
        public string StoredProcedureParameterType { get; set; }


    }
}