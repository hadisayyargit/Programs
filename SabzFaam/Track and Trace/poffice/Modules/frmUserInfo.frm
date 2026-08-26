VERSION 5.00
Begin VB.Form frmUserInfo 
   BorderStyle     =   1  'Fixed Single
   Caption         =   " ﬂ«—»—"
   ClientHeight    =   3000
   ClientLeft      =   2760
   ClientTop       =   3825
   ClientWidth     =   3270
   ControlBox      =   0   'False
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   3000
   ScaleWidth      =   3270
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtPname 
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
      MaxLength       =   15
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Top             =   480
      Visible         =   0   'False
      Width           =   1815
   End
   Begin VB.TextBox txtPass 
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
      IMEMode         =   3  'DISABLE
      Left            =   120
      MaxLength       =   15
      PasswordChar    =   "*"
      TabIndex        =   3
      Top             =   1200
      Width           =   1815
   End
   Begin VB.TextBox txtCode 
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
      Left            =   1320
      MaxLength       =   7
      TabIndex        =   2
      Tag             =   "11"
      Top             =   840
      Width           =   615
   End
   Begin VB.TextBox txtName 
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
      MaxLength       =   15
      TabIndex        =   0
      Top             =   120
      Width           =   1815
   End
   Begin VB.Frame fraCommand 
      BorderStyle     =   0  'None
      Height          =   375
      Left            =   248
      RightToLeft     =   -1  'True
      TabIndex        =   12
      Top             =   2520
      Width           =   2775
      Begin VB.CommandButton cmdExit 
         Caption         =   "Œ—ÊÃ"
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
         TabIndex        =   19
         Top             =   0
         Width           =   1215
      End
      Begin VB.CommandButton cmdClose 
         Caption         =   "«‰’—«›"
         BeginProperty Font 
            Name            =   "Tahoma"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   10
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
      Begin VB.CommandButton cmdSetDef 
         Caption         =   "Ê—Êœ"
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
         RightToLeft     =   -1  'True
         TabIndex        =   18
         Top             =   0
         Width           =   1215
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
         Left            =   1440
         TabIndex        =   7
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
      Begin VB.CommandButton cmdChange 
         Caption         =   " €ÌÌ—"
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
         TabIndex        =   8
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
      Begin VB.CommandButton cmdAdd 
         Caption         =   "œ—Ã"
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
         TabIndex        =   9
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
   End
   Begin VB.Frame fraPass 
      BorderStyle     =   0  'None
      Height          =   735
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   4
      Top             =   1560
      Visible         =   0   'False
      Width           =   2895
      Begin VB.TextBox txtNewPass 
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
         IMEMode         =   3  'DISABLE
         Left            =   0
         MaxLength       =   15
         PasswordChar    =   "*"
         TabIndex        =   5
         Top             =   0
         Width           =   1815
      End
      Begin VB.TextBox txtConfirm 
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
         IMEMode         =   3  'DISABLE
         Left            =   0
         MaxLength       =   15
         PasswordChar    =   "*"
         TabIndex        =   6
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label lblPass2 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "—„“ ⁄»Ê— ÃœÌœ:"
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
         Left            =   1860
         RightToLeft     =   -1  'True
         TabIndex        =   16
         Top             =   60
         Width           =   1005
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   " ﬂ—«— —„“:"
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
         Left            =   1860
         RightToLeft     =   -1  'True
         TabIndex        =   11
         Top             =   420
         Width           =   645
      End
   End
   Begin VB.Label lblPname 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "‰«„ ›«—”Ì ﬂ«—»—:"
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
      Left            =   2040
      RightToLeft     =   -1  'True
      TabIndex        =   17
      Top             =   540
      Visible         =   0   'False
      Width           =   1155
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "‰«„ ·« Ì‰ ﬂ«—»—:"
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
      Left            =   2040
      RightToLeft     =   -1  'True
      TabIndex        =   15
      Top             =   210
      Width           =   975
   End
   Begin VB.Label lblCode 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ ﬂ«—»—:"
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
      TabIndex        =   14
      Top             =   900
      Width           =   570
   End
   Begin VB.Label lblPass 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "—„“ ⁄»Ê—:"
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
      TabIndex        =   13
      Top             =   1260
      Width           =   630
   End
