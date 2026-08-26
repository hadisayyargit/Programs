Attribute VB_Name = "modGlobal"
'   —Ê«·Â« Ê  Ê«»⁄ Ê „ €Ì—Â«Ì ”—«”—Ì

Public Enum G_Languages
    enmEnglish = 409
    enmPersian = 429
End Enum

Public Enum G_prgModConst
    G_NormalMod     'Õ«·  ⁄«œÌ ›—„
    G_AddMod           'Õ«·  «÷«›Â
    G_DeleteMod          'Õ«·  Õ–›
    G_EditMod           'Õ«·  «’·«Õ
    G_MainformMod 'Õ«·  ›—„ «’·Ì »—‰«„Â(»⁄‰Ê«‰ ›·êÌ »—«Ì ⁄œ„ Ê—Êœ »Â „‰ÊÂ«Ì œÌê—)
End Enum

Public Enum G_picType
    G_exclamation = 0
    G_info = 1
    G_critical = 2
    G_question = 3
    G_check = 4
End Enum

Public G_PrgMod As G_prgModConst

Public G_Message As String
Public G_MessageType As VbMsgBoxStyle
Public G_MessagePicType As G_picType
Public G_MsgButton As VbMsgBoxResult
 '»—ê—œ«‰œÂ „Ìù‘Êœ frmMsgDlgœ— «Ì‰ „ €Ì— ﬂ·Ìœ „Ê—œ ‰Ÿ— œ— ›—„
 
Public Enum G_LoginType
    G_UserLogin = 0
    G_UserDefine = 1
    G_UserDelete = 2
    G_UserSetPassword = 3
End Enum
Public G_Login As G_LoginType

Public G_FilePath As String
Public G_MyPath As String    '„”Ì— »—‰«„Â
Public G_DbPath As String    '„”Ì— »«‰ﬂ «ÿ·«⁄« 
Public G_MyDb As String     '„”Ì— »«‰ﬂ+‰«„ »«‰ﬂ
Public G_ConnStr As String
Public G_AdoConn As New ADODB.Connection
Public G_PrimaryRs As New ADODB.Recordset
Public G_MyRst As New ADODB.Recordset
Public G_MyRst2 As New ADODB.Recordset
Public G_JetEngine As New JetEngine
Public G_MyQuery As String
Public G_BookMark As Variant
Public G_CurrentUserCode As Long
Public G_UserEname As String
Public G_UserPname As String
Public G_CurrentDate As String
Public G_CurrentWeekDay As String

Public Declare Function CopyFile Lib "kernel32" Alias "CopyFileA" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Long) As Long
Public Declare Function DeleteFile Lib "kernel32" Alias "DeleteFileA" (ByVal lpFileName As String) As Long
Public Declare Function GetKeyboardLayoutList Lib "user32" (ByVal nBuff As Long, lpList As Long) As Long
Public Declare Function GetKeyboardLayout Lib "user32" (ByVal dwLayout As Long) As Long
Public Declare Function ActivateKeyboardLayout Lib "user32" (ByVal HKL As Long, ByVal flags As Long) As Long
Public Declare Function LoadKeyboardLayout Lib "user32" Alias "LoadKeyboardLayoutA" (ByVal pwszKLID As String, ByVal flags As Long) As Long
Public Declare Function GetKeyboardLayoutName Lib "user32" Alias "GetKeyboardLayoutNameA" (ByVal pwszKLID As String) As Long
Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

'›⁄«· Ì« €Ì— ›⁄«· ‰„Êœ‰ ﬂ·ÌœÂ«
Sub G_SetButtons(MyForm As Form, Myvalue As Boolean)
    For i = 0 To MyForm.count - 1
        If TypeName(MyForm.Controls(i)) = "CommandButton" Then
            If MyForm.Controls(i).Tag = 7 Then
                MyForm.Controls(i).Enabled = Myvalue
            ElseIf MyForm.Controls(i).Tag = 71 Then
                MyForm.Controls(i).Enabled = Not Myvalue
            End If
        End If
    Next
End Sub

'ﬁ›· Ì« ¬“«œ ‰„Êœ‰ »«ﬂ”Â«
Sub G_SetBoxesLock(MyForm As Form, Myvalue As Boolean)
    For i = 0 To MyForm.count - 1
        If (TypeName(MyForm.Controls(i)) = "TextBox" And MyForm.Controls(i).Tag <> "") Or (TypeName(MyForm.Controls(i)) = "ComboBox" And MyForm.Controls(i).Tag = 8) Then
            MyForm.Controls(i).Locked = Myvalue
        End If
    Next
End Sub

