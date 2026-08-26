using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWAS.Common;

namespace RWAS.BusinessRules
{
    public class Score_Encouragement
    {
        #region Method

        /// <summary>
        /// امتیاز
        /// </summary>
        /// <returns></returns>
        public float getScore_Encouragement()
        {
            float nScore = 0;

            switch (m_nDonorId)
            {
                case (short)enumDonorId.President:
                    ///رئیس جمهور
                    nScore = 15;
                    break;
                case (short)enumDonorId.Minister:
                    ///وزیر
                    nScore = 10;
                    break;
                case (short)enumDonorId.surrogate:
                    ///قائم مقام
                    nScore = 8;
                    break;
                case (short)enumDonorId.ManagingDirector:
                    ///مدیر عامل
                    nScore = 8;
                    break;
                case (short)enumDonorId.Assistant:
                    /// معاون
                    nScore = 6;
                    break;
                case (short)enumDonorId.GeneralManager:
                    ///مدیر کل
                    nScore = 4;
                    break;
            }

            switch (m_nEulogyTypeId)
            {
                case (short)enumEulogyType.Satisfaction:
                    ///رضایت رئیس گروه حفاظت
                    nScore = 2;
                    break;
                case (short)enumEulogyType.PreventAccident:
                    nScore = 15;
                    break;
                case (short)enumEulogyType.PreventAccidentReport:
                    nScore = 4;
                    break;
            }

            return nScore;
        }


        #endregion

        #region Property

        public int UniqueId
        {
            get
            {
                return (m_nUniqueId);
            }

            set
            {
                m_nUniqueId = value;
            }
        }


        public short EulogyTypeId
        {
            get
            {
                return (m_nEulogyTypeId);
            }

            set
            {
                m_nEulogyTypeId = value;
            }
        }

        public short DonorId
        {
            get
            {
                return (m_nDonorId);
            }

            set
            {
                m_nDonorId = value;
            }
        }


        #endregion

        #region Private

        private int m_nUniqueId;
        private short m_nEulogyTypeId;
        private short m_nDonorId;

        #endregion
    }
}
