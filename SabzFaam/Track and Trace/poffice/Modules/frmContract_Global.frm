VERSION 5.00
Begin VB.Form frmContract_Global 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "ﬁ—«—œ«œÂ«Ì ”—«”—Ì"
   ClientHeight    =   6945
   ClientLeft      =   1095
   ClientTop       =   240
   ClientWidth     =   8835
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   6945
   ScaleWidth      =   8835
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraMaster 
      BackColor       =   &H00C0C0C0&
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   6855
      Left            =   0
      RightToLeft     =   -1  'True
      TabIndex        =   18
      Top             =   0
      Width           =   8775
      Begin VB.TextBox txtStakeholder 
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
         Height          =   375
         Left            =   240
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   6
         Top             =   1680
         Width           =   2655
      End
      Begin VB.TextBox txtEnd 
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
         Left            =   1440
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   8
         Top             =   2280
         Width           =   1455
      End
      Begin VB.TextBox txtBegin 
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
         Left            =   3960
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   7
         Top             =   2280
         Width           =   1455
      End
      Begin VB.TextBox txtFare 
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
         Left            =   3960
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   9
         Top             =   2880
         Width           =   2655
      End
      Begin VB.TextBox txtCaption 
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
         Height          =   375
         Left            =   3960
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   5
         Top             =   1680
         Width           =   3255
      End
      Begin VB.TextBox txtDetail 
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
         Height          =   375
         Left            =   240
         MaxLength       =   50
         RightToLeft     =   -1  'True
         TabIndex        =   10
         Top             =   3510
         Width           =   7335
      End
      Begin VB.TextBox txtCno 
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
         Height          =   375
         Left            =   5400
         MaxLength       =   20
         RightToLeft     =   -1  'True
         TabIndex        =   4
         Top             =   1080
         Width           =   1815
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00C0C0C0&
         Caption         =   "„ÕœÊœÂ"
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
         Height          =   615
         Left            =   5160
         RightToLeft     =   -1  'True
         TabIndex        =   0
         Top             =   240
         Width           =   3255
         Begin VB.OptionButton rdoLocal 
            Alignment       =   1  'Right Justify
            BackColor       =   &H00C0C0C0&
            Caption         =   "«” «‰Ì"
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
            Left            =   1560
            RightToLeft     =   -1  'True
            TabIndex        =   35
            Top             =   240
            Width           =   975
         End
         Begin VB.OptionButton rdoGlobal 
            Alignment       =   1  'Right Justify
            BackColor       =   &H00C0C0C0&
            Caption         =   "”—«”—Ì"
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
            Left            =   240
            RightToLeft     =   -1  'True
            TabIndex        =   34
            Top             =   240
            Value           =   -1  'True
            Width           =   975
         End
      End
      Begin VB.Frame Frame2 
         BackColor       =   &H00C0C0C0&
         Caption         =   "‰Ê⁄ ﬁ—«—œ«œ"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   1
         Top             =   240
         Width           =   3255
         Begin VB.OptionButton rdoRenew 
            Alignment       =   1  'Right Justify
            BackColor       =   &H00C0C0C0&
            Caption         =   " „œÌœÌ"
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
            Left            =   120
            RightToLeft     =   -1  'True
            TabIndex        =   3
            Top             =   240
            Width           =   975
         End
         Begin VB.OptionButton rdoNew 
            Alignment       =   1  'Right Justify
            BackColor       =   &H00C0C0C0&
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
            ForeColor       =   &H00800000&
            Height          =   195
            Left            =   1440
            RightToLeft     =   -1  'True
            TabIndex        =   2
            Top             =   240
            Value           =   -1  'True
            Width           =   975
         End
      End
      Begin VB.PictureBox picButtons 
         BackColor       =   &H00C0C0C0&
         BorderStyle     =   0  'None
         Height          =   1455
         Left            =   1530
         RightToLeft     =   -1  'True
         ScaleHeight     =   1455
         ScaleWidth      =   5775
         TabIndex        =   11
         Top             =   4080
         Width           =   5775
         Begin VB.CommandButton cmdLast 
            BackColor       =   &H00C0C0C0&
            Caption         =   "<<"
            Height          =   375
            Left            =   480
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmContract_Global.frx":0000
            TabIndex        =   14
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
            Picture         =   "frmContract_Global.frx":0342
            TabIndex        =   13
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
         End
         Begin VB.CommandButton cmdFirst 
            BackColor       =   &H00C0C0C0&
            Caption         =   ">>"
            Height          =   375
            Left            =   5040
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmContract_Global.frx":042C
            TabIndex        =   15
            Top             =   120
            UseMaskColor    =   -1  'True
            Width           =   375
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
            Left            =   2205
            Picture         =   "frmContract_Global.frx":086E
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   17
            Top             =   600
            UseMaskColor    =   -1  'True
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
            Left            =   3045
            Picture         =   "frmContract_Global.frx":0B78
            RightToLeft     =   -1  'True
            Style           =   1  'Graphical
            TabIndex        =   16
            Top             =   600
            UseMaskColor    =   -1  'True
            Width           =   705
         End
         Begin VB.CommandButton cmdNext 
            BackColor       =   &H00C0C0C0&
            Caption         =   "<"
            Height          =   375
            Left            =   840
            MaskColor       =   &H00FFFFFF&
            Picture         =   "frmContract_Global.frx":0E82
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
            TabIndex        =   33
            Top             =   165
            Width           =   3240
         End
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "„œ  “„«‰ «Ã—«Ì ﬁ—«—œ«œ:"
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
         Index           =   9
         Left            =   6780
         RightToLeft     =   -1  'True
         TabIndex        =   43
         Top             =   2370
         Width           =   1680
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   " «:"
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
         Left            =   3120
         RightToLeft     =   -1  'True
         TabIndex        =   42
         Top             =   2370
         Width           =   150
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "«“:"
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
         Left            =   5640
         RightToLeft     =   -1  'True
         TabIndex        =   41
         Top             =   2370
         Width           =   165
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "„Ã—Ì:"
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
         Index           =   3
         Left            =   3120
         RightToLeft     =   -1  'True
         TabIndex        =   40
         Top             =   1770
         Width           =   480
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   " Ê÷ÌÕ« :"
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
         Left            =   7800
         RightToLeft     =   -1  'True
         TabIndex        =   39
         Top             =   3600
         Width           =   660
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Ã„⁄ Â“Ì‰Â Å” Ì(—Ì«·):"
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
         Index           =   4
         Left            =   6795
         RightToLeft     =   -1  'True
         TabIndex        =   38
         Top             =   2970
         Width           =   1665
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "„Ê÷Ê⁄ ﬁ—«—œ«œ:"
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
         Left            =   7425
         RightToLeft     =   -1  'True
         TabIndex        =   37
         Top             =   1770
         Width           =   1035
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
         ForeColor       =   &H00000000&
         Height          =   195
         Index           =   14
         Left            =   7455
         RightToLeft     =   -1  'True
         TabIndex        =   36
         Top             =   1170
         Width           =   1005
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "1- œ— ’Ê— Ì òÂ ﬁ—«—œ«œ ”—«”—Ì »«‘œ ê“Ì‰Â ò«—›—„« ›⁄«· „Ì ê—œœ."
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
         Index           =   11
         Left            =   3915
         RightToLeft     =   -1  'True
         TabIndex        =   32
         Top             =   5760
         Width           =   4635
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "2- œ” —”Ì »Â ê“Ì‰Â ﬁ—«—œ«œ Ê „œ  “„«‰ «Ã—«Ì ﬁ—«—œ«œ »Â ⁄‰Ê«‰ «»“«— ò‰ —·Ì œ— «Œ Ì«— „œÌ—Ì  «” «‰/„‰ÿﬁÂ „Ì »«‘œ"
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
         Index           =   12
         Left            =   540
         RightToLeft     =   -1  'True
         TabIndex        =   31
         Top             =   6120
         Width           =   8010
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "3- Ã„⁄ Â“Ì‰Â Å” Ì ‘«„· Õﬁ «·”Â„ ÿ—› ﬁ—«—œ«œ Ê Õﬁ «·”Â„ Å”  „Ì »«‘œ(œ— «Ì‰ „—Õ·Â  ›òÌòÌ ’Ê—  ‰„Ì êÌ—œ)"
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
         Index           =   13
         Left            =   210
         RightToLeft     =   -1  'True
         TabIndex        =   30
         Top             =   6480
         Width           =   8340
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
      Left            =   1545
      RightToLeft     =   -1  'True
      TabIndex        =   19
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
         TabIndex        =   20
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
         TabIndex        =   21
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
         TabIndex        =   24
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
         TabIndex        =   25
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
         TabIndex        =   28
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
            TabIndex        =   22
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
            TabIndex        =   29
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
         TabIndex        =   26
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
            TabIndex        =   23
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
            TabIndex        =   27
            Top             =   300
            Width           =   450
         End
      End
   End
