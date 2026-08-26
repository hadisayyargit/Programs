using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;

namespace Tosanroid
{
    [Activity(Label = "frmDashboardsActivity")]
    public class frmDashboardsActivity : Activity
    {
        int count = 1;
        bool bAuthenticated;
        ReportClass myReport = new ReportClass();

        void showmessage(String msg)
        {
            AlertDialog myDialog = new AlertDialog.Builder(this).Create();
            //myDialog.setTitle("هشدار");
            myDialog.SetMessage(msg);
            myDialog.SetButton(GetString(Resource.String.ok), delegate { });

            myDialog.Show();

        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmDashboards);

            RequestedOrientation = ScreenOrientation.Portrait;

            Button btnKoli = (Button)FindViewById(Resource.Id.btnKoli);            
            Button btnNaghdinegi = (Button)FindViewById(Resource.Id.btnNaghdinegi);
            Button btnMasaref = (Button)FindViewById(Resource.Id.btnMasaref);
            Button btnManabe = (Button)FindViewById(Resource.Id.btnManabe);            
            Button btnDemo = (Button)FindViewById(Resource.Id.btnDemo);

            //btnKoli.Click += delegate { btnKoli.Text = string.Format("{0} داشبورد مدیریتی!", count++); };
            btnKoli.Click += new EventHandler(btnKoli_click);
            btnNaghdinegi.Click += new EventHandler(btnNaghdinegi_click);
            btnMasaref.Click += new EventHandler(btnMasaref_click);
            btnManabe.Click += new EventHandler(btnManabe_click);
            btnDemo.Click += new EventHandler(btnDemo_click);
        }

        protected override void OnStart()
        {
            Locale mylocale = new Locale(commonclass.currentlocale);
            Configuration myconfig = BaseContext.Resources.Configuration;

            if (!myconfig.Locale.Equals(mylocale))
            {
                Locale.Default = mylocale;
                myconfig.Locale = mylocale;
                BaseContext.Resources.UpdateConfiguration(myconfig, null);
            }


            bAuthenticated = false;

            //bAuthenticated = true;

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
            

            base.OnStart();
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

        void btnKoli_click(object sender, EventArgs e)
        {
            Bundle mybundle = new Bundle();
            Intent myintent1 = new Intent(this, typeof(frmReportViewerActivity));

            ///for chart test

            /*
                    Intent myintent = new Intent(MainActivity.this,
                            frmchartActivity.class);

                    startActivity(myintent);
                */


            if (bAuthenticated)
            {
                // myintent.putExtra("ReportTitle","گزارش کلی");
                myReport.ReportTitle = "Overall Condition";
                myReport.ReportNo = 1;
                myReport.ReportPath = "/Mobile_Bi/داشبورد_وضعیت_کلی_بانک";
                //mybundle.PutSerializable("ReportClass", myReport);
                mybundle.PutString("ReportTitle", myReport.ReportTitle);
                mybundle.PutString("ReportNo", myReport.ReportNo.ToString());
                mybundle.PutString("ReportPath", myReport.ReportPath);

                myintent1.PutExtras(mybundle);
                //myintent1.Put


                StartActivity(myintent1);
            }
            else
                showmessage("کاربر نامعتبر است");


        }

        void btnNaghdinegi_click(object sender, EventArgs e)
        {
            Bundle mybundle = new Bundle();
            Intent myintent1 = new Intent(this, typeof(frmReportViewerActivity));


            if (bAuthenticated)
            {
                // myintent.putExtra("ReportTitle","گزارش وضعیت نقدینگی");
                myReport.ReportTitle = "Cash Position";
                myReport.ReportNo = 2;
                myReport.ReportPath = "/Mobile_Bi/وضعیت_نقدینگی";
                //mybundle.PutSerializable("ReportClass", myReport);
                mybundle.PutString("ReportTitle", myReport.ReportTitle);
                mybundle.PutString("ReportNo", myReport.ReportNo.ToString());
                mybundle.PutString("ReportPath", myReport.ReportPath);

                myintent1.PutExtras(mybundle);
                //myintent1.Put


                StartActivity(myintent1);
            }
            else
                showmessage("کاربر نامعتبر است");


        }

        void btnMasaref_click(object sender, EventArgs e)
        {

            Bundle mybundle = new Bundle();
            Intent myintent1 = new Intent(this, typeof(frmReportViewerActivity));


            if (bAuthenticated)
            {
                // myintent.putExtra("ReportTitle","گزارش وضعیت نقدینگی");
                myReport.ReportTitle = "Uses Condition";
                myReport.ReportNo = 3;
                myReport.ReportPath = "/Mobile_Bi/وضعیت_مصارف";
                //mybundle.PutSerializable("ReportClass", myReport);
                mybundle.PutString("ReportTitle", myReport.ReportTitle);
                mybundle.PutString("ReportNo", myReport.ReportNo.ToString());
                mybundle.PutString("ReportPath", myReport.ReportPath);

                myintent1.PutExtras(mybundle);
                //myintent1.Put


                StartActivity(myintent1);
            }
            else
                showmessage("کاربر نامعتبر است");


        }

        void btnManabe_click(object sender, EventArgs e)
        {
            Bundle mybundle = new Bundle();
            Intent myintent1 = new Intent(this, typeof(frmReportViewerActivity));


            if (bAuthenticated)
            {
                // myintent.putExtra("ReportTitle","گزارش وضعیت نقدینگی");
                myReport.ReportTitle = "Resources Condition";
                myReport.ReportNo = 4;
                myReport.ReportPath = "/Mobile_Bi/وضعیت_منابع";
                //mybundle.PutSerializable("ReportClass", myReport);
                mybundle.PutString("ReportTitle", myReport.ReportTitle);
                mybundle.PutString("ReportNo", myReport.ReportNo.ToString());
                mybundle.PutString("ReportPath", myReport.ReportPath);

                myintent1.PutExtras(mybundle);
                //myintent1.Put


                StartActivity(myintent1);
            }
            else
                showmessage("کاربر نامعتبر است");

        }

        void btnDemo_click(object sender, EventArgs e)
        {
            ///for chart test
            Intent myintent = new Intent(this, typeof(frmChartActivity));
            StartActivity(myintent);
        }
    }
}