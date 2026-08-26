using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShakelliReportsUI.DataLayer.Models
{
    public class postReportData
    {
               
        [Display(Name = "ردیف")]
        public Int64 RowNo { get; set; }
        
        [Display(Name = "سال")]
        public string sal { get; set; }

        [Display(Name = "ماه")]
        public string mah { get; set; }

        [Display(Name = "کد فروشنده")]
        public string SalesmanCode { get; set; }

        [Display(Name = "نام فروشنده")]
        public string SalesmanName { get; set; }

        [Display(Name = "محدوده اعتبار")]
        public double ACCRISKLIMIT        { get; set; }

        [Display(Name = "تعداد فاکتور")]
        public int FactorCount { get; set; }

        [Display(Name = "نحوه پرداخت")]
        public string PaymentType2 { get; set; }

        [Display(Name = "قیمت فاکتور")]
        public double FactorPrice { get; set; }

        [Display(Name = "جایزه")]
        public double Campaign { get; set; }

        [Display(Name = "قابل پرداخت")]
        public double PayableAmount { get; set; }

        [Display(Name = "نقد")]
        public Nullable<double> AMOUNT { get; set; }

        [Display(Name = "نقد")]
        public Nullable<double> ksAMOUNT { get; set; }

        [Display(Name = "چک")]
        public Nullable<double> checkAMOUNT { get; set; }

        [Display(Name = "رسید")]
        public Nullable<double> residAMOUNT { get; set; }

        [Display(Name = "تخفیف")]
        public Nullable<double> distDisc { get; set; }

        [Display(Name = "برگشت از فروش")]
        public Nullable<double> returnAmount { get; set; }

        [Display(Name = "مبلغ ناخالص")]
        public Nullable<double> impureAmount { get; set; }

        [Display(Name = "مبلغ خالص")]
        public Nullable<double> NetAmount { get; set; }

        [Display(Name = "مانده دوره")]
        public Nullable<double> RemainTerm { get; set; }

        [Display(Name = "مانده نهایی")]
        public Nullable<double> RemainTot { get; set; }

        [Display(Name = "مانده روز")]
        public Nullable<double> DailyMod { get; set; }




        [Display(Name = "مانده اعتبار")]
        public Nullable<double> MondehEtebar { get; set; }

        [Display(Name = "مغایرت")]
        public string CheckIsOk { get; set; }


        [Display(Name = "کد مشتری")]
        public string CustomerId { get; set; }

        [Display(Name = "نام مشتری")]
        public string CustomerName { get; set; }

        [Display(Name = "استان")]
        public string ostan { get; set; }
        public string shahr { get; set; }

        [Display(Name = "نام تراکنش")]
        public string DocName { get; set; }

        [Display(Name = "تاریخ")]
        public string DocDate { get; set; }

        [Display(Name = "شماره سند")]
        public string DocNo { get; set; }

        [Display(Name = "بدهکار")]
        public double bedamount { get; set; }

        [Display(Name = "بستانکار")]
        public double besamount { get; set; }

        [Display(Name = "جمع ریالی فروش")]
        public string sum_price { get; set; }

        [Display(Name = "جمع تعدادی فروش")]
        public string sum_tedad { get; set; }

        [Display(Name = "مانده")]
        public Int64 total { get; set; }
        //public Nullable<long> total { get; set; }

        [Display(Name = "سرپرست")]
        public string SupervisorName { get; set; }


        [Display(Name = "مبلغ فروش1")]
        public double payable { get; set; }


        [Display(Name = "تعداد برگشتی")]
        public int retedadfactor { get; set; }

        [Display(Name = "وزن برگشتی")]
        public double reweight { get; set; }

        [Display(Name = "مبلغ برگشتی")]
        public double repayable { get; set; }

        [Display(Name = "مانده")]
        public double mondehpayable { get; set; }

        [Display(Name = "وزن مانده")]
        public double mondehweight { get; set; }

        [Display(Name = "تعداد")]
        public int tedadfactor { get; set; }

        [Display(Name = "وزن")]
        public double weight { get; set; }

        [Display(Name = "نام بانک")]
        public string BankName { get; set; }

        [Display(Name = "کد کالا")]
        public string KalaCode { get; set; }

        [Display(Name = "کد کالا")]
        public string KalaName { get; set; }


        [Display(Name = "واحد اصلی")]
        public string mainunit { get; set; }



        [Display(Name = "وزن خروجی")]
        public double caryWeight { get; set; }

        [Display(Name = "وزن سالم برگشتی")]
        public double caryReWeight { get; set; }


        [Display(Name = "جایزه وزنی")]
        public double capWeight { get; set; }

        [Display(Name = "مانده")]
        public double Remain { get; set; }

        public Nullable<long> Id { get; set; }

    }

   

}