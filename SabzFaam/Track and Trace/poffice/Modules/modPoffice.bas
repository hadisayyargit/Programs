Attribute VB_Name = "modPoffice"
'  —Ê«·Â« Ê  Ê«»⁄ Ê „ €Ì—Â«Ì ”—«”—Ì «Œ ’«’Ì Å—ÊéÂ

Public G_SearchFlag  As Integer
'0
'1    (frmLetter:‘„«—Â „—”Ê·Â)
'2    (frmLetter: «—ÌŒ)
'3    (frmtraffic: «—ÌŒ)

Public Enum G_ReportType
    enmRptTraffic1 = 1              '’›ÕÂ «Ê·
    enmRptTraffic2               '’›ÕÂ œÊ„
    enmRptTraffic3                '’›ÕÂ ”Ê„
    enmRptStatistics               '¬„«—
    enmRptPerformance               '⁄„·ﬂ—œ
    enmRptDispatch               'œÅ‘
    enmRptRegister               'À»  ÅÌ‘ «“
    enmRptEmsStatistics               '¬„«— ÅÌ‘ «“
    enmRptLservice                '¬„«— ﬁ—«—œ«œÂ«
    enmRptGservice               '¬„«— ﬁ—«—œ«œÂ«Ì ”—«”—Ì
    enmRptWeightGroup               '¬„«— Ê“‰Ì
    enmRptRegisterN             'À»  ”›«—‘Ì
    enmRptLserviceTransaction               '¬„«— „—”Ê·«  ﬁ—«—œ«œÌ Œ«’
    enmDigitalRegisteration
    enmRptNotEmsStatistics               '¬„«— ÅÌ‘ «“
End Enum

Public G_Rptno As G_ReportType

' Registery „ €Ì—Â«Ì
Public G_PnCode, G_Startn, G_BajehName, G_BajehCode, G_RegionName, G_WeeklyShow, G_RegistrationSort, G_SoshSort As String
Public G_Tarazoo, G_TarazooScale, G_Printer, G_BPrinter, G_BPrinterPort, G_ScaleBaudRate, G_ScaleParity, G_ScaleDatabits, G_ScaleStopbits, G_ScaleCommPort As String
Public G_RemoteHost, G_RemotePort, G_RemoteRecordCount, G_RemoteTimeOut As String

Public G_PnName, G_CityName, G_CityCode, G_ProvinceName, G_ProvinceCode, G_RegionCode As String
Public G_DBstartn As String


Public Enum G_ServiceTypeElements
    enmIsEMS = 0               'ÅÌ‘ «“ Ì« ”›«—‘Ì
    enmParcelForm = 1           '‘ﬂ· „—”Ê·Â
    enmDestinationType = 2        '‰Ê⁄ „ﬁ’œ
    enmShippingType = 3           '‰ÕÊÂ —Â”Å«—Ì
    enmPayType = 4                '‰ÕÊÂ Å—œ«Œ 
    enmInsurType = 5              '‰Ê⁄ »Ì„Â
    enmTwoReceipt = 10          'œÊﬁ»÷Â
    enmPrice_Receive = 11       ' ÕÊÌ· œ— „ﬁ«»· »Â«
    enmSendPlace = 12              'Õﬁ „ﬁ— ›—” ‰œÂ
    enmUnsizeOrUnstandard = 13     'Œ«—Ã «“ «‰œ«“Â Ì« €Ì— «” «‰œ«—œ
    enmRestant = 14                '—” «‰ 
    enmBankParcel = 15             '„—”Ê·«  »«‰ﬂÌ
    enmFragile = 16                '‘ﬂ” ‰Ì
    enmExpress = 17                '”—Ì⁄ «·”Ì—(«ﬂ”Å—”)
    enmAmanat_Tejari = 18           '«„«‰   Ã«—Ì
    enmAmanat_Anbooh = 19           '«„«‰  «‰»ÊÂ
