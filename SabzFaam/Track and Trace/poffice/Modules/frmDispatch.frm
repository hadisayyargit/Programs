VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "msflxgrd.ocx"
Begin VB.Form frmDispatch 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "œÅ‘ »‰œÌ "
   ClientHeight    =   8580
   ClientLeft      =   45
   ClientTop       =   405
   ClientWidth     =   11880
   Icon            =   "frmDispatch.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   8580
   ScaleWidth      =   11880
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnDelRegisteration 
      Caption         =   "<<----"
      Height          =   495
      Left            =   5520
      TabIndex        =   8
      ToolTipText     =   "Õ–› À»  «“ œÅ‘ «‰ Œ«» ‘œÂ"
      Top             =   5520
      Width           =   735
   End
   Begin VB.CommandButton btnAddRegisteration 
      Caption         =   "---->>"
      Height          =   495
      Left            =   5520
      TabIndex        =   7
      ToolTipText     =   "«Œ ’«’ À»  »Â œÅ‘ «‰ Œ«» ‘œÂ"
      Top             =   4920
      Width           =   735
   End
   Begin VB.Frame Frame2 
      Caption         =   "À» Â«Ì «Œ ’«’ Ì«› Â"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3615
      Left            =   6360
      RightToLeft     =   -1  'True
      TabIndex        =   22
      Top             =   4800
      Width           =   5415
      Begin MSFlexGridLib.MSFlexGrid grdDispatchRegisteration 
         Height          =   3135
         Left            =   120
         TabIndex        =   6
         Top             =   360
         Width           =   5175
         _ExtentX        =   9128
         _ExtentY        =   5530
         _Version        =   393216
         Cols            =   4
         FixedCols       =   0
         RightToLeft     =   -1  'True
         HighLight       =   2
         SelectionMode   =   1
         AllowUserResizing=   1
         FormatString    =   "‘„«—Â À»  | «—ÌŒ À»            |⁄‰Ê«‰ À»                      | ⁄œ«œ „—”Ê·Â "
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
   End
   Begin TabDlg.SSTab sstDispatch 
      Height          =   4575
      Left            =   5520
      TabIndex        =   0
      Top             =   120
      Width           =   6255
      _ExtentX        =   11033
      _ExtentY        =   8070
      _Version        =   393216
      TabOrientation  =   1
      Style           =   1
      Tabs            =   2
      TabHeight       =   882
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   "›Â—”  œÅ‘Â«Ì »«“"
      TabPicture(0)   =   "frmDispatch.frx":0442
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "grdDispatch"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).ControlCount=   1
      TabCaption(1)   =   "ÊÌ—«Ì‘"
      TabPicture(1)   =   "frmDispatch.frx":0894
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "fraTarget"
      Tab(1).ControlCount=   1
      Begin VB.Frame fraTarget 
         Caption         =   "„ﬁ’œ œÅ‘"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   178
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   3855
         Left            =   -74880
         RightToLeft     =   -1  'True
         TabIndex        =   12
         Top             =   120
         Width           =   6015
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
            Left            =   1440
            RightToLeft     =   -1  'True
            TabIndex        =   23
            Top             =   360
            Width           =   2895
         End
         Begin VB.TextBox txtSerialSend 
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
            Left            =   1440
            Locked          =   -1  'True
            RightToLeft     =   -1  'True
            TabIndex        =   15
            Top             =   1440
            Width           =   615
         End
         Begin VB.TextBox txtSerialDay 
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
            Left            =   3600
            Locked          =   -1  'True
            RightToLeft     =   -1  'True
            TabIndex        =   14
            Top             =   1440
            Width           =   735
         End
         Begin VB.ComboBox cboPostNode 
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
            Left            =   1440
            RightToLeft     =   -1  'True
            TabIndex        =   3
            Top             =   1080
            Width           =   2895
         End
         Begin VB.TextBox txtDispatchCode 
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
            Left            =   1440
            Locked          =   -1  'True
            MaxLength       =   15
            RightToLeft     =   -1  'True
            TabIndex        =   13
            Tag             =   "11"
            Top             =   2760
            Width           =   2895
         End
         Begin VB.CommandButton btnNewDispatch 
            Caption         =   "œ—Ã œÅ‘ ÃœÌœ"
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
            TabIndex        =   4
            Top             =   2040
            Width           =   1605
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
            Left            =   1440
            RightToLeft     =   -1  'True
            TabIndex        =   2
            Top             =   720
            Width           =   2895
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
            Left            =   4440
            RightToLeft     =   -1  'True
            TabIndex        =   24
            Top             =   420
            Width           =   480
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "”—Ì«· «—”«·:"
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
            Left            =   2160
            RightToLeft     =   -1  'True
            TabIndex        =   20
            Top             =   1500
            Width           =   960
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "”—Ì«· —Ê“:"
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
            Left            =   4440
            RightToLeft     =   -1  'True
            TabIndex        =   19
            Top             =   1500
            Width           =   735
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            BackStyle       =   0  'Transparent
            Caption         =   "‰ﬁÿÂ Å” Ì:"
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
            Left            =   4440
            RightToLeft     =   -1  'True
            TabIndex        =   18
            Top             =   1140
            Width           =   900
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
            Index           =   0
            Left            =   4440
            RightToLeft     =   -1  'True
            TabIndex        =   17
            Top             =   2820
            Width           =   600
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
            Left            =   4440
            RightToLeft     =   -1  'True
            TabIndex        =   16
            Top             =   780
            Width           =   390
         End
      End
      Begin MSFlexGridLib.MSFlexGrid grdDispatch 
         Height          =   3735
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   5895
         _ExtentX        =   10398
         _ExtentY        =   6588
         _Version        =   393216
         FixedCols       =   0
         RightToLeft     =   -1  'True
         HighLight       =   2
         SelectionMode   =   1
         FormatString    =   "ﬂœ œÅ‘                           | «—ÌŒ «ÌÃ«œ             "
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
   End
   Begin VB.Frame Frame1 
      Caption         =   "À» Â«Ì ¬“«œ"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   8415
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   21
      Top             =   0
      Width           =   5295
      Begin MSFlexGridLib.MSFlexGrid grdRegisteration 
         Height          =   7935
         Left            =   120
         TabIndex        =   5
         Top             =   360
         Width           =   5055
         _ExtentX        =   8916
         _ExtentY        =   13996
         _Version        =   393216
         Cols            =   4
         FixedCols       =   0
         RightToLeft     =   -1  'True
         FocusRect       =   2
         HighLight       =   2
         SelectionMode   =   1
         AllowUserResizing=   1
         FormatString    =   "‘„«—Â À»  | «—ÌŒ À»            |⁄‰Ê«‰ À»                      | ⁄œ«œ „—”Ê·Â "
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
   End
   Begin VB.CommandButton btnClose 
      Caption         =   "»” ‰ œÅ‘ Ê  ÂÌÂ À»  œÌÃÌ «·"
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
      Left            =   5520
      RightToLeft     =   -1  'True
      TabIndex        =   11
      Top             =   7560
      Width           =   735
   End
   Begin VB.CommandButton btnReport 
      Caption         =   "»—êÂ «⁄·«„"
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
      Left            =   5520
      RightToLeft     =   -1  'True
      TabIndex        =   9
      Top             =   6120
      Width           =   735
   End
   Begin VB.CommandButton btnDelete 
      Caption         =   "Õ–› œÅ‘"
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
      Left            =   5520
      RightToLeft     =   -1  'True
      TabIndex        =   10
      Top             =   6840
      Width           =   735
   End
