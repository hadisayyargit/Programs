using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using RWAS.Common;
using RWAS.Common.Combo;
using RWAS.BusinessRules;
using ProgLib;
using ProgLib.Configuration;
using ProgLib.Configuration.Event;

namespace RWAS.WinUI
{
	/// <summary>
	/// Summary description for UCSearchPersonel.
	/// </summary>
	public class UCSearchPersonel : System.Windows.Forms.UserControl
	{
		#region Windows Control
		private ProgLib.Components.CKeyBar CKeyBarSearchPersonel;
		private System.Windows.Forms.ComboBox cmbSearchSubContractor;
		private System.Windows.Forms.ComboBox cmbSearchRegion;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox cmbSearchJob;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtSearchLastName;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TextBox txtSearchFirstName;
		private System.Windows.Forms.DataGrid grdSearchPersonel;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.ImageList imglstSearchPersonel;
		private ProgLib.Components.CHelpPopup CHelpPopupSearchPersonel;
		private System.Windows.Forms.ToolTip ToolTipSearchPersonel;
		private System.Windows.Forms.TextBox txtSearchPersonelID;
		private System.ComponentModel.IContainer components;
		#endregion Windows Control

		#region Contruction
		public UCSearchPersonel()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			CKeyBarSearchPersonel.SetTooltip(ToolTipSearchPersonel);

			//Add any initialization after the InitializeComponent() call
			CKeyBarSearchPersonel.SetExitBtnInfo(imglstSearchPersonel.Images[0], new EventHandler(HandleExit), "Ctrl+X Œ—ÊÃ", "Exit");
			CKeyBarSearchPersonel.SetHelpBtnInfo(imglstSearchPersonel.Images[1],new EventHandler(HandleHelp), "Ctrl+H —«Â‰„«", "Help");
			CKeyBarSearchPersonel.AddKey(imglstSearchPersonel.Images[2],new EventHandler(HandleLoad), "Load", "Ctrl+l »«—ê–«—Ì «ÿ·«⁄«  Å—”‰· ");
			CKeyBarSearchPersonel.AddKey(imglstSearchPersonel.Images[3],new EventHandler(HandleSrch), "Srch", "Ctrl+S Ã” ÃÊ ");
			CKeyBarSearchPersonel.AddKey(imglstSearchPersonel.Images[4],new EventHandler(HandleReset), "Reset", "Ctrl+R Œ«·Ì ”«“Ì ›—„ »—«Ì Ã” ÃÊÌ „Ãœœ");

			CHelpPopupSearchPersonel.SetHelpText(CKeyBarSearchPersonel.GetItem("Exit"), CMessageHandler.HandleHelp(9));
			CHelpPopupSearchPersonel.SetHelpText(CKeyBarSearchPersonel.GetItem("Help"), CMessageHandler.HandleHelp(8));
			CHelpPopupSearchPersonel.SetHelpText(CKeyBarSearchPersonel.GetItem("Load"), CMessageHandler.HandleHelp(32));
			CHelpPopupSearchPersonel.SetHelpText(CKeyBarSearchPersonel.GetItem("Srch"), CMessageHandler.HandleHelp(11));
			CHelpPopupSearchPersonel.SetHelpText(CKeyBarSearchPersonel.GetItem("Reset"), CMessageHandler.HandleHelp(15));
		}
		#endregion Contruction

		#region DefineVar

		private ProgLib.Classes.CUtilities objUtil = new ProgLib.Classes.CUtilities();
		DataView objDataView;
		PersonelData objPersonelData;
//		int intParentWidth,intParentHeight;
		int intUID;
		string strPersonelFirstName;
		string strPersonelLastName;

		enum eGridCol
		{
			Prs_Fld_UniqueCode=0,
			Prs_Fld_PersonelID=1,
			Prs_Fld_FirstName=2,
			Prs_Fld_LastName=3,
			Prs_Fld_Region=4,
			Prs_Fld_SubContractor=5,
			Rws_Fld_JobDescribe=6,
			count=7
		};
		#endregion

