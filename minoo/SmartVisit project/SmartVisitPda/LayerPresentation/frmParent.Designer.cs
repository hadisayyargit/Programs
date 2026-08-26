namespace layerPresentation
{
    partial class frmParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("مشخصات کالا");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("مشخصات مشتری");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("درخواستهای ثبت شده");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("درخواستهای مرجوعی");
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.tpgOrder = new System.Windows.Forms.TabPage();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.lbItemCount = new System.Windows.Forms.Label();
            this.txtMoshtarino = new System.Windows.Forms.TextBox();
            this.ibtnInfoMoshtari = new HControls.HImageButton();
            this.ibtnSearchMoshtari = new HControls.HImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnDetail = new HControls.HImageButton();
            this.ibtnMarjooee = new HControls.HImageButton();
            this.ibtnGprs = new HControls.HImageButton();
            this.ibtnSms = new HControls.HImageButton();
            this.ibtnDelete = new HControls.HImageButton();
            this.ibtnSave = new HControls.HImageButton();
            this.ibtnNew = new HControls.HImageButton();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.txtOrderType = new System.Windows.Forms.TextBox();
            this.txtMoshtarids = new System.Windows.Forms.TextBox();
            this.cboKanalForoosh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtMoshtariInfosn = new System.Windows.Forms.TextBox();
            this.panMarjooee = new System.Windows.Forms.Panel();
            this.txtDalilMarjoo = new System.Windows.Forms.TextBox();
            this.txtFactorMarjoo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelPayType = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoPayType0 = new System.Windows.Forms.RadioButton();
            this.rdoPayType1 = new System.Windows.Forms.RadioButton();
            this.txtModatvosool = new System.Windows.Forms.TextBox();
            this.cboNoeTahvil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpgReport = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.grdDarkhast = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.colDarkhastSn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colDarkhastDate = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colMoshtariDs = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colMoshtarino = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colMoshtariInfoSn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colDarkhastStatus = new System.Windows.Forms.DataGridTextBoxColumn();
            this.treeReport = new System.Windows.Forms.TreeView();
            this.tpgTools = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReadSms = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tpgHelp = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.lbTitr = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelMain = new System.Windows.Forms.Panel();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.tpgOrder.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMarjooee.SuspendLayout();
            this.panelPayType.SuspendLayout();
            this.tpgReport.SuspendLayout();
            this.tpgTools.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpgHelp.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgOrder
            // 
            this.tpgOrder.Controls.Add(this.panelMaster);
            this.tpgOrder.Location = new System.Drawing.Point(0, 0);
            this.tpgOrder.Name = "tpgOrder";
            this.tpgOrder.Size = new System.Drawing.Size(477, 492);
            this.tpgOrder.Text = "سربرگ";
            // 
            // panelMaster
            // 
            this.panelMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaster.Controls.Add(this.lbItemCount);
            this.panelMaster.Controls.Add(this.txtMoshtarino);
            this.panelMaster.Controls.Add(this.ibtnInfoMoshtari);
            this.panelMaster.Controls.Add(this.ibtnSearchMoshtari);
            this.panelMaster.Controls.Add(this.label2);
            this.panelMaster.Controls.Add(this.panel1);
            this.panelMaster.Controls.Add(this.txtTotalOrder);
            this.panelMaster.Controls.Add(this.txtOrderType);
            this.panelMaster.Controls.Add(this.txtMoshtarids);
            this.panelMaster.Controls.Add(this.cboKanalForoosh);
            this.panelMaster.Controls.Add(this.label11);
            this.panelMaster.Controls.Add(this.txtPdate);
            this.panelMaster.Controls.Add(this.label1);
            this.panelMaster.Controls.Add(this.txtOrderId);
            this.panelMaster.Controls.Add(this.txtMoshtariInfosn);
            this.panelMaster.Controls.Add(this.panMarjooee);
            this.panelMaster.Controls.Add(this.panelPayType);
            this.panelMaster.Location = new System.Drawing.Point(6, 3);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(460, 479);
            // 
            // lbItemCount
            // 
            this.lbItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbItemCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbItemCount.Location = new System.Drawing.Point(165, 16);
            this.lbItemCount.Name = "lbItemCount";
            this.lbItemCount.Size = new System.Drawing.Size(42, 38);
            this.lbItemCount.Text = "0";
            this.lbItemCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMoshtarino
            // 
            this.txtMoshtarino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoshtarino.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtMoshtarino.Location = new System.Drawing.Point(103, 69);
            this.txtMoshtarino.Name = "txtMoshtarino";
            this.txtMoshtarino.Size = new System.Drawing.Size(228, 38);
            this.txtMoshtarino.TabIndex = 21;
            this.txtMoshtarino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoshtarino_KeyPress);
            // 
            // ibtnInfoMoshtari
            // 
            this.ibtnInfoMoshtari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibtnInfoMoshtari.Image = ((System.Drawing.Image)(resources.GetObject("ibtnInfoMoshtari.Image")));
            this.ibtnInfoMoshtari.Location = new System.Drawing.Point(14, 69);
            this.ibtnInfoMoshtari.Name = "ibtnInfoMoshtari";
            this.ibtnInfoMoshtari.Size = new System.Drawing.Size(40, 38);
            this.ibtnInfoMoshtari.TabIndex = 15;
            this.ibtnInfoMoshtari.Click += new System.EventHandler(this.ibtnInfoMoshtari_Click);
            // 
            // ibtnSearchMoshtari
            // 
            this.ibtnSearchMoshtari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibtnSearchMoshtari.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearchMoshtari.Image")));
            this.ibtnSearchMoshtari.Location = new System.Drawing.Point(60, 69);
            this.ibtnSearchMoshtari.Name = "ibtnSearchMoshtari";
            this.ibtnSearchMoshtari.Size = new System.Drawing.Size(40, 38);
            this.ibtnSearchMoshtari.TabIndex = 14;
            this.ibtnSearchMoshtari.Click += new System.EventHandler(this.ibtnSearchMoshtari_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(337, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 33);
            this.label2.Text = "نام مشتری";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ibtnDetail);
            this.panel1.Controls.Add(this.ibtnMarjooee);
            this.panel1.Controls.Add(this.ibtnGprs);
            this.panel1.Controls.Add(this.ibtnSms);
            this.panel1.Controls.Add(this.ibtnDelete);
            this.panel1.Controls.Add(this.ibtnSave);
            this.panel1.Controls.Add(this.ibtnNew);
            this.panel1.Location = new System.Drawing.Point(8, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 57);
            // 
            // ibtnDetail
            // 
            this.ibtnDetail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnDetail.Image = ((System.Drawing.Image)(resources.GetObject("ibtnDetail.Image")));
            this.ibtnDetail.Location = new System.Drawing.Point(5, 4);
            this.ibtnDetail.Name = "ibtnDetail";
            this.ibtnDetail.Size = new System.Drawing.Size(68, 48);
            this.ibtnDetail.TabIndex = 13;
            this.ibtnDetail.Click += new System.EventHandler(this.ibtnDetail_Click);
            // 
            // ibtnMarjooee
            // 
            this.ibtnMarjooee.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnMarjooee.Image = ((System.Drawing.Image)(resources.GetObject("ibtnMarjooee.Image")));
            this.ibtnMarjooee.Location = new System.Drawing.Point(111, 4);
            this.ibtnMarjooee.Name = "ibtnMarjooee";
            this.ibtnMarjooee.Size = new System.Drawing.Size(48, 48);
            this.ibtnMarjooee.TabIndex = 12;
            this.ibtnMarjooee.Click += new System.EventHandler(this.ibtnMarjooee_Click);
            // 
            // ibtnGprs
            // 
            this.ibtnGprs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnGprs.Image = ((System.Drawing.Image)(resources.GetObject("ibtnGprs.Image")));
            this.ibtnGprs.Location = new System.Drawing.Point(225, 4);
            this.ibtnGprs.Name = "ibtnGprs";
            this.ibtnGprs.Size = new System.Drawing.Size(48, 48);
            this.ibtnGprs.TabIndex = 11;
            this.ibtnGprs.Click += new System.EventHandler(this.ibtnGprs_Click);
            // 
            // ibtnSms
            // 
            this.ibtnSms.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnSms.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSms.Image")));
            this.ibtnSms.Location = new System.Drawing.Point(168, 4);
            this.ibtnSms.Name = "ibtnSms";
            this.ibtnSms.Size = new System.Drawing.Size(48, 48);
            this.ibtnSms.TabIndex = 10;
            this.ibtnSms.Click += new System.EventHandler(this.ibtnSms_Click);
            // 
            // ibtnDelete
            // 
            this.ibtnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ibtnDelete.Image")));
            this.ibtnDelete.Location = new System.Drawing.Point(282, 4);
            this.ibtnDelete.Name = "ibtnDelete";
            this.ibtnDelete.Size = new System.Drawing.Size(48, 48);
            this.ibtnDelete.TabIndex = 9;
            this.ibtnDelete.Click += new System.EventHandler(this.ibtnDelete_Click);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSave.Image")));
            this.ibtnSave.Location = new System.Drawing.Point(339, 4);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(48, 48);
            this.ibtnSave.TabIndex = 8;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // ibtnNew
            // 
            this.ibtnNew.Image = ((System.Drawing.Image)(resources.GetObject("ibtnNew.Image")));
            this.ibtnNew.Location = new System.Drawing.Point(396, 4);
            this.ibtnNew.Name = "ibtnNew";
            this.ibtnNew.Size = new System.Drawing.Size(48, 48);
            this.ibtnNew.TabIndex = 7;
            this.ibtnNew.Click += new System.EventHandler(this.ibtnNew_Click);
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalOrder.BackColor = System.Drawing.Color.LightGray;
            this.txtTotalOrder.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtTotalOrder.Location = new System.Drawing.Point(266, 16);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(65, 38);
            this.txtTotalOrder.TabIndex = 2;
            // 
            // txtOrderType
            // 
            this.txtOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderType.BackColor = System.Drawing.Color.LightGray;
            this.txtOrderType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtOrderType.ForeColor = System.Drawing.Color.Blue;
            this.txtOrderType.Location = new System.Drawing.Point(408, 16);
            this.txtOrderType.Name = "txtOrderType";
            this.txtOrderType.ReadOnly = true;
            this.txtOrderType.Size = new System.Drawing.Size(34, 38);
            this.txtOrderType.TabIndex = 0;
            this.txtOrderType.Text = "ف";
            // 
            // txtMoshtarids
            // 
            this.txtMoshtarids.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoshtarids.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtMoshtarids.Location = new System.Drawing.Point(14, 129);
            this.txtMoshtarids.Name = "txtMoshtarids";
            this.txtMoshtarids.ReadOnly = true;
            this.txtMoshtarids.Size = new System.Drawing.Size(317, 38);
            this.txtMoshtarids.TabIndex = 7;
            // 
            // cboKanalForoosh
            // 
            this.cboKanalForoosh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKanalForoosh.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cboKanalForoosh.Location = new System.Drawing.Point(14, 184);
            this.cboKanalForoosh.Name = "cboKanalForoosh";
            this.cboKanalForoosh.Size = new System.Drawing.Size(317, 38);
            this.cboKanalForoosh.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(337, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 28);
            this.label11.Text = "کانال فروش";
            // 
            // txtPdate
            // 
            this.txtPdate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtPdate.Location = new System.Drawing.Point(14, 16);
            this.txtPdate.MaxLength = 10;
            this.txtPdate.Name = "txtPdate";
            this.txtPdate.Size = new System.Drawing.Size(144, 38);
            this.txtPdate.TabIndex = 3;
            this.txtPdate.Text = "1389/11/04";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(337, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.Text = "کد مشتری";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.BackColor = System.Drawing.Color.LightGray;
            this.txtOrderId.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtOrderId.Location = new System.Drawing.Point(337, 16);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(65, 38);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtMoshtariInfosn
            // 
            this.txtMoshtariInfosn.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMoshtariInfosn.Location = new System.Drawing.Point(90, 157);
            this.txtMoshtariInfosn.Name = "txtMoshtariInfosn";
            this.txtMoshtariInfosn.Size = new System.Drawing.Size(36, 35);
            this.txtMoshtariInfosn.TabIndex = 5;
            this.txtMoshtariInfosn.Visible = false;
            // 
            // panMarjooee
            // 
            this.panMarjooee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panMarjooee.Controls.Add(this.txtDalilMarjoo);
            this.panMarjooee.Controls.Add(this.txtFactorMarjoo);
            this.panMarjooee.Controls.Add(this.label13);
            this.panMarjooee.Controls.Add(this.label12);
            this.panMarjooee.Location = new System.Drawing.Point(1, 230);
            this.panMarjooee.Name = "panMarjooee";
            this.panMarjooee.Size = new System.Drawing.Size(451, 54);
            this.panMarjooee.Visible = false;
            // 
            // txtDalilMarjoo
            // 
            this.txtDalilMarjoo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDalilMarjoo.Location = new System.Drawing.Point(13, 7);
            this.txtDalilMarjoo.Name = "txtDalilMarjoo";
            this.txtDalilMarjoo.Size = new System.Drawing.Size(89, 38);
            this.txtDalilMarjoo.TabIndex = 12;
            // 
            // txtFactorMarjoo
            // 
            this.txtFactorMarjoo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFactorMarjoo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtFactorMarjoo.Location = new System.Drawing.Point(175, 7);
            this.txtFactorMarjoo.Name = "txtFactorMarjoo";
            this.txtFactorMarjoo.Size = new System.Drawing.Size(155, 38);
            this.txtFactorMarjoo.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label13.Location = new System.Drawing.Point(336, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 30);
            this.label13.Text = "فاکتور";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(108, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 32);
            this.label12.Text = "علت";
            // 
            // panelPayType
            // 
            this.panelPayType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPayType.Controls.Add(this.label5);
            this.panelPayType.Controls.Add(this.rdoPayType0);
            this.panelPayType.Controls.Add(this.rdoPayType1);
            this.panelPayType.Controls.Add(this.txtModatvosool);
            this.panelPayType.Controls.Add(this.cboNoeTahvil);
            this.panelPayType.Controls.Add(this.label6);
            this.panelPayType.Controls.Add(this.label4);
            this.panelPayType.Location = new System.Drawing.Point(1, 231);
            this.panelPayType.Name = "panelPayType";
            this.panelPayType.Size = new System.Drawing.Size(454, 163);
            this.panelPayType.Tag = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(334, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.Text = "نوع پرداخت";
            // 
            // rdoPayType0
            // 
            this.rdoPayType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoPayType0.Checked = true;
            this.rdoPayType0.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rdoPayType0.Location = new System.Drawing.Point(248, 69);
            this.rdoPayType0.Name = "rdoPayType0";
            this.rdoPayType0.Size = new System.Drawing.Size(80, 30);
            this.rdoPayType0.TabIndex = 9;
            this.rdoPayType0.Text = "نقدی";
            this.rdoPayType0.CheckedChanged += new System.EventHandler(this.rdoPayType0_CheckedChanged);
            // 
            // rdoPayType1
            // 
            this.rdoPayType1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.rdoPayType1.Location = new System.Drawing.Point(82, 69);
            this.rdoPayType1.Name = "rdoPayType1";
            this.rdoPayType1.Size = new System.Drawing.Size(124, 30);
            this.rdoPayType1.TabIndex = 10;
            this.rdoPayType1.TabStop = false;
            this.rdoPayType1.Text = "غیرنقدی";
            this.rdoPayType1.CheckedChanged += new System.EventHandler(this.rdoPayType1_CheckedChanged);
            // 
            // txtModatvosool
            // 
            this.txtModatvosool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModatvosool.Enabled = false;
            this.txtModatvosool.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtModatvosool.Location = new System.Drawing.Point(248, 117);
            this.txtModatvosool.MaxLength = 3;
            this.txtModatvosool.Name = "txtModatvosool";
            this.txtModatvosool.Size = new System.Drawing.Size(45, 38);
            this.txtModatvosool.TabIndex = 11;
            this.txtModatvosool.Text = "0";
            // 
            // cboNoeTahvil
            // 
            this.cboNoeTahvil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNoeTahvil.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cboNoeTahvil.Location = new System.Drawing.Point(13, 12);
            this.cboNoeTahvil.Name = "cboNoeTahvil";
            this.cboNoeTahvil.Size = new System.Drawing.Size(315, 38);
            this.cboNoeTahvil.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(309, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.Text = "مدت پرداخت";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(339, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.Text = "نوع تحویل";
            // 
            // tpgReport
            // 
            this.tpgReport.Controls.Add(this.btnReport);
            this.tpgReport.Controls.Add(this.grdDarkhast);
            this.tpgReport.Controls.Add(this.treeReport);
            this.tpgReport.Location = new System.Drawing.Point(0, 0);
            this.tpgReport.Name = "tpgReport";
            this.tpgReport.Size = new System.Drawing.Size(469, 498);
            this.tpgReport.Text = "گزارش";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnReport.Location = new System.Drawing.Point(164, 440);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 40);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "مشاهده";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grdDarkhast
            // 
            this.grdDarkhast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDarkhast.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdDarkhast.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.grdDarkhast.Location = new System.Drawing.Point(11, 229);
            this.grdDarkhast.Name = "grdDarkhast";
            this.grdDarkhast.Size = new System.Drawing.Size(456, 205);
            this.grdDarkhast.TabIndex = 1;
            this.grdDarkhast.TableStyles.Add(this.dataGridTableStyle1);
            this.grdDarkhast.DoubleClick += new System.EventHandler(this.grdDarkhast_DoubleClick);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colDarkhastSn);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colDarkhastDate);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colMoshtariDs);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colMoshtarino);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colMoshtariInfoSn);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.colDarkhastStatus);
            // 
            // colDarkhastSn
            // 
            this.colDarkhastSn.Format = "";
            this.colDarkhastSn.FormatInfo = null;
            this.colDarkhastSn.HeaderText = "شماره درخواست";
            this.colDarkhastSn.MappingName = "darkhastsn";
            this.colDarkhastSn.Width = 180;
            // 
            // colDarkhastDate
            // 
            this.colDarkhastDate.Format = "";
            this.colDarkhastDate.FormatInfo = null;
            this.colDarkhastDate.HeaderText = "تاریخ";
            this.colDarkhastDate.MappingName = "darkhastdate";
            this.colDarkhastDate.Width = 100;
            // 
            // colMoshtariDs
            // 
            this.colMoshtariDs.Format = "";
            this.colMoshtariDs.FormatInfo = null;
            this.colMoshtariDs.HeaderText = "نام مشتری";
            this.colMoshtariDs.MappingName = "moshtarids";
            this.colMoshtariDs.Width = 150;
            // 
            // colMoshtarino
            // 
            this.colMoshtarino.Format = "";
            this.colMoshtarino.FormatInfo = null;
            this.colMoshtarino.HeaderText = "شماره مشتری";
            this.colMoshtarino.MappingName = "moshtarino";
            this.colMoshtarino.Width = 150;
            // 
            // colMoshtariInfoSn
            // 
            this.colMoshtariInfoSn.Format = "";
            this.colMoshtariInfoSn.FormatInfo = null;
            this.colMoshtariInfoSn.HeaderText = "کد مشتری";
            this.colMoshtariInfoSn.MappingName = "moshtariinfosn";
            this.colMoshtariInfoSn.Width = 0;
            // 
            // colDarkhastStatus
            // 
            this.colDarkhastStatus.Format = "";
            this.colDarkhastStatus.FormatInfo = null;
            this.colDarkhastStatus.HeaderText = "وضعیت";
            this.colDarkhastStatus.MappingName = "packetstatusds";
            this.colDarkhastStatus.Width = 200;
            // 
            // treeReport
            // 
            this.treeReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeReport.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.treeReport.Location = new System.Drawing.Point(9, 14);
            this.treeReport.Name = "treeReport";
            treeNode5.Tag = "nodKala";
            treeNode5.Text = "مشخصات کالا";
            treeNode6.Tag = "nodMoshtari";
            treeNode6.Text = "مشخصات مشتری";
            treeNode7.Tag = "nodOrder";
            treeNode7.Text = "درخواستهای ثبت شده";
            treeNode8.Tag = "nodMarjoo";
            treeNode8.Text = "درخواستهای مرجوعی";
            this.treeReport.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeReport.Size = new System.Drawing.Size(456, 209);
            this.treeReport.TabIndex = 0;
            this.treeReport.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeReport_AfterSelect);
            // 
            // tpgTools
            // 
            this.tpgTools.Controls.Add(this.panel2);
            this.tpgTools.Location = new System.Drawing.Point(0, 0);
            this.tpgTools.Name = "tpgTools";
            this.tpgTools.Size = new System.Drawing.Size(469, 498);
            this.tpgTools.Text = "ابزار";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnReadSms);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.btnSync);
            this.panel2.Controls.Add(this.btnRestore);
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Location = new System.Drawing.Point(14, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 456);
            // 
            // btnReadSms
            // 
            this.btnReadSms.Location = new System.Drawing.Point(94, 278);
            this.btnReadSms.Name = "btnReadSms";
            this.btnReadSms.Size = new System.Drawing.Size(268, 40);
            this.btnReadSms.TabIndex = 8;
            this.btnReadSms.Text = "خواندن پیامک";
            this.btnReadSms.Click += new System.EventHandler(this.btnReadSms_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(94, 324);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(268, 40);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "تنظیمات";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(94, 46);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(268, 40);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "تهیه پشتیبان";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(94, 232);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(268, 40);
            this.btnSync.TabIndex = 6;
            this.btnSync.Text = "تبادل اطلاعات";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(94, 92);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(268, 40);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "بازیابی پشتیبان";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(94, 186);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(268, 40);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "تغییر گذرواژه";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tpgHelp
            // 
            this.tpgHelp.Controls.Add(this.pictureBox2);
            this.tpgHelp.Controls.Add(this.lbVersion);
            this.tpgHelp.Controls.Add(this.linkHelp);
            this.tpgHelp.Controls.Add(this.lbTitr);
            this.tpgHelp.Location = new System.Drawing.Point(0, 0);
            this.tpgHelp.Name = "tpgHelp";
            this.tpgHelp.Size = new System.Drawing.Size(477, 492);
            this.tpgHelp.Text = "کمک";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lbVersion
            // 
            this.lbVersion.Location = new System.Drawing.Point(245, 93);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(140, 34);
            this.lbVersion.Text = "نسخه1.4.0";
            // 
            // linkHelp
            // 
            this.linkHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkHelp.Location = new System.Drawing.Point(361, 440);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(98, 40);
            this.linkHelp.TabIndex = 1;
            this.linkHelp.Text = "راهنما";
            this.linkHelp.Click += new System.EventHandler(this.linkHelp_Click);
            // 
            // lbTitr
            // 
            this.lbTitr.Location = new System.Drawing.Point(153, 39);
            this.lbTitr.Name = "lbTitr";
            this.lbTitr.Size = new System.Drawing.Size(317, 54);
            this.lbTitr.Text = "سامانه ثبت سفارش هوشمند";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tpgHelp);
            this.tabControlMain.Controls.Add(this.tpgTools);
            this.tabControlMain.Controls.Add(this.tpgReport);
            this.tabControlMain.Controls.Add(this.tpgOrder);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(477, 536);
            this.tabControlMain.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource2"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource5"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource7"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource8"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource9"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource10"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource11"))));
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Sql Mobile Database files|*.sdf";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.tabControlMain);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(477, 536);
            // 
            // inputPanel1
            // 
            this.inputPanel1.EnabledChanged += new System.EventHandler(this.inputPanel1_EnabledChanged);
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmParent";
            this.Text = "سفارش هوشمند";
            this.Load += new System.EventHandler(this.frmParent_Load);
            this.Closed += new System.EventHandler(this.frmParent_Closed);
            this.Activated += new System.EventHandler(this.frmParent_Activated);
            this.GotFocus += new System.EventHandler(this.frmParent_GotFocus);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmParent_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmParent_KeyDown);
            this.tpgOrder.ResumeLayout(false);
            this.panelMaster.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panMarjooee.ResumeLayout(false);
            this.panelPayType.ResumeLayout(false);
            this.tpgReport.ResumeLayout(false);
            this.tpgTools.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpgHelp.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.TabPage tpgOrder;
        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.ComboBox cboNoeTahvil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPayType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoPayType0;
        private System.Windows.Forms.RadioButton rdoPayType1;
        private System.Windows.Forms.TextBox txtPdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TabPage tpgReport;
        private System.Windows.Forms.TreeView treeReport;
        private System.Windows.Forms.TabPage tpgTools;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TabPage tpgHelp;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Label lbTitr;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TextBox txtModatvosool;
        private System.Windows.Forms.ComboBox cboKanalForoosh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panMarjooee;
        private System.Windows.Forms.TextBox txtFactorMarjoo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDalilMarjoo;
        private System.Windows.Forms.TextBox txtMoshtarids;
        private System.Windows.Forms.TextBox txtMoshtariInfosn;
        private System.Windows.Forms.TextBox txtOrderType;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGrid grdDarkhast;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn colDarkhastSn;
        private System.Windows.Forms.DataGridTextBoxColumn colDarkhastDate;
        private System.Windows.Forms.DataGridTextBoxColumn colMoshtariDs;
        private System.Windows.Forms.DataGridTextBoxColumn colMoshtariInfoSn;
        private System.Windows.Forms.DataGridTextBoxColumn colMoshtarino;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private HControls.HImageButton ibtnNew;
        private System.Windows.Forms.ImageList imageList1;
        private HControls.HImageButton ibtnSave;
        private HControls.HImageButton ibtnDelete;
        private HControls.HImageButton ibtnDetail;
        private HControls.HImageButton ibtnMarjooee;
        private HControls.HImageButton ibtnGprs;
        private HControls.HImageButton ibtnSms;
        private HControls.HImageButton ibtnInfoMoshtari;
        private HControls.HImageButton ibtnSearchMoshtari;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSetting;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.TextBox txtMoshtarino;
        private System.Windows.Forms.Label lbItemCount;
        private System.Windows.Forms.DataGridTextBoxColumn colDarkhastStatus;
        private System.Windows.Forms.Button btnReadSms;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

