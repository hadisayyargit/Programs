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
    public partial class frmViewData : Form
    {
        DataTable m_dtJob = new DataTable();
        DataView m_dataviewActiveJob = new DataView();
        DataView m_dataviewNonActiveJob = new DataView();

        DataTable m_dtEducation = new DataTable();
        DataView m_dataviewActiveEducation = new DataView();
        DataView m_dataviewNonActiveEducation = new DataView();

        public frmViewData()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {

            m_dtJob = dpHadiBusiness.GetJobs();

            m_dataviewActiveJob = new DataView(m_dtJob);
            m_dataviewActiveJob.RowFilter = "JobGroup='RWAS'";

            grdActiveJob.DataSource = m_dataviewActiveJob;            

            m_dataviewNonActiveJob = new DataView(m_dtJob);
            m_dataviewNonActiveJob.RowFilter= "JobGroup IS NULL";
            
            grdNonActiveJob.DataSource = m_dataviewNonActiveJob;


            m_dtEducation = dpHadiBusiness.GetStudyStatus();

            m_dataviewActiveEducation = new DataView(m_dtEducation);
            m_dataviewActiveEducation.RowFilter = "IsActive=1";

            grdActiveEducation.DataSource = m_dataviewActiveEducation;

            m_dataviewNonActiveEducation = new DataView(m_dtEducation);
            m_dataviewNonActiveEducation.RowFilter = "IsActive IS NULL OR IsActive=0";

            grdNonActiveEducation.DataSource = m_dataviewNonActiveEducation;
        }

        private void frmViewData_Load(object sender, EventArgs e)
        {

            RefreshData();

        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (grdNonActiveJob.CurrentRow != null)
            {
                try
                {
                    Job objJob = new Job();
                    objJob.JobId = grdNonActiveJob[colJobId.Name, grdNonActiveJob.CurrentRow.Index].Value.ToString();
                    objJob.JobName = grdNonActiveJob[colJobName.Name, grdNonActiveJob.CurrentRow.Index].Value.ToString();
                    objJob.JobGroup = "RWAS";
                    objJob.dbUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            RefreshData();
        }

        private void btnRemoveJob_Click(object sender, EventArgs e)
        {

            if (grdActiveJob.CurrentRow != null)
            {
                try
                {
                    Job objJob = new Job();
                    objJob.JobId = grdActiveJob[colJobId2.Name, grdActiveJob.CurrentRow.Index].Value.ToString();
                    objJob.JobName = grdActiveJob[colJobName2.Name, grdActiveJob.CurrentRow.Index].Value.ToString();
                    objJob.JobGroup = null;
                    objJob.dbUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            RefreshData();

        }

        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            if (grdNonActiveEducation.CurrentRow != null)
            {
                try
                {
                    EducationDegree objEducationDegree = new EducationDegree();
                    objEducationDegree.EducationCode = int.Parse(grdNonActiveEducation[colEducationCode.Name, grdNonActiveEducation.CurrentRow.Index].Value.ToString());
                    objEducationDegree.IsActive =true;
                    objEducationDegree.dbUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            RefreshData();
        }

        private void btnRemoveEducation_Click(object sender, EventArgs e)
        {
            if (grdActiveEducation.CurrentRow != null)
            {
                try
                {
                    EducationDegree objEducationDegree = new EducationDegree();
                    objEducationDegree.EducationCode = int.Parse(grdActiveEducation[colEducationCode2.Name, grdActiveEducation.CurrentRow.Index].Value.ToString());
                    objEducationDegree.IsActive = false;
                    objEducationDegree.dbUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            RefreshData();
        }
    }
}
