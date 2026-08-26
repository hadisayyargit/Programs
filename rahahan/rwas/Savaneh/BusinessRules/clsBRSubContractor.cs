/*********************************************************************;
 *  File Name : clsBRSubContractor
 *  class Name : clsBRSubContractor
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
	public class clsBRSubContractor
	{
		public clsBRSubContractor()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		//*********************************************************************
		// Method Name : GetSubContractor
		// Called By : SubContractorForm
		// Date       : 9/7/2002
		/// <summary>
		/// </summary>
		/// <returns>clsDSSubContractor</returns>
		/// //*********************************************************************
		public clsDSSubContractor GetSubContractor() 
		{
			clsDSSubContractor  objDSSubContractor;
			clsDASubContractor  objDASubContractor = new clsDASubContractor();

			try 
			{
				objDSSubContractor = objDASubContractor.LoadSubContractor();

				return objDSSubContractor;
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
		/// <param name="objDSSubContractor"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool Update( clsDSSubContractor objDSSubContractor) 
		{
			bool binResult;

			try 
			{
				clsDASubContractor objDASubContractor = new clsDASubContractor();
				binResult=objDASubContractor.UpdateSubContractor(objDSSubContractor);

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
		// Method Name : SubContractorIsConfirm
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSSubContractor"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool SubContractorIsConfirm(int intCode ,clsDSSubContractor objDSSubContractor) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSSubContractor.Rws_Sp_Sel_All_SubContractor.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSSubContractor.Rws_Fld_IsConfirm]== true)
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
		// Method Name : SubContractorIsUsed
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="objDSSubContractor"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool SubContractorIsUsed(int intCode ,clsDSSubContractor objDSSubContractor) 
		{
			DataRow[] drowSelect;

			try 
			{

				drowSelect=objDSSubContractor.Rws_Sp_Sel_All_SubContractor.Select("Rws_Fld_Code=" + intCode.ToString());

				if (drowSelect.Length ==0)
					return false;

				if ((bool)drowSelect[0][clsDSSubContractor.Rws_Fld_IsUsed]== true)
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
		// Method Name : SubContractorIsExistForAdd
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="strSubContractorDes"></param>
		/// <param name="intSubContractorCode"></param>
		/// <param name="objDSSubContractor"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool SubContractorIsExistForAdd(string strSubContractorDes ,clsDSSubContractor objDSSubContractor) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSSubContractor.Rws_Sp_Sel_All_SubContractor.Select("Rws_Fld_Describe='" + strSubContractorDes.ToString() + "'");

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
		// Method Name : SubContractorIsExistForUpdate
		// Called By : 
		// Date       : 02/11/2008
		/// <summary>
		/// </summary>
		/// <param name="intCode"></param>
		/// <param name="strSubContractorDes"></param>
		/// <param name="intSubContractorCode"></param>
		/// <param name="objDSSubContractor"></param>
		/// <returns>bool</returns>
		//**********************************************************************
		public bool SubContractorIsExistForUpdate(int intCode,string strSubContractorDes ,clsDSSubContractor objDSSubContractor) 
		{
			DataRow[] drowSelect;

			try 
			{
				drowSelect=objDSSubContractor.Rws_Sp_Sel_All_SubContractor.Select("Rws_Fld_Describe='" + strSubContractorDes.ToString() + "'");

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