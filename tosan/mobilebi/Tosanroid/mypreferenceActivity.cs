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
using Android.Preferences;


namespace Tosanroid
{
    [Activity(Label = "My Activity")]
    public class mypreferenceActivity : PreferenceActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //AddPreferencesFromResource(Resource.Layout.my);
            //SetContentView(Resource.Layout.frmMain);

        }
    }
}