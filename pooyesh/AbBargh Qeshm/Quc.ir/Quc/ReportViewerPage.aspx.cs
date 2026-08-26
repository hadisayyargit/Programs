using System;
using System.Web.UI;
using quc.Models;
using Microsoft.Reporting.WebForms;

namespace quc
{
    public partial class ReportViewerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ReportViewerControl1.ShowZoomControl = true;

                    ///قبض آب
                    if (((int)Session[GeneralModule.m_billtype]) == 0)
                    {
                        //if (System.IO.File.Exists("\rptAbBill.rdlc"))
                        //ReportViewerControl1.LocalReport.ReportPath = "bin\\rptAbBill.rdlc";

                        AbBillModel myModel = new AbBillModel();
                        ReportModel myReportModel = new ReportModel();

                        myModel = (AbBillModel)Session[GeneralModule.m_abbillmodel];
                        myReportModel = (ReportModel)Session[GeneralModule.m_reportmodel];

                        ReportViewerControl1.ZoomPercent = myReportModel.ZoomPercent;

                        ReportViewerControl1.LocalReport.ReportPath = "rptAbBill.rdlc";

                        ReportParameter pTitr = new ReportParameter("pTitr", "");
                        ReportParameter pSubscribername = new ReportParameter("pSubscribername", myModel.Subscribername);
                        ReportParameter pSubscribeno = new ReportParameter("pSubscribeno", myModel.Subscribeno);
                        ReportParameter pPostalCode = new ReportParameter("pPostalCode", myModel.PostalCode);
                        ReportParameter pAddress = new ReportParameter("pAddress", myModel.Address);
                        ReportParameter pReadPersonCode = new ReportParameter("pReadPersonCode", myModel.ReadPersonCode);
                        ReportParameter pBillDateText = new ReportParameter("pBillDateText", myModel.BillDateText);
                        ReportParameter pBillKindString = new ReportParameter("pBillKindString", myModel.BillKindString);
                        ReportParameter pCodeWord = new ReportParameter("pCodeWord", myModel.CodeWord);
                        ReportParameter pUsageDetailDesc = new ReportParameter("pUsageDetailDesc", myModel.UsageDetailDesc);
                        ReportParameter pUsageInfoDesc = new ReportParameter("pUsageInfoDesc", myModel.UsageInfoDesc);
                        ReportParameter pYear = new ReportParameter("pYear", myModel.Year);
                        ReportParameter pCycleNumber = new ReportParameter("pCycleNumber", myModel.CycleNumber);
                        ReportParameter pResidentialNumber = new ReportParameter("pResidentialNumber", myModel.ResidentialNumber);
                        ReportParameter pFamilyNumber = new ReportParameter("pFamilyNumber", myModel.FamilyNumber);
                        ReportParameter pTxtReadDate = new ReportParameter("pTxtReadDate", myModel.TxtReadDate);
                        ReportParameter pReadNumber = new ReportParameter("pReadNumber", myModel.ReadNumber);
                        ReportParameter pReadStateDesc = new ReportParameter("pReadStateDesc", myModel.ReadStateDesc);
                        ReportParameter pReadViewDesc = new ReportParameter("pReadViewDesc", myModel.ReadViewDesc);
                        ReportParameter pIncDecMessage = new ReportParameter("pIncDecMessage", myModel.IncDecMessage);
                        ReportParameter pBoreDesc = new ReportParameter("pBoreDesc", myModel.BoreDesc);
                        ReportParameter pWaterValueContract = new ReportParameter("pWaterValueContract", myModel.WaterValueContract);
                        ReportParameter pWaterMeterSerial = new ReportParameter("pWaterMeterSerial", myModel.WaterMeterSerial);
                        ReportParameter pBillMinRow = new ReportParameter("pBillMinRow", myModel.BillMinRow);
                        ReportParameter pBillMaxRow = new ReportParameter("pBillMaxRow", myModel.BillMaxRow);
                        ReportParameter pbahayeab = new ReportParameter("pbahayeab", myModel.bahayeab);
                        ReportParameter pkhadamatDafeFaz = new ReportParameter("pkhadamatDafeFaz", myModel.khadamatDafeFaz);
                        ReportParameter pmaliat = new ReportParameter("pmaliat", myModel.maliat);
                        ReportParameter pbedehiGhabli = new ReportParameter("pbedehiGhabli", myModel.bedehiGhabli);
                        ReportParameter pmablaghPardakht = new ReportParameter("pmablaghPardakht", myModel.mablaghPardakht);
                        ReportParameter pBillPartAmount = new ReportParameter("pBillPartAmount", myModel.BillPartAmount);
                        ReportParameter pPayPartAmount = new ReportParameter("pPayPartAmount", myModel.PayPartAmount);
                        ReportParameter pDays = new ReportParameter("pDays", myModel.Days);
                        ReportParameter pUseAmount = new ReportParameter("pUseAmount", myModel.UseAmount);
                        ReportParameter pCommercialNumber = new ReportParameter("pCommercialNumber", myModel.CommercialNumber);
                        ReportParameter pLastReadNumber = new ReportParameter("pLastReadNumber", myModel.LastReadNumber);
                        ReportParameter pPayDate = new ReportParameter("pPayDate", myModel.PayDate);
                        ReportParameter pUseAverage = new ReportParameter("pUseAverage", myModel.UseAverage);
                        ReportParameter pSewageFlag = new ReportParameter("pSewageFlag", myModel.SewageFlag);
                        ReportParameter pShorb76 = new ReportParameter("pShorb76", myModel.Shorb76);
                        ReportParameter pEditAmount = new ReportParameter("pEditAmount", myModel.EditAmount);
                        ReportParameter pBillEditAmount = new ReportParameter("pBillEditAmount", myModel.BillEditAmount);
                        ReportParameter pRialRemain = new ReportParameter("pRialRemain", myModel.RialRemain);
                        ReportParameter pDiscountAmount = new ReportParameter("pDiscountAmount", myModel.DiscountAmount);
                        ReportParameter pPaymentAmount = new ReportParameter("pPaymentAmount", myModel.PaymentAmount);
                        ReportParameter ptxtArr211 = new ReportParameter("ptxtArr211", myModel.txtArr211);
                        ReportParameter ptxtArr212 = new ReportParameter("ptxtArr212", myModel.txtArr212);
                        ReportParameter ptxtArr251 = new ReportParameter("ptxtArr251", myModel.txtArr251);
                        ReportParameter pGeneralMessage = new ReportParameter("pGeneralMessage", myModel.GeneralMessage);

                        ReportViewerControl1.LocalReport.SetParameters(new ReportParameter[] {pGeneralMessage,pTitr,pSubscribeno,pSubscribername,pPostalCode,pAddress,pReadPersonCode,
                    pBillDateText,pBillKindString,pCodeWord,pUsageDetailDesc,pUsageInfoDesc,
                    pYear,pCycleNumber,pResidentialNumber,pFamilyNumber,pTxtReadDate,pReadNumber,pReadStateDesc,pReadViewDesc,pIncDecMessage,
                    pBoreDesc,pWaterValueContract,pWaterMeterSerial,pBillMinRow,pBillMaxRow,pbahayeab,pkhadamatDafeFaz,pmaliat,pbedehiGhabli,
                    pmablaghPardakht,pBillPartAmount,pPayPartAmount,pDays,pUseAmount,pCommercialNumber,pLastReadNumber,pPayDate,pUseAverage,
                    pSewageFlag,pShorb76,pEditAmount,pBillEditAmount,pRialRemain,pDiscountAmount,pPaymentAmount,ptxtArr211,ptxtArr212,ptxtArr251});
                    }


