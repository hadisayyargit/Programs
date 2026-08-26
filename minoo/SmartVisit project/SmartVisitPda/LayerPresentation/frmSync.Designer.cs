namespace layerPresentation
{
    partial class frmSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSync));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.ibtnSaveLog = new HControls.HImageButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbAll = new System.Windows.Forms.Label();
            this.lbBasic = new System.Windows.Forms.Label();
            this.ibtnClose = new HControls.HImageButton();
            this.ibtnSyncAll = new HControls.HImageButton();
            this.ibtnSyncBasic = new HControls.HImageButton();
            this.ibtnNotSended = new HControls.HImageButton();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtLog.Location = new System.Drawing.Point(4, 50);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(231, 169);
            this.txtLog.TabIndex = 1;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.panelMain.Controls.Add(this.ibtnClose);
            this.panelMain.Controls.Add(this.ibtnSaveLog);
            this.panelMain.Controls.Add(this.progressBar1);
            this.panelMain.Controls.Add(this.lbAll);
            this.panelMain.Controls.Add(this.lbBasic);
            this.panelMain.Controls.Add(this.ibtnSyncAll);
            this.panelMain.Controls.Add(this.ibtnSyncBasic);
            this.panelMain.Controls.Add(this.ibtnNotSended);
            this.panelMain.Controls.Add(this.txtServerIp);
            this.panelMain.Controls.Add(this.txtLog);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(240, 265);
            // 
            // ibtnSaveLog
            // 
            this.ibtnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSaveLog.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSaveLog.Image")));
            this.ibtnSaveLog.Location = new System.Drawing.Point(207, 25);
            this.ibtnSaveLog.Name = "ibtnSaveLog";
            this.ibtnSaveLog.Size = new System.Drawing.Size(28, 24);
            this.ibtnSaveLog.TabIndex = 21;
            this.ibtnSaveLog.Click += new System.EventHandler(this.ibtnSaveLog_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(4, 222);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 11);
            // 
            // lbAll
            // 
            this.lbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAll.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lbAll.Location = new System.Drawing.Point(149, 241);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(53, 13);
            this.lbAll.Text = "ارسال دوباره";
            this.lbAll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbBasic
            // 
            this.lbBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBasic.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lbBasic.Location = new System.Drawing.Point(34, 241);
            this.lbBasic.Name = "lbBasic";
            this.lbBasic.Size = new System.Drawing.Size(82, 13);
            this.lbBasic.Text = "دریافت اطلاعات پایه";
            this.lbBasic.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ibtnClose
            // 
            this.ibtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.Location = new System.Drawing.Point(4, 235);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(31, 24);
            this.ibtnClose.TabIndex = 19;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // ibtnSyncAll
            // 
            this.ibtnSyncAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSyncAll.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSyncAll.Image")));
            this.ibtnSyncAll.Location = new System.Drawing.Point(204, 235);
            this.ibtnSyncAll.Name = "ibtnSyncAll";
            this.ibtnSyncAll.Size = new System.Drawing.Size(31, 24);
            this.ibtnSyncAll.TabIndex = 18;
            this.ibtnSyncAll.Click += new System.EventHandler(this.ibtnSyncAll_Click);
            // 
            // ibtnSyncBasic
            // 
            this.ibtnSyncBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSyncBasic.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSyncBasic.Image")));
            this.ibtnSyncBasic.Location = new System.Drawing.Point(118, 235);
            this.ibtnSyncBasic.Name = "ibtnSyncBasic";
            this.ibtnSyncBasic.Size = new System.Drawing.Size(31, 24);
            this.ibtnSyncBasic.TabIndex = 17;
            this.ibtnSyncBasic.Click += new System.EventHandler(this.ibtnSyncBasic_Click);
            // 
            // ibtnNotSended
            // 
            this.ibtnNotSended.Image = ((System.Drawing.Image)(resources.GetObject("ibtnNotSended.Image")));
            this.ibtnNotSended.Location = new System.Drawing.Point(0, 0);
            this.ibtnNotSended.Name = "ibtnNotSended";
            this.ibtnNotSended.Size = new System.Drawing.Size(47, 47);
            this.ibtnNotSended.TabIndex = 16;
            this.ibtnNotSended.Click += new System.EventHandler(this.ibtnNotSended_Click);
            // 
            // txtServerIp
            // 
            this.txtServerIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIp.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtServerIp.Location = new System.Drawing.Point(54, 4);
            this.txtServerIp.Multiline = true;
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(182, 21);
            this.txtServerIp.TabIndex = 7;
            this.txtServerIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            // 
            // frmSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmSync";
            this.Text = "یکسان سازی اطلاعات";
            this.Load += new System.EventHandler(this.frmSync_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtServerIp;
        private HControls.HImageButton ibtnNotSended;
        private HControls.HImageButton ibtnSyncAll;
        private HControls.HImageButton ibtnSyncBasic;
        private HControls.HImageButton ibtnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbAll;
        private System.Windows.Forms.Label lbBasic;
        private System.Windows.Forms.ProgressBar progressBar1;
        private HControls.HImageButton ibtnSaveLog;
    }
}