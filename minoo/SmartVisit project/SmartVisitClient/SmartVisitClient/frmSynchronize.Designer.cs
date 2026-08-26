namespace SmartVisitClient
{
    partial class frmSynchronize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSynchronize));
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnDbSetting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.lbActiveSyncVersion = new System.Windows.Forms.Label();
            this.lbActiveSyncStatus = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.cboVisitor = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCommand.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.gbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCommand
            // 
            this.gbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCommand.Controls.Add(this.btnSync);
            this.gbCommand.Controls.Add(this.btnDbSetting);
            this.gbCommand.Location = new System.Drawing.Point(5, 0);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(286, 100);
            this.gbCommand.TabIndex = 0;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "عملیات";
            // 
            // btnSync
            // 
            this.btnSync.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSync.Location = new System.Drawing.Point(75, 59);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(136, 23);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "آماده سازی";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnDbSetting
            // 
            this.btnDbSetting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDbSetting.Location = new System.Drawing.Point(75, 21);
            this.btnDbSetting.Name = "btnDbSetting";
            this.btnDbSetting.Size = new System.Drawing.Size(136, 23);
            this.btnDbSetting.TabIndex = 0;
            this.btnDbSetting.Text = "تنظیمات پایگاه داده ها";
            this.btnDbSetting.UseVisualStyleBackColor = true;
            this.btnDbSetting.Click += new System.EventHandler(this.btnDbSetting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.picRefresh);
            this.groupBox2.Controls.Add(this.lbActiveSyncVersion);
            this.groupBox2.Controls.Add(this.lbActiveSyncStatus);
            this.groupBox2.Location = new System.Drawing.Point(298, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ActiveSync";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "نسخه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "وضعیت:";
            // 
            // picRefresh
            // 
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(7, 21);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(55, 50);
            this.picRefresh.TabIndex = 2;
            this.picRefresh.TabStop = false;
            // 
            // lbActiveSyncVersion
            // 
            this.lbActiveSyncVersion.AutoSize = true;
            this.lbActiveSyncVersion.Location = new System.Drawing.Point(86, 59);
            this.lbActiveSyncVersion.Name = "lbActiveSyncVersion";
            this.lbActiveSyncVersion.Size = new System.Drawing.Size(54, 13);
            this.lbActiveSyncVersion.TabIndex = 1;
            this.lbActiveSyncVersion.Text = " 5.1.8888";
            // 
            // lbActiveSyncStatus
            // 
            this.lbActiveSyncStatus.AutoSize = true;
            this.lbActiveSyncStatus.Location = new System.Drawing.Point(104, 31);
            this.lbActiveSyncStatus.Name = "lbActiveSyncStatus";
            this.lbActiveSyncStatus.Size = new System.Drawing.Size(26, 13);
            this.lbActiveSyncStatus.TabIndex = 0;
            this.lbActiveSyncStatus.Text = "قطع";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(5, 106);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(501, 342);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // gbSetting
            // 
            this.gbSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSetting.BackColor = System.Drawing.Color.RosyBrown;
            this.gbSetting.Controls.Add(this.cboVisitor);
            this.gbSetting.Controls.Add(this.btnOk);
            this.gbSetting.Controls.Add(this.label2);
            this.gbSetting.Controls.Add(this.txtDbPath);
            this.gbSetting.Controls.Add(this.label1);
            this.gbSetting.Location = new System.Drawing.Point(12, 169);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(473, 147);
            this.gbSetting.TabIndex = 2;
            this.gbSetting.TabStop = false;
            this.gbSetting.Visible = false;
            // 
            // cboVisitor
            // 
            this.cboVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVisitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisitor.FormattingEnabled = true;
            this.cboVisitor.Location = new System.Drawing.Point(16, 61);
            this.cboVisitor.Name = "cboVisitor";
            this.cboVisitor.Size = new System.Drawing.Size(295, 21);
            this.cboVisitor.TabIndex = 7;
            this.cboVisitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboVisitor_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOk.Location = new System.Drawing.Point(211, 104);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 29);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "تأیید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ویزیتور:";
            // 
            // txtDbPath
            // 
            this.txtDbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDbPath.Location = new System.Drawing.Point(16, 24);
            this.txtDbPath.Name = "txtDbPath";
            this.txtDbPath.ReadOnly = true;
            this.txtDbPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDbPath.Size = new System.Drawing.Size(296, 21);
            this.txtDbPath.TabIndex = 3;
            this.txtDbPath.Text = "\\Storage Card\\My Documents\\My Projects\\SmartVisit";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "مسیر بانک اطلاعات دستگاه:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSynchronize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 453);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCommand);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSynchronize";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "یکسان سازی";
            this.Load += new System.EventHandler(this.frmSynchronize_Load);
            this.gbCommand.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnDbSetting;
        private System.Windows.Forms.Label lbActiveSyncVersion;
        private System.Windows.Forms.Label lbActiveSyncStatus;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboVisitor;
    }
}

