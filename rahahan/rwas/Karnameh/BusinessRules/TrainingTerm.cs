using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class TrainingTerm
    {
        #region Method

        public static DataView GetTrainingTerm()
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwPersonnelTraining", "distinct code_amozesh, name_amozesh", "", "name_amozesh").DefaultView;
            }
            catch
            {
            }

            return dvResult;
        }

        public void LoadTrainingTerm(short code_amozesh)
        {
            DataView dvResult = new DataView();

            try
            {
                dvResult = dpHadiData.GetDataTable(dpHadiData.m_PrimaryConnection, "vwPersonnelTraining", "distinct code_amozesh, name_amozesh", "code_amozesh=" + code_amozesh.ToString(), "TrainingTermId").DefaultView;
                m_nTrainingTermId = Convert.ToInt16(dvResult[0]["code_amozesh"]);

            }
            catch
            {
            }

            
        }

        #endregion

        #region Property

        public short TrainingTermId
        {
            get
            {
                return (m_nTrainingTermId);
            }

            set
            {
                m_nTrainingTermId = value;
            }
        }

        public string TrainingTitle
        {
            get
            {
                return (m_strTrainingTitle);
            }

            set
            {
                m_strTrainingTitle = value;
            }
        }

        #endregion

        #region Private

        private short m_nTrainingTermId;
        private string m_strTrainingTitle;

        #endregion
    }
}
