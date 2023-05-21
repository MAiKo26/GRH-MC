Public Class Employe
    <Newtonsoft.Json.JsonProperty("codeemploye")>
    Public Property codeemploye() As String

    <Newtonsoft.Json.JsonProperty("nom")>
    Public Property nom() As String

    <Newtonsoft.Json.JsonProperty("prenom")>
    Public Property prenom() As String


    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing OrElse Not Me.GetType() Is obj.GetType() Then
            Return False
        End If

        Dim Employe = CType(obj, Employe)
        Return Me.codeemploye.Equals(Employe.codeemploye) And Me.nom.Equals(Employe.nom) And Me.prenom.Equals(Employe.prenom)
    End Function

End Class
