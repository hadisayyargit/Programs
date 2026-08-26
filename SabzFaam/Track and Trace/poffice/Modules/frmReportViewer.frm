VERSION 5.00
Object = "{C4847593-972C-11D0-9567-00A0C9273C2A}#2.2#0"; "crviewer.dll"
Begin VB.Form frmReportViewer 
   Caption         =   "ê“«—‘« "
   ClientHeight    =   4410
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9090
   LinkTopic       =   "Form1"
   RightToLeft     =   -1  'True
   ScaleHeight     =   4410
   ScaleWidth      =   9090
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin CRVIEWERLibCtl.CRViewer CRViewer1 
      Height          =   4095
      Left            =   1200
      TabIndex        =   0
      Top             =   240
      Width           =   6015
      DisplayGroupTree=   -1  'True
      DisplayToolbar  =   -1  'True
      EnableGroupTree =   0   'False
      EnableNavigationControls=   -1  'True
      EnableStopButton=   -1  'True
      EnablePrintButton=   -1  'True
      EnableZoomControl=   -1  'True
      EnableCloseButton=   -1  'True
      EnableProgressControl=   -1  'True
      EnableSearchControl=   -1  'True
      EnableRefreshButton=   -1  'True
      EnableDrillDown =   -1  'True
      EnableAnimationControl=   -1  'True
      EnableSelectExpertButton=   0   'False
      EnableToolbar   =   -1  'True
      DisplayBorder   =   -1  'True
      DisplayTabs     =   -1  'True
      DisplayBackgroundEdge=   -1  'True
      SelectionFormula=   ""
      EnablePopupMenu =   -1  'True
      EnableExportButton=   0   'False
      EnableSearchExpertButton=   0   'False
   End
End
Attribute VB_Name = "frmReportViewer"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim L_RptTraffic1 As New rptTraffic1
Dim L_RptTraffic2 As New rptTraffic2
Dim L_RptTraffic3 As New rptTraffic3
Dim L_rptDispatch As New rptDispatch
Dim L_RptPerformance As New rptPerformance
Dim L_RptEmsStatistics As New rptEmsStatistics
Dim L_RptNotEmsStatistics As New rptNotEmsStatistics
Dim L_RptEmsLServices As New rptEmsLServices
Dim L_RptEmsGServices As New rptEmsGServices
Dim L_RptRegister As New rptRegister
Dim L_RptRegisterN As New rptRegisterN
Dim L_RptWeightGroup As New rptWeightGroup
''  LServiceTransaction Report
Dim L_RptLServiceTransaction As New rptLServiceTransaction
''  LServiceTransaction Report

