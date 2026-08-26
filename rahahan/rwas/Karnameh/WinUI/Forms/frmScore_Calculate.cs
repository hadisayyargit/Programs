using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.BusinessRules;
using RWAS.Common;
using ProgLib.Configuration.Event;
using ProgLib.Configuration;

namespace RWAS.WinUI
{
    public partial class frmScore_Calculate : Form
    {

        public frmScore_Calculate()
        {
            InitializeComponent();
        }

        void ClearForm()
        {
            faDatePickerScoreDate.Text = Program.m_strCurrentPDate;
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Text = "آماده محاسبه";
        }

        private void FindPersonelName(string strPersonelID)
        {
            DS_Personel objDSPersonelLocal;

            try
            {
                clsBRPersonel objBRPersonel = new clsBRPersonel();

                objDSPersonelLocal = objBRPersonel.IsExPersonel2(Convert.ToInt32(strPersonelID));

                if (objDSPersonelLocal.Prs_Sp_Sel_Personel.Rows.Count == 0)
                {
                    ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 108), "آگاهی", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                DataRow[] drowSelect;
                int intUID;

                if (objDSPersonelLocal.Prs_Sp_Sel_Personel.Rows.Count != 0)
                {
                    intUID = Convert.ToInt32(txtUniqueCode.Text);

                    drowSelect = objDSPersonelLocal.Prs_Sp_Sel_Personel.Select("Prs_Fld_UniqueCode=" + intUID.ToString());

                    if (drowSelect.Length == 0)
                        return;

                    lblPersonelName.Text = drowSelect[0]["Prs_Fld_FullName"].ToString();
                }
            }
            catch (Exception ocException)
            {
                int intErrNo = (ocException is System.Data.SqlClient.SqlException) ? ((System.Data.SqlClient.SqlException)ocException).Number : 0;

                ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(Program.m_System, 34), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CLogManager.WriteLog(LogType.logError, Program.m_System, ocException.ToString(), CApplicationAssert.LineNumber, "FrmWorkBookRep");

            }
        }

        private void frmScore_Calculate_Load(object sender, EventArgs e)
        {
            clsBRComboHandler obkBRComboHandler = new clsBRComboHandler();

            DS_Region ocDS_Region = new DS_Region();
            ocDS_Region = obkBRComboHandler.getRegion();

            //dpHadiBusiness.FillRegionCombo(cboRegion);
            
            chkcboRegion.DropDownDataSource = ocDS_Region.Rws_Sp_Sel_All_Region;
            chkcboRegion.DropDownDisplayMember = "Rws_Fld_Describe";
            chkcboRegion.DropDownValueMember = "Rws_Fld_Code";

            ClearForm();

            if (Program.m_UserId.ToLower() != "admin")
            {
                chkcboRegion.Enabled = false;
                //chkcboRegion.SelectedValue = Program.m_UserRegion;
            }

        }

        private void frmScore_Calculate_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float nTotal = 0;

