using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Java.Util;
using Android.Content.Res;
using Android.Preferences;

namespace Tosanroid
{
    [Activity(Label = "mainActivity", MainLauncher = false, Icon = "@drawable/icon")]
    public class frmMainActivity : Activity
    {
        ReportClass myReport = new ReportClass();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmMain);

            RequestedOrientation = ScreenOrientation.Portrait;

            Button btnDashboards = (Button)FindViewById(Resource.Id.btnDashboards);
            Button btnChangepassword = (Button)FindViewById(Resource.Id.btnChangepassword);
            Button btnSettings = (Button)FindViewById(Resource.Id.btnSettings);
            Button btnAbout = (Button)FindViewById(Resource.Id.btnAbout);

            btnDashboards.Click += new EventHandler(btnDashboards_click);
            btnChangepassword.Click += new EventHandler(btnChangepassword_click);
            btnSettings.Click += new EventHandler(btnSettings_click);
            btnAbout.Click += new EventHandler(btnAbout_click);
        }

        protected override void OnStart()
        {
            /*
            Locale mylocale = new Locale(commonclass.currentlocale);
            Configuration myconfig = BaseContext.Resources.Configuration;

            if (!myconfig.Locale.Equals(mylocale))
            {
                Locale.Default = mylocale;
                myconfig.Locale = mylocale;
                BaseContext.Resources.UpdateConfiguration(myconfig, null);
            }


            bAuthenticated = false;


            try
            {
                String s1 = commonclass.authenticateuser(commonclass.currentuser, commonclass.currentuserpassword);

                if (s1.StartsWith("true"))
                    bAuthenticated = true;
            }
            catch (Exception e)
            {
                showmessage("خطا");
            }
            
   
             */

            base.OnStart();
        }

        void showmessage(String msg)
        {
            AlertDialog myDialog = new AlertDialog.Builder(this).Create();
            //myDialog.setTitle("هشدار");
            myDialog.SetMessage(msg);
            myDialog.SetButton(GetString(Resource.String.ok), delegate { });

            myDialog.Show();

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            new MenuInflater(this).Inflate(Resource.Menu.menuFooter, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case (Resource.Id.mniHelp):
                    Intent myintent = new Intent(this, typeof(frmHelpActivity));
                    StartActivity(myintent);

                    break;
                case (Resource.Id.mniHome):
                    Intent myintent1 = new Intent(this, typeof(frmSplashActivity));
                    StartActivity(myintent1);
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }

        void btnDashboards_click(object sender, EventArgs e)
        {
            Intent myintent1 = new Intent(this, typeof(frmDashboardsActivity));
            StartActivity(myintent1);
        }

        void btnChangepassword_click(object sender, EventArgs e)
        {
            Intent myintent1 = new Intent(this, typeof(frmPasswordChangeActivity));
            StartActivity(myintent1);
        }
        void btnAbout_click(object sender, EventArgs e)
        {
            Intent myintent = new Intent(this, typeof(frmAboutActivity));
            StartActivity(myintent);
        }

        void btnSettings_click(object sender, EventArgs e)
        {
            Intent myintent1 = new Intent(this, typeof(frmSettingsActivity));
            StartActivity(myintent1);
        }

    }
}

