VERSION 5.00
Begin VB.Form frmRegister 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "ê“«—‘ À» "
   ClientHeight    =   6330
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   6795
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   6330
   ScaleWidth      =   6795
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraLias 
      Height          =   6255
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   29
      Top             =   0
      Width           =   6615
      Begin VB.Frame Frame1 
         Caption         =   "„ÕœÊœÂ À» "
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
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   41
         Top             =   120
         Width           =   6375
         Begin VB.TextBox txtFrom 
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
            Height          =   315
            Left            =   2040
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   2
            Tag             =   "1"
            Top             =   660
            Width           =   1095
         End
         Begin VB.TextBox txtTo 
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
            Height          =   315
            Left            =   120
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   3
            Tag             =   "1"
            Top             =   660
            Width           =   1095
         End
         Begin VB.OptionButton optLimit 
            Alignment       =   1  'Right Justify
            Caption         =   "„ÕœÊœ »Â ‘„«—Â ﬁ»÷"
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
            Left            =   4200
            RightToLeft     =   -1  'True
            TabIndex        =   1
            Top             =   720
            Width           =   1935
         End
         Begin VB.OptionButton optLimit 
            Alignment       =   1  'Right Justify
            Caption         =   "ê“Ì‰ÂùÂ«Ì À» "
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
            Left            =   4080
            RightToLeft     =   -1  'True
            TabIndex        =   0
            Top             =   360
            Value           =   -1  'True
            Width           =   2055
         End
         Begin VB.Label lbFrom 
            AutoSize        =   -1  'True
            Caption         =   "«“ ‘„«—Â:"
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
            Height          =   195
            Left            =   3240
            RightToLeft     =   -1  'True
            TabIndex        =   43
            Top             =   720
            Width           =   660
         End
         Begin VB.Label lbTo 
            AutoSize        =   -1  'True
            Caption         =   " « ‘„«—Â:"
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
            Height          =   195
            Left            =   1320
            RightToLeft     =   -1  'True
            TabIndex        =   42
            Top             =   720
            Width           =   645
         End
      End
      Begin VB.Frame fraParcelForm 
         Caption         =   "‘ﬂ· „—”Ê·Â"
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
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   30
         Top             =   1320
         Width           =   6375
         Begin VB.CheckBox chkParcelForm 
            Alignment       =   1  'Right Justify
            Caption         =   "«„«‰  Ê €Ì—Â"
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
            Left            =   2520
            RightToLeft     =   -1  'True
            TabIndex        =   6
            Top             =   360
            Width           =   1335
         End
         Begin VB.CheckBox chkParcelForm 
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
            Left            =   4200
            RightToLeft     =   -1  'True
            TabIndex        =   5
            Top             =   360
            Width           =   735
         End
         Begin VB.CheckBox chkParcelForm 
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
            Left            =   5520
            RightToLeft     =   -1  'True
            TabIndex        =   4
            Top             =   360
            Width           =   615
         End
      End
      Begin VB.Frame fraService 
         Caption         =   "‰Ê⁄ ”—ÊÌ”"
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
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   31
         Top             =   2160
         Width           =   6375
         Begin VB.ComboBox cboGService 
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
            ItemData        =   "frmRegister.frx":0000
            Left            =   2655
            List            =   "frmRegister.frx":0002
            RightToLeft     =   -1  'True
            Style           =   2  'Dropdown List
            TabIndex        =   12
            Top             =   675
            Visible         =   0   'False
            Width           =   1890
         End
         Begin VB.CheckBox chkService 
            Alignment       =   1  'Right Justify
            Caption         =   "⁄«œÌ"
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
            Left            =   5385
            RightToLeft     =   -1  'True
            TabIndex        =   7
            Top             =   375
            Width           =   780
         End
         Begin VB.CheckBox chkService 
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
            Index           =   4
            Left            =   4650
            RightToLeft     =   -1  'True
            TabIndex        =   11
            Top             =   735
            Width           =   1530
         End
         Begin VB.CheckBox chkService 
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
            Index           =   3
            Left            =   540
            RightToLeft     =   -1  'True
            TabIndex        =   10
            Top             =   360
            Width           =   1260
         End
         Begin VB.CheckBox chkService 
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
            Height          =   195
            Index           =   2
            Left            =   2250
            RightToLeft     =   -1  'True
            TabIndex        =   9
            Top             =   360
            Width           =   900
         End
         Begin VB.CheckBox chkService 
            Alignment       =   1  'Right Justify
            Caption         =   "»Ì„Â «—“‘ùœ«—"
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
            Left            =   3330
            RightToLeft     =   -1  'True
            TabIndex        =   8
            Top             =   375
            Width           =   1410
         End
      End
      Begin VB.Frame fraDestination 
         Caption         =   "‰Ê⁄ „ﬁ’œ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2295
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   32
         Top             =   3360
         Width           =   6375
         Begin VB.Frame fraPostType 
            Height          =   525
            Left            =   2805
            RightToLeft     =   -1  'True
            TabIndex        =   38
            Top             =   1680
            Width           =   1905
            Begin VB.OptionButton optPostType 
               Alignment       =   1  'Right Justify
               Caption         =   "ÂÊ«ÌÌ"
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
               Left            =   945
               RightToLeft     =   -1  'True
               TabIndex        =   23
               Top             =   255
               Value           =   -1  'True
               Width           =   855
            End
            Begin VB.OptionButton optPostType 
               Alignment       =   1  'Right Justify
               Caption         =   "“„Ì‰Ì"
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
               Left            =   135
               RightToLeft     =   -1  'True
               TabIndex        =   24
               Top             =   240
               Width           =   825
            End
         End
         Begin VB.OptionButton optDestination 
            Alignment       =   1  'Right Justify
            Caption         =   "«„«‰«  Œ«—ÃÂ"
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
            Left            =   4830
            RightToLeft     =   -1  'True
            TabIndex        =   18
            Top             =   1845
            Width           =   1200
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
            Height          =   195
            Index           =   3
            Left            =   4905
            RightToLeft     =   -1  'True
            TabIndex        =   16
            Top             =   1230
            Width           =   1125
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
            Height          =   195
            Index           =   4
            Left            =   5325
            RightToLeft     =   -1  'True
            TabIndex        =   17
            Top             =   1530
            Width           =   705
         End
         Begin VB.ComboBox cboProvince 
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
            Left            =   3480
            RightToLeft     =   -1  'True
            TabIndex        =   19
            Text            =   "cboProvince"
            Top             =   585
            Visible         =   0   'False
            Width           =   1575
         End
         Begin VB.OptionButton optDestination 
            Alignment       =   1  'Right Justify
            Caption         =   "«” «‰"
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
            Left            =   5235
            RightToLeft     =   -1  'True
            TabIndex        =   14
            Top             =   615
            Width           =   795
         End
         Begin VB.OptionButton optDestination 
            Alignment       =   1  'Right Justify
            Caption         =   "œ«Œ·Â (”—«”— ﬂ‘Ê—)"
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
            Left            =   4215
            RightToLeft     =   -1  'True
            TabIndex        =   13
            Top             =   300
            Value           =   -1  'True
            Width           =   1815
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
            Height          =   195
            Index           =   2
            Left            =   5235
            RightToLeft     =   -1  'True
            TabIndex        =   15
            Top             =   915
            Width           =   795
         End
         Begin VB.Frame fraProvince 
            Height          =   975
            Left            =   240
            RightToLeft     =   -1  'True
            TabIndex        =   37
            Top             =   600
            Visible         =   0   'False
            Width           =   3015
            Begin VB.ComboBox cboCity 
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
               Height          =   315
               Left            =   120
               RightToLeft     =   -1  'True
               TabIndex        =   22
               Text            =   "cboCity"
               Top             =   540
               Width           =   1695
            End
            Begin VB.OptionButton optProvince 
               Alignment       =   1  'Right Justify
               Caption         =   "‘Â—” «‰"
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
               Left            =   1800
               RightToLeft     =   -1  'True
               TabIndex        =   21
               Top             =   600
               Width           =   1095
            End
            Begin VB.OptionButton optProvince 
               Alignment       =   1  'Right Justify
               Caption         =   "ﬂ· «” «‰"
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
               Left            =   1920
               RightToLeft     =   -1  'True
               TabIndex        =   20
               Top             =   240
               Value           =   -1  'True
               Width           =   975
            End
         End
      End
      Begin VB.CommandButton cmdOK 
         Caption         =   " √ÌÌœ"
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
         Left            =   2670
         RightToLeft     =   -1  'True
         TabIndex        =   25
         Top             =   5760
         Width           =   1455
      End
   End
   Begin VB.Frame fraShSabt 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   360
      RightToLeft     =   -1  'True
      TabIndex        =   33
      Top             =   2400
      Visible         =   0   'False
      Width           =   6015
      Begin VB.TextBox txtHeader 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000F&
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
         Locked          =   -1  'True
         RightToLeft     =   -1  'True
         TabIndex        =   40
         Text            =   "Å«ﬂ °»” Â °»Ì„Â °œÊﬁ»÷Â °ﬁ—«—œ«œÌ °Œœ„«  ÊÌéÂ "
         Top             =   240
         Width           =   4785
      End
      Begin VB.TextBox txtParcelCount 
         Alignment       =   1  'Right Justify
         BackColor       =   &H8000000F&
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
         Locked          =   -1  'True
         RightToLeft     =   -1  'True
         TabIndex        =   39
         Top             =   720
         Width           =   945
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
         Left            =   1560
         TabIndex        =   28
         Top             =   1320
         Width           =   1695
      End
      Begin VB.CommandButton cmdPrint 
         Caption         =   "„‘«ÂœÂ ê“«—‘ À» "
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
         TabIndex        =   27
         Top             =   1320
         Width           =   1695
      End
      Begin VB.TextBox txtRegId 
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
         Left            =   4200
         Locked          =   -1  'True
         RightToLeft     =   -1  'True
         TabIndex        =   26
         Tag             =   "1"
         Text            =   " "
         Top             =   720
         Width           =   735
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   " ⁄œ«œ „—”Ê·Â:"
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
         Left            =   1200
         RightToLeft     =   -1  'True
         TabIndex        =   36
         Top             =   780
         Width           =   990
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "⁄‰Ê«‰ À» :"
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
         Left            =   5040
         RightToLeft     =   -1  'True
         TabIndex        =   35
         Top             =   300
         Width           =   750
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "‘„«—Â À» :"
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
         Left            =   5040
         RightToLeft     =   -1  'True
         TabIndex        =   34
         Top             =   780
         Width           =   810
      End
   End
