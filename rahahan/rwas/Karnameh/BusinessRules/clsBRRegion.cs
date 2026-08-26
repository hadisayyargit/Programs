/*********************************************************************;
 *  File Name : clsBRRegion
 *  class Name : clsBRRegion
 *  namespace  : RWAS
 *  Codding By : H.Ziabakhsh
 *  Date       : 4/10/2006;
 *  Description: 
* /*********************************************************************/

using System;
using System.Data;
using RWAS.Common;
using RWAS.DataAccess ;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// </summary>
	public class clsBRRegion
	{
		public clsBRRegion()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		//*********************************************************************
		// Method Name : GetRegion
		// Called By : RegionForm
		// Date       : 9/7/2002
		/// <summary>
		/// </summary>
		/// <returns>clsDSRegion</returns>
		/// //*********************************************************************
		public clsDSRegion GetRegion() 
		{
			clsDSRegion  objDSRegion;
			clsDARegion  objDARegion = new clsDARegion();

			try 
			{
				objDSRegion = objDARegion.LoadRegion();

				return objDSRegion;
			} 
			catch (Exception ocException) 
			{
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name : Update
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="objDSRegion"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool Update( clsDSRegion objDSRegion) 
		{
			bool binResult;

			try 
			{
				clsDARegion objDARegion = new clsDARegion();
				binResult=objDARegion.UpdateRegion(objDSRegion);

				return binResult;
			} 
			catch (Exception ocException) 
			{
//				throw new Exception(ocException.Message, ocException);
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name : RegionIsConfirm
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSRegion"></param>
		/// <returns>bool</returns>
		//**********************************************************************

		//*********************************************************************
		// Method Name : RegionIsUsed
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSRegion"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool RegionIsUsed(int intCode ,clsDSRegion objDSRegion) 
		{
			DataRow[] drowSelect;

			try 
			{

				drowSelect=objDSRegion.Rws_Sp_Sel_All_Region2.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSRegion.Rws_Fld_IsUsed]== true)
					return true;
				else
					return false;
			} 
			catch (Exception ocException) 
			{
//				throw new Exception(ocException.Message, ocException);
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name : RegionIsExistForAdd
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="strRegionDes"></param>
		/// <param name="intRegionCode"></param>
		/// <param name="objDSRegion"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool RegionIsExistForAdd(string strRegionDes ,clsDSRegion objDSRegion) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSRegion.Rws_Sp_Sel_All_Region2.Select("Rws_Fld_Describe='" + strRegionDes.ToString() + "'");

				if (drowSelect.Length !=0)
					return true;
				else
					return false;
			} 
			catch (Exception ocException) 
			{
//				throw new Exception(ocException.Message, ocException);
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name : RegionIsExistForUpdate
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="strRegionDes"></param>
		/// <param name="intRegionCode"></param>
		/// <param name="objDSRegion"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool RegionIsExistForUpdate(int intCode,string strRegionDes ,clsDSRegion objDSRegion) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSRegion.Rws_Sp_Sel_All_Region2.Select("Rws_Fld_Describe='" + strRegionDes.ToString() + "'");

				if (drowSelect.Length !=0 && (short)drowSelect[0]["Rws_Fld_Code"]!= intCode)
					return true;
				else
					return false;
			} 
			catch (Exception ocException) 
			{
//				throw new Exception(ocException.Message, ocException);
				if (ocException is System.Data.SqlClient.SqlException)
					throw (System.Data.SqlClient.SqlException) ocException;
				else
					throw ocException;
			}
		}
	}
}