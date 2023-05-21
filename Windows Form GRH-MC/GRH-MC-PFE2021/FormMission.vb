Imports MySql.Data.MySqlClient
Imports FireSharp.Interfaces
Imports FireSharp.Config
Public Class FormMission

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

    Private Sub AjouterMissionButton_Click(sender As Object, e As EventArgs) Handles AjouterMissionButton.Click
        Title = "Mission > Ajouter une Mission"
        OpenChildFormChild(New FormMissionAjouter, Title)

    End Sub

    Private Sub SupprimerMissionButton_Click(sender As Object, e As EventArgs) Handles SupprimerMissionButton.Click
        Title = "Mission > Supprimer une Mission"
        OpenChildFormChild(New FormMissionSupprimer, Title)

    End Sub

    Private Sub ModifierMissionButton_Click(sender As Object, e As EventArgs) Handles ModifierMissionButton.Click
        Title = "Mission > Modifier une Mission"
        OpenChildFormChild(New FormMissionModifier, Title)

    End Sub

    Private Sub RecherecherMissionButton_Click(sender As Object, e As EventArgs) Handles RecherecherMissionButton.Click
        Title = "Mission > Rechercher une Mission"
        OpenChildFormChild(New FormMissionRechercher, Title)

    End Sub



    Private Sub Mission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()

        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        adp = gbd.load_mission()
        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()

    End Sub



End Class