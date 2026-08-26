using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using GlobalUnits;
using CommonUnits;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace EmdadMainServices
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            /*
            GeneralModule.m_UserId = "518000";
            GeneralModule.m_Password = "518000";
            */

            GeneralModule.m_UserId = "5555555";
            GeneralModule.m_Password = "54321$2";

            EcommerceService objEcmService1 = new EcommerceService();
            DataSet ds = objEcmService1.GetServices(GeneralModule.m_UserId, GeneralModule.m_Password);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    GeneralModule.m_mpaadcodeList.Add(ConfigurationManager.AppSettings["merchant_code"] + ds.Tables[0].Rows[i]["servicecode"].ToString());
                    
                    GeneralModule.m_FinalPriceList.Add(ds.Tables[0].Rows[i]["finalprice"].ToString());
                    ///for testing
                    //GeneralModule.m_FinalPriceList.Add("25000");

                    GeneralModule.m_PackageIdList.Add(ds.Tables[0].Rows[i]["packageid"].ToString());
                    GeneralModule.m_KharidMenu += (i + 1).ToString() + "- " + ds.Tables[0].Rows[i]["servicedesc"].ToString() + " " + GeneralModule.m_FinalPriceList[i] + "ریال";
                    GeneralModule.m_KharidMenu_Finglish += (i + 1).ToString() + "- " + ds.Tables[0].Rows[i]["ServiceDescFinglish"].ToString() + " " + GeneralModule.m_FinalPriceList[i] + "Rials";
                }
            }

            //GeneralModule.m_KharidMenu = string.Format(CommonUnits.Resources.graph.ResourceManager.GetString("transition_KharidMenu", new CultureInfo("fa-IR")), GeneralModule.m_KharidMenu);
            GeneralModule.m_KharidMenu = CommonUnits.Resources.graph.ResourceManager.GetString("transition_KharidMenu", new CultureInfo("fa-IR")).Replace("<menuitems>", GeneralModule.m_KharidMenu);
            GeneralModule.m_KharidMenu_Finglish = CommonUnits.Resources.graph.ResourceManager.GetString("transition_KharidMenu", new CultureInfo("en-US")).Replace("<menuitems>", GeneralModule.m_KharidMenu_Finglish);

            /*
            CultureInfo ci = new CultureInfo("fa-IR");
            //CultureInfo ci = new CultureInfo("en-US");

            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;                 

            string s1 = CommonUnits.Resources.graph.transition_Begin;
            string s2 = CommonUnits.Resources.graph.ResourceManager.GetString("transition_Begin", new CultureInfo("en-US"));
            */

            BankPasargadService.m_TransitionStates = new List<TransitionState>()
                    {                         
                        new TransitionState(){TransitionStateNo=GeneralModule.transition_Begin,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Begin", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Begin", new CultureInfo("en-US"))}

                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Error,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Error", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Error", new CultureInfo("en-US"))}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Fail,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Fail", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Fail", new CultureInfo("en-US"))}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Success,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Success", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Success", new CultureInfo("en-US"))}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_RequisitionSuccess,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_RequisitionSuccess", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_RequisitionSuccess", new CultureInfo("en-US"))}

                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Success,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_SuccessRequisition", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_SuccessRequisition", new CultureInfo("en-US"))}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_MainMenu,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_MainMenu", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_MainMenu", new CultureInfo("en-US"))}

                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_KharidMenu,TransitionMessage=GeneralModule.m_KharidMenu, TransitionMessage_Finglish=GeneralModule.m_KharidMenu_Finglish}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_GetNationalCode,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_GetNationalCode", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_GetNationalCode", new CultureInfo("en-US"))}


                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Hint,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Hint", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Hint", new CultureInfo("en-US"))}
                        
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_InvalidNationalCode,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_InvalidNationalCode", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_InvalidNationalCode", new CultureInfo("en-US"))}
                        
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_PayRequest}
                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_Notify,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Notify", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_Notify", new CultureInfo("en-US"))}

                        ,new TransitionState(){TransitionStateNo=GeneralModule.transition_CpError,TransitionMessage=CommonUnits.Resources.graph.ResourceManager.GetString("transition_CpError", new CultureInfo("fa-IR")),TransitionMessage_Finglish=CommonUnits.Resources.graph.ResourceManager.GetString("transition_CpError", new CultureInfo("en-US"))}
                                    
                    };

            BankPasargadService.m_TransitionGraph = new List<TransitionGraph>
                    { // Colection Initializer
                        new TransitionGraph(){TransitionStateNo=GeneralModule.transition_Begin,NextStateKey="0", NextTransitionStateNo=GeneralModule.transition_MainMenu}                            
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_Begin,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_MainMenu}                            

                        
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_MainMenu,NextStateKey="0", NextTransitionStateNo=GeneralModule.transition_Begin}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_MainMenu,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_KharidMenu}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_MainMenu,NextStateKey="2", NextTransitionStateNo=GeneralModule.transition_RequisitionSuccess}
                        
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_KharidMenu,NextStateKey="0", NextTransitionStateNo=GeneralModule.transition_MainMenu}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_KharidMenu,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_GetNationalCode}
                        
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_Hint,NextStateKey="0", NextTransitionStateNo=GeneralModule.transition_GetNationalCode}
                        
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_GetNationalCode,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_Notify}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_GetNationalCode,NextStateKey="0", NextTransitionStateNo=GeneralModule.transition_Hint}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_GetNationalCode,NextStateKey="-1", NextTransitionStateNo=GeneralModule.transition_InvalidNationalCode}
                        
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_Notify,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_PayRequest}

                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_PayRequest,NextStateKey="1", NextTransitionStateNo=GeneralModule.transition_Success}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_PayRequest,NextStateKey="-1", NextTransitionStateNo=GeneralModule.transition_Fail}
                        ,new TransitionGraph(){TransitionStateNo=GeneralModule.transition_PayRequest,NextStateKey="-2", NextTransitionStateNo=GeneralModule.transition_CpError}
                    };

            DataSet myDs = new DataSet();

            GeneralModule.m_EcommerceConnection.ConnectionString = ConfigurationManager.ConnectionStrings["EcommerceConnection"].ConnectionString;

            try
            {
                GeneralModule.m_EcommerceConnection.Open();
            }
            catch
            {
            }

            try
            {
                myDs.Tables.Add("dtMessageTemplate");
                DatasetClass.FillDataSet(GeneralModule.m_EcommerceConnection, myDs.Tables["dtMessageTemplate"], "select * from tblMessageTemplate");
                GeneralModule.m_msgActivate = myDs.Tables["dtMessageTemplate"].Select("MsgTmplId=1")[0]["MsgBody"].ToString();
            }
            catch
            {
            }


            GeneralModule.m_Total85Connection.ConnectionString = ConfigurationManager.ConnectionStrings["Total85Connection"].ConnectionString;

            try
            {
                GeneralModule.m_Total85Connection.Open();
            }
            catch
            {
            }


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["SessionID"] = Session.SessionID;
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}