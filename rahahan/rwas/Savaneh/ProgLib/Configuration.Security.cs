using System;

namespace ProgLib.Configuration.Security
{
	public class CSecurityManager
	{
		// Methods
		public CSecurityManager()
		{
		}

		public static string GetSSLCode()
		{
			Guid guid1 = Guid.NewGuid();
			return guid1.ToString();
		}
 

	}
}


