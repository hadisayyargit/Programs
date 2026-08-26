VERSION 5.00
Begin VB.Form frmLservice 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "ﬁ—«—œ«œÂ«Ì „Õ·Ì"
   ClientHeight    =   4140
   ClientLeft      =   1095
   ClientTop       =   240
   ClientWidth     =   6180
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   4140
   ScaleWidth      =   6180
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraMaster 
      Height          =   4095
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   25
      Top             =   0
      Width           =   6015
      Begin VB.CheckBox ChkTwoReceipt 
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
         ForeColor       =   &H00800000&
         Height          =   195
         Left            =   4605
         RightToLeft     =   -1  'True
         TabIndex        =   7
         Tag             =   "50"
         Top             =   2100
         Width           =   855
      End
      Begin VB.CheckBox chkTip 
         Alignment       =   1  'Right Justify
         Caption         =   "ﬁ—«—œ«œ  ÌÅ"
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
         Height          =   195
         Left            =   4365
         RightToLeft     =   -1  'True
         TabIndex        =   5
         Tag             =   "50"
         Top             =   1740
         Width           =   1095
      End
      Begin VB.TextBox txtFields 
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
         Index           =   4
         Left            =   120
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   2
         Top             =   960
         Width           =   4200
      End
      Begin VB.TextBox txtFields 
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
         Left            =   120
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   4
         Top             =   1320
         Width           =   1095
      End
      Begin VB.TextBox txtFields 
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
         Left            =   3225
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   3
         Top             =   1320
         Width           =   1095
      End
      Begin VB.PictureBox picButtons 
         BorderStyle     =   0  'None
         Height          =   1455
         Left            =   120
         RightToLeft     =   -1  'True
         ScaleHeight     =   1455
         ScaleWidth      =   5775
         TabIndex        =   35
         Top             =   2520
         Width           =   5775
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
            Height          =   735
            Left            =   3360
            Picture         =   "frmLservice.frx":0000
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   40
            Top             =   600
            Width           =   705
         End
         Begin VB.CommandButton cmdNext 
            BackColor       =   &H00C0C0C0&
            Caption         =   "<"
            Height          =   375
            Left            =   840
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmLservice.frx":0442
            TabIndex        =   11
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
         End
         Begin VB.CommandButton cmdUpdate 
            Caption         =   "À» "
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
            Height          =   735
            Left            =   2550
            Picture         =   "frmLservice.frx":0784
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   15
            Top             =   600
            Width           =   705
         End
         Begin VB.CommandButton cmdCancel 
            Caption         =   "·€Ê"
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
            Height          =   735
            Left            =   1740
            Picture         =   "frmLservice.frx":0BC6
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   16
            Top             =   600
            Width           =   705
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
            Height          =   735
            Left            =   4170
            Picture         =   "frmLservice.frx":1008
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   14
            Top             =   600
            Width           =   705
         End
         Begin VB.CommandButton cmdNew 
            Caption         =   "ÃœÌœ"
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
            Left            =   4980
            Picture         =   "frmLservice.frx":144A
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   13
            Top             =   600
            Width           =   705
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
            Height          =   735
            Left            =   930
            Picture         =   "frmLservice.frx":188C
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   17
            Top             =   600
            UseMaskColor    =   -1  'True
            Width           =   705
         End
         Begin VB.CommandButton cmdClose 
            Caption         =   "»” ‰"
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
            Picture         =   "frmLservice.frx":1B96
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   18
            Top             =   600
            UseMaskColor    =   -1  'True
            Width           =   705
         End
         Begin VB.CommandButton cmdFirst 
            BackColor       =   &H00C0C0C0&
            Caption         =   ">>"
            Height          =   375
            Left            =   5040
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmLservice.frx":1EA0
            TabIndex        =   9
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
         End
         Begin VB.CommandButton cmdPrevious 
            BackColor       =   &H00C0C0C0&
            Caption         =   ">"
            Height          =   375
            Left            =   4680
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmLservice.frx":22E2
            TabIndex        =   10
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
         End
         Begin VB.CommandButton cmdLast 
            BackColor       =   &H00C0C0C0&
            Caption         =   "<<"
            Height          =   375
            Left            =   480
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmLservice.frx":23CC
            TabIndex        =   12
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
         End
         Begin VB.Label lblStatus 
            Alignment       =   2  'Center
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
            Height          =   285
            Left            =   1320
            RightToLeft     =   -1  'True
            TabIndex        =   36
            Top             =   165
            Width           =   3240
         End
      End
      Begin VB.TextBox txtFields 
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
         Left            =   120
         MaxLength       =   6
         RightToLeft     =   -1  'True
         TabIndex        =   6
         Top             =   1680
         Width           =   1095
      End
      Begin VB.TextBox txtFields 
         BeginProperty DataFormat 
            Type            =   0
            Format          =   "0"
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1025
            SubFormatType   =   0
         EndProperty
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
         Left            =   2505
         MaxLength       =   20
         RightToLeft     =   -1  'True
         TabIndex        =   0
         Top             =   240
         Width           =   1815
      End
      Begin VB.TextBox txtFields 
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
         Index           =   1
         Left            =   120
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   1
         Top             =   600
         Width           =   4200
      End
      Begin VB.TextBox txtFields 
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
         Left            =   720
         MaxLength       =   2
         RightToLeft     =   -1  'True
         TabIndex        =   8
         Top             =   2040
         Width           =   495
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   " «—ÌŒ «‰ﬁ÷«¡:"
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
         Height          =   195
         Index           =   8
         Left            =   1275
         RightToLeft     =   -1  'True
         TabIndex        =   39
         Top             =   1380
         Width           =   840
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   " «—ÌŒ ‘—Ê⁄:"
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
         Height          =   195
         Index           =   7
         Left            =   4380
         RightToLeft     =   -1  'True
         TabIndex        =   38
         Top             =   1380
         Width           =   840
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "”«“„«‰ ÿ—› ﬁ—«—œ«œ:"
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
         Height          =   195
         Index           =   3
         Left            =   4380
         RightToLeft     =   -1  'True
         TabIndex        =   37
         Top             =   1020
         Width           =   1440
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "œ—’œ  Œ›Ì›:"
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
         Height          =   195
         Index           =   2
         Left            =   1260
         RightToLeft     =   -1  'True
         TabIndex        =   29
         Top             =   2100
         Width           =   915
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "„»·€ ﬁ—«—œ«œ:"
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
         Height          =   195
         Index           =   4
         Left            =   1260
         RightToLeft     =   -1  'True
         TabIndex        =   28
         Top             =   1740
         Width           =   855
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "⁄‰Ê«‰ ﬁ—«—œ«œ:"
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
         Height          =   195
         Index           =   1
         Left            =   4380
         RightToLeft     =   -1  'True
         TabIndex        =   27
         Top             =   660
         Width           =   945
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "‘„«—Â ﬁ—«—œ«œ:"
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
         Height          =   195
         Index           =   0
         Left            =   4380
         RightToLeft     =   -1  'True
         TabIndex        =   26
         Top             =   300
         Width           =   1005
      End
   End
   Begin VB.Frame fraSearch 
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
      Height          =   2415
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   30
      Top             =   1680
      Visible         =   0   'False
      Width           =   6015
      Begin VB.OptionButton optSearch 
         Alignment       =   1  'Right Justify
         Caption         =   "»— «”«” ‘„«—Â ﬁ—«—œ«œ"
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
         Left            =   3840
         RightToLeft     =   -1  'True
         TabIndex        =   19
         Top             =   510
         Value           =   -1  'True
         Width           =   1905
      End
      Begin VB.OptionButton optSearch 
         Alignment       =   1  'Right Justify
         Caption         =   "»— «”«” ⁄‰Ê«‰ ﬁ—«—œ«œ"
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
         Left            =   3810
         RightToLeft     =   -1  'True
         TabIndex        =   20
         Top             =   1230
         Width           =   1935
      End
      Begin VB.CommandButton cmdFind 
         Caption         =   "ÅÌœ« ﬂ‰"
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
         Left            =   3240
         RightToLeft     =   -1  'True
         TabIndex        =   23
         Top             =   1800
         Width           =   855
      End
      Begin VB.CommandButton cmdCancelSearch 
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
         Left            =   2280
         RightToLeft     =   -1  'True
         TabIndex        =   24
         Top             =   1800
         Width           =   855
      End
      Begin VB.Frame fraKey1 
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
         TabIndex        =   33
         Top             =   240
         Width           =   3495
         Begin VB.TextBox txtKey1 
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
            MaxLength       =   10
            RightToLeft     =   -1  'True
            TabIndex        =   21
            Top             =   240
            Width           =   2175
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "‘„«—Â ﬁ—«—œ«œ:"
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
            Height          =   195
            Index           =   5
            Left            =   2400
            RightToLeft     =   -1  'True
            TabIndex        =   34
            Top             =   300
            Width           =   1005
         End
      End
      Begin VB.Frame fraKey2 
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
         TabIndex        =   31
         Top             =   960
         Visible         =   0   'False
         Width           =   3495
         Begin VB.TextBox txtKey2 
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
            MaxLength       =   20
            RightToLeft     =   -1  'True
            TabIndex        =   22
            Top             =   240
            Width           =   2655
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "⁄‰Ê«‰:"
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
            Height          =   195
            Index           =   6
            Left            =   2880
            RightToLeft     =   -1  'True
            TabIndex        =   32
            Top             =   300
            Width           =   450
         End
      End
   End