End
Attribute VB_Name = "frmRegister"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim m_strCriteria_ParcelForm As String
Dim m_strCriteria_Destination As String
Dim m_strCriteria_Shipping As String
Dim m_strCriteria_Service As String
Dim m_strCriteria As String
Dim L_strRegHeader(3) As String

Private Sub BuildQuery()
    L_strRegHeader(1) = ""
    L_strRegHeader(2) = ""
    L_strRegHeader(3) = ""
    m_strCriteria_Service = ""
    m_strCriteria = ""
    m_strCriteria_ParcelForm = ""
    m_strCriteria_Shipping = ""
        
    If G_IsEMS = 1 Then       'EMS
        L_strRegHeader(0) = "ÅÌ‘ «“"
    Else
        L_strRegHeader(0) = "”›«—‘Ì"
    End If
    
    
    If (optLimit(0).Value) Then
    
        If chkParcelForm(0).Value = 1 Then
            L_strRegHeader(0) = L_strRegHeader(0) + "° Å«ﬂ "
            m_strCriteria_ParcelForm = "mid(ServiceType,2,1)='0'"    'Å«ﬂ 
        End If
        
        If chkParcelForm(1).Value = 1 Then
            L_strRegHeader(0) = L_strRegHeader(0) + "° »” Â"
            m_strCriteria_ParcelForm = m_strCriteria_ParcelForm + " OR mid(ServiceType,2,1)='1'"  '»” Â
        End If
        
        If chkParcelForm(2).Value = 1 Then
            'L_strRegHeader(0) = L_strRegHeader(0) + "°" + G_ParcelFormList(Val(Mid(ServiceType, 2, 1)))
            L_strRegHeader(0) = L_strRegHeader(0) + "° «„«‰  Ê €Ì—Â"
            m_strCriteria_ParcelForm = m_strCriteria_ParcelForm + " OR (mid(ServiceType,2,1)<>'1' AND mid(ServiceType,2,1)<>'2')"  '»” Â
        End If
        
        If Mid(m_strCriteria_ParcelForm, 1, 4) = " OR " Then m_strCriteria_ParcelForm = Mid(m_strCriteria_ParcelForm, 5)
        
        
        If fraPostType.Visible Then
            If optPostType(0).Value = True Then
                m_strCriteria_Shipping = "mid(ServiceType,4,1)='1'"
                'L_strRegHeader(3) = " ° ÂÊ«ÌÌ"
            Else
                m_strCriteria_Shipping = "mid(ServiceType,4,1)='0'"
                'L_strRegHeader(3) = " ° “„Ì‰Ì"
            End If
        End If
        If optDestination(0).Value = True Then
            m_strCriteria_Destination = "mid(ServiceType,3,1)='0' or mid(ServiceType,3,1)='1'"    'œ«Œ·Â
            L_strRegHeader(1) = "° œ«Œ·Â"
        ElseIf optDestination(2).Value = True Then
            m_strCriteria_Destination = "mid(ServiceType,3,1)='0'"    '‘Â—Ì
            L_strRegHeader(1) = "° ‘Â—Ì"
        ElseIf optDestination(3).Value = True Then
            m_strCriteria_Destination = "mid(ServiceType,3,1)='1'"    '»Ì‰ ‘Â—Ì
            L_strRegHeader(1) = "° »Ì‰ ‘Â—Ì"
        ElseIf optDestination(4).Value = True Then
            m_strCriteria_Destination = "mid(ServiceType,3,1)='2'"    'Œ«—ÃÂ
            L_strRegHeader(1) = "° Œ«—ÃÂ"
        ElseIf optDestination(5).Value = True Then
            m_strCriteria_Destination = "mid(ServiceType,3,1)='2' and mid(ServiceType,2,1)='3'"     '«„«‰  Œ«—ÃÂ
            L_strRegHeader(1) = "° «„«‰  Œ«—ÃÂ"
        End If
                
        If optDestination(1).Value = True Then
            L_strRegHeader(1) = " " + "°" + Trim(cboProvince.Text)
            If optProvince(0).Value = True Then
                m_strCriteria_Destination = ""
                For i = 0 To cboCity.ListCount - 1
                    m_strCriteria_Destination = m_strCriteria_Destination + "," + Trim(Str(cboCity.ItemData(i)))
                Next
                m_strCriteria_Destination = Mid(m_strCriteria_Destination, 2)
                m_strCriteria_Destination = "Destcode in (" + m_strCriteria_Destination + ")"
            Else
                L_strRegHeader(1) = L_strRegHeader(1) + "-" + Trim(cboCity.Text)
                m_strCriteria_Destination = "Destcode =" + Trim(Str(cboCity.ItemData(cboCity.ListIndex)))
            End If
        End If
        
        If chkService(0).Value = 1 Then
            L_strRegHeader(2) = "° ⁄«œÌ"
            m_strCriteria_Service = "(ExpInsur=0 and mid(ServiceType,11,1)='0' and mid(ServiceType,5,1)<>'1' and mid(ServiceType,5,1)<>'3')"    '⁄«œÌ
        End If
        
        If chkService(1).Value = 1 And chkService(2).Value = 0 Then
            L_strRegHeader(2) = L_strRegHeader(2) + "° »Ì„Â «—“‘ œ«—"
            m_strCriteria_Service = m_strCriteria_Service + " OR (ExpInsur>0 and mid(ServiceType,11,1)='0' and mid(ServiceType,5,1)<>'1' and mid(ServiceType,5,1)<>'3')"    '»Ì„Â
        End If
        
        If chkService(2).Value = 1 And chkService(1).Value = 0 Then
            L_strRegHeader(2) = L_strRegHeader(2) + "° œÊﬁ»÷Â"
            m_strCriteria_Service = m_strCriteria_Service + " OR (mid(ServiceType,11,1)='1' and ExpInsur=0 and mid(ServiceType,5,1)<>'1' and mid(ServiceType,5,1)<>'3')"    'œÊﬁ»÷Â
        End If
        
        If chkService(2).Value = 1 And chkService(1).Value = 1 Then
            L_strRegHeader(2) = L_strRegHeader(2) + "° »Ì„Â œÊﬁ»÷Â"
            m_strCriteria_Service = m_strCriteria_Service + " OR (mid(ServiceType,11,1)='1' and ExpInsur>0 and mid(ServiceType,5,1)<>'1' and mid(ServiceType,5,1)<>'3')"    '°»Ì„Â œÊﬁ»÷Â
        End If
        
        If chkService(3).Value = 1 Then
            L_strRegHeader(2) = L_strRegHeader(2) + "° ﬁ—«—œ«œ œ«Œ·Ì"
            m_strCriteria_Service = m_strCriteria_Service + " OR (mid(ServiceType,5,1)='1')"    'ﬁ—«—œ«œÌ
        End If
                    
        If chkService(4).Visible And chkService(4).Value = 1 And cboGService.ListIndex <> -1 Then
            'm_strCriteria_CONTRACTS = " Cno='" + CStr(cboGService.ItemData(cboGService.ListIndex)) + "'"
            m_strCriteria_Service = m_strCriteria_Service + " OR (mid(ServiceType,5,1)='3' and Cno='" + CStr(cboGService.ItemData(cboGService.ListIndex)) + "')"
            
            L_strRegHeader(2) = L_strRegHeader(2) + "° ﬁ—«—œ«œÂ«Ì ”—«”—Ì - " + cboGService.Text
        End If
            
        If Mid(m_strCriteria_Service, 1, 4) = " OR " Then m_strCriteria_Service = Mid(m_strCriteria_Service, 5)
        m_strCriteria = "(" + m_strCriteria_ParcelForm + ") and (" + m_strCriteria_Destination + ") and (" + m_strCriteria_Service + ")"
                    
    Else
        L_strRegHeader(1) = "° «“ ‘„«—Â ﬁ»÷ " + txtFrom.Text + "  « ‘„«—Â ﬁ»÷ " + txtTo.Text
        m_strCriteria = " val(mid((Uniquecode),11,8)) >=" + txtFrom.Text + " and val(mid((Uniquecode),11,8)) <=" + txtTo.Text
    End If
    txtHeader.Text = L_strRegHeader(0) + L_strRegHeader(1) + L_strRegHeader(2) + L_strRegHeader(3)

