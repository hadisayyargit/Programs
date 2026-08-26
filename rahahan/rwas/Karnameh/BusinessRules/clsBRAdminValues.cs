using System;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// Summary description for clsDSAdminValues.
	/// </summary>
	public class clsBRAdminValues
	{
		private static string strPersianDate;

		public clsBRAdminValues()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public string PersianDate 
		{
			get 
			{
				if (strPersianDate == "" || strPersianDate == null)
				{
					Dates objDates=new DataAccess.Dates();

					return strPersianDate = objDates.GetDate();
				}
				else
					return strPersianDate;
			}
		}

		private static string strVersion;

		public string Version
		{
			get 
			{
				if (strVersion == "" || strVersion == null)
				{
					Utility objUtility=new DataAccess.Utility();

					return strVersion = objUtility.GetVersion();
				}
				else
					return strVersion;
			}
		}
	}
}
