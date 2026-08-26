using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using GlobalUnits;
using CommonUnits;

namespace EmdadMainServices
{
    public class BankPasargadService : IBankPasargadService
    {
        public static List<UssdSession> m_UssdSessionList = new List<UssdSession>();
        public static List<TransitionState> m_TransitionStates = new List<TransitionState>();
        public static List<TransitionGraph> m_TransitionGraph = new List<TransitionGraph>();

        public string progressSession(string EncryptedData)
        {
            string strRes = "";
            string strDecrypteData = "";
            string myMobileno = "", myContent = "0", myUssdState = "", myText = "";
            string strToday = "", strTomorrow = "";
            string[] langArray = new string[] { };

            strDecrypteData = EncryptedData;

            ///for testing
            //strDecrypteData = "content=9655|mobileNumber=989122105628|lang=1|traceCode=|state=1|timestamp=20140223144801";

            string strTerminalCode = ConfigurationManager.AppSettings["terminal_code"];
            string strMerchantCode = ConfigurationManager.AppSettings["merchant_code"];
            System.Globalization.PersianCalendar objPCalendar = new System.Globalization.PersianCalendar();
            strToday = objPCalendar.GetYear(DateTime.Today) + "/" + objPCalendar.GetMonth(DateTime.Today).ToString("00") + "/" + objPCalendar.GetDayOfMonth(DateTime.Today).ToString("00");
            strTomorrow = objPCalendar.GetYear(DateTime.Today.AddDays(1)) + "/" + objPCalendar.GetMonth(DateTime.Today.AddDays(1)).ToString("00") + "/" + objPCalendar.GetDayOfMonth(DateTime.Today.AddDays(1)).ToString("00");

            string strFileName = "c:\\EmdadServices\\log" + DateTime.Today.ToString("yyyyMMdd") + ".txt";

            UssdSession myUssdSession = new UssdSession();

            myUssdSession.Mpaadcode = "1";
            myUssdSession.Amount = 1;
            myUssdSession.traceCode = "";
            myUssdSession.language = "1";


            string[] myInputArray = strDecrypteData.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            string m = myInputArray.First(p => p.ToLower().Contains("mobilenumber"));
            string[] mobileArray = m.Split(new string[] { "=" }, StringSplitOptions.None);
            myMobileno = mobileArray[1];

            string c = myInputArray.First(p => p.ToLower().Contains("content"));
            string[] contentArray = c.Split(new string[] { "=" }, StringSplitOptions.None);
            myContent = contentArray[1];

            string s = myInputArray.First(p => p.ToLower().Contains("state"));
            string[] ussdStateArray = s.Split(new string[] { "=" }, StringSplitOptions.None);
            myUssdState = ussdStateArray[1];

            string tr = myInputArray.First(p => p.ToLower().Contains("tracecode"));
            string[] ussdTraceCodeArray = tr.Split(new string[] { "=" }, StringSplitOptions.None);
            myUssdSession.traceCode = ussdTraceCodeArray[1];

            string lang = myInputArray.First(p => p.ToLower().Contains("lang"));
            langArray = lang.Split(new string[] { "=" }, StringSplitOptions.None);
            myUssdSession.language = langArray[1];

            myUssdSession = m_UssdSessionList.Find(x => x.MobileNo.Contains(myMobileno));

            if (myUssdSession != null && myUssdSession.MobileNo == myMobileno && myUssdSession.UssdState != GeneralModule.UssdState_Begin && myUssdSession.UssdState != GeneralModule.UssdState_End)
            {
                myUssdSession.MobileNo = myMobileno;
                myUssdSession.content = myContent;
                myUssdSession.NextStateKey = myContent;
                myUssdSession.UssdState = GeneralModule.UssdState_Continue;
                myUssdSession.traceCode = ussdTraceCodeArray[1];

                switch (myUssdSession.CurrentTransitionState.TransitionStateNo)
                {
                    case GeneralModule.transition_Begin:
                        if (myUssdSession.content == "0")
                            myUssdSession.language = "1";
                        else
                            myUssdSession.language = "2";

                        myUssdSession.TransitToNextState();


                        break;
                    case GeneralModule.transition_MainMenu:
                        if (myUssdSession.content == "2")
                        {
                            EcommerceService objEcommerceService = new EcommerceService();
                            objEcommerceService.InsertUssdReq(GeneralModule.m_Total85Connection, myUssdSession.MobileNo, "from ussd", out strRes);
                            myUssdSession.UssdState = GeneralModule.UssdState_End;
                        }

                        myUssdSession.TransitToNextState();
                        break;

                    //case GeneralModule.transition_RequisitionSuccess:
                    //        if (myUssdSession.content == "1")
                    //        {
                    //            /// web service for inserting in aid_UssdReq emdad-saipa4
                    //            EcommerceService objEcommerceService = new EcommerceService();
                    //            objEcommerceService.InsertUssdReq(GeneralModule.m_Total85Connection,myUssdSession.MobileNo,"from ussd", out strRes);


                    //            myUssdSession.UssdState = GeneralModule.UssdState_End;
                    //        }
                    //        myUssdSession.TransitToNextState();

                    //    break;
                    case GeneralModule.transition_KharidMenu:
                        int n;
                        if (int.TryParse(myContent, out  n))
                        {
                            if (n > 0 && n <= GeneralModule.m_mpaadcodeList.Count)
                            {
                                myUssdSession.Mpaadcode = GeneralModule.m_mpaadcodeList[n - 1];
                                myUssdSession.Amount = Convert.ToInt32(GeneralModule.m_FinalPriceList[n - 1]);

                                myUssdSession.SelectedPackageId = Convert.ToInt32(GeneralModule.m_PackageIdList[n - 1]);
                                myUssdSession.Mpaadcode = GeneralModule.m_mpaadcodeList[n - 1];
                            }

                            else if (n != 0)
                                myUssdSession.NextStateKey = "-1";

                            myUssdSession.TransitToNextState();

                        }

                        break;
                    case GeneralModule.transition_GetNationalCode:
                        if (myUssdSession.content != "0")
                        {
                            bool IsValidNationalNo = GeneralModule.CheckCodeMelli(myContent);
                            if (IsValidNationalNo)
                            {
                                myUssdSession.NationalNo = myContent;
                                myUssdSession.NextStateKey = "1";

                            }
                            else
                                myUssdSession.NextStateKey = "-1";
                        }

                        myUssdSession.TransitToNextState();

                        break;

                    case GeneralModule.transition_Notify:
                        if (myUssdSession.content != "0")
                        {
                            myUssdSession.NationalNo = myContent;
                            myUssdSession.NextStateKey = "1";
                            myUssdSession.UssdState = GeneralModule.UssdState_NonUSSD;

                        }

                        myUssdSession.TransitToNextState();

                        break;
                    case GeneralModule.transition_PayRequest:
                        /// در این مرحله جواب پرداخت از سمت بانک را دریافت کرده ایم
                        //if (myUssdSession.content == "1")
                        if (myUssdSession.traceCode.ToLower() != "null" && myUssdSession.traceCode != null)
                        ///پرداخت انجام شده
                        {
                            ///عملیات فاکتور
                            EcommerceService objEcommerceService = new EcommerceService();
                            string strxml1 = "<root><subscription chassisno='" + myUssdSession.NationalNo + "' mobile='" + myUssdSession.MobileNo + "' nationalno='" + myUssdSession.NationalNo + "' firstname='' lastname='مشتری از طریق ussd' invoicejdate='" + strTomorrow + "' agencycode='" + GeneralModule.m_UserId + "' price='" + myUssdSession.Amount.ToString() + "'>101<payment terminalCode='" + strTerminalCode + "' merchantCode='" + strMerchantCode + "' trace='" + myUssdSession.traceCode + "' trdate='" + DateTime.Today.ToString("yyyyMMdd") + "' cardnumber='' tref='' paymentprice='" + myUssdSession.Amount.ToString() + "' duejdate='" + strToday + "' status='completed' />"
                                + "<invoiceitem packageid='" + myUssdSession.SelectedPackageId.ToString() + "' fee='" + "' tax ='" + "' toll ='" + "' discount='" + "'></invoiceitem>"
                                + "</subscription></root>";
                            strRes = objEcommerceService.SubmitInvoice(GeneralModule.m_UserId, GeneralModule.m_Password, strxml1);

                            if (strRes != "" && strRes.ToLower().StartsWith("<root>") == false)
                                myUssdSession.NextStateKey = "-2";
                            else
                                myUssdSession.NextStateKey = "1";
                        }
                        else
                            myUssdSession.NextStateKey = "-1";

                        myUssdSession.UssdState = GeneralModule.UssdState_End;

                        myUssdSession.TransitToNextState();

                        break;

                    case GeneralModule.transition_Hint:
                        myUssdSession.TransitToNextState();

                        break;
                    case GeneralModule.transition_Error:
                        myUssdSession.CurrentTransitionState.TransitionStateNo = myUssdSession.ParentTransitionStateNo;
                        myUssdSession.CurrentTransitionState.GoTransitState();
                        myUssdSession.ParentTransitionStateNo = GeneralModule.transition_Begin;

                        break;
                    case GeneralModule.transition_InvalidNationalCode:
                        myUssdSession.CurrentTransitionState.TransitionStateNo = myUssdSession.ParentTransitionStateNo;
                        myUssdSession.CurrentTransitionState.GoTransitState();
                        myUssdSession.ParentTransitionStateNo = GeneralModule.transition_KharidMenu;
                        break;
                }

                if (myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_Success)
                {
                    myUssdSession.UssdState = GeneralModule.UssdState_End;

                    try
                    {
                        string strMessage = string.Format(GeneralModule.m_msgActivate, myUssdSession.NationalNo, "365");
                        int retval = SmsClass.SendEmdadSms(new string[]{myUssdSession.MobileNo}, strMessage);
                        if (retval == 1)
                            SmsClass.InsertEmdadSms(myUssdSession.MobileNo, strMessage, 0, 1);
                    }
                    catch
                    {
                    }
                }

                if (myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_Success || myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_Fail || myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_CpError || myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_Error || myUssdSession.CurrentTransitionState.TransitionStateNo == GeneralModule.transition_InvalidNationalCode)
                    myUssdSession.UssdState = GeneralModule.UssdState_End;

                if (myUssdSession.language == "1")
                    strRes = myUssdSession.CurrentTransitionState.TransitionMessage;
                else
                    strRes = myUssdSession.CurrentTransitionState.TransitionMessage_Finglish;

                m_UssdSessionList.Remove(myUssdSession);
                m_UssdSessionList.Add(myUssdSession);

            }

            else
            {
                if (myUssdSession != null)
                    m_UssdSessionList.Remove(myUssdSession);

                myUssdSession = new UssdSession();
                myUssdSession.MobileNo = myMobileno;
                myUssdSession.language = langArray[1];
                myUssdSession.CurrentTransitionState.TransitionStateNo = GeneralModule.transition_Begin;
                myUssdSession.CurrentTransitionState.GoTransitState();

                myUssdSession.UssdState = GeneralModule.UssdState_Continue;
                myUssdSession.Mpaadcode = "1";
                myUssdSession.Amount = 1;

                m_UssdSessionList.Add(myUssdSession);

                if (myUssdSession.language == "1")
                    strRes = myUssdSession.CurrentTransitionState.TransitionMessage;
                else
                    strRes = myUssdSession.CurrentTransitionState.TransitionMessage_Finglish;
            }

            strRes = "message=" + strRes + "|state=" + myUssdSession.UssdState + "|lang=" + myUssdSession.language + "|errorCode=0" + "|mpaadCode=" + myUssdSession.Mpaadcode + "|amount=" + myUssdSession.Amount.ToString() + "|timestamp=" + DateTime.Now.ToString("yyyyMMddHHmmss");

            try
            {
                myText = "<I> " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " -- " + EncryptedData + " -- TransitionStateNo=" + myUssdSession.CurrentTransitionState.TransitionStateNo.ToString() + " SessionID=" + System.Web.HttpContext.Current.Session["SessionID"].ToString() + " </I>";
                GeneralModule.writeLog(strFileName, myText);
                myText = "<O> " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " -- " + strRes + " -- TransitionStateNo=" + myUssdSession.CurrentTransitionState.TransitionStateNo.ToString() + " SessionID=" + System.Web.HttpContext.Current.Session["SessionID"].ToString() + " </O>";
                GeneralModule.writeLog(strFileName, myText);
            }
            catch
            {
            }

            return strRes;
        }
    }

