Imports MySql.Data.MySqlClient
Imports FireSharp.Interfaces
Imports FireSharp.Config

Public Class FormPartenaire

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


    Private Sub AjouterPartenaireButton_Click(sender As Object, e As EventArgs) Handles AjouterPartenaireButton.Click
        Title = "Partenaire > Ajouter un Partenaire"
        OpenChildFormChild(New FormPartenaireAjouter, Title)

    End Sub

    Private Sub SupprimerPartenaireButton_Click(sender As Object, e As EventArgs) Handles SupprimerPartenaireButton.Click
        Title = "Partenaire > Supprimer un Partenaire"
        OpenChildFormChild(New FormPartenaireSupprimer, Title)

    End Sub

    Private Sub ModifierPartenaireButton_Click(sender As Object, e As EventArgs) Handles ModifierPartenaireButton.Click
        Title = "Partenaire > Modifier un Partenaire"
        OpenChildFormChild(New FormPartenaireModifier, Title)

    End Sub

    Private Sub RecherecherPartenaireButton_Click(sender As Object, e As EventArgs) Handles RecherecherPartenaireButton.Click
        Title = "Partenaire > Rechercher un Partenaire"
        OpenChildFormChild(New FormPartenaireRechercher, Title)

    End Sub





    Private Sub Partenaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()

        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        adp = gbd.load_partenaire()
        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()
    End Sub


End Class