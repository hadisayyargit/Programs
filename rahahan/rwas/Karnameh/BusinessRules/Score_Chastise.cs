using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWAS.Common;

namespace RWAS.BusinessRules
{
    public class Score_Chastise
    {
        #region Method

        public float getScore_Chastise()
        {
            float nScore = 0;

            switch (m_nForfeitKind)
            {
                case (byte)enumForfeitKind.Dissatisfaction:
                    nScore = 2;
                    break;
                case (byte)enumForfeitKind.ekhtar:
                    ///
                    nScore = 2;
                    break;
                case (byte)enumForfeitKind.tobikh:
                    ///
                    nScore = 3;
                    break;
                case (byte)enumForfeitKind.kasr1_10:
                case (byte)enumForfeitKind.kasr1_15:
                case (byte)enumForfeitKind.kasr1_20:
                case (byte)enumForfeitKind.kasr1_3:
                case (byte)enumForfeitKind.kasr1_30:
                case (byte)enumForfeitKind.kasr1_4:
                case (byte)enumForfeitKind.kasr1_5:
                case (byte)enumForfeitKind.kasr1_6:
                case (byte)enumForfeitKind.kasr1_8:
                case (byte)enumForfeitKind.kasr4:
                                       
                    nScore = 4*m_nChastiseDuration;
                    if (nScore > 48) nScore = 48;
                    break;
                case (byte)enumForfeitKind.enfesal_movaghat:
                    ///
                    nScore = 5 * m_nChastiseDuration;
                    if (nScore > 60) nScore = 60;

                    break;
                case (byte)enumForfeitKind.taghir_mahal:
                    ///
                    if(m_nChastiseDuration>=12)
                        nScore = 10 *(m_nChastiseDuration/12);
                    if (nScore > 50) nScore = 50;
                    break;
                case (byte)enumForfeitKind.tanazzol_magham:
                    ///
                    nScore = 20;
                    break;
                case (byte)enumForfeitKind.tanazzol_gorooh:
                    ///
                    nScore = 15;
                    break;
                case (byte)enumForfeitKind.bazkharid:
                    ///
                    nScore = 50;
                    break;
                case (byte)enumForfeitKind.bazneshasteh:
                    ///
                    nScore = 60;
                    break;
                case (byte)enumForfeitKind.ekhraj:
                    ///
                    nScore = 80;
                    break;
                case (byte)enumForfeitKind.enfesal_daem:
                    ///
                    nScore = 100;
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

        public byte ForfeitKind
        {
            get
            {
                return (m_nForfeitKind);
            }

            set
            {
                m_nForfeitKind = value;
            }
        }

        public byte ChastiseDuration
        {
            get
            {
                return (m_nChastiseDuration);
            }

            set
            {
                m_nChastiseDuration = value;
            }
        }

        public string ChastiseDate
        {
            get
            {
                return (m_strChastiseDate);
            }

            set
            {
                m_strChastiseDate = value;
            }
        }
        #endregion

        #region Private

        private int m_nUniqueId;
        private short m_nDonorId;
        private byte m_nForfeitKind;
        private string m_strChastiseDate;
        private byte m_nChastiseDuration;

        #endregion
    }
}
