namespace RWAS.WinUI
{
    partial class FrmPersonelAccident
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
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccidentLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccidentDegree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grdMaster = new System.Windows.Forms.DataGridView();
            this.txtForefit = new System.Windows.Forms.TextBox();
            this.txtAccidentDate = new System.Windows.Forms.TextBox();
            this.colAccidentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccidentKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccidentLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccidentReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccidentDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colForefitKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Location = new System.Drawing.Point(449, 77);
            this.txtReason.MaxLength = 255;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(216, 21);
            this.txtReason.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 395;
            this.label8.Text = "علت حادثه";
            // 
            // txtAccidentLocation
            // 
            this.txtAccidentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccidentLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccidentLocation.Location = new System.Drawing.Point(88, 77);
            this.txtAccidentLocation.MaxLength = 50;
            this.txtAccidentLocation.Name = "txtAccidentLocation";
            this.txtAccidentLocation.ReadOnly = true;
            this.txtAccidentLocation.Size = new System.Drawing.Size(273, 21);
            this.txtAccidentLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 388;
            this.label2.Text = "شرح حادثه";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 392;
            this.label10.Text = "میزان جریمه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 390;
            this.label5.Text = "محل حادثه";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescribe.Location = new System.Drawing.Point(88, 43);
            this.txtDescribe.MaxLength = 80;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.ReadOnly = true;
            this.txtDescribe.Size = new System.Drawing.Size(273, 21);
            this.txtDescribe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 387;
            this.label1.Text = "تاریخ حادثه";
            // 
            // txtAccidentDegree
            // 
            this.txtAccidentDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccidentDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccidentDegree.Location = new System.Drawing.Point(88, 109);
            this.txtAccidentDegree.MaxLength = 50;
            this.txtAccidentDegree.Name = "txtAccidentDegree";
            this.txtAccidentDegree.ReadOnly = true;
            this.txtAccidentDegree.Size = new System.Drawing.Size(105, 21);
            this.txtAccidentDegree.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 397;
            this.label3.Text = "درجه حادثه";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(590, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "بازگشت";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdMaster
            // 
            this.grdMaster.AllowUserToAddRows = false;
            this.grdMaster.AllowUserToDeleteRows = false;
            this.grdMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccidentDate,
            this.colAccidentKind,
            this.colAccidentLocation,
            this.colAccidentReason,
            this.colAccidentDegree,
            this.colForefitKind,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdMaster.Location = new System.Drawing.Point(12, 148);
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.ReadOnly = true;
            this.grdMaster.Size = new System.Drawing.Size(653, 218);
            this.grdMaster.TabIndex = 6;
            this.grdMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grdMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaster_CellDoubleClick);
            // 
            // txtForefit
            // 
            this.txtForefit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForefit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForefit.Location = new System.Drawing.Point(449, 109);
            this.txtForefit.MaxLength = 255;
            this.txtForefit.Name = "txtForefit";
            this.txtForefit.ReadOnly = true;
            this.txtForefit.Size = new System.Drawing.Size(216, 21);
            this.txtForefit.TabIndex = 5;
            // 
            // txtAccidentDate
            // 
            this.txtAccidentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccidentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccidentDate.Location = new System.Drawing.Point(88, 12);
            this.txtAccidentDate.MaxLength = 50;
            this.txtAccidentDate.Name = "txtAccidentDate";
            this.txtAccidentDate.ReadOnly = true;
            this.txtAccidentDate.Size = new System.Drawing.Size(105, 21);
            this.txtAccidentDate.TabIndex = 0;
            // 
            // colAccidentDate
            // 
            this.colAccidentDate.DataPropertyName = "Rws_Fld_AccidentDate";
            this.colAccidentDate.HeaderText = "تاریخ حادثه";
            this.colAccidentDate.Name = "colAccidentDate";
            this.colAccidentDate.ReadOnly = true;
            // 
            // colAccidentKind
            // 
            this.colAccidentKind.DataPropertyName = "AccidentKindDesc";
            this.colAccidentKind.HeaderText = "شرح حادثه";
            this.colAccidentKind.Name = "colAccidentKind";
            this.colAccidentKind.ReadOnly = true;
            // 
            // colAccidentLocation
            // 
            this.colAccidentLocation.DataPropertyName = "SourceStationDesc";
            this.colAccidentLocation.HeaderText = "محل حادثه";
            this.colAccidentLocation.Name = "colAccidentLocation";
            this.colAccidentLocation.ReadOnly = true;
            // 
            // colAccidentReason
            // 
            this.colAccidentReason.DataPropertyName = "Rws_Fld_Reason";
            this.colAccidentReason.HeaderText = "علت حادثه";
            this.colAccidentReason.Name = "colAccidentReason";
            this.colAccidentReason.ReadOnly = true;
            // 
            // colAccidentDegree
            // 
            this.colAccidentDegree.DataPropertyName = "DegreeDesc";
            this.colAccidentDegree.HeaderText = "درجه حادثه";
            this.colAccidentDegree.Name = "colAccidentDegree";
            this.colAccidentDegree.ReadOnly = true;
            // 
            // colForefitKind
            // 
            this.colForefitKind.DataPropertyName = "ForeFitKindDesc";
            this.colForefitKind.HeaderText = "میزان جریمه";
            this.colForefitKind.Name = "colForefitKind";
            this.colForefitKind.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Rws_Fld_fk_EarlyAccident";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Rws_Fld_fk_UniqueCode";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Rws_Fld_fk_ForfeitKind";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Rws_Fld_fk_SourceStation";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Rws_Fld_fk_AccidentDegree";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // FrmPersonelAccident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(677, 416);
            this.Controls.Add(this.txtAccidentDate);
            this.Controls.Add(this.txtForefit);
            this.Controls.Add(this.grdMaster);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAccidentDegree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccidentLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReason);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmPersonelAccident";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کارنامه ایمنی - حوادث و سوانح";
            this.Load += new System.EventHandler(this.FrmPersonelAccident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccidentLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccidentDegree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdMaster;
        private System.Windows.Forms.TextBox txtForefit;
        private System.Windows.Forms.TextBox txtAccidentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccidentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccidentKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccidentLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccidentReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccidentDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForefitKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;


    }
}