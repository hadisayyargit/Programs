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
using Java.Util;
using Android.Content.Res;
using Android;

namespace Tosanroid
{
    [Activity(Label = "Tosanroid2", MainLauncher=true)]
    public class frmSplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmSplash);

            ImageButton btnPersian = FindViewById<ImageButton>(Resource.Id.btnPersian);
            ImageButton btnEnglish = FindViewById<ImageButton>(Resource.Id.btnEnglish);

            btnPersian.Click += new EventHandler(btnPersian_click);

            btnEnglish.Click += new EventHandler(btnEnglish_Click);

            //btnHome.Click += delegate { btnHome.Text = string.Format("{0} داشبورد مدیریتی!", count++); };
        }

        void btnPersian_click(object sender, EventArgs e)
        {
            commonclass.currentlocale = "fa";
            //Locale.setDefault(new Locale("fa-IR"));
            Locale mylocale = new Locale("fa");
            //Locale.setDefault(mylocale1);
            Locale.Default = mylocale;

            //Locale.setDefault(new Locale("en-CA"));

            Configuration myconfig = BaseContext.Resources.Configuration;
            //Configuration myconfig1 = getBaseContext().getResources().getConfiguration(); 

            if (!myconfig.Locale.Equals(mylocale))
            {
                myconfig.Locale = mylocale;
                BaseContext.Resources.UpdateConfiguration(myconfig, null);

            }

            Intent myIntent = new Intent(this, typeof(frmLoginActivity));

            StartActivity(myIntent);
          
        }

        void btnEnglish_Click(object sender, EventArgs e)
        {
            commonclass.currentlocale = "en";
            Locale mylocale = new Locale("en");
            Locale.Default = mylocale;

            Configuration myconfig = BaseContext.Resources.Configuration;
            if (!myconfig.Locale.Equals(mylocale))
            {
                myconfig.Locale = mylocale;
                BaseContext.Resources.UpdateConfiguration(myconfig, null);
            }


            //Intent myintent = new Intent(mainActivity.this,						frmSplashActivity.class);
            Intent myIntent = new Intent(this, typeof(frmLoginActivity));
            StartActivity(myIntent);

            //SharedPreferences prefs = PreferenceManager.getDefaultSharedPreferences(this);            
            //Java.Util.Locale 
        }



        
    }
}