using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;

namespace layerBusiness
{
    public class Customer
    {
        #region public

        public static SqlCeResultSet GetAllCustomer(string myFilter)
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSet("pdMoshtari", "*", myFilter, "");

            return objSqlceResultset;

        }


        public static SqlCeResultSet GetAllMasir()
        {
            SqlCeResultSet objSqlceResultset = null;
            string strQuery = "select distinct masirno, masirno as masirds from pdmoshtari where masirno is not null"
        + " union "
        + " select '0','همه' ";

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);

            return objSqlceResultset;

        }

        #endregion

        #region Metod

        public void FetchMoshtari(decimal mymoshtariinfosn)
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nMoshtariInfosn = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdMoshtari", "*", "moshtariinfosn=" + mymoshtariinfosn.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();

                    m_nMoshtariInfosn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("moshtariinfosn"));
                    m_strMoshtarids = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarids"));
                    m_strMoshtarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarino"));
                    m_strMasirno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("masirno"));
                    m_nKanaleforooshsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kanaleforooshsn"));
                    m_nMoshtariStatus = objSqlceResultset.GetByte(objSqlceResultset.GetOrdinal("moshtaristatus"));
                    m_strTel = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("tel"));
                    m_strMobilePhone = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("mobilephone"));
                    m_strAddress = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("address"));
                    m_nMandehEtebar = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehetebar"));
                    m_nMandehMoavagh = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehmoavagh"));
                    m_nMandehAsnadi = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehasnadi"));
                    m_nMandehBargashti = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehbargashti"));
                    m_nCountMoavagh = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("countmoavagh"));
                    m_nCountBargashti = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("countbargashti"));

                }

                else
                    m_nMoshtariInfosn = -1;
            }
            catch (Exception ex)
            {
            }

        }

        public void FetchMoshtariByMoshtariNo(string moshtarino)
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nMoshtariInfosn = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdMoshtari", "*", "moshtarino=" + moshtarino, "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nMoshtariInfosn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("moshtariinfosn"));
                    m_strMoshtarids = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarids"));
                    m_strMoshtarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarino"));
                    m_strMasirno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("masirno"));
                    m_nKanaleforooshsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kanaleforooshsn"));
                    m_nMoshtariStatus = objSqlceResultset.GetByte(objSqlceResultset.GetOrdinal("moshtaristatus"));
                    m_strTel = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("tel"));
                    m_strMobilePhone = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("mobilephone"));
                    m_strAddress = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("address"));
                    m_nMandehEtebar = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehetebar"));
                    m_nMandehMoavagh = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehmoavagh"));
                    m_nMandehAsnadi = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehasnadi"));
                    m_nMandehBargashti = objSqlceResultset.GetInt64(objSqlceResultset.GetOrdinal("mandehbargashti"));
                    m_nCountMoavagh = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("countmoavagh"));
                    m_nCountBargashti = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("countbargashti"));

                }

                else
                    m_nMoshtariInfosn = -1;
            }
            catch (Exception ex)
            {                
            }

        }

        #endregion

        #region Property

        public decimal MoshtariInfosn
        {
            get
            {
                return (m_nMoshtariInfosn);
            }

            set
            {
                m_nMoshtariInfosn = value;
            }
        }

        public string Moshtarids
        {
            get
            {
                return (m_strMoshtarids);
            }

            set
            {
                m_strMoshtarids = value;
            }
        }

        public string Moshtarino
        {
            get
            {
                return (m_strMoshtarino);
            }

            set
            {
                m_strMoshtarino = value;
            }
        }

        public string Masirno
        {
            get
            {
                return (m_strMasirno);
            }

            set
            {
                m_strMasirno = value;
            }
        }

        public decimal KanaleForooshsn
        {
            get
            {
                return (m_nKanaleforooshsn);
            }

            set
            {
                m_nKanaleforooshsn = value;
            }
        }

        public string Tel
        {
            get
            {
                return (m_strTel);
            }

            set
            {
                m_strTel = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return (m_strMobilePhone);
            }

            set
            {
                m_strMobilePhone = value;
            }
        }

        public string Address
        {
            get
            {
                return (m_strAddress);
            }

            set
            {
                m_strAddress = value;
            }
        }

        public long MandehEtebar
        {
            get
            {
                return (m_nMandehEtebar);
            }

            set
            {
                m_nMandehEtebar = value;
            }
        }

        public long MandehMoavagh
        {
            get
            {
                return (m_nMandehMoavagh);
            }

            set
            {
                m_nMandehMoavagh = value;
            }
        }

        public long MandehAsnadi
        {
            get
            {
                return (m_nMandehAsnadi);
            }

            set
            {
                m_nMandehAsnadi = value;
            }
        }

        public long MandehBargashti
        {
            get
            {
                return (m_nMandehBargashti);
            }

            set
            {
                m_nMandehBargashti = value;
            }
        }

        public byte MoshtariStatus
        {
            get
            {
                return (m_nMoshtariStatus);
            }

            set
            {
                m_nMoshtariStatus = value;
            }
        }

        public int CountMoavagh
        {
            get
            {
                return (m_nCountMoavagh);
            }

            set
            {
                m_nCountMoavagh = value;
            }
        }

        public int CountBargashti
        {
            get
            {
                return (m_nCountBargashti);
            }

            set
            {
                m_nCountBargashti = value;
            }
        }
        
        #endregion

        #region Private

        private decimal m_nMoshtariInfosn;
        private string m_strMoshtarids;
        private string m_strMoshtarino;
        private string m_strMasirno;
        private decimal m_nKanaleforooshsn;
        private byte m_nMoshtariStatus;
        private string m_strAddress;
        private string m_strTel;
        private string m_strMobilePhone;
        private long m_nMandehEtebar;
        private long m_nMandehMoavagh;
        private long m_nMandehAsnadi;
        private long m_nMandehBargashti;
        private int m_nCountMoavagh;
        private int m_nCountBargashti;

        #endregion
    }
}
