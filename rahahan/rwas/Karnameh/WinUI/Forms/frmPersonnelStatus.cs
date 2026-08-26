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

namespace RWAS.WinUI
{
    public partial class frmPersonnelStatus : Form
    {
        public int m_nUniqueCode=0;
        DataView m_dvMaster = new DataView();
        int nRow = 0;
        bool m_IsPreferment=false;
        private bool blnIns;
        private bool blnUpd;
        private bool blnDel;

        public frmPersonnelStatus()
        {
            InitializeComponent();
        }

        public frmPersonnelStatus(int UniqueCode, bool ispreferment)
        {
            InitializeComponent();
            m_nUniqueCode = UniqueCode;
            txtUniqueCode.Text = m_nUniqueCode.ToString();
            m_IsPreferment = ispreferment;
        }
        private void getUserFormAccessRight()
        {
            if (Program.m_UserId.ToLower() == "admin")
            {
                blnIns = true;
                blnUpd = true;
                blnDel = true;
            }
            else
            {
                if (m_IsPreferment)
                {
                    CommonClass.m_dtUserAccess.DefaultView.RowFilter = "ObjectId='KARNAMEH_FrmPrefermentHistory'";
                    CommonClass.m_dtGroupAccess.DefaultView.RowFilter = "ObjectId='KARNAMEH_FrmPrefermentHistory'";
                }
                else
                {
                    CommonClass.m_dtUserAccess.DefaultView.RowFilter = "ObjectId='KARNAMEH_frmPersonnelStatus'";
                    CommonClass.m_dtGroupAccess.DefaultView.RowFilter = "ObjectId='KARNAMEH_frmPersonnelStatus'";
                }

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
        }

        private void EditPermited()
        {
            btnNew.Enabled = blnIns;
            btnDelete.Enabled = blnDel;
            btnSave.Enabled = (blnIns || blnUpd);
        }

        void clearBoxes()
        {
            txtRow.Clear();
            faDatePickerBeginDate.ResetSelectedDateTime();
            faDatePickerEndDate.ResetSelectedDateTime();
            if (m_IsPreferment)
                cboJobStatus.SelectedValue = 0;
            else
                cboJobStatus.SelectedIndex = -1;

            //cboRegion.SelectedIndex = -1;
        }

        void showContent()
        {            
            txtRow.Text = grdMaster["colRow", nRow].Value.ToString();
            faDatePickerBeginDate.Text = CommonClass.GetDateWithSlash(grdMaster["colBeginDate", nRow].Value.ToString());
            faDatePickerEndDate.Text = CommonClass.GetDateWithSlash(grdMaster["colEndDate", nRow].Value.ToString());
            cboJobStatus.SelectedValue= grdMaster["colJobStatusId", nRow].Value.ToString();
            cboJob.SelectedValue = grdMaster["colJobId", nRow].Value.ToString();
            cboRegion.SelectedValue = grdMaster["colRegionCode", nRow].Value.ToString();
        }

        private bool Prevalidation()
        {
            bool bRes = true;

            errorProvider1.Clear();

            if (txtRow.Text == "")
                Program.m_PrgMod = Program.PrgMod.NewRecord; 

            if (cboJobStatus.SelectedValue == null)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(cboJobStatus, "وضعیت شغلی را وارد نماييد");
                bRes = false;
                return bRes;
            }


            if (!m_IsPreferment && cboRegion.Text.Length == 0)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(cboRegion, "ناحیه را انتخاب نماييد");
                bRes = false;
                return bRes;
            }

            int nBeginDate, nEndDate, nEmployeeDate;
            nBeginDate=CommonClass.GetDateValue(faDatePickerBeginDate.Text);
            nEndDate=CommonClass.GetDateValue(faDatePickerEndDate.Text);
            string strEmployeeDate = dpHadiBusiness.GetPersonnelEmployeeDate(int.Parse(txtUniqueCode.Text));

            nEmployeeDate=CommonClass.GetDateValue(strEmployeeDate);