                    ///قبض برق
                    else
                    {

                        BarghBillModel myModel = new BarghBillModel();
                        ReportModel myReportModel = new ReportModel();

                        myModel = (BarghBillModel)Session[GeneralModule.m_barghbillmodel];                        
                        myReportModel = (ReportModel)Session[GeneralModule.m_reportmodel];

                        ReportViewerControl1.ZoomPercent = myReportModel.ZoomPercent;

                        ReportParameter pTitr = new ReportParameter("pTitr", "");
                        ReportParameter pGeneralMessage = new ReportParameter("pGeneralMessage", myModel.GeneralMessage);

                        ReportParameter pCOMPANY_NAME = new ReportParameter("pCOMPANY_NAME", myModel.COMPANY_NAME);
                        ReportParameter pNAME = new ReportParameter("pNAME", myModel.NAME);
                        ReportParameter pADR = new ReportParameter("pADR", myModel.ADR);
                        ReportParameter pPOSTC = new ReportParameter("pPOSTC", myModel.POSTC);
                        ReportParameter pSH_GHABZ = new ReportParameter("pSH_GHABZ", myModel.SH_GHABZ);
                        ReportParameter pSH_PARDAKHT = new ReportParameter("pSH_PARDAKHT", myModel.SH_PARDAKHT);
                        ReportParameter pOMOOR_DES = new ReportParameter("pOMOOR_DES", myModel.OMOOR_DES);
                        ReportParameter pOMOOR_ADR = new ReportParameter("pOMOOR_ADR", myModel.OMOOR_ADR);
                        ReportParameter pTEL_OP = new ReportParameter("pTEL_OP", myModel.TEL_OP);
                        ReportParameter pTEL_KHADAMAT = new ReportParameter("pTEL_KHADAMAT", myModel.TEL_KHADAMAT);
                        ReportParameter pSHENASAYEE = new ReportParameter("pSHENASAYEE", myModel.SHENASAYEE);
                        ReportParameter pID = new ReportParameter("pID", myModel.ID);
                        ReportParameter pESHT = new ReportParameter("pESHT", myModel.ESHT);
                        ReportParameter pINSTD = new ReportParameter("pINSTD", myModel.INSTD);
                        ReportParameter pTARF_CODE = new ReportParameter("pTARF_CODE", myModel.TARF_CODE);
                        ReportParameter pEMOJD = new ReportParameter("pEMOJD", myModel.EMOJD);
                        ReportParameter pDEMANDG = new ReportParameter("pDEMANDG", myModel.DEMANDG);
                        ReportParameter pDEMANDC = new ReportParameter("pDEMANDC", myModel.DEMANDC);
                        ReportParameter pPWR = new ReportParameter("pPWR", myModel.PWR);
                        ReportParameter pDEMANDR = new ReportParameter("pDEMANDR", myModel.DEMANDR);
                        ReportParameter pEXTRA_A = new ReportParameter("pEXTRA_A", myModel.EXTRA_A);
                        ReportParameter pLRD1_A = new ReportParameter("pLRD1_A", myModel.LRD1_A);
                        ReportParameter pCRD1 = new ReportParameter("pCRD1", myModel.CRD1);
                        ReportParameter pUSE1_A = new ReportParameter("pUSE1_A", myModel.USE1_A);
                        ReportParameter pNERKH1 = new ReportParameter("pNERKH1", myModel.NERKH1);
                        ReportParameter pMABE1_A = new ReportParameter("pMABE1_A", myModel.MABE1_A);
                        ReportParameter pLRD2_A = new ReportParameter("pLRD2_A", myModel.LRD2_A);
                        ReportParameter pCRD2 = new ReportParameter("pCRD2", myModel.CRD2);
                        ReportParameter pUSE2_A = new ReportParameter("pUSE2_A", myModel.USE2_A);
                        ReportParameter pNERKH2 = new ReportParameter("pNERKH2", myModel.NERKH2);
                        ReportParameter pMABE2_A = new ReportParameter("pMABE2_A", myModel.MABE2_A);
                        ReportParameter pLRD3_A = new ReportParameter("pLRD3_A", myModel.LRD3_A);
                        ReportParameter pCRD3 = new ReportParameter("pCRD3", myModel.CRD3);
                        ReportParameter pUSE3_A = new ReportParameter("pUSE3_A", myModel.USE3_A);
                        ReportParameter pNERKH3 = new ReportParameter("pNERKH3", myModel.NERKH3);
                        ReportParameter pMABE3_A = new ReportParameter("pMABE3_A", myModel.MABE3_A);
                        ReportParameter pLRD4_A = new ReportParameter("pLRD4_A", myModel.LRD4_A);
                        ReportParameter pCRD4 = new ReportParameter("pCRD4", myModel.CRD4);
                        ReportParameter pUSE4_A = new ReportParameter("pUSE4_A", myModel.USE4_A);
                        ReportParameter pNERKH4 = new ReportParameter("pNERKH4", myModel.NERKH4);
                        ReportParameter pMABE4_A = new ReportParameter("pMABE4_A", myModel.MABE4_A);
                        ReportParameter pLRDR_A = new ReportParameter("pLRDR_A", myModel.LRDR_A);
                        ReportParameter pCRDR1 = new ReportParameter("pCRDR1", myModel.CRDR1);
                        ReportParameter pRUSE1_A = new ReportParameter("pRUSE1_A", myModel.RUSE1_A);
                        ReportParameter pNERKHR = new ReportParameter("pNERKHR", myModel.NERKHR);
                        ReportParameter pMABER1_A = new ReportParameter("pMABER1_A", myModel.MABER1_A);
                        ReportParameter pCNTN1 = new ReportParameter("pCNTN1", myModel.CNTN1);
                        ReportParameter pCNTD1 = new ReportParameter("pCNTD1", myModel.CNTD1);
                        ReportParameter pCNTNR = new ReportParameter("pCNTNR", myModel.CNTNR);
                        ReportParameter pZAR = new ReportParameter("pZAR", myModel.ZAR);
                        ReportParameter pZAR_D = new ReportParameter("pZAR_D", myModel.ZAR_D);
                        ReportParameter pCYC = new ReportParameter("pCYC", myModel.CYC);
                        ReportParameter pYR = new ReportParameter("pYR", myModel.YR);
                        ReportParameter pLDAT = new ReportParameter("pLDAT", myModel.LDAT);
                        ReportParameter pCDAT = new ReportParameter("pCDAT", myModel.CDAT);
                        ReportParameter pTOTD = new ReportParameter("pTOTD", myModel.TOTD);
                        ReportParameter pDATS = new ReportParameter("pDATS", myModel.DATS);
                        ReportParameter pTOT_USE = new ReportParameter("pTOT_USE", myModel.TOT_USE);
                        ReportParameter pZARIB = new ReportParameter("pZARIB", myModel.ZARIB);
                        ReportParameter pMAXLDAT = new ReportParameter("pMAXLDAT", myModel.MAXLDAT);
                        ReportParameter pTOTD_B = new ReportParameter("pTOTD_B", myModel.TOTD_B);
                        ReportParameter pTOT_USE_B = new ReportParameter("pTOT_USE_B", myModel.TOT_USE_B);
                        ReportParameter pTOT_MAB_B = new ReportParameter("pTOT_MAB_B", myModel.TOT_MAB_B);
                        ReportParameter pTOT_MAB_A = new ReportParameter("pTOT_MAB_A", myModel.TOT_MAB_A);
                        ReportParameter pDEMANDM_A = new ReportParameter("pDEMANDM_A", myModel.DEMANDM_A);
                        ReportParameter pPEEK_A = new ReportParameter("pPEEK_A", myModel.PEEK_A);
                        ReportParameter pEMOJD_JAR_A = new ReportParameter("pEMOJD_JAR_A", myModel.EMOJD_JAR_A);
                        ReportParameter pBRANCH_COST_A = new ReportParameter("pBRANCH_COST_A", myModel.BRANCH_COST_A);
                        ReportParameter pETOLL = new ReportParameter("pETOLL", myModel.ETOLL);
                        ReportParameter pABN_A = new ReportParameter("pABN_A", myModel.ABN_A);
                        ReportParameter pTOLL = new ReportParameter("pTOLL", myModel.TOLL);
                        ReportParameter pCREDIT = new ReportParameter("pCREDIT", myModel.CREDIT);
                        ReportParameter pKASR = new ReportParameter("pKASR", myModel.KASR);
                        ReportParameter pTOT_MAB = new ReportParameter("pTOT_MAB", myModel.TOT_MAB);
                        ReportParameter pDATM = new ReportParameter("pDATM", myModel.DATM);


                        ReportViewerControl1.LocalReport.ReportPath = "rptBarghBill.rdlc";
                        ReportViewerControl1.LocalReport.SetParameters(new ReportParameter[] { pGeneralMessage, pTitr, pCOMPANY_NAME, pNAME,pADR,pPOSTC,pSH_GHABZ,pSH_PARDAKHT,pOMOOR_DES,pOMOOR_ADR,pTEL_OP,pTEL_KHADAMAT,pSHENASAYEE,pID,pESHT,pINSTD,pTARF_CODE,pEMOJD,
                                    pDEMANDG,pDEMANDC,pPWR,pDEMANDR,pEXTRA_A,pLRD1_A,pCRD1,pUSE1_A,pNERKH1,pMABE1_A,pLRD2_A,pCRD2,pUSE2_A,pNERKH2,pMABE2_A,
                                    pLRD3_A,pCRD3,pUSE3_A,pNERKH3,pMABE3_A,pLRD4_A,pCRD4,pUSE4_A,pNERKH4,pMABE4_A,pLRDR_A,pCRDR1,pRUSE1_A,pNERKHR,pMABER1_A,pZAR,pZAR_D,pCYC,pYR,pLDAT,pCDAT,pTOTD,pDATS,pTOT_USE,pZARIB,
                                    pMAXLDAT,pTOTD_B,pTOT_USE_B,pTOT_MAB_B,pTOT_MAB_A,pDEMANDM_A,pPEEK_A,pEMOJD_JAR_A,pBRANCH_COST_A,pETOLL,pABN_A,pTOLL,pCREDIT,pKASR,pTOT_MAB,pDATM ,pCNTN1,pCNTD1, pCNTNR});
                    }
                }

                catch(Exception ex)
                {

                }
            }
        }
    }
}