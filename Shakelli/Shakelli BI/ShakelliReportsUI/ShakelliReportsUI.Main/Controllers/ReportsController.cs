using GlobalUnits;
using ShakelliReportsUI.DataLayer.Models;
using Kendo.Mvc.UI;
using NPOI.HSSF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using System.Data.SqlClient;
using System.Data;
using ShakelliReportsUI.CommonUnits;
using System.Resources;
using ShakelliReportsUI.CommonUnits.Resources;
using System.Diagnostics;
using System.Reflection;

namespace ShakelliReportsUI.Main.Controllers
{
    public class ReportsController : Controller
    {
        private ShakelliDWEntities db = new ShakelliDWEntities();

        public ActionResult SubmitReport(int stateid = 0, string citycode = null, Nullable<int> branch = null, string salesmancode = null, string fromdate = null, string todate = null, string supervisorcode = null, string customercode = "", int reportdisplaymode = 0, Nullable<int> anbarid = null, string kalagroupcode = null, string kalasubgroupcode = null, string kalaid = null, string kanaltozi = null, string classtakhfif = null, string districtcode = null,string tradinggrp = null, string nontipparameters1 = null, string nontipparameters2 = null, string nontipparameters3 = null, string nontipparameters4 = null, string nontipparameters5 = null)
        {

            if (citycode == "undefined")
                citycode = null;

            if (fromdate == "" || fromdate == "undefined")
                fromdate = null;

            if (todate == "" || todate == "undefined")
                todate = null;

            if (salesmancode == "-1" || salesmancode == "undefined" || salesmancode == "0")
                salesmancode = null;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).ReportDisplayMode = (ReportFormatEnum)reportdisplaymode;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).StateCode = stateid.ToString();

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).CityCode = citycode;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).Branch = branch;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).FromDate = fromdate;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).ToDate = todate;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).AnbarId = anbarid;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).DistrictCode = districtcode;
            
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).SalesmanCode = salesmancode;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).SupervisorCode = supervisorcode;

            try
            {
                ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).CustomerId = Convert.ToInt32(customercode);
            }
            catch
            {
                ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).CustomerId = 0;
            }


            if (((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).CustomerId == -1)
                ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).CustomerId = 0;


            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).KanalTozi = kanaltozi;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).ClassTakhfif = classtakhfif;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).KalaGroupCode = kalagroupcode;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).KalaSubGroupCode = kalasubgroupcode;

            
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).tradinggrp = tradinggrp;

            try
            {
                ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).StockRef = Convert.ToInt32(kalaid);
            }
            catch
            {
                ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).StockRef = 0;
            }

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).NonTipParameters1_Value = nontipparameters1;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).NonTipParameters2_Value = nontipparameters2;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).NonTipParameters3_Value = nontipparameters3;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).NonTipParameters4_Value = nontipparameters4;
            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).NonTipParameters5_Value = nontipparameters5;

            ((ReportModel)Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]).RunStatus = RunStatusEnum.Started;

            return RedirectToAction("DoReport", "Reports", Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ReportModel]);
        }

        /// <summary>
        /// برای استفاده در ایجکس
        /// </summary>
        /// <param name="branch"></param>
        /// <returns></returns>
        public ActionResult GetSellers(string branch)
        {
            //perform your action here

            var result = db.vwSeller.Where(a => a.BRANCH == branch).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetCustomers(string salesmancode)
        {
            var result = db.vwCustomer.Where(a => a.SalesmanCode == salesmancode).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ReportMaster(ReportModel myReportModel)
        {
            if (HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] == null)
            {
                //Response.Redirect("~/Account/Login");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                string m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]).ToString();
                Session[CommonUnits.GeneralModule.m_MessageList] = db.AppNotification.Where(a => (a.NotificationType == 0 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                Session[CommonUnits.GeneralModule.m_NotificationList] = db.AppNotification.Where(a => (a.NotificationType == 1 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
            }

            if (Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserType]) == CommonUnits.GeneralModule.m_UserType_Sale)
            {
                myReportModel.SalesmanCode = Session[CommonUnits.GeneralModule.m_CurrentUserName].ToString();
                try
                {
                    myReportModel.Branch = int.Parse(db.vwSeller.Where(a => a.SalesmanCode == myReportModel.SalesmanCode).First().BRANCH);
                }
                catch
                {

                }
            }

            //if (myReportModel.ReportName != null && myReportModel.RunStatus != RunStatusEnum.Started)
            if (myReportModel.ReportName != null )
            {
                ViewBag.Branch = db.vwBranch.ToList();
                string br = myReportModel.Branch.ToString();
                if (br == "")
                    ViewBag.Seller = db.vwSeller.Where(a => a.BRANCH == "-1").ToList();
                else
                    ViewBag.Seller = db.vwSeller.Where(a => a.BRANCH == br).ToList();

                if (myReportModel.SalesmanCode == null)
                    ViewBag.Customer = db.vwCustomer.Where(a => a.SalesmanCode == "-1").ToList();
                else
                    ViewBag.Customer = db.vwCustomer.Where(a => a.SalesmanCode == myReportModel.SalesmanCode).ToList();

                /*
                ViewBag.Supervisor = db.Safa_vw_Supervisor.ToList();

                ViewBag.State = db.Safa_vw_State.ToList();
                ViewBag.City = db.Safa_vw_City.ToList();
            
                ViewBag.District = db.Safa_vw_DISTRICT.ToList();

                ViewBag.Anbar = db.vwAnbar.ToList();
                ViewBag.KalaGroup = db.Safa_vw_KalaGroup.ToList();
                ViewBag.KalaSubGroup = db.Safa_vw_KalaSubGroup.ToList();
                ViewBag.Kala = db.vwKala.ToList();
                ViewBag.KanalTozi = db.Safa_vw_KanalTozi.ToList();
                ViewBag.ClassTakhfif = db.Safa_vw_ClassTakhfif.ToList();
                ViewBag.TradingGroup = db.Safa_vw_TradingGroup.ToList();
                */

            }

            myReportModel.ContollerName = "Reports";
            myReportModel.ContollerAction = "DoReport";

            Session[CommonUnits.GeneralModule.m_ReportModel] = myReportModel;

            return View("ReportMaster", myReportModel);
        }

        public string TestExec()
        {
            string strRes = "";
            Process p = new Process();

            //p.StartInfo.FileName = @"c:\Program Files\Microsoft SQL Server\MSRS10_50.MSSQLSERVER\Reporting Services\ReportServer\ReportBuilder\ReportBuilder_3_0_0_0.application";
            p.StartInfo.FileName = @"c:\test1\klite.exe";
            p.StartInfo.LoadUserProfile = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;


            try
            {
                bool b = p.Start();
            }
            catch(Exception ex)
            {
                strRes = ex.Message;

            }


            return strRes;
        }

        public FileResult ExportToExcel()
        {
            //IEnumerable<postReportData> myreport = GetReportData(ReportName, p);

            //Create new Excel workbook
            var workbook = new HSSFWorkbook();

            //Create new Excel sheet
            var sheet = workbook.CreateSheet();

            DataSet ds = new DataSet();

            try
            {
                ds = (DataSet)Session[CommonUnits.GeneralModule.m_postReportData];
            }

            catch
            {
                ///List<> To Dataset
                
                List<postReportData> mm = (List<postReportData>)Session[CommonUnits.GeneralModule.m_postReportData];
                DataTable dataTable = new DataTable(typeof(postReportData).Name);
                ds.Tables.Add(dataTable);
                PropertyInfo[] Props = typeof(postReportData).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    dataTable.Columns.Add(prop.Name);                   
                }

                foreach (postReportData item in mm)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }


            }
            

            var headerRow = sheet.CreateRow(0);

            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                sheet.SetColumnWidth(i, 10 * 200);
                if(ds.Tables[0].Columns[i].DataType.FullName == "System.Int16" || ds.Tables[0].Columns[i].DataType.FullName == "System.Int32" || ds.Tables[0].Columns[i].DataType.FullName == "System.Single" || ds.Tables[0].Columns[i].DataType.FullName == "System.Double")
                    headerRow.CreateCell(i,NPOI.SS.UserModel.CellType.NUMERIC).SetCellValue(ds.Tables[0].Columns[i].Caption);
                else
                    headerRow.CreateCell(i).SetCellValue(ds.Tables[0].Columns[i].Caption);
            }


            //Set the column names in the header row

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            int rowNumber = 1;

            //Populate the sheet with values from the grid data

            foreach (DataRow myRow in ds.Tables[0].Rows)
            {
                //Create a new row
                var row = sheet.CreateRow(rowNumber++);

                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    try
                    {
                        if (ds.Tables[0].Columns[j].DataType.FullName == "System.Int16")
                            row.CreateCell(j).SetCellValue(Convert.ToInt16(myRow[j]));
                        else if (ds.Tables[0].Columns[j].DataType.FullName == "System.Int32")
                            row.CreateCell(j).SetCellValue(Convert.ToInt32(myRow[j]));
                        else if (ds.Tables[0].Columns[j].DataType.FullName == "System.Single")
                            row.CreateCell(j).SetCellValue(Convert.ToSingle(myRow[j]));
                        else if (ds.Tables[0].Columns[j].DataType.FullName == "System.Double")
                            row.CreateCell(j).SetCellValue(Convert.ToDouble(myRow[j]));
                        else
                            row.CreateCell(j).SetCellValue(myRow[j].ToString());
                    }
                    catch
                    {

                    }

                }
            }

            //Write the workbook to a memory stream
            MemoryStream output = new MemoryStream();
            workbook.Write(output);

            //Return the result to the end user

            return File(output.ToArray(),   //The binary data of the XLS file
                "application/vnd.ms-excel", //MIME type of Excel files
                "GridExcelExport.xls");     //Suggested file name in the "Save as" dialog which will be displayed to the end user

        }
        
        //List<WorkListModel> getListMenu(string parentid=null)
        //{
        //    List<WorkListModel> mylist = new List<ShakelliReportsUI.DataLayer.Models.WorkListModel>();

        //    List<AppGroupUserObjectView> mainmenulist = (List<AppGroupUserObjectView>)Session[CommonUnits.GeneralModule.m_AccessList];
        //    List<AppGroupUserObjectView> submenulist = mainmenulist.Where(o => (o.ParentObjectId.ToString() == parentid) && o.CRUD.Substring(1, 1) == "1").ToList();
            
        //    if (submenulist.Count > 0)
        //        mylist.Add(new ShakelliReportsUI.DataLayer.Models.WorkListModel() { ItemDs = "یک گزینه را انتخاب نمایید:" });

        //    foreach (var item in submenulist)
        //    {
        //        mylist.Add(new ShakelliReportsUI.DataLayer.Models.WorkListModel() { ItemId = item.ObjectId, ItemDs = item.ObjectDs, ItemName = item.ObjectName, HasDirectPath=item.HasDirectPath,HasOwnGrid=item.HasOwnGrid,HasServerReport=item.HasServerReport,UrlPath=item.UrlPath });
        //    }

        //    return mylist;
        //}

        public ActionResult ReportMenu(ReportModel myReportModel = null, string mainmenu = null,string submenu = null, string submenuds = null, string submenuid = null, string listmenu=null,string mainmenuds=null, bool hasdirectpath=false, string urlpath="")
        {
            Session[CommonUnits.GeneralModule.m_MainMenu] = mainmenu;
            Session[CommonUnits.GeneralModule.m_MainMenuDs] = mainmenuds;
            Session[CommonUnits.GeneralModule.m_SubMenu] = submenu;
            Session[CommonUnits.GeneralModule.m_SubMenuDs] = submenuds;

            if (submenuid != null)
                Session[CommonUnits.GeneralModule.m_SubMenuId] = submenuid;


            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "";

            string ActiveMenu = "activemenu_" + mainmenu.ToLower();
            Session[ActiveMenu] = "active";

            string submenuclass = GeneralModule.m_ActiveSubMenu + submenu.ToLower();
                                   
            Session[submenuclass] = "active";

            myReportModel.ReportName = listmenu;
            myReportModel.RunStatus = RunStatusEnum.NotStarted;

            myReportModel.SubTitle = submenuds;


            if (hasdirectpath)
            {
                myReportModel.IsEnabledParameterDialog = false;
                myReportModel.HasDirectPath = true;
                myReportModel.UrlPath = urlpath;
            }

            if (myReportModel.ReportName == null || myReportModel.ReportName == "" || myReportModel.HasDirectPath )
            {
                return ReportMaster(myReportModel);
            }
            else
            {
                return RedirectToAction("SelectReport", "Reports", myReportModel);
                //return RedirectToAction(myReportModel.ReportName, "Reports", myReportModel);
            }
        }

        public ActionResult DoReport(ReportModel myReportModel)
        {
            CultureInfo ci = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            db.Database.CommandTimeout = 300;

            DatasetGeneral myDatasetGeneral = new DatasetGeneral();
            string strColumnCaptionList = "";
            string strTitle = "";
            string strKalaDs = "", strAnbarDs = "", strCustomersDs = "", strSalesmanDs = "", strBranch = "", strState = "", strCity = "", strDistrict = "", strKalaGroup = "", strKalaSubGroup = "", strSupervisorDs = "", strKanalTozi = "", strClassTakhfif = "", strTradingGrp = "";

            if (myReportModel.ReportName == "rptLocalTest")
            {
                myDatasetGeneral = new DatasetGeneral();
                myReportModel.HasServerReport = false;
                myReportModel.ReportDisplayMode = ReportFormatEnum.ReportViewer;
                myReportModel.UrlPath = "rptLocalReportDynamic.rdlc";

                DatasetGeneral.DataTable1Row dr = (DatasetGeneral.DataTable1Row)myDatasetGeneral.Tables[0].NewRow();
                dr.DataColumn1 = "1";
                dr.DataColumn2 = "کره";
                dr.DataColumn3 = "1393";
                dr.DataColumn4 = "123.45";
                myDatasetGeneral.Tables[0].Rows.Add(dr);

                dr = (DatasetGeneral.DataTable1Row)myDatasetGeneral.Tables[0].NewRow();
                dr.DataColumn1 = "2";
                dr.DataColumn2 = "عسل";
                dr.DataColumn3 = "1393";
                dr.DataColumn4 = "0.01";
                myDatasetGeneral.Tables[0].Rows.Add(dr);

                myReportModel.ReportParameters.Add(new ReportParameter("pTitle", "گزارش پویا"));
                myReportModel.ReportParameters.Add(new ReportParameter("pColumnsCaptions", "شناسه,محصول,مقدار"));

                Session[CommonUnits.GeneralModule.m_postReportData] = myDatasetGeneral;

            }

            System.Globalization.PersianCalendar myCalendar = new PersianCalendar();
            myReportModel.ReportDate = myCalendar.GetYear(DateTime.Today) + "/" + myCalendar.GetMonth(DateTime.Today).ToString("00") + "/" + myCalendar.GetDayOfMonth(DateTime.Today).ToString("00");

            try
            {
                myReportModel.RunStatus = RunStatusEnum.Started;
                //myReportModel.IsServerReport = false;
                Session[CommonUnits.GeneralModule.m_postReportData] = null;

                try
                {
                    string[] datepart = myReportModel.FromDate.Split(new char[] { '/' });
                    if (datepart[0].Length > 2)
                        myReportModel.FromDate = myReportModel.FromDate.Substring(2);
                }
                catch
                {

                }

                try
                {
                    string[] datepart = myReportModel.ToDate.Split(new char[] { '/' });
                    if (datepart[0].Length > 2)
                        myReportModel.ToDate = myReportModel.ToDate.Substring(2);
                }
                catch
                {

                }



                //return Redirect(System.Configuration.ConfigurationManager.AppSettings["MvcReportViewer.ReportServerUrl"]+"/Pages/ReportViewer.aspx?/ShakelliReports/rptKardex&rs:Command=Render");

                //return Redirect(@"http://pooyeshdbtest/ReportServer_MSSQLSERVER2012/Pages/ReportViewer.aspx?/ShakelliReports/rptKardex&rs:Command=Render&Anbarid=1030&Fdate=93/01/13&Todate=93/04/07&STOCKREF=52&IsOkPishnahad=0");

                /*
                string myUrl = "";
                myUrl = @"http://pooyeshdbtest/ReportServer_MSSQLSERVER2012/Pages/ReportViewer.aspx?" + ((ReportModel)Session[CommonUnits.GeneralModule.m_ReportModel]).ReportPath;

                if (((ReportModel)Session[CommonUnits.GeneralModule.m_ReportModel]).ReportDisplayMode == ReportFormatEnum.DirectLink)
                    myUrl += "&rs:Command=Render";

                if (((ReportModel)Session[CommonUnits.GeneralModule.m_ReportModel]).ReportDisplayMode == ReportFormatEnum.PDF)
                    myUrl += "&rs:Format=PDF";

                if (((ReportModel)Session[CommonUnits.GeneralModule.m_ReportModel]).ReportDisplayMode == ReportFormatEnum.Excel)
                    myUrl += "&rs:Format=Excel";

                myUrl += "&Anbarid=1030&Fdate=" + myReportModel.FromDate + "&Todate=" + myReportModel.ToDate + "&STOCKREF=52&IsOkPishnahad=0";

                return Redirect(myUrl);
                            
                 * */


                //myReportModel.IsServerReport = (myReportModel.ReportPath != null && myReportModel.ReportDisplayMode != ReportFormatEnum.Grid);

                myReportModel.ReportParameters = new List<ReportParameter>();

                strTitle = "";

                List<SqlParameter> mySqlParameters = new List<SqlParameter>();

                DataSet ds = new DataSet();

                ///مقداردهی پارامترها
                try
                {
                    if (myReportModel.IsEnabledSeller)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pSalesmancode", myReportModel.SalesmanCode));
                        mySqlParameters.Add(new SqlParameter("@salesmancode", myReportModel.SalesmanCode));

                        if (myReportModel.SalesmanCode == null)
                            strTitle += "-" + "فروشنده:" + "همه";
                        else
                        {
                            try
                            {
                                strSalesmanDs = db.vwSeller.Where(a => a.SalesmanCode == myReportModel.SalesmanCode).First().SalesmanName;
                            }
                            catch
                            {
                            }
                            strTitle += "-" + "فروشنده:" + strSalesmanDs;
                        }

                    }

                    if (myReportModel.IsEnabledCustomer)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pCustomerid", myReportModel.CustomerId.ToString()));
                        mySqlParameters.Add(new SqlParameter("@customerid", myReportModel.CustomerId));

                        if (myReportModel.CustomerId == null || myReportModel.CustomerId == 0)
                            strTitle += "-" + "مشتری:" + "همه";
                        else
                        {
                            try
                            {
                                strCustomersDs = db.vwCustomer.Where(a => a.LOGICALREF == myReportModel.CustomerId).First().CustomerName;
                            }
                            catch
                            {

                            }

                            strTitle += "-" + "مشتری:" + strCustomersDs;
                        }
                    }


                    if (myReportModel.IsEnabledDate)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pCdate", myReportModel.FromDate));
                        mySqlParameters.Add(new SqlParameter("@cdate", myReportModel.FromDate));
                        strTitle += "-" + " تاریخ " + myReportModel.FromDate;
                    }

                    if (myReportModel.IsEnabledFromDate)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pFdate", myReportModel.FromDate));
                        mySqlParameters.Add(new SqlParameter("@fdate", myReportModel.FromDate));
                        strTitle += "-" + " از تاریخ " + myReportModel.FromDate;
                    }

                    if (myReportModel.IsEnabledToDate)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pTdate", myReportModel.ToDate));
                        mySqlParameters.Add(new SqlParameter("@tdate", myReportModel.ToDate));
                        strTitle += "-" + " تا تاریخ " + myReportModel.ToDate;
                    }

                    if (myReportModel.IsEnabledBranch)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pBranch", myReportModel.Branch.ToString()));
                        mySqlParameters.Add(new SqlParameter("@branch", myReportModel.Branch));

                        if (myReportModel.Branch == null)
                            strTitle += "-" + " شعبه: " + "همه";
                        else
                        {
                            try
                            {
                                strBranch = db.vwBranch.Where(a => a.branchId == myReportModel.Branch).First().branchName;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " شعبه: " + strBranch;
                        }
                    }

                    if (myReportModel.IsEnabledState)
                    {
                        string strStatecode = "";
                        int nStateId = 0;

                        try
                        {
                            nStateId = Convert.ToInt32(myReportModel.StateCode);
                           strStatecode = db.Safa_vw_State.Where(a => a.LOGICALREF ==nStateId ).First().Code;
                        }
                        catch(Exception ex)
                        {
                           
                        }

                        myReportModel.ReportParameters.Add(new ReportParameter("pStateCode", strStatecode));
                        mySqlParameters.Add(new SqlParameter("@stateCode", strStatecode));

                        if (myReportModel.StateCode == null)
                            strTitle += "-" + " استان: " + "همه";
                        else
                        {

                            try
                            {
                                strState = db.Safa_vw_State.Where(a => a.Code == myReportModel.StateCode).First().NAME;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " استان: " + strState;
                        }
                    }

                    if (myReportModel.IsEnabledCity)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pCityCode", myReportModel.CityCode));
                        mySqlParameters.Add(new SqlParameter("@citycode", myReportModel.CityCode));

                        if (myReportModel.CityCode == null)
                            strTitle += "-" + " شهر: " + "همه";
                        else
                        {
                            try
                            {
                                int ct = Int32.Parse(myReportModel.CityCode);
                                strCity = db.Safa_vw_City.Where(a => a.LOGICALREF == ct).First().NAME;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " شهر: " + strCity;
                        }
                    }
                    if (myReportModel.IsEnabledDistrict)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pDistrictCode", myReportModel.DistrictCode));
                        mySqlParameters.Add(new SqlParameter("@districtcode", myReportModel.DistrictCode));

                        if (myReportModel.DistrictCode == null)
                            strTitle += "-" + " منطقه: " + "همه";
                        else
                        {
                            try
                            {
                                strDistrict = db.Safa_vw_DISTRICT.Where(a => a.Code == myReportModel.DistrictCode).First().NAME;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " منطقه: " + strDistrict;
                        }
                    }
                    if (myReportModel.IsEnabledKalaGroup)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pKalaGroupCode", myReportModel.KalaGroupCode));
                        mySqlParameters.Add(new SqlParameter("@kalagroupcode", myReportModel.KalaGroupCode));

                        if (myReportModel.KalaGroupCode == null)
                            strTitle += "-" + " گروه کالا: " + "همه";
                        else
                        {
                            try
                            {
                                strKalaGroup = db.Safa_vw_KalaGroup.Where(a => a.code == myReportModel.KalaGroupCode).First().NAME;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " گروه کالا: " + strKalaGroup;
                        }
                    }
                    if (myReportModel.IsEnabledKalaSubGroup)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pKalaSubGroupCode", myReportModel.KalaSubGroupCode));
                        mySqlParameters.Add(new SqlParameter("@kalasubgroupcode", myReportModel.KalaSubGroupCode));

                        if (myReportModel.KalaSubGroupCode == null)
                            strTitle += "-" + " زیرگروه کالا: " + "همه";
                        else
                        {
                            try
                            {
                                strKalaSubGroup = db.Safa_vw_KalaSubGroup.Where(a => a.code == myReportModel.KalaSubGroupCode).First().NAME;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " زیرگروه کالا: " + strKalaSubGroup;
                        }
                    }


                    if (myReportModel.IsEnabledKala)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pStockref", myReportModel.StockRef.ToString()));
                        mySqlParameters.Add(new SqlParameter("@stockref", myReportModel.StockRef));

                        if (myReportModel.StockRef == 0 || myReportModel.StockRef == null)
                            strTitle += "-" + " کالا: " + "همه";
                        else
                        {
                            try
                            {
                                strKalaDs = db.vwKala.Find(myReportModel.StockRef).Name;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " کالا: " + strKalaDs;
                        }

                    }

                    if (myReportModel.IsEnabledKanalTozi)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pKanalTozi", myReportModel.KanalTozi));
                        mySqlParameters.Add(new SqlParameter("@kanaltozi", myReportModel.KanalTozi));

                        if (myReportModel.KanalTozi == null)
                            strTitle += "-" + " کانال توزیع: " + "همه";
                        else
                        {
                            try
                            {
                                strKanalTozi = db.Safa_vw_KanalTozi.Where(a => a.KanalToziCode == myReportModel.KanalTozi).First().KanalToziDs;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " کانال توزیع: " + strKanalTozi;
                        }
                    }

                    if (myReportModel.IsEnabledClassTakhfif)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pClassTakhfif", myReportModel.ClassTakhfif));
                        mySqlParameters.Add(new SqlParameter("@classtakhfif", myReportModel.ClassTakhfif));

                        if (myReportModel.ClassTakhfif == null)
                            strTitle += "-" + " کلاس تخفیف: " + "همه";
                        else
                        {
                            try
                            {
                                strClassTakhfif = db.Safa_vw_ClassTakhfif.Where(a => a.ClassTakhfifCode == myReportModel.ClassTakhfif).First().ClassTakhfifDs;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " کلاس تخفیف: " + strClassTakhfif;
                        }
                    }

                    if (myReportModel.IsEnabledAnbar)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pAnbarid", myReportModel.AnbarId.ToString()));
                        mySqlParameters.Add(new SqlParameter("@anbarid", myReportModel.AnbarId));

                        if (myReportModel.AnbarId == null)
                            strTitle += "-" + " انبار: " + "همه";
                        else
                        {
                            try
                            {
                                strAnbarDs = db.vwAnbar.Where(a => a.NR == myReportModel.AnbarId).First().NAME;
                            }
                            catch
                            {

                            }

                            strTitle += "-" + " انبار: " + strAnbarDs;
                        }

                    }


                    if (myReportModel.IsEnabledSupervisor)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pSupervisorcode", myReportModel.SupervisorCode));
                        mySqlParameters.Add(new SqlParameter("@supervisorcode", myReportModel.SupervisorCode));

                        if (myReportModel.SupervisorCode == null)
                            strTitle += "-" + "سرپرست:" + "همه";
                        else
                        {
                            try
                            {
                                long n = Convert.ToInt64(myReportModel.SupervisorCode);
                                strSupervisorDs = db.Safa_vw_Supervisor.Where(a => a.Supervisorcode == n).First().Supervisorname;
                            }
                            catch
                            {

                            }

                            strTitle += "-" + "سرپرست:" + strSupervisorDs;
                        }
                    }

                    if (myReportModel.IsEnabledTradingGrp)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pTradinGgrp", myReportModel.tradinggrp));
                        mySqlParameters.Add(new SqlParameter("@tradinggrp", myReportModel.tradinggrp));

                        if (myReportModel.tradinggrp == null)
                            strTitle += "-" + " گروه تجاری: " + "همه";
                        else
                        {
                            try
                            {
                                strTradingGrp = db.Safa_vw_TradingGroup.Where(a => a.TrgCode == myReportModel.tradinggrp).First().trgDs;
                            }
                            catch
                            {

                            }
                            strTitle += "-" + " گروه تجاری: " + strTradingGrp;
                        }
                    }

                    if (myReportModel.IsEnabledUserId)
                    {
                        //myReportModel.ReportParameters.Add(new ReportParameter("pUserid", Session[CommonUnits.GeneralModule.m_CurrentUserId].ToString()));
                        mySqlParameters.Add(new SqlParameter("@userid", Session[CommonUnits.GeneralModule.m_CurrentUserId].ToString()));
                    }

                    if (myReportModel.NonTipParameters1_Name != null)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pParameter1", myReportModel.NonTipParameters1_Value));
                        mySqlParameters.Add(new SqlParameter(myReportModel.NonTipParameters1_Name, myReportModel.NonTipParameters1_Value));
                        strTitle += " - " + myReportModel.NonTipParameters1_Ds + ": " + myReportModel.NonTipParameters1_Value;
                    }

                    if (myReportModel.NonTipParameters2_Name != null)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pParameter2", myReportModel.NonTipParameters2_Value));
                        mySqlParameters.Add(new SqlParameter(myReportModel.NonTipParameters2_Name, myReportModel.NonTipParameters2_Value));
                        strTitle += " - " + myReportModel.NonTipParameters2_Ds + ": " + myReportModel.NonTipParameters2_Value;
                    }
                    if (myReportModel.NonTipParameters3_Name != null)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pParameter3", myReportModel.NonTipParameters3_Value));
                        mySqlParameters.Add(new SqlParameter(myReportModel.NonTipParameters3_Name, myReportModel.NonTipParameters3_Value));
                        strTitle += " - " + myReportModel.NonTipParameters3_Ds + ": " + myReportModel.NonTipParameters3_Value;
                    }
                    if (myReportModel.NonTipParameters4_Name != null)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pParameter4", myReportModel.NonTipParameters4_Value));
                        mySqlParameters.Add(new SqlParameter(myReportModel.NonTipParameters4_Name, myReportModel.NonTipParameters4_Value));
                        strTitle += " - " + myReportModel.NonTipParameters4_Ds + ": " + myReportModel.NonTipParameters4_Value;
                    }
                    if (myReportModel.NonTipParameters5_Name != null)
                    {
                        myReportModel.ReportParameters.Add(new ReportParameter("pParameter5", myReportModel.NonTipParameters5_Value));
                        mySqlParameters.Add(new SqlParameter(myReportModel.NonTipParameters5_Name, myReportModel.NonTipParameters5_Value));
                        strTitle += " - " + myReportModel.NonTipParameters5_Ds + ": " + myReportModel.NonTipParameters5_Value;
                    }

                    myReportModel.ReportParameters.Add(new ReportParameter("pTitle", strTitle));
                    myReportModel.ReportParameters.Add(new ReportParameter("pTitr", ""));

                }
                catch
                {

                }

                //if (myReportModel.ReportName == "rptSaleAndReturnOfSalesman" && myReportModel.ReportDisplayMode == ReportFormatEnum.Grid)
                if (myReportModel.HasOwnGrid && myReportModel.ReportDisplayMode == ReportFormatEnum.Grid)
                {
                    string myQuery = "";

                    int n = 0;
                    object[] pp = new object[mySqlParameters.Count];
                    foreach (SqlParameter p in mySqlParameters)
                    {
                        myQuery = myQuery + "," + p.ParameterName + "={" + n.ToString() + "}";

                        pp[n] = p.Value;
                        n++;
                    }

                    if (myQuery[0] == ',')
                        myQuery = myQuery.Substring(1);

                    myQuery = myReportModel.StoredProcedure + " " + myQuery;

                    
                    //Session[CommonUnits.GeneralModule.m_postReportData] = db.Database.SqlQuery<postReportData>("Safa_spGet_SaleAndReturnOfSalesman @FDate = {0},@TDate = {1},@SalesmanCode = {2}", new object[] { myReportModel.FromDate, myReportModel.ToDate, myReportModel.SalesmanCode }).ToList();
                    
                    Session[CommonUnits.GeneralModule.m_postReportData] = db.Database.SqlQuery<postReportData>(myQuery, pp).ToList();

                    ///ساختن دیتاست

                    //IEnumerable<postReportData> ss = (IEnumerable<postReportData>)Session[CommonUnits.GeneralModule.m_postReportData];
                    //var pp = typeof(postReportData).GetProperties();


                    //DataSet ds = new DataSet();
                    //ds.Tables.Add();

                    //foreach (var propInfo in pp)
                    //{
                    //    try
                    //    {
                    //        ds.Tables[0].Columns.Add(propInfo.Name, propInfo.PropertyType);
                    //    }
                    //    catch
                    //    {
                    //        ds.Tables[0].Columns.Add(propInfo.Name, propInfo.PropertyType.GenericTypeArguments[0]);
                    //    }
                    //}

                    //foreach (postReportData item in ss)
                    //{
                    //    DataRow row = ds.Tables[0].NewRow();
                    //    foreach (var propInfo in pp)
                    //    {
                    //        try
                    //        {
                    //            row[propInfo.Name] = propInfo.GetValue(item, null);
                    //        }
                    //        catch
                    //        {
                    //        }
                    //    }
                    //    ds.Tables[0].Rows.Add(row);

                    //}

                    //Session["dataset"] = ds;
                }

                else
                {
                    DatasetClass.ExecuteStoredProcedure(new SqlConnection(db.Database.Connection.ConnectionString), myReportModel.StoredProcedure, mySqlParameters.ToArray(), ds, null);


                    if (myReportModel.ReportDisplayMode == ReportFormatEnum.Grid)
                    {
                        //Session[CommonUnits.GeneralModule.m_GridHtml] = GetGridHtml(ds);

                        for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                        {
                            string strCaption = ds.Tables[0].Columns[i].Caption.ToLower();
                            try
                            {
                                strCaption = db.Glossary.Where(a => a.Lname.ToLower() == strCaption).FirstOrDefault().Pname;
                            }
                            catch
                            {

                            }

                            ds.Tables[0].Columns[i].Caption = strCaption;
                            ///بدلیل مشکل برای فیلدهای با نام پارسی یا عدد در زمان
                            ///resize                                
                            /// گزارشات لولایی

                            //ds.Tables[0].Columns[i].ColumnName = "_" + ds.Tables[0].Columns[i].ColumnName;
                            ds.Tables[0].Columns[i].ColumnName = "DataColumn" + (i + 1).ToString();

                        }

                        Session[CommonUnits.GeneralModule.m_postReportData] = ds;

                    }
                }



                if (myReportModel.ReportDisplayMode == ReportFormatEnum.ReportViewer)
                {
                    if (myReportModel.HasServerReport == false)
                    {
                        for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                        {
                            string strCaption = ds.Tables[0].Columns[i].Caption.ToLower();
                            try
                            {
                                strCaption = db.Glossary.Where(a => a.Lname.ToLower() == strCaption).FirstOrDefault().Pname;
                            }
                            catch
                            {

                            }

                            ds.Tables[0].Columns[i].Caption = strCaption;
                            strColumnCaptionList += "," + strCaption;
                            ds.Tables[0].Columns[i].ColumnName = "datacolumn" + (i + 1).ToString();
                        }

                        if (myDatasetGeneral.Tables[0].Columns.Count > ds.Tables[0].Columns.Count)
                        {
                            for (int i = ds.Tables[0].Columns.Count; i < myDatasetGeneral.Tables[0].Columns.Count; i++)
                            {
                                string col = "datacolumn" + (i + 1).ToString();
                                ds.Tables[0].Columns.Add(col);
                            }
                        }

                        Session[CommonUnits.GeneralModule.m_postReportData] = ds;
                        if (myReportModel.UrlPath == null)
                            myReportModel.UrlPath = "rptLocalReportDynamic.rdlc";

                        if (strColumnCaptionList.StartsWith(","))
                            strColumnCaptionList = strColumnCaptionList.Remove(0, 1);

                        myReportModel.ReportParameters = new List<ReportParameter>();
                        myReportModel.ReportParameters.Add(new ReportParameter("pTitle", strTitle));
                        myReportModel.ReportParameters.Add(new ReportParameter("pTitr", myReportModel.ReportTitle));
                        myReportModel.ReportParameters.Add(new ReportParameter("pColumnsCaptions", strColumnCaptionList));
                    }

                }


                myReportModel.SubTitle = strTitle;
                return ReportMaster(myReportModel);
            }

            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "گزارش", MessageType = "Error", CallerAction = "ReportMaster", CallerController = "Reports" };
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }
        }

        public ActionResult ReturnToMaster(ReportModel myReportModel = null)
        {
            myReportModel.RunStatus = RunStatusEnum.Finish;
            //myReportModel.StockRef = 0;
            //myReportModel.SalesmanCode = null;
            //myReportModel.Branch = null;
            //myReportModel.KalaGroupCode = null;
            //myReportModel.KalaSubGroupCode = null;

            return RedirectToAction("ReportMaster",myReportModel);
        }

        //public ActionResult RunReportBuilder()
        //{

        //    WebBrowser wb = new WebBrowser();
        //    wb.Navigate("http://localhost/ReportServer/ReportBuilder/ReportBuilder_3_0_0_0.application?/Reports/ProductsReport");

        //}

        #region Reports

        public ActionResult SelectReport(ReportModel myReportModel = null)
        {
            if (myReportModel == null)
                myReportModel = new ReportModel();

            List<string> tip_parameters = new List<string> { "@salesmancode", "@cdate", "@fdate", "@tdate", "@branch", "@anbarid", "@stockref", "@customerid", "@statecode", "@citycode", "@districtcode", "@kalagroupcode", "@kalasubgroupcode", "@kanaltozi", "@classtakhfif", "@supervisorcode", "@tradinggrp", "@userid" };

            if (Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserType]) == CommonUnits.GeneralModule.m_UserType_Sale)
            {
                myReportModel.SalesmanCode = Session[CommonUnits.GeneralModule.m_CurrentUserName].ToString();
            }

            if (Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserType]) ==CommonUnits.GeneralModule.m_UserType_Sale)
            {
                myReportModel.SalesmanCode = Session[CommonUnits.GeneralModule.m_CurrentUserName].ToString();
            }

            try
            {
                myReportModel.StoredProcedure = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().StoredProcedure;

                myReportModel.ReportTitle = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().ObjectDs;

                myReportModel.UrlPath = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().UrlPath;

                myReportModel.HasServerReport = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().HasServerReport;
                myReportModel.HasOwnGrid = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().HasOwnGrid;
                myReportModel.HasDirectPath = db.AppObject.Where(a => a.ObjectName == myReportModel.ReportName).First().HasDirectPath;

                /*
                 * سریعتر است Entityframework از dataset چرا
                DataSet ds = new DataSet();
                ds.Tables.Add();
                DatasetClass.FillDataSet(new SqlConnection(db.Database.Connection.ConnectionString), ds.Tables[0], "select [SPECIFIC_NAME] as StoredProcedure,[PARAMETER_NAME] as StoredProcedureParameterName,[DATA_TYPE] as StoredProcedureParameterType  from information_schema.parameters  where specific_name = 'Safa_spGet_AmarSalesOfSalesman'");

                 */


                var mySqlParameters = ((List<ReportModel>)Session[CommonUnits.GeneralModule.m_StoredProcedureParameterList]).Where(a => a.StoredProcedure == myReportModel.StoredProcedure).ToList();
                //List<ReportModel> mySqlParameters = db.Database.SqlQuery<ReportModel>("select [SPECIFIC_NAME] as StoredProcedure,[PARAMETER_NAME] as StoredProcedureParameterName,[DATA_TYPE] as StoredProcedureParameterType  from information_schema.parameters  where specific_name = {0}", new object[] { myReportModel.StoredProcedure }).ToList();

                myReportModel.IsEnabledSeller = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@salesmancode").Count() > 0;
                myReportModel.IsEnabledDate = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@cdate").Count() > 0;
                myReportModel.IsEnabledFromDate = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@fdate").Count() > 0;
                myReportModel.IsEnabledToDate = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@tdate").Count() > 0;
                myReportModel.IsEnabledBranch = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@branch").Count() > 0;
                myReportModel.IsEnabledAnbar = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@anbarid").Count() > 0;
                myReportModel.IsEnabledKala = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@stockref").Count() > 0;
                myReportModel.IsEnabledCustomer = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@customerid" ).Count() > 0;

                myReportModel.IsEnabledState = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@statecode").Count() > 0;
                myReportModel.IsEnabledCity = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@citycode").Count() > 0;
                myReportModel.IsEnabledDistrict = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@districtcode").Count() > 0;
                myReportModel.IsEnabledKalaGroup = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@kalagroupcode").Count() > 0;
                myReportModel.IsEnabledKalaSubGroup = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@kalasubgroupcode").Count() > 0;
                myReportModel.IsEnabledKanalTozi = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@kanaltozi").Count() > 0;
                myReportModel.IsEnabledClassTakhfif = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@classtakhfif").Count() > 0;

                myReportModel.IsEnabledSupervisor = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@supervisorcode").Count() > 0;

                myReportModel.IsEnabledTradingGrp = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@tradinggrp").Count() > 0;

                myReportModel.IsEnabledUserId = mySqlParameters.Where(a => a.StoredProcedureParameterName.ToLower() == "@userid").Count() > 0;
                //var pp = mySqlParameters.Select(p=>p.StoredProcedureParameterName).Where(p => (!tip_parameters.Contains(p.ToLower()))).ToList();
                ///خط بالایی معادل پایینیست
                var nontip_parameters = mySqlParameters.Select(p => p.StoredProcedureParameterName.ToLower()).Except(tip_parameters).ToList();

                myReportModel.NonTipParameters1_Name = nontip_parameters.ElementAtOrDefault(0);
                myReportModel.NonTipParameters2_Name = nontip_parameters.ElementAtOrDefault(1);
                myReportModel.NonTipParameters3_Name = nontip_parameters.ElementAtOrDefault(2);
                myReportModel.NonTipParameters4_Name = nontip_parameters.ElementAtOrDefault(3);
                myReportModel.NonTipParameters5_Name = nontip_parameters.ElementAtOrDefault(4);
             
                try
                {
                    myReportModel.NonTipParameters1_Ds = db.Glossary.Where(a => a.Lname.ToLower() == myReportModel.NonTipParameters1_Name.Replace("@", "")).FirstOrDefault().Pname;
                }
                catch
                {
                    myReportModel.NonTipParameters1_Ds = myReportModel.NonTipParameters1_Name.Replace("@","");
                }

                try
                {
                    myReportModel.NonTipParameters2_Ds = db.Glossary.Where(a => a.Lname.ToLower() == myReportModel.NonTipParameters2_Name.Replace("@", "")).FirstOrDefault().Pname;
                }
                catch
                {
                    myReportModel.NonTipParameters2_Ds = myReportModel.NonTipParameters2_Name.Replace("@", "");
                }

                try
                {
                    myReportModel.NonTipParameters3_Ds = db.Glossary.Where(a => a.Lname.ToLower() == myReportModel.NonTipParameters3_Name.Replace("@", "")).FirstOrDefault().Pname;
                }
                catch
                {
                    myReportModel.NonTipParameters3_Ds = myReportModel.NonTipParameters3_Name.Replace("@", "");
                }

                try
                {
                    myReportModel.NonTipParameters4_Ds = db.Glossary.Where(a => a.Lname.ToLower() == myReportModel.NonTipParameters4_Name.Replace("@", "")).FirstOrDefault().Pname;
                }
                catch
                {
                    myReportModel.NonTipParameters4_Ds = myReportModel.NonTipParameters4_Name.Replace("@", "");
                }

                try
                {
                    myReportModel.NonTipParameters5_Ds = db.Glossary.Where(a => a.Lname.ToLower() == myReportModel.NonTipParameters5_Name.Replace("@", "")).FirstOrDefault().Pname;
                }
                catch
                {
                    myReportModel.NonTipParameters5_Ds = myReportModel.NonTipParameters5_Name.Replace("@", "");
                }
            }
            catch
            {

            }

            myReportModel.IsEnabledReportContainer = true;
            myReportModel.IsEnabledParameterDialog = true;

            return ReportMaster(myReportModel);
        }

        ///روش اول فراخوانی stored procedure            
        ///روش linq
        //IEnumerable<postReportData> myreport = (from r in db.Safa_Sp_ARAPTran(myReportModel.FromDate, myReportModel.ToDate, 7)
        //                                        where r.sum_tedadbudjeh != null
        //                                        select new postReportData
        //                                        {
        //                                            sal = r.sal,
        //                                            ServiceName = r.Servicename,
        //                                            sum_price = r.sum_price,
        //                                            sum_tedad = r.sum_tedad,
        //                                            sum_tedadkhedmat = r.sum_tedadkhedmat,
        //                                            sum_mablaghkhedmat = r.sum_mablaghkhedmat,
        //                                            sum_tedadbudjeh = r.sum_tedadbudjeh,
        //                                            sum_mablaghbudjeh = r.sum_mablaghbudjeh
        //                                        }).ToList();



        ///روش دوم فراخوانی
        ///روش EntityFramework
        //var myReport = db.Database.SqlQuery<postReportData>("Safa_spGet_SaleAndReturnOfSalesman @FDate = {0},@TDate = {1},@SalesmanCode = {2}", new object[] { myReportModel.FromDate, myReportModel.ToDate, myReportModel.SalesmanCode }).ToList();
        //Session[CommonUnits.GeneralModule.m_postReportData] = myReport3;



        //public string GetGridHtml(DataSet ds)
        //{
        //    string strRes = "";
        //    CultureInfo ci = new CultureInfo("fa-IR");
        //    Thread.CurrentThread.CurrentCulture = ci;
        //    Thread.CurrentThread.CurrentUICulture = ci;

        //    strRes = "<table id=\"gridtable\">";

        //    strRes = strRes + "<colgroup>";
        //    foreach (DataColumn myColumn in ds.Tables[0].Columns)
        //    {
        //        strRes += "<col style='font-family:B yekan,Tahoma;width:300px' />";
        //    }

        //    strRes += "<col style='font-family:B yekan,Tahoma' />";
        //    strRes = strRes + "</colgroup>";

        //    strRes = strRes + "<thead>";
        //    strRes = strRes + "<tr>";
        //    foreach (DataColumn myColumn in ds.Tables[0].Columns)
        //    {
        //        //CommonUnits.Resources.DbObjects.salesmanname
        //        string strCaption = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.DbObjects", typeof(DbObjects).Assembly).GetString(myColumn.Caption.ToLower(), ci);
        //        strCaption = (strCaption == null) ? myColumn.Caption : strCaption;
        //        strRes += "<th data-field=\"_" + myColumn.ColumnName + "\" >" + strCaption + "</th>";
        //    }

        //    strRes += "<th></th>";
        //    strRes += "</tr>"
        //    + "</thead>";

        //    strRes = strRes + "<tbody>";
        //    foreach (DataRow myRow in ds.Tables[0].Rows)
        //    {
        //        strRes = strRes + "<tr>";
        //        for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
        //        {
        //            strRes = strRes + "<td style=\"font-family:'B Yekan'; direction:rtl\">" + myRow[i].ToString() + "</td>";
        //        }
        //        strRes = strRes + "<td ></td>";
        //        strRes = strRes + "</tr>";
        //    }

        //    //strRes = strRes + " <tr ><td></td><td></td><td></td><td class=\"auto-style1\" style=\"background-color: #C0C0C0\">مجموع :123</td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr>";
        //    strRes = strRes + "</tbody>"
        //                + "</table>";

        //    return strRes;
        //}



        public ActionResult NewDynamicReport()
        {
            Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "active";
            //return Redirect(@"http://www.yahoo.com");
            return Redirect(System.Configuration.ConfigurationManager.AppSettings["mvcreportviewer.reportbuilderurl"]);
        }
        
        public string print_ssrs()
        {
            string strRes = "";

            ReportModel myReportModel = (ReportModel)Session[GeneralModule.m_ReportModel];

            if (myReportModel.HasServerReport)
            {
                ServerReport rpt = (ServerReport)Session["localreport"];
                ReportPrinter prnt = new ReportPrinter();
                strRes = prnt.Print(null,rpt,true);
            }
            else
            {
                LocalReport rpt = (LocalReport)Session["localreport"];
                ReportPrinter prnt = new ReportPrinter();
                strRes = prnt.Print(rpt,null,false);
            }


            return strRes;
        }

#endregion


    }


}