            if (nBeginDate>0 && nEndDate>0 && nEndDate < nBeginDate)
            {
                ProgLib.Components.MessageBox.Show("بازه های تاریخ نامعتبرند", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                faDatePickerEndDate.Focus();
                return false;
            }


            if (nBeginDate > 0 && nEmployeeDate > 0 && nBeginDate < nEmployeeDate)
            {
                ProgLib.Components.MessageBox.Show("تاریخ شروع نمی تواند قبل از تاریخ استخدام باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                faDatePickerBeginDate.Focus();
                return false;
            }

            if (nEndDate > 0 && nEmployeeDate>0  && nEndDate < nEmployeeDate)
            {
                ProgLib.Components.MessageBox.Show("تاریخ پایان نمی تواند قبل از تاریخ استخدام باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                faDatePickerEndDate.Focus();
                return false;
            }

            return (bRes);
        }

        private int getGridRowIndex(string strKey1, string strKey2)
        {
            int i;
            int res = -1;

            for (i = 0; i < grdMaster.Rows.Count; i++)
            {

                if (grdMaster["colUniqueCode", i].Value != null && grdMaster["colUniqueCode", i].Value.ToString() == strKey1 && grdMaster["colRow", i].Value != null && grdMaster["colRow", i].Value.ToString() == strKey2)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }


        private void RefreshData()
        {
            PersonnelStatus objPersonnelJobStatus = new PersonnelStatus();
            clearBoxes();

            objPersonnelJobStatus.UniqueCode = m_nUniqueCode;
           
            m_dvMaster = objPersonnelJobStatus.GetPersonnelJobStatusOfPersonnel(m_IsPreferment);
            grdMaster.DataSource = m_dvMaster;
            
            Program.m_PrgMod = Program.PrgMod.Normal;

        }

        void InsertData()
        {
            string strRes = "";
            PersonnelStatus objPersonnelJobStatus = new PersonnelStatus();

            objPersonnelJobStatus.UniqueCode = m_nUniqueCode;
            //objPersonnelJobStatus.Row = byte.Parse(txtRow.Text);
            objPersonnelJobStatus.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBeginDate.Text);
            objPersonnelJobStatus.EndDate = CommonClass.GetDateWithoutSlash(faDatePickerEndDate.Text);
            objPersonnelJobStatus.JobStatusId = byte.Parse(cboJobStatus.SelectedValue.ToString());
            objPersonnelJobStatus.RegionCode = int.Parse(cboRegion.SelectedValue.ToString());
            if (cboJob.SelectedValue != null)
                objPersonnelJobStatus.JobId = cboJob.SelectedValue.ToString();

            strRes = objPersonnelJobStatus.dbInsert();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در اضافه\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();

            nRow = getGridRowIndex(objPersonnelJobStatus.UniqueCode.ToString(),objPersonnelJobStatus.Row.ToString());
            if (nRow >= 0)
            {
                grdMaster.CurrentCell = grdMaster["colRow",nRow];
                grdMaster.Rows[nRow].Selected = true;
                showContent();
            }
        }

        void UpdateData()
        {
            try
            {
                string strRes = "";
                PersonnelStatus objPersonnelJobStatus = new PersonnelStatus();

                objPersonnelJobStatus.UniqueCode = m_nUniqueCode;
                objPersonnelJobStatus.Row = byte.Parse(txtRow.Text);
                objPersonnelJobStatus.BeginDate = CommonClass.GetDateWithoutSlash(faDatePickerBeginDate.Text);
                objPersonnelJobStatus.EndDate = CommonClass.GetDateWithoutSlash(faDatePickerEndDate.Text);
                objPersonnelJobStatus.JobStatusId = byte.Parse(cboJobStatus.SelectedValue.ToString());
                objPersonnelJobStatus.RegionCode = int.Parse(cboRegion.SelectedValue.ToString());

                if (cboJob.SelectedValue != null)
                    objPersonnelJobStatus.JobId = cboJob.SelectedValue.ToString();

                strRes = objPersonnelJobStatus.dbUpdate();
                if (strRes == "")
                    MessageBox.Show("اطلاعات با موفقيت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("خطا در ویرایش\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


                RefreshData();

                grdMaster.CurrentCell = grdMaster["colBeginDate", nRow];
                grdMaster.Rows[nRow].Selected = true;
                showContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void deleteData(byte nRow1)
        {
            string strRes = "";
            PersonnelStatus objPersonnelJobStatus = new PersonnelStatus();

            objPersonnelJobStatus.UniqueCode = m_nUniqueCode;
            objPersonnelJobStatus.Row = nRow1;

            try
            {
                strRes = objPersonnelJobStatus.dbDelete();
            }

            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            if (strRes == "")
            {
                MessageBox.Show("اطلاعات با موفقيت حذف شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (strRes.Contains("REFERENCE"))
            {
                MessageBox.Show("حذف انجام نشد. اطلاعات مرتبط در جداول ديگر وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("خطا در حذف\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshData();
            
        }


        private void frmPersonnelStatus_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;


            DataView dvJobStatus = new DataView();
            dvJobStatus = dpHadiBusiness.GetJobStatuses();
            cboJobStatus.DataSource = dvJobStatus;
            cboJobStatus.DisplayMember = "Pname";
            cboJobStatus.ValueMember = "JobStatusId";
            
            DS_Region ocDS_Region = new DS_Region();
            clsBRComboHandler objBRComboHandler = new clsBRComboHandler();
            ocDS_Region = objBRComboHandler.getRegion();
            cboRegion.DataSource = ocDS_Region.Rws_Sp_Sel_All_Region;
            cboRegion.DisplayMember = "Rws_Fld_Describe";
            cboRegion.ValueMember = "Rws_Fld_Code";

            if (m_IsPreferment)
            {
                cboJobStatus.Enabled = false;
                cboJobStatus.SelectedValue = 0;
                cboJob.Enabled = true;
                cboRegion.Enabled = false;
                cboRegion.SelectedValue = dpHadiBusiness.GetLastRegion(m_nUniqueCode);
                this.BackColor = System.Drawing.Color.PowderBlue;
                dpHadiBusiness.FillJobCombo(cboJob);
                this.Text = "ارتقاء شغلی";
            }

            else
            {
                this.Text = "وضعیت شغلی";
                cboJob.Enabled = false;
            }

            RefreshData();

            getUserFormAccessRight();
            EditPermited();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Prevalidation())
            {
                if (Program.m_PrgMod == Program.PrgMod.NewRecord)
                {
                    if (blnIns)
                        InsertData();
                    else
                        MessageBox.Show("اجازه افزودن ندارید");
                }

                else
                {
                    if (blnUpd)
                        UpdateData();
                    else
                        MessageBox.Show("اجازه ویرایش ندارید");
                }
            }    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.NewRecord;
            clearBoxes();
            txtUniqueCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdMaster.CurrentRow != null)
            //if (grdMaster.Rows.Count > 0)
            {
                DialogResult dlgRes = MessageBox.Show("آيا اطلاعات اين ركورد حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgRes == DialogResult.Yes)
                {
                    deleteData(Convert.ToByte(grdMaster["colRow", grdMaster.CurrentRow.Index].Value.ToString()));
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            /*
            nRow = getGridRowIndex(txtUniqueCode.Text,);
            if (nRow < 0)
            {
                Program.m_PrgMod = Program.PrgMod.NewRecord;
                txtRow.Clear();
            }
            else
            {
                Program.m_PrgMod = Program.PrgMod.Normal;
                grdMaster.CurrentCell = grdMaster["colCode", nRow];
                grdMaster.Rows[nRow].Selected = true;
                showContent();
            }            
            */

        }


        //private void txtRow_Leave(object sender, EventArgs e)
        //{
        //    nRow = getGridRowIndex(txtUniqueCode.Text,txtRow.Text);
        //    if (nRow < 0)
        //    {
        //        Program.m_PrgMod = Program.PrgMod.NewRecord;
        //        //clearBoxes();
        //    }
        //    else
        //    {
        //        Program.m_PrgMod = Program.PrgMod.Normal;
        //        grdMaster.CurrentCell = grdMaster["colRow", nRow];
        //        grdMaster.Rows[nRow].Selected = true;
        //        showContent();
        //    }            

        //}       

        private void grdMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.m_PrgMod = Program.PrgMod.Normal;
                nRow = e.RowIndex;
                showContent();
            }
            catch
            {
            }
    
        }

     
    
    }
}
