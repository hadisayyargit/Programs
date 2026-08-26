VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "tabctl32.ocx"
Begin VB.Form frmTraffic 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "œ› — ⁄„·ﬂ—œ"
   ClientHeight    =   7305
   ClientLeft      =   2190
   ClientTop       =   600
   ClientWidth     =   8190
   Icon            =   "frmTraffic.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   7305
   ScaleWidth      =   8190
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdCurrentDate 
      Caption         =   "—Ê“ Ã«—Ì"
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
      Left            =   3360
      RightToLeft     =   -1  'True
      TabIndex        =   78
      ToolTipText     =   "‰„«Ì‘ «ÿ·«⁄«  —Ê“ Ã«—Ì ”Ì” „"
      Top             =   6840
      Width           =   1455
   End
   Begin TabDlg.SSTab SSTab1 
      Height          =   5535
      Left            =   0
      TabIndex        =   81
      Top             =   0
      Width           =   8175
      _ExtentX        =   14420
      _ExtentY        =   9763
      _Version        =   393216
      Tab             =   2
      TabHeight       =   810
      BackColor       =   10485760
      MouseIcon       =   "frmTraffic.frx":0442
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   "’›ÕÂ ”Ê„"
      TabPicture(0)   =   "frmTraffic.frx":045E
      Tab(0).ControlEnabled=   0   'False
      Tab(0).Control(0)=   "Frame1(31)"
      Tab(0).Control(1)=   "Frame1(29)"
      Tab(0).Control(2)=   "Frame1(27)"
      Tab(0).Control(3)=   "Frame1(23)"
      Tab(0).Control(4)=   "Frame1(26)"
      Tab(0).Control(5)=   "Frame1(22)"
      Tab(0).Control(6)=   "Frame1(24)"
      Tab(0).Control(7)=   "Frame1(25)"
      Tab(0).Control(8)=   "Frame1(28)"
      Tab(0).Control(9)=   "Frame1(30)"
      Tab(0).ControlCount=   10
      TabCaption(1)   =   "’›ÕÂ œÊ„"
      TabPicture(1)   =   "frmTraffic.frx":047A
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Frame1(13)"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "Frame1(17)"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).Control(2)=   "Frame1(11)"
      Tab(1).Control(2).Enabled=   0   'False
      Tab(1).Control(3)=   "Frame1(12)"
      Tab(1).Control(3).Enabled=   0   'False
      Tab(1).Control(4)=   "Frame1(15)"
      Tab(1).Control(4).Enabled=   0   'False
      Tab(1).Control(5)=   "Frame1(14)"
      Tab(1).Control(5).Enabled=   0   'False
      Tab(1).Control(6)=   "Frame1(16)"
      Tab(1).Control(6).Enabled=   0   'False
      Tab(1).Control(7)=   "Frame1(20)"
      Tab(1).Control(7).Enabled=   0   'False
      Tab(1).Control(8)=   "Frame1(18)"
      Tab(1).Control(8).Enabled=   0   'False
      Tab(1).Control(9)=   "Frame1(19)"
      Tab(1).Control(9).Enabled=   0   'False
      Tab(1).Control(10)=   "Frame1(21)"
      Tab(1).Control(10).Enabled=   0   'False
      Tab(1).ControlCount=   11
      TabCaption(2)   =   "’›ÕÂ «Ê·"
      TabPicture(2)   =   "frmTraffic.frx":0496
      Tab(2).ControlEnabled=   -1  'True
      Tab(2).Control(0)=   "Frame1(9)"
      Tab(2).Control(0).Enabled=   0   'False
      Tab(2).Control(1)=   "Frame1(8)"
      Tab(2).Control(1).Enabled=   0   'False
      Tab(2).Control(2)=   "Frame1(6)"
      Tab(2).Control(2).Enabled=   0   'False
      Tab(2).Control(3)=   "Frame1(2)"
      Tab(2).Control(3).Enabled=   0   'False
      Tab(2).Control(4)=   "Frame1(3)"
      Tab(2).Control(4).Enabled=   0   'False
      Tab(2).Control(5)=   "Frame1(0)"
      Tab(2).Control(5).Enabled=   0   'False
      Tab(2).Control(6)=   "Frame1(1)"
      Tab(2).Control(6).Enabled=   0   'False
      Tab(2).Control(7)=   "Frame1(5)"
      Tab(2).Control(7).Enabled=   0   'False
      Tab(2).Control(8)=   "Frame1(7)"
      Tab(2).Control(8).Enabled=   0   'False
      Tab(2).Control(9)=   "Frame1(4)"
      Tab(2).Control(9).Enabled=   0   'False
      Tab(2).Control(10)=   "Frame1(10)"
      Tab(2).Control(10).Enabled=   0   'False
      Tab(2).ControlCount=   11
      Begin VB.Frame Frame1 
         Caption         =   "Œœ„«  ŒÊœ—Ê∆Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Index           =   13
         Left            =   -69720
         RightToLeft     =   -1  'True
         TabIndex        =   98
         Top             =   3960
         Width           =   2535
         Begin VB.TextBox txtInt 
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
            Index           =   33
            Left            =   1560
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   34
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   34
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   35
            Tag             =   "11"
            Top             =   480
            Width           =   1335
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   30
            Left            =   600
            RightToLeft     =   -1  'True
            TabIndex        =   183
            Top             =   240
            Width           =   360
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   29
            Left            =   1680
            RightToLeft     =   -1  'True
            TabIndex        =   182
            Top             =   240
            Width           =   405
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "¬»Ê‰„«‰"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Index           =   17
         Left            =   -72240
         RightToLeft     =   -1  'True
         TabIndex        =   179
         Top             =   3960
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   41
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   42
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
            DataSource      =   "Data1"
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
            Index           =   42
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   43
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   181
            Top             =   240
            Width           =   360
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   180
            Top             =   240
            Width           =   405
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "„‘Œ’«  ÊÃÊÂ Ê«—Ì“Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   1335
         Index           =   31
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   148
         Top             =   2760
         Width           =   4935
         Begin VB.TextBox txtInt 
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
            Index           =   67
            Left            =   1800
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   67
            Tag             =   "11"
            Top             =   795
            Width           =   1575
         End
         Begin VB.TextBox txtShHavaleh 
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
            MaxLength       =   35
            RightToLeft     =   -1  'True
            TabIndex        =   66
            Top             =   360
            Width           =   3255
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "‘„«—Â Ê  «—ÌŒ ÕÊ«·Â:"
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
            Index           =   49
            Left            =   3375
            RightToLeft     =   -1  'True
            TabIndex        =   150
            Top             =   360
            Width           =   1395
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„‹‹»‹‹·‹€:"
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
            Index           =   50
            Left            =   3720
            RightToLeft     =   -1  'True
            TabIndex        =   149
            Top             =   840
            Width           =   585
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "œ—¬„œ⁄„·Ì« Ì —Ê“Ã«—Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   855
         Index           =   29
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   147
         Top             =   4200
         Width           =   4935
         Begin VB.TextBox txtInt 
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
            Index           =   65
            Left            =   1575
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   69
            Tag             =   "11"
            Top             =   315
            Width           =   1335
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "›—Ê‘ Å«ﬂ "
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   27
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   146
         Top             =   1680
         Width           =   2295
         Begin VB.TextBox txtInt 
            DataSource      =   "Data1"
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
            Index           =   62
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   63
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   61
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   62
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   44
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   178
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   43
            Left            =   480
            RightToLeft     =   -1  'True
            TabIndex        =   177
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "ÕÊ«·Ã«  ﬂÊÅ‰"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   23
         Left            =   -72120
         RightToLeft     =   -1  'True
         TabIndex        =   145
         Top             =   600
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   54
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   57
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   53
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   56
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   40
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   174
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   39
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   173
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "»Ì„Â Â„ê«‰Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   26
         Left            =   -72120
         RightToLeft     =   -1  'True
         TabIndex        =   119
         Top             =   1680
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   59
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   58
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   60
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   59
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   38
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   172
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   37
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   171
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "»” Â »‰œÌ Ê ·›«›"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Index           =   10
         Left            =   2880
         RightToLeft     =   -1  'True
         TabIndex        =   112
         Top             =   3720
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   24
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   22
            Tag             =   "11"
            Top             =   360
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   1200
            RightToLeft     =   -1  'True
            TabIndex        =   113
            Top             =   420
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "’‰œÊﬁ ‘Œ’Ì"
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
         Index           =   4
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   104
         Top             =   2280
         Width           =   2415
         Begin VB.TextBox txtInt 
            DataField       =   "TSank"
            DataSource      =   "Data1"
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
            Index           =   15
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   18
            Tag             =   "14"
            Top             =   480
            Width           =   615
         End
         Begin VB.TextBox txtInt 
            DataField       =   "MSank"
            DataSource      =   "Data1"
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
            Index           =   16
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   19
            Tag             =   "11"
            Top             =   480
            Width           =   855
         End
         Begin VB.TextBox txtInt 
            DataField       =   "TSanB"
            DataSource      =   "Data1"
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
            Index           =   17
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   20
            Tag             =   "14"
            Top             =   840
            Width           =   615
         End
         Begin VB.TextBox txtInt 
            DataField       =   "MSanB"
            DataSource      =   "Data1"
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
            Index           =   18
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   21
            Tag             =   "11"
            Top             =   840
            Width           =   855
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "»“—ê:"
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
            Left            =   1905
            RightToLeft     =   -1  'True
            TabIndex        =   136
            Top             =   885
            Width           =   390
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "ﬂÊçﬂ:"
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
            Left            =   1845
            RightToLeft     =   -1  'True
            TabIndex        =   135
            Top             =   525
            Width           =   450
         End
         Begin VB.Label lblD 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   420
            RightToLeft     =   -1  'True
            TabIndex        =   106
            Top             =   240
            Width           =   375
         End
         Begin VB.Label lblD 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1350
            RightToLeft     =   -1  'True
            TabIndex        =   105
            Top             =   240
            Width           =   435
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "‰ﬁ‘  „»—"
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
         Index           =   7
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   107
         Top             =   600
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   21
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   6
            Top             =   360
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   68
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   7
            Tag             =   "11"
            Top             =   720
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   109
            Top             =   420
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   52
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   108
            Top             =   780
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "‰«„Â Ê „ÿ»Ê⁄ ⁄«œÌ ﬁ»Ê· ‘œÂ"
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
         Index           =   5
         Left            =   2880
         RightToLeft     =   -1  'True
         TabIndex        =   82
         Top             =   4680
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   19
            Left            =   120
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   24
            Tag             =   "14"
            Top             =   240
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1140
            RightToLeft     =   -1  'True
            TabIndex        =   83
            Top             =   300
            Width           =   405
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "«Ê—«ﬁ »Â«œ«—"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2415
         Index           =   1
         Left            =   5520
         RightToLeft     =   -1  'True
         TabIndex        =   117
         Top             =   2280
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   4
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   9
            Tag             =   "11"
            Top             =   840
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   5
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   10
            Tag             =   "11"
            Top             =   1200
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   6
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   11
            Tag             =   "11"
            Top             =   1560
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   7
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   12
            Tag             =   "11"
            Top             =   1920
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   3
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   8
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "ﬂÊÅ‰ —Å‰”:"
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
            Left            =   1260
            RightToLeft     =   -1  'True
            TabIndex        =   129
            Top             =   1965
            Width           =   795
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "¬Ì—Êê—«„ Œ«—ÃÂ:"
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
            Left            =   1260
            RightToLeft     =   -1  'True
            TabIndex        =   128
            Top             =   1605
            Width           =   1050
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "¬Ì—Êê—«„ œ«Œ·Â:"
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
            Left            =   1260
            RightToLeft     =   -1  'True
            TabIndex        =   127
            Top             =   1245
            Width           =   1020
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " „»— Ì«œê«—Ì:"
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
            Left            =   1260
            RightToLeft     =   -1  'True
            TabIndex        =   126
            Top             =   885
            Width           =   885
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " „»— Ã«—Ì:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   125
            Top             =   540
            Width           =   750
         End
         Begin VB.Label lblD 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   540
            RightToLeft     =   -1  'True
            TabIndex        =   118
            Top             =   240
            Width           =   375
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   " —«›Ìﬂ „—”Ê·«  À» Ì œ«Œ·Â ’«œ—Â"
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
         Index           =   0
         Left            =   5520
         RightToLeft     =   -1  'True
         TabIndex        =   116
         Tag             =   "4"
         Top             =   600
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   1
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   1
            Tag             =   "14"
            Top             =   720
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   0
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   0
            Tag             =   "14"
            Top             =   360
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   2
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   2
            Tag             =   "14"
            Top             =   1080
            Width           =   975
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "»” Â ﬂÊçﬂ:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   124
            Top             =   1140
            Width           =   870
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„ÿ»Ê⁄:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   123
            Top             =   765
            Width           =   510
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "‰«„Â:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   122
            Top             =   405
            Width           =   330
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "«„«‰« "
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
         Index           =   3
         Left            =   2880
         RightToLeft     =   -1  'True
         TabIndex        =   114
         Top             =   2280
         Width           =   2415
         Begin VB.TextBox txtInt 
            DataField       =   "TOutAmanat"
            DataSource      =   "Data1"
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
            Index           =   13
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   16
            Tag             =   "14"
            Top             =   840
            Width           =   615
         End
         Begin VB.TextBox txtInt 
            DataField       =   "MInpAmanat"
            DataSource      =   "Data1"
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
            Index           =   12
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   15
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
            DataField       =   "MOutAmanat"
            DataSource      =   "Data1"
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
            Index           =   14
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   17
            Tag             =   "11"
            Top             =   840
            Width           =   975
         End
         Begin VB.TextBox txtInt 
            DataField       =   "TInpAmanat"
            DataSource      =   "Data1"
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
            Index           =   11
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   14
            Tag             =   "14"
            Top             =   480
            Width           =   615
         End
         Begin VB.Label lblD 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1290
            RightToLeft     =   -1  'True
            TabIndex        =   143
            Top             =   255
            Width           =   435
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "Œ«—ÃÂ:"
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
            Left            =   1920
            RightToLeft     =   -1  'True
            TabIndex        =   134
            Top             =   885
            Width           =   465
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "œ«Œ·Â:"
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
            Left            =   1920
            RightToLeft     =   -1  'True
            TabIndex        =   133
            Top             =   525
            Width           =   435
         End
         Begin VB.Label lblD 
            Alignment       =   2  'Center
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   420
            RightToLeft     =   -1  'True
            TabIndex        =   115
            Top             =   240
            Width           =   375
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   " —«›Ìﬂ „—”Ê·«  À» Ì Œ«—ÃÂù’«œ—Â"
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
         Index           =   2
         Left            =   2880
         RightToLeft     =   -1  'True
         TabIndex        =   103
         Top             =   600
         Width           =   2415
         Begin VB.TextBox txtInt 
            DataField       =   "TOutMatboo"
            DataSource      =   "Data1"
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
            Index           =   9
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   4
            Tag             =   "14"
            Top             =   720
            Width           =   975
         End
         Begin VB.TextBox txtInt 
            DataField       =   "TOutBasteh"
            DataSource      =   "Data1"
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
            Index           =   10
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   5
            Tag             =   "14"
            Top             =   1080
            Width           =   975
         End
         Begin VB.TextBox txtInt 
            DataField       =   "TOutNameh"
            DataSource      =   "Data1"
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
            Index           =   8
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   3
            Tag             =   "14"
            Top             =   360
            Width           =   975
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "»” Â ﬂÊçﬂ:"
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
            Left            =   1290
            RightToLeft     =   -1  'True
            TabIndex        =   132
            Top             =   1125
            Width           =   870
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„ÿ»Ê⁄:"
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
            Left            =   1290
            RightToLeft     =   -1  'True
            TabIndex        =   131
            Top             =   765
            Width           =   510
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "‰«„‹‹Â:"
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
            Index           =   8
            Left            =   1290
            RightToLeft     =   -1  'True
            TabIndex        =   130
            Top             =   405
            Width           =   420
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Å”  ÅÌ‘ «“"
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
         Index           =   11
         Left            =   -69720
         RightToLeft     =   -1  'True
         TabIndex        =   100
         Top             =   600
         Width           =   2655
         Begin VB.TextBox txtInt 
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
            Index           =   25
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   26
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   27
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   28
            Tag             =   "14"
            Top             =   840
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   26
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   27
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   28
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   29
            Tag             =   "11"
            Top             =   840
            Width           =   975
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "Œ«—ÃÂ:"
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
            Left            =   1980
            RightToLeft     =   -1  'True
            TabIndex        =   138
            Top             =   1005
            Width           =   465
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "œ«Œ·Â:"
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
            Left            =   2070
            RightToLeft     =   -1  'True
            TabIndex        =   137
            Top             =   525
            Width           =   435
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   600
            RightToLeft     =   -1  'True
            TabIndex        =   102
            Top             =   240
            Width           =   360
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1335
            RightToLeft     =   -1  'True
            TabIndex        =   101
            Top             =   240
            Width           =   405
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Å”   ’ÊÌ—Ì"
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
         Index           =   12
         Left            =   -69720
         RightToLeft     =   -1  'True
         TabIndex        =   99
         Top             =   2280
         Width           =   2655
         Begin VB.TextBox txtInt 
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
            Index           =   31
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   32
            Tag             =   "14"
            Top             =   840
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   29
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   30
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   32
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   33
            Tag             =   "11"
            Top             =   840
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   30
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   31
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   32
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   166
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   31
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   165
            Top             =   240
            Width           =   360
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "Œ«—ÃÂ:"
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
            Left            =   1980
            RightToLeft     =   -1  'True
            TabIndex        =   140
            Top             =   885
            Width           =   465
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "œ«Œ·Â:"
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
            Left            =   2070
            RightToLeft     =   -1  'True
            TabIndex        =   139
            Top             =   525
            Width           =   435
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "›—Ê‘ œ› —çÂ œ«‰‘ê«Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   15
         Left            =   -72240
         RightToLeft     =   -1  'True
         TabIndex        =   97
         Top             =   1800
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   38
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   39
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   37
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   38
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   154
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   153
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "›—Ê‘ ﬂ«— ‰ Ê ﬂÌ”Â M"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   14
         Left            =   -72240
         RightToLeft     =   -1  'True
         TabIndex        =   96
         Top             =   600
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   35
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   36
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   36
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   37
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   152
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   151
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "À»  ‰«„ œ«‰‘ê«Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   16
         Left            =   -72240
         RightToLeft     =   -1  'True
         TabIndex        =   95
         Top             =   2880
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   40
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   41
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   39
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   40
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   156
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   155
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   " «∆ÌœÌÂ  Õ’Ì·Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   20
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   94
         Top             =   2880
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   48
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   49
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
            DataField       =   "Ttahsil"
            DataSource      =   "Data1"
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
            Index           =   47
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   48
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   26
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   162
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   25
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   161
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "«”‰«œ Å“‘ﬂÌ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   18
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   93
         Top             =   600
         Width           =   2175
         Begin VB.TextBox txtInt 
            DataSource      =   "Data1"
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
            Index           =   44
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   45
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   43
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   44
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   22
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   158
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   21
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   157
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "¬»Ê‰„«‰ „—”Ê·« "
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   19
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   92
         Top             =   1800
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   46
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   47
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   45
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   46
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   160
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   23
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   159
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Ê“«—  ﬂ«—"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Index           =   21
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   91
         Top             =   3960
         Width           =   2175
         Begin VB.TextBox txtInt 
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
            Index           =   50
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   51
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.TextBox txtInt 
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
            Index           =   49
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   50
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   28
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   164
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   27
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   163
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "ﬂÌ”Â M"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   22
         Left            =   -69480
         RightToLeft     =   -1  'True
         TabIndex        =   90
         Top             =   600
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   51
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   52
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   52
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   53
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   34
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   168
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   33
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   167
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "çﬂ »Ì„Â"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   24
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   89
         Top             =   600
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   55
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   60
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   56
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   61
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   42
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   176
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   41
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   175
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Å—œ«Œ  ÕﬁÊﬁ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Index           =   25
         Left            =   -69480
         RightToLeft     =   -1  'True
         TabIndex        =   88
         Top             =   1680
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   57
            Left            =   1200
            MaxLength       =   5
            RightToLeft     =   -1  'True
            TabIndex        =   54
            Tag             =   "14"
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox txtInt 
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
            Index           =   58
            Left            =   120
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   55
            Tag             =   "11"
            Top             =   480
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Index           =   36
            Left            =   1395
            RightToLeft     =   -1  'True
            TabIndex        =   170
            Top             =   240
            Width           =   405
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   35
            Left            =   660
            RightToLeft     =   -1  'True
            TabIndex        =   169
            Top             =   240
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "œ—¬„œ —Ê“ Ã«—Ì"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   1335
         Index           =   28
         Left            =   -69600
         RightToLeft     =   -1  'True
         TabIndex        =   87
         Top             =   2760
         Width           =   2295
         Begin VB.TextBox txtInt 
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
            Index           =   64
            Left            =   240
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   65
            Tag             =   "11"
            Top             =   840
            Width           =   1335
         End
         Begin VB.TextBox txtInt 
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
            Index           =   63
            Left            =   240
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   64
            Tag             =   "11"
            Top             =   360
            Width           =   1335
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄ÂœÌ:"
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
            Left            =   1620
            RightToLeft     =   -1  'True
            TabIndex        =   142
            Top             =   885
            Width           =   525
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "‰ﬁœÌ:"
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
            Left            =   1590
            RightToLeft     =   -1  'True
            TabIndex        =   141
            Top             =   405
            Width           =   435
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "„ÿ«·»«  Ê’Ê· ‘œÂ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   855
         Index           =   30
         Left            =   -69600
         RightToLeft     =   -1  'True
         TabIndex        =   86
         Top             =   4200
         Width           =   2295
         Begin VB.TextBox txtInt 
            DataSource      =   "Data1"
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
            Index           =   66
            Left            =   840
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   68
            Tag             =   "11"
            Text            =   " "
            Top             =   315
            Width           =   1215
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "„‘ —ﬂÌ‰  „»— Ã–» ‘œÂ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Index           =   6
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   84
         Top             =   3720
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   20
            Left            =   240
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   23
            Tag             =   "14"
            Top             =   360
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   " ⁄œ«œ:"
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
            Left            =   1380
            RightToLeft     =   -1  'True
            TabIndex        =   85
            Top             =   405
            Width           =   405
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "ﬂ”—  „»—"
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
         Index           =   8
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   110
         Top             =   4680
         Width           =   2415
         Begin VB.TextBox txtInt 
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
            Index           =   22
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   25
            Tag             =   "11"
            Top             =   240
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Index           =   8
            Left            =   1320
            RightToLeft     =   -1  'True
            TabIndex        =   111
            Top             =   300
            Width           =   360
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "Ìﬂ œ—’œ Õﬁ »Ì„Â"
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
         Index           =   9
         Left            =   5520
         RightToLeft     =   -1  'True
         TabIndex        =   120
         Top             =   4680
         Width           =   2415
         Begin VB.TextBox txtInt 
            BeginProperty Font 
               Name            =   "Tahoma"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   315
            Index           =   23
            Left            =   240
            MaxLength       =   7
            RightToLeft     =   -1  'True
            TabIndex        =   13
            Tag             =   "11"
            Top             =   240
            Width           =   975
         End
         Begin VB.Label lblD 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "„»·€:"
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
            Left            =   1305
            RightToLeft     =   -1  'True
            TabIndex        =   121
            Top             =   285
            Width           =   360
         End
      End
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "«÷«›Â"
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
      Left            =   6480
      Style           =   1  'Graphical
      TabIndex        =   71
      Top             =   6360
      Width           =   1455
   End
   Begin VB.CommandButton cmdEdit 
      Caption         =   "«’·«Õ"
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
      Left            =   4920
      Style           =   1  'Graphical
      TabIndex        =   72
      Top             =   6360
      Width           =   1455
   End
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "À» "
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
      Left            =   3360
      Style           =   1  'Graphical
      TabIndex        =   73
      ToolTipText     =   "–ŒÌ—Â «ÿ·«⁄«  Ã«—Ì"
      Top             =   6360
      Width           =   1455
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "«‰’—«›"
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
      Left            =   1800
      Style           =   1  'Graphical
      TabIndex        =   74
      Top             =   6360
      Width           =   1455
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "Õ–›"
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
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   75
      ToolTipText     =   "Õ–› «ÿ·«⁄«  Ã«—Ì"
      Top             =   6360
      Width           =   1455
   End
   Begin VB.CommandButton cmdPrevious 
      Caption         =   "—Ê“ ﬁ»·"
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
      Left            =   6480
      Style           =   1  'Graphical
      TabIndex        =   76
      ToolTipText     =   "‰„«Ì‘ «ÿ·«⁄«  —Ê“ ﬁ»·"
      Top             =   6840
      Width           =   1455
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "—Ê“ »⁄œ"
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
      Left            =   4920
      Style           =   1  'Graphical
      TabIndex        =   77
      ToolTipText     =   "‰„«Ì‘ «ÿ·«⁄«  —Ê“ »⁄œ"
      Top             =   6840
      Width           =   1455
   End
   Begin VB.CommandButton cmdSearch 
      Caption         =   "Ã” ÃÊ"
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
      Left            =   1800
      Style           =   1  'Graphical
      TabIndex        =   79
      Top             =   6840
      Width           =   1455
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "»«“ê‘ "
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
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   80
      ToolTipText     =   "»«“ê‘  »Â ’›ÕÂ «’·Ì"
      Top             =   6840
      Width           =   1455
   End
   Begin VB.TextBox txtTarikh 
      BackColor       =   &H00E0E0E0&
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
      Height          =   315
      Left            =   5520
      Locked          =   -1  'True
      MaxLength       =   10
      RightToLeft     =   -1  'True
      TabIndex        =   70
      Top             =   5760
      Width           =   1335
   End
   Begin VB.Label lblInfo 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "«ÿ·«⁄«   «—ÌŒ:"
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
      Left            =   6930
      RightToLeft     =   -1  'True
      TabIndex        =   144
      Top             =   5820
      Width           =   975
   End
