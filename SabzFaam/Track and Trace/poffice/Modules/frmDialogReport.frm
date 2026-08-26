VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmDialogReport 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "ê“«—‘« "
   ClientHeight    =   4635
   ClientLeft      =   165
   ClientTop       =   240
   ClientWidth     =   10455
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   4635
   ScaleWidth      =   10455
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BorderStyle     =   0  'None
      Height          =   3375
      Left            =   3120
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Top             =   0
      Width           =   7215
      Begin VB.CommandButton cmdOk 
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
         Left            =   2880
         TabIndex        =   17
         Top             =   2760
         Width           =   1215
      End
      Begin VB.Frame fraTarikh 
         BorderStyle     =   0  'None
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2175
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Visible         =   0   'False
         Width           =   6975
         Begin VB.Frame fraLservice 
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
            Left            =   1800
            RightToLeft     =   -1  'True
            TabIndex        =   20
            Top             =   1080
            Visible         =   0   'False
            Width           =   3135
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
               ItemData        =   "frmDialogReport.frx":0000
               Left            =   120
               List            =   "frmDialogReport.frx":0002
               RightToLeft     =   -1  'True
               Style           =   2  'Dropdown List
               TabIndex        =   9
               Top             =   240
               Width           =   1815
            End
            Begin VB.Label Label1 
               AutoSize        =   -1  'True
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
               Height          =   195
               Index           =   11
               Left            =   2040
               RightToLeft     =   -1  'True
               TabIndex        =   21
               Top             =   300
               Width           =   945
            End
         End
         Begin VB.TextBox txtToDate 
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
            Left            =   1680
            MaxLength       =   10
            RightToLeft     =   -1  'True
            TabIndex        =   7
            Tag             =   "31"
            Top             =   330
            Width           =   1095
         End
         Begin VB.TextBox txtFromDate 
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
            MaxLength       =   10
            RightToLeft     =   -1  'True
            TabIndex        =   6
            Tag             =   "31"
            Top             =   330
            Width           =   1095
         End
         Begin VB.Frame fraUser 
            Height          =   735
            Left            =   1800
            TabIndex        =   18
            Top             =   1080
            Visible         =   0   'False
            Width           =   3135
            Begin VB.TextBox txtUserName 
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
               TabIndex        =   8
               Top             =   240
               Width           =   2055
            End
            Begin VB.Label Label1 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "‰«„ ﬂ«—»—:"
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
               Left            =   2280
               RightToLeft     =   -1  'True
               TabIndex        =   19
               Top             =   300
               Width           =   600
            End
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "«“  «—ÌŒ:"
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
            Left            =   4680
            RightToLeft     =   -1  'True
            TabIndex        =   25
            Top             =   390
            Width           =   525
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   " «  «—ÌŒ:"
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
            Left            =   2880
            RightToLeft     =   -1  'True
            TabIndex        =   24
            Top             =   390
            Width           =   510
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "(—Ê“/„«Â/”«·)"
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
            Left            =   1740
            TabIndex        =   23
            Top             =   720
            Width           =   960
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "(—Ê“/„«Â/”«·)"
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
            Left            =   3660
            TabIndex        =   22
            Top             =   720
            Width           =   960
         End
      End
      Begin VB.Frame fraPreReg 
         BorderStyle     =   0  'None
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1455
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   4
         Top             =   240
         Visible         =   0   'False
         Width           =   6975
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
            Left            =   240
            MaxLength       =   10
            RightToLeft     =   -1  'True
            TabIndex        =   14
            Tag             =   "1"
            Top             =   960
            Width           =   1215
         End
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
            Left            =   2280
            MaxLength       =   10
            RightToLeft     =   -1  'True
            TabIndex        =   13
            Tag             =   "1"
            Top             =   960
            Width           =   1215
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
            Left            =   2280
            MaxLength       =   8
            RightToLeft     =   -1  'True
            TabIndex        =   12
            Tag             =   "1"
            Top             =   360
            Width           =   1215
         End
         Begin VB.OptionButton optPreReg 
            Alignment       =   1  'Right Justify
            Caption         =   "»— «”«” ‘„«—Â ”—Ì«·"
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
            Left            =   4680
            RightToLeft     =   -1  'True
            TabIndex        =   11
            Top             =   1020
            Width           =   2055
         End
         Begin VB.OptionButton optPreReg 
            Alignment       =   1  'Right Justify
            Caption         =   "»— «”«” ‘„«—Â À» "
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
            Left            =   5010
            RightToLeft     =   -1  'True
            TabIndex        =   10
            Top             =   420
            Value           =   -1  'True
            Width           =   1725
         End
         Begin VB.Label Label1 
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
            Index           =   3
            Left            =   1560
            RightToLeft     =   -1  'True
            TabIndex        =   31
            Top             =   1020
            Width           =   645
         End
         Begin VB.Label Label1 
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
            Index           =   2
            Left            =   3600
            RightToLeft     =   -1  'True
            TabIndex        =   30
            Top             =   1020
            Width           =   660
         End
         Begin VB.Label Label1 
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
            Index           =   4
            Left            =   3600
            RightToLeft     =   -1  'True
            TabIndex        =   29
            Top             =   420
            Width           =   810
         End
      End
      Begin VB.Frame fraDispatch 
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
         Left            =   1920
         RightToLeft     =   -1  'True
         TabIndex        =   32
         Top             =   1320
         Visible         =   0   'False
         Width           =   3135
         Begin VB.TextBox txtDispatchCode 
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
            Left            =   240
            MaxLength       =   15
            RightToLeft     =   -1  'True
            TabIndex        =   33
            Tag             =   "1"
            Top             =   240
            Width           =   2055
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "ﬂœ œÅ‘:"
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
            Left            =   2400
            RightToLeft     =   -1  'True
            TabIndex        =   34
            Top             =   300
            Width           =   600
         End
      End
      Begin VB.Frame fraTraffic 
         BorderStyle     =   0  'None
         Height          =   1455
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   5
         Top             =   240
         Visible         =   0   'False
         Width           =   6975
         Begin VB.TextBox txtYear 
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
            Left            =   2640
            MaxLength       =   4
            RightToLeft     =   -1  'True
            TabIndex        =   16
            Tag             =   "1"
            Top             =   600
            Width           =   495
         End
         Begin VB.ComboBox cboMonth 
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
            ItemData        =   "frmDialogReport.frx":0004
            Left            =   3720
            List            =   "frmDialogReport.frx":002C
            RightToLeft     =   -1  'True
            Style           =   2  'Dropdown List
            TabIndex        =   15
            Top             =   600
            Width           =   1335
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "(”«· —« 4—ﬁ„Ì Ê«—œ ‰„«ÌÌœ)"
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
            Left            =   600
            RightToLeft     =   -1  'True
            TabIndex        =   28
            Top             =   660
            Width           =   1860
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "”«·:"
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
            Left            =   3180
            RightToLeft     =   -1  'True
            TabIndex        =   27
            Top             =   660
            Width           =   375
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "ê“«—‘ œ› — ⁄„·ﬂ—œ œ— „«Â:"
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
            Left            =   5100
            RightToLeft     =   -1  'True
            TabIndex        =   26
            Top             =   660
            Width           =   1830
         End
      End
   End
   Begin MSComctlLib.TreeView trReport 
      Height          =   4575
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   3015
      _ExtentX        =   5318
      _ExtentY        =   8070
      _Version        =   393217
      LabelEdit       =   1
      LineStyle       =   1
      Style           =   7
      Appearance      =   1
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
   Begin VB.Label lblHint 
      Alignment       =   1  'Right Justify
      BorderStyle     =   1  'Fixed Single
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   3120
      RightToLeft     =   -1  'True
      TabIndex        =   2
      Top             =   3480
      Width           =   7215
      WordWrap        =   -1  'True
   End
   Begin VB.Menu goz1 
      Caption         =   "ê“«—‘«  "
      Visible         =   0   'False
      Begin VB.Menu first 
         Caption         =   "ﬁ«·» «Ê·"
      End
      Begin VB.Menu second 
         Caption         =   "ﬁ«·» œÊ„"
      End
      Begin VB.Menu third 
         Caption         =   "ﬁ«·» ”Ê„"
      End
   End
