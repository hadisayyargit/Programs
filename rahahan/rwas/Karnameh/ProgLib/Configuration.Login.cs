using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using ProgLib.Classes;

namespace ProgLib.Configuration.Login
{
	public enum AuthenticationType
	{
		// Fields
		WIN = 0,
		SQL = 1
	}

	public enum PersonType
	{
		// Fields
		PrsGharardadi = 1,
		PrsNone = 2,
		PrsRasmi = 0
	}

	public class CAccessControl
	{
		// Fields
		private static SqlConnection __AccessConnection;
		private static SqlConnection __AppConnection;
		private static AuthenticationType __AuthenticateType;
		private static string __ConnectionType;
		private static string __Client;
		private static string __Database;
		private static SqlConnection __NewConnection;
		private static string __PassWord;
		private static string __PassWord_App;
		private static int __Port;
		private static string __ReportPath;
		private static string __Server;
		private static string __UserName;
		private static string __UserName_App;
		private static Hashtable DIC;
		private static DataSet dsSL;
		private static int intEmpNo;
		private static PersonType prsType;

		// Methods
		static CAccessControl()
		{
			CAccessControl.__AuthenticateType = AuthenticationType.WIN;
			CAccessControl.__AppConnection = null;
			CAccessControl.__NewConnection = null;
			CAccessControl.__AccessConnection = null;
			CAccessControl.__Server = string.Empty;
			CAccessControl.__Client = string.Empty;
			CAccessControl.__Database = string.Empty;
			CAccessControl.__ReportPath = string.Empty;
			CAccessControl.__UserName_App = string.Empty;
			CAccessControl.__PassWord_App = string.Empty;
			CAccessControl.__UserName = string.Empty;
			CAccessControl.__PassWord = string.Empty;
			CAccessControl.__Port = 0;
			CAccessControl.intEmpNo = -1;
			CAccessControl.prsType = PersonType.PrsNone;
			CAccessControl.DIC = null;
			CAccessControl.dsSL = null;
		}

		public CAccessControl()
		{
		}

		private static bool CheckUser(SystemID sysId, string strUsername, string strPassword)
		{
			byte[] buffer1 = new byte[100];

			try
			{
				string text1 = "Acc_Sp_Sel_IsEx_IsValiID";
				SqlCommand command1 = new SqlCommand(text1, CAccessControl.__AccessConnection);
				command1.CommandType = CommandType.StoredProcedure;
				SqlParameter parameter1 = command1.Parameters.Add("@System", SqlDbType.Int);
				parameter1.Direction = ParameterDirection.Input;
				parameter1.Value = (int) sysId;
				SqlParameter parameter2 = command1.Parameters.Add("@Acc_Fld_UID", SqlDbType.NVarChar);
				parameter2.Direction = ParameterDirection.Input;
				parameter2.Value = strUsername;
				if (CAccessControl.__AccessConnection.State != ConnectionState.Open)
				{
					CAccessControl.__AccessConnection.Open();
				}
				SqlDataReader reader1 = command1.ExecuteReader();
				if (reader1.Read())
				{
					buffer1 = (byte[]) reader1["Acc_Fld_Image"];
					reader1.Close();
					CAccessControl.__AccessConnection.Close();
					string text2 = CUtilities.ConvertByteArrayToString(buffer1);
					if (text2 == strPassword)
					{
						return true;
					}
					return false;
				}
			}
			catch (Exception exception1)
			{
				throw new ApplicationException("ProgLib Error - CAccessControl : " + exception1.Message);
			}
			return false;
		}

		public void Dispose()
		{
			if (CAccessControl.__AccessConnection != null)
			{
				CAccessControl.__AccessConnection.Close();
				CAccessControl.__AccessConnection.Dispose();
			}
			if (CAccessControl.__AppConnection != null)
			{
				CAccessControl.__AppConnection.Close();
				CAccessControl.__AppConnection.Dispose();
			}
			if (CAccessControl.__NewConnection != null)
			{
				CAccessControl.__NewConnection.Close();
				CAccessControl.__NewConnection.Dispose();
			}
		}

		public static CAccessEntry GetAccess(string strFormName, string strObjectName)
		{
			CAccessEntry entry2;
			if (CAccessControl.DIC == null)
			{
				return null;
			}
			CAccessEntry entry1 = new CAccessEntry();
			try
			{
				string text1 = strFormName.ToUpper() + strObjectName.ToUpper();
				entry1 = (CAccessEntry) CAccessControl.DIC[text1];
				entry2 = entry1;
			}
			catch (Exception exception1)
			{
				throw new ApplicationException("ProgLib Error - CAccessControl : " + exception1.Message);
			}
			return entry2;
		}
		
