VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmReceiptList 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "›Â—”  „—”Ê·« "
   ClientHeight    =   8310
   ClientLeft      =   150
   ClientTop       =   435
   ClientWidth     =   11985
   Icon            =   "frmReceiptList.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   8310
   ScaleWidth      =   11985
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  'CenterOwner
   WindowState     =   2  'Maximized
   Begin VB.Frame fraList 
      Caption         =   "›Â—”  „—”Ê·« "
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
      Height          =   7695
      Left            =   45
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Top             =   600
      Width           =   11895
      Begin MSFlexGridLib.MSFlexGrid grdList 
         Height          =   7215
         Left            =   120
         TabIndex        =   2
         Top             =   360
         Width           =   11655
         _ExtentX        =   20558
         _ExtentY        =   12726
         _Version        =   393216
         Cols            =   25
         FixedCols       =   0
         RightToLeft     =   -1  'True
         SelectionMode   =   1
         AllowUserResizing=   1
         FormatString    =   $"frmReceiptList.frx":030A
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
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   3480
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   29
      ImageHeight     =   27
      MaskColor       =   65535
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   4
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmReceiptList.frx":04CD
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmReceiptList.frx":0E69
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmReceiptList.frx":1805
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmReceiptList.frx":21A1
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Height          =   495
      Left            =   6240
      TabIndex        =   0
      Top             =   0
      Width           =   5655
      _ExtentX        =   9975
      _ExtentY        =   873
      ButtonWidth     =   2275
      ButtonHeight    =   873
      Style           =   1
      TextAlignment   =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   6
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "   »«“ê‘ "
            Key             =   "k1"
            Object.ToolTipText     =   "»«“ê‘  »Â Å‰Ã—Â «’·Ì"
            ImageIndex      =   2
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "Ã” ÃÊ"
            Key             =   "k4"
            Object.ToolTipText     =   "Ã” ÃÊÌ «ÿ·«⁄«  ﬁ»Ê÷"
            ImageIndex      =   1
            Style           =   5
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   2
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "yek"
                  Object.Tag             =   "1"
                  Text            =   "Ã” ÃÊ »—«”«” ‘„«—Â ﬁ»÷"
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
                  Key             =   "doo"
                  Object.Tag             =   "2"
                  Text            =   "Ã” ÃÊ »—«”«”  «—ÌŒ"
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "«»ÿ«·"
            Key             =   "k6"
            Object.ToolTipText     =   "«»ÿ«· ﬁ»÷"
            ImageIndex      =   4
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Caption         =   "ÃœÌœ"
            Key             =   "k7"
            Object.ToolTipText     =   "’œÊ—ﬁ»÷ ÃœÌœ"
            ImageIndex      =   3
         EndProperty
      EndProperty
   End
   Begin VB.Menu bajh 
      Caption         =   "»«ÃÂ"
      Begin VB.Menu BajhNew 
         Caption         =   "ÃœÌœ"
      End
      Begin VB.Menu bajhdel 
         Caption         =   "«»ÿ«·"
      End
      Begin VB.Menu bajhSep 
         Caption         =   "-"
      End
      Begin VB.Menu bajhquit 
         Caption         =   "»«“ê‘ "
      End
   End
   Begin VB.Menu bajhtools 
      Caption         =   "«»“«—"
      Begin VB.Menu bajhserach 
         Caption         =   "Ã” ÃÊ"
         Begin VB.Menu gabzfind 
            Caption         =   "Ã” ÃÊ »—«”«” ‘„«—Â ﬁ»÷"
         End
         Begin VB.Menu datefind 
            Caption         =   "Ã” ÃÊ »—«”«”  «—ÌŒ"
         End
      End
   End
End
Attribute VB_Name = "frmReceiptList"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim L_strProperty As String

Private Sub bajhdel_Click()
    L_DeleteParcel
End Sub

Private Sub BajhNew_Click()
    Screen.MousePointer = vbHourglass
    frmReceipt.Show 1
End Sub

Private Sub bajhquit_Click()
    Unload Me
End Sub

Private Sub datefind_Click()
    If grdList.Rows > 1 Then
        G_SearchFlag = 2
        frmSearch.Show 1
    End If
End Sub

Private Sub Form_Activate()
    If G_SearchFlag = 1 Or G_SearchFlag = 2 Then SendKeys "{Right}"
End Sub