End
Attribute VB_Name = "frmLservice"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Sub L_PrimaryMoveComplete()
    On Error GoTo Err_label
     
    G_PrgMod = G_NormalMod
    Call G_BoxesEmpty(Me)

    If G_PrimaryRs.RecordCount > 0 Then
        If G_PrimaryRs.EOF Then G_PrimaryRs.MoveLast
        If G_PrimaryRs.BOF Then G_PrimaryRs.MoveFirst
        txtFields(0).Text = G_PrimaryRs!F0_tCno
        txtFields(1).Text = G_PrimaryRs!F1_tCaption
        txtFields(2).Text = G_PrimaryRs!F2_nlFare
        txtFields(3).Text = G_PrimaryRs!F3_nlDiscount
        txtFields(4).Text = G_PrimaryRs!F4_tEmployer
        txtFields(5).Text = G_PrimaryRs!F5_tBeginDate
        txtFields(6).Text = G_PrimaryRs!F6_tExpireDate
        If G_PrimaryRs!F7_ynoTwoReceipt = True Then
            ChkTwoReceipt.Value = 1
        Else
            ChkTwoReceipt.Value = 0
        End If
        
        If G_PrimaryRs!F8_ynoTip = True Then
            chkTip.Value = 1
        Else
            chkTip.Value = 0
        End If
        
        lblStatus.Caption = G_PrimaryRs.AbsolutePosition
        G_BookMark = G_PrimaryRs.Bookmark
    Else
        lblStatus.Caption = 0
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        cmdNew.Enabled = True
        Call G_ShowMsg("ÃœÊ· «ÿ·«⁄«  Œ«·Ì «” ", vbOKOnly, G_exclamation)
    End If
    Exit Sub
