Public Class Partenaire

    <Newtonsoft.Json.JsonProperty("codePartenaire")>
    Public Property codePartenaire() As String

    <Newtonsoft.Json.JsonProperty("type")>
    Public Property type() As String

    <Newtonsoft.Json.JsonProperty("adresse")>
    Public Property adresse() As String

    <Newtonsoft.Json.JsonProperty("nom")>
    Public Property nom() As String

    <Newtonsoft.Json.JsonProperty("mobile")>
    Public Property mobile() As String

    <Newtonsoft.Json.JsonProperty("telephone")>
    Public Property telephone() As String

    <Newtonsoft.Json.JsonProperty("ville")>
    Public Property ville() As String

    <Newtonsoft.Json.JsonProperty("pays")>
    Public Property pays() As String

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

        Dim partenaire = CType(obj, Partenaire)
        Return Me.codePartenaire.Equals(partenaire.codePartenaire) And Me.type.Equals(partenaire.type) And Me.adresse.Equals(partenaire.adresse) And Me.nom.Equals(partenaire.nom) And Me.mobile.Equals(partenaire.mobile) And Me.telephone.Equals(partenaire.telephone) And Me.ville.Equals(partenaire.ville) And Me.pays.Equals(partenaire.pays) And Me.info1.Equals(partenaire.info1) And Me.info2.Equals(partenaire.info2) And Me.info3.Equals(partenaire.info3)
    End Function

End Class
