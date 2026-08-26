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
    public partial class frmTrainingTerm : Form
    {
        public frmTrainingTerm()
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

            m_dvMaster = TrainingTerm.GetTrainingTerm();
            grdMaster.DataSource = m_dvMaster;

            clearBoxes();
            Program.m_PrgMod = Program.PrgMod.Normal;
        }
        
        private void frmTrainingTerm_Load(object sender, EventArgs e)
        {
            Program.m_PrgMod = Program.PrgMod.Normal;
            RefreshData();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
