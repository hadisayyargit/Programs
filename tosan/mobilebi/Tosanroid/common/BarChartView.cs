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
    public class BarChartView : View
    {
        private Color backColor = Color.White;

        private Color lineColor = Color.Gray;

        private Color textColor = Color.Gray;
        
        private int groupCount = 0;
        
        private int dataCount = 0;
        
        private float maxData = 0;

        private int maxCeil = 0;

        private int maxGrid = 10;

        private int minGrid = 2;

        private int currentGrid = 2;

        private float gridGap = 0;

        private float rightSpace = 0;

        private float bottomSpace = 40;

        private float[][] data = null;

        private Color[] barColor = null;

        private int barSpace = 10;

        private int maxDataWidth = 0;

        private float widthData = 0;

        private String[] groupTitle = null;

        private String[] dataTitle = null;



        public BarChartView(Context context):base(context)
        {
            
            //super(context);
        }

        
        public BarChartView(Context context, IAttributeSet attrs):base(context, attrs)
        {
            //super(context, attrs);
        }

        public BarChartView(Context context, IAttributeSet attrs, int defStyle):base(context, attrs,defStyle)
        {
            //super(context, attrs, defStyle);
        }

        public void setGroupCount(int count)
        {
            if (count > 0)
            {
                groupCount = count;
                data = new float[count][];
                //groupTitle = new String[count];
            }
        }

 
        public void setDataCount(int count)
        {
            if (count > 0 && data != null && data.Length > 0)
            {
                dataCount = count;
                barColor = new Color[count];
                //dataTitle = new String[count];
                for (int i = 0; i < dataCount; i++)
                {
                    barColor[i] = Color.Green;
                }
            }
        }

        public void setGroupTitle(String[] title)
        {
            if (title != null && groupCount == title.Length)
            {
                groupTitle = title;
            }
        }

        public void setDataTitle(String[] title)
        {
            if (title != null && dataCount == title.Length)
            {
                dataTitle = title;
            }
        }

  
        public void setGroupData(int index, float[] d)
        {
            if (data != null && data.Length > index && d.Length == dataCount)
            {
                data[index] = d;
                for (int i = 0; i < d.Length; i++)
                {
                    if (maxData < d[i])
                        maxData = d[i];

                }
                maxCeil = (int)Math.Ceiling(maxData);
                calGrid();
            }
        }

 
        public void setBarColor(Color[] color)
        {
            if (data != null && barColor != null && barColor.Length == color.Length)
            {
                barColor = color;
            }
        }

        private void calGrid()
        {
            if (maxCeil <= 1)
            {
                float tmp = maxData;
                int c = 0;
                while (tmp < 1)
                {
                    tmp = tmp * 10;
                    if (c == 0)
                        c = 10;
                    else
                        c *= 10;
                }

                gridGap = maxData / 10;
                if (gridGap * c < 0.5)
                {
                    gridGap = 0.5f / c;
                }
                else if (gridGap * c > 0.5)
                {
                    gridGap = 1f / c;
                }
                currentGrid = 1;
                tmp = gridGap;
                while (tmp + (1f / (c * 10)) < maxData)
                {
                    currentGrid++;
                    tmp += gridGap;
                    if (tmp + (1f / (c * 10)) < maxData)
                        calDatawidth(roundFloat(tmp));
                }
            }
            else if (maxCeil <= 10)
            {
                currentGrid = maxCeil;
                gridGap = 1;
            }
            else
            {
                float tmp = maxCeil;
                int c = 0;
                while (tmp > 10)
                {
                    tmp = tmp / 10.0f;
                    if (c == 0)
                        c = 1;
                    else
                        c *= 10;
                }
                int d = (int)tmp;
                if (d == tmp)
                {
                    gridGap = 10;
                }
                else if (d + 0.5 > tmp)
                {
                    gridGap = d + 0.5f;
                }
                else
                {
                    gridGap = d + 1;
                }
                gridGap *= c;
                currentGrid = 1;
                tmp = gridGap;
                while (tmp < maxCeil)
                {
                    currentGrid++;
                    tmp += gridGap;
                    //                if(tmp < maxCeil)
                    //                    calDatawidth(tmp);
                }

            }
            if (currentGrid < minGrid)
                currentGrid = minGrid;
            if (currentGrid > maxGrid)
                currentGrid = maxGrid;
        }

        private void calDatawidth(float f)
        {
            String tmp = f.ToString();
            if (tmp.EndsWith(".0"))
                tmp = tmp.Substring(0, tmp.Length - 2);
            if (tmp.Length > maxDataWidth)
            {
                maxDataWidth = tmp.Length;
                widthData = f;
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

            canvas.Save();
            canvas.Translate(paddingLeft, paddingTop);
            canvas.ClipRect(0, 0, width, height);

            
            canvas.DrawColor( backColor);

            Rect rt = new Rect();
            String txt =maxCeil.ToString();
            if (maxCeil > 1)
            {
                int gg = (int)gridGap;
                if (gg < gridGap)
                    txt += ".5";
            }
            else
            {
                txt = widthData.ToString();
            }
            Paint p = new Paint();
            p.GetTextBounds(txt, 0, txt.Length, rt);
            int txtWidth = rt.Width();
            int txtPadd = 5;

            p.Color=(lineColor);
            int bt = 20;
            int h = (int)(height - bottomSpace);
            float lsp = (h * 1.0f - bt) / (currentGrid * 1.0f);
            canvas.DrawLine(txtWidth + 2 * txtPadd + 5, 5, txtWidth + 2 * txtPadd + 5, h - bt + 10, p);

            Paint paint = new Paint();
            paint.Color=(textColor);
            paint.TextAlign=Paint.Align.Right;
            Paint.FontMetrics fm = paint.GetFontMetrics();

            for (int i = 0; i <= currentGrid; i++)
            {
                canvas.DrawLine(txtWidth + 2 * txtPadd, h - bt - i * lsp + 5, width - rightSpace, h - bt - i * lsp + 5, p);
                float c = i * gridGap;
                if (maxCeil <= 1)
                {
                    if (c.ToString().Length > maxDataWidth)
                    {
                        c = roundFloat(c);
                    }
                }
                String dtxt = c.ToString();
                if (dtxt.EndsWith(".0"))
                    dtxt = dtxt.Substring(0, dtxt.Length - 2);

                canvas.DrawText(dtxt, txtWidth + txtPadd, h - bt - i * lsp - fm.Ascent, paint);
            }

            float w = width - rightSpace - txtWidth - 2 * txtPadd - 5;
            float gp = (w - 2 * groupCount * barSpace);
            float barWidth = gp / groupCount;
            barWidth /= dataCount;
            float sx = txtWidth + 2 * txtPadd + 5;
            float xx = sx;
            for (int i = 0; i < groupCount - 1; i++)
            {
                xx += barSpace * 2;
                xx += barWidth * dataCount;
                canvas.DrawLine(xx, h - bt + 5, xx, h - bt + 10, p);

            }


            for (int i = 0; i < groupCount; i++)
            {
                sx += barSpace;
                for (int j = 0; j < dataCount; j++)
                {
                    p.Color=barColor[j];
                    float v = data[i][j];
                    float y = h - bt + 5 - (v * lsp / gridGap);
                    canvas.DrawRect(sx, y, sx + barWidth, h - bt + 5, p);
                    sx += barWidth;
                }
                sx += barSpace;
            }

            float yy = h + bt - 5;
            xx = 0;
            for (int i = 0; i < dataCount; i++)
            {
                p.Color=(barColor[i]);
                xx += 20;
                canvas.DrawRect(xx, yy, xx + 15, yy + 15, p);
                xx += 20;
                paint.TextAlign=Paint.Align.Left;
                paint.Color=(textColor);
                if (dataTitle != null && dataTitle[i] != null)
                {
                    canvas.DrawText(dataTitle[i], xx, yy - fm.Ascent, paint);
                    Rect r = new Rect();
                    paint.GetTextBounds(dataTitle[i], 0, dataTitle.Length, r);
                    xx += r.Width();
                }
            }

            if (groupTitle != null && groupTitle.Length > 0)
            {
                paint.TextAlign=(Paint.Align.Center);
                paint.Color=(textColor);
                yy = h + 2;
                xx = txtWidth + 2 * txtPadd + 5;
                for (int i = 0; i < groupCount; i++)
                {
                    xx += barSpace;
                    xx += (dataCount * barWidth) / 2;
                    canvas.DrawText(groupTitle[i], xx, yy, paint);
                    xx += barSpace;
                    xx += dataCount * barWidth / 2;
                }
            }

            canvas.Restore();
        }

        private float roundFloat(float f)
        {
            String tmp = gridGap.ToString();
            int ind = tmp.IndexOf(".");
            int m = tmp.Length - ind;
            
            decimal  bd = new decimal(f);
            //bd = bd.setScale(m, BigDecimal.ROUND_HALF_UP);
        
            //return bd.floatValue();

            return f;
        }

         
    }
}