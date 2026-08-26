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
using Android.Content.PM;
using Java.Util;
using Android.Content.Res;


namespace Tosanroid
{
    [Activity(Label = "ورود")]
    public class frmLoginActivity : Activity
    {
        void showmessage(String msg)
        {
            AlertDialog myDialog = new AlertDialog.Builder(this).Create();
            //myDialog.setTitle("هشدار");
            myDialog.SetMessage(msg);
            myDialog.SetButton(GetString(Resource.String.ok), delegate { });

            myDialog.Show();

        }

        /*
        private Boolean AuthenticateUser()
        {
            Boolean bres;

            bres = false;

            DbClass db = new DbClass(this);

            try
            {
                db.open();
            }
            catch (Exception ex)
            {
                //bres=false;
                //showmessage(ex.toString());
                showmessage("اتصال به بانک اطلاعات صورت نمی پذیرد");
                return false;
            }

            try
            {
                AppUser myUser = new AppUser();
                String strUserid = "", strPassword = "";
                EditText txtUserId = (EditText)findViewById(R.id.txtUserId);
                EditText txtPassword = (EditText)findViewById(R.id.txtPassword);
                strUserid = txtUserId.getText().toString();
                strPassword = txtPassword.getText().toString();

                myUser = db.getAppUser(strUserid);
                //if(myUser.password!=null && myUser.password==strPassword)
                if (myUser.password != null && myUser.password.compareTo(strPassword) == 0)
                    bres = true;

                //
                db.close();
            }

            catch (Exception ex)
            {
                //bres=false;
                //showmessage(ex.toString());
                showmessage("خطا در اجرای پرس و جو");
            }

            return bres;
        }	
         */

        protected override void OnCreate(Bundle bundle)
        {
            SetContentView(Resource.Layout.frmLogin);

            Button btnOk = (Button)FindViewById(Resource.Id.btnOk);

            ImageView imageUsers = (ImageView)FindViewById(Resource.Id.imageUsers);

            RequestedOrientation = ScreenOrientation.Portrait;
            this.Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            btnOk.Click += new EventHandler(btnOk_click);
            imageUsers.Click += new EventHandler(imageUsers_click);

            base.OnCreate(bundle);

        }

        void btnOk_click(object sender, EventArgs e)
        {
            /*
                if(!AuthenticateUser())
                {   
                    showmessage("شناسه کاربر یا گذرواژه نامعتبر است");
                }

                else
                {
                */
            
            EditText txtUserId = (EditText)FindViewById(Resource.Id.txtUserId);
            EditText txtPassword = (EditText)FindViewById(Resource.Id.txtPassword);

            commonclass.currentuser = txtUserId.Text;
            commonclass.currentuserpassword = txtPassword.Text;

            Intent myintent1 = new Intent(this, typeof(frmMainActivity));
            StartActivity(myintent1);
        }

        void imageUsers_click(object sender, EventArgs e)
        {
            EditText txtUserId = (EditText)FindViewById(Resource.Id.txtUserId);
            EditText txtPassword = (EditText)FindViewById(Resource.Id.txtPassword);
            String s1 = commonclass.authenticateuser(txtUserId.Text, txtPassword.Text);

            try
            {
                if (s1.StartsWith("true"))
                    showmessage("کاربر معتبر است");
                else
                    showmessage("کاربر نامعتبر است");

            }
            catch
            {
                showmessage("خطا");
            }
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

            /*
            MyDb db=new MyDb(this);
		
            try
            {
                db.createDataBase();
            }
            catch(Exception ex)
            {
                showmessage("اتصال به بانک اطلاعات صورت نمی پذیرد");				
            }
		
            */

            base.OnStart();
        }


        /// <summary>
        /// todo
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
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
                    break;
                case (Resource.Id.mniHome):
                    Intent myintent1 = new Intent(this, typeof(frmSplashActivity));
                    StartActivity(myintent1);
                    break;
            }


            return base.OnOptionsItemSelected(item);
        }
        public override void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
        {
            base.OnCreateContextMenu(menu, v, menuInfo);
        }

    }
}