'(Â«frame)›⁄«· Ì« €Ì— ›⁄«· ‰„Êœ‰ ﬁ«»Â«
Sub G_SetFrame(MyForm As Form, Myvalue As Boolean)
     For i = 1 To MyForm.count - 1
        If TypeName(MyForm.Controls(i)) = "Frame" And MyForm.Controls(i).Tag = 6 Then
            MyForm.Controls(i).Enabled = Myvalue
        End If
    Next
End Sub

'Œ«·Ì ‰„Êœ‰ »«ﬂ”Â«
Sub G_BoxesEmpty(MyForm As Form)
    For i = 0 To MyForm.count - 1
        If TypeName(MyForm.Controls(i)) = "TextBox" And MyForm.Controls(i).Tag <> "" Then
            'Myform.Controls(i).Locked = Myvalue
            MyForm.Controls(i).Text = ""
        End If
    Next
End Sub

'   ﬂ‰ —· ﬂ·Ìœ ›‘—œÂ ‘œÂ Ê «⁄„«· «Ã»«— œ— ê—› ‰ ‰Ê⁄ Ê—ÊœÌ
'   KeyPreview=True »—«Ì œ—”  ﬂ«— ﬂ—œ‰ «Ì‰  «»⁄ »«Ìœ Œ«’Ì 
Public Sub G_SetKeyPress(MyForm As Form, Key As Integer)
    On Error GoTo Err_label
    
    If Key = vbKeyReturn Then
        SendKeys "{Tab}"
        Exit Sub
    End If
    
    If Chr(Key) = "ﬂ" Then
        Key = Asc("ò")
    End If
    
    
'    If Chr(Key) = "Ì" Then
'        Key = Asc("")
'    End If
  
    
    If TypeName(MyForm.ActiveControl) = "TextBox" Then
        If (MyForm.ActiveControl.Tag = "") Then
            Exit Sub
        End If
        
        If MyForm.ActiveControl.Tag = 1 Or MyForm.ActiveControl.Tag = 11 Then '«⁄œ«œ
            If (Not IsNumeric(Chr(Key)) And Not (Key = 8) And Not (Key = 46) And Not (Key = 45)) _
                Or (Len(MyForm.ActiveControl.Text) = 0 And Key = 46) _
                Or (Len(MyForm.ActiveControl.Text) > 0 And Chr(Key) = "-") _
                Or (Len(MyForm.ActiveControl.Text) = 1 And Mid(MyForm.ActiveControl.Text, 1, 1) = "-" And Chr(Key) = ".") _
                Or (InStr(1, MyForm.ActiveControl.Text, ".", 1) And Key = 46) Then
                    Key = 0
            End If
        End If
        
        
        If (MyForm.ActiveControl.Tag = 3 Or MyForm.ActiveControl.Tag = 31) Then  ' «—ÌŒ ÂÃ—Ì
            If (Len(MyForm.ActiveControl.Text) <> 4 And Len(MyForm.ActiveControl.Text) <> 7 And (Not IsNumeric(Chr(Key)) And Not Key = 8)) _
                Or (Not (Key = 8) And Len(MyForm.ActiveControl.Text) = 4 And Not (Key = 47)) _
                Or (Not (Key = 8) And Len(MyForm.ActiveControl.Text) = 7 And Not Key = 47) _
                Or (Not (Key = 8) And Len(MyForm.ActiveControl.Text) >= 10) Then
                    Key = 0
            End If
        End If
    End If
    Exit Sub
    
Err_label:
    Exit Sub
End Sub
            
            '  ‰ŸÌ„ “»«‰ ’›ÕÂ ﬂ·Ìœ
Public Sub G_SetKeyboard(lang As G_Languages)
    Call ActivateKeyboardLayout(LoadKeyboardLayout("00000" & lang, 0), 0)
End Sub


'‰„«Ì‘ ÅÌ«„Â« Ê Â‘œ«—Â«
'—« »«“ „Ìùﬂ‰œfrmMsgDlg›—„
Sub G_ShowMsg(msgText As String, msgType As VbMsgBoxStyle, Optional picType As G_picType)
    G_Message = msgText
    G_MessageType = msgType
    G_MessagePicType = picType
    'frmMsgDlg.Show 1
    If frmMsgDlg.Visible = False Then frmMsgDlg.Show 1
End Sub

