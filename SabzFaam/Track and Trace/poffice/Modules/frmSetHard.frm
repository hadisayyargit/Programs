VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.Form frmSetHard 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   " ‰ŸÌ„«  ”Œ  «›“«—Ì "
   ClientHeight    =   5670
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   6510
   Icon            =   "frmSetHard.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   5670
   ScaleWidth      =   6510
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdHardset 
      Caption         =   " ‰ŸÌ„"
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
      Left            =   3293
      RightToLeft     =   -1  'True
      TabIndex        =   3
      Top             =   5040
      Width           =   1455
   End
   Begin VB.CommandButton Cmdexit 
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
      Left            =   1763
      RightToLeft     =   -1  'True
      TabIndex        =   4
      ToolTipText     =   "»«“ê‘  »Â ›—„ «’·Ì"
      Top             =   5040
      Width           =   1455
   End
   Begin TabDlg.SSTab SSTab1 
      Height          =   5655
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   6495
      _ExtentX        =   11456
      _ExtentY        =   9975
      _Version        =   393216
      Style           =   1
      Tabs            =   2
      TabHeight       =   520
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   " —«“Ê"
      TabPicture(0)   =   "frmSetHard.frx":030A
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "fraTarazoo"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).ControlCount=   1
      TabCaption(1)   =   "ç«Åê—"
      TabPicture(1)   =   "frmSetHard.frx":0326
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "MSComm2"
      Tab(1).Control(1)=   "fraPrinter"
      Tab(1).Control(2)=   "fraBprinter"
      Tab(1).ControlCount=   3
      Begin VB.Frame fraBprinter 
         Caption         =   "ç«Åê— »«—ﬂœ"
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
         Height          =   3375
         Left            =   -74880
         RightToLeft     =   -1  'True
         TabIndex        =   22
         Top             =   1440
         Width           =   6255
         Begin VB.Frame fraBarcode 
            Caption         =   " ‰Ê⁄ ç«Åê— »«—ﬂœ"
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
            Left            =   240
            RightToLeft     =   -1  'True
            TabIndex        =   23
            Top             =   720
            Width           =   5535
            Begin VB.CommandButton btnSetMemory 
               Caption         =   " ‰ŸÌ„ Õ«›ŸÂ ç«Åê—"
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
               RightToLeft     =   -1  'True
               TabIndex        =   19
               Top             =   1320
               Width           =   1575
            End
            Begin VB.OptionButton opt3742 
               Caption         =   "Eltron TLP3642/3742"
               Height          =   195
               Left            =   2880
               TabIndex        =   17
               Top             =   360
               Width           =   1935
            End
            Begin VB.OptionButton opt2742 
               Caption         =   "Eltron TLP2642/2742"
               Height          =   195
               Left            =   240
               TabIndex        =   16
               Top             =   360
               Value           =   -1  'True
               Width           =   1935
            End
            Begin VB.ComboBox cboPort 
               Height          =   315
               ItemData        =   "frmSetHard.frx":0342
               Left            =   2760
               List            =   "frmSetHard.frx":034C
               Style           =   2  'Dropdown List
               TabIndex        =   18
               Top             =   720
               Width           =   975
            End
            Begin VB.Label Label1 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   " ÊÃÂ:  ‰ŸÌ„ Õ«›Ÿ… ç«Åê—° ›ﬁÿ Ìﬂ »«— »—«Ì Â— ç«Åê— »«—ﬂœ «‰Ã«„ „Ìù‘Êœ. ﬁ»· «“ “œ‰ ﬂ·Ìœ° «“ —Ê‘‰ »Êœ‰ ¬‰ „ÿ„∆‰ ‘ÊÌœ."
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
               Height          =   585
               Index           =   2
               Left            =   1920
               RightToLeft     =   -1  'True
               TabIndex        =   25
               Top             =   1080
               Width           =   3330
               WordWrap        =   -1  'True
            End
            Begin VB.Label Label3 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "œ—ê«Â(ÅÊ— )"
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
               Left            =   3960
               RightToLeft     =   -1  'True
               TabIndex        =   24
               Top             =   720
               Width           =   765
            End
         End
         Begin VB.OptionButton optBarcode 
            Alignment       =   1  'Right Justify
            Caption         =   "ç«Åê— »«—ﬂœ €Ì—›⁄«· «”  («“ »«—ﬂœ Preprint  «” ›«œÂ „Ì ‘Êœ)"
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
            Left            =   1440
            RightToLeft     =   -1  'True
            TabIndex        =   15
            Top             =   2880
            Width           =   4575
         End
         Begin VB.OptionButton optBarcode 
            Alignment       =   1  'Right Justify
            Caption         =   "ç«Åê— »«—ﬂœ ›⁄«· «” "
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
            Left            =   4200
            RightToLeft     =   -1  'True
            TabIndex        =   14
            Top             =   360
            Value           =   -1  'True
            Width           =   1815
         End
      End
      Begin VB.Frame fraPrinter 
         Caption         =   "ç«Åê—"
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
         Left            =   -74760
         RightToLeft     =   -1  'True
         TabIndex        =   21
         Top             =   480
         Width           =   6135
         Begin VB.ComboBox cboPrinter 
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
            Style           =   2  'Dropdown List
            TabIndex        =   13
            Top             =   240
            Width           =   3015
         End
      End
      Begin VB.Frame fraTarazoo 
         Caption         =   "  ‰ŸÌ„«   —«“Ê"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   3735
         Left            =   240
         RightToLeft     =   -1  'True
         TabIndex        =   20
         Top             =   600
         Width           =   6015
         Begin VB.Frame gbSettings 
            Height          =   2175
            Left            =   120
            TabIndex        =   26
            Top             =   840
            Width           =   5775
            Begin VB.TextBox txtSettings 
               BackColor       =   &H8000000F&
               Height          =   285
               Left            =   960
               Locked          =   -1  'True
               TabIndex        =   34
               Top             =   240
               Width           =   1695
            End
            Begin VB.TextBox txtScaleCommPort 
               Height          =   285
               Left            =   3840
               TabIndex        =   10
               Top             =   840
               Width           =   375
            End
            Begin VB.ComboBox cboTarazoo 
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
               ItemData        =   "frmSetHard.frx":035C
               Left            =   2880
               List            =   "frmSetHard.frx":0366
               TabIndex        =   5
               Text            =   "cboTarazoo"
               Top             =   360
               Width           =   1935
            End
            Begin VB.Frame gbPandScale 
               Caption         =   "„ﬁÌ«”  —«“Ê ( Å‰œ):"
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
               Left            =   2880
               RightToLeft     =   -1  'True
               TabIndex        =   31
               Top             =   1320
               Width           =   2055
               Begin VB.OptionButton optScale 
                  Caption         =   "0.1"
                  Height          =   195
                  Index           =   1
                  Left            =   120
                  TabIndex        =   12
                  Top             =   360
                  Width           =   615
               End
               Begin VB.OptionButton optScale 
                  Caption         =   "1"
                  Height          =   195
                  Index           =   0
                  Left            =   1080
                  TabIndex        =   11
                  Top             =   360
                  Value           =   -1  'True
                  Width           =   375
               End
            End
            Begin VB.ComboBox cboStopbits 
               Height          =   315
               ItemData        =   "frmSetHard.frx":0387
               Left            =   960
               List            =   "frmSetHard.frx":0394
               Style           =   2  'Dropdown List
               TabIndex        =   9
               Top             =   1680
               Width           =   1695
            End
            Begin VB.ComboBox cboDatabits 
               Height          =   315
               ItemData        =   "frmSetHard.frx":03A3
               Left            =   960
               List            =   "frmSetHard.frx":03B3
               Style           =   2  'Dropdown List
               TabIndex        =   8
               Top             =   1320
               Width           =   1695
            End
            Begin VB.ComboBox cboBaudRate 
               Height          =   315
               ItemData        =   "frmSetHard.frx":03C3
               Left            =   960
               List            =   "frmSetHard.frx":03DC
               Style           =   2  'Dropdown List
               TabIndex        =   6
               Top             =   600
               Width           =   1695
            End
            Begin VB.ComboBox cboParity 
               Height          =   315
               ItemData        =   "frmSetHard.frx":040F
               Left            =   960
               List            =   "frmSetHard.frx":0422
               Style           =   2  'Dropdown List
               TabIndex        =   7
               Top             =   960
               Width           =   1695
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "Comm Port:"
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
               Left            =   2880
               TabIndex        =   33
               Top             =   885
               Width           =   840
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "‰Ê⁄  —«“Ê:"
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
               Left            =   4920
               RightToLeft     =   -1  'True
               TabIndex        =   32
               Top             =   420
               Width           =   630
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "Parity:"
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
               Left            =   120
               TabIndex        =   30
               Top             =   1020
               Width           =   480
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "Stop bits:"
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
               TabIndex        =   29
               Top             =   1740
               Width           =   690
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "Data bits:"
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
               Left            =   120
               TabIndex        =   28
               Top             =   1380
               Width           =   705
            End
            Begin VB.Label Label2 
               Alignment       =   1  'Right Justify
               AutoSize        =   -1  'True
               Caption         =   "Baud Rate:"
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
               Left            =   120
               TabIndex        =   27
               Top             =   660
               Width           =   810
            End
         End
         Begin VB.OptionButton optTarazoo 
            Alignment       =   1  'Right Justify
            Caption         =   " —«“Ê ›⁄«· «” "
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
            TabIndex        =   1
            Top             =   480
            Value           =   -1  'True
            Width           =   1695
         End
         Begin VB.OptionButton optTarazoo 
            Alignment       =   1  'Right Justify
            Caption         =   " —«“Ê ›⁄«· ‰Ì” "
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
            Left            =   4320
            RightToLeft     =   -1  'True
            TabIndex        =   2
            Top             =   3240
            Width           =   1455
         End
      End
      Begin MSCommLib.MSComm MSComm2 
         Left            =   -71640
         Top             =   0
         _ExtentX        =   1005
         _ExtentY        =   1005
         _Version        =   393216
         CommPort        =   2
         DTREnable       =   -1  'True
      End
   End
