VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.Form frmReceipt 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "ﬁ»Ê· „—”Ê·Â"
   ClientHeight    =   8580
   ClientLeft      =   1680
   ClientTop       =   645
   ClientWidth     =   11250
   Icon            =   "frmReceipt.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   8580
   ScaleWidth      =   11250
   ShowInTaskbar   =   0   'False
   Begin VB.Frame frame1 
      Height          =   4815
      Index           =   0
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   48
      Top             =   1920
      Width           =   4815
      Begin VB.CheckBox chkUnStandardPackage 
         Alignment       =   1  'Right Justify
         Caption         =   "Å«ﬂ  €Ì— «” «‰œ«—œ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1980
         RightToLeft     =   -1  'True
         TabIndex        =   37
         Tag             =   "50"
         Top             =   2580
         Width           =   1620
      End
      Begin VB.ComboBox cboPackage 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         ItemData        =   "frmReceipt.frx":0442
         Left            =   2040
         List            =   "frmReceipt.frx":0472
         RightToLeft     =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   34
         Top             =   1560
         Width           =   1335
      End
      Begin VB.TextBox txtPackage 
         Alignment       =   1  'Right Justify
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         Locked          =   -1  'True
         RightToLeft     =   -1  'True
         TabIndex        =   35
         Tag             =   "1"
         Top             =   1560
         Width           =   1455
      End
      Begin VB.TextBox txtDiscount 
         Alignment       =   1  'Right Justify
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   38
         Tag             =   "1"
         ToolTipText     =   " Œ›Ì› œ— ﬁ—«—œ«œÂ«"
         Top             =   3480
         Width           =   1455
      End
      Begin VB.CheckBox chkUnSize 
         Alignment       =   1  'Right Justify
         Caption         =   "Œ«—Ã «“ «‰œ«“Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1980
         RightToLeft     =   -1  'True
         TabIndex        =   36
         Tag             =   "50"
         Top             =   2100
         Width           =   1215
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   19
         Left            =   120
         TabIndex        =   91
         Top             =   3060
         Width           =   255
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H00C0FFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "Õﬁ „ﬁ—:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   12
         Left            =   2040
         RightToLeft     =   -1  'True
         TabIndex        =   90
         Top             =   3060
         Width           =   615
      End
      Begin VB.Label lbSendPlace 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   89
         Top             =   3000
         Width           =   1455
      End
      Begin VB.Label lblTotalPrice 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   85
         Top             =   3960
         Width           =   1455
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Â“Ì‰Â Å” Ì:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   18
         Left            =   2040
         RightToLeft     =   -1  'True
         TabIndex        =   84
         Top             =   4020
         Width           =   945
      End
      Begin VB.Line Line5 
         BorderColor     =   &H00FFFFFF&
         Index           =   0
         X1              =   480
         X2              =   3640
         Y1              =   3390
         Y2              =   3390
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00808080&
         BorderWidth     =   2
         Index           =   1
         X1              =   480
         X2              =   3640
         Y1              =   3405
         Y2              =   3405
      End
      Begin VB.Line Line5 
         BorderColor     =   &H00808080&
         Index           =   1
         X1              =   480
         X2              =   3640
         Y1              =   3870
         Y2              =   3870
      End
      Begin VB.Label lbHint 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "»—«Ì «” ›«œÂ «“ „«‘Ì‰ Õ”«» ”Ì” „ «“ œﬂ„Â F8 «” ›«œÂ ‰„«ÌÌœ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00C00000&
         Height          =   195
         Index           =   8
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   82
         Top             =   240
         Width           =   4530
      End
      Begin VB.Label lblUnstandardPackage 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   64
         Top             =   2520
         Width           =   1455
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   24
         Left            =   120
         TabIndex        =   63
         Top             =   2580
         Width           =   255
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "»” Â »‰œÌ Ê ·›«›:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   17
         Left            =   3420
         RightToLeft     =   -1  'True
         TabIndex        =   62
         Top             =   1620
         Width           =   1320
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   14
         Left            =   120
         TabIndex        =   61
         Top             =   2100
         Width           =   255
      End
      Begin VB.Label lblTotaltxt 
         Alignment       =   2  'Center
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BackStyle       =   0  'Transparent
         Caption         =   "(’›—)"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   195
         Left            =   225
         RightToLeft     =   -1  'True
         TabIndex        =   60
         Top             =   4440
         Width           =   4455
         WordWrap        =   -1  'True
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   16
         Left            =   120
         TabIndex        =   59
         Top             =   4020
         Width           =   255
      End
      Begin VB.Label lblInsur 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   58
         Top             =   1080
         Width           =   1455
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H00C0FFFF&
         BackStyle       =   0  'Transparent
         Caption         =   ":‰—Œ »Ì„Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   7
         Left            =   2040
         TabIndex        =   57
         Top             =   1140
         Width           =   630
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   120
         TabIndex        =   56
         Top             =   1620
         Width           =   255
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   15
         Left            =   120
         TabIndex        =   55
         Top             =   3540
         Width           =   255
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H00C0FFFF&
         BackStyle       =   0  'Transparent
         Caption         =   ": Œ›Ì› Ì«  „»— „‘ —Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   10
         Left            =   2040
         TabIndex        =   54
         Top             =   3540
         Width           =   1575
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   13
         Left            =   120
         TabIndex        =   53
         Top             =   660
         Width           =   255
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackColor       =   &H00C0FFFF&
         BackStyle       =   0  'Transparent
         Caption         =   "ﬂ—«ÌÂ Å” Ì:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   6
         Left            =   2040
         RightToLeft     =   -1  'True
         TabIndex        =   52
         Top             =   660
         Width           =   885
      End
      Begin VB.Label lblParcelFare 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   51
         Top             =   600
         Width           =   1455
      End
      Begin VB.Label lblUnsize 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   50
         Top             =   2040
         Width           =   1455
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "—Ì«·"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   20
         Left            =   120
         TabIndex        =   49
         Top             =   1140
         Width           =   255
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         BorderWidth     =   2
         Index           =   0
         X1              =   480
         X2              =   3640
         Y1              =   3885
         Y2              =   3885
      End
   End
   Begin MSCommLib.MSComm msCommScale 
      Left            =   1920
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
      BaudRate        =   2400
   End
   Begin VB.Frame frame1 
      Caption         =   "‰Ê⁄ „—”Ê·Â"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Index           =   4
      Left            =   8160
      RightToLeft     =   -1  'True
      TabIndex        =   80
      Top             =   600
      Width           =   3015
      Begin VB.ComboBox cboParcelType 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         ItemData        =   "frmReceipt.frx":04DD
         Left            =   240
         List            =   "frmReceipt.frx":04FC
         RightToLeft     =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   720
         Width           =   2535
      End
      Begin VB.OptionButton optParcelType 
         Alignment       =   1  'Right Justify
         Caption         =   "»” Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   960
         RightToLeft     =   -1  'True
         TabIndex        =   3
         Top             =   360
         Width           =   735
      End
      Begin VB.OptionButton optParcelType 
         Alignment       =   1  'Right Justify
         Caption         =   "Å«ﬂ "
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   2160
         RightToLeft     =   -1  'True
         TabIndex        =   2
         Top             =   360
         Value           =   -1  'True
         Width           =   615
      End
   End
   Begin VB.Frame frame1 
      Caption         =   "Œ’Ê’Ì«  ÊÌéÂ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Index           =   2
      Left            =   5040
      RightToLeft     =   -1  'True
      TabIndex        =   81
      Top             =   1920
      Width           =   1815
      Begin VB.CheckBox chkAmanat_Anbooh 
         Alignment       =   1  'Right Justify
         Caption         =   "«„«‰  «‰»ÊÂ"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   480
         RightToLeft     =   -1  'True
         TabIndex        =   18
         Tag             =   "50"
         Top             =   1080
         Width           =   1095
      End
      Begin VB.CheckBox chkAmanat_Tejari 
         Alignment       =   1  'Right Justify
         Caption         =   "«„«‰   Ã«—Ì"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   360
         RightToLeft     =   -1  'True
         TabIndex        =   17
         Tag             =   "50"
         Top             =   840
         Width           =   1215
      End
      Begin VB.CheckBox chkBankParcel 
         Alignment       =   1  'Right Justify
         Caption         =   "„—”Ê·«  »«‰ﬂÌ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   16
         Tag             =   "50"
         Top             =   600
         Width           =   1455
      End
      Begin VB.CheckBox chkFragile 
         Alignment       =   1  'Right Justify
         Caption         =   "«‘Ì«¡‘ﬂ” ‰Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   15
         Tag             =   "50"
         Top             =   360
         Width           =   1455
      End
   End
   Begin VB.Frame frame1 
      Caption         =   " Ê“Ì‰"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Index           =   5
      Left            =   5040
      RightToLeft     =   -1  'True
      TabIndex        =   77
      Top             =   600
      Width           =   3015
      Begin VB.CommandButton cmdWeight 
         Caption         =   " Ê“Ì‰ (F12)"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1680
         RightToLeft     =   -1  'True
         TabIndex        =   5
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txtWeight 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   480
         MaxLength       =   5
         RightToLeft     =   -1  'True
         TabIndex        =   6
         Tag             =   "11"
         Top             =   750
         Width           =   975
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H00C0FFFF&
         BackStyle       =   0  'Transparent
         Caption         =   " —«“Ê:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   9
         Left            =   2520
         RightToLeft     =   -1  'True
         TabIndex        =   87
         Top             =   300
         Width           =   360
      End
      Begin VB.Label lbScale 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   86
         Top             =   240
         Width           =   2295
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "ê—„"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   4
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   78
         Top             =   810
         Width           =   255
      End
   End
   Begin VB.Frame frame1 
      Caption         =   "‰ÕÊÂ Å—œ«Œ "
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Index           =   3
      Left            =   6960
      RightToLeft     =   -1  'True
      TabIndex        =   79
      Top             =   1920
      Width           =   4215
      Begin VB.ComboBox cboLservice 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   11
         Text            =   "cboLservice"
         Top             =   540
         Width           =   2295
      End
      Begin VB.ComboBox cboGservice 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         ItemData        =   "frmReceipt.frx":0555
         Left            =   120
         List            =   "frmReceipt.frx":0557
         RightToLeft     =   -1  'True
         TabIndex        =   14
         Text            =   "cboGservice"
         Top             =   1260
         Width           =   2295
      End
      Begin VB.OptionButton optPay 
         Alignment       =   1  'Right Justify
         Caption         =   "ﬁ—«—œ«œ ”—«”—Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   3
         Left            =   2400
         RightToLeft     =   -1  'True
         TabIndex        =   13
         Top             =   1320
         Width           =   1575
      End
      Begin VB.OptionButton optPay 
         Alignment       =   1  'Right Justify
         Caption         =   "ﬂ—«ÌÂ œ— „ﬁ’œ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   12
         Top             =   960
         Width           =   1335
      End
      Begin VB.OptionButton optPay 
         Alignment       =   1  'Right Justify
         Caption         =   "ﬁ—«—œ«œ œ«Œ·Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   10
         Top             =   600
         Width           =   1335
      End
      Begin VB.OptionButton optPay 
         Alignment       =   1  'Right Justify
         Caption         =   "‰ﬁœÌ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   3240
         RightToLeft     =   -1  'True
         TabIndex        =   9
         Top             =   240
         Value           =   -1  'True
         Width           =   735
      End
   End
   Begin VB.Frame frame1 
      Caption         =   "Œœ„«  ÊÌéÂ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Index           =   6
      Left            =   5040
      RightToLeft     =   -1  'True
      TabIndex        =   75
      Top             =   3720
      Width           =   6135
      Begin VB.ComboBox cboIranInsurType 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         ItemData        =   "frmReceipt.frx":0559
         Left            =   2880
         List            =   "frmReceipt.frx":0563
         RightToLeft     =   -1  'True
         TabIndex        =   20
         Text            =   "cboIranInsurType"
         Top             =   240
         Visible         =   0   'False
         Width           =   1905
      End
      Begin VB.CheckBox ChkIranInsurance 
         Alignment       =   1  'Right Justify
         Caption         =   "»Ì„Â Å” Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   4800
         RightToLeft     =   -1  'True
         TabIndex        =   19
         Tag             =   "50"
         Top             =   270
         Width           =   1095
      End
      Begin VB.CheckBox chkPrice_receive 
         Alignment       =   1  'Right Justify
         Caption         =   " ÕÊÌ· œ— „ﬁ«»· »Â«"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Left            =   3120
         RightToLeft     =   -1  'True
         TabIndex        =   23
         Tag             =   "50"
         Top             =   832
         Width           =   1575
      End
      Begin VB.CheckBox chkTwoReceipt 
         Alignment       =   1  'Right Justify
         Caption         =   "œÊﬁ»÷Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   5040
         RightToLeft     =   -1  'True
         TabIndex        =   22
         Tag             =   "50"
         Top             =   810
         Width           =   855
      End
      Begin VB.TextBox txtExpInsur 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         MaxLength       =   8
         RightToLeft     =   -1  'True
         TabIndex        =   21
         Tag             =   "1"
         Top             =   240
         Visible         =   0   'False
         Width           =   975
      End
      Begin VB.CheckBox chkExpress 
         Alignment       =   1  'Right Justify
         Caption         =   "«ﬂ”Å—”"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1800
         RightToLeft     =   -1  'True
         TabIndex        =   24
         Tag             =   "50"
         Top             =   840
         Width           =   975
      End
      Begin VB.CheckBox chkRestant 
         Alignment       =   1  'Right Justify
         Caption         =   "—” «‰ "
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   25
         Tag             =   "50"
         Top             =   840
         Width           =   855
      End
      Begin VB.Label lblInsurlabel 
         AutoSize        =   -1  'True
         BackColor       =   &H00C0C0C0&
         BackStyle       =   0  'Transparent
         Caption         =   "«—“‘ «ŸÂ«— ‘œÂ(—Ì«·):"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1200
         RightToLeft     =   -1  'True
         TabIndex        =   76
         Top             =   300
         Visible         =   0   'False
         Width           =   1560
      End
   End
   Begin VB.Frame frame1 
      Caption         =   "›—” ‰œÂ/êÌ—‰œÂ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Index           =   1
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   72
      Top             =   600
      Width           =   4815
      Begin VB.TextBox txtSender 
         Alignment       =   1  'Right Justify
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   7
         Tag             =   "21"
         ToolTipText     =   "Left Shift+Left Alt : €ÌÌ— “»«‰"
         Top             =   360
         Width           =   3735
      End
      Begin VB.TextBox txtReceiver 
         Alignment       =   1  'Right Justify
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   8
         Tag             =   "21"
         ToolTipText     =   "Left Shift+Left Alt : €ÌÌ— “»«‰"
         Top             =   720
         Width           =   3735
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   ":›—” ‰œÂ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   3960
         TabIndex        =   74
         Top             =   420
         Width           =   660
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   ":êÌ—‰œÂ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   3
         Left            =   3960
         TabIndex        =   73
         Top             =   780
         Width           =   480
      End
   End
   Begin VB.Frame DestFrame 
      Caption         =   "„ﬁ’œ  (F11)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1575
      Left            =   5040
      RightToLeft     =   -1  'True
      TabIndex        =   68
      Top             =   5160
      Width           =   6135
      Begin VB.TextBox txtDestcode 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         MaxLength       =   5
         RightToLeft     =   -1  'True
         TabIndex        =   29
         Tag             =   "1"
         Top             =   240
         Width           =   735
      End
      Begin VB.OptionButton optDestination 
         Alignment       =   1  'Right Justify
         Caption         =   "Œ«—ÃÂ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   2
         Left            =   2520
         RightToLeft     =   -1  'True
         TabIndex        =   28
         Top             =   300
         Width           =   735
      End
      Begin VB.OptionButton optDestination 
         Alignment       =   1  'Right Justify
         Caption         =   "»Ì‰ ‘Â—Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   1
         Left            =   3600
         RightToLeft     =   -1  'True
         TabIndex        =   27
         Top             =   300
         Value           =   -1  'True
         Width           =   1095
      End
      Begin VB.OptionButton optDestination 
         Alignment       =   1  'Right Justify
         Caption         =   "‘Â—Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   0
         Left            =   5040
         RightToLeft     =   -1  'True
         TabIndex        =   26
         Top             =   300
         Width           =   855
      End
      Begin VB.ComboBox cboSendtype 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         ItemData        =   "frmReceipt.frx":058D
         Left            =   2640
         List            =   "frmReceipt.frx":0597
         RightToLeft     =   -1  'True
         Style           =   2  'Dropdown List
         TabIndex        =   33
         Top             =   1080
         Width           =   2055
      End
      Begin VB.ComboBox cboCity 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   30
         Text            =   "cboCity"
         Top             =   600
         Width           =   2055
      End
      Begin VB.ComboBox cboCountry 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   31
         Text            =   "cboCountry"
         Top             =   600
         Width           =   2055
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   ":ﬂœ„ﬁ’œ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   11
         Left            =   960
         TabIndex        =   88
         Top             =   300
         Width           =   630
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "‰ÕÊÂ —Â”Å«—Ì:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   4800
         RightToLeft     =   -1  'True
         TabIndex        =   83
         Top             =   1140
         Width           =   1080
      End
      Begin VB.Label lblProvince 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "«” «‰:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   1980
         RightToLeft     =   -1  'True
         TabIndex        =   71
         Top             =   660
         Width           =   480
      End
      Begin VB.Label lblCity 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "‘Â—:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   4800
         RightToLeft     =   -1  'True
         TabIndex        =   70
         Top             =   660
         Width           =   390
      End
      Begin VB.Label lblCityName 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   69
         Top             =   600
         Width           =   2025
      End
      Begin VB.Label lblProvincename 
         Alignment       =   1  'Right Justify
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   32
         Top             =   600
         Width           =   1785
      End
   End
   Begin VB.Frame fraParcelCode 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   65
      Top             =   6840
      Width           =   11055
      Begin VB.TextBox txtUniqueCode 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   315
         Left            =   6960
         MaxLength       =   20
         RightToLeft     =   -1  'True
         TabIndex        =   39
         Top             =   240
         Width           =   2415
      End
      Begin VB.TextBox txtReceiptCode 
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00800000&
         Height          =   315
         Left            =   120
         MaxLength       =   20
         RightToLeft     =   -1  'True
         TabIndex        =   40
         Top             =   240
         Visible         =   0   'False
         Width           =   2415
      End
      Begin VB.Label lblCode 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "ﬂœ «‰Õ’«—Ì „—”Ê·Â:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   9480
         RightToLeft     =   -1  'True
         TabIndex        =   67
         Top             =   300
         Width           =   1440
      End
      Begin VB.Label lblTwoReceipt 
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "ﬂœ ﬁ»÷ œÊ„:"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000002&
         Height          =   195
         Left            =   2640
         RightToLeft     =   -1  'True
         TabIndex        =   66
         Top             =   300
         Visible         =   0   'False
         Width           =   900
      End
   End
   Begin VB.CheckBox chkSendPlace 
      Alignment       =   1  'Right Justify
      Caption         =   "ﬁ»Ê· «“ „ﬁ— ›—” ‰œÂ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Left            =   7320
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Tag             =   "50"
      Top             =   180
      Width           =   1815
   End
   Begin VB.TextBox txtSoshNumber 
      Alignment       =   1  'Right Justify
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Left            =   9360
      MaxLength       =   4
      RightToLeft     =   -1  'True
      TabIndex        =   0
      Text            =   "1"
      Top             =   120
      Width           =   495
   End
   Begin VB.CommandButton CmdPrintReceipt 
      BackColor       =   &H80000005&
      Caption         =   " ÂÌÂ —”Ìœ Å” Ì"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7200
      RightToLeft     =   -1  'True
      TabIndex        =   42
      Top             =   7680
      Width           =   1575
   End
   Begin VB.CommandButton cmdCalculate 
      BackColor       =   &H80000000&
      Caption         =   "„Õ«”»Â ﬂœ «‰Õ’«—Ì Ê ‰—Œ  (F9)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8880
      RightToLeft     =   -1  'True
      TabIndex        =   41
      Top             =   7680
      Width           =   2295
   End
   Begin VB.CommandButton cmdNew 
      BackColor       =   &H80000005&
      Caption         =   "„—”Ê·Â ÃœÌœ  (Ctrl+N)"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   44
      Top             =   7680
      Width           =   1935
   End
   Begin VB.CommandButton cmdEdit 
      BackColor       =   &H80000005&
      Caption         =   "ÊÌ—«Ì‘ „—”Ê·«  «‰»ÊÂ"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2160
      RightToLeft     =   -1  'True
      TabIndex        =   43
      Top             =   7680
      Width           =   1935
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Height          =   375
      Left            =   120
      TabIndex        =   45
      Top             =   8160
      Width           =   11055
      _ExtentX        =   19500
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   3
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            Alignment       =   1
            AutoSize        =   2
            TextSave        =   "10:05 ».Ÿ"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            AutoSize        =   1
            Object.Width           =   4180
            Text            =   ":ﬂ«—»—"
            TextSave        =   ":ﬂ«—»—"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            AutoSize        =   2
            Object.Width           =   12674
            Text            =   ". ÊÃÂ: ‰—Œ „—”Ê·«  Å” Ì »— «”«” “„«‰ ”Ì” „ „Õ«”»Â „Ìù‘Êœ. œ—  ‰ŸÌ„ ”«⁄  Ê  «—ÌŒ œﬁ  ﬂ‰Ìœ"
            TextSave        =   ". ÊÃÂ: ‰—Œ „—”Ê·«  Å” Ì »— «”«” “„«‰ ”Ì” „ „Õ«”»Â „Ìù‘Êœ. œ—  ‰ŸÌ„ ”«⁄  Ê  «—ÌŒ œﬁ  ﬂ‰Ìœ"
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSCommLib.MSComm mscommBprinter 
      Left            =   2520
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      CommPort        =   2
      DTREnable       =   -1  'True
      InputLen        =   1
      RThreshold      =   1
   End
   Begin VB.Image imgArm 
      Height          =   375
      Left            =   5318
      OLEDropMode     =   1  'Manual
      Picture         =   "frmReceipt.frx":05A9
      Stretch         =   -1  'True
      Top             =   7680
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Image imgEmsArm 
      Height          =   375
      Left            =   4200
      Picture         =   "frmReceipt.frx":0B0B
      Stretch         =   -1  'True
      Top             =   7680
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.Label lblCounter 
      BackStyle       =   0  'Transparent
      Caption         =   "„‘Œ’«  „—”Ê·Â 1 «“ 1"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   255
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   47
      Top             =   150
      Width           =   2655
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   " ⁄œ«œ „—”Ê·« :"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   195
      Index           =   5
      Left            =   9915
      RightToLeft     =   -1  'True
      TabIndex        =   46
      Top             =   180
      Width           =   1095
   End