' Â«Ì «ÿ·«⁄« Ìbox ”  «⁄ »«—
Function G_BoxesValidate(frmForm As Form) As Boolean
    On Error GoTo Err_label
    Dim i As Integer
    Dim Error1 As Boolean
    Dim tabindex1, control1 As Integer
    Dim mm, dd As Integer
    tabindex1 = -1
    
    
    For i = 0 To frmForm.count - 1
        If (Val(frmForm.Controls(i).Tag) > 0) Then
            If frmForm.Controls(i).Enabled = True Then
                 Select Case Val(frmForm.Controls(i).Tag)
                    Case 1, 11:
                        If (Len(frmForm.Controls(i)) > 0 And Not IsNumeric(frmForm.Controls(i))) Or (frmForm.Controls(i).Tag = 11 And Len(frmForm.Controls(i)) < 1) Then
                            Error1 = True
                        End If
                    Case 21:
                        If Len(frmForm.Controls(i)) < 1 Then
                        Error1 = True
                    End If
                    Case 3, 31:
                        'If frmForm.Controls(i).Tag = 31 And Len(frmForm.Controls(i)) < 10 Then Error1 = True
                        If Len(frmForm.Controls(i).Text) > 0 And Len(frmForm.Controls(i)) < 10 Then Error1 = True
                        mm = Val(Mid(frmForm.Controls(i), 6, 2))
                        dd = Val(Mid(frmForm.Controls(i), 9, 2))
                        If (mm < 0) Or (mm > 12) Or (dd > 31) Or (dd < 0) Or (mm > 6 And dd = 31) Or (mm = 12 And dd = 31) Then Error1 = True
                End Select
                If Error1 = True Then
                     If tabindex1 = -1 Then
                        tabindex1 = frmForm.Controls(i).TabIndex
                        control1 = i
                     Else
                        If frmForm.Controls(i).TabIndex < tabindex1 Then
                             tabindex1 = frmForm.Controls(i).TabIndex
                             control1 = i
                        End If
                     End If
                  Error1 = False
                End If
            End If
        End If
    Next i
    If tabindex1 > -1 Then
         G_ShowMsg "·ÿ›« „ﬁœ«— „⁄ »— Ê«—œ ‰„«ÌÌœ.", vbOKOnly, G_critical
         G_BoxesValidate = False
         If frmForm.Controls(control1).Enabled = True Then frmForm.Controls(control1).SetFocus
    Else
         G_BoxesValidate = True
    End If
  
    Exit Function
    
Err_label:
   G_ShowMsg Err.Description, vbOKOnly, G_critical
   
End Function

Function G_FMonthName(m1 As Integer) As String
   Dim ret1 As String
    Select Case m1
       Case 1
          ret1 = "›—Ê—œÌ‰ „«Â"
       Case 2
          ret1 = "«—œÌ»Â‘  „«Â"
       Case 3
          ret1 = "Œ—œ«œ„«Â"
       Case 4
          ret1 = " Ì—„«Â"
       Case 5
          ret1 = "„—œ«œ„«Â"
       Case 6
          ret1 = "‘Â—ÌÊ—„«Â"
       Case 7
          ret1 = "„Â—„«Â"
       Case 8
          ret1 = "¬»«‰ „«Â"
       Case 9
          ret1 = "¬–—„«Â"
       Case 10
          ret1 = "œÌ „«Â"
       Case 11
          ret1 = "»Â„‰ „«Â"
       Case 12
          ret1 = "«”›‰œ„«Â"
     End Select
     G_FMonthName = ret1
End Function

Function G_FWeekDay(d1 As Integer) As String
    Dim ret2 As String
    
    Select Case d1
        Case 1
           ret2 = "Ìﬂ‘‰»Â"
        Case 2
          ret2 = "œÊ‘‰»Â"
        Case 3
          ret2 = "”Â ‘‰»Â"
        Case 4
          ret2 = "çÂ«—‘‰»Â"
        Case 5
          ret2 = "Å‰Ã‘‰»Â"
        Case 6
          ret2 = "Ã„⁄Â"
        Case 7
          ret2 = "‘‰»Â"
    End Select
    G_FWeekDay = ret2
End Function

