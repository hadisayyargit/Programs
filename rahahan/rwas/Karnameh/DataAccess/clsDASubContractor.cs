 /*********************************************************************
 *  File Name : clsDASubContractor
 *  Class Name : clsDASubContractor
 *  Namespace  : RWAS
 * 
 *  Codding By : N.Nouri
 *  Date       : 2/11/2008
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
	public class clsDASubContractor
	{
		private SqlDataAdapter dadSubContractor;
		private SqlCommand sqlCmdSelect;
		private SqlCommand sqlCmdInsert;
		private SqlCommand sqlCmdDelete;
		private SqlCommand sqlCmdUpdate;
		private SqlConnection sqlConSubContractor;

		private const string PARM_Code = "@Rws_Fld_Code";
		private const string PARM_Describe = "@Rws_Fld_Describe";
		private const string PARM_IsConfirm = "@Rws_Fld_IsConfirm";

		public clsDASubContractor()
		{
			//
			// TODO: Add constructor logic here
			//				

			sqlConSubContractor=CAccessControl.Connection;
			
			dadSubContractor=new SqlDataAdapter(); 	
		}

		//*********************************************************************
		// Method Name :LoadSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>clsDSSubContractor</returns>
		//*********************************************************************
		public clsDSSubContractor LoadSubContractor()
		{
			try
			{
				clsDSSubContractor objDSSubContractor= new clsDSSubContractor();

				if (sqlConSubContractor.State != ConnectionState.Open) 
					sqlConSubContractor.Open();

				objDSSubContractor.EnforceConstraints=false;

				dadSubContractor.SelectCommand=GetLoadSubContractor();
				dadSubContractor.Fill( objDSSubContractor,objDSSubContractor.Rws_Sp_Sel_All_SubContractor.TableName);

				sqlConSubContractor.Close();

				return objDSSubContractor;

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
		// Method Name :GetLoadSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetLoadSubContractor()
		{
			try
			{
				sqlCmdSelect = new SqlCommand("Rws_Sp_Sel_All_SubContractor", sqlConSubContractor);

				sqlCmdSelect.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmSubContractor = sqlCmdSelect.Parameters;

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
		// Method Name :UpdateSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <param name="objDSSubContractor"></param>
		/// <returns></returns>
		//*********************************************************************
		public bool UpdateSubContractor(clsDSSubContractor objDSSubContractor)
		{
			try
			{

				//Set the DeleteCommand , InsertCommand , UpdateCommand & then Save the changes to database
				dadSubContractor.DeleteCommand = GetDeleteCmdSubContractor();
				dadSubContractor.InsertCommand = GetInsertCmdSubContractor();
				dadSubContractor.UpdateCommand = GetUpdateCmdSubContractor();


				if (sqlConSubContractor.State != ConnectionState.Open) 
					sqlConSubContractor.Open();

				dadSubContractor.Update(objDSSubContractor, objDSSubContractor.Rws_Sp_Sel_All_SubContractor.TableName);

				sqlConSubContractor.Close();

				//if any kind of error has accoured during saving
				if(objDSSubContractor.HasErrors) 
				{
					return false;
				}
				else
				{
					objDSSubContractor.AcceptChanges();
					return true;
				}
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
		// Method Name :GetInsertCmdSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetInsertCmdSubContractor()
		{
			try
			{
				sqlCmdInsert = new SqlCommand("Rws_Sp_Ins_SubContractor", sqlConSubContractor);
				sqlCmdInsert.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmSubContractor = sqlCmdInsert.Parameters;

				SqlParmSubContractor.Add(new SqlParameter(PARM_Code , SqlDbType.TinyInt));
				SqlParmSubContractor.Add(new SqlParameter(PARM_Describe , SqlDbType.NVarChar,15));
				SqlParmSubContractor.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));

				SqlParmSubContractor[PARM_Code].SourceColumn = clsDSSubContractor.Rws_Fld_Code;
				SqlParmSubContractor[PARM_Describe].SourceColumn = clsDSSubContractor.Rws_Fld_Describe;
				SqlParmSubContractor[PARM_IsConfirm].SourceColumn = clsDSSubContractor.Rws_Fld_IsConfirm;

				SqlParmSubContractor[PARM_Code].Direction = ParameterDirection.Output;

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
		// Method Name :GetUpdateCmdSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetUpdateCmdSubContractor()
		{
			try
			{
				sqlCmdUpdate = new SqlCommand("Rws_Sp_Upd_SubContractor", sqlConSubContractor);
				sqlCmdUpdate.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmSubContractor = sqlCmdUpdate.Parameters;

				SqlParmSubContractor.Add(new SqlParameter(PARM_Code , SqlDbType.TinyInt));
				SqlParmSubContractor.Add(new SqlParameter(PARM_Describe, SqlDbType.NVarChar,15));
				SqlParmSubContractor.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));

				SqlParmSubContractor[PARM_Code].SourceColumn = clsDSSubContractor.Rws_Fld_Code;
				SqlParmSubContractor[PARM_Describe].SourceColumn = clsDSSubContractor.Rws_Fld_Describe;
				SqlParmSubContractor[PARM_IsConfirm].SourceColumn = clsDSSubContractor.Rws_Fld_IsConfirm;

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
		// Method Name :GetDeleteCmdSubContractor
		// Called By : SubContractor BR
		// Date       : 2/9/2008
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetDeleteCmdSubContractor()
		{
			try
			{
				sqlCmdDelete = new SqlCommand("Rws_Sp_Del_SubContractor", sqlConSubContractor);
				sqlCmdDelete.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmSubContractor = sqlCmdDelete.Parameters;

				SqlParmSubContractor.Add(new SqlParameter(PARM_Code, SqlDbType.TinyInt));

				SqlParmSubContractor[PARM_Code].SourceColumn = clsDSSubContractor.Rws_Fld_Code;
									
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
	}
}