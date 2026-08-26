
//*********************************************************************
// File Name : DataGridComponent
// Class Name :GerneralBaseUI Class
// Namespace  : DataGridComponent.WinUI

// Codding By : Developers Group
// Date       : 8/24/2004

// Description: 

//*********************************************************************//

using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using ProgLib.Components;


namespace ProgLib.Overlap
{
	/// <summary>
	/// Summary description for GeneralBaseUI.
	/// </summary>
	public class DataGridOverLapComponent
	{
		#region Variable

		#region Over Controls

		ComboBox cmbOver;
		Button btnOver;
		PictureBox PicOver;
		TabControl tbcOver;
		CDataGrid dgOver;
		Components.CTreeView TvwOver;
		Components.CCalender CalenderOver; 

		#endregion

		#region Controls DataSets

		DataTable _DgTable;
		DataTable _CmbTable;
		DataSet _TvwTable;

		#endregion

		#region ExternalObject
		private static CDataGrid  _Dg;
		private static System.Windows.Forms.ComboBox _Cmb;
		private static System.Windows.Forms.TreeView _Tvw;
		private static System.Windows.Forms.ListBox _Lb;
		private static System.Windows.Forms.Button _Btn;
		private static CDataGrid _OverDg;
		private static System.Windows.Forms.PictureBox  _Pic;
		private static System.Windows.Forms.TabControl   _Tbc;
		private static Components.CCalender _Calender;
		#endregion

		#region ColumnIndexes
		private static int _intCmbColumnIndex;
		private static int _intBtnColumnIndex;
		private static int _intTvwColumnIndex;
		private static int _intLbColumnIndex;
		private static int _intDgColumnIndex;
		private static int _intPicColumnIndex;
		private static int _intTbcColumnIndex;
		private static int _intCalenderCoulmnIndex;

		private static string _strCodeColumnName;
		private static int _intCodeCoulmnIndex;

		#endregion

		#region ObjectEventHandler

		private EventHandler _NewGetEvent;

		private EventHandler _BtnGetEvent;
		private EventHandler _CalenderGetEvent;
		
		#endregion
		
		#region OtherVariable

		int _intInputColumnKind;
		int _intOverControlType;
		private static string _strColumnName;

		#endregion

		#region Declare Enum

		private enum InputColumnStyle
		{
			Index=0,
			Name=1
		}

		#endregion

		#endregion

		#region Properties

		#region Dg

		public static CDataGrid  Dg
		{
			set
			{
				_Dg=value;
			}
			get
			{
				return(_Dg);
			}
		}

		#endregion

		#region External Object

		public static CDataGrid OverDg
		{
			set
			{
				_OverDg=value;
			}
			get
			{
				return(_OverDg);
			}
		}


		public static System.Windows.Forms.ComboBox Cmb
		{
			set
			{
				_Cmb=value;
			}
			get
			{
				return(_Cmb);
			}
		}

		public static System.Windows.Forms.TreeView Tvw
		{
			set
			{
				_Tvw=value;
			}
			get
			{
				return(_Tvw);
			}
		}

		public static System.Windows.Forms.Button Btn
		{
			set
			{
				_Btn=value;
			}
			get
			{
				return(_Btn);
			}
		}

		public static System.Windows.Forms.ListBox Lb
		{
			set
			{
				_Lb=value;
			}
			get
			{
				return(_Lb);
			}
		}

		public static System.Windows.Forms.PictureBox  Pic
		{
			set
			{
				_Pic=value;
			}
			get
			{
				return(_Pic);
			}
		}
		public static System.Windows.Forms.TabControl   Tbc
		{
			set
			{
				_Tbc=value;
			}
			get
			{
				return(_Tbc);
			}
		}

		public static Components.CCalender  Calender
		{
			set
			{
				_Calender=value;
			}
			get
			{
				return(_Calender);
			}
		}

		#endregion

		#endregion

		#region Constructor

		/// <summary>
		/// GeneralBaseUI
		/// </summary>
		public DataGridOverLapComponent()
		{
			_intOverControlType=0;
		}

		#endregion

		#region General