End Enum

Public Enum GridColumn
    enmParcelCode = 0
    enmSender
    enmReceiver
    enmTwoReceiptCode
    enmService
    enmDestType
    enmDestCode
    enmDestName
    enmParcelForm
    enmSpecification
    enmReceiptDate
    enmReceiptTime
    enmShipping
    enmExpInsur
    enmPayType
    enmWeight
    enmDeleted
    enmFare
    enmInsurFare
    enmPackageFare
    enmEtcFare
    enmDiscount
    enmTotal
    enmUserCode
    enmRegid
End Enum

Public G_IsEMS As Byte   '1: EMS   0: sefareshi
Public G_ParcelFormList(8) As String   '0:‰«„Â(Å«ﬂ )  1:»” Â  2:ﬂÌ”Â „Œ’Ê’  3:«„«‰   4:„ÿ»Ê⁄  5:ﬂ«—  Å” «·  6:¬∆Ê—Êê—«„  7:”ﬂÊê—«„  8:ﬂÊÅ‰ —Å‰”
Public G_PropertyList(7) As String
Public G_NewRegId As Long
Public G_FromHDate, G_ToHDate As String
Public G_ContractNumber(100) As String   ' ‘„«—Â ﬁ—«—œ«œÂ«


' «»⁄ «’·Ì »—‰«„Â
Sub Main()
    
    'MsgBox GetEncodedPostNodeCode("11111")
    