		public static void ConnectionAuthenticate(){
			if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
			{
				CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port);
			}
			else
			{
				CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Username, CAccessControl.Password);
			}
		}

		public static void UserAuthenticate(SystemID sysID, string UserName_App, string PassWord_App)
		{
			CAccessControl.UserAuthenticate(sysID, UserName_App, PassWord_App, true);
		}

		public static void UserAuthenticate(SystemID sysID, string UserName_App, string PassWord_App, bool Refresh)
		{
			try
			{
                
				if (CAccessControl.__AuthenticateType == AuthenticationType.SQL)
				{
					if (CAccessControl.Username == string.Empty)
					{
						throw new Exception("ProgLib Error - CAccessControl : User name not found.");
					}
					if (CAccessControl.Password == string.Empty)
					{
						throw new Exception("ProgLib Error - CAccessControl : Password not found.");
					}
				}
				if (CAccessControl.Server == string.Empty)
				{
					throw new Exception("ProgLib Error - CAccessControl : Server name not found.");
				}
				if (CAccessControl.Client == string.Empty)
				{
					throw new Exception("ProgLib Error - CAccessControl : Client name not found.");
				}
				if (CAccessControl.Database == string.Empty)
				{
					throw new Exception("ProgLib Error - CAccessControl : Database name not found.");
				}
				if ((UserName_App.Length > 0x18) || (PassWord_App.Length > 0x18))
				{
					throw new Exception("ProgLib Error - CAccessControl : Max lenght of Username and Password is 24 character.");
				}
				if (((UserName_App.IndexOf(',', 0) != -1) || (UserName_App.IndexOf(';', 0) != -1)) || ((PassWord_App.IndexOf(',', 0) != -1) || (PassWord_App.IndexOf(';', 0) != -1)))
				{
					throw new Exception("ProgLib Error - CAccessControl : , and ; is not correct characters for Username and Password.");
				}
				if ((CAccessControl.__AccessConnection == null) || (CAccessControl.__AccessConnection.ConnectionString == string.Empty))
				{
					if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
					{
						CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port);
					}
					else
					{
						CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Username, CAccessControl.Password);
					}
				}
				else if (Refresh)
				{
					CAccessControl.__AccessConnection.Close();
					CAccessControl.__AccessConnection.Dispose();
					CAccessControl.__AccessConnection = null;
					if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
					{
						CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port);
					}
					else
					{
						CAccessControl.__AccessConnection = CConnectionPooling.GetAccessConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Username, CAccessControl.Password);
					}
				}
                 