End
Attribute VB_Name = "frmTraffic"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim L_EmptyRecord As Boolean
Dim L_Nimehmah As String
Dim L_strXmlInstruction As String
Dim L_strMDate As String
Dim L_bResult As Boolean

Sub L_PrimaryMoveComplete()
    On Error GoTo Err_label
     
    G_PrgMod = G_NormalMod
    Call G_BoxesEmpty(Me)
    If G_PrimaryRs.RecordCount > 0 And L_EmptyRecord = False Then
        With G_PrimaryRs
            txtTarikh.Text = !tarikh
            L_strMDate = G_Miladi(txtTarikh.Text)
            If Not IsNull(!NimehMah) Then L_Nimehmah = !NimehMah
            If Not IsNull(!TInpNameh) Then txtInt(0).Text = !TInpNameh
            If Not IsNull(!TInpMatboo) Then txtInt(1).Text = !TInpMatboo
            If Not IsNull(!TInpBasteh) Then txtInt(2).Text = !TInpBasteh
            If Not IsNull(!Mjari) Then txtInt(3).Text = !Mjari
            If Not IsNull(!MYadegari) Then txtInt(4).Text = !MYadegari
            If Not IsNull(!MIrogd) Then txtInt(5).Text = !MIrogd
            If Not IsNull(!MIrogk) Then txtInt(6).Text = !MIrogk
            If Not IsNull(!MReponse) Then txtInt(7).Text = !MReponse
            If Not IsNull(!TOutNameh) Then txtInt(8).Text = !TOutNameh
            If Not IsNull(!TOutMatboo) Then txtInt(9).Text = !TOutMatboo
            If Not IsNull(!TOutBasteh) Then txtInt(10).Text = !TOutBasteh
            If Not IsNull(!TInpAmanat) Then txtInt(11).Text = !TInpAmanat
            If Not IsNull(!MInpAmanat) Then txtInt(12).Text = !MInpAmanat
            If Not IsNull(!TOutAmanat) Then txtInt(13).Text = !TOutAmanat
            If Not IsNull(!MOutAmanat) Then txtInt(14).Text = !MOutAmanat
            If Not IsNull(!TSanK) Then txtInt(15).Text = !TSanK
            If Not IsNull(!MSanK) Then txtInt(16).Text = !MSanK
            If Not IsNull(!TSanB) Then txtInt(17).Text = !TSanB
            If Not IsNull(!MSanB) Then txtInt(18).Text = !MSanB
            If Not IsNull(!NamehMatboo) Then txtInt(19).Text = !NamehMatboo
            If Not IsNull(!TMoshtarek) Then txtInt(20).Text = !TMoshtarek
            If Not IsNull(!TNaghsh) Then txtInt(21).Text = !TNaghsh
            If Not IsNull(!MNaghsh) Then txtInt(68).Text = !MNaghsh
            If Not IsNull(!MKasr) Then txtInt(22).Text = !MKasr
            If Not IsNull(!MBimeh) Then txtInt(23).Text = !MBimeh
            If Not IsNull(!MBastehLafaf) Then txtInt(24).Text = !MBastehLafaf
            If Not IsNull(!TInpPishtaz) Then txtInt(25).Text = !TInpPishtaz
            If Not IsNull(!MInpPishtaz) Then txtInt(26).Text = !MInpPishtaz
            If Not IsNull(!TOutPishtaz) Then txtInt(27).Text = !TOutPishtaz
            If Not IsNull(!MOutPishtaz) Then txtInt(28).Text = !MOutPishtaz
            If Not IsNull(!TInpTasviri) Then txtInt(29).Text = !TInpTasviri
            If Not IsNull(!MInpTasviri) Then txtInt(30).Text = !MInpTasviri
            If Not IsNull(!TOutTasviri) Then txtInt(31).Text = !TOutTasviri
            If Not IsNull(!MOutTasviri) Then txtInt(32).Text = !MOutTasviri
            If Not IsNull(!TKhodro) Then txtInt(33).Text = !TKhodro
            If Not IsNull(!MKhodro) Then txtInt(34).Text = !MKhodro
            If Not IsNull(!TKarton) Then txtInt(35).Text = !TKarton
            If Not IsNull(!MKarton) Then txtInt(36).Text = !MKarton
            If Not IsNull(!TDaftar) Then txtInt(37).Text = !TDaftar
            If Not IsNull(!MDaftar) Then txtInt(38).Text = !MDaftar
            If Not IsNull(!TSabt) Then txtInt(39).Text = !TSabt
            If Not IsNull(!MSabt) Then txtInt(40).Text = !MSabt
            If Not IsNull(!TAboon) Then txtInt(41).Text = !TAboon
            If Not IsNull(!MAboon) Then txtInt(42).Text = !MAboon
            If Not IsNull(!TAsanad) Then txtInt(43).Text = !TAsanad
            If Not IsNull(!MAsnad) Then txtInt(44).Text = !MAsnad
            If Not IsNull(!TabMar) Then txtInt(45).Text = !TabMar
            If Not IsNull(!MabMar) Then txtInt(46).Text = !MabMar
            If Not IsNull(!Ttahsil) Then txtInt(47).Text = !Ttahsil
            If Not IsNull(!Mtahsil) Then txtInt(48).Text = !Mtahsil
            If Not IsNull(!Tkar) Then txtInt(49).Text = !Tkar
            If Not IsNull(!Mkar) Then txtInt(50).Text = !Mkar
            If Not IsNull(!Tkm) Then txtInt(51).Text = !Tkm
            If Not IsNull(!Mkm) Then txtInt(52).Text = !Mkm
            If Not IsNull(!TCopon) Then txtInt(53).Text = !TCopon
            If Not IsNull(!MCopon) Then txtInt(54).Text = !MCopon
            If Not IsNull(!TCheck) Then txtInt(55).Text = !TCheck
            If Not IsNull(!MCheck) Then txtInt(56).Text = !MCheck
            If Not IsNull(!TPardakht) Then txtInt(57).Text = !TPardakht
            If Not IsNull(!MPardakht) Then txtInt(58).Text = !MPardakht
            If Not IsNull(!TBimeh) Then txtInt(59).Text = !TBimeh
            If Not IsNull(!MBimehH) Then txtInt(60).Text = !MBimehH
            If Not IsNull(!TPacket) Then txtInt(61).Text = !TPacket
            If Not IsNull(!MPacket) Then txtInt(62).Text = !MPacket
            If Not IsNull(!Naghdi) Then txtInt(63).Text = !Naghdi
            If Not IsNull(!Taahodi) Then txtInt(64).Text = !Taahodi
            If Not IsNull(!Amaliati) Then txtInt(65).Text = !Amaliati
            If Not IsNull(!Motalebat) Then txtInt(66).Text = !Motalebat
            If Not IsNull(!shHavaleh) Then txtShHavaleh.Text = !shHavaleh
            If Not IsNull(!MHavaleh) Then txtInt(67).Text = !MHavaleh

        End With

