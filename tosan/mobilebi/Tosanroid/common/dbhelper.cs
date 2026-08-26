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
using Android.Database.Sqlite;
using Android.Util;

namespace Tosanroid
{
    public class dbhelper : SQLiteOpenHelper
    {
        public  const String DB_PATH = "/data/data/com.tosan.tosanroid/databases/";
        public  const String DATABASE_NAME = "tosanlite.db";

        public dbhelper(Context context) : base(context, DATABASE_NAME, null, 1) 
        {
        }
		
        public override void OnCreate(SQLiteDatabase db)
        {
            Log.Verbose("onCreate", "creating all the tables");
        }
        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            Android.Util.Log.Warn("Constants", "Upgrading database, which will destroy all old	data");
            db.ExecSQL("DROP TABLE IF EXISTS constants");
            OnCreate(db);

        }
    }
}