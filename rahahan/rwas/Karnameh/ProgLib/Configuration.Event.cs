using System;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using ProgLib.Configuration.Login;
using ProgLib.Classes;

namespace ProgLib.Configuration.Event
{
	public enum ActionType
	{
		// Fields
		Application = 1,
		Calculate = 2,
		Delete = 3,
		Edit = 4,
		Insert = 5,
		Load = 6,
		Login = 7,
		Other = 0,
		Print = 8,
		Save = 9
	}


	public enum LogType
	{
		// Fields
		logError = 0,
		logInfo = 1
	}

	public enum OutputType
	{
		// Fields
		outBoth = 2,
		outDatabase = 1,
		outWindows = 0
	}

	public class CApplicationAssert
	{
		// Fields
		public const string FileName = "";
		public const int LineNumber = 0;

		// Methods
		public CApplicationAssert()
		{
		}

		[Conditional("DEBUG")]
		public static void Check(bool condition, SystemID sysID, int intTextCode)
		{
			int num1 = 0;
			if (!condition)
			{
				string text1 = CMessageHandler.Handle(sysID, intTextCode);
				string text2 = string.Empty;
				string text3 = string.Empty;
				try
				{
					CLogManager.WriteLog(LogType.logError, sysID, text1 + text2, num1, text3);
				}
				catch (Exception exception1)
				{
					throw new Exception("ProgLib Error - CApplicationAssert : " + exception1.Message);
				}
				throw new Exception(text1 + text2);
			}
		}

		public static void CheckCondition(bool condition, SystemID sysID, int intTextCode)
		{
			int num1 = 0;
			if (!condition)
			{
				string text1 = CMessageHandler.Handle(sysID, intTextCode);
				string text2 = string.Empty;
				string text3 = string.Empty;
				try
				{
					CLogManager.WriteLog(LogType.logError, sysID, text1 + text2, num1, text3);
				}
				catch (Exception exception1)
				{
					throw new Exception("ProgLib Error - CApplicationAssert : " + exception1.Message);
				}
				throw new Exception(text1 + text2);
			}
		}

		//[Conditional("DEBUG")]
		private static void GenerateStackTrace(int lineNumber, out string currentTrace, out string strFilename)
		{
			currentTrace = string.Empty;
			strFilename = string.Empty;
		}

		
	}


	public class CLogEntry
	{
		// Fields
		private int intLineNo;
		private LogType logType;
		private OutputType outType;
		private string strClientName;
		private string strFileName;
		private string strMessage;
		private SystemID sysID;

		// Methods
		public CLogEntry()
		{
		}


		// Properties
		public string ClientName
		{
			get
			{
				return this.strClientName;
			}
			set
			{
				this.strClientName = value;
			}
		}
 

		public string FileName
		{
			get
			{
				return this.strFileName;
			}
			set
			{
				this.strFileName = value;
			}
		}

		public int LineNo
		{
			get
			{
				return this.intLineNo;
			}
			set
			{
				this.intLineNo = value;
			}
		}
 

		public LogType Log_Type
		{
			get
			{
				return this.logType;
			}
			set
			{
				this.logType = value;
			}
		}

		public string Message
		{
			get
			{
				return this.strMessage;
			}
			set
			{
				this.strMessage = value;
			}
		}

		public OutputType Output_Type
		{
			get
			{
				return this.outType;
			}
			set
			{
				this.outType = value;
			}
		}

		public SystemID System_ID
		{
			get
			{
				return this.sysID;
			}
			set
			{
				this.sysID = value;
			}
		}


		
	}


	public class CLogManager
	{
		// Fields
		public static bool boolActiveLog;
		public static bool boolLogOnLine;
		public static bool boolWeb;
		public static OutputType CurrentOutput;
		private static int intCurrentRecord;
		private static Hashtable ocHashtableLog;
		private static SqlConnection ocSqlConnection;