End
Attribute VB_Name = "frmDispatch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim m_CurrentDispatch As String

Function L_MakeDespCode() As String
    Dim StCode As String
    Dim i As Integer
    Dim count As Integer
    Dim Parity As String
    Dim strPostNodeCode As String
    Dim p, code As Integer
    Dim d1 As String
    
    strPostNodeCode = Format(cboPostNode.ItemData(cboPostNode.ListIndex), "00000")
    
'    G_MyQuery = "SELECT max(DISPATCH_PDATE+mid(DISPATCH_CODE,11,3)) as MyField from tblDispatch where ISOPEN=2 and mid(DISPATCH_CODE,6,5)='" + strPostNodeCode + "'"
'    If RstDep.State = 1 Then RstDep.Close
'    RstDep.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
'
'    'œ— Õ«·  ⁄«œÌ Êﬁ Ì »Â 999 —”Ìœ ‘„«—Â »⁄œÌ 1 „Ìù‘Êœ Ê ‘„«—Â »⁄œ «“ ¬‰ Â„ 1 „Ìù‘Êœ çÊ‰ œ— Â— œÊ Õ«· „«ﬂ“Ì„„ 999 «” 
'
'    If Not RstDep.EOF Then
'        If Not IsNull((RstDep!MyField)) Then
'           If Val(Mid(RstDep!MyField, 11, 3)) <> 999 Then
'               code = Val(Mid(RstDep!MyField, 11, 3))
'               code = code + 1
'           Else
'                d1 = Mid(RstDep!MyField, 1, 10)
'                G_MyQuery = "SELECT max(mid(DISPATCH_CODE,11,3)) as MaxCount from tblDispatch where ISOPEN=2 and mid(DISPATCH_CODE),6,5)='" + strPostNodeCode + "' and DISPATCH_PDATE='" + d1 + "' and val(mid(DISPATCH_CODE,11,3))<500"
'                If RstDep.State = 1 Then RstDep.Close
'                RstDep.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
'                code = RstDep!MaxCount
'           End If
'        Else
'           code = 1
'        End If
'        StCode = Mid(G_pncode, 1, 5) + Trim(strPostNodeCode) + Format(Trim(str(code)), "000")
'    Else
'        StCode = Mid(G_pncode, 1, 5) + Format(strPostNodeCode, "00000") + "001"
'    End If

    StCode = Format(G_PnCode, "00000") + strPostNodeCode + Format(Val(txtSerialDay) * 10 + Val(txtSerialSend), "0000")
    Dim m As Integer   '„Õ«”»Â check digit
    p = 0
    For i = 1 To 14
        If i Mod 2 = 0 Then
            m = 3
        Else
            m = 1
        End If

        p = Val(Trim(Mid(StCode, i, 1))) * m + p
    Next i
    L_MakeDespCode = StCode + Trim(str(p Mod 10))
