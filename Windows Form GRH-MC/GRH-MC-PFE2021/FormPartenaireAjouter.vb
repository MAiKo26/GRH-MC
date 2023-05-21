Public Class FormPartenaireAjouter
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.AjouterPartenaire(Guna2TextBox8.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox7.Text, Guna2TextBox6.Text, Guna2TextBox4.Text, Guna2TextBox3.Text, Guna2TextBox9.Text, Guna2TextBox10.Text, Guna2TextBox11.Text))

        Dim ID As String = gbd.getIDPartenaire()

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ajouterPartenaire(ID, Guna2TextBox8.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox7.Text, Guna2TextBox6.Text, Guna2TextBox4.Text, Guna2TextBox3.Text, Guna2TextBox9.Text, Guna2TextBox10.Text, Guna2TextBox11.Text))

    End Sub

    Private Sub PartenaireAjouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()
        If gbd.getIDPartenaire = "" Then
            Guna2TextBox1.Text = 1
        Else
            Guna2TextBox1.Text = Convert.ToInt32(gbd.getIDPartenaire) + 1
        End If

        Guna2TextBox1.ReadOnly = True
    End Sub

End Class