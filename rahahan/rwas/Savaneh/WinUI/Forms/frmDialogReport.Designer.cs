namespace RWAS.WinUI
{
    partial class frmDialogReport
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
            Janus.Windows.GridEX.GridEXLayout chkcboReason_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialogReport));
            Janus.Windows.GridEX.GridEXLayout chkcboRailVehicleKind_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout chkcboAccidentKind_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout chkcboDegree_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout chkcboEffective_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout chkcboRegion_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout chkcboCategory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gbAccidentParameters = new System.Windows.Forms.GroupBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.chkcboReason = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboRailVehicleKind = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboAccidentKind = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboDegree = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboEffective = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboRegion = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.chkcboCategory = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccidentKind = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.faDatePickerEnd = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lbBeginDate = new System.Windows.Forms.Label();
            this.faDatePickerBegin = new FarsiLibrary.Win.Controls.FADatePicker();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbManouver = new System.Windows.Forms.GroupBox();
            this.rdoManouverAll = new System.Windows.Forms.RadioButton();
            this.rdoManouverNo = new System.Windows.Forms.RadioButton();
            this.rdoManouverYes = new System.Windows.Forms.RadioButton();
            this.gbBlameful = new System.Windows.Forms.GroupBox();
            this.rdoBlamefulAll = new System.Windows.Forms.RadioButton();
            this.rdoBlamefulNo = new System.Windows.Forms.RadioButton();
            this.rdoBlamefulYes = new System.Windows.Forms.RadioButton();
            this.gbBarred = new System.Windows.Forms.GroupBox();
            this.rdoBarredAll = new System.Windows.Forms.RadioButton();
            this.rdoBarredNo = new System.Windows.Forms.RadioButton();
            this.rdoBarredYes = new System.Windows.Forms.RadioButton();
            this.gbAfoul = new System.Windows.Forms.GroupBox();
            this.rdoAfoulAll = new System.Windows.Forms.RadioButton();
            this.rdoAfoulNo = new System.Windows.Forms.RadioButton();
            this.rdoAfoulYes = new System.Windows.Forms.RadioButton();
            this.gbDie = new System.Windows.Forms.GroupBox();
            this.rdoDieAll = new System.Windows.Forms.RadioButton();
            this.rdoDieNo = new System.Windows.Forms.RadioButton();
            this.rdoDieYes = new System.Windows.Forms.RadioButton();
            this.gbLoss = new System.Windows.Forms.GroupBox();
            this.rdoLossAll = new System.Windows.Forms.RadioButton();
            this.rdoLossNo = new System.Windows.Forms.RadioButton();
            this.rdoLossYes = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReportParameters = new System.Windows.Forms.GroupBox();
            this.btnHideParameterGroup = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFooterTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeaderTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbGroupingField = new System.Windows.Forms.GroupBox();
            this.listboxGroupColumns = new System.Windows.Forms.ListBox();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.listboxSortColumns = new System.Windows.Forms.ListBox();
            this.gbColumns = new System.Windows.Forms.GroupBox();
            this.chkListAccident = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mniClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnParameters = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.gbAccidentList = new System.Windows.Forms.GroupBox();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdEarlyAccident = new System.Windows.Forms.DataGridView();
            this.colRws_Fld_AccidentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRws_Fld_FileCategorize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRws_Fld_pk_EarlyAccident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSeir = new System.Windows.Forms.GroupBox();
            this.txtTrainNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbAccidentParameters.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbManouver.SuspendLayout();
            this.gbBlameful.SuspendLayout();
            this.gbBarred.SuspendLayout();
            this.gbAfoul.SuspendLayout();
            this.gbDie.SuspendLayout();
            this.gbLoss.SuspendLayout();
            this.gbReportParameters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbGroupingField.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbColumns.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbAccidentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEarlyAccident)).BeginInit();
            this.gbSeir.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccidentParameters
            // 
            this.gbAccidentParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAccidentParameters.Controls.Add(this.cboLocation);
            this.gbAccidentParameters.Controls.Add(this.chkcboReason);
            this.gbAccidentParameters.Controls.Add(this.chkcboRailVehicleKind);
            this.gbAccidentParameters.Controls.Add(this.chkcboAccidentKind);
            this.gbAccidentParameters.Controls.Add(this.chkcboDegree);
            this.gbAccidentParameters.Controls.Add(this.chkcboEffective);
            this.gbAccidentParameters.Controls.Add(this.chkcboRegion);
            this.gbAccidentParameters.Controls.Add(this.chkcboCategory);
            this.gbAccidentParameters.Controls.Add(this.lbLocation);
            this.gbAccidentParameters.Controls.Add(this.label7);
            this.gbAccidentParameters.Controls.Add(this.label6);
            this.gbAccidentParameters.Controls.Add(this.label5);
            this.gbAccidentParameters.Controls.Add(this.label35);
            this.gbAccidentParameters.Controls.Add(this.label3);
            this.gbAccidentParameters.Controls.Add(this.lblAccidentKind);
            this.gbAccidentParameters.Controls.Add(this.label36);
            this.gbAccidentParameters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbAccidentParameters.Location = new System.Drawing.Point(12, 47);
            this.gbAccidentParameters.Name = "gbAccidentParameters";
            this.gbAccidentParameters.Size = new System.Drawing.Size(690, 158);
            this.gbAccidentParameters.TabIndex = 0;
            this.gbAccidentParameters.TabStop = false;
            // 
            // cboLocation
            // 
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "",
            "سوزن",
            "بلاک"});
            this.cboLocation.Location = new System.Drawing.Point(12, 119);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(182, 21);
            this.cboLocation.TabIndex = 212;
            // 
            // chkcboReason
            // 
            this.chkcboReason.ButtonCancelText = "لغو";
            this.chkcboReason.ButtonOKText = "قبول";
            this.chkcboReason.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboReason_DesignTimeLayout.LayoutString = resources.GetString("chkcboReason_DesignTimeLayout.LayoutString");
            this.chkcboReason.DesignTimeLayout = chkcboReason_DesignTimeLayout;
            this.chkcboReason.Location = new System.Drawing.Point(12, 86);
            this.chkcboReason.Name = "chkcboReason";
            this.chkcboReason.SaveSettings = false;
            this.chkcboReason.Size = new System.Drawing.Size(295, 21);
            this.chkcboReason.TabIndex = 210;
            this.chkcboReason.ValuesDataMember = null;
            this.chkcboReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkcboRailVehicleKind
            // 
            this.chkcboRailVehicleKind.ButtonCancelText = "لغو";
            this.chkcboRailVehicleKind.ButtonOKText = "قبول";
            this.chkcboRailVehicleKind.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboRailVehicleKind_DesignTimeLayout.LayoutString = resources.GetString("chkcboRailVehicleKind_DesignTimeLayout.LayoutString");
            this.chkcboRailVehicleKind.DesignTimeLayout = chkcboRailVehicleKind_DesignTimeLayout;
            this.chkcboRailVehicleKind.Location = new System.Drawing.Point(12, 53);
            this.chkcboRailVehicleKind.Name = "chkcboRailVehicleKind";
            this.chkcboRailVehicleKind.SaveSettings = false;
            this.chkcboRailVehicleKind.Size = new System.Drawing.Size(182, 21);
            this.chkcboRailVehicleKind.TabIndex = 209;
            this.chkcboRailVehicleKind.ValuesDataMember = null;
            this.chkcboRailVehicleKind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkcboAccidentKind
            // 
            this.chkcboAccidentKind.ButtonCancelText = "لغو";
            this.chkcboAccidentKind.ButtonOKText = "قبول";
            this.chkcboAccidentKind.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboAccidentKind_DesignTimeLayout.LayoutString = resources.GetString("chkcboAccidentKind_DesignTimeLayout.LayoutString");
            this.chkcboAccidentKind.DesignTimeLayout = chkcboAccidentKind_DesignTimeLayout;
            this.chkcboAccidentKind.Location = new System.Drawing.Point(12, 19);
            this.chkcboAccidentKind.Name = "chkcboAccidentKind";
            this.chkcboAccidentKind.SaveSettings = false;
            this.chkcboAccidentKind.Size = new System.Drawing.Size(182, 21);
            this.chkcboAccidentKind.TabIndex = 208;
            this.chkcboAccidentKind.ValuesDataMember = null;
            this.chkcboAccidentKind.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkcboDegree
            // 
            this.chkcboDegree.ButtonCancelText = "لغو";
            this.chkcboDegree.ButtonOKText = "قبول";
            this.chkcboDegree.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboDegree_DesignTimeLayout.LayoutString = resources.GetString("chkcboDegree_DesignTimeLayout.LayoutString");
            this.chkcboDegree.DesignTimeLayout = chkcboDegree_DesignTimeLayout;
            this.chkcboDegree.Location = new System.Drawing.Point(432, 119);
            this.chkcboDegree.Name = "chkcboDegree";
            this.chkcboDegree.SaveSettings = false;
            this.chkcboDegree.Size = new System.Drawing.Size(183, 21);
            this.chkcboDegree.TabIndex = 207;
            this.chkcboDegree.ValuesDataMember = null;
            this.chkcboDegree.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkcboEffective
            // 
            this.chkcboEffective.ButtonCancelText = "لغو";
            this.chkcboEffective.ButtonOKText = "قبول";
            this.chkcboEffective.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboEffective_DesignTimeLayout.LayoutString = resources.GetString("chkcboEffective_DesignTimeLayout.LayoutString");
            this.chkcboEffective.DesignTimeLayout = chkcboEffective_DesignTimeLayout;
            this.chkcboEffective.Location = new System.Drawing.Point(432, 86);
            this.chkcboEffective.Name = "chkcboEffective";
            this.chkcboEffective.SaveSettings = false;
            this.chkcboEffective.Size = new System.Drawing.Size(183, 21);
            this.chkcboEffective.TabIndex = 206;
            this.chkcboEffective.ValuesDataMember = null;
            this.chkcboEffective.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.chkcboEffective.CloseUp += new System.EventHandler(this.chkcboEffective_CloseUp);
            // 
            // chkcboRegion
            // 
            this.chkcboRegion.ButtonCancelText = "لغو";
            this.chkcboRegion.ButtonOKText = "قبول";
            this.chkcboRegion.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboRegion_DesignTimeLayout.LayoutString = resources.GetString("chkcboRegion_DesignTimeLayout.LayoutString");
            this.chkcboRegion.DesignTimeLayout = chkcboRegion_DesignTimeLayout;
            this.chkcboRegion.Location = new System.Drawing.Point(432, 53);
            this.chkcboRegion.Name = "chkcboRegion";
            this.chkcboRegion.SaveSettings = false;
            this.chkcboRegion.Size = new System.Drawing.Size(183, 21);
            this.chkcboRegion.TabIndex = 205;
            this.chkcboRegion.ValuesDataMember = null;
            this.chkcboRegion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkcboCategory
            // 
            this.chkcboCategory.ButtonCancelText = "لغو";
            this.chkcboCategory.ButtonOKText = "قبول";
            this.chkcboCategory.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            chkcboCategory_DesignTimeLayout.LayoutString = resources.GetString("chkcboCategory_DesignTimeLayout.LayoutString");
            this.chkcboCategory.DesignTimeLayout = chkcboCategory_DesignTimeLayout;
            this.chkcboCategory.Location = new System.Drawing.Point(313, 19);
            this.chkcboCategory.Name = "chkcboCategory";
            this.chkcboCategory.SaveSettings = false;
            this.chkcboCategory.Size = new System.Drawing.Size(302, 21);
            this.chkcboCategory.TabIndex = 204;
            this.chkcboCategory.ValuesDataMember = null;
            this.chkcboCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbLocation.Location = new System.Drawing.Point(200, 123);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(80, 13);
            this.lbLocation.TabIndex = 194;
            this.lbLocation.Text = "محل وقوع حادثه";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(623, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 193;
            this.label7.Text = "درجه حادثه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(313, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 192;
            this.label6.Text = "علت حادثه";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(623, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 191;
            this.label5.Text = "عامل حادثه";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label35.Location = new System.Drawing.Point(200, 57);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 13);
            this.label35.TabIndex = 190;
            this.label35.Text = "نوع وسیله ریلی";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(623, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 187;
            this.label3.Text = "ناحیه";
            // 
            // lblAccidentKind
            // 
            this.lblAccidentKind.AutoSize = true;
            this.lblAccidentKind.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAccidentKind.Location = new System.Drawing.Point(200, 23);
            this.lblAccidentKind.Name = "lblAccidentKind";
            this.lblAccidentKind.Size = new System.Drawing.Size(59, 13);
            this.lblAccidentKind.TabIndex = 188;
            this.lblAccidentKind.Text = "سبب حادثه";
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label36.Location = new System.Drawing.Point(623, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 13);
            this.label36.TabIndex = 103;
            this.label36.Text = "نوع حادثه";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbEndDate.Location = new System.Drawing.Point(203, 24);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbEndDate.Size = new System.Drawing.Size(41, 13);
            this.lbEndDate.TabIndex = 101;
            this.lbEndDate.Text = "تا تاریخ:";
            // 
            // faDatePickerEnd
            // 
            this.faDatePickerEnd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.faDatePickerEnd.Location = new System.Drawing.Point(15, 21);
            this.faDatePickerEnd.Name = "faDatePickerEnd";
            this.faDatePickerEnd.Size = new System.Drawing.Size(182, 20);
            this.faDatePickerEnd.TabIndex = 1;
            // 
            // lbBeginDate
            // 
            this.lbBeginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBeginDate.AutoSize = true;
            this.lbBeginDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbBeginDate.Location = new System.Drawing.Point(638, 24);
            this.lbBeginDate.Name = "lbBeginDate";
            this.lbBeginDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbBeginDate.Size = new System.Drawing.Size(42, 13);
            this.lbBeginDate.TabIndex = 99;
            this.lbBeginDate.Text = "از تاریخ:";
            // 
            // faDatePickerBegin
            // 
            this.faDatePickerBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faDatePickerBegin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.faDatePickerBegin.Location = new System.Drawing.Point(446, 21);
            this.faDatePickerBegin.Name = "faDatePickerBegin";
            this.faDatePickerBegin.Size = new System.Drawing.Size(182, 20);
            this.faDatePickerBegin.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.gbManouver);
            this.gbOptions.Controls.Add(this.gbBlameful);
            this.gbOptions.Controls.Add(this.gbBarred);
            this.gbOptions.Controls.Add(this.gbAfoul);
            this.gbOptions.Controls.Add(this.gbDie);
            this.gbOptions.Controls.Add(this.gbLoss);
            this.gbOptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbOptions.Location = new System.Drawing.Point(12, 206);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(690, 191);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            // 
            // gbManouver
            // 
            this.gbManouver.Controls.Add(this.rdoManouverAll);
            this.gbManouver.Controls.Add(this.rdoManouverNo);
            this.gbManouver.Controls.Add(this.rdoManouverYes);
            this.gbManouver.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbManouver.Location = new System.Drawing.Point(12, 125);
            this.gbManouver.Name = "gbManouver";
            this.gbManouver.Size = new System.Drawing.Size(180, 47);
            this.gbManouver.TabIndex = 5;
            this.gbManouver.TabStop = false;
            this.gbManouver.Text = "مانور";
            // 
            // rdoManouverAll
            // 
            this.rdoManouverAll.AutoSize = true;
            this.rdoManouverAll.Checked = true;
            this.rdoManouverAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoManouverAll.Location = new System.Drawing.Point(11, 19);
            this.rdoManouverAll.Name = "rdoManouverAll";
            this.rdoManouverAll.Size = new System.Drawing.Size(48, 17);
            this.rdoManouverAll.TabIndex = 2;
            this.rdoManouverAll.TabStop = true;
            this.rdoManouverAll.Text = "هردو";
            this.rdoManouverAll.UseVisualStyleBackColor = true;
            // 
            // rdoManouverNo
            // 
            this.rdoManouverNo.AutoSize = true;
            this.rdoManouverNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoManouverNo.Location = new System.Drawing.Point(65, 19);
            this.rdoManouverNo.Name = "rdoManouverNo";
            this.rdoManouverNo.Size = new System.Drawing.Size(46, 17);
            this.rdoManouverNo.TabIndex = 1;
            this.rdoManouverNo.Text = "ندارد";
            this.rdoManouverNo.UseVisualStyleBackColor = true;
            // 
            // rdoManouverYes
            // 
            this.rdoManouverYes.AutoSize = true;
            this.rdoManouverYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoManouverYes.Location = new System.Drawing.Point(114, 19);
            this.rdoManouverYes.Name = "rdoManouverYes";
            this.rdoManouverYes.Size = new System.Drawing.Size(42, 17);
            this.rdoManouverYes.TabIndex = 0;
            this.rdoManouverYes.Text = "دارد";
            this.rdoManouverYes.UseVisualStyleBackColor = true;
            // 
            // gbBlameful
            // 
            this.gbBlameful.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBlameful.Controls.Add(this.rdoBlamefulAll);
            this.gbBlameful.Controls.Add(this.rdoBlamefulNo);
            this.gbBlameful.Controls.Add(this.rdoBlamefulYes);
            this.gbBlameful.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbBlameful.Location = new System.Drawing.Point(12, 19);
            this.gbBlameful.Name = "gbBlameful";
            this.gbBlameful.Size = new System.Drawing.Size(180, 47);
            this.gbBlameful.TabIndex = 1;
            this.gbBlameful.TabStop = false;
            this.gbBlameful.Text = "مقصر";
            // 
            // rdoBlamefulAll
            // 
            this.rdoBlamefulAll.AutoSize = true;
            this.rdoBlamefulAll.Checked = true;
            this.rdoBlamefulAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBlamefulAll.Location = new System.Drawing.Point(11, 19);
            this.rdoBlamefulAll.Name = "rdoBlamefulAll";
            this.rdoBlamefulAll.Size = new System.Drawing.Size(48, 17);
            this.rdoBlamefulAll.TabIndex = 2;
            this.rdoBlamefulAll.TabStop = true;
            this.rdoBlamefulAll.Text = "هردو";
            this.rdoBlamefulAll.UseVisualStyleBackColor = true;
            // 
            // rdoBlamefulNo
            // 
            this.rdoBlamefulNo.AutoSize = true;
            this.rdoBlamefulNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBlamefulNo.Location = new System.Drawing.Point(65, 19);
            this.rdoBlamefulNo.Name = "rdoBlamefulNo";
            this.rdoBlamefulNo.Size = new System.Drawing.Size(46, 17);
            this.rdoBlamefulNo.TabIndex = 1;
            this.rdoBlamefulNo.Text = "ندارد";
            this.rdoBlamefulNo.UseVisualStyleBackColor = true;
            // 
            // rdoBlamefulYes
            // 
            this.rdoBlamefulYes.AutoSize = true;
            this.rdoBlamefulYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBlamefulYes.Location = new System.Drawing.Point(114, 19);
            this.rdoBlamefulYes.Name = "rdoBlamefulYes";
            this.rdoBlamefulYes.Size = new System.Drawing.Size(42, 17);
            this.rdoBlamefulYes.TabIndex = 0;
            this.rdoBlamefulYes.Text = "دارد";
            this.rdoBlamefulYes.UseVisualStyleBackColor = true;
            // 
            // gbBarred
            // 
            this.gbBarred.Controls.Add(this.rdoBarredAll);
            this.gbBarred.Controls.Add(this.rdoBarredNo);
            this.gbBarred.Controls.Add(this.rdoBarredYes);
            this.gbBarred.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbBarred.Location = new System.Drawing.Point(494, 125);
            this.gbBarred.Name = "gbBarred";
            this.gbBarred.Size = new System.Drawing.Size(180, 47);
            this.gbBarred.TabIndex = 4;
            this.gbBarred.TabStop = false;
            this.gbBarred.Text = "مسدودی";
            // 
            // rdoBarredAll
            // 
            this.rdoBarredAll.AutoSize = true;
            this.rdoBarredAll.Checked = true;
            this.rdoBarredAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBarredAll.Location = new System.Drawing.Point(11, 19);
            this.rdoBarredAll.Name = "rdoBarredAll";
            this.rdoBarredAll.Size = new System.Drawing.Size(48, 17);
            this.rdoBarredAll.TabIndex = 2;
            this.rdoBarredAll.TabStop = true;
            this.rdoBarredAll.Text = "هردو";
            this.rdoBarredAll.UseVisualStyleBackColor = true;
            // 
            // rdoBarredNo
            // 
            this.rdoBarredNo.AutoSize = true;
            this.rdoBarredNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBarredNo.Location = new System.Drawing.Point(65, 19);
            this.rdoBarredNo.Name = "rdoBarredNo";
            this.rdoBarredNo.Size = new System.Drawing.Size(46, 17);
            this.rdoBarredNo.TabIndex = 1;
            this.rdoBarredNo.Text = "ندارد";
            this.rdoBarredNo.UseVisualStyleBackColor = true;
            // 
            // rdoBarredYes
            // 
            this.rdoBarredYes.AutoSize = true;
            this.rdoBarredYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoBarredYes.Location = new System.Drawing.Point(114, 19);
            this.rdoBarredYes.Name = "rdoBarredYes";
            this.rdoBarredYes.Size = new System.Drawing.Size(42, 17);
            this.rdoBarredYes.TabIndex = 0;
            this.rdoBarredYes.Text = "دارد";
            this.rdoBarredYes.UseVisualStyleBackColor = true;
            // 
            // gbAfoul
            // 
            this.gbAfoul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAfoul.Controls.Add(this.rdoAfoulAll);
            this.gbAfoul.Controls.Add(this.rdoAfoulNo);
            this.gbAfoul.Controls.Add(this.rdoAfoulYes);
            this.gbAfoul.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbAfoul.Location = new System.Drawing.Point(494, 72);
            this.gbAfoul.Name = "gbAfoul";
            this.gbAfoul.Size = new System.Drawing.Size(180, 47);
            this.gbAfoul.TabIndex = 2;
            this.gbAfoul.TabStop = false;
            this.gbAfoul.Text = "مصدومیت";
            // 
            // rdoAfoulAll
            // 
            this.rdoAfoulAll.AutoSize = true;
            this.rdoAfoulAll.Checked = true;
            this.rdoAfoulAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAfoulAll.Location = new System.Drawing.Point(11, 19);
            this.rdoAfoulAll.Name = "rdoAfoulAll";
            this.rdoAfoulAll.Size = new System.Drawing.Size(48, 17);
            this.rdoAfoulAll.TabIndex = 2;
            this.rdoAfoulAll.TabStop = true;
            this.rdoAfoulAll.Text = "هردو";
            this.rdoAfoulAll.UseVisualStyleBackColor = true;
            // 
            // rdoAfoulNo
            // 
            this.rdoAfoulNo.AutoSize = true;
            this.rdoAfoulNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAfoulNo.Location = new System.Drawing.Point(65, 19);
            this.rdoAfoulNo.Name = "rdoAfoulNo";
            this.rdoAfoulNo.Size = new System.Drawing.Size(46, 17);
            this.rdoAfoulNo.TabIndex = 1;
            this.rdoAfoulNo.Text = "ندارد";
            this.rdoAfoulNo.UseVisualStyleBackColor = true;
            // 
            // rdoAfoulYes
            // 
            this.rdoAfoulYes.AutoSize = true;
            this.rdoAfoulYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoAfoulYes.Location = new System.Drawing.Point(114, 19);
            this.rdoAfoulYes.Name = "rdoAfoulYes";
            this.rdoAfoulYes.Size = new System.Drawing.Size(42, 17);
            this.rdoAfoulYes.TabIndex = 0;
            this.rdoAfoulYes.Text = "دارد";
            this.rdoAfoulYes.UseVisualStyleBackColor = true;
            // 
            // gbDie
            // 
            this.gbDie.Controls.Add(this.rdoDieAll);
            this.gbDie.Controls.Add(this.rdoDieNo);
            this.gbDie.Controls.Add(this.rdoDieYes);
            this.gbDie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbDie.Location = new System.Drawing.Point(12, 72);
            this.gbDie.Name = "gbDie";
            this.gbDie.Size = new System.Drawing.Size(180, 47);
            this.gbDie.TabIndex = 3;
            this.gbDie.TabStop = false;
            this.gbDie.Text = "فوتی";
            // 
            // rdoDieAll
            // 
            this.rdoDieAll.AutoSize = true;
            this.rdoDieAll.Checked = true;
            this.rdoDieAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoDieAll.Location = new System.Drawing.Point(11, 19);
            this.rdoDieAll.Name = "rdoDieAll";
            this.rdoDieAll.Size = new System.Drawing.Size(48, 17);
            this.rdoDieAll.TabIndex = 2;
            this.rdoDieAll.TabStop = true;
            this.rdoDieAll.Text = "هردو";
            this.rdoDieAll.UseVisualStyleBackColor = true;
            // 
            // rdoDieNo
            // 
            this.rdoDieNo.AutoSize = true;
            this.rdoDieNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoDieNo.Location = new System.Drawing.Point(65, 19);
            this.rdoDieNo.Name = "rdoDieNo";
            this.rdoDieNo.Size = new System.Drawing.Size(46, 17);
            this.rdoDieNo.TabIndex = 1;
            this.rdoDieNo.Text = "ندارد";
            this.rdoDieNo.UseVisualStyleBackColor = true;
            // 
            // rdoDieYes
            // 
            this.rdoDieYes.AutoSize = true;
            this.rdoDieYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoDieYes.Location = new System.Drawing.Point(114, 19);
            this.rdoDieYes.Name = "rdoDieYes";
            this.rdoDieYes.Size = new System.Drawing.Size(42, 17);
            this.rdoDieYes.TabIndex = 0;
            this.rdoDieYes.Text = "دارد";
            this.rdoDieYes.UseVisualStyleBackColor = true;
            // 
            // gbLoss
            // 
            this.gbLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLoss.Controls.Add(this.rdoLossAll);
            this.gbLoss.Controls.Add(this.rdoLossNo);
            this.gbLoss.Controls.Add(this.rdoLossYes);
            this.gbLoss.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbLoss.Location = new System.Drawing.Point(494, 19);
            this.gbLoss.Name = "gbLoss";
            this.gbLoss.Size = new System.Drawing.Size(180, 47);
            this.gbLoss.TabIndex = 0;
            this.gbLoss.TabStop = false;
            this.gbLoss.Text = "خسارت";
            // 
            // rdoLossAll
            // 
            this.rdoLossAll.AutoSize = true;
            this.rdoLossAll.Checked = true;
            this.rdoLossAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLossAll.Location = new System.Drawing.Point(11, 19);
            this.rdoLossAll.Name = "rdoLossAll";
            this.rdoLossAll.Size = new System.Drawing.Size(48, 17);
            this.rdoLossAll.TabIndex = 2;
            this.rdoLossAll.TabStop = true;
            this.rdoLossAll.Text = "هردو";
            this.rdoLossAll.UseVisualStyleBackColor = true;
            // 
            // rdoLossNo
            // 
            this.rdoLossNo.AutoSize = true;
            this.rdoLossNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLossNo.Location = new System.Drawing.Point(65, 19);
            this.rdoLossNo.Name = "rdoLossNo";
            this.rdoLossNo.Size = new System.Drawing.Size(46, 17);
            this.rdoLossNo.TabIndex = 1;
            this.rdoLossNo.Text = "ندارد";
            this.rdoLossNo.UseVisualStyleBackColor = true;
            // 
            // rdoLossYes
            // 
            this.rdoLossYes.AutoSize = true;
            this.rdoLossYes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoLossYes.Location = new System.Drawing.Point(114, 19);
            this.rdoLossYes.Name = "rdoLossYes";
            this.rdoLossYes.Size = new System.Drawing.Size(42, 17);
            this.rdoLossYes.TabIndex = 0;
            this.rdoLossYes.Text = "دارد";
            this.rdoLossYes.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(10, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "بستن";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbReportParameters
            // 
            this.gbReportParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReportParameters.Controls.Add(this.btnHideParameterGroup);
            this.gbReportParameters.Controls.Add(this.groupBox2);
            this.gbReportParameters.Controls.Add(this.gbGroupingField);
            this.gbReportParameters.Controls.Add(this.gbSort);
            this.gbReportParameters.Controls.Add(this.gbColumns);
            this.gbReportParameters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbReportParameters.Location = new System.Drawing.Point(3, 1);
            this.gbReportParameters.Name = "gbReportParameters";
            this.gbReportParameters.Size = new System.Drawing.Size(714, 459);
            this.gbReportParameters.TabIndex = 1;
            this.gbReportParameters.TabStop = false;
            this.gbReportParameters.Text = "پارامترهای گزارش";
            this.gbReportParameters.Visible = false;
            // 
            // btnHideParameterGroup
            // 
            this.btnHideParameterGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHideParameterGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHideParameterGroup.ImageIndex = 1;
            this.btnHideParameterGroup.ImageList = this.imageList1;
            this.btnHideParameterGroup.Location = new System.Drawing.Point(12, 415);
            this.btnHideParameterGroup.Name = "btnHideParameterGroup";
            this.btnHideParameterGroup.Size = new System.Drawing.Size(48, 32);
            this.btnHideParameterGroup.TabIndex = 10;
            this.btnHideParameterGroup.UseVisualStyleBackColor = true;
            this.btnHideParameterGroup.Click += new System.EventHandler(this.btnHideParameterGroup_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh1.png");
            this.imageList1.Images.SetKeyName(1, "Ok.png");
            this.imageList1.Images.SetKeyName(2, "sort.bmp");
            this.imageList1.Images.SetKeyName(3, "1leftarrow.ico");
            this.imageList1.Images.SetKeyName(4, "1rightarrow.ico");
            this.imageList1.Images.SetKeyName(5, "down.ico");
            this.imageList1.Images.SetKeyName(6, "up.ico");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtTitr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFooterTitle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHeaderTitle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtTitr
            // 
            this.txtTitr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTitr.Location = new System.Drawing.Point(12, 20);
            this.txtTitr.Name = "txtTitr";
            this.txtTitr.Size = new System.Drawing.Size(576, 21);
            this.txtTitr.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(607, 23);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "عنوان گزارش";
            // 
            // txtFooterTitle
            // 
            this.txtFooterTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFooterTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFooterTitle.Location = new System.Drawing.Point(12, 81);
            this.txtFooterTitle.Multiline = true;
            this.txtFooterTitle.Name = "txtFooterTitle";
            this.txtFooterTitle.Size = new System.Drawing.Size(576, 33);
            this.txtFooterTitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(602, 89);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "پانویس گزارش";
            // 
            // txtHeaderTitle
            // 
            this.txtHeaderTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeaderTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHeaderTitle.Location = new System.Drawing.Point(12, 48);
            this.txtHeaderTitle.Name = "txtHeaderTitle";
            this.txtHeaderTitle.Size = new System.Drawing.Size(576, 21);
            this.txtHeaderTitle.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(592, 51);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "سرنویس گزارش";
            // 
            // gbGroupingField
            // 
            this.gbGroupingField.Controls.Add(this.listboxGroupColumns);
            this.gbGroupingField.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbGroupingField.Location = new System.Drawing.Point(12, 273);
            this.gbGroupingField.Name = "gbGroupingField";
            this.gbGroupingField.Size = new System.Drawing.Size(397, 111);
            this.gbGroupingField.TabIndex = 14;
            this.gbGroupingField.TabStop = false;
            this.gbGroupingField.Text = "گروهبندی";
            this.gbGroupingField.Visible = false;
            // 
            // listboxGroupColumns
            // 
            this.listboxGroupColumns.AllowDrop = true;
            this.listboxGroupColumns.FormattingEnabled = true;
            this.listboxGroupColumns.Location = new System.Drawing.Point(12, 25);
            this.listboxGroupColumns.Name = "listboxGroupColumns";
            this.listboxGroupColumns.Size = new System.Drawing.Size(370, 69);
            this.listboxGroupColumns.TabIndex = 0;
            this.listboxGroupColumns.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxGroupColumns_DragDrop);
            this.listboxGroupColumns.DragEnter += new System.Windows.Forms.DragEventHandler(this.listboxGroupColumns_DragEnter);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.listboxSortColumns);
            this.gbSort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbSort.Location = new System.Drawing.Point(12, 157);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(397, 111);
            this.gbSort.TabIndex = 12;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "ترتیب بندی براساس:";
            // 
            // listboxSortColumns
            // 
            this.listboxSortColumns.AllowDrop = true;
            this.listboxSortColumns.FormattingEnabled = true;
            this.listboxSortColumns.Location = new System.Drawing.Point(12, 25);
            this.listboxSortColumns.Name = "listboxSortColumns";
            this.listboxSortColumns.Size = new System.Drawing.Size(370, 69);
            this.listboxSortColumns.TabIndex = 1;
            this.listboxSortColumns.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxSortColumns_DragDrop);
            this.listboxSortColumns.DragEnter += new System.Windows.Forms.DragEventHandler(this.listboxSortColumns_DragEnter);
            // 
            // gbColumns
            // 
            this.gbColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbColumns.Controls.Add(this.chkListAccident);
            this.gbColumns.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbColumns.Location = new System.Drawing.Point(420, 157);
            this.gbColumns.Name = "gbColumns";
            this.gbColumns.Size = new System.Drawing.Size(282, 290);
            this.gbColumns.TabIndex = 8;
            this.gbColumns.TabStop = false;
            this.gbColumns.Text = "ستونهای گزارش";
            // 
            // chkListAccident
            // 
            this.chkListAccident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkListAccident.CheckOnClick = true;
            this.chkListAccident.ContextMenuStrip = this.contextMenuStrip1;
            this.chkListAccident.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkListAccident.FormattingEnabled = true;
            this.chkListAccident.Items.AddRange(new object[] {
            "کلاسمان حادثه",
            "ناحیه",
            "تاریخ حادثه"});
            this.chkListAccident.Location = new System.Drawing.Point(24, 26);
            this.chkListAccident.Name = "chkListAccident";
            this.chkListAccident.Size = new System.Drawing.Size(237, 228);
            this.chkListAccident.TabIndex = 9;
            this.chkListAccident.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListAccident_ItemCheck);
            this.chkListAccident.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chkListAccident_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAll,
            this.mniClear});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // mniAll
            // 
            this.mniAll.Name = "mniAll";
            this.mniAll.Size = new System.Drawing.Size(147, 22);
            this.mniAll.Text = "انتخاب همه";
            // 
            // mniClear
            // 
            this.mniClear.Name = "mniClear";
            this.mniClear.Size = new System.Drawing.Size(147, 22);
            this.mniClear.Text = "پاک کردن همه";
            // 
            // btnParameters
            // 
            this.btnParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnParameters.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnParameters.Location = new System.Drawing.Point(243, 415);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(108, 32);
            this.btnParameters.TabIndex = 6;
            this.btnParameters.Text = "پارامترهای گزارش";
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.gbAccidentParameters);
            this.gbMain.Controls.Add(this.btnRefresh);
            this.gbMain.Controls.Add(this.faDatePickerBegin);
            this.gbMain.Controls.Add(this.faDatePickerEnd);
            this.gbMain.Controls.Add(this.lbBeginDate);
            this.gbMain.Controls.Add(this.lbEndDate);
            this.gbMain.Controls.Add(this.btnParameters);
            this.gbMain.Controls.Add(this.btnClose);
            this.gbMain.Controls.Add(this.btnViewReport);
            this.gbMain.Controls.Add(this.gbOptions);
            this.gbMain.Controls.Add(this.gbAccidentList);
            this.gbMain.Controls.Add(this.gbSeir);
            this.gbMain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbMain.Location = new System.Drawing.Point(3, 1);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(714, 459);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(357, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 33);
            this.btnRefresh.TabIndex = 102;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnViewReport.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReport.Image")));
            this.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReport.Location = new System.Drawing.Point(129, 415);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(108, 32);
            this.btnViewReport.TabIndex = 3;
            this.btnViewReport.Text = "مشاهده گزارش";
            this.btnViewReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // gbAccidentList
            // 
            this.gbAccidentList.Controls.Add(this.btnEditImage);
            this.gbAccidentList.Controls.Add(this.pictureBox1);
            this.gbAccidentList.Controls.Add(this.grdEarlyAccident);
            this.gbAccidentList.Controls.Add(this.txtCount);
            this.gbAccidentList.Controls.Add(this.label2);
            this.gbAccidentList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbAccidentList.Location = new System.Drawing.Point(12, 47);
            this.gbAccidentList.Name = "gbAccidentList";
            this.gbAccidentList.Size = new System.Drawing.Size(690, 350);
            this.gbAccidentList.TabIndex = 7;
            this.gbAccidentList.TabStop = false;
            this.gbAccidentList.Text = "فهرست سوانح";
            this.gbAccidentList.Visible = false;
            // 
            // btnEditImage
            // 
            this.btnEditImage.Location = new System.Drawing.Point(129, 317);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(75, 23);
            this.btnEditImage.TabIndex = 4;
            this.btnEditImage.Text = "اصلاح تصویر";
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // grdEarlyAccident
            // 
            this.grdEarlyAccident.AllowUserToAddRows = false;
            this.grdEarlyAccident.AllowUserToDeleteRows = false;
            this.grdEarlyAccident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEarlyAccident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEarlyAccident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRws_Fld_AccidentDate,
            this.colRws_Fld_FileCategorize,
            this.Column1,
            this.Column2,
            this.colRow,
            this.Column3,
            this.colRws_Fld_pk_EarlyAccident});
            this.grdEarlyAccident.Location = new System.Drawing.Point(17, 27);
            this.grdEarlyAccident.MultiSelect = false;
            this.grdEarlyAccident.Name = "grdEarlyAccident";
            this.grdEarlyAccident.ReadOnly = true;
            this.grdEarlyAccident.RowHeadersWidth = 35;
            this.grdEarlyAccident.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEarlyAccident.Size = new System.Drawing.Size(657, 257);
            this.grdEarlyAccident.TabIndex = 0;
            this.grdEarlyAccident.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEarlyAccident_CellDoubleClick);
            // 
            // colRws_Fld_AccidentDate
            // 
            this.colRws_Fld_AccidentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRws_Fld_AccidentDate.DataPropertyName = "Rws_Fld_AccidentDate";
            this.colRws_Fld_AccidentDate.HeaderText = "تاریخ حادثه";
            this.colRws_Fld_AccidentDate.MinimumWidth = 80;
            this.colRws_Fld_AccidentDate.Name = "colRws_Fld_AccidentDate";
            this.colRws_Fld_AccidentDate.ReadOnly = true;
            this.colRws_Fld_AccidentDate.Width = 80;
            // 
            // colRws_Fld_FileCategorize
            // 
            this.colRws_Fld_FileCategorize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRws_Fld_FileCategorize.DataPropertyName = "Rws_Fld_FileCategorize";
            this.colRws_Fld_FileCategorize.HeaderText = "کلاسمان پرونده";
            this.colRws_Fld_FileCategorize.MinimumWidth = 150;
            this.colRws_Fld_FileCategorize.Name = "colRws_Fld_FileCategorize";
            this.colRws_Fld_FileCategorize.ReadOnly = true;
            this.colRws_Fld_FileCategorize.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "rws_fld_fk_region";
            this.Column1.HeaderText = "کد ناحیه";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rws_fld_fk_accidentdegree";
            this.Column2.HeaderText = "درجه حادثه";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // colRow
            // 
            this.colRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRow.DataPropertyName = "Rws_Fld_Row";
            this.colRow.HeaderText = "ردیف";
            this.colRow.Name = "colRow";
            this.colRow.ReadOnly = true;
            this.colRow.Width = 54;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "Rws_Fld_TrainNo";
            this.Column3.HeaderText = "شماره قطار";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // colRws_Fld_pk_EarlyAccident
            // 
            this.colRws_Fld_pk_EarlyAccident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRws_Fld_pk_EarlyAccident.DataPropertyName = "Rws_Fld_pk_EarlyAccident";
            this.colRws_Fld_pk_EarlyAccident.HeaderText = "کد حادثه";
            this.colRws_Fld_pk_EarlyAccident.MinimumWidth = 100;
            this.colRws_Fld_pk_EarlyAccident.Name = "colRws_Fld_pk_EarlyAccident";
            this.colRws_Fld_pk_EarlyAccident.ReadOnly = true;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCount.Location = new System.Drawing.Point(533, 319);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 2;
            this.txtCount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تعداد:";
            // 
            // gbSeir
            // 
            this.gbSeir.Controls.Add(this.txtTrainNo);
            this.gbSeir.Controls.Add(this.label1);
            this.gbSeir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbSeir.Location = new System.Drawing.Point(12, 47);
            this.gbSeir.Name = "gbSeir";
            this.gbSeir.Size = new System.Drawing.Size(690, 47);
            this.gbSeir.TabIndex = 103;
            this.gbSeir.TabStop = false;
            this.gbSeir.Visible = false;
            // 
            // txtTrainNo
            // 
            this.txtTrainNo.Location = new System.Drawing.Point(505, 17);
            this.txtTrainNo.Name = "txtTrainNo";
            this.txtTrainNo.Size = new System.Drawing.Size(100, 21);
            this.txtTrainNo.TabIndex = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(612, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 193;
            this.label1.Text = "شماره قطار";
            // 
            // frmDialogReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 462);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbReportParameters);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDialogReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات";
            this.Load += new System.EventHandler(this.frmDialogReport_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDialogReport_KeyUp);
            this.gbAccidentParameters.ResumeLayout(false);
            this.gbAccidentParameters.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbManouver.ResumeLayout(false);
            this.gbManouver.PerformLayout();
            this.gbBlameful.ResumeLayout(false);
            this.gbBlameful.PerformLayout();
            this.gbBarred.ResumeLayout(false);
            this.gbBarred.PerformLayout();
            this.gbAfoul.ResumeLayout(false);
            this.gbAfoul.PerformLayout();
            this.gbDie.ResumeLayout(false);
            this.gbDie.PerformLayout();
            this.gbLoss.ResumeLayout(false);
            this.gbLoss.PerformLayout();
            this.gbReportParameters.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbGroupingField.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbColumns.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbAccidentList.ResumeLayout(false);
            this.gbAccidentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEarlyAccident)).EndInit();
            this.gbSeir.ResumeLayout(false);
            this.gbSeir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccidentParameters;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerBegin;
        internal System.Windows.Forms.Label lbEndDate;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePickerEnd;
        internal System.Windows.Forms.Label lbBeginDate;
        private System.Windows.Forms.Label label36;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccidentKind;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbBarred;
        private System.Windows.Forms.RadioButton rdoBarredAll;
        private System.Windows.Forms.RadioButton rdoBarredNo;
        private System.Windows.Forms.RadioButton rdoBarredYes;
        private System.Windows.Forms.GroupBox gbAfoul;
        private System.Windows.Forms.RadioButton rdoAfoulAll;
        private System.Windows.Forms.RadioButton rdoAfoulNo;
        private System.Windows.Forms.RadioButton rdoAfoulYes;
        private System.Windows.Forms.GroupBox gbDie;
        private System.Windows.Forms.RadioButton rdoDieAll;
        private System.Windows.Forms.RadioButton rdoDieNo;
        private System.Windows.Forms.RadioButton rdoDieYes;
        private System.Windows.Forms.GroupBox gbLoss;
        private System.Windows.Forms.RadioButton rdoLossAll;
        private System.Windows.Forms.RadioButton rdoLossNo;
        private System.Windows.Forms.RadioButton rdoLossYes;
        private System.Windows.Forms.GroupBox gbBlameful;
        private System.Windows.Forms.RadioButton rdoBlamefulAll;
        private System.Windows.Forms.RadioButton rdoBlamefulNo;
        private System.Windows.Forms.RadioButton rdoBlamefulYes;
        private System.Windows.Forms.GroupBox gbManouver;
        private System.Windows.Forms.RadioButton rdoManouverAll;
        private System.Windows.Forms.RadioButton rdoManouverNo;
        private System.Windows.Forms.RadioButton rdoManouverYes;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbReportParameters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFooterTitle;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeaderTitle;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbColumns;
        private System.Windows.Forms.CheckedListBox chkListAccident;
        private System.Windows.Forms.Button btnParameters;
        private System.Windows.Forms.Button btnHideParameterGroup;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbAccidentList;
        private System.Windows.Forms.DataGridView grdEarlyAccident;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtTitr;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbGroupingField;
        private System.Windows.Forms.ListBox listboxGroupColumns;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniAll;
        private System.Windows.Forms.ToolStripMenuItem mniClear;
        private System.Windows.Forms.ListBox listboxSortColumns;
        private System.Windows.Forms.GroupBox gbSeir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrainNo;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRws_Fld_AccidentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRws_Fld_FileCategorize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRws_Fld_pk_EarlyAccident;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditImage;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboCategory;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboAccidentKind;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboDegree;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboEffective;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboRegion;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboReason;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox chkcboRailVehicleKind;
        private System.Windows.Forms.ComboBox cboLocation;
    }
}