End
Attribute VB_Name = "frmReceipt"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim L_ParcelNumber As Integer           ' ⁄œ«œ „—”Ê·Â
Dim L_NewCodeCounter As Integer         '‘„«—Â «‰œÌ” „—”Ê·Â œ— «‰»ÊÂÂ«
Dim L_RegCounter As Long              '‘„«—‰œÂ ‘„«—Â ”—Ì«·
Dim L_WeightBalance As String
Dim L_ServiceType As String * 20

'¬—«ÌÂ Â«Ì „—”Ê·«  «‰»ÊÂ
Dim L_DestTypeArray(999) As Byte   '0:‘Â—Ì  1:»Ì‰ ‘Â—Ì  2:Œ«—ÃÂ
Dim L_ShippingArray(999) As Byte   '0:“„Ì‰Ì  1:ÂÊ«ÌÌ
Dim L_PayTypeArray(999) As Byte   '0:‰ﬁœÌ  1:ﬁ—«—œ«œÌ  2:ﬂ—«ÌÂ œ— „ﬁ’œ
Dim L_IranInsuranceArray(999) As Byte   '0:€Ì—»Ì„Â 1:ÊÃÊÂ ‰ﬁœ Ê «”‰«œ Ê „—”Ê·«  »«‰ﬂÌ 2:”«Ì— («”‰«œ »« «—“‘ ‰«„⁄Ì‰)  3:”«Ì— („—”Ê·«  œ«—«Ì «—“‘ „⁄Ì‰)
Dim L_UniqueCodeArray(999) As String
Dim L_TwoReceiptCodeArray(999) As String
Dim L_strBarcodeArray(999) As String          '»«—ﬂœ
Dim L_strTwoReceiptBarcodeArray(999) As String    ' »«—ﬂœ ﬁ»÷ œÊ„
Dim L_ServiceTypeArray(999) As String * 20
Dim L_ParcelFormArray(999) As Byte
Dim L_PackageTypeArray(999) As Integer
Dim L_WeightArray(999) As Long
Dim L_InsurCostArray(999) As Long
Dim L_ExpInsurArray(999) As Long
Dim L_ParcelFareArray(999) As Long
Dim L_PackageCostArray(999) As Long
Dim L_DiscountArray(999) As Long
Dim L_DestcodeArray(999) As Long
Dim L_DestNameArray(999) As String
Dim L_SenderArray(999) As String
Dim L_ReceiverArray(999) As String
Dim L_UnsizeArray(999) As Long
Dim L_UnstandardArray(999) As Long
Dim L_SendPlaceCostArray(999) As Long
Dim L_TotalPriceArray(999) As Long
Dim L_ContractsIndexArray(999) As Integer  '«‰œÌ” ﬂ„»Ê ﬁ—«—œ«œ

Dim L_ParcelCodeString As String

Dim L_contractNumber(500) As String   ' ‘„«—Â ﬁ—«—œ«œÂ«
'Dim L_contractCaption(500) As String   ' ⁄‰Ê«‰ ﬁ—«—œ«œÂ«
Dim L_contractDiscount(500) As Integer   ' Œ›Ì› œ— ﬁ—«—œ«œÂ«
Dim L_contractFare(500) As Long   '„»·€ ﬁ—«—œ«œÂ«
Dim L_ContractTwoReceipt(500) As Boolean   'œÊﬁ»÷Â »Êœ‰ œ— ﬁ—«—œ«œÂ«
Dim L_ContractBeginDate(500) As String * 10
Dim L_ContractExpireDate(500) As String * 10
Dim L_ContractTip(500) As Boolean
Dim L_GserviceNumber(100) As String   ' ‘„«—Â ﬁ—«—œ«œ ”—«”—Ì
Dim L_GserviceFare(100) As Long   '„»·€ ›—«—œ«œ ”—«”—Ì

Dim L_Sosh1Report As New rptEmsSosh
Dim L_Sosh2Report As New rptNoneEmsSosh
Dim L_Sosh3Report As New rptEmsSosh2
Dim L_Sosh4Report As New rptNoneEmsSosh2

Dim L_provinceArray(3000) As String
Dim L_CurrentTime As String
Dim L_EditFlag As Boolean
Dim L_CboState As Integer
Dim m_BusyMethod As Byte
'0 : combofill (not select combo or txtDestcode)
'1 : cbocity_click    2: txtDestcode_change

Dim inweight As String * 8
Dim data_completed As Integer

Option Explicit

Sub L_PandBalance()
    Dim vazni As Integer
    Dim vaznf As Double
    Dim vazns As String
    Dim endc As String
    Dim bb As Integer
    Dim i As Long
    
    If msCommScale.PortOpen Then
        msCommScale.PortOpen = False
    End If
    
    'Sleep (100)
    ' Clear Input Buffer
    msCommScale.InBufferCount = 0
    msCommScale.InputMode = comInputModeText
    msCommScale.InputLen = 1
    msCommScale.RThreshold = 1
            
    'Sleep (100)
    
    If msCommScale.PortOpen = False Then
        data_completed = 0
        msCommScale.CommPort = G_ScaleCommPort
        msCommScale.Settings = G_ScaleBaudRate + "," + G_ScaleParity + "," + G_ScaleDatabits + "," + G_ScaleStopbits
        '"2400,n,8,1"
        msCommScale.PortOpen = True
    End If
    
    'MsgBox "2"
    
    i = 0
    'Do Until i > 120000
    Do Until data_completed = 1
        DoEvents
        i = i + 1
    Loop
    
   'MsgBox "3"
   
    If data_completed = 1 Then
        'MsgBox "4"
        'data_completed = 0
        
        'Remarked 4 lines by sayyar at 80/8/21
        'If Val(LTrim$(RTrim$(inweight))) >= 151 Then
               'MsgBox ("WARNING !!!     OVERLOAD")
        'Else
        
        If Len(Trim(inweight)) = 6 Then
            endc = Val(Mid(inweight, 6, 3))
        End If
        If Len(Trim(inweight)) = 5 Then
            endc = Val(Mid(inweight, 5, 3))
        End If
        vaznf = Val(LTrim$(RTrim$(inweight)))
        vaznf = vaznf / 10
        If G_TarazooScale = 1 Then vaznf = vaznf / 10
        If Left((Right(vaznf, 4)), 1) = "." Then   ' .001
            bb = Val(Right(vaznf, 3))
        ElseIf Left((Right(vaznf, 3)), 1) = "." Then   ' .01
            bb = Val(Right(vaznf, 2)) * 10
         ElseIf Left((Right(vaznf, 2)), 1) = "." Then   ' .1
            bb = Val(Right(vaznf, 1)) * 100
         Else
            bb = 0
        End If
        vaznf = (Val(Left(vaznf, 2))) * 1000 + bb
        
        If vaznf = "0.5" Then vaznf = "500"
        L_WeightBalance = Format(vaznf, "###00")
        completeReading
    End If
    
End Sub

Sub L_TozinBalance(Optional counter As Long = 120000)
    On Error GoTo Lastline
    
    Dim str1 As String
    Dim brr(10) As Byte
    Dim arr() As Byte
    Dim i, first As Integer
    Dim cond As Boolean
    Dim rawVal As Long
    Dim Result As Double
    Dim Prec, Dec As Integer
    Dim Sign As Boolean
    Dim Motion As Boolean
    Dim length As Integer
   
    If msCommScale.PortOpen Then
        msCommScale.PortOpen = False
    End If
    
    Sleep (100)
    ' Clear Input Buffer
    msCommScale.InBufferCount = 0
    msCommScale.InputMode = comInputModeBinary
    msCommScale.Settings = G_ScaleBaudRate + "," + G_ScaleParity + "," + G_ScaleDatabits + "," + G_ScaleStopbits
    ' Tell the control to read entire buffer when Input
    ' is used.
    msCommScale.InputLen = 0
    ' Set oncommvent for reading
    msCommScale.RThreshold = 1
    
    Sleep (100)
    If msCommScale.PortOpen = False Then
      ' Open the port.
      msCommScale.CommPort = G_ScaleCommPort
      data_completed = 0
      msCommScale.PortOpen = True
    End If
        
    Sleep (100)
    i = 0
    rawVal = 123
    Sign = True
    cond = True
    Prec = 0
    Dec = 1
    length = 0
                 
    Do Until Len(str1) >= 9 Or i > counter
         Do Until msCommScale.InBufferCount > 15 Or i > counter
             'DoEvents
             i = i + 1
         Loop
         length = msCommScale.InBufferCount
         Sleep (100)
         str1 = msCommScale.Input
         arr = str1
    Loop
    
    ' Check for getting data -----------------------------------
    If length < 15 Then
       Result = -1
       L_WeightBalance = Format(Result, "###0.0")
       data_completed = 1
       completeReading
       Exit Sub
    End If
    
    ' Read from buffer that contains weight data ---------------
    i = LBound(arr)
    For i = LBound(arr) To LBound(arr) + 10 Step 1
       brr(i) = arr(i)
    Next i
    
    i = 0
    Do While cond = True And i < 10
        If (brr(i) And &H80) = &H80 Then
            cond = False
            first = i
        Else
            i = i + 1
        End If
    Loop
    
    ' chck for sign --------------------------------------------
    i = first
    If (brr(i + 1) And &H8) Then
        Sign = True
    Else
        Sign = False
    End If
    
    ' Get Decimal point ----------------------------------------
    Prec = (brr(i) And &H7)
    For i = 1 To Prec Step 1
        Dec = 10 * Dec
    Next i
    
    ' Get raw weight -------------------------------------------
    i = first
    rawVal = (CLng(brr(i + 1)) And CLng(&H7))
    rawVal = rawVal * CLng(&H20000) 'CLng(&H7) * CLng(&H7F) * CLng(&H7F)
    rawVal = rawVal + ((CLng(brr(i + 2)) And CLng(&H7F)) * CLng(&H4000)) ' CLng(&H7F) * CLng(&H7F))
    rawVal = rawVal + ((CLng(brr(i + 3)) And CLng(&H7F)) * CLng(&H80)) 'CLng(&H7F))
    rawVal = rawVal + ((CLng(brr(i + 4)) And CLng(&H7F)))
    
    ' Set sign -------------------------------------------------
    If Sign = True Then
        rawVal = rawVal * -1
    End If
    
    ' Set decimal point ----------------------------------------
    Result = (rawVal / Dec) * 1000
    L_WeightBalance = Format(Result, "###00")
    data_completed = 1
    completeReading
    Exit Sub
Lastline:
    G_ShowMsg "Œÿ« œ— ŒÊ«‰œ‰ Ê“‰: " + Err.Description, vbOKOnly, G_critical
End Sub

Private Sub completeReading()
    If msCommScale.PortOpen Then
        msCommScale.PortOpen = False
    End If
    txtWeight.Text = L_WeightBalance
End Sub

Private Sub fillBoxes()
    lblCounter.Caption = "„‘Œ’«  „—”Ê·Â " + Str(L_NewCodeCounter + 1) + " «“ " + Str(L_ParcelNumber)
    txtSender = L_SenderArray(L_NewCodeCounter)
    txtReceiver = L_ReceiverArray(L_NewCodeCounter)
    txtWeight = L_WeightArray(L_NewCodeCounter)
    If G_IsEMS = 1 Then
        optParcelType(L_ParcelFormArray(L_NewCodeCounter)).Value = True
    Else
        cboParcelType.ListIndex = L_ParcelFormArray(L_NewCodeCounter)
        chkFragile.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmFragile, 1))
        chkBankParcel.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmBankParcel, 1))
        chkExpress.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmExpress, 1))
        chkRestant.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmRestant, 1))
        chkAmanat_Tejari.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmAmanat_Tejari, 1))
        chkAmanat_Anbooh.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmAmanat_Anbooh, 1))
    End If
    
    cboLservice.Visible = False
    cboGservice.Visible = False
    optPay(L_PayTypeArray(L_NewCodeCounter)).Value = True
    If L_PayTypeArray(L_NewCodeCounter) = 1 Then
        cboLservice.ListIndex = L_ContractsIndexArray(L_NewCodeCounter)
        cboLservice.Visible = True
    End If
    If L_PayTypeArray(L_NewCodeCounter) = 3 Then
        cboGservice.ListIndex = L_ContractsIndexArray(L_NewCodeCounter)
        cboGservice.Visible = True
    End If
    
    If Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmInsurType, 1) = 0 Then
        ChkIranInsurance.Value = 0
        'cboIranInsurType.Enabled = False
        txtExpInsur = ""
    Else
        ChkIranInsurance.Value = 1
        cboIranInsurType.ListIndex = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmInsurType, 1)) - 1
        txtExpInsur = L_ExpInsurArray(L_NewCodeCounter)
        'cboIranInsurType.Enabled = True
    End If
    
    chkTwoReceipt.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmTwoReceipt, 1))
    chkPrice_receive.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmPrice_Receive, 1))
    chkSendPlace.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmSendPlace, 1))
    chkUnStandardPackage.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmUnsizeOrUnstandard, 1))
    chkUnSize.Value = Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmUnsizeOrUnstandard, 1))
    cboPackage.ListIndex = L_PackageTypeArray(L_NewCodeCounter)
    optDestination(Val(Mid(L_ServiceTypeArray(L_NewCodeCounter), 1 + G_ServiceTypeElements.enmDestinationType, 1))).Value = True
    txtDestcode = L_DestcodeArray(L_NewCodeCounter)
    Call txtDestcode_LostFocus