''  Bug Fixing: the lines betwen begin..end moved here from subtail of splash load
    G_MyPath = App.Path
    G_DbPath = G_MyPath + "\Data"
    G_MyDb = G_DbPath + "\TTPOFFICE.mdb"
    
    G_AdoConn.CursorLocation = adUseClient
    ''G_ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + G_MyDb + ";Persist Security Info=false;Database Password=123"
    G_ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + G_MyDb + ";Persist Security Info=false"
    G_AdoConn.ConnectionString = G_ConnStr
    G_AdoConn.Open
    Load frmSplash
    
    G_PrgMod = G_NormalMod
    G_CurrentDate = G_Hejri(Date)
    
    G_CurrentWeekDay = G_FWeekDay(Weekday(Date))
    
    G_WeeklyShow = GetSetting("Track&Trace", "PostOffice", "WeeklyShow")
    If G_WeeklyShow = "" Then G_WeeklyShow = 2
    
    G_RegistrationSort = GetSetting("Track&Trace", "PostOffice", "RegistrationSort")
    If G_RegistrationSort = "" Then G_RegistrationSort = 0
    
    G_SoshSort = GetSetting("Track&Trace", "PostOffice", "SoshSort")
    If G_SoshSort = "" Then G_SoshSort = 0
    
    G_PnCode = GetDecodedPostNodeCode(Trim(GetSetting("Track&Trace", "PostOffice", "pn-code")))
    G_RegionName = Trim(GetSetting("Track&Trace", "PostOffice", "zone-name"))
    G_RegionCode = Str(G_GetRegionCodeofPostnode(Val(G_PnCode)))
    If G_RegionCode = "-1" Then G_RegionCode = ""
    G_PnName = G_GetPostnodeName(Val(G_PnCode))
    G_CityCode = Trim(Str(G_GetCityCodeOfPostnode(Val(G_PnCode))))
    If G_CityCode = "1011" Or G_CityCode = "1012" Or G_CityCode = "1013" Or G_CityCode = "1014" Or G_CityCode = "1015" Or G_CityCode = "1016" Or G_CityCode = "1017" Or G_CityCode = "1018" Or G_CityCode = "1019" Then
        G_CityCode = "1"
    End If
    
    G_CityName = G_GetCityName(Val(G_CityCode))
    G_ProvinceCode = Str(G_GetProvinceCodeOfCity(Val(G_CityCode)))
    G_ProvinceName = G_GetProvinceName(Val(G_ProvinceCode))
    G_BajehName = Trim(GetSetting("Track&Trace", "PostOffice", "baje-name"))
    G_BajehCode = Trim(GetSetting("Track&Trace", "PostOffice", "baje-code"))
    G_Startn = G_GetDecrypted(GetSetting("Track&Trace", "PostOffice", "startno"))
    G_RemoteHost = GetSetting("Track&Trace", "PostOffice", "RemoteHost")
    If G_RemoteHost = "" Then G_RemoteHost = "TNT.IRPOST.IR"
    G_RemotePort = GetSetting("Track&Trace", "PostOffice", "RemotePort")
    G_RemoteTimeOut = GetSetting("Track&Trace", "PostOffice", "RemoteTimeOut")
    G_RemoteRecordCount = GetSetting("Track&Trace", "PostOffice", "RecordCount")
    
    G_Printer = GetSetting("Track&Trace", "PostOffice", "printer")
    G_BPrinter = GetSetting("Track&Trace", "PostOffice", "bprinter")
    G_Tarazoo = GetSetting("Track&Trace", "PostOffice", "tarazo")
    G_TarazooScale = GetSetting("Track&Trace", "PostOffice", "tarazo_Scale")
    If G_TarazooScale = "" Then G_TarazooScale = "1"
    
    G_ScaleBaudRate = GetSetting("Track&Trace", "PostOffice", "ScaleBaudRate")
    If G_ScaleBaudRate = "" Then G_ScaleBaudRate = "9600"
    
    G_ScaleParity = GetSetting("Track&Trace", "PostOffice", "ScaleParity")
    If G_ScaleParity = "" Then G_ScaleParity = "N"
    
    G_ScaleDatabits = GetSetting("Track&Trace", "PostOffice", "ScaleDatabits")
    If G_ScaleDatabits = "" Then G_ScaleDatabits = "8"
    
    G_ScaleStopbits = GetSetting("Track&Trace", "PostOffice", "ScaleStopbits")
    If G_ScaleStopbits = "" Then G_ScaleStopbits = "1"
 
    G_ScaleCommPort = GetSetting("Track&Trace", "PostOffice", "ScaleCommPort")
    If G_ScaleCommPort = "" Then G_ScaleCommPort = "1"
    
    G_BPrinterPort = Trim(GetSetting("Track&Trace", "PostOffice", "Barcode_port"))
    If G_BPrinterPort = "" Then G_BPrinterPort = "com2"
    
    Set adoRst = New ADODB.Recordset
    adoRst.Open "SELECT Max(Mid([Uniquecode],11,8)) AS MaxPurcelCode FROM tblParcels", G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If Not IsNull(adoRst.Fields("MaxPurcelCode")) Then
        G_DBstartn = adoRst.Fields("MaxPurcelCode").Value + 1
    Else
        G_DBstartn = "0"
    End If
    adoRst.Close
    
    Set adoRst = Nothing
    
    If Val(G_Startn) < Val(G_DBstartn) Then
        G_Startn = G_DBstartn
    End If
    
    G_ParcelFormList(0) = "‰«„Â-Å«ﬂ "
    G_ParcelFormList(1) = "»” Â"
    G_ParcelFormList(2) = "ﬂÌ”Â „Œ’Ê’"
    G_ParcelFormList(3) = "«„«‰ "
    G_ParcelFormList(4) = "„ÿ»Ê⁄"
    G_ParcelFormList(5) = "ﬂ«—  Å” «·"
    G_ParcelFormList(6) = "¬∆Ê—Êê—«„"
    G_ParcelFormList(7) = "”ﬂÊê—«„"
    G_PropertyList(0) = "œÊﬁ»÷Â"
    G_PropertyList(1) = " ÕÊÌ· œ— „ﬁ«»· »Â«"
    G_PropertyList(2) = "Õﬁ „ﬁ— ›—” ‰œÂ"
    G_PropertyList(3) = "Œ«—Ã «“ «‰œ«“Â Ì« ·›«› €Ì—«” «‰œ«—œ"
    G_PropertyList(4) = "—” «‰ "
    G_PropertyList(5) = "„—”Ê·«  »«‰ﬂÌ"
    G_PropertyList(6) = "‘ﬂ” ‰Ì"
    G_PropertyList(7) = "«ﬂ”Å—”"

    ChDrive (Left(G_MyPath, 2))
    ChDir (G_MyPath)
    Call G_SetKeyboard(enmEnglish)
    G_IsEMS = 1
