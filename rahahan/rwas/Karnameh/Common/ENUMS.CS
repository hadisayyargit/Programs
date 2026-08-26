using System;

namespace RWAS.Common
{
    public enum ReportID
    {
        Report1 = 1,
        Report2 = 2,
        Report3 = 3,
        Report4 = 4,
        Report4_1 = 41,
        Report4_2 = 42,
        Report5 = 5,
        Report6 = 6,
        Report7 = 7,
        Report8 = 8,
        Report9 = 9,
        Report10 = 10,
        Report11 = 11,
        Report12 = 12,
        Report13 = 13
    }


    public enum enumDonorId
    {
        President = 1
       ,
        Minister = 2
            ,
        GeneralManager = 6 ///مدیر کل
            ,
        ManagingDirector = 3 ///مدیر عامل
            ,
        Assistant = 5 ///معاون
            , surrogate = 4 ///قائم مقام
    }

    public enum enumEulogyType
    {
        Satisfaction = 1 ///ایمنی - رضایت رئیس گروه حفاظت و ایمنی سیر و حرکت
       ,
        PreventAccidentReport = 2 /// گزارش جلوگیری از حادثه یا کاهش حادثه
            , PreventAccident = 3 ///  جلوگیری از حادثه یا کاهش حادثه

    }

    public enum enumForfeitKind
    {
        Dissatisfaction = 23 ///عدم رضایت رئیس گروه حفاظت
       ,

        enfesal_movaghat = 1 ///1	انفصال موقت
,
        kasr1_3 = 2 ///2	كسر3ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_4 = 3 ///3	كسر4ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_5 = 4 ///4	كسر5ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_6 = 5 ///5	كسر6ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_10 = 6 ///6	كسر10ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_15 = 7 ///7	كسر15ˆ1حقوق وفوق العاده شغل
            ,
        enfesal_daem = 8 ///8	انفصال دائم
            ,
        ekhtar = 9 ///9	اخطار
            ,
        beraat = 10 ///10	برائت
            ,
        ekhraj = 11 ///11	اخراج
            ,
        bazneshasteh = 12 ///12	بازنشسته
            ,
        tobikh = 13 ///13	توبيخ
            ,
        kasr4 = 14 ///14	كسر4روزحقوق وفوق العاده شغل
            ,
        kasr1_8 = 15 ///15	كسر8ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_20 = 16 ///16	كسر20ˆ1حقوق وفوق العاده شغل
            ,
        kasr1_30 = 17 ///17	كسر30ˆ1حقوق وفوق العاده شغل
            ,
        jarimeh_naghdi = 18 ///18	جريمه نقدی
            ,
        taghir_mahal = 19 ///19	تغییر محل جغرافیایی
            ,
        tanazzol_magham = 20 ///20	تنزل مقام یا محرومیت از انتصاب به پستهای دولتی
            ,
        tanazzol_gorooh = 21 ///21	تنزل گروه شغلی یا تعویق در اعطای گروه شغلی
            , bazkharid = 22///22	بازخرید خدمت

    }

}