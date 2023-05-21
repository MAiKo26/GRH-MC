<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconAboutUs = New FontAwesome.Sharp.IconButton()
        Me.IconButtonEmploye = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMissionAffecte = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPartenaire = New FontAwesome.Sharp.IconButton()
        Me.IconButtonMission = New FontAwesome.Sharp.IconButton()
        Me.IconButtonAcceuil = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.IconWindowMinimize = New FontAwesome.Sharp.IconButton()
        Me.IconWindowMaximize = New FontAwesome.Sharp.IconButton()
        Me.IconWindowClose = New FontAwesome.Sharp.IconButton()
        Me.LabelFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconAboutUs)
        Me.PanelMenu.Controls.Add(Me.IconButtonEmploye)
        Me.PanelMenu.Controls.Add(Me.IconButtonMissionAffecte)
        Me.PanelMenu.Controls.Add(Me.IconButtonPartenaire)
        Me.PanelMenu.Controls.Add(Me.IconButtonMission)
        Me.PanelMenu.Controls.Add(Me.IconButtonAcceuil)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 611)
        Me.PanelMenu.TabIndex = 0
        '
        'IconAboutUs
        '
        Me.IconAboutUs.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconAboutUs.FlatAppearance.BorderSize = 0
        Me.IconAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconAboutUs.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconAboutUs.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.IconAboutUs.IconColor = System.Drawing.Color.Gainsboro
        Me.IconAboutUs.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconAboutUs.Location = New System.Drawing.Point(0, 420)
        Me.IconAboutUs.Name = "IconAboutUs"
        Me.IconAboutUs.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconAboutUs.Size = New System.Drawing.Size(200, 60)
        Me.IconAboutUs.TabIndex = 6
        Me.IconAboutUs.Text = "A Propos"
        Me.IconAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconAboutUs.UseVisualStyleBackColor = True
        '
        'IconButtonEmploye
        '
        Me.IconButtonEmploye.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonEmploye.FlatAppearance.BorderSize = 0
        Me.IconButtonEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonEmploye.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonEmploye.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButtonEmploye.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonEmploye.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonEmploye.Location = New System.Drawing.Point(0, 360)
        Me.IconButtonEmploye.Name = "IconButtonEmploye"
        Me.IconButtonEmploye.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonEmploye.Size = New System.Drawing.Size(200, 60)
        Me.IconButtonEmploye.TabIndex = 5
        Me.IconButtonEmploye.Text = "Employé"
        Me.IconButtonEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonEmploye.UseVisualStyleBackColor = True
        '
        'IconButtonMissionAffecte
        '
        Me.IconButtonMissionAffecte.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMissionAffecte.FlatAppearance.BorderSize = 0
        Me.IconButtonMissionAffecte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMissionAffecte.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMissionAffecte.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture
        Me.IconButtonMissionAffecte.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMissionAffecte.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMissionAffecte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMissionAffecte.Location = New System.Drawing.Point(0, 300)
        Me.IconButtonMissionAffecte.Name = "IconButtonMissionAffecte"
        Me.IconButtonMissionAffecte.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonMissionAffecte.Size = New System.Drawing.Size(200, 60)
        Me.IconButtonMissionAffecte.TabIndex = 4
        Me.IconButtonMissionAffecte.Text = "Mission Affecté"
        Me.IconButtonMissionAffecte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMissionAffecte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMissionAffecte.UseVisualStyleBackColor = True
        '
        'IconButtonPartenaire
        '
        Me.IconButtonPartenaire.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPartenaire.FlatAppearance.BorderSize = 0
        Me.IconButtonPartenaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPartenaire.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPartenaire.IconChar = FontAwesome.Sharp.IconChar.Handshake
        Me.IconButtonPartenaire.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonPartenaire.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonPartenaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPartenaire.Location = New System.Drawing.Point(0, 240)
        Me.IconButtonPartenaire.Name = "IconButtonPartenaire"
        Me.IconButtonPartenaire.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPartenaire.Size = New System.Drawing.Size(200, 60)
        Me.IconButtonPartenaire.TabIndex = 3
        Me.IconButtonPartenaire.Text = "Partenaire"
        Me.IconButtonPartenaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPartenaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPartenaire.UseVisualStyleBackColor = True
        '
        'IconButtonMission
        '
        Me.IconButtonMission.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonMission.FlatAppearance.BorderSize = 0
        Me.IconButtonMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonMission.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMission.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        Me.IconButtonMission.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonMission.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonMission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMission.Location = New System.Drawing.Point(0, 180)
        Me.IconButtonMission.Name = "IconButtonMission"
        Me.IconButtonMission.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonMission.Size = New System.Drawing.Size(200, 60)
        Me.IconButtonMission.TabIndex = 2
        Me.IconButtonMission.Text = "Mission"
        Me.IconButtonMission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonMission.UseVisualStyleBackColor = True
        '
        'IconButtonAcceuil
        '
        Me.IconButtonAcceuil.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonAcceuil.FlatAppearance.BorderSize = 0
        Me.IconButtonAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonAcceuil.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAcceuil.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconButtonAcceuil.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAcceuil.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAcceuil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonAcceuil.Location = New System.Drawing.Point(0, 120)
        Me.IconButtonAcceuil.Name = "IconButtonAcceuil"
        Me.IconButtonAcceuil.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonAcceuil.Size = New System.Drawing.Size(200, 60)
        Me.IconButtonAcceuil.TabIndex = 1
        Me.IconButtonAcceuil.Text = "Acceuil"
        Me.IconButtonAcceuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonAcceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonAcceuil.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 120)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GRH_MC_PFE2021.My.Resources.Resources.logov3icon
        Me.PictureBox1.Location = New System.Drawing.Point(50, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.IconWindowMinimize)
        Me.PanelTitleBar.Controls.Add(Me.IconWindowMaximize)
        Me.PanelTitleBar.Controls.Add(Me.IconWindowClose)
        Me.PanelTitleBar.Controls.Add(Me.LabelFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(200, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1134, 62)
        Me.PanelTitleBar.TabIndex = 1
        '
        'IconWindowMinimize
        '
        Me.IconWindowMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconWindowMinimize.FlatAppearance.BorderSize = 0
        Me.IconWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconWindowMinimize.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconWindowMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconWindowMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.IconWindowMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconWindowMinimize.IconSize = 15
        Me.IconWindowMinimize.Location = New System.Drawing.Point(1057, 10)
        Me.IconWindowMinimize.Name = "IconWindowMinimize"
        Me.IconWindowMinimize.Size = New System.Drawing.Size(20, 20)
        Me.IconWindowMinimize.TabIndex = 4
        Me.IconWindowMinimize.UseVisualStyleBackColor = True
        '
        'IconWindowMaximize
        '
        Me.IconWindowMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconWindowMaximize.FlatAppearance.BorderSize = 0
        Me.IconWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconWindowMaximize.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconWindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.IconWindowMaximize.IconColor = System.Drawing.Color.Gainsboro
        Me.IconWindowMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconWindowMaximize.IconSize = 15
        Me.IconWindowMaximize.Location = New System.Drawing.Point(1083, 10)
        Me.IconWindowMaximize.Name = "IconWindowMaximize"
        Me.IconWindowMaximize.Size = New System.Drawing.Size(20, 20)
        Me.IconWindowMaximize.TabIndex = 3
        Me.IconWindowMaximize.UseVisualStyleBackColor = True
        '
        'IconWindowClose
        '
        Me.IconWindowClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconWindowClose.FlatAppearance.BorderSize = 0
        Me.IconWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconWindowClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconWindowClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconWindowClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconWindowClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconWindowClose.IconSize = 15
        Me.IconWindowClose.Location = New System.Drawing.Point(1106, 10)
        Me.IconWindowClose.Name = "IconWindowClose"
        Me.IconWindowClose.Size = New System.Drawing.Size(20, 20)
        Me.IconWindowClose.TabIndex = 2
        Me.IconWindowClose.UseVisualStyleBackColor = True
        '
        'LabelFormTitle
        '
        Me.LabelFormTitle.AutoSize = True
        Me.LabelFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.LabelFormTitle.Location = New System.Drawing.Point(65, 24)
        Me.LabelFormTitle.Name = "LabelFormTitle"
        Me.LabelFormTitle.Size = New System.Drawing.Size(42, 13)
        Me.LabelFormTitle.TabIndex = 1
        Me.LabelFormTitle.Text = "Acceuil"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 43
        Me.IconCurrentForm.Location = New System.Drawing.Point(16, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(43, 44)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Guna2HtmlLabel4)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(200, 62)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1134, 549)
        Me.PanelDesktop.TabIndex = 2
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Silver
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 147)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(1109, 102)
        Me.Guna2HtmlLabel4.TabIndex = 4
        Me.Guna2HtmlLabel4.Text = "Bienvenue dans notre Application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GRH-MC"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1334, 611)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1100, 500)
        Me.Name = "Main"
        Me.Text = "GRH Media Concept"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButtonEmploye As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMissionAffecte As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPartenaire As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonMission As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonAcceuil As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents LabelFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconWindowClose As FontAwesome.Sharp.IconButton
    Friend WithEvents IconWindowMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents IconWindowMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents IconAboutUs As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
