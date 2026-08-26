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
using Android.Webkit;
using Android.Content.PM;

namespace Tosanroid
{
    [Activity(Label = "Reports")]
    public class frmReportViewerActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmReportViewer);

            RequestedOrientation = ScreenOrientation.Landscape;

            // Create your application here
        }


        protected override void OnStart()
        {
            Bundle extras = Intent.Extras;

            ReportClass myReport = new ReportClass();


            if (extras != null)
            {
                myReport.ReportTitle= extras.GetString("ReportTitle");

                //myReport = (ReportClass)extras.GetSerializable("ReportClass");

                //myReport.ReportNo = extras.GetString("ReportNo");

                myReport.ReportPath = extras.GetString("ReportPath");

            }

            String myUrl = "";

            ISharedPreferences prefs = GetPreferences(FileCreationMode.Private);
            
            //myUrl = "http://www.yahoo.com";


            /*
SharedPreferences prefs=PreferenceManager.getDefaultSharedPreferences(this);
	    	
            servername=prefs.getString("presenter_server", "");
            serverport=prefs.getString("presenter_port", "80");
	    	
             */

            myUrl = "http://" + commonclass.presenter_server + ":" + commonclass.presenter_port;
	    	
            myUrl=myUrl+"/ReportPresenter";

            myUrl=myUrl+"?reportpath="+myReport.ReportPath;                           

            try
           {
               WebView myWebView = FindViewById<WebView>(Resource.Id.webView1);
               myWebView.Settings.JavaScriptEnabled=true;
               WebSettings webSettings = myWebView.Settings;
               webSettings.BuiltInZoomControls=false;
               myWebView.SetWebViewClient(new WebViewClient());
               myWebView.LoadUrl(myUrl);
               Toast.MakeText(this, "Please Wait...", ToastLength.Long).Show();                 
           }

           catch (Exception e)
           {
               // TODO: handle exception
           } 

            base.OnStart();
        }

    }
}