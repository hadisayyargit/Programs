using System;
using System.Data;
using System.Data.SqlClient;

namespace ProgLib
{
	public class ProgLibException : Exception
	{
		// Properties
		public string Class
		{
			get
			{
				return this.__Class;
			}
		}

		public override string Message
		{
			get
			{
				return this.__Message;
			}
		}

		public ErrorType Type
		{
			get
			{
				return this.__Type;
			}
		}


		// Fields
		private string __Class;
		private string __Message;
		private ErrorType __Type;

		// Methods
		public ProgLibException(ErrorType type)
		{
			this.__Class = "UnKnown";
			this.__Message = "ProgLib Error";
			this.__Type = ErrorType.UnKnown;
			this.__Message = this.GetError(type);
			this.__Type = type;
		}

		public ProgLibException(string strMessage)
		{
			this.__Class = "UnKnown";
			this.__Message = "ProgLib Error";
			this.__Type = ErrorType.UnKnown;
			this.__Message = strMessage;
		}
 

		public ProgLibException(Exception ocException, string strClass)
		{
			this.__Class = "UnKnown";
			this.__Message = "ProgLib Error";
			this.__Type = ErrorType.UnKnown;
			this.__Message = this.GetError(ocException);
			this.__Class = strClass;
		}

		private string GetError(ErrorType type)
		{
			string text1 = string.Empty;
			switch (type)
			{
				case ErrorType.AE_CDate_01:
				{
					text1 = "Valid values are between -120000 and 120000, inclusive.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_02:
				{
					text1 = "The resulting DateTime is outside the supported range.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_03:
				{
					text1 = "Specified time is not supported in this calendar. It should be between 12:00:00 AM, 1/01/0001 AP and 11:59:59 PM, 12/10/9378 AP, inclusive.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_04:
				{
					text1 = "Valid values for year to be converted are between 0 and 9378, inclusive.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_05:
				{
					text1 = "Valid values are between 100 and 9378, inclusive.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_06:
				{
					text1 = "Era value was not valid.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_07:
				{
					text1 = "Values for month must be between 1 and 12.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_08:
				{
					text1 = "Day must be at most 29 for month 12 of this year.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_09:
				{
					text1 = "Day must be between 1 and 31.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CDate_10:
				{
					text1 = "Date string is not valid";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CLanguage_01:
				{
					text1 = "Input language not instaled in your system.";
					this.__Class = "Proglib.Classes.CDate";
					return text1;
				}
				case ErrorType.AE_CLicence_01:
				{
					text1 = "Licence Check CR101";
					this.__Class = "Proglib.Classes.CLicence";
					return text1;
				}
				case ErrorType.AE_CLicence_02:
				{
					text1 = "Licence Check CR102";
					this.__Class = "Proglib.Classes.CLicence";
					return text1;
				}
				case ErrorType.AE_CLicence_03:
				{
					text1 = "Licence Check CR103";
					this.__Class = "Proglib.Classes.CLicence";
					return text1;
				}
				case ErrorType.AE_CLicence_04:
				{
					text1 = "An error happened in your application";
					this.__Class = "UnKnown";
					return text1;
				}
				case ErrorType.AE_CLicence_05:
				{
					text1 = "An error found in your system memory.";
					this.__Class = "UnKnown";
					return text1;
				}
			}
			return "ProgLib Error";
		}

		private string GetError(Exception ocException)
		{
			string text1 = ocException.Message;
			if (ocException is SqlException)
			{
				int num1 = ((SqlException) ocException).Number;
				if (num1 <= 0x203)
				{
					if (num1 <= 230)
					{
						if ((num1 != 0xc9) && (num1 != 0xd6))
						{
							switch (num1)
							{
								case 0xe5:
								case 230:
								{
									return text1;
								}
							}
						}
						return text1;
					}
					switch (num1)
					{
						case 260:
						case 0x105:
						case 0x106:
						{
							return text1;
						}
						case 0x200:
						{
							return text1;
						}
						case 0x203:
						{
							return text1;
						}
					}
					return text1;
				}
				if (num1 <= 0xafc)
				{
					if (((num1 == 0x223) || (num1 == 0xa43)) || (num1 == 0xafc))
					{
					}
					return text1;
				}
				if (num1 != 0x1fb2)
				{
					switch (num1)
					{
						case 0x1fd0:
						case 0x1fd1:
						{
							return text1;
						}
						case 15210:
						{
							return text1;
						}
					}
				}
				return text1;
			}
			if ((!(ocException is FormatException) && !(ocException is NullReferenceException)) && (!(ocException is ArgumentOutOfRangeException) && !(ocException is OverflowException)))
			{
				ConstraintException exception1 = ocException as ConstraintException;
			}
			return text1;
		}

		public override string ToString()
		{
			string[] textArray1 = new string[1] { this.Message + Environment.NewLine + base.ToString() } ;
			return string.Concat(textArray1);
		}
 



	}

	public enum ErrorType
	{
		// Fields
		AE_CDate_01 = 0,
		AE_CDate_02 = 1,
		AE_CDate_03 = 2,
		AE_CDate_04 = 3,
		AE_CDate_05 = 4,
		AE_CDate_06 = 5,
		AE_CDate_07 = 6,
		AE_CDate_08 = 7,
		AE_CDate_09 = 8,
		AE_CDate_10 = 9,
		AE_CLanguage_01 = 10,
		AE_CLicence_01 = 11,
		AE_CLicence_02 = 12,
		AE_CLicence_03 = 13,
		AE_CLicence_04 = 14,
		AE_CLicence_05 = 15,
		UnKnown = 0x10
	}
}

