Public Class MissionEmploye

    <Newtonsoft.Json.JsonProperty("codeemploye")>
    Public Property codeemploye() As String

    <Newtonsoft.Json.JsonProperty("codemission")>
    Public Property codemission() As String

    <Newtonsoft.Json.JsonProperty("datemission")>
    Public Property Datemission() As String

    <Newtonsoft.Json.JsonProperty("codepartenaire")>
    Public Property codepartenaire() As String

    <Newtonsoft.Json.JsonProperty("heuredepart")>
    Public Property heuredepart() As String

    <Newtonsoft.Json.JsonProperty("heurearrive")>
    Public Property heurearrive() As String

    <Newtonsoft.Json.JsonProperty("objet")>
    Public Property objet() As String

    <Newtonsoft.Json.JsonProperty("adresse")>
    Public Property adresse() As String

    <Newtonsoft.Json.JsonProperty("prixu")>
    Public Property prixu() As String

    <Newtonsoft.Json.JsonProperty("unite")>
    Public Property unite() As String

    <Newtonsoft.Json.JsonProperty("info1")>
    Public Property info1() As String


    <Newtonsoft.Json.JsonProperty("info2")>
    Public Property info2() As String


    <Newtonsoft.Json.JsonProperty("info3")>
    Public Property info3() As String

    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing OrElse Not Me.GetType() Is obj.GetType() Then
            Return False
        End If

        Dim missionemploye = CType(obj, MissionEmploye)
        Return Me.codepartenaire.Equals(missionemploye.codepartenaire) And Me.Datemission.Equals(missionemploye.codemission) And Me.codemission.Equals(missionemploye.codemission) And Me.codeemploye.Equals(missionemploye.codeemploye) And Me.heuredepart.Equals(missionemploye.heuredepart) And Me.heurearrive.Equals(missionemploye.heurearrive) And Me.objet.Equals(missionemploye.objet) And Me.adresse.Equals(missionemploye.adresse) And Me.prixu.Equals(missionemploye.prixu) And Me.unite.Equals(missionemploye.unite) And Me.info1.Equals(missionemploye.info1) And Me.info2.Equals(missionemploye.info2) And Me.info3.Equals(missionemploye.info3)
    End Function

End Class
