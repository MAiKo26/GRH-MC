Imports MySql.Data.MySqlClient
Public Class FormPartenaireRechercher
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        Dim gbd As New GestionBD.MySQL()

        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        If (Guna2TextBox1.Text <> "") And (Guna2TextBox2.Text <> "") And (Guna2TextBox3.Text <> "") Then
            adp = gbd.RechPartenaire(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text)
        End If

        If (Guna2TextBox1.Text <> "") And (Guna2TextBox2.Text = "") And (Guna2TextBox3.Text = "") Then
            adp = gbd.RechPartenaireParNom(Guna2TextBox1.Text)
        End If

        If (Guna2TextBox1.Text = "") And (Guna2TextBox2.Text <> "") And (Guna2TextBox3.Text = "") Then
            adp = gbd.RechPartenaireParAdresse(Guna2TextBox2.Text)
        End If

        If (Guna2TextBox1.Text = "") And (Guna2TextBox2.Text = "") And (Guna2TextBox3.Text <> "") Then
            adp = gbd.RechPartenaireParVille(Guna2TextBox3.Text)
        End If


        adp.Fill(dbDataSet)
        bSource.DataSource = dbDataSet
        Guna2DataGridView1.DataSource = bSource
        adp.Update(dbDataSet)
        adp.Dispose()
        dbDataSet.Dispose()


    End Sub
End Class