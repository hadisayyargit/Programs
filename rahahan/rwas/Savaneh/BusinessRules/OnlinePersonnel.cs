using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RWAS.DataAccess;

namespace RWAS.BusinessRules
{
    public class OnlinePersonnel
    {

        #region Property


        public string UniqueCode
        {
            get
            {
                return (m_strUniqueCode);
            }

            set
            {
                m_strUniqueCode = value;
            }
        }

        public string FirstName
        {
            get
            {
                return (m_strFirstName);
            }

            set
            {
                m_strFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return (m_strLastName);
            }

            set
            {
                m_strLastName = value;
            }
        }


        #endregion

        #region Private


        public string m_strUniqueCode;
        public string m_strPersonelID;
        public string m_strFirstName;
        public string m_strLastName;
        public string m_strfk_Job;
        public string m_strfk_Job2;
        public string m_strJobHistory;
        public string m_strLastJobHistory;
        public string m_strJob2Describe;
        public string m_strJobDescribe;
        public string m_strMaritalStatus;
        public string m_strBirthYear;
        public string m_strfk_StudyStatus;
        public string m_strfk_EmployeeStatus;
        public string m_strStudyStatusDescribe;
        public string m_strEmployeeStatusDescribe;
        public string m_strfk_Region;
        public string m_strRegionDescribe;
        public string m_strEmployeeDate;
        public string m_strAddress;
        public string m_strTelNo;
        public string m_strfk_OrgUnit;
        public string m_strOrgUnitDescribe;



        #endregion
    }
}
