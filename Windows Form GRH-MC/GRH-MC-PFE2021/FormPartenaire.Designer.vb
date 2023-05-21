<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPartenaire
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
        Me.code_partenaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ville = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.info3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecherecherPartenaireButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ModifierPartenaireButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupprimerPartenaireButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AjouterPartenaireButton = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_partenaire, Me.type, Me.adresse, Me.nom, Me.mobile, Me.telephone, Me.ville, Me.pays, Me.info1, Me.info2, Me.info3})
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
        Me.Guna2DataGridView1.TabIndex = 1
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
        'code_partenaire
        '
        Me.code_partenaire.DataPropertyName = "code_partenaire"
        Me.code_partenaire.HeaderText = "Code du partenaire"
        Me.code_partenaire.Name = "code_partenaire"
        Me.code_partenaire.ReadOnly = True
        '
        'type
        '
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'adresse
        '
        Me.adresse.DataPropertyName = "adresse"
        Me.adresse.HeaderText = "Adresse"
        Me.adresse.Name = "adresse"
        Me.adresse.ReadOnly = True
        '
        'nom
        '
        Me.nom.DataPropertyName = "nom"
        Me.nom.HeaderText = "Nom"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'mobile
        '
        Me.mobile.DataPropertyName = "mobile"
        Me.mobile.HeaderText = "Mobile"
        Me.mobile.Name = "mobile"
        Me.mobile.ReadOnly = True
        '
        'telephone
        '
        Me.telephone.DataPropertyName = "telephone"
        Me.telephone.HeaderText = "Telephone"
        Me.telephone.Name = "telephone"
        Me.telephone.ReadOnly = True
        '
        'ville
        '
        Me.ville.DataPropertyName = "ville"
        Me.ville.HeaderText = "Ville"
        Me.ville.Name = "ville"
        Me.ville.ReadOnly = True
        '
        'pays
        '
        Me.pays.DataPropertyName = "pays"
        Me.pays.HeaderText = "Pays"
        Me.pays.Name = "pays"
        Me.pays.ReadOnly = True
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
        'RecherecherPartenaireButton
        '
        Me.RecherecherPartenaireButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecherecherPartenaireButton.CheckedState.Parent = Me.RecherecherPartenaireButton
        Me.RecherecherPartenaireButton.CustomImages.Parent = Me.RecherecherPartenaireButton
        Me.RecherecherPartenaireButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.RecherecherPartenaireButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RecherecherPartenaireButton.ForeColor = System.Drawing.Color.White
        Me.RecherecherPartenaireButton.HoverState.Parent = Me.RecherecherPartenaireButton
        Me.RecherecherPartenaireButton.Location = New System.Drawing.Point(634, 12)
        Me.RecherecherPartenaireButton.Name = "RecherecherPartenaireButton"
        Me.RecherecherPartenaireButton.ShadowDecoration.Parent = Me.RecherecherPartenaireButton
        Me.RecherecherPartenaireButton.Size = New System.Drawing.Size(109, 44)
        Me.RecherecherPartenaireButton.TabIndex = 10
        Me.RecherecherPartenaireButton.Text = "Rechercher un partenaire"
        '
        'ModifierPartenaireButton
        '
        Me.ModifierPartenaireButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifierPartenaireButton.CheckedState.Parent = Me.ModifierPartenaireButton
        Me.ModifierPartenaireButton.CustomImages.Parent = Me.ModifierPartenaireButton
        Me.ModifierPartenaireButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ModifierPartenaireButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ModifierPartenaireButton.ForeColor = System.Drawing.Color.White
        Me.ModifierPartenaireButton.HoverState.Parent = Me.ModifierPartenaireButton
        Me.ModifierPartenaireButton.Location = New System.Drawing.Point(749, 12)
        Me.ModifierPartenaireButton.Name = "ModifierPartenaireButton"
        Me.ModifierPartenaireButton.ShadowDecoration.Parent = Me.ModifierPartenaireButton
        Me.ModifierPartenaireButton.Size = New System.Drawing.Size(109, 44)
        Me.ModifierPartenaireButton.TabIndex = 9
        Me.ModifierPartenaireButton.Text = "Modifier un partenaire"
        '
        'SupprimerPartenaireButton
        '
        Me.SupprimerPartenaireButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupprimerPartenaireButton.CheckedState.Parent = Me.SupprimerPartenaireButton
        Me.SupprimerPartenaireButton.CustomImages.Parent = Me.SupprimerPartenaireButton
        Me.SupprimerPartenaireButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SupprimerPartenaireButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupprimerPartenaireButton.ForeColor = System.Drawing.Color.White
        Me.SupprimerPartenaireButton.HoverState.Parent = Me.SupprimerPartenaireButton
        Me.SupprimerPartenaireButton.Location = New System.Drawing.Point(864, 12)
        Me.SupprimerPartenaireButton.Name = "SupprimerPartenaireButton"
        Me.SupprimerPartenaireButton.ShadowDecoration.Parent = Me.SupprimerPartenaireButton
        Me.SupprimerPartenaireButton.Size = New System.Drawing.Size(109, 44)
        Me.SupprimerPartenaireButton.TabIndex = 8
        Me.SupprimerPartenaireButton.Text = "Supprimer un partenaire"
        '
        'AjouterPartenaireButton
        '
        Me.AjouterPartenaireButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AjouterPartenaireButton.CheckedState.Parent = Me.AjouterPartenaireButton
        Me.AjouterPartenaireButton.CustomImages.Parent = Me.AjouterPartenaireButton
        Me.AjouterPartenaireButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.AjouterPartenaireButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AjouterPartenaireButton.ForeColor = System.Drawing.Color.White
        Me.AjouterPartenaireButton.HoverState.Parent = Me.AjouterPartenaireButton
        Me.AjouterPartenaireButton.Location = New System.Drawing.Point(979, 12)
        Me.AjouterPartenaireButton.Name = "AjouterPartenaireButton"
        Me.AjouterPartenaireButton.ShadowDecoration.Parent = Me.AjouterPartenaireButton
        Me.AjouterPartenaireButton.Size = New System.Drawing.Size(109, 44)
        Me.AjouterPartenaireButton.TabIndex = 7
        Me.AjouterPartenaireButton.Text = "Ajouter un partenaire"
        '
        'FormPartenaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 506)
        Me.Controls.Add(Me.RecherecherPartenaireButton)
        Me.Controls.Add(Me.ModifierPartenaireButton)
        Me.Controls.Add(Me.SupprimerPartenaireButton)
        Me.Controls.Add(Me.AjouterPartenaireButton)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Name = "FormPartenaire"
        Me.Text = "FormPartenaire"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents code_partenaire As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents adresse As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents mobile As DataGridViewTextBoxColumn
    Friend WithEvents telephone As DataGridViewTextBoxColumn
    Friend WithEvents ville As DataGridViewTextBoxColumn
    Friend WithEvents pays As DataGridViewTextBoxColumn
    Friend WithEvents info1 As DataGridViewTextBoxColumn
    Friend WithEvents info2 As DataGridViewTextBoxColumn
    Friend WithEvents info3 As DataGridViewTextBoxColumn
    Friend WithEvents RecherecherPartenaireButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ModifierPartenaireButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupprimerPartenaireButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AjouterPartenaireButton As Guna.UI2.WinForms.Guna2Button
End Class
