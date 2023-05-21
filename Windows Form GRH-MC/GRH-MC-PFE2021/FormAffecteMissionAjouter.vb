Imports MySql.Data.MySqlClient

Public Class FormAffecteMissionAjouter

    Private kon As New MySqlConnection("server='localhost';user id='root';password='123456789';database='rh'")
    Private Childform As New Form

    Private Sub Display_Data_From_MySQL_Depending_On_Combobox_Value_Load(Sender As Object, e As EventArgs) Handles MyBase.Load



        Dim cmd As New MySqlCommand("Select * from partenaire", kon)
        Dim adp As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        Guna2ComboBox2.DataSource = table
        Guna2ComboBox2.DisplayMember = "nom"
        Guna2ComboBox2.ValueMember = "code_partenaire"

        Dim cmd2 As New MySqlCommand("Select * from mission", kon)
        Dim adp2 As New MySqlDataAdapter(cmd2)
        Dim table2 As New DataTable()
        adp2.Fill(table2)
        Guna2ComboBox1.DataSource = table2
        Guna2ComboBox1.DisplayMember = "libelle"
        Guna2ComboBox1.ValueMember = "code_mission"


    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Childform = New FormPartenaireAjouter
        Me.Close()
        Childform.TopLevel = False
        Childform.FormBorderStyle = FormBorderStyle.None
        Childform.Dock = DockStyle.Fill
        Main.PanelDesktop.Controls.Add(Childform)
        Main.PanelDesktop.Tag = Childform
        Childform.BringToFront()
        Childform.Show()
        Main.LabelFormTitle.Text = "Partenaire > Ajouter un partenaire"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.AjouterAffecteMission(Guna2DateTimePicker1.Value, Guna2ComboBox1.SelectedValue, Guna2TextBox1.Text, Guna2ComboBox2.SelectedValue, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox6.Text, Guna2TextBox7.Text, Guna2TextBox8.Text, Guna2TextBox9.Text, Guna2TextBox10.Text))

        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.AjouterAffecteMission(Guna2DateTimePicker1.Value, Guna2ComboBox1.SelectedValue, Guna2TextBox1.Text, Guna2ComboBox2.SelectedValue, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox6.Text, Guna2TextBox7.Text, Guna2TextBox8.Text, Guna2TextBox9.Text, Guna2TextBox10.Text))

    End Sub


    Public Sub load_ajouter_mission(code As String, Childform As Form)

        FormEmploye.Close()
        Childform.TopLevel = False
        Childform.FormBorderStyle = FormBorderStyle.None
        Childform.Dock = DockStyle.Fill
        Main.PanelDesktop.Controls.Add(Childform)
        Main.PanelDesktop.Tag = Childform
        Childform.BringToFront()
        Childform.Show()

        Main.LabelFormTitle.Text = "Mission Affecte > Affecter une nouvelle mission"

        Guna2TextBox1.Text = code

    End Sub



End Class