End
Attribute VB_Name = "frmDialogReport"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim L_col1 As Long
Dim L_col2 As Long
Dim L_col3 As Long
Dim L_col4 As Long
Dim L_col5 As Long
Dim m_QueryArray(33) As String

Private Sub L_CreateStatisticsReport() '¬„«—
    Dim i, j, reccount As Integer
    Dim ii, jj, kk, mm, nn As String
    
    G_AdoConn.Execute "Delete from tblTransReprort"
    G_AdoConn.Execute "Insert into tblTransReprort(F00_tTarikh) Values('" + txtFromDate + "')"
    
    m_QueryArray(0) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='0'"
    m_QueryArray(1) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='1'"
    m_QueryArray(2) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='2'"
    m_QueryArray(6) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='0'"
    m_QueryArray(7) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='1'"
    m_QueryArray(8) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='2'"
    m_QueryArray(9) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='0' and deleted=true "
    m_QueryArray(10) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='1' and deleted=true"
    m_QueryArray(11) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='2' and deleted=true "
    m_QueryArray(12) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and insurcost<>0 and deleted=false"
    
    
    For i = 0 To 12
        L_col1 = 0
        L_col2 = 0
        L_col3 = 0
        L_col4 = 0
        L_col5 = 0
        ii = "F0"
        jj = "F0"
        kk = "F0"
        mm = "F0"
        nn = "F0"
        
        If Not (i = 3 Or i = 4 Or i = 5) Then
            If G_MyRst2.State = 1 Then G_MyRst2.Close
            G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
            If G_MyRst2.RecordCount > 0 Then
                If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
                If Not IsNull(G_MyRst2.Fields(1)) Then L_col2 = G_MyRst2.Fields(1)
                If Not IsNull(G_MyRst2.Fields(2)) Then L_col3 = G_MyRst2.Fields(2)
                If Not IsNull(G_MyRst2.Fields(3)) Then L_col4 = G_MyRst2.Fields(3)
                If Not IsNull(G_MyRst2.Fields(4)) Then L_col5 = G_MyRst2.Fields(4)
            End If
        End If
        If 3 + 5 * i >= 10 Then ii = "F"
        If 4 + 5 * i >= 10 Then jj = "F"
        If 5 + 5 * i >= 10 Then kk = "F"
        If 6 + 5 * i >= 10 Then mm = "F"
        If 7 + 5 * i >= 10 Then nn = "F"
        G_MyQuery = "Update tblTransReprort set " + ii + Trim(Str(3 + 5 * i)) + "=" + Str(L_col1) + "," + jj + Trim(Str(4 + 5 * i)) + "=" + Str(L_col2) + "," + kk + Trim(Str(5 + 5 * i)) + "=" + Str(L_col3) + "," + mm + Trim(Str(6 + 5 * i)) + "=" + Str(L_col4) + "," + nn + Trim(Str(7 + 5 * i)) + "=" + Str(L_col5)
        G_AdoConn.Execute (G_MyQuery)
    Next i
    
    '„Õ«”»Â œÊﬁ»÷Â Â«
    m_QueryArray(0) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='0' and deleted=false"
    m_QueryArray(1) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='1' and deleted=false"
    m_QueryArray(2) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='2' and deleted=false"
    m_QueryArray(6) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='0' and deleted=false"
    m_QueryArray(7) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='1' and deleted=false"
    m_QueryArray(8) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='2' and deleted=false"
    m_QueryArray(9) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='0' and mid(ServiceType,11,1)='1' and deleted=true"
    m_QueryArray(10) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='1' and mid(ServiceType,11,1)='1' and deleted=true"
    m_QueryArray(11) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='2' and mid(ServiceType,11,1)='1' and deleted=true"
    
    For i = 0 To 11
        L_col1 = 0
        If Not (i = 3 Or i = 4 Or i = 5) Then
            If G_MyRst2.State = 1 Then G_MyRst2.Close
            G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
            If G_MyRst2.RecordCount > 0 Then
                If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
            End If
        End If
        G_MyQuery = "Update tblTransReprort set F" + Trim(Str(i + 68)) + "=" + Str(L_col1)
        G_AdoConn.Execute (G_MyQuery)
    Next
    frmReportViewer.Show 1
End Sub

