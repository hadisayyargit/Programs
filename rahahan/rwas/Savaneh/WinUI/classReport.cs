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

        public enum ReportIdType { reportAccident, reportAccidentStatistics,reportAccidentStatistics_Matrix, reportAccidentBlockStatistics, reportCroquis, reportTrainArrangement, reportAccidentMedia,
            reportHumanDelinquent, reportHumanDelinquentStatistics, reportWagonDelinquent, reportWagonDelinquentStatistics,
            reportLoss, reportLossStatistics, reportDieAndAfoul, reportDieAndAfoulStatistics, reportAgentDieAndAfoul, reportAgentDieAndAfoulStatistics,reportTest
            , reportSeir
        }


        #endregion

        #region Private

        ReportIdType m_ReportId;
        string m_strTitr, m_strSubTitle, m_strFooter, m_strPrintPDate, m_strStringParam;
        string m_strBeginDate, m_strEndDate, m_strGroupColumn1, m_strGroupColumn2, m_strGroupColumn3, m_strGroupColumn4, m_strSortColumn1, m_strSortColumn2, m_strSortColumn3;
        string m_nCategoryList, m_nAccidentKindList, m_nReasonList, m_nRegionList, m_nRailWayVehicleKindList, m_nDegreeList, m_nLocationList, m_nEffectiveList;
        int m_nPKEarlyAccident, m_nTrainNo;
        double m_nShowColumn;
        sbyte m_nHasLoss, m_nHasAfoul, m_nHasBlameful, m_nHasDie, m_nHasBarred, m_nHasManouver;

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

        public string CategoryList
        {
            get
            {
                return (m_nCategoryList);
            }
            set
            {
                m_nCategoryList = value;
            }
        }

        public string ReasonList
        {
            get
            {
                return (m_nReasonList);
            }
            set
            {
                m_nReasonList = value;
            }
        }

        public string AccidentKindList
        {
            get
            {
                return (m_nAccidentKindList);
            }
            set
            {
                m_nAccidentKindList = value;
            }
        }
        public string DegreeList
        {
            get
            {
                return (m_nDegreeList);
            }
            set
            {
                m_nDegreeList = value;
            }
        }
        public string RailWayVehicleKindList
        {
            get
            {
                return (m_nRailWayVehicleKindList);
            }
            set
            {
                m_nRailWayVehicleKindList = value;
            }
        }
        public string RegionList
        {
            get
            {
                return (m_nRegionList);
            }
            set
            {
                m_nRegionList = value;
            }
        }
        public string LocationList
        {
            get
            {
                return (m_nLocationList);
            }
            set
            {
                m_nLocationList = value;
            }
        }

        public string EffectiveList
        {
            get
            {
                return (m_nEffectiveList);
            }
            set
            {
                m_nEffectiveList = value;
            }
        }

        public sbyte HasLoss
        {
            get
            {
                return (m_nHasLoss);
            }
            set
            {
                m_nHasLoss = value;
            }
        }

        public sbyte HasBarred
        {
            get
            {
                return (m_nHasBarred);
            }
            set
            {
                m_nHasBarred = value;
            }
        }
        public sbyte HasManouver
        {
            get
            {
                return (m_nHasManouver);
            }
            set
            {
                m_nHasManouver = value;
            }
        }
        public sbyte HasAfoul
        {
            get
            {
                return (m_nHasAfoul);
            }
            set
            {
                m_nHasAfoul = value;
            }
        }
        public sbyte HasBlameful
        {
            get
            {
                return (m_nHasBlameful);
            }
            set
            {
                m_nHasBlameful = value;
            }
        }
        public sbyte HasDie
        {
            get
            {
                return (m_nHasDie);
            }
            set
            {
                m_nHasDie = value;
            }
        }

        public int TrainNo
        {
            get
            {
                return (m_nTrainNo);
            }
            set
            {
                m_nTrainNo = value;
            }
        }

        public double ShowColumn
        {
            get
            {
                return (m_nShowColumn);
            }
            set
            {
                m_nShowColumn = value;
            }
        }

        public string GroupColumn1
        {
            get
            {
                return (m_strGroupColumn1);
            }
            set
            {
                m_strGroupColumn1 = value;
            }
        }

        public string GroupColumn2
        {
            get
            {
                return (m_strGroupColumn2);
            }
            set
            {
                m_strGroupColumn2 = value;
            }
        }

        public string GroupColumn3
        {
            get
            {
                return (m_strGroupColumn3);
            }
            set
            {
                m_strGroupColumn3 = value;
            }
        }

        public string GroupColumn4
        {
            get
            {
                return (m_strGroupColumn4);
            }
            set
            {
                m_strGroupColumn4 = value;
            }
        }

        public string GroupDesc1
        {
            get;
            set;
        }

        public string GroupDesc2
        {
            get;
            set;
        }
        public string GroupDesc3
        {
            get;
            set;
        }
        public string GroupDesc4
        {
            get;
            set;
        }

        public string SortColumn1
        {
            get
            {
                return (m_strSortColumn1);
            }
            set
            {
                m_strSortColumn1 = value;
            }
        }

        public string SortColumn2
        {
            get
            {
                return (m_strSortColumn2);
            }
            set
            {
                m_strSortColumn2 = value;
            }
        }
        
        public string SortColumn3
        {
            get
            {
                return (m_strSortColumn3);
            }
            set
            {
                m_strSortColumn3 = value;
            }
        }

        #endregion

        
    }
}
