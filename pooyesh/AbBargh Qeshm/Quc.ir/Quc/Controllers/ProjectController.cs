using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using quc.Models;

namespace quc
{
    public class ProjectController : Controller
    {
        
        
        //
        // GET: /Project/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="abModel"></param>
        /// <param name="barghModel"></param>
        /// <param name="billType"> 0: Ab 1:Bargh </param>
        /// <returns></returns>
        public ActionResult AbBarghBill(AbBillModel myAbBillModel, BarghBillModel myBarghBillModel, int billType)
        {
            ReportModel myReportModel;


            Session[GeneralModule.m_billtype] = billType;

            myReportModel = (ReportModel)Session[GeneralModule.m_reportmodel];

            if (billType == 0)
            {
                if (myReportModel == null)
                {
                    myReportModel = new ReportModel();
                    myReportModel.HasDirectPath = false;
                    myAbBillModel = new AbBillModel();
                    myBarghBillModel = null;
                    Session[GeneralModule.m_abbillmodel] = myAbBillModel;
                }
            }
            else
            {
                if (myReportModel == null)
                {
                    myReportModel = new ReportModel();
                    myReportModel.HasDirectPath = false;
                    myBarghBillModel = new BarghBillModel();
                    myAbBillModel = null;
                    Session[GeneralModule.m_barghbillmodel] = myBarghBillModel;
                }
            }

            myReportModel.ZoomPercent = 50;

            if (myReportModel.HasDirectPath)
            {
                myReportModel.ZoomPercent = 100;                
            }

            Session[GeneralModule.m_reportmodel] = myReportModel;

            return View();
        }



        public ActionResult AbProjects()
        {
            return View();
        }

        public ActionResult BarghProjects()
        {
            return View();
        }

        public ActionResult GetAbBill(string subscriberno,int hasdirectpath=0)
        {
            AbBillModel myModel = new AbBillModel();
            ReportModel myReportModel = new ReportModel();

            try
            {
                //http://212.33.216.122:8001/PublishWeb/WebServices/omrService.asmx
                //http://192.168.10.106/PublishWeb/WebServices/omrService.asmx
                quc.omrService.OMRService hor = new omrService.OMRService();

                //11054338 , 11050000
                string[] Params;
                string s = "";
                s = hor.ShowLstDebitBillArr(subscriberno+";0");
                
                Params = s.Split(';');

                myModel.GeneralMessage = "";
                myModel.Subscribeno = Params[1];
                myModel.Subscribername = Params[2] + " " + Params[3];
                myModel.PostalCode = Params[4];
                myModel.Address = Params[5];
                myModel.ReadPersonCode = Params[6];
                myModel.BillDateText = Params[7];
                myModel.BillKindString = Params[8];
                myModel.CodeWord = Params[9];
                myModel.UsageDetailDesc = Params[10];
                myModel.UsageInfoDesc = Params[11];
                myModel.Year = Params[12] + "-" + Params[13];
                myModel.CycleNumber = "1";
                myModel.ResidentialNumber = Params[14];
                myModel.FamilyNumber = Params[15];
                myModel.TxtReadDate = Params[16];
                myModel.ReadNumber = Params[17];
                myModel.ReadStateDesc = Params[18];
                myModel.ReadViewDesc = Params[19];
                myModel.IncDecMessage = Params[20];//tarighGeraateGhabli
                myModel.BoreDesc = Params[21];
                myModel.WaterValueContract = Params[22];//formul
                myModel.WaterMeterSerial = Params[23];
                myModel.BillMinRow = Params[24];//tedad
                myModel.BillMaxRow = Params[25];//mande    
                myModel.bahayeab = GeneralModule.Separate(Params[26]);
                myModel.khadamatDafeFaz = GeneralModule.Separate(Params[27]);
                myModel.maliat = GeneralModule.Separate(Params[28]);
                myModel.bedehiGhabli = GeneralModule.Separate(Params[29]);
                myModel.mablaghPardakht = Params[30];
                myModel.BillPartAmount = Params[31];
                myModel.PayPartAmount = Params[32];
                myModel.Days = Params[33];
                myModel.UseAmount = Params[34];
                myModel.CommercialNumber = Params[35];
                myModel.LastReadNumber = Params[36];
                myModel.PayDate = Params[37];
                myModel.UseAverage = Math.Round(Convert.ToDecimal(Params[38].ToString()) * 1000, 0, MidpointRounding.ToEven).ToString();
                myModel.AreaDesc = Params[39] + " " + Params[40];
                myModel.ZoneDesc = Params[40];
                myModel.SewageFlag = Params[41];
                myModel.Shorb76 = GeneralModule.Separate(Params[42]);
                myModel.EditAmount = GeneralModule.Separate(Params[43]);
                myModel.BillEditAmount = GeneralModule.Separate(Params[44]);
                myModel.RialRemain = GeneralModule.Separate(Params[45]);
                myModel.CostAmount = GeneralModule.Separate(Params[46]);
                myModel.DiscountAmount = GeneralModule.Separate(Params[47]);
                myModel.PaymentAmount = Params[48];
                myModel.txtArr251 = GeneralModule.Separate(
                            (Int32.Parse(Params[26].ToString()) +
                            Int32.Parse(Params[27].ToString()) +
                            Int32.Parse(Params[28].ToString()) +
                            Int32.Parse(Params[42].ToString())).ToString()
                            );

                if (Params[30].ToString().Equals("بستانکار"))
                {
                    myModel.PaymentAmount = Params[30].ToString();
                    //myModel.PayPartAmount = Params[30].ToString();

                }
                else
                {
                    myModel.PaymentAmount = GeneralModule.AbH(Params[30].ToString());
                    //myModel.PayPartAmount = GeneralModule.Separate(Params[30].ToString());
                    //txtArr47.Text = AbH(myDataTbl.Rows[0].ItemArray[29].ToString());
                    //txtArr29.Text = GeneralModule.Separate(myDataTbl.Rows[0].ItemArray[29].ToString());

                }
                int i = Int32.Parse(Params[22]);
                if (i != 0)
                {
                    if (i == 999999)
                        myModel.txtArr211 = "0";
                    else
                    {
                        
                        myModel.txtArr211 = (Math.Round((double)((i * 1000) / 30) * Int32.Parse(Params[33]),2)).ToString();
                        myModel.txtArr212 = (Int32.Parse(Params[34]) - i).ToString();

                    }
                }
                else
                {

                    myModel.txtArr211 = Params[38].ToString();
                    myModel.txtArr212 = "0";
                }

            }
            catch(Exception ex)
            {
                myModel.GeneralMessage = "error:" + ex.Message;
            }

            Session[GeneralModule.m_abbillmodel] = myModel;

            if (hasdirectpath==0 )
            {
                myReportModel.HasDirectPath = false;
                myReportModel.ZoomPercent = 50;
                Session[GeneralModule.m_reportmodel] = myReportModel;
                return RedirectToAction("AbBarghBill", "Project",routeValues:new { myAbBillModel = myModel,  billtype=0});
            }
            else
            {
                myReportModel.HasDirectPath = true;
                myReportModel.ZoomPercent = 100;
                Session[GeneralModule.m_reportmodel] = myReportModel;
                return Redirect("~/ReportViewerPage.aspx");
            }

            //return Redirect(@"http://www.yahoo.com");
        }

