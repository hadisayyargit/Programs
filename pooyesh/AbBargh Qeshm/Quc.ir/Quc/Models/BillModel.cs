using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quc.Models
{
    public enum RunStatusEnum
    {
        Started = 1,
        NotStarted = 0,
        Finish = 2,
    }

    public class AbBillModel
    {

        public string Subscribeno { get; set; }
        public string Subscribername { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string ReadPersonCode { get; set; }
        public string BillDateText { get; set; }
        public string BillKindString { get; set; }
        public string CodeWord { get; set; }
        public string UsageDetailDesc { get; set; }
        public string UsageInfoDesc { get; set; }
        public string Year { get; set; }
        public string CycleNumber { get; set; }
        public string ResidentialNumber { get; set; }
        public string FamilyNumber { get; set; }
        public string TxtReadDate { get; set; }
        public string ReadNumber { get; set; }
        public string ReadStateDesc { get; set; }
        public string ReadViewDesc { get; set; }
        public string IncDecMessage { get; set; }//tarighGeraateGhabli
        public string BoreDesc { get; set; }
        public string WaterValueContract { get; set; }//formul
        public string WaterMeterSerial { get; set; }
        public string BillMinRow { get; set; }//tedad
        public string BillMaxRow { get; set; }//mande    
        public string bahayeab { get; set; }
        public string khadamatDafeFaz { get; set; }
        public string maliat { get; set; }
        public string bedehiGhabli { get; set; }
        public string mablaghPardakht { get; set; }
        public string BillPartAmount { get; set; }
        public string PayPartAmount { get; set; }
        public string Days { get; set; }
        public string UseAmount { get; set; }
        public string CommercialNumber { get; set; }
        public string LastReadNumber { get; set; }
        public string PayDate { get; set; }
        public string UseAverage { get; set; }
        public string AreaDesc { get; set; }
        public string ZoneDesc { get; set; }
        public string SewageFlag { get; set; }
        public string Shorb76 { get; set; }
        public string EditAmount { get; set; }
        public string BillEditAmount { get; set; }
        public string RialRemain { get; set; }
        public string CostAmount { get; set; }
        public string DiscountAmount { get; set; }
        public string PaymentAmount { get; set; }
        public string txtArr211 { get; set; }
        public string txtArr212 { get; set; }
        public string txtArr251 { get; set; }

        public string GeneralMessage { get; set; }


    }

    public class BarghBillModel
    {
        ///آبونمان                                            
        public string ABN_A { get; set; }

        ///شماره حساب                                         
        public string ACCOUNT_CODE { get; set; }

        ///آدرس                                               
        public string ADR { get; set; }

        ///آمپر                                               
        public string AMPER { get; set; }

        ///تفاوت تعرف انشعاب آزاد                             
        public string BRANCH_COST_A { get; set; }

        ///تاریخ قرائت کنونی                                  
        public string CDAT { get; set; }

        ///تعداد ارقام                                        
        public string CNTD1 { get; set; }

        ///تنه کنتور                                          
        public string CNTN1 { get; set; }

        /// تنه کنتور راکتیو                                          
        public string CNTNR { get; set; }
        
        ///شرکت توزیع                                         
        public string COMPANY_NAME { get; set; }

        ///میان باری-کنونی                                    
        public string CRD1 { get; set; }

        ///اوج بار-کنونی                                      
        public string CRD2 { get; set; }

        ///کم باری-کنونی                                      
        public string CRD3 { get; set; }

        ///اوج بار جمعه کنونی                                 
        public string CRD4 { get; set; }

        ///راکتیو کنونی                                       
        public string CRDR1 { get; set; }

        ///بدهکاری/بستانکاری                                  
        public string CREDIT { get; set; }

        ///دوره                                               
        public string CYC { get; set; }

        ///تاریخ مهلت پرداخت                                  
        public string DATM { get; set; }

        ///تاریخ صدور صورتحساب                                
        public string DATS { get; set; }

        ///تخفیف مدیریت مصرف                                  
        public string DECREASE_A { get; set; }

        ///دیماند محاسبه                                      
        public string DEMANDC { get; set; }

        ///دیماند قرارداد                                     
        public string DEMANDG { get; set; }

        ///بهای قدرت                                          
        public string DEMANDM_A { get; set; }

        ///دیماند قرائت                                       
        public string DEMANDR { get; set; }

        ///تاریخ انقضاء پروانه                                
        public string EMOJD { get; set; }

        ///تفاوت انقضاء اعتبار پروانه                         
        public string EMOJD_JAR_A { get; set; }

        ///اشتراک                                             
        public string ESHT { get; set; }

        ///عوارض برق                                          
        public string ETOLL { get; set; }

        ///تجاوز از قدرت                                      
        public string EXTRA_A { get; set; }

        ///فاز                                                
        public string FAZ { get; set; }

        ///کد اقتصادی                                         
        public string FINANCIAL_CODE { get; set; }

        ///پرونده                                             
        public string ID { get; set; }

        ///تاریخ نصب                                          
        public string INSTD { get; set; }

        ///مبلغ بیمه                                          
        public string INSURANCE { get; set; }

        ///کسر هزار ریال                                      
        public string KASR { get; set; }

        ///خانوار                                             
        public string KHAN { get; set; }

        ///تاریخ قرائت پیشین                                  
        public string LDAT { get; set; }

        ///میان باری پیشین                                    
        public string LRD1 { get; set; }

        ///شمارنده قبلی میان باری_سنگین                       
        public string LRD1_A { get; set; }

        ///اوج بار پیشین                                      
        public string LRD2 { get; set; }

        ///شمارنده قبلی اوج بار_سنگین                         
        public string LRD2_A { get; set; }

        ///شمارنده قبلی کم باری_سنگین                         
        public string LRD3_A { get; set; }

        ///اوج بار جمعه پیشین                                 
        public string LRD4 { get; set; }

        ///شمارنده قبلی جمعه_سنگین                            
        public string LRD4_A { get; set; }

        ///شمارنده قبلی راکتیو_سنگین                          
        public string LRDR_A { get; set; }

        ///راکتیو پیشین                                       
        public string LRDR1 { get; set; }

        ///مبلغ میان باری بعد از                              
        public string MABE1_A { get; set; }

        ///هزینه مصرف اوج بار                                 
        public string MABE2_A { get; set; }

        ///هزینه مصرف کم باری                                 
        public string MABE3_A { get; set; }

        ///هزینه مصرف اوج بار جمعه                            
        public string MABE4_A { get; set; }

        ///هزینه مصرف راکتیو                                  
        public string MABER1_A { get; set; }

        ///                                                   
        public string MAXLDAT { get; set; }

        ///پیام قبض                                           
        public string MSG { get; set; }

        ///نام                                                
        public string NAME { get; set; }

        ///نرخ میان باری                                      
        public string NERKH1 { get; set; }

        ///نرخ اوج بار                                        
        public string NERKH2 { get; set; }

        ///نرخ کم باری                                        
        public string NERKH3 { get; set; }

        ///نرخ جمعه                                           
        public string NERKH4 { get; set; }

        ///نرخ راکتیو                                         
        public string NERKHR { get; set; }

        ///آدرس منطقه                                         
        public string OMOOR_ADR { get; set; }

        ///منطقه برق                                          
        public string OMOOR_DES { get; set; }

        ///پیک فصلی                                           
        public string PEEK_A { get; set; }

        ///کدپستی                                             
        public string POSTC { get; set; }

        ///قدرت پروانه                                        
        public string PWR { get; set; }

        ///کم باری پیشین                                      
        public string RD3 { get; set; }

        ///نحوه قرائت کنتور                                   
        public string READ_TYPE { get; set; }

        ///میزان مصرف راکتیو                                  
        public string RUSE1_A { get; set; }

        ///شناسه قبض                                          
        public string SH_GHABZ { get; set; }

        ///شناسه پرداخت                                       
        public string SH_PARDAKHT { get; set; }

        ///شناسایی                                            
        public string SHENASAYEE { get; set; }

        ///کد تعرفه                                           
        public string TARF_CODE { get; set; }

        ///عنوان تعرفه                                        
        public string TARF_TITLE { get; set; }

        ///پاسخ گویی صورتحساب                                 
        public string TEL_KHADAMAT { get; set; }

        ///واحد حوادث                                         
        public string TEL_M { get; set; }

        ///تلفن گویا                                          
        public string TEL_OP { get; set; }

        ///مالیات بر ارزش افزوده                              
        public string TOLL { get; set; }

        ///متوسط مصرف 30 روزه                                 
        public string TOT_AV { get; set; }

        ///مبلغ قابل پرداخت                                   
        public string TOT_MAB { get; set; }

        ///مبلغ بعد از                                        
        public string TOT_MAB_A { get; set; }

        ///مبلغ قبل از                                        
        public string TOT_MAB_B { get; set; }

        ///مصرف کل دوره                                       
        public string TOT_USE { get; set; }

        ///مصرف بعد از                                        
        public string TOT_USE_A { get; set; }

        ///مصرف قبل از                                        
        public string TOT_USE_B { get; set; }

        ///مصرف میان باری                                     
        public string TOT_USE1 { get; set; }

        ///مصرف اوج بار                                       
        public string TOT_USE2 { get; set; }

        ///مصرف کم باری                                       
        public string TOT_USE3 { get; set; }

        ///تعداد روز                                          
        public string TOTD { get; set; }

        ///تعداد روز بعد از                                   
        public string TOTD_A { get; set; }

        ///تعداد روز قبل از                                   
        public string TOTD_B { get; set; }

        ///میزان مصرف در میان باری                            
        public string USE1_A { get; set; }

        ///میزان مصرف در اوج بار                              
        public string USE2_A { get; set; }

        ///میزان مصرف کم باری                                 
        public string USE3_A { get; set; }

        ///میزان مصرف جمعه                                    
        public string USE4_A { get; set; }

        ///سال                                                
        public string YR { get; set; }

        ///ضریب کنتور                                         
        public string ZAR { get; set; }

        ///ضریب ترانس جریان                                   
        public string ZAR_D { get; set; }

        ///ضریب زیان                                          
        public string ZARIB { get; set; }

        ///مصارف 12 ماهه                                      
        public string CHART_STR { get; set; }

        ///پله های مصرف                                       
        public string STEP_STR { get; set; }

        public string GeneralMessage { get; set; }


    }
}