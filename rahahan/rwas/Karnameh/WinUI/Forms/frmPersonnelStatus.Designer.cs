namespace RWAS.WinUI
{
    partial class frmPersonnelStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtUniqueCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grdMaster = new System.Windows.Forms.DataGridView();
            this.colRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobStatusDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniqueCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.faDatePickerEndDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faDatePickerBeginDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.cboJobStatus = new System.Windows.Forms.ComboBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "ردیف:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "کد انحصاری:";
            // 
            // txtRow
            // 
            this.txtRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRow.Location = new System.Drawing.Point(320, 16);
            this.txtRow.MaxLength = 2;
            this.txtRow.Name = "txtRow";
            this.txtRow.ReadOnly = true;
            this.txtRow.Size = new System.Drawing.Size(38, 21);
            this.txtRow.TabIndex = 1;
            this.txtRow.Visible = false;
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Location = new System.Drawing.Point(84, 12);
            this.txtUniqueCode.MaxLength = 4;
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.ReadOnly = true;
            this.txtUniqueCode.Size = new System.Drawing.Size(69, 21);
            this.txtUniqueCode.TabIndex = 0;
            this.txtUniqueCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(209, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(141, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(73, 414);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(62, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(614, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(5, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grdMaster
            // 
            this.grdMaster.AllowUserToAddRows = false;
            this.grdMaster.AllowUserToDeleteRows = false;
            this.grdMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRow,
            this.colBeginDate,
            this.colEndDate,
            this.colJobStatusDescribe,
            this.colRegionDescribe,
            this.colJobDescribe,
            this.colUniqueCode,
            this.colRegionCode,
            this.colJobStatusId,
            this.colJobId});
            this.grdMaster.Location = new System.Drawing.Point(5, 119);
            this.grdMaster.MultiSelect = false;
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.ReadOnly = true;
            this.grdMaster.RowHeadersWidth = 20;
            this.grdMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaster.Size = new System.Drawing.Size(671, 289);
            this.grdMaster.TabIndex = 8;
            this.grdMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaster_RowEnter);
            // 
            // colRow
            // 
            this.colRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRow.DataPropertyName = "Rws_Fld_Row";
            this.colRow.HeaderText = "ردیف";
            this.colRow.MinimumWidth = 50;
            this.colRow.Name = "colRow";
            this.colRow.ReadOnly = true;
            this.colRow.Visible = false;
            // 
            // colBeginDate
            // 
            this.colBeginDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colBeginDate.DataPropertyName = "Rws_Fld_FromDate";
            dataGridViewCellStyle1.Format = "####/##/##";
            dataGridViewCellStyle1.NullValue = null;
            this.colBeginDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBeginDate.HeaderText = "تاربخ شروع";
            this.colBeginDate.Name = "colBeginDate";
            this.colBeginDate.ReadOnly = true;
            this.colBeginDate.Width = 84;
            // 
            // colEndDate
            // 
            this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colEndDate.DataPropertyName = "Rws_Fld_ToDate";
            this.colEndDate.HeaderText = "تاریخ پایان";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Width = 75;
            // 
            // colJobStatusDescribe
            // 
            this.colJobStatusDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colJobStatusDescribe.DataPropertyName = "JobStatusDescribe";
            this.colJobStatusDescribe.HeaderText = "وضعیت شغلی";
            this.colJobStatusDescribe.Name = "colJobStatusDescribe";
            this.colJobStatusDescribe.ReadOnly = true;
            this.colJobStatusDescribe.Width = 101;
            // 
            // colRegionDescribe
            // 
            this.colRegionDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colRegionDescribe.DataPropertyName = "RegionDescribe";
            this.colRegionDescribe.HeaderText = "ناحیه";
            this.colRegionDescribe.Name = "colRegionDescribe";
            this.colRegionDescribe.ReadOnly = true;
            this.colRegionDescribe.Width = 55;
            // 
            // colJobDescribe
            // 
            this.colJobDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJobDescribe.DataPropertyName = "JobDescribe";
            this.colJobDescribe.HeaderText = "شغل";
            this.colJobDescribe.Name = "colJobDescribe";
            this.colJobDescribe.ReadOnly = true;
            // 
            // colUniqueCode
            // 
            this.colUniqueCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colUniqueCode.DataPropertyName = "Rws_Fld_UniqueCode";
            this.colUniqueCode.HeaderText = "کد انحصاری";
            this.colUniqueCode.MinimumWidth = 50;
            this.colUniqueCode.Name = "colUniqueCode";
            this.colUniqueCode.ReadOnly = true;
            this.colUniqueCode.Visible = false;
            // 
            // colRegionCode
            // 
            this.colRegionCode.DataPropertyName = "Rws_Fld_fk_Region";
            this.colRegionCode.HeaderText = "RegionCode";
            this.colRegionCode.Name = "colRegionCode";
            this.colRegionCode.ReadOnly = true;
            this.colRegionCode.Visible = false;
            // 
            // colJobStatusId
            // 
            this.colJobStatusId.DataPropertyName = "JobStatusId";
            this.colJobStatusId.HeaderText = "JobStatusId";
            this.colJobStatusId.Name = "colJobStatusId";
            this.colJobStatusId.ReadOnly = true;
            this.colJobStatusId.Visible = false;
            // 
            // colJobId
            // 
            this.colJobId.DataPropertyName = "Rws_Fld_fk_Job";
            this.colJobId.HeaderText = "Rws_Fld_fk_Job";
            this.colJobId.Name = "colJobId";
            this.colJobId.ReadOnly = true;
            this.colJobId.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "وضعیت:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "از تاریخ :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "تا تاریخ:";
            // 
            // faDatePickerEndDate
            // 
            this.faDatePickerEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faDatePickerEndDate.Location = new System.Drawing.Point(534, 46);
            this.faDatePickerEndDate.Name = "faDatePickerEndDate";
            this.faDatePickerEndDate.Size = new System.Drawing.Size(132, 20);
            this.faDatePickerEndDate.TabIndex = 3;
            // 
            // faDatePickerBeginDate
            // 
            this.faDatePickerBeginDate.Location = new System.Drawing.Point(56, 46);
            this.faDatePickerBeginDate.Name = "faDatePickerBeginDate";
            this.faDatePickerBeginDate.Size = new System.Drawing.Size(132, 20);
            this.faDatePickerBeginDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 392;
            this.label6.Text = "ناحیه:";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Location = new System.Drawing.Point(56, 79);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboRegion.Size = new System.Drawing.Size(187, 21);
            this.cboRegion.TabIndex = 5;
            // 
            // cboJobStatus
            // 
            this.cboJobStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobStatus.Location = new System.Drawing.Point(532, 13);
            this.cboJobStatus.Name = "cboJobStatus";
            this.cboJobStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboJobStatus.Size = new System.Drawing.Size(134, 21);
            this.cboJobStatus.TabIndex = 4;
            // 
            // cboJob
            // 
            this.cboJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJob.Location = new System.Drawing.Point(440, 79);
            this.cboJob.Name = "cboJob";
            this.cboJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboJob.Size = new System.Drawing.Size(226, 21);
            this.cboJob.TabIndex = 393;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 394;
            this.label7.Text = "شغل:";
            // 
            // frmPersonnelStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(678, 449);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboJobStatus);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.faDatePickerEndDate);
            this.Controls.Add(this.faDatePickerBeginDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.txtUniqueCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdMaster);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonnelStatus";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "وضعیت شغلی";
            this.Load += new System.EventHandler(this.frmPersonnelStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtUniqueCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView grdMaster;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerEndDate;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerBeginDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.ComboBox cboJobStatus;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobStatusDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniqueCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobId;

    }
}