End Sub

'Å— ﬂ—œ‰ ﬂ„»Ê
Public Function G_FillCombo2(myCombo As ComboBox, rst1 As ADODB.Recordset) As Boolean
 
    myCombo.Clear
    G_FillCombo2 = False
    If rst1.RecordCount > 0 Then rst1.MoveFirst
    While Not rst1.EOF
        If IsNull(rst1.Fields(1)) Then
            myCombo.AddItem ""
        Else
            myCombo.AddItem rst1.Fields(1)
        End If
        myCombo.ItemData(myCombo.NewIndex) = rst1.Fields(0)
        rst1.MoveNext
    Wend
    'rst1.Close
    G_CboState = 0
    If myCombo.ListCount > 0 Then
        myCombo.ListIndex = 0
    End If
End Function

Public Function binarytodecimal(binary As String) As Long
    Dim N As Long
    Dim s As Integer

    For s = 1 To Len(binary)
      N = N + (Mid(binary, Len(binary) - s + 1, 1) * (2 ^ (s - 1)))
    Next s
    binarytodecimal = N
End Function

Public Function G_InsertToReplicationOutbox(strTableName As String, strOperation As String, strFieldValues As String) As Boolean
    On Error GoTo Err_label
    Dim MAXSEQNO As Long
        
    G_MyQuery = "SELECT MAX(SEQ_NO) as MAXSEQNO FROM REPLICATION_OUTBOX "
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        MAXSEQNO = 1
    Else
        If IsNull(G_MyRst!MAXSEQNO) Then
            MAXSEQNO = 1
        Else
            MAXSEQNO = 1 + Val(G_MyRst!MAXSEQNO)
        End If
    End If
    
    G_MyQuery = "INSERT INTO REPLICATION_OUTBOX (TABLE_NAME,OPERATION,OPERATION_TIME,FIELD_VALUES,SEQ_NO) VALUES ('" + strTableName + "','" + strOperation + " ','" + Format(Now, "yyyy-mm-dd HH:mm:ss") + " ','" + strFieldValues + "'," + Str(MAXSEQNO) + ")"
    G_AdoConn.Execute G_MyQuery
    Sleep (100)
    G_InsertToReplicationOutbox = True
    Exit Function
Err_label:
    G_InsertToReplicationOutbox = False
End Function

Public Function G_GetEncrypted(strStartno As String) As String
    Dim strFormatted As String * 8
    
    strFormatted = Format(strStartno, "00000000")
    G_GetEncrypted = Trim(Str((Val(Mid(strFormatted, 7, 1)) + 6) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 3, 1)) + 3) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 6, 1)) + 8) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 1, 1)) + 5) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 8, 1)) + 1) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 2, 1)) + 7) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 5, 1)) + 2) Mod 10)) + Trim(Str((Val(Mid(strFormatted, 4, 1)) + 4) Mod 10))
End Function

Public Function G_GetDecrypted(strStartno As String) As String
    Dim nTemp As Integer
    Dim strResult As String
    
    strResult = ""
    
    nTemp = (Val(Mid(strStartno, 4, 1)) - 5) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 6, 1)) - 7) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 2, 1)) - 3) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 8, 1)) - 4) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 7, 1)) - 2) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 3, 1)) - 8) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 1, 1)) - 6) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    nTemp = (Val(Mid(strStartno, 5, 1)) - 1) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    
    G_GetDecrypted = strResult
