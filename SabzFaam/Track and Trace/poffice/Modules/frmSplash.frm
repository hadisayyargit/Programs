VERSION 5.00
Begin VB.Form frmSplash 
   BorderStyle     =   0  'None
   ClientHeight    =   4605
   ClientLeft      =   210
   ClientTop       =   1365
   ClientWidth     =   6765
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4605
   ScaleWidth      =   6765
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Interval        =   3500
      Left            =   600
      Top             =   600
   End
   Begin VB.PictureBox Picture1 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   4590
      Left            =   22
      Picture         =   "frmSplash.frx":030A
      RightToLeft     =   -1  'True
      ScaleHeight     =   4590
      ScaleWidth      =   6750
      TabIndex        =   0
      Top             =   0
      Width           =   6750
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "Product Version = 3.6.3"
         Height          =   255
         Index           =   1
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   2
         Top             =   1440
         Width           =   1695
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         BackStyle       =   0  'Transparent
         Caption         =   "August 2008"
         Height          =   255
         Index           =   0
         Left            =   120
         RightToLeft     =   -1  'True
         TabIndex        =   1
         Top             =   1200
         Width           =   975
      End
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Form_Load()
    Show
End Sub

Private Sub Timer1_Timer()
    'frmMain.Visible = True
    Unload frmSplash
    Load frmMain
End Sub