//				string str=  CAccessControl.__AccessConnection.ConnectionString;

				if (CAccessControl.__AccessConnection.State != ConnectionState.Open)
				{
					CAccessControl.__AccessConnection.Open();
				}
				
              

                
                if (!CAccessControl.CheckUser(sysID, UserName_App, PassWord_App))
				{
					throw new Exception("ProgLib Error - CAccessControl : Username or Password is not valid.");
				}
                
				
                CAccessControl.intEmpNo = CAccessControl.GetEmployeeNo(sysID, UserName_App);
				CAccessControl.__UserName_App = UserName_App;
				CAccessControl.__PassWord_App = PassWord_App;

              
				if ((CAccessControl.__AppConnection == null) || (CAccessControl.__AppConnection.ConnectionString == string.Empty))
				{
					if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
					{
						CAccessControl.__AppConnection = CConnectionPooling.GetApplicationConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database);
					}
					else
					{
						//CAccessControl.__AppConnection = CConnectionPooling.GetApplicationConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database, CAccessControl.Username, CAccessControl.Password);
                        CAccessControl.__AppConnection = CConnectionPooling.GetApplicationConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database, CAccessControl.Username, CAccessControl.Password);
					}
				}
				else
				{
					if (!Refresh)
					{
						return;
					}
					CAccessControl.__AppConnection.Close();
					CAccessControl.__AppConnection.Dispose();
					CAccessControl.__AppConnection = null;
					if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
					{
						CAccessControl.__AppConnection = CConnectionPooling.GetApplicationConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database);
					}
					else
					{
						CAccessControl.__AppConnection = CConnectionPooling.GetApplicationConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database, CAccessControl.Username, CAccessControl.Password);
					}
				}
                 
			}
			catch (Exception exception1)
			{
				throw new Exception("ProgLib Error - CAccessControl : " + exception1.Message);
			}
		}

		private static int GetEmployeeNo(SystemID ID, string strCurrentUser)
		{
			int num1;
			try
			{
				string text1 = "Acc_Sp_Sel_IsEx_User";
				SqlCommand command1 = new SqlCommand(text1, CAccessControl.__AccessConnection);
				command1.CommandType = CommandType.StoredProcedure;
				SqlParameter parameter1 = command1.Parameters.Add("@Acc_Fld_fk_System", SqlDbType.Int);
				parameter1.Direction = ParameterDirection.Input;
				parameter1.Value = (int) ID;
				SqlParameter parameter2 = command1.Parameters.Add("@Acc_Fld_UID", SqlDbType.NVarChar);
				parameter2.Direction = ParameterDirection.Input;
				parameter2.Value = strCurrentUser;
				if (CAccessControl.__AccessConnection.State != ConnectionState.Open)
				{
					CAccessControl.__AccessConnection.Open();
				}
				SqlDataReader reader1 = command1.ExecuteReader();
				CAccessControl.intEmpNo = -1;
				if (reader1.Read())
				{
					CAccessControl.intEmpNo = Convert.ToInt32(reader1["Acc_Fld_fk_UniqueCode"].ToString());
				}
				reader1.Close();
				CAccessControl.__AccessConnection.Close();
				num1 = CAccessControl.intEmpNo;
			}
			catch (Exception exception1)
			{
				throw new ApplicationException("ProgLib Error - CAccessControl : " + exception1.Message);
			}
			return num1;
		}
 
		// Properties
		public static AuthenticationType AuthenticateType
		{
			get
			{
				return CAccessControl.__AuthenticateType;
			}
			set
			{
				CAccessControl.__AuthenticateType = value;
			}
		}

		public static string ConnectionType
		{
			get
			{
				return CAccessControl.__ConnectionType;
			}
			set
			{
				CAccessControl.__ConnectionType = value;
			}
		}

		public static string Client
		{
			get
			{
				return CAccessControl.__Client;
			}
			set
			{
				CAccessControl.__Client = value;
			}
		}

		public static SqlConnection Connection
		{
			get
			{
				return CAccessControl.__AppConnection;
			}
		}

		public static int ConnectionTimeout
		{
			get
			{
				return CAccessControl.__AppConnection.ConnectionTimeout;
			}
			set
			{
				if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
				{
					CConnectionPooling.ChangeConnectionTimeout(CAccessControl.Server, CAccessControl.Database, value);
				}
				else
				{
					CConnectionPooling.ChangeConnectionTimeout(CAccessControl.Server, CAccessControl.Database, CAccessControl.Username, CAccessControl.Password, value);
				}
			}
		}

		public static string Database
		{
			get
			{
				return CAccessControl.__Database;
			}
			set
			{
				CAccessControl.__Database = value;
			}
		}

		public static int intEmployeeNo
		{
			get
			{
				if (CAccessControl.intEmpNo == -1)
				{
					throw new Exception("ProgLib Error - CAccessControl : You must using GetAccessLevel method from first of Application.");
				}
				return CAccessControl.intEmpNo;
			}
		}

		public static SqlConnection NewConnection
		{
			get
			{
				if (CAccessControl.__NewConnection == null)
				{
					if (CAccessControl.__AuthenticateType == AuthenticationType.WIN)
					{
						CAccessControl.__NewConnection = CConnectionPooling.GetConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database);
					}
					else
					{
						CAccessControl.__NewConnection = CConnectionPooling.GetConnection(CAccessControl.Server, CAccessControl.Port, CAccessControl.Database, CAccessControl.Username, CAccessControl.Password);
					}
				}
				return CAccessControl.__NewConnection;
			}
		}
 

		public static string Password
		{
			get
			{
				return CAccessControl.__PassWord;
			}
			set
			{
				CAccessControl.__PassWord = value;
			}
		}

		public static string Password_App
		{
			get
			{
				return CAccessControl.__PassWord_App;
			}
		}

		public static PersonType PersonelType
		{
			get
			{
				if (CAccessControl.prsType == PersonType.PrsNone)
				{
					throw new Exception("ProgLib Error - CAccessControl : You must using UserAuthenticate method from first of Application.");
				}
				return CAccessControl.prsType;
			}
		}

		public static int Port
		{
			get
			{
				return CAccessControl.__Port;
			}
			set
			{
				CAccessControl.__Port = value;
			}
		}


		public static string ReportPath
		{
			get
			{
				return CAccessControl.__ReportPath;
			}
			set
			{
				CAccessControl.__ReportPath = value;
			}
		}

		public static string Server
		{
			get
			{
				return CAccessControl.__Server;
			}
			set
			{
				CAccessControl.__Server = value;
			}
		}

		public static DataSet ServiceLocatiocs
		{
			get
			{
				if (CAccessControl.dsSL == null)
				{
					throw new Exception("ProgLib Error - CAccessControl : You must using GetAccessLevel method from first of Application.");
				}
				return CAccessControl.dsSL;
			}
		}

		public static string Username
		{
			get
			{
				return CAccessControl.__UserName;
			}
			set
			{
				CAccessControl.__UserName = value;
			}
		}

		public static string Username_App
		{
			get
			{
				return CAccessControl.__UserName_App;
			}
		}


		
	}


	public class CAccessEntry
	{
		// Fields
		private bool bEnable;
		private bool bVisible;
		private string FrmName;
		private string objName;

		// Methods
		public CAccessEntry()
		{
		}


		// Properties
		public bool Enable
		{
			get
			{
				return this.bEnable;
			}
			set
			{
				this.bEnable = value;
			}
		}

		public string FormName
		{
			get
			{
				return this.FrmName;
			}
			set
			{
				this.FrmName = value;
			}
		}

		public string ObjectName
		{
			get
			{
				return this.objName;
			}
			set
			{
				this.objName = value;
			}
		}

		public bool Visible
		{
			get
			{
				return this.bVisible;
			}
			set
			{
				this.bVisible = value;
			}
		}


		
	}


	internal class CConnectionPooling
	{
		// Fields
		private static SqlConnection ocAccessConnection;
		private static SqlConnection ocApplicationConnection;

		// Methods
		static CConnectionPooling()
		{
			CConnectionPooling.ocAccessConnection = null;
			CConnectionPooling.ocApplicationConnection = null;
		}
 

		private CConnectionPooling()
		{
		}
 

		public static void ChangeConnectionTimeout(string Server, string Database, int Timeout)
		{
			try
			{
				string text1;
				string[] textArray1;
				if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
				{
					//textArray1 = new string[8] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; Integrated Security = SSPI; Connect Timeout = ", Timeout.ToString() } ;
					textArray1 = new string[8] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + "; Connect Timeout = ", Timeout.ToString() } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
				else
				{
					if (CConnectionPooling.ocApplicationConnection.State != ConnectionState.Closed)
					{
						CConnectionPooling.ocApplicationConnection.Close();
					}
					CConnectionPooling.ocApplicationConnection = null;
					textArray1 = new string[8] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + "; Connect Timeout = ", Timeout.ToString() } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
		}

		public static SqlConnection ChangeConnectionTimeout(string Server, string Database, string UserId, string Password, int Timeout)
		{
			try
			{
				string text1;
				string[] textArray1;
				if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
				{
					textArray1 = new string[12] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password, "; Connect Timeout = ", Timeout.ToString() } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
				else
				{
					if (CConnectionPooling.ocApplicationConnection.State != ConnectionState.Closed)
					{
						CConnectionPooling.ocApplicationConnection.Close();
					}
					CConnectionPooling.ocApplicationConnection = null;
					textArray1 = new string[12] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password, "; Connect Timeout = ", Timeout.ToString() } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return CConnectionPooling.ocApplicationConnection;
		}

		public static void CloseAccessConnection()
		{
			CConnectionPooling.ocAccessConnection.Close();
		}

		public static void CloseApplicationConnection()
		{
			CConnectionPooling.ocApplicationConnection.Close();
		}

		public static SqlConnection GetAccessConnection(string Server)
		{
			return CConnectionPooling.GetAccessConnection(Server, 0);
		}

		public static SqlConnection GetAccessConnection(string Server, int Port)
		{
			try
			{
				string text1;
				string[] textArray1;
				if (Port > 0)
				{
					if ((CConnectionPooling.ocAccessConnection == null) || (CConnectionPooling.ocAccessConnection.ConnectionString == string.Empty))
					{
						textArray1 = new string[9] { "Server = ", Server, ",", Port.ToString(), " ; Network Library = DBMSSOCN; initial catalog =" ,CAccessControl.Database ,"; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + "; " } ;
						text1 = string.Concat(textArray1);
						CConnectionPooling.ocAccessConnection = new SqlConnection(text1);
					}
				}
				else if ((CConnectionPooling.ocAccessConnection == null) || (CConnectionPooling.ocAccessConnection.ConnectionString == string.Empty))
				{
					textArray1 = new string[7] { "Server = ", Server, " ;initial catalog = " ,CAccessControl.Database ,"; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + "; " } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocAccessConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return CConnectionPooling.ocAccessConnection;
		}

		public static SqlConnection GetAccessConnection(string Server, string UserId, string Password)
		{
			return CConnectionPooling.GetAccessConnection(Server, 0, UserId, Password);
		}

		public static SqlConnection GetAccessConnection(string Server, int Port, string UserId, string Password)
		{
			try
			{
				string text1;
				string[] textArray1;
				if (Port > 0)
				{
					if ((CConnectionPooling.ocAccessConnection == null) || (CConnectionPooling.ocAccessConnection.ConnectionString == string.Empty))
					{
						textArray1 = new string[12] { "Data Source = ", Server, ",", Port.ToString(), " ;Network Library = DBMSSOCN; initial catalog = " ,CAccessControl.Database ,"; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
						text1 = string.Concat(textArray1);
						CConnectionPooling.ocAccessConnection = new SqlConnection(text1);
					}
				}
				else if ((CConnectionPooling.ocAccessConnection == null) || (CConnectionPooling.ocAccessConnection.ConnectionString == string.Empty))
				{
					textArray1 = new string[10] { "Data Source = ", Server, " ;initial catalog = " ,CAccessControl.Database ,"; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocAccessConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return CConnectionPooling.ocAccessConnection;
		}

		public static SqlConnection GetApplicationConnection(string Server, string Database)
		{
			return CConnectionPooling.GetApplicationConnection(Server, 0, Database);
		}

		public static SqlConnection GetApplicationConnection(string Server, int Port, string Database)
		{
			try
			{
				string text1;
				string[] textArray1;
				if (Port > 0)
				{
					if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
					{
						textArray1 = new string[9] { "Server = ", Server, ",", Port.ToString(), " ; Network Library = DBMSSOCN; initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + ";" } ;
						text1 = string.Concat(textArray1);
						CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
					}
				}
				else if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
				{
					textArray1 = new string[7] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + ";" } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return CConnectionPooling.ocApplicationConnection;
		}

		public static SqlConnection GetApplicationConnection(string Server, string Database, string UserId, string Password)
		{
			return CConnectionPooling.GetApplicationConnection(Server, 0, Database, UserId, Password);
		}

		public static SqlConnection GetApplicationConnection(string Server, int Port, string Database, string UserId, string Password)
		{
			try
			{
				string text1;
				string[] textArray1;

				if (Port > 0)
				{
					if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
					{
						textArray1 = new string[12] { "Server = ", Server, ",", Port.ToString(), " ; Network Library = DBMSSOCN; initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
						text1 = string.Concat(textArray1);
						CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
					}
				}
				else if ((CConnectionPooling.ocApplicationConnection == null) || (CConnectionPooling.ocApplicationConnection.ConnectionString == string.Empty))
				{
					textArray1 = new string[10] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
					text1 = string.Concat(textArray1);
					CConnectionPooling.ocApplicationConnection = new SqlConnection(text1);
				}
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return CConnectionPooling.ocApplicationConnection;
		}

		public static SqlConnection GetConnection(string Server, string Database)
		{
			return CConnectionPooling.GetConnection(Server, 0, Database);
		}

		public static SqlConnection GetConnection(string Server, int Port, string Database)
		{
			SqlConnection connection1;
			try
			{
				string text1;
				string[] textArray1;
				if (Port > 0)
				{
					textArray1 = new string[9] { "Server = ", Server, ",", Port.ToString(), " ; Network Library = DBMSSOCN; initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + ";" } ;
					text1 = string.Concat(textArray1);
					return new SqlConnection(text1);
				}
				textArray1 = new string[7] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; user id = " + CAccessControl.Username +"; password = " + CAccessControl.Password + ";" } ;
				text1 = string.Concat(textArray1);
				connection1 = new SqlConnection(text1);
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return connection1;
		}
 

		public static SqlConnection GetConnection(string Server, string Database, string UserId, string Password)
		{
			return CConnectionPooling.GetConnection(Server, 0, Database, UserId, Password);
		}

		public static SqlConnection GetConnection(string Server, int Port, string Database, string UserId, string Password)
		{
			SqlConnection connection1;
			try
			{
				string text1;
				string[] textArray1;
				if (Port > 0)
				{
					textArray1 = new string[12] { "Server = ", Server, ",", Port.ToString(), " ; Network Library = DBMSSCON; initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
					text1 = string.Concat(textArray1);
					return new SqlConnection(text1);
				}
				textArray1 = new string[10] { "Server = ", Server, " ;initial catalog = ", Database, " ; Workstation id= ", Environment.MachineName, "; User ID = ", UserId, ";Password = ", Password } ;
				text1 = string.Concat(textArray1);
				connection1 = new SqlConnection(text1);
			}
			catch (Exception exception1)
			{
				throw exception1;
			}
			return connection1;
		}


		
	}


	
}