    public class UssdSession
    {
        public string MobileNo { get; set; }
        public string NationalNo { get; set; }
        public TransitionState CurrentTransitionState { get; set; }
        public int ParentTransitionStateNo { get; set; }
        public int SelectedPackageId { get; set; }

        /// <summary>
        /// کد کالا(سرویس)ـ
        /// </summary>
        public string Mpaadcode { get; set; }
        
        public int Amount { get; set; }
        public int UssdState { get; set; }
        public string traceCode { get; set; }
        public string content { get; set; }
        public string language { get; set; }
        public string NextStateKey { get; set; }
        public DateTime RecordTime { get; set; }

        public UssdSession()
        {
            this.CurrentTransitionState = new TransitionState();
        }

        public void TransitToNextState()
        {
            List<TransitionGraph> myTransitionGraph;
            
             myTransitionGraph = (from p in BankPasargadService.m_TransitionGraph
                                  where (p.TransitionStateNo == this.CurrentTransitionState.TransitionStateNo && ( p.NextStateKey == null || p.NextStateKey == this.NextStateKey))
                 select p).ToList();

             this.ParentTransitionStateNo = this.CurrentTransitionState.TransitionStateNo;

             if (myTransitionGraph.Count > 0)
                 this.CurrentTransitionState.TransitionStateNo = myTransitionGraph[0].NextTransitionStateNo;
             else
                 this.CurrentTransitionState.TransitionStateNo = GeneralModule.transition_Error;

             this.CurrentTransitionState.GoTransitState();
             this.RecordTime = DateTime.Now;
        }

 

    }

    public class TransitionState
    {
        public int TransitionStateNo { get; set; }
        public string TransitionMessage { get; set; }
        public string TransitionMessage_Finglish { get; set; }

        public void GoTransitState()
        {
            List<TransitionState> x;

            x = (from p in BankPasargadService.m_TransitionStates
                 where (p.TransitionStateNo == this.TransitionStateNo)
                 select p).ToList();


            if (x.Count > 0)
            {
                this.TransitionMessage= x[0].TransitionMessage;
                this.TransitionMessage_Finglish = x[0].TransitionMessage_Finglish;
            }
            else
            {
                this.TransitionStateNo = GeneralModule.transition_Error;
                this.TransitionMessage = "ورودی اشتباه است";
                this.TransitionMessage_Finglish = "voroodi eshtebah ast";
            }

        }
    }


    public class TransitionGraph
    {
        public int TransitionStateNo { get; set; }
        public string NextStateKey { get; set; }
        public int NextTransitionStateNo { get; set; }
    }
}
