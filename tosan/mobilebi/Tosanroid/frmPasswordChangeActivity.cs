using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tosanroid
{
    [Activity(Label = "My Activity")]
    public class frmPasswordChangeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmPasswordChange);

            RequestedOrientation = ScreenOrientation.Portrait;

            this.Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            Button btnGoMaster = (Button)FindViewById(Resource.Id.btnGoMaster);

            btnGoMaster.Click += new EventHandler(btnGoMaster_click);
        }

        
        void btnGoMaster_click(object sender, EventArgs e)
        {
            Intent myintent = new Intent(this, typeof(frmMainActivity));
            StartActivity(myintent);
        }
        
    }
}