End
Attribute VB_Name = "frmUserInfo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub CmdAdd_Click()
    Dim pp As String
    Dim p(15) As String
    Dim i As Integer
    
    If Len(txtName) < 1 Then
        G_ShowMsg "‰«„ ·« Ì‰ ﬂ«—»— —« Ê«—œ ‰„«ÌÌœ!", vbOKOnly, G_info
        txtName.SetFocus
        Exit Sub
    End If
    
    If Len(txtPname) < 1 Then
        G_ShowMsg "‰«„ ›«—”Ì ﬂ«—»— —« Ê«—œ ‰„«ÌÌœ!", vbOKOnly, G_info
        txtPname.SetFocus
        Exit Sub
    End If
    
    If Val(txtCode) <= 2 Then
        G_ShowMsg "ﬂœ ﬂ«—»— »«Ìœ »“—ê — «“ 2 »«‘œ!", vbOKOnly, G_exclamation
        txtCode.SetFocus
        Exit Sub
    End If
    
    If txtConfirm <> txtNewPass Then
        G_ShowMsg " ﬂ—«— —„“ ⁄»Ê— «‘ »«Â «” !", vbOKOnly, G_exclamation
        txtConfirm.SetFocus
        Exit Sub
    End If
        
    G_MyQuery = "select * from tbluser where usercode=" & txtCode
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst2.RecordCount > 0 Then
        G_ShowMsg "ﬂœ ﬂ«—»—  ﬂ—«—Ì «” .", vbOKOnly, G_exclamation
    Else
        pp = UCase(txtNewPass)
        For i = 0 To 15
            p(i) = Mid(pp, i + 1, 1)
            If IsNull(p(i)) Or p(i) = "" Or p(i) = "Ê" Then p(i) = " "
            p(i) = Chr((Asc(p(i)) Xor 666) Mod 256)
        Next
        pp = Trim(p(0) + p(1) + p(2) + p(3) + p(4) + p(5) + p(6) + p(7) + p(8) + p(9) + p(10) + p(11) + p(12) + p(13) + p(14) + p(15))
    
        G_AdoConn.Execute "INSERT INTO tblUser (USERCODE,Ename,Pname,pass) VALUES(" + txtCode + ",'" + txtName + "','" + txtPname + "','" + pp + "')"
        G_ShowMsg "„‘Œ’«  ﬂ«—»— À»  ‘œ.", vbOKOnly, G_check
        txtName = ""
        txtPname = ""
        txtNewPass = ""
        txtCode = ""
        txtConfirm = ""
        txtName.SetFocus
    End If
End Sub

Private Sub cmdChange_Click()
    Dim pp As String
    Dim p(15) As String
    Dim i As Integer

    G_MyQuery = "select * from tbluser where Ename='" + txtName + "'"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    
    If G_MyRst2.EOF Then
        G_ShowMsg "ﬂ«—»— „Ê—œ ‰Ÿ—  ⁄—Ì› ‰‘œÂ «” !", vbOKOnly, G_exclamation
        txtName.SetFocus
        Exit Sub
    End If
        
    pp = UCase(txtPass)
    For i = 0 To 15
        p(i) = Mid(pp, i + 1, 1)
        If IsNull(p(i)) Or p(i) = "" Or p(i) = "Ê" Then p(i) = " "
        p(i) = Chr((Asc(p(i)) Xor 666) Mod 256)
    Next
    pp = Trim(p(0) + p(1) + p(2) + p(3) + p(4) + p(5) + p(6) + p(7) + p(8) + p(9) + p(10) + p(11) + p(12) + p(13) + p(14) + p(15))
    
    If G_MyRst2("pass") <> pp Then
        G_ShowMsg "—„“ ⁄»Ê— ›⁄·Ì «‘ »«Â «” !", vbOKOnly, G_exclamation
        txtPass.SetFocus
    ElseIf txtConfirm <> txtNewPass Then
        G_ShowMsg "—„“ ⁄»Ê— ÃœÌœ «‘ »«Â «” !", vbOKOnly, G_exclamation
        txtConfirm.SetFocus
    Else
        pp = UCase(txtNewPass)
        For i = 0 To 15
            p(i) = Mid(pp, i + 1, 1)
            If IsNull(p(i)) Or p(i) = "" Or p(i) = "Ê" Then p(i) = " "
            p(i) = Chr((Asc(p(i)) Xor 666) Mod 256)
        Next
        pp = Trim(p(0) + p(1) + p(2) + p(3) + p(4) + p(5) + p(6) + p(7) + p(8) + p(9) + p(10) + p(11) + p(12) + p(13) + p(14) + p(15))
        
        G_AdoConn.Execute "Update  tbluser set pass='" + pp + "' where Ename='" + txtName + "'"
        G_ShowMsg "—„“ Ê—Êœ ﬂ«—»—  €ÌÌ— ﬂ—œ.", vbOKOnly, G_check
        G_SetKeyboard (enmPersian)
    End If
    If G_MyRst2.State = 1 Then G_MyRst2.Close
