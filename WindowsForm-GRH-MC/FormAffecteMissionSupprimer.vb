Public Class FormAffecteMissionSupprimer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.SuppAffecteMission(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2DateTimePicker1.Value))


        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.SuppAffecteMission(Guna2TextBox1.Text, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2DateTimePicker1.Value))


    End Sub
End Class