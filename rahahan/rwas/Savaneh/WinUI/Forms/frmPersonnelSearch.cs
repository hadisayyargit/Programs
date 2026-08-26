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

namespace RWAS.WinUI
{
    public partial class frmPersonnelSearch : Form
    {
        public int PersonUniqueCode = 0;
        public string PersonFirstName = "";
        public string PersonLastName = "";
        public int m_IsSubcontractor;

        public frmPersonnelSearch()
        {
            InitializeComponent();
            m_IsSubcontractor = -1;
        }

        public frmPersonnelSearch(int IsSubcontractor)
        {
            InitializeComponent();
            m_IsSubcontractor = IsSubcontractor;
        }

        private void frmPersonnelSearch_Load(object sender, EventArgs e)
        {
            try
            {
                Program.m_PrgMod = Program.PrgMod.FormLoading;
                FirstInitialize();
                Program.m_PrgMod = Program.PrgMod.Normal;
                btnClear.PerformClick();

                if (m_IsSubcontractor == 1)
                {
                    cboEmployeeStatus.Enabled = false;
                    cboEmployeeStatus.SelectedValue = Parameters._EmployeeStatus_Contract;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FirstInitialize()
        {
            clsBRSubContractor objBRSubContractor = new clsBRSubContractor();
            clsDSSubContractor objDSSubContractor = new clsDSSubContractor();

            try
            {
                dpHadiBusiness.FillRegionCombo(cboRegion);
                dpHadiBusiness.FillEmployeeStatusCombo(cboEmployeeStatus);
                dpHadiBusiness.FillJobCombo(cboJob);

                objDSSubContractor = objBRSubContractor.GetSubContractor();
                cboSubContractor.DataSource = objDSSubContractor.Rws_Sp_Sel_All_SubContractor;
                cboSubContractor.DisplayMember = clsDSSubContractor.Rws_Fld_Describe;
                cboSubContractor.ValueMember = clsDSSubContractor.Rws_Fld_Code;

                cboRegion.SelectedIndex = -1;
                cboJob.SelectedItem = null;
                cboEmployeeStatus.SelectedItem = null;
                cboSubContractor.SelectedIndex = -1;

                if (Program.m_UserId.ToLower() != "admin")
                {
                    cboRegion.Enabled = false;
                    cboRegion.SelectedValue = Program.m_UserRegion;
                }

            }
            catch
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboEmployeeStatus.SelectedIndex = -1;
            cboJob.SelectedIndex = -1;
            cboSubContractor.SelectedIndex = -1;

            cboEmployeeStatus.SelectedItem = null;
            cboJob.SelectedItem = null;
            cboSubContractor.SelectedItem = null;

            if (Program.m_UserId.ToLower() == "admin")
            {
                cboRegion.SelectedIndex = -1;
                cboRegion.SelectedItem = null;
            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNationalCode.Text = "";
            txtPersonelID.Text = "";
            txtPersonelID.Text = "";
            txtUniqueCode.Text = "";

            txtRowCount.Text = "0";
            //grdSearchPersonel.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dvPerson = new DataView();

            int nUniquecode, nRegion, nEmployeeStatus, nSubcontractor;
            string strJob;

            this.Cursor = Cursors.WaitCursor;

            try
            {
                nUniquecode = Int32.Parse(txtUniqueCode.Text);
            }
            catch
            {
                nUniquecode = 0;
            }

            try
            {
                nRegion = Int32.Parse(cboRegion.SelectedValue.ToString());
            }
            catch
            {
                nRegion = 0;
            }

            try
            {
                //if (m_IsSubcontractor==1)
                //  nEmployeeStatus = 0;
                //else
                nEmployeeStatus = Int32.Parse(cboEmployeeStatus.SelectedValue.ToString());
            }
            catch
            {
                nEmployeeStatus = 0;
            }

            try
            {
                nSubcontractor = Int32.Parse(cboSubContractor.SelectedValue.ToString());
            }
            catch
            {
                nSubcontractor = 0;
            }

            try
            {
                strJob = cboJob.SelectedValue.ToString();
            }
            catch
            {
                strJob = null;
            }


            dvPerson = dpHadiBusiness.SearchPersonnel(nUniquecode, txtFirstName.Text, txtLastName.Text, txtPersonelID.Text, nRegion, strJob, nEmployeeStatus, nSubcontractor, txtNationalCode.Text, m_IsSubcontractor);
            grdSearchPersonel.DataSource = dvPerson;
            txtRowCount.Text = grdSearchPersonel.Rows.Count.ToString();

            this.Cursor = Cursors.Default;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                PersonUniqueCode = Int32.Parse(grdSearchPersonel["colUniqueId", grdSearchPersonel.CurrentRow.Index].Value.ToString());
                PersonFirstName = grdSearchPersonel["colFirstName", grdSearchPersonel.CurrentRow.Index].Value.ToString();
                PersonLastName = grdSearchPersonel["colLastName", grdSearchPersonel.CurrentRow.Index].Value.ToString();
                
            }
            catch
            {
                PersonUniqueCode = 0;
                PersonFirstName = "";
                PersonLastName = "";
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PersonUniqueCode = 0;
            this.Close();
        }

        private void grdSearchPersonel_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