Private Sub L_CreatePerformanceReport()   '⁄„·ﬂ—œ
    Dim i, j, reccount As Integer
    Dim ii, jj, kk, mm, nn As String
    Dim UserName As String
    Dim UserCode As String
    
    G_AdoConn.Execute "delete from tblTransReprort"
    G_AdoConn.Execute "Insert into tblTransReprort(F00_tTarikh) Values('" + txtFromDate + "')"
    
    
    G_MyQuery = "select * from tbluser where Ename= '" + txtUsername.Text + "'"
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If Not G_MyRst.EOF Then
        UserCode = Str(G_MyRst!UserCode)
        UserName = G_MyRst!PNAME
        G_MyRst.Close
    
        m_QueryArray(0) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='0' and usercode=" + UserCode
        m_QueryArray(1) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='1' and usercode=" + UserCode
        m_QueryArray(2) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and deleted=false and mid(servicetype,3,1)='2' and usercode=" + UserCode
        m_QueryArray(6) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='0' and usercode=" + UserCode
        m_QueryArray(7) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='1' and usercode=" + UserCode
        m_QueryArray(8) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and deleted=false and mid(servicetype,3,1)='2' and usercode=" + UserCode
        m_QueryArray(9) = "select count(*)  as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='0' and deleted=true and usercode=" + UserCode
        m_QueryArray(10) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='1' and deleted=true and usercode=" + UserCode
        m_QueryArray(11) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='2' and deleted=true and usercode=" + UserCode
        m_QueryArray(12) = "select count(*) as mycount,sum(weight) as sumweight,sum(insurcost) as sumbimeh,sum(PackageCost) as sumPackage,sum(totalcost) as sumcolprice  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and insurcost<>0 and deleted=false and usercode=" + UserCode
                
        For i = 0 To 12
            L_col1 = 0
            L_col2 = 0
            L_col3 = 0
            L_col4 = 0
            L_col5 = 0
            ii = "F0"
            jj = "F0"
            kk = "F0"
            mm = "F0"
            nn = "F0"
            
            If Not (i = 3 Or i = 4 Or i = 5) Then
                If G_MyRst2.State = 1 Then G_MyRst2.Close
                G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
                If G_MyRst2.RecordCount > 0 Then
                    If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
                    If Not IsNull(G_MyRst2.Fields(1)) Then L_col2 = G_MyRst2.Fields(1)
                    If Not IsNull(G_MyRst2.Fields(2)) Then L_col3 = G_MyRst2.Fields(2)
                    If Not IsNull(G_MyRst2.Fields(3)) Then L_col4 = G_MyRst2.Fields(3)
                    If Not IsNull(G_MyRst2.Fields(4)) Then L_col5 = G_MyRst2.Fields(4)
                End If
            End If
            If 3 + 5 * i >= 10 Then ii = "F"
            If 4 + 5 * i >= 10 Then jj = "F"
            If 5 + 5 * i >= 10 Then kk = "F"
            If 6 + 5 * i >= 10 Then mm = "F"
            If 7 + 5 * i >= 10 Then nn = "F"
            G_MyQuery = "Update tblTransReprort set F01_tCode=" + UserCode + ",F02_tName='" + UserName + "'," + ii + Trim(Str(3 + 5 * i)) + "=" + Str(L_col1) + "," + jj + Trim(Str(4 + 5 * i)) + "=" + Str(L_col2) + "," + kk + Trim(Str(5 + 5 * i)) + "=" + Str(L_col3) + "," + mm + Trim(Str(6 + 5 * i)) + "=" + Str(L_col4) + "," + nn + Trim(Str(7 + 5 * i)) + "=" + Str(L_col5)
            G_AdoConn.Execute (G_MyQuery)
        Next i
        
        '„Õ«”»Â œÊﬁ»÷Â Â«
        m_QueryArray(0) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='0' and deleted=false and usercode=" + UserCode
        m_QueryArray(1) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='1' and deleted=false and usercode=" + UserCode
        m_QueryArray(2) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='2' and deleted=false and usercode=" + UserCode
        m_QueryArray(6) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='0' and deleted=false and usercode=" + UserCode
        m_QueryArray(7) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='1' and deleted=false and usercode=" + UserCode
        m_QueryArray(8) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='0' and mid(ServiceType,11,1)='1' and mid(servicetype,3,1)='2' and deleted=false and usercode=" + UserCode
        m_QueryArray(9) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='0' and mid(ServiceType,11,1)='1' and deleted=true and usercode=" + UserCode
        m_QueryArray(10) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='1' and mid(ServiceType,11,1)='1' and deleted=true and usercode=" + UserCode
        m_QueryArray(11) = "select count(*) as mycount2 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,3,1)='2' and mid(ServiceType,11,1)='1' and deleted=true and usercode=" + UserCode
        
        For i = 0 To 11
            L_col1 = 0
            If Not (i = 3 Or i = 4 Or i = 5) Then
                If G_MyRst2.State = 1 Then G_MyRst2.Close
                G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
                If G_MyRst2.RecordCount > 0 Then
                    If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
                End If
            End If
            G_MyQuery = "Update tblTransReprort set F" + Trim(Str(i + 68)) + "=" + Str(L_col1)
            G_AdoConn.Execute (G_MyQuery)
        Next
        Screen.MousePointer = vbHourglass
        Sleep (1500)
        frmReportViewer.Show 1
    Else
        G_ShowMsg "ﬂ«—»— „Ê—œ ‰Ÿ—ÊÃÊœ ‰œ«—œ.", vbOKOnly, G_critical
        txtUsername.SetFocus
    End If
End Sub

Private Sub L_DepRep()
    On Error GoTo Err_handle

    If txtFromDate = "" Or txtToDate = "" Then
        G_ShowMsg " «—ÌŒ —« »ÿÊ— ’ÕÌÕ Ê«—œ ‰„«∆Ìœ", vbOKOnly, G_info
        Exit Sub
    End If
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "delete * from tblTransReprort"
    G_AdoConn.Execute "insert into tblTransReprort(F03,F01_tCode,F02_tName,F81_tHeader,F04,F05,F00_tTarikh,F06)" & _
        " select tblRegister.RegId,tblRegister.RegDate,tblRegister.DISPATCH_CODE,tblRegister.RegHeader,tblRegister.RegType,tblRegister.ParcelCount, tblDispatch.DISPATCH_PDATE,tblDispatch.ISOPEN" _
        + " from tblRegister inner join tblDispatch on tblRegister.DISPATCH_CODE=tblDispatch.DISPATCH_CODE where tblDispatch.DISPATCH_PDATE>='" & Trim(txtFromDate) & "' and tblDispatch.DISPATCH_PDATE<='" & Trim(txtToDate) & "'"
    Sleep (1500)
    frmReportViewer.Show 1
    Exit Sub
Err_handle:
    If Err.Number = -2147217900 Then
        Resume
    Else
        G_ShowMsg Err.Description, vbOKOnly, G_critical
    End If
End Sub