Private Sub Form_Load()
    G_SearchFlag = 0
    Screen.MousePointer = vbDefault
    If G_CurrentUserCode = 1 Or G_CurrentUserCode = 2 Then
        Toolbar1.Buttons(5).Enabled = True
        bajhdel.Enabled = True
    Else
        Toolbar1.Buttons(5).Enabled = False
        bajhdel.Enabled = False
    End If
    If G_IsEMS = 1 Then
        fraList.Caption = "›Â—”  „—”Ê·«  ÅÌ‘ «“"
    Else
        fraList.Caption = "›Â—”  „—”Ê·«  ”›«—‘Ì"
    End If
    L_SetGrid
End Sub

Private Sub Form_Resize()
    fraList.Width = Width - 300
    fraList.Left = 70
    Toolbar1.Left = Width - Toolbar1.Width - 200
    grdList.Width = fraList.Width - 200
    fraList.Height = Height - Toolbar1.Height - 1000
    grdList.Height = fraList.Height - 400
End Sub

Private Sub gabzfind_Click()
    If grdList.Rows > 1 Then
        G_SearchFlag = 1
        frmSearch.Show 1
    End If
End Sub

Private Sub Toolbar1_ButtonClick(ByVal Button As MSComctlLib.Button)

    Select Case Button.Key
        Case "k1"
             Unload Me
        Case "k4":
             If grdList.Rows > 1 Then
                G_SearchFlag = 1
                frmSearch.Show 1
             End If
        Case "k6"
             L_DeleteParcel
        Case "k7"
             Screen.MousePointer = vbHourglass
             frmReceipt.Show 1
    End Select
End Sub

Private Sub Toolbar1_ButtonMenuClick(ByVal ButtonMenu As MSComctlLib.ButtonMenu)
    If grdList.Rows > 1 Then
        Select Case ButtonMenu.Key
            Case "yek"
                 G_SearchFlag = 1
                 frmSearch.Show 1
            Case "doo"
                 G_SearchFlag = 2
                 frmSearch.Show 1
        End Select
    End If
End Sub

Private Sub L_DeleteParcel()
    Dim l_title(21) As String
    Dim i, j As Integer
    Dim strCode As String
    
    If grdList.Rows > 1 Then
        grdList.Col = GridColumn.enmParcelCode
        
        strCode = grdList.Text
        G_ShowMsg "¬Ì« „—”Ê·Â ‘„«—Â " + strCode + " —« «»ÿ«· „Ìù‰„«ÌÌœø", vbYesNo, G_question
        If G_MsgButton = vbYes Then
            If grdList.TextMatrix(grdList.Row, GridColumn.enmRegid) <> "-1" Then
                G_ShowMsg "«Ì‰ „—”Ê·Â Ê«—œ À»  ‘œÂ Ê ﬁ«»· «»ÿ«· ‰Ì” ", vbOKOnly, G_exclamation
                Exit Sub
            End If
            grdList.Col = enmParcelCode
            G_AdoConn.Execute "update tblParcels set deleted=true where uniquecode='" & Trim(strCode) & "'"
            
            If grdList.Rows = 2 Then
                grdList.Clear
                grdList.FormatString = "‘„«—Â „—”Ê·Â                          |›—” ‰œÂ                                  |êÌ—‰œÂ                                  |ﬂœ ﬁ»÷ œÊ„                        |”—ÊÌ” |‰Ê⁄ „ﬁ’œ |ﬂœ „ﬁ’œ |‰«„ „ﬁ’œ                          |‘ﬂ· „—”Ê·Â  |„‘Œ’«                                              | «—ÌŒ À»  |“„«‰ À»  |‰ÕÊÂ —Â”Å«—Ì |„»·€ «ŸÂ«—‘œÂ|‰Ê⁄ Å—œ«Œ    |Ê“‰    |«»ÿ«·|ﬂ—«ÌÂ Å” Ì|„»·€ »Ì„Â|·›«›  |”«Ì—  | Œ›Ì› Ì«  „»— „‘ —Ì|„»·€ ﬂ·      |ﬂœ ﬂ«—»—|‘„«—Â À» "
            Else
                grdList.RemoveItem (grdList.Row)
            End If
        End If
    End If
End Sub