End Function

Public Function G_LoadBasicData()
    Dim tmpConn As New ADODB.Connection
    
    Call G_ShowMsg("»—«Ì «œ«„Â ⁄„·Ì«  »«‰ﬂ ÃœÌœ TTBASICDATA.MDB —« œ— ﬂ‰«— »«‰ﬂ «ÿ·«⁄«  ›⁄·Ì ﬂÅÌ ‰„«ÌÌœ. ¬Ì« ⁄„·Ì«  —« «œ«„Â „ÌùœÂÌœø", vbYesNo, G_question)
    If G_MsgButton = vbYes Then
        If Dir(G_DbPath + "\TTBASICDATA.mdb") = "" Then
            Call G_ShowMsg("»«‰ﬂ «ÿ·«⁄« Ì TTBASICDATA.MDB œ— „”Ì— „Ê—œ ‰Ÿ— ÅÌœ« ‰‘œ!", vbOKOnly, G_critical)
            Exit Function
        Else
            DoEvents
            'G_ClearMDB
            G_AdoConn.Execute "delete from POSTNODE"
            G_AdoConn.Execute "delete from CITY"
            G_AdoConn.Execute "delete from STATE"
            G_AdoConn.Execute "delete from CONTRACTS"
            G_AdoConn.Execute "delete from COUNTRY"
            Sleep (100)
            tmpConn.CursorLocation = adUseClient
            tmpConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + G_DbPath + "\TTBASICDATA.mdb" + ";Persist Security Info=false"
            tmpConn.Open
            tmpConn.Execute "INSERT INTO COUNTRY IN '" + G_MyDb + "' SELECT COUNTRY.* FROM COUNTRY"
            tmpConn.Execute "INSERT INTO CONTRACTS IN '" + G_MyDb + "' SELECT CONTRACTS.* FROM CONTRACTS"
            tmpConn.Execute "INSERT INTO STATE IN '" + G_MyDb + "' SELECT STATE.* FROM STATE"
            tmpConn.Execute "INSERT INTO CITY IN '" + G_MyDb + "' SELECT CITY.* FROM CITY"
            tmpConn.Execute "INSERT INTO POSTNODE IN '" + G_MyDb + "' SELECT POSTNODE.* FROM POSTNODE"
            Sleep (100)
            tmpConn.Close
            G_ShowMsg "⁄„·Ì«  »«—êÌ—Ì »« „Ê›ﬁÌ  «‰Ã«„ ‘œ.", vbOKOnly, G_check
        End If
    End If
End Function

Public Function G_BackupMDB() As Boolean
    On Error GoTo Err_label
    Dim DF As Boolean
    Dim pathfile As String
    
    DF = False
    frmMain.CommonDialog1.CancelError = True
    frmMain.CommonDialog1.DialogTitle = "„”Ì— ›«Ì· Å‘ Ì»«‰"
    frmMain.CommonDialog1.Filter = "Mdb Files (*.mdb)|*.mdb"
    frmMain.CommonDialog1.FilterIndex = 0
    frmMain.CommonDialog1.FileName = "TTPOFFICE" + Mid(G_CurrentDate, 1, 4) + Mid(G_CurrentDate, 6, 2) + Mid(G_CurrentDate, 9, 2)
    On Error GoTo Cancel_Label
    frmMain.CommonDialog1.ShowSave
    
    On Error GoTo Err_label
    'If frmMain.CommonDialog1.flags = 1024 Then Exit Function
    pathfile = frmMain.CommonDialog1.FileName
    If Dir(pathfile) <> "" Then
        G_ShowMsg "›«Ì· «“ ﬁ»· „ÊÃÊœ «” .¬Ì« —ÊÌ ¬‰ ‰Ê‘ Â ‘Êœø", vbYesNo, G_question
        If G_MsgButton = vbYes Then
            DF = True
        End If
    Else
        DF = True
    End If
    
    If DF Then
        DeleteFile pathfile
        If CopyFile(Trim(G_MyPath + "\Data\TTPOFFICE.mdb"), pathfile, -1) = 0 Then
            G_ShowMsg "Œÿ« œ— ⁄„·Ì«  Å‘ Ì»«‰Ì —Œ œ«œÂ «” .", vbOKOnly, G_critical
        Else
            G_ShowMsg "⁄„·Ì«  Å‘ Ì»«‰Ì »« „Ê›ﬁÌ  «‰Ã«„ ‘œ.", vbOKOnly, G_check
            G_BackupMDB = True
        End If
    Else
        G_BackupMDB = False
    End If
    Exit Function