End Function

Private Function L_GetLastSerial() As Integer
    G_MyQuery = "select Max(mid(DISPATCH_CODE,11,4)) AS MAXSERIAL from tblDispatch WHERE DISPATCH_PDATE='" + G_CurrentDate + "'"
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        L_GetLastSerial = 0
    ElseIf IsNull(G_MyRst!MAXSERIAL) Then
        L_GetLastSerial = 0
    Else
        L_GetLastSerial = (1 + G_MyRst!MAXSERIAL) Mod 10
    End If
End Function

Private Function L_GetSerialDay() As Integer
    Dim strFirstDayofCurrentHejriYear As String
    
    strFirstDayofCurrentHejriYear = Mid(modGlobal.G_CurrentDate, 1, 4) + "/01/01"
    L_GetSerialDay = 1 + DateDiff("d", G_Miladi(strFirstDayofCurrentHejriYear), Date)
End Function

Private Function m_ShowOpenDispatches()
    Dim nRow As Integer
    
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_MyQuery = "SELECT * FROM tblDispatch WHERE ISOPEN = 1"
    G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    grdDispatch.Clear
    grdDispatch.Rows = 2
    grdDispatch.FormatString = "ﬂœ œÅ‘                           | «—ÌŒ «ÌÃ«œ             "
    
    While Not G_PrimaryRs.EOF
        nRow = grdDispatch.Rows - 1
        grdDispatch.AddItem ""
        grdDispatch.TextMatrix(nRow, 0) = G_PrimaryRs!DISPATCH_CODE
        grdDispatch.TextMatrix(nRow, 1) = G_PrimaryRs!DISPATCH_PDATE
        G_PrimaryRs.MoveNext
    Wend
    m_CurrentDispatch = ""
