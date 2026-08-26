using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ProgLib;
using ProgLib.Configuration;
using ProgLib.Configuration.Login;
using ProgLib.Configuration.Event;
using RWAS.Common;
using RWAS.BusinessRules;


using System.Globalization;

namespace RWAS.WinUI
{
    public partial class frmWorkBook : Form
    {
        #region Variables

        ProgLib.Classes.CUtilities objUtil = new ProgLib.Classes.CUtilities();
        PersonelData objDSPersonel = new PersonelData();
        clsDSOrgUnit objDSOrgUnit = new clsDSOrgUnit();
        DS_Personel objDS_Personel = new DS_Personel();

        int nUniqueCode=0;
        bool blnIns, blnUpd, blnDel;
        #endregion

        public frmWorkBook()
        {
            InitializeComponent();
        }

        private void frmWorkBook_Load(object sender, EventArgs e)
        {
            CheckAccess();
            FirstInitialize();
        }

        private void CheckAccess()
        {
            ///<Hadi>

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



        //*********************************************************************
        // Method Name : AddClicked
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        ///تغییر وضعیت کلیدها
        /// </summary>
        //*********************************************************************
        private void AddClicked()
        {
            if (blnIns)
            {
                if (CAccessControl.GetAccess(this.Name, "NewButton") != null)
                {
                    //set new button enable property in the base of AccessControl
                    btnNew.Enabled = CAccessControl.GetAccess(this.Name, "NewButton").Enable;
                }
                else
                {
                    btnNew.Enabled = true;
                }
            }
        }

        //*********************************************************************
        // Method Name : HandleSave
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        /// ذخیره در پایگاه اطلاعاتی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //*********************************************************************
        //		private void HandleSave(object sender, System.EventArgs e)
        //		{
        //		}

        private void save()
        {
            bool binSaveSecResult;
            clsBRWorkBook objBRWorkBook = new clsBRWorkBook();
            UserPersonel objBRUserPersonel = new UserPersonel();
            Activity objActivity = new Activity();

            try
            {
                binSaveSecResult = objBRUserPersonel.UpdatePersonel(objDS_Personel);

                if (binSaveSecResult == true)
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 15), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 10), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //				SaveDefault();
            }
            catch (System.Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;

                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 10), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //*********************************************************************
        // Method Name : NewCondition
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        ///وضعیت جدید
        /// </summary>
        //*********************************************************************
        private void NewCondition()
        {
            //			ProgLib.Classes.CDate objCDate=new ProgLib.Classes.CDate();

            txtUniqueCode.Enabled = true;
            txtUniqueCode.Text = "";
            txtPersonelID.Enabled = true;
            txtPersonelID.Text = "";

            lblPersonelName.Text = "";
            txtJobHistory.Text = "0";
            txtBirthYear.Text = "0";
            cmbEmployeeStatus.SelectedIndex = -1;
            cmbStudyStatus.SelectedIndex = -1;
            cmbJob.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            //cmbRegion.SelectedIndex = -1;
            cboOrgUnit.SelectedIndex = -1;

            txtEmployeeDate.ResetSelectedDateTime();

            txtContractor.Text = "";
            txtTelNo.Text = "";
            txtAddress.Text = "";
            txtIDNo.Text = "";
            txtNationalCode.Text = "";
            txtFather.Text = "";

            disButtons();
        }

