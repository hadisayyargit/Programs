using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace RWAS.Common
{
    public class CommonClass
    {
        public static string m_ApplicationId = "KARNAMEH";

        public static DataTable datatableTableColumns = new DataTable();
        public static DataTable m_dtGroupAccess = new DataTable();
        public static DataTable m_dtUserAccess = new DataTable();
        public static DataTable m_PostTable = new DataTable();

        public static void MakeColumnsTable()
        {
            datatableTableColumns.Columns.Clear();

            datatableTableColumns.Columns.Add("ColumnId");
            datatableTableColumns.Columns.Add("ColumnName");
            datatableTableColumns.Columns.Add("TableName");
            datatableTableColumns.Columns.Add("ColumnOrder");

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_FileCategorize", "کلاسمان حادثه", "Accident",1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AccidentDate", "تاریخ حادثه", "Accident", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "RegionDesc", "ناحیه", "Accident",3 });            
            datatableTableColumns.Rows.Add(new Object[] { "TrainSourceStation", "ایستگاه مبدأ", "Accident",4 });
            datatableTableColumns.Rows.Add(new Object[] { "TrainDestinationStation", "ایستگاه مقصد", "Accident",5 });
            datatableTableColumns.Rows.Add(new Object[] { "AccidentSourceStation", "ایستگاه ابتدای وقوع حادثه", "Accident", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "AccidentDestinationStation", "ایستگاه انتهای وقوع حادثه", "Accident", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Kilometer", "کیلومتر محل حادثه", "Accident",8 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Description", "شرح حادثه", "Accident",9 });
            datatableTableColumns.Rows.Add(new Object[] { "EffectiveDesc", "عامل بروز حادثه", "Accident" ,10});
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Reason", "علت بروز حادثه", "Accident" ,11});
            datatableTableColumns.Rows.Add(new Object[] { "AccidentKindDesc", "سبب حادثه", "Accident",12 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_IsOnManeuver", "در حال مانور؟", "Accident",13 });
            datatableTableColumns.Rows.Add(new Object[] { "RailWayVehicleKindDesc", "نوع وسیله ریلی", "Accident",14 });
            datatableTableColumns.Rows.Add(new Object[] { "DegreeDesc", "درجه اهمیت", "Accident" ,15});
            datatableTableColumns.Rows.Add(new Object[] { "AccidentTypeDesc", "نوع حادثه", "Accident" ,16});
            datatableTableColumns.Rows.Add(new Object[] { "CategoryType", "کد کلاسمان", "Accident", 17 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AccidentTime", "زمان وقوع", "General", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_TrainNo", "شماره قطار", "General", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "DriverName", "نام لکوموتیوران", "General", 3 });
            datatableTableColumns.Rows.Add(new Object[] { "TrainBossName", "نام رئیس قطار", "General", 4 });
            datatableTableColumns.Rows.Add(new Object[] { "FinalSurveyStation", "آخرین پست بازدید", "General", 5 });
            datatableTableColumns.Rows.Add(new Object[] { "ExitVehicleSerialNo", "مشخصات وسایل ریلی از خط خارج شده", "General", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "ScapeSerialNo", "مشخصات وسایل ریلی فراری", "General", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "FiredVehicleSerialNo", "مشخصات وسایل ریلی آتش گرفته", "General", 8 });
            datatableTableColumns.Rows.Add(new Object[] { "CrossRoadDesc", "محل تقاطع", "General", 9 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerGender", "جنسیت عابر", "General", 10 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_PassengerAgeStatuse", "وضعیت سنی عابر", "General", 11 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_CrossroadKind", "نوع تقاطع همسطح", "General", 12 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_RoadVehicleKind", "نوع وسیله نقلیه جاده ای", "General", 13 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ExitVehicleCount", "تعداد وسایل از خط خارج شده", "General", 14 });
            //datatableTableColumns.Rows.Add(new Object[] { "BlockString", "بلاک", "General", 15 });

            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_Name", "نام", "Blameful" ,1});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_BirthYear", "سال تولد", "Blameful", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_StudyStatusDescribe", "وضعیت تحصیلی", "Blameful" ,3});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_MaritalStatusDescribe", "وضعیت تأهل", "Blameful" ,4});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_EmployeeStatusDescribe", "نوع استخدام", "Blameful",5 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobHistory", "سابقه کار", "Blameful", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobDescribe", "شغل", "Blameful", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_Note8", "ماده8", "Blameful", 8 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_Note9", "ماده9", "Blameful", 9 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RestHoursBeforeDuty", "مدت استراحت", "Blameful", 10 });            
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SessionDate", "تاریخ جلسه", "Blameful" ,11});
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ForfeitKindDescribe", "میزان جریمه", "Blameful",12 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SentenceNo", "شماره رأی", "Blameful", 13 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Duration", "مدت جریمه", "Blameful", 14 });

            datatableTableColumns.Rows.Add(new Object[] { "VehicleKindDes", "نوع وسیله", "ExitRail", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SerialNo", "شماره وسیله", "ExitRail", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LastRepairDate", "تاریخ آخرین تعمیرات ویژه", "ExitRail", 3 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_BasicRepairDate", "تاریخ آخرین تعمیرات اساسی", "ExitRail", 4 });
            datatableTableColumns.Rows.Add(new Object[] { "LoadBojiKindDes", "نوع بوژی", "ExitRail" ,5});
            datatableTableColumns.Rows.Add(new Object[] { "CramponKindDesc", "نوع قلاب", "ExitRail", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_WheelExitReason", "علت خروج اولین چرخ", "ExitRail", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "RubberKindDes", "نوع کفشها", "ExitRail",8 });
            datatableTableColumns.Rows.Add(new Object[] { "LoadingStationDesc", "محل بارگیری", "ExitRail", 9 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LineLoss", "میزان خسارت خط", "Loss", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SignalLoss", "خسارت علائم", "Loss", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_OtherLoss", "سایر خسارات", "Loss", 3 });
            datatableTableColumns.Rows.Add(new Object[] { "LossRailwayKindDes", "نوع وسیله ریلی", "Loss", 4 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_SerialNo", "شماره وسیله ریلی", "Loss", 5 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LossAmount", "میزان خسارت وسیله ریلی", "Loss", 6 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RailWayAfoulCount", "تعداد مصدومین راه آهن", "DieAndAfoul", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RailwayDieCount", "تعداد فوتیهای راه آهن", "DieAndAfoul", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AbRailwayAfoulCount", "تعداد مصدومین غیر راه آهن", "DieAndAfoul", 3 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AbRailwayDieCount", "تعداد فوتیهای غیر راه آهن", "DieAndAfoul", 4 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ThirdPartyAfoulCount", "تعداد مصدومین اشخاص ثالث", "DieAndAfoul", 5 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ThirdPartyDieCount", "تعداد فوتیهای اشخاص ثالث", "DieAndAfoul", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerAfoulCount", "تعداد مصدومین مسافر", "DieAndAfoul", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerDieCount", "تعداد فوتیهای مسافر", "DieAndAfoul", 8 });
            //datatableTableColumns.Rows.Add(new Object[] { "", "نتیجه حادثه", "DieAndAfoul", 9 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_UniqueCode", "نام و نام خانوادگی مأمور", "AgentDieAndAfoul", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_WorkHours", "ساعت کارکرد قبل از حادثه", "AgentDieAndAfoul", 2 });
            datatableTableColumns.Rows.Add(new Object[] { "JobDesc", "شغل سازمانی", "AgentDieAndAfoul", 3 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobHistory", "سابقه خدمت در راه آهن", "AgentDieAndAfoul", 4 });
            datatableTableColumns.Rows.Add(new Object[] { "JobDesc2", "شغل به هنگام حادثه", "AgentDieAndAfoul", 5 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_LastJobHistory", "سابقه خدمت در شغل فعلی", "AgentDieAndAfoul", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_IsAfoul", "نتیجه حادثه", "AgentDieAndAfoul", 7 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Det_EarlyAccidentReasonDescription", "علت اول بروز حادثه", "AgentDieAndAfoul", 8 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Det_EarlyAccidentReasonDescription2", "علت دوم بروز حادثه", "AgentDieAndAfoul", 9 });


            
        }

        public static string GetDateWithSlash(string strPDate)
        {
            string strRes = "";
            if (strPDate.Length == 8)
                strRes = strPDate.Substring(0, 4) + "/" + strPDate.Substring(4, 2) + "/" + strPDate.Substring(6, 2);
            else if (strPDate.Length == 10 && strPDate.Substring(4,1)=="/" && strPDate.Substring(7,1)=="/")
                strRes = strPDate;
            
            return strRes;            
        }

        public static string GetDateWithoutSlash(string strPDate)
        {
            string strRes = "";
            bool bflag;
            int nValue=0;
            if (strPDate != null)
            {
                strRes = strPDate.Replace("/", "");
                bflag = Int32.TryParse(strRes, out nValue);
                if (!bflag) strRes = "";
            }
            return strRes;
        }

        public static int GetDateValue(string strPDate)
        {
            string s = "";
            bool bflag;
            int nValue = 0;

            s = strPDate.Replace("/", "");
            if (s.Length == 8)
            {
                bflag = Int32.TryParse(s, out nValue);
                if (!bflag) nValue = 0;
            }
            else
                nValue = 0;

            return nValue;
        }




    }
}