End
Attribute VB_Name = "frmContract_Global"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Sub L_PrimaryMoveComplete()
    On Error Resume Next
     
    G_PrgMod = G_NormalMod
    Call G_BoxesEmpty(Me)

    If G_PrimaryRs.RecordCount > 0 Then
        If G_PrimaryRs.EOF Then G_PrimaryRs.MoveLast
        If G_PrimaryRs.BOF Then G_PrimaryRs.MoveFirst
        txtCno.Text = G_PrimaryRs!Cno
        txtCaption.Text = G_PrimaryRs!Caption
        txtFare.Text = G_PrimaryRs!Fare
                
        txtDetail.Text = G_PrimaryRs!Detail
        txtStakeholder.Text = G_PrimaryRs!stakeholder
        txtBegin.Text = G_PrimaryRs!BeginDate
        txtEnd.Text = G_PrimaryRs!ExpireDate
        If G_PrimaryRs!Contract_type = 0 Then
            rdoNew.Value = True
        Else
            rdoRenew.Value = True
        End If
                
        lblStatus.Caption = G_PrimaryRs.AbsolutePosition
        G_BookMark = G_PrimaryRs.Bookmark
    Else
        lblStatus.Caption = 0
        Call G_ShowMsg("ÃœÊ· «ÿ·«⁄«  Œ«·Ì «” ", vbOKOnly, G_exclamation)
    End If
    Exit Sub
