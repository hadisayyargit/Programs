using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

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

        public static DataView SearchPersonnel(int nUniquecode = 0, string strFirstName = null, string strLastName = null, string strPersonelID = null, int RegionId = 0, string JobId = null, int EmployeeStatus = 0, int nSubcontractor = 0, string National_code = null, int nIsSubcontractor = -1)
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

        public static DataView GetUserGroups()
        {
            DataView myView = new DataView();

            try
            {
                myView = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Acc_Tbl_Group", "*", "", "").DefaultView;
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
                objCommand.CommandText = "select Acc_Fld_fk_Group from Acc_Tbl_User where Acc_Fld_UID='" + userid + "'";
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                nRes = Convert.ToInt32(dr["Acc_Fld_fk_Group"].ToString());


                dpHadiData.m_PrimaryConnection.Close();
            }

            catch (Exception ex)
            {
            }

            return nRes;
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
                dtInput = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwOrgUnit", "*", "vahedeasli=" + RegionCode.ToString(), "");
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

        public static DataTable GetAccidentImages(string begindate, string enddate, bool HasTrainArrangement, bool HasCroquis)
        {
            DataTable myTable = new DataTable();
            SqlParameter[] objSqlParameters = new SqlParameter[4];

            try
            {
                objSqlParameters[0] = new SqlParameter("@BeginDate", begindate);
                objSqlParameters[1] = new SqlParameter("@EndDate", enddate);
                objSqlParameters[2] = new SqlParameter("@HasTrainArrangement", HasTrainArrangement);
                objSqlParameters[3] = new SqlParameter("@HasCroquis", HasCroquis);

                myTable = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Sp_GetAccidentImages", objSqlParameters);
            }
            catch (Exception ex)
            {
            }

            return myTable;
        }

        public static DataTable GetAccidentMedia(string begindate, string enddate)
        {
            DataTable myTable = new DataTable();
            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@BeginDate", begindate);
                objSqlParameters[1] = new SqlParameter("@EndDate", enddate);

                myTable = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "Sp_GetAccidentMedia", objSqlParameters);
            }
            catch (Exception ex)
            {
            }

            return myTable;
        }

        public static object GetAccidentImageValue(int EarlyAccidentPK, bool IsCroquis)
        {
            object myObject = new object();

            try
            {

                if (IsCroquis)
                    myObject = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "Rws_Tbl_AccidentLocation", "Rws_Fld_Croquis", "Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString());
                else
                    myObject = dpHadiData.GetFieldValue(dpHadiData.m_PrimaryConnection, "Rws_Tbl_TrainAttribute", "Rws_Fld_TrainArrangementCroquis", "Rws_Fld_fk_EarlyAccident=" + EarlyAccidentPK.ToString());
            }

            catch (Exception ex)
            {
            }

            return myObject;
        }

        public static string UpdateAccidentMediaData(int EarlyAccidentPK, byte[] myPic, bool IsCroquis)
        {
            SqlParameter[] objSqlParameters = new SqlParameter[2];
            string strRes = "";

            objSqlParameters[0] = new SqlParameter("@Rws_Fld_fk_EarlyAccident", EarlyAccidentPK);
            objSqlParameters[1] = new SqlParameter("@Rws_Fld_Croquis", myPic);

            if (IsCroquis)
                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Update_AccidentLocation_Image", objSqlParameters);
            else
                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Update_TrainAttribute_Image", objSqlParameters);

            return strRes;
        }

        public static string GetMaxPkOfAccident(string myDate)
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
                objCommand.CommandText = "select Max(Rws_Fld_pk_EarlyAccident) as MaxPK from Rws_Tbl_EarlyAccident where [Rws_Fld_AccidentDate]='" + myDate + "'";
                SqlDataReader dr = objCommand.ExecuteReader();

                dr.Read();
                strRes = dr["MaxPK"].ToString();


                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return strRes;
        }

        public static byte GetMaxPkOfAccidentKind()
        {
            byte nRes = 0;

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
                objCommand.CommandText = "select Max(Rws_Fld_Code) as MaxPK from Rws_Tbl_AccidentKind";
                SqlDataReader dr = objCommand.ExecuteReader();

                dr.Read();
                nRes = dr.GetByte(0);

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return nRes;
        }

        public static DataView GetAllAccidentKind()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "Rws_Tbl_AccidentKind", "*", "", "Rws_Fld_Code").DefaultView;
            }
            catch
            {
            }

            return dvResult;

        }

        public static string GetAccidentCategory(int EarlyAccidentPK)
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
                objCommand.CommandText = "select [Rws_Fld_FileCategorize] from Rws_Tbl_EarlyAccident where [Rws_Fld_pk_EarlyAccident]=" + EarlyAccidentPK.ToString();
                SqlDataReader dr = objCommand.ExecuteReader();
                
                dr.Read();
                strRes = dr["Rws_Fld_FileCategorize"].ToString();


                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return strRes;
        }

        public static bool GetAccidentLocationKind(int EarlyAccidentPK)
        {
            bool bRes = false;
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
                objCommand.CommandText = "select [Rws_Fld_IsAccidentOnBlock] from Rws_Tbl_AccidentLocation where [Rws_Fld_fk_EarlyAccident]=" + EarlyAccidentPK.ToString();
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                bRes = (bool)dr["Rws_Fld_IsAccidentOnBlock"];


                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return bRes;
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
                    //strRes = ex.Message;
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


                objCommand.CommandText = "DELETE From Acc_Tbl_UserAccessRight where userid='" + userid+"'";
                objCommand.ExecuteNonQuery();

                dpHadiData.m_PrimaryConnection.Close();
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        public static int GetRailVeihcleKind(int EarlyAccidentPK)
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
                objCommand.CommandText = "select Rws_Fld_fk_RailWayVehicleKind from Rws_Tbl_EarlyAccident where Rws_Fld_pk_EarlyAccident=" + EarlyAccidentPK.ToString();
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();

                nRes = Convert.ToInt32(dr["Rws_Fld_fk_RailWayVehicleKind"].ToString());


                dpHadiData.m_PrimaryConnection.Close();
            }
            catch
            {
            }

            return nRes;
        }

        public static int GetRailVeihcleSerial(int EarlyAccidentPK)
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
                objCommand.CommandText = "select Rws_Fld_fk_SerialNo from Rws_Tbl_EarlyAccident where Rws_Fld_pk_EarlyAccident=" + EarlyAccidentPK.ToString();
                SqlDataReader dr = objCommand.ExecuteReader();
                dr.Read();
                nRes = Convert.ToInt32(dr["Rws_Fld_fk_SerialNo"].ToString());


                dpHadiData.m_PrimaryConnection.Close();
            }

            catch (Exception ex)
            {
            }

            return nRes;
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
                objCommand.CommandText = "select dbo.fn_GetLastRegion(" + nUniquecode.ToString() + ")";

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
