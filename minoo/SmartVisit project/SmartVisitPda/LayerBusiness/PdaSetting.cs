using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;

namespace layerBusiness
{
    public class PdaSetting
    {
        #region Method

        public void FetchSetting()
        {
            SqlCeResultSet objSqlceResultset = null;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdSetting", "*", "", "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nLastSerial = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("LastSerial"));
                    m_nLastSerialMarjoo = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("LastSerialMarjoo"));
                    m_strServerIP = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("ServerIP"));
                    m_strSmsPhone = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("SmsPhone"));
                    m_strSim = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("Sim"));
                }

            }
            catch
            {
            }
        }

        public void dbInsert()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[5];

            try
            {
                strQuery = "delete pdSetting";

                dpDataAccess.ExecuteNonQuery(strQuery);
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                strQuery = "Insert Into pdSetting(lastserial,lastserialmarjoo,serverip,smsphone,sim)"
                    + " Values(@lastserial,@lastserialmarjoo,@serverip,@smsphone,@sim)";

                objSqlCeParameters[0] = new SqlCeParameter("@lastserial", m_nLastSerial);
                objSqlCeParameters[1] = new SqlCeParameter("@lastserialmarjoo", m_nLastSerialMarjoo);
                objSqlCeParameters[2] = new SqlCeParameter("@serverip", m_strServerIP);
                objSqlCeParameters[3] = new SqlCeParameter("@smsphone", m_strSmsPhone);
                objSqlCeParameters[4] = new SqlCeParameter("@sim", m_strSim);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbUpdateLastSerial()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Update pdSetting Set lastserial=@lastserial";

                objSqlCeParameters[0] = new SqlCeParameter("@lastserial", m_nLastSerial);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        #endregion

        #region Property

        public decimal LastSerial
        {
            get
            {
                return (m_nLastSerial);
            }

            set
            {
                m_nLastSerial = value;
            }
        }

        public decimal LastSerialMarjoo
        {
            get
            {
                return (m_nLastSerialMarjoo);
            }

            set
            {
                m_nLastSerialMarjoo = value;
            }
        }

        public string ServerIP
        {
            get
            {
                return (m_strServerIP);
            }

            set
            {
                m_strServerIP = value;
            }
        }

        public string SmsPhone
        {
            get
            {
                return (m_strSmsPhone);
            }

            set
            {
                m_strSmsPhone = value;
            }
        }

        public string Sim
        {
            get
            {
                return (m_strSim);
            }

            set
            {
                m_strSim = value;
            }
        }

        #endregion

        #region Private

        private decimal m_nLastSerial;
        private decimal m_nLastSerialMarjoo;
        private string m_strServerIP;
        private string m_strSmsPhone;
        private string m_strSim;

        #endregion
    }
}
