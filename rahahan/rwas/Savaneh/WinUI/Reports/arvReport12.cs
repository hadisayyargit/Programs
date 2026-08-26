using System;
using System.Data;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using RWAS.Common;
using RWAS.BusinessRules;


namespace RWAS.WinUI
{
	public class arvReport12 : ActiveReport
	{
		int intPkEarlyAccident;
		ReportID reportID;

		public arvReport12(int intPkEarlyAccident, ReportID reportID)
		{
			InitializeReport();
			this.intPkEarlyAccident = intPkEarlyAccident;
			this.reportID = reportID;
		}


		private void arvReport12_DataInitialize(object sender, System.EventArgs eArgs)
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
		private DataDynamics.ActiveReports.Label Label1 = null;
		private DataDynamics.ActiveReports.Label Label2 = null;
		private DataDynamics.ActiveReports.Label Label3 = null;
		private DataDynamics.ActiveReports.Label Label5 = null;
		private DataDynamics.ActiveReports.Label Label6 = null;
		private DataDynamics.ActiveReports.Label Label7 = null;
		private DataDynamics.ActiveReports.Line Line = null;
		private DataDynamics.ActiveReports.Line Line2 = null;
		private DataDynamics.ActiveReports.Line Line4 = null;
		private DataDynamics.ActiveReports.Line Line5 = null;
		private DataDynamics.ActiveReports.Line Line6 = null;
		private DataDynamics.ActiveReports.TextBox TextBox = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
		private DataDynamics.ActiveReports.TextBox TextBox2 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.TextBox TextBox4 = null;
		private DataDynamics.ActiveReports.TextBox TextBox5 = null;
		private DataDynamics.ActiveReports.Label Label4 = null;
		private DataDynamics.ActiveReports.Line Line13 = null;
		private DataDynamics.ActiveReports.TextBox TextBox41 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;
		private DataDynamics.ActiveReports.Line Line3 = null;
		private DataDynamics.ActiveReports.Line Line11 = null;
		private DataDynamics.ActiveReports.Line Line12 = null;
		private DataDynamics.ActiveReports.TextBox TextBox6 = null;
		private DataDynamics.ActiveReports.PageFooter PageFooter = null;
		private DataDynamics.ActiveReports.Line Line8 = null;
		private DataDynamics.ActiveReports.Line Line9 = null;
		private DataDynamics.ActiveReports.Line Line10 = null;
		private DataDynamics.ActiveReports.Label Label8 = null;
		private DataDynamics.ActiveReports.Line Line7 = null;
		private DataDynamics.ActiveReports.TextBox TextBox7 = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvReport12.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[0]));
			this.Line1 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[1]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[2]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[3]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[4]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[5]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[6]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[7]));
			this.Line = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[8]));
			this.Line2 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[9]));
			this.Line4 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[10]));
			this.Line5 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[11]));
			this.Line6 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[12]));
			this.TextBox = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[13]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[14]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[15]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[16]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[17]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[18]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[19]));
			this.Line13 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[20]));
			this.TextBox41 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[21]));
			this.Line3 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[0]));
			this.Line11 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[1]));
			this.Line12 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[2]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			this.Line8 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[0]));
			this.Line9 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[1]));
			this.Line10 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[2]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.PageFooter.Controls[3]));
			this.Line7 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[4]));
			this.TextBox7 = ((DataDynamics.ActiveReports.TextBox)(this.PageFooter.Controls[5]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvReport12_DataInitialize);
		}

		#endregion
	}
}