End Sub

Private Sub cmdDelete_Click()
    Dim pp As String
    Dim p(15) As String
    Dim i As Integer

    G_MyQuery = "select * from tbluser where Ename='" + txtName + "'"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    
    If G_MyRst2.EOF Then
        G_ShowMsg "ﬂ«—»— „Ê—œ ‰Ÿ—  ⁄—Ì› ‰‘œÂ «” !", vbOKOnly, G_exclamation
        txtName.SetFocus
        Exit Sub
    End If
    
    pp = UCase(txtPass)
    For i = 0 To 15
        p(i) = Mid(pp, i + 1, 1)
        If IsNull(p(i)) Or p(i) = "" Or p(i) = "Ê" Then p(i) = " "
        p(i) = Chr((Asc(p(i)) Xor 666) Mod 256)
    Next
    pp = Trim(p(0) + p(1) + p(2) + p(3) + p(4) + p(5) + p(6) + p(7) + p(8) + p(9) + p(10) + p(11) + p(12) + p(13) + p(14) + p(15))
    
    If G_MyRst2("pass") <> pp Then
        G_ShowMsg "—„“ ⁄»Ê— «‘ »«Â «” !", vbOKOnly, G_exclamation
        txtPass.SetFocus
        Exit Sub
    End If
    
    If G_MyRst2!UserCode > 2 Then
        G_AdoConn.Execute "DELETE  from tbluser where Ename='" + txtName.Text + "'"
        G_ShowMsg "„‘Œ’«  ﬂ«—»— Õ–› ‘œ.", vbOKOnly, G_check
    Else
        G_ShowMsg "—«Â»— ”Ì” „ Ê „”∆Ê· œ› — —« ‰„Ìù Ê«‰Ìœ Õ–› ﬂ‰Ìœ.", vbOKOnly, G_exclamation
    End If
End Sub

Private Sub cmdClose_Click()
    Unload Me
End Sub

Private Sub cmdExit_Click()
    'If G_AdoConn.State = 1 Then G_AdoConn.Close
    'Call G_SetKeyboard(enmEnglish)
    Unload frmMain
    'End
End Sub

