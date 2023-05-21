Public Class FormPartenaireModifier
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.ModifierPartenaire(Guna2TextBox1.Text, Guna2TextBox8.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox7.Text, Guna2TextBox6.Text, Guna2TextBox4.Text, Guna2TextBox3.Text, Guna2TextBox9.Text, Guna2TextBox10.Text, Guna2TextBox11.Text))

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ModifierPartenaire(Guna2TextBox1.Text, Guna2TextBox8.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox7.Text, Guna2TextBox6.Text, Guna2TextBox4.Text, Guna2TextBox3.Text, Guna2TextBox9.Text, Guna2TextBox10.Text, Guna2TextBox11.Text))


    End Sub
End Class