End Function

Private Function m_ShowDispatchRegisterations()
    Dim nRow As Integer
    
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyQuery = "select * from tblRegister where DISPATCH_CODE='" & m_CurrentDispatch & "' and IsEms=1"
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    grdDispatchRegisteration.Clear
    grdDispatchRegisteration.Rows = 2
    grdDispatchRegisteration.FormatString = "‘„«—Â À»  | «—ÌŒ À»            |⁄‰Ê«‰ À»                      | ⁄œ«œ „—”Ê·Â "
    
    While Not G_MyRst2.EOF
        nRow = grdDispatchRegisteration.Rows - 1
        grdDispatchRegisteration.AddItem ""
        grdDispatchRegisteration.TextMatrix(nRow, 0) = G_MyRst2!RegId
        grdDispatchRegisteration.TextMatrix(nRow, 1) = G_MyRst2!RegDate
        grdDispatchRegisteration.TextMatrix(nRow, 2) = G_MyRst2!RegHeader
        grdDispatchRegisteration.TextMatrix(nRow, 3) = G_MyRst2!ParcelCount
        G_MyRst2.MoveNext
    Wend
End Function

Private Function m_ShowRegisterations()
    Dim nRow As Integer
    
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyQuery = "SELECT * From tblRegister where (DISPATCH_CODE is null or DISPATCH_CODE='') and IsEms=1"
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    grdRegisteration.Clear
    grdRegisteration.Rows = 2
    grdRegisteration.FormatString = "‘„«—Â À»  | «—ÌŒ À»            |⁄‰Ê«‰ À»                      | ⁄œ«œ „—”Ê·Â "
    
    While Not G_MyRst.EOF
        nRow = grdRegisteration.Rows - 1
        grdRegisteration.AddItem ""
        grdRegisteration.TextMatrix(nRow, 0) = G_MyRst!RegId
        grdRegisteration.TextMatrix(nRow, 1) = G_MyRst!RegDate
        grdRegisteration.TextMatrix(nRow, 2) = G_MyRst!RegHeader
        grdRegisteration.TextMatrix(nRow, 3) = G_MyRst!ParcelCount
        G_MyRst.MoveNext
    Wend
End Function

Private Function m_SetDefaultCity()
    cboCity.ListIndex = 0
    While cboCity.ItemData(cboCity.ListIndex) <> 1012
        cboCity.ListIndex = cboCity.ListIndex + 1
    Wend
End Function
Private Sub btnClose_Click()
    On Error GoTo ErrClose
    
    If m_CurrentDispatch <> "" Then
        G_ShowMsg "¬Ì« œÅ‘ »” Â ‘Êœø", vbOKCancel, G_question
        If G_MsgButton = vbOK Then
            G_AdoConn.Execute "Update tblDispatch Set ISOPEN = 0 where DISPATCH_CODE='" & m_CurrentDispatch & "'"
            Sleep (1000)
            
            G_ShowMsg "œÅ‘ »” Â ‘œ. ¬Ì« À»  œÌÃÌ «·  ÂÌÂ „Ìùﬂ‰Ìœø", vbYesNo, G_question
            If G_MsgButton = vbYes Then
                m_BuildDigitalRegisteration (m_CurrentDispatch)
            End If
            
            grdDispatch.RemoveItem grdDispatch.Row
            m_CurrentDispatch = ""
            m_ShowDispatchRegisterations
        End If
    End If
    Exit Sub