Private Sub L_PreReg()
    Dim s1, s2 As String
    Dim i As Integer
    
    If optPreReg(0).Value = True Then
        If txtFrom = "" Or txtTo = "" Then
            G_ShowMsg "‘„«—Â „—”Ê·Â —« Ê«—œ ‰„«∆Ìœ", vbOKOnly, G_info
            If txtFrom = "" Then
                txtFrom.SetFocus
            Else
                txtTo.SetFocus
            End If
        Else
            txtFrom = Trim(txtFrom)
            txtTo = Trim(txtTo)
            G_MyQuery = "select distinct Regid from tblParcels where Regid<>-1 and val(mid((Uniquecode),11,8)) >=" + txtFrom + " and val(mid((Uniquecode),11,8)) <=" + txtTo
            If G_MyRst.State = 1 Then G_MyRst.Close
            G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
            If G_MyRst.RecordCount = 0 Then
                G_ShowMsg "ÂÌç À» Ì »—«Ì «Ì‰ „—”Ê·«  ÊÃÊœ ‰œ«—œ!", vbOKOnly, G_exclamation
                txtFrom.SetFocus
            ElseIf G_MyRst.RecordCount > 1 Then
                s1 = "„—”Ê·«  „Ê—œ ‰Ÿ— ‘„« œ— À» Â«Ì “Ì— À»  ê—œÌœÂù«‰œ. ÌﬂÌ «— ¬‰Â« —« Ê«—œ ‰„«ÌÌœ: " + Chr(10) + Chr(13)
                s2 = ""
                For i = 1 To G_MyRst.RecordCount
                    s2 = Str(G_MyRst!RegId) + "," + s2
                    G_MyRst.MoveNext
                Next
                s2 = Mid(s2, 1, Len(s2) - 1)
                G_ShowMsg s1 + s2, vbOKOnly, G_info
                txtFrom.SetFocus
            Else
                G_NewRegId = G_MyRst!RegId
                frmReportViewer.Show 1
            End If
            G_MyRst.Close
        End If
    Else
        If optPreReg(1).Value = True And txtRegId = "" Then
            G_ShowMsg "‘„«—Â À»  —« Ê«—œ ‰„«∆Ìœ", vbOKOnly, G_info
            txtRegId.SetFocus
            Exit Sub
        Else
            G_NewRegId = Val(txtRegId)
            frmReportViewer.Show 1
        End If
    End If
End Sub

Private Sub L_EmsStatistics()
    Dim i As Byte
    
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "Delete from tblTransReprort"
    G_AdoConn.Execute "Insert into tblTransReprort(F00_tTarikh) Values('" + txtFromDate + "')"
    
    m_QueryArray(0) = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -⁄«œÌ
    m_QueryArray(1) = "select  count(UniqueCode)  as count1  ,sum(TotalCost) as cost1  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '‘Â—Ì- »” Â -⁄«œÌ
    m_QueryArray(2) = "select  count(UniqueCode)  as count2  ,sum(TotalCost) as cost2  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -œÊﬁ»÷Â
    m_QueryArray(3) = "select  count(UniqueCode)  as count3  ,sum(TotalCost) as cost3  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '‘Â—Ì- »” Â -œÊﬁ»÷Â
    m_QueryArray(4) = "select  count(UniqueCode)  as count4  ,sum(TotalCost) as cost4  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -»Ì„Â
    m_QueryArray(5) = "select  count(UniqueCode)  as count5  ,sum(TotalCost) as cost5  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '‘Â—Ì- »” Â -»Ì„Â
    m_QueryArray(6) = "select  count(UniqueCode)  as count6  ,sum(TotalCost) as cost6  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(7) = "select  count(UniqueCode)  as count7  ,sum(TotalCost) as cost7  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '‘Â—Ì- »” Â -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(8) = "select  count(UniqueCode)  as count8  ,sum(TotalCost) as cost8  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)='1'  and deleted=false"     '‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÌ
    m_QueryArray(9) = "select  count(UniqueCode)  as count9  ,sum(TotalCost) as cost9  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)='1'  and deleted=false"      '‘Â—Ì- »” Â -ﬁ—«—œ«œÌ
    m_QueryArray(10) = "select count(UniqueCode)  as count10 ,sum(TotalCost) as cost10 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)='3'  and deleted=false"     '‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(11) = "select count(UniqueCode)  as count11 ,sum(TotalCost) as cost11 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)='3'  and deleted=false"     '‘Â—Ì- »” Â -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(12) = "select count(UniqueCode)  as count12 ,sum(TotalCost) as cost12 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -⁄«œÌ
    m_QueryArray(13) = "select count(UniqueCode)  as count13 ,sum(TotalCost) as cost13 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -⁄«œÌ
    m_QueryArray(14) = "select count(UniqueCode)  as count14 ,sum(TotalCost) as cost14 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -œÊﬁ»÷Â
    m_QueryArray(15) = "select count(UniqueCode)  as count15 ,sum(TotalCost) as cost15 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -œÊﬁ»÷Â
    m_QueryArray(16) = "select count(UniqueCode)  as count16 ,sum(TotalCost) as cost16 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -»Ì„Â
    m_QueryArray(17) = "select count(UniqueCode)  as count17 ,sum(TotalCost) as cost17 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -»Ì„Â
    m_QueryArray(18) = "select count(UniqueCode)  as count18 ,sum(TotalCost) as cost18 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(19) = "select count(UniqueCode)  as count19 ,sum(TotalCost) as cost19 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(20) = "select count(UniqueCode)  as count20 ,sum(TotalCost) as cost20 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)='1'  and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÌ
    m_QueryArray(21) = "select count(UniqueCode)  as count21 ,sum(TotalCost) as cost21 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)='1'  and deleted=false"      '»Ì‰ ‘Â—Ì- »” Â -ﬁ—«—œ«œÌ
    m_QueryArray(22) = "select count(UniqueCode)  as count22 ,sum(TotalCost) as cost22 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)='3'  and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(23) = "select count(UniqueCode)  as count23 ,sum(TotalCost) as cost23 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)='3'  and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(24) = "select count(UniqueCode)  as count24 ,sum(TotalCost) as cost24 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='102' and deleted=false"     'Œ«—ÃÂ- Å«ﬂ 
    m_QueryArray(25) = "select count(UniqueCode)  as count25 ,sum(TotalCost) as cost25 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='112' and deleted=false"     'Œ«—ÃÂ- »” Â
    m_QueryArray(26) = "select count(UniqueCode)  as count26 ,sum(TotalCost) as cost26 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,2)='10' and deleted=True"     '»«ÿ·Â- Å«ﬂ 
    m_QueryArray(27) = "select count(UniqueCode)  as count27 ,sum(TotalCost) as cost27 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,2)='11' and deleted=True"     '»«ÿ·Â- »” Â
    
    
    For i = 0 To 27
        L_col1 = 0
        L_col2 = 0
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If G_MyRst2.RecordCount > 0 Then
            If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
            If Not IsNull(G_MyRst2.Fields(1)) Then L_col2 = G_MyRst2.Fields(1)
        End If
        G_MyQuery = "Update tblTransReprort set F" + Format(Str(i + 3), "00") + "=" + Str(L_col1) + ",F" + Format(Str(i + 31), "00") + "=" + Str(L_col2)
        G_AdoConn.Execute (G_MyQuery)
    Next
    Sleep (1500)
    frmReportViewer.Show 1