		// Methods
		static CLogManager()
		{
			CLogManager.ocHashtableLog = new Hashtable();
			CLogManager.ocSqlConnection = new SqlConnection();
			CLogManager.intCurrentRecord = 0;
			CLogManager.boolWeb = false;
			CLogManager.boolActiveLog = true;
			
			CLogManager.CurrentOutput = OutputType.outDatabase;
		}

		public CLogManager()
		{
		}

		public static void Clear()
		{
			CLogManager.ocHashtableLog.Clear();
			CLogManager.intCurrentRecord = 0;
		}

		public static void CloseLogConnection()
		{
			if (CLogManager.ocSqlConnection.State == ConnectionState.Open)
			{
				CLogManager.ocSqlConnection.Close();
				CLogManager.ocSqlConnection.Dispose();
			}
		}
 

		private static string GetTableName(SystemID sysID, LogType logType)
		{
			if (CLogManager.boolWeb)
			{
				return CLogManager.GetWebTableName(sysID, logType);
			}
			string text1 = string.Empty;
			switch (sysID)
			{
				case SystemID.idWorkbook:
				{
					if (logType == LogType.logError)
					{
						return "Log_Tbl_Error";
					}
					return "Log_Tbl_Info";
				}
				
			}
			return text1;
		}

		private static string GetWebTableName(SystemID sysID, LogType logType)
		{
			string text1 = string.Empty;
			switch (sysID)
			{
				case SystemID.idWorkbook:
				{
					if (logType == LogType.logError)
					{
						return "Log_Tbl_Error4WebTeam";
					}
					return "Log_Tbl_Info4WebTeam";
				}
				
			}
			return text1;
		}
 

		public static bool OpenLogConnection(SystemID sysID)
		{
			bool flag1;
			string text1 = "";
			if (CLogManager.ocSqlConnection.State == ConnectionState.Open)
			{
				return true;
			}
			if (CAccessControl.Server == string.Empty)
			{
				throw new ApplicationException("ProgLib Error - CLogManager : Server name not found in CAccessControl class.");
			}
			if (CAccessControl.Client == string.Empty)
			{
				throw new ApplicationException("ProgLib Error - CLogManager : Client name not found in CAccessControl class.");
			}
			if (CAccessControl.AuthenticateType == AuthenticationType.SQL)
			{
				if (CAccessControl.Username == string.Empty)
				{
					throw new ApplicationException("ProgLib Error - CLogManager : User name not found in CAccessControl class.");
				}
				if (CAccessControl.Password == string.Empty)
				{
					throw new ApplicationException("ProgLib Error - CLogManager : Password not found in CAccessControl class.");
				}
			}
			try
			{
				string[] textArray1;
				if (CAccessControl.AuthenticateType == AuthenticationType.WIN)
				{
					//textArray1 = new string[7] { "Server = ", CAccessControl.Server, " ;initial catalog =", CAccessControl.Database ,"; Workstation id= ", CAccessControl.Client, " ; Integrated Security = SSPI" } ;
					textArray1 = new string[10] { "Server = ", CAccessControl.Server, " ;initial catalog = ", CAccessControl.Database ,"; Workstation id= ", CAccessControl.Client, " ; User ID = ", CAccessControl.Username, " ; password = ", CAccessControl.Password } ;
					text1 = string.Concat(textArray1);
				}
				else if (CAccessControl.AuthenticateType == AuthenticationType.SQL)
				{
					textArray1 = new string[10] { "Server = ", CAccessControl.Server, " ;initial catalog = ", CAccessControl.Database ,"; Workstation id= ", CAccessControl.Client, " ; User ID = ", CAccessControl.Username, " ; password = ", CAccessControl.Password } ;
					text1 = string.Concat(textArray1);
				}
				CLogManager.ocSqlConnection.ConnectionString = text1;
				CLogManager.ocSqlConnection.Open();
				flag1 = true;
			}
			catch (Exception exception1)
			{
				throw new ApplicationException("ProgLib Error - CLogManager : " + exception1.Message);
			}
			return flag1;
		}

