using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace RWAS.WinUI
{
	/// <summary>
	/// Summary description for Combo.
	/// </summary>
	public class Combo : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TextBox txtValue;
		private ButtonEx btnSearch;

		/// <summary>
		/// protected value that is set to true of false within the
		///  SetTextValueToSelectedNode method.
		/// </summary>
		protected bool TextValueSet;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ListBox listBox1;


		[
		Description("Gets the TreeView Data Table"),
		Category("TreeView")
		]
		private DataTable _DataSource;
		public DataTable DataSource 
		{
			get 
			{
				return _DataSource;
			}
			set 
			{
				
				_DataSource = value;
			}
		}
		

		[
		Description("Gets the TreeView Data Table"),
		Category("TreeView")
		]
		private string _Text="";
		public string Text 
		{
			get 
			{
				return _Text.Trim();
			}
			set 
			{
				_Text = value;
			}
		}

		private string _SelectedValue="";
		public string SelectedValue 
		{
			get 
			{

				
				return _SelectedValue.Trim();
			}
			set 
			{
				try
				{
					_SelectedValue = value;
					if(_SelectedValue != String.Empty)
					{
						DataRow [] drs = _DataSource.Select(_ValueMember+"='"+_SelectedValue+"'");
						txtValue.Text = drs[0][_DisplayMember].ToString().Trim();
						txtValue.Tag = drs[0][_ValueMember].ToString().Trim();
					}

					//				this.Text = drs[0][_DisplayMember].ToString();
					//				this.Tag = drs[0][_ValueMember].ToString();
					//				this.SelectedValue = drs[0][_ValueMember].ToString();
				}
				catch(Exception  ex)
				{
				}

			}
		}

		//private int _SelectedIndex;
		public int SelectedIndex 
		{
			get 
			{
				return listBox1.SelectedIndex;
			}
			set 
			{
				listBox1.SelectedIndex = value;
			}
		}

		private string _ValueMember="";
		public string ValueMember 
		{
			get 
			{
				return _ValueMember;
			}
			set 
			{
				_ValueMember = value;
			}
		}

		private string _DisplayMember="";
		public string DisplayMember 
		{
			get 
			{
				return _DisplayMember;
			}
			set 
			{
				_DisplayMember = value;
			}
		}

		public event System.EventHandler Click;
		protected virtual void OnClick(object sender) 
		{
			// Raise the tabclicked event.
			if(this.Click != null) 
				this.Click(sender, new EventArgs());
		}


		public Combo()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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
			this.txtValue = new System.Windows.Forms.TextBox();
			this.btnSearch = new RWAS.WinUI.ButtonEx();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtValue
			// 
			this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtValue.Location = new System.Drawing.Point(0, 0);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(200, 20);
			this.txtValue.TabIndex = 3;
			this.txtValue.Text = "";
			this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(0, 0);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(18, 20);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "button1";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.Location = new System.Drawing.Point(0, 22);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(200, 69);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
			// 
			// Combo
			// 
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtValue);
			this.Name = "Combo";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Size = new System.Drawing.Size(200, 80);
			this.Load += new System.EventHandler(this.Combo_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void Combo_Load(object sender, System.EventArgs e)
		{
			listBox1.Width = 0;
		}

		protected void btnSearch_Click(object sender, System.EventArgs e)
		{
			if(listBox1.Width == 0)
			{
				OnClick(sender);
				listBox1.Width = this.Width;
				listBox1.Height = this.Height -(txtValue.Height + btnSearch.Height);//txtValue.Width + btnSearch.Width;
				//this.Height =txtValue.Width ;
				this.Height=120;
			}
			else
			{
				listBox1.Width = 0;
				listBox1.Height = txtValue.Height + btnSearch.Height;
				this.Height = txtValue.Height;
				
			}
		}

		private void txtValue_TextChanged(object sender, System.EventArgs e)
		{
			this.Text = txtValue.Text;

			if(listBox1.Width != 0 && txtValue.Text.Length >0)
			{
				listBox1.Width = 0;
				listBox1.Height =this.Height -(txtValue.Height + btnSearch.Height);
				this.Height = txtValue.Height;
				
			}
			
		}

		public void DataBind()
		{
			ArrayList Items = new ArrayList();
			Items.Clear();
			if(_DataSource.Rows.Count != 0)
			{
				for(int i =0; i<_DataSource.Rows.Count ;i++)
				{
					DataRow dr = _DataSource.Rows[i];
					Items.Add(new Item(dr[_DisplayMember].ToString(),dr[_ValueMember].ToString()));
				}
			}
			listBox1.DataSource = Items;
			listBox1.DisplayMember = "Value";
			//listBox1.ValueMember = "ID";
		

		}

		private void listBox1_SelectedValueChanged(object sender, System.EventArgs e)
		{
			txtValue.Text = "";
			//DataView dv= new DataView(_DataSource,"id = '"+txtValue.Text+"'","",DataViewRowState.CurrentRows);
			Item selectedItem =(Item) listBox1.SelectedValue;
			txtValue.Text = selectedItem.Value;
			txtValue.Tag = selectedItem.ID;
			this.Text = selectedItem.Value;
			this.Tag = selectedItem.ID;
			this.SelectedValue = selectedItem.ID;
		}
	}
}
