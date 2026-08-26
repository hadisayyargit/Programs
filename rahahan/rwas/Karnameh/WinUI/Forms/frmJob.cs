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
    public partial class frmJob : Form
    {
        public frmJob()
        {
            InitializeComponent();
        }

        DataTable m_dtJob = new DataTable();
        DataView m_dvJob = new DataView();


        void clearBoxes()
        {
            txtCode.Clear();
            txtName.Clear();
        }

        void showContent(int nRow)
        {
            txtCode.Text = grdMaster["colJobId", nRow].Value.ToString();
            txtName.Text = grdMaster["colJobName", nRow].Value.ToString();
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
                if (grdMaster["colJobId", i].Value != null && grdMaster["colJobId", i].Value.ToString() == strKey)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }

        private void RefreshData()
        {

            m_dtJob = dpHadiBusiness.GetJobs();
            m_dvJob = new DataView(m_dtJob);
            grdMaster.DataSource = m_dvJob;

            clearBoxes();
            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        void InsertData()
        {
            string strRes = "";
            Job objJob = new Job();

            objJob.JobId = txtCode.Text;
            objJob.JobName = txtName.Text;
            objJob.JobGroup = "RWAS";

            strRes = objJob.dbInsert();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در اضافه\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();
        }

        void UpdateData()
        {
            string strRes = "";
            Job objJob = new Job();

            objJob.JobId = txtCode.Text;
            objJob.JobName = txtName.Text;
            objJob.JobGroup = "RWAS";

            strRes = objJob.dbUpdate();
            if (strRes == "")
                MessageBox.Show("اطلاعات با موفقيت ویرایش شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("خطا در ویرایش\n" + strRes, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);


            RefreshData();
        }

        void deleteData(string strJobId)
        {
            string strRes = "";
            Job objJob = new Job();

            objJob.JobId = strJobId;

            try
            {
                strRes = objJob.dbDelete();
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

        private void frmJob_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdMaster.CurrentRow != null)
            //if (grdMaster.Rows.Count > 0)
            {
                DialogResult dlgRes = MessageBox.Show("آيا اطلاعات اين ركورد حذف شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgRes == DialogResult.Yes)
                {
                    deleteData(grdMaster["colJobId", grdMaster.CurrentRow.Index].Value.ToString());
                }
            }
        }

 
        private void txtCode_Leave(object sender, EventArgs e)
        {
            int i = getGridRowIndex(txtCode.Text);
            if (i < 0)
            {
                Program.m_PrgMod = Program.PrgMod.NewRecord;
                txtName.Clear();
            }
            else
            {
                Program.m_PrgMod = Program.PrgMod.Normal;
                grdMaster.CurrentCell = grdMaster["colJobId", i];
                showContent(i);
            }
            
        }

        private void grdMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                showContent(e.RowIndex);
            }
            catch
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.NewRecord;
            clearBoxes();
            txtCode.Focus();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