		public static bool UpLoadLog()
		{
			bool flag1;
			try
			{
				CLogEntry entry1 = new CLogEntry();
				int num1 = CLogManager.ocHashtableLog.Count;
				for (int num2 = 0; num2 < num1; num2++)
				{
					entry1 = (CLogEntry) CLogManager.ocHashtableLog[num2];
					if (entry1.Output_Type == OutputType.outWindows)
					{
						CLogManager.WriteLogToWindows(entry1.Log_Type, entry1.System_ID, entry1.Message);
					}
					else if (entry1.Output_Type == OutputType.outDatabase)
					{
						CLogManager.WriteLogToDatabase(entry1.Log_Type, entry1.System_ID, entry1.Message, entry1.LineNo, entry1.FileName);
					}
					else
					{
						CLogManager.WriteLogToWindows(entry1.Log_Type, entry1.System_ID, entry1.Message);
						CLogManager.WriteLogToDatabase(entry1.Log_Type, entry1.System_ID, entry1.Message, entry1.LineNo, entry1.FileName);
					}
				}
				CLogManager.ocHashtableLog.Clear();
				CLogManager.intCurrentRecord = 0;
				flag1 = true;
			}
			catch (Exception exception1)
			{
				throw new Exception("ProgLib Error - CLogManager : " + exception1.Message);
			}
			return flag1;
		}
 

		public static void WriteLog(LogType logType, SystemID sysID, string strMessage)
		{
			CLogManager.WriteLog(logType, sysID, strMessage, 0, "");
		}

		public static void WriteLog(OutputType outType, LogType logType, SystemID sysID, string strMessage)
		{
			CLogManager.WriteLog(outType, logType, sysID, strMessage, 0, "");
		}

		public static void WriteLog(LogType logType, SystemID sysID, string strMessage, int intLineNo, string strFileName)
		{
			if (!CLogManager.boolActiveLog)
			{
				throw new ApplicationException("ProgLib Error - CLogManager : Log is off.");
			}
			if (CLogManager.boolLogOnLine)
			{
				if (CLogManager.CurrentOutput == OutputType.outWindows)
				{
					CLogManager.WriteLogToWindows(logType, sysID, strMessage);
				}
				else if (CLogManager.CurrentOutput == OutputType.outDatabase)
				{
					CLogManager.WriteLogToDatabase(logType, sysID, strMessage, intLineNo, strFileName);
				}
				else
				{
					CLogManager.WriteLogToWindows(logType, sysID, strMessage);
					CLogManager.WriteLogToDatabase(logType, sysID, strMessage, intLineNo, strFileName);
				}
			}
			else
			{
				CLogManager.WriteLogToEntry(logType, CLogManager.CurrentOutput, sysID, strMessage, intLineNo, strFileName);
			}
		}

		public static void WriteLog(OutputType outType, LogType logType, SystemID sysID, string strMessage, int intLineNo, string strFileName)
		{
			if (!CLogManager.boolActiveLog)
			{
				throw new ApplicationException("ProgLib Error - CLogManager : Log is off.");
			}
			if (CLogManager.boolLogOnLine)
			{
				if (outType == OutputType.outWindows)
				{
					CLogManager.WriteLogToWindows(logType, sysID, strMessage);
				}
				else if (outType == OutputType.outDatabase)
				{
					CLogManager.WriteLogToDatabase(logType, sysID, strMessage, intLineNo, strFileName);
				}
				else
				{
					CLogManager.WriteLogToWindows(logType, sysID, strMessage);
					CLogManager.WriteLogToDatabase(logType, sysID, strMessage, intLineNo, strFileName);
				}
			}
			else
			{
				CLogManager.WriteLogToEntry(logType, outType, sysID, strMessage, intLineNo, strFileName);
			}
		}

