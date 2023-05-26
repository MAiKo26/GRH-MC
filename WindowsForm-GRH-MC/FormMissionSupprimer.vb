Public Class FormMissionSupprimer
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.SuppMission(Guna2TextBox1.Text))

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.SuppMission(Guna2TextBox1.Text))
    End Sub
End Class