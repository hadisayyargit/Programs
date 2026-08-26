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
    public class CurveChartView : View
    {
        private Color backColor = Color.Black;
        //private Color gridColor = new Color(0xFF339933);
        private Color gridColor =  Color.Cyan;

        private Color[] curveColor = null;

        private Color defaCurveColor = Color.Yellow;

        //private Color textColor = new Color(0xeeeeee);
        private Color textColor = Color.DarkSlateBlue;

        //private Color popupColor = new Color(0xaa33ff33;
        private Color popupColor = Color.DeepPink;

        //private Color selectLineColor = new Color(0xaaaaaa);
        private Color selectLineColor = Color.Gray;

        /**最小水平线的数目*/
        private int minHarizonLineCount = 3;

        private int maxHarizonLineCount = 10;
        /**是否显示选择时的数据*/
        private bool showTips = true;

        private float minValue = 0;

        private float maxValue = 0;

        private int maxCeil = 0;

        private int minCeil = 0;

        private DataQueue[] dataList = null;

        private int gridPaddingLeft = 3;

        private int gridPaddingRight = 3;

        private int gridPaddingTop = 3;

        private int gridPaddingBottom = 3;

        //private int gridStart = gridPaddingLeft;
        private int gridStart = 3;

        private int pointGapDef = 2;

        //private float pointGap = pointGapDef;
        private float pointGap = 2;

        /**是否为静态曲线 curve is static*/
        private bool isStatic = true;

        private float currentMaxValue;

        private float[][] staticData = null;

        private float[] pointX = null;

        private int selectPoint = -1;

        private PointF lastPoint = null;

        private bool sizeHaveSet = false;
        /**是否要显示刻度*/
        private bool showCalibration = false;
        /**刻度是否显示在左边*/
        private bool onLeft = false;

        private bool setScope = false;

        private Context context = null;

        public CurveChartView(Context context)
            : base(context)
        {
            init(context);
        }

        public CurveChartView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            init(context);
        }

        public CurveChartView(Context context, IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {
            init(context);
        }

        private void init(Context context)
        {
            this.context = context;
            gridPaddingLeft = toPixel(context, gridPaddingLeft);
            gridPaddingTop = toPixel(context, gridPaddingTop);
            gridPaddingRight = toPixel(context, gridPaddingRight);
            gridPaddingBottom = toPixel(context, gridPaddingBottom);
            pointGapDef = toPixel(context, pointGapDef);
        }


        public void setCurveStatic(bool b)
        {
            isStatic = b;
        }


        public void setCurveCount(int c)
        {

            if (isStatic)
            {
                staticData = new float[c][];
            }
            else
            {
                dataList = new DataQueue[c];
            }
            curveColor = new Color[c];
            for (int i = 0; i < c; i++)
            {
                curveColor[i] = defaCurveColor;
            }

        }


        public void setDataScope(int minv, int maxv)
        {
            setScope = true;
            minCeil = minv;
            maxCeil = maxv;
        }



        public void setCalibrationLeft(bool b)
        {
            onLeft = b;
        }


        public void setCalibrationOn(bool b)
        {
            showCalibration = b;
            gridPaddingTop = toPixel(context, 10);
            gridPaddingBottom = toPixel(context, isStatic ? 10 : 25);
        }


        public void setBackgroundColor(Color color)
        {
            backColor = color;
        }


        public void setGridColor(Color color)
        {
            gridColor = color;
        }


        public void setMaxHarizonLineCount(int c)
        {
            maxHarizonLineCount = c;
        }


        public void setCurveColor(int index, Color Color)
        {
            if (curveColor == null || curveColor.Length <= index)
                return;
            curveColor[index] = Color;
        }


        public void setCurveColor(Color[] color)
        {
            if (curveColor == null || color == null || curveColor.Length != color.Length)
                return;
            curveColor = color;
        }

        public void setCurveColor(Color color)
        {
            if ((isStatic && curveColor == null) || (isStatic == false && dataList == null))
            {
                setCurveCount(1);
            }
            curveColor[0] = color;
        }


        public void setMaxCount(int size)
        {
            if (isStatic || dataList == null)
                return;
            for (int i = 0; i < dataList.Length; i++)
            {
                if (dataList[i] == null)
                    dataList[i] = new DataQueue();
                dataList[i].setSize(size);
            }
            pointGap = (Width - PaddingLeft - PaddingRight) * 1.0f / size * 1.0f;
        }



        public void appendData(float data)
        {
            if (isStatic)
                return;
            if (dataList == null)
            {
                setCurveCount(1);
            }
            if (sizeHaveSet == false)
            {
                int s = (Width - PaddingLeft - PaddingRight) / pointGapDef;
                if (s > 1)
                {
                    for (int i = 0; i < dataList.Length; i++)
                    {
                        if (dataList[i] == null)
                            dataList[i] = new DataQueue();
                        dataList[i].setSize(s);
                    }
                    sizeHaveSet = true;
                    pointGap = pointGapDef;
                }
            }
            if (dataList[0] == null)
                dataList[0] = new DataQueue();
            if (maxValue < data)
                maxValue = data;
            if (minValue > data)
                minValue = data;
            dataList[0].add(data);
            if (setScope == false)
            {
                maxCeil = (int)Math.Ceiling(maxValue);
                minCeil = (int)Math.Floor(minValue);
            }
            currentMaxValue = maxValue - minValue;
            Invalidate();
        }


        public void appendData(float[] data)
        {
            if (data == null || isStatic || dataList == null || dataList.Length != data.Length)
            {
                return;
            }
            if (sizeHaveSet == false)
            {
                int s = (Width - PaddingLeft - PaddingRight) / pointGapDef;
                if (s > 1)
                {
                    for (int i = 0; i < dataList.Length; i++)
                    {
                        if (dataList[i] == null)
                            dataList[i] = new DataQueue();
                        dataList[i].setSize(s);
                    }
                    sizeHaveSet = true;
                    pointGap = pointGapDef;
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                if (maxValue < data[i])
                    maxValue = data[i];
                if (minValue > data[i])
                    minValue = data[i];
                if (dataList[i] == null)
                    dataList[i] = new DataQueue();
                dataList[i].add(data[i]);
            }
            if (setScope == false)
            {
                maxCeil = (int)Math.Ceiling(maxValue);
                minCeil = (int)Math.Floor(minValue);
            }
            currentMaxValue = maxValue - minValue;
            Invalidate();
        }



        public void setData(int index, float[] data)
        {
            if (data == null || isStatic == false)
                return;
            if (staticData == null || staticData.Length <= index)
                return;
            if (staticData[0] == null)
                index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (maxValue < data[i])
                {
                    maxValue = data[i];
                }
                if (minValue > data[i])
                {
                    minValue = data[i];
                }
            }
            staticData[index] = data;
            if (setScope == false)
            {
                maxCeil = (int)Math.Ceiling(maxValue);
                minCeil = (int)Math.Floor(minValue);
            }
            currentMaxValue = maxValue - minValue;
            pointX = null;
        }


        public void setData(float[] data)
        {
            if (data == null || isStatic == false)
                return;
            if (staticData != null && staticData.Length > 1)
                return;

            if (staticData == null)
                setCurveCount(1);

            for (int i = 0; i < data.Length; i++)
            {
                if (maxValue < data[i])
                {
                    maxValue = data[i];
                }
                if (minValue > data[i])
                {
                    minValue = data[i];
                }
            }
            staticData[0] = data;
            if (setScope == false)
            {
                maxCeil = (int)Math.Ceiling(maxValue);
                minCeil = (int)Math.Floor(minValue);
            }
            currentMaxValue = maxValue - minValue;
            pointX = null;
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

            canvas.DrawColor(backColor);

            Paint p = new Paint();
            float textw = 0;
            if (showCalibration)
            {
                Rect rect = new Rect();
                String txt = maxCeil.ToString() + "88";
                p.GetTextBounds(txt, 0, txt.Length, rect);
                textw = rect.Width();
                txt = minCeil.ToString() + "88";
                p.GetTextBounds(txt, 0, txt.Length, rect);
                if (textw < rect.Width())
                    textw = rect.Width();
                textw += 5;
            }

            float vsp = 1;

            int ceilValue = Math.Abs(maxCeil - minCeil);
            if (ceilValue == 0)
                ceilValue = minHarizonLineCount;
            if (ceilValue > maxHarizonLineCount)
            {
                vsp = (ceilValue * 1.0f) / maxHarizonLineCount;
                ceilValue = maxHarizonLineCount;
            }


            int vheight = height - gridPaddingTop - gridPaddingBottom;
            int vwidth = (int)(width - gridPaddingLeft - gridPaddingRight - textw);
            if (isStatic)
            {
                if (staticData != null && staticData[0].Length > 1)
                    pointGap = (vwidth * 1.0f) / (staticData[0].Length - 1);
                else
                    pointGap = pointGapDef;
            }
            else
            {
                //            pointGap = pointGapDef;
            }


            float verticalSpace = (vheight * 1.0f) / (ceilValue * 1.0f);
            gridStart = gridPaddingLeft;

            //格线
            Paint paint = new Paint();
            paint.Color = (textColor);
            Paint.FontMetrics fm = paint.GetFontMetrics();
            if (onLeft)
            {
                paint.TextAlign = (Paint.Align.Right);
                gridStart += int.Parse(textw.ToString());
            }




            for (int i = 0; i <= ceilValue; i++)
            {
                p.Color = (gridColor);
                canvas.DrawLine(gridStart, gridPaddingTop + i * verticalSpace, gridStart + vwidth, gridPaddingTop + i * verticalSpace, p);
                if (showCalibration)
                {
                    if (i > 0 && i < ceilValue)
                    {
                        p.Color = (textColor);
                        String cs = String.Format("%.1f", maxCeil - i * vsp);
                        if (cs.EndsWith("0"))
                            cs = cs.Substring(0, cs.Length - 2);
                        if (onLeft)
                        {
                            canvas.DrawText(cs, gridStart, gridPaddingTop + i * verticalSpace - fm.Ascent - toPixel(context, 5), paint);
                        }
                        else
                        {
                            canvas.DrawText(cs, gridPaddingLeft + vwidth + 1, gridPaddingTop + i * verticalSpace - fm.Ascent - toPixel(context, 5), paint);
                        }
                    }
                }
            }
            p.Color = (gridColor);
            canvas.DrawLine(gridStart, gridPaddingTop, gridStart, gridPaddingTop + vheight, p);
            canvas.DrawLine(gridStart + vwidth, gridPaddingTop, gridStart + vwidth, gridPaddingTop + vheight, p);
            if (showCalibration)
            {
                if (onLeft)
                {
                    canvas.DrawText(maxCeil.ToString(), gridStart, gridPaddingTop - fm.Ascent - toPixel(context, 5), paint);
                    canvas.DrawText(minCeil.ToString(), gridStart, gridPaddingTop + vheight + toPixel(context, 5), paint);
                }
                else
                {
                    canvas.DrawText(maxCeil.ToString(), gridPaddingLeft + vwidth + 1, gridPaddingTop - fm.Ascent - toPixel(context, 5), paint);
                    canvas.DrawText(minCeil.ToString(), gridPaddingLeft + vwidth + 1, gridPaddingTop + vheight + toPixel(context, 5), paint);
                }
            }
            canvas.Restore();
            if (isStatic)
                drawStaticCurve(canvas, vwidth, vheight, verticalSpace, vsp);
            else
            {
                drawDynamicCurve(canvas, vwidth, vheight, verticalSpace, vsp);
            }

        }

        private void drawDynamicCurve(Canvas canvas, int width, int height, float hsp, float hv)
        {

            if (dataList != null && dataList[0] != null)
            {
                canvas.Save();
                canvas.Translate(PaddingLeft + gridStart, PaddingTop + gridPaddingTop);
                canvas.ClipRect(0, 0, width, height + 1);
                Paint p = new Paint();
                int s = dataList[0].getListSize();
                float mx = minCeil;
                float mi = maxCeil;
                for (int i = 0; i < dataList.Length; i++)
                {
                    if (dataList[i] == null)
                        continue;
                    p.Color = (curveColor[i]);
                    bool flag = false;
                    float px = 0;
                    float py = 0;
                    float tmp = width - s * pointGap;
                    if (tmp > 0)
                    {
                        for (int j = 0; j < s; j++)
                        {
                            float v = dataList[i].getData(j);
                            if (mx < v)
                                mx = v;
                            if (mi > v)
                                mi = v;
                            float x = width - j * pointGap;
                            float y = height - ((minCeil - v) * (-1.0f) * hsp) / hv;

                            if (flag)
                            {
                                canvas.DrawLine(px, py, x, y, p);
                            }
                            else
                            {
                                flag = true;
                            }
                            px = x;
                            py = y;
                        }
                    }
                    else
                    {
                        int k = 0;
                        for (int j = s - 1; j >= 0; j--)
                        {
                            float v = dataList[i].getData(j);
                            if (mx < v)
                                mx = v;
                            if (mi > v)
                                mi = v;
                            float x = k * pointGap;
                            k++;
                            if (x > width)
                                break;
                            float y = height - ((minCeil - v) * (-1.0f) * hsp) / hv;

                            if (flag)
                            {
                                canvas.DrawLine(px, py, x, y, p);
                            }
                            else
                            {
                                flag = true;
                            }
                            px = x;
                            py = y;
                        }
                    }
                }
                if (maxValue > mx)
                    maxValue = mx;
                if (minValue < mi)
                    minValue = mi;
                canvas.Restore();
                Paint.FontMetrics fm = p.GetFontMetrics();
                float tw = 0;
                float ty = gridPaddingTop + height + toPixel(context, 15) - fm.Ascent;
                float tx = gridPaddingLeft + toPixel(context, 30);

                for (int i = 0; i < dataList.Length; i++)
                {
                    if (dataList[i] == null)
                        continue;
                    String tmp = dataList[i].getData(s - 1).ToString();
                    Rect r = new Rect();
                    p.Color = (curveColor[i]);
                    p.GetTextBounds(tmp, 0, tmp.Length, r);
                    tw += r.Width();
                    canvas.DrawText(tmp, tx, ty, p);
                    tx += tw + toPixel(context, 10);
                }
            }
        }

        private void drawStaticCurve(Canvas canvas, int width, int height, float hsp, float hv)
        {
            Paint p = new Paint();
            canvas.Save();
            canvas.Translate(PaddingLeft + gridStart, PaddingTop + gridPaddingTop);
            canvas.ClipRect(0, 0, width, height + 1);
            if (staticData != null && staticData[0] != null)
            {
                bool po = false;
                int s = staticData[0].Length;
                if (pointX == null)
                {
                    pointX = new float[s];
                    po = true;
                }

                for (int k = 0; k < staticData.Length; k++)
                {
                    p.Color = (curveColor[k]);
                    bool flag = false;

                    float px = 0;
                    float py = 0;
                    if (staticData[k] == null)
                        continue;
                    for (int i = 0; i < s; i++)
                    {
                        float v = staticData[k][i];
                        float x = (i * pointGap);
                        float y = height - ((minCeil - v) * (-1.0f) * hsp) / hv;
                        if (po)
                            pointX[i] = x;

                        if (flag)
                        {
                            canvas.DrawLine(px, py, x, y, p);
                        }
                        else
                        {
                            flag = true;
                        }
                        px = x;
                        py = y;
                    }
                }
            }


            if (showTips && selectPoint != -1)
            {
                p.Color = (selectLineColor);
                canvas.DrawLine(pointX[selectPoint], 0, pointX[selectPoint], height, p);
                Paint paint = new Paint();
                paint.AntiAlias = (true);
                paint.StrokeWidth = (5);
                paint.Color = (popupColor);
                Paint.FontMetrics fm = paint.GetFontMetrics();
                int bd = 2;
                float fms = fm.Descent - fm.Ascent;
                float x = width / 2 - 20;
                float y = gridPaddingTop + 10;
                Rect bounds = new Rect();
                for (int i = 0; i < staticData.Length; i++)
                {
                    if (staticData[i] == null)
                        continue;
                    String txt = (staticData[i][selectPoint]).ToString();
                    paint.GetTextBounds(txt, 0, txt.Length, bounds);
                    RectF rf = new RectF(x - bd, y - bd, x + bounds.Width() + bd, y + fms + bd);
                    //canvas.drawRoundRect(rf, 3, 3, paint);
                    p.Color = (curveColor[i]);
                    canvas.DrawText(txt, x, y - fm.Ascent, p);
                    y += fms + bd + 3;
                }
                selectPoint = -1;
            }
            canvas.Restore();
        }

     
        private int getPointData(float x, float y)
        {
            if (pointX != null && pointX.Length > 2)
            {
                float sp = pointX[1] - pointX[0];
                if (lastPoint != null)
                {
                    if (lastPoint.X > x)
                    {
                        for (int i = (int)lastPoint.Y; i >= 0; i--)
                        {
                            if (Math.Abs(x - pointX[i]) <= sp)
                            {
                                lastPoint.X = x;
                                lastPoint.Y = i;
                                return i;
                            }
                        }
                    }
                    else if (lastPoint.X < x)
                    {
                        for (int i = (int)lastPoint.Y; i < pointX.Length; i++)
                        {
                            if (Math.Abs(x - pointX[i]) <= sp)
                            {
                                lastPoint.X = x;
                                lastPoint.Y = i;
                                return i;
                            }
                        }
                    }
                    else
                    {
                        return (int)lastPoint.Y;
                    }
                }
                else
                {
                    for (int i = 0; i < pointX.Length; i++)
                    {
                        if (Math.Abs(x - pointX[i]) <= sp)
                        {
                            lastPoint = new PointF();
                            lastPoint.X = x;
                            lastPoint.Y = i;
                            return i;
                        }
                    }
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }

        private bool isDown = false;

        public override bool OnTouchEvent(MotionEvent e)
        {
            if (showTips == false || isStatic == false)
                return false;
            MotionEventActions action = e.Action;
            switch (action)
            {
                case MotionEventActions.Down:
                    if (isDown)
                    {
                        handler.RemoveMessages(100);
                        return true;
                    }
                    else
                    {
                        isDown = true;
                    }
                    break;
                case MotionEventActions.Move:
                    float x = e.GetX();
                    float y = e.GetY();
                    selectPoint = getPointData(x, y);
                    Invalidate();
                    isDown = false;
                    return true;
                case MotionEventActions.Up:
                    handler.SendEmptyMessageDelayed(100, 5000);
                    isDown = false;
                    break;
                case MotionEventActions.Outside:
                    isDown = false;
                    break;
            }
            return false;
        }
        
        private void reDraw()
        {
            Invalidate();
        }

        private int toPixel(Context context, int dip)
        {

            float px = TypedValue.ApplyDimension(ComplexUnitType.Sp,
                    dip, context.Resources.DisplayMetrics);
            return (int)px;
        }


        private Handler handler = new Handler();
        /*
    private Handler handler = new Handler()
    {
        public void handleMessage(Message msg) {
            reDraw();
        }
    };
    */        
        public void handleMessage(Message msg)
        {
            reDraw();
        }

        

    }

    public class DataQueue
    {
        private LinkedList<float> list = new LinkedList<float>();
        private int size = 1;

        public DataQueue() { }

        public DataQueue(int s)
        {
            size = s;
        }

        public void setSize(int s)
        {
            if (s <= 1)
                return;
            if (size > s && list.Count > s)
            {
                for (int i = 0; i < list.Count - s; i++)
                {
                    list.RemoveLast();
                    //list.poll();
                }
            }
            size = s;
        }

        public void add(float f)
        {
            if (list.Count >= size)
            {
                list.RemoveLast();
                //list.poll();
            }
            list.AddLast(f);
        }


        public float getData(int index)
        {

            return list.ElementAt(index);
            //return list[index];
            //return list.get(index);
        }

        public int getListSize()
        {
            return list.Count;
        }

        public void removeAll()
        {
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list.RemoveLast();
                }
            }
        }

    }
    
}