End
Attribute VB_Name = "frmSetHard"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim L_temp As String

Private Function L_MakeBinaryFile()
    Dim t0, t1, t2, t3, t4 As String
    Dim BufferSize As Long
    Dim L_fno1, L_fno2 As Integer
    Dim L_fname As String
    Dim L_flen As Long
    
    'pcx ŒÊ«‰œ‰ «‰œ«“Â ›«Ì·
    L_fno1 = FreeFile
    If G_BPrinter = "Eltron TLP2642/2742" Then
        L_fname = G_MyPath + "\Data\p2742_" + G_PnCode + ".pcx"
    ElseIf G_BPrinter = "Eltron TLP3642/3742" Then
        L_fname = G_MyPath + "\Data\p3742_" + G_PnCode + ".pcx"
    End If
    If Dir(L_fname) = "" Then
        Call G_ShowMsg("›«Ì· " + L_fname + " „ÊÃÊœ ‰„Ìù»«‘œ.", vbOKOnly, G_exclamation)
        L_MakeBinaryFile = 0
        Exit Function
    End If
    Open L_fname For Binary Access Read As #L_fno1
    If Err Then
        G_ShowMsg Error$, vbOKOnly, G_critical
        Exit Function
    End If
    L_flen = LOF(L_fno1)
    
    '   .dat ”«Œ ‰ ›«Ì·
    If G_BPrinter = "Eltron TLP2642/2742" Then
        L_fname = G_MyPath + "\Data\p2742_" + G_PnCode + ".dat"
        t0 = Chr(13)
        t1 = Chr(10)
        t2 = Trim(Str(L_flen))
        t3 = "GK" + Chr(34) + "PIC27" + Chr(34)
        t4 = "GM" + Chr(34) + "PIC27" + Chr(34) + t2
    ElseIf G_BPrinter = "Eltron TLP3642/3742" Then
        L_fname = G_MyPath + "\Data\p3742_" + G_PnCode + ".dat"
        t0 = Chr(13)
        t1 = Chr(10)
        t2 = Trim(Str(L_flen))
        t3 = "GK" + Chr(34) + "PIC37" + Chr(34)
        t4 = "GM" + Chr(34) + "PIC37" + Chr(34) + t2
    End If
    L_temp = t3 + t0 + t1 + t4 + t0 + t1
   
    L_fno2 = FreeFile
    Open L_fname For Binary Access Write As #L_fno2
    Put #L_fno2, , L_temp
    
    While Not EOF(L_fno1)
        BufferSize = L_flen - Loc(L_fno1) + 1
        L_temp = Space$(BufferSize)
        Get #L_fno1, , L_temp
        Put #L_fno2, , L_temp
    Wend
    Close #L_fno1
    Close #L_fno2
    L_MakeBinaryFile = -1
