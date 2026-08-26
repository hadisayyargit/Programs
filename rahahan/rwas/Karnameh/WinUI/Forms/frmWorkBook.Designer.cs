namespace RWAS.WinUI
{
    partial class frmWorkBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkBook));
            this.cmbStudyStatus = new combo.MyComboBox();
            this.cmbJob = new combo.MyComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelNo = new ProgLib.Components.CNTextBox(this.components);
            this.txtIDNo = new ProgLib.Components.CNTextBox(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imglstWorkBook = new System.Windows.Forms.ImageList(this.components);
            this.txtContractor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJobHistory = new ProgLib.Components.CNTextBox(this.components);
            this.txtBirthYear = new ProgLib.Components.CNTextBox(this.components);
            this.txtPersonelID = new ProgLib.Components.CNTextBox(this.components);
            this.txtUniqueCode = new ProgLib.Components.CNTextBox(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.ToolTipWorkBook = new System.Windows.Forms.ToolTip(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.CHelpPopupSecondaryAccidentDetail = new ProgLib.Components.CHelpPopup();
            this.btnPersonelAccident = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPersonelTraining = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnPrefermentHistory = new System.Windows.Forms.Button();
            this.btnEulogy = new System.Windows.Forms.Button();
            this.btnBodilyMentalStatus = new System.Windows.Forms.Button();
            this.btnChastise = new System.Windows.Forms.Button();
            this.btnUniqueCode = new System.Windows.Forms.Button();
            this.txtEmployeeDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.cboOrgUnit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonelJobStatus = new System.Windows.Forms.Button();
            this.txtNationalCode = new ProgLib.Components.CNTextBox(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbStudyStatus
            // 
            this.cmbStudyStatus.CellSort = System.Windows.Forms.SortOrder.None;
            this.cmbStudyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbStudyStatus.GetDataTable = null;
            this.cmbStudyStatus.Location = new System.Drawing.Point(115, 77);
            this.cmbStudyStatus.Name = "cmbStudyStatus";
            this.cmbStudyStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStudyStatus.Size = new System.Drawing.Size(216, 21);
            this.cmbStudyStatus.TabIndex = 6;
            this.cmbStudyStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStudyStatus_KeyDown);
            // 
            // cmbJob
            // 
            this.cmbJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbJob.CellSort = System.Windows.Forms.SortOrder.None;
            this.cmbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbJob.GetDataTable = null;
            this.cmbJob.Location = new System.Drawing.Point(115, 176);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbJob.Size = new System.Drawing.Size(216, 21);
            this.cmbJob.TabIndex = 12;
            this.cmbJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbJob_KeyDown);
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbRegion.Location = new System.Drawing.Point(115, 142);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRegion.Size = new System.Drawing.Size(216, 21);
            this.cmbRegion.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 146);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 438;
            this.label14.Text = "ناحیه";
            // 
            // txtTelNo
            // 
            this.txtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelNo.Location = new System.Drawing.Point(114, 240);
            this.txtTelNo.MaxLength = 12;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTelNo.Size = new System.Drawing.Size(217, 21);
            this.txtTelNo.strVal = "";
            this.txtTelNo.TabIndex = 15;
            this.txtTelNo.Text = "0";
            this.txtTelNo.Value = 0;
            // 
            // txtIDNo
            // 
            this.txtIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNo.Location = new System.Drawing.Point(511, 208);
            this.txtIDNo.MaxLength = 9;
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIDNo.Size = new System.Drawing.Size(217, 21);
            this.txtIDNo.strVal = "";
            this.txtIDNo.TabIndex = 14;
            this.txtIDNo.Text = "0";
            this.txtIDNo.Value = 0;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 242);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 437;
            this.label13.Text = "آدرس";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAddress.Location = new System.Drawing.Point(509, 240);
            this.txtAddress.MaxLength = 80;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(269, 45);
            this.txtAddress.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(17, 276);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 435;
            this.label11.Text = "شرکت پیمانکار";
            // 
            // imglstWorkBook
            // 
            this.imglstWorkBook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstWorkBook.ImageStream")));
            this.imglstWorkBook.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstWorkBook.Images.SetKeyName(0, "");
            this.imglstWorkBook.Images.SetKeyName(1, "");
            this.imglstWorkBook.Images.SetKeyName(2, "");
            this.imglstWorkBook.Images.SetKeyName(3, "");
            this.imglstWorkBook.Images.SetKeyName(4, "");
            this.imglstWorkBook.Images.SetKeyName(5, "");
            this.imglstWorkBook.Images.SetKeyName(6, "");
            this.imglstWorkBook.Images.SetKeyName(7, "");
            this.imglstWorkBook.Images.SetKeyName(8, "");
            // 
            // txtContractor
            // 
            this.txtContractor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtContractor.Location = new System.Drawing.Point(115, 272);
            this.txtContractor.MaxLength = 50;
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractor.Size = new System.Drawing.Size(214, 21);
            this.txtContractor.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 244);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 434;
            this.label10.Text = "شماره تلفن";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 212);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 433;
            this.label9.Text = "شماره شناسنامه";
            // 
            // txtJobHistory
            // 
            this.txtJobHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJobHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobHistory.Location = new System.Drawing.Point(509, 44);
            this.txtJobHistory.MaxLength = 2;
            this.txtJobHistory.Name = "txtJobHistory";
            this.txtJobHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJobHistory.Size = new System.Drawing.Size(37, 21);
            this.txtJobHistory.strVal = "";
            this.txtJobHistory.TabIndex = 4;
            this.txtJobHistory.Text = "0";
            this.txtJobHistory.Value = 0;
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthYear.Location = new System.Drawing.Point(741, 44);
            this.txtBirthYear.MaxLength = 4;
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBirthYear.Size = new System.Drawing.Size(37, 21);
            this.txtBirthYear.strVal = "";
            this.txtBirthYear.TabIndex = 5;
            this.txtBirthYear.Text = "0";
            this.txtBirthYear.Value = 0;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonelID.Location = new System.Drawing.Point(115, 44);
            this.txtPersonelID.MaxLength = 9;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonelID.Size = new System.Drawing.Size(217, 21);
            this.txtPersonelID.strVal = "";
            this.txtPersonelID.TabIndex = 3;
            this.txtPersonelID.Text = "0";
            this.txtPersonelID.Value = 0;
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUniqueCode.Location = new System.Drawing.Point(114, 14);
            this.txtUniqueCode.MaxLength = 9;
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUniqueCode.Size = new System.Drawing.Size(192, 21);
            this.txtUniqueCode.strVal = "";
            this.txtUniqueCode.TabIndex = 0;
            this.txtUniqueCode.Text = "0";
            this.txtUniqueCode.Value = 0;
            this.txtUniqueCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUniqueCode_KeyDown);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(431, 114);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 432;
            this.label17.Text = "تاریخ استخدام";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 81);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 431;
            this.label8.Text = "وضعیت تحصیلی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 424;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 81);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 430;
            this.label7.Text = "وضعیت تاهل";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 48);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 429;
            this.label6.Text = "سابقه کار(سال)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 48);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 428;
            this.label5.Text = "سال تولد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 427;
            this.label4.Text = "نوع استخدام";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 179);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 426;
            this.label3.Text = "شغل سازمانی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 425;
            this.label2.Text = "شماره کارمندی";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 21);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 423;
            this.label23.Text = "کد انحصاری ";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonelName.BackColor = System.Drawing.Color.Azure;
            this.lblPersonelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPersonelName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPersonelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonelName.Location = new System.Drawing.Point(509, 9);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonelName.Size = new System.Drawing.Size(269, 21);
            this.lblPersonelName.TabIndex = 2;
            this.lblPersonelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.ImageIndex = 6;
            this.btnNew.ImageList = this.imglstWorkBook;
            this.btnNew.Location = new System.Drawing.Point(51, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(41, 34);
            this.btnNew.TabIndex = 0;
            this.ToolTipWorkBook.SetToolTip(this.btnNew, "جدید");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageIndex = 0;
            this.btnExit.ImageList = this.imglstWorkBook;
            this.btnExit.Location = new System.Drawing.Point(4, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 34);
            this.btnExit.TabIndex = 3;
            this.ToolTipWorkBook.SetToolTip(this.btnExit, "خروج");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaritalStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMaritalStatus.Enabled = false;
            this.cmbMaritalStatus.Location = new System.Drawing.Point(509, 77);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMaritalStatus.Size = new System.Drawing.Size(146, 21);
            this.cmbMaritalStatus.TabIndex = 7;
            this.cmbMaritalStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaritalStatus_KeyDown);
            // 
            // cmbEmployeeStatus
            // 
            this.cmbEmployeeStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEmployeeStatus.Location = new System.Drawing.Point(114, 110);
            this.cmbEmployeeStatus.Name = "cmbEmployeeStatus";
            this.cmbEmployeeStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmployeeStatus.Size = new System.Drawing.Size(217, 21);
            this.cmbEmployeeStatus.TabIndex = 8;
            this.cmbEmployeeStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployeeStatus_KeyDown);
            // 
            // CHelpPopupSecondaryAccidentDetail
            // 
            this.CHelpPopupSecondaryAccidentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CHelpPopupSecondaryAccidentDetail.BackColor = System.Drawing.SystemColors.Info;
            this.CHelpPopupSecondaryAccidentDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CHelpPopupSecondaryAccidentDetail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CHelpPopupSecondaryAccidentDetail.Location = new System.Drawing.Point(433, 15);
            this.CHelpPopupSecondaryAccidentDetail.Name = "CHelpPopupSecondaryAccidentDetail";
            this.CHelpPopupSecondaryAccidentDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CHelpPopupSecondaryAccidentDetail.Size = new System.Drawing.Size(75, 23);
            this.CHelpPopupSecondaryAccidentDetail.TabIndex = 422;
            this.CHelpPopupSecondaryAccidentDetail.TabStop = false;
            this.CHelpPopupSecondaryAccidentDetail.Visible = false;
            // 
            // btnPersonelAccident
            // 
            this.btnPersonelAccident.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonelAccident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelAccident.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelAccident.Image")));
            this.btnPersonelAccident.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelAccident.Location = new System.Drawing.Point(134, 318);
            this.btnPersonelAccident.Name = "btnPersonelAccident";
            this.btnPersonelAccident.Size = new System.Drawing.Size(113, 24);
            this.btnPersonelAccident.TabIndex = 18;
            this.btnPersonelAccident.TabStop = false;
            this.btnPersonelAccident.Text = "حوادث";
            this.btnPersonelAccident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelAccident.Click += new System.EventHandler(this.btnPersonelAccident_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScore.Image = ((System.Drawing.Image)(resources.GetObject("btnScore.Image")));
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScore.Location = new System.Drawing.Point(339, 332);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(113, 24);
            this.btnScore.TabIndex = 25;
            this.btnScore.TabStop = false;
            this.btnScore.Text = "نمرات";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPersonelTraining
            // 
            this.btnPersonelTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonelTraining.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelTraining.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelTraining.Image")));
            this.btnPersonelTraining.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelTraining.Location = new System.Drawing.Point(134, 348);
            this.btnPersonelTraining.Name = "btnPersonelTraining";
            this.btnPersonelTraining.Size = new System.Drawing.Size(113, 24);
            this.btnPersonelTraining.TabIndex = 22;
            this.btnPersonelTraining.TabStop = false;
            this.btnPersonelTraining.Text = "وضعیت آموزشی";
            this.btnPersonelTraining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelTraining.Click += new System.EventHandler(this.btnPersonelTraining_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnOperation.Image")));
            this.btnOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOperation.Location = new System.Drawing.Point(15, 318);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(113, 24);
            this.btnOperation.TabIndex = 17;
            this.btnOperation.TabStop = false;
            this.btnOperation.Text = "عملکرد";
            this.btnOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnPrefermentHistory
            // 
            this.btnPrefermentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrefermentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrefermentHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnPrefermentHistory.Image")));
            this.btnPrefermentHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrefermentHistory.Location = new System.Drawing.Point(545, 348);
            this.btnPrefermentHistory.Name = "btnPrefermentHistory";
            this.btnPrefermentHistory.Size = new System.Drawing.Size(113, 24);
            this.btnPrefermentHistory.TabIndex = 23;
            this.btnPrefermentHistory.TabStop = false;
            this.btnPrefermentHistory.Text = "ارتقاء شغلی";
            this.btnPrefermentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrefermentHistory.Click += new System.EventHandler(this.btnPrefermentHistory_Click);
            // 
            // btnEulogy
            // 
            this.btnEulogy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEulogy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEulogy.Image = ((System.Drawing.Image)(resources.GetObject("btnEulogy.Image")));
            this.btnEulogy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEulogy.Location = new System.Drawing.Point(545, 318);
            this.btnEulogy.Name = "btnEulogy";
            this.btnEulogy.Size = new System.Drawing.Size(113, 24);
            this.btnEulogy.TabIndex = 19;
            this.btnEulogy.TabStop = false;
            this.btnEulogy.Text = "تشویق";
            this.btnEulogy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEulogy.Click += new System.EventHandler(this.btnEulogy_Click);
            // 
            // btnBodilyMentalStatus
            // 
            this.btnBodilyMentalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBodilyMentalStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBodilyMentalStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnBodilyMentalStatus.Image")));
            this.btnBodilyMentalStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBodilyMentalStatus.Location = new System.Drawing.Point(15, 348);
            this.btnBodilyMentalStatus.Name = "btnBodilyMentalStatus";
            this.btnBodilyMentalStatus.Size = new System.Drawing.Size(113, 24);
            this.btnBodilyMentalStatus.TabIndex = 21;
            this.btnBodilyMentalStatus.TabStop = false;
            this.btnBodilyMentalStatus.Text = "وضعیت جسمانی";
            this.btnBodilyMentalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBodilyMentalStatus.Click += new System.EventHandler(this.btnBodilyMentalStatus_Click);
            // 
            // btnChastise
            // 
            this.btnChastise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChastise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChastise.Image = ((System.Drawing.Image)(resources.GetObject("btnChastise.Image")));
            this.btnChastise.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChastise.Location = new System.Drawing.Point(664, 318);
            this.btnChastise.Name = "btnChastise";
            this.btnChastise.Size = new System.Drawing.Size(113, 24);
            this.btnChastise.TabIndex = 20;
            this.btnChastise.TabStop = false;
            this.btnChastise.Text = "تنبیهات";
            this.btnChastise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChastise.Click += new System.EventHandler(this.btnChastise_Click);
            // 
            // btnUniqueCode
            // 
            this.btnUniqueCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUniqueCode.Image = ((System.Drawing.Image)(resources.GetObject("btnUniqueCode.Image")));
            this.btnUniqueCode.Location = new System.Drawing.Point(307, 14);
            this.btnUniqueCode.Name = "btnUniqueCode";
            this.btnUniqueCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUniqueCode.Size = new System.Drawing.Size(24, 21);
            this.btnUniqueCode.TabIndex = 1;
            this.btnUniqueCode.TabStop = false;
            this.btnUniqueCode.Click += new System.EventHandler(this.btnUniqueCode_Click);
            // 
            // txtEmployeeDate
            // 
            this.txtEmployeeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeDate.Enabled = false;
            this.txtEmployeeDate.Location = new System.Drawing.Point(509, 110);
            this.txtEmployeeDate.Name = "txtEmployeeDate";
            this.txtEmployeeDate.Readonly = true;
            this.txtEmployeeDate.Size = new System.Drawing.Size(146, 20);
            this.txtEmployeeDate.TabIndex = 9;
            // 
            // cboOrgUnit
            // 
            this.cboOrgUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrgUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOrgUnit.Location = new System.Drawing.Point(509, 142);
            this.cboOrgUnit.Name = "cboOrgUnit";
            this.cboOrgUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboOrgUnit.Size = new System.Drawing.Size(269, 21);
            this.cboOrgUnit.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 146);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 444;
            this.label12.Text = "محل کار";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.CHelpPopupSecondaryAccidentDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 50);
            this.panel1.TabIndex = 25;
            // 
            // btnPersonelJobStatus
            // 
            this.btnPersonelJobStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonelJobStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelJobStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelJobStatus.Image")));
            this.btnPersonelJobStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelJobStatus.Location = new System.Drawing.Point(664, 348);
            this.btnPersonelJobStatus.Name = "btnPersonelJobStatus";
            this.btnPersonelJobStatus.Size = new System.Drawing.Size(113, 24);
            this.btnPersonelJobStatus.TabIndex = 24;
            this.btnPersonelJobStatus.TabStop = false;
            this.btnPersonelJobStatus.Text = "وضعیت اشتغال";
            this.btnPersonelJobStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelJobStatus.Click += new System.EventHandler(this.btnPersonelJobStatus_Click);
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalCode.Location = new System.Drawing.Point(115, 208);
            this.txtNationalCode.MaxLength = 9;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalCode.Size = new System.Drawing.Size(217, 21);
            this.txtNationalCode.strVal = "";
            this.txtNationalCode.TabIndex = 13;
            this.txtNationalCode.Text = "0";
            this.txtNationalCode.Value = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 212);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 448;
            this.label15.Text = "کد ملی";
            // 
            // txtFather
            // 
            this.txtFather.BackColor = System.Drawing.SystemColors.Window;
            this.txtFather.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFather.Location = new System.Drawing.Point(509, 176);
            this.txtFather.MaxLength = 50;
            this.txtFather.Name = "txtFather";
            this.txtFather.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFather.Size = new System.Drawing.Size(146, 21);
            this.txtFather.TabIndex = 451;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(467, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 13);
            this.label26.TabIndex = 452;
            this.label26.Text = "نام پدر";
            // 
            // frmWorkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(790, 433);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnPersonelJobStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboOrgUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmployeeDate);
            this.Controls.Add(this.cmbStudyStatus);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtIDNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtContractor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtJobHistory);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtUniqueCode);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersonelAccident);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPersonelTraining);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnPrefermentHistory);
            this.Controls.Add(this.btnEulogy);
            this.Controls.Add(this.btnBodilyMentalStatus);
            this.Controls.Add(this.btnChastise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnUniqueCode);
            this.Controls.Add(this.lblPersonelName);
            this.Controls.Add(this.cmbMaritalStatus);
            this.Controls.Add(this.cmbEmployeeStatus);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmWorkBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کارنامه ایمنی";
            this.Load += new System.EventHandler(this.frmWorkBook_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmWorkBook_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmWorkBook_KeyUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private combo.MyComboBox cmbStudyStatus;
        private combo.MyComboBox cmbJob;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label label14;
        private ProgLib.Components.CNTextBox txtTelNo;
        private ProgLib.Components.CNTextBox txtIDNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ImageList imglstWorkBook;
        private System.Windows.Forms.TextBox txtContractor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private ProgLib.Components.CNTextBox txtJobHistory;
        private ProgLib.Components.CNTextBox txtBirthYear;
        private ProgLib.Components.CNTextBox txtPersonelID;
        private ProgLib.Components.CNTextBox txtUniqueCode;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelAccident;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPersonelTraining;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnPrefermentHistory;
        private System.Windows.Forms.Button btnEulogy;
        private System.Windows.Forms.Button btnBodilyMentalStatus;
        private System.Windows.Forms.Button btnChastise;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnUniqueCode;
        private System.Windows.Forms.Label lblPersonelName;
        private System.Windows.Forms.ToolTip ToolTipWorkBook;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.ComboBox cmbEmployeeStatus;
        private ProgLib.Components.CHelpPopup CHelpPopupSecondaryAccidentDetail;
        private FarsiLibrary.Win.Controls.FADatePicker txtEmployeeDate;
        private System.Windows.Forms.ComboBox cboOrgUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPersonelJobStatus;
        private ProgLib.Components.CNTextBox txtNationalCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.Label label26;
    }
}