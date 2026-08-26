using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;
using RWAS.Common;

namespace RWAS.BusinessRules
{
    public class Score
    {
        public static DataView GetPersonnelScore(int nUniquecode)
        {
            DataView myView = new DataView();
            SqlParameter[] objSqlParameters = new SqlParameter[1];

            try
            {
                objSqlParameters[0] = new SqlParameter("@Rws_Fld_UniqueCode", nUniquecode);

                myView = dpHadiData.ExecuteStoredProcedure2(dpHadiData.m_PrimaryConnection, "sp_GetPersonnelScore", objSqlParameters).DefaultView;
            }
            catch (Exception ex)
            {
            }

            return myView;
        }

        public float CalculateTotalScore(int myUniqueId, string strPDate)
        {
            float nScore_Training = 0, nScore_Accident = 0, nScore_Encouragement = 0, nScore_Chastise = 0, nScore_Total = 0;
            float nScore_Training_Negative = 0, nScore_Accident_Negative = 0, nScore_Encouragement_Negative = 0, nScore_Chastise_Negative = 0, nScore_Total_Negative = 0;
            float nTotal = 0;




            nScore_Training = GetTotalScore_Training(myUniqueId, strPDate);
            nScore_Accident = GetTotalScore_Accident(myUniqueId, strPDate);
            nScore_Encouragement = GetTotalScore_Encouragement(myUniqueId, strPDate);
            nScore_Chastise = GetTotalScore_Chastise(myUniqueId, strPDate);
            nScore_Total = nScore_Training + nScore_Accident + nScore_Encouragement + nScore_Chastise;

            nScore_Training_Negative = 0;
            nScore_Accident_Negative = GetTotalScore_Accident_Negative(myUniqueId, strPDate);
            nScore_Encouragement_Negative = 0;
            nScore_Chastise_Negative = GetTotalScore_Chastise_Negative(myUniqueId, strPDate);
            nScore_Total_Negative = nScore_Training_Negative + nScore_Accident_Negative + nScore_Encouragement_Negative + nScore_Chastise_Negative;

            nTotal = nScore_Total - nScore_Total_Negative;

            return nTotal;
        }       

        public float GetTotalScore_Training(int myUniqueId, string strPDate)
        {
            float nScore = 0;

            Score_Training objScore_Training = new Score_Training();
            DataView myView = new DataView();

            myView = dpHadiBusiness.GetPersonnelTraining(myUniqueId);

            myView.RowFilter = "d_end<='" + strPDate + "'";

            for (int i = 0; i < myView.Count; i++)
            {
                try
                {
                    objScore_Training = new Score_Training();
                    objScore_Training.UniqueId = myUniqueId;

                    /*
                    if (myView[i]["TrainingHours"] != DBNull.Value)
                        objScore_Training.Hours = Convert.ToInt16(myView[i]["TrainingHours"]);
                    if (myView[i]["Rws_Fld_Degree"] != DBNull.Value)
                        objScore_Training.Degree = Convert.ToInt16(myView[i]["Rws_Fld_Degree"]);
                    if (myView[i]["HasExamination"].ToString() == "0")
                        objScore_Training.Degree = 50;
                     */
                    if (myView[i]["time_hours"] != DBNull.Value)
                        objScore_Training.Hours = Convert.ToInt16(myView[i]["time_hours"]);
                    if (myView[i]["Rws_Fld_Degree"] != DBNull.Value)
                        objScore_Training.Degree = Convert.ToInt16(myView[i]["Rws_Fld_Degree"]);
                    else
                        objScore_Training.Degree = 50;


                    nScore += objScore_Training.getScore_training();
                }
                catch(Exception ex)
                {

                }
            }

            return nScore;
        }
        
        public float GetTotalScore_Encouragement(int myUniqueId,string strPDate)
        {
            float nScore = 0;

            Score_Encouragement objScore_Encouragement = new Score_Encouragement();
            DataView myView = new DataView();

            myView = dpHadiBusiness.GetPersonnelEulogy4Score(myUniqueId);

            myView.RowFilter = "Rws_Fld_Date<='" + strPDate + "'";

            for (int i = 0; i < myView.Count; i++)
            {
                try
                {
                    objScore_Encouragement = new Score_Encouragement();
                    objScore_Encouragement.UniqueId = myUniqueId;

                    if (myView[i]["DonorId"] != DBNull.Value)
                        objScore_Encouragement.DonorId = Convert.ToInt16(myView[i]["DonorId"]);
                    if (myView[i]["EulogyTypeId"] != DBNull.Value)
                        objScore_Encouragement.EulogyTypeId = Convert.ToInt16(myView[i]["EulogyTypeId"]);

                    nScore += objScore_Encouragement.getScore_Encouragement();
                }
                catch (Exception ex)
                {

                }
            }

            return nScore;
        }