''„Õ«”»Â  «—ÌŒ ÂÃ—Ì —Ê“ Ã«—Ì ”Ì” „
' »œÌ· „Ì·«œÌ »Â ‘„”Ì
Function G_Hejri(MTODAY As Date) As String
    Dim Y, D, m As Integer
    Dim y1, d1, m1 As Integer
  
    Y = Year(MTODAY)
    m = Month(MTODAY)
    D = Day(MTODAY)
    If (Y Mod 4) = 0 Then
         'If (m < 4 And D < 20) Then
         If (m < 3) Or (m = 3 And D < 20) Then
             y1 = Y - 622
         Else
             y1 = Y - 621
         End If
         Select Case m
            Case 1
                If (D < 21) Then
                    m1 = 10
                    d1 = D + 10
                Else
                    m1 = 11
                    d1 = D - 20
                End If
            Case 2
                If (D < 20) Then
                    m1 = 11
                    d1 = D + 11
                Else
                    m1 = 12
                    d1 = D - 19
                End If
            Case 3
                 If (D < 20) Then
                     m1 = 12
                     d1 = D + 10
                 Else
                     m1 = 1
                     d1 = D - 19
                 End If
            Case 4
                 If (D < 20) Then
                    m1 = 1
                    d1 = D + 12
                 Else
                    m1 = 2
                    d1 = D - 19
                 End If
            Case 5, 6
                 If (D < 21) Then
                    m1 = m - 3
                    d1 = D + 11
                 Else
                    m1 = m - 2
                    d1 = D - 20
                 End If
            Case 7, 8, 9
                 If (D < 22) Then
                     m1 = m - 3
                     d1 = D + 10
                 Else
                     m1 = m - 2
                     d1 = D - 21
                 End If
            Case 10
                 If (D < 22) Then
                     m1 = 7
                     d1 = D + 9
                 Else
                     m1 = 8
                     d1 = D - 21
                 End If
            Case 11, 12
                If (D < 21) Then
                    m1 = m - 3
                    d1 = D + 10
                 Else
                    m1 = m - 2
                    d1 = D - 20
                 End If
        End Select
    Else
         'If (m < 4 And D < 21) Then
         If (m < 3) Or (m = 3 And D < 21) Then
            y1 = Y - 622
         Else
            y1 = Y - 621
         End If
            
    If (Y Mod 4 = 1) Then
      Select Case m
            Case 1
                  If (D < 20) Then
                      m1 = 10
                      d1 = D + 11
                  Else
                      m1 = 11
                      d1 = D - 19
                  End If
             Case 2
                  If (D <= 18) Then
                      m1 = 11
                      d1 = D + 12
                  Else
                      m1 = 12
                      d1 = D - 18
                  End If
             Case 3
                  If (D < 21) Then
                      m1 = 12
                      d1 = D + 10
                  Else
                      m1 = 1
                      d1 = D - 20
                  End If
        End Select
     Else
         Select Case m
                Case 1
                     If (D < 21) Then
                         m1 = 10
                         d1 = D + 10
                      Else
                         m1 = 11
                         d1 = D - 20
                     End If
                Case 2
                     If (D < 20) Then
                         m1 = 11
                         d1 = D + 11
                      Else
                         m1 = 12
                         d1 = D - 19
                     End If
                Case 3
                     If (D < 21) Then
                         m1 = 12
                         d1 = D + 9
                     Else
                         m1 = 1
                            d1 = D - 20
                        End If
            End Select
        End If
         
        Select Case m
            Case 4
                 'If (D < 20) Then     'change at 80/2/1
                 If (D <= 20) Then
                     m1 = 1
                     d1 = D + 11
                 Else
                     m1 = 2
                     d1 = D - 20
                 End If
            Case 5, 6
                 If (D < 22) Then
                     m1 = m - 3
                     d1 = D + 10
                 Else
                     m1 = m - 2
                     d1 = D - 21
                 End If
            Case 7, 8, 9
                 If (D < 23) Then
                     m1 = m - 3
                     d1 = D + 9
                 Else
                     m1 = m - 2
                     d1 = D - 22
                 End If
            Case 10
                 If (D < 23) Then
                     m1 = 7
                     d1 = D + 8
                 Else
                     m1 = 8
                     d1 = D - 22
                 End If
            Case 11, 12
                 If (D < 22) Then
                     m1 = m - 3
                     d1 = D + 9
                 Else
                     m1 = m - 2
                     d1 = D - 21
                 End If
        End Select
    End If
    G_Hejri = Format(Str(y1)) + "/" + Format(Str(m1), "00") + "/" + Format(Str(d1), "00")
End Function