Private Sub cmdSetDef_Click()
    Dim pp As String
    Dim p(15) As String
    Dim i As Integer
    
    G_MyQuery = "select * from tbluser where Ename='" + txtName + "'"
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst2.EOF Then
        G_ShowMsg "ﬂ«—»— „Ê—œ ‰Ÿ—  ⁄—Ì› ‰‘œÂ «” !", vbOKOnly, G_exclamation
        txtName.SetFocus
        Exit Sub
    End If
    
    pp = UCase(txtPass)
    For i = 0 To 15
        p(i) = Mid(pp, i + 1, 1)
        If IsNull(p(i)) Or p(i) = "" Or p(i) = "Ê" Then p(i) = " "
        p(i) = Chr((Asc(p(i)) Xor 666) Mod 256)
    Next
    pp = Trim(p(0) + p(1) + p(2) + p(3) + p(4) + p(5) + p(6) + p(7) + p(8) + p(9) + p(10) + p(11) + p(12) + p(13) + p(14) + p(15))
    
    If G_MyRst2("pass") <> pp Then
        G_ShowMsg "—„“ ⁄»Ê— «‘ »«Â «” !", vbOKOnly, G_exclamation
        txtPass.SetFocus
    Else
        G_CurrentUserCode = G_MyRst2!UserCode
        G_UserEname = G_MyRst2!Ename
        G_UserPname = G_MyRst2!PNAME
        G_PrgMod = G_MainformMod
        If G_CurrentUserCode = 1 Then            'ﬂ«—‘‰«”(ADMIN)
        ElseIf G_CurrentUserCode = 2 Then       '„”∆Ê· œ› —
            frmMain.mnuClearDb.Enabled = False
        Else                                    '„ ’œÌ »«ÃÂ (ﬂ«—»— ⁄«œÌ)
            frmMain.mnuLservice.Enabled = False
            frmMain.mnuClearDb.Enabled = False
            frmMain.mnuRestoreDb.Enabled = False
            frmMain.mnuBasicData.Enabled = False
            frmMain.mnuSetHard.Enabled = False
            frmMain.mnuSetSoft.Enabled = False
            frmMain.mnuSetNet.Enabled = False
            frmMain.mnuUserDefine.Enabled = False
            frmMain.mnuUserDelete.Enabled = False
            frmMain.Toolbar1.Buttons(3).Enabled = False
            frmMain.Toolbar1.Buttons(4).Enabled = False
        End If
        G_SetKeyboard (enmPersian)
        Unload Me
    End If
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    Dim i As Integer
        
    Select Case G_Login
        Case G_UserLogin
            fraPass.Visible = False
            lblPname.Visible = False
            txtPname.Visible = False
            lblCode.Visible = False
            txtCode.Visible = False
            lblPass.Visible = True
            txtPass.Visible = True
            txtPass.Top = txtPname.Top
            lblPass.Top = lblPname.Top
            cmdSetDef.Visible = True
            Cmdexit.Visible = True
            cmdAdd.Visible = False
            cmdDelete.Visible = False
            cmdChange.Visible = False
            cmdClose.Visible = False
            fraCommand.Top = txtPass.Top + txtPass.Height + 105
            Me.Height = fraCommand.Top + fraCommand.Height + 550
        Case G_UserDefine
            fraPass.Visible = True
            txtCode.Visible = True
            lblCode.Visible = True
            lblPname.Visible = True
            txtPname.Visible = True
            lblPass.Visible = False
            txtPass.Visible = False
            cmdSetDef.Visible = False
            Cmdexit.Visible = False
            cmdAdd.Visible = True
            cmdDelete.Visible = False
            cmdChange.Visible = False
            cmdClose.Visible = True
            fraPass.Top = txtPass.Top
            fraCommand.Top = fraPass.Top + fraPass.Height + 105
            Me.Height = fraCommand.Top + fraCommand.Height + 550
        Case G_UserDelete
            fraPass.Visible = False
            txtCode.Visible = False
            lblCode.Visible = False
            lblPname.Visible = False
            txtPname.Visible = False
            txtPass.Top = txtPname.Top
            lblPass.Top = lblPname.Top
            lblPass.Visible = True
            txtPass.Visible = True
            cmdSetDef.Visible = False
            Cmdexit.Visible = False
            cmdAdd.Visible = False
            cmdDelete.Visible = True
            cmdChange.Visible = False
            cmdClose.Visible = True
            fraCommand.Top = txtPass.Top + txtPass.Height + 105
            Me.Height = fraCommand.Top + fraCommand.Height + 550
        Case G_UserSetPassword
            fraPass.Visible = True
            txtCode.Visible = False
            lblCode.Visible = False
            txtPass.Top = txtPname.Top
            lblPass.Top = lblPname.Top
            lblPass.Visible = True
            txtPass.Visible = True
            lblPname.Visible = False
            txtPname.Visible = False
            cmdSetDef.Visible = False
            Cmdexit.Visible = False
            cmdAdd.Visible = False
            cmdDelete.Visible = False
            cmdChange.Visible = True
            cmdClose.Visible = True
            fraPass.Top = txtPass.Top + txtPass.Height + 105
            fraCommand.Top = fraPass.Top + fraPass.Height + 105
            Me.Height = fraCommand.Top + fraCommand.Height + 550
    End Select
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    If G_PrgMod <> G_MainformMod Then cmdExit_Click
End Sub

Private Sub txtConfirm_GotFocus()
    Call G_SetKeyboard(enmEnglish)
End Sub

Private Sub txtName_GotFocus()
    Call G_SetKeyboard(enmEnglish)
End Sub

Private Sub txtNewPass_GotFocus()
    Call G_SetKeyboard(enmEnglish)
End Sub

Private Sub txtPass_GotFocus()
    Call G_SetKeyboard(enmEnglish)
End Sub

Private Sub txtPname_GotFocus()
    Call G_SetKeyboard(enmPersian)
End Sub
