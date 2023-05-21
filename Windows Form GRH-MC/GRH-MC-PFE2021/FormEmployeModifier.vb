Public Class FormEmployeModifier
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.ModifIerEmploye(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text))

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ModifierEmploye(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text))
    End Sub
End Class