End Function

Private Sub L_SetBarcodePrn(Fname As String)
    Dim fSend, BufferSize, FileLocation&
    Dim Ret As Long
    
    If MSComm2.PortOpen = True Then MSComm2.PortOpen = False
    If G_BPrinterPort = "com1" Then
        MSComm2.CommPort = 1
    Else
        MSComm2.CommPort = 2
    End If
    'If MSComm2.PortOpen = True Then MSComm2.PortOpen = False
    MSComm2.Handshaking = comNone
    'MSComm2.Settings = "38400,o,8,1"
    MSComm2.PortOpen = True
    
    fSend = FreeFile
    
    Open G_MyPath + "\Data\" + Fname For Binary Access Read As fSend
    If Err Then
        MsgBox Error$, 48
    Else
        ' Read the file in blocks the size of the transmit buffer.
        BufferSize = MSComm2.OutBufferSize
        FileLocation& = LOF(fSend)
        Do Until EOF(fSend)
             ' Don't read too much at the end.
            If FileLocation& - Loc(fSend) <= BufferSize Then
                BufferSize = FileLocation& - Loc(fSend) + 1
            End If
       
            ' Read a block of data.
            L_temp = Space$(BufferSize)
            Get fSend, , L_temp
       
          ' Transmit the block.
          
            MSComm2.Output = L_temp
          If Err Then
             MsgBox Error$, 48
             Exit Do
          End If
       
          ' Wait for all the data to be sent.
          Do
             Ret = DoEvents()
          Loop Until MSComm2.OutBufferCount = 0
       Loop
    End If
     
    Close fSend
