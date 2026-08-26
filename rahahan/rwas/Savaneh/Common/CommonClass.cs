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
        public static string m_ApplicationId = "SAVANEH";

        public static DataTable datatableTableColumns = new DataTable();
        public static DataTable m_dtGroupAccess = new DataTable();
        public static DataTable m_dtUserAccess = new DataTable();

        public static void MakeColumnsTable()
        {
            datatableTableColumns.Columns.Clear();

            datatableTableColumns.Columns.Add("ColumnId");
            datatableTableColumns.Columns.Add("ColumnName");
            datatableTableColumns.Columns.Add("TableName");
            datatableTableColumns.Columns.Add("ColumnOrder");

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_FileCategorize", "کلاسمان حادثه", "Accident",0 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AccidentDate", "تاریخ حادثه", "Accident", 1 });
            datatableTableColumns.Rows.Add(new Object[] { "RegionDesc", "ناحیه", "Accident",2 });            
            datatableTableColumns.Rows.Add(new Object[] { "TrainSourceStation", "ایستگاه مبدأ", "Accident",3 });
            datatableTableColumns.Rows.Add(new Object[] { "TrainDestinationStation", "ایستگاه مقصد", "Accident",4 });
            datatableTableColumns.Rows.Add(new Object[] { "AccidentSourceStation", "ایستگاه ابتدای وقوع حادثه", "Accident", 5 });
            datatableTableColumns.Rows.Add(new Object[] { "AccidentDestinationStation", "ایستگاه انتهای وقوع حادثه", "Accident", 6 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Kilometer", "کیلومتر محل حادثه", "Accident",7 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Description", "شرح حادثه", "Accident",8 });
            datatableTableColumns.Rows.Add(new Object[] { "EffectiveDesc", "عامل بروز حادثه", "Accident" ,9});
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Reason", "علت بروز حادثه", "Accident" ,10});
            datatableTableColumns.Rows.Add(new Object[] { "AccidentKindDesc", "سبب حادثه", "Accident",11 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_IsOnManeuver", "در حال مانور؟", "Accident",12 });
            datatableTableColumns.Rows.Add(new Object[] { "RailWayVehicleKindDesc", "نوع وسیله ریلی", "Accident",13 });
            datatableTableColumns.Rows.Add(new Object[] { "DegreeDesc", "درجه اهمیت", "Accident" ,14});
            datatableTableColumns.Rows.Add(new Object[] { "AccidentTypeDesc", "نوع حادثه", "Accident" ,15});
            datatableTableColumns.Rows.Add(new Object[] { "CategoryType", "کد کلاسمان", "Accident", 16 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_BlockTime", "مدت مسدودی", "Accident", 17 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AccidentTime", "زمان وقوع", "General", 18 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_TrainNo", "شماره قطار", "General", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "DriverName", "نام لکوموتیوران", "General", 20 });
            datatableTableColumns.Rows.Add(new Object[] { "TrainBossName", "نام رئیس قطار", "General", 21 });
            datatableTableColumns.Rows.Add(new Object[] { "FinalSurveyStation", "آخرین پست بازدید", "General", 22 });
            datatableTableColumns.Rows.Add(new Object[] { "ExitVehicleSerialNo", "مشخصات وسایل ریلی از خط خارج شده", "General", 23 });
            datatableTableColumns.Rows.Add(new Object[] { "ScapeSerialNo", "مشخصات وسایل ریلی فراری", "General", 24 });
            datatableTableColumns.Rows.Add(new Object[] { "FiredVehicleSerialNo", "مشخصات وسایل ریلی آتش گرفته", "General", 25 });
            datatableTableColumns.Rows.Add(new Object[] { "CrossRoadDesc", "محل تقاطع", "General", 26 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerGender", "جنسیت عابر", "General", 27 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_PassengerAgeStatuse", "وضعیت سنی عابر", "General", 28 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_CrossroadKind", "نوع تقاطع همسطح", "General", 29 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_RoadVehicleKind", "نوع وسیله نقلیه جاده ای", "General", 30 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ExitVehicleCount", "تعداد وسایل از خط خارج شده", "General", 31 });
            
            //datatableTableColumns.Rows.Add(new Object[] { "BlockString", "بلاک", "General", 15 });

            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_Name", "نام", "Blameful" ,18});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_BirthYear", "سال تولد", "Blameful", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_StudyStatusDescribe", "وضعیت تحصیلی", "Blameful" ,20});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_MaritalStatusDescribe", "وضعیت تأهل", "Blameful" ,21});
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_EmployeeStatusDescribe", "نوع استخدام", "Blameful",22 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobHistory", "سابقه کار", "Blameful", 23 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobDescribe", "شغل", "Blameful", 24 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_Note8", "ماده8", "Blameful", 25 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_Note9", "ماده9", "Blameful", 26 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RestHoursBeforeDuty", "مدت استراحت", "Blameful", 27 });            
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SessionDate", "تاریخ جلسه", "Blameful" ,28});
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ForfeitKindDescribe", "میزان جریمه", "Blameful",29 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SentenceNo", "شماره رأی", "Blameful", 30 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Duration", "مدت جریمه", "Blameful", 31 });

            datatableTableColumns.Rows.Add(new Object[] { "VehicleKindDes", "نوع وسیله", "ExitRail", 18 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SerialNo", "شماره وسیله", "ExitRail", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LastRepairDate", "تاریخ آخرین تعمیرات ویژه", "ExitRail", 20 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_BasicRepairDate", "تاریخ آخرین تعمیرات اساسی", "ExitRail", 21 });
            datatableTableColumns.Rows.Add(new Object[] { "LoadBojiKindDes", "نوع بوژی", "ExitRail" ,22});
            datatableTableColumns.Rows.Add(new Object[] { "CramponKindDesc", "نوع قلاب", "ExitRail", 23 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ufk_WheelExitReason", "علت خروج اولین چرخ", "ExitRail", 24 });
            datatableTableColumns.Rows.Add(new Object[] { "RubberKindDes", "نوع کفشها", "ExitRail",25 });
            datatableTableColumns.Rows.Add(new Object[] { "LoadingStationDesc", "محل بارگیری", "ExitRail", 26 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LineLoss", "میزان خسارت خط", "Loss", 18 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_SignalLoss", "خسارت علائم", "Loss", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_OtherLoss", "سایر خسارات", "Loss", 20 });
            datatableTableColumns.Rows.Add(new Object[] { "LossRailwayKindDes", "نوع وسیله ریلی", "Loss", 21 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_SerialNo", "شماره وسیله ریلی", "Loss", 22 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_LossAmount", "میزان خسارت وسیله ریلی", "Loss", 23 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RailWayAfoulCount", "تعداد مصدومین راه آهن", "DieAndAfoul", 18 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_RailwayDieCount", "تعداد فوتیهای راه آهن", "DieAndAfoul", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AbRailwayAfoulCount", "تعداد مصدومین غیر راه آهن", "DieAndAfoul", 20 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_AbRailwayDieCount", "تعداد فوتیهای غیر راه آهن", "DieAndAfoul", 21 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ThirdPartyAfoulCount", "تعداد مصدومین اشخاص ثالث", "DieAndAfoul", 22 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_ThirdPartyDieCount", "تعداد فوتیهای اشخاص ثالث", "DieAndAfoul", 23 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerAfoulCount", "تعداد مصدومین مسافر", "DieAndAfoul", 24 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_PassengerDieCount", "تعداد فوتیهای مسافر", "DieAndAfoul", 25 });
            //datatableTableColumns.Rows.Add(new Object[] { "", "نتیجه حادثه", "DieAndAfoul", 9 });

            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_fk_UniqueCode", "نام و نام خانوادگی مأمور", "AgentDieAndAfoul", 18 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_WorkHours", "ساعت کارکرد قبل از حادثه", "AgentDieAndAfoul", 19 });
            datatableTableColumns.Rows.Add(new Object[] { "JobDesc", "شغل سازمانی", "AgentDieAndAfoul", 20 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_JobHistory", "سابقه خدمت در راه آهن", "AgentDieAndAfoul", 21 });
            datatableTableColumns.Rows.Add(new Object[] { "JobDesc2", "شغل به هنگام حادثه", "AgentDieAndAfoul", 22 });
            datatableTableColumns.Rows.Add(new Object[] { "Prs_Fld_LastJobHistory", "سابقه خدمت در شغل فعلی", "AgentDieAndAfoul", 23 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_IsAfoul", "نتیجه حادثه", "AgentDieAndAfoul", 24 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Det_EarlyAccidentReasonDescription", "علت اول بروز حادثه", "AgentDieAndAfoul", 25 });
            datatableTableColumns.Rows.Add(new Object[] { "Rws_Fld_Det_EarlyAccidentReasonDescription2", "علت دوم بروز حادثه", "AgentDieAndAfoul", 26 });
            
        }


        public static DateTime GetDatetime(string strPdate)
        {
            DateTime dtmResult = new DateTime();

            System.Globalization.PersianCalendar objPC = new System.Globalization.PersianCalendar();
            

            int nDate = GetDateValue(strPdate);
            if (nDate != 0)
            {
                int nYear = int.Parse(nDate.ToString().Substring(0, 4));
                int nMonth = int.Parse(nDate.ToString().Substring(4, 2));
                int nDay = int.Parse(nDate.ToString().Substring(6, 2));
                dtmResult = objPC.ToDateTime(nYear, nMonth, nDay, 0, 0, 0, 0);
            }
            return dtmResult;
        }


        public static string GetDateWithSlash(string strPDate)
        {
            string strRes = "";
            if (strPDate.Length == 8)
                strRes = strPDate.Substring(0, 4) + "/" + strPDate.Substring(4, 2) + "/" + strPDate.Substring(6, 2);
            else if (strPDate.Length == 10 && strPDate.Substring(4, 1) == "/" && strPDate.Substring(7, 1) == "/")
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
