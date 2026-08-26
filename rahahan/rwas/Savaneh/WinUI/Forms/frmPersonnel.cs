using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.Common;
using RWAS.BusinessRules;
using ProgLib;
using ProgLib.Configuration;
using ProgLib.Configuration.Login;
using ProgLib.Configuration.Event;


namespace RWAS.WinUI
{
    public partial class frmPersonnel : Form
    {
        #region Variables
        DataView objDataView;
        string strCurrentDate;
        ProgLib.Classes.CUtilities objUtil = new ProgLib.Classes.CUtilities();
        ProgLib.Components.CCalender ocCCalender;

        //		clsBRPersonel objBRPersonel; 
        //		DS_Personel objDS_Personel = new DS_Personel();
        PersonelData objDSPersonel = new PersonelData();

        bool blnIns, blnUpd, blnDel;


        #endregion

        #region Private

        enum eGrdCol
        {
            UniqueCode = 0,
            PersonelID = 1,
            FirstName = 2,
            LastName = 3,
            JobTitle = 4,
            RegionTitle = 5,
            SubContractorTitle = 6,
            count = 7
        }

        private void ShowContent(int nUniqueCode)
        {
            try
            {
                clearBoxes();

                cboEmployeeStatus.SelectedItem = null;
                cboMaritalStatus.SelectedItem = null;
                cboJob.SelectedItem = null;
                cboRegion.SelectedItem = null;
                cboOrgUnit.SelectedItem = null;
                cboStudyStatus.SelectedItem = null;

                DataView dvPersonnel = dpHadiBusiness.SearchPersonnel(nUniqueCode);

                if (dvPersonnel.Count > 0)
                {
                    //if (dvPersonnel[0]["SubContractorDescribe"] == DBNull.Value)
                    //{
                    //    MessageBox.Show("پرسنل مورد نظر جزو کارکنان پیمانکاری نمی باشد");
                    //    return;
                    //}

                    txtUniqueCode.Text = nUniqueCode.ToString();
                    txtFirstName.Text = dvPersonnel[0]["Prs_Fld_FirstName"].ToString();
                    txtLastName.Text = dvPersonnel[0]["Prs_Fld_LastName"].ToString();
                    txtFather.Text = dvPersonnel[0]["Prs_Fld_FatherName"].ToString();
                    txtNationalCode.Text = dvPersonnel[0]["National_Code"].ToString();
                    txtPersonelID.Text = dvPersonnel[0]["Prs_Fld_PersonelID"].ToString();

                    txtBirthYear.Text = dvPersonnel[0]["Prs_Fld_BirthYear"].ToString();
                    txtIDNo.Text = dvPersonnel[0]["Prs_Fld_IDNo"].ToString();
                    txtTelNo.Text = dvPersonnel[0]["Prs_Fld_TelNo"].ToString();
                    txtAddress.Text = dvPersonnel[0]["Prs_Fld_Address"].ToString();
                    txtJobHistory.Text = dvPersonnel[0]["Prs_Fld_JobHistory"].ToString();

                    //if (dvPersonnel[0]["SubContractorDescribe"]!= DBNull.Value) 
                    cboSubContractor.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_SubContractor"];
                    cboStudyStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_StudyStatus"];
                    cboMaritalStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_MaritalStatus"];
                    cboEmployeeStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_EmployeeStatus"];
                    cboOrgUnit.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_OrgUnit"];


                    if (dvPersonnel[0]["Prs_Fld_EmployeeDate"] != System.DBNull.Value)
                        faDatePickerEmployeeDate.Text = CommonClass.GetDateWithSlash(dvPersonnel[0]["Prs_Fld_EmployeeDate"].ToString());
                    else
                        faDatePickerEmployeeDate.ResetSelectedDateTime();


                    string strLastJob = dpHadiBusiness.GetLastJob(nUniqueCode);

                    if (strLastJob != "")
                        cboJob.SelectedValue = strLastJob;

                    int nLastRegion = dpHadiBusiness.GetLastRegion(nUniqueCode);

                    if (nLastRegion != 0)
                        cboRegion.SelectedValue = nLastRegion;


                    txtPersonelID.Enabled = false;
                    EditPermited();
                    AddClicked();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void NewCondition()
        {
            clearBoxes();
            clearBoxes();
            btnNew.Enabled = blnIns;
            txtUniqueCode.Enabled = true;
            txtPersonelID.Enabled = true;
        }

        private void clearBoxes()
        {
            txtPersonelID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtJobHistory.Text = "0";
            txtBirthYear.Text = "0";
            cboEmployeeStatus.SelectedIndex = -1;
            cboJob.SelectedIndex = -1;
            cboMaritalStatus.SelectedIndex = -1;
            cboStudyStatus.SelectedIndex = -1;
            cboSubContractor.SelectedIndex = -1;
            txtUniqueCode.Text = "";
            faDatePickerEmployeeDate.ResetSelectedDateTime();

            //			txtContractor.Text="";
            txtTelNo.Text = "";
            txtAddress.Text = "";
            txtIDNo.Text = "";
            txtNationalCode.Text = "";

            txtFather.Text = "";

            cboRegion.SelectedItem = null;
            cboOrgUnit.SelectedItem = null;
            
            if (Program.m_UserId.ToLower() != "admin")
            {
                cboRegion.Enabled = false;
                cboRegion.SelectedValue = Program.m_UserRegion;
            }
        }

        void BindOrgUnit()
        {
            if (cboRegion.SelectedItem != null)
            {
                dpHadiBusiness.FillOrgUnitCombo(cboOrgUnit,int.Parse(cboRegion.SelectedValue.ToString()));
            }
        }

        private void AddClicked()
        {
            btnAdd.Enabled = false;
        }

        //*********************************************************************
        // Method Name : NewClicked
        // Called By : FrmPersonel
        // Date       : 6/18/2006
        /// <summary>
        ///تغییر وضعیت کلیدها
        /// </summary>
        //*********************************************************************
        private void NewClicked()
        {
            btnAdd.Enabled = blnIns;
            btnNew.Enabled = blnIns;

            EditNotPermited();
        }

        private void save()
        {
            int nSaveSecResult;
            clsBRPersonel objBRPersonel = new clsBRPersonel();
            UserPersonel objBRUserPersonel = new UserPersonel();
            Activity objActivity = new Activity();

            try
            {
                nSaveSecResult = objBRUserPersonel.UpdateContractorPersonel(objDSPersonel);

                if (nSaveSecResult !=-1)
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 15), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (nSaveSecResult > 0)
                        txtUniqueCode.Text = nSaveSecResult.ToString();

                }
                else
                {
                    ProgLib.Components.MessageBox.Show("رخداد خطا", "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool IsValidData()
        {
            clsBRPersonel objBRPersonel = new clsBRPersonel();

            //check if item entered
            //			if (txtUniqueCode.Text=="")
            //			{
            //				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 90), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            //				txtUniqueCode.Focus();
            //				return false;
            //			}

            //			if (txtPersonelID.Text=="")
            //			{
            //				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 273), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            //				txtPersonelID.Focus();
            //				return false;
            //			}
            if (txtFirstName.Text == "")
            {
                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 91), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFirstName.Focus();
                return false;
            }
            if (txtLastName.Text == "")
            {
                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 91), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLastName.Focus();
                return false;
            }

            //			if (txtBirthYear.Text!="") 
            //				if (Convert.ToInt32(txtBirthYear.Text)>100) 
            //				{
            //					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 132), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            //					txtBirthYear.Focus();
            //					return false;
            //				}

            if (CommonClass.GetDateValue(faDatePickerEmployeeDate.Text) != 0)
            {
                if (Convert.ToInt32(strCurrentDate) < CommonClass.GetDateValue(faDatePickerEmployeeDate.Text))
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 251), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    faDatePickerEmployeeDate.Focus();
                    return false;
                }
            }

            if (cboSubContractor.SelectedValue==null)
            {
                MessageBox.Show("شرکت پیمانکار را انتخاب نمایید");
                cboSubContractor.Focus();
                return false;
            }

            return true;
        }



        private void EditPermited()
        {
            btnUpdate.Enabled = blnUpd;
            btnDelete.Enabled = blnDel;
        }

        //*********************************************************************
        // Method Name : EditNotPermited
        // Called By : FrmPersonel
        // Date       : 10/21/2005
        /////<//summary>
        /// تغییر وضعیت کلیدها
        /// </summary>
        //**********************************************************************
        private void EditNotPermited()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        //*********************************************************************
        // Method Name : ListFill
        // Called By : FrmPersonel
        // Date       : 6/18/2006
        /// <summary>
        /// پر شدن اطلاعات
        /// </summary>
        //*********************************************************************
        private void FillInfo()
        {
            clsBRPersonel objBRPersonel = new clsBRPersonel();
            clsBRSubContractor objBRSubContractor = new clsBRSubContractor();
            clsBRComboHandler objBRComboHandler = new clsBRComboHandler();

            DS_Region ocDS_Region = new DS_Region();
            DS_EmployeeStatus ocDS_EmployeeStatus = new DS_EmployeeStatus();
            DS_Job ocDS_Job = new DS_Job();
            DS_StudyStatus ocDS_StudyStatus = new DS_StudyStatus();
            clsDSOrgUnit objDSOrgUnit = new clsDSOrgUnit();
            clsDSSubContractor objDSSubContractor = new clsDSSubContractor();

            try
            {
                dpHadiBusiness.FillRegionCombo(cboRegion);
                dpHadiBusiness.FillEmployeeStatusCombo(cboEmployeeStatus);
                dpHadiBusiness.FillStudyStatusCombo(cboStudyStatus);
                dpHadiBusiness.FillJobCombo(cboJob);
                dpHadiBusiness.FillMaritalStatusCombo(cboMaritalStatus);



                objDSSubContractor = objBRSubContractor.GetSubContractor();
                cboSubContractor.DataSource = objDSSubContractor.Rws_Sp_Sel_All_SubContractor;
                cboSubContractor.DisplayMember = clsDSSubContractor.Rws_Fld_Describe;
                cboSubContractor.ValueMember = clsDSSubContractor.Rws_Fld_Code;

               
                UserPersonel objBRUserPersonel = new UserPersonel();
                //objDSPersonel = objBRUserPersonel.IsExConractorPersonelByName()

            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmPersonel");

            }
        }

        //*********************************************************************
        // Method Name : FirstInitialize
        // Called By : FrmPersonel
        // Date       : 6/18/2006
        /// <summary>
        ///بارگذاری اولیه فرم
        /// </summary>
        //*********************************************************************
        private void FirstInitialize()
        {
            RWAS.WinUI.FrmLoad objLoadForm;
            strCurrentDate = Program.m_strCurrentPDateNoneSlash;

            try
            {
                //Show Load Form
                objLoadForm = new FrmLoad(CMessageHandler.Handle(Program.m_System, 39));
                objLoadForm.StartPosition = FormStartPosition.CenterScreen;
                objLoadForm.Show();

                getUserFormAccessRight();
                //Fill The form with DataBase Information
                FillInfo();

                //Close Load Form
                objLoadForm.Close();

                NewClicked();

                NewCondition();


                if (Program.m_UserId.ToLower() == "admin")
                {
                }
                else
                {
                    cboRegion.Enabled = false;
                    cboRegion.SelectedValue = Program.m_UserRegion;
                }
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmPersonel");

            }
        }

        private void getUserFormAccessRight()
        {
            if (Program.m_UserId.ToLower() == "admin")
            {
                blnIns = true;
                blnUpd = true;
                blnDel = true;
                return;
            }

            CommonClass.m_dtUserAccess.DefaultView.RowFilter = "ObjectId='" + Common.CommonClass.m_ApplicationId + "_"  + this.Name + "'";
            CommonClass.m_dtGroupAccess.DefaultView.RowFilter = "ObjectId='" + Common.CommonClass.m_ApplicationId + "_"  + this.Name + "'";


            if (CommonClass.m_dtUserAccess.DefaultView.Count > 0)
            {
                blnIns = (bool)CommonClass.m_dtUserAccess.DefaultView[0]["GrantInsert"];
                blnUpd = (bool)CommonClass.m_dtUserAccess.DefaultView[0]["GrantUpdate"];
                blnDel = (bool)CommonClass.m_dtUserAccess.DefaultView[0]["GrantDelete"];
            }

            else if (CommonClass.m_dtGroupAccess.DefaultView.Count > 0)
            {
                blnIns = (bool)CommonClass.m_dtGroupAccess.DefaultView[0]["GrantInsert"];
                blnUpd = (bool)CommonClass.m_dtGroupAccess.DefaultView[0]["GrantUpdate"];
                blnDel = (bool)CommonClass.m_dtGroupAccess.DefaultView[0]["GrantDelete"];
            }

            else
            {
                blnIns = false;
                blnUpd = false;
                blnDel = false;
            }
        }

        #endregion

        public frmPersonnel()
        {
            InitializeComponent();
        }

        private void frmPersonnel_Load(object sender, EventArgs e)
        {
            try
            {
                Program.m_PrgMod = Program.PrgMod.FormLoading;
                FirstInitialize();
                Program.m_PrgMod = Program.PrgMod.Normal;
                BindOrgUnit();
            }

            catch (System.Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;
                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int nUniqueCode = 0;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (txtUniqueCode.Text == "")
                {
                    frmPersonnelSearch objChild = new frmPersonnelSearch(1);
                    objChild.ShowDialog(this);

                    nUniqueCode = objChild.PersonUniqueCode;
                }
                else
                {
                    nUniqueCode = int.Parse(txtUniqueCode.Text);
                }

                NewCondition();

                if (nUniqueCode != 0)
                {
                    int nRegion = dpHadiBusiness.GetLastRegion(nUniqueCode);
                    if (Program.m_UserId.ToLower() != "admin" && nRegion != Program.m_UserRegion)
                    {
                        this.Cursor = Cursors.Default;
                        System.Windows.Forms.MessageBox.Show("پرسنل مورد نظر تعریف نشده و یا در ناحیه شما نمی باشد");

                    }
                    else
                    {
                        ShowContent(nUniqueCode);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewCondition();

                NewClicked();
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmPersonel");

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Activity objActivity = new Activity();
            clsBRPersonel objBRPersonel = new clsBRPersonel();
            PersonelData.Prs_Sp_Sel_IsEx_PersonelInfoRow objPersonelRow;
            bool binValidationResult;
            //			int intMax;
            //			object objMax;
            string strMsg;

            try
            {
                binValidationResult = IsValidData();
                if (binValidationResult == false)
                {
                    return;
                }
                else
                {
                    objPersonelRow = objDSPersonel.Prs_Sp_Sel_IsEx_PersonelInfo.NewPrs_Sp_Sel_IsEx_PersonelInfoRow();

                    //fill new row
                    objPersonelRow["Prs_Fld_UniqueCode"] = 0;

                    if (txtPersonelID.Text != "")
                        objPersonelRow["Prs_Fld_PersonelID"] = txtPersonelID.Text;//
                    else
                        objPersonelRow["Prs_Fld_PersonelID"] = 0;//

                    objPersonelRow["Prs_Fld_FirstName"] = txtFirstName.Text;//
                    objPersonelRow["Prs_Fld_LastName"] = txtLastName.Text;//
                    if (cboMaritalStatus.SelectedIndex != -1)
                        objPersonelRow["Prs_Fld_MaritalStatus"] = Convert.ToByte(cboMaritalStatus.SelectedValue);
                    
                    if (cboEmployeeStatus.SelectedIndex != -1)
                        objPersonelRow["Prs_Fld_fk_EmployeeStatus"] = Convert.ToByte(cboEmployeeStatus.SelectedValue);
                    if (CommonClass.GetDateValue(faDatePickerEmployeeDate.Text) != 0)
                        objPersonelRow["Prs_Fld_EmployeeDate"] = CommonClass.GetDateWithoutSlash(faDatePickerEmployeeDate.Text);
                    if (cboJob.SelectedIndex >= 0)
                        objPersonelRow["Prs_Fld_fk_Job"] = Convert.ToString(cboJob.SelectedValue);
                    if (cboOrgUnit.SelectedIndex > -1)
                        objPersonelRow["Prs_Fld_fk_OrgUnit"] = Convert.ToInt32(cboOrgUnit.SelectedValue);
                    if (cboRegion.SelectedIndex > -1)
                        objPersonelRow["Prs_Fld_fk_Region"] = Convert.ToInt32(cboRegion.SelectedValue);

                    objPersonelRow["Prs_Fld_Address"] = txtAddress.Text;
                    if (txtIDNo.Text != "")
                        objPersonelRow["Prs_Fld_IDNo"] = Convert.ToInt32(txtIDNo.Text);
                    if (txtTelNo.Text != "")
                        objPersonelRow["Prs_Fld_TelNo"] = Convert.ToString(txtTelNo.Text);
                    if (cboSubContractor.SelectedIndex > -1)
                        objPersonelRow["Prs_Fld_fk_SubContractor"] = Convert.ToInt32(cboSubContractor.SelectedValue);
                    if (cboStudyStatus.SelectedIndex > -1)
                        objPersonelRow["Prs_Fld_fk_StudyStatus"] = Convert.ToInt32(cboStudyStatus.SelectedValue);

                    if (txtJobHistory.Text != "")
                        objPersonelRow["Prs_Fld_JobHistory"] = Convert.ToInt16(txtJobHistory.Text);


                    objPersonelRow["Prs_Fld_BirthYear"] = Convert.ToInt32(txtBirthYear.Text);

                    if (txtNationalCode.Text != "")
                        objPersonelRow["National_code"] = txtNationalCode.Text;

                    if (txtFather.Text != "")
                        objPersonelRow["Prs_Fld_FatherName"] = txtFather.Text;

                    //add new row
                    objDSPersonel.Prs_Sp_Sel_IsEx_PersonelInfo.Rows.Add(objPersonelRow);

                    //					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 20), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    save();
                    strMsg = CMessageHandler.Handle(Program.m_System, 20) + Convert.ToString(txtPersonelID.Text);
                    //CLogManager.WriteLog(LogType.logInfo, Program.m_System, strMsg, CApplicationAssert.LineNumber, "FrmPersonel");
                    //objActivity.WriteLog(FrmLogin.objActivityData,(int)FormID.FrmPersonel,(int)ActivityKind.Add);

                    //					SaveSet();
                }
                AddClicked();
                EditPermited();
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmRegion");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool binValid;
            int Prs_Fld_PersonelID = 0, Prs_Fld_fk_OrgUnit = 0, Prs_Fld_fk_SubContractor = 0, Prs_Fld_fk_Region = 0, Prs_Fld_IDNo = 0;
            string Prs_Fld_FirstName = "", Prs_Fld_LastName = "", Prs_Fld_FatherName = "", Prs_Fld_fk_Job = "", Prs_Fld_EmployeeDate = "", Prs_Fld_Address = "", Prs_Fld_TelNo = "", National_code = "";
            short Prs_Fld_JobHistory = 0, Prs_Fld_BirthYear = 0, Prs_Fld_fk_StudyStatus = 0;
            byte Prs_Fld_fk_EmployeeStatus = 0, Prs_Fld_MaritalStatus = 0;

            if (ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 106), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                binValid = IsValidData();

                if (binValid == false)
                    return;

                if (txtFather.Text != "")
                    Prs_Fld_FatherName = txtFather.Text;

                Prs_Fld_FirstName = txtFirstName.Text;
                Prs_Fld_LastName = txtLastName.Text;

                if (txtPersonelID.Text != "")
                    Prs_Fld_PersonelID = Convert.ToInt32(txtPersonelID.Text);
                else
                    Prs_Fld_PersonelID = 0;

                if (txtJobHistory.Text != "")
                    Prs_Fld_JobHistory = Convert.ToInt16(txtJobHistory.Text);

                if (txtBirthYear.Text != "")
                    Prs_Fld_BirthYear = Convert.ToInt16(txtBirthYear.Text);

                if (cboStudyStatus.SelectedIndex != -1)
                    Prs_Fld_fk_StudyStatus = Convert.ToInt16(cboStudyStatus.SelectedValue);

                if (cboMaritalStatus.SelectedIndex != -1)
                    Prs_Fld_MaritalStatus = Convert.ToByte(cboMaritalStatus.SelectedValue);

                if (cboEmployeeStatus.SelectedIndex != -1)
                    Prs_Fld_fk_EmployeeStatus = Convert.ToByte(cboEmployeeStatus.SelectedValue);

                if (CommonClass.GetDateValue(faDatePickerEmployeeDate.Text) != 0)
                    Prs_Fld_EmployeeDate = CommonClass.GetDateWithoutSlash(faDatePickerEmployeeDate.Text);

                if (cboJob.SelectedIndex >= 0)
                    Prs_Fld_fk_Job = Convert.ToString(cboJob.SelectedValue);

                if (cboOrgUnit.SelectedIndex > -1)
                    Prs_Fld_fk_OrgUnit = Convert.ToInt32(cboOrgUnit.SelectedValue);

                if (cboRegion.SelectedIndex > -1)
                    Prs_Fld_fk_Region = Convert.ToInt32(cboRegion.SelectedValue);

                if (cboSubContractor.SelectedIndex > -1)
                    Prs_Fld_fk_SubContractor = Convert.ToInt32(cboSubContractor.SelectedValue);

                if (txtAddress.Text != "")
                    Prs_Fld_Address = txtAddress.Text;

                if (txtIDNo.Text != "")
                    Prs_Fld_IDNo = Convert.ToInt32(txtIDNo.Text);

                if (txtTelNo.Text != "")
                    Prs_Fld_TelNo = txtTelNo.Text;

                if (txtNationalCode.Text != "")
                    National_code = txtNationalCode.Text;

                string strRes = dpHadiBusiness.UpdatePersonnel(Convert.ToInt32(txtUniqueCode.Text), Prs_Fld_PersonelID, Prs_Fld_FirstName, Prs_Fld_LastName, Prs_Fld_FatherName, Prs_Fld_MaritalStatus, Prs_Fld_fk_Job, Prs_Fld_JobHistory, Prs_Fld_BirthYear, Prs_Fld_fk_StudyStatus, Prs_Fld_fk_EmployeeStatus, Prs_Fld_EmployeeDate, Prs_Fld_Address, Prs_Fld_TelNo, Prs_Fld_fk_OrgUnit, Prs_Fld_IDNo, Prs_Fld_fk_Region, Prs_Fld_fk_SubContractor, National_code);

                if (strRes == "")
                {
                    MessageBox.Show("اطلاعات ویرایش شد");
                }
                else
                {
                    MessageBox.Show(strRes);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Activity objActivity = new Activity();
            bool binlIsUsed = false;
            //			int intCode;

            try
            {
                if (ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 65), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (binlIsUsed == true)
                    {
                        ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 111), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string strRes = dpHadiBusiness.DeletePersonnel(Convert.ToInt32(txtUniqueCode.Text));

                    if (strRes == "")
                    {
                        MessageBox.Show("اطلاعات با موفقیت حذف شد");
                        btnNew.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(strRes);
                    }
                }
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;

                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ocException)
            {

                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void frmPersonnel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{Tab}");

                if (e.KeyValue == (int)Keys.Delete)
                {
                    if (this.ActiveControl.GetType() == typeof(ComboBox))
                    {
                        ((ComboBox)this.ActiveControl).SelectedIndex = -1;
                        ((ComboBox)this.ActiveControl).SelectedIndex = -1;
                    }
                }

                if (e.KeyCode == Keys.Escape)
                    if (this.Contains(ocCCalender))
                        this.Controls.Remove(ocCCalender);
                
                if (e.Modifiers == Keys.Control)
                {
                    switch (e.KeyValue)
                    {
                        case (int)Keys.D:
                            btnDelete.PerformClick();
                            break;
                        case (int)Keys.N:
                            btnNew.PerformClick();
                            break;
                    }
                }

            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 68), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cboStudyStatus_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUniqueCode_Leave(object sender, EventArgs e)
        {

            int nUniqueCode = 0;

            if (this.ActiveControl != btnClose && txtUniqueCode.Text != "")
            {
                try
                {
                    nUniqueCode = int.Parse(txtUniqueCode.Text);

                    NewCondition();

                    if (nUniqueCode != 0)
                    {
                        int nRegion = dpHadiBusiness.GetLastRegion(nUniqueCode);
                        if (Program.m_UserId.ToLower() != "admin" && nRegion != Program.m_UserRegion)
                        {
                            this.Cursor = Cursors.Default;
                            System.Windows.Forms.MessageBox.Show("پرسنل مورد نظر تعریف نشده و یا در ناحیه شما نمی باشد");

                        }
                        else
                        {
                            ShowContent(nUniqueCode);
                        }
                    }



                    /*
                    if (txtLastName.Text == "")
                    {
                        MessageBox.Show("پرسنل جدید");
                        txtUniqueCode.Text = "0";
                        NewClicked();
                        txtPersonelID.Focus();
                    }
                     */

                }
                catch
                {
                }
            }
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.m_PrgMod != Program.PrgMod.FormLoading)
            {
                BindOrgUnit();
            }
        }

        private void cboOrgUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewContractor_Click(object sender, EventArgs e)
        {
            try
            {
                clsDSSubContractor objDSSubContractor = new clsDSSubContractor();
                clsBRSubContractor objBRSubContractor = new clsBRSubContractor();

                frmSubContractor objFrmSubContractor = new frmSubContractor();
                objFrmSubContractor.StartPosition = FormStartPosition.CenterScreen;
                objFrmSubContractor.ShowDialog(this);

                objDSSubContractor = objBRSubContractor.GetSubContractor();
                cboSubContractor.DataSource = objDSSubContractor.Rws_Sp_Sel_All_SubContractor;
                cboSubContractor.DisplayMember = clsDSSubContractor.Rws_Fld_Describe;
                cboSubContractor.ValueMember = clsDSSubContractor.Rws_Fld_Code;

            }
            catch (System.Exception ocException)
            {
                ProgLib.Components.MessageBox.Show(ocException.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void cboSubContractor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
