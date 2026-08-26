using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tosanroid
{
    [Serializable]
    public class ReportClass
    {

        public string ReportTitle
        {
            get;
            set;
        }

        public int ReportNo
        {
            get;
            set;
        }

        public string ReportPath
        {
            get;
            set;
        }
   

    }
}