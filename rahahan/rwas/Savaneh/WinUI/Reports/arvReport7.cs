using System;
using System.Data;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using RWAS.Common;
using RWAS.BusinessRules;


namespace RWAS.WinUI
{
	public class arvReport7 : ActiveReport
	{
		int intPkEarlyAccident;
		ReportID reportID;

		public arvReport7(int intPkEarlyAccident, ReportID reportID)
		{
			InitializeReport();
			this.intPkEarlyAccident = intPkEarlyAccident;
			this.reportID = reportID;
		}

		private void arvReport7_DataInitialize(object sender, System.EventArgs eArgs)
		{
			clsBRDocReport objBRDocReport = new clsBRDocReport();
			DataSet ocDataSet = new DataSet();
			try
			{
				ocDataSet = objBRDocReport.SearchReport(intPkEarlyAccident,reportID);
				this.DataSource = ocDataSet.Tables[0].DefaultView;
			}
			catch(Exception ocException)
			{
				throw (ocException);
			}
		}

		#region ActiveReports Designer generated code
		private DataDynamics.ActiveReports.PageHeader PageHeader = null;
		private DataDynamics.ActiveReports.Label Label = null;
		private DataDynamics.ActiveReports.Line Line1 = null;
		private DataDynamics.ActiveReports.Line Line = null;
		private DataDynamics.ActiveReports.Line Line2 = null;
		private DataDynamics.ActiveReports.Line Line3 = null;
		private DataDynamics.ActiveReports.Line Line4 = null;
		private DataDynamics.ActiveReports.Label Label1 = null;
		private DataDynamics.ActiveReports.Label Label2 = null;
		private DataDynamics.ActiveReports.Label Label3 = null;
		private DataDynamics.ActiveReports.Label Label4 = null;
		private DataDynamics.ActiveReports.Label Label5 = null;
		private DataDynamics.ActiveReports.Label Label6 = null;
		private DataDynamics.ActiveReports.Label Label7 = null;
		private DataDynamics.ActiveReports.Label Label8 = null;
		private DataDynamics.ActiveReports.Label Label9 = null;
		private DataDynamics.ActiveReports.Label Label10 = null;
		private DataDynamics.ActiveReports.Label Label11 = null;
		private DataDynamics.ActiveReports.Label Label13 = null;
		private DataDynamics.ActiveReports.Label Label14 = null;
		private DataDynamics.ActiveReports.Label Label15 = null;
		private DataDynamics.ActiveReports.Label Label16 = null;
		private DataDynamics.ActiveReports.Line Line5 = null;
		private DataDynamics.ActiveReports.TextBox TextBox = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
		private DataDynamics.ActiveReports.TextBox TextBox2 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.TextBox TextBox4 = null;
		private DataDynamics.ActiveReports.TextBox TextBox5 = null;
		private DataDynamics.ActiveReports.TextBox TextBox6 = null;
		private DataDynamics.ActiveReports.TextBox TextBox7 = null;
		private DataDynamics.ActiveReports.TextBox TextBox8 = null;
		private DataDynamics.ActiveReports.TextBox TextBox9 = null;
		private DataDynamics.ActiveReports.TextBox TextBox10 = null;
		private DataDynamics.ActiveReports.TextBox TextBox12 = null;
		private DataDynamics.ActiveReports.TextBox TextBox13 = null;
		private DataDynamics.ActiveReports.TextBox TextBox14 = null;
		private DataDynamics.ActiveReports.TextBox TextBox15 = null;
		private DataDynamics.ActiveReports.TextBox TextBox16 = null;
		private DataDynamics.ActiveReports.Label Label17 = null;
		private DataDynamics.ActiveReports.TextBox TextBox41 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;
		private DataDynamics.ActiveReports.PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvReport7.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[0]));
			this.Line1 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[1]));
			this.Line = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[2]));
			this.Line2 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[3]));
			this.Line3 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[4]));
			this.Line4 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[5]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[6]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[7]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[8]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[9]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[10]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[11]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[12]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[13]));
			this.Label9 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[14]));
			this.Label10 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[15]));
			this.Label11 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[16]));
			this.Label13 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[17]));
			this.Label14 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[18]));
			this.Label15 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[19]));
			this.Label16 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[20]));
			this.Line5 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[21]));
			this.TextBox = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[22]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[23]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[24]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[25]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[26]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[27]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[28]));
			this.TextBox7 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[29]));
			this.TextBox8 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[30]));
			this.TextBox9 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[31]));
			this.TextBox10 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[32]));
			this.TextBox12 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[33]));
			this.TextBox13 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[34]));
			this.TextBox14 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[35]));
			this.TextBox15 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[36]));
			this.TextBox16 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[37]));
			this.Label17 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[38]));
			this.TextBox41 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[39]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvReport7_DataInitialize);
		}

		#endregion
	}
}
