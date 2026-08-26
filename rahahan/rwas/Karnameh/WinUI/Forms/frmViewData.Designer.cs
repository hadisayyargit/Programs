namespace RWAS.WinUI
{
    partial class frmViewData
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageJob = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdActiveJob = new System.Windows.Forms.DataGridView();
            this.colJobId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobGroup2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveJob = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdNonActiveJob = new System.Windows.Forms.DataGridView();
            this.colJobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.tabPageEducation = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdActiveEducation = new System.Windows.Forms.DataGridView();
            this.colEducationCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRemoveEducation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdNonActiveEducation = new System.Windows.Forms.DataGridView();
            this.colEducationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducationGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddEducation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageJob.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveJob)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNonActiveJob)).BeginInit();
            this.tabPageEducation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveEducation)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNonActiveEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageJob);
            this.tabControl1.Controls.Add(this.tabPageEducation);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageJob
            // 
            this.tabPageJob.Controls.Add(this.groupBox2);
            this.tabPageJob.Controls.Add(this.groupBox1);
            this.tabPageJob.Location = new System.Drawing.Point(4, 22);
            this.tabPageJob.Name = "tabPageJob";
            this.tabPageJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJob.Size = new System.Drawing.Size(730, 398);
            this.tabPageJob.TabIndex = 0;
            this.tabPageJob.Text = "مشاغل";
            this.tabPageJob.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.grdActiveJob);
            this.groupBox2.Controls.Add(this.btnRemoveJob);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(17, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 374);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشاغل فعال";
            // 
            // grdActiveJob
            // 
            this.grdActiveJob.AllowUserToAddRows = false;
            this.grdActiveJob.AllowUserToDeleteRows = false;
            this.grdActiveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdActiveJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobId2,
            this.colJobName2,
            this.colJobGroup2});
            this.grdActiveJob.Location = new System.Drawing.Point(6, 29);
            this.grdActiveJob.MultiSelect = false;
            this.grdActiveJob.Name = "grdActiveJob";
            this.grdActiveJob.ReadOnly = true;
            this.grdActiveJob.RowHeadersWidth = 20;
            this.grdActiveJob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdActiveJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdActiveJob.Size = new System.Drawing.Size(314, 302);
            this.grdActiveJob.TabIndex = 8;
            // 
            // colJobId2
            // 
            this.colJobId2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobId2.DataPropertyName = "Prs_Fld_Code";
            this.colJobId2.HeaderText = "کد شغل";
            this.colJobId2.Name = "colJobId2";
            this.colJobId2.ReadOnly = true;
            this.colJobId2.Width = 71;
            // 
            // colJobName2
            // 
            this.colJobName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobName2.DataPropertyName = "Prs_Fld_Describe";
            this.colJobName2.HeaderText = "عنوان شغل";
            this.colJobName2.Name = "colJobName2";
            this.colJobName2.ReadOnly = true;
            this.colJobName2.Width = 86;
            // 
            // colJobGroup2
            // 
            this.colJobGroup2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobGroup2.DataPropertyName = "JobGroup";
            this.colJobGroup2.HeaderText = "گروه شغلی";
            this.colJobGroup2.Name = "colJobGroup2";
            this.colJobGroup2.ReadOnly = true;
            this.colJobGroup2.Visible = false;
            // 
            // btnRemoveJob
            // 
            this.btnRemoveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveJob.Location = new System.Drawing.Point(293, 345);
            this.btnRemoveJob.Name = "btnRemoveJob";
            this.btnRemoveJob.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveJob.TabIndex = 10;
            this.btnRemoveJob.Text = "<";
            this.btnRemoveJob.UseVisualStyleBackColor = true;
            this.btnRemoveJob.Click += new System.EventHandler(this.btnRemoveJob_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grdNonActiveJob);
            this.groupBox1.Controls.Add(this.btnAddJob);
            this.groupBox1.Location = new System.Drawing.Point(359, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 374);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشاغل غیرفعال";
            // 
            // grdNonActiveJob
            // 
            this.grdNonActiveJob.AllowUserToAddRows = false;
            this.grdNonActiveJob.AllowUserToDeleteRows = false;
            this.grdNonActiveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNonActiveJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdNonActiveJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobId,
            this.colJobName,
            this.colJobGroup});
            this.grdNonActiveJob.Location = new System.Drawing.Point(15, 29);
            this.grdNonActiveJob.MultiSelect = false;
            this.grdNonActiveJob.Name = "grdNonActiveJob";
            this.grdNonActiveJob.RowHeadersWidth = 20;
            this.grdNonActiveJob.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdNonActiveJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNonActiveJob.Size = new System.Drawing.Size(340, 302);
            this.grdNonActiveJob.TabIndex = 7;
            // 
            // colJobId
            // 
            this.colJobId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobId.DataPropertyName = "Prs_Fld_Code";
            this.colJobId.HeaderText = "کد شغل";
            this.colJobId.Name = "colJobId";
            this.colJobId.Width = 71;
            // 
            // colJobName
            // 
            this.colJobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobName.DataPropertyName = "Prs_Fld_Describe";
            this.colJobName.HeaderText = "عنوان شغل";
            this.colJobName.Name = "colJobName";
            this.colJobName.Width = 86;
            // 
            // colJobGroup
            // 
            this.colJobGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJobGroup.DataPropertyName = "JobGroup";
            this.colJobGroup.HeaderText = "گروه شغلی";
            this.colJobGroup.Name = "colJobGroup";
            this.colJobGroup.Visible = false;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddJob.Location = new System.Drawing.Point(15, 345);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(27, 23);
            this.btnAddJob.TabIndex = 9;
            this.btnAddJob.Text = ">";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // tabPageEducation
            // 
            this.tabPageEducation.Controls.Add(this.groupBox3);
            this.tabPageEducation.Controls.Add(this.groupBox4);
            this.tabPageEducation.Location = new System.Drawing.Point(4, 22);
            this.tabPageEducation.Name = "tabPageEducation";
            this.tabPageEducation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEducation.Size = new System.Drawing.Size(730, 398);
            this.tabPageEducation.TabIndex = 1;
            this.tabPageEducation.Text = "تحصیلات";
            this.tabPageEducation.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.grdActiveEducation);
            this.groupBox3.Controls.Add(this.btnRemoveEducation);
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 374);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تحصیلات فعال";
            // 
            // grdActiveEducation
            // 
            this.grdActiveEducation.AllowUserToAddRows = false;
            this.grdActiveEducation.AllowUserToDeleteRows = false;
            this.grdActiveEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdActiveEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActiveEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEducationCode2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grdActiveEducation.Location = new System.Drawing.Point(6, 29);
            this.grdActiveEducation.MultiSelect = false;
            this.grdActiveEducation.Name = "grdActiveEducation";
            this.grdActiveEducation.ReadOnly = true;
            this.grdActiveEducation.RowHeadersWidth = 20;
            this.grdActiveEducation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdActiveEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdActiveEducation.Size = new System.Drawing.Size(314, 302);
            this.grdActiveEducation.TabIndex = 8;
            // 
            // colEducationCode2
            // 
            this.colEducationCode2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEducationCode2.DataPropertyName = "Prs_Fld_Code";
            this.colEducationCode2.HeaderText = "کد تحصیلی";
            this.colEducationCode2.Name = "colEducationCode2";
            this.colEducationCode2.ReadOnly = true;
            this.colEducationCode2.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prs_Fld_Describe";
            this.dataGridViewTextBoxColumn2.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumn3.HeaderText = "فعال";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // btnRemoveEducation
            // 
            this.btnRemoveEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveEducation.Location = new System.Drawing.Point(293, 345);
            this.btnRemoveEducation.Name = "btnRemoveEducation";
            this.btnRemoveEducation.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveEducation.TabIndex = 10;
            this.btnRemoveEducation.Text = "<";
            this.btnRemoveEducation.UseVisualStyleBackColor = true;
            this.btnRemoveEducation.Click += new System.EventHandler(this.btnRemoveEducation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.grdNonActiveEducation);
            this.groupBox4.Controls.Add(this.btnAddEducation);
            this.groupBox4.Location = new System.Drawing.Point(351, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 374);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تحصیلات غیرفعال";
            // 
            // grdNonActiveEducation
            // 
            this.grdNonActiveEducation.AllowUserToAddRows = false;
            this.grdNonActiveEducation.AllowUserToDeleteRows = false;
            this.grdNonActiveEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNonActiveEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNonActiveEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEducationCode,
            this.colEducationName,
            this.colEducationGroup});
            this.grdNonActiveEducation.Location = new System.Drawing.Point(15, 29);
            this.grdNonActiveEducation.MultiSelect = false;
            this.grdNonActiveEducation.Name = "grdNonActiveEducation";
            this.grdNonActiveEducation.ReadOnly = true;
            this.grdNonActiveEducation.RowHeadersWidth = 20;
            this.grdNonActiveEducation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdNonActiveEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNonActiveEducation.Size = new System.Drawing.Size(340, 302);
            this.grdNonActiveEducation.TabIndex = 7;
            // 
            // colEducationCode
            // 
            this.colEducationCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEducationCode.DataPropertyName = "Prs_Fld_Code";
            this.colEducationCode.HeaderText = "کد تحصیلی";
            this.colEducationCode.Name = "colEducationCode";
            this.colEducationCode.ReadOnly = true;
            this.colEducationCode.Width = 84;
            // 
            // colEducationName
            // 
            this.colEducationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEducationName.DataPropertyName = "Prs_Fld_Describe";
            this.colEducationName.HeaderText = "عنوان";
            this.colEducationName.Name = "colEducationName";
            this.colEducationName.ReadOnly = true;
            this.colEducationName.Width = 58;
            // 
            // colEducationGroup
            // 
            this.colEducationGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEducationGroup.DataPropertyName = "IsActive";
            this.colEducationGroup.HeaderText = "فعال";
            this.colEducationGroup.Name = "colEducationGroup";
            this.colEducationGroup.ReadOnly = true;
            this.colEducationGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEducationGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEducationGroup.Visible = false;
            // 
            // btnAddEducation
            // 
            this.btnAddEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEducation.Location = new System.Drawing.Point(15, 345);
            this.btnAddEducation.Name = "btnAddEducation";
            this.btnAddEducation.Size = new System.Drawing.Size(27, 23);
            this.btnAddEducation.TabIndex = 9;
            this.btnAddEducation.Text = ">";
            this.btnAddEducation.UseVisualStyleBackColor = true;
            this.btnAddEducation.Click += new System.EventHandler(this.btnAddEducation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(667, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(4, 431);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 464);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimizeBox = false;
            this.Name = "frmViewData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نمایشی";
            this.Load += new System.EventHandler(this.frmViewData_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageJob.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveJob)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNonActiveJob)).EndInit();
            this.tabPageEducation.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveEducation)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNonActiveEducation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageJob;
        private System.Windows.Forms.TabPage tabPageEducation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdNonActiveJob;
        private System.Windows.Forms.DataGridView grdActiveJob;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobGroup2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdActiveEducation;
        private System.Windows.Forms.Button btnRemoveEducation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdNonActiveEducation;
        private System.Windows.Forms.Button btnAddEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducationCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducationName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEducationGroup;
    }
}