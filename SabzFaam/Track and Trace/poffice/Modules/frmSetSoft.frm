VERSION 5.00
Begin VB.Form frmSetSoft 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   " ‰ŸÌ„«  ‰—„ «›“«—Ì"
   ClientHeight    =   4320
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   6945
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   4320
   ScaleWidth      =   6945
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   Begin VB.Frame gbRegistrationSort 
      Caption         =   "„— » ”«“Ì œ— ê“«—‘ À» "
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
      Height          =   975
      Left            =   3600
      RightToLeft     =   -1  'True
      TabIndex        =   30
      Top             =   2760
      Width           =   3255
      Begin VB.OptionButton optRegistrationSort 
         Alignment       =   1  'Right Justify
         Caption         =   "‘„«—Â „—”Ê·Â"
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
         Left            =   1200
         RightToLeft     =   -1  'True
         TabIndex        =   32
         Top             =   240
         Value           =   -1  'True
         Width           =   1575
      End
      Begin VB.OptionButton optRegistrationSort 
         Alignment       =   1  'Right Justify
         Caption         =   " — Ì» Ê—Êœ «ÿ·«⁄« "
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
         Left            =   840
         RightToLeft     =   -1  'True
         TabIndex        =   31
         Top             =   600
         Width           =   1935
      End
   End
   Begin VB.Frame gbSoshSort 
      Caption         =   "„— » ”«“Ì œ— —”Ìœ „—”Ê·«  «‰»ÊÂ"
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
      Height          =   975
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   27
      Top             =   2760
      Width           =   3255
      Begin VB.OptionButton optSoshSort 
         Alignment       =   1  'Right Justify
         Caption         =   " — Ì» Ê—Êœ «ÿ·«⁄« "
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
         Left            =   840
         RightToLeft     =   -1  'True
         TabIndex        =   29
         Top             =   600
         Width           =   1935
      End
      Begin VB.OptionButton optSoshSort 
         Alignment       =   1  'Right Justify
         Caption         =   "‘„«—Â „—”Ê·Â"
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
         Left            =   1200
         RightToLeft     =   -1  'True
         TabIndex        =   28
         Top             =   240
         Value           =   -1  'True
         Width           =   1575
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "ﬂœ —„“ ‘œÂ"
      Height          =   375
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   26
      Top             =   3840
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.TextBox txtRegionCode 
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
      TabIndex        =   10
      Top             =   1560
      Width           =   945
   End
   Begin VB.TextBox txtPncode 
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
      TabIndex        =   4
      Top             =   480
      Width           =   945
   End
   Begin VB.TextBox txtBajehcode 
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
      Left            =   90
      Locked          =   -1  'True
      MaxLength       =   5
      RightToLeft     =   -1  'True
      TabIndex        =   12
      Top             =   1920
      Width           =   975
   End
   Begin VB.TextBox txtEncrypted 
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
      Left            =   4320
      Locked          =   -1  'True
      MaxLength       =   8
      RightToLeft     =   -1  'True
      TabIndex        =   2
      Tag             =   "1"
      Top             =   120
      Width           =   945
   End
   Begin VB.TextBox txtGhabz 
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
      Left            =   2760
      Locked          =   -1  'True
      MaxLength       =   8
      RightToLeft     =   -1  'True
      TabIndex        =   13
      Tag             =   "1"
      Top             =   2280
      Width           =   1665
   End
   Begin VB.TextBox txtBajeh 
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
      Left            =   2730
      Locked          =   -1  'True
      MaxLength       =   30
      RightToLeft     =   -1  'True
      TabIndex        =   11
      Top             =   1920
      Width           =   2535
   End
   Begin VB.TextBox txtRegionName 
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
      Left            =   2730
      Locked          =   -1  'True
      MaxLength       =   30
      RightToLeft     =   -1  'True
      TabIndex        =   9
      Top             =   1560
      Width           =   2535
   End
   Begin VB.TextBox txtDaftar 
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
      Left            =   2760
      Locked          =   -1  'True
      RightToLeft     =   -1  'True
      TabIndex        =   3
      Top             =   480
      Width           =   2505
   End
   Begin VB.TextBox txtProvince 
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
      Left            =   2760
      Locked          =   -1  'True
      RightToLeft     =   -1  'True
      TabIndex        =   5
      Top             =   840
      Width           =   2505
   End
   Begin VB.TextBox txtPrcode 
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
      TabIndex        =   6
      Top             =   840
      Width           =   945
   End
   Begin VB.TextBox txtCity 
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
      Left            =   2760
      Locked          =   -1  'True
      RightToLeft     =   -1  'True
      TabIndex        =   7
      Top             =   1200
      Width           =   2505
   End
   Begin VB.TextBox txtCTcode 
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
      TabIndex        =   8
      Top             =   1200
      Width           =   945
   End
   Begin VB.CommandButton cmdClose 
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
      Left            =   2160
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Top             =   3840
      Width           =   1215
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
      Left            =   3480
      RightToLeft     =   -1  'True
      TabIndex        =   0
      Top             =   3840
      Width           =   1215
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ „‰ÿﬁÂ Å” Ì:"
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
      Left            =   1200
      RightToLeft     =   -1  'True
      TabIndex        =   25
      Top             =   1620
      Width           =   1215
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ —ÂêÌ—Ì:"
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
      Left            =   1200
      RightToLeft     =   -1  'True
      TabIndex        =   24
      Top             =   540
      Width           =   825
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "„‰ÿﬁÂ Å” Ì:"
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
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   23
      Top             =   1620
      Width           =   1005
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "‘„«—Â ”—Ì«· Ã«—Ì ﬁ»÷ —”Ìœ:"
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
      Left            =   4560
      RightToLeft     =   -1  'True
      TabIndex        =   22
      Top             =   2340
      Width           =   2190
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "‰«„ »«ÃÂ Å” Ì:"
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
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   21
      Top             =   1980
      Width           =   1080
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "‰«„ œ› — Å” Ì:"
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
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   20
      Top             =   540
      Width           =   1080
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
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
      Index           =   17
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   19
      Top             =   900
      Width           =   480
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "‘Â—” «‰:"
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
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   18
      Top             =   1260
      Width           =   765
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ «” «‰:"
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
      Left            =   1200
      RightToLeft     =   -1  'True
      TabIndex        =   17
      Top             =   900
      Width           =   690
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ ‘Â—” «‰:"
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
      Left            =   1200
      RightToLeft     =   -1  'True
      TabIndex        =   16
      Top             =   1260
      Width           =   975
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ »«ÃÂ:"
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
      Left            =   1200
      RightToLeft     =   -1  'True
      TabIndex        =   15
      Top             =   1980
      Width           =   555
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ﬂœ —„“‘œÂ —ÂêÌ—Ì:"
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
      Left            =   5400
      RightToLeft     =   -1  'True
      TabIndex        =   14
      Top             =   180
      Width           =   1425
   End