End Sub

'Private Sub L_FillContractsCombo(ctype As Byte)
'    If ctype = 0 Then
'        G_MyQuery = "select * from tblLocalService"
'    Else
'        G_MyQuery = "select * from GLOBALSERVICE"
'    End If
'    If G_MyRst2.State = 1 Then G_MyRst2.Close
'    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
'    If G_MyRst2.RecordCount > 0 Then
'        G_MyRst2.MoveLast
'        G_MyRst2.MoveFirst
'    End If
'    If ctype = 0 Then
'        cboLservice.Clear
'        While Not G_MyRst2.EOF
'            If IsNull(G_MyRst2!F1_tCaption) Then
'                cboLservice.AddItem ""
'            Else
'                cboLservice.AddItem G_MyRst2!F1_tCaption
'                L_contractNumber(cboLservice.NewIndex) = G_MyRst2!F0_tCno
'                L_contractFare(cboLservice.NewIndex) = G_MyRst2!F2_nlFare
'                L_contractDiscount(cboLservice.NewIndex) = G_MyRst2!F3_nlDiscount
'                L_ContractTwoReceipt(cboLservice.NewIndex) = G_MyRst2!F7_ynoTwoReceipt
'                L_ContractBeginDate(cboLservice.NewIndex) = G_MyRst2!F5_tBeginDate
'                L_ContractExpireDate(cboLservice.NewIndex) = G_MyRst2!F6_tExpireDate
'                L_ContractTip(cboLservice.NewIndex) = G_MyRst2!F8_ynoTip
'            End If
'            G_MyRst2.MoveNext
'        Wend
'        G_MyRst2.Close
'        If cboLservice.ListCount > 0 Then
'            cboLservice.ListIndex = 0
'        End If
'    Else
'        cboGService.Clear
'        While Not G_MyRst2.EOF
'            If IsNull(G_MyRst2!F1_tCaption) Then
'                cboGService.AddItem ""
'            Else
'                cboGService.AddItem G_MyRst2!F1_tCaption
'                '' DoubleLable support
'                If G_MyRst2!F3_bDoubleLable Then
'                    cboGService.ItemData(cboGService.NewIndex) = 1
'                Else
'                    cboGService.ItemData(cboGService.NewIndex) = 0
'                End If
'                ''
'                L_GserviceNumber(cboGService.NewIndex) = G_MyRst2!F0_tCno
'                L_GserviceFare(cboGService.NewIndex) = G_MyRst2!F2_nlFare
'            End If
'            G_MyRst2.MoveNext
'        Wend
'        G_MyRst2.Close
'        If cboGService.ListCount > 0 Then
'            cboGService.ListIndex = 0
'        End If
'    End If
'End Sub

Private Sub L_FillContractsCombo(ctype As Byte)
    If ctype = 0 Then
        G_MyQuery = "select * from tblLocalContracts"
    Else
        G_MyQuery = "select * from CONTRACTS"
    End If
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    If G_MyRst2.RecordCount > 0 Then
        G_MyRst2.MoveLast
        G_MyRst2.MoveFirst
    End If
    If ctype = 0 Then
        cboLservice.Clear
        While Not G_MyRst2.EOF
            If IsNull(G_MyRst2!Caption) Then
                cboLservice.AddItem ""
            Else
                cboLservice.AddItem G_MyRst2!Caption
                L_contractNumber(cboLservice.NewIndex) = G_MyRst2!Cno
                L_contractFare(cboLservice.NewIndex) = G_MyRst2!Fare
                'L_contractDiscount(cboLservice.NewIndex) = G_MyRst2!F3_nlDiscount
                'L_ContractTwoReceipt(cboLservice.NewIndex) = G_MyRst2!F7_ynoTwoReceipt
                L_ContractBeginDate(cboLservice.NewIndex) = G_MyRst2!BeginDate
                L_ContractExpireDate(cboLservice.NewIndex) = G_MyRst2!ExpireDate
                'L_ContractTip(cboLservice.NewIndex) = G_MyRst2!F8_ynoTip
            End If
            G_MyRst2.MoveNext
        Wend
        G_MyRst2.Close
        If cboLservice.ListCount > 0 Then
            cboLservice.ListIndex = 0
        End If
    Else
        cboGservice.Clear
        While Not G_MyRst2.EOF
            If IsNull(G_MyRst2!Caption) Then
                cboGservice.AddItem ""
            Else
                cboGservice.AddItem G_MyRst2!Caption
                L_GserviceNumber(cboGservice.NewIndex) = G_MyRst2!Cno
                L_GserviceFare(cboGservice.NewIndex) = G_MyRst2!Fare
            End If
            G_MyRst2.MoveNext
        Wend
        G_MyRst2.Close
        If cboGservice.ListCount > 0 Then
            cboGservice.ListIndex = 0
        End If
    End If
End Sub