End Sub

Private Sub L_NotEmsStatistics()
    Dim i As Byte
    
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "Delete from tblTransReprort"
    G_AdoConn.Execute "Insert into tblTransReprort(F00_tTarikh) Values('" + txtFromDate + "')"
    
    m_QueryArray(0) = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -⁄«œÌ
    m_QueryArray(1) = "select  count(UniqueCode)  as count1  ,sum(TotalCost) as cost1  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '‘Â—Ì- »” Â -⁄«œÌ
    m_QueryArray(2) = "select  count(UniqueCode)  as count2  ,sum(TotalCost) as cost2  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -œÊﬁ»÷Â
    m_QueryArray(3) = "select  count(UniqueCode)  as count3  ,sum(TotalCost) as cost3  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '‘Â—Ì- »” Â -œÊﬁ»÷Â
    m_QueryArray(4) = "select  count(UniqueCode)  as count4  ,sum(TotalCost) as cost4  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -»Ì„Â
    m_QueryArray(5) = "select  count(UniqueCode)  as count5  ,sum(TotalCost) as cost5  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '‘Â—Ì- »” Â -»Ì„Â
    m_QueryArray(6) = "select  count(UniqueCode)  as count6  ,sum(TotalCost) as cost6  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '‘Â—Ì- Å«ﬂ  -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(7) = "select  count(UniqueCode)  as count7  ,sum(TotalCost) as cost7  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '‘Â—Ì- »” Â -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(8) = "select  count(UniqueCode)  as count8  ,sum(TotalCost) as cost8  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)='1'  and deleted=false"     '‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÌ
    m_QueryArray(9) = "select  count(UniqueCode)  as count9  ,sum(TotalCost) as cost9  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)='1'  and deleted=false"      '‘Â—Ì- »” Â -ﬁ—«—œ«œÌ
    m_QueryArray(10) = "select count(UniqueCode)  as count10 ,sum(TotalCost) as cost10 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='000' and mid(servicetype,5,1)='3'  and deleted=false"     '‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(11) = "select count(UniqueCode)  as count11 ,sum(TotalCost) as cost11 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='010' and mid(servicetype,5,1)='3'  and deleted=false"     '‘Â—Ì- »” Â -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(12) = "select count(UniqueCode)  as count12 ,sum(TotalCost) as cost12 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -⁄«œÌ
    m_QueryArray(13) = "select count(UniqueCode)  as count13 ,sum(TotalCost) as cost13 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -⁄«œÌ
    m_QueryArray(14) = "select count(UniqueCode)  as count14 ,sum(TotalCost) as cost14 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -œÊﬁ»÷Â
    m_QueryArray(15) = "select count(UniqueCode)  as count15 ,sum(TotalCost) as cost15 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur=0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -œÊﬁ»÷Â
    m_QueryArray(16) = "select count(UniqueCode)  as count16 ,sum(TotalCost) as cost16 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -»Ì„Â
    m_QueryArray(17) = "select count(UniqueCode)  as count17 ,sum(TotalCost) as cost17 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='0' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -»Ì„Â
    m_QueryArray(18) = "select count(UniqueCode)  as count18 ,sum(TotalCost) as cost18 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(19) = "select count(UniqueCode)  as count19 ,sum(TotalCost) as cost19 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)<>'1' and mid(servicetype,5,1)<>'3' and mid(ServiceType,11,1)='1' and ExpInsur>0 and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -»Ì„Â œÊﬁ»÷Â
    m_QueryArray(20) = "select count(UniqueCode)  as count20 ,sum(TotalCost) as cost20 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)='1'  and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÌ
    m_QueryArray(21) = "select count(UniqueCode)  as count21 ,sum(TotalCost) as cost21 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)='1'  and deleted=false"      '»Ì‰ ‘Â—Ì- »” Â -ﬁ—«—œ«œÌ
    m_QueryArray(22) = "select count(UniqueCode)  as count22 ,sum(TotalCost) as cost22 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='001' and mid(servicetype,5,1)='3'  and deleted=false"     '»Ì‰ ‘Â—Ì- Å«ﬂ  -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(23) = "select count(UniqueCode)  as count23 ,sum(TotalCost) as cost23 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='011' and mid(servicetype,5,1)='3'  and deleted=false"     '»Ì‰ ‘Â—Ì- »” Â -ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    m_QueryArray(24) = "select count(UniqueCode)  as count24 ,sum(TotalCost) as cost24 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='002' and deleted=false"     'Œ«—ÃÂ- Å«ﬂ 
    m_QueryArray(25) = "select count(UniqueCode)  as count25 ,sum(TotalCost) as cost25 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='012' and deleted=false"     'Œ«—ÃÂ- »” Â
    m_QueryArray(26) = "select count(UniqueCode)  as count26 ,sum(TotalCost) as cost26 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,2)='00' and deleted=True"     '»«ÿ·Â- Å«ﬂ 
    m_QueryArray(27) = "select count(UniqueCode)  as count27 ,sum(TotalCost) as cost27 from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,2)='01' and deleted=True"     '»«ÿ·Â- »” Â
    
    
    For i = 0 To 27
        L_col1 = 0
        L_col2 = 0
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If G_MyRst2.RecordCount > 0 Then
            If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
            If Not IsNull(G_MyRst2.Fields(1)) Then L_col2 = G_MyRst2.Fields(1)
        End If
        G_MyQuery = "Update tblTransReprort set F" + Format(Str(i + 3), "00") + "=" + Str(L_col1) + ",F" + Format(Str(i + 31), "00") + "=" + Str(L_col2)
        G_AdoConn.Execute (G_MyQuery)
    Next
    Sleep (1500)
    frmReportViewer.Show 1
End Sub

