using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;
using System.Data;

namespace layerBusiness
{
    public class Kala
    {
        #region Public

        public static SqlCeResultSet GetKalaTableResultSet()
        {
            SqlCeResultSet objSqlceResultset = null;
            SqlCeCommand sqlCeSelectCommand = null;

            sqlCeSelectCommand = dpDataAccess.m_mySqlCeConnection.CreateCommand();
            sqlCeSelectCommand.CommandType = System.Data.CommandType.TableDirect;
            sqlCeSelectCommand.CommandText = "pdKala";
            sqlCeSelectCommand.IndexName = "ix_forooshcode";

            objSqlceResultset = sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Scrollable);

            return objSqlceResultset;
        }

        public static SqlCeResultSet GetKalaInfoTableResultSet()
        {
            SqlCeResultSet objSqlceResultset = null;
            SqlCeCommand sqlCeSelectCommand = null;

            sqlCeSelectCommand = dpDataAccess.m_mySqlCeConnection.CreateCommand();
            sqlCeSelectCommand.CommandType = System.Data.CommandType.TableDirect;
            sqlCeSelectCommand.CommandText = "pdKalaInfo";
            sqlCeSelectCommand.IndexName = "PK__pdKalaInfo__0000000000000121";

            objSqlceResultset = sqlCeSelectCommand.ExecuteResultSet(ResultSetOptions.Updatable);

            return objSqlceResultset;
        }


        public static SqlCeResultSet GetAllKala()
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery("select pdkala.kalasn,pdkala.kalads,pdkala.forooshcode,pdkala.imagepath, pdtaminkonandeh.taminkonandehds " 
                + ",pdkalainfo.nerkheforoosh,pdkalainfo.mojoodi,pdkalainfo.nerkhemasraf,pdkalainfo.mindarkhastkala,pdkalainfo.kalastatus,pdkalainfo.vahedesanjeshds " 
                + "from pdkala inner join pdkalainfo on pdkala.kalasn=pdkalainfo.kalasn "
                + "inner join pdtaminkonandeh on pdkala.taminkonandehsn=pdtaminkonandeh.taminkonandehsn order by taminkonandehds,kalads");

            return objSqlceResultset;

        }

        public static SqlCeDataReader GetAllKalaReader()
        {
            SqlCeDataReader dr1 = null;

            dr1 = dpDataAccess.GetReaderOfQuery("select pdkala.kalasn,pdkala.kalads,pdkala.forooshcode,pdkala.imagepath, pdtaminkonandeh.taminkonandehds "
                + ",pdkalainfo.nerkheforoosh,pdkalainfo.mojoodi,pdkalainfo.nerkhemasraf,pdkalainfo.mindarkhastkala,pdkalainfo.kalastatus,pdkalainfo.vahedesanjeshds "
                + "from pdkala inner join pdkalainfo on pdkala.kalasn=pdkalainfo.kalasn "
                + "inner join pdtaminkonandeh on pdkala.taminkonandehsn=pdtaminkonandeh.taminkonandehsn order by taminkonandehds,kalads");
            
            return dr1;

        }

        #endregion

        #region Method

        /*
        public void FetchKalaByForooshcode(int nForooshcode)
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nKalaSN = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdKala", "*", "forooshcode=" + nForooshcode.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nKalaSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kalasn"));
                    m_strKalaDs = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("kalads"));
                    m_nForooshcode = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("forooshcode"));
                    m_strImagePath = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("imagepath"));
                    m_nGorooheKalaSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("goroohekalasn"));
                    m_nTaminKonandehSN = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("taminkonandehsn"));
                }

                else
                    m_nKalaSN = -1;
            }
            catch
            {
            }
        }
         */

        #endregion

        #region Property

        public decimal KalaSN
        {
            get
            {
                return (m_nKalaSN);
            }

            set
            {
                m_nKalaSN = value;
            }
        }

        public string KalaDs
        {
            get
            {
                return (m_strKalaDs);
            }

            set
            {
                m_strKalaDs = value;
            }
        }

        public decimal TaminKonandehSN
        {
            get
            {
                return (m_nTaminKonandehSN);
            }

            set
            {
                m_nTaminKonandehSN = value;
            }
        }

        public int Forooshcode
        {
            get
            {
                return (m_nForooshcode);
            }

            set
            {
                m_nForooshcode = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return (m_strImagePath);
            }

            set
            {
                m_strImagePath = value;
            }
        }

        public decimal GorooheKalaSN
        {
            get
            {
                return (m_nGorooheKalaSN);
            }

            set
            {
                m_nGorooheKalaSN = value;
            }
        }


        #endregion

        #region Private

        private decimal  m_nKalaSN;
        private string m_strKalaDs;
        private decimal m_nTaminKonandehSN;
        private int m_nForooshcode;
        private string m_strImagePath;
        private decimal m_nGorooheKalaSN;

        #endregion
    }
}