Cancel_Label:
    G_BackupMDB = False
    Exit Function
Err_label:
    G_BackupMDB = False
    Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
End Function

Public Function G_RestoreMDB() As Boolean
    On Error GoTo Err_handler
    Dim i, j As Integer

    Call G_ShowMsg("»—«Ì Õ›Ÿ Â„«Â‰êÌ «ÿ·«⁄«  »« ”«Ì  „—ﬂ“Ì  ÊÃÂ ‘Êœ ﬂÂ ›ﬁÿ »« »«‰ﬂ «ÿ·«⁄«  ﬂ«—Ì «—”«· «ÿ·«⁄«  ‘Êœ.", vbOKOnly, G_exclamation)
    G_FilePath = ""
    frmMain.CommonDialog1.CancelError = True
    frmMain.CommonDialog1.DialogTitle = "„”Ì— ›«Ì· Å‘ Ì»«‰"
    frmMain.CommonDialog1.Filter = "Mdb Files (*.mdb)|*.mdb"
    frmMain.CommonDialog1.FilterIndex = 0
    On Error GoTo Cancel_Label
    frmMain.CommonDialog1.ShowOpen
    On Error GoTo Err_handler
    G_FilePath = frmMain.CommonDialog1.FileName
    
    If Dir(G_FilePath) = "" Then
    Call G_ShowMsg("ÂÌç ›«Ì·Ì «‰ Œ«» ‰‘œÂ «” ", vbOKOnly, G_exclamation)
        G_RestoreMDB = False
        Exit Function
    End If

    If Dir(G_FilePath) <> "" Then
        frmWait.Label2 = "œ— Õ«· »«“Ì«»Ì «ÿ·«⁄« "
        frmWait.Show 0
        DoEvents
        G_AdoConn.Close
        DeleteFile G_MyDb
        If CopyFile(G_FilePath, G_DbPath + "\TTPOFFICE.mdb", -1) = 0 Then
            G_ShowMsg "Œÿ« œ— ⁄„·Ì«  »«“Ì«»Ì —Œ œ«œÂ «” .", vbOKOnly, G_critical
            G_RestoreMDB = False
        Else
            G_AdoConn.ConnectionString = G_ConnStr
            G_AdoConn.Open
            G_RestoreMDB = True
            G_ShowMsg "⁄„·Ì«  »«“Ì«»Ì »« „Ê›ﬁÌ  «‰Ã«„ ‘œ.", vbOKOnly, G_check
        End If
        Unload frmWait
    Else
        G_RestoreMDB = False
        G_ShowMsg "›«Ì· Å‘ Ì»«‰ œ— «Ì‰ „”Ì— „ÊÃÊœ ‰Ì” .", vbOKOnly, G_critical
    End If
    Exit Function
    
Cancel_Label:
    G_RestoreMDB = False
    Exit Function
    
Err_handler:
    Unload frmWait
    frmWait.ProgressBar1.Visible = False
    G_RestoreMDB = False
    G_ShowMsg "Œÿ«œ— »«“Ì«»Ì «ÿ·«⁄«  —Œ œ«œÂ «” . ›«Ì· Å‘ Ì»«‰ —« »Â ÿÊ— œ” Ì œ— „”Ì— „—»ÊÿÂ ﬂÅÌ ‰„«ÌÌœ", vbOKOnly, G_critical
