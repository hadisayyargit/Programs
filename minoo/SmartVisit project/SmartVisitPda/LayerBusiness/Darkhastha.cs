using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using layerData;

namespace layerBusiness
{
    public class Darkhastha
    {
        #region Public

        public static SqlCeResultSet GetDarkhastha(decimal nDarkhastsn)
        {
            SqlCeResultSet objSqlceResultset = null;
            string strQuery = "select pdDarkhastha.darkhastsn,pdDarkhastha.darkhasthasn,pdDarkhastha.kalasn,pdDarkhastha.tedad, pdkala.kalads, pdkala.forooshcode, pdkala.imagepath , pdKalaInfo.nerkheforoosh, cast( (pdDarkhastha.tedad* pdKalaInfo.nerkheforoosh) as bigint) as mablagh" 
                    +" from pdDarkhastha inner join pdKala on pddarkhastha.kalasn=pdkala.kalasn  inner join pdKalaInfo on pdKala.kalasn=pdKalaInfo.kalasn"
                    +" Where  DarkhastSN=" + nDarkhastsn.ToString();

            objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);
            
            return objSqlceResultset;

        }

        public static SqlCeResultSet GetDarkhastMarjooha(decimal nDarkhastsn)
        {
            SqlCeResultSet objSqlceResultset = null;
            string strQuery = "select pddarkhastmarjooha.darkhastmarjoosn,pddarkhastmarjooha.darkhastmarjoohasn,pddarkhastmarjooha.kalasn,pddarkhastmarjooha.tedad, pdkala.kalads, pdkala.forooshcode, pdkala.imagepath , pdKalaInfo.nerkheforoosh, cast( (pdDarkhastmarjooha.tedad* pdKalaInfo.nerkheforoosh) as bigint) as mablagh"
        + " from pddarkhastmarjooha inner join pdKala on pddarkhastmarjooha.kalasn=pdkala.kalasn  inner join pdKalaInfo on pdKala.kalasn=pdKalaInfo.kalasn"
        + " Where  darkhastmarjoosn=" + nDarkhastsn.ToString();


            objSqlceResultset = dpDataAccess.GetResultSetOfQuery(strQuery);

            return objSqlceResultset;

        }

        #endregion

        #region Method

        public void FetchDarkhastha()
        {
            SqlCeResultSet objSqlceResultset = null;
            

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdDarkhastha", "*", "DarkhasthaSN=" + m_nDarkhasthasn.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nDarkhastsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Darkhastsn"));
                    m_nKalasn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Kalasn"));
                    m_nTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("Tedad"));

                }

                else
                    m_nDarkhasthasn = -1;
            }
            catch
            {
                m_nDarkhasthasn = -1;
            }

        }

        public void FetchDarkhastMarjooha()
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nDarkhasthasn = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdDarkhastMarjooha", "*", "darkhastmarjoohasn=" + m_nDarkhasthasn.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nDarkhastsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("darkhastmarjoosn"));
                    m_nKalasn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("kalasn"));
                    m_nTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("tedad"));

                }

                else
                    m_nDarkhasthasn = -1;
            }
            catch
            {
                m_nDarkhasthasn = -1;
            }

        }

        public void FetchDarkhasthaByKalasn(decimal nKalasn)
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nDarkhasthasn = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdDarkhastha", "*", "kalasn=" + nKalasn.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nDarkhasthasn = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("Darkhasthasn"));
                    m_nDarkhastsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Darkhastsn"));
                    m_nKalasn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Kalasn"));
                    m_nTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("Tedad"));

                }

                else
                    m_nDarkhasthasn = -1;
            }
            catch
            {
            }

        }

        public void FetchDarkhastMarjoohaByKalasn(decimal nKalasn)
        {
            SqlCeResultSet objSqlceResultset = null;
            m_nDarkhasthasn = -1;

            try
            {
                objSqlceResultset = dpDataAccess.GetResultSet("pdDarkhastMarjooha", "*", "kalasn=" + nKalasn.ToString(), "");

                if (objSqlceResultset.HasRows)
                {
                    objSqlceResultset.Read();
                    m_nDarkhasthasn = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("darkhastmarjoohasn"));
                    m_nDarkhastsn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("darkhastmarjoosn"));
                    m_nKalasn = objSqlceResultset.GetDecimal(objSqlceResultset.GetOrdinal("Kalasn"));
                    m_nTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("Tedad"));

                }

                else
                    m_nDarkhasthasn = -1;
            }
            catch
            {
            }

        }

        public void dbInsert()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[3];

            try
            {
                strQuery = "Insert Into pdDarkhastha(Darkhastsn,Kalasn,Tedad)"
                    + "Values(@Darkhastsn,@Kalasn,@Tedad)";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Kalasn", m_nKalasn);
                objSqlCeParameters[2] = new SqlCeParameter("@Tedad", m_nTedad);

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
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[3];

            try
            {
                strQuery = "Insert Into pdDarkhastMarjooha(DarkhastMarjoosn,Kalasn,Tedad)"
                    + "Values(@Darkhastsn,@Kalasn,@Tedad)";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhastsn", m_nDarkhastsn);
                objSqlCeParameters[1] = new SqlCeParameter("@Kalasn", m_nKalasn);
                objSqlCeParameters[2] = new SqlCeParameter("@Tedad", m_nTedad);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /*
        public string dbUpdate()
        {
            string strRes = "";

            SqlParameter[] objSqlParameters = new SqlParameter[2];

            try
            {
                objSqlParameters[0] = new SqlParameter("@EulogyTypeId", m_nEulogyTypeId);
                objSqlParameters[1] = new SqlParameter("@EulogyTypeDescribe", m_strEulogyTypeName);

                strRes = dpHadiData.ExecuteStoredProcedure(dpHadiData.m_PrimaryConnection, "sp_Rws_Tbl_EulogyType_Update", objSqlParameters);
            }
            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

         */

        public void dbDelete()
        {
            string strQuery;
            SqlCeParameter[] objSqlCeParameters = new SqlCeParameter[1];

            try
            {
                strQuery = "Delete pdDarkhastha Where darkhasthasn=@darkhasthasn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhasthasn", m_nDarkhasthasn);

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
                strQuery = "Delete pdDarkhastha Where darkhastmarjoohasn=@darkhasthasn";

                objSqlCeParameters[0] = new SqlCeParameter("@Darkhasthasn", m_nDarkhasthasn);

                dpDataAccess.ExecuteNonQuery(strQuery, objSqlCeParameters);
            }
            catch (Exception ex)
            {
                throw;
            }

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

        public int Darkhasthasn
        {
            get
            {
                return (m_nDarkhasthasn);
            }

            set
            {
                m_nDarkhasthasn = value;
            }
        }

        public decimal Kalasn
        {
            get
            {
                return (m_nKalasn);
            }

            set
            {
                m_nKalasn = value;
            }
        }

        public int Tedad
        {
            get
            {
                return (m_nTedad);
            }

            set
            {
                m_nTedad = value;
            }
        }


        #endregion

        #region Private

        private decimal m_nDarkhastsn;
        private int m_nDarkhasthasn;
        private decimal m_nKalasn;
        private int m_nTedad;

        #endregion
    }
}
