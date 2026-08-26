using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ProgLib.Win32;

namespace ProgLib.General
{
	public enum Direction
	{
		// Fields
		Horizontal = 1,
		Vertical = 0
	}

	public enum DrawState
	{
		// Fields
		Disable = 1,
		Hot = 2,
		Normal = 0,
		Pressed = 3
	}

	public enum VisualStyle
	{
		// Fields
		IDE = 0,
		Plain = 1
	}



	public class ColorUtil
	{
		// Properties
		public static bool UsingCustomColor
		{
			get
			{
				return ColorUtil.useCustomColor;
			}
		}

		public static Color VSNetBackgroundColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.backgroundColor != Color.Empty))
				{
					return ColorUtil.backgroundColor;
				}
				return ColorUtil.CalculateColor(SystemColors.Window, SystemColors.Control, 220);
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.backgroundColor = value;
			}
		}
 

		public static Color VSNetBorderColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.borderColor != Color.Empty))
				{
					return ColorUtil.borderColor;
				}
				return SystemColors.Highlight;
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.borderColor = value;
			}
		}

		public static Color VSNetCheckedColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.pressedColor != Color.Empty))
				{
					return ColorUtil.checkedColor;
				}
				return ColorUtil.CalculateColor(SystemColors.Highlight, SystemColors.Window, 30);
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.checkedColor = value;
			}
		}

		public static Color VSNetControlColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.controlColor != Color.Empty))
				{
					return ColorUtil.controlColor;
				}
				return ColorUtil.CalculateColor(SystemColors.Control, ColorUtil.VSNetBackgroundColor, 0xc3);
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.controlColor = value;
			}
		}
 

		public static Color VSNetPressedColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.pressedColor != Color.Empty))
				{
					return ColorUtil.pressedColor;
				}
				return ColorUtil.CalculateColor(SystemColors.Highlight, ColorUtil.VSNetSelectionColor, 70);
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.pressedColor = value;
			}
		}

		public static Color VSNetSelectionColor
		{
			get
			{
				if (ColorUtil.useCustomColor && (ColorUtil.selectionColor != Color.Empty))
				{
					return ColorUtil.selectionColor;
				}
				return ColorUtil.CalculateColor(SystemColors.Highlight, SystemColors.Window, 70);
			}
			set
			{
				ColorUtil.useCustomColor = true;
				ColorUtil.selectionColor = value;
			}
		}

		// Fields
		private static Color backgroundColor;
		private static Color borderColor;
		private static Color checkedColor;
		private static Color controlColor;
		public static string[] KnownColorNames;
		private static Color pressedColor;
		private static Color selectionColor;
		public static string[] SystemColorNames;
		private static bool useCustomColor;

		// Methods
		static ColorUtil()
		{
			ColorUtil.backgroundColor = Color.Empty;
			ColorUtil.selectionColor = Color.Empty;
			ColorUtil.controlColor = Color.Empty;
			ColorUtil.pressedColor = Color.Empty;
			ColorUtil.checkedColor = Color.Empty;
			ColorUtil.borderColor = Color.Empty;
			ColorUtil.useCustomColor = false;
			string[] textArray1 = new string[0x8b] { 
													   "Transparent", "Black", "DimGray", "Gray", "DarkGray", "Silver", "LightGray", "Gainsboro", "WhiteSmoke", "White", "RosyBrown", "IndianRed", "Brown", "Firebrick", "LightCoral", "Maroon", 
													   "DarkRed", "Red", "Snow", "MistyRose", "Salmon", "Tomato", "DarkSalmon", "Coral", "OrangeRed", "LightSalmon", "Sienna", "SeaShell", "Chocalate", "SaddleBrown", "SandyBrown", "PeachPuff", 
													   "Peru", "Linen", "Bisque", "DarkOrange", "BurlyWood", "Tan", "AntiqueWhite", "NavajoWhite", "BlanchedAlmond", "PapayaWhip", "Mocassin", "Orange", "Wheat", "OldLace", "FloralWhite", "DarkGoldenrod", 
													   "Cornsilk", "Gold", "Khaki", "LemonChiffon", "PaleGoldenrod", "DarkKhaki", "Beige", "LightGoldenrod", "Olive", "Yellow", "LightYellow", "Ivory", "OliveDrab", "YellowGreen", "DarkOliveGreen", "GreenYellow", 
													   "Chartreuse", "LawnGreen", "DarkSeaGreen", "ForestGreen", "LimeGreen", "PaleGreen", "DarkGreen", "Green", "Lime", "Honeydew", "SeaGreen", "MediumSeaGreen", "SpringGreen", "MintCream", "MediumSpringGreen", "MediumAquaMarine", 
													   "YellowAquaMarine", "Turquoise", "LightSeaGreen", "MediumTurquoise", "DarkSlateGray", "PaleTurquoise", "Teal", "DarkCyan", "Aqua", "Cyan", "LightCyan", "Azure", "DarkTurquoise", "CadetBlue", "PowderBlue", "LightBlue", 
													   "DeepSkyBlue", "SkyBlue", "LightSkyBlue", "SteelBlue", "AliceBlue", "DodgerBlue", "SlateGray", "LightSlateGray", "LightSteelBlue", "CornflowerBlue", "RoyalBlue", "MidnightBlue", "Lavender", "Navy", "DarkBlue", "MediumBlue", 
													   "Blue", "GhostWhite", "SlateBlue", "DarkSlateBlue", "MediumSlateBlue", "MediumPurple", "BlueViolet", "Indigo", "DarkOrchid", "DarkViolet", "MediumOrchid", "Thistle", "Plum", "Violet", "Purple", "DarkMagenta", 
													   "Magenta", "Fuchsia", "Orchid", "MediumVioletRed", "DeepPink", "HotPink", "LavenderBlush", "PaleVioletRed", "Crimson", "Pink", "LightPink"
												   } ;
			ColorUtil.KnownColorNames = textArray1;
			textArray1 = new string[0x1a] { 
											  "ActiveBorder", "ActiveCaption", "ActiveCaptionText", "AppWorkspace", "Control", "ControlDark", "ControlDarkDark", "ControlLight", "ControlLightLight", "ControlText", "Desktop", "GrayText", "HighLight", "HighLightText", "HotTrack", "InactiveBorder", 
											  "InactiveCaption", "InactiveCaptionText", "Info", "InfoText", "Menu", "MenuText", "ScrollBar", "Window", "WindowFrame", "WindowText"
										  } ;
			ColorUtil.SystemColorNames = textArray1;
		}

		private ColorUtil()
		{
		}

		private static Color CalculateColor(Color front, Color back, int alpha)
		{
			Color color1 = Color.FromArgb(0xff, front);
			Color color2 = Color.FromArgb(0xff, back);
			float single1 = color1.R;
			float single2 = color1.G;
			float single3 = color1.B;
			float single4 = color2.R;
			float single5 = color2.G;
			float single6 = color2.B;
			float single7 = ((single1 * alpha) / 255f) + (single4 * (((float) (0xff - alpha)) / 255f));
			byte num1 = (byte) single7;
			float single8 = ((single2 * alpha) / 255f) + (single5 * (((float) (0xff - alpha)) / 255f));
			byte num2 = (byte) single8;
			float single9 = ((single3 * alpha) / 255f) + (single6 * (((float) (0xff - alpha)) / 255f));
			byte num3 = (byte) single9;
			return Color.FromArgb(0xff, num1, num2, num3);
		}

		public static Color ColorFromPoint(Graphics g, int x, int y)
		{
			IntPtr ptr1 = g.GetHdc();
			uint num1 = WindowsAPI.GetPixel(ptr1, x, y);
			byte num2 = ColorUtil.GetRValue(num1);
			byte num3 = ColorUtil.GetGValue(num1);
			byte num4 = ColorUtil.GetBValue(num1);
			g.ReleaseHdc(ptr1);
			return Color.FromArgb(num2, num3, num4);
		}

		public static Color ColorFromRGBString(string text)
		{
			Color color1 = Color.Empty;
			char[] chArray1 = new char[1] { ',' } ;
			string[] textArray1 = text.Split(chArray1);
			if (textArray1.Length != 3)
			{
				throw new Exception("ProgLib Error - ColorUtil : RGB color string is not well formed");
			}
			string text1 = textArray1[0];
			string text2 = textArray1[1];
			string text3 = textArray1[2];
			try
			{
				int num1 = Convert.ToInt32(text1);
				int num2 = Convert.ToInt32(text2);
				int num3 = Convert.ToInt32(text3);
				if ((((num1 < 0) || (num1 > 0xff)) || ((num2 < 0) || (num2 > 0xff))) || ((num3 < 0) || (num3 > 0xff)))
				{
					throw new Exception("ProgLib Error - ColorUtil : Out of bounds RGB value");
				}
				color1 = Color.FromArgb(num1, num2, num3);
				Color color2 = Color.Empty;
				bool flag1 = ColorUtil.IsKnownColor(color1, ref color2, true);
				if (!flag1)
				{
					flag1 = ColorUtil.IsSystemColor(color1, ref color2);
				}
				if (flag1)
				{
					color1 = color2;
				}
			}
			catch (InvalidCastException)
			{
				throw new Exception("ProgLib Error - ColorUtil : Invalid RGB value");
			}
			return color1;
		}

		public static byte GetBValue(uint color)
		{
			return (byte) (color >> 0x10);
		}

		public static uint GetCOLORREF(Color color)
		{
			return ColorUtil.RGB(color.R, color.G, color.B);
		}

		public static byte GetGValue(uint color)
		{
			return (byte) (((short) color) >> 8);
		}

		private static float getRGBValue(float n1, float n2, float hue)
		{
			if (hue > 360f)
			{
				hue -= 360f;
			}
			else if (hue < 0f)
			{
				hue += 360f;
			}
			if (hue < 60)
			{
				return (n1 + (((n2 - n1) * hue) / 60f));
			}
			if (hue < 180f)
			{
				return n2;
			}
			if (hue < 240f)
			{
				return (n1 + (((n2 - n1) * (240f - hue)) / 60f));
			}
			return n1;
		}
 

		public static byte GetRValue(uint color)
		{
			return (byte) color;
		}

		public static void HSLToRGB(float h, float s, float l, ref float r, ref float g, ref float b)
		{
			float single2;
			h = (h / 240f) * 360f;
			s /= 240f;
			l /= 240f;
			r /= 255f;
			g /= 255f;
			b /= 255f;
			if (l <= 0.5f)
			{
				single2 = l * (1f + s);
			}
			else
			{
				single2 = (l + s) - (l * s);
			}
			float single1 = (2f * l) - single2;
			if (s == 0f)
			{
				float single3;
				b = single3 = l;
				g = single3 = single3;
				r = single3;
			}
			else
			{
				r = ColorUtil.getRGBValue(single1, single2, h + 120f);
				g = ColorUtil.getRGBValue(single1, single2, h);
				b = ColorUtil.getRGBValue(single1, single2, h - 120f);
			}
			r *= 255f;
			g *= 255f;
			b *= 255f;
		}

		public static bool IsKnownColor(Color color, ref Color knownColor, bool useTransparent)
		{
			Color color1 = Color.Empty;
			bool flag1 = false;
			for (KnownColor color2 = (KnownColor) 0; color2 <= KnownColor.YellowGreen; color2 = color2 + Convert.ToInt32(KnownColor.ActiveBorder))
			{
				color1 = Color.FromKnownColor(color2);
				string text1 = color1.Name;
				if (!useTransparent)
				{
					flag1 = text1 == "Transparent";
				}
				if ((((color.A == color1.A) && (color.R == color1.R)) && ((color.G == color1.G) && (color.B == color1.B))) && (!color1.IsSystemColor && !flag1))
				{
					knownColor = color1;
					return true;
				}
			}
			return false;
		}

		public static bool IsSystemColor(Color color, ref Color knownColor)
		{
			Color color1 = Color.Empty;
			for (KnownColor color2 = (KnownColor) 0; color2 <= KnownColor.YellowGreen; color2=color2 + Convert.ToInt32(KnownColor.ActiveBorder))
			{
				color1 = Color.FromKnownColor(color2);
				string text1 = color1.Name;
				if (((color.R == color1.R) && (color.G == color1.G)) && ((color.B == color1.B) && color1.IsSystemColor))
				{
					knownColor = color1;
					return true;
				}
			}
			return false;
		}

		public static uint RGB(int r, int g, int b)
		{
			return (uint) ((((byte) r) | (((byte) g) << 8)) | (((byte) b) << 0x10));
		}

		public static void RGBToHSL(int r, int g, int b, ref float h, ref float s, ref float l)
		{
			float single2 = ((float) r) / 255f;
			float single3 = ((float) g) / 255f;
			float single4 = ((float) b) / 255f;
			float single5 = Math.Max(single2, Math.Max(single3, single4));
			float single6 = Math.Min(single2, Math.Min(single3, single4));
			l = (single5 + single6) / 2f;
			if (single5 == single6)
			{
				s = 0f;
				h = 240f;
			}
			else
			{
				float single1 = single5 - single6;
				if (((double) l) < 0.5)
				{
					s = single1 / (single5 + single6);
				}
				else
				{
					s = single1 / (2f - (single5 + single6));
				}
				if (single2 == single5)
				{
					h = (single3 - single4) / single1;
				}
				else if (single3 == single5)
				{
					h = 2f + ((single4 - single2) / single1);
				}
				else if (single4 == single5)
				{
					h = 4f + ((single2 - single3) / single1);
				}
				h *= 60f;
				if (h < 0f)
				{
					h += 360f;
				}
			}
			l *= 240f;
			s *= 240f;
			h = (h / 360f) * 240f;
		}



	}


	public class DoubleBuffer
	{
		// Fields
		private Graphics buffer;
		private int bufferHeight;
		private int bufferWidth;
		private Bitmap surface;

		// Methods
		public DoubleBuffer()
		{
		}

		private void Cleanup()
		{
			if (this.buffer != null)
			{
				this.buffer.Dispose();
				this.buffer = null;
			}
			if (this.surface != null)
			{
				this.surface.Dispose();
				this.surface = null;
			}
		}

		public void Dispose()
		{
			this.Cleanup();
		}

		public void PaintBuffer(Graphics dest, int x, int y)
		{
			dest.DrawImage(this.surface, x, y);
		}

		public Graphics RequestBuffer(int width, int height)
		{
			if (((width != this.bufferWidth) || (height != this.bufferHeight)) || (this.buffer == null))
			{
				this.Cleanup();
				this.surface = new Bitmap(width, height);
				this.buffer = Graphics.FromImage(this.surface);
				this.bufferWidth = width;
				this.bufferHeight = height;
			}
			return this.buffer;
		}


	
	}


	public class GDIUtil
	{
		// Methods
		private GDIUtil()
		{
		}

		public static void Draw3DRect(Graphics g, Rectangle rc, Color topLeft, Color bottomRight)
		{
			GDIUtil.Draw3DRect(g, rc.Left, rc.Top, rc.Width, rc.Height, topLeft, bottomRight);
		}

		public static void Draw3DRect(Graphics g, int x, int y, int width, int height, Color topLeft, Color bottomRight)
		{
			g.FillRectangle(new SolidBrush(topLeft), x, y, (int) (width - 1), 1);
			g.FillRectangle(new SolidBrush(topLeft), x, y, 1, (int) (height - 1));
			g.FillRectangle(new SolidBrush(bottomRight), (int) (x + width), y, -1, height);
			g.FillRectangle(new SolidBrush(bottomRight), x, (int) (y + height), width, -1);
		}

		public static Bitmap GetStrechedBitmap(Graphics gDest, Rectangle rcDest, Bitmap bitmap)
		{
			Bitmap bitmap1 = new Bitmap(rcDest.Width, rcDest.Height);
			Graphics graphics1 = Graphics.FromImage(bitmap1);
			IntPtr ptr1 = graphics1.GetHdc();
			WindowsAPI.SetStretchBltMode(ptr1, 3);
			IntPtr ptr2 = WindowsAPI.CreateCompatibleDC(ptr1);
			IntPtr ptr3 = WindowsAPI.SelectObject(ptr2, bitmap.GetHbitmap());
			WindowsAPI.StretchBlt(ptr1, rcDest.Left, rcDest.Top, rcDest.Width, rcDest.Height, ptr2, 0, 0, bitmap.Width, bitmap.Height, 0xcc0020);
			WindowsAPI.SelectObject(ptr2, ptr3);
			graphics1.ReleaseHdc(ptr1);
			return bitmap1;
		}

		public static Bitmap GetTileBitmap(Rectangle rcDest, Bitmap bitmap)
		{
			Bitmap bitmap1 = new Bitmap(rcDest.Width, rcDest.Height);
			using (Graphics graphics1 = Graphics.FromImage(bitmap1))
			{
				for (int num1 = 0; num1 < bitmap1.Width; num1 += bitmap.Width)
				{
					for (int num2 = 0; num2 < bitmap1.Height; num2 += bitmap.Height)
					{
						graphics1.DrawImage(bitmap, new Point(num1, num2));
					}
				}
			}
			return bitmap1;
		}

		public static void StrechBitmap(Graphics gDest, Rectangle rcDest, Bitmap bitmap)
		{
			IntPtr ptr1 = gDest.GetHdc();
			WindowsAPI.SetStretchBltMode(ptr1, 3);
			IntPtr ptr2 = WindowsAPI.CreateCompatibleDC(ptr1);
			IntPtr ptr3 = WindowsAPI.SelectObject(ptr2, bitmap.GetHbitmap());
			WindowsAPI.StretchBlt(ptr1, rcDest.Left, rcDest.Top, rcDest.Width, rcDest.Height, ptr2, 0, 0, bitmap.Width, bitmap.Height, 0xcc0020);
			WindowsAPI.SelectObject(ptr2, ptr3);
			gDest.ReleaseHdc(ptr1);
		}

	}


	public class TextUtil
	{
		// Methods
		private TextUtil()
		{
		}

		public static void DrawReverseString(Graphics g, string drawText, Font drawFont, Rectangle drawRect, Brush drawBrush, StringFormat drawFormat)
		{
			GraphicsContainer container1 = g.BeginContainer();
			g.TranslateTransform((float) ((drawRect.Left * 2) + drawRect.Width), (float) ((drawRect.Top * 2) + drawRect.Height));
			g.RotateTransform(180f);
			g.DrawString(drawText, drawFont, drawBrush, (RectangleF) drawRect, drawFormat);
			g.EndContainer(container1);
		}

		public static void DrawText(Graphics graphics, string text, Font font, Rectangle rect)
		{
			RECT rect1;
			IntPtr ptr1 = graphics.GetHdc();
			IntPtr ptr2 = font.ToHfont();
			IntPtr ptr3 = WindowsAPI.SelectObject(ptr1, ptr2);
			WindowsAPI.SetBkMode(ptr1, BackgroundMode.TRANSPARENT);
			rect1 = new RECT();
			rect1.left = rect.Left;
			rect1.top = rect.Top;
			rect1.right = rect1.left + rect.Width;
			rect1.bottom = rect1.top + rect.Height;
			WindowsAPI.DrawText(ptr1, text, text.Length, ref rect1, 0x50020);
			WindowsAPI.SelectObject(ptr1, ptr3);
			WindowsAPI.DeleteObject(ptr2);
			graphics.ReleaseHdc(ptr1);
		}

		public static Size GetTextSize(Graphics graphics, string text, Font font)
		{
			RECT rect1;
			IntPtr ptr1 = graphics.GetHdc();
			IntPtr ptr2 = font.ToHfont();
			IntPtr ptr3 = WindowsAPI.SelectObject(ptr1, ptr2);
			rect1 = new RECT();
			rect1.left = 0;
			rect1.right = 0;
			rect1.top = 0;
			rect1.bottom = 0;
			WindowsAPI.DrawText(ptr1, text, text.Length, ref rect1, 0x420);
			WindowsAPI.SelectObject(ptr1, ptr3);
			WindowsAPI.DeleteObject(ptr2);
			graphics.ReleaseHdc(ptr1);
			return new Size(rect1.right - rect1.left, rect1.bottom - rect1.top);
		}

		public static Size GetTextSize(Graphics graphics, string text, Font font, ref Rectangle rc, DrawTextFormatFlags drawFlags)
		{
			RECT rect1;
			IntPtr ptr1 = graphics.GetHdc();
			IntPtr ptr2 = font.ToHfont();
			IntPtr ptr3 = WindowsAPI.SelectObject(ptr1, ptr2);
			rect1 = new RECT();
			rect1.left = rc.Left;
			rect1.right = rc.Right;
			rect1.top = rc.Top;
			rect1.bottom = rc.Bottom;
			WindowsAPI.DrawText(ptr1, text, text.Length, ref rect1, (int) drawFlags);
			WindowsAPI.SelectObject(ptr1, ptr3);
			WindowsAPI.DeleteObject(ptr2);
			graphics.ReleaseHdc(ptr1);
			return new Size(rect1.right - rect1.left, rect1.bottom - rect1.top);
		}

	}

	
}


