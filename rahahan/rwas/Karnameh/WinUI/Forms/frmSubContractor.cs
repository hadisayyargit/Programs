using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.BusinessRules;

namespace RWAS.WinUI
{
    public partial class frmSubContractor : Form
    {
        public frmSubContractor()
        {
            InitializeComponent();
        }

        DataView m_dvMaster = new DataView();


        void clearBoxes()
        {
            txtCode.Clear();
            txtName.Clear();
        }

        void showContent(int nRow)
        {
            txtCode.Text = grdMaster["colCode", nRow].Value.ToString();
            txtName.Text = grdMaster["colName", nRow].Value.ToString();
        }

        private bool Prevalidation()
        {
            bool bRes = true;

            errorProvider1.Clear();

            if (Program.m_PrgMod != Program.PrgMod.NewRecord)
            {
                if (txtCode.Text.Length == 0)
                {
                    Cursor = Cursors.Default;
                    errorProvider1.SetError(txtCode, "کد را وارد نماييد");
                    bRes = false;
                    return bRes;
                }
            }

            if (txtName.Text.Length == 0)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(txtName, "عنوان را وارد نماييد");
                bRes = false;
                return bRes;
            }

            return (bRes);
        }

        private int getGridRowIndex(string strKey)
        {
            int i;
            int res = -1;

            for (i = 0; i < grdMaster.Rows.Count; i++)
            {
                if (grdMaster["colCode", i].Value != null && grdMaster["colCode", i].Value.ToString() == strKey)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }

        private void RefreshData()
        {

            m_dvMaster = SubContractor.GetAllSubContractors();
            grdMaster.DataSource = m_dvMaster;

            clearBoxes();
            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        void InsertData()
        {
            string strRes = "";
            SubContractor objSubContractor = new SubContractor();

            objSubContractor.SubContractorName = txtName.Text;

            strRes = objSubContractor.dbInsert();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (strRes.Contains("duplicate"))
                    MessageBox.Show("خطا در اضافه\n" + "اطلاعات تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("خطا در اضافه\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshData();
        }

        void UpdateData()
        {
            string strRes = "";
            SubContractor objSubContractor = new SubContractor();

            objSubContractor.SubContractorCode = int.Parse( txtCode.Text);
            objSubContractor.SubContractorName = txtName.Text;

            strRes = objSubContractor.dbUpdate();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (strRes.Contains("duplicate"))
                    MessageBox.Show("خطا در اضافه\n" + "اطلاعات تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    MessageBox.Show("خطا در ویرایش\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshData();
        }

        void deleteData(int nSubContractorCode)
        {
            string strRes = "";
            SubContractor objSubContractor = new SubContractor();

            objSubContractor.SubContractorCode = nSubContractorCode;

            try
            {
                strRes = objSubContractor.dbDelete();
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


        private void frmSubContractor_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;
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
            txtCode.Focus();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdMaster.CurrentRow != null)
            //if (grdMaster.Rows.Count > 0)
            {
                DialogResult dlgRes = MessageBox.Show("آيا اطلاعات اين ركورد حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgRes == DialogResult.Yes)
                {
                    deleteData(int.Parse( grdMaster["colCode", grdMaster.CurrentRow.Index].Value.ToString()));
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
                Program.m_PrgMod = Program.PrgMod.NewRecord;

            if (Prevalidation())
            {
                if (Program.m_PrgMod == Program.PrgMod.NewRecord)
                {
                    InsertData();
                }

                else
                {
                    UpdateData();
                }
            }    

        }

        private void grdMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
