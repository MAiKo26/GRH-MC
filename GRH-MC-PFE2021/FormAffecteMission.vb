Imports MySql.Data.MySqlClient
Imports FireSharp.Interfaces
Imports FireSharp.Config
Public Class FormAffecteMission
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


    Private Sub AffecteMissionButton_Click(sender As Object, e As EventArgs) Handles AffecteMissionButton.Click
        Title = "Mission Affecté > Affecté une nouvelle mission"
        OpenChildFormChild(New FormAffecteMissionAjouter, Title)

    End Sub

    Private Sub SupprimerMissionAffecteButton_Click(sender As Object, e As EventArgs) Handles SupprimerMissionAffecteButton.Click
        Title = "Mission Affecté > Supprimer une mission affecté"
        OpenChildFormChild(New FormAffecteMissionSupprimer, Title)

    End Sub

    Private Sub ModifierMissionAffecteButton_Click(sender As Object, e As EventArgs) Handles ModifierMissionAffecteButton.Click
        Title = "Mission Affecté > Modifier une mission affecté"
        OpenChildFormChild(New FormAffecteMissionModifier, Title)

    End Sub

    Private Sub RecherecherMissionAffecteButton_Click(sender As Object, e As EventArgs) Handles RecherecherMissionAffecteButton.Click
        Title = "Mission Affecté > Rechercher une mission affecté"
        OpenChildFormChild(New FormAffecteMissionRechercher, Title)

    End Sub



    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick


    '    Dim DateM, codeM, codeE, codeP, hd, ha, objet, adresse, prixu, unite, info1, info2, info3 As String


    '    DateM = Guna2DataGridView1.Rows(e.RowIndex).Cells(1).Value
    '    codeM = Guna2DataGridView1.Rows(e.RowIndex).Cells(2).Value
    '    codeE = Guna2DataGridView1.Rows(e.RowIndex).Cells(3).Value
    '    codeP = Guna2DataGridView1.Rows(e.RowIndex).Cells(4).Value
    '    hd = Guna2DataGridView1.Rows(e.RowIndex).Cells(5).Value
    '    ha = Guna2DataGridView1.Rows(e.RowIndex).Cells(6).Value
    '    objet = Guna2DataGridView1.Rows(e.RowIndex).Cells(7).Value
    '    adresse = Guna2DataGridView1.Rows(e.RowIndex).Cells(8).Value
    '    prixu = Guna2DataGridView1.Rows(e.RowIndex).Cells(9).Value
    '    unite = Guna2DataGridView1.Rows(e.RowIndex).Cells(10).Value
    '    info1 = Guna2DataGridView1.Rows(e.RowIndex).Cells(11).Value
    '    info2 = Guna2DataGridView1.Rows(e.RowIndex).Cells(12).Value
    '    info3 = Guna2DataGridView1.Rows(e.RowIndex).Cells(13).Value

    '    Dim gbd As New FormAffecteMissionModifier

    '    gbd.load_modifier_mission(DateM, codeM, codeE, codeP, hd, ha, objet, adresse, prixu, unite, info1, info2, info3)


    'End Sub

    Private Sub AffecteMission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()

        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        adp = gbd.Load_AffecteMission()
        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()
    End Sub


End Class