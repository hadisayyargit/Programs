VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Begin VB.Form frmMain 
   BackColor       =   &H80000001&
   Caption         =   "”Ì” „ Ã«„⁄ œ› — Å” Ì"
   ClientHeight    =   6030
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   9900
   HelpContextID   =   1
   Icon            =   "frmMain.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   RightToLeft     =   -1  'True
   ScaleHeight     =   6030
   ScaleWidth      =   9900
   StartUpPosition =   3  'Windows Default
   Visible         =   0   'False
   WindowState     =   2  'Maximized
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   720
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483633
      ImageWidth      =   29
      ImageHeight     =   27
      MaskColor       =   65535
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   9
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0CCA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1666
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":2002
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":299E
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":333A
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":3CD6
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":4672
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":500E
            Key             =   ""
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":59AA
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   120
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      FilterIndex     =   1
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      TabIndex        =   1
      Top             =   5655
      Width           =   9900
      _ExtentX        =   17463
      _ExtentY        =   661
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   4
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Alignment       =   1
            AutoSize        =   2
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   5
            Alignment       =   1
            AutoSize        =   2
            TextSave        =   "10:06 ».Ÿ"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
         EndProperty
         BeginProperty Panel4 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Alignment       =   2
            AutoSize        =   1
            Object.Width           =   9234
            Text            =   "‰—„ «›“«— œ› — Å” Ì ‰”ŒÂ 3.6.3"
            TextSave        =   "‰—„ «›“«— œ› — Å” Ì ‰”ŒÂ 3.6.3"
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
   Begin MSComctlLib.Toolbar Toolbar1 
      Height          =   735
      Left            =   3960
      TabIndex        =   0
      Top             =   0
      Width           =   11280
      _ExtentX        =   19897
      _ExtentY        =   1296
      ButtonWidth     =   1984
      ButtonHeight    =   1244
      Appearance      =   1
      Style           =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   12
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "—«Â‰„«"
            Key             =   "k9"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "ê“«—‘« "
            Key             =   "k6"
            ImageIndex      =   8
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "ÅÌﬂ—»‰œÌ"
            Key             =   "k7"
            ImageIndex      =   9
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   3
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k71"
                  Text            =   " ‰ŸÌ„«  ‰—„ «›“«—"
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k72"
                  Text            =   " ‰ŸÌ„«  ”Œ  «›“«—"
               EndProperty
               BeginProperty ButtonMenu3 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k73"
                  Text            =   "«— »«ÿ«  ‘»ﬂÂù«Ì"
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "«ÿ·«⁄«  Å«ÌÂ"
            Key             =   "k8"
            ImageIndex      =   2
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   2
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k81"
                  Text            =   "ﬁ—«—œ«œÂ«Ì ”—«”—Ì"
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k82"
                  Text            =   "ﬁ—«—œ«œÂ«Ì «” «‰Ì"
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "«—”«· «ÿ·«⁄« "
            Key             =   "k5"
            ImageIndex      =   7
         EndProperty
         BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "œ› — ⁄„·ﬂ—œ"
            Key             =   "k1"
            ImageIndex      =   1
         EndProperty
         BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "œÅ‘ »‰œÌ"
            Key             =   "k4"
            ImageIndex      =   3
         EndProperty
         BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "·Ì«” »‰œÌ"
            Key             =   "k3"
            ImageIndex      =   6
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   2
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k31"
                  Text            =   "ÅÌ‘ «“"
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k32"
                  Text            =   "”›«—‘Ì"
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "ﬁ»Ê· „—”Ê·Â"
            Key             =   "k2"
            Object.ToolTipText     =   "ﬁ»Ê· „—”Ê·Â"
            ImageIndex      =   5
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   2
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k21"
                  Text            =   "ÅÌ‘ «“"
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "k22"
                  Text            =   "”›«—‘Ì"
               EndProperty
            EndProperty
         EndProperty
      EndProperty
      BorderStyle     =   1
   End
   Begin VB.Menu mnuFnc 
      Caption         =   "⁄„·Ì« "
      Begin VB.Menu mnuEms 
         Caption         =   "ÅÌ‘ «“"
         Begin VB.Menu mnuReceipt 
            Caption         =   "ﬁ»Ê· „—”Ê·Â"
         End
         Begin VB.Menu mnuLias 
            Caption         =   "·Ì«” »‰œÌ"
         End
         Begin VB.Menu mnuDispatch 
            Caption         =   "œÅ‘ »‰œÌ"
         End
      End
      Begin VB.Menu mnuNormal 
         Caption         =   "”›«—‘Ì"
         Begin VB.Menu mnuNReceipt 
            Caption         =   "ﬁ»Ê· „—”Ê·Â"
         End
         Begin VB.Menu mnuNLias 
            Caption         =   "·Ì«” »‰œÌ"
         End
      End
      Begin VB.Menu mnuSep2 
         Caption         =   "-"
      End
      Begin VB.Menu mnuTraffic 
         Caption         =   "œ› — ⁄„·ﬂ—œ"
      End
      Begin VB.Menu mnuSep1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuQuit 
         Caption         =   "Œ—ÊÃ"
      End
   End
   Begin VB.Menu mnuDeclare 
      Caption         =   "«ÿ·«⁄«  Å«ÌÂ"
      Begin VB.Menu mnuGservice 
         Caption         =   "ﬁ—«—œ«œÂ«Ì ”—«”—Ì"
      End
      Begin VB.Menu mnuLservice 
         Caption         =   "ﬁ—«—œ«œÂ«Ì „Õ·Ì ÅÌ‘ «“"
      End
      Begin VB.Menu mnuUsers 
         Caption         =   "ﬂ«—»—«‰"
         Begin VB.Menu mnuUserDefine 
            Caption         =   " ⁄—Ì› ﬂ«—»—"
         End
         Begin VB.Menu mnuUserDelete 
            Caption         =   "Õ–› ﬂ«—»—"
         End
         Begin VB.Menu mnuUserPass 
            Caption         =   " €ÌÌ— —„“ Ê—Êœ"
         End
      End
   End
   Begin VB.Menu mnuReports 
      Caption         =   "ê“«—‘« "
   End
   Begin VB.Menu mnuReplicate 
      Caption         =   "Â„«Â‰ê ”«“Ì «ÿ·«⁄« "
      Begin VB.Menu mnuErsal 
         Caption         =   "«—”«· «ÿ·«⁄« "
      End
      Begin VB.Menu mnuSep3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuClearDb 
         Caption         =   " Œ·ÌÂ »«‰ﬂ «ÿ·«⁄« Ì"
      End
      Begin VB.Menu mnuBackupDb 
         Caption         =   " ÂÌÂ ‰”ŒÂ Å‘ Ì»«‰"
      End
      Begin VB.Menu mnuRestoreDb 
         Caption         =   "»«“Ì«»Ì «ÿ·«⁄«  «“ ‰”ŒÂ Å‘ Ì»«‰"
      End
      Begin VB.Menu mnuBasicData 
         Caption         =   "»«—êÌ—Ì «ÿ·«⁄«  Å«ÌÂ"
      End
   End
   Begin VB.Menu mnuSetting 
      Caption         =   "ÅÌﬂ— »‰œÌ"
      Begin VB.Menu mnuSetHard 
         Caption         =   " ‰ŸÌ„«  ”Œ  «›“«—"
      End
      Begin VB.Menu mnuSetSoft 
         Caption         =   " ‰ŸÌ„«  ‰—„ «›“«—"
      End
      Begin VB.Menu mnuSetNet 
         Caption         =   "«— »«ÿ«  ‘»ﬂÂ «Ì"
      End
      Begin VB.Menu mnuView 
         Caption         =   "‰„«Ì‘ ›Â—”  „—”Ê·« "
         Begin VB.Menu mnuView1 
            Caption         =   "—Ê“«‰Â"
            Index           =   0
         End
         Begin VB.Menu mnuView1 
            Caption         =   "Â› êÌ"
            Index           =   1
         End
         Begin VB.Menu mnuView1 
            Caption         =   "ﬂ·Ì"
            Checked         =   -1  'True
            Index           =   2
         End
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "—«Â‰„«"
      Begin VB.Menu mnuHelpBajeh 
         Caption         =   "«ÿ·«⁄«  ›‰Ì Ê ﬂ„ﬂÌ"
         Shortcut        =   {F1}
      End
      Begin VB.Menu mnyWebSite 
         Caption         =   "Å«Ìê«Â «ÿ·«⁄« Ì ‘—ﬂ  Å”  »— —ÊÌ Ê»"
      End
      Begin VB.Menu mnuSep4 
         Caption         =   "-"
      End
      Begin VB.Menu mnuAbout 
         Caption         =   "„⁄—›Ì     "
         Shortcut        =   {F2}
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim m_strDispatchDate As String

