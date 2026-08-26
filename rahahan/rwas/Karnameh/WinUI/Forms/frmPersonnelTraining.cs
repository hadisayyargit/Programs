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

namespace RWAS.WinUI
{
    public partial class frmPersonnelTraining : Form
    {
        int m_nUniquecode = 0;

        public frmPersonnelTraining()
        {
            InitializeComponent();
        }

        public frmPersonnelTraining(int nUniquecode)
        {
            m_nUniquecode = nUniquecode;
            InitializeComponent();
        }

        DataView m_dvMaster = new DataView();
        private bool m_bUpd;

        void clearBoxes()
        {
            txtTermCode.Clear();
            txtLocation.Clear();
            txtDegree.Clear();
            txtTermName.Clear();
        }

        void showContent(int nRow)
        {
            txtTermCode.Text = grdMaster["colTermCode", nRow].Value.ToString();
            txtTermName.Text = grdMaster["colTermName", nRow].Value.ToString();
            txtLocation.Text = grdMaster["colLocation", nRow].Value.ToString();
            txtDegree.Text = grdMaster["colDegree", nRow].Value.ToString();
            
        }

        private void getUserFormAccessRight()
        {
            if (Program.m_UserId.ToLower() == "admin")
            {
                m_bUpd = true;
                return;
            }

            CommonClass.m_dtUserAccess.DefaultView.RowFilter = "ObjectId='" + Common.CommonClass.m_ApplicationId + "_" + this.Name + "'";
            CommonClass.m_dtGroupAccess.DefaultView.RowFilter = "ObjectId='" + Common.CommonClass.m_ApplicationId + "_" + this.Name + "'";


            if (CommonClass.m_dtUserAccess.DefaultView.Count > 0)
                m_bUpd = (bool)CommonClass.m_dtUserAccess.DefaultView[0]["GrantUpdate"];

            else if (CommonClass.m_dtGroupAccess.DefaultView.Count > 0)
                m_bUpd = (bool)CommonClass.m_dtGroupAccess.DefaultView[0]["GrantUpdate"];

            else
                m_bUpd = false;
        }

        private bool Prevalidation()
        {
            bool bRes = true;

            errorProvider1.Clear();

            if (txtTermCode.Text.Length == 0)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(txtTermCode, "کد را وارد نماييد");
                bRes = false;
                return bRes;
            }

            if (txtLocation.Text.Length == 0 && txtDegree.Text.Length==0)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(txtLocation, "محل دوره یا نمره را وارد نماييد");
                bRes = false;
                return bRes;
            }

            if (txtDegree.Text.Length > 0)
            {
                try
                {
                    byte n1 = byte.Parse(txtDegree.Text);
                }

                catch
                {
                    errorProvider1.SetError(txtDegree, "نمره را به شکل عدد وارد کنید");
                    bRes = false;
                }
            }

            return (bRes);
        }

        private int getGridRowIndex(string strKey)
        {
            int i;
            int res = -1;

            for (i = 0; i < grdMaster.Rows.Count; i++)
            {
                if (grdMaster["colRow", i].Value != null && grdMaster["colRow", i].Value.ToString() == strKey)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }

        private void RefreshData()
        {
            PersonnelTraining objPersonnelTraining = new PersonnelTraining();
            objPersonnelTraining.UniqueCode = m_nUniquecode;
            m_dvMaster = objPersonnelTraining.GetPersonnelTrainingOfPersonnel();
            //m_dvMaster = PersonnelTraining.GetPersonnelTraining();
            grdMaster.DataSource = m_dvMaster;

            clearBoxes();
            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        void InsertData()
        {
            string strRes = "";
            PersonnelTraining objPersonnelTraining = new PersonnelTraining();

            objPersonnelTraining.Row = byte.Parse(grdMaster["colRow", grdMaster.CurrentRow.Index].Value.ToString());
            objPersonnelTraining.UniqueCode = int.Parse(grdMaster["colUniquecode", grdMaster.CurrentRow.Index].Value.ToString());
            objPersonnelTraining.Rws_Fld_TrainingLocation = txtLocation.Text;
            try
            {
                objPersonnelTraining.Rws_Fld_Degree = Int16.Parse(txtDegree.Text);
            }
            catch
            {
            }

            strRes = objPersonnelTraining.dbInsert();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در اضافه\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            RefreshData();
        }

        void UpdateData()
        {
            string strRes = "";
            PersonnelTraining objPersonnelTraining = new PersonnelTraining();

            objPersonnelTraining.Row = byte.Parse(grdMaster["colRow", grdMaster.CurrentRow.Index].Value.ToString());
            objPersonnelTraining.UniqueCode = int.Parse(grdMaster["colUniquecode", grdMaster.CurrentRow.Index].Value.ToString());
            objPersonnelTraining.Rws_Fld_TrainingLocation = txtLocation.Text;
            try
            {
                objPersonnelTraining.Rws_Fld_Degree = Int16.Parse(txtDegree.Text);
            }
            catch
            {
                objPersonnelTraining.Rws_Fld_Degree = -1;
            }

            strRes = objPersonnelTraining.dbUpdate();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در ویرایش\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();
        }

        void deleteData()
        {
            string strRes = "";
            PersonnelTraining objPersonnelTraining = new PersonnelTraining();

            objPersonnelTraining.Row = byte.Parse(grdMaster["colRow", grdMaster.CurrentRow.Index].Value.ToString());
            objPersonnelTraining.UniqueCode = int.Parse(grdMaster["colUniquecode", grdMaster.CurrentRow.Index].Value.ToString());

            try
            {
                strRes = objPersonnelTraining.dbDelete();
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

        private void frmPersonnelTraining_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;
            getUserFormAccessRight();

            btnSave.Enabled = m_bUpd;
            RefreshData();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            Program.m_PrgMod = Program.PrgMod.NewRecord;
            clearBoxes();
            txtTermCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdMaster.CurrentRow != null)
            //if (grdMaster.Rows.Count > 0)
            {
                DialogResult dlgRes = MessageBox.Show("آيا اطلاعات اين ركورد حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgRes == DialogResult.Yes)
                {
                    deleteData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Prevalidation())
            {
                if (grdMaster["colDegree", grdMaster.CurrentRow.Index].Value == DBNull.Value && grdMaster["colLocation", grdMaster.CurrentRow.Index].Value == DBNull.Value)
                {
                    Program.m_PrgMod = Program.PrgMod.NewRecord;
                    InsertData();
                }

                else
                {
                    UpdateData();
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdMaster_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                showContent(grdMaster.CurrentRow.Index);
            }
            catch
            {
            }
        }

    }
}
