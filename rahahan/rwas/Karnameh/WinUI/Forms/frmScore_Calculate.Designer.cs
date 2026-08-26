namespace RWAS.WinUI
{
    partial class frmScore_Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScore_Calculate));
            Janus.Windows.GridEX.GridEXLayout chkcboRegion_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rdoRegion = new System.Windows.Forms.RadioButton();
            this.rdoPersonnel = new System.Windows.Forms.RadioButton();
            this.gbUID = new System.Windows.Forms.GroupBox();
            this.btnUniqueCode = new System.Windows.Forms.Button();
            this.txtUniqueCode = new ProgLib.Components.CNTextBox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPersonelName = new System.Windows.Forms.Label();
            this.faDatePickerScoreDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.chkcboRegion = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.gbUID.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(141, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "محاسبه و ثبت";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rdoRegion
            // 
            this.rdoRegion.AutoSize = true;
            this.rdoRegion.Checked = true;
            this.rdoRegion.Location = new System.Drawing.Point(21, 64);
            this.rdoRegion.Name = "rdoRegion";
            this.rdoRegion.Size = new System.Drawing.Size(48, 17);
            this.rdoRegion.TabIndex = 14;
            this.rdoRegion.TabStop = true;
            this.rdoRegion.Text = "ناحیه";
            this.rdoRegion.UseVisualStyleBackColor = true;
            this.rdoRegion.CheckedChanged += new System.EventHandler(this.rdoRegion_CheckedChanged);
            // 
            // rdoPersonnel
            // 
            this.rdoPersonnel.AutoSize = true;
            this.rdoPersonnel.Location = new System.Drawing.Point(21, 100);
            this.rdoPersonnel.Name = "rdoPersonnel";
            this.rdoPersonnel.Size = new System.Drawing.Size(82, 17);
            this.rdoPersonnel.TabIndex = 15;
            this.rdoPersonnel.Text = "پرسنل خاص";
            this.rdoPersonnel.UseVisualStyleBackColor = true;
            this.rdoPersonnel.CheckedChanged += new System.EventHandler(this.rdoPersonnel_CheckedChanged);
            // 
            // gbUID
            // 
            this.gbUID.Controls.Add(this.btnUniqueCode);
            this.gbUID.Controls.Add(this.txtUniqueCode);
            this.gbUID.Controls.Add(this.label9);
            this.gbUID.Controls.Add(this.label23);
            this.gbUID.Controls.Add(this.lblPersonelName);
            this.gbUID.Enabled = false;
            this.gbUID.Location = new System.Drawing.Point(12, 123);
            this.gbUID.Name = "gbUID";
            this.gbUID.Size = new System.Drawing.Size(342, 89);
            this.gbUID.TabIndex = 16;
            this.gbUID.TabStop = false;
            // 
            // btnUniqueCode
            // 
            this.btnUniqueCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUniqueCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUniqueCode.Image = ((System.Drawing.Image)(resources.GetObject("btnUniqueCode.Image")));
            this.btnUniqueCode.Location = new System.Drawing.Point(124, 20);
            this.btnUniqueCode.Name = "btnUniqueCode";
            this.btnUniqueCode.Size = new System.Drawing.Size(24, 21);
            this.btnUniqueCode.TabIndex = 1;
            this.btnUniqueCode.UseVisualStyleBackColor = true;
            this.btnUniqueCode.Click += new System.EventHandler(this.btnUniqueCode_Click);
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniqueCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUniqueCode.Location = new System.Drawing.Point(151, 20);
            this.txtUniqueCode.MaxLength = 9;
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUniqueCode.Size = new System.Drawing.Size(89, 21);
            this.txtUniqueCode.strVal = "";
            this.txtUniqueCode.TabIndex = 0;
            this.txtUniqueCode.Text = "0";
            this.txtUniqueCode.Value = 0;
            this.txtUniqueCode.TextChanged += new System.EventHandler(this.txtUniqueCode_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 314;
            this.label9.Text = "نام و نام خانوادگی";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(251, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 313;
            this.label23.Text = "کد انحصاری ";
            // 
            // lblPersonelName
            // 
            this.lblPersonelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonelName.BackColor = System.Drawing.Color.Azure;
            this.lblPersonelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPersonelName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPersonelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPersonelName.Location = new System.Drawing.Point(15, 50);
            this.lblPersonelName.Name = "lblPersonelName";
            this.lblPersonelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonelName.Size = new System.Drawing.Size(225, 21);
            this.lblPersonelName.TabIndex = 312;
            this.lblPersonelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faDatePickerScoreDate
            // 
            this.faDatePickerScoreDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faDatePickerScoreDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.faDatePickerScoreDate.Location = new System.Drawing.Point(97, 12);
            this.faDatePickerScoreDate.Name = "faDatePickerScoreDate";
            this.faDatePickerScoreDate.Size = new System.Drawing.Size(182, 20);
            this.faDatePickerScoreDate.TabIndex = 123;
            this.faDatePickerScoreDate.SelectedDateTimeChanged += new System.EventHandler(this.faDatePickerScoreDate_SelectedDateTimeChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 16);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "تاریخ محاسبه:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(366, 22);
            this.statusStrip1.TabIndex = 124;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(209, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "آماده محاسبه";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(140, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // chkcboRegion
            // 
            this.chkcboRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkcboRegion.ButtonCancelText = "لغو";
            this.chkcboRegion.ButtonOKText = "قبول";
            this.chkcboRegion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboRegion_DesignTimeLayout.LayoutString = resources.GetString("chkcboRegion_DesignTimeLayout.LayoutString");
            this.chkcboRegion.DesignTimeLayout = chkcboRegion_DesignTimeLayout;
            this.chkcboRegion.Location = new System.Drawing.Point(97, 61);
            this.chkcboRegion.Name = "chkcboRegion";
            this.chkcboRegion.SaveSettings = false;
            this.chkcboRegion.Size = new System.Drawing.Size(232, 21);
            this.chkcboRegion.TabIndex = 125;
            this.chkcboRegion.ValueItemDataMember = "(None)";
            this.chkcboRegion.ValuesDataMember = null;
            this.chkcboRegion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmScore_Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 292);
            this.Controls.Add(this.chkcboRegion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.faDatePickerScoreDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gbUID);
            this.Controls.Add(this.rdoPersonnel);
            this.Controls.Add(this.rdoRegion);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScore_Calculate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محاسبه امتیازات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScore_Calculate_FormClosed);
            this.Load += new System.EventHandler(this.frmScore_Calculate_Load);
            this.gbUID.ResumeLayout(false);
            this.gbUID.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rdoRegion;
        private System.Windows.Forms.RadioButton rdoPersonnel;
        private System.Windows.Forms.GroupBox gbUID;
        private System.Windows.Forms.Button btnUniqueCode;
        private ProgLib.Components.CNTextBox txtUniqueCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPersonelName;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerScoreDate;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboRegion;
    }
}