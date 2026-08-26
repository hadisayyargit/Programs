/*********************************************************************;
 *  File Name : clsBRChastiseReason
 *  class Name : clsBRChastiseReason
 *  namespace  : RWAS
 *  Codding By : N.Nouri
 *  Date       : 2/11/2008
 *  Description: 
* /*********************************************************************/

using System;
using System.Data;
using RWAS.Common;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
	/// <summary>
	/// </summary>
	public class clsBRChastiseReason
	{
		public clsBRChastiseReason()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		//*********************************************************************
		// Method Name : GetChastiseReason
		// Called By : ChastiseReasonForm
		// Date       : 9/7/2002
		/// <summary>
		/// </summary>
		/// <returns>clsDSChastiseReason</returns>
		/// //*********************************************************************
		public clsDSChastiseReason GetChastiseReason() 
		{
			clsDSChastiseReason  objDSChastiseReason;
			clsDAChastiseReason  objDAChastiseReason = new clsDAChastiseReason();

			try 
			{
				objDSChastiseReason = objDAChastiseReason.LoadChastiseReason();

				return objDSChastiseReason;
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
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="objDSChastiseReason"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool Update( clsDSChastiseReason objDSChastiseReason) 
		{
			bool binResult;

			try 
			{
				clsDAChastiseReason objDAChastiseReason = new clsDAChastiseReason();
				binResult=objDAChastiseReason.UpdateChastiseReason(objDSChastiseReason);

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
		// Method Name : ChastiseReasonIsConfirm
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSChastiseReason"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool ChastiseReasonIsConfirm(int intCode ,clsDSChastiseReason objDSChastiseReason) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSChastiseReason.Rws_Sp_Sel_All_ChastiseReason.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSChastiseReason.Rws_Fld_IsConfirm]== true)
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
		// Method Name : ChastiseReasonIsUsed
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSChastiseReason"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool ChastiseReasonIsUsed(int intCode ,clsDSChastiseReason objDSChastiseReason) 
		{
			DataRow[] drowSelect;

			try 
			{

				drowSelect=objDSChastiseReason.Rws_Sp_Sel_All_ChastiseReason.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSChastiseReason.Rws_Fld_IsUsed]== true)
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
		// Method Name : ChastiseReasonIsExistForAdd
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="strChastiseReasonDes"></param>
		/// <param name="intChastiseReasonCode"></param>
		/// <param name="objDSChastiseReason"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool ChastiseReasonIsExistForAdd(string strChastiseReasonDes ,clsDSChastiseReason objDSChastiseReason) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSChastiseReason.Rws_Sp_Sel_All_ChastiseReason.Select("Rws_Fld_Describe='" + strChastiseReasonDes.ToString() + "'");

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
		// Method Name : ChastiseReasonIsExistForUpdate
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="strChastiseReasonDes"></param>
		/// <param name="intChastiseReasonCode"></param>
		/// <param name="objDSChastiseReason"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool ChastiseReasonIsExistForUpdate(int intCode,string strChastiseReasonDes ,clsDSChastiseReason objDSChastiseReason) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSChastiseReason.Rws_Sp_Sel_All_ChastiseReason.Select("Rws_Fld_Describe='" + strChastiseReasonDes.ToString() + "'");

				if (drowSelect.Length !=0 && (int)drowSelect[0]["Rws_Fld_Code"]!= intCode)
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