using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tosanroid
{
    [Activity(Label = "Configurations")]
    public class frmSettingsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
                       
            SetContentView(Resource.Layout.frmSettings);

            RequestedOrientation = ScreenOrientation.Portrait;

            this.Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            Button btnApply = (Button)FindViewById(Resource.Id.btnApply);

            btnApply.Click += new EventHandler(btnApply_click);

        }

        void showmessage(String msg)
        {
            AlertDialog myDialog = new AlertDialog.Builder(this).Create();
            //myDialog.setTitle("هشدار");
            myDialog.SetMessage(msg);
            myDialog.SetButton(GetString(Resource.String.ok), delegate { });            

            myDialog.Show();
        }

        protected override void OnStart()
        {
            ISharedPreferences prefs = GetPreferences(FileCreationMode.Private);

            commonclass.Internet_Server = prefs.GetString("Internet_Server", commonclass.Internet_Server);
            commonclass.Local_Server = prefs.GetString("Local_Server", commonclass.Local_Server);
            commonclass.mobilebiserviceurl = prefs.GetString("mobilebiserviceurl", commonclass.mobilebiserviceurl);

            commonclass.presenter_server = prefs.GetString("presenter_server", commonclass.Internet_Server);
            commonclass.presenter_port = prefs.GetString("presenter_port", "80");
            commonclass.connectionchannel = prefs.GetString("connectionchannel", "gprs");

            RadioButton rdoGprs = (RadioButton)FindViewById(Resource.Id.rdoGprs);
            RadioButton rdoWifi = (RadioButton)FindViewById(Resource.Id.rdoWifi);

            EditText txtInternetServer = (EditText)FindViewById(Resource.Id.txtInternetServer);
            EditText txtLocalServer = (EditText)FindViewById(Resource.Id.txtLocalServer);
            EditText txtReportPresenterPort = (EditText)FindViewById(Resource.Id.txtReportPresenterPort);
            EditText txtWcfService = (EditText)FindViewById(Resource.Id.txtWcfService);

            if (commonclass.connectionchannel == "wifi")
                rdoWifi.Checked = true;
            else
                rdoGprs.Checked = true;

            txtInternetServer.Text = commonclass.Internet_Server;
            txtLocalServer.Text = commonclass.Local_Server;
            txtReportPresenterPort.Text = commonclass.presenter_port;
            txtWcfService.Text = commonclass.mobilebiserviceurl;

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

        void btnApply_click(object sender, EventArgs e)
        {
            RadioGroup g1 = (RadioGroup)FindViewById(Resource.Id.radioGroup1);
            RadioButton r1 = (RadioButton)FindViewById(g1.CheckedRadioButtonId);

            EditText txtInternetServer = (EditText)FindViewById(Resource.Id.txtInternetServer);
            EditText txtLocalServer = (EditText)FindViewById(Resource.Id.txtLocalServer);
            EditText txtReportPresenterPort = (EditText)FindViewById(Resource.Id.txtReportPresenterPort);
            EditText txtWcfService = (EditText)FindViewById(Resource.Id.txtWcfService);

            //ISharedPreferences prefs = this.GetSharedPreferences("mypreference", FileCreationMode.Private);
            //ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
            ISharedPreferences prefs = GetPreferences(FileCreationMode.Private);
            ISharedPreferencesEditor prefeditor = prefs.Edit();

            commonclass.Internet_Server = txtInternetServer.Text;
            commonclass.Local_Server = txtLocalServer.Text;
            commonclass.presenter_port = txtReportPresenterPort.Text;
            commonclass.mobilebiserviceurl = txtWcfService.Text;

            if (r1.Id == Resource.Id.rdoWifi)
            {
                commonclass.connectionchannel = "wifi";
                commonclass.presenter_server = commonclass.Local_Server;
            }
            else
            {
                commonclass.connectionchannel = "gprs";
                commonclass.presenter_server = commonclass.Internet_Server;
            }

            prefeditor.PutString("connectionchannel", commonclass.connectionchannel);
            prefeditor.PutString("presenter_server", commonclass.presenter_server);
            prefeditor.PutString("presenter_port", commonclass.presenter_port);
            prefeditor.PutString("Internet_Server", commonclass.Internet_Server);
            prefeditor.PutString("Local_Server", commonclass.Local_Server);
            prefeditor.PutString("mobilebiserviceurl", commonclass.mobilebiserviceurl);

            prefeditor.Commit();
            showmessage("تنظیمات ذخیره شد");
        }
 

    }
}