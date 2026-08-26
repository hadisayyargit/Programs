using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace RWAS.WinUI
{
	/// <summary>
	/// Summary description for LabelEx.
	/// </summary>
	public class LabelEx : System.Windows.Forms.Control
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LabelEx()
		{
			// This call is required by the Windows.Forms Form Designer.
			//InitializeComponent();
			this.SetStyle(ControlStyles.UserPaint,true);
			this.SetStyle(ControlStyles.DoubleBuffer,true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint,true);
			// TODO: Add any initialization after the InitComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
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
			components = new System.ComponentModel.Container();
		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e) 
		{
			base.OnPaint(e);
			System.Windows.Forms.ControlPaint.DrawSizeGrip(e.Graphics,Color.Black, 0,0,16,16);
		}
	}
}
