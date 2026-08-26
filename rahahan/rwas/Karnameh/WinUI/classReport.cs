using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWAS.WinUI
{
    public class classReport
    {
        #region Public

        /// <summary>
        /// اين جدول براي اتصال به گزارش استفاده مي شود
        /// </summary>

        public enum ReportIdType { reportWorkBook, reportOperation, reportAccident, reportEulogy, reportChastise, reportTrainingTerm, reportBodily, reportScore, reportDataEntry }

        #endregion

        #region Private

        ReportIdType m_ReportId;
        string m_strTitr, m_strSubTitle, m_strFooter, m_strPrintPDate, m_strStringParam;
        string m_strBeginDate, m_strEndDate, m_strShowColumn, m_strGroupFieldName,m_strJobDesc, m_strRegionDesc, m_strPersonName;
        int m_nCategory, m_nAccidentKind, m_nReason, m_nRegion, m_nRailWayVehicleKind, m_nDegree, m_nLocation, m_nEffective;
        int m_nPKEarlyAccident;

        Guid m_strSerialId;

        /// <summary>
        /// filename or path
        /// </summary>
        string m_strReportSource;

        #endregion

        #region Property

        public ReportIdType ReportId
        {
            get
            {
                return (m_ReportId);
            }
            set
            {
                m_ReportId = value;
            }
        }

        public string Titr
        {
            get
            {
                return (m_strTitr);
            }
            set
            {
                m_strTitr = value;
            }
        }

        public string SubTitle
        {
            get
            {
                return (m_strSubTitle);
            }
            set
            {
                m_strSubTitle = value;
            }
        }

        public string Footer
        {
            get
            {
                return (m_strFooter);
            }
            set
            {
                m_strFooter = value;
            }
        }

        public string PrintPDate
        {
            get
            {
                return (m_strPrintPDate);
            }
            set
            {
                m_strPrintPDate = value;
            }
        }



        public int PKEarlyAccident
        {
            get
            {
                return (m_nPKEarlyAccident);
            }
            set
            {
                m_nPKEarlyAccident = value;
            }
        }

        
        public Guid SerialId
        {
            get
            {
                return (m_strSerialId);
            }
            set
            {
                m_strSerialId = value;
            }
        }

        public string BeginDate
        {
            get
            {
                return (m_strBeginDate);
            }
            set
            {
                m_strBeginDate = value;
            }
        }
        public string EndDate
        {
            get
            {
                return (m_strEndDate);
            }
            set
            {
                m_strEndDate = value;
            }
        }

        public int Category
        {
            get
            {
                return (m_nCategory);
            }
            set
            {
                m_nCategory = value;
            }
        }

        public int Reason
        {
            get
            {
                return (m_nReason);
            }
            set
            {
                m_nReason = value;
            }
        }
        
        public int AccidentKind
        {
            get
            {
                return (m_nAccidentKind);
            }
            set
            {
                m_nAccidentKind = value;
            }
        }
        public int Degree
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
        public int RailWayVehicleKind
        {
            get
            {
                return (m_nRailWayVehicleKind);
            }
            set
            {
                m_nRailWayVehicleKind = value;
            }
        }
        public int Region
        {
            get
            {
                return (m_nRegion);
            }
            set
            {
                m_nRegion = value;
            }
        }
        public int Location
        {
            get
            {
                return (m_nLocation);
            }
            set
            {
                m_nLocation = value;
            }
        }

        public int Effective
        {
            get
            {
                return (m_nEffective);
            }
            set
            {
                m_nEffective = value;
            }
        }

        public string ShowColumn
        {
            get
            {
                return (m_strShowColumn);
            }
            set
            {
                m_strShowColumn = value;
            }
        }

        public string GroupFieldName
        {
            get
            {
                return (m_strGroupFieldName);
            }
            set
            {
                m_strGroupFieldName = value;
            }
        }

        public string RegionDesc
        {
            get
            {
                return (m_strRegionDesc);
            }
            set
            {
                m_strRegionDesc = value;
            }
        }
        public string JobDesc
        {
            get
            {
                return (m_strJobDesc);
            }
            set
            {
                m_strJobDesc = value;
            }
        }
        public string PersonName
        {
            get
            {
                return (m_strPersonName);
            }
            set
            {
                m_strPersonName = value;
            }
        }

        public string StringParam
        {
            get
            {
                return (m_strStringParam);
            }
            set
            {
                m_strStringParam = value;
            }
        }

        #endregion
        
    }
}
