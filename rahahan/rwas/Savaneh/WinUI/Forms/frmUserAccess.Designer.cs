namespace RWAS.WinUI
{
    partial class frmUserAccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mniUnCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkSelectUser = new System.Windows.Forms.CheckBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboUserGroup = new System.Windows.Forms.ComboBox();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.grdMaster = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn14 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.grdEditAccess = new System.Windows.Forms.DataGridView();
            this.colPname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSecurable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGrantSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGrantInsert = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGrantUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGrantDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGrantExecute = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).BeginInit();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCheckAll,
            this.mniUnCheckAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // mniCheckAll
            // 
            this.mniCheckAll.Name = "mniCheckAll";
            this.mniCheckAll.Size = new System.Drawing.Size(136, 22);
            this.mniCheckAll.Text = "انتخاب همه";
            this.mniCheckAll.Click += new System.EventHandler(this.mniCheckAll_Click);
            // 
            // mniUnCheckAll
            // 
            this.mniUnCheckAll.Name = "mniUnCheckAll";
            this.mniUnCheckAll.Size = new System.Drawing.Size(136, 22);
            this.mniUnCheckAll.Text = "پاک کردن همه";
            this.mniUnCheckAll.Click += new System.EventHandler(this.mniUnCheckAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.chkSelectUser);
            this.groupBox1.Controls.Add(this.lbUser);
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboUserGroup);
            this.groupBox1.Controls.Add(this.cboRegion);
            this.groupBox1.Controls.Add(this.grdMaster);
            this.groupBox1.Controls.Add(this.gbAdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(671, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 161;
            this.btnAdd.Text = "ویرایش دسترسی";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(11, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(780, 439);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(761, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "نام برنامه کاربردی:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Location = new System.Drawing.Point(549, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(263, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "نام ماشین:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Location = new System.Drawing.Point(11, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 155;
            // 
            // chkSelectUser
            // 
            this.chkSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectUser.AutoSize = true;
            this.chkSelectUser.Location = new System.Drawing.Point(777, 51);
            this.chkSelectUser.Name = "chkSelectUser";
            this.chkSelectUser.Size = new System.Drawing.Size(78, 17);
            this.chkSelectUser.TabIndex = 154;
            this.chkSelectUser.Text = "انتخاب کاربر";
            this.chkSelectUser.UseVisualStyleBackColor = true;
            this.chkSelectUser.CheckedChanged += new System.EventHandler(this.chkSelectUser_CheckedChanged);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(263, 50);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(31, 13);
            this.lbUser.TabIndex = 153;
            this.lbUser.Text = "کاربر:";
            this.lbUser.Visible = false;
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.Location = new System.Drawing.Point(11, 47);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(246, 21);
            this.cboUser.TabIndex = 152;
            this.cboUser.Visible = false;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            this.cboUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboUser_KeyUp);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(788, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "گروه کاربری:";
            // 
            // cboUserGroup
            // 
            this.cboUserGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserGroup.Location = new System.Drawing.Point(549, 18);
            this.cboUserGroup.Name = "cboUserGroup";
            this.cboUserGroup.Size = new System.Drawing.Size(206, 21);
            this.cboUserGroup.TabIndex = 1;
            this.cboUserGroup.SelectedIndexChanged += new System.EventHandler(this.cboUserGroup_SelectedIndexChanged);
            this.cboUserGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboUserGroup_KeyUp);
            // 
            // cboRegion
            // 
            this.cboRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.Location = new System.Drawing.Point(549, 47);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(206, 21);
            this.cboRegion.TabIndex = 4;
            this.cboRegion.Visible = false;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            this.cboRegion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboRegion_KeyUp);
            // 
            // grdMaster
            // 
            this.grdMaster.AllowUserToAddRows = false;
            this.grdMaster.AllowUserToDeleteRows = false;
            this.grdMaster.AllowUserToOrderColumns = true;
            this.grdMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMaster.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.grdMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12,
            this.dataGridViewCheckBoxColumn13,
            this.dataGridViewCheckBoxColumn14,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.grdMaster.EnableHeadersVisualStyles = false;
            this.grdMaster.Location = new System.Drawing.Point(11, 113);
            this.grdMaster.MultiSelect = false;
            this.grdMaster.Name = "grdMaster";
            this.grdMaster.ReadOnly = true;
            this.grdMaster.RowHeadersWidth = 20;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.grdMaster.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMaster.Size = new System.Drawing.Size(842, 320);
            this.grdMaster.TabIndex = 163;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GroupDes";
            this.dataGridViewTextBoxColumn1.HeaderText = "گروه کاربری";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام کاربر";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ObjectPname";
            this.dataGridViewTextBoxColumn7.HeaderText = "نام شیئ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ParentObjectId";
            this.dataGridViewTextBoxColumn8.HeaderText = "نام شیئ پدر";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "IsVisible";
            this.dataGridViewCheckBoxColumn8.HeaderText = "قابل رویت";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.ReadOnly = true;
            this.dataGridViewCheckBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn8.Width = 76;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "IsEnable";
            this.dataGridViewCheckBoxColumn9.HeaderText = "فعال";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.ReadOnly = true;
            this.dataGridViewCheckBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn9.Width = 53;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "GrantSelect";
            this.dataGridViewCheckBoxColumn10.HeaderText = "اجازه انتخاب";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.ReadOnly = true;
            this.dataGridViewCheckBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn10.Width = 86;
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "GrantInsert";
            this.dataGridViewCheckBoxColumn11.HeaderText = "اجازه درج";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            this.dataGridViewCheckBoxColumn11.ReadOnly = true;
            this.dataGridViewCheckBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn11.Width = 73;
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "GrantUpdate";
            this.dataGridViewCheckBoxColumn12.HeaderText = "اجازه اصلاح";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            this.dataGridViewCheckBoxColumn12.ReadOnly = true;
            this.dataGridViewCheckBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn12.Width = 84;
            // 
            // dataGridViewCheckBoxColumn13
            // 
            this.dataGridViewCheckBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn13.DataPropertyName = "GrantDelete";
            this.dataGridViewCheckBoxColumn13.HeaderText = "اجازه حذف";
            this.dataGridViewCheckBoxColumn13.Name = "dataGridViewCheckBoxColumn13";
            this.dataGridViewCheckBoxColumn13.ReadOnly = true;
            this.dataGridViewCheckBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn13.Width = 80;
            // 
            // dataGridViewCheckBoxColumn14
            // 
            this.dataGridViewCheckBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn14.DataPropertyName = "GrantExecute";
            this.dataGridViewCheckBoxColumn14.HeaderText = "اجازه اجرا";
            this.dataGridViewCheckBoxColumn14.Name = "dataGridViewCheckBoxColumn14";
            this.dataGridViewCheckBoxColumn14.ReadOnly = true;
            this.dataGridViewCheckBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn14.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ObjectType";
            this.dataGridViewTextBoxColumn9.HeaderText = "نوع شیئ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "objectId";
            this.dataGridViewTextBoxColumn10.HeaderText = "کد شیئ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 74;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn11.HeaderText = "شناسه کاربری";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AccessId";
            this.dataGridViewTextBoxColumn12.HeaderText = "کد دسترسی";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn13.HeaderText = "MachineName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Acc_Fld_fk_UniqueCode";
            this.dataGridViewTextBoxColumn14.HeaderText = "UniqueCode";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RegionDes";
            this.dataGridViewTextBoxColumn15.HeaderText = "ناحیه";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Acc_Fld_fk_Region";
            this.dataGridViewTextBoxColumn16.HeaderText = "RegionId";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "GroupId";
            this.dataGridViewTextBoxColumn17.HeaderText = "کد گروه";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // gbAdd
            // 
            this.gbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdd.Controls.Add(this.grdEditAccess);
            this.gbAdd.Controls.Add(this.btnCancel);
            this.gbAdd.Controls.Add(this.btnApplyAll);
            this.gbAdd.Location = new System.Drawing.Point(11, 104);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(842, 318);
            this.gbAdd.TabIndex = 162;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "افزودن دسترسی";
            this.gbAdd.Visible = false;
            // 
            // grdEditAccess
            // 
            this.grdEditAccess.AllowUserToAddRows = false;
            this.grdEditAccess.AllowUserToDeleteRows = false;
            this.grdEditAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEditAccess.BackgroundColor = System.Drawing.Color.LightYellow;
            this.grdEditAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEditAccess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPname,
            this.colIsSecurable,
            this.colParentObjectId,
            this.colIsVisible,
            this.colIsEnable,
            this.colGrantSelect,
            this.colGrantInsert,
            this.colGrantUpdate,
            this.colGrantDelete,
            this.colGrantExecute,
            this.colObjectType,
            this.colObjectId,
            this.colApplicationId});
            this.grdEditAccess.ContextMenuStrip = this.contextMenuStrip1;
            this.grdEditAccess.Location = new System.Drawing.Point(12, 20);
            this.grdEditAccess.Name = "grdEditAccess";
            this.grdEditAccess.RowHeadersWidth = 20;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            this.grdEditAccess.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEditAccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdEditAccess.Size = new System.Drawing.Size(812, 253);
            this.grdEditAccess.TabIndex = 161;
            this.grdEditAccess.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEditAccess_CellValueChanged);
            // 
            // colPname
            // 
            this.colPname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPname.DataPropertyName = "Pname";
            this.colPname.HeaderText = "نام شیئ";
            this.colPname.MinimumWidth = 200;
            this.colPname.Name = "colPname";
            this.colPname.ReadOnly = true;
            this.colPname.Width = 200;
            // 
            // colIsSecurable
            // 
            this.colIsSecurable.DataPropertyName = "IsSecurable";
            this.colIsSecurable.HeaderText = "IsSecurable";
            this.colIsSecurable.Name = "colIsSecurable";
            this.colIsSecurable.Visible = false;
            // 
            // colParentObjectId
            // 
            this.colParentObjectId.DataPropertyName = "ParentObjectId";
            this.colParentObjectId.HeaderText = "نام شیئ پدر";
            this.colParentObjectId.Name = "colParentObjectId";
            this.colParentObjectId.Visible = false;
            // 
            // colIsVisible
            // 
            this.colIsVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIsVisible.HeaderText = "قابل رویت";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsVisible.Width = 76;
            // 
            // colIsEnable
            // 
            this.colIsEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIsEnable.HeaderText = "فعال";
            this.colIsEnable.Name = "colIsEnable";
            this.colIsEnable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsEnable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsEnable.Width = 53;
            // 
            // colGrantSelect
            // 
            this.colGrantSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGrantSelect.HeaderText = "اجازه انتخاب";
            this.colGrantSelect.Name = "colGrantSelect";
            this.colGrantSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGrantSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGrantSelect.Width = 86;
            // 
            // colGrantInsert
            // 
            this.colGrantInsert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGrantInsert.HeaderText = "اجازه درج";
            this.colGrantInsert.Name = "colGrantInsert";
            this.colGrantInsert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGrantInsert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGrantInsert.Width = 73;
            // 
            // colGrantUpdate
            // 
            this.colGrantUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGrantUpdate.HeaderText = "اجازه اصلاح";
            this.colGrantUpdate.Name = "colGrantUpdate";
            this.colGrantUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGrantUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGrantUpdate.Width = 84;
            // 
            // colGrantDelete
            // 
            this.colGrantDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGrantDelete.HeaderText = "اجازه حذف";
            this.colGrantDelete.Name = "colGrantDelete";
            this.colGrantDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGrantDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGrantDelete.Width = 80;
            // 
            // colGrantExecute
            // 
            this.colGrantExecute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colGrantExecute.HeaderText = "اجازه اجرا";
            this.colGrantExecute.Name = "colGrantExecute";
            this.colGrantExecute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGrantExecute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGrantExecute.Width = 75;
            // 
            // colObjectType
            // 
            this.colObjectType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colObjectType.DataPropertyName = "ObjectType";
            this.colObjectType.HeaderText = "نوع شیئ";
            this.colObjectType.Name = "colObjectType";
            this.colObjectType.Visible = false;
            // 
            // colObjectId
            // 
            this.colObjectId.DataPropertyName = "objectId";
            this.colObjectId.HeaderText = "کد شیئ";
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.Visible = false;
            this.colObjectId.Width = 74;
            // 
            // colApplicationId
            // 
            this.colApplicationId.DataPropertyName = "ApplicationId";
            this.colApplicationId.HeaderText = "ApplicationId";
            this.colApplicationId.Name = "colApplicationId";
            this.colApplicationId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(640, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyAll.AutoSize = true;
            this.btnApplyAll.Location = new System.Drawing.Point(721, 279);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(103, 23);
            this.btnApplyAll.TabIndex = 15;
            this.btnApplyAll.Text = "ذخیره دسترسیها";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            this.btnApplyAll.Click += new System.EventHandler(this.btnApplyAll_Click);
            // 
            // frmUserAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 483);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "frmUserAccess";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دسترسی کاربران";
            this.Load += new System.EventHandler(this.frmUserAccess_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaster)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEditAccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboUserGroup;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkSelectUser;
        private System.Windows.Forms.Button btnApplyAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniCheckAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridView grdEditAccess;
        private System.Windows.Forms.ToolStripMenuItem mniUnCheckAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSecurable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentObjectId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsVisible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsEnable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantInsert;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationId;
    }
}