'        For i = 2 To 68
'            If Not IsNull(G_PrimaryRs.Fields(i)) Then
'                Txtint(i - 2).Text = G_PrimaryRs.Fields(i)
'            Else
'                Txtint(i - 2).Text = ""
'            End If
'        Next
        G_BookMark = G_PrimaryRs.Bookmark
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
        cmdAdd.Enabled = False
'        cmdNext.Enabled = True
'        cmdPrevious.Enabled = True
    Else
        
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        cmdAdd.Enabled = True
        If G_PrimaryRs.RecordCount = 0 Then
            Call G_ShowMsg("ÃœÊ· «ÿ·«⁄«  Œ«·Ì «” ", vbOKOnly, G_exclamation)
            'txtTarikh = Date
            'txtTarikh = "1379/10/01"
            'txtTarikh.Text = G_FDate()
'            cmdNext.Enabled = False
'            cmdPrevious.Enabled = False
        End If
    End If
    Exit Sub
    
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub cmdCancel_Click()
    On Error GoTo Err_label
    Dim flag1 As Boolean
    
    Call G_SetBoxesLock(Me, True)
    If G_PrgMod = G_EditMod Then
        flag1 = True
        G_PrimaryRs.CancelUpdate
    Else
    End If
    
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
    G_PrgMod = G_NormalMod
    Call L_PrimaryMoveComplete
    
    If flag1 = True Then cmdAdd.Enabled = False

    Exit Sub
    
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
    'If Err.Number = 3021 Then
    'End If
