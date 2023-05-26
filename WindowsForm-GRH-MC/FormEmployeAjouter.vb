Public Class FormEmployeAjouter

    Private Sub EmployeAjouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gbd As New GestionBD.MySQL()

        If gbd.getIDEmploye = "" Then
            Guna2TextBox1.Text = 1
        Else
            Guna2TextBox1.Text = Convert.ToInt32(gbd.getIDEmploye) + 1
        End If

        Guna2TextBox1.ReadOnly = True

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.AjouterEmploye(Guna2TextBox2.Text, Guna2TextBox3.Text))

        Dim ID As String = gbd.getIDEmploye()

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.AjouterEmploye(ID, Guna2TextBox2.Text, Guna2TextBox3.Text))
    End Sub
End Class