End Sub

Private Sub btnSetMemory_Click()
    Dim res As Integer
    Dim Pfilename As String
    
    If G_BPrinter = "Eltron TLP2642/2742" Then
        res = L_MakeBinaryFile
        If res = 0 Then
            Exit Sub
        Else
            Screen.MousePointer = vbHourglass
            'frmWait.Label2 = ""
            'frmWait.Show 0
            'DoEvents
            cmdHardset.Enabled = False
            cmdExit.Enabled = False
        End If
        Sleep (2000)
        Call L_SetBarcodePrn("pak.txt")
        Sleep (2000)
        'frmWait.Hide
        'FrmWait.Show 0
        Screen.MousePointer = vbDefault
        Call G_ShowMsg("·ÿ›« Ìﬂ»«— ç«Åê— »«—ﬂœ —« Œ«„Ê‘ Ê —Ê‘‰ ‰„«ÌÌœ Ê  Å” «“ « „«„ ç‘„ﬂ “œ‰ ç«Åê— »«—ﬂœ ﬂ·Ìœ  √ÌÌœ —« »“‰Ìœ", vbOKOnly, G_info)
        Screen.MousePointer = vbHourglass
        Call L_SetBarcodePrn("sabet2742.dat")
        Sleep (1000)
        Call L_SetBarcodePrn("num2742.dat")
        Sleep (1000)
        Call L_SetBarcodePrn("ems2742.dat")
        Sleep (3000)
        Call L_SetBarcodePrn("Naghsh27.dat")
        Sleep (3000)
        Pfilename = "p2742_" + G_PnCode + ".dat"
        Screen.MousePointer = vbDefault
        If Dir(G_MyPath + "\Data\" + Pfilename) = "" Then
            Call G_ShowMsg("›«Ì· " + Pfilename + " „ÊÃÊœ ‰„Ìù»«‘œ.", vbOKOnly, G_exclamation)
        Else
            Screen.MousePointer = vbHourglass
            Call L_SetBarcodePrn(Pfilename)
            Sleep (3000)
        End If
        Screen.MousePointer = vbDefault
        Call G_ShowMsg("·ÿ›« „Ãœœ« ç«Åê— »«—ﬂœ —« Œ«„Ê‘ Ê —Ê‘‰ ‰„«ÌÌœ", vbOKOnly, G_info)
    ElseIf G_BPrinter = "Eltron TLP3642/3742" Then
        res = L_MakeBinaryFile
        If res = 0 Then
            Exit Sub
        Else
            Screen.MousePointer = vbHourglass
            'frmWait.Show vbModal, Me
            'frmWait.Label2 = ""
            'DoEvents
            cmdHardset.Enabled = False
            cmdExit.Enabled = False
        End If
        Sleep (2000)
        Call L_SetBarcodePrn("pak.txt")
        Sleep (2000)
        'frmWait.Hide
        Screen.MousePointer = vbDefault
        Call G_ShowMsg("·ÿ›« Ìﬂ»«— ç«Åê— »«—ﬂœ —« Œ«„Ê‘ Ê —Ê‘‰ ‰„«ÌÌœ Ê  Å” «“ « „«„ ç‘„ﬂ “œ‰ ç«Åê— »«—ﬂœ ﬂ·Ìœ  √ÌÌœ —« »“‰Ìœ", vbOKOnly, G_info)
        Screen.MousePointer = vbHourglass
        Call L_SetBarcodePrn("sabet3742.dat")
        Sleep (1000)
        Call L_SetBarcodePrn("num3742.dat")
        Sleep (1000)
        Call L_SetBarcodePrn("ems3742.dat")
        Sleep (3000)
        Call L_SetBarcodePrn("Naghsh37.dat")
        Sleep (3000)
        Pfilename = "p3742_" + G_PnCode + ".dat"
        Screen.MousePointer = vbDefault
        If Dir(G_MyPath + "\Data\" + Pfilename) = "" Then
            Call G_ShowMsg("›«Ì· " + Pfilename + " „ÊÃÊœ ‰„Ìù»«‘œ.", vbOKOnly, G_exclamation)
        Else
            Screen.MousePointer = vbHourglass
            Call L_SetBarcodePrn(Pfilename)
            Sleep (3000)
        End If
        Screen.MousePointer = vbDefault
        Call G_ShowMsg("·ÿ›« „Ãœœ« ç«Åê— »«—ﬂœ —« Œ«„Ê‘ Ê —Ê‘‰ ‰„«ÌÌœ", vbOKOnly, G_info)
    End If
    'Unload frmWait
    'fraWait.Visible = False
    cmdHardset.Enabled = True
    cmdExit.Enabled = True

End Sub

Private Sub cboBaudRate_Click()
    txtSettings.Text = cboBaudRate.Text + "," + UCase(Left(cboParity.Text, 1)) + "," + cboDatabits.Text + "," + cboStopbits.Text
End Sub

Private Sub cboDatabits_Click()
    txtSettings.Text = cboBaudRate.Text + "," + UCase(Left(cboParity.Text, 1)) + "," + cboDatabits.Text + "," + cboStopbits.Text
End Sub

Private Sub cboParity_Click()
    txtSettings.Text = cboBaudRate.Text + "," + UCase(Left(cboParity.Text, 1)) + "," + cboDatabits.Text + "," + cboStopbits.Text
End Sub

Private Sub cboStopbits_Click()
    txtSettings.Text = cboBaudRate.Text + "," + UCase(Left(cboParity.Text, 1)) + "," + cboDatabits.Text + "," + cboStopbits.Text
End Sub

Private Sub cmdExit_Click()
    Unload Me
End Sub

Private Sub Cmdhardset_Click()
    
    Select Case SSTab1.Tab
        Case 0
            If optTarazoo(0).Value = True Then
                SaveSetting "Track&Trace", "PostOffice", "tarazo", cboTarazoo.Text
            Else
                SaveSetting "Track&Trace", "PostOffice", "tarazo", ""
            End If
            G_Tarazoo = GetSetting("Track&Trace", "PostOffice", "tarazo")
            
            
            If optScale(0).Value = True Then
                G_TarazooScale = "1"
            Else
                G_TarazooScale = "0.1"
            End If
                        
            SaveSetting "Track&Trace", "PostOffice", "tarazo_Scale", G_TarazooScale
            
            G_ScaleCommPort = txtScaleCommPort.Text
            SaveSetting "Track&Trace", "PostOffice", "ScaleCommPort", G_ScaleCommPort
            G_ScaleBaudRate = cboBaudRate.Text
            SaveSetting "Track&Trace", "PostOffice", "ScaleBaudRate", G_ScaleBaudRate
            G_ScaleDatabits = cboDatabits.Text
            SaveSetting "Track&Trace", "PostOffice", "ScaleDatabits", G_ScaleDatabits
            G_ScaleStopbits = cboStopbits.Text
            SaveSetting "Track&Trace", "PostOffice", "ScaleStopbits", G_ScaleStopbits
            
            Select Case cboParity.Text
                Case "None":
                    G_ScaleParity = "N"
                Case "Even":
                    G_ScaleParity = "E"
                Case "Odd":
                    G_ScaleParity = "O"
                Case "Mark":
                    G_ScaleParity = "M"
                Case "Space":
                    G_ScaleParity = "S"
            End Select
            
            SaveSetting "Track&Trace", "PostOffice", "ScaleParity", G_ScaleParity
            
            G_ShowMsg " ‰ŸÌ„«   —«“Ê À»  ê—œÌœ!", vbOKOnly, G_check
        Case 1
            If cboPrinter.ListCount > 0 Then
                    SaveSetting "Track&Trace", "PostOffice", "printer", cboPrinter.Text
            Else
                    SaveSetting "Track&Trace", "PostOffice", "printer", ""
            End If
            If optBarcode(0).Value = True Then
                If opt2742.Value = True Then
                    SaveSetting "Track&Trace", "PostOffice", "bprinter", "Eltron TLP2642/2742"
                Else
                    SaveSetting "Track&Trace", "PostOffice", "bprinter", "Eltron TLP3642/3742"
                End If
                    SaveSetting "Track&Trace", "PostOffice", "Barcode_port", cboPort.Text
            Else
                SaveSetting "Track&Trace", "PostOffice", "bprinter", ""
            End If
            G_BPrinter = GetSetting("Track&Trace", "PostOffice", "bprinter")
            G_Printer = GetSetting("Track&Trace", "PostOffice", "printer")
            G_BPrinterPort = cboPort.Text
            G_ShowMsg " ‰ŸÌ„«  ç«Åê—Â« À»  ê—œÌœ!", vbOKOnly, G_check
    End Select
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    Dim X As Printer
    Dim i As Integer

    For Each X In Printers
        cboPrinter.AddItem X.DeviceName
    Next
    If cboPrinter.ListCount > 0 Then
        For i = 0 To cboPrinter.ListCount - 1
            cboPrinter.ListIndex = i
            If cboPrinter.Text = G_Printer Then Exit For
        Next
        'cboPrinter.ListIndex = 0
    End If
    
    cboBaudRate.Text = G_ScaleBaudRate
    cboDatabits.Text = G_ScaleDatabits
    cboStopbits.Text = G_ScaleStopbits
    
    Select Case UCase(G_ScaleParity)
        Case "N":
            cboParity.Text = "None"
        Case "E":
            cboParity.Text = "even"
        Case "O":
            cboParity.Text = "odd"
        Case "M":
            cboParity.Text = "mark"
        Case "S":
            cboParity.Text = "space"
    End Select
    txtScaleCommPort.Text = G_ScaleCommPort
    If G_BPrinter = "" Then
        optBarcode(1).Value = True
        optBarcode_Click (1)
    Else
       optBarcode(0).Value = True
       optBarcode_Click (0)
       If G_BPrinter = "Eltron TLP2642/2742" Then
            opt2742.Value = True
       Else
            opt3742.Value = True
       End If
       If G_BPrinterPort <> "" Then
            cboPort.Text = G_BPrinterPort
        End If
    End If
    If G_Tarazoo = "" Then
        optTarazoo(1).Value = True
        cboTarazoo.ListIndex = 0
    Else
        optTarazoo(0).Value = True
        cboTarazoo.Text = G_Tarazoo
        If G_TarazooScale = "1" Then
            optScale(0).Value = True
        Else
            optScale(1).Value = True
        End If
    End If
    
    SSTab1_Click (2)
End Sub

Private Sub optBarcode_Click(Index As Integer)
    If optBarcode(0).Value = True Then
        fraBarcode.Enabled = True
    Else
        fraBarcode.Enabled = False
    End If
End Sub

Private Sub optTarazoo_Click(Index As Integer)
    If optTarazoo(0).Value = True Then
        gbSettings.Enabled = True
    Else
        gbSettings.Enabled = False
    End If
End Sub

Private Sub SSTab1_Click(PreviousTab As Integer)
    Select Case SSTab1.Tab
        Case 0
            fraTarazoo.Enabled = True
            fraPrinter.Enabled = False
            fraBprinter.Enabled = False
            cmdHardset.Caption = " ‰ŸÌ„  —«“Ê"
        Case 1
            fraTarazoo.Enabled = False
            fraBprinter.Enabled = True
            fraPrinter.Enabled = True
            cmdHardset.Caption = " ‰ŸÌ„ ç«Åê—Â«"
        Case 2
            fraTarazoo.Enabled = False
            fraBprinter.Enabled = False
            fraPrinter.Enabled = False
            cmdHardset.Caption = " ‰ŸÌ„ Õ«›ŸÂ"
    End Select
End Sub
