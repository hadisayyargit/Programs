namespace RWAS.WinUI
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Rws_Sp_Rep_ChastiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrimary = new RWAS.WinUI.dsPrimary();
            this.Rws_Sp_Rep_EulogyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rws_Sp_Rep_ChastiseTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Rws_Sp_Rep_ChastiseTableAdapter();
            this.Rws_Sp_Rep_EulogyTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Rws_Sp_Rep_EulogyTableAdapter();
            this.Rws_Sp_Rep_PersonelTrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rws_Sp_Rep_PersonelTrainingTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Rws_Sp_Rep_PersonelTrainingTableAdapter();
            this.sp_GetPersonnelScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetPersonnelScoreTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.sp_GetPersonnelScoreTableAdapter();
            this.Rws_Sp_Rep_BodilyMentalStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rws_Sp_Rep_BodilyMentalStatusTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Rws_Sp_Rep_BodilyMentalStatusTableAdapter();
            this.Sp_GetPersonnelJobStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_GetPersonnelJobStatusTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Sp_GetPersonnelJobStatusTableAdapter();
            this.Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter();
            this.sp_Rep_GetPersonnelOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Rep_GetPersonnelOperationTableAdapter = new RWAS.WinUI.dsPrimaryTableAdapters.sp_Rep_GetPersonnelOperationTableAdapter();
            //this.vw_Rep_DataEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Prs_Sp_Sel_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_ChastiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_EulogyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_PersonelTrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetPersonnelScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_BodilyMentalStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_GetPersonnelJobStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rep_GetPersonnelOperationBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.vw_Rep_DataEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prs_Sp_Sel_PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Rws_Sp_Rep_ChastiseBindingSource
            // 
            this.Rws_Sp_Rep_ChastiseBindingSource.DataMember = "Rws_Sp_Rep_Chastise";
            this.Rws_Sp_Rep_ChastiseBindingSource.DataSource = this.dsPrimary;
            // 
            // dsPrimary
            // 
            this.dsPrimary.DataSetName = "dsPrimary";
            this.dsPrimary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rws_Sp_Rep_EulogyBindingSource
            // 
            this.Rws_Sp_Rep_EulogyBindingSource.DataMember = "Rws_Sp_Rep_Eulogy";
            this.Rws_Sp_Rep_EulogyBindingSource.DataSource = this.dsPrimary;
            // 
            // Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource
            // 
            this.Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource.DataMember = "Rws_Sp_Rep_WorkBookPersonelAccident";
            this.Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource.DataSource = this.dsPrimary;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datasetPersonnelEulogy";
            reportDataSource1.Value = this.Rws_Sp_Rep_EulogyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RWAS.WinUI.Reports.rptPersonnelEulogy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.Size = new System.Drawing.Size(758, 521);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Rws_Sp_Rep_ChastiseTableAdapter
            // 
            this.Rws_Sp_Rep_ChastiseTableAdapter.ClearBeforeFill = true;
            // 
            // Rws_Sp_Rep_EulogyTableAdapter
            // 
            this.Rws_Sp_Rep_EulogyTableAdapter.ClearBeforeFill = true;
            // 
            // Rws_Sp_Rep_PersonelTrainingBindingSource
            // 
            this.Rws_Sp_Rep_PersonelTrainingBindingSource.DataMember = "Rws_Sp_Rep_PersonelTraining";
            this.Rws_Sp_Rep_PersonelTrainingBindingSource.DataSource = this.dsPrimary;
            // 
            // Rws_Sp_Rep_PersonelTrainingTableAdapter
            // 
            this.Rws_Sp_Rep_PersonelTrainingTableAdapter.ClearBeforeFill = true;
            // 
            // sp_GetPersonnelScoreBindingSource
            // 
            this.sp_GetPersonnelScoreBindingSource.DataMember = "sp_GetPersonnelScore";
            this.sp_GetPersonnelScoreBindingSource.DataSource = this.dsPrimary;
            // 
            // sp_GetPersonnelScoreTableAdapter
            // 
            this.sp_GetPersonnelScoreTableAdapter.ClearBeforeFill = true;
            // 
            // Rws_Sp_Rep_BodilyMentalStatusBindingSource
            // 
            this.Rws_Sp_Rep_BodilyMentalStatusBindingSource.DataMember = "Rws_Sp_Rep_BodilyMentalStatus";
            this.Rws_Sp_Rep_BodilyMentalStatusBindingSource.DataSource = this.dsPrimary;
            // 
            // Rws_Sp_Rep_BodilyMentalStatusTableAdapter
            // 
            this.Rws_Sp_Rep_BodilyMentalStatusTableAdapter.ClearBeforeFill = true;
            // 
            // Sp_GetPersonnelJobStatusBindingSource
            // 
            this.Sp_GetPersonnelJobStatusBindingSource.DataMember = "Sp_GetPersonnelJobStatus";
            this.Sp_GetPersonnelJobStatusBindingSource.DataSource = this.dsPrimary;
            // 
            // Sp_GetPersonnelJobStatusTableAdapter
            // 
            this.Sp_GetPersonnelJobStatusTableAdapter.ClearBeforeFill = true;
            // 
            // Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter
            // 
            this.Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter.ClearBeforeFill = true;
            // 
            // sp_Rep_GetPersonnelOperationBindingSource
            // 
            this.sp_Rep_GetPersonnelOperationBindingSource.DataMember = "sp_Rep_GetPersonnelOperation";
            this.sp_Rep_GetPersonnelOperationBindingSource.DataSource = this.dsPrimary;
            // 
            // sp_Rep_GetPersonnelOperationTableAdapter
            // 
            this.sp_Rep_GetPersonnelOperationTableAdapter.ClearBeforeFill = true;
            // 
            // vw_Rep_DataEntryBindingSource
            // 
            //this.vw_Rep_DataEntryBindingSource.DataMember = "vw_Rep_DataEntry";
            //this.vw_Rep_DataEntryBindingSource.DataSource = this.dsPrimary;
            // 
            // Prs_Sp_Sel_PersonelBindingSource
            // 
            this.Prs_Sp_Sel_PersonelBindingSource.DataMember = "Prs_Sp_Sel_Personel";
            this.Prs_Sp_Sel_PersonelBindingSource.DataSource = this.dsPrimary;
            // 
            // PostDataBindingSource
            // 
            this.PostDataBindingSource.DataMember = "PostData";
            this.PostDataBindingSource.DataSource = this.dsPrimary;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 521);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "frmReportViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش نما";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_ChastiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_EulogyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_PersonelTrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetPersonnelScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rws_Sp_Rep_BodilyMentalStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_GetPersonnelJobStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rep_GetPersonnelOperationBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.vw_Rep_DataEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prs_Sp_Sel_PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsPrimaryTableAdapters.Prs_Sp_Sel_PersonelTableAdapter Prs_Sp_Sel_PersonelTableAdapter;
        //private dsPrimaryTableAdapters.vw_Rep_DataEntryTableAdapter vw_Rep_DataEntryTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Rws_Sp_Rep_ChastiseBindingSource;
        private dsPrimary dsPrimary;
        private dsPrimaryTableAdapters.Rws_Sp_Rep_ChastiseTableAdapter Rws_Sp_Rep_ChastiseTableAdapter;
        private System.Windows.Forms.BindingSource Rws_Sp_Rep_EulogyBindingSource;
        private dsPrimaryTableAdapters.Rws_Sp_Rep_EulogyTableAdapter Rws_Sp_Rep_EulogyTableAdapter;
        private System.Windows.Forms.BindingSource Rws_Sp_Rep_PersonelTrainingBindingSource;
        private dsPrimaryTableAdapters.Rws_Sp_Rep_PersonelTrainingTableAdapter Rws_Sp_Rep_PersonelTrainingTableAdapter;
        private System.Windows.Forms.BindingSource sp_GetPersonnelScoreBindingSource;
        private dsPrimaryTableAdapters.sp_GetPersonnelScoreTableAdapter sp_GetPersonnelScoreTableAdapter;
        private System.Windows.Forms.BindingSource Rws_Sp_Rep_BodilyMentalStatusBindingSource;
        private System.Windows.Forms.BindingSource Sp_GetPersonnelJobStatusBindingSource;
        private System.Windows.Forms.BindingSource Rws_Sp_Rep_WorkBookPersonelAccidentBindingSource;
        private System.Windows.Forms.BindingSource sp_Rep_GetPersonnelOperationBindingSource;
        private dsPrimaryTableAdapters.Rws_Sp_Rep_BodilyMentalStatusTableAdapter Rws_Sp_Rep_BodilyMentalStatusTableAdapter;
        private dsPrimaryTableAdapters.Sp_GetPersonnelJobStatusTableAdapter Sp_GetPersonnelJobStatusTableAdapter;
        private dsPrimaryTableAdapters.Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter Rws_Sp_Rep_WorkBookPersonelAccidentTableAdapter;
        private dsPrimaryTableAdapters.sp_Rep_GetPersonnelOperationTableAdapter sp_Rep_GetPersonnelOperationTableAdapter;
        //private System.Windows.Forms.BindingSource vw_Rep_DataEntryBindingSource;
        private System.Windows.Forms.BindingSource Prs_Sp_Sel_PersonelBindingSource;
        private System.Windows.Forms.BindingSource PostDataBindingSource;
    }
}