' »œÌ· ‘„”Ì »Â „Ì·«œÌ
'‰ÊÌ”‰œÂ: ⁄·«ÌÌ
Public Function G_Miladi(Fa_Date As String) As String
    Dim The_Year, The_Month, The_Day As Integer
    Dim The_Select As Integer
    
    If IsNull(Fa_Date) Or Fa_Date = "" Then
        G_Miladi = ""
        Exit Function
    End If
    
    The_Year = CInt(Mid(Fa_Date, 1, 4))
    The_Month = CInt(Mid(Fa_Date, 6, 2))
    The_Day = CInt(Mid(Fa_Date, 9, 2))
    

    The_Select = The_Year Mod 4
    
    '------------------------------------------------------------------------------------------------------------------------
    If The_Select = 0 Then                'Like : 1360, 1364, 1368, 1372, 1376, 1380, 1384, ...
    Select Case The_Month
    Case 1: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 3
        The_Year = The_Year + 621
        Case 12 To 31: The_Day = The_Day - 11
        The_Month = 4
        The_Year = The_Year + 621
        End Select
    Case 2: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 20
        The_Month = 4
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 5
        The_Year = The_Year + 621
        End Select
    Case 3: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 5
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 6
        The_Year = The_Year + 621
        End Select
    Case 4: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 21
        The_Month = 6
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 7
        The_Year = The_Year + 621
        End Select
    Case 5: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 7
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 8
        The_Year = The_Year + 621
        End Select
    Case 6: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 8
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 9
        The_Year = The_Year + 621
        End Select
    Case 7: Select Case The_Day
        Case 1 To 8: The_Day = The_Day + 22
        The_Month = 9
        The_Year = The_Year + 621
        Case 9 To 30: The_Day = The_Day - 8
        The_Month = 10
        The_Year = The_Year + 621
        End Select
    Case 8: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 10
        The_Year = The_Year + 621
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 11
        The_Year = The_Year + 621
        End Select
    Case 9: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 21
        The_Month = 11
        The_Year = The_Year + 621
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 12
        The_Year = The_Year + 621
        End Select
    Case 10: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 12
        The_Year = The_Year + 621
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 1
        The_Year = The_Year + 622
        End Select
    Case 11: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 1
        The_Year = The_Year + 622
        Case 12 To 30: The_Day = The_Day - 11
        The_Month = 2
        The_Year = The_Year + 622
        End Select
    Case 12: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 19
        The_Month = 2
        The_Year = The_Year + 622
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 3
        The_Year = The_Year + 622
        End Select
    End Select
    End If
    '------------------------------------------------------------------------------------------------------------------------
    If The_Select = 1 Then                'Like : 1361, 1365, 1369, 1373, 1377, 1381, 1385, ...
    Select Case The_Month
        Case 1: Select Case The_Day
            Case 1 To 11: The_Day = The_Day + 20
            The_Month = 3
            The_Year = The_Year + 621
            Case 12 To 31: The_Day = The_Day - 11
            The_Month = 4
            The_Year = The_Year + 621
            End Select
        Case 2: Select Case The_Day
            Case 1 To 10: The_Day = The_Day + 20
            The_Month = 4
            The_Year = The_Year + 621
            Case 11 To 31: The_Day = The_Day - 10
            The_Month = 5
            The_Year = The_Year + 621
            End Select
        Case 3: Select Case The_Day
            Case 1 To 10: The_Day = The_Day + 21
            The_Month = 5
            The_Year = The_Year + 621
            Case 11 To 31: The_Day = The_Day - 10
            The_Month = 6
            The_Year = The_Year + 621
            End Select
        Case 4: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 21
            The_Month = 6
            The_Year = The_Year + 621
            Case 10 To 31: The_Day = The_Day - 9
            The_Month = 7
            The_Year = The_Year + 621
            End Select
        Case 5: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 22
            The_Month = 7
            The_Year = The_Year + 621
            Case 10 To 31: The_Day = The_Day - 9
            The_Month = 8
            The_Year = The_Year + 621
            End Select
        Case 6: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 22
            The_Month = 8
            The_Year = The_Year + 621
            Case 10 To 31: The_Day = The_Day - 9
            The_Month = 9
            The_Year = The_Year + 621
            End Select
        Case 7: Select Case The_Day
            Case 1 To 8: The_Day = The_Day + 22
            The_Month = 9
            The_Year = The_Year + 621
            Case 9 To 30: The_Day = The_Day - 8
            The_Month = 10
            The_Year = The_Year + 621
            End Select
        Case 8: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 22
            The_Month = 10
            The_Year = The_Year + 621
            Case 10 To 30: The_Day = The_Day - 9
            The_Month = 11
            The_Year = The_Year + 621
            End Select
        Case 9: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 21
            The_Month = 11
            The_Year = The_Year + 621
            Case 10 To 30: The_Day = The_Day - 9
            The_Month = 12
            The_Year = The_Year + 621
            End Select
        Case 10: Select Case The_Day
            Case 1 To 10: The_Day = The_Day + 21
            The_Month = 12
            The_Year = The_Year + 621
            Case 11 To 30: The_Day = The_Day - 10
            The_Month = 1
            The_Year = The_Year + 622
            End Select
        Case 11: Select Case The_Day
            Case 1 To 11: The_Day = The_Day + 20
            The_Month = 1
            The_Year = The_Year + 622
            Case 12 To 30: The_Day = The_Day - 11
            The_Month = 2
            The_Year = The_Year + 622
            End Select
        Case 12: Select Case The_Day
            Case 1 To 9: The_Day = The_Day + 19
            The_Month = 2
            The_Year = The_Year + 622
            Case 10 To 30: The_Day = The_Day - 9
            The_Month = 3
            The_Year = The_Year + 622
            End Select
    End Select
    End If
    '------------------------------------------------------------------------------------------------------------------------
    If The_Select = 2 Then                'Like : 1362, 1366, 1370, 1374, 1378, 1382, 1386, ...
    Select Case The_Month
    Case 1: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 3
        The_Year = The_Year + 621
        Case 12 To 31: The_Day = The_Day - 11
        The_Month = 4
        The_Year = The_Year + 621
        End Select
    Case 2: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 20
        The_Month = 4
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 5
        The_Year = The_Year + 621
        End Select
    Case 3: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 5
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 6
        The_Year = The_Year + 621
        End Select
    Case 4: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 21
        The_Month = 6
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 7
        The_Year = The_Year + 621
        End Select
    Case 5: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 7
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 8
        The_Year = The_Year + 621
        End Select
    Case 6: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 8
        The_Year = The_Year + 621
        Case 10 To 31: The_Day = The_Day - 9
        The_Month = 9
        The_Year = The_Year + 621
        End Select
    Case 7: Select Case The_Day
        Case 1 To 8: The_Day = The_Day + 22
        The_Month = 9
        The_Year = The_Year + 621
        Case 9 To 30: The_Day = The_Day - 8
        The_Month = 10
        The_Year = The_Year + 621
        End Select
    Case 8: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 22
        The_Month = 10
        The_Year = The_Year + 621
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 11
        The_Year = The_Year + 621
        End Select
    Case 9: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 21
        The_Month = 11
        The_Year = The_Year + 621
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 12
        The_Year = The_Year + 621
        End Select
    Case 10: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 12
        The_Year = The_Year + 621
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 1
        The_Year = The_Year + 622
        End Select
    Case 11: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 1
        The_Year = The_Year + 622
        Case 12 To 30: The_Day = The_Day - 11
        The_Month = 2
        The_Year = The_Year + 622
        End Select
    Case 12: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 19
        The_Month = 2
        The_Year = The_Year + 622
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 3
        The_Year = The_Year + 622
        End Select
    End Select
    End If
    '------------------------------------------------------------------------------------------------------------------------
    If The_Select = 3 Then                'Like : 1363, 1367, 1371, 1375, 1379, 1383, 1387, ...
    Select Case The_Month
    Case 1: Select Case The_Day
        Case 1 To 12: The_Day = The_Day + 19
        The_Month = 3
        The_Year = The_Year + 621
        Case 13 To 31: The_Day = The_Day - 12
        The_Month = 4
        The_Year = The_Year + 621
        End Select
    Case 2: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 19
        The_Month = 4
        The_Year = The_Year + 621
        Case 12 To 31: The_Day = The_Day - 11
        The_Month = 5
        The_Year = The_Year + 621
        End Select
    Case 3: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 5
        The_Year = The_Year + 621
        Case 12 To 31: The_Day = The_Day - 11
        The_Month = 6
        The_Year = The_Year + 621
        End Select
    Case 4: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 20
        The_Month = 6
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 7
        The_Year = The_Year + 621
        End Select
    Case 5: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 7
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 8
        The_Year = The_Year + 621
        End Select
    Case 6: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 8
        The_Year = The_Year + 621
        Case 11 To 31: The_Day = The_Day - 10
        The_Month = 9
        The_Year = The_Year + 621
        End Select
    Case 7: Select Case The_Day
        Case 1 To 9: The_Day = The_Day + 21
        The_Month = 9
        The_Year = The_Year + 621
        Case 10 To 30: The_Day = The_Day - 9
        The_Month = 10
        The_Year = The_Year + 621
        End Select
    Case 8: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 21
        The_Month = 10
        The_Year = The_Year + 621
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 11
        The_Year = The_Year + 621
        End Select
    Case 9: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 20
        The_Month = 11
        The_Year = The_Year + 621
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 12
        The_Year = The_Year + 621
        End Select
    Case 10: Select Case The_Day
        Case 1 To 11: The_Day = The_Day + 20
        The_Month = 12
        The_Year = The_Year + 621
        Case 12 To 30: The_Day = The_Day - 11
        The_Month = 1
        The_Year = The_Year + 622
        End Select
    Case 11: Select Case The_Day
        Case 1 To 12: The_Day = The_Day + 19
        The_Month = 1
        The_Year = The_Year + 622
        Case 13 To 30: The_Day = The_Day - 12
        The_Month = 2
        The_Year = The_Year + 622
        End Select
    Case 12: Select Case The_Day
        Case 1 To 10: The_Day = The_Day + 18
        The_Month = 2
        The_Year = The_Year + 622
        Case 11 To 30: The_Day = The_Day - 10
        The_Month = 3
        The_Year = The_Year + 622
        End Select
    End Select
    End If
    '------------------------------------------------------------------------------------------------------------------------
    
    G_Miladi = DateSerial(The_Year, The_Month, The_Day)
