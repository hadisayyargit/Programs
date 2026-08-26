using System;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using ProgLib.Components;
using System.ComponentModel;

namespace ProgLib.Overlap
{
	/// <summary>
	/// Summary description for TreeViewComponent.
	/// </summary>
	
	public class TreeViewDgOverlap :  ProgLib.Components.CTreeView 
	{

		private Container components;
		DataGrid dgOver;
		DataTable ocDgOverDataSource=new DataTable();
		string strTableName;
		string strFieldsKind;
		string strFieldsName;
		string strHeaderText;
		string strWidth;
		int intDgWidth;
		int intDgHeight;

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams params1 = base.CreateParams;
				//				try
				//				{
				//					CLicence licence1 = new CLicence();
				//					licence1.LicenceCheck();
				//				}
				//				catch (Exception exception1)
				//				{
				//					throw new Exception("ProgLib Error - CTreeView : " + exception1.Message);
				//				}
				params1 = base.CreateParams;
				params1.ExStyle |= 0x400000;
				return params1;
			}
		}


		private void InitializeComponent()
		{
			this.components = new Container();
		}

		public TreeViewDgOverlap()
		{
			this.InitializeComponent();

			

			base.MouseDown  += new System.Windows.Forms.MouseEventHandler(TvwMouseDown);

			
		}

		public void SetOverLapGrid(int DataGridWidth,int DataGridHeight,DataTable ocinitDgOverDataSource,string initTableName,string initFieldsKind,string initFieldsName,string initHeaderText,string initWidth)
		{
			intDgWidth=DataGridWidth;
			intDgHeight=DataGridHeight;

			ocDgOverDataSource=ocinitDgOverDataSource;
			strTableName=initTableName;
			strFieldsKind=initFieldsKind;
			strFieldsName=initFieldsName;
			strHeaderText=initHeaderText;
			strWidth=initWidth;
		}

		private void TvwMouseDown(object sender,System.Windows.Forms.MouseEventArgs e)
		{
			int _intX,_intY;
			int _intDgX,_intDgY;
			
			TreeNode ocTreeNode; 
			Rectangle Rec; 

			dgOver=new DataGrid();

			//If right Click
			if (e.Button == MouseButtons.Right)
			{
				//Get the location of clicked point
				_intX=e.X;
				_intY=e.Y;

				//Get the node that is at that location
				ocTreeNode=base.GetNodeAt(_intX,_intY);

				//set selected node with the node that is in this location
				base.SelectedNode=ocTreeNode;

				if(base.SelectedNode==null)
					return;

				//Get the bounds of selected node
				Rec=base.SelectedNode.Bounds;

				//if the clicked point is in the area of Rec
				if ((Rec.Y <= _intY && _intY<=Rec.Y+Rec.Height) && (Rec.X  <= _intX && _intX<=Rec.X+Rec.Width))
				{

					ocTreeNode=base.GetNodeAt(_intX,_intY);

					if(ocTreeNode!=null)
					{

						//Set the location of DataGrid
						_intDgX=(base.Width -_intX)-dgOver.Width ;
						_intDgY=_intY;

						//if DaraGrid location is out of tree view location
						if (_intDgY + dgOver.Height > base.Height)
							_intDgY=_intDgY-dgOver.Height;

						

						//dgOver.BringToFront();


						//dgOver.RightToLeft=System.Windows.Forms.RightToLeft.Yes;

						SetDgProperties(ocDgOverDataSource,strTableName,strFieldsKind,strFieldsName,strHeaderText,strWidth);

						dgOver.Location=new Point(_intDgX ,_intDgY);

						dgOver.Visible=true;

					}
					else
						dgOver.Visible=false;
				}
				else
					dgOver.Visible=false;

			}
			else
				dgOver.Visible=false;
		}




		private void SetDgProperties(DataTable ocDgOverDataSource,string TableName,string FieldsKind,string FieldsName,string HeaderText,string Width)
		{
			try
			{

				dgOver.DataSource=ocDgOverDataSource;

				dgOver.Width=intDgWidth;
				dgOver.Height=intDgHeight;
				//dgOver.RightToLeft=RightToLeft.Yes;

				//SetDgOverAppearanceSetting(strTableName,strFieldsKind,strFieldsName,strHeaderText,strWidth);

//				dgOver.BringToFront();

				this.Controls.Add(dgOver);

				


			}
			catch (Exception ocException)
			{
				throw (ocException);
			}

		}



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

			
				dgOver.TableStyles.Clear();
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



		
	}

}