            try
            {
                Cursor = Cursors.WaitCursor;
                toolStripStatusLabel1.Text = "در حال محاسبه...";
                
                if (CommonClass.GetDateValue(faDatePickerScoreDate.Text) == 0)
                {
                    Cursor = Cursors.Default;

                    MessageBox.Show("تاریخ محاسبه را وارد نمایید");
                    toolStripStatusLabel1.Text = "آماده محاسبه";
                    return;
                }              

                if (rdoPersonnel.Checked)
                {
                    if (lblPersonelName.Text == "")
                    {
                        Cursor = Cursors.Default;

                        MessageBox.Show("نام پرسنل را وارد نمایید");
                        toolStripStatusLabel1.Text = "آماده محاسبه";
                        return;
                    }

                    float nScore_Training = 0, nScore_Accident = 0, nScore_Encouragement = 0, nScore_Chastise = 0, nScore_Total = 0;
                    float nScore_Training_Negative = 0, nScore_Accident_Negative = 0, nScore_Encouragement_Negative = 0, nScore_Chastise_Negative = 0, nScore_Total_Negative = 0;
                    
                    string strDate = CommonClass.GetDateWithoutSlash(faDatePickerScoreDate.Text);
                    int myUniqueCode = int.Parse(txtUniqueCode.Text);


                    Score objScore = new Score();

                    nScore_Training = objScore.GetTotalScore_Training(myUniqueCode, strDate);
                    nScore_Accident = objScore.GetTotalScore_Accident(myUniqueCode, strDate);
                    nScore_Encouragement = objScore.GetTotalScore_Encouragement(myUniqueCode, strDate);
                    nScore_Chastise = objScore.GetTotalScore_Chastise(myUniqueCode, strDate);
                    nScore_Total = nScore_Training + nScore_Accident + nScore_Encouragement + nScore_Chastise;

                    nScore_Training_Negative = 0;
                    nScore_Accident_Negative = objScore.GetTotalScore_Accident_Negative(myUniqueCode, strDate);
                    nScore_Encouragement_Negative = 0;
                    nScore_Chastise_Negative = objScore.GetTotalScore_Chastise_Negative(myUniqueCode, strDate);
                    nScore_Total_Negative = nScore_Training_Negative + nScore_Accident_Negative + nScore_Encouragement_Negative + nScore_Chastise_Negative;

                    nTotal = nScore_Total - nScore_Total_Negative;

                    objScore.dbInsert(myUniqueCode, strDate, nScore_Accident - nScore_Accident_Negative, nScore_Training - nScore_Training_Negative, nScore_Encouragement - nScore_Encouragement_Negative, nScore_Chastise - nScore_Chastise_Negative);

                    Cursor = Cursors.Default;
                    toolStripStatusLabel1.Text = "امتیاز = " + nTotal.ToString();

                }
                else
                {

                    DataView dvPersonnel;
                    if (Program.m_UserId.ToLower() == "admin")
                    {
                        if (rdoRegion.Checked && chkcboRegion.CheckedItems == null)
                        {
                            Cursor = Cursors.Default;

                            MessageBox.Show("ناحیه را انتخاب نمایید");
                            ClearForm();
                            return;
                        }
                        //dvPersonnel = dpHadiBusiness.GetPersonnelOfRegions(new object[1] { chkcboRegion.CheckedValues });
                        dvPersonnel = dpHadiBusiness.GetPersonnelOfRegions( chkcboRegion.CheckedValues );
                    }

                    else
                        dvPersonnel = dpHadiBusiness.GetPersonnelOfRegions(new object[1] { Program.m_UserRegion });
                    
                    toolStripProgressBar1.Minimum = 0;
                    toolStripProgressBar1.Maximum = dvPersonnel.Count;

                    for (int i = 0; i < dvPersonnel.Count; i++)
                    {
                        toolStripProgressBar1.Value = i + 1;
                        statusStrip1.Refresh();


                        float nScore_Training = 0, nScore_Accident = 0, nScore_Encouragement = 0, nScore_Chastise = 0, nScore_Total = 0;
                        float nScore_Training_Negative = 0, nScore_Accident_Negative = 0, nScore_Encouragement_Negative = 0, nScore_Chastise_Negative = 0, nScore_Total_Negative = 0;
                        string strDate = CommonClass.GetDateWithoutSlash(faDatePickerScoreDate.Text);
                        int myUniqueCode = Convert.ToInt32(dvPersonnel[i]["Prs_Fld_UniqueCode"]);


                        Score objScore = new Score();

                        nScore_Training = objScore.GetTotalScore_Training(myUniqueCode, strDate);
                        nScore_Accident = objScore.GetTotalScore_Accident(myUniqueCode, strDate);
                        nScore_Encouragement = objScore.GetTotalScore_Encouragement(myUniqueCode, strDate);
                        nScore_Chastise = objScore.GetTotalScore_Chastise(myUniqueCode, strDate);
                        nScore_Total = nScore_Training + nScore_Accident + nScore_Encouragement + nScore_Chastise;

                        nScore_Training_Negative = 0;
                        nScore_Accident_Negative = objScore.GetTotalScore_Accident_Negative(myUniqueCode, strDate);
                        nScore_Encouragement_Negative = 0;
                        nScore_Chastise_Negative = objScore.GetTotalScore_Chastise_Negative(myUniqueCode, strDate);
                        nScore_Total_Negative = nScore_Training_Negative + nScore_Accident_Negative + nScore_Encouragement_Negative + nScore_Chastise_Negative;

                        nTotal = nScore_Total - nScore_Total_Negative;

                        objScore.dbInsert(myUniqueCode, strDate, nScore_Accident - nScore_Accident_Negative, nScore_Training - nScore_Training_Negative, nScore_Encouragement - nScore_Encouragement_Negative, nScore_Chastise - nScore_Chastise_Negative);
                        
                        
                    }
                    toolStripStatusLabel1.Text = "محاسبه انجام شد";
                    Cursor = Cursors.Default;
                    
                    //MessageBox.Show("امتیاز = " + nTotal.ToString
                     
                     
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
                toolStripStatusLabel1.Text = "خطا در محاسبه";
            }
        }

        private void rdoRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.m_UserId.ToLower() == "admin")
                chkcboRegion.Enabled = rdoRegion.Checked;

            ClearForm();
        }

        private void rdoPersonnel_CheckedChanged(object sender, EventArgs e)
        {
            gbUID.Enabled = rdoPersonnel.Checked;
            ClearForm();
        }

        private void btnUniqueCode_Click(object sender, EventArgs e)
        {
            int nUniquecode = 0;
            string strFirstName = "", strLastName = "";
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (txtUniqueCode.Text == "")
                {
                    frmPersonnelSearch objChild = new frmPersonnelSearch();
                    objChild.ShowDialog(this);

                    nUniquecode = objChild.PersonUniqueCode;
                    strFirstName = objChild.PersonFirstName;
                    strLastName = objChild.PersonLastName;
                }
                else
                {
                    nUniquecode = int.Parse(txtUniqueCode.Text);

                    DataView dvPersonnel = dpHadiBusiness.SearchPersonnel(nUniquecode);

                    if (dvPersonnel.Count > 0)
                    {
                        strFirstName = dvPersonnel[0]["Prs_Fld_FirstName"].ToString();
                        strLastName = dvPersonnel[0]["Prs_Fld_LastName"].ToString();
                    }
                }

                //txtUniqueCode.Text = "";
                lblPersonelName.Text = "";

                if (nUniquecode != 0)
                {
                    int nRegion = dpHadiBusiness.GetLastRegion(nUniquecode);
                    if (Program.m_UserId.ToLower() != "admin" && nRegion != Program.m_UserRegion)
                    {
                        this.Cursor = Cursors.Default;
                        System.Windows.Forms.MessageBox.Show("پرسنل مورد نظر تعریف نشده و یا در ناحیه شما نمی باشد");

                    }
                    else
                    {
                        lblPersonelName.Text = strFirstName + " " + strLastName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

        private void txtUniqueCode_TextChanged(object sender, EventArgs e)
        {
            lblPersonelName.Text = "";
        }

        private void faDatePickerScoreDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {


        }
    }
}