Private Sub L_SetGrid()
    ' ‰ŸÌ„ ê—Ìœ
    Dim j, i As Integer
    Dim strTodayDate As String
    Dim str7DaysBefore As String
    Dim m As Integer
    
    grdList.Clear
    grdList.Rows = 2
    grdList.FormatString = "‘„«—Â „—”Ê·Â                          |›—” ‰œÂ                                  |êÌ—‰œÂ                                  |ﬂœ ﬁ»÷ œÊ„                        |”—ÊÌ” |‰Ê⁄ „ﬁ’œ |ﬂœ „ﬁ’œ |‰«„ „ﬁ’œ                          |‘ﬂ· „—”Ê·Â  |„‘Œ’«                                              | «—ÌŒ À»  |“„«‰ À»  |‰ÕÊÂ —Â”Å«—Ì |„»·€ «ŸÂ«—‘œÂ|‰Ê⁄ Å—œ«Œ    |Ê“‰    |«»ÿ«·|ﬂ—«ÌÂ Å” Ì|„»·€ »Ì„Â|·›«›  |”«Ì—  | Œ›Ì› Ì«  „»— „‘ —Ì|„»·€ ﬂ·      |ﬂœ ﬂ«—»—|‘„«—Â À» "
    strTodayDate = G_Hejri(Now)
    str7DaysBefore = G_Hejri(Now - 7)
    Select Case G_WeeklyShow
        Case 0
            G_MyQuery = "select tblParcels.*,CITY.PNAME from CITY INNER JOIN tblParcels ON CITY.CODE = tblParcels.DestCode where mid(servicetype,1,1)='" + Trim(str(G_IsEMS)) + "' and deleted=false and (receiptdate ='" + strTodayDate + "') order by mid(uniquecode,11,8) "
        Case 1
            G_MyQuery = "select tblParcels.*,CITY.PNAME from CITY INNER JOIN tblParcels ON CITY.CODE = tblParcels.DestCode where mid(servicetype,1,1)='" + Trim(str(G_IsEMS)) + "' and deleted=false and (receiptdate >'" & str7DaysBefore & "' and receiptdate<='" & strTodayDate & "') order by mid(uniquecode,11,8) "
        Case 2
            G_MyQuery = "select tblParcels.*,CITY.PNAME from CITY INNER JOIN tblParcels ON CITY.CODE = tblParcels.DestCode where mid(servicetype,1,1)='" + Trim(str(G_IsEMS)) + "' and deleted=false order by mid(uniquecode,11,8) "
    End Select
    If G_MyRst2.State = 1 Then G_MyRst2.Close
    G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    m = 0
    While Not G_MyRst2.EOF
        m = m + 1
        grdList.AddItem ""
        Call L_FillGrid(m, G_MyRst2!uniquecode, G_MyRst2!ServiceType, G_MyRst2!destcode, G_MyRst2!ReceiptDate, G_MyRst2!receipttime, G_MyRst2!ExpInsur, G_MyRst2!Weight, G_MyRst2!SenderName, G_MyRst2!ReceiverName, G_MyRst2!Fare, G_MyRst2!Insurcost, G_MyRst2!Packagecost, G_MyRst2!EtcCost, G_MyRst2!Discount, G_MyRst2!TotalCost, G_MyRst2!UserCode, G_MyRst2!RECEIPT_CODE, G_MyRst2!RegId, G_MyRst2!PNAME)
        G_MyRst2.MoveNext
    Wend
    If (grdList.Rows > 2 And grdList.TextMatrix(grdList.Rows - 1, enmParcelCode) = "") Then
        grdList.RemoveItem grdList.Rows - 1
    End If
End Sub

