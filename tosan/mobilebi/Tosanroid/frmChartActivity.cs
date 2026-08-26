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
using Android.Graphics;
using com.ant.liao;
using Java.Lang;

namespace Tosanroid
{
    [Activity(Label = "My Activity")]
    public class frmChartActivity : Activity
    {
        private CurveChartView mycurvechart2 = null;
        public bool isRun = true;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.frmChart);

            float d = 0;
            float sp = 0.1f;
            float[] data = new float[100];
            float[] data1 = new float[100];
            float[] data2 = new float[100];
            for (int i = 0; i < 100; i++)
            {

                data[i] = (float)(Java.Lang.Math.Sin(d) * 10);
                data1[i] = (float)(Java.Lang.Math.Cos(d) * 5);
                data2[i] = 3 * data[i] - data1[i] * data1[i] * 2;
                d += sp;

            }           
                        
            CurveChartView mycurvechart1 = (CurveChartView)FindViewById(Resource.Id.chart);
            mycurvechart1.setCurveCount(3);
            mycurvechart1.setCurveColor(new Color[] { Color.Yellow, Color.Blue, Color.Red });
            mycurvechart1.setCalibrationOn(true);
            mycurvechart1.setData(0, data);
            mycurvechart1.setData(1, data1);
            mycurvechart1.setData(2, data2);

            mycurvechart2 = (CurveChartView)FindViewById(Resource.Id.dchart);
            mycurvechart2.setCurveStatic(false);
            mycurvechart2.setCurveCount(2);
            mycurvechart2.setCalibrationLeft(true);
            mycurvechart2.setCurveColor(new Color[] { Color.Blue, Color.Yellow });
            mycurvechart2.setCalibrationOn(true);
            mycurvechart2.setCalibrationLeft(true);
            mycurvechart2.setDataScope(0, 100);

            DataThread dt = new DataThread();
            dt.Start();           

            PieChartView mypiechart = (PieChartView)FindViewById(Resource.Id.pie);
            mypiechart.setDataCount(5);
            mypiechart.setColor(new Color[] { Color.Yellow, Color.Blue, Color.Gray, Color.Magenta, Color.Red });
            mypiechart.setData(new float[] { 200, 700, 45, 190, 409 });
            mypiechart.setSpecial(4);
           
            BarChartView mybarchart = (BarChartView)FindViewById(Resource.Id.bar);
            mybarchart.setGroupCount(3);
            mybarchart.setDataCount(3);
            mybarchart.setGroupData(0, new float[] { 277f, 2101f, 3222f });
            mybarchart.setGroupData(1, new float[] { 1213f, 11194f, 444f });
            mybarchart.setGroupData(2, new float[] { 193f, 2645f, 858f });
            mybarchart.setBarColor(new Color[] { Color.Yellow, Color.Blue, Color.Green });
            mybarchart.setDataTitle(new string[] { "نمودار میله ای", "Title", "123234" });
            mybarchart.setGroupTitle(new string[] { "group1", "group2", "group3" });    
        }

            private static Handler handler = new Handler();

        public void handleMessage(Message msg) 
        {
            Bundle d = msg.Data;
            float d1 = d.GetFloat("d1");
            float d2 = d.GetFloat("d2");
            mycurvechart2.appendData(new float[] { d1, d2 });
        }    

        class DataThread : Thread
        {
            private float d = 0;
            private float sp = 0.1f;

            private int t = 1;
            private bool flat = true;

            public override void Run()
            {
                while (true)
                {
                    float d1 = (float)(System.Math.Sin(d) * t);
                    float d2 = (float)(System.Math.Cos(d) * t);
                    Message msg = handler.ObtainMessage();
                    Bundle b = new Bundle();
                    b.PutFloat("d1", d1);
                    b.PutFloat("d2", d2);
                    msg.Data=(b);
                    handler.SendMessage(msg);
                    d += sp;
                    if (flat)
                    {
                        t++;
                        if (t > 300)
                            flat = false;
                    }
                    else
                    {
                        t--;
                        if (t <= 1)
                            flat = true;
                    }

                    SystemClock.Sleep(200);
                }
            }
        }

    }


    
}