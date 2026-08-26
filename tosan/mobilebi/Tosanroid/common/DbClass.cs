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
using Java.IO;

namespace Tosanroid
{
    public class DbClass
    {
        private SQLiteDatabase db;
        private dbhelper mydbhelper;
        private Context mycontext;

        public DbClass(Context c)
        {
            mycontext = c;
            mydbhelper = new dbhelper(mycontext);
        }

        public void open()
        {
            try
            {
                db = mydbhelper.WritableDatabase;
                //db.openDatabase(path, factory, flags)

            }
            catch (SQLiteException ex)
            {
                Log.Verbose("Open database exception caught", ex.Message);
                db = mydbhelper.ReadableDatabase;
            }
        }

        public void close()
        {
            db.Close();
        }


        public void createDataBase()
        {
            bool dbExist = checkDataBase();

            ///this line must be dropped
            dbExist = false;

            if (dbExist)
            {
                //do nothing - database already exist
            }
            else
            {

                //By calling this method and empty database will be created into the default system path
                //of your application so we are gonna be able to overwrite that database with our database.

                //mydbhelper.ReadableDatabase;

                try
                {

                    copyDataBase();

                }
                catch (SQLiteDiskIOException e)
                {

                    throw e;

                }
            }

        }

        private bool checkDataBase()
        {

            SQLiteDatabase checkDB = null;

            try
            {
                //String myPath = DB_PATH + DATABASE_NAME;

                String myPath = dbhelper.DB_PATH + dbhelper.DATABASE_NAME;

                checkDB = SQLiteDatabase.OpenDatabase(myPath, null, DatabaseOpenFlags.OpenReadonly);

            }
            catch (SQLiteException e)
            {

                //database does't exist yet.

            }

            if (checkDB != null)
            {

                checkDB.Close();

            }

            return checkDB != null ? true : false;
        }


        private void copyDataBase()
        {


            //Open your local db as the input stream
            System.IO.Stream myInput = mycontext.Assets.Open(dbhelper.DATABASE_NAME);

            // Path to the just created empty db
            String outFileName = dbhelper.DB_PATH + dbhelper.DATABASE_NAME;

            //Open the empty db as the output stream
            OutputStream myOutput = new FileOutputStream(outFileName);

            //transfer bytes from the inputfile to the outputfile
            byte[] buffer = new byte[1024];
            int length;
            while ((length = myInput.Read(buffer, 0, 1)) > 0)
            {
                myOutput.Write(buffer, 0, length);
            }

            //Close the streams
            myOutput.Flush();
            myOutput.Close();
            myInput.Close();

        }

        public Android.Database.ICursor getAppUsers()
        {
            Android.Database.ICursor c = db.Query("AppUser", null, null, null, null, null, null);
            return c;
        }

        /*
    public AppUser getAppUser(String userid)
    {
        AppUser myUser=new AppUser();

        String[] columns={"userid","password"};
		
        try
        {
            Cursor c=db.query("AppUser", columns, "userid='"+userid+"'", null, null, null, null);
			
            if(c!=null)
            {
                c.moveToFirst();
                myUser.userid=c.getString(0);
                myUser.password=c.getString(1);
            }
        }
		
        catch(Exception ex)
        {
            //throw ex;
        }
		
        return myUser;
    }
         */
    }
}