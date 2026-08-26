VERSION 5.00
Begin VB.Form frmSetNet 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "«— »«ÿ«  ‘»ﬂÂ"
   ClientHeight    =   2070
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   4395
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   RightToLeft     =   -1  'True
   ScaleHeight     =   2070
   ScaleWidth      =   4395
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtRecordCount 
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
      TabIndex        =   3
      Top             =   1140
      Width           =   1605
   End
   Begin VB.TextBox txtTimeout 
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
      TabIndex        =   2
      Top             =   780
      Width           =   1605
   End
   Begin VB.CommandButton Command1 
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
      Left            =   915
      TabIndex        =   5
      Top             =   1590
      Width           =   1215
   End
   Begin VB.TextBox txtPort 
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
      MaxLength       =   5
      TabIndex        =   1
      Tag             =   "121"
      Top             =   420
      Width           =   1605
   End
   Begin VB.TextBox txtServ 
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
      TabIndex        =   0
      Top             =   60
      Width           =   1605
   End
   Begin VB.CommandButton CmdClose 
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
      Left            =   2280
      TabIndex        =   4
      Top             =   1590
      Width           =   1215
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "“„«‰ «‰ Ÿ«— œ—Ì«›  «ÿ·«⁄«  (œﬁÌﬁÂ):"
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
      Left            =   1800
      RightToLeft     =   -1  'True
      TabIndex        =   9
      Top             =   840
      Width           =   2430
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   " ⁄œ«œ —ﬂÊ—œÂ« œ— Â— «—”«· Â„“„«‰:"
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
      Left            =   1800
      RightToLeft     =   -1  'True
      TabIndex        =   8
      Top             =   1200
      Width           =   2430
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   ":(TCP port) ‘„«—Â ÅÊ— "
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
      Left            =   1800
      TabIndex        =   7
      Top             =   480
      Width           =   1665
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   ":”—Ê— IP ‰«„ Ì« "
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
      Left            =   1800
      TabIndex        =   6
      Top             =   120
      Width           =   1050
   End
End
Attribute VB_Name = "frmSetNet"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Command1_Click()
    Unload Me
End Sub

Private Sub cmdClose_Click()
    SaveSetting "Track&Trace", "PostOffice", "RemoteHost", txtServ.Text
    SaveSetting "Track&Trace", "PostOffice", "RemotePort", txtPort.Text
    SaveSetting "Track&Trace", "PostOffice", "RemoteTimeOut", txtTimeout.Text
    SaveSetting "Track&Trace", "PostOffice", "RecordCount", txtRecordCount.Text
    G_RemoteHost = txtServ
    G_RemotePort = txtPort
    G_RemoteTimeOut = txtTimeout
    G_RemoteRecordCount = txtRecordCount
    
    Call G_ShowMsg(" ‰ŸÌ„«  «‰Ã«„ ‘œ", vbOKOnly, G_check)
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
    Call G_SetKeyPress(Me, KeyAscii)
End Sub

Private Sub Form_Load()
    txtServ = G_RemoteHost
    txtPort = G_RemotePort
    txtTimeout = G_RemoteTimeOut
    txtRecordCount = G_RemoteRecordCount
End Sub
