using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Reporting.WebForms;
using System.Net;
using System.Security.Principal;

namespace GlobalUnits
{

    [Serializable]
    public sealed class ReportServerCredentials : IReportServerCredentials
    {
        public ReportServerCredentials()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //C:\Windows\assembly\GAC_MSIL\Microsoft.ReportViewer.WebForms\11.0.0.0__89845dcd8080cc91\Microsoft.ReportViewer.WebForms.DLL

        public ReportServerCredentials(string userName, string password)
        {
            networkCredentials = new NetworkCredential(userName, password);
        }

        public WindowsIdentity ImpersonationUser
        {
            get
            {
                // Use the default Windows user.  Credentials will be
                // provided by the NetworkCredentials property.
                return null;
            }
        }

        private ICredentials networkCredentials;
        public ICredentials NetworkCredentials
        {
            get { return networkCredentials; }
        }

        public bool GetFormsCredentials(out Cookie authCookie,
                    out string userName, out string password,
                    out string authority)
        {
            authCookie = null;
            userName = null;
            password = null;
            authority = null;

            // Not using form credentials
            return false;
        }


    }
}
