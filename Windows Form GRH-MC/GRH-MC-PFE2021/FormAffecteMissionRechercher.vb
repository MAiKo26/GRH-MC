Imports MySql.Data.MySqlClient

Public Class FormAffecteMissionRechercher

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim gbd As New GestionBD.MySQL()

        adp = gbd.RechAffecteMission(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2DateTimePicker1.Value)
        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()
    End Sub
End Class