using System;

namespace RWAS.WinUI
{
	/// <summary>
	/// Summary description for Items.
	/// </summary>
	public class Item
	{

		private string _Value="";
		public string Value 
		{
			get 
			{
				return _Value;
			}
			set 
			{
				_Value = value;
			}
		}

		private string _Id="";
		public string ID 
		{
			get 
			{
				return _Id;
			}
			set 
			{
				_Id = value;
			}
		}
		public Item(string strValue,string strId)
		{
			this._Id = strId;
			this._Value = strValue;
		}
	}
}
