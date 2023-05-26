Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Main
    'Fields

    Private CurrentBtn As IconButton
    Private leftBorderBtn As Panel
    Public currentChildForm As Form
    Private Title As String

    'Constructor



    Public Sub New()


        ' Cet appel est requis par le concepteur.
        InitializeComponent()





        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Form

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        IconButtonAcceuil.PerformClick()

    End Sub

    'Methodes

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'button
            CurrentBtn = CType(senderBtn, IconButton)
            CurrentBtn.BackColor = Color.FromArgb(37, 36, 81)
            CurrentBtn.ForeColor = customColor
            CurrentBtn.IconColor = customColor
            CurrentBtn.TextAlign = ContentAlignment.MiddleCenter
            CurrentBtn.ImageAlign = ContentAlignment.MiddleRight
            CurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, CurrentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon
            IconCurrentForm.IconChar = CurrentBtn.IconChar
            IconCurrentForm.IconColor = customColor


        End If

    End Sub

    Private Sub DisableButton()
        If CurrentBtn IsNot Nothing Then
            CurrentBtn.BackColor = Color.FromArgb(85, 82, 115)
            CurrentBtn.ForeColor = Color.Gainsboro
            CurrentBtn.IconColor = Color.Gainsboro
            CurrentBtn.TextAlign = ContentAlignment.MiddleLeft
            CurrentBtn.ImageAlign = ContentAlignment.MiddleLeft
            CurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If

    End Sub

    Public Sub OpenChildForm(childForm As Form, Title As String)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelFormTitle.Text = Title
    End Sub

    'Events
    Private Sub IconButtonAcceuil_Click(sender As Object, e As EventArgs) Handles IconButtonAcceuil.Click
        ActivateButton(sender, RGBColor.color1)
        Title = "Acceuil"
        OpenChildForm(New FormAcceuil, Title)
    End Sub

    Private Sub IconButtonMission_Click(sender As Object, e As EventArgs) Handles IconButtonMission.Click
        ActivateButton(sender, RGBColor.color2)
        Title = "Mission"
        OpenChildForm(New FormMission, Title)
    End Sub

    Private Sub IconButtonPartenaire_Click(sender As Object, e As EventArgs) Handles IconButtonPartenaire.Click
        ActivateButton(sender, RGBColor.color3)
        Title = "Partenaire"
        OpenChildForm(New FormPartenaire, Title)
    End Sub

    Private Sub IconButtonMissionAffecte_Click(sender As Object, e As EventArgs) Handles IconButtonMissionAffecte.Click
        ActivateButton(sender, RGBColor.color4)
        Title = "Mission Affecté"
        OpenChildForm(New FormAffecteMission, Title)
    End Sub

    Private Sub IconButtonEmploye_Click(sender As Object, e As EventArgs) Handles IconButtonEmploye.Click
        ActivateButton(sender, RGBColor.color5)
        Title = "Employé"
        OpenChildForm(New FormEmploye, Title)
    End Sub

    Private Sub IconAboutUs_Click(sender As Object, e As EventArgs) Handles IconAboutUs.Click
        ActivateButton(sender, RGBColor.color6)
        Title = "A Propos"
        OpenChildForm(New FormAboutUs, Title)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        IconButtonAcceuil.PerformClick()
    End Sub

    ' Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub



    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconWindowClose_Click(sender As Object, e As EventArgs) Handles IconWindowClose.Click
        Application.Exit()
    End Sub

    Private Sub IconWindowMaximize_Click(sender As Object, e As EventArgs) Handles IconWindowMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconWindowMinimize_Click(sender As Object, e As EventArgs) Handles IconWindowMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class
