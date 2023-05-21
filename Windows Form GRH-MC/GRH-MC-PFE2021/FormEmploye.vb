Imports MySql.Data.MySqlClient
Imports FireSharp.Interfaces
Imports FireSharp.Config
Public Class FormEmploye

    Public codeE As String
    Private Title As String

    Private Sub OpenChildFormChild(ChildForm As Form, Title As String)
        Me.Close()
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        Main.PanelDesktop.Controls.Add(ChildForm)
        Main.PanelDesktop.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
        Main.LabelFormTitle.Text = Title

    End Sub


    Private Sub AjouterEmployeButton_Click(sender As Object, e As EventArgs) Handles AjouterEmployeButton.Click
        Title = "Employé > Ajouter un employé"
        OpenChildFormChild(New FormEmployeAjouter, Title)

    End Sub

    Private Sub SupprimerEmployeButton_Click(sender As Object, e As EventArgs) Handles SupprimerEmployeButton.Click
        Title = "Employé > Supprimer un employé"
        OpenChildFormChild(New FormEmployeSupprimer, Title)

    End Sub

    Private Sub ModifierEmployeButton_Click(sender As Object, e As EventArgs) Handles ModifierEmployeButton.Click
        Title = "Employé > Modifier un employé"
        OpenChildFormChild(New FormEmployeModifier, Title)

    End Sub

    Private Sub RecherecherEmployeButton_Click(sender As Object, e As EventArgs) Handles RecherecherEmployeButton.Click
        Title = "Employé > Rechercher un employé"
        OpenChildFormChild(New FormEmployeRechercher, Title)

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Dim code As String

        code = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value

        Dim gbd As New FormAffecteMissionAjouter

        gbd.load_ajouter_mission(code, gbd)

    End Sub


    Private Sub Employe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()

        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        adp = gbd.Load_Employe()
        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()
    End Sub



End Class