Option Explicit

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    Screen.MousePointer = vbHourglass
    
    If G_Rptno = enmRptRegister Then
        G_MyQuery = "select IsEms from tblRegister where Regid=" + Str(G_NewRegId)
        If G_MyRst2.State = 1 Then G_MyRst2.Close
        G_MyRst2.Open G_MyQuery, G_AdoConn, adOpenForwardOnly, adLockReadOnly
        If G_MyRst2.EOF = False And Not IsNull(G_MyRst2!IsEms) Then
            If G_MyRst2!IsEms = 0 Then G_Rptno = enmRptRegisterN
        End If
        G_MyRst2.Close
        Sleep (1000)
    End If
    
    Select Case G_Rptno
        Case enmRptTraffic1
            L_RptTraffic1.RecordSelectionFormula = ""
            L_RptTraffic1.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_RptTraffic1
            L_RptTraffic1.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptTraffic1.PaperOrientation = crLandscape
            L_RptTraffic1.DiscardSavedData
            L_RptTraffic1.RecordSelectionFormula = "{tblTraffic.tarikh} in '" + G_FromHDate + "' to '" + G_ToHDate + "'"
            L_RptTraffic1.ReadRecords
            L_RptTraffic1.txtMonth.SetText frmDialogReport.cboMonth.Text
            L_RptTraffic1.txtYear.SetText frmDialogReport.txtYear.Text
            L_RptTraffic1.txtPnname.SetText G_PnName
        Case enmRptTraffic2
            L_RptTraffic2.RecordSelectionFormula = ""
            L_RptTraffic2.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_RptTraffic2
            L_RptTraffic2.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptTraffic2.PaperOrientation = crLandscape
            L_RptTraffic2.DiscardSavedData
            L_RptTraffic2.ReadRecords
            L_RptTraffic2.RecordSelectionFormula = "{tblTraffic.tarikh} in '" + G_FromHDate + "' to '" + G_ToHDate + "'"
            L_RptTraffic2.txtMonth.SetText frmDialogReport.cboMonth.Text
            L_RptTraffic2.txtYear.SetText frmDialogReport.txtYear.Text
            L_RptTraffic2.txtPnname.SetText G_PnName
        Case enmRptTraffic3
            L_RptTraffic3.RecordSelectionFormula = ""
            L_RptTraffic3.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_RptTraffic3
            L_RptTraffic3.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptTraffic3.PaperOrientation = crLandscape
            L_RptTraffic3.DiscardSavedData
            L_RptTraffic3.ReadRecords
            L_RptTraffic3.RecordSelectionFormula = "{tblTraffic.tarikh} in '" + G_FromHDate + "' to '" + G_ToHDate + "'"
            L_RptTraffic3.txtMonth.SetText frmDialogReport.cboMonth.Text
            L_RptTraffic3.txtYear.SetText frmDialogReport.txtYear.Text
            L_RptTraffic3.txtPnname.SetText G_PnName
        Case enmRptStatistics
            CRViewer1.ReportSource = L_RptPerformance
            L_RptPerformance.Database.Tables(1).Location = G_MyDb
            L_RptPerformance.SelectPrinter G_Printer, G_Printer, "lpt1"
            CRViewer1.ReportSource = L_RptPerformance
            L_RptPerformance.DiscardSavedData
            L_RptPerformance.ReadRecords
            L_RptPerformance.txtUsercode.Suppress = True
            L_RptPerformance.txtUserName.Suppress = True
            L_RptPerformance.Field1.Suppress = True
            L_RptPerformance.Field2.Suppress = True
            L_RptPerformance.txtTitr.SetText (" ê“«—‘ ¬„«—Ì „—”Ê·«  „ ⁄«—› Ê ÅÌ‘ «“ «“  «—ÌŒ")
            L_RptPerformance.txtTarikh1.SetText frmDialogReport.txtFromDate
            L_RptPerformance.txtTarikh2.SetText frmDialogReport.txtToDate
            L_RptPerformance.txtPnname.SetText G_PnName
        Case enmRptPerformance
            L_RptPerformance.Database.Tables(1).Location = G_MyDb
            L_RptPerformance.SelectPrinter G_Printer, G_Printer, "lpt1"
            CRViewer1.ReportSource = L_RptPerformance
            L_RptPerformance.DiscardSavedData
            L_RptPerformance.ReadRecords
            L_RptPerformance.txtUsercode.Suppress = False
            L_RptPerformance.txtUserName.Suppress = False
            L_RptPerformance.Field1.Suppress = False
            L_RptPerformance.Field2.Suppress = False
            L_RptPerformance.txtTitr.SetText (" ê“«—‘ ⁄„·ﬂ—œ ﬂ«—»—«‰")
            L_RptPerformance.txtTarikh1.SetText frmDialogReport.txtFromDate
            L_RptPerformance.txtTarikh2.SetText frmDialogReport.txtToDate
            L_RptPerformance.txtPnname.SetText G_PnName
        Case enmRptDispatch
            CRViewer1.ReportSource = L_rptDispatch
            L_rptDispatch.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_rptDispatch.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_rptDispatch
            L_rptDispatch.DiscardSavedData
            L_rptDispatch.ReadRecords
            L_rptDispatch.txtPnname.SetText G_PnName
        Case enmRptRegister
            CRViewer1.ReportSource = L_RptRegister
            L_RptRegister.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptRegister.Database.Tables(1).Location = G_MyDb
            L_RptRegister.Database.Tables(1).SetLogOnInfo G_ConnStr
            CRViewer1.ReportSource = L_RptRegister
            L_RptRegister.DiscardSavedData
            L_RptRegister.RecordSelectionFormula = "{ado.RegId} =" + Str(G_NewRegId)
            
            'L_RptRegister.RecordSortFields.Add(""
            If (G_RegistrationSort = 1) Then
                L_RptRegister.FormulaFields(3).Text = "{ado.ReceiptDate}+{ado.ReceiptTime}"
            Else
                L_RptRegister.FormulaFields(3).Text = "Mid ({ado.Uniquecode},11 ,8 )"
            End If
            L_RptRegister.ReadRecords
            L_RptRegister.txtPnname.SetText G_PnName
            Sleep (1000)
        Case enmRptEmsStatistics
            CRViewer1.ReportSource = L_RptEmsStatistics
            L_RptEmsStatistics.Database.Tables(1).Location = G_MyDb
            L_RptEmsStatistics.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptEmsStatistics.PaperOrientation = crLandscape
            L_RptEmsStatistics.PaperSize = crPaperA4
            
            L_RptEmsStatistics.DiscardSavedData
            L_RptEmsStatistics.ReadRecords
            L_RptEmsStatistics.txtTitr.SetText (" ê“«—‘ ¬„«— „—”Ê·«  ÅÌ‘ «“")
            L_RptEmsStatistics.txtTarikh1.SetText frmDialogReport.txtFromDate
            L_RptEmsStatistics.txtTarikh2.SetText frmDialogReport.txtToDate
            L_RptEmsStatistics.txtPnname.SetText G_PnName
        Case enmRptNotEmsStatistics
            CRViewer1.ReportSource = L_RptNotEmsStatistics
            L_RptNotEmsStatistics.Database.Tables(1).Location = G_MyDb
            L_RptNotEmsStatistics.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptNotEmsStatistics.PaperOrientation = crLandscape
            L_RptNotEmsStatistics.PaperSize = crPaperA4
            
            L_RptNotEmsStatistics.DiscardSavedData
            L_RptNotEmsStatistics.ReadRecords
            L_RptNotEmsStatistics.txtTitr.SetText (" ê“«—‘ ¬„«— „—”Ê·«  „ ⁄«—›")
            L_RptNotEmsStatistics.txtTarikh1.SetText frmDialogReport.txtFromDate
            L_RptNotEmsStatistics.txtTarikh2.SetText frmDialogReport.txtToDate
            L_RptNotEmsStatistics.txtPnname.SetText G_PnName
        Case enmRptLservice
            CRViewer1.ReportSource = L_RptEmsLServices
            L_RptEmsLServices.Database.Tables(1).Location = G_MyDb
            L_RptEmsLServices.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptEmsLServices.PaperOrientation = crLandscape
            L_RptEmsLServices.DiscardSavedData
            L_RptEmsLServices.ReadRecords
            L_RptEmsLServices.txtTitr.SetText ("ê“«—‘ ¬„«— Ê „€«Ì—  ﬁ—«—œ«œÂ«Ì „Õ·Ì ÅÌ‘ «“ «“  «—ÌŒ") + frmDialogReport.txtFromDate + "  «  «—ÌŒ " + frmDialogReport.txtToDate
            L_RptEmsLServices.txtPnname.SetText G_PnName
        Case enmRptGservice
            CRViewer1.ReportSource = L_RptEmsGServices
            L_RptEmsGServices.Database.Tables(1).Location = G_MyDb
            L_RptEmsGServices.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptEmsGServices.PaperOrientation = crLandscape
            L_RptEmsGServices.DiscardSavedData
            L_RptEmsGServices.ReadRecords
            L_RptEmsGServices.txtTitr.SetText (" ê“«—‘ ¬„«— ﬁ—«—œ«œÂ«Ì ”—«”—Ì ÅÌ‘ «“ «“  «—ÌŒ") + frmDialogReport.txtFromDate + "  «  «—ÌŒ " + frmDialogReport.txtToDate
            L_RptEmsGServices.txtPnname.SetText G_PnName
        Case enmRptWeightGroup
                'ÃœÊ· ¬„«—  „—”Ê·«  Œ«—ÃÂ ÅÌ‘ «“ »Â  ›ﬂÌﬂ —œÂ Ê“‰Ì
            CRViewer1.ReportSource = L_RptWeightGroup
            L_RptWeightGroup.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptWeightGroup.PaperOrientation = crLandscape
            L_RptWeightGroup.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_RptWeightGroup
            L_RptWeightGroup.DiscardSavedData
            L_RptWeightGroup.ReadRecords
            L_RptWeightGroup.txtTitr.SetText ("ÃœÊ· ¬„«— „—”Ê·«  Œ«—ÃÂ ÅÌ‘ «“ »Â  ›ﬂÌﬂ —œÂ Ê“‰Ì «“  «—ÌŒ " + frmDialogReport.txtFromDate + "  «  «—ÌŒ " + frmDialogReport.txtToDate)
            L_RptWeightGroup.txtPnname.SetText "‰«„ œ› — Å” Ì: " + G_PnName
        Case enmRptRegisterN
            CRViewer1.ReportSource = L_RptRegisterN
            L_RptRegisterN.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptRegisterN.Database.Tables(1).Location = G_MyDb
            CRViewer1.ReportSource = L_RptRegisterN
            L_RptRegisterN.DiscardSavedData
            L_RptRegisterN.RecordSelectionFormula = "{qryRegister.RegId} =" + Str(G_NewRegId)
            L_RptRegisterN.ReadRecords
            L_RptRegisterN.txtPnname.SetText G_PnName
            G_Rptno = enmRptRegister
        ''  LServiceTransaction Report
        Case enmRptLserviceTransaction
            CRViewer1.ReportSource = L_RptLServiceTransaction
            L_RptLServiceTransaction.SelectPrinter G_Printer, G_Printer, "lpt1"
            L_RptLServiceTransaction.PaperOrientation = crLandscape
            L_RptLServiceTransaction.Database.Tables(1).Location = G_MyDb
            L_RptLServiceTransaction.Database.Tables(1).SetLogOnInfo G_ConnStr
            
           Dim strCriteria As String
           strCriteria = ""
            If frmDialogReport.cboLservice.ListIndex <> -1 Then
                strCriteria = "{ado.Cno} ='" + CStr(G_ContractNumber(frmDialogReport.cboLservice.ListIndex)) + "'"
                If frmDialogReport.txtFromDate.Visible And frmDialogReport.txtFromDate.Text <> "" Then
                    strCriteria = strCriteria + " AND {ado.ReceiptDate} >= '" + frmDialogReport.txtFromDate + "'"
                End If
                If frmDialogReport.txtToDate.Visible And frmDialogReport.txtToDate.Text <> "" Then
                    strCriteria = strCriteria + " AND {ado.ReceiptDate} <='" + frmDialogReport.txtToDate + "'"
                End If
            Else
                strCriteria = ""
                If frmDialogReport.txtFromDate.Visible And frmDialogReport.txtFromDate.Text <> "" Then
                    strCriteria = "{ado.ReceiptDate} >= '" + frmDialogReport.txtFromDate + "'"
                End If
                If frmDialogReport.txtToDate.Visible And frmDialogReport.txtToDate.Text <> "" Then
                    If strCriteria <> "" Then
                        strCriteria = strCriteria + " AND "
                    End If
                    strCriteria = "{ado.ReceiptDate} <='" + frmDialogReport.txtToDate + "'"
                End If
            End If
            L_RptLServiceTransaction.RecordSelectionFormula = strCriteria
            
            CRViewer1.ReportSource = L_RptLServiceTransaction
            L_RptLServiceTransaction.DiscardSavedData
            L_RptLServiceTransaction.ReadRecords
            L_RptLServiceTransaction.txtPnname.SetText G_PnName
            L_RptLServiceTransaction.txtTitr.SetText G_ContractNumber(frmDialogReport.cboLservice.ListIndex)
    End Select
    Sleep (2000)
    CRViewer1.ViewReport
    Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Resize()
    CRViewer1.Top = 0
    CRViewer1.Left = 0
    CRViewer1.Height = ScaleHeight
    CRViewer1.Width = ScaleWidth
End Sub
