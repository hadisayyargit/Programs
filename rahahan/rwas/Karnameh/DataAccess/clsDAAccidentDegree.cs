 /*********************************************************************
 *  File Name : clsDAAccidentDegree
 *  Class Name : clsDAAccidentDegree
 *  Namespace  : RWAS
 * 
 *  Codding By : H.Ziabakhsh
 *  Date       : 10/4/2006
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
	public class clsDAAccidentDegree
	{
		private SqlDataAdapter dadAccidentDegree;
		private SqlCommand sqlCmdSelect;
		private SqlCommand sqlCmdInsert;
		private SqlCommand sqlCmdDelete;
		private SqlCommand sqlCmdUpdate;
		private SqlConnection sqlConAccidentDegree;

		private const string PARM_Code = "@Rws_Fld_Code";
		private const string PARM_Describe = "@Rws_Fld_Describe";
		private const string PARM_IsConfirm = "@Rws_Fld_IsConfirm";

		public clsDAAccidentDegree()
		{
			//
			// TODO: Add constructor logic here
			//				

			sqlConAccidentDegree=CAccessControl.Connection;
			
			dadAccidentDegree=new SqlDataAdapter(); 	
		}

		//*********************************************************************
		// Method Name :LoadAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>clsDSAccidentDegree</returns>
		//*********************************************************************
		public clsDSAccidentDegree LoadAccidentDegree()
		{
			try
			{
				clsDSAccidentDegree objDSAccidentDegree= new clsDSAccidentDegree();

				if (sqlConAccidentDegree.State != ConnectionState.Open) 
					sqlConAccidentDegree.Open();

				objDSAccidentDegree.EnforceConstraints=false;

				dadAccidentDegree.SelectCommand=GetLoadAccidentDegree();
				dadAccidentDegree.Fill( objDSAccidentDegree,objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.TableName);

				sqlConAccidentDegree.Close();

				return objDSAccidentDegree;

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
		// Method Name :GetLoadAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetLoadAccidentDegree()
		{
			try
			{
				sqlCmdSelect = new SqlCommand("Rws_Sp_Sel_All_AccidentDegree2", sqlConAccidentDegree);

				sqlCmdSelect.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmAccidentDegree = sqlCmdSelect.Parameters;

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
		// Method Name :UpdateAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <param name="objDSAccidentDegree"></param>
		/// <returns></returns>
		//*********************************************************************
		public bool UpdateAccidentDegree(clsDSAccidentDegree objDSAccidentDegree)
		{
			try
			{
				//Set the DeleteCommand , InsertCommand , UpdateCommand & then Save the changes to database
				dadAccidentDegree.DeleteCommand = GetDeleteCmdAccidentDegree();
				dadAccidentDegree.InsertCommand = GetInsertCmdAccidentDegree();
				dadAccidentDegree.UpdateCommand = GetUpdateCmdAccidentDegree();

				if (sqlConAccidentDegree.State != ConnectionState.Open) 
					sqlConAccidentDegree.Open();

				dadAccidentDegree.Update(objDSAccidentDegree, objDSAccidentDegree.Rws_Sp_Sel_All_AccidentDegree2.TableName);

				sqlConAccidentDegree.Close();

				//if any kind of error has accoured during saving
				if(objDSAccidentDegree.HasErrors) 
				{
					return false;
				}
				else
				{
					objDSAccidentDegree.AcceptChanges();
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
		// Method Name :GetInsertCmdAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetInsertCmdAccidentDegree()
		{
			try
			{
				sqlCmdInsert = new SqlCommand("Rws_Sp_Ins_AccidentDegree", sqlConAccidentDegree);
				sqlCmdInsert.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmAccidentDegree = sqlCmdInsert.Parameters;

				SqlParmAccidentDegree.Add(new SqlParameter(PARM_Code , SqlDbType.SmallInt));
				SqlParmAccidentDegree.Add(new SqlParameter(PARM_Describe , SqlDbType.NVarChar,20));
				SqlParmAccidentDegree.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));

				SqlParmAccidentDegree[PARM_Code].SourceColumn = clsDSAccidentDegree.Rws_Fld_Code;
				SqlParmAccidentDegree[PARM_Describe].SourceColumn = clsDSAccidentDegree.Rws_Fld_Describe;
				SqlParmAccidentDegree[PARM_IsConfirm].SourceColumn = clsDSAccidentDegree.Rws_Fld_IsConfirm;

				SqlParmAccidentDegree[PARM_Code].Direction = ParameterDirection.Output;

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
		// Method Name :GetUpdateCmdAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetUpdateCmdAccidentDegree()
		{
			try
			{
				sqlCmdUpdate = new SqlCommand("Rws_Sp_Upd_AccidentDegree", sqlConAccidentDegree);
				sqlCmdUpdate.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmAccidentDegree = sqlCmdUpdate.Parameters;

				SqlParmAccidentDegree.Add(new SqlParameter(PARM_Code , SqlDbType.SmallInt));
				SqlParmAccidentDegree.Add(new SqlParameter(PARM_Describe, SqlDbType.NVarChar,20));
				SqlParmAccidentDegree.Add(new SqlParameter(PARM_IsConfirm , SqlDbType.Bit));

				SqlParmAccidentDegree[PARM_Code].SourceColumn = clsDSAccidentDegree.Rws_Fld_Code;
				SqlParmAccidentDegree[PARM_Describe].SourceColumn = clsDSAccidentDegree.Rws_Fld_Describe;
				SqlParmAccidentDegree[PARM_IsConfirm].SourceColumn = clsDSAccidentDegree.Rws_Fld_IsConfirm;

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
		// Method Name :GetDeleteCmdAccidentDegree
		// Called By : AccidentDegree BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetDeleteCmdAccidentDegree()
		{
			try
			{
				sqlCmdDelete = new SqlCommand("Rws_Sp_Del_AccidentDegree", sqlConAccidentDegree);
				sqlCmdDelete.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmAccidentDegree = sqlCmdDelete.Parameters;

				SqlParmAccidentDegree.Add(new SqlParameter(PARM_Code, SqlDbType.SmallInt));

				SqlParmAccidentDegree[PARM_Code].SourceColumn = clsDSAccidentDegree.Rws_Fld_Code;
									
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