End Sub

Private Sub chkService_Click(Index As Integer)
    If chkService(4).Value = 1 Then
        If Index = 4 Then
            cboGService.Visible = True
            If cboGService.ListCount = 0 Then
                L_FillServiceCombo
            End If
            cboGService.ListIndex = 0
        End If
    Else
        cboGService.Visible = False
    End If
End Sub

Private Sub L_FillServiceCombo()
    G_MyQuery = "select * from CONTRACTS"
    
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    If G_MyRst2.RecordCount > 0 Then
        G_MyRst2.MoveLast
        G_MyRst2.MoveFirst
    End If
    cboGService.Clear
    While Not G_MyRst2.EOF
        If IsNull(G_MyRst2!Caption) Then
            cboGService.AddItem ""
        Else
            cboGService.AddItem G_MyRst2!Caption
            cboGService.ItemData(cboGService.NewIndex) = G_MyRst2!Cno
        End If
        G_MyRst2.MoveNext
    Wend
    G_MyRst2.Close
End Sub
''  Add service type

Private Sub cmdCancel_Click()
    Me.Width = fraLias.Width + 270
    Me.Height = fraLias.Height + 525
    fraLias.Top = 0
    fraLias.Left = 120
    fraShSabt.Visible = False
    fraLias.Visible = True
    cmdPrint.Enabled = True
