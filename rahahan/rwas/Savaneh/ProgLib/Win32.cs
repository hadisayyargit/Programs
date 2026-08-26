using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ProgLib.Win32
{
	public enum ActivateState
	{
		// Fields
		WA_ACTIVE = 1,
		WA_CLICKACTIVE = 2,
		WA_INACTIVE = 0
	}


	public enum AlphaFlags : byte
	{
		// Fields
		AC_SRC_ALPHA = 1,
		AC_SRC_OVER = 0
	}
 
	public enum BackgroundMode
	{
		// Fields
		OPAQUE = 2,
		TRANSPARENT = 1
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAP
	{
		public long bmType;
		public long bmWidth;
		public long bmHeight;
		public long bmWidthBytes;
		public short bmPlanes;
		public short bmBitsPixel;
		public IntPtr bmBits;
	}


	[StructLayout(LayoutKind.Sequential)]
	public class BITMAPINFO
	{
		public BITMAPINFOHEADER bmiHeader;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst=0x400)]
		public byte[] bmiColors;
		public BITMAPINFO()
		{
		}
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct BITMAPINFO_FLAT
	{
		public int bmiHeader_biSize;
		public int bmiHeader_biWidth;
		public int bmiHeader_biHeight;
		public short bmiHeader_biPlanes;
		public short bmiHeader_biBitCount;
		public int bmiHeader_biCompression;
		public int bmiHeader_biSizeImage;
		public int bmiHeader_biXPelsPerMeter;
		public int bmiHeader_biYPelsPerMeter;
		public int bmiHeader_biClrUsed;
		public int bmiHeader_biClrImportant;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst=0x400)]
		public byte[] bmiColors;
	}
 


	[StructLayout(LayoutKind.Sequential)]
	public class BITMAPINFOHEADER
	{
		public int biSize;
		public int biWidth;
		public int biHeight;
		public short biPlanes;
		public short biBitCount;
		public int biCompression;
		public int biSizeImage;
		public int biXPelsPerMeter;
		public int biYPelsPerMeter;
		public int biClrUsed;
		public int biClrImportant;
		public BITMAPINFOHEADER()
		{
			this.biSize = Marshal.SizeOf(typeof(BITMAPINFOHEADER));
		}

	}
 

	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public struct BLENDFUNCTION
	{
		public byte BlendOp;
		public byte BlendFlags;
		public byte SourceConstantAlpha;
		public byte AlphaFormat;
	}



	public enum ClipboardFormats : uint
	{
		// Fields
		CF_BITMAP = 2,
		CF_DIB = 8,
		CF_DIF = 5,
		CF_DSPBITMAP = 130,
		CF_DSPENHMETAFILE = 0x8e,
		CF_DSPMETAFILEPICT = 0x83,
		CF_DSPTEXT = 0x81,
		CF_ENHMETAFILE = 14,
		CF_GDIOBJFIRST = 0x300,
		CF_GDIOBJLAST = 0x3ff,
		CF_HDROP = 15,
		CF_LOCALE = 0x10,
		CF_MAX = 0x11,
		CF_METAFILEPICT = 3,
		CF_OEMTEXT = 7,
		CF_OWNERDISPLAY = 0x80,
		CF_PALETTE = 9,
		CF_PENDATA = 10,
		CF_PRIVATEFIRST = 0x200,
		CF_PRIVATELAST = 0x2ff,
		CF_RIFF = 11,
		CF_SYLK = 4,
		CF_TEXT = 1,
		CF_TIFF = 6,
		CF_UNICODETEXT = 13,
		CF_WAVE = 12
	}


	public enum ComboBoxMessages
	{
		// Fields
		CB_GETDROPPEDSTATE = 0x157
	}

	public enum CommonControlInitFlags
	{
		// Fields
		ICC_ANIMATE_CLASS = 0x80,
		ICC_BAR_CLASSES = 4,
		ICC_COOL_CLASSES = 0x400,
		ICC_DATE_CLASSES = 0x100,
		ICC_HOTKEY_CLASS = 0x40,
		ICC_INTERNET_CLASSES = 0x800,
		ICC_LISTVIEW_CLASSES = 1,
		ICC_NATIVEFNTCTL_CLASS = 0x2000,
		ICC_PAGESCROLLER_CLASS = 0x1000,
		ICC_PROGRESS_CLASS = 0x20,
		ICC_TAB_CLASSES = 8,
		ICC_TREEVIEW_CLASSES = 2,
		ICC_UPDOWN_CLASS = 0x10,
		ICC_USEREX_CLASSES = 0x200,
		ICC_WIN95_CLASSES = 0xff
	}

	public enum CommonControlStyles
	{
		// Fields
		CCS_ADJUSTABLE = 0x20,
		CCS_BOTTOM = 3,
		CCS_LEFT = 0x81,
		CCS_NODIVIDER = 0x40,
		CCS_NOMOVEX = 130,
		CCS_NOMOVEY = 2,
		CCS_NOPARENTALIGN = 8,
		CCS_NORESIZE = 4,
		CCS_RIGHT = 0x83,
		CCS_TOP = 1,
		CCS_VERT = 0x80
	}

	public enum CursorType : uint
	{
		// Fields
		IDC_APPSTARTING = 32650,
		IDC_ARROW = 0x7f00,
		IDC_CROSS = 0x7f03,
		IDC_HAND = 0x7f89,
		IDC_HELP = 0x7f8b,
		IDC_IBEAM = 0x7f01,
		IDC_ICON = 0x7f81,
		IDC_NO = 0x7f88,
		IDC_SIZE = 32640,
		IDC_SIZEALL = 0x7f86,
		IDC_SIZENESW = 0x7f83,
		IDC_SIZENS = 0x7f85,
		IDC_SIZENWSE = 0x7f82,
		IDC_SIZEWE = 0x7f84,
		IDC_UPARROW = 0x7f04,
		IDC_WAIT = 0x7f02
	}


	public enum CustomDrawDrawStateFlags
	{
		// Fields
		CDDS_ITEM = 0x10000,
		CDDS_ITEMPOSTERASE = 65540,
		CDDS_ITEMPOSTPAINT = 0x10002,
		CDDS_ITEMPREERASE = 0x10003,
		CDDS_ITEMPREPAINT = 0x10001,
		CDDS_POSTERASE = 4,
		CDDS_POSTPAINT = 2,
		CDDS_PREERASE = 3,
		CDDS_PREPAINT = 1,
		CDDS_SUBITEM = 0x20000
	}


	public enum CustomDrawItemStateFlags
	{
		// Fields
		CDIS_CHECKED = 8,
		CDIS_DEFAULT = 0x20,
		CDIS_DISABLED = 4,
		CDIS_FOCUS = 0x10,
		CDIS_GRAYED = 2,
		CDIS_HOT = 0x40,
		CDIS_INDETERMINATE = 0x100,
		CDIS_MARKED = 0x80,
		CDIS_SELECTED = 1
	}


	public enum CustomDrawReturnFlags
	{
		// Fields
		CDRF_DODEFAULT = 0,
		CDRF_NEWFONT = 2,
		CDRF_NOTIFYITEMDRAW = 0x20,
		CDRF_NOTIFYPOSTERASE = 0x40,
		CDRF_NOTIFYPOSTPAINT = 0x10,
		CDRF_NOTIFYSUBITEMDRAW = 0x20,
		CDRF_SKIPDEFAULT = 4
	}


	public enum DialogCodes
	{
		// Fields
		DLGC_BUTTON = 0x2000,
		DLGC_DEFPUSHBUTTON = 0x10,
		DLGC_HASSETSEL = 8,
		DLGC_RADIOBUTTON = 0x40,
		DLGC_STATIC = 0x100,
		DLGC_UNDEFPUSHBUTTON = 0x20,
		DLGC_WANTALLKEYS = 4,
		DLGC_WANTARROWS = 1,
		DLGC_WANTCHARS = 0x80,
		DLGC_WANTMESSAGE = 4,
		DLGC_WANTTAB = 2
	}
 

	[StructLayout(LayoutKind.Sequential)]
	public struct DLLVERSIONINFO
	{
		public int cbSize;
		public int dwMajorVersion;
		public int dwMinorVersion;
		public int dwBuildNumber;
		public int dwPlatformID;
	}
 
	public enum DrawTextFormatFlags
	{
		// Fields
		DT_BOTTOM = 8,
		DT_CALCRECT = 0x400,
		DT_CENTER = 1,
		DT_EDITCONTROL = 0x2000,
		DT_END_ELLIPSIS = 0x8000,
		DT_EXPANDTABS = 0x40,
		DT_EXTERNALLEADING = 0x200,
		DT_INTERNAL = 0x1000,
		DT_LEFT = 0,
		DT_MODIFYSTRING = 0x10000,
		DT_NOCLIP = 0x100,
		DT_NOPREFIX = 0x800,
		DT_PATH_ELLIPSIS = 0x4000,
		DT_RIGHT = 2,
		DT_RTLREADING = 0x20000,
		DT_SINGLELINE = 0x20,
		DT_TABSTOP = 0x80,
		DT_TOP = 0,
		DT_VCENTER = 4,
		DT_WORD_ELLIPSIS = 0x40000,
		DT_WORDBREAK = 0x10
	}

	public enum GetDCExFlags
	{
		// Fields
		DCX_CACHE = 2,
		DCX_CLIPCHILDREN = 8,
		DCX_CLIPSIBLINGS = 0x10,
		DCX_EXCLUDERGN = 0x40,
		DCX_EXCLUDEUPDATE = 0x100,
		DCX_INTERSECTRGN = 0x80,
		DCX_INTERSECTUPDATE = 0x200,
		DCX_LOCKWINDOWUPDATE = 0x400,
		DCX_NORESETATTRS = 4,
		DCX_PARENTCLIP = 0x20,
		DCX_VALIDATE = 0x200000,
		DCX_WINDOW = 1
	}
 

	[StructLayout(LayoutKind.Sequential)]
	public struct HD_HITTESTINFO
	{
		public POINT pt;
		public uint flags;
		public int iItem;
	}

	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct HDITEM
	{
		public uint mask;
		public int cxy;
		public IntPtr pszText;
		public IntPtr hbm;
		public int cchTextMax;
		public int fmt;
		public int lParam;
		public int iImage;
		public int iOrder;
	}
 

	public enum HeaderControlHitTestFlags : uint
	{
		// Fields
		HHT_ABOVE = 0x100,
		HHT_BELOW = 0x200,
		HHT_NOWHERE = 1,
		HHT_ONDIVIDER = 4,
		HHT_ONDIVOPEN = 8,
		HHT_ONHEADER = 2,
		HHT_TOLEFT = 0x800,
		HHT_TORIGHT = 0x400
	}

	public enum HeaderControlMessages
	{
		// Fields
		HDM_FIRST = 0x1200,
		HDM_GETITEMRECT = 0x1207,
		HDM_GETITEMW = 0x120b,
		HDM_HITTEST = 0x1206,
		HDM_ORDERTOINDEX = 0x120f,
		HDM_SETIMAGELIST = 0x1208
	}


	public enum HeaderControlNotifications
	{
		// Fields
		HDN_BEGINTRACKW = -326,
		HDN_ENDTRACKW = -327,
		HDN_FIRST = -300,
		HDN_ITEMCLICKW = -322
	}


	public enum HeaderItemFlags
	{
		// Fields
		HDI_BITMAP = 0x10,
		HDI_DI_SETITEM = 0x40,
		HDI_FORMAT = 4,
		HDI_HEIGHT = 1,
		HDI_IMAGE = 0x20,
		HDI_LPARAM = 8,
		HDI_ORDER = 0x80,
		HDI_TEXT = 2,
		HDI_WIDTH = 1
	}


	public enum HitTest
	{
		// Fields
		HTBORDER = 0x12,
		HTBOTTOM = 15,
		HTBOTTOMLEFT = 0x10,
		HTBOTTOMRIGHT = 0x11,
		HTCAPTION = 2,
		HTCLIENT = 1,
		HTCLOSE = 20,
		HTERROR = -2,
		HTGROWBOX = 4,
		HTHELP = 0x15,
		HTHSCROLL = 6,
		HTLEFT = 10,
		HTMAXBUTTON = 9,
		HTMENU = 5,
		HTMINBUTTON = 8,
		HTNOWHERE = 0,
		HTOBJECT = 0x13,
		HTREDUCE = 8,
		HTRIGHT = 11,
		HTSIZE = 4,
		HTSIZEFIRST = 10,
		HTSIZELAST = 0x11,
		HTSYSMENU = 3,
		HTTOP = 12,
		HTTOPLEFT = 13,
		HTTOPRIGHT = 14,
		HTTRANSPARENT = -1,
		HTVSCROLL = 7,
		HTZOOM = 9
	}
 

	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public class INITCOMMONCONTROLSEX
	{
		public int dwSize;
		public int dwICC;
		public INITCOMMONCONTROLSEX()
		{
		}
	}



	public enum ListViewItemFlags
	{
		// Fields
		LVIF_IMAGE = 2,
		LVIF_INDENT = 0x10,
		LVIF_NORECOMPUTE = 0x800,
		LVIF_PARAM = 4,
		LVIF_STATE = 8,
		LVIF_TEXT = 1
	}

	public enum ListViewMessages
	{
		// Fields
		LVM_FIRST = 0x1000,
		LVM_GETITEMSTATE = 4140,
		LVM_GETITEMTEXTW = 0x1073,
		LVM_GETSUBITEMRECT = 0x1038
	}
 


	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct LVITEM
	{
		public uint mask;
		public int iItem;
		public int iSubItem;
		public uint state;
		public uint stateMask;
		public IntPtr pszText;
		public int cchTextMax;
		public int iImage;
		public int lParam;
		public int iIndent;
	}


	public enum MenuCharReturnValues
	{
		// Fields
		MNC_CLOSE = 1,
		MNC_EXECUTE = 2,
		MNC_IGNORE = 0,
		MNC_SELECT = 3
	}


	public enum MouseActivateFlags
	{
		// Fields
		MA_ACTIVATE = 1,
		MA_ACTIVATEANDEAT = 2,
		MA_NOACTIVATE = 3,
		MA_NOACTIVATEANDEAT = 4
	}



	public enum MouseHookFilters
	{
		// Fields
		MSGF_DIALOGBOX = 0,
		MSGF_MENU = 2,
		MSGF_MESSAGEBOX = 1,
		MSGF_NEXTWINDOW = 6,
		MSGF_SCROLLBAR = 5
	}
 
	[StructLayout(LayoutKind.Sequential)]
	public struct MOUSEHOOKSTRUCT
	{
		public POINT pt;
		public IntPtr hwnd;
		public int wHitTestCode;
		public IntPtr dwExtraInfo;
	}
 
	public enum Msg
	{
		// Fields
		WM_ACTIVATE = 6,
		WM_ACTIVATEAPP = 0x1c,
		WM_AFXFIRST = 0x360,
		WM_AFXLAST = 0x37f,
		WM_APP = 0x8000,
		WM_ASKCBFORMATNAME = 780,
		WM_CANCELJOURNAL = 0x4b,
		WM_CANCELMODE = 0x1f,
		WM_CAPTURECHANGED = 0x215,
		WM_CHANGECBCHAIN = 0x30d,
		WM_CHAR = 0x102,
		WM_CHARTOITEM = 0x2f,
		WM_CHILDACTIVATE = 0x22,
		WM_CLEAR = 0x303,
		WM_CLOSE = 0x10,
		WM_COMMAND = 0x111,
		WM_COMMNOTIFY = 0x44,
		WM_COMPACTING = 0x41,
		WM_COMPAREITEM = 0x39,
		WM_CONTEXTMENU = 0x7b,
		WM_COPY = 0x301,
		WM_COPYDATA = 0x4a,
		WM_CREATE = 1,
		WM_CTLCOLOR = 0x19,
		WM_CTLCOLORBTN = 0x135,
		WM_CTLCOLORDLG = 310,
		WM_CTLCOLOREDIT = 0x133,
		WM_CTLCOLORLISTBOX = 0x134,
		WM_CTLCOLORMSGBOX = 0x132,
		WM_CTLCOLORSCROLLBAR = 0x137,
		WM_CTLCOLORSTATIC = 0x138,
		WM_CUT = 0x300,
		WM_DEADCHAR = 0x103,
		WM_DELETEITEM = 0x2d,
		WM_DESTROY = 2,
		WM_DESTROYCLIPBOARD = 0x307,
		WM_DEVICECHANGE = 0x219,
		WM_DEVMODECHANGE = 0x1b,
		WM_DISPLAYCHANGE = 0x7e,
		WM_DRAWCLIPBOARD = 0x308,
		WM_DRAWITEM = 0x2b,
		WM_DROPFILES = 0x233,
		WM_ENABLE = 10,
		WM_ENDSESSION = 0x16,
		WM_ENTERIDLE = 0x121,
		WM_ENTERMENULOOP = 0x211,
		WM_ENTERSIZEMOVE = 0x231,
		WM_ERASEBKGND = 20,
		WM_EXITMENULOOP = 530,
		WM_EXITSIZEMOVE = 0x232,
		WM_FONTCHANGE = 0x1d,
		WM_GETDLGCODE = 0x87,
		WM_GETFONT = 0x31,
		WM_GETHOTKEY = 0x33,
		WM_GETICON = 0x7f,
		WM_GETMINMAXINFO = 0x24,
		WM_GETOBJECT = 0x3d,
		WM_GETTEXT = 13,
		WM_GETTEXTLENGTH = 14,
		WM_HANDHELDFIRST = 0x358,
		WM_HANDHELDLAST = 0x35f,
		WM_HELP = 0x53,
		WM_HOTKEY = 0x312,
		WM_HSCROLL = 0x114,
		WM_HSCROLLCLIPBOARD = 0x30e,
		WM_ICONERASEBKGND = 0x27,
		WM_IME_CHAR = 0x286,
		WM_IME_COMPOSITION = 0x10f,
		WM_IME_COMPOSITIONFULL = 0x284,
		WM_IME_CONTROL = 0x283,
		WM_IME_ENDCOMPOSITION = 270,
		WM_IME_KEYDOWN = 0x290,
		WM_IME_KEYLAST = 0x10f,
		WM_IME_KEYUP = 0x291,
		WM_IME_NOTIFY = 0x282,
		WM_IME_REQUEST = 0x288,
		WM_IME_SELECT = 0x285,
		WM_IME_SETCONTEXT = 0x281,
		WM_IME_STARTCOMPOSITION = 0x10d,
		WM_INITDIALOG = 0x110,
		WM_INITMENU = 0x116,
		WM_INITMENUPOPUP = 0x117,
		WM_INPUTLANGCHANGE = 0x51,
		WM_INPUTLANGCHANGEREQUEST = 80,
		WM_KEYDOWN = 0x100,
		WM_KEYLAST = 0x108,
		WM_KEYUP = 0x101,
		WM_KILLFOCUS = 8,
		WM_LBUTTONDBLCLK = 0x203,
		WM_LBUTTONDOWN = 0x201,
		WM_LBUTTONUP = 0x202,
		WM_MBUTTONDBLCLK = 0x209,
		WM_MBUTTONDOWN = 0x207,
		WM_MBUTTONUP = 520,
		WM_MDIACTIVATE = 0x222,
		WM_MDICASCADE = 0x227,
		WM_MDICREATE = 0x220,
		WM_MDIDESTROY = 0x221,
		WM_MDIGETACTIVE = 0x229,
		WM_MDIICONARRANGE = 0x228,
		WM_MDIMAXIMIZE = 0x225,
		WM_MDINEXT = 0x224,
		WM_MDIREFRESHMENU = 0x234,
		WM_MDIRESTORE = 0x223,
		WM_MDISETMENU = 560,
		WM_MDITILE = 550,
		WM_MEASUREITEM = 0x2c,
		WM_MENUCHAR = 0x120,
		WM_MENUCOMMAND = 0x126,
		WM_MENUDRAG = 0x123,
		WM_MENUGETOBJECT = 0x124,
		WM_MENURBUTTONUP = 290,
		WM_MENUSELECT = 0x11f,
		WM_MOUSEACTIVATE = 0x21,
		WM_MOUSEHOVER = 0x2a1,
		WM_MOUSELEAVE = 0x2a3,
		WM_MOUSEMOVE = 0x200,
		WM_MOUSEWHEEL = 0x20a,
		WM_MOVE = 3,
		WM_MOVING = 0x216,
		WM_NCACTIVATE = 0x86,
		WM_NCCALCSIZE = 0x83,
		WM_NCCREATE = 0x81,
		WM_NCDESTROY = 130,
		WM_NCHITTEST = 0x84,
		WM_NCLBUTTONDBLCLK = 0xa3,
		WM_NCLBUTTONDOWN = 0xa1,
		WM_NCLBUTTONUP = 0xa2,
		WM_NCMBUTTONDBLCLK = 0xa9,
		WM_NCMBUTTONDOWN = 0xa7,
		WM_NCMBUTTONUP = 0xa8,
		WM_NCMOUSEMOVE = 160,
		WM_NCPAINT = 0x85,
		WM_NCRBUTTONDBLCLK = 0xa6,
		WM_NCRBUTTONDOWN = 0xa4,
		WM_NCRBUTTONUP = 0xa5,
		WM_NEXTDLGCTL = 40,
		WM_NEXTMENU = 0x213,
		WM_NOTIFY = 0x4e,
		WM_NOTIFYFORMAT = 0x55,
		WM_NULL = 0,
		WM_PAINT = 15,
		WM_PAINTCLIPBOARD = 0x309,
		WM_PAINTICON = 0x26,
		WM_PALETTECHANGED = 0x311,
		WM_PALETTEISCHANGING = 0x310,
		WM_PARENTNOTIFY = 0x210,
		WM_PASTE = 770,
		WM_PENWINFIRST = 0x380,
		WM_PENWINLAST = 0x38f,
		WM_POWER = 0x48,
		WM_PRINT = 0x317,
		WM_PRINTCLIENT = 0x318,
		WM_QUERYDRAGICON = 0x37,
		WM_QUERYENDSESSION = 0x11,
		WM_QUERYNEWPALETTE = 0x30f,
		WM_QUERYOPEN = 0x13,
		WM_QUEUESYNC = 0x23,
		WM_QUIT = 0x12,
		WM_RBUTTONDBLCLK = 0x206,
		WM_RBUTTONDOWN = 0x204,
		WM_RBUTTONUP = 0x205,
		WM_REFLECT = 0x2000,
		WM_RENDERALLFORMATS = 0x306,
		WM_RENDERFORMAT = 0x305,
		WM_SETCURSOR = 0x20,
		WM_SETFOCUS = 7,
		WM_SETFONT = 0x30,
		WM_SETHOTKEY = 50,
		WM_SETICON = 0x80,
		WM_SETREDRAW = 11,
		WM_SETTEXT = 12,
		WM_SETTINGCHANGE = 0x1a,
		WM_SHOWWINDOW = 0x18,
		WM_SIZE = 5,
		WM_SIZECLIPBOARD = 0x30b,
		WM_SIZING = 0x214,
		WM_SPOOLERSTATUS = 0x2a,
		WM_STYLECHANGED = 0x7d,
		WM_STYLECHANGING = 0x7c,
		WM_SYNCPAINT = 0x88,
		WM_SYSCHAR = 0x106,
		WM_SYSCOLORCHANGE = 0x15,
		WM_SYSCOMMAND = 0x112,
		WM_SYSDEADCHAR = 0x107,
		WM_SYSKEYDOWN = 260,
		WM_SYSKEYUP = 0x105,
		WM_TCARD = 0x52,
		WM_TIMECHANGE = 30,
		WM_TIMER = 0x113,
		WM_UNDO = 0x304,
		WM_UNINITMENUPOPUP = 0x125,
		WM_USER = 0x400,
		WM_USERCHANGED = 0x54,
		WM_VKEYTOITEM = 0x2e,
		WM_VSCROLL = 0x115,
		WM_VSCROLLCLIPBOARD = 0x30a,
		WM_WINDOWPOSCHANGED = 0x47,
		WM_WINDOWPOSCHANGING = 70,
		WM_WININICHANGE = 0x1a
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct MSG
	{
		public IntPtr hwnd;
		public int message;
		public IntPtr wParam;
		public IntPtr lParam;
		public int time;
		public int pt_x;
		public int pt_y;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct NMCUSTOMDRAW
	{
		public NMHDR hdr;
		public int dwDrawStage;
		public IntPtr hdc;
		public RECT rc;
		public int dwItemSpec;
		public int uItemState;
		public int lItemlParam;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct NMHDR
	{
		public IntPtr hwndFrom;
		public int idFrom;
		public int code;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct NMLVCUSTOMDRAW
	{
		public NMCUSTOMDRAW nmcd;
		public uint clrText;
		public uint clrTextBk;
		public int iSubItem;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct NMREBARCHEVRON
	{
		public NMHDR hdr;
		public int uBand;
		public int wID;
		public int lParam;
		public RECT rc;
		public int lParamNM;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct NMTBCUSTOMDRAW
	{
		public NMCUSTOMDRAW nmcd;
		public IntPtr hbrMonoDither;
		public IntPtr hbrLines;
		public IntPtr hpenLines;
		public int clrText;
		public int clrMark;
		public int clrTextHighlight;
		public int clrBtnFace;
		public int clrBtnHighlight;
		public int clrHighlightHotTrack;
		public RECT rcText;
		public int nStringBkMode;
		public int nHLStringBkMode;
	}
 

	[StructLayout(LayoutKind.Sequential)]
	public struct NMTOOLBAR
	{
		public NMHDR hdr;
		public int iItem;
		public TBBUTTON tbButton;
		public int cchText;
		public IntPtr pszText;
		public RECT rcButton;
	}



	[StructLayout(LayoutKind.Sequential)]
	public struct NMTVCUSTOMDRAW
	{
		public NMCUSTOMDRAW nmcd;
		public uint clrText;
		public uint clrTextBk;
		public int iLevel;
	}


	public enum NotificationMessages
	{
		// Fields
		NM_CUSTOMDRAW = -12,
		NM_FIRST = 0,
		NM_NCHITTEST = -14
	}



	public enum ObjectTypes
	{
		// Fields
		OBJ_BITMAP = 7,
		OBJ_BRUSH = 2,
		OBJ_DC = 3,
		OBJ_ENHMETADC = 12,
		OBJ_ENHMETAFILE = 13,
		OBJ_EXTPEN = 11,
		OBJ_FONT = 6,
		OBJ_MEMDC = 10,
		OBJ_METADC = 4,
		OBJ_METAFILE = 9,
		OBJ_PAL = 5,
		OBJ_PEN = 1,
		OBJ_REGION = 8
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct PAINTSTRUCT
	{
		public IntPtr hdc;
		public int fErase;
		public Rectangle rcPaint;
		public int fRestore;
		public int fIncUpdate;
		public int Reserved1;
		public int Reserved2;
		public int Reserved3;
		public int Reserved4;
		public int Reserved5;
		public int Reserved6;
		public int Reserved7;
		public int Reserved8;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct PALETTEENTRY
	{
		public byte peRed;
		public byte peGreen;
		public byte peBlue;
		public byte peFlags;
	}


	public enum PatBltTypes
	{
		// Fields
		BLACKNESS = 0x42,
		DSTINVERT = 0x550009,
		MERGECOPY = 0xc000ca,
		MERGEPAINT = 0xbb0226,
		NOTSRCCOPY = 0x330008,
		NOTSRCERASE = 0x1100a6,
		PATCOPY = 0xf00021,
		PATINVERT = 0x5a0049,
		PATPAINT = 0xfb0a09,
		SRCAND = 0x8800c6,
		SRCCOPY = 0xcc0020,
		SRCERASE = 0x440328,
		SRCINVERT = 0x660046,
		SRCPAINT = 0xee0086,
		WHITENESS = 0xff0062
	}


	public enum PeekMessageFlags
	{
		// Fields
		PM_NOREMOVE = 0,
		PM_NOYIELD = 2,
		PM_REMOVE = 1
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct POINT
	{
		public int x;
		public int y;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct REBARBANDINFO
	{
		public int cbSize;
		public int fMask;
		public int fStyle;
		public int clrFore;
		public int clrBack;
		public IntPtr lpText;
		public int cch;
		public int iImage;
		public IntPtr hwndChild;
		public int cxMinChild;
		public int cyMinChild;
		public int cx;
		public IntPtr hbmBack;
		public int wID;
		public int cyChild;
		public int cyMaxChild;
		public int cyIntegral;
		public int cxIdeal;
		public int lParam;
		public int cxHeader;
	}
 

	public enum RebarInfoMask
	{
		// Fields
		BBIM_HEADERSIZE = 0x800,
		RBBIM_BACKGROUND = 0x80,
		RBBIM_CHILD = 0x10,
		RBBIM_CHILDSIZE = 0x20,
		RBBIM_COLORS = 2,
		RBBIM_ID = 0x100,
		RBBIM_IDEALSIZE = 0x200,
		RBBIM_IMAGE = 8,
		RBBIM_LPARAM = 0x400,
		RBBIM_SIZE = 0x40,
		RBBIM_STYLE = 1,
		RBBIM_TEXT = 4
	}


	public enum RebarMessages
	{
		// Fields
		CCM_FIRST = 0x2000,
		RB_BEGINDRAG = 0x418,
		RB_DELETEBAND = 0x402,
		RB_DRAGMOVE = 1050,
		RB_ENDDRAG = 0x419,
		RB_GETBANDBORDERS = 0x422,
		RB_GETBANDCOUNT = 0x40c,
		RB_GETBANDINFO = 0x405,
		RB_GETBANDINFOA = 0x41d,
		RB_GETBANDINFOW = 0x41c,
		RB_GETBARHEIGHT = 0x41b,
		RB_GETBARINFO = 0x403,
		RB_GETBKCOLOR = 0x414,
		RB_GETCOLORSCHEME = 0x2003,
		RB_GETDROPTARGET = 0x2004,
		RB_GETPALETTE = 0x426,
		RB_GETRECT = 0x409,
		RB_GETROWCOUNT = 0x40d,
		RB_GETROWHEIGHT = 0x40e,
		RB_GETTEXTCOLOR = 0x416,
		RB_GETTOOLTIPS = 0x411,
		RB_GETUNICODEFORMAT = 0x2006,
		RB_HITTEST = 0x408,
		RB_IDTOINDEX = 1040,
		RB_INSERTBANDA = 0x401,
		RB_INSERTBANDW = 0x40a,
		RB_MAXIMIZEBAND = 0x41f,
		RB_MINIMIZEBAND = 0x41e,
		RB_MOVEBAND = 0x427,
		RB_SETBANDINFOA = 1030,
		RB_SETBANDINFOW = 0x40b,
		RB_SETBARINFO = 0x404,
		RB_SETBKCOLOR = 0x413,
		RB_SETCOLORSCHEME = 0x2002,
		RB_SETPALETTE = 0x425,
		RB_SETPARENT = 0x407,
		RB_SETTEXTCOLOR = 0x415,
		RB_SETTOOLTIPS = 0x412,
		RB_SETUNICODEFORMAT = 0x2005,
		RB_SHOWBAND = 0x423,
		RB_SIZETORECT = 0x417,
		WM_USER = 0x400
	}


	public enum RebarNotifications
	{
		// Fields
		RBN_AUTOSIZE = -834,
		RBN_BEGINDRAG = -835,
		RBN_CHEVRONPUSHED = -841,
		RBN_CHILDSIZE = -839,
		RBN_DELETEDBAND = -838,
		RBN_DELETINGBAND = -837,
		RBN_ENDDRAG = -836,
		RBN_FIRST = -831,
		RBN_GETOBJECT = -832,
		RBN_HEIGHTCHANGE = -831,
		RBN_LAYOUTCHANGED = -833
	}


	public enum RebarStyles
	{
		// Fields
		RBS_AUTOSIZE = 0x2000,
		RBS_BANDBORDERS = 0x400,
		RBS_DBLCLKTOGGLE = 0x8000,
		RBS_FIXEDORDER = 0x800,
		RBS_REGISTERDROP = 0x1000,
		RBS_TOOLTIPS = 0x100,
		RBS_VARHEIGHT = 0x200,
		RBS_VERTICALGRIPPER = 0x4000
	}



	public enum RebarStylesEx
	{
		// Fields
		RBBS_BREAK = 1,
		RBBS_CHILDEDGE = 4,
		RBBS_FIXEDBMP = 0x20,
		RBBS_GRIPPERALWAYS = 0x80,
		RBBS_USECHEVRON = 0x200
	}



	[StructLayout(LayoutKind.Sequential)]
	public struct RECT
	{
		public int left;
		public int top;
		public int right;
		public int bottom;
	}



	public enum ReflectedMessages
	{
		// Fields
		OCM__BASE = 0x2000,
		OCM_CHARTOITEM = 0x202f,
		OCM_COMMAND = 0x2111,
		OCM_COMPAREITEM = 0x2039,
		OCM_CTLCOLOR = 0x2019,
		OCM_CTLCOLORBTN = 0x2135,
		OCM_CTLCOLORDLG = 0x2136,
		OCM_CTLCOLOREDIT = 0x2133,
		OCM_CTLCOLORLISTBOX = 8500,
		OCM_CTLCOLORMSGBOX = 0x2132,
		OCM_CTLCOLORSCROLLBAR = 0x2137,
		OCM_CTLCOLORSTATIC = 0x2138,
		OCM_DELETEITEM = 0x202d,
		OCM_DRAWITEM = 0x202b,
		OCM_HSCROLL = 0x2114,
		OCM_MEASUREITEM = 0x202c,
		OCM_NOTIFY = 8270,
		OCM_PARENTNOTIFY = 8720,
		OCM_VKEYTOITEM = 0x202e,
		OCM_VSCROLL = 0x2115
	}


	public class RegistryUtil
	{
		// Methods
		private RegistryUtil()
		{
		}
//		public static string ReadFromRegistry(RegistryKey RegHive, string RegPath, string KeyName, string DefaultValue);
//		public static void WriteToRegistry(RegistryKey RegHive, string RegPath, string KeyName, string KeyValue);
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct RGBQUAD
	{
		public byte rgbBlue;
		public byte rgbGreen;
		public byte rgbRed;
		public byte rgbReserved;
	}



	public enum SetWindowLongOffsets
	{
		// Fields
		GWL_EXSTYLE = -20,
		GWL_HINSTANCE = -6,
		GWL_HWNDPARENT = -8,
		GWL_ID = -12,
		GWL_STYLE = -16,
		GWL_USERDATA = -21,
		GWL_WNDPROC = -4
	}



	public enum SetWindowPosFlags : uint
	{
		// Fields
		SWP_ASYNCWINDOWPOS = 0x4000,
		SWP_DEFERERASE = 0x2000,
		SWP_DRAWFRAME = 0x20,
		SWP_FRAMECHANGED = 0x20,
		SWP_HIDEWINDOW = 0x80,
		SWP_NOACTIVATE = 0x10,
		SWP_NOCOPYBITS = 0x100,
		SWP_NOMOVE = 2,
		SWP_NOOWNERZORDER = 0x200,
		SWP_NOREDRAW = 8,
		SWP_NOREPOSITION = 0x200,
		SWP_NOSENDCHANGING = 0x400,
		SWP_NOSIZE = 1,
		SWP_NOZORDER = 4,
		SWP_SHOWWINDOW = 0x40
	}
 

	public enum SetWindowPosZOrder
	{
		// Fields
		HWND_BOTTOM = 1,
		HWND_NOTOPMOST = -2,
		HWND_TOP = 0,
		HWND_TOPMOST = -1
	}



	public enum ShowWindowStyles : short
	{
		// Fields
		SW_FORCEMINIMIZE = 11,
		SW_HIDE = 0,
		SW_MAX = 11,
		SW_MAXIMIZE = 3,
		SW_MINIMIZE = 6,
		SW_NORMAL = 1,
		SW_RESTORE = 9,
		SW_SHOW = 5,
		SW_SHOWDEFAULT = 10,
		SW_SHOWMAXIMIZED = 3,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOWNORMAL = 1
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct SIZE
	{
		public int cx;
		public int cy;
	}


	public enum StrechModeFlags
	{
		// Fields
		BLACKONWHITE = 1,
		COLORONCOLOR = 3,
		HALFTONE = 4,
		MAXSTRETCHBLTMODE = 4,
		WHITEONBLACK = 2
	}
 

	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct STRINGBUFFER
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=0x200)]
		public string szText;
	}
 
	public enum SubItemPortion
	{
		// Fields
		LVIR_BOUNDS = 0,
		LVIR_ICON = 1,
		LVIR_LABEL = 2
	}
 
	[StructLayout(LayoutKind.Sequential, Pack=1)]
	public struct TBBUTTON
	{
		public int iBitmap;
		public int idCommand;
		public byte fsState;
		public byte fsStyle;
		public byte bReserved0;
		public byte bReserved1;
		public int dwData;
		public int iString;
	}

	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct TBBUTTONINFO
	{
		public int cbSize;
		public int dwMask;
		public int idCommand;
		public int iImage;
		public byte fsState;
		public byte fsStyle;
		public short cx;
		public IntPtr lParam;
		public IntPtr pszText;
		public int cchText;
	}

	public enum ToolBarButtonInfoFlags
	{
		// Fields
		I_IMAGECALLBACK = -1,
		I_IMAGENONE = -2,
		TBIF_COMMAND = 0x20,
		TBIF_IMAGE = 1,
		TBIF_LPARAM = 0x10,
		TBIF_SIZE = 0x40,
		TBIF_STATE = 4,
		TBIF_STYLE = 8,
		TBIF_TEXT = 2
	}
 
	public enum ToolBarButtonStates
	{
		// Fields
		TBSTATE_CHECKED = 1,
		TBSTATE_ELLIPSES = 0x40,
		TBSTATE_ENABLED = 4,
		TBSTATE_HIDDEN = 8,
		TBSTATE_INDETERMINATE = 0x10,
		TBSTATE_MARKED = 0x80,
		TBSTATE_PRESSED = 2,
		TBSTATE_WRAP = 0x20
	}


	public enum ToolBarButtonStyles
	{
		// Fields
		TBSTYLE_ALTDRAG = 0x400,
		TBSTYLE_AUTOSIZE = 0x10,
		TBSTYLE_BUTTON = 0,
		TBSTYLE_CHECK = 2,
		TBSTYLE_CHECKGROUP = 6,
		TBSTYLE_CUSTOMERASE = 0x2000,
		TBSTYLE_DROPDOWN = 8,
		TBSTYLE_EX_DRAWDDARROWS = 1,
		TBSTYLE_FLAT = 0x800,
		TBSTYLE_GROUP = 4,
		TBSTYLE_LIST = 0x1000,
		TBSTYLE_NOPREFIX = 0x20,
		TBSTYLE_REGISTERDROP = 0x4000,
		TBSTYLE_SEP = 1,
		TBSTYLE_TOOLTIPS = 0x100,
		TBSTYLE_TRANSPARENT = 0x8000,
		TBSTYLE_WRAPABLE = 0x200
	}


	public enum ToolBarExStyles
	{
		// Fields
		TBSTYLE_EX_DOUBLEBUFFER = 0x80,
		TBSTYLE_EX_DRAWDDARROWS = 1,
		TBSTYLE_EX_HIDECLIPPEDBUTTONS = 0x10
	}



	public enum ToolBarMessages
	{
		// Fields
		TB_ADDBITMAP = 0x413,
		TB_ADDBUTTONS = 0x414,
		TB_ADDBUTTONSA = 0x414,
		TB_ADDBUTTONSW = 0x444,
		TB_ADDSTRINGA = 0x41c,
		TB_ADDSTRINGW = 0x44d,
		TB_AUTOSIZE = 0x421,
		TB_BUTTONCOUNT = 0x418,
		TB_BUTTONSTRUCTSIZE = 0x41e,
		TB_CHANGEBITMAP = 0x42b,
		TB_CHECKBUTTON = 0x402,
		TB_COMMANDTOINDEX = 0x419,
		TB_CUSTOMIZE = 0x41b,
		TB_DELETEBUTTON = 0x416,
		TB_ENABLEBUTTON = 0x401,
		TB_GETANCHORHIGHLIGHT = 0x44a,
		TB_GETBITMAP = 0x42c,
		TB_GETBITMAPFLAGS = 0x429,
		TB_GETBUTTON = 0x417,
		TB_GETBUTTONINFOA = 0x441,
		TB_GETBUTTONINFOW = 0x43f,
		TB_GETBUTTONSIZE = 0x43a,
		TB_GETBUTTONTEXTA = 0x42d,
		TB_GETBUTTONTEXTW = 0x44b,
		TB_GETDISABLEDIMAGELIST = 0x437,
		TB_GETEXTENDEDSTYLE = 0x455,
		TB_GETHOTIMAGELIST = 0x435,
		TB_GETHOTITEM = 0x447,
		TB_GETIMAGELIST = 0x431,
		TB_GETINSERTMARK = 0x44f,
		TB_GETINSERTMARKCOLOR = 0x459,
		TB_GETITEMRECT = 0x41d,
		TB_GETMAXSIZE = 0x453,
		TB_GETOBJECT = 0x43e,
		TB_GETPADDING = 1110,
		TB_GETRECT = 0x433,
		TB_GETROWS = 0x428,
		TB_GETSTATE = 0x412,
		TB_GETSTYLE = 0x439,
		TB_GETTEXTROWS = 0x43d,
		TB_GETTOOLTIPS = 0x423,
		TB_HIDEBUTTON = 0x404,
		TB_HITTEST = 0x445,
		TB_INDETERMINATE = 0x405,
		TB_INSERTBUTTON = 0x415,
		TB_INSERTBUTTONA = 0x415,
		TB_INSERTBUTTONW = 0x443,
		TB_INSERTMARKHITTEST = 0x451,
		TB_ISBUTTONCHECKED = 0x40a,
		TB_ISBUTTONENABLED = 0x409,
		TB_ISBUTTONHIDDEN = 0x40c,
		TB_ISBUTTONHIGHLIGHTED = 0x40e,
		TB_ISBUTTONINDETERMINATE = 0x40d,
		TB_ISBUTTONPRESSED = 0x40b,
		TB_LOADIMAGES = 0x432,
		TB_MAPACCELERATORA = 0x44e,
		TB_MARKBUTTON = 1030,
		TB_MOVEBUTTON = 0x452,
		TB_PRESSBUTTON = 0x403,
		TB_REPLACEBITMAP = 1070,
		TB_SAVERESTOREA = 1050,
		TB_SAVERESTOREW = 1100,
		TB_SETANCHORHIGHLIGHT = 0x449,
		TB_SETBITMAPSIZE = 0x420,
		TB_SETBUTTONINFOA = 1090,
		TB_SETBUTTONINFOW = 0x440,
		TB_SETBUTTONSIZE = 0x41f,
		TB_SETBUTTONWIDTH = 0x43b,
		TB_SETCMDID = 0x42a,
		TB_SETDISABLEDIMAGELIST = 0x436,
		TB_SETDRAWTEXTFLAGS = 0x446,
		TB_SETEXTENDEDSTYLE = 0x454,
		TB_SETHOTIMAGELIST = 0x434,
		TB_SETHOTITEM = 0x448,
		TB_SETIMAGELIST = 0x430,
		TB_SETINDENT = 0x42f,
		TB_SETINSERTMARK = 0x450,
		TB_SETINSERTMARKCOLOR = 0x458,
		TB_SETMAXTEXTROWS = 0x43c,
		TB_SETPADDING = 0x457,
		TB_SETPARENT = 0x425,
		TB_SETROWS = 0x427,
		TB_SETSTATE = 0x411,
		TB_SETSTYLE = 1080,
		TB_SETTOOLTIPS = 1060,
		WM_USER = 0x400
	}
 


	public enum ToolBarNotifications
	{
		// Fields
		TBN_DROPDOWN = -710,
		TBN_HOTITEMCHANGE = -713,
		TBN_QUERYINSERT = -706,
		TTN_NEEDTEXTA = -520,
		TTN_NEEDTEXTW = -530
	}


	public enum ToolBarStyles
	{
		// Fields
		TBSTYLE_ALTDRAG = 0x400,
		TBSTYLE_AUTOSIZE = 0x10,
		TBSTYLE_BUTTON = 0,
		TBSTYLE_CHECK = 2,
		TBSTYLE_CHECKGROUP = 6,
		TBSTYLE_CUSTOMERASE = 0x2000,
		TBSTYLE_DROPDOWN = 8,
		TBSTYLE_EX_DRAWDDARROWS = 1,
		TBSTYLE_FLAT = 0x800,
		TBSTYLE_GROUP = 4,
		TBSTYLE_LIST = 0x1000,
		TBSTYLE_NOPREFIX = 0x20,
		TBSTYLE_REGISTERDROP = 0x4000,
		TBSTYLE_SEP = 1,
		TBSTYLE_TOOLTIPS = 0x100,
		TBSTYLE_TRANSPARENT = 0x8000,
		TBSTYLE_WRAPABLE = 0x200
	}

	public enum ToolTipFlags
	{
		// Fields
		TTF_ABSOLUTE = 0x80,
		TTF_CENTERTIP = 2,
		TTF_DI_SETITEM = 0x8000,
		TTF_RTLREADING = 4,
		TTF_SUBCLASS = 0x10,
		TTF_TRACK = 0x20,
		TTF_TRANSPARENT = 0x100
	}
 
	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct TOOLTIPTEXT
	{
		public NMHDR hdr;
		public IntPtr lpszText;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=80)]
		public string szText;
		public IntPtr hinst;
		public int uFlags;
	}


	[StructLayout(LayoutKind.Sequential)]
	public struct TOOLTIPTEXTA
	{
		public NMHDR hdr;
		public IntPtr lpszText;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=80)]
		public string szText;
		public IntPtr hinst;
		public int uFlags;
	}


	public enum TrackerEventFlags : uint
	{
		// Fields
		TME_CANCEL = 0x80000000,
		TME_HOVER = 1,
		TME_LEAVE = 2,
		TME_QUERY = 0x40000000
	}



	[StructLayout(LayoutKind.Sequential)]
	public struct TRACKMOUSEEVENTS
	{
		public uint cbSize;
		public uint dwFlags;
		public IntPtr hWnd;
		public uint dwHoverTime;
	}
 
	public enum TreeViewItemFlags
	{
		// Fields
		TVIF_CHILDREN = 0x40,
		TVIF_HANDLE = 0x10,
		TVIF_IMAGE = 2,
		TVIF_INTEGRAL = 0x80,
		TVIF_PARAM = 4,
		TVIF_SELECTEDIMAGE = 0x20,
		TVIF_STATE = 8,
		TVIF_TEXT = 1
	}


	public enum TreeViewMessages
	{
		// Fields
		TV_FIRST = 0x1100,
		TVM_GETITEMRECT = 0x1104,
		TVM_GETITEMW = 0x113e
	}


	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct TVITEM
	{
		public uint mask;
		public IntPtr hItem;
		public uint state;
		public uint stateMask;
		public IntPtr pszText;
		public int cchTextMax;
		public int iImage;
		public int iSelectedImage;
		public int cChildren;
		public int lParam;
	}



	public enum UpdateLayeredWindowsFlags
	{
		// Fields
		ULW_ALPHA = 2,
		ULW_COLORKEY = 1,
		ULW_OPAQUE = 4
	}
 

	public enum VirtualKeys
	{
		// Fields
		VK_0 = 0x30,
		VK_1 = 0x31,
		VK_2 = 50,
		VK_3 = 0x33,
		VK_4 = 0x34,
		VK_5 = 0x35,
		VK_6 = 0x36,
		VK_7 = 0x37,
		VK_8 = 0x38,
		VK_9 = 0x39,
		VK_A = 0x41,
		VK_ADD = 0x6b,
		VK_APPS = 0x5d,
		VK_ATTN = 0xf6,
		VK_B = 0x42,
		VK_BACK = 8,
		VK_C = 0x43,
		VK_CANCEL = 3,
		VK_CAPITAL = 20,
		VK_CLEAR = 12,
		VK_CONTROL = 0x11,
		VK_CRSEL = 0xf7,
		VK_D = 0x44,
		VK_DECIMAL = 110,
		VK_DIVIDE = 0x6f,
		VK_DOWN = 40,
		VK_E = 0x45,
		VK_END = 0x23,
		VK_EREOF = 0xf9,
		VK_ESCAPE = 0x1b,
		VK_EXECUTE = 0x2b,
		VK_EXSEL = 0xf8,
		VK_F = 70,
		VK_G = 0x47,
		VK_H = 0x48,
		VK_HELP = 0x2f,
		VK_HOME = 0x24,
		VK_I = 0x49,
		VK_J = 0x4a,
		VK_K = 0x4b,
		VK_L = 0x4c,
		VK_LBUTTON = 1,
		VK_LCONTROL = 0xa2,
		VK_LEFT = 0x25,
		VK_LMENU = 0xa4,
		VK_LSHIFT = 160,
		VK_LWIN = 0x5b,
		VK_M = 0x4d,
		VK_MENU = 0x12,
		VK_MULTIPLY = 0x6a,
		VK_N = 0x4e,
		VK_NEXT = 0x22,
		VK_NONAME = 0xfc,
		VK_NUMPAD0 = 0x60,
		VK_NUMPAD1 = 0x61,
		VK_NUMPAD2 = 0x62,
		VK_NUMPAD3 = 0x63,
		VK_NUMPAD4 = 100,
		VK_NUMPAD5 = 0x65,
		VK_NUMPAD6 = 0x66,
		VK_NUMPAD7 = 0x67,
		VK_NUMPAD8 = 0x68,
		VK_NUMPAD9 = 0x69,
		VK_O = 0x4f,
		VK_OEM_CLEAR = 0xfe,
		VK_P = 80,
		VK_PA1 = 0xfd,
		VK_PLAY = 250,
		VK_PRIOR = 0x21,
		VK_Q = 0x51,
		VK_R = 0x52,
		VK_RCONTROL = 0xa3,
		VK_RETURN = 13,
		VK_RIGHT = 0x27,
		VK_RMENU = 0xa5,
		VK_RSHIFT = 0xa1,
		VK_RWIN = 0x5c,
		VK_S = 0x53,
		VK_SELECT = 0x29,
		VK_SEPARATOR = 0x6c,
		VK_SHIFT = 0x10,
		VK_SNAPSHOT = 0x2c,
		VK_SPACE = 0x20,
		VK_SUBTRACT = 0x6d,
		VK_T = 0x54,
		VK_TAB = 9,
		VK_U = 0x55,
		VK_UP = 0x26,
		VK_V = 0x56,
		VK_W = 0x57,
		VK_X = 0x58,
		VK_Y = 0x59,
		VK_Z = 90,
		VK_ZOOM = 0xfb
	}
 

	public enum WindowExStyles
	{
		// Fields
		WS_EX_ACCEPTFILES = 0x10,
		WS_EX_APPWINDOW = 0x40000,
		WS_EX_CLIENTEDGE = 0x200,
		WS_EX_CONTEXTHELP = 0x400,
		WS_EX_CONTROLPARENT = 0x10000,
		WS_EX_DLGMODALFRAME = 1,
		WS_EX_LAYERED = 0x80000,
		WS_EX_LEFT = 0,
		WS_EX_LEFTSCROLLBAR = 0x4000,
		WS_EX_LTRREADING = 0,
		WS_EX_MDICHILD = 0x40,
		WS_EX_NOPARENTNOTIFY = 4,
		WS_EX_OVERLAPPEDWINDOW = 0x300,
		WS_EX_PALETTEWINDOW = 0x188,
		WS_EX_RIGHT = 0x1000,
		WS_EX_RIGHTSCROLLBAR = 0,
		WS_EX_RTLREADING = 0x2000,
		WS_EX_STATICEDGE = 0x20000,
		WS_EX_TOOLWINDOW = 0x80,
		WS_EX_TOPMOST = 8,
		WS_EX_TRANSPARENT = 0x20,
		WS_EX_WINDOWEDGE = 0x100
	}


	[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
	public struct WINDOWPLACEMENT
	{
		public uint length;
		public uint flags;
		public uint showCmd;
		public POINT ptMinPosition;
		public POINT ptMaxPosition;
		public RECT rcNormalPosition;
	}


	public class WindowsAPI
	{
		// Methods
		private WindowsAPI()
		{
		}
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT ps);
		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hDCDest, int XOriginDest, int YOriginDest, int WidthDest, int HeightDest, IntPtr hDCSrc, int XOriginScr, int YOriginSrc, uint Rop);
		[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhook, int code, IntPtr wparam, IntPtr lparam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool ClientToScreen(IntPtr hWnd, ref POINT pt);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool CloseClipboard();
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int Width, int Heigth);
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
		[DllImport("gdi32")]
		public static extern IntPtr CreateDIBSection(IntPtr hdc, ref BITMAPINFO_FLAT bmi, int iUsage, ref int ppvBits, IntPtr hSection, int dwOffset);
		[DllImport("gdi32")]
		public static extern IntPtr CreateSolidBrush(uint crColor);
		[DllImport("gdi32.dll")]
		public static extern IntPtr DeleteDC(IntPtr hDC);
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool DispatchMessage(ref MSG msg);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int DrawText(IntPtr hdc, string lpString, int nCount, ref RECT lpRect, int uFormat);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool EmptyClipboard();
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT ps);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int FillRect(IntPtr hDC, ref RECT rect, IntPtr hBrush);
		public static int GET_X_LPARAM(int lParam)
		{
			return (lParam & 0xffff);
		}

		public static int GET_Y_LPARAM(int lParam)
		{
			return (lParam >> 0x10);
		}

		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int GetClassName(IntPtr hWnd, out STRINGBUFFER ClassName, int nMaxCount);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int GetClientRect(IntPtr hWnd, ref RECT rc);
		[DllImport("comctl32.dll", EntryPoint="DllGetVersion")]
		public static extern int GetCommonControlDLLVersion(ref DLLVERSIONINFO dvi);
		[DllImport("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
		public static extern int GetCurrentThreadId();
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetDC(IntPtr hWnd);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hRegion, uint flags);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetDesktopWindow();
		[DllImport("gdi32")]
		public static extern int GetDIBits(IntPtr hDC, IntPtr hbm, int StartScan, int ScanLines, int lpBits, BITMAPINFOHEADER bmi, int usage);
		[DllImport("gdi32")]
		public static extern int GetDIBits(IntPtr hdc, IntPtr hbm, int StartScan, int ScanLines, int lpBits, ref BITMAPINFO_FLAT bmi, int usage);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetDlgItem(IntPtr hDlg, int nControlID);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetFocus();
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern ushort GetKeyState(int virtKey);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool GetMenuItemRect(IntPtr hWnd, IntPtr hMenu, uint Item, ref RECT rc);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool GetMessage(ref MSG msg, int hWnd, uint wFilterMin, uint wFilterMax);
		[DllImport("gdi32.dll")]
		public static extern int GetObjectType(IntPtr handle);
		[DllImport("gdi32")]
		public static extern IntPtr GetPaletteEntries(IntPtr hpal, int iStartIndex, int nEntries, byte[] lppe);
		[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
		public static extern IntPtr GetParent(IntPtr hWnd);
		[DllImport("gdi32.dll")]
		public static extern uint GetPixel(IntPtr hDC, int XPos, int YPos);
		public static Point GetPointFromLPARAM(int lParam)
		{
			return new Point(WindowsAPI.GET_X_LPARAM(lParam), WindowsAPI.GET_Y_LPARAM(lParam));
		}

		[DllImport("gdi32")]
		public static extern IntPtr GetSystemPaletteEntries(IntPtr hdc, int iStartIndex, int nEntries, byte[] lppe);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT wp);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int GetWindowText(IntPtr hWnd, out STRINGBUFFER text, int maxCount);
		public static int HIGH_ORDER(int param)
		{
			return (param >> 0x10);
		}

		[DllImport("comctl32.dll")]
		public static extern bool InitCommonControlsEx(INITCOMMONCONTROLSEX icc);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int InvalidateRect(IntPtr hWnd, IntPtr rect, int bErase);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr LoadCursor(IntPtr hInstance, uint cursor);
		public static int LOW_ORDER(int param)
		{
			return (param & 0xffff);
		}

		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool OpenClipboard(IntPtr hWndNewOwner);
		[DllImport("gdi32.dll")]
		public static extern bool PatBlt(IntPtr hDC, int XLeft, int YLeft, int Width, int Height, uint Rop);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool PeekMessage(ref MSG msg, int hWnd, uint wFilterMin, uint wFilterMax, uint wFlag);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref HD_HITTESTINFO hti);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref HDITEM lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref LVITEM lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref POINT lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref REBARBANDINFO lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref RECT lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref TBBUTTON lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref TBBUTTONINFO lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern void SendMessage(IntPtr hWnd, int msg, int wParam, ref TVITEM lParam);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
		[DllImport("gdi32")]
		public static extern int SetBkMode(IntPtr hDC, BackgroundMode mode);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetClipboardData(uint Format, IntPtr hData);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetCursor(IntPtr hCursor);
		[DllImport("gdi32")]
		public static extern uint SetDCBrushColor(IntPtr hdc, uint crColor);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetFocus(IntPtr hWnd);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("gdi32.dll")]
		public static extern int SetMapMode(IntPtr hDC, int fnMapMode);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetParent(IntPtr hChild, IntPtr hParent);
		[DllImport("gdi32")]
		public static extern int SetStretchBltMode(IntPtr hDC, int StrechMode);
		[DllImport("gdi32")]
		public static extern uint SetTextColor(IntPtr hDC, uint colorRef);
		[DllImport("gdi32")]
		public static extern int SetViewportOrgEx(IntPtr hdc, int x, int y, int param);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int Width, int Height, uint flags);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool redraw);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SetWindowsHookEx(int hookid, HookProc pfnhook, IntPtr hinst, int threadid);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern int SetWindowText(IntPtr hWnd, string text);
		[DllImport("uxtheme.dll")]
		public static extern int SetWindowTheme(IntPtr hWnd, string AppID, string ClassID);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool ShowWindow(IntPtr hWnd, short State);
		[DllImport("gdi32.dll")]
		public static extern bool StretchBlt(IntPtr hDCDest, int XOriginDest, int YOriginDest, int WidthDest, int HeightDest, IntPtr hDCSrc, int XOriginScr, int YOriginSrc, int WidthScr, int HeightScr, uint Rop);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENTS tme);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool TranslateMessage(ref MSG msg);
		[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
		public static extern bool UnhookWindowsHookEx(IntPtr hhook);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pprSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern bool UpdateWindow(IntPtr hWnd);
		[DllImport("User32.dll", CharSet=CharSet.Auto)]
		public static extern bool WaitMessage();

		// Fields
		public const string PROGRESSBARCLASSNAME = "msctls_progress32";
		public const string REBARCLASSNAME = "ReBarWindow32";
		public const string TOOLBARCLASSNAME = "ToolbarWindow32";

		// Nested Types
		public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

	}
 
	public enum WindowsHookCodes
	{
		// Fields
		WH_CALLWNDPROC = 4,
		WH_CALLWNDPROCRET = 12,
		WH_CBT = 5,
		WH_DEBUG = 9,
		WH_FOREGROUNDIDLE = 11,
		WH_GETMESSAGE = 3,
		WH_HARDWARE = 8,
		WH_JOURNALPLAYBACK = 1,
		WH_JOURNALRECORD = 0,
		WH_KEYBOARD = 2,
		WH_KEYBOARD_LL = 13,
		WH_MOUSE = 7,
		WH_MOUSE_LL = 14,
		WH_MSGFILTER = -1,
		WH_SHELL = 10,
		WH_SYSMSGFILTER = 6
	}



	public enum WindowStyles : uint
	{
		// Fields
		WS_BORDER = 0x800000,
		WS_CAPTION = 0xc00000,
		WS_CHILD = 0x40000000,
		WS_CHILDWINDOW = 0x40000000,
		WS_CLIPCHILDREN = 0x2000000,
		WS_CLIPSIBLINGS = 0x4000000,
		WS_DISABLED = 0x8000000,
		WS_DLGFRAME = 0x400000,
		WS_GROUP = 0x20000,
		WS_HSCROLL = 0x100000,
		WS_ICONIC = 0x20000000,
		WS_MAXIMIZE = 0x1000000,
		WS_MAXIMIZEBOX = 0x10000,
		WS_MINIMIZE = 0x20000000,
		WS_MINIMIZEBOX = 0x20000,
		WS_OVERLAPPED = 0,
		WS_OVERLAPPEDWINDOW = 0xcf0000,
		WS_POPUP = 0x80000000,
		WS_POPUPWINDOW = 0x80880000,
		WS_SIZEBOX = 0x40000,
		WS_SYSMENU = 0x80000,
		WS_TABSTOP = 0x10000,
		WS_THICKFRAME = 0x40000,
		WS_TILED = 0,
		WS_TILEDWINDOW = 0xcf0000,
		WS_VISIBLE = 0x10000000,
		WS_VSCROLL = 0x200000
	}
 


}
