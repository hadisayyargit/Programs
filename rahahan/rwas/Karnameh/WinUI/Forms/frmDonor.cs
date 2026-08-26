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
    public partial class frmDonor : Form
    {
        public frmDonor()
        {
            InitializeComponent();
        }

        DataView m_dvMaster = new DataView();
        int nRow = 0;

        void clearBoxes()
        {
            txtCode.Clear();
            txtName.Clear();
        }

        void showContent()
        {
            txtCode.Text = grdMaster["colCode", nRow].Value.ToString();
            txtName.Text = grdMaster["colDescribe", nRow].Value.ToString();
        }

        private bool Prevalidation()
        {
            bool bRes = true;

            errorProvider1.Clear();
            if (txtCode.Text.Length == 0)
            {
                Cursor = Cursors.Default;
                errorProvider1.SetError(txtCode, "کد را وارد نماييد");
                bRes = false;
                return bRes;
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

            m_dvMaster = Donor.GetDonor();
            grdMaster.DataSource = m_dvMaster;

            clearBoxes();
            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        void InsertData()
        {
            string strRes = "";
            Donor objDonor = new Donor();

            objDonor.DonorId = Convert.ToInt16(txtCode.Text);
            objDonor.Pname = txtName.Text;

            strRes = objDonor.dbInsert();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در اضافه\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();

            nRow = getGridRowIndex(objDonor.DonorId.ToString());
            if (nRow >= 0)
            {
                grdMaster.CurrentCell = grdMaster["colCode",nRow];
                grdMaster.Rows[nRow].Selected = true;
                showContent();
            }
        }

        void UpdateData()
        {
            string strRes = "";
            Donor objDonor = new Donor();            

            objDonor.DonorId = Convert.ToInt16(txtCode.Text);
            objDonor.Pname = txtName.Text;

            strRes = objDonor.dbUpdate();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در ویرایش\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();

            grdMaster.CurrentCell = grdMaster["colCode",nRow];
            grdMaster.Rows[nRow].Selected=true;
            showContent();

        }

        void deleteData(short nDonor)
        {
            string strRes = "";
            Donor objDonor = new Donor();

            objDonor.DonorId = nDonor;

            try
            {
                strRes = objDonor.dbDelete();
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


        private void frmDonor_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;
            RefreshData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                    deleteData(Convert.ToInt16(grdMaster["colCode", grdMaster.CurrentRow.Index].Value.ToString()));
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            nRow = getGridRowIndex(txtCode.Text);
            if (nRow < 0)
            {
                Program.m_PrgMod = Program.PrgMod.NewRecord;
                txtName.Clear();
            }
            else
            {
                Program.m_PrgMod = Program.PrgMod.Normal;
                grdMaster.CurrentCell = grdMaster["colCode", nRow];
                grdMaster.Rows[nRow].Selected = true;
                showContent();
            }            

        }

        private void grdMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
