namespace RWAS.WinUI
{
    partial class frmAppObject
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("پنجره اصلی", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.btnClose = new System.Windows.Forms.Button();
            this.grdApplicationObject = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.treeObjects = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOperationalObject = new System.Windows.Forms.GroupBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rdoOperational = new System.Windows.Forms.RadioButton();
            this.rdoAppObject = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbMaster = new System.Windows.Forms.GroupBox();
            this.Pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParentObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colApplicationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdApplicationObject)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbOperationalObject.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(16, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdApplicationObject
            // 
            this.grdApplicationObject.AllowUserToAddRows = false;
            this.grdApplicationObject.AllowUserToDeleteRows = false;
            this.grdApplicationObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdApplicationObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdApplicationObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pname,
            this.colObjectId,
            this.colParentObjectId,
            this.colObjectType,
            this.colIsVisible,
            this.colApplicationId});
            this.grdApplicationObject.Location = new System.Drawing.Point(16, 20);
            this.grdApplicationObject.MultiSelect = false;
            this.grdApplicationObject.Name = "grdApplicationObject";
            this.grdApplicationObject.ReadOnly = true;
            this.grdApplicationObject.RowHeadersWidth = 20;
            this.grdApplicationObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdApplicationObject.Size = new System.Drawing.Size(753, 413);
            this.grdApplicationObject.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(664, 451);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "بازخوانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyAll.AutoSize = true;
            this.btnApplyAll.Location = new System.Drawing.Point(618, 472);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(153, 23);
            this.btnApplyAll.TabIndex = 15;
            this.btnApplyAll.Text = "افزودن به جدول اشیاء";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            this.btnApplyAll.Click += new System.EventHandler(this.btnApplyAll_Click);
            // 
            // treeObjects
            // 
            this.treeObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeObjects.CheckBoxes = true;
            this.treeObjects.ContextMenuStrip = this.contextMenuStrip1;
            this.treeObjects.HideSelection = false;
            this.treeObjects.Location = new System.Drawing.Point(11, 71);
            this.treeObjects.Name = "treeObjects";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Node2";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "پنجره اصلی";
            this.treeObjects.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeObjects.RightToLeftLayout = true;
            this.treeObjects.Size = new System.Drawing.Size(759, 320);
            this.treeObjects.TabIndex = 17;
            this.treeObjects.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeObjects_AfterCheck);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCheckAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // mniCheckAll
            // 
            this.mniCheckAll.Name = "mniCheckAll";
            this.mniCheckAll.Size = new System.Drawing.Size(169, 22);
            this.mniCheckAll.Text = "انتخاب همه زیرشاخه";
            this.mniCheckAll.Click += new System.EventHandler(this.mniCheckAll_Click);
            // 
            // gbOperationalObject
            // 
            this.gbOperationalObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperationalObject.Controls.Add(this.txtPname);
            this.gbOperationalObject.Controls.Add(this.label2);
            this.gbOperationalObject.Controls.Add(this.txtEname);
            this.gbOperationalObject.Controls.Add(this.label1);
            this.gbOperationalObject.Enabled = false;
            this.gbOperationalObject.Location = new System.Drawing.Point(12, 397);
            this.gbOperationalObject.Name = "gbOperationalObject";
            this.gbOperationalObject.Size = new System.Drawing.Size(759, 57);
            this.gbOperationalObject.TabIndex = 18;
            this.gbOperationalObject.TabStop = false;
            // 
            // txtPname
            // 
            this.txtPname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPname.Location = new System.Drawing.Point(282, 19);
            this.txtPname.MaxLength = 50;
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(183, 21);
            this.txtPname.TabIndex = 20;
            this.txtPname.Text = " عملیات شماره1 ...";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "عنوان:";
            // 
            // txtEname
            // 
            this.txtEname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEname.Location = new System.Drawing.Point(532, 21);
            this.txtEname.MaxLength = 50;
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(187, 21);
            this.txtEname.TabIndex = 18;
            this.txtEname.Text = "KARNAMEH_process1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "نام:";
            // 
            // gbAdd
            // 
            this.gbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdd.Controls.Add(this.btnReturn);
            this.gbAdd.Controls.Add(this.rdoOperational);
            this.gbAdd.Controls.Add(this.rdoAppObject);
            this.gbAdd.Controls.Add(this.treeObjects);
            this.gbAdd.Controls.Add(this.gbOperationalObject);
            this.gbAdd.Controls.Add(this.btnApplyAll);
            this.gbAdd.Location = new System.Drawing.Point(5, 1);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(783, 510);
            this.gbAdd.TabIndex = 20;
            this.gbAdd.TabStop = false;
            this.gbAdd.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.AutoSize = true;
            this.btnReturn.Location = new System.Drawing.Point(11, 472);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 23);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "بازگشت";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rdoOperational
            // 
            this.rdoOperational.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOperational.AutoSize = true;
            this.rdoOperational.Location = new System.Drawing.Point(515, 32);
            this.rdoOperational.Name = "rdoOperational";
            this.rdoOperational.Size = new System.Drawing.Size(56, 17);
            this.rdoOperational.TabIndex = 20;
            this.rdoOperational.Text = "عملیات";
            this.rdoOperational.UseVisualStyleBackColor = true;
            this.rdoOperational.CheckedChanged += new System.EventHandler(this.rdoOperational_CheckedChanged);
            // 
            // rdoAppObject
            // 
            this.rdoAppObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAppObject.AutoSize = true;
            this.rdoAppObject.Checked = true;
            this.rdoAppObject.Location = new System.Drawing.Point(683, 32);
            this.rdoAppObject.Name = "rdoAppObject";
            this.rdoAppObject.Size = new System.Drawing.Size(61, 17);
            this.rdoAppObject.TabIndex = 19;
            this.rdoAppObject.TabStop = true;
            this.rdoAppObject.Text = "فرم/منو";
            this.rdoAppObject.UseVisualStyleBackColor = true;
            this.rdoAppObject.CheckedChanged += new System.EventHandler(this.rdoAppObject_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(512, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "تعریف/افزودن شیئ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbMaster
            // 
            this.gbMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMaster.Controls.Add(this.grdApplicationObject);
            this.gbMaster.Controls.Add(this.btnAdd);
            this.gbMaster.Controls.Add(this.btnRefresh);
            this.gbMaster.Controls.Add(this.btnClose);
            this.gbMaster.Location = new System.Drawing.Point(5, 12);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(783, 489);
            this.gbMaster.TabIndex = 22;
            this.gbMaster.TabStop = false;
            // 
            // Pname
            // 
            this.Pname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pname.DataPropertyName = "Pname";
            this.Pname.HeaderText = "نام شیئ";
            this.Pname.MinimumWidth = 100;
            this.Pname.Name = "Pname";
            this.Pname.ReadOnly = true;
            // 
            // colObjectId
            // 
            this.colObjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colObjectId.DataPropertyName = "ObjectId";
            this.colObjectId.HeaderText = "شناسه شیئ";
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.ReadOnly = true;
            this.colObjectId.Width = 96;
            // 
            // colParentObjectId
            // 
            this.colParentObjectId.DataPropertyName = "ParentObjectId";
            this.colParentObjectId.HeaderText = "شیئ پدر";
            this.colParentObjectId.Name = "colParentObjectId";
            this.colParentObjectId.ReadOnly = true;
            // 
            // colObjectType
            // 
            this.colObjectType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colObjectType.DataPropertyName = "ObjectType";
            this.colObjectType.HeaderText = "نوع شیئ";
            this.colObjectType.Name = "colObjectType";
            this.colObjectType.ReadOnly = true;
            this.colObjectType.Width = 76;
            // 
            // colIsVisible
            // 
            this.colIsVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIsVisible.DataPropertyName = "IsSecurable";
            this.colIsVisible.HeaderText = "IsSecurable";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.ReadOnly = true;
            this.colIsVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsVisible.Visible = false;
            this.colIsVisible.Width = 88;
            // 
            // colApplicationId
            // 
            this.colApplicationId.DataPropertyName = "ApplicationId";
            this.colApplicationId.HeaderText = "ApplicationId";
            this.colApplicationId.Name = "colApplicationId";
            this.colApplicationId.ReadOnly = true;
            this.colApplicationId.Visible = false;
            // 
            // frmAppObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 513);
            this.Controls.Add(this.gbMaster);
            this.Controls.Add(this.gbAdd);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "frmAppObject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اشیاء برنامه";
            this.Load += new System.EventHandler(this.frmAppObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdApplicationObject)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbOperationalObject.ResumeLayout(false);
            this.gbOperationalObject.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdApplicationObject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApplyAll;
        private System.Windows.Forms.TreeView treeObjects;
        private System.Windows.Forms.GroupBox gbOperationalObject;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbMaster;
        private System.Windows.Forms.RadioButton rdoOperational;
        private System.Windows.Forms.RadioButton rdoAppObject;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniCheckAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParentObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationId;
    }
}