        #region comment Del
        //*********************************************************************
        // Method Name : HandleDel
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        ///  حذف به صورت موقت
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //*********************************************************************
        //		private void HandleDel(object sender, System.EventArgs e)
        //		{
        //			SecondaryAccidentDetail objSecondaryAccidentDetail= new SecondaryAccidentDetail();
        //			Activity objActivity=new Activity(); 
        //
        //			bool binlIsConfirm;
        //			string  strMsg;
        //			DataRow[] drowSelect;
        ////			int intUniqueCode;
        //
        //			try 
        //			{
        //				if ( ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 65), "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes ) 
        //				{
        ////					intUniqueCode=Convert.ToInt32(grdWorkBook[grdWorkBook.CurrentRowIndex,0]);
        //
        //					//do Del
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_BodilyMentalStatus.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_Chastise.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_Eulogy.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_Operation.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_PersonelAccident.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_PersonelTraining.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_PrefermentHistory.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSWorkBook.Rws_Sp_Sel_IsEx_Score.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        //					drowSelect=objDSPersonel.Prs_Sp_Sel_IsEx_PersonelInfo.Select("Prs_Fld_UniqueCode =" + intUniqueCode.ToString() + " And Prs_Fld_UniqueCode=" + intUniqueCode.ToString());
        //					drowSelect[0].Delete();
        //
        ////					ShowAppropriateItems();
        //
        //					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 22), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //
        //					strMsg = CMessageHandler.Handle(Program.m_System, 22) + Convert.ToString(intUniqueCode);
        //					//CLogManager.WriteLog(LogType.logInfo, Program.m_System, strMsg, CApplicationAssert.LineNumber, "FrmWorkBook");
        //					//objActivity.WriteLog(FrmLogin.objActivityData,(int)FormID.FrmWorkBook,(int)ActivityKind.Delete);
        //
        //					SaveSet();
        //				}
        //
        //
        //			} 
        //			catch (Exception ocException) 
        //			{
        //				
        //				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 11), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error );
        //				//CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBook");
        //				
        //			}
        //
        //		}
        #endregion comment Del

        //*********************************************************************
        // Method Name : HandleUpd
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        /// ویرایش به صورت موقت
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //*********************************************************************
        //*********************************************************************
        // Method Name : IsValidData
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        /// چک شدن درستی اطلاعات ورودی
        /// </summary>
        /// <returns></returns>
        //*********************************************************************
        private bool IsValidData()
        {
            clsBRWorkBook objBRWorkBook = new clsBRWorkBook();

            //check if item entered
            if (txtUniqueCode.Text == "")
            {
                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 90), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUniqueCode.Focus();
                return false;
            }

            //			if (txtAge.Text!="") 
            //				if (Convert.ToInt32(txtAge.Text)>100) 
            //				{
            //					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 132), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            //					txtAge.Focus();
            //					return false;
            //				}

            if (txtEmployeeDate.Text.ToString() != "")
            {
                if (!objBRWorkBook.checkDateFormat(CommonClass.GetDateWithoutSlash(txtEmployeeDate.Text)))
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 250), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmployeeDate.Focus();
                    return false;
                }

                //				if (txtEmployeeDate.Text.Substring(0,2)!="13" && txtEmployeeDate.Text.Substring(0,2)!="14")
                //				{
                //					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 250), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                //					txtEmployeeDate.Focus();
                //					return false;
                //				}


