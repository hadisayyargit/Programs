namespace RWAS.WinUI
{
    partial class frmPersonnelSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonnelSearch));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.grdSearchPersonel = new System.Windows.Forms.DataGridView();
            this.colUniqueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNational_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubContractorTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboSubContractor = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.txtUniqueCode = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRowCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "EXET.png");
            this.imageList1.Images.SetKeyName(1, "refresh.png");
            this.imageList1.Images.SetKeyName(2, "KAMKARDAN.png");
            this.imageList1.Images.SetKeyName(3, "Jostejoo Kartabl Sanad.ico");
            this.imageList1.Images.SetKeyName(4, "load.png");
            this.imageList1.Images.SetKeyName(5, "Gozaresh.ico");
            this.imageList1.Images.SetKeyName(6, "EZAFEH.png");
            this.imageList1.Images.SetKeyName(7, "new.png");
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(396, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 468;
            this.label21.Text = "شماره ملی";
            // 
            // grdSearchPersonel
            // 
            this.grdSearchPersonel.AllowUserToAddRows = false;
            this.grdSearchPersonel.AllowUserToDeleteRows = false;
            this.grdSearchPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearchPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdSearchPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUniqueId,
            this.colFirstName,
            this.colLastName,
            this.colNational_Code,
            this.colPersonelId,
            this.colRegionTitle,
            this.colJobTitle,
            this.colSubContractorTitle,
            this.Column2,
            this.Column4,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.grdSearchPersonel.Location = new System.Drawing.Point(12, 147);
            this.grdSearchPersonel.Name = "grdSearchPersonel";
            this.grdSearchPersonel.ReadOnly = true;
            this.grdSearchPersonel.Size = new System.Drawing.Size(719, 252);
            this.grdSearchPersonel.TabIndex = 466;
            this.grdSearchPersonel.CurrentCellChanged += new System.EventHandler(this.grdSearchPersonel_CurrentCellChanged);
            // 
            // colUniqueId
            // 
            this.colUniqueId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colUniqueId.DataPropertyName = "Prs_Fld_UniqueCode";
            this.colUniqueId.HeaderText = "کد انحصاری";
            this.colUniqueId.MinimumWidth = 100;
            this.colUniqueId.Name = "colUniqueId";
            this.colUniqueId.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFirstName.DataPropertyName = "Prs_Fld_FirstName";
            this.colFirstName.HeaderText = "نام";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 80;
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLastName.DataPropertyName = "Prs_Fld_LastName";
            this.colLastName.HeaderText = "نام خانوادگی";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colNational_Code
            // 
            this.colNational_Code.DataPropertyName = "National_Code";
            this.colNational_Code.HeaderText = "کد ملی";
            this.colNational_Code.Name = "colNational_Code";
            this.colNational_Code.ReadOnly = true;
            this.colNational_Code.Width = 67;
            // 
            // colPersonelId
            // 
            this.colPersonelId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colPersonelId.DataPropertyName = "Prs_Fld_PersonelID";
            this.colPersonelId.HeaderText = "شماره کارمندی";
            this.colPersonelId.MinimumWidth = 100;
            this.colPersonelId.Name = "colPersonelId";
            this.colPersonelId.ReadOnly = true;
            this.colPersonelId.Width = 103;
            // 
            // colRegionTitle
            // 
            this.colRegionTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRegionTitle.DataPropertyName = "Prs_Fld_RegionDescribe";
            this.colRegionTitle.HeaderText = "ناحیه کاری";
            this.colRegionTitle.MinimumWidth = 50;
            this.colRegionTitle.Name = "colRegionTitle";
            this.colRegionTitle.ReadOnly = true;
            this.colRegionTitle.Width = 120;
            // 
            // colJobTitle
            // 
            this.colJobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colJobTitle.DataPropertyName = "Rws_Fld_JobDescribe";
            this.colJobTitle.HeaderText = "شغل";
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.ReadOnly = true;
            // 
            // colSubContractorTitle
            // 
            this.colSubContractorTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSubContractorTitle.DataPropertyName = "SubContractorDescribe";
            this.colSubContractorTitle.HeaderText = "شرکت پیمانکار";
            this.colSubContractorTitle.Name = "colSubContractorTitle";
            this.colSubContractorTitle.ReadOnly = true;
            this.colSubContractorTitle.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "prs_fld_employeedate";
            this.Column2.HeaderText = "تاریخ استخدام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 97;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Prs_Fld_OrgUnitDescribe";
            this.Column4.HeaderText = "محل کار";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Prs_Fld_FatherName";
            this.Column1.HeaderText = "نام پدر";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 61;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Rws_Fld_EmployeeStatusDescribe";
            this.Column3.HeaderText = "نوع استخدام";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 91;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "prs_fld_jobhistory";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 73;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "prs_fld_BirthYear";
            this.Column6.HeaderText = "سال تولد";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 73;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "prs_fld_fk_StudyStatus";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 73;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "prs_fld_Contractor";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 73;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "prs_fld_TelNo";
            this.Column9.HeaderText = "تلفن";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 53;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "prs_fld_IdNo";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 79;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "prs_fld_maritalstatus";
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            this.Column11.Width = 79;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "prs_fld_fk_orgunit";
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            this.Column12.Width = 79;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "prs_fld_fk_subcontractor";
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            this.Column13.Width = 79;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "prs_fld_fk_employeestatus";
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            this.Column14.Width = 79;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "prs_fld_fk_region";
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            this.Column15.Width = 79;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "prs_fld_fk_job";
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            this.Column16.Width = 79;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "prs_fld_address";
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Visible = false;
            this.Column17.Width = 79;
            // 
            // cboSubContractor
            // 
            this.cboSubContractor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSubContractor.BackColor = System.Drawing.SystemColors.Window;
            this.cboSubContractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubContractor.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboSubContractor.Location = new System.Drawing.Point(478, 120);
            this.cboSubContractor.Name = "cboSubContractor";
            this.cboSubContractor.Size = new System.Drawing.Size(253, 20);
            this.cboSubContractor.TabIndex = 454;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 459;
            this.label22.Text = "ناحیه";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(396, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
            this.label25.TabIndex = 458;
            this.label25.Text = "شغل سازمانی";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 457;
            this.label18.Text = "شماره کارمندی";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(396, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 456;
            this.label24.Text = "نام خانوادگی";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(33, 43);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 13);
            this.label36.TabIndex = 455;
            this.label36.Text = "نام";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 460;
            this.label11.Text = "شرکت پیمانکار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 471;
            this.label4.Text = "نوع استخدام";
            // 
            // cboEmployeeStatus
            // 
            this.cboEmployeeStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cboEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeStatus.Location = new System.Drawing.Point(84, 120);
            this.cboEmployeeStatus.Name = "cboEmployeeStatus";
            this.cboEmployeeStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboEmployeeStatus.Size = new System.Drawing.Size(195, 21);
            this.cboEmployeeStatus.TabIndex = 470;
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Location = new System.Drawing.Point(84, 12);
            this.txtUniqueCode.MaxLength = 9;
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.Size = new System.Drawing.Size(112, 21);
            this.txtUniqueCode.TabIndex = 472;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 473;
            this.label23.Text = "کد انحصاری ";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalCode.Location = new System.Drawing.Point(478, 66);
            this.txtNationalCode.MaxLength = 10;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(167, 21);
            this.txtNationalCode.TabIndex = 479;
            // 
            // cboJob
            // 
            this.cboJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJob.Location = new System.Drawing.Point(478, 93);
            this.cboJob.Name = "cboJob";
            this.cboJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboJob.Size = new System.Drawing.Size(253, 21);
            this.cboJob.TabIndex = 478;
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Location = new System.Drawing.Point(84, 93);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboRegion.Size = new System.Drawing.Size(195, 21);
            this.cboRegion.TabIndex = 477;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonelID.Location = new System.Drawing.Point(86, 66);
            this.txtPersonelID.MaxLength = 20;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(110, 21);
            this.txtPersonelID.TabIndex = 476;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(478, 39);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(230, 21);
            this.txtLastName.TabIndex = 475;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(84, 39);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(112, 21);
            this.txtFirstName.TabIndex = 474;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(501, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 469;
            this.btnClear.Text = "جدید";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImageKey = "EXET.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(686, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 24);
            this.btnClose.TabIndex = 465;
            this.btnClose.TabStop = false;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.ImageKey = "load.png";
            this.btnLoad.ImageList = this.imageList1;
            this.btnLoad.Location = new System.Drawing.Point(634, 407);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(46, 24);
            this.btnLoad.TabIndex = 464;
            this.btnLoad.TabStop = false;
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "Jostejoo Kartabl Sanad.ico";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(582, 407);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 24);
            this.btnSearch.TabIndex = 463;
            this.btnSearch.TabStop = false;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRowCount
            // 
            this.txtRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRowCount.Location = new System.Drawing.Point(53, 410);
            this.txtRowCount.MaxLength = 20;
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.ReadOnly = true;
            this.txtRowCount.Size = new System.Drawing.Size(67, 21);
            this.txtRowCount.TabIndex = 481;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 480;
            this.label1.Text = "تعداد";
            // 
            // frmPersonnelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.txtRowCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUniqueCode);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboEmployeeStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.grdSearchPersonel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSubContractor);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmPersonnelSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی کارکنان";
            this.Load += new System.EventHandler(this.frmPersonnelSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView grdSearchPersonel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSubContractor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEmployeeStatus;
        private System.Windows.Forms.TextBox txtUniqueCode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtRowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniqueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNational_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubContractorTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;


    }
}