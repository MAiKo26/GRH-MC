Public Class Mission

    <Newtonsoft.Json.JsonProperty("codemission")>
    Public Property codemission() As String

    <Newtonsoft.Json.JsonProperty("libelle")>
    Public Property libelle() As String

    <Newtonsoft.Json.JsonProperty("type")>
    Public Property type() As String

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



        Dim mission = CType(obj, Mission)
        Return Me.codemission.Equals(mission.codemission) And Me.libelle.Equals(mission.libelle) And Me.info1.Equals(mission.info1) And Me.info2.Equals(mission.info2) And Me.info3.Equals(mission.info3) And Me.type.Equals(mission.type)
    End Function

End Class
