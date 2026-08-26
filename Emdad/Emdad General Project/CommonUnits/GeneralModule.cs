using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CommonUnits
{
    public class GeneralModule
    {
        public static SqlConnection m_Total85Connection = new SqlConnection();

        public static int m_val = 24;

        public enum RemoteDataType
        {
            Nullification = 1
            , Inverse = 2
        }

    }
}
