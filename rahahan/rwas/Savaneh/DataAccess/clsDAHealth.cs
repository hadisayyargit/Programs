 /*********************************************************************
 *  File Name : clsDAHealthItem
 *  Class Name : clsDAHealthItem
 *  Namespace  : RWAS
 * 
 *  Codding By : Z.Tanoursaz
 *  Date       : 6/6/2008
 * 
 *  Description: 
 * /*********************************************************************/

using System;
using RWAS.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;
using System.Data;
using System.Text;
using ProgLib.Configuration.Login;

namespace RWAS.DataAccess
{
	/// <summary>
	/// 
	/// </summary>
	public class clsDAHealth
	{
		private SqlDataAdapter dadHealth;
		//private SqlDataAdapter dadHealthResult;

		private SqlCommand sqlCmdSelect;
		private SqlCommand sqlCmdInsert;
		private SqlCommand sqlCmdDelete;
		private SqlCommand sqlCmdUpdate;

		private SqlCommand sqlCmdSelectResult;
		private SqlCommand sqlCmdInsertResult;
		private SqlCommand sqlCmdDeleteResult;
		
		private SqlConnection sqlConHealthItem;

		private const string PARM_fk_HealthKind = "@Rws_Fld_fk_HealthKind";
		private const string PARM_HealthDescribe = "@Rws_Fld_HealthDescribe";
		private const string PARM_IsConfirm = "@Rws_Fld_IsConfirm";
		private const string PARM_pk_HealthItem = "@Rws_Fld_pk_HealthItem";

		private const string PARM_Describe = "@Rws_Fld_Describe";
		private const string PARM_fk_HealthItem = "@Rws_Fld_fk_HealthItem";
		private const string PARM_pk_HealthResult = "@Rws_Fld_pk_HealthResult";

		public clsDAHealth()
		{
			//
			// TODO: Add constructor logic here
			//			

			sqlConHealthItem=CAccessControl.Connection;

			dadHealth=new SqlDataAdapter(); 	
			//dadHealthResult=new SqlDataAdapter(); 	
		}

