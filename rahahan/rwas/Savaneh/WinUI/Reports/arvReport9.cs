using System;
using System.Data;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using RWAS.Common;
using RWAS.BusinessRules;


namespace RWAS.WinUI
{
	public class arvReport9 : ActiveReport
	{
		int intPkEarlyAccident;
		ReportID reportID;

		public arvReport9(int intPkEarlyAccident, ReportID reportID)
		{
			InitializeReport();
			this.intPkEarlyAccident = intPkEarlyAccident;
			this.reportID = reportID;
		}


		private void arvReport9_DataInitialize(object sender, System.EventArgs eArgs)
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
		private DataDynamics.ActiveReports.Label Label3 = null;
		private DataDynamics.ActiveReports.Label Label16 = null;
		private DataDynamics.ActiveReports.Line Line5 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.TextBox TextBox = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
		private DataDynamics.ActiveReports.TextBox TextBox41 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;
		private DataDynamics.ActiveReports.PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvReport9.rpx");
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
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[7]));
			this.Label16 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[8]));
			this.Line5 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[9]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[10]));
			this.TextBox = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[11]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[12]));
			this.TextBox41 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[13]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvReport9_DataInitialize);
		}

		#endregion
	}
}