End Function

Public Function G_ClearMDB() As Boolean
    On Error GoTo Err_label
    
    Call G_ShowMsg("ﬁ»· «“ «œ«„Â ⁄„·Ì«  «“ »«‰ﬂ «ÿ·«⁄«  ‰”ŒÂ Å‘ Ì»«‰  ÂÌÂ ﬂ‰Ìœ. («ÿ·«⁄«  –ŒÌ—Â ‘œÂ Å«ﬂ „Ìù‘Ê‰œ.) ¬Ì« «œ«„Â „ÌùœÂÌœø", vbYesNo, G_question)
    If G_MsgButton = vbYes Then
        frmWait.Label2 = "œ— Õ«· Õ–› «ÿ·«⁄« "
        frmWait.Show 0
        DoEvents
        G_AdoConn.Execute "delete from tblParcels"
        G_AdoConn.Execute "delete from tblRegister"
        G_AdoConn.Execute "delete from tblDispatch"
        G_AdoConn.Execute "delete from tblTraffic"
        G_AdoConn.Execute "delete from tblTransReprort"
        G_AdoConn.Execute "delete from REPLICATION_OUTBOX"
        Sleep (100)
        G_AdoConn.Close
        Sleep (100)
        If Dir(G_DbPath + "\ptemp.mdb") <> "" Then
            Kill (G_DbPath + "\ptemp.mdb")
        End If
            
        G_JetEngine.CompactDatabase G_ConnStr, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + G_DbPath + "\ptemp.mdb"
        Sleep (100)
        DeleteFile G_MyDb
        
        Unload frmWait
        If CopyFile(G_DbPath + "\ptemp.mdb", G_MyDb, -1) = 0 Then
            G_ClearMDB = False
            G_ShowMsg "Œÿ« œ— ⁄„·Ì«  —Œ œ«œÂ «” . ·ÿ›« ‰”ŒÂ Å‘ Ì»«‰ —« »«“Ì«»Ì ‰„«ÌÌœ.", vbOKOnly, G_critical
        Else
            DeleteFile G_DbPath + "\ptemp.mdb"
            G_AdoConn.ConnectionString = G_ConnStr
            G_AdoConn.Open
            G_ShowMsg "«ÿ·«⁄«  »«‰ﬂ «ÿ·«⁄« Ì »« „Ê›ﬁÌ  Å«ﬂ ‘œ.", vbOKOnly, G_check
            G_ClearMDB = True
        End If
        'SaveSetting "Track&Trace", "PostOffice", "startno", "1"
        'G_startn = "1"
        Exit Function
    End If
Err_label:
    Unload frmWait
    'Call G_ShowMsg(Err.Description, vbOKOnly, G_critical)
End Function

Public Function G_GetPostnodeName(nCode As Long) As String
    G_MyQuery = "SELECT PNAME FROM POSTNODE WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetPostnodeName = ""
    Else
        G_GetPostnodeName = G_MyRst!PNAME
    End If
    G_MyRst.Close
End Function

Public Function G_GetCityName(nCode As Long) As String
    G_MyQuery = "SELECT PNAME FROM CITY WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetCityName = ""
    Else
        G_GetCityName = G_MyRst!PNAME
    End If
    G_MyRst.Close
End Function

Public Function G_GetProvinceName(nCode As Long) As String
    G_MyQuery = "SELECT PNAME FROM STATE WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetProvinceName = ""
    Else
        G_GetProvinceName = G_MyRst!PNAME
    End If
    G_MyRst.Close
End Function

Public Function G_GetCityCodeOfPostnode(nCode As Long) As Long
    G_MyQuery = "SELECT CITY_CODE FROM POSTNODE WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetCityCodeOfPostnode = -1
    Else
        G_GetCityCodeOfPostnode = G_MyRst!CITY_CODE
    End If
    G_MyRst.Close
