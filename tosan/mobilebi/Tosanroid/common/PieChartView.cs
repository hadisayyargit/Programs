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
using Android.Util;

namespace com.ant.liao
{
    public class PieChartView : View
    {
        /**背景色 backcolor*/
        private Color backColor = Color.White;

        private int piePaddingLeft = 15;
        private int piePaddingTop = 15;
        private int piePaddingRight = 15;
        private int piePaddingBottom = 15;
        private int specialSpace = 10;

        private int rightSpace = 100;

        /**数据 the data*/
        private float[] data = null;
        /**每个数据对应的标题 the data title*/
        private String[] title = null;

        private Color defColor = Color.Green;
        /**数据的颜色 data color*/
        private Color[] color = null;

        private float sumData = 0;

        private int dataCount = 0;

        private int specialIndex = -1;

        private float startAngle = 30;

        private int barWidth = 15;

        //private Color textColor = new Color(0xaa3333);
        private Color textColor = Color.Bisque;


        public PieChartView(Context context)
            : base(context)
        {

        }

        public PieChartView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
        }

        public PieChartView(Context context, IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {


        }

        public void setSpecial(int index)
        {
            if (data != null && dataCount > index)
            {
                specialIndex = index;
            }
        }


        public void setDataCount(int count)
        {
            if (count > 0)
            {
                data = new float[count];
                title = new String[count];
                dataCount = count;
                color = new Color[count];
                for (int i = 0; i < count; i++)
                {
                    color[i] = defColor;
                }
            }
        }


        public void setData(float[] d)
        {
            if (d != null && d.Length == dataCount)
            {
                for (int i = 0; i < dataCount; i++)
                {
                    sumData += d[i];
                }
                data = d;
            }
        }


        public void setData(int index, float d)
        {
            if (data != null && dataCount > index)
            {
                sumData -= data[index];
                data[index] = d;
                sumData += d;
            }
        }


        public void setDataTitle(String[] desc)
        {
            if (desc != null && dataCount == desc.Length)
            {
                title = desc;
            }
        }


        public void setDataTitle(int index, String desc)
        {
            if (title != null && dataCount > index)
            {
                title[index] = desc;
            }
        }


        public void setColor(Color[] c)
        {
            if (color != null && c.Length == dataCount)
            {
                color = c;
            }
        }

        public void setColor(int index, Color c)
        {
            if (color != null & dataCount > index)
            {
                color[index] = c;
            }
        }

        public void setBackgroundColor(Color color)
        {
            backColor = color;
        }

        protected override void OnDraw(Canvas canvas)
        {
            int paddingLeft = PaddingLeft;
            int paddingRight = PaddingRight;
            int paddingTop = PaddingTop;
            int paddingBottom = PaddingBottom;

            int height = Height - paddingTop - paddingBottom;
            int width = Width - paddingLeft - paddingRight;

            if (data != null)
            {
                canvas.Save();
                canvas.Translate(paddingLeft, paddingTop);
                canvas.ClipRect(0, 0, width, height);

                canvas.DrawColor(backColor);


                int w = width - piePaddingLeft - piePaddingRight - rightSpace;
                int h = height - piePaddingTop - piePaddingBottom;

                int r = w;
                if (w > h)
                    r = h;

                RectF rf = new RectF(piePaddingLeft, piePaddingTop, piePaddingLeft + r, piePaddingTop + r);

                Paint paint = new Paint();
                paint.AntiAlias = (true);
                paint.SetStyle(Paint.Style.Fill);

                float ang = startAngle;

                float[] percent = new float[dataCount];

                for (int i = 0; i < data.Length; i++)
                {
                    paint.Color = (color[i]);
                    float tmp = data[i] / (sumData * 1.0f);
                    percent[i] = tmp;
                    tmp = tmp * 360;


                    float toang = (float)(Math.Round(tmp));


                    if (specialIndex == i)
                    {
                        float ds = (ang + toang / 2);
                        float dy = (float)Math.Abs((specialSpace * Math.Sin(ds * 0.01745)));
                        float dx = (float)Math.Abs((specialSpace * Math.Cos(ds * 0.01745)));
                        if (ds > 0 && ds <= 90)
                        {

                        }
                        else if (ds > 90 && ds <= 180)
                        {
                            dx = dx * (-1);
                        }
                        else if (ds > 180 && ds <= 270)
                        {
                            dx = dx * (-1);
                            dy = dy * (-1);
                        }
                        else if (ds > 270)
                        {
                            dy = dy * (-1);
                        }
                        RectF sf = new RectF(piePaddingLeft + dx, piePaddingTop + dy, piePaddingLeft + dx + r, piePaddingTop + r + dy);
                        canvas.DrawArc(sf, ang, toang, true, paint);
                    }
                    else
                        canvas.DrawArc(rf, ang, toang, true, paint);

                    ang += toang;

                }


                Paint.FontMetrics fm = paint.GetFontMetrics();
                float texty = piePaddingTop - fm.Ascent;
                float textx = piePaddingLeft + r + 35;
                for (int i = 0; i < dataCount; i++)
                {
                    paint.Color = (color[i]);
                    canvas.DrawRect(textx, texty, textx + barWidth, texty + barWidth, paint);
                    paint.Color = (textColor);
                    canvas.DrawText(String.Format("%.1f%%", percent[i] * 100), textx + barWidth + 10, texty - fm.Ascent, paint);
                    texty += fm.Descent - fm.Ascent + 15;
                }

                canvas.Restore();
            }
        }
    }
}
    