End Function

'«÷«›Â ﬂ—œ‰ Ìﬂ —Ê“ »Â  «—ÌŒ
Function G_AddDate(tarikh As String, daynumber As Integer) As String
    Dim mdate As Date
    
    mdate = CDate(G_Miladi(tarikh)) + daynumber
    G_AddDate = G_Hejri(mdate)
End Function

Function G_FormatDate(dDate As Date) As String
    Dim monthArray(1 To 12) As String
    
    monthArray(1) = "Jan"
    monthArray(2) = "Feb"
    monthArray(3) = "Mar"
    monthArray(4) = "Apr"
    monthArray(5) = "May"
    monthArray(6) = "Jun"
    monthArray(7) = "Jul"
    monthArray(8) = "Aug"
    monthArray(9) = "Sep"
    monthArray(10) = "Oct"
    monthArray(11) = "Nov"
    monthArray(12) = "Dec"
    
    G_FormatDate = monthArray(Month(dDate)) + " " + Format(Day(dDate), "00") + " " + Format(Year(dDate), "0000") + " " + Format(dDate, "hh:mmAM/PM")
    'Mar 10 2004 12:17PM
    
End Function
'               (Delimiter) ﬁ—«— œ«œ‰ Ãœ«ﬂ‰‰œÂ «⁄œ«œ
' Form_Load  œ— —ÊÌœ«œ  G_Comma »—«Ì «” ›«œÂ «“  «»⁄ “Ì— »«Ìœ „ €Ì—
' ﬂ‰ —· „Ê—œ ‰Ÿ— ›—«ŒÊ«‰Ì ‘Êœ _Change ‘Êœ Ê «Ì‰  «»⁄ œ— —ÊÌœ«œ True »—«»—
Public Function G_CommaIn(myTextbox As TextBox) As Boolean
    Dim MyStr As String
    
    If G_Comma = True Then
        G_Comma = False
        MyStr = Trim(myTextbox.Text)
        MyStr = StrReverse(MyStr)
        MyStr = Replace(MyStr, ",", "")
        s = MyStr
        l = Len(MyStr)
        k = (l - 1) \ 3    ' ⁄œ«œ Ãœ«ﬂ‰‰œÂ Â«
        part1 = ""
        For i = 1 To l Step 3
            If part1 = "" Then
                part1 = Mid(MyStr, i, 3)
            Else
                part1 = part1 + "," + Mid(MyStr, i, 3)
            End If
        Next
        s = StrReverse(part1)
        myTextbox.Text = s
    End If
    myTextbox.SelStart = Len(myTextbox.Text)
    G_Comma = True