        public ActionResult GetBarghBill(string subscriberno, int hasdirectpath = 0)
        {
            BarghBillModel myModel = new BarghBillModel();
            ReportModel myReportModel = new ReportModel();

            //http://82.115.27.221:8081/amar/gheshmwebservice.asmx

            qeshmBarghService.GheshmWebService myQeshmBarghService = new qeshmBarghService.GheshmWebService();


            try
            {
                string[] Params;
                string s = "";
                //s = myQeshmBarghService.GetBillsList(15540);
                s = myQeshmBarghService.GetBillsList(int.Parse(subscriberno));
                Params = s.Split(',');

                myModel.GeneralMessage = "";

                myModel.ABN_A = Params[0];
                if (myModel.ABN_A != null)
                    myModel.ABN_A = myModel.ABN_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ADR = Params[2];
                if (myModel.ADR != null)
                    myModel.ADR = myModel.ADR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.BRANCH_COST_A = Params[4];
                if (myModel.BRANCH_COST_A != null)
                    myModel.BRANCH_COST_A = myModel.BRANCH_COST_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CNTN1 = Params[7];
                if (myModel.CNTN1 != null)
                    myModel.CNTN1 = myModel.CNTN1.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CNTD1 = Params[6];
                if (myModel.CNTD1 != null)
                    myModel.CNTD1 = myModel.CNTD1.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CNTNR = "";

                myModel.COMPANY_NAME = Params[8];
                if (myModel.COMPANY_NAME != null)
                    myModel.COMPANY_NAME = myModel.COMPANY_NAME.Split(':')[1].Replace('"',' ').Trim().TrimStart(new char[] { '0' });

                myModel.CRD1 = Params[9];
                if (myModel.CRD1 != null)
                    myModel.CRD1 = myModel.CRD1.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CRD2 = Params[10];
                if (myModel.CRD2 != null)
                    myModel.CRD2 = myModel.CRD2.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CRD3 = Params[11];
                if (myModel.CRD3 != null)
                    myModel.CRD3 = myModel.CRD3.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CRD4 = Params[12];
                if (myModel.CRD4 != null)
                    myModel.CRD4 = myModel.CRD4.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CRDR1 = Params[13];
                if (myModel.CRDR1 != null)
                    myModel.CRDR1 = myModel.CRDR1.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CREDIT = Params[14];
                if (myModel.CREDIT != null)
                    myModel.CREDIT = myModel.CREDIT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CYC = Params[15];
                if (myModel.CYC != null)
                    myModel.CYC = myModel.CYC.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DATM = Params[16];
                if (myModel.DATM != null)
                    myModel.DATM = myModel.DATM.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DATS = Params[17];
                if (myModel.DATS != null)
                    myModel.DATS = myModel.DATS.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DEMANDC = Params[19];
                if (myModel.DEMANDC != null)
                    myModel.DEMANDC = myModel.DEMANDC.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DEMANDG = Params[20];
                if (myModel.DEMANDG != null)
                    myModel.DEMANDG = myModel.DEMANDG.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DEMANDM_A = Params[21];
                if (myModel.DEMANDM_A != null)
                    myModel.DEMANDM_A = myModel.DEMANDM_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.DEMANDR = Params[22];
                if (myModel.DEMANDR != null)
                    myModel.DEMANDR = myModel.DEMANDR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.EMOJD = Params[23];
                if (myModel.EMOJD != null)
                    myModel.EMOJD = myModel.EMOJD.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.EMOJD_JAR_A = Params[24];
                if (myModel.EMOJD_JAR_A != null)
                    myModel.EMOJD_JAR_A = myModel.EMOJD_JAR_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ESHT = Params[25];
                if (myModel.ESHT != null)
                    myModel.ESHT = myModel.ESHT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ETOLL = Params[26];
                if (myModel.ETOLL != null)
                    myModel.ETOLL = myModel.ETOLL.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.EXTRA_A = Params[27];
                if (myModel.EXTRA_A != null)
                    myModel.EXTRA_A = myModel.EXTRA_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ID = Params[30];
                if (myModel.ID != null)
                    myModel.ID = myModel.ID.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.INSTD = Params[31];
                if (myModel.INSTD != null)
                    myModel.INSTD = myModel.INSTD.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.KASR = Params[33];
                if (myModel.KASR != null)
                    myModel.KASR = myModel.KASR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LDAT = Params[35];
                if (myModel.LDAT != null)
                    myModel.LDAT = myModel.LDAT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LRD1_A = Params[37];
                if (myModel.LRD1_A != null)
                    myModel.LRD1_A = myModel.LRD1_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LRD2_A = Params[39];
                if (myModel.LRD2_A != null)
                    myModel.LRD2_A = myModel.LRD2_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LRD3_A = Params[40];
                if (myModel.LRD3_A != null)
                    myModel.LRD3_A = myModel.LRD3_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LRD4_A = Params[42];
                if (myModel.LRD4_A != null)
                    myModel.LRD4_A = myModel.LRD4_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.LRDR_A = Params[44];
                if (myModel.LRDR_A != null)
                    myModel.LRDR_A = myModel.LRDR_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MABE1_A = Params[45];
                if (myModel.MABE1_A != null)
                    myModel.MABE1_A = myModel.MABE1_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MABE2_A = Params[46];
                if (myModel.MABE2_A != null)
                    myModel.MABE2_A = myModel.MABE2_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MABE3_A = Params[47];
                if (myModel.MABE3_A != null)
                    myModel.MABE3_A = myModel.MABE3_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MABE4_A = Params[48];
                if (myModel.MABE4_A != null)
                    myModel.MABE4_A = myModel.MABE4_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MABER1_A = Params[49];
                if (myModel.MABER1_A != null)
                    myModel.MABER1_A = myModel.MABER1_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.MAXLDAT = Params[50];
                if (myModel.MAXLDAT != null)
                    myModel.MAXLDAT = myModel.MAXLDAT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.CDAT = Params[51];
                if (myModel.CDAT != null)
                    myModel.CDAT = myModel.CDAT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NAME = Params[52];
                if (myModel.NAME != null)
                    myModel.NAME = myModel.NAME.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NERKH1 = Params[53];
                if (myModel.NERKH1 != null)
                    myModel.NERKH1 = myModel.NERKH1.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NERKH2 = Params[54];
                if (myModel.NERKH2 != null)
                    myModel.NERKH2 = myModel.NERKH2.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NERKH3 = Params[55];
                if (myModel.NERKH3 != null)
                    myModel.NERKH3 = myModel.NERKH3.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NERKH4 = Params[56];
                if (myModel.NERKH4 != null)
                    myModel.NERKH4 = myModel.NERKH4.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.NERKHR = Params[57];
                if (myModel.NERKHR != null)
                    myModel.NERKHR = myModel.NERKHR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.OMOOR_ADR = Params[58];
                if (myModel.OMOOR_ADR != null)
                    myModel.OMOOR_ADR = myModel.OMOOR_ADR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.OMOOR_DES = Params[59];
                if (myModel.OMOOR_DES != null)
                    myModel.OMOOR_DES = myModel.OMOOR_DES.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.PEEK_A = Params[60];
                if (myModel.PEEK_A != null)
                    myModel.PEEK_A = myModel.PEEK_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.POSTC = Params[61];
                if (myModel.POSTC != null)
                    myModel.POSTC = myModel.POSTC.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.PWR = Params[62];
                if (myModel.PWR != null)
                    myModel.PWR = myModel.PWR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.RUSE1_A = Params[65];
                if (myModel.RUSE1_A != null)
                    myModel.RUSE1_A = myModel.RUSE1_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.SH_GHABZ = Params[66];
                if (myModel.SH_GHABZ != null)
                    myModel.SH_GHABZ = myModel.SH_GHABZ.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.SH_PARDAKHT = Params[67];
                if (myModel.SH_PARDAKHT != null)
                    myModel.SH_PARDAKHT = myModel.SH_PARDAKHT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.SHENASAYEE = Params[68];
                if (myModel.SHENASAYEE != null)
                    myModel.SHENASAYEE = myModel.SHENASAYEE.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TARF_CODE = Params[69];
                if (myModel.TARF_CODE != null)
                    myModel.TARF_CODE = myModel.TARF_CODE.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TEL_KHADAMAT = Params[71];
                if (myModel.TEL_KHADAMAT != null)
                    myModel.TEL_KHADAMAT = myModel.TEL_KHADAMAT.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TEL_OP = Params[73];
                if (myModel.TEL_OP != null)
                    myModel.TEL_OP = myModel.TEL_OP.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOLL = Params[74];
                if (myModel.TOLL != null)
                    myModel.TOLL = myModel.TOLL.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOT_MAB = Params[76];
                if (myModel.TOT_MAB != null)
                    myModel.TOT_MAB = myModel.TOT_MAB.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOT_MAB_A = Params[77];
                if (myModel.TOT_MAB_A != null)
                    myModel.TOT_MAB_A = myModel.TOT_MAB_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOT_MAB_B = Params[78];
                if (myModel.TOT_MAB_B != null)
                    myModel.TOT_MAB_B = myModel.TOT_MAB_B.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOT_USE = Params[79];
                if (myModel.TOT_USE != null)
                    myModel.TOT_USE = myModel.TOT_USE.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOT_USE_B = Params[81];
                if (myModel.TOT_USE_B != null)
                    myModel.TOT_USE_B = myModel.TOT_USE_B.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOTD = Params[85];
                if (myModel.TOTD != null)
                    myModel.TOTD = myModel.TOTD.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.TOTD_B = Params[87];
                if (myModel.TOTD_B != null)
                    myModel.TOTD_B = myModel.TOTD_B.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.USE1_A = Params[88];
                if (myModel.USE1_A != null)
                    myModel.USE1_A = myModel.USE1_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.USE2_A = Params[89];
                if (myModel.USE2_A != null)
                    myModel.USE2_A = myModel.USE2_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.USE3_A = Params[90];
                if (myModel.USE3_A != null)
                    myModel.USE3_A = myModel.USE3_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.USE4_A = Params[91];
                if (myModel.USE4_A != null)
                    myModel.USE4_A = myModel.USE4_A.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.YR = Params[92];
                if (myModel.YR != null)
                    myModel.YR = myModel.YR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ZAR = Params[93];
                if (myModel.ZAR != null)
                    myModel.ZAR = myModel.ZAR.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ZAR_D = Params[94];
                if (myModel.ZAR_D != null)
                    myModel.ZAR_D = myModel.ZAR_D.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

                myModel.ZARIB = Params[95];
                if (myModel.ZARIB != null)
                    myModel.ZARIB = myModel.ZARIB.Split(':')[1].Replace('"', ' ').Trim().TrimStart(new char[] { '0' });

            }

            catch (Exception ex)
            {
                string strErr = ex.Message;
                if(strErr.Contains("found"))
                       strErr = $"مشترک با شناسه {subscriberno} نامعتبر است";
                
                myModel.GeneralMessage = strErr;

            }

            Session[GeneralModule.m_barghbillmodel] = myModel;

            if (hasdirectpath == 0)
            {
                myReportModel.HasDirectPath = false;
                myReportModel.ZoomPercent = 50;
                Session[GeneralModule.m_reportmodel] = myReportModel;
                return RedirectToAction("AbBarghBill", "Project", routeValues: new { myBarghBillModel = myModel, billtype = 1 });
            }
            else
            {
                myReportModel.HasDirectPath = true;
                myReportModel.ZoomPercent = 100;
                Session[GeneralModule.m_reportmodel] = myReportModel;
                return Redirect("~/ReportViewerPage.aspx");
            }

        }


    }

}