 /*********************************************************************
 *  File Name : clsDARegion
 *  Class Name : clsDARegion
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
	public class clsDARegion
	{
		private SqlDataAdapter dadRegion;
		private SqlCommand sqlCmdSelect;
		private SqlCommand sqlCmdInsert;
		private SqlCommand sqlCmdDelete;
		private SqlCommand sqlCmdUpdate;
		private SqlConnection sqlConRegion;

		private const string PARM_Code = "@Rws_Fld_Code";
		private const string PARM_Describe = "@Rws_Fld_Describe";

		public clsDARegion()
		{
			//
			// TODO: Add constructor logic here
			//				

			sqlConRegion=CAccessControl.Connection;
			
			dadRegion=new SqlDataAdapter(); 	
		}

		//*********************************************************************
		// Method Name :LoadRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>clsDSRegion</returns>
		//*********************************************************************
		public clsDSRegion LoadRegion()
		{
			try
			{
				clsDSRegion objDSRegion= new clsDSRegion();

				if (sqlConRegion.State != ConnectionState.Open) 
					sqlConRegion.Open();

				objDSRegion.EnforceConstraints=false;

				dadRegion.SelectCommand=GetLoadRegion();
				dadRegion.Fill( objDSRegion,objDSRegion.Rws_Sp_Sel_All_Region2.TableName);

				sqlConRegion.Close();

				return objDSRegion;

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
		// Method Name :GetLoadRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetLoadRegion()
		{
			try
			{
				sqlCmdSelect = new SqlCommand("Rws_Sp_Sel_All_Region2", sqlConRegion);

				sqlCmdSelect.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmRegion = sqlCmdSelect.Parameters;

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
		// Method Name :UpdateRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <param name="objDSRegion"></param>
		/// <returns></returns>
		//*********************************************************************
		public bool UpdateRegion(clsDSRegion objDSRegion)
		{
			try
			{

				//Set the DeleteCommand , InsertCommand , UpdateCommand & then Save the changes to database
				dadRegion.DeleteCommand = GetDeleteCmdRegion();
				dadRegion.InsertCommand = GetInsertCmdRegion();
				dadRegion.UpdateCommand = GetUpdateCmdRegion();


				if (sqlConRegion.State != ConnectionState.Open) 
					sqlConRegion.Open();

				dadRegion.Update(objDSRegion, objDSRegion.Rws_Sp_Sel_All_Region2.TableName);

				sqlConRegion.Close();

				//if any kind of error has accoured during saving
				if(objDSRegion.HasErrors) 
				{
					return false;
				}
				else
				{
					objDSRegion.AcceptChanges();
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
		// Method Name :GetInsertCmdRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetInsertCmdRegion()
		{
			try
			{
				sqlCmdInsert = new SqlCommand("Rws_Sp_Ins_Region", sqlConRegion);
				sqlCmdInsert.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmRegion = sqlCmdInsert.Parameters;

				SqlParmRegion.Add(new SqlParameter(PARM_Code , SqlDbType.Int));
				SqlParmRegion.Add(new SqlParameter(PARM_Describe , SqlDbType.NVarChar,15));

				SqlParmRegion[PARM_Code].SourceColumn = clsDSRegion.Rws_Fld_Code;
				SqlParmRegion[PARM_Describe].SourceColumn = clsDSRegion.Rws_Fld_Describe;

				SqlParmRegion[PARM_Code].Direction = ParameterDirection.Output;

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
		// Method Name :GetUpdateCmdRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetUpdateCmdRegion()
		{
			try
			{
				sqlCmdUpdate = new SqlCommand("Rws_Sp_Upd_Region", sqlConRegion);
				sqlCmdUpdate.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmRegion = sqlCmdUpdate.Parameters;

				SqlParmRegion.Add(new SqlParameter(PARM_Code , SqlDbType.Int));
				SqlParmRegion.Add(new SqlParameter(PARM_Describe, SqlDbType.NVarChar,15));

				SqlParmRegion[PARM_Code].SourceColumn = clsDSRegion.Rws_Fld_Code;
				SqlParmRegion[PARM_Describe].SourceColumn = clsDSRegion.Rws_Fld_Describe;

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
		// Method Name :GetDeleteCmdRegion
		// Called By : Region BR
		// Date       : 9/24/2005
		/// <summary>
		/// 
		/// </summary>
		/// <returns>SqlCommand</returns>
		//*********************************************************************
		private SqlCommand GetDeleteCmdRegion()
		{
			try
			{
				sqlCmdDelete = new SqlCommand("Rws_Sp_Del_Region", sqlConRegion);
				sqlCmdDelete.CommandType = CommandType.StoredProcedure;

				SqlParameterCollection SqlParmRegion = sqlCmdDelete.Parameters;

				SqlParmRegion.Add(new SqlParameter(PARM_Code, SqlDbType.TinyInt));

				SqlParmRegion[PARM_Code].SourceColumn = clsDSRegion.Rws_Fld_Code;
									
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