		/// <summary>
		/// Hidden
		/// </summary>
		/// <param name="BtnIsactive"></param>
		/// <param name="TvwIsActive"></param>
		/// <param name="LbIsActive"></param>
		/// <param name="OverDgIsActive"></param>
		/// <param name="PicIsActive"></param>
		/// <param name="CmbIsactive"></param>
		/// <param name="TbcIsActive"></param>
		/// <param name="CalenderIsActive"></param>
		private void Hidden(bool BtnIsactive,bool TvwIsActive,bool LbIsActive,bool OverDgIsActive,bool PicIsActive,bool CmbIsactive,bool TbcIsActive,bool CalenderIsActive )
		{
			try
			{
				Btn.Visible=BtnIsactive;
				Tvw.Visible=TvwIsActive;
				OverDg.Visible=OverDgIsActive;
				Pic.Visible=PicIsActive;
				Cmb.Visible =CmbIsactive;
				Tbc.Visible=TbcIsActive;
				Calender.Visible=CalenderIsActive;

				if (BtnIsactive)
				{
					Btn.Visible = BtnIsactive;
					Btn.BringToFront();
					Btn.Focus();
				}
				else if (TvwIsActive)
				{
					Tvw.Visible = TvwIsActive;
					Tvw.BringToFront();
					Tvw.Focus();
				}
				else if (OverDgIsActive)
				{
					OverDg.Visible = OverDgIsActive;
					OverDg.BringToFront();
					OverDg.Focus();
				}
				else if (PicIsActive)
				{
					Pic.Visible = PicIsActive;
					Pic.BringToFront();
					Pic.Focus();
				}
				else if (CmbIsactive)
				{
					Cmb.Visible = CmbIsactive;
					Cmb.BringToFront();
					Cmb.Focus();
				}
				else if (TbcIsActive)
				{
					Tbc.Visible=TbcIsActive;
					Tbc.BringToFront();
					Tbc.Focus();
				}
				else if (CalenderIsActive)
				{
					Calender.Visible=CalenderIsActive;
					Calender.BringToFront();
					Calender.Focus();
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
		
		}


		/// <summary>
		/// HiddenOtherObject
		/// </summary>
		/// <param name="ObjectName"></param>
		private void HiddenOtherObject(OverControlType ObjectName)
		{
			try
			{
				switch( ObjectName )
				{   
					case OverControlType.Button:
						Hidden(true,false,false,false,false,false,false,false);
						break;
					case OverControlType.ComboBox:
						Hidden(false,false,false,false,false,true,false,false);
						break;
					case OverControlType.DataGrid:
						Hidden(false,false,false,true,false,false,false,false);
						break;
					case OverControlType.ListBox:
						Hidden(false,false,false,false,false,false,false,false);
						break;
					case OverControlType.Picture:
						Hidden(false,false,false,false,true,false,false,false);
						break;
					case OverControlType.TreeView:
						Hidden(false,true,false,false,false,false,false,false);
						break;
					case OverControlType.TabControl:
						Hidden(false,false,false,false,false,false,true,false);
						break;
					case OverControlType.Calender:
						Hidden(false,false,false,false,false,false,false,true);
						break;
				}
			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
		
		}



		
		/// <summary>
		/// HiddenObjects
		/// </summary>
		private void HiddenObjects()
		{
			try
			{
				if (Cmb!=null)
					Cmb.Visible=false;

				if (Btn!=null)
					Btn.Visible=false;

				if (Tvw !=null)
					Tvw.Visible=false;

				if (OverDg !=null)
					OverDg.Visible=false;

				if (Pic!=null)
					Pic.Visible=false;

				if (Calender!=null)
					Calender.Visible=false;

				if (Tbc !=null)
					Tbc.Visible=false;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
		
		}

		#endregion

		#region Dg_CurrentCellChange

		/// <summary>
		/// Dg_CurrentCellChanged
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Dg_CurrentCellChanged(object sender, System.EventArgs e)
		{
			bool boolClickOnIndexes;
			
			try
			{
				boolClickOnIndexes=false;

				_NewGetEvent(sender,e);

				if ((_intOverControlType & (int)OverControlType.ComboBox)== (int)OverControlType.ComboBox)
					if( Dg.CurrentCell.ColumnNumber == _intCmbColumnIndex)
					{
						DgComBoxCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.ComboBox);
						boolClickOnIndexes=true;
					}
				if ((_intOverControlType & (int)OverControlType.Button)== (int)OverControlType.Button)
					if( Dg.CurrentCell.ColumnNumber == _intBtnColumnIndex)
					{
						DgButtonCurrentCellChange();
						HiddenOtherObject(OverControlType.Button);
						boolClickOnIndexes=true;
					}
	
				if ((_intOverControlType & (int)OverControlType.TreeView)== (int)OverControlType.TreeView)
					if( Dg.CurrentCell.ColumnNumber == _intTvwColumnIndex)
					{
						DgTreeViewCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.TreeView);
						boolClickOnIndexes=true;
					}

				if ((_intOverControlType & (int)OverControlType.DataGrid)== (int)OverControlType.DataGrid)
					if( Dg.CurrentCell.ColumnNumber == _intDgColumnIndex)
					{
						DgDataGridCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.DataGrid);
						boolClickOnIndexes=true;
					}
			
				if ((_intOverControlType & (int)OverControlType.Picture)== (int)OverControlType.Picture)
					if( Dg.CurrentCell.ColumnNumber == _intPicColumnIndex)
					{
						DgPictureCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.Picture);
						boolClickOnIndexes=true;
					}
				if ((_intOverControlType & (int)OverControlType.TabControl)== (int)OverControlType.TabControl)
					if( Dg.CurrentCell.ColumnNumber == _intTbcColumnIndex)
					{
						DgTabControlCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.TabControl);
						boolClickOnIndexes=true;
					}
				if ((_intOverControlType & (int)OverControlType.Calender)== (int)OverControlType.Calender)
					if( Dg.CurrentCell.ColumnNumber == _intCalenderCoulmnIndex)
					{
						DgCalenderCurrentCellChange(sender,e);
						HiddenOtherObject(OverControlType.Calender);
						boolClickOnIndexes=true;
					}

				if (boolClickOnIndexes==false)
					Hidden(false,false,false,false,false,false,false,false);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}