Err_label:
    'G_ShowMsg Err.Description, vbOKOnly
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical
End Sub

Private Sub chkTip_Click()
    If G_PrgMod = G_NormalMod Then
        Exit Sub
    ElseIf chkTip.Value = 0 Then
        txtFields(2) = 0
    End If
End Sub

Private Sub cmdCancelSearch_Click()
    fraSearch.Visible = False
    fraMaster.Enabled = True
End Sub

Private Sub cmdClose_Click()
    G_PrgMod = G_MainformMod
    Unload Me
End Sub

Private Sub cmdFind_Click()
    G_PrimaryRs.MoveFirst
    If optSearch(0).Value = True And txtKey1 <> "" Then
        G_PrimaryRs.Find "F0_tCno=" + txtKey1
    ElseIf txtKey2 <> "" Then
        G_PrimaryRs.Find "F1_tCaption Like '*" + Trim(txtKey2) + "*'"
    End If
    If G_PrimaryRs.EOF Then
        Call G_ShowMsg("ÅÌœ« ‰‘œ!", vbOKOnly, G_exclamation)
        G_PrimaryRs.Bookmark = G_BookMark
    End If
    Call L_PrimaryMoveComplete
End Sub

Private Sub cmdNew_Click()
    On Error GoTo Err_label
    
    If G_PrimaryRs.RecordCount = 100 Then
        G_ShowMsg "Õœ«ﬂÀ—  ⁄œ«œ ﬁ—«—œ«œ 100  « „Ìù»«‘œ", vbOKOnly, G_exclamation
        Exit Sub
    End If
    Call G_SetBoxesLock(Me, False)
    lblStatus.Caption = "—ﬂÊ—œ ÃœÌœ"
    G_PrgMod = G_AddMod
    Call G_SetButtons(Me, False)
    Call G_SetFrame(Me, True)
    Call G_BoxesEmpty(Me)
    G_PrimaryRs.AddNew
    txtFields(0).SetFocus
    Exit Sub
    
