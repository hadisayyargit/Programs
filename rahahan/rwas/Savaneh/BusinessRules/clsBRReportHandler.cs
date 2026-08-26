using System;
using System.Data;
using RWAS.DataAccess;
using RWAS.Common;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// Summary description for clsDSReportHandler.
	/// </summary>
	public class clsBRReportHandler
	{
		#region Data Sets

		private DS_Rep_AbRailWayAccident ocDS_Rep_AbRailWayAccident;
		private DS_Rep_AccidentCount ocDS_Rep_AccidentCount;
		private DS_Rep_AccidentDegree ocDS_Rep_AccidentDegree;
		private DS_Rep_AccidentOnLoc ocDS_Rep_AccidentOnLoc;
		private DS_Rep_AccidentOnRailway ocDS_Rep_AccidentOnRailway;
		private DS_Rep_AccidentCountOnBlockKind ocDS_Rep_AccidentCountOnBlockKind;
		private DS_Rep_AccidentOnCategoryKindType ocDS_Rep_AccidentOnCategoryKindType;
		private DS_Rep_DieAndAfoul ocDS_Rep_DieAndAfoul;
		private DS_Rep_AccidentDieAndAfoul ocDS_Rep_AccidentDieAndAfoul;
		private DS_Rep_RailWayAccident ocDS_Rep_RailWayAccident;
		private DS_Rep_AccidentReason ocDS_Rep_AccidentReason;

		private DS_Rep_Collision ocDS_Rep_Collision;
		private DS_Rep_ExitRailWayCount ocDS_Rep_ExitRailWayCount;
		private DS_Rep_FireRailWay ocDS_Rep_FireRailWay;
		private DS_Rep_ScapeRailWay ocDS_Rep_ScapeRailWay;
		private DS_Rep_Loss ocDS_Rep_Loss;

		private DS_Rep_Survey ocDS_Rep_Survey;
		private DS_Rep_SurveyMonthy ocDS_Rep_SurveyMonthy;

		private DS_Rep_Personel ocDS_Rep_Personel;
		//private DS_Rep_Personel_WorkBook ocDS_Rep_Personel_WorkBook;
		private DS_Rep_Operation ocDS_Rep_Operation;
		private DS_Rep_PersonelAccident ocDS_Rep_PersonelAccident;
		private DS_Rep_Chastise ocDS_Rep_Chastise;
		private DS_Rep_BodilyMentalStatus ocDS_Rep_BodilyMentalStatus;
		private DS_Rep_Eulogy ocDS_Rep_Eulogy;
		private DS_Rep_Score ocDS_Rep_Score;
		private DS_Rep_PersonelTraining ocDS_Rep_PersonelTraining;
		private DS_Rep_PrefermentHistory ocDS_Rep_PrefermentHistory;
		private DS_Rep_SumScore ocDS_Rep_SumScore;
		private DS_Rep_Bogy ocDS_Rep_Bogy;
		#endregion Data Sets

		private clsDAReport objDAReport;

		// Constructors
		public clsBRReportHandler() 
		{
			objDAReport = new clsDAReport();
		}

		#region Rep_AbRailWayAccident
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchData
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AbRailWayAccident</returns>
		/// *********************************************************************
		public DS_Rep_AbRailWayAccident SearchData(
			int intRepID,
			string strFromYear,
			string strToYear, short shrRegion)
		{
			if ( intRepID == (int)enumRepKind.Rep_AbRailWayAccident)
			{
				try 
				{
					ocDS_Rep_AbRailWayAccident = objDAReport.QueryAbRailWayAccident(strFromYear,strToYear, shrRegion);

					return ocDS_Rep_AbRailWayAccident;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AbRailWayAccident

		#region Rep_AccidentCount
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchData
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AbRailWayAccident</returns>
		/// *********************************************************************
		public DS_Rep_AccidentCount SearchData(
			int intRepID,
			string strFromYear,
			string strToYear,
			int intCategoryNo,
			short shrAccidentType,
			short shrAccidentKind,
			short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_AccidentCountOnCType
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnCTypeKind
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnCTypeKindRegion
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnCTypeRegion
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnType
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnTypeKind
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnTypeKindRegion
				|| intRepID == (int)enumRepKind.Rep_AccidentCountOnTypeRegion
				)
			{
				try 
				{
					ocDS_Rep_AccidentCount = objDAReport.QueryAccidentCount(strFromYear, strToYear, intCategoryNo, shrAccidentType, shrAccidentKind, shrRegion);

					return ocDS_Rep_AccidentCount;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentCount

		#region Rep_AccidentDegree
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchData
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AbRailWayAccident</returns>
		/// *********************************************************************
		public DS_Rep_AccidentDegree SearchData(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrAccidentType,
			bool blnComparePercent, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_AccidentDegree)
			{
				try 
				{
					ocDS_Rep_AccidentDegree = objDAReport.QueryAccidentDegree(strFromYear, strToYear, shrAccidentType, blnComparePercent, shrRegion);

					return ocDS_Rep_AccidentDegree;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentDegree

		#region Rep_AccidentOnLoc
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchData
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AccidentOnLoc</returns>
		/// *********************************************************************
		public DS_Rep_AccidentOnLoc SearchData(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrAccidentKind, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_AccidentOnCKindLoc || intRepID == (int)enumRepKind.Rep_AccidentOnKindLoc)
			{
				try 
				{
					ocDS_Rep_AccidentOnLoc = objDAReport.QueryAccidentOnLoc(strFromYear, strToYear, shrAccidentKind, shrRegion);

					return ocDS_Rep_AccidentOnLoc;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentOnLoc

		#region Rep_AccidentOnRailway
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataAccidentOnRailway
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AccidentOnRailway</returns>
		/// *********************************************************************
		public DS_Rep_AccidentOnRailway SearchDataAccidentOnRailway(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrAccidentKind, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_AccidentOnCKindRailWay || intRepID == (int)enumRepKind.Rep_AccidentOnKindRailWay)
			{
				try 
				{
					ocDS_Rep_AccidentOnRailway = objDAReport.QueryAccidentOnRailway(strFromYear, strToYear, shrAccidentKind, shrRegion);

					return ocDS_Rep_AccidentOnRailway;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentOnRailway

		#region Rep_AccidentCountOnBlockKind
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataAccidentCountOnBlockKind
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrAccidentKind"></param>
		/// <param name="blnIsAccidentOnBlock"></param>
		/// <param name="intCategoryNo"></param>
		/// <param name="intFromCount"></param>
		/// <param name="intToCount"></param>
		/// <returns>DS_Rep_AccidentCountOnBlockKind</returns>
		/// *********************************************************************
		public DS_Rep_AccidentCountOnBlockKind SearchDataAccidentCountOnBlockKind(
			int intRepID,
			string strFromYear,
			string strToYear,
			bool blnIsAccidentOnBlock,
			int intCategoryNo,
			int intFromCount,
			int intToCount, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_AccidentOnBlock || intRepID == (int)enumRepKind.Rep_AccidentOnStation || intRepID == (int)enumRepKind.Rep_AccidentOnBlockKind)
			{
				try 
				{
					ocDS_Rep_AccidentCountOnBlockKind = objDAReport.QueryAccidentCountOnBlockKind(strFromYear, strToYear, blnIsAccidentOnBlock, intCategoryNo, intFromCount, intToCount, shrRegion);

					return ocDS_Rep_AccidentCountOnBlockKind;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentCountOnBlockKind

		#region Rep_AccidentOnCategoryKindType
		//*********************************************************************
		/// <summary>
		/// Method Name : Rep_AccidentOnCategoryKindType
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AbRailWayAccident</returns>
		/// *********************************************************************
		public DS_Rep_AccidentOnCategoryKindType SearchDataAccidentOnCategoryKindType(
			int intRepID,
			string strFromYear,
			string strToYear,
			int intCategoryNo,
			short shrAccidentKind,
			short shrAccidentType,
			short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_AccidentOnCategoryKindType)
			{
				try 
				{
					ocDS_Rep_AccidentOnCategoryKindType = objDAReport.QueryAccidentOnCategoryKindType(strFromYear, strToYear, intCategoryNo, shrAccidentKind, shrAccidentType, shrRegion);

					return ocDS_Rep_AccidentOnCategoryKindType;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentCount

		#region DS_Rep_DieAndAfoul
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataDieAndAfoul
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrAccidentType"></param>
		/// <param name="shrAccidentKind"></param>
		/// <returns>DS_Rep_DieAndAfoul</returns>
		/// *********************************************************************
		public DS_Rep_DieAndAfoul SearchDataDieAndAfoul(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrAccidentType,
			short shrAccidentKind, short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_DieAndAfoulOnCType
				|| intRepID == (int)enumRepKind.Rep_DieAndAfoulOnCTypeKind
				|| intRepID == (int)enumRepKind.Rep_DieAndAfoulOnType
				|| intRepID == (int)enumRepKind.Rep_DieAndAfoulOnTypeKind
				)
			{
				try 
				{
					ocDS_Rep_DieAndAfoul = objDAReport.QueryDieAndAfoul(strFromYear, strToYear, shrAccidentType, shrAccidentKind, shrRegion);

					return ocDS_Rep_DieAndAfoul;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_DieAndAfoul

		#region DS_Rep_AccidentDieAndAfoul
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataAccidentDieAndAfoul
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_AccidentDieAndAfoul</returns>
		/// *********************************************************************
		public DS_Rep_AccidentDieAndAfoul SearchDataAccidentDieAndAfoul(
			int intRepID,
			string strFromYear,
			string strToYear, short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_DieAndAfoul)
			{
				try 
				{
					ocDS_Rep_AccidentDieAndAfoul = objDAReport.QueryAccidentDieAndAfoul(strFromYear, strToYear, shrRegion);

					return ocDS_Rep_AccidentDieAndAfoul;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentDieAndAfoul

		#region DS_Rep_RailWayAccident
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataRailWayAccident
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_RailWayAccident</returns>
		/// *********************************************************************
		public DS_Rep_RailWayAccident SearchDataRailWayAccident(
			int intRepID,
			string strFromYear,
			string strToYear, short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_RailWayAccident)
			{
				try 
				{
					ocDS_Rep_RailWayAccident = objDAReport.QueryRailWayAccident(strFromYear, strToYear, shrRegion);

					return ocDS_Rep_RailWayAccident;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_RailWayAccident

		#region DS_Rep_AccidentReason
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataAccidentReason
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrEffective"></param>
		/// <param name="shrRegion"></param>
		/// <param name="blnIsSecond"></param>
		/// <returns>DS_Rep_AccidentReason</returns>
		/// *********************************************************************
		public DS_Rep_AccidentReason SearchDataAccidentReason(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrEffective,
			short shrRegion,
			bool blnIsSecond
			)
		{
			if (   intRepID == (int)enumRepKind.Rep_AccidentReason
				|| intRepID == (int)enumRepKind.Rep_AccidentReasonOnRegion)
			{
				try 
				{
					ocDS_Rep_AccidentReason = objDAReport.QueryAccidentReason(strFromYear, strToYear, shrEffective, shrRegion, blnIsSecond);

					return ocDS_Rep_AccidentReason;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentReason

		#region DS_Rep_Collision
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataCollision
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrAccidentKind"></param>
		/// <param name="shrCollisionState"></param>
		/// <param name="shrCollisionKind"></param>
		/// <returns>DS_Rep_Collision</returns>
		/// *********************************************************************
		public DS_Rep_Collision SearchDataCollision(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrAccidentKind,
			short shrCollisionState,
			short shrCollisionKind, short shrRegion
			)
		{
			if (   intRepID == (int)enumRepKind.Rep_CollisionWith)
			{
				try 
				{
					ocDS_Rep_Collision = objDAReport.QueryCollision(strFromYear, strToYear, shrAccidentKind, shrCollisionState, shrCollisionKind, shrRegion);

					return ocDS_Rep_Collision;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_Collision

		#region DS_Rep_ExitRailWayCount
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataExitRailWayCount
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_ExitRailWayCount</returns>
		/// *********************************************************************
		public DS_Rep_ExitRailWayCount SearchDataExitRailWayCount(
			int intRepID,
			string strFromYear,
			string strToYear, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_ExitRailWayCount)
			{
				try 
				{
					ocDS_Rep_ExitRailWayCount = objDAReport.QueryExitRailWayCount(strFromYear, strToYear, shrRegion);

					return ocDS_Rep_ExitRailWayCount;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_ExitRailWayCount

		#region DS_Rep_FireRailWay
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataFireRailWay
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrFireKind"></param>
		/// <returns>DS_Rep_FireRailWay</returns>
		/// *********************************************************************
		public DS_Rep_FireRailWay SearchDataFireRailWay(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrFireKind, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_FireRailWayKind)
			{
				try 
				{
					ocDS_Rep_FireRailWay = objDAReport.QueryFireRailWay(strFromYear, strToYear, shrFireKind, shrRegion);

					return ocDS_Rep_FireRailWay;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_FireRailWay

		#region DS_Rep_ScapeRailWay
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataScapeRailWay
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrScapeKind"></param>
		/// <returns>DS_Rep_ScapeRailWay</returns>
		/// *********************************************************************
		public DS_Rep_ScapeRailWay SearchDataScapeRailWay(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrScapeKind, short shrRegion
			)
		{
			if (intRepID == (int)enumRepKind.Rep_ScapeRailWayKind)
			{
				try 
				{
					ocDS_Rep_ScapeRailWay = objDAReport.QueryScapeRailWay(strFromYear, strToYear, shrScapeKind, shrRegion);

					return ocDS_Rep_ScapeRailWay;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_ScapeRailWay

		#region DS_Rep_Loss
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataLoss
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <param name="shrRegion"></param>
		/// <param name="blnByYear"></param>
		/// <returns>DS_Rep_Loss</returns>
		/// *********************************************************************
		public DS_Rep_Loss SearchDataLoss(
			int intRepID,
			string strFromYear,
			string strToYear,
			short shrRegion,
			bool blnByYear
			)
		{
			if (   intRepID == (int)enumRepKind.Rep_Loss
				|| intRepID == (int)enumRepKind.Rep_LossOnRegion
				|| intRepID == (int)enumRepKind.Rep_LossOnYear
				|| intRepID == (int)enumRepKind.Rep_LossOnYearRegion
				|| intRepID == (int)enumRepKind.Rep_LossPercent
				|| intRepID == (int)enumRepKind.Rep_LossPercentOnRegion
				|| intRepID == (int)enumRepKind.Rep_LossPercentOnYear
				|| intRepID == (int)enumRepKind.Rep_LossPercentOnYearRegion)
			{
				try 
				{
					ocDS_Rep_Loss = objDAReport.QueryLoss(strFromYear, strToYear, shrRegion, blnByYear);

					return ocDS_Rep_Loss;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_Loss



		#region DS_Rep_PersonelAccident
		//*********************************************************************
		/// <summary>
		/// Method Name : SearchDataPersonelAccident
		/// Called By : FrmActiveReport
		/// Date       : 10/2/2007
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="intUniqueCode"></param>
		/// <returns></returns>
		/// *********************************************************************
		public DS_Rep_PersonelAccident SearchDataPersonelAccident(
			int intRepID,
			byte bytRegion,
			int intUniqueCode,
			string strFromEmployeeDate,
			string strToEmployeeDate,
			int intSubContractor,
			int intEmployeeStatus,
			int intStudyStatus,
			int intOrgUnit,
			string strJob
			)
		{
			if (intRepID == (int)enumRepKind.Rep_WorkBook)
			{
				try 
				{
					ocDS_Rep_PersonelAccident = objDAReport.QueryPersonelAccident(bytRegion, intUniqueCode, strFromEmployeeDate, strToEmployeeDate, intSubContractor, intEmployeeStatus, intStudyStatus, intOrgUnit, strJob);

					return ocDS_Rep_PersonelAccident;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_PersonelAccident


		#region Rep_AccidentOnCategoryKindType
		//*********************************************************************
		/// <summary>
		/// Method Name : Rep_Bogy
		/// Called By : FrmActiveReport
		/// Date       : 11/12/2006
		/// </summary>
		/// <param name="intRepID"></param>
		/// <param name="strFromYear"></param>
		/// <param name="strToYear"></param>
		/// <returns>DS_Rep_Bogy</returns>
		/// *********************************************************************
		public DS_Rep_Bogy SearchDataBogy(
			int intRepID,
			string strFromDate,
			string strToDate,
			int intCategoryNo,
			short shrAccidentKind,
			short shrAccidentType,
			short shrRegion
			)
		{
			if (  intRepID == (int)enumRepKind.Rep_Bogy)
			{
				try 
				{
					ocDS_Rep_Bogy = objDAReport.QueryBogy(strFromDate, strToDate, intCategoryNo, shrAccidentKind, shrAccidentType, shrRegion);

					return ocDS_Rep_Bogy;
				}
				catch( Exception ocException)
				{
					if (ocException is System.Data.SqlClient.SqlException)
						throw (System.Data.SqlClient.SqlException) ocException;
					else
						throw ocException;
				}
			}
			else
				throw new ArgumentException("„ﬁœ«— Ê«—œ ‘œÂ Œ«—Ã «“ „ÕœÊœÂ ê“«—‘«  «” ");
		}
		#endregion Rep_AccidentCount
	}
}