		#endregion

		#region Dg_Scroll

		/// <summary>
		/// Dg_Scroll
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Dg_Scroll(object sender, System.EventArgs e)
		{
			HiddenObjects();

		}


		#endregion

		#region Dg_ColumnWidthChange
				
		
		/// <summary>
		/// ResetColumnWidth
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetColumnWidth(Object sender,System.EventArgs e)
		{
			bool boolSet;

			boolSet=false;

			try
			{

				if (Dg.CurrentCell.ColumnNumber == _intCalenderCoulmnIndex)
				{
					Calender.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X = rect.X+Dg.Left;
					rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
					Calender.Location = rect.Location;
					Calender.Show();

					boolSet=true;
				}



				if (Dg.CurrentCell.ColumnNumber == _intTbcColumnIndex)
				{
					Tbc.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X = rect.X+Dg.Left;
					rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
					Tbc.Location = rect.Location;

					boolSet=true;
				}



				if (Dg.CurrentCell.ColumnNumber == _intDgColumnIndex)
				{
					OverDg.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X = rect.X+Dg.Left;
					rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
					OverDg.Location = rect.Location;

					boolSet=true;
				}


				if (Dg.CurrentCell.ColumnNumber == _intTvwColumnIndex)
				{
					Tvw.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X = rect.X+Dg.Left;
					rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
					Tvw.Location = rect.Location;	

					boolSet=true;
				}


				if (Dg.CurrentCell.ColumnNumber == _intCmbColumnIndex)
				{
					Cmb.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X += Dg.Left;
					rect.Y += Dg.Top;
					Cmb.Location = rect.Location;
					Cmb.Size = new Size(Dg.GetCurrentCellBounds().Width, Dg.GetCurrentCellBounds().Height);

					boolSet=true;
				}


				if (Dg.CurrentCell.ColumnNumber == _intBtnColumnIndex)
				{
					Btn.Parent = Dg.Parent;
					Rectangle rect = Dg.GetCurrentCellBounds();
					rect.X += Dg.Left;
					rect.Y += Dg.Top;
					Btn.Location = rect.Location;
					Btn.Size = new Size(Dg.GetCurrentCellBounds().Width, Dg.GetCurrentCellBounds().Height);

					boolSet=true;
				}

				if (boolSet==false)
					Hidden(false,false,false,false,false,false,false,false);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
				

		}

		#endregion

		#region SetDataGrid Apearance



		/// <summary>
		/// SetDgApearance
		/// </summary>
		/// <param name="strTableName"></param>
		/// <param name="FieldsKind"></param>
		/// <param name="FieldsName"></param>
		/// <param name="HeaderText"></param>
		/// <param name="Width"></param>
		public void SetDgApearance(string strTableName,ArrayList FieldsKind,ArrayList FieldsName,ArrayList HeaderText,ArrayList Width,ArrayList Mask,ArrayList MaxLength)
		{
			DataGridTableStyle ocDataGridTableStyle=new DataGridTableStyle();

			DataGridTextBoxColumn[] TextColumnStyle;
			DataGridBoolColumn[] BoolColumnStyle;
			ProgLib.Components.CDataGridMaskTextBoxColumn[] MaskColumnStyle;

			try
			{
				TextColumnStyle=new DataGridTextBoxColumn[FieldsKind.Count];
				BoolColumnStyle=new DataGridBoolColumn[FieldsKind.Count];
				MaskColumnStyle=new ProgLib.Components.CDataGridMaskTextBoxColumn[FieldsKind.Count];

				ocDataGridTableStyle.MappingName=strTableName;

				
				for (int intCount=0;intCount<FieldsKind.Count;++intCount)
				{
					if (Convert.ToInt32(FieldsKind[intCount])==0)
					{
						if (Mask[intCount].ToString() =="")
						{
							TextColumnStyle[intCount]=new DataGridTextBoxColumn();

							TextColumnStyle[intCount].MappingName =FieldsName[intCount].ToString();
							TextColumnStyle[intCount].HeaderText=HeaderText[intCount].ToString();
							TextColumnStyle[intCount].Width=Convert.ToInt32(Width[intCount]);
							if (Convert.ToInt32(MaxLength[intCount])!=0)
								TextColumnStyle[intCount].TextBox.MaxLength=Convert.ToInt32(MaxLength[intCount]);

							TextColumnStyle[intCount].WidthChanged+=new System.EventHandler(this.ResetColumnWidth);

							ocDataGridTableStyle.GridColumnStyles.Add(TextColumnStyle[intCount]);
						}
						else if(Mask[intCount].ToString() !="")
						{
							MaskColumnStyle[intCount]=new ProgLib.Components.CDataGridMaskTextBoxColumn();

							MaskColumnStyle[intCount].MappingName =FieldsName[intCount].ToString();
							MaskColumnStyle[intCount].HeaderText=HeaderText[intCount].ToString();
							MaskColumnStyle[intCount].Width=Convert.ToInt32(Width[intCount]);
							MaskColumnStyle[intCount].Mask=Mask[intCount].ToString();
							if (Convert.ToInt32(MaxLength[intCount])!=0)
								MaskColumnStyle[intCount].TextBox.MaxLength =Convert.ToInt32(MaxLength[intCount]);

							MaskColumnStyle[intCount].WidthChanged+=new System.EventHandler(this.ResetColumnWidth);

							ocDataGridTableStyle.GridColumnStyles.Add(MaskColumnStyle[intCount]);

						}
					}
					else
					{
						BoolColumnStyle[intCount]=new DataGridBoolColumn();

						BoolColumnStyle[intCount].MappingName =FieldsName[intCount].ToString();
						BoolColumnStyle[intCount].HeaderText=HeaderText[intCount].ToString();
						BoolColumnStyle[intCount].Width=Convert.ToInt32(Width[intCount]);

						BoolColumnStyle[intCount].WidthChanged+=new System.EventHandler(this.ResetColumnWidth);

						ocDataGridTableStyle.GridColumnStyles.Add(BoolColumnStyle[intCount]);

					}
				
				}

			
				Dg.TableStyles.Add(ocDataGridTableStyle);

				ocDataGridTableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(173, 186,222);
				ocDataGridTableStyle.BackColor = System.Drawing.Color.FromArgb(239, 243, 255);
				ocDataGridTableStyle.AlternatingBackColor = System.Drawing.Color.White;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}


		}

		#endregion

		#region SetGeneralBase

		/// <summary>
		/// SetGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="GetEvent"></param>
		/// <param name="ScrollEvent"></param>
		public void SetGeneralBase(EventHandler GetEvent)
		{
			_NewGetEvent=GetEvent;

		}

		#endregion

		#region External Objects

		#region ComboBox Setting	


			

		/// <summary>
		/// SetComboGeneralBase
		/// </summary>
		/// <param name="intCmbColumnIndex"></param>
		/// <param name="ocCmbDataSourse"></param>
		/// <param name="CmbValueMember"></param>
		/// <param name="CmbDisplayMember"></param>
		/// <param name="ocDgDataSource"></param>
		/// <param name="CodeColumnName"></param>
		/// <param name="CodeColumnIndex"></param>
		public void SetComboGeneralBase(int intCmbColumnIndex,DataTable ocCmbDataSourse,string CmbValueMember,string CmbDisplayMember,DataTable ocDgDataSource,string CodeColumnName,int CodeColumnIndex)
		{
			try
			{
				SetComboProperties(ocCmbDataSourse,CmbValueMember,CmbDisplayMember);

				_intOverControlType=_intOverControlType | (int)OverControlType.ComboBox;

				_intCmbColumnIndex=intCmbColumnIndex;
				_strCodeColumnName=CodeColumnName;
				_intCodeCoulmnIndex=CodeColumnIndex;
				_CmbTable =ocCmbDataSourse;
				_DgTable =ocDgDataSource;

				Cmb.SelectedValueChanged += new System.EventHandler(this.cmbSelectedValueChange);
				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}


		

		/// <summary>
		/// SetComboGeneralBase
		/// </summary>
		/// <param name="intCmbColumnIndex"></param>
		/// <param name="ocCmbDataSourse"></param>
		/// <param name="CmbValueMember"></param>
		/// <param name="CmbDisplayMember"></param>
		/// <param name="ocDgDataSource"></param>
		/// <param name="CodeColumnName"></param>
		/// <param name="CodeColumnIndex"></param>
		/// <param name="FilterFieldName"></param>
		/// <param name="FilterColumnVal"></param>
		/// <param name="Type"></param>
		public void SetComboGeneralBase(int intCmbColumnIndex,DataTable ocCmbDataSourse,string CmbValueMember,string CmbDisplayMember,DataTable ocDgDataSource,string CodeColumnName,int CodeColumnIndex,string FilterFieldName,int FilterColumnVal,VarType Type)
		{
			try
			{
				SetComboPropertiesFiltering(ocCmbDataSourse,CmbValueMember,CmbDisplayMember,FilterFieldName,FilterColumnVal,Type);

				_intOverControlType=_intOverControlType | (int)OverControlType.ComboBox;

				_intCmbColumnIndex=intCmbColumnIndex;
				_strCodeColumnName=CodeColumnName;
				_intCodeCoulmnIndex=CodeColumnIndex;
				_CmbTable =ocCmbDataSourse;
				_DgTable =ocDgDataSource;

				Cmb.SelectedValueChanged += new System.EventHandler(this.cmbSelectedValueChange);
				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// SetComboPropertiesFiltering
		/// </summary>
		/// <param name="ocCmbDataSourse"></param>
		/// <param name="CmbValueMember"></param>
		/// <param name="CmbDisplayMember"></param>
		/// <param name="FilterFieldName"></param>
		/// <param name="FilterColumnVal"></param>
		/// <param name="Type"></param>
		private void SetComboPropertiesFiltering(DataTable ocCmbDataSourse,string CmbValueMember,string CmbDisplayMember,string FilterFieldName,int FilterColumnVal,VarType Type)
		{
			DataView ocDataView;
 
			cmbOver=new ComboBox();

			try
			{
				cmbOver.DropDownStyle=ComboBoxStyle.DropDownList;
				cmbOver.RightToLeft=RightToLeft.Yes;

				ocDataView=ocCmbDataSourse.DefaultView;

				if (Type==VarType.intType)
					ocDataView.RowFilter=FilterFieldName+ "=" + Dg[Dg.CurrentRowIndex,FilterColumnVal].ToString();
				else if (Type==VarType.stringType)
					ocDataView.RowFilter=FilterFieldName+ "= '" + Dg[Dg.CurrentRowIndex,FilterColumnVal].ToString() +"'";
			
				cmbOver.DataSource=ocDataView;
				cmbOver.DisplayMember=CmbDisplayMember;
				cmbOver.ValueMember=CmbValueMember;

				Cmb=cmbOver;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}


		}




		/// <summary>
		/// SetComboProperties
		/// </summary>
		/// <param name="ocCmbDataSourse"></param>
		/// <param name="CmbValueMember"></param>
		/// <param name="CmbDisplayMember"></param>
		private void SetComboProperties(DataTable ocCmbDataSourse,string CmbValueMember,string CmbDisplayMember)
		{
			cmbOver=new ComboBox();

			try
			{
				cmbOver.DropDownStyle=ComboBoxStyle.DropDownList;
				cmbOver.RightToLeft=RightToLeft.Yes;

				cmbOver.DataSource=ocCmbDataSourse;
				cmbOver.DisplayMember=CmbDisplayMember;
				cmbOver.ValueMember=CmbValueMember;

				Cmb=cmbOver;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}


		}



		/// <summary>
		/// cmbSelectedValueChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void cmbSelectedValueChange(object sender,System.EventArgs e)
		{

			DataRow[] ocDataRow;

			try
			{
 
				ocDataRow=_DgTable.Select(_strCodeColumnName + "="+ Dg[Dg.CurrentRowIndex,_intCodeCoulmnIndex].ToString());

				ocDataRow[0][_intCmbColumnIndex]=Cmb.GetItemText(Cmb.SelectedItem);

				Cmb.Visible=false;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
		}




		/// <summary>
		/// DgComBoxCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgComBoxCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intCmbColumnIndex)
					{
						Cmb.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X += Dg.Left;
						rect.Y += Dg.Top;
						Cmb.Location = rect.Location;
						Cmb.Size = new Size(Dg.GetCurrentCellBounds().Width, Dg.GetCurrentCellBounds().Height);


					}
					else
						Cmb.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{

				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}




		#endregion

		#region Button Setting	

		/// <summary>
		/// SetButtonGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="ScrollEvent"></param>
		public void SetButtonGeneralBase(int intBtnColumnIndex,EventHandler BtnClickEvent)
		{
			try
			{
				SetButtonProperties();

				_intOverControlType=_intOverControlType | (int)OverControlType.Button;

				_intBtnColumnIndex=intBtnColumnIndex;
				_BtnGetEvent=BtnClickEvent;

				btnOver.Click += new System.EventHandler(this.BtnClick);
				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// SetButtonProperties
		/// </summary>
		private void SetButtonProperties()
		{
			btnOver=new Button();

			Btn=btnOver;

		}


		/// <summary>
		/// BtnClick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClick(object sender , EventArgs e)
		{
			_BtnGetEvent(sender,e);

		}


		/// <summary>
		/// DgButtonCurrentCellChange
		/// </summary>
		private void DgButtonCurrentCellChange()
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intBtnColumnIndex)
					{
						Btn.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X += Dg.Left;
						rect.Y += Dg.Top;
						Btn.Location = rect.Location;
						Btn.Size = new Size(Dg.GetCurrentCellBounds().Width, Dg.GetCurrentCellBounds().Height);
					
					}
					else
					{}
					Btn.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}




		#endregion
		
		#region TreeView Setting	

		/// <summary>
		/// SetTreeViewGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="GetEvent"></param>
		/// <param name="ScrollEvent"></param>
		public void SetTreeViewGeneralBase(int intTvwColumnIndex,DataSet ocTvwDataSet,string TvwTableName,string TagFieldName,string DesFieldName,int intTopLevel,DataTable ocDgDataSource,string CodeColumnName,int CodeColumnIndex)
		{
			try
			{
				SetTreeViewProperties(ocTvwDataSet,TvwTableName,TagFieldName,DesFieldName,intTopLevel);

				_intOverControlType=_intOverControlType | (int)OverControlType.TreeView;

				_intTvwColumnIndex=intTvwColumnIndex;
				_strCodeColumnName=CodeColumnName;
				_intCodeCoulmnIndex=CodeColumnIndex;
				_TvwTable=ocTvwDataSet;
				_DgTable=ocDgDataSource;

				TvwOver.DoubleClick += new System.EventHandler(this.tvwDoubleClick);
				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// SetTreeViewProperties
		/// </summary>
		/// <param name="ocTvwDataSet"></param>
		/// <param name="TvwTableName"></param>
		/// <param name="TagFieldName"></param>
		/// <param name="DesFieldName"></param>
		/// <param name="TopLevel"></param>
		private void SetTreeViewProperties(DataSet ocTvwDataSet,string TvwTableName,string TagFieldName,string DesFieldName,int TopLevel)
		{
			try
			{
				TvwOver=new ProgLib.Components.CTreeView();

				ImageList tvwImageList=new ImageList();

				tvwImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Image\\new-2.PNG"));
				tvwImageList.Images.Add(Image.FromFile(Application.StartupPath + "\\Image\\new-3.PNG"));

				//Set the Describe & Tag
				ArrayList ocCoulemnArrayList=new ArrayList();
				ocCoulemnArrayList.Add(TagFieldName);
				ocCoulemnArrayList.Add(DesFieldName);

				TvwOver.ImageList=tvwImageList;
				TvwOver.Width=200;
				TvwOver.Height=150;

				//Set ImageIndexes
				ArrayList ocArrayList=new ArrayList();
				ocArrayList.Add(0);
				ocArrayList.Add(1);
					
				TvwOver.ImageArray=ocArrayList;

				TvwOver.TopLevelCode = TopLevel;
				TvwOver.Fill_TreeView(ocTvwDataSet,TvwTableName ,ocCoulemnArrayList);

				Tvw=TvwOver;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}




		/// <summary>
		/// tvwDoubleClick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tvwDoubleClick(object sender , EventArgs e)
		{
			DataRow[] ocDataRow;

			try
			{
 
				ocDataRow=_DgTable.Select(_strCodeColumnName + "=" +Dg[Dg.CurrentRowIndex,_intCodeCoulmnIndex].ToString());

				ocDataRow[0][_intTvwColumnIndex]=Tvw.SelectedNode.Text;

				HiddenObjects();

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}
		}


		/// <summary>
		/// SetTreeViewGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="ScrollEvent"></param>
		public void SetTreeViewGeneralBase(int intColumnNumber,EventHandler ScrollEvent)
		{
			try
			{
				_intOverControlType=_intOverControlType | (int)OverControlType.TreeView;

				_intTvwColumnIndex=intColumnNumber;

				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}


		/// <summary>
		/// DgTreeViewCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgTreeViewCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intTvwColumnIndex)
					{
						
						Tvw.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X = rect.X+Dg.Left;
						rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
						Tvw.Location = rect.Location;
		
					}
					else
						Tvw.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		#endregion

		#region DataGrid Setting	

		/// <summary>
		/// SetDataGridGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="GetEvent"></param>
		/// <param name="ScrollEvent"></param>
		public void SetDataGridGeneralBase(int intDgColumnIndex,DataTable ocDgOverDataSource,string strTableName,string FieldsKind,string FieldsName,string HeaderText,string Width)
		{
			try
			{
				SetDgProperties(ocDgOverDataSource,strTableName,FieldsKind,FieldsName,HeaderText,Width);

				_intOverControlType=_intOverControlType | (int)OverControlType.DataGrid;

				_intDgColumnIndex=intDgColumnIndex;

				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}


		/// <summary>
		/// SetDgOverAppearanceSetting
		/// </summary>
		/// <param name="strTableName"></param>
		/// <param name="FieldsKind"></param>
		/// <param name="FieldsName"></param>
		/// <param name="HeaderText"></param>
		/// <param name="Width"></param>
		private void SetDgOverAppearanceSetting(string strTableName,string FieldsKind,string FieldsName,string HeaderText,string Width)
		{
			try
			{
				ArrayList ocFiledKind=new ArrayList();
				ArrayList ocFiledName=new ArrayList();
				ArrayList ocHeaderText=new ArrayList();
				ArrayList ocWidth=new ArrayList();

				string strTemp;

				strTemp="";

				for (int intCount=0;intCount<FieldsKind.Length;++intCount)
				{
					if (FieldsKind[intCount]!= Convert.ToChar("/"))
					{
						strTemp=strTemp+FieldsKind[intCount];

						if (intCount==(FieldsKind.Length)-1)
							ocFiledKind.Add(strTemp);
					}

					else
					{
						ocFiledKind.Add(strTemp);
						strTemp="";
					}

				}

				strTemp="";

				for (int intCount=0;intCount<FieldsName.Length;++intCount)
				{
					if (FieldsName[intCount]!= Convert.ToChar("/"))
					{
						strTemp=strTemp+FieldsName[intCount];

						if (intCount==(FieldsName.Length)-1)
							ocFiledName.Add(strTemp);
					}
					else
					{
						ocFiledName.Add(strTemp);
						strTemp="";
					}

				}

				strTemp="";

				for (int intCount=0;intCount<HeaderText.Length;++intCount)
				{
					if (HeaderText[intCount]!= Convert.ToChar("/"))
					{
						strTemp=strTemp+HeaderText[intCount];

						if (intCount==(HeaderText.Length)-1)
							ocHeaderText.Add(strTemp);
					}
					else
					{
						ocHeaderText.Add(strTemp);
						strTemp="";
					}

				}

				strTemp="";

				for (int intCount=0;intCount<Width.Length;++intCount)
				{
					if (Width[intCount]!= Convert.ToChar("/"))
					{
						strTemp=strTemp+Width[intCount];

						if (intCount==(Width.Length)-1)
							ocWidth.Add(strTemp);
					}
					else
					{
						ocWidth.Add(strTemp);
						strTemp="";
					}

				}

			
				SetDgOverAppearance(strTableName,ocFiledKind,ocFiledName,ocHeaderText,ocWidth);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}


		}




		/// <summary>
		/// SetDgProperties
		/// </summary>
		/// <param name="ocDgOverDataSource"></param>
		/// <param name="TableName"></param>
		/// <param name="FieldsKind"></param>
		/// <param name="FieldsName"></param>
		/// <param name="HeaderText"></param>
		/// <param name="Width"></param>
		private void SetDgProperties(DataTable ocDgOverDataSource,string TableName,string FieldsKind,string FieldsName,string HeaderText,string Width)
		{
			dgOver=new CDataGrid();

			try
			{

				dgOver.DataSource=ocDgOverDataSource;

				dgOver.Width=250;
				dgOver.Height=150;
				dgOver.RightToLeft=RightToLeft.Yes;

				SetDgOverAppearanceSetting(TableName,FieldsKind,FieldsName,HeaderText,Width);

				OverDg=dgOver;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}




		/// <summary>
		/// SetDgOverAppearance
		/// </summary>
		/// <param name="strTableName"></param>
		/// <param name="FieldsKind"></param>
		/// <param name="FieldsName"></param>
		/// <param name="HeaderText"></param>
		/// <param name="Width"></param>
		private void SetDgOverAppearance(string strTableName,ArrayList FieldsKind,ArrayList FieldsName,ArrayList HeaderText,ArrayList Width)
		{
		
			try
			{

				DataGridTableStyle ocDataGridTableStyle=new DataGridTableStyle();

				DataGridColumnStyle[] ColumnStyle;

				ColumnStyle=new DataGridColumnStyle[FieldsKind.Count];

				ocDataGridTableStyle.MappingName=strTableName;

				for (int intCount=0;intCount<FieldsKind.Count;++intCount)
				{
					if (Convert.ToInt32(FieldsKind[intCount])==0)
					{
						ColumnStyle[intCount]=new DataGridTextBoxColumn();
					}
					else if(Convert.ToInt32(FieldsKind[intCount])==1)
					{
						ColumnStyle[intCount]=new DataGridBoolColumn();
					}
				}

				for (int intCount=0;intCount<FieldsKind.Count;++intCount)
				{
					ColumnStyle[intCount].MappingName =FieldsName[intCount].ToString();
					ColumnStyle[intCount].HeaderText=HeaderText[intCount].ToString();
					ColumnStyle[intCount].Width=Convert.ToInt32(Width[intCount]);

					ocDataGridTableStyle.GridColumnStyles.Add(ColumnStyle[intCount]);
				
				}

			
				dgOver.TableStyles.Add(ocDataGridTableStyle);

				ocDataGridTableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(173, 186,222);
				ocDataGridTableStyle.BackColor = System.Drawing.Color.FromArgb(239, 243, 255);
				ocDataGridTableStyle.AlternatingBackColor = System.Drawing.Color.White;

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

			

		}


		/// <summary>
		/// DgDataGridCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgDataGridCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intDgColumnIndex)
					{
						
						OverDg.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X = rect.X+Dg.Left;
						rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
						OverDg.Location = rect.Location;

					}
					else
						OverDg.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		
		#endregion

		#region Picture Setting	
		

		/// <summary>
		/// SetPicGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="GetEvent"></param>
		/// <param name="ScrollEvent"></param>
		public void SetPicGeneralBase(int intPicColumnIndex,ImageList PicImageList)
		{

			try
			{
				SetPicProperties(PicImageList);

				_intOverControlType=_intOverControlType | (int)OverControlType.Picture;

				_intPicColumnIndex=intPicColumnIndex;

				Pic.DoubleClick+=new System.EventHandler(this.PicDoubleClick);
				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}


		}



		/// <summary>
		/// SetPicProperties
		/// </summary>
		/// <param name="PicImageList"></param>
		private void SetPicProperties(ImageList PicImageList)
		{
			try
			{
				PicOver=new PictureBox();

				PicOver.Height=120;
				PicOver.Image=PicImageList.Images[Dg.CurrentCell.RowNumber];

				Pic=PicOver;
			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// PicDoubleClick
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PicDoubleClick(object sender , EventArgs e)
		{
			HiddenObjects();

		}

		/// <summary>
		/// DgPictureCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgPictureCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intPicColumnIndex)
					{
						
						Pic.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X = rect.X+Dg.Left;
						rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
						Pic.Location = rect.Location;

					}
					else
						Pic.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		

		#endregion

		#region TabControl Setting	


		/// <summary>
		/// SetTabControlGeneralBase
		/// </summary>
		/// <param name="intColumnNumber"></param>
		/// <param name="ScrollEvent"></param>
		public void SetTabControlGeneralBase(int intTbcColumnIndex)
		{
			try
			{
				SetTbcProperties();

				_intOverControlType=_intOverControlType | (int)OverControlType.TabControl;

				_intDgColumnIndex=intTbcColumnIndex;

				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// SetTbcProperties
		/// </summary>
		private void SetTbcProperties()
		{
			tbcOver=new TabControl();

			Tbc=tbcOver;

		}

		/// <summary>
		/// DgTabControlCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgTabControlCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intTbcColumnIndex)
					{
						
						Tbc.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X = rect.X+Dg.Left;
						rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
						Tbc.Location = rect.Location;

					}
					else
						Tbc.Visible = false;
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}


		

		#endregion

		#region Calender Setting	


		/// <summary>
		/// SetCalenderGeneralBase
		/// </summary >
		/// <param name="intColumnNumber"></param>
		/// <param name="GetEvent"></param>
		/// <param name="ScrollEvent"></param>
		public void SetCalenderGeneralBase(int intCalColumnIndex,DataTable ocDgDataSource,string CodeColumnName,int CodeColumnIndex)
		{
			try
			{
				SetCalenderProperties();

				_intOverControlType=_intOverControlType | (int)OverControlType.Calender;

				_intCalenderCoulmnIndex=intCalColumnIndex;
				_DgTable=ocDgDataSource;
				_intCodeCoulmnIndex=CodeColumnIndex;
				_strCodeColumnName=CodeColumnName;

				CalenderOver.DateClick += new ProgLib.Components.OnSelectedDate(this.CalenderClick);

				Dg.CurrentCellChanged += new System.EventHandler(Dg_CurrentCellChanged);
				Dg.Scroll += new System.EventHandler(Dg_Scroll);

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



		/// <summary>
		/// SetCalenderProperties
		/// </summary>
		private void SetCalenderProperties()
		{
			CalenderOver=new ProgLib.Components.CCalender();

			Calender=CalenderOver;

		}



		/// <summary>
		/// CalenderClick
		/// </summary>
		/// <param name="intYear"></param>
		/// <param name="intMonth"></param>
		/// <param name="intDay"></param>
		private void CalenderClick(int intYear, int intMonth, int intDay)
		{
			string strDate;
			DataRow[] ocDataRow;

			try
			{
				strDate=intYear+"/"+intMonth+"/"+intDay;
 
				ocDataRow=_DgTable.Select(_strCodeColumnName + "="+ Dg[Dg.CurrentRowIndex,_intCodeCoulmnIndex].ToString());

				ocDataRow[0][_intCalenderCoulmnIndex]=strDate;

				HiddenObjects();

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}

		/// <summary>
		/// DgCalenderCurrentCellChange
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgCalenderCurrentCellChange(object sender, System.EventArgs e)
		{
			try
			{
				if(_intInputColumnKind==(int)InputColumnStyle.Index)
				{
					if( Dg.CurrentCell.ColumnNumber == _intCalenderCoulmnIndex)
					{
						if (_CalenderGetEvent!=null)
							_CalenderGetEvent(sender,e); 
					
						Calender.Parent = Dg.Parent;
						Rectangle rect = Dg.GetCurrentCellBounds();
						rect.X = rect.X+Dg.Left;
						rect.Y += Dg.Top+Dg.GetCurrentCellBounds().Height;
						Calender.Location = rect.Location;
						Calender.Show();

					}
					else
					{
						Calender.Visible = false;
						Calender.Dispose();
					}
				}
				else if(_intInputColumnKind==(int)InputColumnStyle.Name)
				{
				
				}

			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}




		#endregion

		#endregion


	}
}