Err_label:
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical
End Sub
'
Private Sub cmdDelete_Click()

    On Error GoTo Err_label
    
    G_PrgMod = G_DeleteMod
    Call G_ShowMsg("«ÿ·«⁄«  —ﬂÊ—œ Õ–› „Ìù‘Êœ. ⁄„·Ì«  —« «œ„Â „ÌùœÂÌœø", vbYesNoCancel, G_question)
    
    If G_MsgButton = vbYes Then
        With G_PrimaryRs
            .Delete
            .MoveNext
        End With
        Call L_PrimaryMoveComplete
    End If
    Exit Sub
Err_label:
    
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical

End Sub
'
Private Sub cmdEdit_Click()
    On Error GoTo EditErr

    lblStatus.Caption = "«’·«Õ —ﬂÊ—œ"
    Call G_SetBoxesLock(Me, False)
    G_PrgMod = G_EditMod
    Call G_SetButtons(Me, False)
    Call G_SetFrame(Me, True)
    txtFields(0).SetFocus
    Exit Sub

EditErr:
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical

End Sub
'
Private Sub cmdCancel_Click()
    On Error GoTo cancelErr
    
    If G_PrgMod = G_EditMod Then
        flag1 = True
    End If
    G_PrimaryRs.CancelUpdate
    Call G_SetBoxesLock(Me, True)
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
    G_PrgMod = G_NormalMod
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.Bookmark = G_BookMark
    Call L_PrimaryMoveComplete
    Exit Sub

cancelErr:
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical

End Sub

Private Sub cmdSearch_Click()
    If G_PrimaryRs.RecordCount > 0 Then
        fraSearch.Visible = True
        fraMaster.Enabled = False
        fraSearch.ZOrder
    End If
End Sub

'
Private Sub cmdUpdate_Click()
    On Error GoTo Err_label
    Dim key1 As String
    
    If G_BoxesValidate(Me) = True Then
        If Val(txtFields(3).Text) > 15 Then
            Call G_ShowMsg("Õœ«ﬂÀ— œ—’œ  Œ›Ì› 15% „Ìù»«‘œ!", vbOKOnly, G_exclamation)
            Exit Sub
        End If
        key1 = txtFields(0)
        G_PrimaryRs!F0_tCno = txtFields(0).Text
        G_PrimaryRs!F1_tCaption = txtFields(1).Text
        G_PrimaryRs!F2_nlFare = Val(txtFields(2).Text)
        G_PrimaryRs!F3_nlDiscount = Val(txtFields(3).Text)
        G_PrimaryRs!F4_tEmployer = Trim(txtFields(4).Text)
        G_PrimaryRs!F5_tBeginDate = txtFields(5).Text
        G_PrimaryRs!F6_tExpireDate = txtFields(6).Text
        If ChkTwoReceipt.Value = 1 Then
            G_PrimaryRs!F7_ynoTwoReceipt = True
        Else
            G_PrimaryRs!F7_ynoTwoReceipt = False
        End If
        If chkTip.Value = 1 Then
            G_PrimaryRs!F8_ynoTip = True
        Else
            G_PrimaryRs!F8_ynoTip = False
        End If
        
        G_PrimaryRs.UpdateBatch adAffectAll
        G_PrimaryRs.Requery
        If G_PrimaryRs.RecordCount > 0 Then
            G_PrimaryRs.MoveLast
            G_PrimaryRs.MoveFirst
        End If
        
        If G_PrgMod = G_EditMod Then
            G_PrimaryRs.Bookmark = G_BookMark
        Else    ' G_AddMod
            G_PrimaryRs.Find "F0_tCno=" + key1
        End If
        Call L_PrimaryMoveComplete
        Call G_SetBoxesLock(Me, True)
        Call G_SetButtons(Me, True)
        Call G_SetFrame(Me, False)
    End If
    Exit Sub

