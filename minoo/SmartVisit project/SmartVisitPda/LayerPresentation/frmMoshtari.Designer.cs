namespace layerPresentation
{
    partial class frmMoshtari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mniClose = new System.Windows.Forms.MenuItem();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.grdMoshtari = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cboMasir = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txtCountMoavagh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCountBargashti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMandehMoavagh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMandehBargashti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMandehAsnadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobilephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMandehEtebar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoshtarids = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoshtarino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMaster.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mniClose);
            // 
            // mniClose
            // 
            this.mniClose.Text = "بازگشت";
            this.mniClose.Click += new System.EventHandler(this.mniClose_Click);
            // 
            // panelMaster
            // 
            this.panelMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMaster.Controls.Add(this.grdMoshtari);
            this.panelMaster.Controls.Add(this.cboMasir);
            this.panelMaster.Controls.Add(this.label11);
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(474, 530);
            // 
            // grdMoshtari
            // 
            this.grdMoshtari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMoshtari.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grdMoshtari.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdMoshtari.Location = new System.Drawing.Point(6, 64);
            this.grdMoshtari.Name = "grdMoshtari";
            this.grdMoshtari.Size = new System.Drawing.Size(463, 463);
            this.grdMoshtari.TabIndex = 37;
            this.grdMoshtari.TableStyles.Add(this.dataGridTableStyle1);
            this.grdMoshtari.DoubleClick += new System.EventHandler(this.grdMoshtari_DoubleClick);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "شماره مشتری";
            this.dataGridTextBoxColumn1.MappingName = "moshtarino";
            this.dataGridTextBoxColumn1.Width = 170;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "نام مشتری";
            this.dataGridTextBoxColumn2.MappingName = "moshtarids";
            this.dataGridTextBoxColumn2.Width = 200;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.MappingName = "moshtariinfosn";
            this.dataGridTextBoxColumn3.Width = 0;
            // 
            // cboMasir
            // 
            this.cboMasir.Location = new System.Drawing.Point(174, 14);
            this.cboMasir.Name = "cboMasir";
            this.cboMasir.Size = new System.Drawing.Size(230, 41);
            this.cboMasir.TabIndex = 35;
            this.cboMasir.SelectedIndexChanged += new System.EventHandler(this.cboMasir_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label11.Location = new System.Drawing.Point(410, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 30);
            this.label11.Text = "مسیر";
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.Controls.Add(this.txtCountMoavagh);
            this.panelDetail.Controls.Add(this.label13);
            this.panelDetail.Controls.Add(this.txtCountBargashti);
            this.panelDetail.Controls.Add(this.label12);
            this.panelDetail.Controls.Add(this.txtMandehMoavagh);
            this.panelDetail.Controls.Add(this.label9);
            this.panelDetail.Controls.Add(this.txtMandehBargashti);
            this.panelDetail.Controls.Add(this.label8);
            this.panelDetail.Controls.Add(this.txtMandehAsnadi);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.txtMobilephone);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.txtTel);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.txtMandehEtebar);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Controls.Add(this.txtAddress);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.txtMoshtarids);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.txtMoshtarino);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.chkStatus);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(474, 530);
            // 
            // txtCountMoavagh
            // 
            this.txtCountMoavagh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtCountMoavagh.Location = new System.Drawing.Point(174, 404);
            this.txtCountMoavagh.Name = "txtCountMoavagh";
            this.txtCountMoavagh.ReadOnly = true;
            this.txtCountMoavagh.Size = new System.Drawing.Size(131, 35);
            this.txtCountMoavagh.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label13.Location = new System.Drawing.Point(312, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 32);
            this.label13.Text = "تعداد فاکتور معوق:";
            // 
            // txtCountBargashti
            // 
            this.txtCountBargashti.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtCountBargashti.Location = new System.Drawing.Point(174, 445);
            this.txtCountBargashti.Name = "txtCountBargashti";
            this.txtCountBargashti.ReadOnly = true;
            this.txtCountBargashti.Size = new System.Drawing.Size(131, 35);
            this.txtCountBargashti.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(337, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 32);
            this.label12.Text = "چک برگشتی:";
            // 
            // txtMandehMoavagh
            // 
            this.txtMandehMoavagh.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMandehMoavagh.Location = new System.Drawing.Point(174, 363);
            this.txtMandehMoavagh.Name = "txtMandehMoavagh";
            this.txtMandehMoavagh.ReadOnly = true;
            this.txtMandehMoavagh.Size = new System.Drawing.Size(131, 35);
            this.txtMandehMoavagh.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(343, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 32);
            this.label9.Text = "مانده معوق:";
            // 
            // txtMandehBargashti
            // 
            this.txtMandehBargashti.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMandehBargashti.Location = new System.Drawing.Point(174, 281);
            this.txtMandehBargashti.Name = "txtMandehBargashti";
            this.txtMandehBargashti.ReadOnly = true;
            this.txtMandehBargashti.Size = new System.Drawing.Size(131, 35);
            this.txtMandehBargashti.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(337, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 32);
            this.label8.Text = "مانده برگشتی:";
            // 
            // txtMandehAsnadi
            // 
            this.txtMandehAsnadi.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMandehAsnadi.Location = new System.Drawing.Point(174, 322);
            this.txtMandehAsnadi.Name = "txtMandehAsnadi";
            this.txtMandehAsnadi.ReadOnly = true;
            this.txtMandehAsnadi.Size = new System.Drawing.Size(131, 35);
            this.txtMandehAsnadi.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(343, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 32);
            this.label7.Text = "مانده اسنادی:";
            // 
            // txtMobilephone
            // 
            this.txtMobilephone.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMobilephone.Location = new System.Drawing.Point(211, 114);
            this.txtMobilephone.Name = "txtMobilephone";
            this.txtMobilephone.ReadOnly = true;
            this.txtMobilephone.Size = new System.Drawing.Size(147, 35);
            this.txtMobilephone.TabIndex = 22;
            this.txtMobilephone.Text = "+989122108888";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(361, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.Text = "تلفن همراه:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtTel.Location = new System.Drawing.Point(6, 114);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(145, 35);
            this.txtTel.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(157, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 30);
            this.label5.Text = "تلفن:";
            // 
            // txtMandehEtebar
            // 
            this.txtMandehEtebar.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMandehEtebar.Location = new System.Drawing.Point(174, 240);
            this.txtMandehEtebar.Name = "txtMandehEtebar";
            this.txtMandehEtebar.ReadOnly = true;
            this.txtMandehEtebar.Size = new System.Drawing.Size(131, 35);
            this.txtMandehEtebar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(343, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.Text = "مانده اعتبار:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtAddress.Location = new System.Drawing.Point(6, 164);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(358, 59);
            this.txtAddress.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(379, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.Text = "آدرس:";
            // 
            // txtMoshtarids
            // 
            this.txtMoshtarids.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMoshtarids.Location = new System.Drawing.Point(6, 64);
            this.txtMoshtarids.Name = "txtMoshtarids";
            this.txtMoshtarids.ReadOnly = true;
            this.txtMoshtarids.Size = new System.Drawing.Size(352, 35);
            this.txtMoshtarids.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(370, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.Text = "نام:";
            // 
            // txtMoshtarino
            // 
            this.txtMoshtarino.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMoshtarino.Location = new System.Drawing.Point(237, 14);
            this.txtMoshtarino.Name = "txtMoshtarino";
            this.txtMoshtarino.ReadOnly = true;
            this.txtMoshtarino.Size = new System.Drawing.Size(121, 35);
            this.txtMoshtarino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(370, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.Text = "شماره مشتری";
            // 
            // chkStatus
            // 
            this.chkStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.chkStatus.Location = new System.Drawing.Point(15, 9);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(174, 40);
            this.chkStatus.TabIndex = 41;
            this.chkStatus.Text = "بلوکه شده";
            // 
            // inputPanel1
            // 
            this.inputPanel1.EnabledChanged += new System.EventHandler(this.inputPanel1_EnabledChanged);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelDetail);
            this.panelMain.Controls.Add(this.panelMaster);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 533);
            // 
            // frmMoshtari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmMoshtari";
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.frmMoshtari_Load);
            this.GotFocus += new System.EventHandler(this.frmMoshtari_GotFocus);
            this.panelMaster.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMaster;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ComboBox cboMasir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGrid grdMoshtari;
        private System.Windows.Forms.TextBox txtMoshtarino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMandehEtebar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoshtarids;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobilephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMandehMoavagh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMandehBargashti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMandehAsnadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkStatus;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtCountBargashti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCountMoavagh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuItem mniClose;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
    }
}