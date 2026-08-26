VERSION 5.00
Begin VB.Form frmMsgDlg 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "”Ì” „ œ› — Å” Ì"
   ClientHeight    =   1440
   ClientLeft      =   2760
   ClientTop       =   3705
   ClientWidth     =   4860
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   1440
   ScaleWidth      =   4860
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Visible         =   0   'False
   Begin VB.Frame fraCommand 
      BorderStyle     =   0  'None
      Height          =   375
      Left            =   360
      RightToLeft     =   -1  'True
      TabIndex        =   1
      Top             =   960
      Width           =   4095
      Begin VB.CommandButton cmdNo 
         Caption         =   "ŒÌ—"
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
         TabIndex        =   3
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
      Begin VB.CommandButton cmdYes 
         Caption         =   "»·Ì"
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
         Left            =   2760
         TabIndex        =   2
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
      Begin VB.CommandButton cmdOk 
         Caption         =   " √ÌÌœ"
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
         TabIndex        =   5
         Top             =   0
         Width           =   1215
      End
      Begin VB.CommandButton cmdCancel 
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
         Left            =   1440
         TabIndex        =   4
         Top             =   0
         Visible         =   0   'False
         Width           =   1215
      End
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   1
      Left            =   4200
      Picture         =   "frmMsg.frx":0000
      Top             =   120
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   4
      Left            =   4200
      Picture         =   "frmMsg.frx":0442
      Top             =   120
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   3
      Left            =   4200
      Picture         =   "frmMsg.frx":0884
      Top             =   120
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   2
      Left            =   4200
      Picture         =   "frmMsg.frx":0CC6
      Top             =   120
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   0
      Left            =   4200
      Picture         =   "frmMsg.frx":1108
      Top             =   120
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Label lblMsg 
      Alignment       =   1  'Right Justify
      AutoSize        =   -1  'True
      Caption         =   "lblMsg"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   178
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   120
      RightToLeft     =   -1  'True
      TabIndex        =   0
      Top             =   360
      Width           =   3900
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "frmMsgDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdCancel_Click()
    G_MsgButton = vbCancel
    Unload Me
End Sub

Private Sub cmdNo_Click()
    G_MsgButton = vbNo
    Unload Me
End Sub

Private Sub cmdOk_Click()
    G_MsgButton = vbOK
    Unload Me
End Sub

Private Sub cmdYes_Click()
    G_MsgButton = vbYes
    Unload Me
End Sub

Private Sub Form_Load()
    lblMsg.Caption = G_Message
    cmdYes.Visible = False
    cmdNo.Visible = False
    cmdCancel.Visible = False
    cmdOk.Visible = False
    
    Select Case G_MessageType
        Case vbOKOnly:
            cmdOk.Visible = True
            cmdOk.Left = (fraCommand.Width \ 2) - (cmdOk.Width \ 2)
        Case vbOKCancel:
            cmdOk.Visible = True
            cmdCancel.Visible = True
            cmdCancel.Left = (fraCommand.Width \ 2) - (cmdCancel.Width) - 30
            cmdOk.Left = (fraCommand.Width \ 2) + 30
        Case vbYesNo:
            cmdYes.Visible = True
            cmdNo.Visible = True
            cmdNo.Left = (fraCommand.Width \ 2) - (cmdNo.Width) - 30
            cmdYes.Left = (fraCommand.Width \ 2) + 30
        Case vbYesNoCancel:
            cmdYes.Visible = True
            cmdNo.Visible = True
            cmdCancel.Visible = True
            cmdNo.Left = (fraCommand.Width \ 2) - (cmdNo.Width \ 2)
            cmdYes.Left = cmdNo.Left + cmdNo.Width + 30
            cmdCancel.Left = cmdNo.Left - cmdNo.Width - 30
    End Select
        
    Image1.Item(G_MessagePicType).Visible = True
    fraCommand.Top = lblMsg.Top + lblMsg.Height + 300
    Me.Height = fraCommand.Top + fraCommand.Height + 550
End Sub