' Ê·Ìœ ﬂœ «‰Õ’«—Ì Ê »«—ﬂœ
Private Function L_CreateUniquecode() As Boolean
    Dim i As Integer
    Dim UnsizeOrUnstandard As Integer
   
    If G_IsEMS = 1 And G_BPrinter = "" Then   'preprint
        If Not L_CheckBarcode(txtUniqueCode.Text) Then
            G_ShowMsg " »«—ﬂœ ‰«„⁄ »— «” .", vbOKOnly, G_critical
            L_CreateUniquecode = False
            txtUniqueCode.SetFocus
            Exit Function
        End If
        
        If chkTwoReceipt.Value = 1 Then
            If Not L_CheckBarcode(txtReceiptCode.Text) Then
                G_ShowMsg " »«—ﬂœ ﬁ»÷ œÊ„ ‰«„⁄ »— «” .", vbOKOnly, G_exclamation
                L_CreateUniquecode = False
                txtReceiptCode.SetFocus
                Exit Function
            End If
        End If
    Else
        txtUniqueCode.Text = L_CreateUniquecode20(G_PnCode, txtDestcode.Text, L_RegCounter)
        If chkTwoReceipt.Value = 1 Then
            txtReceiptCode.Text = L_CreateUniquecode20(G_PnCode, txtDestcode, 1 + L_RegCounter)
        End If
    End If
             
    L_UniqueCodeArray(L_NewCodeCounter) = txtUniqueCode
    
    If chkTwoReceipt.Value = 1 Then
        L_TwoReceiptCodeArray(L_NewCodeCounter) = txtReceiptCode
        L_strTwoReceiptBarcodeArray(L_NewCodeCounter) = L_MakeBarcode128c(L_TwoReceiptCodeArray(L_NewCodeCounter))
    Else
        L_TwoReceiptCodeArray(L_NewCodeCounter) = ""
        L_strTwoReceiptBarcodeArray(L_NewCodeCounter) = ""
    End If
    
    If G_IsEMS = 1 Then
        If G_BPrinter = "" And L_ParcelNumber > 1 Then
            txtUniqueCode = ""
            txtReceiptCode = ""
        End If
    
        L_ShippingArray(L_NewCodeCounter) = 1  'ÂÊ«ÌÌ
        '' Unstandard Package
        L_strBarcodeArray(L_NewCodeCounter) = L_MakeBarcode128c(L_UniqueCodeArray(L_NewCodeCounter))
        
        If chkTwoReceipt.Value = 1 Then
            L_TwoReceiptCodeArray(L_NewCodeCounter) = L_TwoReceiptCodeArray(L_NewCodeCounter)
            L_strTwoReceiptBarcodeArray(L_NewCodeCounter) = L_strTwoReceiptBarcodeArray(L_NewCodeCounter)
        Else
            L_TwoReceiptCodeArray(L_NewCodeCounter) = ""
            L_strTwoReceiptBarcodeArray(L_NewCodeCounter) = ""
        End If
                
        If optPay(1).Value Then L_ContractsIndexArray(L_NewCodeCounter) = cboLservice.ListIndex
        If optPay(3).Value Then L_ContractsIndexArray(L_NewCodeCounter) = cboGservice.ListIndex
    Else    '”›«—‘Ì
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmRestant, 1) = CStr(chkRestant.Value)
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmBankParcel, 1) = CStr(chkBankParcel.Value)
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmFragile, 1) = CStr(chkFragile.Value)
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmExpress, 1) = CStr(chkExpress.Value)
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmAmanat_Tejari, 1) = CStr(chkAmanat_Tejari.Value)
        Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmAmanat_Anbooh, 1) = CStr(chkAmanat_Anbooh.Value)
    End If
    
    L_WeightBalance = txtWeight.Text
    L_WeightArray(L_NewCodeCounter) = Val(txtWeight.Text)
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmIsEMS, 1) = CStr(G_IsEMS)
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmParcelForm, 1) = CStr(L_ParcelFormArray(L_NewCodeCounter))
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmDestinationType, 1) = CStr(L_DestTypeArray(L_NewCodeCounter))
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmShippingType, 1) = CStr(L_ShippingArray(L_NewCodeCounter))
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmPayType, 1) = CStr(L_PayTypeArray(L_NewCodeCounter))
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmInsurType, 1) = CStr(L_IranInsuranceArray(L_NewCodeCounter))
    
    ''  Iran Insurance
    
    '' UnStandard Package
    UnsizeOrUnstandard = chkUnSize.Value + chkUnStandardPackage.Value
    If UnsizeOrUnstandard = 2 Then UnsizeOrUnstandard = 1
    
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmTwoReceipt, 1) = CStr(chkTwoReceipt.Value)
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmPrice_Receive, 1) = CStr(chkPrice_receive.Value)
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmSendPlace, 1) = CStr(chkSendPlace.Value)
    Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmUnsizeOrUnstandard, 1) = CStr(UnsizeOrUnstandard)
    
    
    If L_DestTypeArray(L_NewCodeCounter) = 0 Then
        L_DestNameArray(L_NewCodeCounter) = G_CityName
    ElseIf L_DestTypeArray(L_NewCodeCounter) = 1 Then
        L_DestNameArray(L_NewCodeCounter) = cboCity.Text
    Else
        L_DestNameArray(L_NewCodeCounter) = cboCountry.Text
    End If
    
    L_DestcodeArray(L_NewCodeCounter) = txtDestcode
    L_PackageTypeArray(L_NewCodeCounter) = cboPackage.ListIndex
    L_SenderArray(L_NewCodeCounter) = txtSender
    
    
    
    L_ReceiverArray(L_NewCodeCounter) = txtReceiver
    L_ServiceTypeArray(L_NewCodeCounter) = L_ServiceType
    L_WeightArray(L_NewCodeCounter) = Val(L_WeightBalance)
    L_DiscountArray(L_NewCodeCounter) = Val(txtDiscount.Text)
    L_PackageCostArray(L_NewCodeCounter) = Val(txtPackage)
    L_ExpInsurArray(L_NewCodeCounter) = Val(txtExpInsur)
    L_ParcelCodeString = L_ParcelCodeString + ",""" + L_UniqueCodeArray(L_NewCodeCounter) + """"
    L_CreateUniquecode = True
End Function

Function L_CreateUniquecode20(ByVal strPnCode As String, ByVal strDestCode As String, nSerial As Long) As String
    '„Ê·œ ﬂœ «‰Õ’«—Ì 20—ﬁ„Ì
    Dim total, ss As String
    Dim i As Integer
    
    ss = Format(strPnCode, "00000") + Format(strDestCode, "00000") + Format(Str(nSerial), "00000000")
    total = 0
    For i = 1 To 18 Step 2
        total = total + Val(Mid(ss, i, 1)) * 1 + Val(Mid(ss, i + 1, 1)) * 3
    Next i
    total = total Mod 100
    L_CreateUniquecode20 = ss + Format(total, "00")
End Function

Function L_CheckBarcode(strCode As String) As Boolean
    ' ”  «⁄ »«— »«—ﬂœ ﬂœ «‰Õ’«—Ì 10—ﬁ„Ì
    Dim total As String
    Dim i As Integer

    L_CheckBarcode = False
    If Len(strCode) = 10 Then
    
        total = 0
        For i = 1 To 8 Step 2
            total = total + Mid(strCode, i, 1) * 1 + CInt(Mid(strCode, i + 1, 1)) * 3
        Next i
        total = total Mod 100
        i = CInt(Right(strCode, 2))
        L_CheckBarcode = (total = i)
    Else
    
    End If
End Function

Function L_Permition() As Boolean 'ﬂ‰ —· «ÿ·«⁄«  Ê «⁄ »«—'
    L_Permition = True
    If G_IsEMS = 1 Then     'EMS
        If optDestination(2).Value = True Then
            G_MyQuery = "Select * from COUNTRY where countrycode=" & (txtDestcode.Text) & " and groupems>'0'"
            If G_MyRst2.State = 1 Then G_MyRst2.Close
            G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
            If G_MyRst2.RecordCount = 0 Then
                Call G_ShowMsg(" ﬂ‘Ê— „Ê—œ ‰Ÿ— œ— ê—ÊÂ ÅÌ‘ «“ ﬁ—«— ‰œ«—œ.", vbOKOnly, G_exclamation)
                L_Permition = False
                Exit Function
            End If
        End If
        
        If optPay(1).Value Then
            If cboLservice.ListIndex = -1 Then
                Call G_ShowMsg("ﬁ—«—œ«œÌ  ⁄—Ì› ‰‘œÂ «” .", vbOKOnly, G_exclamation)
                L_Permition = False
                Exit Function
            End If
                
            If Trim(L_ContractBeginDate(cboLservice.ListIndex)) <> "" Then
                If CDate(G_Miladi(G_CurrentDate)) < CDate(G_Miladi(L_ContractBeginDate(cboLservice.ListIndex))) Then
                    Call G_ShowMsg("  «—ÌŒ ‘—Ê⁄ ﬁ—«—œ«œ ¬€«“ ‰‘œÂ «” .", vbOKOnly, G_exclamation)
                    L_Permition = False
                    Exit Function
                End If
            End If
            
            If Trim(L_ContractExpireDate(cboLservice.ListIndex)) <> "" Then
                If CDate(G_Miladi(G_CurrentDate)) > CDate(G_Miladi(L_ContractExpireDate(cboLservice.ListIndex))) Then
                    Call G_ShowMsg("  «—ÌŒ ﬁ—«—œ«œ ”Å—Ì ‘œÂ «” .", vbOKOnly, G_exclamation)
                    L_Permition = False
                    Exit Function
                End If
            End If
        End If
        
        '*********ﬂ‰ —· „»·€ «ŸÂ«— ‘œÂ
'' Iran Insurance
        If Val(txtExpInsur.Text) > 50000000 Then
            G_ShowMsg "Õœ«ﬂÀ— „»·€ «ŸÂ«— ‘œÂ 50,000,000 —Ì«· „Ìù Ê«‰œ »«‘œ", vbOKOnly, G_exclamation
            txtExpInsur.SetFocus
            L_Permition = False
            Exit Function
        End If
        
        '******* ﬂ‰ —· Ê“‰
        If optParcelType(0).Value = True And Val(txtWeight.Text) > 2000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ ‰«„Â „Ì»«Ì”  2000 ê—„ »«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        ElseIf Val(txtWeight.Text) > 30000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ »” Â „Ì»«Ì”  30000 ê—„ »«‘œ", vbOKOnly, G_exclamation
        End If
        
        If Val(txtWeight.Text) <= 0 Then
            G_ShowMsg "Ê“‰ „—”Ê·Â ‰»«Ìœ ’›— Ê Ì« ﬂ„ — »«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        End If
        '****************************************
        '****************************************
        '****************************************
        
    Else   '”›«—‘Ì
        '*********ﬂ‰ —· „»·€ «ŸÂ«— ‘œÂ
        '' Iran Insurance
        If Val(txtExpInsur.Text) > 50000000 Then
            G_ShowMsg "Õœ«ﬂÀ— „»·€ «ŸÂ«— ‘œÂ 50,000,000 —Ì«· „Ìù Ê«‰œ »«‘œ", vbOKOnly, G_exclamation
            txtExpInsur.SetFocus
            L_Permition = False
            Exit Function
        End If
                
        '******* ﬂ‰ —· Ê“‰
        If Val(txtWeight.Text) <= 0 Then
            G_ShowMsg "Ê“‰ „—”Ê·Â ‰„Ìù»«Ì”  ’›— Ê Ì« ﬂ„ — »«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        End If
        
        If cboParcelType.ListIndex = 2 And Val(txtWeight.Text) > 30000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ „—”Ê·«  ﬂÌ”Â „Œ’Ê’  30000 ê—„ „Ìù»«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        ElseIf cboParcelType.ListIndex = 4 And Val(txtWeight.Text) > 5000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ „ÿ»Ê⁄«  Ê ﬂ «» 5000 ê—„ „Ìù»«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        ElseIf cboParcelType.ListIndex = 3 And Val(txtWeight.Text) > 30000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ „—”Ê·«  «„«‰   30000 ê—„ „Ìù»«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        ElseIf cboParcelType.ListIndex <> 2 And cboParcelType.ListIndex <> 3 And cboParcelType.ListIndex <> 4 And Val(txtWeight.Text) > 2000 Then
            G_ShowMsg "Õœ«ﬂÀ— Ê“‰ „Ì»«Ì”  2000 ê—„ »«‘œ", vbOKOnly, G_exclamation
            txtWeight.SetFocus
            L_Permition = False
            Exit Function
        End If
    End If
End Function

Sub L_SendBarcode(ByVal P_ucode As String, ByVal P_barcode As String, ByVal P_weight As String, P_tarikh As String, P_time As String, P_kerayeh As String, P_MarkForTwoReceipt As Boolean)
    Dim t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24 As String
    Dim temp As String
    
    If mscommBprinter.PortOpen = True Then mscommBprinter.PortOpen = False
    If G_BPrinterPort = "com1" Then
        mscommBprinter.CommPort = 1
    Else
        mscommBprinter.CommPort = 2
    End If
    
    mscommBprinter.Handshaking = comNone
    mscommBprinter.Settings = "9600,N,8,1"
    mscommBprinter.PortOpen = True
    
    t0 = Chr(13)
    t1 = Chr(10)
    
    If G_BPrinter = "Eltron TLP2642/2742" Then
    'Tlp2742
        t2 = "N"
        t3 = "q440"
        t4 = "X20,4,3,410,375"
        t5 = "GG85,20," + Chr(34) + "EMS" + Chr(34)
        t6 = "GG178,60," + Chr(34) + "PIC27" + Chr(34)
        t7 = "LO20,115,390,3"
        t8 = "LO20,181,390,3"
        t9 = "LO20,250,390,3"
        t10 = "LO220,120,3,133"
        t11 = "A25,200,0,b,1,1,N," + Chr(34) + "≈C‚j" + Chr(34)
        t12 = "A161,200,0,b,1,1,N," + Chr(34) + "ÿ‚Bk¿" + Chr(34)
        t13 = "A228,200,0,b,1,1,N," + Chr(34) + "…kƒ" + Chr(34)
        t14 = "A360,200,0,b,1,1,N," + Chr(34) + "Õl”" + Chr(34)
        t15 = "A100,60,0,b,1,1,N," + Chr(34) + "ﬂk·√⁄j g¿" + Chr(34)
        t16 = "A52,145,0,a,1,1,N," + Chr(34) + P_tarikh + Chr(34) '  «—ÌŒ
        
        '“œ‰ ⁄·«„  »—«Ì œÊﬁ»÷Â Â«
        If P_MarkForTwoReceipt Then
            t24 = "A385,30,0,3,1,1,N," + Chr(34) + "*" + Chr(34)     '
        Else
            t24 = ""
        End If
        t17 = "A276,145,0,a,1,1,N," + Chr(34) + P_time + Chr(34) '”«⁄ 
        t18 = "A76,200,0,a,1,1,N," + Chr(34) + P_kerayeh + Chr(34) '  ﬂ—«ÌÂ
        t19 = "A284,200,0,a,1,1,N," + Chr(34) + P_weight + Chr(34)    'Ê“‰
        t20 = "A30,60,0,a,1,1,N," + Chr(34) + G_PnCode + Chr(34)    'ﬂœ —ÂêÌ—Ì
        t21 = "B60,257,0,1,2,3,80,N," + Chr(34) + P_ucode + Chr(34)
        t22 = "A70,340,0,a,1,1,N," + Chr(34) + P_ucode + Chr(34)   '⁄œœ »«—ﬂœ
        t23 = "P1"
        'Temp = Space(mscommBprinter.OutBufferSize)
        temp = t0 + t1 + t2 + t0 + t1 + t3 + t0 + t1 + t4 + t0 + t1 + t5 + t0 + t1 + t6 + t0 + t1 + t7 + t0 + t1 + t8 + t0 + t1 + t9 + t0 + t1 + t10 + t0 + t1 + t11 + t0 + t1 + t12 + t0 + t1 + t13 + t0 + t1 + t14 + t0 + t1 + t15 + t0 + t1 + t16 + t0 + t1 + t17 + t0 + t1 + t0 + t1 + t24 + t0 + t1 + t18 + t0 + t1 + t19 + t0 + t1 + t20 + t0 + t1 + t21 + t0 + t1 + t22 + t0 + t1 + t23 + t0 + t1
    ElseIf G_BPrinter = "Eltron TLP3642/3742" Then
        'Tlp3742
        t2 = "N"
        t3 = "q630"
        t4 = "X15,20,5,580,565"
        t5 = "GG85,46," + Chr(34) + "EMS" + Chr(34)
        t6 = "GG220,110," + Chr(34) + "PIC37" + Chr(34)
        t7 = "LO15,200,565,5"
        t8 = "LO15,280,565,5"
        t9 = "LO15,360,565,5"
        t10 = "LO320,200,3,162"
        t11 = "A22,300,0,b,1,1,N," + Chr(34) + "≈C‚j" + Chr(34)
        t12 = "A240,300,0,b,1,1,N," + Chr(34) + "ÿ‚Bk¿" + Chr(34)
        t13 = "A340,300,0,b,1,1,N," + Chr(34) + "…kƒ" + Chr(34)
        t14 = "A510,300,0,b,1,1,N," + Chr(34) + "Õl”" + Chr(34)
        t15 = "A140,105,0,b,1,1,N," + Chr(34) + "ﬂk·√⁄j g¿" + Chr(34)
        t16 = "A88,220,0,a,1,1,N," + Chr(34) + P_tarikh + Chr(34) '  «—ÌŒ
        '“œ‰ ⁄·«„  »—«Ì œÊﬁ»÷Â Â«
        If P_MarkForTwoReceipt Then
            t24 = "A550,30,0,3,1,1,N," + Chr(34) + "*" + Chr(34)     '
        Else
            t24 = ""
        End If
        t17 = "A400,220,0,a,1,1,N," + Chr(34) + P_time + Chr(34) '”«⁄ 
        t18 = "A124,300,0,a,1,1,N," + Chr(34) + P_kerayeh + Chr(34) '  ﬂ—«ÌÂ
        t19 = "A422,300,0,a,1,1,N," + Chr(34) + P_weight + Chr(34)    'Ê“‰
        t20 = "A30,105,0,a,1,1,N," + Chr(34) + G_PnCode + Chr(34)    'ﬂœ —ÂêÌ—Ì
        t21 = "B75,380,0,1,3,5,120,N," + Chr(34) + P_ucode + Chr(34)
        t22 = "A135,505,0,a,1,1,N," + Chr(34) + P_ucode + Chr(34)   '⁄œœ »«—ﬂœ
        t23 = "P1"
        'temp = t0 + t1 + t2 + t0 + t1 + t3 + t0 + t1 + t4 + t0 + t1 + t5 + t0 + t1 + t6 + t0 + t1 + t7 + t0 + t1 + t8 + t0 + t1 + t9 + t0 + t1 + t10 + t0 + t1 + t11 + t0 + t1 + t12 + t0 + t1 + t13 + t0 + t1 + t14 + t0 + t1 + t15 + t0 + t1 + t16 + t0 + t1 + t17 + t0 + t1 + t18 + t0 + t1 + t19 + t0 + t1 + t20 + t0 + t1 + t21 + t0 + t1 + t22 + t0 + t1 + t23 + t0 + t1
        temp = t0 + t1 + t2 + t0 + t1 + t3 + t0 + t1 + t4 + t0 + t1 + t5 + t0 + t1 + t6 + t0 + t1 + t7 + t0 + t1 + t8 + t0 + t1 + t9 + t0 + t1 + t10 + t0 + t1 + t11 + t0 + t1 + t12 + t0 + t1 + t13 + t0 + t1 + t14 + t0 + t1 + t15 + t0 + t1 + t16 + t0 + t1 + t17 + t0 + t1 + t18 + t0 + t1 + t19 + t0 + t1 + t20 + t0 + t1 + t21 + t0 + t1 + t22 + t0 + t1 + t24 + t0 + t1 + t0 + t1 + t23 + t0 + t1
    End If
    mscommBprinter.Output = temp
    If Err Then
        MsgBox Error$, 48
        Exit Sub
    End If
    Sleep (1500)
    If mscommBprinter.PortOpen = True Then mscommBprinter.PortOpen = False
End Sub

Sub L_SendNaghsh(ByVal P_weight As String, P_tarikh As String, P_time As String, P_kerayeh As String)
    Dim t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23 As String
    Dim temp As String
    
    
    If mscommBprinter.PortOpen = True Then mscommBprinter.PortOpen = False
    If G_BPrinterPort = "com1" Then
        mscommBprinter.CommPort = 1
    Else
        mscommBprinter.CommPort = 2
    End If
    'If mscommBprinter.PortOpen = True Then mscommBprinter.PortOpen = False
    mscommBprinter.Handshaking = comNone
    mscommBprinter.Settings = "9600,N,8,1"
    mscommBprinter.PortOpen = True
    
    t0 = Chr(13)
    t1 = Chr(10)
    
    If G_BPrinter = "Eltron TLP2642/2742" Then
    'Tlp2742
        t2 = "N"
        t3 = "q440"
        t4 = "X20,4,3,410,375"
        t5 = "GG85,20," + Chr(34) + "NAGHSH" + Chr(34)
        t6 = "GG178,200," + Chr(34) + "PIC27" + Chr(34)
        t7 = "LO20,270,390,3"
        t8 = "LO20,320,390,3"
        t9 = "LO220,270,3,50"
        t10 = "A50,335,0,b,1,1,N," + Chr(34) + "…kƒ" + Chr(34)
        t11 = "A300,335,0,b,1,1,N," + Chr(34) + "Õl”" + Chr(34)
        t12 = "A100,200,0,b,1,1,N," + Chr(34) + "ﬂk·√⁄j g¿" + Chr(34)
        t13 = "A52,280,0,a,1,1,N," + Chr(34) + P_tarikh + Chr(34) '  «—ÌŒ
        t14 = "A276,280,0,a,1,1,N," + Chr(34) + P_time + Chr(34) '”«⁄ 
        t15 = "A176,100,0,a,1,1,N," + Chr(34) + P_kerayeh + Chr(34) '  ﬂ—«ÌÂ
        t16 = "A176,335,0,a,1,1,N," + Chr(34) + P_weight + Chr(34)    'Ê“‰
        t17 = "A30,200,0,a,1,1,N," + Chr(34) + G_PnCode + Chr(34)    'ﬂœ —ÂêÌ—Ì
        t18 = "P1"
        temp = t0 + t1 + t2 + t0 + t1 + t3 + t0 + t1 + t4 + t0 + t1 + t5 + t0 + t1 + t6 + t0 + t1 + t7 + t0 + t1 + t8 + t0 + t1 + t9 + t0 + t1 + t10 + t0 + t1 + t11 + t0 + t1 + t12 + t0 + t1 + t13 + t0 + t1 + t14 + t0 + t1 + t15 + t0 + t1 + t16 + t0 + t1 + t17 + t0 + t1 + t18 + t0 + t1
    ElseIf G_BPrinter = "Eltron TLP3642/3742" Then
        'Tlp3742
        t2 = "N"
        t3 = "q630"
        t4 = "X15,15,5,580,550"
        t5 = "GG110,35," + Chr(34) + "NAGHSH37" + Chr(34)
        t6 = "GG230,300," + Chr(34) + "PIC37" + Chr(34)
        't6 = ""
        t7 = "LO20,400,550,5"
        t8 = "LO20,470,550,5"
        t9 = "LO300,400,5,70"
        t10 = "A50,485,0,b,1,1,N," + Chr(34) + "…kƒ" + Chr(34)
        t11 = "A400,485,0,b,1,1,N," + Chr(34) + "Õl”" + Chr(34)
        t12 = "A130,300,0,b,1,1,N," + Chr(34) + "ﬂk·√⁄j g¿" + Chr(34)
        t13 = "A52,420,0,a,1,1,N," + Chr(34) + P_tarikh + Chr(34) '  «—ÌŒ
        t14 = "A350,420,0,a,1,1,N," + Chr(34) + P_time + Chr(34) '”«⁄ 
        t15 = "A230,150,0,a,1,1,N," + Chr(34) + P_kerayeh + Chr(34) '  ﬂ—«ÌÂ
        t16 = "A176,485,0,a,1,1,N," + Chr(34) + P_weight + Chr(34)    'Ê“‰
        t17 = "A30,300,0,a,1,1,N," + Chr(34) + G_PnCode + Chr(34)    'ﬂœ —ÂêÌ—Ì
        t18 = "P1"
        temp = t0 + t1 + t2 + t0 + t1 + t3 + t0 + t1 + t4 + t0 + t1 + t5 + t0 + t1 + t6 + t0 + t1 + t7 + t0 + t1 + t8 + t0 + t1 + t9 + t0 + t1 + t10 + t0 + t1 + t11 + t0 + t1 + t12 + t0 + t1 + t13 + t0 + t1 + t14 + t0 + t1 + t15 + t0 + t1 + t16 + t0 + t1 + t17 + t0 + t1 + t18 + t0 + t1
    
    End If
    mscommBprinter.Output = temp

    If Err Then
        MsgBox Error$, 48
        Exit Sub
    End If
    Sleep (1500)
    If mscommBprinter.PortOpen = True Then mscommBprinter.PortOpen = False
End Sub

'ç«Å ”Ê‘ Ê »—ç”»
Sub L_PrintJob()
    On Error GoTo Err_label
    
    Dim i, j, k As Long
    Dim str1 As String
    Dim strExpText As String
    
    If L_ParcelNumber = 1 Then
        If G_IsEMS = 1 Then 'EMS
            Screen.MousePointer = vbHourglass
            L_Sosh1Report.Database.Tables(1).Location = G_MyDb
            L_Sosh1Report.Database.Tables(1).SetLogOnInfo G_ConnStr
            L_Sosh1Report.DiscardSavedData
            L_Sosh1Report.RecordSelectionFormula = "{ado.Uniquecode}=""" + L_UniqueCodeArray(0) + """"
            L_Sosh1Report.ReadRecords
            
            L_Sosh1Report.txtCityName.SetText G_CityName
            L_Sosh1Report.txtCityName2.SetText G_CityName
            L_Sosh1Report.txtPnname.SetText G_PnName
            L_Sosh1Report.txtPnName2.SetText G_PnName
            L_Sosh1Report.txtArzesh.SetText txtExpInsur.Text
            L_Sosh1Report.txtArzesh2.SetText txtExpInsur.Text
            If Val(txtExpInsur) > 0 Then
                strExpText = G_NumToText(Val(txtExpInsur.Text))
                L_Sosh1Report.txtExpText.SetText strExpText
                L_Sosh1Report.txtExpText2.SetText strExpText
            Else
                L_Sosh1Report.txtExpText.SetText ""
                L_Sosh1Report.txtExpText2.SetText ""
            End If
            
            L_Sosh1Report.txtNote.SetText ""
            L_Sosh1Report.txtNote2.SetText ""
            
            If optPay(1).Value Then
                L_Sosh1Report.txtNote.SetText "ﬁ—«—œ«œ œ«Œ·Ì: " + cboLservice.Text
                L_Sosh1Report.txtNote2.SetText "ﬁ—«—œ«œ œ«Œ·Ì: " + cboLservice.Text
            ElseIf optPay(3).Value Then
                L_Sosh1Report.txtNote.SetText "ﬁ—«—œ«œ ”—«”—Ì: " + cboGservice.Text
                L_Sosh1Report.txtNote2.SetText "ﬁ—«—œ«œ ”—«”—Ì: " + cboGservice.Text
            End If
                        
            Sleep (1500)
            L_Sosh1Report.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_Sosh1Report.PrintOut False      '⁄œ„ —ÊÌ  Å‰Ã—Â ç«Å
            If G_BPrinter <> "" Then
                Call L_SendBarcode(L_UniqueCodeArray(0), L_strBarcodeArray(0), L_WeightBalance, G_CurrentDate, L_CurrentTime, Str(lblTotalPrice), False)
                If chkTwoReceipt.Value = 1 Then   ' œÊﬁ»÷Â
                    Sleep (1500)
                    Call L_SendBarcode(L_TwoReceiptCodeArray(0), L_strTwoReceiptBarcodeArray(0), L_WeightBalance, G_CurrentDate, L_CurrentTime, Str(lblTotalPrice), True)
                End If
                                
                'If (optPay(3).Value And cboGService.ItemData(cboGService.ListIndex) = 1) Then
                If (optPay(3).Value) Then
                    Sleep (1500)
                    Call L_SendBarcode(L_UniqueCodeArray(0), L_strBarcodeArray(0), L_WeightBalance, G_CurrentDate, L_CurrentTime, Str(lblTotalPrice), False)
                End If
            End If
        Else ' ”›«—‘Ì
            str1 = ""
            If chkTwoReceipt.Value = 1 Then str1 = str1 + "° œÊﬁ»÷Â"
            If chkExpress.Value = 1 Then str1 = str1 + "° «ﬂ”Å—”"
            If chkRestant.Value = 1 Then str1 = str1 + "° —” «‰ "
            If chkFragile.Value = 1 Then str1 = str1 + "° ‘ﬂ” ‰Ì"
            If chkBankParcel.Value = 1 Then str1 = str1 + "° „—”Ê·Â »«‰ﬂÌ"
            If chkAmanat_Tejari.Value = 1 Then str1 = str1 + "° «„«‰   Ã«—Ì"
            If chkAmanat_Anbooh.Value = 1 Then str1 = str1 + "° «„«‰  «‰»ÊÂ"
            If optPay(2).Value = True Then str1 = str1 + "° ﬂ—«ÌÂ œ— „ﬁ’œ"
            
            L_Sosh2Report.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_Sosh2Report.PaperOrientation = crLandscape
            L_Sosh2Report.Database.Tables(1).Location = G_MyDb
            L_Sosh2Report.Database.Tables(1).SetLogOnInfo G_ConnStr
            L_Sosh2Report.DiscardSavedData
            L_Sosh2Report.RecordSelectionFormula = "{ado.Uniquecode}=""" + L_UniqueCodeArray(0) + """"
            L_Sosh2Report.ReadRecords
            L_Sosh2Report.txtEzhar.SetText txtExpInsur.Text
            L_Sosh2Report.txtEzhar2.SetText txtExpInsur.Text
            If Val(txtExpInsur) > 0 Then
                strExpText = G_NumToText(Val(txtExpInsur.Text))
                L_Sosh2Report.txtExpText.SetText strExpText
                L_Sosh2Report.txtExpText2.SetText strExpText
            Else
                L_Sosh2Report.txtExpText.SetText ""
                L_Sosh2Report.txtExpText2.SetText ""
            End If
            L_Sosh2Report.txtAttribute.SetText str1
            L_Sosh2Report.txtAttribute2.SetText str1
            L_Sosh2Report.txtMarsoleh.SetText cboParcelType
            L_Sosh2Report.txtMarsoleh2.SetText cboParcelType
            L_Sosh2Report.txtCityName.SetText G_CityName
            L_Sosh2Report.txtCityName2.SetText G_CityName
            L_Sosh2Report.txtPnname.SetText G_PnName
            L_Sosh2Report.txtPnName2.SetText G_PnName
            L_Sosh2Report.PrintOut False
            
            If G_BPrinter <> "" Then
                ' œÊﬁ»÷Â
                Call L_SendNaghsh(L_WeightBalance, G_CurrentDate, L_CurrentTime, lblTotalPrice)
                If chkTwoReceipt.Value = 1 Then
                    'Sleep (1500)
                    Call L_SendNaghsh(L_WeightBalance, G_CurrentDate, L_CurrentTime, lblTotalPrice)
                End If
            End If
        End If
    Else           '«‰»ÊÂ
        If G_IsEMS = 1 Then
            Sleep (1500)
            L_Sosh3Report.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_Sosh3Report.Database.Tables(1).Location = G_MyDb
            L_Sosh3Report.Database.Tables(1).SetLogOnInfo G_ConnStr
            L_Sosh3Report.DiscardSavedData
            L_ParcelCodeString = Mid(L_ParcelCodeString, 2)
            L_Sosh3Report.RecordSelectionFormula = "{ado.Uniquecode} in [" + L_ParcelCodeString + "]"
            'L_Sosh3Report.ReadRecords
            L_Sosh3Report.txtKarbar.SetText (G_UserPname)
            L_Sosh3Report.txtPrintDate.SetText (G_CurrentDate)
                        
            If (G_SoshSort = 1) Then
                L_Sosh3Report.FormulaFields(3).Text = "{ado.ReceiptDate}+{ado.ReceiptTime}"
            Else
                L_Sosh3Report.FormulaFields(3).Text = "Mid ({ado.Uniquecode},11 ,8 )"
                'L_Sosh3Report.FormulaFields(3).Text = "{ado.Uniquecode}"
            End If
            
            L_Sosh3Report.ReadRecords
            L_Sosh3Report.PrintOut False, 2         '⁄œ„ —ÊÌ  Å‰Ã—Â ç«Å
            Screen.MousePointer = vbHourglass
        Else
            Sleep (1500)
            L_Sosh4Report.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_Sosh4Report.Database.Tables(1).Location = G_MyDb
            L_Sosh4Report.Database.Tables(1).SetLogOnInfo G_ConnStr
            L_Sosh4Report.DiscardSavedData
            L_ParcelCodeString = Mid(L_ParcelCodeString, 2)
            L_Sosh4Report.RecordSelectionFormula = "{ado.Uniquecode} in [" + L_ParcelCodeString + "]"
            L_Sosh4Report.ReadRecords
            L_Sosh4Report.txtPnname.SetText G_PnName
            L_Sosh4Report.txtKarbar.SetText (G_UserPname)
            L_Sosh4Report.txtPrintDate.SetText (G_CurrentDate)
            L_Sosh4Report.PrintOut , 2          'ç«Å 2 ‰”ŒÂ ”Ê‘ «‰»ÊÂ
            'L_Sosh4Report.PrintOut False, 2        '⁄œ„ —ÊÌ  Å‰Ã—Â ç«Å
            Screen.MousePointer = vbHourglass
        End If
        If G_BPrinter <> "" Then
            For i = 1 To L_ParcelNumber
                If G_IsEMS = 0 Then
                    If (i Mod 40) = 0 Then
                        '»Â «“«Ì Â— 40  « „—”Ê·Â Ìﬂ  «ŒÌ—
                        Sleep (5000)   ' «ŒÌ— 4.5 À«‰ÌÂ
                    Else
                        Sleep (2500)   ' «ŒÌ— 1.5 À«‰ÌÂ
                    End If
                    Call L_SendNaghsh(L_WeightArray(i - 1), G_CurrentDate, L_CurrentTime, Str(L_TotalPriceArray(i - 1)))
                    If Mid(L_ServiceTypeArray(i - 1), 1 + G_ServiceTypeElements.enmTwoReceipt, 1) = 1 Then 'œÊﬁ»÷Â
                   
                        Sleep (2500)   ' «ŒÌ— 2.5 À«‰ÌÂ
                        Call L_SendNaghsh(L_WeightArray(i - 1), G_CurrentDate, L_CurrentTime, Str(L_TotalPriceArray(i - 1)))
                    End If
                Else
                    If (i Mod 40) = 0 Then
                        '»Â «“«Ì Â— 40  « „—”Ê·Â Ìﬂ  «ŒÌ—
                        Sleep (5000)   ' «ŒÌ— 5 À«‰ÌÂ
                    Else
                        Sleep (2000)   ' «ŒÌ— 2 À«‰ÌÂ
                    End If
                    Call L_SendBarcode(L_UniqueCodeArray(i - 1), L_strBarcodeArray(i - 1), L_WeightArray(i - 1), G_CurrentDate, L_CurrentTime, Str(L_TotalPriceArray(i - 1)), False)
                    If Mid(L_ServiceTypeArray(i - 1), 1 + G_ServiceTypeElements.enmTwoReceipt, 1) = 1 Then 'œÊﬁ»÷Â
                        Sleep (2000)   ' «ŒÌ— 2 À«‰ÌÂ
                        Call L_SendBarcode(L_TwoReceiptCodeArray(i - 1), L_strTwoReceiptBarcodeArray(i - 1), L_WeightArray(i - 1), G_CurrentDate, L_CurrentTime, Str(L_TotalPriceArray(i - 1)), True)
                    End If
                End If
            Next
        End If
    End If
    Exit Sub
Err_label:
    Call G_ShowMsg("Œÿ« œ— ç«Å:" + Err.Description, vbOKOnly, G_critical)
    'Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
    Screen.MousePointer = vbDefault
End Sub

Function L_MakeBarcode128c(M_CODE)
    Dim rowbarcode As String
    Dim pack2 As Integer
    Dim i, j, intpack2, barcode_weight, check As Integer
    If (Len(M_CODE) Mod 2) <> 0 Then
      G_ShowMsg ("ÿÊ· »«—ﬂœ „⁄ »— ‰Ì” ."), vbOKOnly, G_exclamation
      Exit Function
    End If
    rowbarcode = ""
    barcode_weight = 1
    check = 0
    
    For i = 1 To (Len(M_CODE) / 2)
      pack2 = CInt(Mid(M_CODE, 1 + (i - 1) * 2, 2))
      If pack2 < 95 Then
         intpack2 = pack2 + 32
      Else
        intpack2 = pack2 + 100
      End If
      rowbarcode = rowbarcode + Chr(intpack2)
      check = check + (barcode_weight * pack2)
      barcode_weight = barcode_weight + 1
    Next
    check = ((check + 105) Mod 103)
    
    If check < 95 Then
       check = check + 32
    Else
       check = check + 100
    End If
    L_MakeBarcode128c = rowbarcode + Chr(check)
End Function

Private Function L_CalculateCost()
    Dim mctCostValue As New MoraseleCost
    Dim strSQL As String
    Dim adoRst As ADODB.Recordset
    
    Dim k As Byte
        
    
'<hadi date=87/3/7>
    mctCostValue.ParcelIndex = L_NewCodeCounter
    '</hadi>
    
    If G_IsEMS = 1 Then
        If optPay(1).Value Then
            If cboLservice.ListIndex = -1 Then
                Call G_ShowMsg("ﬁ—«—œ«œÌ  ⁄—Ì› ‰‘œÂ «” .", vbOKOnly, G_exclamation)
                L_CalculateCost = True
                Exit Function
            ElseIf L_contractFare(cboLservice.ListIndex) <> 0 Then
                lblTotalPrice = Str(Val(lblParcelFare) + Val(lblInsur) + Val(txtPackage) + Val(lblUnsize) + Val(lblUnstandardPackage) - Val(txtDiscount))
                lblTotaltxt = "(" + G_NumToText(Round(Val(lblTotalPrice) / 10)) + " Ê„«‰)"
                L_CalculateCost = False
                'Exit Function
            End If
        End If
        
        If optPay(3).Value Then
            lblTotalPrice = Str(Val(lblParcelFare) + Val(lblInsur) + Val(txtPackage) + Val(lblUnsize) + Val(lblUnstandardPackage) - Val(txtDiscount))
            lblTotaltxt = "(" + G_NumToText(Round(Val(lblTotalPrice) / 10)) + " Ê„«‰)"
            L_CalculateCost = False
            'Exit Function
        End If
        
        
        If optDestination(2).Value = True Then
            Set adoRst = New ADODB.Recordset
            'strSQL = "SELECT * From COUNTRY WHERE CountryName = '" & cboCountry.Text & "'"
            strSQL = "SELECT * From COUNTRY WHERE CountryCode = " & cboCountry.ItemData(cboCountry.ListIndex)
            adoRst.Open strSQL, G_AdoConn, adOpenStatic, adLockOptimistic
            If adoRst.RecordCount > 0 Then
                adoRst.MoveFirst
                mctCostValue.CountryGroup = adoRst("GroupNormal")
                mctCostValue.EMSCountryGroup = adoRst("GroupEMS")
                mctCostValue.ConsigneeCountryGroup = adoRst("GroupConsignee")
                mctCostValue.DestinationCountryName = cboCountry.Text
            End If
            adoRst.Close
            Set adoRst = Nothing
        End If
        If optDestination(1).Value = True Then
            Set adoRst = New ADODB.Recordset
            'strSQL = "SELECT * FROM qryCityProvince WHERE CityName = '" & cboCity.Text & "'"
            strSQL = "SELECT * FROM qryCityProvince WHERE CityCode = " & cboCity.ItemData(cboCity.ListIndex)
            adoRst.Open strSQL, G_AdoConn, adOpenStatic, adLockOptimistic
            If adoRst.RecordCount > 0 Then
                adoRst.MoveFirst
                mctCostValue.DestinationCityName = cboCity.Text
                mctCostValue.DestinationProvinceName = adoRst("provinceName")
            End If
            adoRst.Close
            Set adoRst = Nothing
        Else
            mctCostValue.DestinationCityName = G_CityName
            mctCostValue.DestinationProvinceName = G_ProvinceName
        End If
        mctCostValue.CustomerStampPrice = Val(txtDiscount.Text) * (-1)
        mctCostValue.IsRegistered = False
        mctCostValue.IsEMSType = True
        mctCostValue.IsExpress = False
        If chkTwoReceipt.Value = 1 Then
            mctCostValue.Is2Receipt = True
        Else
            mctCostValue.Is2Receipt = False
        End If
        mctCostValue.IsRestant = False
        If chkUnSize.Value = 1 Then
            mctCostValue.ISOutOfSize = True
        Else
            mctCostValue.ISOutOfSize = False
        End If

        '' OutOfStandardPackage
        If chkUnStandardPackage.Value = 1 Then
            mctCostValue.ISOutOfStandardPackage = True
        Else
            mctCostValue.ISOutOfStandardPackage = False
        End If
        '' OutOfStandardPackage
        
        mctCostValue.IsMayeOrBreak = False
        If chkBankParcel.Value = 1 Then
            mctCostValue.IsBankAndMoney = True
        Else
            mctCostValue.IsBankAndMoney = False
        End If
        
        If chkAmanat_Tejari.Value = 1 Then
            mctCostValue.Amanat_Tejari = True
        Else
            mctCostValue.Amanat_Tejari = False
        End If
        If chkAmanat_Anbooh.Value = 1 Then
            mctCostValue.Amanat_Anbooh = True
        Else
            mctCostValue.Amanat_Anbooh = False
        End If
        
        If chkSendPlace.Value = 1 Then  'Õﬁ „ﬁ—
            mctCostValue.IsSendPlace = True
        Else
            mctCostValue.IsSendPlace = False
        End If
        If optPay(2).Value = True Then
            mctCostValue.IsFareInDest = True
        Else
            mctCostValue.IsFareInDest = False
        End If
            
        mctCostValue.ToldValue = Val(txtExpInsur.Text)
        If optDestination(2).Value = True Then
            'If cboIranInsurType.Visible And cboIranInsurType.Text = "ÊÃÂ ‰ﬁœ° «”‰«œ Ê „—”Ê·«  »«‰ﬂÌ" Then
            If cboIranInsurType.Visible Then
                mctCostValue.HasForeignInsurance = True
            Else
               mctCostValue.HasForeignInsurance = False
            End If
            mctCostValue.HasUnknownValuePackIranInsurance = False
            mctCostValue.HasUnknownValueEnvelopeIranInsurance = False
            mctCostValue.HasKnownValueCashIranInsurance = False
            mctCostValue.HasKnownValueOthersIranInsurance = False
        ElseIf Trim(txtExpInsur.Text) = "" Then
            If optParcelType(0).Value = True Then
                If optPay(1).Value <> True Then
                    mctCostValue.HasUnknownValueEnvelopeIranInsurance = True
                End If
                mctCostValue.HasUnknownValuePackIranInsurance = False
            Else
                mctCostValue.HasUnknownValueEnvelopeIranInsurance = False
                 If optPay(1).Value <> True Then
                    mctCostValue.HasUnknownValuePackIranInsurance = True
                End If
            End If
        ElseIf IsNumeric(Trim(txtExpInsur.Text)) Then
            Select Case cboIranInsurType.Text
                Case "ÊÃÂ ‰ﬁœ° «”‰«œ Ê „—”Ê·«  »«‰ﬂÌ"
                    mctCostValue.HasKnownValueCashIranInsurance = True
                Case "”«Ì—"
                    mctCostValue.HasKnownValueOthersIranInsurance = True
            End Select
        End If
        ''  Iran Insurance
        
        mctCostValue.OtherPrice = 0
        If Not IsNumeric(txtPackage.Text) Then
            txtPackage.Text = "0"
        End If
        mctCostValue.PackingPrice = txtPackage.Text
        
        If Not IsNumeric(txtDiscount.Text) Then
            txtDiscount.Text = "0"
        End If
        mctCostValue.CustomerStampPrice = (-1) * txtDiscount.Text
        
        
        If IsNumeric(txtSoshNumber.Text) Then
            mctCostValue.ParcelCount = txtSoshNumber.Text
        Else
            mctCostValue.ParcelCount = 1
        End If
                
        mctCostValue.Amanat_Anbooh = chkAmanat_Anbooh.Value
        
        If optParcelType(0).Value = True Then
            mctCostValue.MoraseleType = "‰«„Â"
        Else
            mctCostValue.MoraseleType = "»” Â"
        End If
        
        'mctCostValue.TransportType = cboSendtype.Text
        mctCostValue.TransportType = "ÂÊ«ÌÌ"
        'mctCostValue.DestinationType = cboDestType.Text
        If optDestination(0).Value = True Then
            mctCostValue.DestinationType = "‘Â—Ì"
        ElseIf optDestination(1).Value = True Then
            mctCostValue.DestinationType = "»Ì‰ ‘Â—Ì"
        Else
            mctCostValue.DestinationType = "Œ«—ÃÂ"
        End If
        mctCostValue.Weight = txtWeight.Text
        'mctCostValue.ParcelCount = L_NewCodeCounter + 1
        
        If mctCostValue.GetCost < 0 Then
            G_ShowMsg "⁄œ„ „ÿ«»ﬁ  ‰—Œ‰«„Â »« «ÿ·«⁄«  œ«œÂ ‘œÂ.", vbOKOnly, G_exclamation
            L_CalculateCost = True
           Exit Function
        End If
        
        If optPay(1).Value = False And optPay(3).Value = False Then
            lblParcelFare.Caption = mctCostValue.PostalCost
        End If
        
        lblInsur.Caption = mctCostValue.InsuranceCost
        'chkSendPlace.Tag = mctCostValue.MySendPlaceCost
        
        If optPay(1).Value = True Then
            txtDiscount = (L_contractDiscount(cboLservice.ListIndex) / 100) * Val(lblParcelFare)
        Else
            txtDiscount = 0
        End If
        lblUnsize.Caption = mctCostValue.UnsizeCost
            
        '' OutOfStandardPackage
        lblUnstandardPackage.Caption = mctCostValue.UnstandardPackageCost
        '' OutOfStandardPackage
        
        If chkSendPlace.Value = 1 Then
            L_SendPlaceCostArray(L_NewCodeCounter) = Val(mctCostValue.MySendPlaceCost)
        Else
            L_SendPlaceCostArray(L_NewCodeCounter) = 0
        End If
        lbSendPlace.Caption = L_SendPlaceCostArray(L_NewCodeCounter)
        lblTotalPrice = Str(Val(lblParcelFare) + Val(lblInsur) + Val(txtPackage) + Val(lblUnsize) + Val(lblUnstandardPackage) + Val(lbSendPlace) - Val(txtDiscount))
        lblTotaltxt = "(" + G_NumToText(Round(Val(lblTotalPrice) / 10)) + " Ê„«‰)"
    '******************************************************
    Else   '€Ì— ÅÌ‘ «“
        If optDestination(2).Value = True Then
            Set adoRst = New ADODB.Recordset
            'strSQL = "SELECT * From COUNTRY WHERE CountryName = '" & cboCountry.Text & "'"
            strSQL = "SELECT * From COUNTRY WHERE CountryCode = " & cboCountry.ItemData(cboCountry.ListIndex)
            adoRst.Open strSQL, G_AdoConn, adOpenStatic, adLockOptimistic
            If adoRst.RecordCount > 0 Then
                adoRst.MoveFirst
                mctCostValue.CountryGroup = adoRst("GroupNormal")
                mctCostValue.EMSCountryGroup = adoRst("GroupEMS")
                mctCostValue.ConsigneeCountryGroup = adoRst("GroupConsignee")
                mctCostValue.DestinationCountryName = cboCountry.Text
            End If
            adoRst.Close
            Set adoRst = Nothing
        End If
        If optDestination(1).Value = True Then
            Set adoRst = New ADODB.Recordset
            'strSQL = "SELECT * FROM qryCityProvince WHERE CityName = '" & cboCity.Text & "'"
            strSQL = "SELECT * FROM qryCityProvince WHERE CityCode = " & cboCity.ItemData(cboCity.ListIndex)
            adoRst.Open strSQL, G_AdoConn, adOpenStatic, adLockOptimistic
            If adoRst.RecordCount > 0 Then
                adoRst.MoveFirst
                mctCostValue.DestinationCityName = cboCity.Text
                mctCostValue.DestinationProvinceName = adoRst("provinceName")
            End If
            adoRst.Close
            Set adoRst = Nothing
        ElseIf optDestination(0).Value = True Then
            mctCostValue.DestinationCityName = G_CityName
            mctCostValue.DestinationProvinceName = G_ProvinceName
        End If
        
        mctCostValue.CustomerStampPrice = Val(txtDiscount.Text) * (-1)
        mctCostValue.IsRegistered = True
        mctCostValue.IsEMSType = False
        If chkExpress.Value = 1 Then
            mctCostValue.IsExpress = True
        Else
            mctCostValue.IsExpress = False
        End If
        If chkTwoReceipt.Value = 1 Then
            mctCostValue.Is2Receipt = True
        Else
            mctCostValue.Is2Receipt = False
        End If
        If chkRestant.Value = 1 Then
            mctCostValue.IsRestant = True
        Else
            mctCostValue.IsRestant = False
        End If
        If chkUnSize.Value = 1 Then
            mctCostValue.ISOutOfSize = True
        Else
            mctCostValue.ISOutOfSize = False
        End If
        '' OutOfStandardPackage
        If chkUnStandardPackage.Value = 1 Then
            mctCostValue.ISOutOfStandardPackage = True
        Else
            mctCostValue.ISOutOfStandardPackage = False
        End If
        '' OutOfStandardPackage
        If chkFragile.Value = 1 Then
            mctCostValue.IsMayeOrBreak = True
        Else
            mctCostValue.IsMayeOrBreak = False
        End If
        
        If chkBankParcel.Value = 1 Then
            mctCostValue.IsBankAndMoney = True
        Else
            mctCostValue.IsBankAndMoney = False
        End If
        
        If chkAmanat_Tejari.Value = 1 Then
            mctCostValue.Amanat_Tejari = True
        Else
            mctCostValue.Amanat_Tejari = False
        End If
        
        If chkAmanat_Anbooh.Value = 1 Then
            mctCostValue.Amanat_Anbooh = True
        Else
            mctCostValue.Amanat_Anbooh = False
        End If
        
        If chkSendPlace.Value = 1 Then  'Õﬁ „ﬁ—
            mctCostValue.IsSendPlace = True
        Else
            mctCostValue.IsSendPlace = False
        End If
        
        If optPay(2).Value Then
            mctCostValue.IsFareInDest = True
        Else
            mctCostValue.IsFareInDest = False
        End If
            
        mctCostValue.ToldValue = Val(txtExpInsur.Text)
        If optDestination(2).Value = True Then
            If cboIranInsurType.Visible And cboIranInsurType.Text = "ÊÃÂ ‰ﬁœ° «”‰«œ Ê „—”Ê·«  »«‰ﬂÌ" Then
                mctCostValue.HasForeignInsurance = True
            Else
               mctCostValue.HasForeignInsurance = False
            End If
            mctCostValue.HasUnknownValuePackIranInsurance = False
            mctCostValue.HasUnknownValueEnvelopeIranInsurance = False
            mctCostValue.HasKnownValueCashIranInsurance = False
            mctCostValue.HasKnownValueOthersIranInsurance = False
        ElseIf Trim(txtExpInsur.Text) = "" Then
            If cboParcelType.ListIndex = 1 Or cboParcelType.ListIndex = 3 Then
                mctCostValue.HasUnknownValueEnvelopeIranInsurance = False
                mctCostValue.HasUnknownValuePackIranInsurance = True
            Else
                mctCostValue.HasUnknownValueEnvelopeIranInsurance = False
                mctCostValue.HasUnknownValuePackIranInsurance = False
            End If
        ElseIf IsNumeric(Trim(txtExpInsur.Text)) Then
            Select Case cboIranInsurType.Text
                Case "ÊÃÂ ‰ﬁœ° «”‰«œ Ê „—”Ê·«  »«‰ﬂÌ"
                    mctCostValue.HasKnownValueCashIranInsurance = True
                Case "”«Ì—"
                    mctCostValue.HasKnownValueOthersIranInsurance = True
            End Select
        End If
        ''  Iran Insurance
        mctCostValue.OtherPrice = 0
        mctCostValue.PackingPrice = txtPackage.Text
        
        mctCostValue.CustomerStampPrice = (-1) * Val(txtDiscount.Text)
        If IsNumeric(txtSoshNumber.Text) Then
            mctCostValue.ParcelCount = txtSoshNumber.Text
        Else
            mctCostValue.ParcelCount = 1
        End If
        mctCostValue.Amanat_Anbooh = chkAmanat_Anbooh.Value
        
        If cboParcelType.ListIndex = 0 Then
            mctCostValue.MoraseleType = "‰«„Â"
        ElseIf cboParcelType.ListIndex = 1 Then
            mctCostValue.MoraseleType = "»” Â"
        Else
            mctCostValue.MoraseleType = cboParcelType.Text
        End If
                
        mctCostValue.TransportType = cboSendtype.Text
        'mctCostValue.TransportType = "ÂÊ«ÌÌ"
        'mctCostValue.DestinationType = cboDestType.Text
        If optDestination(0).Value = True Then
            mctCostValue.DestinationType = "‘Â—Ì"
        ElseIf optDestination(1).Value = True Then
            mctCostValue.DestinationType = "»Ì‰ ‘Â—Ì"
        Else
            mctCostValue.DestinationType = "Œ«—ÃÂ"
        End If
        mctCostValue.Weight = txtWeight.Text
        'mctCostValue.ParcelCount = L_NewCodeCounter + 1
        
        If mctCostValue.GetCost < 0 Then
            G_ShowMsg "⁄œ„ „ÿ«»ﬁ  ‰—Œ‰«„Â »« «ÿ·«⁄«  œ«œÂ ‘œÂ.", vbOKOnly, G_exclamation
            L_CalculateCost = True
           Exit Function
        End If
        
        If chkSendPlace.Value = 1 Then
            L_SendPlaceCostArray(L_NewCodeCounter) = Val(mctCostValue.MySendPlaceCost)
        Else
            L_SendPlaceCostArray(L_NewCodeCounter) = 0
        End If
        lbSendPlace.Caption = L_SendPlaceCostArray(L_NewCodeCounter)
        
        lblParcelFare.Caption = mctCostValue.PostalCost
        lblInsur.Caption = mctCostValue.InsuranceCost
        lblUnsize.Caption = mctCostValue.UnsizeCost
        '' OutOfStandardPackage
        lblUnstandardPackage.Caption = mctCostValue.UnstandardPackageCost
        '' OutOfStandardPackage
        lblTotalPrice.Caption = mctCostValue.TotalCost '+ Val(txtDiscount)
        lblTotalPrice.Caption = mctCostValue.TotalCost + Val(lbSendPlace)
        'lblTotalPrice = Str(Val(lblParcelFare) + Val(lblInsur) + Val(txtPackage) + Val(lblUnsize) + Val(lblUnstandardPackage) + Val(lbSendPlace) - Val(txtDiscount))
        lblTotaltxt = "(" + G_NumToText(Round(Val(lblTotalPrice) / 10)) + " Ê„«‰)"
    End If
    L_CalculateCost = False
End Function

Private Sub L_SetContract()
    If (optPay(1).Value And cboLservice.ListIndex = -1) Or (optPay(3).Value And cboGservice.ListIndex = -1) Then
        'G_ShowMsg "ÂÌç ﬁ—«—œ«œÌ «‰ Œ«» ‰‘œÂ «” ", vbOKOnly, G_exclamation
        Exit Sub
    End If
    If optPay(3).Value And cboGservice.ListCount > 0 Then
        'L_ContractsIndexArray(L_NewCodeCounter) = cboGService.ListIndex
        lblParcelFare = L_GserviceFare(cboGservice.ListIndex)
        txtDiscount = "0"
    End If
    
    If optPay(1).Value = True And cboLservice.ListCount > 0 Then
        'If L_ContractTip(cboLservice.ListIndex) = True Then
            lblParcelFare = L_contractFare(cboLservice.ListIndex)
        'Else
        '    lblParcelFare = ""
        'End If
        'L_ContractsIndexArray(L_NewCodeCounter) = cboLservice.ListIndex
        txtDiscount = (L_contractDiscount(cboLservice.ListIndex) / 100) * L_contractFare(cboLservice.ListIndex)
    End If
End Sub

Private Sub L_ResetValues()
    'If L_EditFlag Then Exit Sub
    
    
    If m_BusyMethod = 0 Then
        
        m_BusyMethod = 1
               
        lblParcelFare = ""
        'txtDiscount.Text = ""
        lblInsur = ""
        lblTotaltxt = ""
        lblTotalPrice = ""
        lbSendPlace = ""
        If (G_BPrinter <> "") Then
            txtUniqueCode = ""
            txtReceiptCode = ""
        End If
        If L_ParcelNumber = 1 Then L_NewCodeCounter = 0
        CmdPrintReceipt.Enabled = False
        cmdCalculate.Enabled = True
        
        If optDestination(0).Value = True Then
            L_DestTypeArray(L_NewCodeCounter) = 0
        ElseIf optDestination(1).Value = True Then
            L_DestTypeArray(L_NewCodeCounter) = 1
        Else
            L_DestTypeArray(L_NewCodeCounter) = 2
        End If
        
        If optPay(0).Value Then
            L_PayTypeArray(L_NewCodeCounter) = 0
        ElseIf optPay(1).Value Then
            L_PayTypeArray(L_NewCodeCounter) = 1
            'ChkIranInsurance.Value = 0
        ElseIf optPay(2).Value Then
            L_PayTypeArray(L_NewCodeCounter) = 2
        Else
            L_PayTypeArray(L_NewCodeCounter) = 3
            ChkIranInsurance.Value = 0
        End If
        
        If G_IsEMS = 1 Then
            If optParcelType(0).Value Then
                L_ParcelFormArray(L_NewCodeCounter) = 0
            Else
                L_ParcelFormArray(L_NewCodeCounter) = 1
            End If
            
            'ChkIranInsurance.Value = 1
            'ChkIranInsurance.Enabled = True
                            
            If optPay(1).Value = False Then
 
                ChkIranInsurance.Value = 1
            End If
            
            If optPay(1).Value = True And cboLservice.ListCount > 0 Then
                'ChkIranInsurance.Value = 1
                
                
                optPay(3).Value = False
                If (cboLservice.ListIndex > -1) Then
                    If L_ContractTwoReceipt(cboLservice.ListIndex) = True Then chkTwoReceipt.Value = 1
                Else
                    chkTwoReceipt.Value = 0
                End If
            End If
        Else
            L_ParcelFormArray(L_NewCodeCounter) = cboParcelType.ListIndex
            If cboParcelType.ListIndex = 1 Or cboParcelType.ListIndex = 3 Then
                ChkIranInsurance.Enabled = True
                ChkIranInsurance.Value = 1
            Else
                'ChkIranInsurance.Value = 0
            End If
            
            '«„«‰ 
            If cboParcelType.ListIndex = 3 Then
                chkAmanat_Anbooh.Enabled = True
                chkAmanat_Tejari.Enabled = True
            Else
                chkAmanat_Anbooh.Enabled = False
                chkAmanat_Tejari.Enabled = False
            End If
        End If
                    
                   ' <hadi>
        If chkAmanat_Anbooh.Value = 1 Then
            txtDiscount.Enabled = False
'            optDestination(0).Value = True
'            optDestination(0).Enabled = False
'            optDestination(1).Enabled = False
'            optDestination(2).Enabled = False
        Else
'            optDestination(0).Enabled = True
'            optDestination(1).Enabled = True
'            optDestination(2).Enabled = True
        End If
        
        '</Hadi>
        
        If ChkIranInsurance.Value = 0 Then
            txtExpInsur = ""
            lblInsur = ""
            L_IranInsuranceArray(L_NewCodeCounter) = 0
        Else
            L_IranInsuranceArray(L_NewCodeCounter) = 1 + cboIranInsurType.ListIndex
        End If
                    
        txtExpInsur.Visible = ChkIranInsurance.Value
        cboIranInsurType.Visible = ChkIranInsurance.Value
        lblInsurlabel.Visible = ChkIranInsurance.Value
        'cboIranInsurType.Enabled = (ChkIranInsurance.Value = 1)
        cboLservice.Visible = optPay(1).Value
        cboGservice.Visible = optPay(3).Value
                                
        If optPay(3).Value Or optPay(1).Value Then
            L_SetContract
        End If
        
        '<h 83/11/5>
        If cboSendtype.ListIndex >= 0 Then
            L_ShippingArray(L_NewCodeCounter) = cboSendtype.ListIndex
        End If

        If cboPackage.ListIndex <> -1 Then
            txtPackage.Text = cboPackage.ItemData(cboPackage.ListIndex)
        End If
        
        If chkTwoReceipt.Value = 1 Then
            lblTwoReceipt.Visible = True
            txtReceiptCode.Visible = True
        Else
            lblTwoReceipt.Visible = False
            txtReceiptCode.Visible = False
        End If
        
        If chkUnSize.Value = 0 Then lblUnsize = ""
        '' OutOfStandardPackage
        If chkUnSize.Value = 1 And chkUnStandardPackage.Value = 1 Then chkUnStandardPackage.Value = 0
        '' OutOfStandardPackage
        
        If chkUnStandardPackage.Value = 0 Then
            lblUnstandardPackage = ""
        ElseIf chkUnStandardPackage.Value = 1 And chkUnSize.Value = 1 Then
            chkUnSize.Value = 0
        End If
        
        '</h>
        m_BusyMethod = 0
    End If
End Sub

Private Sub cboCity_Click()
    On Error GoTo Err_label
        
    If L_CboState = 0 Then
        L_CboState = 1
        L_ResetValues
        txtDestcode = ""
        txtDestcode = cboCity.ItemData(cboCity.ListIndex)
        lblProvincename = L_provinceArray(cboCity.ListIndex)
    End If
Err_label:
    L_CboState = 0
End Sub

Private Sub cboCity_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboCity_LostFocus()
    cboCity_Click
End Sub

Private Sub cboCountry_Click()
    On Error GoTo Err_label
    
    If L_CboState = 0 Then
        L_CboState = 1
        L_ResetValues
        txtDestcode = ""
        txtDestcode = cboCountry.ItemData(cboCountry.ListIndex)
    End If
Err_label:
    L_CboState = 0
End Sub

Private Sub cboCountry_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboCountry_LostFocus()
    cboCountry_Click
End Sub

Private Sub cboGService_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboGservice_LostFocus()
    cboGService_Click
End Sub

Private Sub cboIranInsurType_Click()
    L_ResetValues
End Sub

Private Sub cboIranInsurType_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboLservice_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboLservice_LostFocus()
    cboLservice_Click
End Sub

Private Sub cboPackage_Click()
    L_ResetValues
End Sub

Private Sub cboPackage_GotFocus()
    SendKeys "{F4}"
End Sub

Private Sub cboParcelType_Click()
    L_ResetValues
End Sub

Private Sub cboSendtype_Click()
    L_ResetValues
End Sub

Private Sub chkAmanat_Anbooh_Click()
    L_ResetValues
End Sub

Private Sub chkAmanat_Tejari_Click()
    L_ResetValues
End Sub

Private Sub chkBankParcel_Click()
    L_ResetValues
End Sub

Private Sub chkExpress_Click()
    L_ResetValues
End Sub

Private Sub chkFragile_Click()
    L_ResetValues
End Sub

Private Sub chkPrice_receive_Click()
    L_ResetValues
End Sub

Private Sub chkRestant_Click()
    L_ResetValues
End Sub

Private Sub chkTwoReceipt_Click()
    L_ResetValues
End Sub

Private Sub cboSendType_GotFocus()
    SendKeys "{f4}"
End Sub

Private Sub cboLservice_Click()
    L_ResetValues
End Sub

Private Sub cboGService_Click()
    L_ResetValues
End Sub

Private Sub ChkIranInsurance_Click()
    L_ResetValues
End Sub

Private Sub chkUnSize_Click()
    L_ResetValues
End Sub

'' OutOfStandardPackage
Private Sub chkUnStandardPackage_Click()
    L_ResetValues
End Sub

Private Sub cmdCalculate_Click()
    Dim i As Integer
    Dim calFlag As Boolean
    
    If L_ParcelNumber > 1000 Or L_ParcelNumber <= 0 Then
        txtSoshNumber.SetFocus
        Exit Sub
    End If
    
    If L_NewCodeCounter = L_ParcelNumber And L_ParcelNumber > 1 Then Exit Sub
    
    If G_BoxesValidate(Me) Then
        If L_Permition = False Then Exit Sub
              
        If L_NewCodeCounter = 0 Then
            L_RegCounter = Val(G_Startn)
        End If
        
        'If L_ParcelNumber > 0 And Not L_EditFlag And G_BPrinter <> "" Then
        If L_ParcelNumber > 0 And Not L_EditFlag Then
            L_ResetValues
        End If
        
        If Not L_CreateUniquecode Then  ' Ê·Ìœ ﬂœ «‰Õ’«—Ì Ê »«—ﬂœ
            Exit Sub
        End If
        
        If L_CalculateCost Then   '„Õ«”»Â ‰—Œ
            Exit Sub
        End If
        
        L_ParcelFareArray(L_NewCodeCounter) = Val(lblParcelFare)
        L_InsurCostArray(L_NewCodeCounter) = Val(lblInsur)
        L_TotalPriceArray(L_NewCodeCounter) = Val(lblTotalPrice)
        L_UnsizeArray(L_NewCodeCounter) = Val(lblUnsize)
        L_UnstandardArray(L_NewCodeCounter) = Val(lblUnstandardPackage)
        L_NewCodeCounter = L_NewCodeCounter + 1
        
         If G_IsEMS = 1 Then
            If G_BPrinter <> "" Then  'ﬂœ 20 —ﬁ„Ì
                If L_RegCounter >= 99999999 Then
                    Call G_ShowMsg("‘„«—Â „—”Ê·Â „⁄«œ· Õœ ‰Â«ÌÌ 99999999 „Ìù»«‘œ. œ—  ‰ŸÌ„«  ‰—„ «›“«—Ì ¬‰—« „⁄«œ· 1 ﬁ—«— œÂÌœ.", vbOKOnly, G_exclamation)
                Else
                    L_RegCounter = L_RegCounter + 1
                    If chkTwoReceipt.Value = 1 Then
                        L_RegCounter = L_RegCounter + 1
                        'Ì⁄‰Ì œ— Õ«·  œÊﬁ»÷Â »«Ìœ œÊ « Ã·Ê —Êœ
                    End If
                End If
            End If
        Else
            If L_RegCounter >= 99999999 Then
                Call G_ShowMsg("‘„«—Â „—”Ê·Â „⁄«œ· Õœ ‰Â«ÌÌ 99999999 „Ìù»«‘œ. œ—  ‰ŸÌ„«  ‰—„ «›“«—Ì ¬‰—« „⁄«œ· 1 ﬁ—«— œÂÌœ.", vbOKOnly, G_exclamation)
            Else
                L_RegCounter = L_RegCounter + 1
            End If
        End If
        
        If L_NewCodeCounter = L_ParcelNumber Then
            cmdCalculate.Enabled = False
            CmdPrintReceipt.Enabled = True
            If L_ParcelNumber > 1 Then cmdEdit.Enabled = True
            If Me.ActiveControl <> txtDestcode And Me.ActiveControl <> cboCity And Me.ActiveControl <> cboCountry Then CmdPrintReceipt.SetFocus
        Else
            If G_IsEMS = 1 Then
                If L_ParcelNumber > 1 Then
                    lblCounter.Caption = "„‘Œ’«  „—”Ê·Â " + Str(L_NewCodeCounter + 1) + " «“ " + Str(L_ParcelNumber)
                    If L_EditFlag Then
                        Call fillBoxes
                    End If
                End If
                txtReceiver.SelStart = 0
                txtReceiver.SelLength = 30
                If Me.ActiveControl <> txtDestcode And Me.ActiveControl <> cboCity And Me.ActiveControl <> cboCountry Then txtReceiver.SetFocus
            Else
                If L_ParcelNumber > 1 Then
                    lblCounter.Caption = "„‘Œ’«  „—”Ê·Â " + Str(L_NewCodeCounter + 1) + " «“ " + Str(L_ParcelNumber)
                    If L_EditFlag Then
                        Call fillBoxes
                    End If
                    txtReceiver.SelStart = 0
                    txtReceiver.SelLength = 30
                    If Me.ActiveControl <> txtDestcode And Me.ActiveControl <> cboCity And Me.ActiveControl <> cboCountry Then txtReceiver.SetFocus
                End If
            End If
        End If
    End If
End Sub

Private Sub cmdEdit_Click()
    L_EditFlag = True
    cmdCalculate.Enabled = True
    L_NewCodeCounter = 0
    L_ParcelNumber = Val(txtSoshNumber)
    If L_ParcelNumber > 1000 Then
        G_ShowMsg " ⁄œ«œ „—”Ê·«  Õœ«ﬂÀ— 1000 ⁄œœ „Ìù Ê«‰œ »«‘œ.", vbOKOnly, G_exclamation
        txtSoshNumber.SetFocus
        Exit Sub
    End If
    lblParcelFare = ""
    lblTotalPrice = ""
    lblTotaltxt = ""
    Call fillBoxes
End Sub

Private Sub cmdNew_Click()
    L_ResetValues
    
    L_NewCodeCounter = 0
    L_ParcelNumber = 1
    L_ParcelCodeString = ""
    L_RegCounter = Val(G_Startn)
    txtSoshNumber = 1
    lblCounter.Caption = "„‘Œ’«  „—”Ê·Â 1 «“ 1"
    
    'L_CurrentTime = Time
    L_CurrentTime = Format(Time, "HH:mm:ss")
    
    lblInsur = ""
    txtWeight = ""
    txtReceiver = ""
    txtSender = ""
    chkUnSize.Value = 0
    chkUnStandardPackage.Value = 0
    chkTwoReceipt.Value = 0
    chkPrice_receive.Value = 0
    chkBankParcel.Value = 0
    chkRestant.Value = 0
    chkFragile.Value = 0
    chkExpress.Value = 0
    chkAmanat_Tejari.Value = 0
    chkAmanat_Anbooh.Value = 0
    txtExpInsur.Text = ""
    txtDiscount.Text = ""
    
    If G_IsEMS = 1 Then
        optParcelType(0).Value = True
    End If
    
    cboParcelType.ListIndex = 0
    ChkIranInsurance.Value = 0
    ChkIranInsurance_Click
    optPay(0).Value = True
    L_ResetValues
    cboCountry.Visible = False
    cboCity.Visible = True
    cboIranInsurType.ListIndex = 0
    cboPackage.ListIndex = 0
    optDestination(1).Value = True
    cboCity.ListIndex = 0
    If G_IsEMS = 1 Then
        L_ServiceType = "10110100000000000000"  'ÅÌ‘ ›—÷: ÅÌ‘ «“-Å«ﬂ -»Ì‰ ‘Â—Ì-ÂÊ«ÌÌ-‰ﬁœÌ-»Ì„Â
    Else
        L_ServiceType = "00110000000000000000"  'ÅÌ‘ ›—÷: „ ⁄«—›-‰«„Â-»Ì‰ ‘Â—Ì-ÂÊ«ÌÌ-‰ﬁœÌ-€Ì—»Ì„Â
        optDestination_Click (1)
    End If
    cmdEdit.Enabled = False
    L_EditFlag = False
    Screen.MousePointer = vbDefault
    If txtSoshNumber.Visible Then txtSoshNumber.SetFocus
End Sub

Private Sub CmdPrintReceipt_Click()
    On Error GoTo Err_label
    Dim temp As String
    Dim i As Integer
    Dim strMcodeBarcode As String
    Dim strRECEIPT_CODE As String
    Dim strRECEIPT_BARCODE As String
    Dim strCno As String
        
        
    '<Hadi>
    '<Date 85/3/24 />
    'Ãœ« ‘œ‰ Õﬁ „ﬁ— œ— ”Ê‘Â«Ì ”›«—‘Ì ‰Ì“ «⁄„«· ‘Êœ
    '</Hadi>
    
    
    L_NewCodeCounter = 0
    temp = IIf(G_IsEMS = 0, "”›«—‘Ì", "ÅÌ‘ «“")
    G_ShowMsg "¬Ì« »—êÂ —”Ìœ " & temp & " œ— ç«Åê— ﬁ—«— œ«—œø", vbYesNo, G_question
    If G_MsgButton = vbYes Then
        Screen.MousePointer = vbHourglass
        For i = 0 To L_ParcelNumber - 1
            If L_UniqueCodeArray(i) = L_TwoReceiptCodeArray(i) Then
                Screen.MousePointer = vbDefault
                G_ShowMsg "ﬂœ „—”Ê·Â »—«»— ﬂœ ﬁ»÷ œÊ„ «” .", vbOKOnly, G_exclamation
                If L_ParcelNumber = 1 Then
                    L_NewCodeCounter = 0
                    cmdCalculate.Enabled = True
                    CmdPrintReceipt.Enabled = False
                End If
                Exit Sub
            End If
            
            G_MyQuery = "select * from tblParcels where uniquecode='" + L_UniqueCodeArray(i) + "'"
            If G_MyRst2.State = 1 Then G_MyRst2.Close
            G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
            If Not G_MyRst2.EOF Then
                Screen.MousePointer = vbDefault
                G_ShowMsg "ﬂœ „—”Ê·Â  ﬂ—«—Ì «” .", vbOKOnly, G_exclamation
                If L_ParcelNumber = 1 Then
                    L_NewCodeCounter = 0
                    cmdCalculate.Enabled = True
                    CmdPrintReceipt.Enabled = False
                End If
                Exit Sub
            End If
            
            G_MyQuery = "select * from tblParcels where RECEIPT_CODE='" + L_UniqueCodeArray(i) + "'"
            If G_MyRst2.State = 1 Then G_MyRst2.Close
            G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
            If Not G_MyRst2.EOF Then
                Screen.MousePointer = vbDefault
                G_ShowMsg "ﬂœ „—”Ê·Â  ﬂ—«—Ì «” .(œ— ﬂœ ﬁ»÷ œÊ„ Ìﬂ „—”Ê·Â »Â ﬂ«— —› Â «” )", vbOKOnly, G_exclamation
                If L_ParcelNumber = 1 Then
                    L_NewCodeCounter = 0
                    cmdCalculate.Enabled = True
                    CmdPrintReceipt.Enabled = False
                End If
                Exit Sub
            End If
        
            If L_TwoReceiptCodeArray(L_NewCodeCounter) <> "" Then
                G_MyQuery = "select * from tblParcels where uniquecode='" + L_TwoReceiptCodeArray(i) + "'"
                If G_MyRst2.State = 1 Then G_MyRst2.Close
                G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
                If Not G_MyRst2.EOF Then
                    Screen.MousePointer = vbDefault
                    G_ShowMsg "ﬂœ ﬁ»÷ œÊ„ „—”Ê·Â  ﬂ—«—Ì «” .(œ— ﬂœ Ìﬂ „—”Ê·Â »Â ﬂ«— —› Â «” )", vbOKOnly, G_exclamation
                    If L_ParcelNumber = 1 Then
                        L_NewCodeCounter = 0
                        cmdCalculate.Enabled = True
                        CmdPrintReceipt.Enabled = False
                    End If
                    Exit Sub
                End If
                
                G_MyQuery = "select * from tblParcels where RECEIPT_CODE='" + L_TwoReceiptCodeArray(i) + "'"
                If G_MyRst2.State = 1 Then G_MyRst2.Close
                G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
                If Not G_MyRst2.EOF Then
                    Screen.MousePointer = vbDefault
                    G_ShowMsg "ﬂœ ﬁ»÷ œÊ„ „—”Ê·Â  ﬂ—«—Ì «” .(œ— ﬂœ ﬁ»÷ œÊ„ Ìﬂ „—”Ê·Â »Â ﬂ«— —› Â «” )", vbOKOnly, G_exclamation
                    If L_ParcelNumber = 1 Then
                        L_NewCodeCounter = 0
                        cmdCalculate.Enabled = True
                        CmdPrintReceipt.Enabled = False
                    End If
                    Exit Sub
                End If
            End If
        Next
            '«Ì‰ œÊ Õ·ﬁÂ ‰»«Ìœ œ— Â„ «œ€«„ ‘Ê‰œ
        For i = 0 To L_ParcelNumber - 1
'            strMcodeBarcode = "NULL"
'            strRECEIPT_CODE = "NULL"
'            strRECEIPT_BARCODE = "NULL"
'            strCno = "NULL"
'
'            If G_IsEMS = 1 Then
'                strMcodeBarcode = "'" + L_strBarcodeArray(i) + "'"
'                If Mid(L_ServiceTypeArray(i), 1 + G_ServiceTypeElements.enmTwoReceipt, 1) = 1 Then 'œÊﬁ»÷Â
'                    strRECEIPT_CODE = "'" + L_TwoReceiptCodeArray(i) + "'"
'                    strRECEIPT_BARCODE = "'" + L_strTwoReceiptBarcodeArray(i) + "'"
'                End If
'
'                If Mid(L_ServiceTypeArray(i), 1 + G_ServiceTypeElements.enmPayType, 1) = 1 Or Mid(L_ServiceTypeArray(i), 1 + G_ServiceTypeElements.enmPayType, 1) = 3 Then
'                    strCno = L_contractNumber(L_ContractsArray(i))
'                End If
'            End If

'            G_MyQuery = "INSERT INTO tblParcels (Uniquecode, DestCode, ServiceType, ExpInsur, ReceiptDate, ReceiptTime, SenderName, ReceiverName, Weight, Fare, InsurCost, PackageCost, EtcCost, Discount, TotalCost, UserCode, MCodeBarcode,RECEIPT_CODE,RECEIPT_BARCODE,Cno)" _
'                + " VALUES(" _
'                + "'" + L_UniqueCodeArray(i) + "'," + str(L_DestcodeArray(i)) + ",'" + L_ServiceTypeArray(i) + "'," + str(L_ExpInsurArray(i)) + ",'" _
'                + G_CurrentDate + "','" + Left(L_CurrentTime, 8) + "','" + L_SenderArray(i) + "','" + L_ReceiverArray(i) _
'                + "'," + str(L_WeightArray(i)) + "," + str(L_ParcelFareArray(i)) + "," + str(L_InsurCostArray(i)) + "," + str(L_PackageCostArray(i)) + "," + "0" + "," _
'                + str(L_DiscountArray(i)) + "," + str(L_TotalPriceArray(i)) + "," + CStr(G_CurrentUserCode) + "," + strMcodeBarcode + "," + strRECEIPT_CODE + "," + strRECEIPT_BARCODE + "," + strCno + ")"
'
'            G_AdoConn.Execute G_MyQuery

            '»œ·Ì· „‘ﬂ· ⁄·«„ Â«Ì Œ«’ œ— »«—ﬂœ »Ã«Ì ﬂœ »«·« «“ ﬂœ “Ì— «” ›«œÂ ‘œ
            G_MyQuery = "select * from tblParcels where uniquecode='" + L_UniqueCodeArray(i) + "'"
            If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
            G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
            G_PrimaryRs.AddNew
            G_PrimaryRs!uniquecode = L_UniqueCodeArray(i)
            G_PrimaryRs!destcode = L_DestcodeArray(i)
            G_PrimaryRs!ServiceType = L_ServiceTypeArray(i)
            G_PrimaryRs!ExpInsur = L_ExpInsurArray(i)
            G_PrimaryRs!ReceiptDate = G_CurrentDate
            G_PrimaryRs!receipttime = Left(L_CurrentTime, 8)
            G_PrimaryRs!SenderName = L_SenderArray(i)
            G_PrimaryRs!ReceiverName = L_ReceiverArray(i)
            G_PrimaryRs!Weight = L_WeightArray(i)
            G_PrimaryRs!Fare = L_ParcelFareArray(i)
            G_PrimaryRs!Insurcost = L_InsurCostArray(i)
            G_PrimaryRs!Packagecost = L_PackageCostArray(i)
            G_PrimaryRs!EtcCost = L_UnstandardArray(i) + L_UnsizeArray(i)
            G_PrimaryRs!Discount = L_DiscountArray(i)
            G_PrimaryRs!TotalCost = L_TotalPriceArray(i)
            G_PrimaryRs!UserCode = CStr(G_CurrentUserCode)
            G_PrimaryRs!SendPlaceCost = L_SendPlaceCostArray(i)
                        
            If G_IsEMS = 1 Then
                G_PrimaryRs!McodeBarcode = L_strBarcodeArray(i)
                If chkTwoReceipt.Value = 1 Then
                    G_PrimaryRs!RECEIPT_CODE = L_TwoReceiptCodeArray(i)
                    G_PrimaryRs!RECEIPT_BARCODE = L_strTwoReceiptBarcodeArray(i)
                End If
                If L_ParcelNumber > 1 Then
                    If L_PayTypeArray(i) = 1 Then G_PrimaryRs!Cno = L_contractNumber(L_ContractsIndexArray(i))
                    If L_PayTypeArray(i) = 3 Then G_PrimaryRs!Cno = L_GserviceNumber(L_ContractsIndexArray(i))
                Else
                    If Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmPayType, 1) = 1 Then G_PrimaryRs!Cno = L_contractNumber(L_ContractsIndexArray(i))
                    If Mid(L_ServiceType, 1 + G_ServiceTypeElements.enmPayType, 1) = 3 Then G_PrimaryRs!Cno = L_GserviceNumber(L_ContractsIndexArray(i))
                End If
            End If
            
            G_PrimaryRs.Update

            If (frmReceiptList.grdList.Rows > 2) Or (frmReceiptList.grdList.Rows = 2 And Len(frmReceiptList.grdList.TextMatrix(1, enmParcelCode)) > 0) Then frmReceiptList.grdList.AddItem ""
            Call frmReceiptList.L_FillGrid(frmReceiptList.grdList.Rows - 1, L_UniqueCodeArray(i), L_ServiceTypeArray(i), L_DestcodeArray(i), G_CurrentDate, Left(L_CurrentTime, 8), Val(L_ExpInsurArray(i)), L_WeightArray(i), L_SenderArray(i), L_ReceiverArray(i), Val(L_ParcelFareArray(i)), Val(L_InsurCostArray(i)), Val(L_PackageCostArray(i)), L_UnstandardArray(i) + L_UnsizeArray(i), Val(L_DiscountArray(i)), Val(L_TotalPriceArray(i)), G_CurrentUserCode, L_TwoReceiptCodeArray(i), -1, L_DestNameArray(i))
        Next
        Sleep (5000)
        Call L_PrintJob 'ç«Å ”Ê‘ Ê»—ç”»
        
        G_Startn = Format(Str(L_RegCounter), "00000000")
        SaveSetting "Track&Trace", "PostOffice", "startno", G_GetEncrypted(Str(L_RegCounter))
        Call cmdNew_Click
        
        Screen.MousePointer = vbDefault
    End If
    Exit Sub
Err_label:
    Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
    L_NewCodeCounter = 0
    cmdCalculate.Enabled = True
    CmdPrintReceipt.Enabled = False
    Screen.MousePointer = vbDefault
End Sub

Private Sub CmdWeight_Click()
    If G_Tarazoo = " Ê“Ì‰ «·ﬂ —Ê‰Ìﬂ" Then     ' Ê“Ì‰
        L_TozinBalance
    Else
        L_PandBalance      'Å‰œ
    End If
    SendKeys "{tab}"
End Sub

Private Sub CmdWeight_KeyUp(KeyCode As Integer, Shift As Integer)
    SendKeys "{tab}"
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    Select Case KeyCode
        
        Case vbKeyEscape:
        Unload Me
       
        Case vbKeyF12:
            If G_Tarazoo <> "" Then
                If G_Tarazoo = " Ê“Ì‰ «·ﬂ —Ê‰Ìﬂ" Then
                    L_TozinBalance
                Else
                    L_PandBalance
                End If
            End If
        Case vbKeyF8:
            Shell ("calc.exe")
        Case vbKeyF9:
            If cmdCalculate.Enabled = True Then cmdCalculate_Click
        Case vbKeyF11:
            'If cmdCalculate.Enabled = True Then If G_IsEMS = 1 Then optDestination(1).SetFocus Else optDestination(1).SetFocus
            If cmdCalculate.Enabled = True Then
                If optDestination(1).Value Then cboCity.SetFocus
                If optDestination(2).Value Then cboCountry.SetFocus
            End If
        Case vbKeyN:
            If Shift = vbCtrlMask And cmdNew.Enabled = True Then
                cmdNew_Click
            End If
    End Select
    Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Load()
    Dim ErrorNumber, i, k As Integer
    
    Select Case Screen.Width
        Case 9600
            Top = 0
            Left = 0
        Case 12000
            Top = 1000
            Left = 1000
        Case 15360
            Top = 2000
            Left = 2500
    End Select
    
    'MsgBox L_MakeBarcode128c("87654321")
    
    For i = 0 To Me.count - 1
        Me.Controls(i).Tag = ""
    Next
    txtSoshNumber.Tag = 11
    txtWeight.Tag = 11
    txtSender.Tag = 21
    txtReceiver.Tag = 21
    txtPackage.Tag = 1
    txtDiscount.Tag = 1
    txtDestcode.Tag = 11
    txtExpInsur.Tag = 1
    
    m_BusyMethod = 0
    cboParcelType.ListIndex = 0
    ChkIranInsurance.Value = 0
    ChkIranInsurance_Click
    optPay(0).Value = True
    
    'cboIranInsurType.Enabled = False
    cboCountry.Visible = False
    cboCity.Visible = True
    cboIranInsurType.ListIndex = 0
    cboIranInsurType.Visible = False
    cboPackage.ListIndex = 0
    chkTwoReceipt.Value = 1
    
    If G_Tarazoo = "" Then
        cmdWeight.Enabled = False
        lbScale = " —«“Ê €Ì— ›⁄«·"
    Else
        lbScale = G_Tarazoo
    End If
    
    txtUniqueCode.Locked = (G_BPrinter <> "")
    txtReceiptCode.Locked = (G_BPrinter <> "")

    L_NewCodeCounter = 0
    L_ParcelNumber = 1
    L_RegCounter = Val(G_Startn)
    
    G_MyQuery = "SELECT CITY.CODE as citycode, CITY.PName as cityname, CITY.IsPort, CITY.IsFreeZone, CITY.STATE_CODE, STATE.PName as ProvinceName" _
        + " FROM STATE INNER JOIN CITY ON STATE.CODE = CITY.STATE_Code WHERE CITY.STATE_CODE <> 0 and CITY.CODE<>" + G_CityCode _
        + " ORDER BY CITY.PName"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    If G_MyRst2.RecordCount > 0 Then
        G_MyRst2.MoveLast
        G_MyRst2.MoveFirst
        cboCity.Clear
        For i = 0 To G_MyRst2.RecordCount - 1
           cboCity.List(i) = Trim(G_MyRst2!cityname)
           cboCity.ItemData(i) = G_MyRst2!citycode
           L_provinceArray(i) = G_MyRst2!ProvinceName
           G_MyRst2.MoveNext
        Next
    End If
    L_CboState = 0
    G_MyQuery = "select countrycode,countryname from COUNTRY order by countryname"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    Call G_FillCombo2(cboCountry, G_MyRst2)
     
    optDestination(1).Value = True
    optDestination_Click (1)
    cboCity.ListIndex = 0
    StatusBar1.Panels(2).Text = " ﬂ«—»—: " + G_UserPname
    If G_IsEMS = 1 Then
        Me.Caption = "ﬁ»Ê· „—”Ê·«  ÅÌ‘ «“"
        Me.BackColor = &H8000000F
        
        L_ServiceType = "10111000000000000000"  'ÅÌ‘ ›—÷: ÅÌ‘ «“-Å«ﬂ -»Ì‰ ‘Â—Ì-ÂÊ«ÌÌ-‰ﬁœÌ-»Ì„Â
        imgArm.Visible = False
        imgEmsArm.Visible = True
        Call L_FillContractsCombo(1)
        Call L_FillContractsCombo(0)
        cboParcelType.Enabled = False
        chkFragile.Enabled = False
        chkBankParcel.Enabled = False
        chkAmanat_Tejari.Enabled = False
        chkAmanat_Anbooh.Enabled = False
        chkExpress.Enabled = False
        chkRestant.Enabled = False
        cboSendtype.Enabled = False
        txtDiscount.Enabled = False
    Else
        Me.Caption = "ﬁ»Ê· „—”Ê·«  ”›«—‘Ì"
        'On Error Resume Next
        cmdCalculate.Caption = "„Õ«”»Â ‰—Œ"
        Me.BackColor = &HC0C0C0
        chkSendPlace.BackColor = &HC0C0C0
        chkTwoReceipt.BackColor = &HC0C0C0
        chkExpress.BackColor = &HC0C0C0
        chkPrice_receive.BackColor = &HC0C0C0
        chkFragile.BackColor = &HC0C0C0
        chkBankParcel.BackColor = &HC0C0C0
        chkAmanat_Tejari.BackColor = &HC0C0C0
        chkAmanat_Anbooh.BackColor = &HC0C0C0
        chkRestant.BackColor = &HC0C0C0
        ChkIranInsurance.BackColor = &HC0C0C0
        DestFrame.BackColor = &HC0C0C0
        fraParcelCode.BackColor = &HC0C0C0
        chkUnSize.BackColor = &HC0C0C0
        chkUnStandardPackage.BackColor = &HC0C0C0
        optDestination(0).BackColor = &HC0C0C0
        optDestination(1).BackColor = &HC0C0C0
        optDestination(2).BackColor = &HC0C0C0
        optPay(0).BackColor = &HC0C0C0
        optPay(1).BackColor = &HC0C0C0
        optPay(2).BackColor = &HC0C0C0
        optPay(3).BackColor = &HC0C0C0
        optParcelType(0).BackColor = &HC0C0C0
        optParcelType(1).BackColor = &HC0C0C0
        
        For k = 0 To 6
            frame1(k).BackColor = &HC0C0C0
        Next k
        
        
        L_ServiceType = "00110000000000000000"  'ÅÌ‘ ›—÷: „ ⁄«—›-‰«„Â-»Ì‰ ‘Â—Ì-ÂÊ«ÌÌ-‰ﬁœÌ-€Ì—»Ì„Â
        imgArm.Visible = True
        imgEmsArm.Visible = False
        optParcelType(0).Enabled = False
        optParcelType(1).Enabled = False
        cboParcelType.Enabled = True
        optPay(1).Enabled = False
        cboLservice.Enabled = False
        optPay(3).Enabled = False
        cboGservice.Visible = False
        cboLservice.Visible = False
        chkPrice_receive.Enabled = False
        fraParcelCode.Visible = False
        cboParcelType.ListIndex = 0
        txtDiscount.Enabled = True
        'cmdEdit.Visible = False
    End If
    cboSendtype.ListIndex = 1
    Screen.MousePointer = vbDefault
    cmdNew_Click
End Sub

Private Sub Form_Unload(Cancel As Integer)
       If msCommScale.PortOpen = True Then
        msCommScale.PortOpen = False
   End If
End Sub

'«Ì‰ —ÊÌœ«œ »—«Ì  —«“ÊÌ  Ê“Ì‰ ﬂ«—Ì «‰Ã«„ ‰„ÌœÂœ
Private Sub msCommScale_OnComm()
    Dim W As String
    Dim dd As String
    Dim r As Integer
    Dim p As Integer
    Dim over_w As Integer
    Static flag As Integer
    Static sbuff(2 To 4) As String * 2
    Static sflag As Integer
    Static scount As Integer
    Static w_neg As Integer
    ''''''''''''''''''''''''''''''''
    Static flg1 As Integer
    Static flg2 As Integer

    If data_completed = 1 Then
        Exit Sub
    End If

    If (G_Tarazoo = " Ê“Ì‰ «·ﬂ —Ê‰Ìﬂ") Then
         Exit Sub
    End If

    'MsgBox "oncomm"
    
    Select Case msCommScale.CommEvent
        Case comEvReceive
            W$ = msCommScale.Input
            ''''''''''''''''''''''''''''
            If Mid(W$, 1, 1) = Chr$(187) Then '0xbb
                sflag = 1
                flag = 0
                flg1 = 0
                flg2 = 0
                scount = 0
            End If
            
            If sflag = 1 Then
                If W$ <> "" Then
                    scount = scount + 1
                    If scount = 2 Then
                        If W$ = Chr$(224) Then
                            w_neg = 1
                        ElseIf W$ = Chr$(240) Then
                            over_w = 1
                        Else
                            w_neg = 0
                            over_w = 0
                        End If
                    End If

                    If over_w = 1 Then
                        scount = 0
                        inweight = "------"
                        Beep
                        data_completed = 1
                    ElseIf w_neg = 1 Then
                        If scount >= 3 And scount <= 5 Then
                            sbuff(scount - 1) = LTrim$(RTrim$(Hex(Asc(W$))))
                            If Asc(W$) < 10 And scount > 3 Then sbuff(scount - 1) = "0" + sbuff(scount - 1)
                                If Asc(W$) < 10 And scount = 3 Then sbuff(scount - 1) = " " + sbuff(scount - 1)
                                If scount = 5 Then
                                    scount = 0
                                    sflag = 0
                                    If Val(sbuff(2)) = 0 Then sbuff(2) = ""
                                    dd$ = Trim$(sbuff(2) + sbuff(3) + sbuff(4))
                                    r% = Len(Trim$(dd$))
                                    inweight = "-" + Mid(dd$, 1, r% - 3) + "." + Mid(dd$, r% - 2, 3)
                                    data_completed = 1
                                End If
                            End If
                        ElseIf scount >= 2 And scount <= 4 Then
                            sbuff(scount) = LTrim$(RTrim$(Hex(Asc(W$))))
                            If Asc(W$) < 10 And scount > 2 Then sbuff(scount) = "0" + sbuff(scount)
                            If Asc(W$) < 10 And scount = 2 Then sbuff(scount) = " " + sbuff(scount)
                            If scount = 4 Then
                                 scount = 0
                                 sflag = 0
                                 If Val(sbuff(2)) = 0 Then sbuff(2) = ""
                                 dd$ = Trim$(sbuff(2) + sbuff(3) + sbuff(4))
                                 r% = Len(Trim$(dd$))
                                 inweight = Mid(dd$, 1, r% - 3) + "." + Mid(dd$, r% - 2, 3)
                                data_completed = 1
                            End If
                        End If
                    End If
                End If
        Case comEvSend
            p% = 0
    End Select
End Sub

Private Sub optDestination_Click(Index As Integer)
    L_ResetValues
        
    L_DestTypeArray(L_NewCodeCounter) = Index
    cboSendtype.Enabled = True
    Select Case Index
        Case 0:  '‘Â—Ì
            lblCity.Caption = "‘Â—:"
            cboCountry.Visible = False
            cboCity.Visible = False
            lblCityName.Visible = True
            lblCityName = G_CityName
            lblProvincename.Visible = True
            lblProvince.Visible = True
            txtDestcode = G_CityCode
            txtDestcode.Enabled = False
            lblProvincename = G_ProvinceName
            cboSendtype.ListIndex = 0
            cboSendtype.Enabled = False
        Case 1:    '»Ì‰ ‘Â—Ì
            lblCityName.Visible = False
            cboCity.Visible = True
            lblProvincename.Visible = True
            lblProvince.Visible = True
            cboCountry.Visible = False
            txtDestcode.Enabled = True
            lblCity.Caption = "‘Â—:"
            cboCity.ListIndex = 0
            cboCity_Click
            cboSendtype.ListIndex = 1
        Case 2:    'Œ«—ÃÂ
            lblCityName.Visible = False
            cboCountry.Visible = True
            cboCity.Visible = False
            lblProvincename.Visible = False
            lblProvince.Visible = False
            txtDestcode = cboCountry.ItemData(0)
            txtDestcode.Enabled = True
            lblCity.Caption = "ﬂ‘Ê—"
            cboCountry.ListIndex = 0
            cboCountry_Click
            cboSendtype.ListIndex = 1
    End Select
End Sub

Private Sub optParcelType_Click(Index As Integer)
    L_ResetValues
End Sub

Private Sub optPay_Click(Index As Integer)
    L_ResetValues
End Sub

Private Sub txtDestcode_GotFocus()
    txtDestcode.SelLength = 10
End Sub

Private Sub txtDestcode_LostFocus()
    Dim i As Integer
    
    If L_CboState = 0 Then
        L_CboState = 2
        If optDestination(1).Value = True Then
            cboCity.ListIndex = 0
            
            For i = 0 To cboCity.ListCount - 1
                
                If txtDestcode <> "" Then
                    If cboCity.ItemData(i) = txtDestcode Then
                        If cboCity.List(i) = "" Then
                            cboCity.ListIndex = 0
                        Else
                            'cboCity.Text = cboCity.List(i)
                            cboCity.ListIndex = i
                            lblProvincename = L_provinceArray(i)
                        End If
                        L_CboState = 0
                        cboCity_Click
                        cboCity.SetFocus
                        Exit Sub
                    End If
                End If
            Next i
        ElseIf optDestination(2).Value = True Then    'Œ«—ÃÂ
            For i = 0 To cboCountry.ListCount - 1
                cboCountry.ListIndex = 0
                If txtDestcode <> "" Then
                    If cboCountry.ItemData(i) = txtDestcode Then
                        If cboCountry.List(i) = "" Then
                            cboCountry.ListIndex = 0
                        Else
                            'cboCity.Text = cboCity.List(i)
                            cboCountry.ListIndex = i
                        End If
                        L_CboState = 0
                        cboCountry_Click
                        Exit Sub
                    End If
                End If
            Next i
        End If
        L_CboState = 0
    End If
End Sub

Private Sub txtExpInsur_KeyUp(KeyCode As Integer, Shift As Integer)
    If Val(txtExpInsur.Text) > 0 And IsNumeric(txtExpInsur.Text) And ChkIranInsurance.Value = 1 Then
    Else
        txtExpInsur.Text = ""
    End If
End Sub

Private Sub txtExpInsur_Change()
    L_ResetValues
    If Val(txtExpInsur.Text) > 0 And IsNumeric(txtExpInsur.Text) Then
        If ChkIranInsurance.Value = 1 Then
            L_IranInsuranceArray(L_NewCodeCounter) = cboIranInsurType.ListIndex + 1
        End If
    Else
         If ChkIranInsurance.Value = 1 Then
         End If
         txtExpInsur = ""
         L_IranInsuranceArray(L_NewCodeCounter) = 0
    End If
End Sub

Private Sub txtSoshNumber_Change()
    L_ParcelNumber = Val(txtSoshNumber)
    L_NewCodeCounter = 0
    lblCounter.Caption = "„‘Œ’«  „—”Ê·Â " + Str(L_NewCodeCounter + 1) + " «“ " + Str(L_ParcelNumber)
End Sub

Private Sub txtSoshNumber_LostFocus()
    If Val(txtSoshNumber) > 1000 Then
        G_ShowMsg " ⁄œ«œ „—”Ê·«  Õœ«ﬂÀ— 1000 ⁄œœ „Ìù Ê«‰œ »«‘œ.", vbOKOnly, G_exclamation
        'txtSoshNumber.SetFocus
        Exit Sub
    ElseIf Val(txtSoshNumber) <= 0 Then
        G_ShowMsg " ⁄œ«œ „—”Ê·«  —« œ—”  Ê«—œ ‰„«ÌÌœ.", vbOKOnly, G_exclamation
        'txtSoshNumber.SetFocus
        Exit Sub
    End If
End Sub

Private Sub txtWeight_Change()
    L_ResetValues
End Sub