Private Sub L_EmsLservice()
    Dim i As Integer
        
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "Delete from tblTransReprort"
    G_MyQuery = "SELECT DISTINCT tblParcels.Cno, tblLocalContracts.Caption" _
        + " FROM tblLocalContracts INNER JOIN tblParcels ON tblLocalContracts.Cno = tblParcels.Cno" _
        + " WHERE tblParcels.Receiptdate>='" & Trim(txtFromDate.Text) & "' and tblParcels.Receiptdate<='" & Trim(txtToDate.Text) & "' And tblParcels.Deleted=False"
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open "tblTransReprort", G_AdoConn, adOpenDynamic, adLockOptimistic
    For i = 1 To G_MyRst.RecordCount
        G_PrimaryRs.AddNew
        G_PrimaryRs!F01_tCode = G_MyRst!Cno
        G_PrimaryRs!F02_tName = G_MyRst!Caption
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" '‘Â—Ì- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F03 = G_MyRst2!count0 Else G_PrimaryRs!F03 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F04 = G_MyRst2!cost0 Else G_PrimaryRs!F04 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" '‘Â—Ì- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F05 = G_MyRst2!count0 Else G_PrimaryRs!F05 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F06 = G_MyRst2!cost0 Else G_PrimaryRs!F06 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" '»Ì‰ ‘Â—Ì- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F07 = G_MyRst2!count0 Else G_PrimaryRs!F07 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F08 = G_MyRst2!cost0 Else G_PrimaryRs!F08 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" '»Ì‰ ‘Â—Ì- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F09 = G_MyRst2!count0 Else G_PrimaryRs!F09 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F10 = G_MyRst2!cost0 Else G_PrimaryRs!F10 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='102' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" 'Œ«—ÃÂ- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F11 = G_MyRst2!count0 Else G_PrimaryRs!F11 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F12 = G_MyRst2!cost0 Else G_PrimaryRs!F12 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='112' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" 'Œ«—ÃÂ- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F13 = G_MyRst2!count0 Else G_PrimaryRs!F13 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F14 = G_MyRst2!cost0 Else G_PrimaryRs!F14 = 0
        
        G_MyQuery = "select  sum(Discount) as sumofdiscount  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,1)='1' and mid(servicetype,5,1)='1'  and deleted=false and cno='" + G_MyRst!Cno + "'" 'Ã„⁄  Œ›Ì›
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!sumofdiscount) Then G_PrimaryRs!F15 = G_MyRst2!sumofdiscount Else G_PrimaryRs!F15 = 0
        
        G_PrimaryRs.Update
        G_MyRst.MoveNext
    Next
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    If G_MyRst.State = 1 Then G_MyRst.Close
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    Sleep (500)
    frmReportViewer.Show 1
End Sub

Private Sub L_EmsGservice()
    Dim i As Integer
        
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "Delete from tblTransReprort"
    G_MyQuery = "SELECT DISTINCT tblParcels.Cno, CONTRACTS.Caption" _
        + " FROM CONTRACTS INNER JOIN tblParcels ON CONTRACTS.Cno = tblParcels.Cno" _
        + " WHERE tblParcels.Receiptdate>='" & Trim(txtFromDate.Text) & "' and tblParcels.Receiptdate<='" & Trim(txtToDate.Text) & "' And tblParcels.Deleted=False"
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open "tblTransReprort", G_AdoConn, adOpenDynamic, adLockOptimistic
    For i = 1 To G_MyRst.RecordCount
        G_PrimaryRs.AddNew
        G_PrimaryRs!F01_tCode = G_MyRst!Cno
        G_PrimaryRs!F02_tName = G_MyRst!Caption
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='100' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" '‘Â—Ì- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F03 = G_MyRst2!count0 Else G_PrimaryRs!F03 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F04 = G_MyRst2!cost0 Else G_PrimaryRs!F04 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='110' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" '‘Â—Ì- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F05 = G_MyRst2!count0 Else G_PrimaryRs!F05 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F06 = G_MyRst2!cost0 Else G_PrimaryRs!F06 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='101' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" '»Ì‰ ‘Â—Ì- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F07 = G_MyRst2!count0 Else G_PrimaryRs!F07 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F08 = G_MyRst2!cost0 Else G_PrimaryRs!F08 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='111' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" '»Ì‰ ‘Â—Ì- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F09 = G_MyRst2!count0 Else G_PrimaryRs!F09 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F10 = G_MyRst2!cost0 Else G_PrimaryRs!F10 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='102' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" 'Œ«—ÃÂ- Å«ﬂ 
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F11 = G_MyRst2!count0 Else G_PrimaryRs!F11 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F12 = G_MyRst2!cost0 Else G_PrimaryRs!F12 = 0
        G_MyQuery = "select  count(UniqueCode)  as count0  ,sum(TotalCost) as cost0  from tblParcels where receiptdate>='" & Trim(txtFromDate.Text) & "' and receiptdate<='" & Trim(txtToDate.Text) & "' and mid(servicetype,1,3)='112' and mid(servicetype,5,1)='3'  and deleted=false and cno='" + G_MyRst!Cno + "'" 'Œ«—ÃÂ- »” Â
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If Not IsNull(G_MyRst2!count0) Then G_PrimaryRs!F13 = G_MyRst2!count0 Else G_PrimaryRs!F13 = 0
        If Not IsNull(G_MyRst2!cost0) Then G_PrimaryRs!F14 = G_MyRst2!cost0 Else G_PrimaryRs!F14 = 0
        G_PrimaryRs.Update
        G_MyRst.MoveNext
    Next
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    If G_MyRst.State = 1 Then G_MyRst.Close
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    Sleep (500)
    frmReportViewer.Show 1
End Sub

Private Sub L_LServiceTransaction()
    On Error GoTo Err_label
    
    Screen.MousePointer = vbHourglass
    Sleep (1500)
    frmReportViewer.Show 1
    Exit Sub
Err_label:
    Screen.MousePointer = vbDefault
    Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
End Sub