Private Sub m_SendData()
    Dim strCommandLineInstruction As String
    strCommandLineInstruction = "POfficeReplicationClient S " + G_RemoteHost + " " + G_RemotePort + " " + G_PnCode + " " + G_RemoteTimeOut + " " + G_RemoteRecordCount
    Shell (G_MyPath + "\" + strCommandLineInstruction)
    G_MyQuery = "update tblDispatch set TRANSFERRED_TAG = 1 where TRANSFERRED_TAG = 2"
    G_AdoConn.Execute G_MyQuery
    Sleep (100)
    frmWait.Hide
    Unload frmWait
    Screen.MousePointer = vbDefault
End Sub

Private Sub m_InsertDispatchToReplicationOutbox(strDispatchCode As String)
    Dim Result As Boolean
    Dim strXmlInstruction As String
    Dim strDispatchPostNodeCode, strDispatchSerial As String
    Dim strParcelCode, strReceiptCode, strDestinationCode, strRegisterationNo, strWeight, strPrice, strBagParcelsSerial As String
    
    Result = True
    
    strDispatchPostNodeCode = Mid(strDispatchCode, 6, 5)
    strDispatchSerial = Mid(strDispatchCode, 11, 4)
    
    G_AdoConn.BeginTrans
    ' // todo: set creation_time correct
    If Result Then    'dispatch
        strXmlInstruction = "<RowData ISIMPORTED=""0"" POSTNODE_CODE=""" + strDispatchPostNodeCode + """ SERIAL=""" + strDispatchSerial + """ CREATION_DATETIME=""" + m_strDispatchDate + """ ISOPEN=""1"" TRANSPORT_TYPECODE=""0"" />"
        Result = modPoffice.G_InsertToReplicationOutbox("DISPATCH", "I", strXmlInstruction)
    End If
    
    If Result Then   ' bag
        strXmlInstruction = "<RowData DISPATCH_ISIMPORTED=""0"" DISPATCH_POSTNODE_CODE=""" + strDispatchPostNodeCode + """ DISPATCH_SERIAL=""" + strDispatchSerial + """ BAG_NO=""1"" ISTRANSIT=""0"" WEIGHT=""0"" />"
        Result = G_InsertToReplicationOutbox("BAG", "I", strXmlInstruction)
    End If
        
    If Result Then
        G_MyQuery = "SELECT * FROM V_DISPATCH_PARCEL WHERE DISPATCH_CODE='" + strDispatchCode + "'"
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        While Not G_MyRst2.EOF
            'parcel
            strParcelCode = Trim(G_MyRst2!parcel_code)
            strRegisterationNo = Trim(Str(G_MyRst2!Registeration_no))
            strDestinationCode = Format(G_MyRst2!destcode, "00000")
            If IsNull(G_MyRst2!RECEIPT_CODE) Then
                strReceiptCode = ""
            Else
                strReceiptCode = Trim(G_MyRst2!RECEIPT_CODE)
            End If
            strWeight = Trim(Str(G_MyRst2!Weight))
            strPrice = Trim(Str(G_MyRst2!Price))
            strBagParcelsSerial = Trim(Str(G_MyRst2!BAG_PARCELS_SERIAL))
            
            strXmlInstruction = "<RowData CODE=""" + strParcelCode + """ WEIGHT=""" + strWeight + """ PRICE=""" + strPrice + """ SOURCE_POSTNODE_CODE=""" + G_PnCode + """ DESTINATION_CITY_CODE=""" + strDestinationCode + """ IPS_CODE=""NULL"" RECEIPT_CODE=""" + strReceiptCode + """ RECORD_DATE=""" + m_strDispatchDate + """ />"
            Result = G_InsertToReplicationOutbox("PARCEL", "I", strXmlInstruction)
            'bag_parcels
            strXmlInstruction = "<RowData DISPATCH_ISIMPORTED=""0"" DISPATCH_POSTNODE_CODE=""" + strDispatchPostNodeCode + """ DISPATCH_SERIAL=""" + strDispatchSerial + """ PARCEL_CODE=""" + strParcelCode + """ BAG_NO=""1"" REGISTERATION_NO=""" + strRegisterationNo + """ SERIAL=""" + strBagParcelsSerial + """ />"
            Result = G_InsertToReplicationOutbox("BAG_PARCELS", "I", strXmlInstruction)
            If Result Then
                G_MyRst2.MoveNext
            Else
                'exit while
            End If
        Wend
    End If
    
    If Result Then    'dispatch
        strXmlInstruction = "<RowData ISIMPORTED=""0"" POSTNODE_CODE=""" + strDispatchPostNodeCode + """ SERIAL=""" + strDispatchSerial + """ CREATION_DATETIME=""" + m_strDispatchDate + """ ISOPEN=""0"" TRANSPORT_TYPECODE=""0"" /> <PrimaryKey ISIMPORTED=""0"" POSTNODE_CODE=""" + strDispatchPostNodeCode + """ SERIAL=""" + strDispatchSerial + """ />"
        Result = G_InsertToReplicationOutbox("DISPATCH", "U", strXmlInstruction)
    End If

    Sleep (3000)
    If Result Then    '
        G_MyQuery = "update tblDispatch set TRANSFERRED_TAG = 2 where DISPATCH_CODE='" & strDispatchCode & "'"
        G_AdoConn.Execute G_MyQuery
        Sleep (1000)
    End If
    
    frmWait.Hide
    Unload frmWait
    Screen.MousePointer = vbDefault
    If Result Then
        G_AdoConn.CommitTrans
        'modGlobal.G_ShowMsg "«ÿ·«⁄«  ¬„«œÂ «—”«· Â” ‰œ", vbOKOnly
    Else
       G_AdoConn.RollbackTrans
       'modGlobal.G_ShowMsg "Œÿ« œ— ¬„«œÂ ”«“Ì «ÿ·«⁄« ", vbOKOnly
    End If
End Sub

Private Sub m_Prepare_ReplicationOutbox()
    Dim m_CurrentDispatch As String
    Dim nCount As Integer
             
    G_MyQuery = "SELECT * FROM tblDispatch WHERE ISOPEN = 0 AND TRANSFERRED_TAG = 0"
    If G_PrimaryRs.State = 1 Then G_PrimaryRs.Close
    G_PrimaryRs.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_PrimaryRs.EOF Then
        frmWait.Hide
        Unload frmWait
        Screen.MousePointer = vbDefault
        modGlobal.G_ShowMsg "ÂÌç œÅ‘ œÌê—Ì »—«Ì ¬„«œÂ ”«“Ì ÊÃÊœ ‰œ«—œ", vbOKOnly, G_info
        Exit Sub
    End If
    
    
    '<Hadi >1386/09/12
    While Not G_PrimaryRs.EOF
    'If Not G_PrimaryRs.EOF Then
        m_CurrentDispatch = Trim(G_PrimaryRs!DISPATCH_CODE)
        m_strDispatchDate = G_FormatDate(G_PrimaryRs!CREATION_DATETIME)
        'Mar 10 2004 12:17PM
        m_InsertDispatchToReplicationOutbox (m_CurrentDispatch)
        nCount = G_PrimaryRs.RecordCount - 1
        
        'œ·Ì· ‰Ê‘ ‰ Œÿ Å«ÌÌ‰ ﬁ«ÿ “œ‰ »«‰ﬂ «ÿ·«⁄« Ì «” 
        Sleep (1000)
       ' modGlobal.G_ShowMsg " ⁄œ«œ " + Str(nCount) + " œÅ‘ œÌê— »—«Ì ¬„«œÂ ”«“Ì ÊÃÊœ œ«—œ", vbOKOnly, G_info
        G_AdoConn.Execute ("delete from REPLICATION_OUTBOX where TABLE_NAME='NULL'")
        '»—«Ì Õ›Ÿ ”—⁄  «—”«· œÅ‘Â« —«  ﬂ  ﬂ «‰Ã«„ „ÌœÂÌ„
        
        '<Hadi >1386/09/12
        ' unremark this line
        G_PrimaryRs.MoveNext
        '</Hadi>
    Wend
   ' End If
   '</Hadi>
End Sub

Sub m_Replicate()
    
    Dim strCommandLineArgument As String
    
    Screen.MousePointer = vbHourglass
    frmWait.Show
    m_Prepare_ReplicationOutbox
    frmWait.Show
    m_SendData
    
    'strCommandLineArgument = G_DbPath + "\ttpoffice.mdb"
    'Shell G_MyPath + "\replicator\replicator " + strCommandLineArgument, vbNormalFocus
    Screen.MousePointer = vbDefault
 
End Sub

Private Sub mnuBasicData_Click()
    Call G_LoadBasicData
End Sub

Private Sub mnuCleardb_Click()
    Call G_ClearMDB
End Sub

Private Sub mnuDispatch_Click()
    G_IsEMS = 1
    frmDispatch.Show 1
End Sub

Private Sub mnuGservice_Click()
    frmContract_Global.Show 1
End Sub

Private Sub mnuNLias_Click()
    G_IsEMS = 0
    frmRegister.Show 1
End Sub

Private Sub mnuNReceipt_Click()
    G_IsEMS = 0
    frmReceiptList.Show 1
End Sub

Private Sub mnuReports_Click()
    frmDialogReport.Show 1
End Sub

Private Sub mnuUserDelete_Click()
    G_Login = G_UserDelete
    G_SetKeyboard (enmEnglish)
    frmUserInfo.Show 1
End Sub

Private Sub Form_Activate()
    If frmSetHard.Visible Then frmSetHard.SetFocus
End Sub

Private Sub Form_Load() 'ok
    Screen.MousePointer = vbHourglass
    Screen.MousePointer = 0
    StatusBar1.Panels(1).Text = G_CurrentDate + " " + G_CurrentWeekDay
    mnuView1(0).Checked = False
    mnuView1(1).Checked = False
    mnuView1(2).Checked = False
    mnuView1(G_WeeklyShow).Checked = True
    Show
    G_Login = G_UserLogin
    frmUserInfo.Show 1
    StatusBar1.Panels(3).Text = G_UserPname
    Call G_SetKeyboard(enmPersian)
    If Len(G_PnCode) < 5 Then
        G_ShowMsg "«ÿ·«⁄«  œ› — Å” Ì —« Ê«—œ ﬂ‰Ìœ", vbOKOnly, G_info
        Call G_ShowMsg("ç‰«‰çÂ »«‰ﬂ «ÿ·«⁄«  ‘„« Œ«·Ì „Ìù»«‘œ Ê ﬁ»·« »« »—‰«„Â ﬂ«— ﬂ—œÂù«Ìœ ¬Œ—Ì‰ ‘„«—Â ”—Ì«· —« «“ ”«Ì  „—ﬂ“Ì œ—Ì«›  ‰„«ÌÌœ", vbOKOnly, G_exclamation)
        frmSetSoft.Show 1
    End If
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
     G_ShowMsg " ¬Ì« «“ »—‰«„Â Œ«—Ã „Ìù‘ÊÌœø", vbYesNo, G_question
    If Not (G_MsgButton = vbYes) Then
        Cancel = True
    Else
        If G_AdoConn.State = 1 Then G_AdoConn.Close
        Call G_SetKeyboard(enmEnglish)
        End
    End If
End Sub

Private Sub Form_Resize()
    StatusBar1.Visible = False
    Toolbar1.Visible = False
    If Me.WindowState <> 1 Then
        Toolbar1.Left = Width - Toolbar1.Width
    End If
    StatusBar1.Visible = True
    Toolbar1.Visible = True
End Sub

Private Sub mnuBackupdb_Click()
    Call G_BackupMDB
End Sub

Private Sub MnuAbout_Click() 'ok
    frmSplash.Show
End Sub

Private Sub mnuErsal_Click()
    m_Replicate
End Sub

Private Sub mnuReceipt_Click() 'question
    G_IsEMS = 1
    frmReceiptList.Show 1
End Sub

Private Sub mnutraffic_Click() 'ok
    frmTraffic.Show 1
End Sub

Private Sub MnuHelpBajeh_Click()
    'SendKeys "{F1}"
    Dim ie As New InternetExplorer
    ie.Visible = True
    ie.Navigate G_MyPath + "\help\index.htm"
    Set ie = Nothing
End Sub

Private Sub mnuLias_Click()
    G_IsEMS = 1
    frmRegister.Show 1
End Sub

Private Sub mnuLservice_Click()
    frmContract_Local.Show 1
End Sub

Private Sub mnuquit_Click() 'ok
    Unload Me
End Sub

Private Sub mnuUserPass_Click()
    G_Login = G_UserSetPassword
    G_SetKeyboard (enmEnglish)
    frmUserInfo.Show 1
End Sub

Private Sub mnuRestoreDb_Click()
    If (G_RestoreMDB) Then
        Call G_ShowMsg("¬Ì« ⁄„·Ì«  »«—êÌ—Ì «ÿ·«⁄«  Å«ÌÂ —« «‰Ã«„ „ÌùœÂÌœø", vbYesNo, G_question)
        If G_MsgButton = vbYes Then
            Call G_LoadBasicData
        End If
    End If
End Sub

Private Sub mnuSetHard_Click() 'ok
    frmSetHard.Show 0
End Sub

Private Sub mnuSetNet_Click()
    frmSetNet.Show 1
End Sub

Private Sub mnuView1_Click(Index As Integer)
    G_WeeklyShow = Index
    mnuView1(0).Checked = False
    mnuView1(1).Checked = False
    mnuView1(2).Checked = False
    mnuView1(Index).Checked = True
    SaveSetting "Track&Trace", "PostOffice", "WeeklyShow", G_WeeklyShow
End Sub

Private Sub mnuSetSoft_Click()
    frmSetSoft.Show 1
End Sub

Private Sub mnyWebSite_Click()
    Dim ie As New SHDocVw.InternetExplorer
    ie.Visible = True
    ie.Navigate "http://www.irpost.com"
    Set ie = Nothing
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)
    Select Case Button.Key
        Case "k1":
            frmTraffic.Show 1
        Case "k2":
            mnuReceipt_Click
        Case "k3":
            mnuLias_Click
        Case "k4":
            frmDispatch.Show 1
        Case "k5":
            m_Replicate
        Case "k6":
            frmDialogReport.Show 1
        Case "k7":
            frmSetSoft.Show 1
        Case "k8":
            frmContract_Local.Show 1
        Case "k9":
            MnuHelpBajeh_Click
    End Select
End Sub

Private Sub Toolbar1_ButtonMenuClick(ByVal ButtonMenu As MSComctlLib.ButtonMenu)
    Select Case ButtonMenu.Key
        Case "k21":
            G_IsEMS = 1
            frmReceiptList.Show 1
        Case "k22":
            G_IsEMS = 0
            frmReceiptList.Show 1
        Case "k31":
            G_IsEMS = 1
            frmRegister.Show 1
        Case "k32":
            G_IsEMS = 0
            frmRegister.Show 1
        Case "k71":
            frmSetSoft.Show 1
        Case "k72":
            frmSetHard.Show 1
        Case "k73":
            frmSetNet.Show 1
        Case "k81":
            frmContract_Global.Show 1
        Case "k82":
            frmContract_Local.Show 1
    End Select
End Sub


Private Sub mnuUserDefine_Click()
    G_Login = G_UserDefine
    G_SetKeyboard (enmEnglish)
    frmUserInfo.Show 1
End Sub