End Sub

Private Sub cmdCurrentDate_Click()
    txtTarikh.Text = G_CurrentDate
    If G_PrimaryRs.RecordCount = 0 Then
        Call L_PrimaryMoveComplete
        Exit Sub
    End If
    G_BookMark = G_PrimaryRs.Bookmark
    If L_EmptyRecord = False Or (L_EmptyRecord = True And txtTarikh > G_PrimaryRs!tarikh) Then
        G_PrimaryRs.MoveNext
    End If
    
    If G_PrimaryRs.EOF Then
        L_EmptyRecord = True
        cmdAdd.Enabled = False
        G_PrimaryRs.Bookmark = G_BookMark
        Call L_PrimaryMoveComplete
        Exit Sub
    Else
        cmdAdd.Enabled = True
    End If
    
    If G_PrimaryRs!tarikh = txtTarikh Then
        L_EmptyRecord = False
    Else
        L_EmptyRecord = True
        G_PrimaryRs.Bookmark = G_BookMark
    End If
    Call L_PrimaryMoveComplete
End Sub

Private Sub cmdDelete_Click()
    On Error GoTo Err_label
    Dim strReportDate As String
    
    G_PrgMod = G_DeleteMod
    Call G_ShowMsg("«ÿ·«⁄«  —ﬂÊ—œ Õ–› „Ìù‘Êœ. ⁄„·Ì«  —« «œ„Â „ÌùœÂÌœø", vbYesNoCancel, G_question)
    
    If G_MsgButton = vbYes Then
        strReportDate = G_FormatDate(CDate(L_strMDate))
        G_AdoConn.Execute "delete * from tblTraffic where tarikh='" + txtTarikh.Text + "'"
        L_strXmlInstruction = "<PrimaryKey REPORT_DATE=""" + strReportDate + """ />"
        L_bResult = G_InsertToReplicationOutbox("POSTOFFICE_REPORT", "D", L_strXmlInstruction)
        G_PrimaryRs.Requery
        Call L_PrimaryMoveComplete
    End If
    Exit Sub
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub cmdSearch_Click()
    G_SearchFlag = 3
    frmSearch.Show 1
End Sub

Private Sub cmdUpdate_Click()
    On Error GoTo Err_label
    Dim strReportDate As String
    
    Call G_SetBoxesLock(Me, True)
    L_strMDate = G_Miladi(txtTarikh.Text)
    strReportDate = G_FormatDate(CDate(L_strMDate))

    If G_PrgMod = G_EditMod Then
        G_BookMark = G_PrimaryRs.Bookmark
        'G_PrimaryRs.Close
        G_MyQuery = "UPDATE tblTraffic" _
                        + " SET NimehMah = " + Trim(str(Val(L_Nimehmah))) + ",TInpNameh =" + Trim(str(Val(txtInt(0).Text))) + ", TInpMatboo =" + Trim(str(Val(txtInt(1).Text))) _
                        + " ,TInpBasteh = " + Trim(str(Val(txtInt(2).Text))) + ", Mjari =" + Trim(str(Val(txtInt(3).Text))) + ", MYadegari =" + Trim(str(Val(txtInt(4).Text))) + ", MIrogd =" + Trim(str(Val(txtInt(5).Text))) _
                        + " ,MIrogk = " + Trim(str(Val(txtInt(6).Text))) + ", MReponse =" + Trim(str(Val(txtInt(7).Text))) + ", TOutNameh =" + Trim(str(Val(txtInt(8).Text))) _
                        + " ,TOutMatboo = " + Trim(str(Val(txtInt(9).Text))) + ", TOutBasteh =" + Trim(str(Val(txtInt(10).Text))) + ", TInpAmanat =" + Trim(str(Val(txtInt(11).Text))) _
                        + " ,MInpAmanat = " + Trim(str(Val(txtInt(12).Text))) + ", TOutAmanat =" + Trim(str(Val(txtInt(13).Text))) + ", MOutAmanat =" + Trim(str(Val(txtInt(14).Text))) _
                        + " ,TSanK =" + Trim(str(Val(txtInt(15).Text))) + ", MSanK = " + Trim(str(Val(txtInt(16).Text))) + ", TSanB =" + Trim(str(Val(txtInt(17).Text))) _
                        + " ,MSanB = " + Trim(str(Val(txtInt(18).Text))) + ",NamehMatboo =" + Trim(str(Val(txtInt(19).Text))) + ", TMoshtarek = " + Trim(str(Val(txtInt(20).Text))) _
                        + " ,TNaghsh =" + Trim(str(Val(txtInt(21).Text))) + " ,MNaghsh =" + Trim(str(Val(txtInt(68).Text))) + ", Mkasr = " + Trim(str(Val(txtInt(22).Text))) + ", MBimeh =" + Trim(str(Val(txtInt(23).Text))) _
                        + " ,MBastehLafaf =" + Trim(str(Val(txtInt(24).Text))) + ", TInpPishtaz = " + Trim(str(Val(txtInt(25).Text))) + ", MInpPishtaz = " + Trim(str(Val(txtInt(26).Text))) _
                        + " ,TOutPishtaz =" + Trim(str(Val(txtInt(27).Text))) + ", MOutPishtaz =" + Trim(str(Val(txtInt(28).Text))) + ", TInpTasviri =" + Trim(str(Val(txtInt(29).Text))) _
                        + " ,MInpTasviri =" + Trim(str(Val(txtInt(30).Text))) + ", TOutTasviri =" + Trim(str(Val(txtInt(31).Text))) + ", MOutTasviri = " + Trim(str(Val(txtInt(32).Text))) _
                        + " ,Tkhodro = " + Trim(str(Val(txtInt(33).Text))) + ", Mkhodro = " + Trim(str(Val(txtInt(34).Text))) + ", Tkarton = " + Trim(str(Val(txtInt(35).Text))) _
                        + " ,Mkarton = " + Trim(str(Val(txtInt(36).Text))) + ", TDaftar = " + Trim(str(Val(txtInt(37).Text))) + ", MDaftar =" + Trim(str(Val(txtInt(38).Text))) _
                        + " ,TSabt = " + Trim(str(Val(txtInt(39).Text))) + ", MSabt = " + Trim(str(Val(txtInt(40).Text))) + ", TAboon = " + Trim(str(Val(txtInt(41).Text))) _
                        + " ,MAboon = " + Trim(str(Val(txtInt(42).Text))) + ", TAsanad = " + Trim(str(Val(txtInt(43).Text))) + ", MAsnad = " + Trim(str(Val(txtInt(44).Text))) _
                        + " ,TabMar = " + Trim(str(Val(txtInt(45).Text))) + ", MabMar = " + Trim(str(Val(txtInt(46).Text))) + ", Ttahsil = " + Trim(str(Val(txtInt(47).Text))) _
                        + " ,Mtahsil = " + Trim(str(Val(txtInt(48).Text))) + ", Tkar = " + Trim(str(Val(txtInt(49).Text))) + ", Mkar = " + Trim(str(Val(txtInt(50).Text))) _
                        + " ,Tkm = " + Trim(str(Val(txtInt(51).Text))) + ", Mkm = " + Trim(str(Val(txtInt(52).Text))) + ", TCopon = " + Trim(str(Val(txtInt(53).Text))) _
                        + " ,MCopon = " + Trim(str(Val(txtInt(54).Text))) + ", TCheck = " + Trim(str(Val(txtInt(55).Text))) + ", MCheck =" + Trim(str(Val(txtInt(56).Text))) _
                        + " ,TPardakht =" + Trim(str(Val(txtInt(57).Text))) + ", MPardakht = " + Trim(str(Val(txtInt(58).Text))) + ", TBimeh = " + Trim(str(Val(txtInt(59).Text))) _
                        + " ,MBimehH = " + Trim(str(Val(txtInt(60).Text))) + ", TPacket = " + Trim(str(Val(txtInt(61).Text))) + ", MPacket =" + Trim(str(Val(txtInt(62).Text))) _
                        + " ,Naghdi = " + Trim(str(Val(txtInt(63).Text))) + ", Taahodi = " + Trim(str(Val(txtInt(64).Text))) + ", Amaliati = " + Trim(str(Val(txtInt(65).Text))) _
                        + " ,Motalebat = " + Trim(str(Val(txtInt(66).Text))) + ", ShHavaleh ='" + txtShHavaleh.Text + "', MHavaleh =" + Trim(str(Val(txtInt(67).Text))) _
                    + " Where tarikh ='" + txtTarikh.Text + "'"
      
        L_strXmlInstruction = "<RowData REPORT_DATE=""" + strReportDate + """ TInpNameh=""" + Trim(str(Val(txtInt(0).Text))) + """ TInpMatboo=""" + Trim(str(Val(txtInt(1).Text))) _
        + """ TInpBasteh=""" + Trim(str(Val(txtInt(2).Text))) + """ TOutNameh=""" + Trim(str(Val(txtInt(8).Text))) + """ TOutMatboo=""" + Trim(str(Val(txtInt(9).Text))) + """ TOutBasteh=""" + Trim(str(Val(txtInt(10).Text))) _
        + """ NamehMatboo=""" + Trim(str(Val(txtInt(19).Text))) + """ TMoshtarek=""" + Trim(str(Val(txtInt(20).Text))) + """ Mjari=""" + Trim(str(Val(txtInt(3).Text))) _
        + """ MYadegari=""" + Trim(str(Val(txtInt(4).Text))) + """ MIrogd=""" + Trim(str(Val(txtInt(5).Text))) + """ MIrogk=""" + Trim(str(Val(txtInt(6).Text))) _
        + """ MReponse=""" + Trim(str(Val(txtInt(7).Text))) + """ TNaghsh=""" + Trim(str(Val(txtInt(21).Text))) + """ MNaghsh=""" + Trim(str(Val(txtInt(68).Text))) _
        + """ Mkasr=""" + Trim(str(Val(txtInt(22).Text))) + """ TInpAmanat=""" + Trim(str(Val(txtInt(11).Text))) + """ MInpAmanat=""" + Trim(str(Val(txtInt(12).Text))) _
        + """ TOutAmanat=""" + Trim(str(Val(txtInt(13).Text))) + """ MOutAmanat=""" + Trim(str(Val(txtInt(14).Text))) + """ MBimeh=""" + Trim(str(Val(txtInt(23).Text))) _
        + """ MBastehLafaf=""" + Trim(str(Val(txtInt(24).Text))) + """ TSank=""" + Trim(str(Val(txtInt(15).Text))) + """ MSank=""" + Trim(str(Val(txtInt(16).Text))) _
        + """ TSanB=""" + Trim(str(Val(txtInt(17).Text))) + """ MSanB=""" + Trim(str(Val(txtInt(18).Text))) + """ TInpPishtaz=""" + Trim(str(Val(txtInt(25).Text))) _
        + """ MInpPishtaz=""" + Trim(str(Val(txtInt(26).Text))) + """ TOutPishtaz=""" + Trim(str(Val(txtInt(27).Text))) + """ MOutPishtaz=""" + Trim(str(Val(txtInt(28).Text))) _
        + """ Tkhodro=""" + Trim(str(Val(txtInt(33).Text))) + """ Mkhodro=""" + Trim(str(Val(txtInt(34).Text))) + """ TInpTasviri=""" + Trim(str(Val(txtInt(29).Text))) _
        + """ MInpTasviri=""" + Trim(str(Val(txtInt(30).Text))) + """ TOutTasviri=""" + Trim(str(Val(txtInt(31).Text))) + """ MOutTasviri=""" + Trim(str(Val(txtInt(32).Text))) _
        + """ Tkarton=""" + Trim(str(Val(txtInt(35).Text))) + """ Mkarton=""" + Trim(str(Val(txtInt(36).Text))) + """ TDaftar=""" + Trim(str(Val(txtInt(37).Text))) _
        + """ MDaftar=""" + Trim(str(Val(txtInt(38).Text))) + """ TSabt=""" + Trim(str(Val(txtInt(39).Text))) + """ MSabt=""" + Trim(str(Val(txtInt(40).Text))) _
        + """ TAboon=""" + Trim(str(Val(txtInt(41).Text))) + """ MAboon=""" + Trim(str(Val(txtInt(42).Text))) + """ TAsanad=""" + Trim(str(Val(txtInt(43).Text))) _
        + """ MAsnad=""" + Trim(str(Val(txtInt(44).Text))) + """ TabMar=""" + Trim(str(Val(txtInt(45).Text))) + """ MabMar=""" + Trim(str(Val(txtInt(46).Text))) _
        + """ Ttahsil=""" + Trim(str(Val(txtInt(47).Text))) + """ MTahsil=""" + Trim(str(Val(txtInt(48).Text))) + """ Tkar=""" + Trim(str(Val(txtInt(49).Text))) _
        + """ Mkar=""" + Trim(str(Val(txtInt(50).Text))) + """ Tkm=""" + Trim(str(Val(txtInt(51).Text))) + """ Mkm=""" + Trim(str(Val(txtInt(52).Text))) _
        + """ TCopon=""" + Trim(str(Val(txtInt(53).Text))) + """ MCopon=""" + Trim(str(Val(txtInt(54).Text))) + """ TCheck=""" + Trim(str(Val(txtInt(55).Text))) _
        + """ MCheck=""" + Trim(str(Val(txtInt(56).Text))) + """ TPardakht=""" + Trim(str(Val(txtInt(57).Text))) + """ MPardakht=""" + Trim(str(Val(txtInt(58).Text))) _
        + """ TBimeh=""" + Trim(str(Val(txtInt(59).Text))) + """ MBimehH=""" + Trim(str(Val(txtInt(60).Text))) + """ TPacket=""" + Trim(str(Val(txtInt(61).Text))) _
        + """ MPacket=""" + Trim(str(Val(txtInt(62).Text))) + """ Naghdi=""" + Trim(str(Val(txtInt(63).Text))) + """ Taahodi=""" + Trim(str(Val(txtInt(64).Text))) _
        + """ Amaliati=""" + Trim(str(Val(txtInt(65).Text))) + """ Motalebat=""" + Trim(str(Val(txtInt(66).Text))) + """ ShHavaleh=""" + Trim(txtShHavaleh.Text) _
        + """ MHavaleh=""" + Trim(str(Val(txtInt(67).Text))) + """ />" _
        + "<PrimaryKey REPORT_DATE=""" + strReportDate + """ />"
    ElseIf G_PrgMod = G_AddMod Then
        G_MyQuery = "Insert into tblTraffic " + _
                "(Tarikh,REPORT_DATE , NimehMah , TInpNameh , TInpMatboo , TInpBasteh , Mjari , MYadegari , MIrogd , MIrogk , MReponse" + _
                ",TOutNameh , TOutMatboo, TOutBasteh, TInpAmanat, MInpAmanat, TOutAmanat, MOutAmanat" + _
                ",TSanK,MSanK , TSanB , MSanB , NamehMatboo , TMoshtarek , TNaghsh ,MNaghsh, MKasr , MBimeh , MBastehLafaf" + _
                ",TInpPishtaz , MInpPishtaz , TOutPishtaz  , MOutPishtaz , TInpTasviri , MInpTasviri , TOutTasviri , MOutTasviri" + _
                ",TKhodro , MKhodro , TKarton , MKarton , TDaftar ,  MDaftar , TSabt , MSabt , TAboon , MAboon , TAsanad , MAsnad" + _
                ",TabMar , MabMar , Ttahsil , Mtahsil , Tkar , Mkar , Tkm , Mkm , TCopon , MCopon , TCheck , MCheck , TPardakht , MPardakht" + _
                ",TBimeh , MBimehH , TPacket , MPacket , Naghdi , Taahodi , Amaliati , Motalebat , shHavaleh , MHavaleh)" + _
                " Values('" + txtTarikh.Text + "','" + L_strMDate + "'," + Trim(str(Val(L_Nimehmah))) + "," + Trim(str(Val(txtInt(0).Text))) + "," + Trim(str(Val(txtInt(1).Text))) + "," + Trim(str(Val(txtInt(2).Text))) + "," + Trim(str(Val(txtInt(3).Text))) + "," + Trim(str(Val(txtInt(4).Text))) + "," + Trim(str(Val(txtInt(5).Text))) + _
                "," + Trim(str(Val(txtInt(6).Text))) + "," + Trim(str(Val(txtInt(7).Text))) + "," + Trim(str(Val(txtInt(8).Text))) + "," + Trim(str(Val(txtInt(9).Text))) + "," + Trim(str(Val(txtInt(10).Text))) + "," + Trim(str(Val(txtInt(11).Text))) + "," + Trim(str(Val(txtInt(12).Text))) + _
                "," + Trim(str(Val(txtInt(13).Text))) + "," + Trim(str(Val(txtInt(14).Text))) + "," + Trim(str(Val(txtInt(15).Text))) + "," + Trim(str(Val(txtInt(16).Text))) + "," + Trim(str(Val(txtInt(17).Text))) + "," + Trim(str(Val(txtInt(18).Text))) + "," + Trim(str(Val(txtInt(19).Text))) + _
                "," + Trim(str(Val(txtInt(20).Text))) + "," + Trim(str(Val(txtInt(21).Text))) + "," + Trim(str(Val(txtInt(68).Text))) + "," + Trim(str(Val(txtInt(22).Text))) + "," + Trim(str(Val(txtInt(23).Text))) + "," + Trim(str(Val(txtInt(24).Text))) + "," + Trim(str(Val(txtInt(25).Text))) + "," + Trim(str(Val(txtInt(26).Text))) + _
                "," + Trim(str(Val(txtInt(27).Text))) + "," + Trim(str(Val(txtInt(28).Text))) + "," + Trim(str(Val(txtInt(29).Text))) + "," + Trim(str(Val(txtInt(30).Text))) + "," + Trim(str(Val(txtInt(31).Text))) + "," + Trim(str(Val(txtInt(32).Text))) + "," + Trim(str(Val(txtInt(33).Text))) + _
                "," + Trim(str(Val(txtInt(34).Text))) + "," + Trim(str(Val(txtInt(35).Text))) + "," + Trim(str(Val(txtInt(36).Text))) + "," + Trim(str(Val(txtInt(37).Text))) + "," + Trim(str(Val(txtInt(38).Text))) + "," + Trim(str(Val(txtInt(39).Text))) + "," + Trim(str(Val(txtInt(40).Text))) + _
                "," + Trim(str(Val(txtInt(41).Text))) + "," + Trim(str(Val(txtInt(42).Text))) + "," + Trim(str(Val(txtInt(43).Text))) + "," + Trim(str(Val(txtInt(44).Text))) + "," + Trim(str(Val(txtInt(45).Text))) + "," + Trim(str(Val(txtInt(46).Text))) + "," + Trim(str(Val(txtInt(47).Text))) + _
                "," + Trim(str(Val(txtInt(48).Text))) + "," + Trim(str(Val(txtInt(49).Text))) + "," + Trim(str(Val(txtInt(50).Text))) + "," + Trim(str(Val(txtInt(51).Text))) + "," + Trim(str(Val(txtInt(52).Text))) + "," + Trim(str(Val(txtInt(53).Text))) + "," + Trim(str(Val(txtInt(54).Text))) + _
                "," + Trim(str(Val(txtInt(55).Text))) + "," + Trim(str(Val(txtInt(56).Text))) + "," + Trim(str(Val(txtInt(57).Text))) + "," + Trim(str(Val(txtInt(58).Text))) + "," + Trim(str(Val(txtInt(59).Text))) + "," + Trim(str(Val(txtInt(60).Text))) + "," + Trim(str(Val(txtInt(61).Text))) + _
                "," + Trim(str(Val(txtInt(62).Text))) + "," + Trim(str(Val(txtInt(63).Text))) + "," + Trim(str(Val(txtInt(64).Text))) + "," + Trim(str(Val(txtInt(65).Text))) + "," + Trim(str(Val(txtInt(66).Text))) + ",'" + txtShHavaleh.Text + "'," + Trim(str(Val(txtInt(67).Text))) + ")"
                
        L_strXmlInstruction = "<RowData REPORT_DATE=""" + strReportDate + """ TInpNameh=""" + Trim(str(Val(txtInt(0).Text))) + """ TInpMatboo=""" + Trim(str(Val(txtInt(1).Text))) _
        + """ TInpBasteh=""" + Trim(str(Val(txtInt(2).Text))) + """ TOutNameh=""" + Trim(str(Val(txtInt(8).Text))) + """ TOutMatboo=""" + Trim(str(Val(txtInt(9).Text))) + """ TOutBasteh=""" + Trim(str(Val(txtInt(10).Text))) _
        + """ NamehMatboo=""" + Trim(str(Val(txtInt(19).Text))) + """ TMoshtarek=""" + Trim(str(Val(txtInt(20).Text))) + """ Mjari=""" + Trim(str(Val(txtInt(3).Text))) _
        + """ MYadegari=""" + Trim(str(Val(txtInt(4).Text))) + """ MIrogd=""" + Trim(str(Val(txtInt(5).Text))) + """ MIrogk=""" + Trim(str(Val(txtInt(6).Text))) _
        + """ MReponse=""" + Trim(str(Val(txtInt(7).Text))) + """ TNaghsh=""" + Trim(str(Val(txtInt(21).Text))) + """ MNaghsh=""" + Trim(str(Val(txtInt(68).Text))) _
        + """ Mkasr=""" + Trim(str(Val(txtInt(22).Text))) + """ TInpAmanat=""" + Trim(str(Val(txtInt(11).Text))) + """ MInpAmanat=""" + Trim(str(Val(txtInt(12).Text))) _
        + """ TOutAmanat=""" + Trim(str(Val(txtInt(13).Text))) + """ MOutAmanat=""" + Trim(str(Val(txtInt(14).Text))) + """ MBimeh=""" + Trim(str(Val(txtInt(23).Text))) _
        + """ MBastehLafaf=""" + Trim(str(Val(txtInt(24).Text))) + """ TSank=""" + Trim(str(Val(txtInt(15).Text))) + """ MSank=""" + Trim(str(Val(txtInt(16).Text))) _
        + """ TSanB=""" + Trim(str(Val(txtInt(17).Text))) + """ MSanB=""" + Trim(str(Val(txtInt(18).Text))) + """ TInpPishtaz=""" + Trim(str(Val(txtInt(25).Text))) _
        + """ MInpPishtaz=""" + Trim(str(Val(txtInt(26).Text))) + """ TOutPishtaz=""" + Trim(str(Val(txtInt(27).Text))) + """ MOutPishtaz=""" + Trim(str(Val(txtInt(28).Text))) _
        + """ Tkhodro=""" + Trim(str(Val(txtInt(33).Text))) + """ Mkhodro=""" + Trim(str(Val(txtInt(34).Text))) + """ TInpTasviri=""" + Trim(str(Val(txtInt(29).Text))) _
        + """ MInpTasviri=""" + Trim(str(Val(txtInt(30).Text))) + """ TOutTasviri=""" + Trim(str(Val(txtInt(31).Text))) + """ MOutTasviri=""" + Trim(str(Val(txtInt(32).Text))) _
        + """ Tkarton=""" + Trim(str(Val(txtInt(35).Text))) + """ Mkarton=""" + Trim(str(Val(txtInt(36).Text))) + """ TDaftar=""" + Trim(str(Val(txtInt(37).Text))) _
        + """ MDaftar=""" + Trim(str(Val(txtInt(38).Text))) + """ TSabt=""" + Trim(str(Val(txtInt(39).Text))) + """ MSabt=""" + Trim(str(Val(txtInt(40).Text))) _
        + """ TAboon=""" + Trim(str(Val(txtInt(41).Text))) + """ MAboon=""" + Trim(str(Val(txtInt(42).Text))) + """ TAsanad=""" + Trim(str(Val(txtInt(43).Text))) _
        + """ MAsnad=""" + Trim(str(Val(txtInt(44).Text))) + """ TabMar=""" + Trim(str(Val(txtInt(45).Text))) + """ MabMar=""" + Trim(str(Val(txtInt(46).Text))) _
        + """ Ttahsil=""" + Trim(str(Val(txtInt(47).Text))) + """ MTahsil=""" + Trim(str(Val(txtInt(48).Text))) + """ Tkar=""" + Trim(str(Val(txtInt(49).Text))) _
        + """ Mkar=""" + Trim(str(Val(txtInt(50).Text))) + """ Tkm=""" + Trim(str(Val(txtInt(51).Text))) + """ Mkm=""" + Trim(str(Val(txtInt(52).Text))) _
        + """ TCopon=""" + Trim(str(Val(txtInt(53).Text))) + """ MCopon=""" + Trim(str(Val(txtInt(54).Text))) + """ TCheck=""" + Trim(str(Val(txtInt(55).Text))) _
        + """ MCheck=""" + Trim(str(Val(txtInt(56).Text))) + """ TPardakht=""" + Trim(str(Val(txtInt(57).Text))) + """ MPardakht=""" + Trim(str(Val(txtInt(58).Text))) _
        + """ TBimeh=""" + Trim(str(Val(txtInt(59).Text))) + """ MBimehH=""" + Trim(str(Val(txtInt(60).Text))) + """ TPacket=""" + Trim(str(Val(txtInt(61).Text))) _
        + """ MPacket=""" + Trim(str(Val(txtInt(62).Text))) + """ Naghdi=""" + Trim(str(Val(txtInt(63).Text))) + """ Taahodi=""" + Trim(str(Val(txtInt(64).Text))) _
        + """ Amaliati=""" + Trim(str(Val(txtInt(65).Text))) + """ Motalebat=""" + Trim(str(Val(txtInt(66).Text))) + """ ShHavaleh=""" + Trim(txtShHavaleh.Text) _
        + """ MHavaleh=""" + Trim(str(Val(txtInt(67).Text))) + """ />"
    End If
    
    G_AdoConn.Execute G_MyQuery
    
    If G_PrgMod = G_EditMod Then
        L_bResult = G_InsertToReplicationOutbox("POSTOFFICE_REPORT", "U", L_strXmlInstruction)
    ElseIf G_PrgMod = G_AddMod Then
        L_bResult = G_InsertToReplicationOutbox("POSTOFFICE_REPORT", "I", L_strXmlInstruction)
    End If
    
    G_PrimaryRs.Requery
    If G_PrgMod = G_EditMod Then
        G_PrimaryRs.Bookmark = G_BookMark
    Else    ' G_AddMod
        G_PrimaryRs.Find "Tarikh='" + txtTarikh.Text + "'"
        L_EmptyRecord = False
    End If
    
    Call L_PrimaryMoveComplete
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
    cmdAdd.Enabled = False
    Exit Sub
    
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub Form_Activate()
    If G_SearchFlag = 3 Then
        L_PrimaryMoveComplete
    End If
End Sub

Private Sub txtInt_GotFocus(Index As Integer)
    txtInt(Index).SelLength = 10
End Sub

Private Sub txtTarikh_Change()
Dim mojvar As String
    If Len(txtTarikh.Text) = 10 Then
        mojvar = Right(txtTarikh.Text, 2)
       If mojvar <= 15 And mojvar >= 1 Then
            L_Nimehmah = "1"
       End If
       If mojvar <= 31 And mojvar >= 16 Then
            L_Nimehmah = "2"
       End If
    End If
End Sub

Private Sub CmdAdd_Click()
    On Error GoTo Err_label
    Call G_SetBoxesLock(Me, False)
    
    G_PrgMod = G_AddMod
    Call G_SetButtons(Me, False)
    Call G_SetFrame(Me, True)
    Call G_BoxesEmpty(Me)
    txtInt(0).SetFocus
    Exit Sub
    
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub cmdEdit_Click()
    On Error GoTo Err_label
    
    Call G_SetBoxesLock(Me, False)
    G_PrgMod = G_EditMod
    Call G_SetButtons(Me, False)
    Call G_SetFrame(Me, True)
    txtInt(0).SetFocus
    Exit Sub
    
Err_label:
    'If Err.Number = 3021 Then
    'End If
End Sub

Private Sub cmdPrevious_Click()
    txtTarikh = G_AddDate(txtTarikh.Text, -1)
    If G_PrimaryRs.RecordCount = 0 Then
        Call L_PrimaryMoveComplete
        Exit Sub
    End If
    
    G_BookMark = G_PrimaryRs.Bookmark
    
    If (L_EmptyRecord = False) Or (L_EmptyRecord = True And txtTarikh < G_PrimaryRs!tarikh) Then
        G_PrimaryRs.MovePrevious
    End If
    If G_PrimaryRs.BOF Then
        L_EmptyRecord = True
        cmdAdd.Enabled = False
        G_PrimaryRs.Bookmark = G_BookMark
        Call L_PrimaryMoveComplete
        'call
        Exit Sub
        Else
            cmdAdd.Enabled = True
    End If
    
    If G_PrimaryRs!tarikh = txtTarikh Then
        L_EmptyRecord = False
    Else
        L_EmptyRecord = True
        G_PrimaryRs.Bookmark = G_BookMark
    End If
    Call L_PrimaryMoveComplete
End Sub

Private Sub cmdNext_Click()
    txtTarikh.Text = G_AddDate(txtTarikh.Text, 1)
    If G_PrimaryRs.RecordCount = 0 Then
        Call L_PrimaryMoveComplete
        Exit Sub
    End If
'    If G_PrgMod = G_DeleteMod Then
'        G_PrimaryRs.MovePrevious
'        If G_PrimaryRs.BOF Then G_PrimaryRs.Requery
'        G_PrimaryRs.MoveFirst
'    End If
    G_BookMark = G_PrimaryRs.Bookmark
    If L_EmptyRecord = False Or (L_EmptyRecord = True And txtTarikh > G_PrimaryRs!tarikh) Then
        G_PrimaryRs.MoveNext
    End If
    
    If G_PrimaryRs.EOF Then
        L_EmptyRecord = True
        cmdAdd.Enabled = False
        G_PrimaryRs.Bookmark = G_BookMark
        Call L_PrimaryMoveComplete
        Exit Sub
    Else
        cmdAdd.Enabled = True
    End If
    
    If G_PrimaryRs!tarikh = txtTarikh Then
        L_EmptyRecord = False
    Else
        L_EmptyRecord = True
        G_PrimaryRs.Bookmark = G_BookMark
    End If
    Call L_PrimaryMoveComplete
End Sub


Private Sub cmdExit_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    Dim a1 As Integer
    
    Call G_SetBoxesLock(Me, True)
' Me.Width = 10410
    G_PrgMod = G_NormalMod
    L_EmptyRecord = False
    G_SearchFlag = 0
    'Â«tag  ‰ŸÌ„
    Dim i As Integer
    For i = 0 To Me.count - 1
        Me.Controls(i).Tag = ""
    Next
    For i = 0 To 31
        Frame1(i).Tag = 6
    Next
    For i = 0 To 68
        txtInt(i).Tag = 1
    Next
    cmdAdd.Tag = 7
    cmdDelete.Tag = 7
    cmdEdit.Tag = 7
    cmdCancel.Tag = 71
    cmdUpdate.Tag = 71
    cmdNext.Tag = 7
    cmdPrevious.Tag = 7
    cmdExit.Tag = 7
    cmdSearch.Tag = 7
    cmdCurrentDate.Tag = 7
    'cmdAdd.Tag = 7
    txtShHavaleh.Tag = 2
    
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
    
    'lblToday = G_FDate()
    lblToday = G_CurrentDate
    txtTarikh.Text = lblToday
    'L_Roz = G_FWeekDay(Weekday(Date))
    
    G_MyQuery = "select * from tblTraffic order by tarikh"
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
    If G_PrimaryRs.RecordCount > 0 Then
        G_PrimaryRs.MoveLast
        cmdCurrentDate_Click
'        G_PrimaryRs.Find "TARIKH= '" & G_CurrentDate & "'"
'        If G_PrimaryRs.EOF Then
'            G_ShowMsg "«ÿ·«⁄«  —Ê“ Ã«—Ì À»  ‰‘œÂ «” .", vbOKOnly, 3
'            G_PrimaryRs.MoveFirst
'        Else
'
'        End If
        L_EmptyRecord = False
    Else
        L_EmptyRecord = True
    End If
    Call L_PrimaryMoveComplete
    'Show 1
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If G_PrimaryRs.State = 1 Then
        G_PrimaryRs.Close
    End If
    G_PrgMod = G_MainformMod
End Sub