Private Sub L_WeightGroup()
    On Error GoTo Err_label
    Dim strFieldName As String
    Dim i As Byte
    
    Screen.MousePointer = vbHourglass
    m_QueryArray(1) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>0    And tblParcels.Weight<=500  and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(2) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>0    And tblParcels.Weight<=500  and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(3) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>0    And tblParcels.Weight<=500  and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(4) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>500  And tblParcels.Weight<=1000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(5) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>500  And tblParcels.Weight<=1000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(6) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>500  And tblParcels.Weight<=1000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(7) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>1000 And tblParcels.Weight<=1500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(8) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>1000 And tblParcels.Weight<=1500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(9) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>1000 And tblParcels.Weight<=1500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(10) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>1500 And tblParcels.Weight<=2000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(11) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>1500 And tblParcels.Weight<=2000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(12) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>1500 And tblParcels.Weight<=2000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(13) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>2000 And tblParcels.Weight<=2500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(14) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>2000 And tblParcels.Weight<=2500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(15) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>2000 And tblParcels.Weight<=2500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(16) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>2500 And tblParcels.Weight<=3000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(17) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>2500 And tblParcels.Weight<=3000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(18) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>2500 And tblParcels.Weight<=3000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(19) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>3000 And tblParcels.Weight<=3500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(20) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>3000 And tblParcels.Weight<=3500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(21) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>3000 And tblParcels.Weight<=3500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(22) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>3500 And tblParcels.Weight<=4000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(23) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>3500 And tblParcels.Weight<=4000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(24) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>3500 And tblParcels.Weight<=4000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(25) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>4000 And tblParcels.Weight<=4500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(26) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>4000 And tblParcels.Weight<=4500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(27) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>4000 And tblParcels.Weight<=4500 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(28) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>4500 And tblParcels.Weight<=5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(29) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>4500 And tblParcels.Weight<=5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(30) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>4500 And tblParcels.Weight<=5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(31) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='1' AND tblParcels.Weight>5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(32) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='2' AND tblParcels.Weight>5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    m_QueryArray(33) = "SELECT Count(tblParcels.Uniquecode) FROM COUNTRY INNER JOIN tblParcels ON COUNTRY.CountryCode = tblParcels.DestCode WHERE mid(servicetype,1,1)='1' AND tblParcels.Deleted=False AND COUNTRY.GroupEMS='3' AND tblParcels.Weight>5000 and tblParcels.Receiptdate>='" + Trim(txtFromDate.Text) + "' and tblParcels.Receiptdate<='" + Trim(txtToDate.Text) + "'"
    
    G_AdoConn.Execute "Delete from tblTransReprort"
    
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open "tblTransReprort", G_AdoConn, adOpenDynamic, adLockOptimistic
    G_PrimaryRs.AddNew
    For i = 1 To 33
        strFieldName = "F" + Format(i, "00")
        
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open m_QueryArray(i), G_AdoConn, adOpenForwardOnly, adLockReadOnly
        L_col1 = 0
        If Not G_MyRst2.EOF Then
            If Not IsNull(G_MyRst2.Fields(0)) Then L_col1 = G_MyRst2.Fields(0)
        End If
        G_PrimaryRs(strFieldName) = L_col1
    Next
    G_PrimaryRs.Update
    
    Sleep (1500)
    frmReportViewer.Show 1
    Exit Sub
Err_label:
    Screen.MousePointer = vbDefault
    Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
End Sub

Private Sub cboLservice_KeyDown(KeyCode As Integer, Shift As Integer)
    If KeyCode = vbKeyDelete Then
        cboLservice.ListIndex = -1
    End If
End Sub

Private Sub cmdOk_Click()
    If G_BoxesValidate(Me) Then
        Select Case G_Rptno
            Case enmRptTraffic1, enmRptTraffic2, enmRptTraffic3
                G_FromHDate = txtYear.Text + "/" + Format(1 + cboMonth.ListIndex, "00") + "/01"
                If cboMonth.ListIndex = 12 Then
                    G_ToHDate = Format(1 + txtYear, "0000") + "/01/01"
                Else
                    G_ToHDate = txtYear.Text + "/" + Format(2 + cboMonth.ListIndex, "00") + "/01"
                End If
                frmReportViewer.Show 1
            Case enmRptStatistics  '¬„«—
                L_CreateStatisticsReport
            Case enmRptPerformance   '⁄„·ﬂ—œ
                L_CreatePerformanceReport
            Case enmRptDispatch   'œÅ‘
                L_DepRep
            Case enmRptRegister   'À» Â«Ì ﬁ»·Ì
                L_PreReg
            Case enmRptEmsStatistics  '¬„«— ÅÌ‘ «“
                L_EmsStatistics
            Case enmRptNotEmsStatistics  '¬„«— „ ⁄«—›
                L_NotEmsStatistics
            Case enmRptLservice  '¬„«— ﬁ—«—œ«œ
                L_EmsLservice
            Case enmRptGservice  '¬„«— ﬁ—«—œ«œÂ«Ì ”—«”—Ì
                L_EmsGservice
            Case enmRptWeightGroup         '¬„«— Ê“‰Ì
                L_WeightGroup
            ''  LServiceTransaction Report
            Case enmRptLserviceTransaction         '¬„«— „—”Ê·«  ﬁ—«—œ«œ
                L_LServiceTransaction
            Case enmDigitalRegisteration
                m_BuildDigitalRegisteration (txtDispatchCode.Text)
        End Select
    End If
End Sub

Private Sub cmdReport_Click(Index As Integer)
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Call G_SetKeyboard(enmPersian)
End Sub

Private Sub optPreReg_Click(Index As Integer)
    If optPreReg(0).Value = True Then
        txtFrom.Enabled = True
        txtTo.Enabled = True
        Label1(2).Enabled = True
        Label1(3).Enabled = True
        txtRegId.Enabled = False
        Label1(4).Enabled = False
    Else
        txtFrom.Enabled = False
        txtTo.Enabled = False
        Label1(2).Enabled = False
        Label1(3).Enabled = False
        txtRegId.Enabled = True
        Label1(4).Enabled = True
    End If
End Sub

Private Sub L_FillContractsCombo()
'    G_MyQuery = "select * from tbllocalService"
'
'    If G_MyRst2.State = 1 Then G_MyRst2.Close
'    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
'    If G_MyRst2.RecordCount > 0 Then
'        G_MyRst2.MoveLast
'        G_MyRst2.MoveFirst
'    End If
'    cboLservice.Clear
'    While Not G_MyRst2.EOF
'        If IsNull(G_MyRst2!F1_tCaption) Then
'            cboLservice.AddItem ""
'        Else
'            cboLservice.AddItem G_MyRst2!F1_tCaption
'            G_ContractNumber(cboLservice.NewIndex) = G_MyRst2!F0_tCno
'        End If
'        G_MyRst2.MoveNext
'    Wend
'    G_MyRst2.Close

    G_MyQuery = "select * from tblLocalContracts"
    
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    If G_MyRst2.RecordCount > 0 Then
        G_MyRst2.MoveLast
        G_MyRst2.MoveFirst
    End If
    cboLservice.Clear
    While Not G_MyRst2.EOF
        If IsNull(G_MyRst2!Caption) Then
            cboLservice.AddItem ""
        Else
            cboLservice.AddItem G_MyRst2!Caption
            G_ContractNumber(cboLservice.NewIndex) = G_MyRst2!Cno
        End If
        G_MyRst2.MoveNext
    Wend
    G_MyRst2.Close

