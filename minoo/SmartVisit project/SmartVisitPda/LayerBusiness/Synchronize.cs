using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Web;
using Common;

namespace layerBusiness
{
    public class Synchronize
    {
        /* 
* فيدبك درخواست

      PacketType, darkhastsn, darkhaststatus 


درخواست

      PacketType,vahedetejarino,darkhastsn,darkhastdate,userno,noetahvilno,noepardakhtsn,moshtarino,modatvosool

      ,kanaleforooshno,latitude,longitude

      ;forooshcode,tedad             


 

         مرجوعی

PacketType,vahedetejarino,darkhastmarjoosn,darkhastmarjoodate,userno,dalilmarjoo,factormarjoono,moshtarino

         ,kanaleforooshno,latitude,longitude

         ;forooshcode,tedad             


موجودي كالا

      forooshcode,mojoodi;forooshcode,mojoodi

نرخ كالا

      forooshcode,NerkheForoosh,NerkheMasraf;forooshcode,NerkheForoosh,NerkheMasraf

      */


        #region public

        public static void UnPack(out string[] mySplits, string myPacket, char myDelimiter)
        {

            mySplits = myPacket.Split(new char[] { myDelimiter });
        }

        public static void SyncKalaNerkh(string[] mySplit)
        {
            string[] mySubSplit = new string[] { };
            decimal kalasn;

            SqlCeResultSet objKalaResultset = null;
            SqlCeResultSet objKalaInfoResultset = null;


            try
            {
                objKalaResultset = Kala.GetKalaTableResultSet();
                objKalaInfoResultset = Kala.GetKalaInfoTableResultSet();

                for (int i = 0; i < mySplit.Length; i++)
                {
                    if (mySplit[i].Length > 0)
                    {
                        UnPack(out mySubSplit, mySplit[i], ',');
                        if (mySubSplit.Length > 0)
                        {
                            if (objKalaResultset.Seek(DbSeekOptions.FirstEqual, new object[] { mySubSplit[0] }))
                            {
                                objKalaResultset.Read();
                                kalasn = objKalaResultset.GetDecimal(objKalaResultset.GetOrdinal("kalasn"));
                                if (objKalaInfoResultset.Seek(DbSeekOptions.FirstEqual, new object[] { kalasn }))
                                {
                                    objKalaInfoResultset.Read();
                                    objKalaInfoResultset.SetInt32(objKalaInfoResultset.GetOrdinal("nerkheforoosh"), Int32.Parse(mySubSplit[1]));
                                    objKalaInfoResultset.SetInt32(objKalaInfoResultset.GetOrdinal("nerkhemasraf"), Int32.Parse(mySubSplit[2]));
                                    objKalaInfoResultset.Update();
                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public static void SyncKalaMojoodi(string[] mySplit)
        {
            string[] mySubSplit = new string[] { };
            decimal kalasn;

            SqlCeResultSet objKalaResultset = null;
            SqlCeResultSet objKalaInfoResultset = null;


            try
            {
                objKalaResultset = Kala.GetKalaTableResultSet();
                objKalaInfoResultset = Kala.GetKalaInfoTableResultSet();

                for (int i = 0; i < mySplit.Length; i++)
                {
                    if (mySplit[i].Length > 0)
                    {
                        UnPack(out mySubSplit, mySplit[i], ',');
                        if (mySubSplit.Length > 0)
                        {
                            if (objKalaResultset.Seek(DbSeekOptions.FirstEqual, new object[] { mySubSplit[0] }))
                            {
                                objKalaResultset.Read();
                                kalasn = objKalaResultset.GetDecimal(objKalaResultset.GetOrdinal("kalasn"));
                                if (objKalaInfoResultset.Seek(DbSeekOptions.FirstEqual, new object[] { kalasn }))
                                {
                                    objKalaInfoResultset.Read();
                                    objKalaInfoResultset.SetInt32(objKalaInfoResultset.GetOrdinal("mojoodi"), Int32.Parse(mySubSplit[1]));
                                    objKalaInfoResultset.Update();
                                }
                            }
                        }

                    }
                }
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Method
        
        public  void Pack_Darkhast()
        {
     
            SqlCeResultSet objSqlceResultset = null;
            string strTedad,strForooshcode;            
            
            Darkhast objDarkhast = new Darkhast();
            objDarkhast.Darkhastsn = m_nDarkhastsn;
            objDarkhast.FetchDarkhast();
            m_PacketString = ((int)MainCommon.PacketType.Darkhast).ToString()
                + "," + objDarkhast.VahedeTejariNo
                + "," + m_nDarkhastsn.ToString("0")
                + "," + objDarkhast.DarkhastDate.Replace("/","") 
                + "," + objDarkhast.UserNo 
                + "," + objDarkhast.MoshtariNo 
                + "," + objDarkhast.KanaleForooshNo
                + "," + objDarkhast.Latitude.ToString() 
                + "," + objDarkhast.Longitude.ToString()
                + "," + objDarkhast.NoeTahvilNo
                + "," + objDarkhast.NoePardakhtsn.ToString("0")
                + "," + objDarkhast.ModatVosool.ToString() ;
                //+ "," + objDarkhast.ExecTimeStart.ToString("yyyy-MM-dd HH:mm:ss") + "," + objDarkhast.ExecTimeEnd.ToString("yyyy-MM-dd HH:mm:ss");
                        
            objSqlceResultset=Darkhastha.GetDarkhastha(m_nDarkhastsn);

            while (objSqlceResultset.Read())
            {
                strForooshcode = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("forooshcode")).ToString();
                strTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("tedad")).ToString();
                m_PacketString = m_PacketString + ";"
                    //+strDarkhasthasn+","
                    +strForooshcode+","+strTedad;
            }
        }

        public void Pack_Marjoo()
        {
            SqlCeResultSet objSqlceResultset = null;
            string strTedad, strForooshcode;

            Darkhast objDarkhast = new Darkhast();
            objDarkhast.Darkhastsn = m_nDarkhastsn;
            objDarkhast.FetchDarkhastMarjoo();
            m_PacketString = ((int)MainCommon.PacketType.Marjoo).ToString()
                + "," + objDarkhast.VahedeTejariNo
                + "," + m_nDarkhastsn.ToString().Replace(".000", "")
                + "," + objDarkhast.DarkhastDate.Replace("/", "")
                + "," + objDarkhast.UserNo
                + "," + objDarkhast.MoshtariNo
                + "," + objDarkhast.KanaleForooshNo
                + "," + objDarkhast.Latitude.ToString()
                + "," + objDarkhast.Longitude.ToString()
                + "," + objDarkhast.DalilMarjoo
                + "," + objDarkhast.FactorMarjoono;
            //+ "," + objDarkhast.ExecTimeStart.ToString("yyyy-MM-dd HH:mm:ss") + "," + objDarkhast.ExecTimeEnd.ToString("yyyy-MM-dd HH:mm:ss");

            objSqlceResultset = Darkhastha.GetDarkhastMarjooha(m_nDarkhastsn);

            while (objSqlceResultset.Read())
            {
                strForooshcode = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("forooshcode")).ToString();
                strTedad = objSqlceResultset.GetInt32(objSqlceResultset.GetOrdinal("tedad")).ToString();
                m_PacketString = m_PacketString + ";"
                    //+strDarkhasthasn+","
                    + strForooshcode + "," + strTedad;
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

        public string PacketString
        {
            get
            {
                return (m_PacketString);
            }

            set
            {
                m_PacketString = value;
            }
        }


        #endregion

        #region Private

        private decimal m_nDarkhastsn;
        private string  m_PacketString;

        #endregion
    }
}
