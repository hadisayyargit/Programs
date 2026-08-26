using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;
using Common;

namespace layerBusiness
{
    public class Darkhast
    {

        #region Public

        public static SqlCeResultSet GetDarkhast()
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery("select pddarkhast.darkhastsn,pddarkhast.darkhastdate, pddarkhast.Moshtariinfosn, pdmoshtari.moshtarids,pdmoshtari.moshtarino,pddarkhast.darkhaststatus, pdPacketStatus.packetstatusds from "
                    +" pdDarkhast left join pdmoshtari on pddarkhast.Moshtariinfosn=pdmoshtari.Moshtariinfosn"
                    +" inner join pdPacketStatus on pddarkhast.darkhaststatus=pdPacketStatus.packetstatussn");

            return objSqlceResultset;

        }

        public static SqlCeResultSet GetNotSendedDarkhast()
        {
            SqlCeResultSet objSqlceResultset = null;

            string strQuery = "select * from  pddarkhast "
                + " Where pdDarkhast.darkhaststatus=" + ((byte)MainCommon.PacketStatus.New).ToString();

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);

            return objSqlceResultset;

        }

        public static SqlCeResultSet GetNotSendedMarjoo()
        {
            SqlCeResultSet objSqlceResultset = null;

            string strQuery = "select * from pdDarkhastMarjoo"
                + " Where pdDarkhastMarjoo.darkhastmarjoostatus=" + ((byte)MainCommon.PacketStatus.New).ToString();

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);

            return objSqlceResultset;

        }
        
        public static SqlCeResultSet GetDarkhastMarjoo()
        {
            SqlCeResultSet objSqlceResultset = null;

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery("select pdDarkhastMarjoo.darkhastmarjoosn,pdDarkhastMarjoo.darkhastmarjoodate, pdDarkhastMarjoo.Moshtariinfosn, pdmoshtari.moshtarids,pdmoshtari.moshtarino,pdDarkhastMarjoo.darkhastmarjoostatus,pdPacketStatus.packetstatusds from "
                    + " pdDarkhastMarjoo left join pdmoshtari on pdDarkhastMarjoo.moshtariinfosn=pdmoshtari.Moshtariinfosn"
                    + " inner join pdPacketStatus on pdDarkhastMarjoo.darkhastmarjoostatus=pdPacketStatus.packetstatussn");

            return objSqlceResultset;

        }

        public static decimal GetLastDarkhastSN()
        {
            decimal nResult = 0;
            //object objRes = dpDataAccess.GetFieldValue("pdDarkhast", "Max(darkhastsn)", "");
            object objRes = dpDataAccess.GetFieldValue("pdSetting", "lastserial", "");

            if (objRes != DBNull.Value)
                nResult = Convert.ToDecimal(objRes);

            return nResult;
        }

        public static int GetCountOfDarkhast(string strDate)
        {
            int nResult = 0;
            object objRes = dpDataAccess.GetFieldValue("pdDarkhast", "Count(darkhastsn)", "darkhastdate='"+strDate+"'");

            if (objRes != DBNull.Value)
                nResult = Convert.ToInt32(objRes);

            return nResult;
        }

        public static int GetCountOfMarjoo(string strDate)
        {
            int nResult = 0;
            object objRes = dpDataAccess.GetFieldValue("pdDarkhastMarjoo", "Count(darkhastmarjoosn)", "darkhastmarjoodate='" + strDate + "'");

            if (objRes != DBNull.Value)
                nResult = Convert.ToInt32(objRes);

            return nResult;
        }

        public static decimal GetLastMarjooSN()
        {
            decimal nResult = 0;
            //object objRes = dpDataAccess.GetFieldValue("pdDarkhastMarjoo", "Max(darkhastmarjoosn)", "");
            object objRes = dpDataAccess.GetFieldValue("pdSetting", "lastserialmarjoo", "");

            if (objRes!=DBNull.Value)
                nResult = Convert.ToDecimal(objRes);

            return nResult;
        }

        #endregion

        #region Method

        public void FetchDarkhast()
        {
            SqlCeResultSet objSqlceResultset = null;
            

            try
            {
                string strQuery = "select pddarkhast.*, pduser.userno, pdvahedetejari.vahedetejarino, pdmoshtari.moshtarino, pdmoshtari.moshtarids, pdkanaleforoosh.kanaleforooshno, pdNoeTahvil.noetahvilno from "
                    + " pddarkhast inner join pdvisitor on pddarkhast.visitorsn=pdvisitor.visitorsn"
                    + " inner join pduser on pdvisitor.usersn=pduser.usersn"
                    + " inner join pdvahedetejari on pddarkhast.vahedetejarisn=pdvahedetejari.vahedetejarisn"
                    + " inner join pdmoshtari on pddarkhast.moshtariinfosn=pdmoshtari.moshtariinfosn"
                    + " inner join pdkanaleforoosh on pddarkhast.kanaleforooshsn=pdkanaleforoosh.kanaleforooshsn "
                    + " inner join pdNoeTahvil on pddarkhast.noetahvilsn=pdNoeTahvil.noetahvilsn"
                    + " Where darkhastsn=" + m_nDarkhastsn.ToString();

                objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);


                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nMoshtariinfosn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Moshtariinfosn"));
                    m_nVisitorsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Visitorsn"));
                    m_nNoeTahvilsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("NoeTahvilsn"));
                    m_nNoePardakhtsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("NoePardakhtsn"));
                    m_strDarkhastDate = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("DarkhastDate"));
                    m_nModatVosool = objSqlceResultset.GetInt16(objSqlceResultset.GetOrdinal("modatvosool"));
                    m_nVahedeTejarisn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("vahedetejarisn"));
                    m_nKanaleForooshsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kanaleforooshsn"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("darkhaststatus")))
                        m_nDarkhastStatus = objSqlceResultset.GetByte(objSqlceResultset.GetOrdinal("darkhaststatus"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("latitude")))
                        m_nLatitude = objSqlceResultset.GetFloat(objSqlceResultset.GetOrdinal("latitude"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("longitude")))
                        m_nLongitude = objSqlceResultset.GetFloat(objSqlceResultset.GetOrdinal("longitude"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("exectimestart")))
                        m_dtmExecTimeStart = objSqlceResultset.GetDateTime(objSqlceResultset.GetOrdinal("exectimestart"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("exectimeend")))
                        m_dtmExecTimeEnd = objSqlceResultset.GetDateTime(objSqlceResultset.GetOrdinal("exectimeend"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("userno")))
                        m_Userno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("userno"));
                
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("vahedetejarino")))
                        m_Vahedetejarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("vahedetejarino"));
                    
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("moshtarino")))
                        m_Moshtarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarino"));
                    
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("moshtarids")))
                        m_MoshtariDs = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarids"));
                    
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("kanaleforooshno")))
                        m_Kanaleforooshno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("kanaleforooshno"));
                    
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("noetahvilno")))
                        m_Noetahvilno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("noetahvilno"));
                }

                else
                    m_nDarkhastsn = -1;    
            }

            catch(Exception ex)
            {
                m_nDarkhastsn = -1;
            }

        }

        public void FetchDarkhastMarjoo()
        {
            SqlCeResultSet objSqlceResultset = null;
            

            try
            {
                string strQuery = "select pdDarkhastMarjoo.*, pduser.userno, pdvahedetejari.vahedetejarino, pdmoshtari.moshtarino, pdmoshtari.moshtarids, pdkanaleforoosh.kanaleforooshno from "
    + " pdDarkhastMarjoo inner join pdvisitor on pdDarkhastMarjoo.visitorsn=pdvisitor.visitorsn"
    + " inner join pduser on pdvisitor.usersn=pduser.usersn"
    + " inner join pdvahedetejari on pdDarkhastMarjoo.vahedetejarisn=pdvahedetejari.vahedetejarisn"
    + " inner join pdmoshtari on pdDarkhastMarjoo.moshtariinfosn=pdmoshtari.moshtariinfosn"
    + " inner join pdkanaleforoosh on pdDarkhastMarjoo.kanaleforooshsn=pdkanaleforoosh.kanaleforooshsn "
    + " Where darkhastmarjoosn=" + m_nDarkhastsn.ToString();


                objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nMoshtariinfosn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Moshtariinfosn"));
                    m_nVisitorsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("visitorsn"));
                    m_strDalilMarjoo = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("dalilmarjoo"));
                    m_strFactorMarjoono = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("factormarjoono"));
                    m_strDarkhastDate = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("darkhastmarjoodate"));
                    m_nVahedeTejarisn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("vahedetejarisn"));
                    m_nKanaleForooshsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kanaleforooshsn"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("darkhastmarjoostatus")))
                        m_nDarkhastStatus = objSqlceResultset.GetByte(objSqlceResultset.GetOrdinal("darkhastmarjoostatus"));
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("latitude")))
                        m_nLatitude = objSqlceResultset.GetFloat(objSqlceResultset.GetOrdinal("latitude"));
                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("longitude")))
                        m_nLongitude = objSqlceResultset.GetFloat(objSqlceResultset.GetOrdinal("longitude"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("exectimestart")))
                        m_dtmExecTimeStart = objSqlceResultset.GetDateTime(objSqlceResultset.GetOrdinal("exectimestart"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("exectimeend")))
                        m_dtmExecTimeEnd = objSqlceResultset.GetDateTime(objSqlceResultset.GetOrdinal("exectimeend"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("userno")))
                        m_Userno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("userno"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("vahedetejarino")))
                        m_Vahedetejarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("vahedetejarino"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("moshtarino")))
                        m_Moshtarino = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarino"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("moshtarids")))
                        m_MoshtariDs = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("moshtarids"));

                    if (!objSqlceResultset.IsDBNull(objSqlceResultset.GetOrdinal("kanaleforooshno")))
                        m_Kanaleforooshno = objSqlceResultset.GetString(objSqlceResultset.GetOrdinal("kanaleforooshno"));
                }

                else
                    m_nDarkhastsn = -1;
            }
            catch (Exception ex)
            {
                m_nDarkhastsn = -1;
            }

        }

        public void dbInsert()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[12];

            try
            {
                strQuery = "Insert Into pdDarkhast(darkhastsn,moshtariinfosn,visitorsn,noetahvilsn,noepardakhtsn,darkhastdate,modatvosool,vahedetejarisn,kanaleforooshsn,latitude,longitude,darkhastStatus)"
                    + "Values(@Darkhastsn,@Moshtariinfosn,@Visitorsn,@NoeTahvilsn,@NoePardakhtsn,@DarkhastDate,@ModatVosool,@Vahedetejarisn,@Kanaleforooshsn,@Latitude,@Longitude,@DarkhastStatus)";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Moshtariinfosn", m_nMoshtariinfosn);
                objSqlCeParameters[2] = new SqlCeParameter("@Visitorsn", m_nVisitorsn);
                objSqlCeParameters[3] = new SqlCeParameter("@NoeTahvilsn", m_nNoeTahvilsn);
                objSqlCeParameters[4] = new SqlCeParameter("@NoePardakhtsn", m_nNoePardakhtsn);
                objSqlCeParameters[5] = new SqlCeParameter("@DarkhastDate", m_strDarkhastDate);
                objSqlCeParameters[6] = new SqlCeParameter("@ModatVosool", m_nModatVosool);
                objSqlCeParameters[7] = new SqlCeParameter("@Vahedetejarisn", m_nVahedeTejarisn);
                objSqlCeParameters[8] = new SqlCeParameter("@Kanaleforooshsn", m_nKanaleForooshsn);
                objSqlCeParameters[9] = new SqlCeParameter("@Latitude", m_nLatitude);
                objSqlCeParameters[10] = new SqlCeParameter("@Longitude", m_nLongitude);
                objSqlCeParameters[11] = new SqlCeParameter("@DarkhastStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);

                strQuery = "Update pdSetting Set lastserial=" + m_nDarkhastsn.ToString();
                dpDataAccess.ExecuteNonQuery(strQuery);
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        
        public void dbUpdate()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[12];

            try
            {
                strQuery = "Update pdDarkhast Set Moshtariinfosn=@Moshtariinfosn,visitorsn=@visitorsn,noetahvilsn=@noetahvilsn,noepardakhtsn=@noepardakhtsn,darkhastdate=@darkhastdate,modatvosool=@ModatVosool,vahedetejarisn=@Vahedetejarisn,kanaleforooshsn=@kanaleforooshsn,latitude=@latitude,longitude=@longitude,darkhaststatus=@DarkhastStatus" +
                " Where darkhastsn=@darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Moshtariinfosn", m_nMoshtariinfosn);
                objSqlCeParameters[2] = new SqlCeParameter("@Visitorsn", m_nVisitorsn);
                objSqlCeParameters[3] = new SqlCeParameter("@NoeTahvilsn", m_nNoeTahvilsn);
                objSqlCeParameters[4] = new SqlCeParameter("@NoePardakhtsn", m_nNoePardakhtsn);
                objSqlCeParameters[5] = new SqlCeParameter("@DarkhastDate", m_strDarkhastDate);
                objSqlCeParameters[6] = new SqlCeParameter("@ModatVosool", m_nModatVosool);
                objSqlCeParameters[7] = new SqlCeParameter("@Vahedetejarisn", m_nVahedeTejarisn);
                objSqlCeParameters[8] = new SqlCeParameter("@Kanaleforooshsn", m_nKanaleForooshsn);
                objSqlCeParameters[9] = new SqlCeParameter("@Latitude", m_nLatitude);
                objSqlCeParameters[10] = new SqlCeParameter("@Longitude", m_nLongitude);
                objSqlCeParameters[11] = new SqlCeParameter("@DarkhastStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbUpdateStatus()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[2];

            try
            {
                strQuery = "Update pdDarkhast Set darkhaststatus=@DarkhastStatus" +
                " Where darkhastsn=@darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@DarkhastStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        
        public void dbDelete()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Delete pdDarkhast Where darkhastsn=@Darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);

                /*
                strQuery = "Update pdSetting Set lastserial= (select max(darkhastsn) from pdDarkhast)";
                dpDataAccess.ExecuteNonQuery(strQuery);
                 */

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbDeleteDetails()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Delete pdDarkhastha Where darkhastsn=@Darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbInsertMarjoo()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[11];

            try
            {
                strQuery = "Insert Into pdDarkhastMarjoo(darkhastmarjoosn,moshtariinfosn,visitorsn,darkhastmarjoodate,dalilmarjoo, factormarjoono,vahedetejarisn,kanaleforooshsn,latitude,longitude,darkhastmarjoostatus)"
                    + "Values(@Darkhastsn,@Moshtariinfosn,@Visitorsn,@DarkhastDate,@dalilmarjoo,@factormarjoono,@Vahedetejarisn,@Kanaleforooshsn,@Latitude,@Longitude,@DarkhastMarjooStatus)";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Moshtariinfosn", m_nMoshtariinfosn);
                objSqlCeParameters[2] = new SqlCeParameter("@Visitorsn", m_nVisitorsn);
                objSqlCeParameters[3] = new SqlCeParameter("@DarkhastDate", m_strDarkhastDate);
                objSqlCeParameters[4] = new SqlCeParameter("@dalilmarjoo", m_strDalilMarjoo);
                objSqlCeParameters[5] = new SqlCeParameter("@factormarjoono", m_strFactorMarjoono);
                objSqlCeParameters[6] = new SqlCeParameter("@Vahedetejarisn", m_nVahedeTejarisn);
                objSqlCeParameters[7] = new SqlCeParameter("@Kanaleforooshsn", m_nKanaleForooshsn);
                objSqlCeParameters[8] = new SqlCeParameter("@Latitude", m_nLatitude);
                objSqlCeParameters[9] = new SqlCeParameter("@Longitude", m_nLongitude);
                objSqlCeParameters[10] = new SqlCeParameter("@DarkhastMarjooStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);

                strQuery = "Update pdSetting Set lastserialmarjoo=" + m_nDarkhastsn.ToString();
                dpDataAccess.ExecuteNonQuery(strQuery);

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public void dbUpdateMarjoo()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[11];

            try
            {
                strQuery = "Update pdDarkhastMarjoo Set Moshtariinfosn=@Moshtariinfosn,visitorsn=@visitorsn,dalilmarjoo=@dalilmarjoo,factormarjoono=@factormarjoono,darkhastmarjoodate=@darkhastdate,vahedetejarisn=@Vahedetejarisn,kanaleforooshsn=@kanaleforooshsn,latitude=@latitude,longitude=@longitude, darkhastmarjoostatus=@DarkhastMarjooStatus Where darkhastmarjoosn=@darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Moshtariinfosn", m_nMoshtariinfosn);
                objSqlCeParameters[2] = new SqlCeParameter("@Visitorsn", m_nVisitorsn);
                objSqlCeParameters[3] = new SqlCeParameter("@DarkhastDate", m_strDarkhastDate);
                objSqlCeParameters[4] = new SqlCeParameter("@dalilmarjoo", m_strDalilMarjoo);
                objSqlCeParameters[5] = new SqlCeParameter("@factormarjoono", m_strFactorMarjoono);
                objSqlCeParameters[6] = new SqlCeParameter("@Vahedetejarisn", m_nVahedeTejarisn);
                objSqlCeParameters[7] = new SqlCeParameter("@Kanaleforooshsn", m_nKanaleForooshsn);
                objSqlCeParameters[8] = new SqlCeParameter("@Latitude", m_nLatitude);
                objSqlCeParameters[9] = new SqlCeParameter("@Longitude", m_nLongitude);
                objSqlCeParameters[10] = new SqlCeParameter("@DarkhastMarjooStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbUpdateMarjooStatus()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[2];

            try
            {
                strQuery = "Update pdDarkhastMarjoo Set darkhastmarjoostatus=@DarkhastMarjooStatus" +
                " Where darkhastmarjoosn=@darkhastmarjoosn";

                objSqlCeParameters[0] = new SqlCeParameter("@darkhastmarjoosn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@DarkhastMarjooStatus", m_nDarkhastStatus);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbDeleteMarjoo()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Delete pdDarkhastMarjoo Where darkhastmarjoosn=@Darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void dbDeleteDetailsMarjoo()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Delete pdDarkhastMarjooha Where darkhastmarjoosn=@Darkhastsn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public int GetCountOfItems()
        {
            int nResult = 0;
            object objRes = dpDataAccess.GetFieldValue("pdDarkhastha", "Count(darkhasthasn)", "darkhastsn='" + m_nDarkhastsn + "'");

            if (objRes != DBNull.Value)
                nResult = Convert.ToInt32(objRes);

            return nResult;

        }

        public int GetCountOfMarjooItems()
        {
            int nResult = 0;
            object objRes = dpDataAccess.GetFieldValue("pdDarkhastMarjooha", "Count(darkhastmarjoosn)", "darkhastmarjoosn='" + m_nDarkhastsn + "'");

            if (objRes != DBNull.Value)
                nResult = Convert.ToInt32(objRes);

            return nResult;

        }

        #endregion

        #region Property

        public decimal Darkhastsn
        {
            get
            {
                return (m_nDarkhastsn);
            }

            set
            {
                m_nDarkhastsn = value;
            }
        }

        public decimal Visitorsn
        {
            get
            {
                return (m_nVisitorsn);
            }

            set
            {
                m_nVisitorsn = value;
            }
        }

        public decimal Moshtariinfosn
        {
            get
            {
                return (m_nMoshtariinfosn);
            }

            set
            {
                m_nMoshtariinfosn = value;
            }
        }

        public string DarkhastDate
        {
            get
            {
                return (m_strDarkhastDate);
            }

            set
            {
                m_strDarkhastDate = value;
            }
        }

        public decimal NoeTahvilsn
        {
            get
            {
                return (m_nNoeTahvilsn);
            }

            set
            {
                m_nNoeTahvilsn = value;
            }
        }

        public decimal NoePardakhtsn
        {
            get
            {
                return (m_nNoePardakhtsn);
            }

            set
            {
                m_nNoePardakhtsn = value;
            }
        }

        public decimal KanaleForooshsn
        {
            get
            {
                return (m_nKanaleForooshsn);
            }

            set
            {
                m_nKanaleForooshsn = value;
            }
        }

        public string DalilMarjoo
        {
            get
            {
                return (m_strDalilMarjoo);
            }

            set
            {
                m_strDalilMarjoo = value;
            }
        }

        public string FactorMarjoono
        {
            get
            {
                return (m_strFactorMarjoono);
            }

            set
            {
                m_strFactorMarjoono = value;
            }
        }

        public short ModatVosool
        {
            get
            {
                return (m_nModatVosool);
            }

            set
            {
                m_nModatVosool = value;
            }
        }

        public decimal VahedeTejarisn
        {
            get
            {
                return (m_nVahedeTejarisn);
            }

            set
            {
                m_nVahedeTejarisn = value;
            }
        }

        public byte DarkhastStatus
        {
            get
            {
                return (m_nDarkhastStatus);
            }

            set
            {
                m_nDarkhastStatus = value;
            }
        }

        public float Latitude
        {
            get
            {
                return (m_nLatitude);
            }

            set
            {
                m_nLatitude = value;
            }
        }

        public float Longitude
        {
            get
            {
                return (m_nLongitude);
            }

            set
            {
                m_nLongitude = value;
            }
        }

        public DateTime ExecTimeStart
        {
            get
            {
                return (m_dtmExecTimeStart);
            }

            set
            {
                m_dtmExecTimeStart = value;
            }
        }

        public DateTime ExecTimeEnd
        {
            get
            {
                return (m_dtmExecTimeEnd);
            }

            set
            {
                m_dtmExecTimeEnd = value;
            }
        }

        public string VahedeTejariNo
        {
            get
            {
                return (m_Vahedetejarino);
            }

            set
            {
                m_Vahedetejarino = value;
            }
        }

        public string MoshtariNo
        {
            get
            {
                return (m_Moshtarino);
            }

            set
            {
                m_Moshtarino = value;
            }
        }

        public string MoshtariDs
        {
            get
            {
                return (m_MoshtariDs);
            }

            set
            {
                m_MoshtariDs = value;
            }
        }

        public string UserNo
        {
            get
            {
                return (m_Userno);
            }

            set
            {
                m_Userno = value;
            }
        }

        public string NoeTahvilNo
        {
            get
            {
                return (m_Noetahvilno);
            }

            set
            {
                m_Noetahvilno = value;
            }
        }

        public string KanaleForooshNo
        {
            get
            {
                return (m_Kanaleforooshno);
            }

            set
            {
                m_Kanaleforooshno = value;
            }
        }
        
        #endregion

        #region Private

        private decimal m_nDarkhastsn;
        private decimal m_nVisitorsn;
        private decimal m_nMoshtariinfosn;
        private string m_strDarkhastDate;
        private decimal m_nNoeTahvilsn;
        private decimal m_nNoePardakhtsn;
        private decimal m_nKanaleForooshsn;
        private string m_strDalilMarjoo;
        private string m_strFactorMarjoono;
        private short m_nModatVosool;

        private byte m_nDarkhastStatus;
        private float m_nLatitude;
        private float m_nLongitude;
        private decimal m_nVahedeTejarisn;
        private DateTime m_dtmExecTimeStart;
        private DateTime m_dtmExecTimeEnd;

        private string m_Moshtarino, m_MoshtariDs, m_Vahedetejarino, m_Userno, m_Kanaleforooshno, m_Noetahvilno;

        #endregion
    }
}
