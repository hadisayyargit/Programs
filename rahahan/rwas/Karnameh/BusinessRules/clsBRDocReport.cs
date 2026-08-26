using System;
using System.Data;
using RWAS.DataAccess;
using RWAS.Common;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// Summary description for clsDSReportHandler.
	/// </summary>
	public class clsBRDocReport
	{
		#region Data Sets
		private DS_Report1 ocDS_Report1;
		private DS_Report2 ocDS_Report2;
		private DS_Report3 ocDS_Report3;
		#endregion Data Sets

		private clsDAReport objDAReport;

		// Constructors
		public clsBRDocReport() 
		{
			objDAReport = new clsDAReport();
		}

		#region Report1
		/// *********************************************************************
		/// <summary>
		/// Method Name : Rep_Bogy
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intPKEarlyAccident"></param>
		/// <returns></returns>
		/// *********************************************************************
		public DataSet SearchReport(int intPKEarlyAccident, ReportID reportID)
		{
			clsDADocReport objDADocReport = new clsDADocReport();
			return objDADocReport.QueryReport(intPKEarlyAccident, reportID);
		}
		#endregion Report1
	}
}