End Function
'               (Delimiter)  »—œ«‘ ‰ Ãœ«ﬂ‰‰œÂ «⁄œ«œ
Public Function G_CommaOut(myTextbox As TextBox) As Boolean
    If G_Comma = True Then
        G_Comma = False
        myTextbox.Text = Replace(myTextbox.Text, ",", "")
        G_Comma = True
    End If
End Function

Function G_OneToTwentyName(N As Integer) As String
' use for G_NumToText
Select Case N
   Case 0
        G_OneToTwentyName = ""
   Case 1
        G_OneToTwentyName = "Ìﬂ"
   Case 2
        G_OneToTwentyName = "œÊ"
   Case 3
        G_OneToTwentyName = "”Â "
   Case 4
        G_OneToTwentyName = "çÂ«—"
   Case 5
        G_OneToTwentyName = "Å‰Ã"
   Case 6
        G_OneToTwentyName = "‘‘"
   Case 7
        G_OneToTwentyName = "Â› "
   Case 8
        G_OneToTwentyName = "Â‘ "
   Case 9
        G_OneToTwentyName = "‰Â "
   Case 10
        G_OneToTwentyName = "œÂ"
   Case 11
        G_OneToTwentyName = "Ì«“œÂ"
   Case 12
        G_OneToTwentyName = "œÊ«“œÂ"
   Case 13
        G_OneToTwentyName = "”Ì“œÂ"
   Case 14
        G_OneToTwentyName = "çÂ«—œÂ "
   Case 15
        G_OneToTwentyName = "Å«‰“œÂ"
   Case 16
        G_OneToTwentyName = "‘«‰“œÂ"
   Case 17
        G_OneToTwentyName = "Â›œÂ "
   Case 18
        G_OneToTwentyName = "ÂÌÃœÂ"
   Case 19
        G_OneToTwentyName = "‰Ê“œÂ"
End Select
End Function
Function G_DecadeToHundred(N As Integer) As String
' use for G_NumToText
Select Case N
    Case 0
         G_DecadeToHundred = ""
    Case 1
         G_DecadeToHundred = "œÂ"
    Case 2
         G_DecadeToHundred = "»Ì” "
    Case 3
         G_DecadeToHundred = "”Ì"
    Case 4
         G_DecadeToHundred = "çÂ·"
    Case 5
         G_DecadeToHundred = "Å‰Ã«Â"
    Case 6
         G_DecadeToHundred = "‘’ "
    Case 7
         G_DecadeToHundred = "Â› «œ"
    Case 8
         G_DecadeToHundred = "Â‘ «œ"
    Case 9
         G_DecadeToHundred = "‰Êœ"
  End Select
