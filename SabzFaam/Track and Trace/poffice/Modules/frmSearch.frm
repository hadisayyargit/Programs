VERSION 5.00
Begin VB.Form frmSearch 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Ã” ÃÊ"
   ClientHeight    =   1320
   ClientLeft      =   5955
   ClientTop       =   5970
   ClientWidth     =   3750
   Icon            =   "frmSearch.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   1320
   ScaleWidth      =   3750
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      Caption         =   "«‰’—«›"
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
      Left            =   593
      Style           =   1  'Graphical
      TabIndex        =   4
      ToolTipText     =   "«‰’—«›"
      Top             =   900
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   " «ÌÌœ"
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
      Left            =   1920
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   " «ÌÌœ"
      Top             =   900
      Width           =   1215
   End
   Begin VB.Frame fraDate 
      Caption         =   "»—«”«”  «—ÌŒ"
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
      Height          =   855
      Left            =   8
      RightToLeft     =   -1  'True
      TabIndex        =   2
      Top             =   0
      Visible         =   0   'False
      Width           =   3735
      Begin VB.TextBox txtTarikh 
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
         MaxLength       =   10
         RightToLeft     =   -1  'True
         TabIndex        =   1
         Tag             =   "31"
         Top             =   315
         Width           =   1455
      End
      Begin VB.Label Label3 
         Alignment       =   1  'Right Justify
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
         Left            =   375
         RightToLeft     =   -1  'True
         TabIndex        =   8
         Top             =   360
         Width           =   960
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   ": «—ÌŒ"
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
         Left            =   3000
         TabIndex        =   7
         Top             =   360
         Width           =   375
      End
   End
   Begin VB.Frame fraReceiptno 
      Caption         =   "»—«”«” ‘„«—Â „—”Ê·Â"
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
      Height          =   855
      Left            =   8
      RightToLeft     =   -1  'True
      TabIndex        =   5
      Top             =   0
      Visible         =   0   'False
      Width           =   3735
      Begin VB.TextBox txtSerial 
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
         Left            =   248
         MaxLength       =   20
         RightToLeft     =   -1  'True
         TabIndex        =   0
         Top             =   360
         Width           =   2055
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   ":‘„«—Â „—”Ê·Â"
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
         Left            =   2408
         TabIndex        =   6
         Top             =   405
         Width           =   1095
      End
   End
End
Attribute VB_Name = "frmSearch"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click()
    Dim i As Integer
    Dim findFlag As Boolean
    
    If G_SearchFlag = 3 Then
        If G_PrimaryRs.RecordCount = 0 Then
            Call G_ShowMsg("ÃœÊ· «ÿ·«⁄«  Œ«·Ì «” ", vbOKOnly, G_exclamation)
            Exit Sub
        End If
        If G_BoxesValidate(Me) Then
            G_BookMark = G_PrimaryRs.Bookmark
            G_PrimaryRs.MoveFirst
            G_PrimaryRs.Find "TARIKH= '" & txtTarikh.Text & "'"
            If G_PrimaryRs.EOF Then
                G_ShowMsg "—ﬂÊ—œ „Ê—œ ‰Ÿ— À»  ‰‘œÂ «” .", vbOKOnly, G_exclamation
                txtTarikh.SetFocus
                G_PrimaryRs.Bookmark = G_BookMark
                G_SearchFlag = 3
            Else
                Unload Me
            End If
        End If
    ElseIf G_SearchFlag = 1 Then
        findFlag = False
        If G_BoxesValidate(Me) Then
            For i = 1 To frmReceiptList.grdList.Rows - 1
                'If Trim(frmReceiptList.grdList.TextMatrix(i, 0)) = Trim(txtSerial.Text) Then
                If Trim(frmReceiptList.grdList.TextMatrix(i, enmParcelCode)) = Trim(txtSerial.Text) Then
                    frmReceiptList.grdList.Row = i
                    frmReceiptList.grdList.RowSel = i
                    findFlag = True
                    Exit For
                End If
            Next i
            If findFlag = False Then
                G_ShowMsg "—ﬂÊ—œ „Ê—œ ‰Ÿ— œ— «Ì‰ ·Ì”  „ÊÃÊœ ‰„Ìù»«‘œ", vbOKOnly, G_exclamation
                txtSerial.SetFocus
            Else
                Unload Me
            End If
        End If
    ElseIf G_SearchFlag = 2 Then
        findFlag = False
        If G_BoxesValidate(Me) Then
            'frmReceiptList.grdList.Col = 8
            frmReceiptList.grdList.Col = enmReceiptDate
            
            For i = 1 To frmReceiptList.grdList.Rows - 1
                 frmReceiptList.grdList.Row = i
                 If Trim(frmReceiptList.grdList.Text) = txtTarikh.Text Then
                    frmReceiptList.grdList.RowSel = i
                    findFlag = True
                    Exit For
                 End If
            Next i
            If findFlag = False Then
              G_ShowMsg "—ﬂÊ—œ „Ê—œ ‰Ÿ— œ— «Ì‰ ·Ì”  „ÊÃÊœ ‰„Ìù»«‘œ", vbOKOnly, G_exclamation
              txtTarikh.SetFocus
            Else
               Unload Me
            End If
        End If
    End If
End Sub

Private Sub Command2_Click()
    G_SearchFlag = 0  '« „«„ Ã” ÃÊ
    Unload Me
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    If G_SearchFlag = 1 Then
        fraReceiptno.Enabled = True
        fraReceiptno.Visible = True
        fraReceiptno.ZOrder
    Else
        txtTarikh.Text = G_CurrentDate
        fraDate.Enabled = True
        fraDate.Visible = True
        fraDate.ZOrder
    End If
    txtTarikh.Tag = 31
End Sub

