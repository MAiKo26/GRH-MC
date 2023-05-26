Public Class FormMissionModifier
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.modifierMission(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox5.Text, Guna2TextBox6.Text))

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ajoutermission(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox5.Text, Guna2TextBox6.Text))

    End Sub
End Class