		#region HandleKeys
		//*********************************************************************
		// Method Name : HandleExit
		// Called By : FrmSearchPersonel
		// Date       : 9/7/2005
		/// <summary>
		///»” ‰ ›—„
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//*********************************************************************
		private void HandleExit(object sender, System.EventArgs e)
		{
			try 
			{
				if ( CKeyBarSearchPersonel.EnableItem("Save") == true ) 
				{
					//if user has changed some thing and didnot save it , system must
					//tell him about that
					if ( ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 16), "Â‘œ«—", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes ) 
					{
						CLogManager.Clear();
						strPersonelFirstName="";
						strPersonelLastName="";
						intUID=0;
						this.Visible=true;
					}
				} 
				else
				{
					if ( ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 245), "Å—”‘", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						CLogManager.Clear();
						strPersonelFirstName="";
						strPersonelLastName="";
						intUID=0;
						this.Visible=true;
					}
				}
			} 
			catch (Exception ocException) 
			{ 
				CLogManager.boolLogOnLine = true;
				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 35), "«Œÿ«—", MessageBoxButtons.OK, MessageBoxIcon.Error );
				CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, "FrmSearchPersonel");
				CLogManager.boolLogOnLine = false;
			}
		}

		//*********************************************************************
		// Method Name : HandleHelp
		// Called By : FrmSearchPersonel
		// Date       : 9/7/2005
		/// <summary>
		///„ Êœ ò„ò »Â ò«—»— ÃÂ  «” ›«œÂ —«Õ   — «“ ›—„
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//*********************************************************************
		private void HandleHelp(object sender, System.EventArgs e)
		{
			CHelpPopupSearchPersonel.SetHelpCursor(true);
		}

		//*********************************************************************
		// Method Name : HandleLoad
		// Called By : FrmSearchPersonel
		// Date       : 9/7/2005
		/// <summary>
		/// ‰„«Ì‘ ›—„ ê“«—‘ «Ê·ÌÂ Õ«œÀÂ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//*********************************************************************
		private void HandleLoad(object sender, System.EventArgs e)
		{
			clsBRPersonel objBRPersonel=new clsBRPersonel();
			//SecondaryInfo.FrmSecondaryAccidentReport objFrmSecondaryAccidentReport;

			try
			{
				if (grdSearchPersonel.CurrentRowIndex==-1)
					return;

				intUID=Convert.ToInt32(grdSearchPersonel[grdSearchPersonel.CurrentRowIndex,(int)eGridCol.Prs_Fld_UniqueCode]); 
				strPersonelFirstName=Convert.ToString(grdSearchPersonel[grdSearchPersonel.CurrentRowIndex,(int)eGridCol.Prs_Fld_FirstName]); 
				strPersonelLastName=Convert.ToString(grdSearchPersonel[grdSearchPersonel.CurrentRowIndex,(int)eGridCol.Prs_Fld_LastName]); 

				CLogManager.Clear();
				this.Visible=true;

				//objPersonelData=objBRPersonel.IsExPersonelByName(txtSearchFirstName.Text, txtSearchLastName.Text, Convert.ToInt32(txtSearchPersonelID.Text), 0);
				//grdSearchPersonel.DataSource=objPersonelData.Prs_Sp_Sel_IsEx_PersonelInfo;
			}
			catch(System.Exception ocException)
			{
				CLogManager.boolLogOnLine = true;
				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 14), "«Œÿ«—", MessageBoxButtons.OK, MessageBoxIcon.Error );
				CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, "FrmSearchPersonel");
				CLogManager.boolLogOnLine = false;
			}
		}

		//*********************************************************************
		// Method Name : HandleSrch
		// Called By : FrmSurveyItem
		// Date       : 9/7/2005
		/// <summary>
		/// Ã” ÃÊ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//*********************************************************************
		private void HandleSrch(object sender, System.EventArgs e)
		{
			if (txtSearchPersonelID.Text == "" )
				txtSearchPersonelID.Text = "0";

			try
			{
				UserPersonel objBRPersonel=new UserPersonel();

				this.Cursor = Cursors.WaitCursor;
				objPersonelData = objBRPersonel.IsExContractorPersonelByName(txtSearchFirstName.Text, txtSearchLastName.Text, Convert.ToInt32(txtSearchPersonelID.Text),0, Convert.ToInt32(cmbSearchJob.SelectedValue), Convert.ToByte(cmbSearchRegion.SelectedValue));
				this.Cursor = Cursors.Default;

				objDataView=objPersonelData.Prs_Sp_Sel_Personel.DefaultView;
				objDataView.RowFilter="";

				grdSearchPersonel.DataSource = objDataView;

				if (objDataView.Count==0)
				{
					CKeyBarSearchPersonel.EnableItem("Load", false);

					ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 40), "¬ê«ÂÌ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					CKeyBarSearchPersonel.EnableItem("Load", true);
			}
			catch(System.Exception ocException)
			{
				this.Cursor = Cursors.Default;
				CLogManager.boolLogOnLine = true;
				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 34), "«Œÿ«—", MessageBoxButtons.OK, MessageBoxIcon.Error );
				CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, "FrmSearchPersonel");
				CLogManager.boolLogOnLine = false;
			}
		}

		//*********************************************************************
		// Method Name : HandleReset
		// Called By : FrmSurveyItem
		// Date       : 9/7/2005
		/// <summary>
		///  €ÌÌ— Ê÷⁄Ì  ÃÂ  Ã” ÃÊÌ „Ãœœ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//*********************************************************************
		private void HandleReset(object sender, System.EventArgs e)
		{
			try
			{
				txtSearchFirstName.Text="";
				txtSearchLastName.Text="";
				txtSearchPersonelID.Text="0";
				cmbSearchJob.SelectedIndex = -1;
				cmbSearchRegion.SelectedIndex = -1;
				cmbSearchSubContractor.SelectedIndex = -1;

				//				grdSearchPersonel.DataSource=objDataView;
				//
				//				objDataView.RowFilter="";
				//
				//				cNavigateSearchPersonel.SetData(objDataView);

				if (objDataView.Count==0)
					CKeyBarSearchPersonel.EnableItem("Load", false);
				else
					CKeyBarSearchPersonel.EnableItem("Load", true);
			}
			catch(System.Exception ocException)
			{
				CLogManager.boolLogOnLine = true;
				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 42), "«Œÿ«—", MessageBoxButtons.OK, MessageBoxIcon.Error );
				CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, "FrmSearchPersonel");
				CLogManager.boolLogOnLine = false;
			}
		}
		#endregion HandleKeys

		//*********************************************************************
		// Method Name : ListFill
		// Called By : FrmSearchPersonel
		// Date       : 9/7/2005
		/// <summary>
		/// Å— ‘œ‰ ·Ì”  «ÿ·«⁄« Ì
		/// </summary>
		//*********************************************************************
		private void FillInfo() 
		{
			clsBRSubContractor objBRSubContractor = new clsBRSubContractor();
			clsBRComboHandler objBRComboHandler = new clsBRComboHandler();

			DS_Region ocDS_Region = new DS_Region();
			DS_Job ocDS_Job = new DS_Job();
			clsDSOrgUnit objDSOrgUnit = new clsDSOrgUnit();
			clsDSSubContractor objDSSubContractor = new clsDSSubContractor();

			try
			{
				ocDS_Region = objBRComboHandler.getRegion();
				cmbSearchRegion.DataSource=ocDS_Region.Rws_Sp_Sel_All_Region;
				cmbSearchRegion.DisplayMember="Rws_Fld_Describe";
				cmbSearchRegion.ValueMember ="Rws_Fld_Code";

				ocDS_Job = objBRComboHandler.getJob();
				cmbSearchJob.DataSource=ocDS_Job.Prs_Sp_Sel_All_Job;
				cmbSearchJob.DisplayMember=clsDSPersonel.Prs_Fld_Describe;
				cmbSearchJob.ValueMember =clsDSPersonel.Prs_Fld_Code;

				objDSSubContractor = objBRSubContractor.GetSubContractor();
				cmbSearchSubContractor.DataSource=objDSSubContractor.Rws_Sp_Sel_All_SubContractor;
				cmbSearchSubContractor.DisplayMember=clsDSSubContractor.Rws_Fld_Describe;
				cmbSearchSubContractor.ValueMember =clsDSSubContractor.Rws_Fld_Code;

				UserPersonel objBRPersonel=new UserPersonel();
				objPersonelData = objBRPersonel.IsExContractorPersonelByName(txtSearchFirstName.Text,"h 7 6", Convert.ToInt32(txtSearchPersonelID.Text),0,Convert.ToInt32(cmbSearchJob.SelectedValue),Convert.ToByte(cmbSearchRegion.SelectedValue));

//				SetDataGridAppearance();

				objDataView=objPersonelData.Prs_Sp_Sel_Personel.DefaultView;
				objDataView.RowFilter="";

				grdSearchPersonel.DataSource = objDataView;
			} 
			catch (Exception ocException) 
			{
				CLogManager.boolLogOnLine = true;
				ProgLib.Components.MessageBox.Show(CMessageHandler.Handle(SystemID.idRWAS, 18), "«Œÿ«—", MessageBoxButtons.OK, MessageBoxIcon.Error );
				CLogManager.WriteLog(LogType.logError, SystemID.idRWAS, ocException.ToString(), CApplicationAssert.LineNumber, "FrmSearchPersonelReport");
				CLogManager.boolLogOnLine = false;
			}
		}


		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(UCSearchPersonel));
			this.CKeyBarSearchPersonel = new ProgLib.Components.CKeyBar();
			this.cmbSearchSubContractor = new System.Windows.Forms.ComboBox();
			this.cmbSearchRegion = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.cmbSearchJob = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSearchPersonelID = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtSearchLastName = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.txtSearchFirstName = new System.Windows.Forms.TextBox();
			this.grdSearchPersonel = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.imglstSearchPersonel = new System.Windows.Forms.ImageList(this.components);
			this.CHelpPopupSearchPersonel = new ProgLib.Components.CHelpPopup();
			this.ToolTipSearchPersonel = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grdSearchPersonel)).BeginInit();
			this.SuspendLayout();
			// 
			// CKeyBarSearchPersonel
			// 
			this.CKeyBarSearchPersonel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.CKeyBarSearchPersonel.Location = new System.Drawing.Point(8, 256);
			this.CKeyBarSearchPersonel.Name = "CKeyBarSearchPersonel";
			this.CKeyBarSearchPersonel.Size = new System.Drawing.Size(76, 29);
			this.CKeyBarSearchPersonel.TabIndex = 352;
			this.CKeyBarSearchPersonel.TabStop = false;
			// 
			// cmbSearchSubContractor
			// 
			this.cmbSearchSubContractor.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSearchSubContractor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearchSubContractor.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmbSearchSubContractor.Location = new System.Drawing.Point(8, 32);
			this.cmbSearchSubContractor.Name = "cmbSearchSubContractor";
			this.cmbSearchSubContractor.Size = new System.Drawing.Size(199, 20);
			this.cmbSearchSubContractor.TabIndex = 350;
			// 
			// cmbSearchRegion
			// 
			this.cmbSearchRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearchRegion.Location = new System.Drawing.Point(536, 31);
			this.cmbSearchRegion.Name = "cmbSearchRegion";
			this.cmbSearchRegion.TabIndex = 348;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(664, 33);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(31, 18);
			this.label22.TabIndex = 358;
			this.label22.Text = "‰«ÕÌÂ";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(208, 8);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(81, 18);
			this.label25.TabIndex = 356;
			this.label25.Text = "‘€· ”«“„«‰Ì";
			// 
			// cmbSearchJob
			// 
			this.cmbSearchJob.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSearchJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearchJob.Location = new System.Drawing.Point(8, 8);
			this.cmbSearchJob.Name = "cmbSearchJob";
			this.cmbSearchJob.Size = new System.Drawing.Size(200, 22);
			this.cmbSearchJob.TabIndex = 347;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(432, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 18);
			this.label5.TabIndex = 355;
			this.label5.Text = "‘„«—Â ﬂ«—„‰œÌ";
			// 
			// txtSearchPersonelID
			// 
			this.txtSearchPersonelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearchPersonelID.Location = new System.Drawing.Point(304, 31);
			this.txtSearchPersonelID.MaxLength = 20;
			this.txtSearchPersonelID.Name = "txtSearchPersonelID";
			this.txtSearchPersonelID.Size = new System.Drawing.Size(121, 22);
			this.txtSearchPersonelID.TabIndex = 349;
			this.txtSearchPersonelID.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(432, 8);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(71, 18);
			this.label18.TabIndex = 354;
			this.label18.Text = "‰«„ Œ«‰Ê«œêÌ";
			// 
			// txtSearchLastName
			// 
			this.txtSearchLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearchLastName.Location = new System.Drawing.Point(304, 8);
			this.txtSearchLastName.MaxLength = 20;
			this.txtSearchLastName.Name = "txtSearchLastName";
			this.txtSearchLastName.Size = new System.Drawing.Size(121, 22);
			this.txtSearchLastName.TabIndex = 346;
			this.txtSearchLastName.Text = "";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(672, 8);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(19, 18);
			this.label36.TabIndex = 353;
			this.label36.Text = "‰«„";
			// 
			// txtSearchFirstName
			// 
			this.txtSearchFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearchFirstName.Location = new System.Drawing.Point(536, 8);
			this.txtSearchFirstName.MaxLength = 20;
			this.txtSearchFirstName.Name = "txtSearchFirstName";
			this.txtSearchFirstName.Size = new System.Drawing.Size(121, 22);
			this.txtSearchFirstName.TabIndex = 345;
			this.txtSearchFirstName.Text = "";
			// 
			// grdSearchPersonel
			// 
			this.grdSearchPersonel.BackgroundColor = System.Drawing.Color.Azure;
			this.grdSearchPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.grdSearchPersonel.CaptionBackColor = System.Drawing.Color.FromArgb(((System.Byte)(67)), ((System.Byte)(131)), ((System.Byte)(158)));
			this.grdSearchPersonel.DataMember = "";
			this.grdSearchPersonel.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grdSearchPersonel.Location = new System.Drawing.Point(8, 56);
			this.grdSearchPersonel.Name = "grdSearchPersonel";
			this.grdSearchPersonel.ReadOnly = true;
			this.grdSearchPersonel.Size = new System.Drawing.Size(696, 192);
			this.grdSearchPersonel.TabIndex = 351;
			this.grdSearchPersonel.TabStop = false;
			this.grdSearchPersonel.Tag = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(208, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 359;
			this.label1.Text = "‘—ò  ÅÌ„«‰ò«—";
			// 
			// imglstSearchPersonel
			// 
			this.imglstSearchPersonel.ImageSize = new System.Drawing.Size(35, 25);
			this.imglstSearchPersonel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstSearchPersonel.ImageStream")));
			this.imglstSearchPersonel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// CHelpPopupSearchPersonel
			// 
			this.CHelpPopupSearchPersonel.BackColor = System.Drawing.SystemColors.Info;
			this.CHelpPopupSearchPersonel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.CHelpPopupSearchPersonel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.CHelpPopupSearchPersonel.Location = new System.Drawing.Point(96, 264);
			this.CHelpPopupSearchPersonel.Name = "CHelpPopupSearchPersonel";
			this.CHelpPopupSearchPersonel.Size = new System.Drawing.Size(75, 23);
			this.CHelpPopupSearchPersonel.TabIndex = 360;
			this.CHelpPopupSearchPersonel.TabStop = false;
			this.CHelpPopupSearchPersonel.Visible = false;
			// 
			// UCSearchPersonel
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.CHelpPopupSearchPersonel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CKeyBarSearchPersonel);
			this.Controls.Add(this.cmbSearchSubContractor);
			this.Controls.Add(this.cmbSearchRegion);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.cmbSearchJob);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSearchPersonelID);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtSearchLastName);
			this.Controls.Add(this.label36);
			this.Controls.Add(this.txtSearchFirstName);
			this.Controls.Add(this.grdSearchPersonel);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.Name = "UCSearchPersonel";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(712, 288);
			this.Load += new System.EventHandler(this.UCSearchPersonel_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdSearchPersonel)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void UCSearchPersonel_Load(object sender, System.EventArgs e)
		{
		
		}

	}
}
