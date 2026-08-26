using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GlobalUnit
{
    /// <summary>
    /// Hadi Sayyar
    /// </summary>
    public class PDateTime
    {
        #region Private

        private const double PERSIAN_EPOCH = 1948320.5;
        private const double GREGORIAN_EPOCH = 1721425.5;

        private double m_Julianday;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GDate"></param>
        /// <returns></returns>
        private double gregorianToJulian(System.DateTime GDate)
        {
            double nYear, nMonth, nDay;
            double res;

            nYear = GDate.Year;
            nMonth = GDate.Month;
            nDay = GDate.Day;

            res = (GREGORIAN_EPOCH - 1) + (365 * (nYear - 1)) +
                System.Math.Floor((nYear - 1) / 4) +
                (-System.Math.Floor((nYear - 1) / 100)) +
                System.Math.Floor((nYear - 1) / 400) +
                System.Math.Floor((((367 * nMonth) - 362) / 12) +
                ((nMonth <= 2) ? 0 : (IsGregorianLeap(nYear) ? -1 : -2)) + nDay);
            res = res + timeToFractionOfJulian(GDate.Hour, GDate.Minute, GDate.Second);

            return res;
        }

        private double persianToJulian(string strDate)
        {
            double epbase, epyear;
            double rYear, rMonth, rDay;
            string strDelimiter = "/";
            char[] aDelimiter = strDelimiter.ToCharArray();
            string[] aSplit = null;
            aSplit = strDate.Split(aDelimiter);
            rYear = System.Convert.ToInt32(aSplit[0], 10);
            rMonth = System.Convert.ToInt32(aSplit[1], 10);
            rDay = System.Convert.ToInt32(aSplit[2], 10);

            epbase = rYear - ((rYear >= 0) ? 474 : 473);
            epyear = 474 + (epbase % 2820);
            return rDay + ((rMonth <= 7) ? ((rMonth - 1) * 31) :
                (((rMonth - 1) * 30) + 6)) + System.Math.Floor(((epyear * 682) - 110) / 2816) +
                (epyear - 1) * 365 + System.Math.Floor(epbase / 2820) * 1029983 + (PERSIAN_EPOCH - 1);
        }

        private string julianToPersian(double rJd)
        {

            double month, day, depoch, cyear;
            double year, cycle, aux1, aux2, ycycle, yday;

            rJd = System.Math.Floor(rJd) + 0.5;
            depoch = rJd - persianToJulian("0475/01/01");
            cycle = System.Math.Floor(depoch / 1029983);
            cyear = System.Convert.ToInt64(depoch) % 1029983;

            if (cyear == 1029982)
            {
                ycycle = 2820;
            }

            else
            {
                aux1 = System.Math.Floor(cyear / 366);
                aux2 = (cyear % 366);
                ycycle = System.Math.Floor(((2134 * aux1) + (2816 * aux2) + 2815) / 1028522) +
                    aux1 + 1;
            }

            year = ycycle + (2820 * cycle) + 474;

            if (year <= 0)
            {
                year--;
            }

            yday = (rJd - persianToJulian(year.ToString() + "/01/01")) + 1;
            month = (yday <= 186) ? System.Math.Ceiling(yday / 31) : System.Math.Ceiling((yday - 6) / 30);
            day = (rJd - persianToJulian(year.ToString() + "/" + month.ToString() + "/01")) + 1;

            return year.ToString() + "/" + month.ToString() + "/" + day.ToString();
        }

        private DateTime julianToGregorian(double jd)
        {
            double wjd, depoch, quadricent, dqc, day, month, cent, dcent, quad, dquad, yindex, year, yearday, leapadj;
            int nHour, nMinute, nSecond;
            string strTime;

            wjd = Math.Floor(jd - 0.5) + 0.5;
            depoch = wjd - GREGORIAN_EPOCH;
            quadricent = Math.Floor(depoch / 146097);
            dqc = depoch % 146097;
            cent = Math.Floor(dqc / 36524);
            dcent = dqc % 36524;
            quad = Math.Floor(dcent / 1461);
            dquad = dcent % 1461;
            yindex = Math.Floor(dquad / 365);
            year = (quadricent * 400) + (cent * 100) + (quad * 4) + yindex;
            if (!((cent == 4) || (yindex == 4)))
            {
                year++;
            }
            yearday = wjd - gregorianToJulian(new DateTime((int)year, 1, 1));
            leapadj = ((wjd < gregorianToJulian(new DateTime((int)year, 3, 1))) ? 0 : (IsGregorianLeap(year) ? 1 : 2));
            month = Math.Floor((((yearday + leapadj) * 12) + 373) / 367);
            day = (wjd - gregorianToJulian(new DateTime((int)year, (int)month, 1))) + 1;

            strTime = julianToTime(jd);
            nHour = Convert.ToInt32(strTime.Substring(0, 2));
            nMinute = Convert.ToInt32(strTime.Substring(3, 2));
            nSecond = Convert.ToInt32(strTime.Substring(6, 2));
            return new DateTime((int)year, (int)month, (int)day, nHour, nMinute, nSecond);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nHour"></param>
        /// <param name="nMinute"></param>
        /// <param name="nSecond"></param>
        /// <returns></returns>
        private double timeToFractionOfJulian(int nHour, int nMinute, int nSecond)
        {
            return ((nSecond + 60 * (nMinute + 60 * nHour)) / 864000.0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jd"></param>
        /// <returns></returns>
        private string julianToTime(double jd)
        {
            int nHour, nMinute, nSecond;
            double dFract;
            string res;

            dFract = jd - Math.Floor(jd) - 0.5;
            //dFract := Frac(jd) - 0.5;

            nHour = (int)Math.Floor(dFract * 240);
            nMinute = (int)Math.Floor((dFract * 14400) - 60 * nHour);
            nSecond = (int)Math.Round(dFract * 864000 - 60 * (nMinute + 60 * nHour));

            if (nSecond == 60)
            {
                nSecond = 0;
                nMinute = nMinute + 1;
            }
            if (nMinute == 60)
            {
                nMinute = 0;
                nHour = (nHour + 1) % 24;
            }

            res = nHour.ToString().PadLeft(2, '0') + ":" + nMinute.ToString().PadLeft(2, '0') + ":" + nSecond.ToString().PadLeft(2, '0');
            //res= string.Format("{0}:{1}:{2}",nHour.ToString(),nMinute.ToString(),nSecond.ToString());
            return (res);
        }

        #endregion

        #region Property

        public DateTime AsDateTime
        {
            get
            {
                return julianToGregorian(m_Julianday);
            }
            set
            {
                m_Julianday = gregorianToJulian(value);
            }
        }

        /// <summary>
        /// مثال:7/9/1383
        /// </summary>
        public string AsPDate
        {
            get
            {
                return julianToPersian(m_Julianday);
            }
            set
            {
                m_Julianday = persianToJulian(value);
            }
        }

        /// <summary>
        /// به شكل 10 رقم برميگرداند
        /// مثال:02/04/1383
        /// </summary>
        public string AsPDate10
        {
            get
            {
                string str = julianToPersian(m_Julianday);

                string strDelimiter = "/";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = str.Split(aDelimiter);

                return aSplit[0] + "/" + aSplit[1].PadLeft(2, '0') + "/" + aSplit[2].PadLeft(2, '0');
            }
        }

        public string AsRTLPDate
        {
            get
            {
                string strPersianDate = julianToPersian(m_Julianday);
                string strDelimiter = "/";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = strPersianDate.Split(aDelimiter);
                int m_nPYear = System.Convert.ToInt32(aSplit[2], 10);
                int m_nPMonth = System.Convert.ToInt32(aSplit[1], 10);
                int m_nPDay = System.Convert.ToInt32(aSplit[0], 10);
                return (m_nPYear.ToString() + "/" + m_nPMonth.ToString() + "/" + m_nPDay.ToString());
            }

            set
            {
                string strDelimiter = "/";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = value.Split(aDelimiter);
                int m_nPYear = System.Convert.ToInt32(aSplit[2], 10);
                int m_nPMonth = System.Convert.ToInt32(aSplit[1], 10);
                int m_nPDay = System.Convert.ToInt32(aSplit[0], 10);
                m_Julianday = persianToJulian(m_nPYear.ToString() + "/" + m_nPMonth.ToString() + "/" + m_nPDay.ToString());
            }
        }


        public string AsTimeString
        {
            get
            {
                return (julianToTime(m_Julianday));
            }
        }

        public int PYear
        {
            get
            {
                string strPersianDate = julianToPersian(m_Julianday);

                string strDelimiter = "/ ";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = strPersianDate.Split(aDelimiter);
                return System.Convert.ToInt32(aSplit[0], 10);
            }
        }
        public int PMonth
        {
            get
            {
                string strPersianDate = julianToPersian(m_Julianday);

                string strDelimiter = "/ ";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = strPersianDate.Split(aDelimiter);
                return System.Convert.ToInt32(aSplit[1], 10);
            }
        }
        public int PDay
        {
            get
            {
                string strPersianDate = julianToPersian(m_Julianday);

                string strDelimiter = "/ ";
                char[] aDelimiter = strDelimiter.ToCharArray();
                string[] aSplit = strPersianDate.Split(aDelimiter);
                return System.Convert.ToInt32(aSplit[2], 10);
            }
        }

        public string PWeekDay
        {
            get
            {
                string strRes = "";
                System.DayOfWeek dw = julianToGregorian(m_Julianday).DayOfWeek;
                switch (dw)
                {
                    case DayOfWeek.Saturday:
                        strRes = P_DAY_OF_WEEK[0];
                        break;
                    case DayOfWeek.Sunday:
                        strRes = P_DAY_OF_WEEK[1];
                        break;
                    case DayOfWeek.Monday:
                        strRes = P_DAY_OF_WEEK[2];
                        break;
                    case DayOfWeek.Tuesday:
                        strRes = P_DAY_OF_WEEK[3];
                        break;
                    case DayOfWeek.Wednesday:
                        strRes = P_DAY_OF_WEEK[4];
                        break;
                    case DayOfWeek.Thursday:
                        strRes = P_DAY_OF_WEEK[5];
                        break;
                    case DayOfWeek.Friday:
                        strRes = P_DAY_OF_WEEK[6];
                        break;
                }
                return strRes;
            }
        }

        #endregion

        #region Public
        public static string[] P_SEASON = { "بهار", "تابستان", "پاييز", "زمستان" };
        public static string[] P_MONTH_NAME = { "فروردين", "ارديبهشت", "خرداد", "تير", "مرداد", "شهريور", "مهر", "آبان", "آذر", "دي", "بهمن", "اسفند" };
        public static string[] P_DAY_OF_WEEK = { "شنبه", "يكشنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
        public static string[] P_WEEK_OF_MONTH = { "اول", "دوم", "سوم", "چهارم", "پنجم" };

        public enum PeriodType { Yearly, Seasonly, Monthly, Weekly, Daily, Range }

        public void SetTime(int nHour, int nMinute, int nSecond)
        {
            this.AsDateTime = this.AsDateTime.Date;
            this.AsDateTime = this.AsDateTime.AddSeconds(nHour * 3600 + nMinute * 60 + nSecond);
        }

        public bool IsGregorianLeap(double nYear)
        {
            return ((nYear % 4) == 0) &&
                (!(((nYear % 100) == 0) && ((nYear % 400) != 0)));
        }


        public bool IsPersianLeap(int nYear)
        {
            return ((((((nYear - ((nYear > 0) ? 474 : 473)) % 2820) +
                474) + 38) * 682) % 2816) < 682;
        }

        /// <summary>
        /// برگرداندن مدت زمان يك تاريخ به دقيقه
        /// </summary>
        /// <param name="dtInput"></param>
        /// <returns></returns>
        public static int GetMinutes(DateTime dtInput)
        {
            int nResult = 0;

            nResult = dtInput.Hour * 60 + dtInput.Minute;
            return nResult;
        }


        #endregion	
    }
}
