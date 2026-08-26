/*********************************************************************;
 *  File Name : clsBRAccidentDegree
 *  class Name : clsBRAccidentDegree
 *  namespace  : RWAS
 *  Codding By : H.Ziabakhsh
 *  Date       : 4/10/2006;
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
	public class clsBRAccidentDegree
	{
		public clsBRAccidentDegree()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		//*********************************************************************
		// Method Name : GetAccidentDegree
		// Called By : AccidentDegreeForm
		// Date       : 9/7/2002
		/// <summary>
		/// </summary>
		/// <returns>clsDSAccidentDegree</returns>
		/// //*********************************************************************
		public clsDSAccidentDegree GetAccidentDegree() 
		{
			clsDSAccidentDegree  objDSAccidentDegree;
			clsDAAccidentDegree  objDAAccidentDegree = new clsDAAccidentDegree();

			try 
			{
				objDSAccidentDegree = objDAAccidentDegree.LoadAccidentDegree();

				return objDSAccidentDegree;
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
		/// <param name="objDSAccidentDegree"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool Update( clsDSAccidentDegree objDSAccidentDegree) 
		{
			bool binResult;

			try 
			{
				clsDAAccidentDegree objDAAccidentDegree = new clsDAAccidentDegree();
				binResult=objDAAccidentDegree.UpdateAccidentDegree(objDSAccidentDegree);

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
		// Method Name : AccidentDegreeIsConfirm
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSAccidentDegree"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool AccidentDegreeIsConfirm(int intCode ,clsDSAccidentDegree objDSAccidentDegree) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSAccidentDegree.Rws_Fld_IsConfirm]== true)
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
		// Method Name : AccidentDegreeIsUsed
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSAccidentDegree"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool AccidentDegreeIsUsed(int intCode ,clsDSAccidentDegree objDSAccidentDegree) 
		{
			DataRow[] drowSelect;

			try 
			{

				drowSelect=objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSAccidentDegree.Rws_Fld_IsUsed]== true)
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
		// Method Name : AccidentDegreeIsExistForAdd
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="strAccidentDegreeDes"></param>
		/// <param name="intRegionCode"></param>
		/// <param name="objDSAccidentDegree"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool AccidentDegreeIsExistForAdd(string strAccidentDegreeDes ,clsDSAccidentDegree objDSAccidentDegree) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.Select("Rws_Fld_Describe='" + strAccidentDegreeDes.ToString() + "'");

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
		// Method Name : AccidentDegreeIsExistForUpdate
		// Called By : 
		// Date       : 09/25/2006
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="strAccidentDegreeDes"></param>
		/// <param name="intRegionCode"></param>
		/// <param name="objDSAccidentDegree"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool AccidentDegreeIsExistForUpdate(int intCode,string strAccidentDegreeDes ,clsDSAccidentDegree objDSAccidentDegree) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.Select("Rws_Fld_Describe='" + strAccidentDegreeDes.ToString() + "'");

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