Function L_FillGrid(k As Integer, ByVal uniquecode1 As String, servicetype1 As String, ByVal destcode1 As String, _
    date1 As String, time1 As String, ByVal expinsur1 As Long, ByVal weight1 As Long _
    , ByVal sender1 As String, receiver1 As String, ByVal fare1 As Long, ByVal insur1 As Long, ByVal package1 As Long _
    , ByVal etcCost1 As Long, ByVal discount1 As Long, total1 As Long, usercode1 As Long, ByVal ReceiptCode1 As Variant, Regid1 As Integer, ByVal destname1 As String) As Boolean
    'Å— ﬂ—œ‰ Ìﬂ ”ÿ— ê—Ìœ
    Dim i As Integer
    
    With grdList
        'If Not IsNull(uniquecode1) Then .TextMatrix(k, GridColumn.enmParcelCode) = uniquecode1
        If Mid(servicetype1, 1 + G_ServiceTypeElements.enmIsEMS, 1) = "1" Then
            .TextMatrix(k, GridColumn.enmService) = "ÅÌ‘ «“"
            .TextMatrix(k, GridColumn.enmParcelCode) = uniquecode1
        Else
            .TextMatrix(k, GridColumn.enmService) = "”›«—‘Ì"
            .TextMatrix(k, GridColumn.enmParcelCode) = uniquecode1
        End If

        Select Case Mid(servicetype1, 1 + G_ServiceTypeElements.enmDestinationType, 1)
           Case "0":
                .TextMatrix(k, GridColumn.enmDestType) = "‘Â—Ì"
           Case "1":
                .TextMatrix(k, GridColumn.enmDestType) = "»Ì‰ ‘Â—Ì"
           Case "2":
                .TextMatrix(k, GridColumn.enmDestType) = "Œ«—ÃÂ"
        End Select
        If Not IsNull(destcode1) Then .TextMatrix(k, GridColumn.enmDestCode) = destcode1
        .TextMatrix(k, GridColumn.enmDestName) = destname1
        
        .TextMatrix(k, GridColumn.enmParcelForm) = G_ParcelFormList(Val(Mid(servicetype1, 1 + G_ServiceTypeElements.enmParcelForm, 1)))
        
        L_strProperty = ""
        For i = 1 To 8
            If Mid(servicetype1, i + 10, 1) = "1" Then
                L_strProperty = L_strProperty + "° " + G_PropertyList(i - 1)
            End If
        Next
        
        If L_strProperty <> "" And Mid(L_strProperty, 1, 1) = "°" Then Mid(L_strProperty, 1, 1) = ""
        
       .TextMatrix(k, GridColumn.enmSpecification) = L_strProperty
        If Not IsNull(date1) Then .TextMatrix(k, GridColumn.enmReceiptDate) = date1
        If Not IsNull(time1) Then .TextMatrix(k, GridColumn.enmReceiptTime) = time1
        If Mid(servicetype1, 1 + G_ServiceTypeElements.enmShippingType, 1) = "1" Then .TextMatrix(k, GridColumn.enmShipping) = "ÂÊ«ÌÌ" Else: .TextMatrix(k, GridColumn.enmShipping) = "“„Ì‰Ì"
        If Not IsNull(expinsur1) Then
            .TextMatrix(k, GridColumn.enmExpInsur) = expinsur1
        End If
        
        Select Case Mid(servicetype1, 1 + G_ServiceTypeElements.enmPayType, 1)
                Case "0"
                    .TextMatrix(k, GridColumn.enmPayType) = "‰ﬁœÌ"
                Case "1"
                    .TextMatrix(k, GridColumn.enmPayType) = "ﬁ—«—œ«œ œ«Œ·Ì"
                Case "2"
                    .TextMatrix(k, GridColumn.enmPayType) = "ﬂ—«ÌÂ œ— „ﬁ’œ"
                Case "3"
                    .TextMatrix(k, GridColumn.enmPayType) = "ﬁ—«—œ«œ ”—«”—Ì"
        End Select
        .TextMatrix(k, GridColumn.enmWeight) = weight1
        .TextMatrix(k, GridColumn.enmSender) = sender1
        .TextMatrix(k, GridColumn.enmReceiver) = receiver1
        .TextMatrix(k, GridColumn.enmFare) = fare1
        If Not IsNull(insur1) Then .TextMatrix(k, GridColumn.enmInsurFare) = insur1
        If Not IsNull(package1) Then .TextMatrix(k, GridColumn.enmPackageFare) = package1
        If Not IsNull(etcCost1) Then .TextMatrix(k, GridColumn.enmEtcFare) = etcCost1
        If Not IsNull(discount1) Then .TextMatrix(k, GridColumn.enmDiscount) = discount1
        .TextMatrix(k, GridColumn.enmTotal) = total1
        .TextMatrix(k, GridColumn.enmUserCode) = usercode1
        If Not IsNull(ReceiptCode1) Then .TextMatrix(k, GridColumn.enmTwoReceiptCode) = ReceiptCode1
        .TextMatrix(k, GridColumn.enmRegid) = Regid1
     End With
     L_FillGrid = False
End Function
