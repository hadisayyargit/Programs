using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class MainCommon
    {
        public static string m_DbPath;
        public static string m_BackupPath;
        public static decimal m_VisitorSN;
        public static decimal m_UserSN;
        public static decimal m_VahedeTejariSN;
        public static string m_CurrentPDate;
        public static string m_ServerIp = "178.248.42.163";
        public static string m_SmsPhone = "200049136";
        public static string m_Sim = "";
        public static bool m_TestMod=false;

        public enum PacketStatus
        {
            New = 0
            , Sending = 1
            , SendedToVDS = 2
            , SendedToMIS = 3
        }

        public enum PacketType
        {
            Feedback = 1
           , KalaMojoodi = 2
           , Darkhast = 3
           , Marjoo = 4
           , KalaNerkh = 5
        }

        public enum SendType
        {
            Cable = 1
            , SMS = 2
            , GPRS = 3
            , Email = 4
            , Wifi = 5
            , Bluetooth = 6
        }

    }
}
