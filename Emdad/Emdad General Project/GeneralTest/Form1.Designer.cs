namespace GeneralTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtXmlInput = new System.Windows.Forms.TextBox();
            this.btnEcommerce = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectXml = new System.Windows.Forms.Button();
            this.txtXmlOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtMobileno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.btnGetFinalPrice = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDamageFinalRep = new System.Windows.Forms.TextBox();
            this.txtRequisition_SparePart = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtRequisition_Activity = new System.Windows.Forms.TextBox();
            this.btnGurantee = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnPublicTest = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXmlInput
            // 
            this.txtXmlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXmlInput.Location = new System.Drawing.Point(6, 106);
            this.txtXmlInput.Multiline = true;
            this.txtXmlInput.Name = "txtXmlInput";
            this.txtXmlInput.Size = new System.Drawing.Size(492, 65);
            this.txtXmlInput.TabIndex = 1;
            // 
            // btnEcommerce
            // 
            this.btnEcommerce.Location = new System.Drawing.Point(258, 176);
            this.btnEcommerce.Name = "btnEcommerce";
            this.btnEcommerce.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEcommerce.Size = new System.Drawing.Size(157, 23);
            this.btnEcommerce.TabIndex = 2;
            this.btnEcommerce.Text = "SubmitInvoice";
            this.btnEcommerce.UseVisualStyleBackColor = true;
            this.btnEcommerce.Click += new System.EventHandler(this.btnEcommerce_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectXml
            // 
            this.btnSelectXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectXml.Location = new System.Drawing.Point(368, 6);
            this.btnSelectXml.Name = "btnSelectXml";
            this.btnSelectXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSelectXml.Size = new System.Drawing.Size(130, 23);
            this.btnSelectXml.TabIndex = 3;
            this.btnSelectXml.Text = "انتخاب فایل xml";
            this.btnSelectXml.UseVisualStyleBackColor = true;
            this.btnSelectXml.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // txtXmlOutput
            // 
            this.txtXmlOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXmlOutput.Location = new System.Drawing.Point(6, 206);
            this.txtXmlOutput.Multiline = true;
            this.txtXmlOutput.Name = "txtXmlOutput";
            this.txtXmlOutput.ReadOnly = true;
            this.txtXmlOutput.Size = new System.Drawing.Size(492, 122);
            this.txtXmlOutput.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 360);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.btnSms);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtUserInput);
            this.tabPage1.Controls.Add(this.txtMobileno);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGetServices);
            this.tabPage1.Controls.Add(this.btnGetFinalPrice);
            this.tabPage1.Controls.Add(this.btnSelectXml);
            this.tabPage1.Controls.Add(this.txtXmlOutput);
            this.tabPage1.Controls.Add(this.txtXmlInput);
            this.tabPage1.Controls.Add(this.btnEcommerce);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "فروش";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(325, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "lang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(86, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "trace";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(358, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "1";
            // 
            // btnSms
            // 
            this.btnSms.Location = new System.Drawing.Point(6, 6);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(75, 23);
            this.btnSms.TabIndex = 11;
            this.btnSms.Text = "تست پیامک";
            this.btnSms.UseVisualStyleBackColor = true;
            this.btnSms.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(408, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "شماره موبایل";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserInput.Location = new System.Drawing.Point(83, 56);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(94, 21);
            this.txtUserInput.TabIndex = 9;
            this.txtUserInput.Text = "9655";
            // 
            // txtMobileno
            // 
            this.txtMobileno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMobileno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMobileno.Location = new System.Drawing.Point(302, 56);
            this.txtMobileno.Name = "txtMobileno";
            this.txtMobileno.Size = new System.Drawing.Size(100, 21);
            this.txtMobileno.TabIndex = 8;
            this.txtMobileno.Text = "989122105628";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(183, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "متن ورودی کاربر";
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(6, 176);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(147, 23);
            this.btnGetServices.TabIndex = 6;
            this.btnGetServices.Text = "ProgressSession";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.btnGetServices_Click);
            // 
            // btnGetFinalPrice
            // 
            this.btnGetFinalPrice.Location = new System.Drawing.Point(159, 176);
            this.btnGetFinalPrice.Name = "btnGetFinalPrice";
            this.btnGetFinalPrice.Size = new System.Drawing.Size(93, 23);
            this.btnGetFinalPrice.TabIndex = 5;
            this.btnGetFinalPrice.Text = "GetFinalPrice";
            this.btnGetFinalPrice.UseVisualStyleBackColor = true;
            this.btnGetFinalPrice.Click += new System.EventHandler(this.btnGetFinalPrice_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDamageFinalRep);
            this.tabPage2.Controls.Add(this.txtRequisition_SparePart);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.txtRequisition_Activity);
            this.tabPage2.Controls.Add(this.btnGurantee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "گارانتی بدنه";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "DamageFinalRep";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Requisition_SparePart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Requisition_Activity";
            // 
            // txtDamageFinalRep
            // 
            this.txtDamageFinalRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDamageFinalRep.Location = new System.Drawing.Point(124, 115);
            this.txtDamageFinalRep.Multiline = true;
            this.txtDamageFinalRep.Name = "txtDamageFinalRep";
            this.txtDamageFinalRep.Size = new System.Drawing.Size(374, 40);
            this.txtDamageFinalRep.TabIndex = 9;
            // 
            // txtRequisition_SparePart
            // 
            this.txtRequisition_SparePart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequisition_SparePart.Location = new System.Drawing.Point(124, 68);
            this.txtRequisition_SparePart.Multiline = true;
            this.txtRequisition_SparePart.Name = "txtRequisition_SparePart";
            this.txtRequisition_SparePart.Size = new System.Drawing.Size(374, 40);
            this.txtRequisition_SparePart.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(6, 189);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(492, 139);
            this.textBox4.TabIndex = 7;
            // 
            // txtRequisition_Activity
            // 
            this.txtRequisition_Activity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequisition_Activity.Location = new System.Drawing.Point(124, 6);
            this.txtRequisition_Activity.Multiline = true;
            this.txtRequisition_Activity.Name = "txtRequisition_Activity";
            this.txtRequisition_Activity.Size = new System.Drawing.Size(374, 55);
            this.txtRequisition_Activity.TabIndex = 5;
            this.txtRequisition_Activity.Text = "11;1134;567.89;33;1392/09/16;999@12;1234;567.89;33;1392/09/17;999";
            // 
            // btnGurantee
            // 
            this.btnGurantee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGurantee.Location = new System.Drawing.Point(341, 161);
            this.btnGurantee.Name = "btnGurantee";
            this.btnGurantee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGurantee.Size = new System.Drawing.Size(157, 23);
            this.btnGurantee.TabIndex = 6;
            this.btnGurantee.Text = "تست وب سرویسهای گارانتی بدنه";
            this.btnGurantee.UseVisualStyleBackColor = true;
            this.btnGurantee.Click += new System.EventHandler(this.btnGurantee_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtTest);
            this.tabPage3.Controls.Add(this.btnPublicTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(504, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(148, 200);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(195, 89);
            this.txtTest.TabIndex = 1;
            // 
            // btnPublicTest
            // 
            this.btnPublicTest.Location = new System.Drawing.Point(148, 171);
            this.btnPublicTest.Name = "btnPublicTest";
            this.btnPublicTest.Size = new System.Drawing.Size(75, 23);
            this.btnPublicTest.TabIndex = 0;
            this.btnPublicTest.Text = "تست کلاس";
            this.btnPublicTest.UseVisualStyleBackColor = true;
            this.btnPublicTest.Click += new System.EventHandler(this.btnPublicTest_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnLoad);
            this.tabPage4.Controls.Add(this.btnShow);
            this.tabPage4.Controls.Add(this.btnSave);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(504, 334);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Picture";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(15, 305);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.Location = new System.Drawing.Point(96, 305);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(177, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXmlInput;
        private System.Windows.Forms.Button btnEcommerce;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectXml;
        private System.Windows.Forms.TextBox txtXmlOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtRequisition_Activity;
        private System.Windows.Forms.Button btnGurantee;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.Button btnGetFinalPrice;
        private System.Windows.Forms.TextBox txtDamageFinalRep;
        private System.Windows.Forms.TextBox txtRequisition_SparePart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPublicTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.TextBox txtMobileno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
    }
}

