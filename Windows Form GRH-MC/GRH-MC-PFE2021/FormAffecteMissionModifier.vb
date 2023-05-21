Imports MySql.Data.MySqlClient

Public Class FormAffecteMissionModifier

    Private kon As New MySqlConnection("server='localhost';user id='root';password='123456789';database='rh'")
    Private Childform As Form

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


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim gbd As New GestionBD.MySQL()
        MsgBox(gbd.ModifierAffecteMission(Guna2DateTimePicker1.Value, Guna2ComboBox1.SelectedValue, Guna2TextBox1.Text, Guna2ComboBox2.SelectedValue, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox6.Text, Guna2TextBox7.Text, Guna2TextBox8.Text, Guna2TextBox9.Text, Guna2TextBox10.Text))


        Dim gbd2 As New GestionBD.Firebase()
        MsgBox(gbd2.ModifierAffecteMission(Guna2DateTimePicker1.Value, Guna2ComboBox1.SelectedValue, Guna2TextBox1.Text, Guna2ComboBox2.SelectedValue, Guna2TextBox3.Text, Guna2TextBox4.Text, Guna2TextBox2.Text, Guna2TextBox5.Text, Guna2TextBox6.Text, Guna2TextBox7.Text, Guna2TextBox8.Text, Guna2TextBox9.Text, Guna2TextBox10.Text))


    End Sub


    Public Sub load_modifier_mission(DateM As Date, codeM As String, codeE As String, codeP As String, HD As String, HA As String, Objet As String, Adresse As String, PrixU As String, Unite As String, Info1 As String, Info2 As String, Info3 As String)

        Me.Close()
        Childform = New FormAffecteMissionModifier
        Childform.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        Main.PanelDesktop.Controls.Add(ChildForm)
        Main.PanelDesktop.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
        Main.LabelFormTitle.Text = "Mission Affecté > Modifier une mission affecté"

        Guna2DateTimePicker1.Value = DateM
        Guna2ComboBox1.Text = codeM
        Guna2TextBox1.Text = codeE
        Guna2ComboBox1.Text = codeP
        Guna2TextBox3.Text = HD
        Guna2TextBox4.Text = HA
        Guna2TextBox2.Text = Objet
        Guna2TextBox5.Text = Adresse
        Guna2TextBox6.Text = PrixU
        Guna2TextBox7.Text = Unite
        Guna2TextBox8.Text = Info1
        Guna2TextBox9.Text = Info2
        Guna2TextBox10.Text = Info3



    End Sub

End Class