End Function
Function G_HundredToTousend(N As Integer) As String
' use for G_NumToText
Select Case N
    Case 0
         G_HundredToTousend = ""
    Case 1
         G_HundredToTousend = "Ìﬂ’œ"
    Case 2
         G_HundredToTousend = "œÊÌ” "
    Case 3
         G_HundredToTousend = "”Ì’œ"
    Case 4
         G_HundredToTousend = "çÂ«—’œ"
    Case 5
         G_HundredToTousend = "Å«‰’œ"
    Case 6
         G_HundredToTousend = "‘‘’œ"
    Case 7
         G_HundredToTousend = "Â› ’œ"
    Case 8
         G_HundredToTousend = "Â‘ ’œ"
    Case 9
         G_HundredToTousend = "‰Â’œ"
End Select
End Function
Function G_Units(N As Integer) As String
' use for G_NumToText
Select Case N
     Case 1
          G_Units = ""
     Case 2
          G_Units = "Â“«—"
     Case 3
          G_Units = "„Ì·ÌÊ‰"
     Case 4
          G_Units = "„Ì·Ì«—œ"
'     Case 5
'          G_Units = "»Ì·ÌÊ‰"
'     Case 6
'          G_Units = " —Ì·ÌÊ‰"
     Case 5
          G_Units = " —Ì·ÌÊ‰"
     
     Case Else
          G_Units = ""
End Select
End Function

Function G_GetFarsiSentence(N As Integer, Base As Integer) As String
' use for G_NumToText
Dim s As String
Dim NoOfTen As Integer
Dim NoOfHundred As Integer
s = ""
NoOfHundred = Int(N / 100)
N = N - NoOfHundred * 100
If (N > 0) And (NoOfHundred > 0) Then
   s = s + " " + G_HundredToTousend(NoOfHundred) + " Ê "
Else
   s = s + G_HundredToTousend(NoOfHundred)
End If
If N >= 20 Then
   NoOfTen = Int(N / 10)
   N = N - NoOfTen * 10
   If (N > 0) And (NoOfTen > 0) Then
      s = s + " " + G_DecadeToHundred(NoOfTen)
   Else
      s = s + " " + G_DecadeToHundred(NoOfTen)
   End If
   If N > 0 Then
      s = s + " Ê " + G_OneToTwentyName(N)
   End If
Else
   s = s + " " + G_OneToTwentyName(N)
End If
G_GetFarsiSentence = s + " " + G_Units(Base) + " Ê "
End Function

' »œÌ· «⁄œ«œ »Â „⁄«œ· «”„Ì ¬‰Â«
'  Maximum digit support is 15
Public Function G_NumToText(r As Double) As String
    Dim Qutient, Remain, TempR  As Double
    Dim temp As Integer
    Dim Base  As Integer
    Dim s   As String
    If r > 999999999999999# Then
      G_NumToText = ""
      Exit Function
    ElseIf r = 0 Then
      G_NumToText = "’›—"
      Exit Function
    End If
    Base = 1
    s = ""
    TempR = r
    Do While r > 0
       Remain = Int(r / 1000)
       temp = CLng(r - Remain * 1000)
       If temp > 0 Then
          s = G_GetFarsiSentence(temp, Base) + s
       End If
       r = Remain
       Base = Base + 1
    Loop
    s = Mid(s, 1, Len(s) - 3)
    G_NumToText = s
End Function

'Å— ﬂ—œ‰ ﬂ„»Ê
Public Function G_FillCombo(myCombo As ComboBox, tbLname As String, Codefieldname As String, Onvanfieldname As String) As Boolean
 
    G_MyQuery = "select " + Codefieldname + "," + Onvanfieldname + " from " + tbLname + " Order by " + Codefieldname
    
    If G_MyRst.State = 1 Then G_MyRst.Close
    G_MyRst.Open G_MyQuery, G_AdoConn, adOpenKeyset, adLockReadOnly
    If G_MyRst.RecordCount > 0 Then
        G_MyRst.MoveLast
        G_MyRst.MoveFirst
    End If
    myCombo.Clear
    G_FillCombo = False
    While Not G_MyRst.EOF
        If IsNull(G_MyRst.Fields(1)) Then
            myCombo.AddItem ""
        Else
            myCombo.AddItem G_MyRst.Fields(1)
        End If
        myCombo.ItemData(myCombo.NewIndex) = Val(G_MyRst.Fields(0))
        G_MyRst.MoveNext
    Wend
    G_MyRst.Close
    G_CboState = 0
    If myCombo.ListCount > 0 Then
        myCombo.ListIndex = 0
    End If
End Function