Err_label:
    Select Case Err.Number
            Case -2147467259
                G_ShowMsg "«ÿ·«⁄«  ‰«„⁄ »— «”  Ì« ﬂœ «’·Ì  ﬂ—«—Ì «” !", vbOKOnly, G_critical
'            Case -2147217887, -2147217842
'                MsgBox "‰Ê⁄ ÌﬂÌ «“ «ÿ·«⁄«  Ê—ÊœÌ «‘ »«Â «” !", vbMsgBoxRight + vbMsgBoxRtlReading,G_critical
            Case Else
                G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
                G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
                G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical
    End Select
End Sub
'
Private Sub cmdFirst_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveFirst
    L_PrimaryMoveComplete
End Sub
'
Private Sub cmdLast_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveLast
    L_PrimaryMoveComplete
End Sub
'
Private Sub cmdNext_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveNext
    L_PrimaryMoveComplete
End Sub
'
Private Sub cmdPrevious_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MovePrevious
    L_PrimaryMoveComplete
    Exit Sub
End Sub

Private Sub Form_Deactivate()
     'Screen.MousePointer = vbDefault
      G_PrgMod = G_MainformMod
End Sub

'
Private Sub Form_Load()
    For i = 0 To Me.count - 1
        Me.Controls(i).Tag = ""
    Next
    
    txtFields(0).Tag = 21
    txtFields(1).Tag = 21
    txtFields(2).Tag = 11
    txtFields(3).Tag = 1
    txtFields(4).Tag = 21
    txtFields(5).Tag = 31
    txtFields(6).Tag = 31
    'fraTwoReceipt.Tag = 6
    cmdNew.Tag = 7
    cmdDelete.Tag = 7
    cmdEdit.Tag = 7
    cmdCancel.Tag = 71
    cmdUpdate.Tag = 71
    cmdNext.Tag = 7
    cmdPrevious.Tag = 7
    cmdFirst.Tag = 7
    cmdLast.Tag = 7
    cmdClose.Tag = 7
    cmdSearch.Tag = 7
    
   
    Call G_SetBoxesLock(Me, True)
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
 
    G_MyQuery = "SELECT F0_tCno, F1_tCaption,F2_nlFare, F3_nlDiscount,F4_tEmployer,F5_tBeginDate,F6_tExpireDate,F7_ynoTwoReceipt,F8_ynoTip From tblLocalService ORDER BY tblLocalService.F0_tCno"

    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
    
    If G_PrimaryRs.RecordCount > 0 Then
        G_PrimaryRs.MoveLast
        G_PrimaryRs.MoveFirst
    End If
    Call L_PrimaryMoveComplete

    'Height = 6930
    'Width = 6404
    'Show
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
 'Screen.MousePointer = vbDefault
    'G_PrgMod = G_MainformMod
End Sub

Private Sub Form_Unload(Cancel As Integer)
    'Screen.MousePointer = vbDefault
    G_PrgMod = G_MainformMod
End Sub

Private Sub optSearch_Click(Index As Integer)
    If optSearch(0).Value = True Then
        fraKey1.Visible = True
        fraKey2.Visible = False
        txtKey1.Tag = 11
        txtKey2.Tag = ""
    Else
        fraKey2.Visible = True
        fraKey1.Visible = False
        txtKey1.Tag = ""
        txtKey2.Tag = 21
    End If
End Sub

Private Sub txtFields_Change(Index As Integer)
    If G_PrgMod <> G_NormalMod Then
        If Val(txtFields(2)) = 0 Then
            chkTip.Value = 0
        Else
            chkTip.Value = 1
        End If
    End If
End Sub