        public float GetTotalScore_Chastise(int myUniqueId,string strPDate)
        {
            float nScore = 0, nMissScore = 0;

            DataView myView = dpHadiBusiness.GetPersonnelChastise(myUniqueId);

            myView.RowFilter = "Rws_Fld_Date<='" + strPDate + "'";

            string strEDate = dpHadiBusiness.GetPersonnelEmployeeDate(myUniqueId);

            int d1, d2;

            if (strEDate.Trim() != "")
            {
                d1 = int.Parse(strEDate);
                System.Globalization.PersianCalendar objPCalendar = new System.Globalization.PersianCalendar();
            
                
                d2 = int.Parse(strPDate);

                for (int i = d1; i < d2 - 10000; i += 10000)
                {

                    myView.RowFilter = "Rws_Fld_Date>=" + i.ToString() + " And Rws_Fld_Date<" + (i + 10000).ToString();
                    if (myView.Count == 0)
                        nScore += 5;
                }
            }


            myView = dpHadiBusiness.GetPersonnelOperation(myUniqueId);
            myView.RowFilter = "Rws_Fld_MonthYear<='" + strPDate.Substring(0,6) + "'";

            int nTotalOffDay = 0;
            if (myView.Count > 0)
            {
                nTotalOffDay = Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_LeaveDay)", ""))
                        + Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_SickLeaveDay)", ""))
                        + Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_LeaveWithoutPay)", ""));
            }
            nMissScore = (nTotalOffDay / 30) * 0.5f;
            if (nMissScore > 5) nMissScore = 5;

            nScore = nScore - nMissScore;

            /*
            
            y2 = objPCalendar.GetYear(DateTime.Now);
            if (strEDate != "")
            {
                y1 = int.Parse(strEDate.Substring(0, 4));

                for (int i = y1; i <= y2; i++)
                {
                    myView.RowFilter = "substring(Rws_Fld_Date,1,4)=" + i.ToString();
                    if (myView.Count == 0)
                        nScore += 5;

                }
            }

             */


            return nScore;
        }

        public float GetTotalScore_Accident(int myUniqueId,string strPDate)
        {
            float nScore = 0, nMissScore=0;
            DataView myView = dpHadiBusiness.GetPersonnelAccidents(myUniqueId);
            myView.RowFilter = "Rws_Fld_AccidentDate<='" + strPDate + "'";


            string strEDate=dpHadiBusiness.GetPersonnelEmployeeDate(myUniqueId);
            
            int d1, d2;
            
            if (strEDate.Trim() != "")
            {
                d1 = int.Parse(strEDate);
                d2 = int.Parse(strPDate);

                for (int i = d1; i < d2-10000; i += 10000)
                {

                    myView.RowFilter = "Rws_fld_AccidentDate>=" + i.ToString() +" And Rws_fld_AccidentDate<" + (i + 10000).ToString();
                    if (myView.Count == 0)
                        nScore += 10;
                }
            }


            int nTotalOffDay = 0;
            myView = dpHadiBusiness.GetPersonnelOperation(myUniqueId);
            myView.RowFilter = "Rws_Fld_MonthYear<='" + strPDate.Substring(0, 6) + "'";
            if (myView.Count > 0)
            {
                nTotalOffDay = Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_LeaveDay)", ""))
                        + Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_SickLeaveDay)", ""))
                        + Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_LeaveWithoutPay)", ""))
                        + Convert.ToInt32(myView.Table.Compute("sum(Rws_Fld_AbsentDay)", ""));
            }

            nMissScore = nTotalOffDay / 30;
            if (nMissScore > 10) nMissScore = 10;

            nScore = nScore - nMissScore;
            /*
            int y1, y2;

            System.Globalization .PersianCalendar objPCalendar=new System.Globalization.PersianCalendar();

            y2=objPCalendar.GetYear(DateTime.Now);
            if (strEDate != "")
            {

                y1 = int.Parse(strEDate.Substring(0,4));

                for (int i = y1; i < y2; i++)
                {

                    myView.RowFilter = "substring(Rws_fld_AccidentDate,1,4)="+i.ToString();
                    if (myView.Count == 0)
                        nScore += 10;

                }
            }
             */

            return nScore;
        }

        public float GetTotalScore_Chastise_Negative(int myUniqueId,string strPDate)
        {
            float nScore = 0;

            Score_Chastise objScore_Chastise = new Score_Chastise();
            DataView myView = new DataView();

            myView = dpHadiBusiness.GetPersonnelChastise(myUniqueId);
            myView.RowFilter = "Rws_Fld_Date<='" + strPDate + "'";

            string strEDate = dpHadiBusiness.GetPersonnelEmployeeDate(myUniqueId);


            for (int i = 0; i < myView.Count; i++)
            {
                try
                {
                    objScore_Chastise = new Score_Chastise();
                    objScore_Chastise.UniqueId = myUniqueId;

                    if (myView[i]["DonorId"] != DBNull.Value)
                        objScore_Chastise.DonorId = Convert.ToInt16(myView[i]["DonorId"]);
                    if (myView[i]["ForfeitKind"] != DBNull.Value)
                        objScore_Chastise.ForfeitKind = Convert.ToByte(myView[i]["ForfeitKind"]);
                    if (myView[i]["Rws_fld_date"] != DBNull.Value)
                        objScore_Chastise.ChastiseDate = myView[i]["Rws_fld_date"].ToString();
                    if (myView[i]["ChastiseDuration"] != DBNull.Value)
                        objScore_Chastise.ChastiseDuration = Convert.ToByte(myView[i]["ChastiseDuration"]);

                    nScore += objScore_Chastise.getScore_Chastise();
                }
                catch (Exception ex)
                {

                }
            }

            int d1, d2;

            if (strEDate.Trim() != "")
            {
                d1 = int.Parse(strEDate);
                d2 = int.Parse(strPDate);

                for (int i = d1; i < d2 ; i += 10000)
                {

                    myView.RowFilter = "Rws_Fld_Date>=" + i.ToString() + " And Rws_Fld_Date<" + (i + 10000).ToString() + " And (ForfeitKind=" + ((byte)enumForfeitKind.ekhtar).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.tobikh).ToString() + ")";
                    if (myView.Count > 3)
                        nScore += 10;
                }
            }

            if (strEDate.Trim() != "")
            {
                d1 = int.Parse(strEDate);
                d2 = int.Parse(strPDate);

                for (int i = d1; i < d2; i += 10000)
                {

                    myView.RowFilter = "Rws_Fld_Date>=" + i.ToString() + " And Rws_Fld_Date<" + (i + 10000).ToString() 
                        + " And (ForfeitKind=" + ((byte)enumForfeitKind.kasr1_10).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_15).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_20).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_3).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_30).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_4).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_5).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_6).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr1_8).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.kasr4).ToString()
                        + " Or ForfeitKind=" + ((byte)enumForfeitKind.enfesal_daem).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.enfesal_movaghat).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.taghir_mahal).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.tanazzol_magham).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.tanazzol_gorooh).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.bazkharid).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.bazneshasteh).ToString() + " Or ForfeitKind=" + ((byte)enumForfeitKind.ekhraj).ToString() + ")";
                    if (myView.Count >= 3)
                        nScore += 30;
                }
            }
            
            return nScore;
        }

        public float GetTotalScore_Accident_Negative(int myUniqueId,string strPDate)
        {
            float nScore = 0;

            if (myUniqueId > 1000000)
                return nScore;

            DataView myView = dpHadiBusiness.GetPersonnelAccidents(myUniqueId);
            myView.RowFilter = "Rws_Fld_AccidentDate<='" + strPDate + "'";

            for (int i = 0; i < myView.Count; i++)
            {

                if (myView[i]["Rws_fld_fk_AccidentDegree"] != DBNull.Value)
                {
                    short nDegree = Convert.ToInt16(myView[i]["Rws_fld_fk_AccidentDegree"]);
                    switch (nDegree)
                    {
                        case 1:   
                            //بسیار مهم
                            nScore += 60;
                            break;
                        case 2:
                            //مهم
                            nScore += 30;
                            break;
                        case 3:
                            //درجه1
                            nScore += 15;
                            break;
                        case 4:
                            //درجه2
                            nScore += 10;
                            break;
                        case 5:
                            //درجه3
                            nScore += 5;
                            break;
                    }
                }

            }

            return nScore;
        }

        public void dbInsert(int myUniqueId, string strPDate, float AccidentScore, float TrainingScore, float EulogyScore, float ChastiseScore)
        {
            string strQuery;
            SqlParameter[] myParametes = new SqlParameter[6];

            try
            {
                strQuery = "delete RWS_Tbl_Score Where Rws_Fld_Uniquecode=" + myUniqueId.ToString() + " and Rws_Fld_Date='" + strPDate + "'";
                dpHadiData.ExecuteNonQuery(dpHadiData.m_PrimaryConnection, strQuery);

                strQuery = "Insert Into RWS_Tbl_Score (Rws_Fld_UniqueCode ,Rws_Fld_Date ,Training_Score ,Accident_Score ,Eulogy_Score ,Chastise_Score)"
                            + " Values(@Rws_Fld_Uniquecode,@Rws_Fld_Date ,@Training_Score ,@Accident_Score ,@Eulogy_Score ,@Chastise_Score)";
                myParametes[0] = new SqlParameter("@Rws_Fld_Uniquecode", myUniqueId);
                myParametes[1] = new SqlParameter("@Rws_Fld_Date", strPDate);
                myParametes[2] = new SqlParameter("@Training_Score", TrainingScore);
                myParametes[3] = new SqlParameter("@Accident_Score", AccidentScore);
                myParametes[4] = new SqlParameter("@Eulogy_Score", EulogyScore);
                myParametes[5] = new SqlParameter("@Chastise_Score", ChastiseScore);

                dpHadiData.ExecuteNonQuery(dpHadiData.m_PrimaryConnection, strQuery, myParametes);

            }
            catch
            {

            }
        }

    }
}