ErrClose:
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub btnDelete_Click()
    On Error GoTo ErrLabelDel
    
    If m_CurrentDispatch = "" Then Exit Sub
    
    G_ShowMsg "¬Ì« œÅ‘ Õ–› ‘Êœø", vbOKCancel, G_question
    If G_MsgButton = vbOK Then
        Screen.MousePointer = vbHourglass
        G_AdoConn.Execute "update tblRegister set DISPATCH_CODE=NULL where DISPATCH_CODE='" + m_CurrentDispatch + "' and IsEms=1"
        Sleep (100)
        G_AdoConn.Execute "delete * from tblDispatch where DISPATCH_CODE='" + m_CurrentDispatch + "'"
        Sleep (100)
        txtSerialSend.Text = L_GetLastSerial()
        grdDispatch.RemoveItem grdDispatch.Row
        m_CurrentDispatch = ""
        m_ShowRegisterations
        m_ShowDispatchRegisterations
        Screen.MousePointer = vbDefault
    End If
    Exit Sub
    
ErrLabelDel:
    Screen.MousePointer = vbDefault
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub btnAddRegisteration_Click()
    On Error GoTo ErrLabel
    
    If m_CurrentDispatch = "" Then Exit Sub
    If grdRegisteration.TextMatrix(grdRegisteration.Row, 0) = "" Then Exit Sub
    
    G_AdoConn.Execute "update tblRegister set DISPATCH_CODE='" & m_CurrentDispatch & "'  where RegId=" & grdRegisteration.TextMatrix(grdRegisteration.Row, 0) & " and IsEms=1"
    Sleep (100)
    grdDispatchRegisteration.AddItem ""
    grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Rows - 2, 0) = grdRegisteration.TextMatrix(grdRegisteration.Row, 0)
    grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Rows - 2, 1) = grdRegisteration.TextMatrix(grdRegisteration.Row, 1)
    grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Rows - 2, 2) = grdRegisteration.TextMatrix(grdRegisteration.Row, 2)
    grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Rows - 2, 3) = grdRegisteration.TextMatrix(grdRegisteration.Row, 3)
    grdRegisteration.RemoveItem grdRegisteration.Row
    Exit Sub
ErrLabel:
    Screen.MousePointer = vbDefault
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub btnDelRegisteration_Click()
    On Error GoTo ErrLabel
    
    If m_CurrentDispatch = "" Then Exit Sub
    If grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 0) = "" Then Exit Sub
    G_AdoConn.Execute "update tblRegister set DISPATCH_CODE=NULL where RegId=" & grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 0) & " and IsEms=1"
    Sleep (100)
    grdRegisteration.AddItem ""
    grdRegisteration.TextMatrix(grdRegisteration.Rows - 2, 0) = grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 0)
    grdRegisteration.TextMatrix(grdRegisteration.Rows - 2, 1) = grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 1)
    grdRegisteration.TextMatrix(grdRegisteration.Rows - 2, 2) = grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 2)
    grdRegisteration.TextMatrix(grdRegisteration.Rows - 2, 3) = grdDispatchRegisteration.TextMatrix(grdDispatchRegisteration.Row, 3)
    grdDispatchRegisteration.RemoveItem grdDispatchRegisteration.Row
    Exit Sub
ErrLabel:
    Screen.MousePointer = vbDefault
    G_ShowMsg Err.Description, vbOKOnly, G_critical
End Sub

