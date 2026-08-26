using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakelliReportsUI.CommonUnits
{
    public class GeneralModule
    {
        enum ContractType
        {
            waranty = 0,
            propagational = 1

        }


        public const string m_CurrentUserName = "currentusername";
        public const string m_CurrentUserId = "currentuserid";
        public const string m_CurrentUserType = "currentusertype";

        public const string m_CurrentGroupId = "currentgroupid";
        public const string m_CurrentPersonName = "currentpersonname";
        public const string m_CurrentPersonCode = "currentpersoncode";
        public const string m_CurrentPersonId = "currentpersonid";
        public const string m_PersonImagePath = "personimagepath";
        public const string m_SessionTime = "sessiontime";
        public const string m_CurrentError = "currenterror";
        public const string m_ReportModel = "reportmodel";
        public const string m_postReportData = "postreportdata";
        public const string m_MessageModel = "messagemodel";
        public const string m_Node = "node";

        public const string m_AccessList = "accesslist";
        public const string m_MenuList_Prime = "menulist_prime";
        public const string m_MenuList_Sale = "menulist_sale";
        public const string m_MenuList_Material = "menulist_material";
        public const string m_MenuList_Finance = "menulist_finance";
        public const string m_MenuList_BookOfAccounts = "menulist_bookofaccounts";
        public const string m_MenuList_SmartReports = "menulist_smartreports";
        public const string m_MenuList_ReportGenerator = "menulist_reportgenerator";
        public const string m_MenuList_Administration = "menulist_administration";

        public const string m_MenuLevel1 = "menulevel1";

        public const string m_PrimeVisible = "primevisible";
        public const string m_AdministrationVisible = "administrationvisible";
        public const string m_SaleVisible = "salevisible";
        public const string m_MaterialVisible = "materialvisible";
        public const string m_FinanceVisible = "financevisible";
        public const string m_BookOfAccountsVisible = "bookofaccountsvisible";
        public const string m_SmartReportsVisible = "smartreportsvisible";
        public const string m_ReportGeneratorVisible = "reportgeneratorvisible";

        public const string m_MainMenu = "mainmenu";
        public const string m_SubMenu = "submenu";
        public const string m_MainMenuDs = "mainmenuds";
        public const string m_SubMenuDs = "submenuds";
        public const string m_SubMenuId = "submenuid";

        public const string m_ActiveMenu_Home = "activemenu_home";
        public const string m_ActiveMenu_Prime = "activemenu_prime";
        public const string m_ActiveMenu_Sale = "activemenu_sale";
        public const string m_ActiveMenu_Material = "activemenu_material";
        public const string m_ActiveMenu_Finance = "activemenu_finance";
        public const string m_ActiveMenu_Bookofaccounts = "activemenu_bookofaccounts";
        public const string m_ActiveMenu_Smartreports = "activemenu_smartreports";
        public const string m_ActiveMenu_ReportGenerator = "activemenu_reportgenerator";
        public const string m_ActiveMenu_Administration = "activemenu_administration";
        public const string m_ActiveMenu_Help = "activemenu_help";

        public const string m_ActiveSubMenu = "activesubmenu_";
        public const string m_ActiveListMenu = "activelistmenu_";

        public const string m_ReportList = "reportlist";

        public const string m_StoredProcedureParameterList = "storedprocedureparameterlist";

        public const int m_UserType_Sale = 2;
        public const int m_UserType_Admin = 1;
        public const int m_UserType_Manager = 3;

        public const string m_MessageList = "messagelist";
        public const string m_NotificationList = "notificationlist";
        public const string m_ProgramMode = "programmode";


    }


}
