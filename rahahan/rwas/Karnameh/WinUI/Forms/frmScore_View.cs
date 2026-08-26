using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RWAS.BusinessRules;
using RWAS.Common;


namespace RWAS.WinUI
{
    public partial class frmScore_View : Form
    {
        public int m_nUniqueCode;
        DataView m_dvMaster = new DataView();

        public frmScore_View()
        {
            InitializeComponent();
        }

        public frmScore_View(int UniqueCode)
        {
            InitializeComponent();
            m_nUniqueCode = UniqueCode;
            grdScore.RowCount = 5;
            grdScore[colTitle.Name, 0].Value = "دوره های آموزشی";
            grdScore[colTitle.Name, 1].Value = "حوادث";
            grdScore[colTitle.Name, 2].Value = "تشویقات";
            grdScore[colTitle.Name, 3].Value = "تنبیهات";
            grdScore[colTitle.Name, 4].Value = "مجموع";

            grdScore.Rows[4].DefaultCellStyle.BackColor = Color.Aqua;
        }


        private void RefreshData()
        {

            m_dvMaster = Score.GetPersonnelScore(m_nUniqueCode);
            
            Program.m_PrgMod = Program.PrgMod.Normal;
        }

        private void frmScore_View_Load(object sender, EventArgs e)
        {
            //faDatePickerScoreDate.Text = Program.m_strCurrentPDate;
            txtUniqueCode.Text = m_nUniqueCode.ToString();
            txtName.Text = dpHadiBusiness.GetPersonnelName(m_nUniqueCode);

            RefreshData();

            if (m_dvMaster.Count > 0)
            {
                grdScore[colScore.Name, 0].Value = m_dvMaster[0]["Training_Score"];
                grdScore[colScore.Name, 1].Value = m_dvMaster[0]["Accident_Score"];
                grdScore[colScore.Name, 2].Value = m_dvMaster[0]["Eulogy_Score"];
                grdScore[colScore.Name, 3].Value = m_dvMaster[0]["Chastise_Score"];
                grdScore[colScore.Name, 4].Value = Convert.ToSingle(m_dvMaster[0]["Training_Score"]) + Convert.ToSingle(m_dvMaster[0]["Accident_Score"]) + Convert.ToSingle(m_dvMaster[0]["Eulogy_Score"]) + Convert.ToSingle(m_dvMaster[0]["Chastise_Score"]);
                txtDate.Text = CommonClass.GetDateWithSlash(m_dvMaster[0]["Rws_Fld_Date"].ToString());
            }
        }

        /*

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float nScore_Training = 0, nScore_Accident = 0, nScore_Encouragement = 0, nScore_Chastise = 0, nScore_Total = 0;
            float nScore_Training_Negative = 0, nScore_Accident_Negative = 0, nScore_Encouragement_Negative = 0, nScore_Chastise_Negative = 0, nScore_Total_Negative = 0;
            float nTotal = 0;

            string strDate = GlobalUnit.GetDateWithoutSlash(faDatePickerScoreDate.Text);
            if (strDate == "")
            {
                MessageBox.Show("تاریخ را وارد نمایید");
                return;
            }

            Cursor = Cursors.WaitCursor;

            Score objScore = new Score();

            nScore_Training = objScore.GetTotalScore_Training(m_nUniqueCode,strDate);
            nScore_Accident = objScore.GetTotalScore_Accident(m_nUniqueCode, strDate);
            nScore_Encouragement = objScore.GetTotalScore_Encouragement(m_nUniqueCode, strDate);
            nScore_Chastise = objScore.GetTotalScore_Chastise(m_nUniqueCode, strDate);
            nScore_Total = nScore_Training + nScore_Accident + nScore_Encouragement + nScore_Chastise;

            nScore_Training_Negative = 0;
            nScore_Accident_Negative = objScore.GetTotalScore_Accident_Negative(m_nUniqueCode, strDate);
            nScore_Encouragement_Negative = 0;
            nScore_Chastise_Negative = objScore.GetTotalScore_Chastise_Negative(m_nUniqueCode, strDate);
            nScore_Total_Negative = nScore_Training_Negative + nScore_Accident_Negative + nScore_Encouragement_Negative + nScore_Chastise_Negative;

            nTotal = nScore_Total - nScore_Total_Negative;

            grdPositiveScore[colPositiveScore.Name, 0].Value = nScore_Training.ToString();
            grdPositiveScore[colPositiveScore.Name, 1].Value = nScore_Accident.ToString();
            grdPositiveScore[colPositiveScore.Name, 2].Value = nScore_Encouragement.ToString();
            grdPositiveScore[colPositiveScore.Name, 3].Value = nScore_Chastise.ToString();
            grdPositiveScore[colPositiveScore.Name, 4].Value = nScore_Total.ToString();

            grdPositiveScore[colNegativeScore.Name, 0].Value = nScore_Training_Negative;
            grdPositiveScore[colNegativeScore.Name, 1].Value = nScore_Accident_Negative;
            grdPositiveScore[colNegativeScore.Name, 2].Value = nScore_Encouragement_Negative;
            grdPositiveScore[colNegativeScore.Name, 3].Value = nScore_Chastise_Negative;
            grdPositiveScore[colNegativeScore.Name, 4].Value = nScore_Total_Negative;


            txtTotalScore.Text = nTotal.ToString();

            Cursor = Cursors.Default;
        }

         */

    

    }
}