                if (Convert.ToInt32(Program.m_strCurrentPDateNoneSlash) < Convert.ToInt32(CommonClass.GetDateWithoutSlash(txtEmployeeDate.Text)))
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 251), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmployeeDate.Focus();
                    return false;
                }
            }
            return true;
        }

        //*********************************************************************
        // Method Name : EditPersonel
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        ///  ویرایش پرسنل
        /// </summary>
        //*********************************************************************
        private void EditPersonel()
        {
            DataRow[] drowSelect;
            int intUID;

            if (objDSPersonel.Prs_Sp_Sel_IsEx_PersonelInfo.Rows.Count != 0)
            {
                intUID = Convert.ToInt32(txtUniqueCode.Text);

                drowSelect = objDSPersonel.Prs_Sp_Sel_IsEx_PersonelInfo.Select("Prs_Fld_UniqueCode=" + intUID.ToString());

                if (drowSelect.Length == 0)
                    return;

                if (txtPersonelID.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_PersonelID] = txtPersonelID.Text;
                if (txtJobHistory.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_JobHistory] = txtJobHistory.Text;
                if (txtBirthYear.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_BirthYear] = txtBirthYear.Text;
                if (cmbEmployeeStatus.SelectedIndex != -1)
                    drowSelect[0][PersonelData.Prs_Fld_fk_EmployeeStatus] = cmbEmployeeStatus.SelectedValue;
                if (cmbJob.SelectedIndex != -1)
                    drowSelect[0][PersonelData.Prs_Fld_fk_Job] = cmbJob.SelectedValue;
                if (cmbStudyStatus.SelectedIndex != -1)
                    drowSelect[0][PersonelData.Prs_Fld_fk_StudyStatus] = cmbStudyStatus.SelectedValue;
                if (txtJobHistory.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_JobHistory] = txtJobHistory.Text;
                if (cmbMaritalStatus.SelectedIndex != -1)
                    drowSelect[0][PersonelData.Prs_Fld_MaritalStatus] = cmbMaritalStatus.SelectedIndex;
                if (txtPersonelID.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_PersonelID] = txtPersonelID.Text;

                if (txtAddress.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_Address] = txtAddress.Text;
                if (txtTelNo.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_TelNo] = txtTelNo.Text;
                if (txtContractor.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_Contractor] = txtContractor.Text;
                if (txtIDNo.Text != "")
                    drowSelect[0][PersonelData.Prs_Fld_IDNo] = txtIDNo.Text;
                if (txtNationalCode.Text != "")
                    drowSelect[0][PersonelData.National_Code] = txtNationalCode.Text;
            }
        }



        //*********************************************************************
        // Method Name : ListFill
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        /// پر شدن اطلاعات
        /// </summary>
        //*********************************************************************
        private void FillInfo()
        {
            clsDSPersonel objDSPersonel = new clsDSPersonel();
            clsBRPersonel objBRPersonel = new clsBRPersonel();

            try
            {
                dpHadiBusiness.FillRegionCombo(cmbRegion);
                dpHadiBusiness.FillOrgUnitCombo(cboOrgUnit);
                dpHadiBusiness.FillEmployeeStatusCombo(cmbEmployeeStatus);
                dpHadiBusiness.FillStudyStatusCombo(cmbStudyStatus);
                dpHadiBusiness.FillJobCombo(cmbJob);
                dpHadiBusiness.FillMaritalStatusCombo(cmbMaritalStatus);

            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 18), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBook");

            }
        }


        //*********************************************************************
        // Method Name : FirstInitialize
        // Called By : FrmWorkBook
        // Date       : 6/18/2006
        /// <summary>
        ///بارگذاری اولیه فرم
        /// </summary>
        //*********************************************************************
        private void FirstInitialize()
        {
            RWAS.WinUI.FrmLoad objLoadForm;


            try
            {
                //Show Load Form
                objLoadForm = new FrmLoad(CMessageHandler.Handle(Program.m_System, 39));
                objLoadForm.StartPosition = FormStartPosition.CenterScreen;
                objLoadForm.Show();

                //Fill The form with DataBase Information
                FillInfo();

                //Close Load Form
                objLoadForm.Close();

                btnNew.Enabled = blnIns;

                NewCondition();

                cmbRegion.SelectedValue = Program.m_UserRegion;
                //cboCurrentRegion.SelectedValue = nUserRegion;

                if (Program.m_UserId.ToLower() != "admin")
                {
                    cmbRegion.Enabled = false;
                    cmbRegion.SelectedValue = Program.m_UserRegion;
                }

            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;


                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 18), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBook");

            }
        }

        private void ShowContent()
        {
            try
            {
                cmbEmployeeStatus.SelectedItem = null;
                cmbMaritalStatus.SelectedItem = null;
                cmbJob.SelectedItem = null;
                cmbRegion.SelectedItem = null;
                cboOrgUnit.SelectedItem = null;
                cmbStudyStatus.SelectedItem = null;

                DataView dvPersonnel = dpHadiBusiness.SearchPersonnel(nUniqueCode);

                if (dvPersonnel.Count > 0)
                {

                    txtUniqueCode.Text = nUniqueCode.ToString();
                    lblPersonelName.Text = dvPersonnel[0]["Prs_Fld_FirstName"].ToString() + " " + dvPersonnel[0]["Prs_Fld_LastName"].ToString();
                    txtFather.Text = dvPersonnel[0]["Prs_Fld_FatherName"].ToString();
                    txtNationalCode.Text = dvPersonnel[0]["National_Code"].ToString();
                    txtPersonelID.Text = dvPersonnel[0]["Prs_Fld_PersonelID"].ToString();
                    txtBirthYear.Text = dvPersonnel[0]["Prs_Fld_BirthYear"].ToString();
                    txtIDNo.Text = dvPersonnel[0]["Prs_Fld_IDNo"].ToString();
                    txtTelNo.Text = dvPersonnel[0]["Prs_Fld_TelNo"].ToString();
                    txtAddress.Text = dvPersonnel[0]["Prs_Fld_Address"].ToString();
                    txtContractor.Text = dvPersonnel[0]["SubContractorDescribe"].ToString();
                    txtJobHistory.Text = dvPersonnel[0]["Prs_Fld_JobHistory"].ToString();

                    cmbEmployeeStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_EmployeeStatus"];
                    cboOrgUnit.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_OrgUnit"];
                    cmbStudyStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_fk_StudyStatus"];
                    cmbMaritalStatus.SelectedValue = dvPersonnel[0]["Prs_Fld_MaritalStatus"];


                    if (dvPersonnel[0]["Prs_Fld_EmployeeDate"] != System.DBNull.Value)
                        txtEmployeeDate.Text = CommonClass.GetDateWithSlash(dvPersonnel[0]["Prs_Fld_EmployeeDate"].ToString());
                    else
                        txtEmployeeDate.ResetSelectedDateTime();


                    string strLastJob = dpHadiBusiness.GetLastJob(nUniqueCode);

                    if (strLastJob != "")
                        cmbJob.SelectedValue = strLastJob;

                    int nLastRegion = dpHadiBusiness.GetLastRegion(nUniqueCode);

                    if (nLastRegion != 0)
                        cmbRegion.SelectedValue = nLastRegion;


                    txtPersonelID.Enabled = false;

                    btnOperation.Enabled = true;
                    btnChastise.Enabled = true;
                    btnBodilyMentalStatus.Enabled = true;
                    btnPersonelAccident.Enabled = true;
                    btnEulogy.Enabled = true;
                    btnPersonelAccident.Enabled = true;
                    btnPersonelJobStatus.Enabled = true;
                    btnPrefermentHistory.Enabled = true;
                    btnPersonelTraining.Enabled = true;
                    btnScore.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUniqueCode_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (txtUniqueCode.Text == "")
                {
                    frmPersonnelSearch objChild = new frmPersonnelSearch();
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
                        ShowContent();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

    
        private void txtUniqueCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnUniqueCode.PerformClick();
            }
        }

        private void FrmWorkBook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control)
                {
                    switch (e.KeyValue)
                    {
                        case (int)Keys.X:
                            btnExit.PerformClick();
                            break;
                        case (int)Keys.H:
                            //CKeyBarWorkBook.PerformClick("Help");
                            break;
                        //						case (int)Keys.S:
                        //							CKeyBarWorkBook.PerformClick("Save");
                        //							break;
                        //						case (int)Keys.D:
                        //							CKeyBarWorkBook.PerformClick("Del");
                        //							break;
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
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBook");

            }
        }

        private void btnEulogy_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.FrmEulogy objFrmEulogy = new RWAS.WinUI.FrmEulogy(Convert.ToInt32(txtUniqueCode.Text));
            objFrmEulogy.StartPosition = FormStartPosition.CenterParent;
            objFrmEulogy.ShowDialog(this);
        }

        private void btnChastise_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.FrmChastise objFrmChastise = new RWAS.WinUI.FrmChastise(Convert.ToInt32(txtUniqueCode.Text));
            objFrmChastise.StartPosition = FormStartPosition.CenterParent;
            objFrmChastise.ShowDialog(this);
        }

        private void btnBodilyMentalStatus_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.FrmBodilyMentalStatus objFrmBodilyMentalStatus = new RWAS.WinUI.FrmBodilyMentalStatus(Convert.ToInt32(txtUniqueCode.Text));
            objFrmBodilyMentalStatus.StartPosition = FormStartPosition.CenterParent;
            objFrmBodilyMentalStatus.ShowDialog(this);
        }

        private void btnScore_Click(object sender, System.EventArgs e)
        {

            if (nUniqueCode <= 0)
                return;
            try
            {

                frmScore_View objFrmScore = new frmScore_View(Convert.ToInt32(txtUniqueCode.Text));
                objFrmScore.ShowDialog(this);
            }
            catch
            {
            }
        }

        private void btnOperation_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.FrmOperation objFrmOperation = new RWAS.WinUI.FrmOperation(Convert.ToInt32(txtUniqueCode.Text));
            objFrmOperation.StartPosition = FormStartPosition.CenterParent;
            objFrmOperation.ShowDialog(this);
        }

        private void btnPersonelAccident_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.FrmPersonelAccident objFrmPersonelAccident = new RWAS.WinUI.FrmPersonelAccident(Convert.ToInt32(txtUniqueCode.Text));
            //objFrmPersonelAccident.StartPosition=FormStartPosition.CenterParent;
            objFrmPersonelAccident.ShowDialog();
        }

        private void btnPersonelTraining_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            RWAS.WinUI.frmPersonnelTraining objFrmPersonelTraining = new RWAS.WinUI.frmPersonnelTraining(Convert.ToInt32(txtUniqueCode.Text));
            objFrmPersonelTraining.StartPosition = FormStartPosition.CenterParent;
            objFrmPersonelTraining.MdiParent = this.MdiParent;
            objFrmPersonelTraining.Show();
        }


        private void cmbStudyStatus_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Delete)
                cmbStudyStatus.SelectedIndex = -1;
        }

        private void cmbMaritalStatus_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Delete)
                cmbMaritalStatus.SelectedIndex = -1;
        }

        private void cmbEmployeeStatus_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Delete)
                cmbEmployeeStatus.SelectedIndex = -1;
        }

        private void cmbJob_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Delete)
                cmbJob.SelectedIndex = -1;
        }

        private void disButtons()
        {
            btnBodilyMentalStatus.Enabled = false;
            btnChastise.Enabled = false;
            btnEulogy.Enabled = false;
            btnOperation.Enabled = false;
            btnPersonelAccident.Enabled = false;
            btnPersonelTraining.Enabled = false;
            btnPrefermentHistory.Enabled = false;
            btnPersonelJobStatus.Enabled = false;
            btnScore.Enabled = false;
        }

        private void enButtons()
        {
            btnBodilyMentalStatus.Enabled = true;
            btnChastise.Enabled = true;
            btnEulogy.Enabled = true;
            btnOperation.Enabled = true;
            btnPersonelAccident.Enabled = true;
            btnPersonelTraining.Enabled = true;
            btnPrefermentHistory.Enabled = true;
            btnPersonelJobStatus.Enabled = true;
            btnScore.Enabled = true;
        }

        private void FrmWorkBook_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }


        private void CKeyBarWorkBook_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 245), "پرسش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    CLogManager.Clear();
                    this.Close();
                }
                //				}
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;
                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 35), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewCondition();

                btnNew.Enabled = blnIns;
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;

                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 42), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBook");

            }

        }

        private void btnPrefermentHistory_Click(object sender, System.EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            frmPersonnelStatus objfrmPersonnelStatus = new frmPersonnelStatus(Convert.ToInt32(txtUniqueCode.Text),true);
            objfrmPersonnelStatus.StartPosition = FormStartPosition.CenterParent;
            objfrmPersonnelStatus.ShowDialog(this);

            //int nUID = Convert.ToInt32(txtUniqueCode.Text);
            //int nLastRegion = dpHadiBusiness.GetLastRegion(nUID);
            //int nLastJob = dpHadiBusiness.GetLastJob(nUID);

            btnUniqueCode.PerformClick();
        }

        private void btnPersonelJobStatus_Click(object sender, EventArgs e)
        {
            if (nUniqueCode <= 0)
                return;

            frmPersonnelStatus objfrmPersonnelStatus = new frmPersonnelStatus(Convert.ToInt32(txtUniqueCode.Text),false);
            objfrmPersonnelStatus.StartPosition = FormStartPosition.CenterParent;
            objfrmPersonnelStatus.ShowDialog(this);

            //int nUID = Convert.ToInt32(txtUniqueCode.Text);
            //int nLastRegion = dpHadiBusiness.GetLastRegion(nUID);
            //int nLastJob = dpHadiBusiness.GetLastJob(nUID);

            //   if (nLastRegion != 0)
            //     cmbRegion.SelectedValue = nLastRegion;
            //else
            btnUniqueCode.PerformClick();

        }



    }

}