		private static void WriteLogToDatabase(LogType logType, SystemID sysID, string strMessage, int intLineNo, string strFileName)
		{
			ProgLib.Classes.PersianDate ocCDate=new ProgLib.Classes.PersianDate();

			try
			{
				if (CLogManager.ocSqlConnection.State != ConnectionState.Open)
				{
					CLogManager.OpenLogConnection(sysID);
				}

				if (logType==LogType.logError)
				{
					string text1 = "Log_Sp_Ins_Error";
					SqlCommand command1 = new SqlCommand(text1, CLogManager.ocSqlConnection);
					command1.CommandType = CommandType.StoredProcedure;

					SqlParameter parameter0 = command1.Parameters.Add("@Log_Fld_fk_System", SqlDbType.TinyInt);
					parameter0.Direction = ParameterDirection.Input;
					parameter0.Value = (int)SystemID.idWorkbook;

					SqlParameter parameter1 = command1.Parameters.Add("@Log_Fld_Row", SqlDbType.BigInt);
					parameter1.Direction = ParameterDirection.Output;

					SqlParameter parameter2 = command1.Parameters.Add("@Log_Fld_Login", SqlDbType.NVarChar, 24);
					parameter2.Direction = ParameterDirection.Input;
					parameter2.Value = CAccessControl.Username_App;

					SqlParameter parameter3 = command1.Parameters.Add("@Log_Fld_Client", SqlDbType.NVarChar, 24);
					parameter3.Direction = ParameterDirection.Input;
					parameter3.Value = CAccessControl.Client;

					SqlParameter parameter4 = command1.Parameters.Add("@Log_Fld_File", SqlDbType.NVarChar, 255);
					parameter4.Direction = ParameterDirection.Input;
					parameter4.Value = strFileName;

					SqlParameter parameter5 = command1.Parameters.Add("@log_Fld_Line", SqlDbType.Int);
					parameter5.Direction = ParameterDirection.Input;
					parameter5.Value = intLineNo;

					SqlParameter parameter6 = command1.Parameters.Add("@Log_Fld_Message", SqlDbType.NVarChar, 2000);
					parameter6.Direction = ParameterDirection.Input;
					parameter6.Value = strMessage.Replace("'", "''");

					SqlParameter parameter7 = command1.Parameters.Add("@Log_Fld_Date", SqlDbType.NChar,8);
					parameter7.Direction = ParameterDirection.Input;
					parameter7.Value = ocCDate.getPersianDate();

					SqlParameter parameter8 = command1.Parameters.Add("@Log_Fld_Time", SqlDbType.NChar,4);
					parameter8.Direction = ParameterDirection.Input;
					parameter8.Value = DateTime.Now.Hour + DateTime.Now.Minute ;

					SqlDataReader reader1 = command1.ExecuteReader();
					reader1.Close();
				}

				if (logType==LogType.logInfo)
				{
					string text1 = "Log_Sp_Ins_Info";
					SqlCommand command1 = new SqlCommand(text1, CLogManager.ocSqlConnection);
					command1.CommandType = CommandType.StoredProcedure;

					SqlParameter parameter0 = command1.Parameters.Add("@Log_Fld_fk_System", SqlDbType.TinyInt);
					parameter0.Direction = ParameterDirection.Input;
					parameter0.Value = (int)SystemID.idWorkbook;

					SqlParameter parameter1 = command1.Parameters.Add("@Log_Fld_Row", SqlDbType.BigInt);
					parameter1.Direction = ParameterDirection.Output;

					SqlParameter parameter2 = command1.Parameters.Add("@Log_Fld_Login", SqlDbType.NVarChar, 24);
					parameter2.Direction = ParameterDirection.Input;
					parameter2.Value = CAccessControl.Username_App;

					SqlParameter parameter3 = command1.Parameters.Add("@Log_Fld_Client", SqlDbType.NVarChar, 24);
					parameter3.Direction = ParameterDirection.Input;
					parameter3.Value = CAccessControl.Client;

					SqlParameter parameter4 = command1.Parameters.Add("@Log_Fld_File", SqlDbType.NVarChar, 255);
					parameter4.Direction = ParameterDirection.Input;
					parameter4.Value = strFileName;

					SqlParameter parameter5 = command1.Parameters.Add("@log_Fld_Line", SqlDbType.Int);
					parameter5.Direction = ParameterDirection.Input;
					parameter5.Value = intLineNo;

					SqlParameter parameter6 = command1.Parameters.Add("@Log_Fld_Message", SqlDbType.NVarChar, 2000);
					parameter6.Direction = ParameterDirection.Input;
					parameter6.Value = strMessage.Replace("'", "''");

					SqlParameter parameter7 = command1.Parameters.Add("@Log_Fld_Date", SqlDbType.NChar,8);
					parameter7.Direction = ParameterDirection.Input;
					parameter7.Value = ocCDate.getPersianDate();

					SqlParameter parameter8 = command1.Parameters.Add("@Log_Fld_Time", SqlDbType.NChar,4);
					parameter8.Direction = ParameterDirection.Input;
					parameter8.Value = Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute);

					SqlDataReader reader1 = command1.ExecuteReader();
					reader1.Close();
				}


			}
			catch (Exception exception1)
			{
				throw new Exception("ProgLib Error - CLogManager : " + exception1.Message);
			}
		}