End Function

Public Function G_GetProvinceCodeOfCity(nCode As Long) As Long
    G_MyQuery = "SELECT STATE_CODE FROM CITY WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetProvinceCodeOfCity = -1
    Else
        G_GetProvinceCodeOfCity = G_MyRst!STATE_CODE
    End If
    G_MyRst.Close
End Function

Public Function G_GetRegionCodeofPostnode(nCode As Long) As Long
    G_MyQuery = "SELECT REGION_CODE FROM POSTNODE WHERE CODE=" + Str(nCode)
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
    If G_MyRst.EOF Then
        G_GetRegionCodeofPostnode = -1
    Else
        If IsNull(G_MyRst!REGION_CODE) Then
            G_GetRegionCodeofPostnode = -1
        Else
            G_GetRegionCodeofPostnode = G_MyRst!REGION_CODE
        End If
    End If
    G_MyRst.Close
End Function

Public Function GetEncodedPostNodeCode(ByVal strCode As String) As String
    Dim nCounter As Byte
    Dim strCheckDigit As String
    Dim nTemp As Integer
    Dim strInput As String

    strInput = Format(strCode, "00000")
    nTemp = (Val(Mid(strInput, 5, 1)) * 1 + Val(Mid(strInput, 4, 1)) * 3 + Val(Mid(strInput, 3, 1)) * 5 + Val(Mid(strInput, 2, 1)) * 7 + Val(Mid(strInput, 1, 1)) * 9) Mod 100
    
    strCheckDigit = Format(nTemp, "00")
    nTemp = (Val(Mid(strInput, 1, 1)) - 5) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strCheckDigit = strCheckDigit + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 2, 1)) - 3) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strCheckDigit = strCheckDigit + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 3, 1)) + 1) Mod 10
    strCheckDigit = strCheckDigit + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 4, 1)) + 3) Mod 10
    strCheckDigit = strCheckDigit + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 5, 1)) + 5) Mod 10
    strCheckDigit = strCheckDigit + Trim(Str(nTemp))
    GetEncodedPostNodeCode = strCheckDigit
End Function

Public Function GetDecodedPostNodeCode(ByVal strCode As String) As String
    Dim nCounter As Byte
    Dim strResult As String
    Dim nTemp As Integer
    Dim strInput As String

    strInput = Format(strCode, "0000000")
    GetDecodedPostNodeCode = ""
    strResult = ""
    nTemp = (Val(Mid(strInput, 3, 1)) + 5) Mod 10
    strResult = strResult + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 4, 1)) + 3) Mod 10
    strResult = strResult + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 5, 1)) - 1) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 6, 1)) - 3) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    nTemp = (Val(Mid(strInput, 7, 1)) - 5) Mod 10
    If nTemp < 0 Then nTemp = nTemp + 10
    strResult = strResult + Trim(Str(nTemp))
    '
    '  compare checkdigit
    '
    nTemp = (Val(Mid(strResult, 5, 1)) * 1 + Val(Mid(strResult, 4, 1)) * 3 + Val(Mid(strResult, 3, 1)) * 5 + Val(Mid(strResult, 2, 1)) * 7 + Val(Mid(strResult, 1, 1)) * 9) Mod 100
    If Left(strInput, 2) = Format(nTemp, "00") Then
        GetDecodedPostNodeCode = strResult
    End If
End Function

Public Sub m_BuildDigitalRegisteration(strDispatchCode As String)
    Dim strCommandLineInstruction As String
    
    strCommandLineInstruction = "POfficeReplicationClient D " + G_PnCode + " " + Mid(strDispatchCode, 6, 5) + " " + Mid(strDispatchCode, 11, 4)
    Shell (G_MyPath + "\" + strCommandLineInstruction)
End Sub


