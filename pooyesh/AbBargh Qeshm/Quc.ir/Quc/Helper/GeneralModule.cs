using System;

namespace quc
{
    public class GeneralModule
    {

        public static string[] m_JalaliWeekDayNames = new string[] { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
        public static string[] m_JalaliMonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        public static string[] AlphaNumeric1 = { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه", "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هیجده", "نوزده" };
        public static string[] AlphaNumeric2 = { "", "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        public static string[] AlphaNumeric3 = { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };

        public const string m_CurrentUser = "currentuser";
        public const string m_Message = "message";

        public const string m_JalaliToday = "jalalitoday";
        public const string m_JalaliTodayName = "jalalitodayname";
        public const string m_abbillmodel = "abbillmodel";
        public const string m_barghbillmodel = "barghbillmodel";
        public const string m_reportmodel = "reportmodel";
        public const string m_billtype = "billtype";

        public static string AbH(string Number)
        {
            string IsNegative;
            int DotPosition, pos;
            string IntegerSegment;
            string DecimalSegment;
            string DotTxt, DecimalTxt;

            DecimalTxt = "";
            pos = 0;
            if (Convert.ToDouble(Number) >= 0) IsNegative = "";
            else { IsNegative = "منفی "; pos++; }

            DotPosition = Number.IndexOf('.');
            if (DotPosition != -1)
            {
                IntegerSegment = Number.Substring(pos, Number.Length - pos - DotPosition);
                DecimalSegment = Number.Substring(DotPosition + 1, Number.Length - DotPosition - 1);
                if (Convert.ToInt64(IntegerSegment) != 0) DotTxt = " ممیز ";
                else DotTxt = "";

                switch (DecimalSegment.Length)
                {
                    case 1:
                        DecimalTxt = " دهم ";
                        break;
                    case 2:
                        DecimalTxt = " صدم ";
                        break;
                    case 3:
                        DecimalTxt = " هزارم ";
                        break;
                    case 4:
                        DecimalTxt = " ده هزارم ";
                        break;
                    case 5:
                        DecimalTxt = " صد هزارم ";
                        break;
                }
                return (IsNegative + Horof(IntegerSegment) + DotTxt + Horof(DecimalSegment) + DecimalTxt);
            }
            else
                return (IsNegative + Horof(Number.Substring(pos)));
        }

        public static string Horof(string Number)
        {
            string N;
            long No;

            No = Convert.ToInt64(Number);
            N = No.ToString();

            switch (N.Length)
            {
                case 1:
                case 2:
                case 3:
                    if (Convert.ToInt64(N) < 20) return (GeneralModule.AlphaNumeric1[Convert.ToInt64(N)]);
                    else
                        if (Convert.ToInt64(N) < 100)
                            if ((Convert.ToInt64(N) % 10) == 0) return (GeneralModule.AlphaNumeric2[(Convert.ToInt64(N) / 10)]);
                            else return (GeneralModule.AlphaNumeric2[Convert.ToInt64(N) / 10] + " و " + Horof((Convert.ToInt64(N) % 10).ToString()));
                        else if (Convert.ToInt64(N) < 1000)
                            if ((Convert.ToInt64(N) % 100) == 0) return (GeneralModule.AlphaNumeric3[Convert.ToInt64(N) / 100]);
                            else return (GeneralModule.AlphaNumeric3[Convert.ToInt64(N) / 100] + " و " + Horof((Convert.ToInt64(N) % 100).ToString()));
                    break;
                case 4:
                case 5:
                case 6:
                    if (Convert.ToInt64(N.Substring(N.Length - 3)) == 0) return (Horof(N.Substring(0, N.Length - 3)) + " هزار ");
                    else return (Horof(N.Substring(0, N.Length - 3)) + " هزار و " + Horof(N.Substring(N.Length - 3)));

                case 7:
                case 8:
                case 9:
                    if (Convert.ToInt64(N.Substring(N.Length - 6)) == 0)
                        return (Horof(N.Substring(0, N.Length - 6)) + " میلیون ");
                    else
                        return (Horof(N.Substring(0, N.Length - 6)) + " میلیون و " + Horof(N.Substring(N.Length - 6)));

                default:
                    if (Convert.ToInt64(N.Substring(N.Length - 9)) == 0)
                        return (Horof(N.Substring(0, N.Length - 9)) + " میلیارد ");
                    else
                        return (Horof(N.Substring(0, N.Length - 9)) + " میلیارد و " + Horof(N.Substring(N.Length - 9)));

            }
            return ("Error");

        }

        public static string Separate(string Lnum)
        {
            string MyStr;
            int i, len;
            char[] ch;

            MyStr = "";
            len = Lnum.Length;
            ch = Lnum.ToCharArray();
            for (i = 0; i < len; i++)
            {
                if ((ch[i] >= '0') && (ch[i] <= '9') || (ch[i] == '-')) MyStr += Lnum.Substring(i, 1);
            }
            if (MyStr != "") MyStr = Convert.ToInt64(MyStr).ToString("#,###0");
            return (MyStr);
        }

    }

}