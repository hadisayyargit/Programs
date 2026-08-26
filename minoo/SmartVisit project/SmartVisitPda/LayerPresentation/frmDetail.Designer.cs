namespace layerPresentation
{
    partial class frmDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label8 = new System.Windows.Forms.Label();
            this.picKalaImage = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKalads = new System.Windows.Forms.TextBox();
            this.txtForooshcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mniDeleteRow = new System.Windows.Forms.MenuItem();
            this.mniCancelMenu = new System.Windows.Forms.MenuItem();
            this.panelKala = new System.Windows.Forms.Panel();
            this.ibtnSearch = new HControls.HImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdKala = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.colKalasn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colForooshCode = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colKalads = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colMojoodi = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colTaminKonandehDs = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colMinDarkhast = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colNerkhForoosh = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colNerkhMasraf = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colVahedeSanjesh = new System.Windows.Forms.DataGridTextBoxColumn();
            this.colKalaStatus = new System.Windows.Forms.DataGridTextBoxColumn();
            this.listViewDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.txtKalasn = new System.Windows.Forms.TextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lbCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinDarkhast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMojoodi = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbtnClose = new System.Windows.Forms.ToolBarButton();
            this.tbtnOk = new System.Windows.Forms.ToolBarButton();
            this.tbtnDetail = new System.Windows.Forms.ToolBarButton();
            this.tbtnKala = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.panelKala.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(379, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.Text = "کد فروش";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picKalaImage
            // 
            this.picKalaImage.Image = ((System.Drawing.Image)(resources.GetObject("picKalaImage.Image")));
            this.picKalaImage.Location = new System.Drawing.Point(3, 3);
            this.picKalaImage.Name = "picKalaImage";
            this.picKalaImage.Size = new System.Drawing.Size(96, 88);
            this.picKalaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtQuantity.Location = new System.Drawing.Point(292, 142);
            this.txtQuantity.MaxLength = 6;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(76, 35);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(371, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 26);
            this.label7.Text = "تعداد/مقدار";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(9, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKalads
            // 
            this.txtKalads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKalads.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKalads.Location = new System.Drawing.Point(9, 98);
            this.txtKalads.Name = "txtKalads";
            this.txtKalads.ReadOnly = true;
            this.txtKalads.Size = new System.Drawing.Size(359, 35);
            this.txtKalads.TabIndex = 1;
            // 
            // txtForooshcode
            // 
            this.txtForooshcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForooshcode.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtForooshcode.Location = new System.Drawing.Point(262, 10);
            this.txtForooshcode.Name = "txtForooshcode";
            this.txtForooshcode.Size = new System.Drawing.Size(106, 35);
            this.txtForooshcode.TabIndex = 0;
            this.txtForooshcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForooshcode_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(401, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.Text = "نام کالا";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.mniDeleteRow);
            this.contextMenu1.MenuItems.Add(this.mniCancelMenu);
            // 
            // mniDeleteRow
            // 
            this.mniDeleteRow.Text = "حذف ردیف";
            this.mniDeleteRow.Click += new System.EventHandler(this.mniDeleteRow_Click);
            // 
            // mniCancelMenu
            // 
            this.mniCancelMenu.Text = "بازگشت";
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
            this.panelKala.Controls.Add(this.grdKala);
            this.panelKala.Location = new System.Drawing.Point(8, 201);
            this.panelKala.Name = "panelKala";
            this.panelKala.Size = new System.Drawing.Size(465, 327);
            this.panelKala.Visible = false;
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("ibtnSearch.Image")));
            this.ibtnSearch.Location = new System.Drawing.Point(6, 283);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(45, 35);
            this.ibtnSearch.TabIndex = 21;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(222, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.Text = "نام کالا";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKey1
            // 
            this.txtKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKey1.Location = new System.Drawing.Point(292, 283);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(92, 35);
            this.txtKey1.TabIndex = 17;
            // 
            // txtKey2
            // 
            this.txtKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtKey2.Location = new System.Drawing.Point(66, 283);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(150, 35);
            this.txtKey2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(374, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.Text = "کد فروش";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grdKala
            // 
            this.grdKala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdKala.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grdKala.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdKala.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.grdKala.Location = new System.Drawing.Point(6, 6);
            this.grdKala.Name = "grdKala";
            this.grdKala.Size = new System.Drawing.Size(456, 271);
            this.grdKala.TabIndex = 0;
            this.grdKala.TableStyles.Add(this.dataGridTableStyle3);
            this.grdKala.DoubleClick += new System.EventHandler(this.grdKala_DoubleClick);
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colKalasn);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colForooshCode);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colKalads);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colMojoodi);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colTaminKonandehDs);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colMinDarkhast);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colNerkhForoosh);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colNerkhMasraf);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colVahedeSanjesh);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.colKalaStatus);
            // 
            // colKalasn
            // 
            this.colKalasn.Format = "";
            this.colKalasn.FormatInfo = null;
            this.colKalasn.HeaderText = "کد کالا";
            this.colKalasn.MappingName = "kalasn";
            this.colKalasn.NullText = "";
            this.colKalasn.Width = 0;
            // 
            // colForooshCode
            // 
            this.colForooshCode.Format = "";
            this.colForooshCode.FormatInfo = null;
            this.colForooshCode.HeaderText = "کد فروش";
            this.colForooshCode.MappingName = "forooshcode";
            this.colForooshCode.NullText = "";
            this.colForooshCode.Width = 110;
            // 
            // colKalads
            // 
            this.colKalads.Format = "";
            this.colKalads.FormatInfo = null;
            this.colKalads.HeaderText = "شرح کالا";
            this.colKalads.MappingName = "kalads";
            this.colKalads.NullText = "";
            this.colKalads.Width = 180;
            // 
            // colMojoodi
            // 
            this.colMojoodi.Format = "";
            this.colMojoodi.FormatInfo = null;
            this.colMojoodi.HeaderText = "موجودی";
            this.colMojoodi.MappingName = "mojoodi";
            this.colMojoodi.NullText = "";
            this.colMojoodi.Width = 80;
            // 
            // colTaminKonandehDs
            // 
            this.colTaminKonandehDs.Format = "";
            this.colTaminKonandehDs.FormatInfo = null;
            this.colTaminKonandehDs.HeaderText = "تأمین کننده";
            this.colTaminKonandehDs.MappingName = "taminkonandehds";
            this.colTaminKonandehDs.NullText = "";
            this.colTaminKonandehDs.Width = 200;
            // 
            // colMinDarkhast
            // 
            this.colMinDarkhast.Format = "";
            this.colMinDarkhast.FormatInfo = null;
            this.colMinDarkhast.HeaderText = "حداقل درخواست";
            this.colMinDarkhast.MappingName = "mindarkhastkala";
            this.colMinDarkhast.NullText = "";
            this.colMinDarkhast.Width = 100;
            // 
            // colNerkhForoosh
            // 
            this.colNerkhForoosh.Format = "";
            this.colNerkhForoosh.FormatInfo = null;
            this.colNerkhForoosh.HeaderText = "نرخ";
            this.colNerkhForoosh.MappingName = "nerkheforoosh";
            this.colNerkhForoosh.NullText = "";
            this.colNerkhForoosh.Width = 100;
            // 
            // colNerkhMasraf
            // 
            this.colNerkhMasraf.Format = "";
            this.colNerkhMasraf.FormatInfo = null;
            this.colNerkhMasraf.HeaderText = "نرخ مصرف";
            this.colNerkhMasraf.MappingName = "nerkhemasraf";
            this.colNerkhMasraf.NullText = "";
            this.colNerkhMasraf.Width = 100;
            // 
            // colVahedeSanjesh
            // 
            this.colVahedeSanjesh.Format = "";
            this.colVahedeSanjesh.FormatInfo = null;
            this.colVahedeSanjesh.HeaderText = "بسته بندی";
            this.colVahedeSanjesh.MappingName = "vahedesanjeshds";
            this.colVahedeSanjesh.NullText = "";
            this.colVahedeSanjesh.Width = 100;
            // 
            // colKalaStatus
            // 
            this.colKalaStatus.Format = "";
            this.colKalaStatus.FormatInfo = null;
            this.colKalaStatus.HeaderText = "وضعیت";
            this.colKalaStatus.MappingName = "kalastatus";
            this.colKalaStatus.NullText = "";
            this.colKalaStatus.Width = 100;
            // 
            // listViewDetails
            // 
            this.listViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDetails.BackColor = System.Drawing.Color.White;
            this.listViewDetails.Columns.Add(this.columnHeader1);
            this.listViewDetails.Columns.Add(this.columnHeader3);
            this.listViewDetails.Columns.Add(this.columnHeader4);
            this.listViewDetails.Columns.Add(this.columnHeader2);
            this.listViewDetails.Columns.Add(this.columnHeader5);
            this.listViewDetails.Columns.Add(this.columnHeader6);
            this.listViewDetails.ContextMenu = this.contextMenu1;
            this.listViewDetails.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.listViewDetails.FullRowSelect = true;
            this.listViewDetails.Location = new System.Drawing.Point(9, 35);
            this.listViewDetails.Name = "listViewDetails";
            this.listViewDetails.Size = new System.Drawing.Size(447, 283);
            this.listViewDetails.TabIndex = 47;
            this.listViewDetails.View = System.Windows.Forms.View.Details;
            this.listViewDetails.SelectedIndexChanged += new System.EventHandler(this.listViewKala_SelectedIndexChanged);
            this.listViewDetails.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewKala_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "کد کالا";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "کد فروش";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "نام کالا";
            this.columnHeader4.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "تعداد";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "نرخ";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "مبلغ";
            this.columnHeader6.Width = 200;
            // 
            // txtKalasn
            // 
            this.txtKalasn.Location = new System.Drawing.Point(181, 10);
            this.txtKalasn.Name = "txtKalasn";
            this.txtKalasn.Size = new System.Drawing.Size(43, 41);
            this.txtKalasn.TabIndex = 48;
            this.txtKalasn.Visible = false;
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.Controls.Add(this.lbCount);
            this.panelDetail.Controls.Add(this.label9);
            this.panelDetail.Controls.Add(this.lbSum);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.listViewDetails);
            this.panelDetail.Location = new System.Drawing.Point(8, 201);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(465, 327);
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lbCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCount.Location = new System.Drawing.Point(284, 6);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(63, 26);
            this.lbCount.Text = "0";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(119, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 26);
            this.label9.Text = "جمع نهایی:";
            // 
            // lbSum
            // 
            this.lbSum.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lbSum.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSum.Location = new System.Drawing.Point(9, 6);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(104, 26);
            this.lbSum.Text = "0";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(353, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.Text = "تعداد اقلام:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(144, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.Text = "حداقل درخواست";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMinDarkhast
            // 
            this.txtMinDarkhast.Enabled = false;
            this.txtMinDarkhast.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMinDarkhast.Location = new System.Drawing.Point(61, 142);
            this.txtMinDarkhast.MaxLength = 4;
            this.txtMinDarkhast.Name = "txtMinDarkhast";
            this.txtMinDarkhast.ReadOnly = true;
            this.txtMinDarkhast.Size = new System.Drawing.Size(77, 35);
            this.txtMinDarkhast.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(386, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.Text = "موجودی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMojoodi
            // 
            this.txtMojoodi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMojoodi.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.txtMojoodi.Location = new System.Drawing.Point(262, 54);
            this.txtMojoodi.MaxLength = 5;
            this.txtMojoodi.Name = "txtMojoodi";
            this.txtMojoodi.ReadOnly = true;
            this.txtMojoodi.Size = new System.Drawing.Size(106, 35);
            this.txtMojoodi.TabIndex = 64;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.txtMinDarkhast);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.picKalaImage);
            this.panelMain.Controls.Add(this.txtKalads);
            this.panelMain.Controls.Add(this.txtMojoodi);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.txtForooshcode);
            this.panelMain.Controls.Add(this.txtQuantity);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.txtKalasn);
            this.panelMain.Controls.Add(this.panelDetail);
            this.panelMain.Controls.Add(this.panelKala);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(477, 533);
            // 
            // inputPanel1
            // 
            this.inputPanel1.EnabledChanged += new System.EventHandler(this.inputPanel1_EnabledChanged);
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.Add(this.tbtnClose);
            this.toolBar1.Buttons.Add(this.tbtnOk);
            this.toolBar1.Buttons.Add(this.tbtnDetail);
            this.toolBar1.Buttons.Add(this.tbtnKala);
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbtnClose
            // 
            this.tbtnClose.ImageIndex = 2;
            // 
            // tbtnOk
            // 
            this.tbtnOk.ImageIndex = 3;
            // 
            // tbtnDetail
            // 
            this.tbtnDetail.ImageIndex = 1;
            // 
            // tbtnKala
            // 
            this.tbtnKala.ImageIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.Images.Clear();
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource2"))));
            this.imageList1.Images.Add(((System.Drawing.Icon)(resources.GetObject("resource3"))));
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 536);
            this.ControlBox = false;
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmDetail";
            this.Text = "اقلام سربرگ";
            this.Load += new System.EventHandler(this.frmKala_Load);
            this.GotFocus += new System.EventHandler(this.frmKala_GotFocus);
            this.panelKala.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picKalaImage;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKalads;
        private System.Windows.Forms.TextBox txtForooshcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelKala;
        private System.Windows.Forms.DataGrid grdKala;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mniDeleteRow;
        private System.Windows.Forms.MenuItem mniCancelMenu;
        private System.Windows.Forms.DataGridTextBoxColumn colKalasn;
        private System.Windows.Forms.DataGridTextBoxColumn colKalads;
        private System.Windows.Forms.DataGridTextBoxColumn colForooshCode;
        private System.Windows.Forms.DataGridTextBoxColumn colMojoodi;
        private System.Windows.Forms.ListView listViewDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtKalasn;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DataGridTextBoxColumn colTaminKonandehDs;
        private System.Windows.Forms.DataGridTextBoxColumn colMinDarkhast;
        private System.Windows.Forms.DataGridTextBoxColumn colNerkhMasraf;
        private System.Windows.Forms.DataGridTextBoxColumn colNerkhForoosh;
        private System.Windows.Forms.DataGridTextBoxColumn colVahedeSanjesh;
        private System.Windows.Forms.DataGridTextBoxColumn colKalaStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMojoodi;
        private System.Windows.Forms.Panel panelMain;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinDarkhast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label4;
        private HControls.HImageButton ibtnSearch;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton tbtnDetail;
        private System.Windows.Forms.ToolBarButton tbtnKala;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton tbtnClose;
        private System.Windows.Forms.ToolBarButton tbtnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCount;
    }
}