End Sub

Private Sub cmdPrint_Click()
    On Error GoTo Err_label
    
    Screen.MousePointer = vbHourglass
    cmdPrint.Enabled = False
    G_AdoConn.Execute G_MyQuery
    G_MyQuery = "Insert Into tblRegister(RegId,RegDate,RegHeader,ParcelCount,IsEms) Values(" & txtRegId & " ,'" & G_CurrentDate & "','" & txtHeader.Text & "'," & txtParcelCount.Text & "," & G_IsEMS & ")"
    G_AdoConn.Execute G_MyQuery
    
    Sleep (2000)
    If G_IsEMS = 1 Then
        G_MyQuery = "Update tblParcels set Regid=" + txtRegId + " Where mid(ServiceType,1,1)='1' and Deleted=false and RegId=-1 and (" + m_strCriteria + ") "
    Else
        G_MyQuery = "Update tblParcels set Regid=" + txtRegId + " Where mid(ServiceType,1,1)='0' and Deleted=false and RegId=-1 and (" + m_strCriteria + ")"
    End If
    If m_strCriteria_Shipping <> "" Then
        G_MyQuery = G_MyQuery + " and (" + m_strCriteria_Shipping + ")"
    End If
    
    G_AdoConn.Execute G_MyQuery
    Sleep (2500)
    G_Rptno = enmRptRegister
    frmReportViewer.Show 1
    Screen.MousePointer = vbDefault
    Exit Sub
