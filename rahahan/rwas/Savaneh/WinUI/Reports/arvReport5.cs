using System;
using System.Data;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using RWAS.Common;
using RWAS.BusinessRules;


namespace RWAS.WinUI
{
	public class arvReport5 : ActiveReport
	{
		int intPkEarlyAccident;
		ReportID reportID;

		public arvReport5(int intPkEarlyAccident, ReportID reportID)
		{
			InitializeReport();
			this.intPkEarlyAccident = intPkEarlyAccident;
			this.reportID = reportID;
		}

		private void arvReport5_DataInitialize(object sender, System.EventArgs eArgs)
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
		private DataDynamics.ActiveReports.Label Label43 = null;
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
		private DataDynamics.ActiveReports.Label Label12 = null;
		private DataDynamics.ActiveReports.Label Label13 = null;
		private DataDynamics.ActiveReports.Label Label14 = null;
		private DataDynamics.ActiveReports.Line Line = null;
		private DataDynamics.ActiveReports.Line Line1 = null;
		private DataDynamics.ActiveReports.Line Line2 = null;
		private DataDynamics.ActiveReports.Line Line21 = null;
		private DataDynamics.ActiveReports.Line Line34 = null;
		private DataDynamics.ActiveReports.Line Line35 = null;
		private DataDynamics.ActiveReports.Line Line36 = null;
		private DataDynamics.ActiveReports.Line Line37 = null;
		private DataDynamics.ActiveReports.Line Line38 = null;
		private DataDynamics.ActiveReports.Line Line39 = null;
		private DataDynamics.ActiveReports.Line Line40 = null;
		private DataDynamics.ActiveReports.Line Line41 = null;
		private DataDynamics.ActiveReports.Line Line42 = null;
		private DataDynamics.ActiveReports.Line Line43 = null;
		private DataDynamics.ActiveReports.Line Line44 = null;
		private DataDynamics.ActiveReports.Line Line45 = null;
		private DataDynamics.ActiveReports.Line Line46 = null;
		private DataDynamics.ActiveReports.Line Line4 = null;
		private DataDynamics.ActiveReports.TextBox TextBox41 = null;
		private DataDynamics.ActiveReports.Detail Detail = null;
		private DataDynamics.ActiveReports.Line Line3 = null;
		private DataDynamics.ActiveReports.Line Line5 = null;
		private DataDynamics.ActiveReports.Line Line6 = null;
		private DataDynamics.ActiveReports.Line Line7 = null;
		private DataDynamics.ActiveReports.Line Line8 = null;
		private DataDynamics.ActiveReports.Line Line9 = null;
		private DataDynamics.ActiveReports.Line Line10 = null;
		private DataDynamics.ActiveReports.Line Line11 = null;
		private DataDynamics.ActiveReports.Line Line12 = null;
		private DataDynamics.ActiveReports.Line Line13 = null;
		private DataDynamics.ActiveReports.Line Line14 = null;
		private DataDynamics.ActiveReports.Line Line15 = null;
		private DataDynamics.ActiveReports.Line Line16 = null;
		private DataDynamics.ActiveReports.Line Line17 = null;
		private DataDynamics.ActiveReports.Line Line18 = null;
		private DataDynamics.ActiveReports.Line Line19 = null;
		private DataDynamics.ActiveReports.Line Line20 = null;
		private DataDynamics.ActiveReports.TextBox TextBox = null;
		private DataDynamics.ActiveReports.TextBox TextBox4 = null;
		private DataDynamics.ActiveReports.TextBox TextBox5 = null;
		private DataDynamics.ActiveReports.TextBox TextBox6 = null;
		private DataDynamics.ActiveReports.TextBox TextBox7 = null;
		private DataDynamics.ActiveReports.TextBox TextBox8 = null;
		private DataDynamics.ActiveReports.TextBox TextBox9 = null;
		private DataDynamics.ActiveReports.TextBox TextBox10 = null;
		private DataDynamics.ActiveReports.TextBox TextBox11 = null;
		private DataDynamics.ActiveReports.TextBox TextBox12 = null;
		private DataDynamics.ActiveReports.TextBox TextBox13 = null;
		private DataDynamics.ActiveReports.TextBox TextBox14 = null;
		private DataDynamics.ActiveReports.TextBox TextBox15 = null;
		private DataDynamics.ActiveReports.TextBox TextBox16 = null;
		private DataDynamics.ActiveReports.TextBox TextBox17 = null;
		private DataDynamics.ActiveReports.PageFooter PageFooter = null;
		private DataDynamics.ActiveReports.Label Label15 = null;
		private DataDynamics.ActiveReports.Label Label16 = null;
		private DataDynamics.ActiveReports.Label Label17 = null;
		private DataDynamics.ActiveReports.Line Line22 = null;
		private DataDynamics.ActiveReports.Line Line23 = null;
		private DataDynamics.ActiveReports.Line Line24 = null;
		private DataDynamics.ActiveReports.Line Line25 = null;
		private DataDynamics.ActiveReports.Line Line26 = null;
		private DataDynamics.ActiveReports.Line Line27 = null;
		private DataDynamics.ActiveReports.Line Line29 = null;
		private DataDynamics.ActiveReports.Line Line30 = null;
		private DataDynamics.ActiveReports.Line Line31 = null;
		private DataDynamics.ActiveReports.Line Line32 = null;
		private DataDynamics.ActiveReports.Line Line33 = null;
		private DataDynamics.ActiveReports.TextBox TextBox1 = null;
		private DataDynamics.ActiveReports.TextBox TextBox2 = null;
		private DataDynamics.ActiveReports.TextBox TextBox3 = null;
		private DataDynamics.ActiveReports.Line Line28 = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "RWAS.WinUI.Reports.arvReport5.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[0]));
			this.Label43 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[1]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[2]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[3]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[4]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[5]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[6]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[7]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[8]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[9]));
			this.Label9 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[10]));
			this.Label10 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[11]));
			this.Label11 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[12]));
			this.Label12 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[13]));
			this.Label13 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[14]));
			this.Label14 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[15]));
			this.Line = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[16]));
			this.Line1 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[17]));
			this.Line2 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[18]));
			this.Line21 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[19]));
			this.Line34 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[20]));
			this.Line35 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[21]));
			this.Line36 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[22]));
			this.Line37 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[23]));
			this.Line38 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[24]));
			this.Line39 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[25]));
			this.Line40 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[26]));
			this.Line41 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[27]));
			this.Line42 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[28]));
			this.Line43 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[29]));
			this.Line44 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[30]));
			this.Line45 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[31]));
			this.Line46 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[32]));
			this.Line4 = ((DataDynamics.ActiveReports.Line)(this.PageHeader.Controls[33]));
			this.TextBox41 = ((DataDynamics.ActiveReports.TextBox)(this.PageHeader.Controls[34]));
			this.Line3 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[0]));
			this.Line5 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[1]));
			this.Line6 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[2]));
			this.Line7 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[3]));
			this.Line8 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[4]));
			this.Line9 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[5]));
			this.Line10 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[6]));
			this.Line11 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[7]));
			this.Line12 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[8]));
			this.Line13 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[9]));
			this.Line14 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[10]));
			this.Line15 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[11]));
			this.Line16 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[12]));
			this.Line17 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[13]));
			this.Line18 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[14]));
			this.Line19 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[15]));
			this.Line20 = ((DataDynamics.ActiveReports.Line)(this.Detail.Controls[16]));
			this.TextBox = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[17]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[18]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[19]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[20]));
			this.TextBox7 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[21]));
			this.TextBox8 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[22]));
			this.TextBox9 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[23]));
			this.TextBox10 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[24]));
			this.TextBox11 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[25]));
			this.TextBox12 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[26]));
			this.TextBox13 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[27]));
			this.TextBox14 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[28]));
			this.TextBox15 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[29]));
			this.TextBox16 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[30]));
			this.TextBox17 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[31]));
			this.Label15 = ((DataDynamics.ActiveReports.Label)(this.PageFooter.Controls[0]));
			this.Label16 = ((DataDynamics.ActiveReports.Label)(this.PageFooter.Controls[1]));
			this.Label17 = ((DataDynamics.ActiveReports.Label)(this.PageFooter.Controls[2]));
			this.Line22 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[3]));
			this.Line23 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[4]));
			this.Line24 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[5]));
			this.Line25 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[6]));
			this.Line26 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[7]));
			this.Line27 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[8]));
			this.Line29 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[9]));
			this.Line30 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[10]));
			this.Line31 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[11]));
			this.Line32 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[12]));
			this.Line33 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[13]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.PageFooter.Controls[14]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.PageFooter.Controls[15]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.PageFooter.Controls[16]));
			this.Line28 = ((DataDynamics.ActiveReports.Line)(this.PageFooter.Controls[17]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.arvReport5_DataInitialize);
		}

		#endregion
	}
}