		private static void WriteLogToEntry(LogType logType, OutputType outType, SystemID sysID, string strMessage, int intLineNo, string strFileName)
		{
			CLogEntry entry1 = new CLogEntry();
			entry1.ClientName = CAccessControl.Client;
			entry1.Log_Type = logType;
			entry1.Output_Type = outType;
			entry1.FileName = strFileName;
			entry1.LineNo = intLineNo;
			entry1.Message = strMessage;
			entry1.System_ID = sysID;
			CLogManager.ocHashtableLog.Add(CLogManager.intCurrentRecord, entry1);
			CLogManager.intCurrentRecord++;
		}

		private static void WriteLogToWindows(LogType logType, SystemID sysID, string strMessage)
		{
		}
	}


	public class CMessageHandler
	{
		// Fields
		private static Hashtable[] aocHelpTable;
		private static Hashtable[] aocMessageTable;
		public static bool boolWeb;
		private static int nCode;

		// Methods
		static CMessageHandler()
		{
			CMessageHandler.boolWeb = false;
		}

		private CMessageHandler()
		{
		}

		public static string Handle(SystemID sysID, int intCode)
		{
			string text1;
			try
			{
				text1 = (string) CMessageHandler.aocMessageTable[(int) sysID][intCode];
			}
			catch
			{
				throw new ApplicationException("ProgLib Error - CMessageHandler : Message code not found. Index out of range. Code : " + intCode.ToString());
			}
			return text1;
		}

		public static string HandleHelp(int intCode)
		{
			string text1;
			try
			{
				text1 = (string) CMessageHandler.aocHelpTable[CMessageHandler.nCode][intCode];
			}
			catch
			{
				throw new ApplicationException("ProgLib Error - CMessageHandler : Help code not found. Index out of range. Code : " + intCode.ToString());
			}
			return text1;
		}

		public static string HandleHelp(SystemID sysID, int intCode)
		{
			string text1;
			try
			{
				text1 = (string) CMessageHandler.aocHelpTable[(int) sysID][intCode];
			}
			catch
			{
				throw new ApplicationException("ProgLib Error - CMessageHandler : Help code not found. Index out of range. Code : " + intCode.ToString());
			}
			return text1;
		}

		public static void LoadApplicationMessages(SystemID sysID)
		{
			CMessageHandler.nCode = (int) sysID;
			if (CMessageHandler.aocMessageTable == null)
			{
				CMessageHandler.aocMessageTable = new Hashtable[40];
			}
			if (CMessageHandler.aocMessageTable[(int) sysID] == null)
			{
				CMessageHandler.aocMessageTable[(int) sysID] = new Hashtable();
			}
			else
			{
				return;
			}
			if (CMessageHandler.aocHelpTable == null)
			{
				CMessageHandler.aocHelpTable = new Hashtable[40];
			}
			if (CMessageHandler.aocHelpTable[(int) sysID] == null)
			{
				CMessageHandler.aocHelpTable[(int) sysID] = new Hashtable();
			}
			else
			{
				return;
			}
//			try
//			{
//				CLicence licence1 = new CLicence();
//				licence1.LicenceCheck();
//			}
//			catch (Exception exception1)
//			{
//				throw new Exception("ProgLib Error - CMessageHandler : " + exception1.Message);
//			}
			if (CAccessControl.Server == string.Empty)
			{
				CLogManager.WriteLog(LogType.logError, sysID, "Server name not found.");
				throw new ApplicationException("ProgLib Error - CMessageHandler : Server name not found.");
			}
			if (CAccessControl.Client == string.Empty)
			{
				CLogManager.WriteLog(LogType.logError, sysID, "Client name not found.");
				throw new ApplicationException("ProgLib Error - CMessageHandler : Client name not found.");
			}
			try
			{
				int num1;
				string text2;
				string text3;
				//string[] textArray1 = CAccessControl.Connection.ConnectionString; //new string[7] { "Server = ", CAccessControl.Server, " ;initial catalog =", CAccessControl.Database ," ; Workstation id= ", CAccessControl.Client, " ; Integrated Security = SSPI" } ;
//				string text1 = string.Concat(textArray1);
				CMessageHandler.aocMessageTable[(int) sysID].Clear();
				if (CMessageHandler.boolWeb)
				{
					text2 = "Msg_Sp_Sel_isEx_WebMessage";
				}
				else
				{
					text2 = "Adn_Sp_Sel_SystemMessage";
				}
				SqlConnection connection1 = new SqlConnection(CAccessControl.Connection.ConnectionString);
				connection1.Open();
				SqlCommand command1 = new SqlCommand(text2, connection1);
				command1.CommandType = CommandType.StoredProcedure;
				SqlParameter parameter1 = command1.Parameters.Add("@SystemCode", SqlDbType.Int);
				parameter1.Direction = ParameterDirection.Input;
				parameter1.Value = (int) sysID;
				SqlDataReader reader1 = command1.ExecuteReader();
				while (reader1.Read())
				{
					num1 = Convert.ToInt32(reader1["Msg_Fld_Code"].ToString());
					text3 = reader1["Msg_Fld_Describe"].ToString();
					CMessageHandler.aocMessageTable[(int) sysID].Add(num1, text3);
				}
				reader1.Close();
				command1.Dispose();
				CMessageHandler.aocHelpTable[(int) sysID].Clear();
				text2 = "Adn_Sp_Sel_Help";
				command1 = new SqlCommand(text2, connection1);
				command1.CommandType = CommandType.StoredProcedure;
				parameter1 = command1.Parameters.Add("@Hlp_Fld_fk_System", SqlDbType.Int);
				parameter1.Direction = ParameterDirection.Input;
				parameter1.Value = (int) sysID;
				reader1 = command1.ExecuteReader();
				while (reader1.Read())
				{
					num1 = Convert.ToInt32(reader1["Hlp_Fld_Code"].ToString());
					text3 = reader1["Hlp_Fld_Describe"].ToString();
					CMessageHandler.aocHelpTable[(int) sysID].Add(num1, text3);
				}
				reader1.Close();
				connection1.Close();
				connection1.Dispose();
			}
			catch (Exception exception2)
			{
				throw new ApplicationException("ProgLib Error - CMessageHandler : " + exception2.Message);
			}
		}


		
	}


	
}