Err_label:
    'G_ShowMsg Err.Description, vbOKOnly
    G_ShowMsg "·ÿ›« ÅÌ€«„ Œÿ« Ê ‘„«—Â Ê „Õ· ÊﬁÊ⁄ ¬‰—« »Â »—‰«„Â ‰ÊÌ” ê“«—‘ ﬂ‰Ìœ", vbOKOnly, G_critical
    G_ShowMsg " ÅÌ€«„ Œÿ«:" + Err.Description, vbOKOnly, G_critical
    G_ShowMsg "‘„«—Â Œÿ«: " + Str(Err.Number), vbOKOnly, G_critical
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
        G_PrimaryRs.Find "Cno=" + txtKey1
    ElseIf txtKey2 <> "" Then
        G_PrimaryRs.Find "Caption Like '*" + Trim(txtKey2) + "*'"
    End If
    If G_PrimaryRs.EOF Then
        Call G_ShowMsg("ÅÌœ« ‰‘œ!", vbOKOnly, G_exclamation)
        G_PrimaryRs.Bookmark = G_BookMark
    End If
    Call L_PrimaryMoveComplete
End Sub

Private Sub cmdSearch_Click()
    If G_PrimaryRs.RecordCount > 0 Then
        fraSearch.Visible = True
        fraMaster.Enabled = False
        fraSearch.ZOrder
    End If
End Sub


Private Sub cmdFirst_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveFirst
    L_PrimaryMoveComplete
End Sub

Private Sub cmdLast_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveLast
    L_PrimaryMoveComplete
End Sub
'
Private Sub cmdNext_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MoveNext
    L_PrimaryMoveComplete
End Sub

Private Sub cmdPrevious_Click()
    If G_PrimaryRs.RecordCount > 0 Then G_PrimaryRs.MovePrevious
    L_PrimaryMoveComplete
    Exit Sub
End Sub
'
Private Sub Form_Load()
    For i = 0 To Me.count - 1
        Me.Controls(i).Tag = ""
    Next
    
    
    txtCno.Tag = 21
    txtCaption.Tag = 21
    txtFare.Tag = 11
    txtDetail.Tag = 2
    txtStakeholder.Tag = 2
    txtBegin.Tag = 3
    txtEnd.Tag = 3

    cmdNext.Tag = 7
    cmdPrevious.Tag = 7
    cmdFirst.Tag = 7
    cmdLast.Tag = 7
    cmdClose.Tag = 7
    cmdSearch.Tag = 7
    
   
    Call G_SetBoxesLock(Me, True)
    Call G_SetButtons(Me, True)
    Call G_SetFrame(Me, False)
 
    G_MyQuery = "SELECT * From Contracts ORDER BY Cno"

    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenDynamic, adLockOptimistic
    
    If G_PrimaryRs.RecordCount > 0 Then
        G_PrimaryRs.MoveLast
        G_PrimaryRs.MoveFirst
    End If
    
    Call L_PrimaryMoveComplete

   
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Unload(Cancel As Integer)
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