Err_label:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub cboProvince_Click()
    G_MyQuery = "select CODE,Pname from CITY where STATE_CODE=" + Trim(Str(cboProvince.ItemData(cboProvince.ListIndex)))
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    Call G_FillCombo2(cboCity, G_MyRst)
End Sub

Private Sub cmdOk_Click()
    If optLimit(0).Value Then
        If chkParcelForm(0).Value = 0 And chkParcelForm(1).Value = 0 And chkParcelForm(2).Value = 0 Then
            Call G_ShowMsg("Õœ«ﬁ· ÌﬂÌ «“ «‰Ê«⁄ „—”Ê·Â —« «‰ Œ«» ﬂ‰Ìœ", vbOKOnly, G_exclamation)
            chkParcelForm(0).SetFocus
            Exit Sub
        End If
        If chkService(0).Value = 0 And chkService(1).Value = 0 And chkService(2).Value = 0 And chkService(3).Value = 0 And chkService(4).Value = 0 Then
            Call G_ShowMsg("Õœ«ﬁ· ÌﬂÌ «“ «‰Ê«⁄ ”—ÊÌ” —« «‰ Œ«» ﬂ‰Ìœ", vbOKOnly, G_exclamation)
            chkService(0).SetFocus
            Exit Sub
        End If
    Else
        If Len(txtFrom.Text) = 0 Then
            Call G_ShowMsg("‘„«—Â ﬁ»÷ «» œ«ÌÌ —« „‘Œ’ ‰„«ÌÌœ", vbOKOnly, G_exclamation)
            txtFrom.SetFocus
            Exit Sub
        End If
        If Len(txtTo.Text) = 0 Then
            Call G_ShowMsg("‘„«—Â ﬁ»÷ «‰ Â«ÌÌ —« „‘Œ’ ‰„«ÌÌœ", vbOKOnly, G_exclamation)
            txtTo.SetFocus
            Exit Sub
        End If
    End If
    
    BuildQuery
    G_MyQuery = "select * from tblParcels Where Deleted=false and RegId=-1 and mid(ServiceType,1,1)='" + Trim(Str(G_IsEMS)) + "' and (" + m_strCriteria + ")"
    
    If optLimit(0).Value And m_strCriteria_Shipping <> "" Then
        G_MyQuery = G_MyQuery + " and (" + m_strCriteria_Shipping + ")"
    End If
    
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.RecordCount = 0 Then
        Call G_ShowMsg("„—”Ê·Â «Ì »—«Ì À»  „ÊÃÊœ ‰Ì” !", vbOKOnly, G_exclamation)
        Exit Sub
    End If
    
    G_MyQuery = "select max(RegId) as MaxRegId from tblRegister"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst2.RecordCount = 0 Or IsNull(G_MyRst2!MaxRegId) Then
        G_NewRegId = 1
    Else
        G_NewRegId = 1 + Val(G_MyRst2!MaxRegId)
    End If
    txtRegId = G_NewRegId
    txtParcelCount = G_MyRst.RecordCount
    
    fraLias.Visible = False
    Me.Width = fraShSabt.Width + 270
    Me.Height = fraShSabt.Height + 525
    fraShSabt.Top = 0
    fraShSabt.Left = 120
    fraShSabt.Visible = True
    fraShSabt.ZOrder
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    fraLias.Visible = True
    Call G_FillCombo(cboProvince, "STATE", "CODE", "PNAME")
    m_strCriteria_ParcelForm = ""
    L_strRegHeader(0) = ""
    m_strCriteria_Destination = ""
    L_strRegHeader(1) = ""
    m_strCriteria_Service = ""
    m_strCriteria_CONTRACTS = ""
    L_strRegHeader(2) = ""
    optDestination_Click (0)
    If G_IsEMS = 1 Then
        optDestination(5).Enabled = False
        chkParcelForm(2).Enabled = False
        Me.Caption = "ê“«—‘ À»  ÅÌ‘ «“"
    Else
        chkService(3).Enabled = False
        chkService(4).Enabled = False
        chkService(4).Value = 0
        cboGService.Visible = False
        Me.Caption = "ê“«—‘ À»  ”›«—‘Ì"
    End If
End Sub

Private Sub optDestination_Click(Index As Integer)
    fraProvince.Visible = optDestination(1).Value
    cboProvince.Visible = optDestination(1).Value
    fraPostType.Visible = optDestination(5).Value
End Sub

Private Sub optLimit_Click(Index As Integer)
    lbFrom.Enabled = optLimit(1).Value
    txtFrom.Enabled = optLimit(1).Value
    txtTo.Enabled = optLimit(1).Value
    lbTo.Enabled = optLimit(1).Value
    fraParcelForm.Enabled = optLimit(0).Value
    fraService.Enabled = optLimit(0).Value
    fraDestination.Enabled = optLimit(0).Value
End Sub

Private Sub optprovince_Click(Index As Integer)
    cboCity.Enabled = optProvince(1).Value
End Sub