Private Sub btnNewDispatch_Click()
    Dim p, m As Integer
    Dim i As Integer
    Dim Despstr As String
    
    btnNewDispatch.Enabled = False
    txtDispatchCode = L_MakeDespCode
    txtDispatchCode = Format(txtDispatchCode, "00000000000000")
    G_MyQuery = "SELECT * from tblDispatch WHERE DISPATCH_CODE='" & txtDispatchCode & "'"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If Not G_MyRst2.EOF Then
        G_ShowMsg "œÅ‘  ﬂ—«—Ì", vbOKOnly, G_critical
        btnNewDispatch.Enabled = True
        Exit Sub
    End If
       
    G_AdoConn.Execute "Insert into tblDispatch(DISPATCH_CODE, DISPATCH_PDATE, ISOPEN, TRANSFERRED_TAG, CREATION_DATETIME) values('" & txtDispatchCode & "','" & G_CurrentDate & "',1,0,'" + Format(Now, "yyyy-mm-dd HH:mm:ss") + "')"
    Sleep (1000)
    Call G_ShowMsg("œÅ‘ »« „Ê›ﬁÌ  «ÌÃ«œ ê—œÌœ", vbOKOnly, G_check)
    txtSerialSend.Text = 1 + Val(txtSerialSend)
    m_ShowOpenDispatches
    m_ShowDispatchRegisterations
    btnNewDispatch.Enabled = True
    m_CurrentDispatch = txtDispatchCode
End Sub

Private Sub btnReport_Click()
    If m_CurrentDispatch = "" Then Exit Sub
    Screen.MousePointer = vbHourglass
    G_AdoConn.Execute "delete * from tblTransReprort"
    Sleep (50)
    G_AdoConn.Execute "insert into tblTransReprort(F03,F01_tCode,F02_tName,F81_tHeader,F04,F05,F00_tTarikh,F06)" & _
        " select tblRegister.RegId,tblRegister.RegDate,tblRegister.DISPATCH_CODE,tblRegister.RegHeader,tblRegister.RegType,tblRegister.ParcelCount, tblDispatch.DISPATCH_PDATE,tblDispatch.ISOPEN" _
        + " from tblRegister inner join tblDispatch on tblRegister.DISPATCH_CODE=tblDispatch.DISPATCH_CODE where tblDispatch.DISPATCH_CODE='" & m_CurrentDispatch & "'"
    
    G_Rptno = enmRptDispatch
    Sleep (1500)
    frmReportViewer.Show 1
End Sub

Private Sub Form_Load()
    txtSerialDay = L_GetSerialDay()
    txtSerialSend.Text = L_GetLastSerial()
    G_MyQuery = "select * from STATE WHERE CODE<>0"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    Call G_FillCombo2(cboProvince, G_MyRst2)
    m_ShowOpenDispatches
    m_ShowRegisterations
    sstDispatch.Tab = 0
    grdDispatch_RowColChange
    m_SetDefaultCity
    'cboCity.Text = " Ã“ÌÂ „»«œ·«  ·‘ﬂ—"
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub cboCity_Click()
    G_MyQuery = "select CODE,PNAME from POSTNODE where CITY_CODE=" + Trim(str(cboCity.ItemData(cboCity.ListIndex)))
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    Call G_FillCombo2(cboPostNode, G_MyRst)
End Sub

Private Sub cboProvince_Click()
    G_MyQuery = "select CODE,PNAME from CITY where STATE_CODE=" + Trim(str(cboProvince.ItemData(cboProvince.ListIndex)))
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    Call G_FillCombo2(cboCity, G_MyRst)
End Sub

Private Sub grdDispatch_RowColChange()
    m_CurrentDispatch = grdDispatch.TextMatrix(grdDispatch.Row, 0)
    m_ShowDispatchRegisterations
End Sub

Private Sub grdDispatchRegisteration_DblClick()
    'btnDelRegisteration_Click
End Sub

Private Sub grdRegisteration_DblClick()
    'btnAddRegisteration_Click
End Sub

Private Sub sstDispatch_Click(PreviousTab As Integer)
    If sstDispatch.Tab = 1 Then   'ÊÌ—«Ì‘
        txtDispatchCode.Text = ""
        btnAddRegisteration.Enabled = False
        btnDelRegisteration.Enabled = False
        btnReport.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        grdRegisteration.Enabled = False
        grdDispatchRegisteration.Enabled = False
    Else
        btnAddRegisteration.Enabled = True
        btnDelRegisteration.Enabled = True
        btnReport.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
        grdRegisteration.Enabled = True
        grdDispatchRegisteration.Enabled = True
    End If
End Sub
