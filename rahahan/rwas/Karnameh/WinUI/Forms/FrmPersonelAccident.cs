using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ProgLib;
using ProgLib.Configuration;
using ProgLib.Configuration.Login;
using ProgLib.Configuration.Event;
using RWAS.Common;
using RWAS.BusinessRules;
using System.Globalization;

namespace RWAS.WinUI
{
    public partial class FrmPersonelAccident : Form
    {
        
        int m_nUinqueCode;
        DataView m_dvMaster = new DataView();
        int nRow = 0;

        void showContent()
        {
            
            txtAccidentDate.Text = CommonClass.GetDateWithSlash(grdMaster["colAccidentDate", nRow].Value.ToString());
            txtDescribe.Text = grdMaster["colAccidentKind", nRow].Value.ToString();
            txtReason.Text = grdMaster["colAccidentReason", nRow].Value.ToString();
            txtForefit.Text = grdMaster["colForefitKind", nRow].Value.ToString();
            txtAccidentDegree.Text = grdMaster["colAccidentDegree", nRow].Value.ToString();
            txtAccidentLocation.Text = grdMaster["colAccidentLocation", nRow].Value.ToString();
        }

        private void RefreshData()
        {

            m_dvMaster = dpHadiBusiness.GetPersonnelAccidents(m_nUinqueCode);
            grdMaster.DataSource = m_dvMaster;

            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        public FrmPersonelAccident()
        {
            InitializeComponent();
        }

        public FrmPersonelAccident(int myUinqueCode)
        {
            InitializeComponent();


            m_nUinqueCode = myUinqueCode;

        }

        private void FrmPersonelAccident_Load(object sender, EventArgs e)
        {
            //strCurrentDate = Program.m_strCurrentPDateNoneSlash;
            RefreshData();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void grdMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nRow = e.RowIndex;
            showContent();
        }
    }
}
