using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWAS.BusinessRules
{
    public class Score_Accident
    {
        #region Method

        public float getScore_Accident()
        {
            float nScore = 0;


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


        public short Hours
        {
            get
            {
                return (m_nHours);
            }

            set
            {
                m_nHours = value;
            }
        }

        public short Degree
        {
            get
            {
                return (m_nDegree);
            }

            set
            {
                m_nDegree = value;
            }
        }


        #endregion

        #region Private

        private int m_nUniqueId;
        private short m_nHours;
        private short m_nDegree;

        #endregion
    }
}