End
Attribute VB_Name = "frmSetSoft"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim L_EditFlag As Boolean
' true:edit mode
' false:normal mode

Private Sub cmdClose_Click()
    Unload Me
End Sub

Private Sub cmdEdit_Click()
    On Error GoTo Err_label
    
    gbRegistrationSort.Enabled = Not L_EditFlag
    gbSoshSort.Enabled = Not L_EditFlag
    
    If L_EditFlag = False Then
        txtEncrypted.Locked = False
        txtRegionName.Locked = False
        txtBajeh.Locked = False
        txtBajehcode.Locked = False
        txtGhabz.Locked = False
        cmdEdit.Caption = "À»  „‘Œ’« "
        
        txtEncrypted.SetFocus
        L_EditFlag = True
    Else
        If txtPncode.Text = "" Or txtEncrypted = "" Or txtBajeh = "" Or txtBajehcode = "" Then
            Call G_ShowMsg("ﬂœ —ÂêÌ—Ì ‰«„⁄ »— «”  Ì« ÌﬂÌ «“ „ﬁ«œÌ— Ê«—œ ‰‘œÂ «” !", vbOKOnly, G_exclamation)
            txtEncrypted.SetFocus
        Else
            SaveSetting "Track&Trace", "PostOffice", "pn-code", txtEncrypted.Text
            SaveSetting "Track&Trace", "PostOffice", "zone-name", txtRegionName
            SaveSetting "Track&Trace", "PostOffice", "baje-name", txtBajeh.Text
            SaveSetting "Track&Trace", "PostOffice", "baje-code", txtBajehcode.Text
            
            Dim LocaladoRst As ADODB.Recordset
            Set LocaladoRst = New ADODB.Recordset
            LocaladoRst.Open "SELECT Max(Mid([Uniquecode],11,8)) AS MaxPurcelCode FROM tblParcels", G_AdoConn, adOpenForwardOnly, adLockReadOnly
            If Not IsNull(LocaladoRst.Fields("MaxPurcelCode")) Then
                G_DBstartn = LocaladoRst.Fields("MaxPurcelCode").Value + 1
            Else
                G_DBstartn = "00000000"
            End If
            LocaladoRst.Close
            Set LocaladoRst = Nothing
            If Val(txtGhabz.Text) < Val(G_DBstartn) Then
                G_ShowMsg "»«  ÊÃÂ »Â ÊÃÊœ «ÿ·«⁄«  œ— »«‰ﬂ Õœ«ﬁ· „ﬁœ«— ‘„«—Â ”—Ì«·" + CStr(G_DBstartn) + "„Ìù»«‘œ.", vbOKOnly, G_exclamation
                txtGhabz.Text = G_DBstartn
            End If
            'SaveSetting "Track&Trace", "PostOffice", "startno", txtGhabz.Text
            SaveSetting "Track&Trace", "PostOffice", "startno", G_GetEncrypted(txtGhabz.Text)
            
            If optRegistrationSort(0).Value Then
                G_RegistrationSort = 0
            Else
                G_RegistrationSort = 1
            End If
            SaveSetting "Track&Trace", "PostOffice", "RegistrationSort", G_RegistrationSort
            
            If optSoshSort(0).Value Then
                G_SoshSort = 0
            Else
                G_SoshSort = 1
            End If
                
            SaveSetting "Track&Trace", "PostOffice", "SoshSort", G_SoshSort
            
            G_PnName = txtDaftar.Text
            G_PnCode = GetDecodedPostNodeCode(Trim(GetSetting("Track&Trace", "PostOffice", "pn-code")))
            G_CityName = txtCity.Text
            G_RegionName = txtRegionName.Text
            G_RegionCode = txtRegionCode.Text
            G_CityCode = txtCTcode.Text
            G_ProvinceName = txtProvince.Text
            G_ProvinceCode = txtPrcode.Text
            G_BajehName = txtBajeh.Text
            G_BajehCode = txtBajehcode.Text
            G_Startn = G_GetDecrypted(GetSetting("Track&Trace", "PostOffice", "startno"))
                    
            G_ShowMsg " ‰ŸÌ„«  «‰Ã«„ ‘œ", vbOKOnly, G_check
            txtEncrypted.Locked = True
            txtRegionName.Locked = True
            txtBajeh.Locked = True
            txtBajehcode.Locked = True
            txtGhabz.Locked = True
            cmdEdit.Caption = "«’·«Õ"
            L_EditFlag = False
        End If
    End If
    Exit Sub
