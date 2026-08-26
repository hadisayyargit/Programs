using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using RWAS.DataAccess;


namespace RWAS.BusinessRules
{
    public class dpHadiBusiness
    {        
        public static void FillListControl(System.Windows.Forms.ListControl workListControl, DataTable dtSource, string displayFieldName, string valueFieldName)
        {
            try
            {                
                workListControl.DataSource = dtSource;
                workListControl.DisplayMember = displayFieldName;
                workListControl.ValueMember = valueFieldName;
            }
            catch
            {
                workListControl.DataSource = null;
                
            }
        }


        private static List<SqlDataRecord> GetTableParameter(object[] myArray)
        {

            List<SqlDataRecord> value_list = new List<SqlDataRecord>();

            SqlMetaData[] tvp_definition = { new SqlMetaData("mystringColumn", SqlDbType.VarChar, 20) };

            if (myArray != null)
            {
                foreach (object myvalue in myArray)
                {
                    SqlDataRecord myRecord = new SqlDataRecord(tvp_definition);
                    myRecord.SetSqlString(0, myvalue.ToString());
                    value_list.Add(myRecord);
                }
            }

            return value_list;
        }

        private static SqlParameter[] GetSqlParameter(object[] arrayRegion,
            int nUniquecode,
            string strFromEmployeeDate,
            string strToEmployeeDate,
            object[] arraySubContractor,
            object[] arrayEmployeeStatus,
            object[] arrayStudyStatus,
            object[] arrayOrgUnit,
            object[] arrayJob,

            string strBeginDate, string strEndDate,
            bool IsOperationReport, short BeginWorkHours, short EndWorkHours, int BeginKilometer, int EndKilometer, short BeginLeave, short EndLeave, short BeginAbsent, short EndAbsent,
            bool IsAccidentReport, int AccidentReason, byte AccidentForfeitKind, short AccidentDegree, short AccidentCount_Low,short AccidentCount_Up,
            bool IsEulogyReport, short EulogyTypeId, short EulogyDonorId,
            bool IsChastiseReport, byte ChastiseForfeitKind, short ChastiseDonorId, int ChastiseReasonId,short ChastiseCount_Low,short ChastiseCount_Up,
            bool IsTrainingReport, short TrainingTermId, short TermScore_Low, short TermScore_Up, short TermCount_Low, short TermCount_Up,
            bool IsHealthReport, byte HealthKindId ,
            bool IsScoreReport, float Score_Accident_Low, float Score_Accident_Up, float Score_Chastise_Low, float Score_Chastise_Up, float Score_Eulogy_Low, float Score_Eulogy_Up, float Score_Training_Low, float Score_Training_Up, float Score_Low, float Score_Up 
            )
        {
            SqlParameter[] objSqlParameters = new SqlParameter[22];
            List<SqlDataRecord> value_list1 = new List<SqlDataRecord>();


            objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);
            objSqlParameters[1] = new SqlParameter("@Prs_Fld_FromEmployeeDate", strFromEmployeeDate);
            objSqlParameters[2] = new SqlParameter("@Prs_Fld_ToEmployeeDate", strToEmployeeDate);
            objSqlParameters[3] = new SqlParameter("@RegionList", SqlDbType.Structured);
            objSqlParameters[4] = new SqlParameter("@SubContractorList", SqlDbType.Structured);
            objSqlParameters[5] = new SqlParameter("@EmployeeStatusList", SqlDbType.Structured);
            objSqlParameters[6] = new SqlParameter("@StudyStatusList", SqlDbType.Structured);
            objSqlParameters[7] = new SqlParameter("@OrgUnitList", SqlDbType.Structured);
            objSqlParameters[8] = new SqlParameter("@JobList", SqlDbType.Structured);

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arrayRegion);
            if (value_list1.Count != 0)
                objSqlParameters[3].Value = value_list1;

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arraySubContractor);
            if (value_list1.Count != 0)
                objSqlParameters[4].Value = value_list1;

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arrayEmployeeStatus);
            if (value_list1.Count != 0)
                objSqlParameters[5].Value = value_list1;

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arrayStudyStatus);
            if (value_list1.Count != 0)
                objSqlParameters[6].Value = value_list1;

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arrayOrgUnit);
            if (value_list1.Count != 0)
                objSqlParameters[7].Value = value_list1;

            value_list1 = new List<SqlDataRecord>();
            value_list1 = GetTableParameter(arrayJob);
            if (value_list1.Count != 0)
                objSqlParameters[8].Value = value_list1;


            objSqlParameters[9] = new SqlParameter("@BeginDate", strBeginDate);
            objSqlParameters[10] = new SqlParameter("@EndDate", strEndDate);

            if (IsOperationReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsOperationReport", 1);
                objSqlParameters[12] = new SqlParameter("@BeginWorkHours", BeginWorkHours);
                objSqlParameters[13] = new SqlParameter("@EndWorkHours", EndWorkHours);
                objSqlParameters[14] = new SqlParameter("@BeginKilometer", BeginKilometer);
                objSqlParameters[15] = new SqlParameter("@EndKilometer", EndKilometer);
                objSqlParameters[16] = new SqlParameter("@BeginLeave", BeginLeave);
                objSqlParameters[17] = new SqlParameter("@EndLeave", EndLeave);
                objSqlParameters[18] = new SqlParameter("@BeginAbsent", BeginAbsent);
                objSqlParameters[19] = new SqlParameter("@EndAbsent", EndAbsent);
            }

            if (IsAccidentReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsAccidentReport", 1);
                objSqlParameters[12] = new SqlParameter("@AccidentReason", AccidentReason);
                objSqlParameters[13] = new SqlParameter("@AccidentForfeitKind", AccidentForfeitKind);
                objSqlParameters[14] = new SqlParameter("@AccidentDegree", AccidentDegree);
                objSqlParameters[15] = new SqlParameter("@AccidentCount_Low", AccidentCount_Low);
                objSqlParameters[16] = new SqlParameter("@AccidentCount_Up", AccidentCount_Up);
            }

            if (IsEulogyReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsEulogyReport", 1);
                objSqlParameters[12] = new SqlParameter("@EulogyTypeId", EulogyTypeId);
                objSqlParameters[13] = new SqlParameter("@EulogyDonorId", EulogyDonorId);
            }
            if (IsChastiseReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsChastiseReport", 1);
                objSqlParameters[12] = new SqlParameter("@ChastiseForfeitKind", ChastiseForfeitKind);
                objSqlParameters[13] = new SqlParameter("@ChastiseDonorId", ChastiseDonorId);
                objSqlParameters[14] = new SqlParameter("@ChastiseReasonId", ChastiseReasonId);
                objSqlParameters[15] = new SqlParameter("@ChastiseCount_Low", ChastiseCount_Low);
                objSqlParameters[16] = new SqlParameter("@ChastiseCount_Up", ChastiseCount_Up);
            }
            if (IsTrainingReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsTrainingReport", 1);
                objSqlParameters[12] = new SqlParameter("@TrainingTermId", TrainingTermId);
                objSqlParameters[13] = new SqlParameter("@TermScore_Low", TermScore_Low);
                objSqlParameters[14] = new SqlParameter("@TermScore_Up", TermScore_Up);
                objSqlParameters[15] = new SqlParameter("@TermCount_Low", TermCount_Low);
                objSqlParameters[16] = new SqlParameter("@TermCount_Up", TermCount_Up);
            }
            if (IsHealthReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsHealthReport", 1);
                objSqlParameters[12] = new SqlParameter("@HealthKindId", HealthKindId);
            }

            if (IsScoreReport)
            {
                objSqlParameters[11] = new SqlParameter("@IsScoreReport", 1);
                objSqlParameters[12] = new SqlParameter("@Score_Accident_Low", Score_Accident_Low);
                objSqlParameters[13] = new SqlParameter("@Score_Accident_Up", Score_Accident_Up);
                objSqlParameters[14] = new SqlParameter("@Score_Chastise_Low", Score_Chastise_Low);
                objSqlParameters[15] = new SqlParameter("@Score_Chastise_Up", Score_Chastise_Up);
                objSqlParameters[16] = new SqlParameter("@Score_Eulogy_Low", Score_Eulogy_Low);
                objSqlParameters[17] = new SqlParameter("@Score_Eulogy_Up", Score_Eulogy_Up);
                objSqlParameters[18] = new SqlParameter("@Score_Training_Low", Score_Training_Low);
                objSqlParameters[19] = new SqlParameter("@Score_Training_Up", Score_Training_Up);
                objSqlParameters[20] = new SqlParameter("@Score_Low", Score_Low);
                objSqlParameters[21] = new SqlParameter("@Score_Up", Score_Up);

            }

            return objSqlParameters;
        }
        
        public static DataView Get_Rep_Personnel(object[] arrayRegion,
            int nUniquecode,
            string strFromEmployeeDate,
            string strToEmployeeDate,            object[] arraySubContractor,            object[] arrayEmployeeStatus,
            object[] arrayStudyStatus,
            object[] arrayOrgUnit,
            object[] arrayJob,

            string strBeginDate, string strEndDate,
            bool IsOperationReport, short BeginWorkHours ,short EndWorkHours ,int BeginKilometer ,int EndKilometer, short BeginLeave ,short EndLeave ,short BeginAbsent,short EndAbsent ,
            bool IsAccidentReport ,int  AccidentReason ,byte AccidentForfeitKind ,short AccidentDegree,short AccidentCount_Low,short AccidentCount_Up,
            bool IsEulogyReport , short EulogyTypeId , short EulogyDonorId ,
            bool IsChastiseReport , byte ChastiseForfeitKind , short ChastiseDonorId , int ChastiseReasonId ,short ChastiseCount_Low, short ChastiseCount_Up,
            bool IsTrainingReport, short TrainingTermId, short TermScore_Low, short TermScore_Up, short TermCount_Low, short TermCount_Up,
            bool IsHealthReport , byte HealthKindId ,
            bool IsScoreReport, float Score_Accident_Low, float Score_Accident_Up, float Score_Chastise_Low, float Score_Chastise_Up, float Score_Eulogy_Low, float Score_Eulogy_Up, float Score_Training_Low, float Score_Training_Up, float Score_Low, float Score_Up 
)
        {
            DataView dvResult = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[20];

            try
            {
                objSqlParameters = GetSqlParameter(arrayRegion, nUniquecode, strFromEmployeeDate, strToEmployeeDate, arraySubContractor, arrayEmployeeStatus, arrayStudyStatus, arrayOrgUnit, arrayJob,       
                    strBeginDate,  strEndDate,
             IsOperationReport,  BeginWorkHours , EndWorkHours , BeginKilometer , EndKilometer,  BeginLeave , EndLeave , BeginAbsent, EndAbsent ,
             IsAccidentReport ,  AccidentReason , AccidentForfeitKind , AccidentDegree,AccidentCount_Low,AccidentCount_Up,
             IsEulogyReport ,  EulogyTypeId ,  EulogyDonorId ,
             IsChastiseReport ,  ChastiseForfeitKind ,  ChastiseDonorId ,  ChastiseReasonId , ChastiseCount_Low, ChastiseCount_Up,
             IsTrainingReport ,  TrainingTermId , TermScore_Low,TermScore_Up , TermCount_Low, TermCount_Up,
             IsHealthReport ,  HealthKindId ,
             IsScoreReport, Score_Accident_Low, Score_Accident_Up, Score_Chastise_Low, Score_Chastise_Up, Score_Eulogy_Low, Score_Eulogy_Up, Score_Training_Low, Score_Training_Up, Score_Low, Score_Up );

                dvResult = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_Personnel", objSqlParameters).DefaultView;
            }

            catch (Exception ex)
            {
            }

            return dvResult;

        }

        public static DataView SearchPersonnel(int nUniquecode = 0, string strFirstName = null, string strLastName = null, string strPersonelID = null, int RegionId = 0, string JobId = null, int EmployeeStatus = 0, int nSubcontractor = 0, string National_code = null, int nIsSubcontractor=-1)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[10];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_UniqueCode", SqlDbType.Int);
                objSqlParameters[1] = new SqlParameter("@Prs_Fld_FirstName", SqlDbType.NVarChar, 50);
                objSqlParameters[2] = new SqlParameter("@Prs_Fld_LastName", SqlDbType.NVarChar, 50);
                objSqlParameters[3] = new SqlParameter("@Prs_Fld_PersonelID", SqlDbType.NVarChar, 8);
                objSqlParameters[4] = new SqlParameter("@Prs_Fld_fk_Region", SqlDbType.Int);
                objSqlParameters[5] = new SqlParameter("@Prs_Fld_fk_Job", SqlDbType.VarChar, 8);
                objSqlParameters[6] = new SqlParameter("@Prs_Fld_fk_EmployeeStatus", SqlDbType.Int);
                objSqlParameters[7] = new SqlParameter("@Prs_Fld_fk_Subcontractor", SqlDbType.Int);
                objSqlParameters[8] = new SqlParameter("@National_Code", SqlDbType.VarChar, 12);
                objSqlParameters[9] = new SqlParameter("@IsSubcontractor", SqlDbType.Bit);

                objSqlParameters[0].Value = nUniquecode;
                objSqlParameters[1].Value = strFirstName;
                objSqlParameters[2].Value = strLastName;
                objSqlParameters[3].Value = strPersonelID;
                objSqlParameters[4].Value = RegionId;
                objSqlParameters[5].Value = JobId;
                objSqlParameters[6].Value = EmployeeStatus;
                objSqlParameters[7].Value = nSubcontractor;
                objSqlParameters[8].Value = National_code;

                if (nIsSubcontractor == -1)
                    objSqlParameters[9].Value = null;
                else
                    objSqlParameters[9].Value = nIsSubcontractor;

                if (RegionId == 0 && JobId == null)
                    myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_SearchPersonnel_Fast", objSqlParameters).DefaultView;
                else
                    myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_SearchPersonnel", objSqlParameters).DefaultView;

            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static string DeletePersonnel(int nUniquecode)
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_UniqueCode_1", nUniquecode);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Prs_Sp_del_Personel", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;

        }

        public static string UpdatePersonnel(int nUniquecode, int Prs_Fld_PersonelID, string Prs_Fld_FirstName, string Prs_Fld_LastName, string Prs_Fld_FatherName, byte Prs_Fld_MaritalStatus, string Prs_Fld_fk_Job, short Prs_Fld_JobHistory, short Prs_Fld_BirthYear, short Prs_Fld_fk_StudyStatus, byte Prs_Fld_fk_EmployeeStatus, string Prs_Fld_EmployeeDate, string Prs_Fld_Address, string Prs_Fld_TelNo, int Prs_Fld_fk_OrgUnit, int Prs_Fld_IDNo, int Prs_Fld_fk_Region, int Prs_Fld_fk_SubContractor, string National_code)
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[19];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Prs_Fld_UniqueCode", nUniquecode);
                objSqlParameters[1] = new SqlParameter("@Prs_Fld_PersonelID", Prs_Fld_PersonelID);
                objSqlParameters[2] = new SqlParameter("@Prs_Fld_FirstName", Prs_Fld_FirstName);
                objSqlParameters[3] = new SqlParameter("@Prs_Fld_LastName", Prs_Fld_LastName);
                objSqlParameters[4] = new SqlParameter("@Prs_Fld_FatherName", Prs_Fld_FatherName);
                objSqlParameters[5] = new SqlParameter("@Prs_Fld_MaritalStatus", Prs_Fld_MaritalStatus);
                objSqlParameters[6] = new SqlParameter("@Prs_Fld_fk_Job", Prs_Fld_fk_Job);
                objSqlParameters[7] = new SqlParameter("@Prs_Fld_JobHistory", Prs_Fld_JobHistory);
                objSqlParameters[8] = new SqlParameter("@National_code", National_code);
                objSqlParameters[9] = new SqlParameter("@Prs_Fld_BirthYear", Prs_Fld_BirthYear);
                objSqlParameters[10] = new SqlParameter("@Prs_Fld_fk_StudyStatus", Prs_Fld_fk_StudyStatus);
                objSqlParameters[11] = new SqlParameter("@Prs_Fld_fk_EmployeeStatus", Prs_Fld_fk_EmployeeStatus);
                objSqlParameters[12] = new SqlParameter("@Prs_Fld_EmployeeDate", Prs_Fld_EmployeeDate);
                objSqlParameters[13] = new SqlParameter("@Prs_Fld_Address", Prs_Fld_Address);
                objSqlParameters[14] = new SqlParameter("@Prs_Fld_TelNo", Prs_Fld_TelNo);
                objSqlParameters[15] = new SqlParameter("@Prs_Fld_fk_OrgUnit", Prs_Fld_fk_OrgUnit);
                objSqlParameters[16] = new SqlParameter("@Prs_Fld_IDNo", Prs_Fld_IDNo);
                objSqlParameters[17] = new SqlParameter("@Prs_Fld_fk_Region", Prs_Fld_fk_Region);
                objSqlParameters[18] = new SqlParameter("@Prs_Fld_fk_SubContractor", Prs_Fld_fk_SubContractor);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "Prs_Sp_upd_Personel", objSqlParameters);
            }

            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;

        }

        public static string UpdateApplicationObject(DataTable myTable)
        {
            string strRes = "";

            SqlCommand c1 = new SqlCommand("select * from Acc_Tbl_ApplicationObject", dpHadiData.m_PrimaryConnection);

            SqlCommand c2 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Insert", dpHadiData.m_PrimaryConnection);
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c2.Parameters.Add("@ParentObjectId", SqlDbType.VarChar, 50, "ParentObjectId");
            c2.Parameters.Add("@ObjectType", SqlDbType.VarChar, 20, "ObjectType");
            c2.Parameters.Add("@Pname", SqlDbType.NVarChar, 50, "Pname");
            c2.Parameters.Add("@IsSecurable", SqlDbType.Bit, 1, "IsSecurable");

            SqlCommand c3 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Update", dpHadiData.m_PrimaryConnection);
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c3.Parameters.Add("@ParentObjectId", SqlDbType.VarChar, 50, "ParentObjectId");
            c3.Parameters.Add("@ObjectType", SqlDbType.VarChar, 20, "ObjectType");
            c3.Parameters.Add("@Pname", SqlDbType.NVarChar, 50, "Pname");
            c3.Parameters.Add("@IsSecurable", SqlDbType.Bit, 1, "IsSecurable");

            SqlCommand c4 = new SqlCommand("sp_Acc_Tbl_ApplicationObject_Delete", dpHadiData.m_PrimaryConnection);
            c4.CommandType = CommandType.StoredProcedure;
            c4.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");

            strRes = RWAS.DataAccess.dpHadiData.UpdateDataSource(RWAS.DataAccess.dpHadiData.m_PrimaryConnection, myTable, c1, c2, c3, c4);


            return strRes;
        }

        public static string UpdateAccess(DataTable myTable)
        {
            string strRes = "";

            SqlCommand c1 = new SqlCommand("select * from Acc_Tbl_UserAccessRight", dpHadiData.m_PrimaryConnection);
         
            SqlCommand c2 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Insert", dpHadiData.m_PrimaryConnection);
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("@GroupId", SqlDbType.Int, 4, "GroupId");
            c2.Parameters.Add("@UserId", SqlDbType.VarChar, 16, "UserId");
            c2.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c2.Parameters.Add("@IsVisible", SqlDbType.Bit, 1, "IsVisible");
            c2.Parameters.Add("@IsEnable", SqlDbType.Bit, 1, "IsEnable");
            c2.Parameters.Add("@GrantSelect", SqlDbType.Bit, 1, "GrantSelect");
            c2.Parameters.Add("@GrantInsert", SqlDbType.Bit, 1, "GrantInsert");
            c2.Parameters.Add("@GrantUpdate", SqlDbType.Bit, 1, "GrantUpdate");
            c2.Parameters.Add("@GrantDelete", SqlDbType.Bit, 1, "GrantDelete");
            c2.Parameters.Add("@GrantExecute", SqlDbType.Bit, 1, "GrantExecute");
            
            SqlCommand c3 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Update", dpHadiData.m_PrimaryConnection);
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("@AccessId", SqlDbType.UniqueIdentifier, 16, "AccessId");
            c3.Parameters.Add("@GroupId", SqlDbType.Int, 4, "GroupId");
            c3.Parameters.Add("@UserId", SqlDbType.VarChar, 16, "UserId");
            c3.Parameters.Add("@ObjectId", SqlDbType.VarChar, 50, "ObjectId");
            c3.Parameters.Add("@IsVisible", SqlDbType.Bit, 1, "IsVisible");
            c3.Parameters.Add("@IsEnable", SqlDbType.Bit, 1, "IsEnable");
            c3.Parameters.Add("@GrantSelect", SqlDbType.Bit, 1, "GrantSelect");
            c3.Parameters.Add("@GrantInsert", SqlDbType.Bit, 1, "GrantInsert");
            c3.Parameters.Add("@GrantUpdate", SqlDbType.Bit, 1, "GrantUpdate");
            c3.Parameters.Add("@GrantDelete", SqlDbType.Bit, 1, "GrantDelete");
            c3.Parameters.Add("@GrantExecute", SqlDbType.Bit, 1, "GrantExecute");

            SqlCommand c4 = new SqlCommand("sp_Acc_Tbl_UserAccessRight_Delete", dpHadiData.m_PrimaryConnection);
            c4.CommandType = CommandType.StoredProcedure;
            c4.Parameters.Add("@AccessId", SqlDbType.UniqueIdentifier, 16, "AccessId");

            strRes = RWAS.DataAccess.dpHadiData.UpdateDataSource(RWAS.DataAccess.dpHadiData.m_PrimaryConnection, myTable,c1,c2,c3,c4);


            return strRes;
        }

        public static DataTable GetJobs()
        {
            DataTable dtResult = new DataTable();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwJob", "*", "", "Prs_Fld_Describe");
            }
            catch
            {
            }

            return dtResult;
        }

        public static DataTable GetOrgUnits()
        {
            DataTable dtResult = new DataTable();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwOrgUnit", "*", "", "Prs_Fld_Code");
            }
            catch
            {
            }

            return dtResult;
        }

        public static DataTable GetEmployeeStatus()
        {
            DataTable dtResult = new DataTable();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwEmployeeStatus", "*", "", "Prs_Fld_Code");
            }
            catch
            {
            }

            return dtResult;
        }


        public static DataTable GetStudyStatus()
        {
            DataTable dtResult = new DataTable();

            try
            {
                dtResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwStudyStatus", "*", "", "Prs_Fld_Code");
            }
            catch
            {
            }

            return dtResult;
        }

        public static void FillUserCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                //dtInput = dpHadiData.ExecuteStoredProcedure2((dpHadiData.m_PrimaryConnection, "Acc_Tbl_Group", "*", "", "");
                //dpHadiBusiness.FillListControl(cboWork, dtInput, "Acc_Fld_Describe", "Acc_Fld_pk_Group");

                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Acc_Viw_Full_User", "Acc_Fld_UID, Acc_Fld_GroupCode,Acc_Fld_fk_Region, Prs_Fld_FirstName+' '+Prs_Fld_LastName as UserName", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "UserName", "Acc_Fld_UID");

                
                /*
				dvwSelect=objUserDefineData.Acc_Sp_Sel_User.DefaultView;
                dvwSelect.RowFilter = "Acc_Fld_GroupCode=" + cmbUserGroup.SelectedValue.ToString() + " and Acc_Fld_fk_Region="+cmbRegion.SelectedValue.ToString();
                
                 */

            }
            catch
            {
            }
        }

        public static void FillUserGroupCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Acc_Tbl_Group", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "Acc_Fld_Describe", "Acc_Fld_pk_Group");
            }
            catch
            {
            }
        }

        public static void FillRegionCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwRegion", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "Rws_Fld_Describe", "Rws_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillOrgUnitCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwOrgUnit", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "prs_Fld_Describe", "prs_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillOrgUnitCombo(System.Windows.Forms.ComboBox cboWork, int RegionCode)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwOrgUnit", "*", "vahedeasli="+RegionCode.ToString(), "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "prs_Fld_Describe", "prs_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillEmployeeStatusCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwEmployeeStatus", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "prs_Fld_Describe", "prs_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillStudyStatusCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwStudyStatus", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "prs_Fld_Describe", "prs_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillJobCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwJob", "*", "", "prs_Fld_Describe");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "prs_Fld_Describe", "prs_Fld_Code");
            }
            catch
            {
            }
        }

        public static void FillMaritalStatusCombo(System.Windows.Forms.ComboBox cboWork)
        {
            DataTable dtInput = new DataTable();

            try
            {
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwMaritalstatus", "*", "", "");
                dpHadiBusiness.FillListControl(cboWork, dtInput, "descript", "id");
            }
            catch
            {
            }
        }
        
        public static DataTable GetAccidents(string begindate, string enddate)
        {
            DataTable myTable = new DataTable();
            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@BeginDate", begindate);
                objSqlParameters[1] = new SqlParameter("@EndDate", enddate);

                myTable = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Sp_RWS_Rep_EarlyAccident", objSqlParameters);
            }
            catch (Exception ex)
            {
            }

            return myTable;
        }

        public static string GetPersonnelName(int nUniquecode)
        {
            string strResult = "";

            strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwFullPersonnel", "Prs_Fld_FirstName + ' - '+  Prs_Fld_LastName", "Prs_Fld_UniqueCode="+nUniquecode.ToString()).ToString();

            return strResult;
        }

        public static string GetPersonnelEmployeeDate(int nUniquecode)
        {
            string strResult = "";

            strResult = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwFullPersonnel", "Prs_Fld_EmployeeDate", "Prs_Fld_UniqueCode=" + nUniquecode.ToString()).ToString();

            return strResult;
        }
        
        public static DataView GetPersonnelAccidents(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_fk_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_GetPersonnelAccidents", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelOperation(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_fk_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_GetPersonnelOperation", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetReportPersonnelOperation(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_fk_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_Rep_GetPersonnelOperation", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelTraining(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_PersonelTraining", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelBodily(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_BodilyMentalStatus", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelEulogy(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_Eulogy", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelEulogy4Score(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_Eulogy_4Score", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetJobStatuses()
        {
            DataView myView = new DataView();

            try
            {
                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_tbl_JobStatus", "*", "", "JobStatusId").DefaultView;
            }
            catch
            {
            }

            return myView;
        }

        public static DataView GetPersonnelOfRegions(object[] myRegion)
        {
            DataView myView = new DataView();

            try
            {
                string strMyRegionList = "(" + string.Join(",", myRegion) + ")";

                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwFullPersonnel", "*", "Prs_Fld_fk_Region in "+strMyRegionList, "").DefaultView;
            }
            catch
            {
            }

            return myView;
        }

        public static DataView GetDataEntry(object[] myRegion)
        {
            DataView myView = new DataView();
            DataTable dtResult = new DataTable();

            //string strMyRegionList = "(" + string.Join(",", myRegion) + ")";
            SqlParameter[] objSqlParameters = new SqlParameter[1];
            dtResult.Columns.Add("RegionDesc");
            dtResult.Columns.Add("accident_count");
            dtResult.Columns.Add("operation_count");
            dtResult.Columns.Add("bodily_count");
            dtResult.Columns.Add("training_count");
            dtResult.Columns.Add("eulogy_count");
            dtResult.Columns.Add("chastise_count");
            dtResult.Columns.Add("preferment_count");
            dtResult.Columns.Add("jobstatus_count");

            try
            {

                for (int i = 0; i < myRegion.Length; i++)
                {
                    objSqlParameters[0] = new SqlParameter("@Region", myRegion[i]);
                    myView = new DataView();
                    myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Sp_GetDataEntry", objSqlParameters).DefaultView;                    
                    string strRegionDesc = "";

                    strRegionDesc = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "vwRegion", "rws_fld_describe", "rws_fld_code="+myRegion[i].ToString()).ToString();
                    dtResult.Rows.Add(new object[9] {strRegionDesc, myView[0]["accident_count"], myView[0]["operation_count"], myView[0]["bodily_count"], myView[0]["training_count"], myView[0]["eulogy_count"], myView[0]["chastise_count"], myView[0]["preferment_count"], myView[0]["jobstatus_count"] });
                }

            }
            catch
            {
                throw;
            }

            return dtResult.DefaultView;
        }

        public static DataView GetHealthItem(byte nHealthKind)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {

                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_HealthItem", "*", "Rws_Fld_fk_HealthKind="+nHealthKind.ToString(), "").DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }
        
        public static DataView GetAccidentReason()
        {
            DataView myView = new DataView();

            try
            {

                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_AccidentReason", "*", "", "Rws_Fld_Reason").DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetAccidentDegree()
        {
            DataView myView = new DataView();

            try
            {

                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_AccidentDegree", "*", "", "").DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static DataView GetPersonnelChastise(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Rws_Sp_Rep_Chastise", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }



        public static string GetRailVeihcleKind(string RailwayVehiclePK)
        {
            string strRes = "";
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;
                objCommand.CommandText = "select Rws_Fld_fk_RailwayVehicleKind from Rws_Tbl_RailwayVehicle where Rws_Fld_pk_RailwayVehicle=" + RailwayVehiclePK;
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                strRes = dr["Rws_Fld_fk_RailwayVehicleKind"].ToString();


                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return strRes;
        }

        public static string DeleteDependenceUser(string userid)
        {
            string strRes = "";
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch (Exception ex)
                {
                    //strRes = ex.Message;
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;


                objCommand.CommandText = "DELETE From Acc_Tbl_UserAccessRight where userid='" + userid + "'";
                objCommand.ExecuteNonQuery();

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }


        public static string DeleteDependenceAccident(int EarlyAccidentPK)
        {
            string strRes = "";
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch (Exception ex)
                {
                    strRes = ex.Message;
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;

                /*
                objCommand.CommandText = "DELETE From Rws_Tbl_AccidentLocation where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();
                */

                objCommand.CommandText = "DELETE From Rws_Tbl_AccidentMedia where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();

                objCommand.CommandText = "DELETE From Rws_Tbl_AgentDieAndAfoul where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();

                objCommand.CommandText = "DELETE From Rws_Tbl_RailwayAccident where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();

                objCommand.CommandText = "DELETE From Rws_Tbl_AbRailwayAccident where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();

                objCommand.CommandText = "DELETE From Rws_Tbl_SecondaryAccident where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();

                /*
                objCommand.CommandText = "DELETE From Rws_Tbl_TrainAttribute where Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString();
                objCommand.ExecuteNonQuery();
                */

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        public static string GetRailVeihcleSerial(string RailwayVehiclePK)
        {
            string strRes = "";
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;
                objCommand.CommandText = "select Rws_Fld_SerialNo from Rws_Tbl_RailwayVehicle where Rws_Fld_pk_RailwayVehicle=" + RailwayVehiclePK;
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                strRes = dr["Rws_Fld_SerialNo"].ToString();


                dpHadiData.m_PrimaryConnection.Close();
            }

            catch (Exception ex)
            {
            }

            return strRes;
        }

        public static DataView GetUserGroups()
        {
            DataView myView = new DataView();

            try
            {
                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Acc_Tbl_Group","*","","").DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public static int GetUserGroup(string userid)
        {
            int nRes = 0;
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;
                objCommand.CommandText = "select Acc_Fld_fk_Group from Acc_Tbl_User where Acc_Fld_UID='" + userid+"'";
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                nRes = Convert.ToInt32( dr["Acc_Fld_fk_Group"].ToString());


                dpHadiData.m_PrimaryConnection.Close();
            }

            catch (Exception ex)
            {
            }

            return nRes;
        }

        public static int GetLastRegion(int nUniquecode)
        {
            int nRes = 0;
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;
                objCommand.CommandText = "select dbo.fn_GetLastRegion("+nUniquecode.ToString()+")";

                nRes = Convert.ToInt32(objCommand.ExecuteScalar());

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return nRes;
        }

        public static string GetLastJob(int nUniquecode)
        {
            string strRes = "";
            SqlCommand objCommand = new SqlCommand();

            try
            {
                try
                {
                    dpHadiData.m_PrimaryConnection.Open();
                }
                catch
                {
                }

                objCommand.Connection = dpHadiData.m_PrimaryConnection;
                objCommand.CommandText = "select dbo.fn_GetLastJob(" + nUniquecode.ToString() + ")";

                strRes = objCommand.ExecuteScalar().ToString();

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return strRes;
        }

    }
}
