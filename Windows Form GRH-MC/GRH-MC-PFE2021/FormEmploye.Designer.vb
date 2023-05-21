<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmploye
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
        Me.code_employe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RecherecherEmployeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.ModifierEmployeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.SupprimerEmployeButton = New Guna.UI2.WinForms.Guna2Button()
        Me.AjouterEmployeButton = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_employe, Me.nom, Me.prenom, Me.btn})
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
        Me.Guna2DataGridView1.TabIndex = 3
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
        'code_employe
        '
        Me.code_employe.DataPropertyName = "code_employe"
        Me.code_employe.HeaderText = "Code de l'employé"
        Me.code_employe.Name = "code_employe"
        Me.code_employe.ReadOnly = True
        '
        'nom
        '
        Me.nom.DataPropertyName = "nom"
        Me.nom.HeaderText = "Nom de l'employé"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'prenom
        '
        Me.prenom.DataPropertyName = "prenom"
        Me.prenom.HeaderText = "Prénom de l'employé"
        Me.prenom.Name = "prenom"
        Me.prenom.ReadOnly = True
        '
        'btn
        '
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.HeaderText = "Affecté une mission"
        Me.btn.Name = "btn"
        Me.btn.ReadOnly = True
        Me.btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RecherecherEmployeButton
        '
        Me.RecherecherEmployeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecherecherEmployeButton.CheckedState.Parent = Me.RecherecherEmployeButton
        Me.RecherecherEmployeButton.CustomImages.Parent = Me.RecherecherEmployeButton
        Me.RecherecherEmployeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.RecherecherEmployeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RecherecherEmployeButton.ForeColor = System.Drawing.Color.White
        Me.RecherecherEmployeButton.HoverState.Parent = Me.RecherecherEmployeButton
        Me.RecherecherEmployeButton.Location = New System.Drawing.Point(630, 12)
        Me.RecherecherEmployeButton.Name = "RecherecherEmployeButton"
        Me.RecherecherEmployeButton.ShadowDecoration.Parent = Me.RecherecherEmployeButton
        Me.RecherecherEmployeButton.Size = New System.Drawing.Size(109, 44)
        Me.RecherecherEmployeButton.TabIndex = 10
        Me.RecherecherEmployeButton.Text = "Rechercher un employé"
        '
        'ModifierEmployeButton
        '
        Me.ModifierEmployeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifierEmployeButton.CheckedState.Parent = Me.ModifierEmployeButton
        Me.ModifierEmployeButton.CustomImages.Parent = Me.ModifierEmployeButton
        Me.ModifierEmployeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ModifierEmployeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ModifierEmployeButton.ForeColor = System.Drawing.Color.White
        Me.ModifierEmployeButton.HoverState.Parent = Me.ModifierEmployeButton
        Me.ModifierEmployeButton.Location = New System.Drawing.Point(745, 12)
        Me.ModifierEmployeButton.Name = "ModifierEmployeButton"
        Me.ModifierEmployeButton.ShadowDecoration.Parent = Me.ModifierEmployeButton
        Me.ModifierEmployeButton.Size = New System.Drawing.Size(109, 44)
        Me.ModifierEmployeButton.TabIndex = 9
        Me.ModifierEmployeButton.Text = "Modifier une employé"
        '
        'SupprimerEmployeButton
        '
        Me.SupprimerEmployeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupprimerEmployeButton.CheckedState.Parent = Me.SupprimerEmployeButton
        Me.SupprimerEmployeButton.CustomImages.Parent = Me.SupprimerEmployeButton
        Me.SupprimerEmployeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SupprimerEmployeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SupprimerEmployeButton.ForeColor = System.Drawing.Color.White
        Me.SupprimerEmployeButton.HoverState.Parent = Me.SupprimerEmployeButton
        Me.SupprimerEmployeButton.Location = New System.Drawing.Point(860, 12)
        Me.SupprimerEmployeButton.Name = "SupprimerEmployeButton"
        Me.SupprimerEmployeButton.ShadowDecoration.Parent = Me.SupprimerEmployeButton
        Me.SupprimerEmployeButton.Size = New System.Drawing.Size(109, 44)
        Me.SupprimerEmployeButton.TabIndex = 8
        Me.SupprimerEmployeButton.Text = "Supprimer un employé"
        '
        'AjouterEmployeButton
        '
        Me.AjouterEmployeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AjouterEmployeButton.CheckedState.Parent = Me.AjouterEmployeButton
        Me.AjouterEmployeButton.CustomImages.Parent = Me.AjouterEmployeButton
        Me.AjouterEmployeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.AjouterEmployeButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AjouterEmployeButton.ForeColor = System.Drawing.Color.White
        Me.AjouterEmployeButton.HoverState.Parent = Me.AjouterEmployeButton
        Me.AjouterEmployeButton.Location = New System.Drawing.Point(975, 12)
        Me.AjouterEmployeButton.Name = "AjouterEmployeButton"
        Me.AjouterEmployeButton.ShadowDecoration.Parent = Me.AjouterEmployeButton
        Me.AjouterEmployeButton.Size = New System.Drawing.Size(109, 44)
        Me.AjouterEmployeButton.TabIndex = 7
        Me.AjouterEmployeButton.Text = "Ajouter un employé"
        '
        'FormEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 506)
        Me.Controls.Add(Me.RecherecherEmployeButton)
        Me.Controls.Add(Me.ModifierEmployeButton)
        Me.Controls.Add(Me.SupprimerEmployeButton)
        Me.Controls.Add(Me.AjouterEmployeButton)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Name = "FormEmploye"
        Me.Text = "FormEmploye"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents RecherecherEmployeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ModifierEmployeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SupprimerEmployeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AjouterEmployeButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents code_employe As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents btn As DataGridViewButtonColumn
End Class
