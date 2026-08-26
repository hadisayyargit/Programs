namespace layerPresentation
{
    partial class frmKala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKala));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelKala = new System.Windows.Forms.Panel();
            this.ibtnSearch = new HControls.HImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ibtnClose = new HControls.HImageButton();
            this.grdKala = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.panelMain.SuspendLayout();
            this.panelKala.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelKala);
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(477, 533);
            // 
            // panelKala
            // 
            this.panelKala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKala.Controls.Add(this.ibtnSearch);
            this.panelKala.Controls.Add(this.label3);
            this.panelKala.Controls.Add(this.txtKey1);
            this.panelKala.Controls.Add(this.txtKey2);
            this.panelKala.Controls.Add(this.label4);
            this.panelKala.Controls.Add(this.ibtnClose);
            this.panelKala.Controls.Add(this.grdKala);
            this.panelKala.Location = new System.Drawing.Point(0, 0);
            this.panelKala.Name = "panelKala";
            this.panelKala.Size = new System.Drawing.Size(474, 530);
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Image")));
            this.ibtnSearch.Location = new System.Drawing.Point(10, 13);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(45, 35);
            this.ibtnSearch.TabIndex = 21;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(224, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.Text = "نام کالا";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKey1
            // 
            this.txtKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKey1.Location = new System.Drawing.Point(294, 13);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(92, 35);
            this.txtKey1.TabIndex = 17;
            // 
            // txtKey2
            // 
            this.txtKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKey2.Location = new System.Drawing.Point(61, 13);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(162, 35);
            this.txtKey2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(380, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.Text = "کد فروش";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ibtnClose
            // 
            this.ibtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ibtnClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.Location = new System.Drawing.Point(10, 490);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(40, 37);
            this.ibtnClose.TabIndex = 14;
            this.ibtnClose.Click += new System.EventHandler(this.ibtnClose_Click);
            // 
            // grdKala
            // 
            this.grdKala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdKala.BackColor = System.Drawing.Color.AntiqueWhite;
            this.grdKala.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdKala.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.grdKala.Location = new System.Drawing.Point(6, 60);
            this.grdKala.Name = "grdKala";
            this.grdKala.Size = new System.Drawing.Size(465, 424);
            this.grdKala.TabIndex = 0;
            this.grdKala.TableStyles.Add(this.dataGridTableStyle3);
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "کد کالا";
            this.dataGridTextBoxColumn1.MappingName = "kalasn";
            this.dataGridTextBoxColumn1.Width = 0;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "کد فروش";
            this.dataGridTextBoxColumn2.MappingName = "forooshcode";
            this.dataGridTextBoxColumn2.Width = 110;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "شرح کالا";
            this.dataGridTextBoxColumn3.MappingName = "kalads";
            this.dataGridTextBoxColumn3.Width = 180;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "موجودی";
            this.dataGridTextBoxColumn4.MappingName = "mojoodi";
            this.dataGridTextBoxColumn4.Width = 80;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "تأمین کننده";
            this.dataGridTextBoxColumn5.MappingName = "taminkonandehds";
            this.dataGridTextBoxColumn5.Width = 200;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "حداقل درخواست";
            this.dataGridTextBoxColumn6.MappingName = "mindarkhast";
            this.dataGridTextBoxColumn6.Width = 100;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "نرخ";
            this.dataGridTextBoxColumn7.MappingName = "nerkheforoosh";
            this.dataGridTextBoxColumn7.Width = 100;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "نرخ مصرف";
            this.dataGridTextBoxColumn8.MappingName = "nerkhemasraf";
            this.dataGridTextBoxColumn8.Width = 100;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "بسته بندی";
            this.dataGridTextBoxColumn9.MappingName = "vahedesanjeshds";
            this.dataGridTextBoxColumn9.Width = 100;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "وضعیت";
            this.dataGridTextBoxColumn10.MappingName = "kalastatus";
            this.dataGridTextBoxColumn10.Width = 100;
            // 
            // inputPanel1
            // 
            this.inputPanel1.EnabledChanged += new System.EventHandler(this.inputPanel1_EnabledChanged);
            // 
            // frmKala
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
            this.Name = "frmKala";
            this.Text = "کالاها";
            this.Load += new System.EventHandler(this.frmKala_Load);
            this.panelMain.ResumeLayout(false);
            this.panelKala.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelKala;
        private HControls.HImageButton ibtnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label4;
        private HControls.HImageButton ibtnClose;
        private System.Windows.Forms.DataGrid grdKala;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
    }
}