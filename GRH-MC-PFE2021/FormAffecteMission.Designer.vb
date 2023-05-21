<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAffecteMission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.date_mission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_mission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_employe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_partenaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.heure_depart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.heure_arrive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.objet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresse_mission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix_unitaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecherecherMissionAffecteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ModifierMissionAffecteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupprimerMissionAffecteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AffecteMissionButton = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 60
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date_mission, Me.code_mission, Me.code_employe, Me.code_partenaire, Me.heure_depart, Me.heure_arrive, Me.objet, Me.adresse_mission, Me.prix_unitaire, Me.unite, Me.info1, Me.info2, Me.info3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 40
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1090, 432)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 60
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'date_mission
        '
        Me.date_mission.DataPropertyName = "date_mission"
        Me.date_mission.HeaderText = "Date du mission"
        Me.date_mission.Name = "date_mission"
        Me.date_mission.ReadOnly = True
        '
        'code_mission
        '
        Me.code_mission.DataPropertyName = "code_mission"
        Me.code_mission.HeaderText = "Code du mission"
        Me.code_mission.Name = "code_mission"
        Me.code_mission.ReadOnly = True
        '
        'code_employe
        '
        Me.code_employe.DataPropertyName = "code_employe"
        Me.code_employe.HeaderText = "Code de l'employé"
        Me.code_employe.Name = "code_employe"
        Me.code_employe.ReadOnly = True
        '
        'code_partenaire
        '
        Me.code_partenaire.DataPropertyName = "code_partenaire"
        Me.code_partenaire.HeaderText = "Code du partenaire"
        Me.code_partenaire.Name = "code_partenaire"
        Me.code_partenaire.ReadOnly = True
        '
        'heure_depart
        '
        Me.heure_depart.DataPropertyName = "heure_depart"
        Me.heure_depart.HeaderText = "Heure du départ"
        Me.heure_depart.Name = "heure_depart"
        Me.heure_depart.ReadOnly = True
        '
        'heure_arrive
        '
        Me.heure_arrive.DataPropertyName = "heure_arrive"
        Me.heure_arrive.HeaderText = "Heure de l'arrivé"
        Me.heure_arrive.Name = "heure_arrive"
        Me.heure_arrive.ReadOnly = True
        '
        'objet
        '
        Me.objet.DataPropertyName = "objet"
        Me.objet.HeaderText = "L'Objetive du mission"
        Me.objet.Name = "objet"
        Me.objet.ReadOnly = True
        '
        'adresse_mission
        '
        Me.adresse_mission.DataPropertyName = "adresse_mission"
        Me.adresse_mission.HeaderText = "L'adresse du mission"
        Me.adresse_mission.Name = "adresse_mission"
        Me.adresse_mission.ReadOnly = True
        '
        'prix_unitaire
        '
        Me.prix_unitaire.DataPropertyName = "prix_unitaire"
        Me.prix_unitaire.HeaderText = "Prix unitaire"
        Me.prix_unitaire.Name = "prix_unitaire"
        Me.prix_unitaire.ReadOnly = True
        '
        'unite
        '
        Me.unite.DataPropertyName = "prix_unitaire"
        Me.unite.HeaderText = "Le nombre d'unité"
        Me.unite.Name = "unite"
        Me.unite.ReadOnly = True
        '
        'info1
        '
        Me.info1.DataPropertyName = "info1"
        Me.info1.HeaderText = "Info 1"
        Me.info1.Name = "info1"
        Me.info1.ReadOnly = True
        '
        'info2
        '
        Me.info2.DataPropertyName = "info2"
        Me.info2.HeaderText = "Info 2"
        Me.info2.Name = "info2"
        Me.info2.ReadOnly = True
        '
        'info3
        '
        Me.info3.DataPropertyName = "info3"
        Me.info3.HeaderText = "Info 3"
        Me.info3.Name = "info3"
        Me.info3.ReadOnly = True
        '
        'RecherecherMissionAffecteButton
        '
        Me.RecherecherMissionAffecteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecherecherMissionAffecteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.RecherecherMissionAffecteButton.CheckedState.Parent = Me.RecherecherMissionAffecteButton
        Me.RecherecherMissionAffecteButton.CustomImages.Parent = Me.RecherecherMissionAffecteButton
        Me.RecherecherMissionAffecteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.RecherecherMissionAffecteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RecherecherMissionAffecteButton.ForeColor = System.Drawing.Color.White
        Me.RecherecherMissionAffecteButton.HoverState.Parent = Me.RecherecherMissionAffecteButton
        Me.RecherecherMissionAffecteButton.Location = New System.Drawing.Point(637, 12)
        Me.RecherecherMissionAffecteButton.Name = "RecherecherMissionAffecteButton"
        Me.RecherecherMissionAffecteButton.ShadowDecoration.Parent = Me.RecherecherMissionAffecteButton
        Me.RecherecherMissionAffecteButton.Size = New System.Drawing.Size(109, 44)
        Me.RecherecherMissionAffecteButton.TabIndex = 10
        Me.RecherecherMissionAffecteButton.Text = "Rechercher une mission Affecté"
        '
        'ModifierMissionAffecteButton
        '
        Me.ModifierMissionAffecteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifierMissionAffecteButton.CheckedState.Parent = Me.ModifierMissionAffecteButton
        Me.ModifierMissionAffecteButton.CustomImages.Parent = Me.ModifierMissionAffecteButton
        Me.ModifierMissionAffecteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ModifierMissionAffecteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ModifierMissionAffecteButton.ForeColor = System.Drawing.Color.White
        Me.ModifierMissionAffecteButton.HoverState.Parent = Me.ModifierMissionAffecteButton
        Me.ModifierMissionAffecteButton.Location = New System.Drawing.Point(752, 12)
        Me.ModifierMissionAffecteButton.Name = "ModifierMissionAffecteButton"
        Me.ModifierMissionAffecteButton.ShadowDecoration.Parent = Me.ModifierMissionAffecteButton
        Me.ModifierMissionAffecteButton.Size = New System.Drawing.Size(109, 44)
        Me.ModifierMissionAffecteButton.TabIndex = 9
        Me.ModifierMissionAffecteButton.Text = "Modifier une mission affecté"
        '
        'SupprimerMissionAffecteButton
        '
        Me.SupprimerMissionAffecteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupprimerMissionAffecteButton.CheckedState.Parent = Me.SupprimerMissionAffecteButton
        Me.SupprimerMissionAffecteButton.CustomImages.Parent = Me.SupprimerMissionAffecteButton
        Me.SupprimerMissionAffecteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SupprimerMissionAffecteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupprimerMissionAffecteButton.ForeColor = System.Drawing.Color.White
        Me.SupprimerMissionAffecteButton.HoverState.Parent = Me.SupprimerMissionAffecteButton
        Me.SupprimerMissionAffecteButton.Location = New System.Drawing.Point(867, 12)
        Me.SupprimerMissionAffecteButton.Name = "SupprimerMissionAffecteButton"
        Me.SupprimerMissionAffecteButton.ShadowDecoration.Parent = Me.SupprimerMissionAffecteButton
        Me.SupprimerMissionAffecteButton.Size = New System.Drawing.Size(109, 44)
        Me.SupprimerMissionAffecteButton.TabIndex = 8
        Me.SupprimerMissionAffecteButton.Text = "Supprimer une mission affecté"
        '
        'AffecteMissionButton
        '
        Me.AffecteMissionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AffecteMissionButton.CheckedState.Parent = Me.AffecteMissionButton
        Me.AffecteMissionButton.CustomImages.Parent = Me.AffecteMissionButton
        Me.AffecteMissionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.AffecteMissionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AffecteMissionButton.ForeColor = System.Drawing.Color.White
        Me.AffecteMissionButton.HoverState.Parent = Me.AffecteMissionButton
        Me.AffecteMissionButton.Location = New System.Drawing.Point(982, 12)
        Me.AffecteMissionButton.Name = "AffecteMissionButton"
        Me.AffecteMissionButton.ShadowDecoration.Parent = Me.AffecteMissionButton
        Me.AffecteMissionButton.Size = New System.Drawing.Size(109, 44)
        Me.AffecteMissionButton.TabIndex = 7
        Me.AffecteMissionButton.Text = "Affecté une mission"
        '
        'FormAffecteMission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 506)
        Me.Controls.Add(Me.RecherecherMissionAffecteButton)
        Me.Controls.Add(Me.ModifierMissionAffecteButton)
        Me.Controls.Add(Me.SupprimerMissionAffecteButton)
        Me.Controls.Add(Me.AffecteMissionButton)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Name = "FormAffecteMission"
        Me.Text = "FormAffecteMission"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents date_mission As DataGridViewTextBoxColumn
    Friend WithEvents code_mission As DataGridViewTextBoxColumn
    Friend WithEvents code_employe As DataGridViewTextBoxColumn
    Friend WithEvents code_partenaire As DataGridViewTextBoxColumn
    Friend WithEvents heure_depart As DataGridViewTextBoxColumn
    Friend WithEvents heure_arrive As DataGridViewTextBoxColumn
    Friend WithEvents objet As DataGridViewTextBoxColumn
    Friend WithEvents adresse_mission As DataGridViewTextBoxColumn
    Friend WithEvents prix_unitaire As DataGridViewTextBoxColumn
    Friend WithEvents unite As DataGridViewTextBoxColumn
    Friend WithEvents info1 As DataGridViewTextBoxColumn
    Friend WithEvents info2 As DataGridViewTextBoxColumn
    Friend WithEvents info3 As DataGridViewTextBoxColumn
    Friend WithEvents RecherecherMissionAffecteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ModifierMissionAffecteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupprimerMissionAffecteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AffecteMissionButton As Guna.UI2.WinForms.Guna2Button
End Class
