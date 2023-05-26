Public Class FormMissionAjouter
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.ajouterMission(Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox5.Text, Guna2TextBox6.Text))

        Dim ID As String = gbd.getIDMission()

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ajoutermission(ID, Guna2TextBox2.Text, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox5.Text, Guna2TextBox6.Text))

    End Sub

    Private Sub MissionAjouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()
        If gbd.getIDMission = "" Then
            Guna2TextBox1.Text = 1
        Else
            Guna2TextBox1.Text = Convert.ToInt32(gbd.getIDMission) + 1

        End If

        Guna2TextBox1.ReadOnly = True
    End Sub


End Class