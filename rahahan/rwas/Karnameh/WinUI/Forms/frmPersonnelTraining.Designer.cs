namespace RWAS.WinUI
{
    partial class frmPersonnelTraining
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
            this.txtTermCode = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grdMaster = new System.Windows.Forms.DataGridView();
            this.colRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTermCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniquecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTermName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDegree = new ProgLib.Components.CNTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTermCode
            // 
            this.txtTermCode.Location = new System.Drawing.Point(82, 23);
            this.txtTermCode.MaxLength = 8;
            this.txtTermCode.Name = "txtTermCode";
            this.txtTermCode.ReadOnly = true;
            this.txtTermCode.Size = new System.Drawing.Size(74, 21);
            this.txtTermCode.TabIndex = 43;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(148, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(711, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(80, 480);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(62, 23);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(711, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 480);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 23);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grdMaster
            // 
            this.grdMaster.AllowUserToAddRows = false;
            this.grdMaster.AllowUserToDeleteRows = false;
            this.grdMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRow,
            this.colTermCode,
            this.colTermName,
            this.colDegree,
            this.colUniquecode,
            this.colStartDate,
            this.colEndDate,
            this.colDuration,
            this.colLocation,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdMaster.Location = new System.Drawing.Point(12, 111);
            this.grdMaster.MultiSelect = false;
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.ReadOnly = true;
            this.grdMaster.RowHeadersWidth = 20;
            this.grdMaster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaster.Size = new System.Drawing.Size(761, 363);
            this.grdMaster.TabIndex = 37;
            this.grdMaster.CurrentCellChanged += new System.EventHandler(this.grdMaster_CurrentCellChanged);
            // 
            // colRow
            // 
            this.colRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRow.DataPropertyName = "row";
            this.colRow.HeaderText = "ردیف";
            this.colRow.Name = "colRow";
            this.colRow.ReadOnly = true;
            this.colRow.Width = 54;
            // 
            // colTermCode
            // 
            this.colTermCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTermCode.DataPropertyName = "code_amozesh";
            this.colTermCode.HeaderText = "کد دوره";
            this.colTermCode.Name = "colTermCode";
            this.colTermCode.ReadOnly = true;
            this.colTermCode.Width = 65;
            // 
            // colTermName
            // 
            this.colTermName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTermName.DataPropertyName = "name_amozesh";
            this.colTermName.HeaderText = "عنوان";
            this.colTermName.MinimumWidth = 200;
            this.colTermName.Name = "colTermName";
            this.colTermName.ReadOnly = true;
            this.colTermName.Width = 200;
            // 
            // colDegree
            // 
            this.colDegree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colDegree.DataPropertyName = "Rws_Fld_Degree";
            this.colDegree.HeaderText = "نمره";
            this.colDegree.Name = "colDegree";
            this.colDegree.ReadOnly = true;
            this.colDegree.Width = 52;
            // 
            // colUniquecode
            // 
            this.colUniquecode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colUniquecode.DataPropertyName = "uniq_code";
            this.colUniquecode.HeaderText = "کد انحصاری";
            this.colUniquecode.Name = "colUniquecode";
            this.colUniquecode.ReadOnly = true;
            this.colUniquecode.Visible = false;
            // 
            // colStartDate
            // 
            this.colStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colStartDate.DataPropertyName = "d_start";
            this.colStartDate.HeaderText = "تاریخ شروع";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            this.colStartDate.Width = 84;
            // 
            // colEndDate
            // 
            this.colEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colEndDate.DataPropertyName = "d_end";
            this.colEndDate.HeaderText = "تاریخ پایان";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            this.colEndDate.Width = 75;
            // 
            // colDuration
            // 
            this.colDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colDuration.DataPropertyName = "time_hours";
            this.colDuration.HeaderText = "مدت";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 53;
            // 
            // colLocation
            // 
            this.colLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLocation.DataPropertyName = "Rws_Fld_TrainingLocation";
            this.colLocation.HeaderText = "محل دوره";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "period_g";
            this.Column1.HeaderText = "period_g";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "time_year";
            this.Column2.HeaderText = "time_year";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "time_mounth";
            this.Column3.HeaderText = "time_mounth";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "time_day";
            this.Column4.HeaderText = "time_day";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTermName
            // 
            this.txtTermName.Location = new System.Drawing.Point(162, 23);
            this.txtTermName.Name = "txtTermName";
            this.txtTermName.ReadOnly = true;
            this.txtTermName.Size = new System.Drawing.Size(241, 21);
            this.txtTermName.TabIndex = 402;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 407;
            this.label3.Text = "محل دوره";
            // 
            // txtDegree
            // 
            this.txtDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDegree.Location = new System.Drawing.Point(713, 50);
            this.txtDegree.MaxLength = 3;
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(60, 21);
            this.txtDegree.strVal = "";
            this.txtDegree.TabIndex = 404;
            this.txtDegree.Text = "0";
            this.txtDegree.Value = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(680, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 406;
            this.label10.Text = "نمره";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 405;
            this.label4.Text = "دوره";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(82, 52);
            this.txtLocation.MaxLength = 100;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(192, 21);
            this.txtLocation.TabIndex = 44;
            // 
            // frmPersonnelTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(785, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTermName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtTermCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdMaster);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmPersonnelTraining";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "وضعیت آموزشی";
            this.Load += new System.EventHandler(this.frmPersonnelTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTermCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView grdMaster;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTermName;
        private System.Windows.Forms.Label label3;
        private ProgLib.Components.CNTextBox txtDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTermCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniquecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}