		//*********************************************************************
		// Method Name :LoadHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>clsDSHealthItem</returns>
		//*********************************************************************
		public clsDSHealth LoadHealth(int intHealthItem, string strHealthDescribe, int intHealthKind)
		{
			try
			{
				clsDSHealth objDSHealth= new clsDSHealth();

				if (sqlConHealthItem.State != ConnectionState.Open) 
					sqlConHealthItem.Open();

				dadHealth.SelectCommand=GetLoadHealthItem(intHealthItem, strHealthDescribe, intHealthKind);
				dadHealth.Fill( objDSHealth, objDSHealth.Rws_Sp_Sel_HealthItem.TableName);

				dadHealth.SelectCommand=GetLoadHealthResult(intHealthItem, strHealthDescribe, intHealthKind);
				dadHealth.Fill( objDSHealth, objDSHealth.Rws_Sp_Sel_HealthResult.TableName);

				sqlConHealthItem.Close();

				return objDSHealth;
			}
			catch( Exception ocException )
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :GetLoadHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetLoadHealthItem(int intHealthItem, string strHealthDescribe, int intHealthKind)
		{
			try
			{
				sqlCmdSelect = new SqlCommand("Rws_Sp_Sel_HealthItem", sqlConHealthItem);

				sqlCmdSelect.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthItem = sqlCmdSelect.Parameters;

				SqlParmHealthItem.Add(new SqlParameter(PARM_pk_HealthItem , SqlDbType.Int));
				SqlParmHealthItem.Add(new SqlParameter(PARM_fk_HealthKind , SqlDbType.TinyInt));
				SqlParmHealthItem.Add(new SqlParameter(PARM_HealthDescribe , SqlDbType.NVarChar, 50));

				SqlParmHealthItem[PARM_pk_HealthItem].Value = intHealthItem;
				SqlParmHealthItem[PARM_fk_HealthKind].Value = intHealthKind;
				SqlParmHealthItem[PARM_HealthDescribe].Value = strHealthDescribe;

				return sqlCmdSelect;
		
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :LoadHealthResult
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>clsDSHealthResult</returns>
		//*********************************************************************
//		public clsDSHealth LoadHealthResult(int intHealthResult)
//		{
//			try
//			{
//				clsDSHealth objDSHealth= new clsDSHealth();
//
//				if (sqlConHealthItem.State != ConnectionState.Open) 
//					sqlConHealthItem.Open();
//
//				dadHealthResult.SelectCommand=GetLoadHealthResult(intHealthResult);
//				dadHealthResult.Fill( objDSHealthResult, objDSHealthResult.Rws_Sp_Sel_HealthResult.TableName);
//
//				sqlConHealthItem.Close();
//
//				return objDSHealthResult;
//			}
//			catch( Exception ocException )
//			{
//				if (ocException is SqlException)
//					throw (SqlException) ocException;
//				else
//					throw ocException;
//			}
//		}

		//*********************************************************************
		// Method Name :GetLoadHealthResult
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetLoadHealthResult(int intHealthItem, string strHealthDescribe, int intHealthKind)
		{
			try
			{
				sqlCmdSelectResult = new SqlCommand("Rws_Sp_Sel_HealthResult", sqlConHealthItem);

				sqlCmdSelectResult.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthResult = sqlCmdSelectResult.Parameters;

				SqlParmHealthResult.Add(new SqlParameter(PARM_pk_HealthItem , SqlDbType.Int));
				SqlParmHealthResult.Add(new SqlParameter(PARM_fk_HealthKind , SqlDbType.TinyInt));
				SqlParmHealthResult.Add(new SqlParameter(PARM_HealthDescribe , SqlDbType.NVarChar, 50));

				SqlParmHealthResult[PARM_pk_HealthItem].Value = intHealthItem;
				SqlParmHealthResult[PARM_fk_HealthKind].Value = intHealthKind;
				SqlParmHealthResult[PARM_HealthDescribe].Value = strHealthDescribe;

				return sqlCmdSelectResult;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :UpdateHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <param name="objDSHealthItem"></param>
		/// <param name="objDSHealthResult"></param>
		/// <returns></returns>
		//*********************************************************************
		public bool UpdateHealth(clsDSHealth objDSHealth)
		{
			try
			{

				if (sqlConHealthItem.State != ConnectionState.Open) 
					sqlConHealthItem.Open();

				//objDSHealth.EnforceConstraints = false;

				//Set the DeleteCommand , InsertCommand , UpdateCommand & then Save the changes to database
				dadHealth.DeleteCommand = GetDeleteCmdHealthItem();
				dadHealth.InsertCommand = GetInsertCmdHealthItem();
				dadHealth.UpdateCommand = GetUpdateCmdHealthItem();
				dadHealth.Update(objDSHealth, objDSHealth.Rws_Sp_Sel_HealthItem.TableName);
				
				//Set the InsertCommand & then Save the changes to database
				dadHealth.DeleteCommand = GetDeleteCmdHealthResult();
				dadHealth.InsertCommand = GetInsertCmdHealthResult();
				dadHealth.Update(objDSHealth, objDSHealth.Rws_Sp_Sel_HealthResult.TableName);

				sqlConHealthItem.Close();

				//if any kind of error has accoured during saving
				if(objDSHealth.HasErrors) 
				{
					return false;
				}
				else
				{
					objDSHealth.AcceptChanges();
					return true;
				}
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
				{
					if (ocException.Message == "Concurrency violation: the DeleteCommand affected 0 records.")
						return true;
					else
						throw ocException;
				}
			}
		}

		//*********************************************************************
		// Method Name :GetInsertCmdHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetInsertCmdHealthItem()
		{
			try
			{
				sqlCmdInsert = new SqlCommand("Rws_Sp_Ins_HealthItem", sqlConHealthItem);
				sqlCmdInsert.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthItem = sqlCmdInsert.Parameters;

				SqlParmHealthItem.Add(new SqlParameter(PARM_fk_HealthKind , SqlDbType.TinyInt));
				SqlParmHealthItem.Add(new SqlParameter(PARM_HealthDescribe , SqlDbType.NVarChar,50));
				SqlParmHealthItem.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));
				SqlParmHealthItem.Add(new SqlParameter(PARM_pk_HealthItem , SqlDbType.Int));

				SqlParmHealthItem[PARM_fk_HealthKind].SourceColumn = clsDSHealth.Rws_Fld_fk_HealthKind;
				SqlParmHealthItem[PARM_HealthDescribe].SourceColumn = clsDSHealth.Rws_Fld_HealthDescribe;
				SqlParmHealthItem[PARM_IsConfirm].SourceColumn = clsDSHealth.Rws_Fld_IsConfirm;
				SqlParmHealthItem[PARM_pk_HealthItem].SourceColumn = clsDSHealth.Rws_Fld_pk_HealthItem;
				SqlParmHealthItem[PARM_pk_HealthItem].Direction = ParameterDirection.InputOutput;

				return sqlCmdInsert;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :GetUpdateCmdHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetUpdateCmdHealthItem()
		{
			try
			{
				sqlCmdUpdate = new SqlCommand("Rws_Sp_Upd_HealthItem", sqlConHealthItem);
				sqlCmdUpdate.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthItem = sqlCmdUpdate.Parameters;

				SqlParmHealthItem.Add(new SqlParameter(PARM_fk_HealthKind , SqlDbType.TinyInt));
				SqlParmHealthItem.Add(new SqlParameter(PARM_HealthDescribe , SqlDbType.NVarChar,50));
				SqlParmHealthItem.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));
				SqlParmHealthItem.Add(new SqlParameter(PARM_pk_HealthItem , SqlDbType.Int));

				SqlParmHealthItem[PARM_fk_HealthKind].SourceColumn = clsDSHealth.Rws_Fld_fk_HealthKind;
				SqlParmHealthItem[PARM_HealthDescribe].SourceColumn = clsDSHealth.Rws_Fld_HealthDescribe;
				SqlParmHealthItem[PARM_IsConfirm].SourceColumn = clsDSHealth.Rws_Fld_IsConfirm;
				SqlParmHealthItem[PARM_pk_HealthItem].SourceColumn = clsDSHealth.Rws_Fld_pk_HealthItem;

				return sqlCmdUpdate;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :GetDeleteCmdHealthItem
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetDeleteCmdHealthItem()
		{
			try
			{
				sqlCmdDelete = new SqlCommand("Rws_Sp_Del_HealthItem", sqlConHealthItem);
				sqlCmdDelete.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthItem = sqlCmdDelete.Parameters;

				SqlParmHealthItem.Add(new SqlParameter(PARM_pk_HealthItem, SqlDbType.Int));

				SqlParmHealthItem[PARM_pk_HealthItem].SourceColumn = clsDSHealth.Rws_Fld_pk_HealthItem;
									
				return sqlCmdDelete;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :GetInsertCmdHealthResult
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetInsertCmdHealthResult()
		{
			try
			{
				sqlCmdInsertResult = new SqlCommand("Rws_Sp_Ins_HealthResult", sqlConHealthItem);
				sqlCmdInsertResult.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthResult = sqlCmdInsertResult.Parameters;

				SqlParmHealthResult.Add(new SqlParameter(PARM_fk_HealthItem , SqlDbType.Int));
				SqlParmHealthResult.Add(new SqlParameter(PARM_Describe , SqlDbType.NVarChar,50));
				SqlParmHealthResult.Add(new SqlParameter(PARM_pk_HealthResult , SqlDbType.Int));

				SqlParmHealthResult[PARM_fk_HealthItem].SourceColumn = clsDSHealth.Rws_Fld_fk_HealthItem;
				SqlParmHealthResult[PARM_Describe].SourceColumn = clsDSHealth.Rws_Fld_Describe;
				SqlParmHealthResult[PARM_pk_HealthResult].SourceColumn = clsDSHealth.Rws_Fld_pk_HealthResult;
				SqlParmHealthResult[PARM_pk_HealthResult].Direction = ParameterDirection.InputOutput;

				return sqlCmdInsertResult;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}

		//*********************************************************************
		// Method Name :GetDeleteCmdHealthResult
		// Called By : HealthItem BR
		// Date       : 6/6/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetDeleteCmdHealthResult()
		{
			try
			{
				sqlCmdDeleteResult = new SqlCommand("Rws_Sp_Del_HealthResult", sqlConHealthItem);
				sqlCmdDeleteResult.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmHealthResult = sqlCmdDeleteResult.Parameters;

				SqlParmHealthResult.Add(new SqlParameter(PARM_pk_HealthResult , SqlDbType.Int));

				SqlParmHealthResult[PARM_pk_HealthResult].SourceColumn = clsDSHealth.Rws_Fld_pk_HealthResult;
									
				return sqlCmdDeleteResult;
			}
			catch(Exception ocException)
			{
				if (ocException is SqlException)
					throw (SqlException) ocException;
				else
					throw ocException;
			}
		}
	}
}