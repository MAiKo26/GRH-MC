<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMission
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
        Me.code_mission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AjouterMissionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupprimerMissionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ModifierMissionButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RecherecherMissionButton = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.Guna2DataGridView1.ColumnHeadersHeight = 50
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_mission, Me.libelle, Me.type, Me.info1, Me.info2, Me.info3})
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
        Me.Guna2DataGridView1.TabIndex = 2
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
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'code_mission
        '
        Me.code_mission.DataPropertyName = "code_mission"
        Me.code_mission.HeaderText = "Code du mission"
        Me.code_mission.Name = "code_mission"
        Me.code_mission.ReadOnly = True
        '
        'libelle
        '
        Me.libelle.DataPropertyName = "libelle"
        Me.libelle.HeaderText = "Libellé"
        Me.libelle.Name = "libelle"
        Me.libelle.ReadOnly = True
        '
        'type
        '
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
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
        'AjouterMissionButton
        '
        Me.AjouterMissionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AjouterMissionButton.CheckedState.Parent = Me.AjouterMissionButton
        Me.AjouterMissionButton.CustomImages.Parent = Me.AjouterMissionButton
        Me.AjouterMissionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AjouterMissionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.AjouterMissionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AjouterMissionButton.ForeColor = System.Drawing.Color.White
        Me.AjouterMissionButton.HoverState.Parent = Me.AjouterMissionButton
        Me.AjouterMissionButton.Location = New System.Drawing.Point(984, 12)
        Me.AjouterMissionButton.Name = "AjouterMissionButton"
        Me.AjouterMissionButton.ShadowDecoration.Parent = Me.AjouterMissionButton
        Me.AjouterMissionButton.Size = New System.Drawing.Size(109, 44)
        Me.AjouterMissionButton.TabIndex = 3
        Me.AjouterMissionButton.Text = "Ajouter une mission"
        '
        'SupprimerMissionButton
        '
        Me.SupprimerMissionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupprimerMissionButton.CheckedState.Parent = Me.SupprimerMissionButton
        Me.SupprimerMissionButton.CustomImages.Parent = Me.SupprimerMissionButton
        Me.SupprimerMissionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SupprimerMissionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupprimerMissionButton.ForeColor = System.Drawing.Color.White
        Me.SupprimerMissionButton.HoverState.Parent = Me.SupprimerMissionButton
        Me.SupprimerMissionButton.Location = New System.Drawing.Point(869, 12)
        Me.SupprimerMissionButton.Name = "SupprimerMissionButton"
        Me.SupprimerMissionButton.ShadowDecoration.Parent = Me.SupprimerMissionButton
        Me.SupprimerMissionButton.Size = New System.Drawing.Size(109, 44)
        Me.SupprimerMissionButton.TabIndex = 4
        Me.SupprimerMissionButton.Text = "Supprimer une mission"
        '
        'ModifierMissionButton
        '
        Me.ModifierMissionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifierMissionButton.CheckedState.Parent = Me.ModifierMissionButton
        Me.ModifierMissionButton.CustomImages.Parent = Me.ModifierMissionButton
        Me.ModifierMissionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ModifierMissionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ModifierMissionButton.ForeColor = System.Drawing.Color.White
        Me.ModifierMissionButton.HoverState.Parent = Me.ModifierMissionButton
        Me.ModifierMissionButton.Location = New System.Drawing.Point(754, 12)
        Me.ModifierMissionButton.Name = "ModifierMissionButton"
        Me.ModifierMissionButton.ShadowDecoration.Parent = Me.ModifierMissionButton
        Me.ModifierMissionButton.Size = New System.Drawing.Size(109, 44)
        Me.ModifierMissionButton.TabIndex = 5
        Me.ModifierMissionButton.Text = "Modifier une mission"
        '
        'RecherecherMissionButton
        '
        Me.RecherecherMissionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecherecherMissionButton.CheckedState.Parent = Me.RecherecherMissionButton
        Me.RecherecherMissionButton.CustomImages.Parent = Me.RecherecherMissionButton
        Me.RecherecherMissionButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.RecherecherMissionButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RecherecherMissionButton.ForeColor = System.Drawing.Color.White
        Me.RecherecherMissionButton.HoverState.Parent = Me.RecherecherMissionButton
        Me.RecherecherMissionButton.Location = New System.Drawing.Point(639, 12)
        Me.RecherecherMissionButton.Name = "RecherecherMissionButton"
        Me.RecherecherMissionButton.ShadowDecoration.Parent = Me.RecherecherMissionButton
        Me.RecherecherMissionButton.Size = New System.Drawing.Size(109, 44)
        Me.RecherecherMissionButton.TabIndex = 6
        Me.RecherecherMissionButton.Text = "Rechercher une mission"
        '
        'FormMission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 506)
        Me.Controls.Add(Me.RecherecherMissionButton)
        Me.Controls.Add(Me.ModifierMissionButton)
        Me.Controls.Add(Me.SupprimerMissionButton)
        Me.Controls.Add(Me.AjouterMissionButton)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Name = "FormMission"
        Me.Text = "FormMission"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents code_mission As DataGridViewTextBoxColumn
    Friend WithEvents libelle As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents info1 As DataGridViewTextBoxColumn
    Friend WithEvents info2 As DataGridViewTextBoxColumn
    Friend WithEvents info3 As DataGridViewTextBoxColumn
    Friend WithEvents AjouterMissionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupprimerMissionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ModifierMissionButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RecherecherMissionButton As Guna.UI2.WinForms.Guna2Button
End Class