Err_label:
    G_ShowMsg "»—Ê“ Œÿ«", vbOKOnly, G_critical
End Sub

Private Sub Command1_Click()
    'MsgBox G_GetEncrypted(txtBajeh.Text)
    txtEncrypted.Text = GetEncodedPostNodeCode(txtBajeh.Text)
End Sub

'form.KeyPreview=True »—«Ì œ—”  ﬂ«— ﬂ—œ‰ «Ì‰  «»⁄ »«Ìœ Œ«’Ì 
Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    L_EditFlag = False
    'MsgBox (GetEncodedPostNodeCode("20829"))
    If G_PnCode <> "" Then
        txtProvince = G_ProvinceName
        txtPrcode = G_ProvinceCode
        txtCity = G_CityName
        txtCTcode = G_CityCode
        txtRegionName = G_RegionName
        txtRegionCode = G_RegionCode
        txtDaftar = G_PnName
        txtEncrypted = modPoffice.GetEncodedPostNodeCode(G_PnCode)
        txtPncode.Text = G_PnCode
        txtBajeh = G_BajehName
        txtBajehcode = G_BajehCode
        txtGhabz = G_Startn
    End If
    
    optRegistrationSort(G_RegistrationSort).Value = True
    optSoshSort(G_SoshSort).Value = True

End Sub

Private Sub Form_Unload(Cancel As Integer)
    If G_MyRst.State = 1 Then G_MyRst.Close
End Sub

Private Sub Option3_Click()

End Sub

Private Sub txtEncrypted_LostFocus()
    If cmdEdit.Caption = "À»  „‘Œ’« " Then
        txtPncode.Text = modPoffice.GetDecodedPostNodeCode(txtEncrypted.Text)
        If txtPncode = "" Then Exit Sub
        G_MyQuery = "SELECT POSTNODE.CODE, POSTNODE.PNAME,POSTNODE.REGION_CODE, POSTNODE.POSTNODE_GROUP_CODE, POSTNODE.CITY_CODE, CITY.PName as CityName, CITY.STATE_CODE as Provincecode, STATE.PName as ProvinceName" _
            + " FROM STATE INNER JOIN (City INNER JOIN PostNode ON City.Code = PostNode.CITY_CODE) ON STATE.Code = City.STATE_CODE" _
            + " WHERE POSTNODE.CODE=" + txtPncode.Text
        If G_MyRst.State = 1 Then G_MyRst.Close
        G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If G_MyRst.EOF = True Then
            txtEncrypted = ""
            txtPncode.Text = ""
            txtRegionName = ""
            txtRegionCode = ""
            txtProvince = ""
            txtPrcode = ""
            txtCity = ""
            txtCTcode = ""
            txtDaftar = ""
        Else
            If IsNull(G_MyRst!REGION_CODE) Then
                txtRegionCode = ""
            Else
                txtRegionCode = G_MyRst!REGION_CODE
            End If
            
            txtProvince = G_MyRst("ProvinceName")
            txtPrcode = G_MyRst("Provincecode")
            txtDaftar = G_MyRst("PNAME")
           
            If G_MyRst("CITY_CODE") = 1011 Or G_MyRst("CITY_CODE") = 1012 Or G_MyRst("CITY_CODE") = 1013 Or G_MyRst("CITY_CODE") = 1014 Or G_MyRst("CITY_CODE") = 1015 Or G_MyRst("CITY_CODE") = 1016 Or G_MyRst("CITY_CODE") = 1017 Or G_MyRst("CITY_CODE") = 1018 Or G_MyRst("CITY_CODE") = 1019 Then
                txtCity = " Â—«‰"
                txtCTcode = 1
            Else
                txtCity = G_MyRst("CityName")
                txtCTcode = G_MyRst("CITY_CODE")
            End If
        End If
    End If
End Sub