End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    Dim NodeX As Node
    Dim mm, yyyy  As String
    
    Call G_SetKeyboard(enmEnglish)
    mm = Mid(G_CurrentDate, 6, 2)
    yyyy = Mid(G_CurrentDate, 1, 4)
    cboMonth.ListIndex = Val(mm - 1)
    txtFromDate = G_CurrentDate
    txtToDate = G_CurrentDate
    G_Rptno = 0
    L_FillContractsCombo
    trReport.Nodes.Clear
    txtYear.Text = yyyy
    G_Rptno = enmRptTraffic1
    Set NodeX = trReport.Nodes.Add(, , "RptTraffic", "ê“«—‘ „«Â«‰Â œ› — ⁄„·ﬂ—œ")
    Set NodeX = trReport.Nodes.Add(, , "RptStatistics", "¬„«—")
    Set NodeX = trReport.Nodes.Add(, , "RptPerformance", "⁄„·ﬂ—œ")
    Set NodeX = trReport.Nodes.Add(, , "RptDispatch", "»—êÂ «⁄·«„ œÅ‘")
    Set NodeX = trReport.Nodes.Add(, , "RptRegister", "ê“«—‘ À» Â«Ì ﬁ»·Ì")
    Set NodeX = trReport.Nodes.Add(, , "RptLservice", "¬„«— Ê „€«Ì—  ﬁ—«—œ«œÂ«")
    Set NodeX = trReport.Nodes.Add(, , "RptGservice", "¬„«— ﬁ—«—œ«œÂ«Ì ”—«”—Ì")
    Set NodeX = trReport.Nodes.Add(, , "RptWeightGroup", "¬„«— Ê“‰Ì Œ«—ÃÂ")
    Set NodeX = trReport.Nodes.Add(, , "RptLserviceTransaction", "¬„«— „—”Ê·«  ﬁ—«—œ«œÌ")
    Set NodeX = trReport.Nodes.Add(, , "DigitalRegisteration", " ÂÌÂ À»  œÌÃÌ «·")
    
    Set NodeX = trReport.Nodes.Add("RptTraffic", tvwChild, "RptTraffic1", "’›ÕÂ «Ê·")
    Set NodeX = trReport.Nodes.Add("RptTraffic", tvwChild, "RptTraffic2", "’›ÕÂ œÊ„")
    Set NodeX = trReport.Nodes.Add("RptTraffic", tvwChild, "RptTraffic3", "’›ÕÂ ”Ê„")
    Set NodeX = trReport.Nodes.Add("RptStatistics", tvwChild, "RptStatisticsAll", "ﬂ·Ì")
    Set NodeX = trReport.Nodes.Add("RptStatistics", tvwChild, "RptEmsStatistics", "ÅÌ‘ «“")
    Set NodeX = trReport.Nodes.Add("RptStatistics", tvwChild, "RptNotEmsStatistics", "„ ⁄«—›")
    
    NodeX.EnsureVisible
End Sub

Private Sub trReport_NodeClick(ByVal Node As MSComctlLib.Node)
    lblHint.Caption = ""
    G_Rptno = 0
    fraDispatch.Visible = False
    fraTraffic.Visible = False
    fraUser.Visible = False
    fraPreReg.Visible = False
    fraLservice.Visible = False
    fraTarikh.Visible = False
    Select Case Node.Key
        Case "RptTraffic1"
            G_Rptno = enmRptTraffic1
            fraTraffic.Visible = True
            lblHint.Caption = "ê“«—‘ ’›ÕÂ «Ê· œ› — ⁄„·ﬂ—œ"
        Case "RptTraffic2"
            G_Rptno = enmRptTraffic2
            fraTraffic.Visible = True
            lblHint.Caption = "ê“«—‘ ’›ÕÂ œÊ„ œ› — ⁄„·ﬂ—œ"
        Case "RptTraffic3"
            G_Rptno = enmRptTraffic3
            fraTraffic.Visible = True
            lblHint.Caption = "ê“«—‘ ’›ÕÂ ”Ê„ œ› — ⁄„·ﬂ—œ"
        Case "RptStatisticsAll"
            G_Rptno = enmRptStatistics
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— ﬂ·Ì ›⁄«·Ì Â«Ì œ› — Å” Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptEmsStatistics"
            G_Rptno = enmRptEmsStatistics
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— ﬂ·Ì ›⁄«·Ì Â«Ì Œœ„«  ÅÌ‘ «“ œ› — Å” Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptNotEmsStatistics"
            G_Rptno = enmRptNotEmsStatistics
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— ﬂ·Ì ›⁄«·Ì Â«Ì Œœ„«  „ ⁄«—› œ› — Å” Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptPerformance"
            G_Rptno = enmRptPerformance
            fraTarikh.Visible = True
            fraUser.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— ﬂ·Ì ›⁄«·Ì Â«Ì „ ’œÌ«‰ »«ÃÂùÂ«Ì œ› — Å” Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptDispatch"
            G_Rptno = enmRptDispatch
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— œÅ‘Â«Ì „—”Ê·«  ÅÌ‘ «“ œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptRegister"
            G_Rptno = enmRptRegister
            fraPreReg.Visible = True
            lblHint.Caption = "ê“«—‘ À» Â«Ì ê—› Â ‘œÂ „—”Ê·« "
        Case "RptLservice"
            G_Rptno = enmRptLservice
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— „—”Ê·«  ÅÌ‘ «“ ﬁ—«—œ«œÂ«Ì œ«Œ·Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptGservice"
            G_Rptno = enmRptGservice
            fraTarikh.Visible = True
            lblHint.Caption = "ê“«—‘ ¬„«— „—”Ê·«  ÅÌ‘ «“ ﬁ—«—œ«œÂ«Ì ”—«”—Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptWeightGroup"
            G_Rptno = enmRptWeightGroup
            fraTarikh.Visible = True
            lblHint.Caption = "ÃœÊ· ¬„«— „—”Ê·«  Œ«—ÃÂ ÅÌ‘ «“ »Â  ›ﬂÌﬂ —œÂ Ê“‰Ì œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "RptLserviceTransaction"
            G_Rptno = enmRptLserviceTransaction
            fraLservice.Visible = True
            fraTarikh.Visible = True
            cboLservice.ListIndex = -1
            lblHint.Caption = "·Ì”  „—”Ê·«  ÅÌ‘ «“ Ìﬂ ﬁ—«—œ«œ „Õ·Ì Œ«’ œ— »«“Â “„«‰Ì „Ê—œ ‰Ÿ—"
        Case "DigitalRegisteration"
            G_Rptno = enmDigitalRegisteration
            fraDispatch.Visible = True
            lblHint.Caption = " ÂÌÂ À»  œÌÃÌ «· »—«Ì Ìﬂ œÅ‘"
    End Select
End Sub

