using System;
using System.Data;
using RWAS.DataAccess;
using RWAS.Common;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// Summary description for clsDSReportHandler.
	/// </summary>
	public class clsBRComboHandler
	{
		#region Data Sets
		private clsDSHealthKind objDSHealthKind;
		private DS_AccidentEffective ocDS_AccidentEffective;
		private DS_Region ocDS_Region;
		private DS_RailWayVehicleKind ocDS_RailWayVehicleKind;
		private DS_Station ocDS_Station;
		private DS_SurveyItem ocDS_SurveyItem;
		private DS_SurveyMajorItem ocDS_SurveyMajorItem;
		private DS_SurveyResult ocDS_SurveyResult;
		private DS_EmployeeStatus ocDS_EmployeeStatus;
		private DS_Job ocDS_Job;
		private DS_OrgUnit ocDS_OrgUnit;
		private DS_StudyStatus ocDS_StudyStatus;
		private DS_ForfeitKind ocDS_ForfeitKind;
		private DS_AccidentCategory ocDS_AccidentCategory;

		#endregion Data Sets

		private clsDACombo objDACombo;

		// Constructors
		public clsBRComboHandler() 
		{
			objDACombo = new clsDACombo();
		}

		#region AccidentEffective
		//*********************************************************************
		/// <summary>
		/// Method Name : getAccidentEffective
		/// Called By : 
		/// Date       : 12/01/2006
		/// </summary>
		/// <returns>DS_AccidentEffective</returns>
		/// *********************************************************************
		public DS_AccidentEffective getAccidentEffective()
		{
			try 
			{
				ocDS_AccidentEffective = objDACombo.QueryAccidentEffective();

				return ocDS_AccidentEffective;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion AccidentEffective

		#region Region
		//*********************************************************************
		/// <summary>
		/// Method Name : getRegion
		/// Called By : 
		/// Date       : 12/01/2006
		/// </summary>
		/// <returns>DS_Region</returns>
		/// *********************************************************************
		public DS_Region getRegion()
		{
			try 
			{
				ocDS_Region = objDACombo.QueryRegion();

				return ocDS_Region;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion Region

		#region RailWayVehicleKind
		//*********************************************************************
		/// <summary>
		/// Method Name : getRailWayVehicleKind
		/// Called By : 
		/// Date       : 12/01/2006
		/// </summary>
		/// <returns>DS_RailWayVehicleKind</returns>
		/// *********************************************************************
		public DS_RailWayVehicleKind getRailWayVehicleKind()
		{
			try 
			{
				ocDS_RailWayVehicleKind = objDACombo.QueryRailWayVehicleKind();

				return ocDS_RailWayVehicleKind;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion RailWayVehicleKind

		#region Station
		//*********************************************************************
		/// <summary>
		/// Method Name : getStation
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_Station</returns>
		/// *********************************************************************
		public DS_Station getStation()
		{
			try 
			{
				ocDS_Station = objDACombo.QueryStation();

				return ocDS_Station;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion Station

		#region SurveyMajorItem
		//*********************************************************************
		/// <summary>
		/// Method Name : getSurveyMajorItem
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_SurveyMajorItem</returns>
		/// *********************************************************************
		public DS_SurveyMajorItem getSurveyMajorItem()
		{
			try 
			{
				ocDS_SurveyMajorItem = objDACombo.QuerySurveyMajorItem();

				return ocDS_SurveyMajorItem;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion SurveyMajorItem

		#region SurveyItem
		//*********************************************************************
		/// <summary>
		/// Method Name : getSurveyItem
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_SurveyItem</returns>
		/// *********************************************************************
		public DS_SurveyItem getSurveyItem()
		{
			try 
			{
				ocDS_SurveyItem = objDACombo.QuerySurveyItem();

				return ocDS_SurveyItem;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion SurveyItem

		#region SurveyResult
		//*********************************************************************
		/// <summary>
		/// Method Name : getSurveyResult
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_SurveyResult</returns>
		/// *********************************************************************
		public DS_SurveyResult getSurveyResult()
		{
			try 
			{
				ocDS_SurveyResult = objDACombo.QuerySurveyResult();

				return ocDS_SurveyResult;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion SurveyResult

		#region Job
		//*********************************************************************
		/// <summary>
		/// Method Name : getJob
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_Job</returns>
		/// *********************************************************************
		public DS_Job getJob()
		{
			try 
			{
				ocDS_Job = objDACombo.QueryJob();

				return ocDS_Job;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion Job

		public DataTable SearchJobByText(string strSearch)
		{
			try 
			{
				clsDACombo objDACombo = new clsDACombo();
				DataTable dtResult = objDACombo.QuerySearchJobByText(strSearch);

				return dtResult;
			} 
			catch (Exception ocException) 
			{
				throw new Exception(ocException.Message, ocException);
			}
		}


		#region OrgUnit
		//*********************************************************************
		/// <summary>
		/// Method Name : getOrgUnit
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_OrgUnit</returns>
		/// *********************************************************************
		public DS_OrgUnit getOrgUnit()
		{
			try 
			{
				ocDS_OrgUnit = objDACombo.QueryOrgUnit();

				return ocDS_OrgUnit;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion OrgUnit

		public DataTable SearchOrgUnitByText(string strSearch)
		{
			try 
			{
				clsDACombo objDACombo = new clsDACombo();
				DataTable dtResult = objDACombo.QuerySearchOrgUnitByText(strSearch);

				return dtResult;
			} 
			catch (Exception ocException) 
			{
				throw new Exception(ocException.Message, ocException);
			}
		}

		#region StudyStatus
		//*********************************************************************
		/// <summary>
		/// Method Name : getStudyStatus
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_StudyStatus</returns>
		/// *********************************************************************
		public DS_StudyStatus getStudyStatus()
		{
			try 
			{
				ocDS_StudyStatus = objDACombo.QueryStudyStatus();

				return ocDS_StudyStatus;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion StudyStatus

		public DataTable SearchStudyStatusByText(string strSearch)
		{
			try 
			{
				clsDACombo objDACombo = new clsDACombo();
				DataTable dtResult = objDACombo.QuerySearchStudyStatusByText(strSearch);

				return dtResult;
			} 
			catch (Exception ocException) 
			{
				throw new Exception(ocException.Message, ocException);
			}
		}

		#region EmployeeStatus
		//*********************************************************************
		/// <summary>
		/// Method Name : getEmployeeStatus
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_EmployeeStatus</returns>
		/// *********************************************************************
		public DS_EmployeeStatus getEmployeeStatus()
		{
			try 
			{
				ocDS_EmployeeStatus = objDACombo.QueryEmployeeStatus();

				return ocDS_EmployeeStatus;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion EmployeeStatus

		#region ForfeitKind
		//*********************************************************************
		/// <summary>
		/// Method Name : getForfeitKind
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_ForfeitKind</returns>
		/// *********************************************************************
		public DS_ForfeitKind getForfeitKind()
		{
			try 
			{
				ocDS_ForfeitKind = objDACombo.QueryForfeitKind();

				return ocDS_ForfeitKind;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion ForfeitKind

		#region ForfeitKind
		//*********************************************************************
		/// <summary>
		/// Method Name : getHealthKind
		/// Called By : 
		/// Date       : 2/8/2008
		/// </summary>
		/// <returns>clsDSHealthKind</returns>
		/// *********************************************************************
		public clsDSHealthKind getHealthKind()
		{
			try 
			{
				objDSHealthKind = objDACombo.QueryHealthKind();

				return objDSHealthKind;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion ForfeitKind

		#region AccidentCategory
		//*********************************************************************
		/// <summary>
		/// Method Name : getAccidentCategory
		/// Called By : 
		/// Date       : 2/9/2007
		/// </summary>
		/// <returns>DS_AccidentCategory</returns>
		/// *********************************************************************
		public DS_AccidentCategory getAccidentCategory()
		{
			try 
			{
				ocDS_AccidentCategory = objDACombo.QueryAccidentCategory();

				return ocDS_AccidentCategory;
			}
			catch( Exception ocException)
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
		#endregion AccidentCategory
	}
}