Imports MySql.Data.MySqlClient


Public Class MySQL


    Private kon As New MySqlConnection("server='localhost';user id='root';password='123456789';database='rh'")




    ' *** SECTION MISSION ***

    'Load Initial du Mission 
    Public Function load_mission() As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String

        'SQL STATEMENT
        sql = "select * from mission"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        adp.SelectCommand = cmd

        kon.Close()
        cmd.Dispose()
        Return adp

    End Function




    ' Ajouter une Mission
    Public Function ajouterMission(LibelleMission As String,
                                   TypeMission As String,
                                   Inf1Mission As String,
                                   Inf2Mission As String,
                                   Inf3Mission As String) As String
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String

        'SQL STATEMENT
        sql = "INSERT INTO `rh`.`mission` ( `libelle`, `type`, `info1`, `info2`, `info3`) VALUES ( @lib, @type, @inf1, @inf2, @inf3);"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = LibelleMission
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = TypeMission
        cmd.Parameters.Add("@inf1", MySqlDbType.VarChar).Value = Inf1Mission
        cmd.Parameters.Add("@inf2", MySqlDbType.VarChar).Value = Inf2Mission
        cmd.Parameters.Add("@inf3", MySqlDbType.VarChar).Value = Inf3Mission


        If cmd.ExecuteNonQuery() = 1 Then

            res = "La Mission a été ajouté avec succées dans la base SQL"

        Else

            res = "Echoue d'ajout du Mission dans la base SQL"

        End If


        cmd.Dispose()
        kon.Close()
        Return res

    End Function



    ' Modifier une Mission
    Public Function modifierMission(CodeMission As String,
                                    LibelleMission As String,
                                    TypeMission As String,
                                    Inf1Mission As String,
                                    Inf2Mission As String,
                                    Inf3Mission As String) As String

        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String

        'SQL STATEMENT
        sql = "Update `rh`.`mission` Set `code_mission` = @codeM, `libelle` = @lib, `type` = @type, `info1` = @inf1, `info2` = @inf2, `info3` = @inf3 WHERE (`code_mission` = @codeM);"


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = CodeMission
        cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = LibelleMission
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = TypeMission
        cmd.Parameters.Add("@inf1", MySqlDbType.VarChar).Value = Inf1Mission
        cmd.Parameters.Add("@inf2", MySqlDbType.VarChar).Value = Inf2Mission
        cmd.Parameters.Add("@inf3", MySqlDbType.VarChar).Value = Inf3Mission


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Mission modifié avec succes dans la base SQL"

        Else

            res = "Erreur de modification dans la base SQL "


        End If

        cmd.Dispose()
        kon.Close()
        Return res


    End Function



    'Supprimer Une Mission
    Public Function SuppMission(CodeMission As String)
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String

        'SQL STATEMENT
        sql = "Delete from `rh`.`mission` WHERE (`code_mission` = @codeM);"


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = CodeMission



        If cmd.ExecuteNonQuery() = 1 Then

            res = "Mission supprimé avec succes dans la base SQL"
        Else
            res = "Erreur de suppression dans la base SQL  "


        End If

        cmd.Dispose()
        kon.Close()
        Return res



    End Function




    'Rechercher une Mission
    Public Function RechMission(CodeMission As String,
                                Libelle As String,
                                Type As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String



        sql = "select * from rh.mission where type=@type and libelle=@lib and code_mission=@codeM ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = CodeMission
        cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = Libelle
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Type
        adp.SelectCommand = cmd

        cmd.Dispose()
        kon.Close()
        Return adp
    End Function
    Public Function RechMissionParCodeMission(CodeMission As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String



        sql = "select * from rh.mission where code_mission=@codeM ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = CodeMission
        adp.SelectCommand = cmd


        cmd.Dispose()
        kon.Close()
        Return adp
    End Function
    Public Function RechMissionParLibelle(Libelle As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String



        sql = "select * from rh.mission where libelle=@lib  ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = Libelle
        adp.SelectCommand = cmd

        cmd.Dispose()
        kon.Close()
        Return adp
    End Function
    Public Function RechMissionParType(Type As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String



        sql = "select * from rh.mission where type=@type  ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Type
        adp.SelectCommand = cmd

        cmd.Dispose()
        kon.Close()
        Return adp
    End Function




    ' Get id pour le FireBase Insert
    Public Function getIDMission() As String

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim res As String

        Dim sql As String
        'SQL STATEMENT
        sql = "SELECT code_mission FROM rh.mission ORDER BY code_mission DESC LIMIT 1 ;"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        res = Convert.ToString(cmd.ExecuteScalar())

        cmd.Dispose()
        kon.Close()
        Return res

    End Function







    ' *** SECTION PARTENAIRE ***



    ' Load Initial du Partenaire
    Public Function load_partenaire() As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dbDataSet As New DataTable

        Dim sql As String
        'SQL STATEMENT
        sql = "select * from partenaire"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        adp.SelectCommand = cmd

        kon.Close()
        cmd.Dispose()
        Return adp



    End Function




    'Ajouter un Partenaire
    Public Function AjouterPartenaire(type As String,
                                      adresse As String,
                                      nom As String,
                                      mobile As String,
                                      tel As String,
                                      ville As String,
                                      pays As String,
                                      Inf1 As String,
                                      Inf2 As String,
                                      Inf3 As String) As String
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = " INSERT INTO `rh`.`partenaire` (`type`, `adresse`, `nom`, `mobile`, `telephone`, `ville`, `pays`, `info1`, `info2`, `info3`) VALUES (@type, @adr, @nom, @mobile, @tel, @ville, @pays, @inf1, @inf2, @inf3); "


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type
        cmd.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adresse
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom
        cmd.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = mobile
        cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel
        cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville
        cmd.Parameters.Add("@pays", MySqlDbType.VarChar).Value = pays
        cmd.Parameters.Add("@inf1", MySqlDbType.VarChar).Value = Inf1
        cmd.Parameters.Add("@inf2", MySqlDbType.VarChar).Value = Inf2
        cmd.Parameters.Add("@inf3", MySqlDbType.VarChar).Value = Inf3


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Partenaire inserer avec succes dans la base SQL "
        Else
            res = "Erreur d'insertion du Partenaire dans la base SQL "


        End If


        cmd.Dispose()
        kon.Close()
        Return res
    End Function




    'Modifier un Partenaire
    Public Function ModifierPartenaire(codePartenaire As String,
                                       type As String,
                                       adresse As String,
                                       nom As String,
                                       mobile As String,
                                       tel As String,
                                       ville As String,
                                       pays As String,
                                       Inf1 As String,
                                       Inf2 As String,
                                       Inf3 As String) As String
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = "UPDATE `rh`.`partenaire` SET `type` = @type, `adresse` = @adr, `nom` = @nom, `mobile` = @mobile, `telephone` = @tel, `ville` = @ville, `pays` = @pays, `info1` = @inf1, `info2` = @inf2, `info3` = @inf3 WHERE (`code_partenaire` = @codep); "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codep", MySqlDbType.VarChar).Value = codePartenaire
        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type
        cmd.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adresse
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom
        cmd.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = mobile
        cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel
        cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = ville
        cmd.Parameters.Add("@pays", MySqlDbType.VarChar).Value = pays
        cmd.Parameters.Add("@inf1", MySqlDbType.VarChar).Value = Inf1
        cmd.Parameters.Add("@inf2", MySqlDbType.VarChar).Value = Inf2
        cmd.Parameters.Add("@inf3", MySqlDbType.VarChar).Value = Inf3


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Partenaire modifié avec succes dans la base SQL"
        Else
            res = "Erreur de modification dans la base SQL"


        End If


        cmd.Dispose()
        kon.Close()
        Return res

    End Function




    'Supprimer un Partenaire 
    Public Function SuppPartenaire(CodePartenaire As String)
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = " DELETE FROM `rh`.`partenaire` WHERE (`code_partenaire` = @codep); "


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codep", MySqlDbType.VarChar).Value = CodePartenaire


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Partenaire a été supprimé dans la base SQL"
        Else
            res = "Erreur de suppression dans la base SQL"


        End If


        cmd.Dispose()
        kon.Close()
        Return res


    End Function




    'Rechercher Un Partenaire (Soit Nom , Soit Adresse , Soit Ville )
    Public Function RechPartenaire(nom As String,
                                   Adresse As String,
                                   Ville As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String = "select * from rh.partenaire ; "

        If (nom <> "") And (Adresse <> "") And (Ville <> "") Then
            sql = "select * from rh.partenaire where nom=@nom and adresse LIKE @adr and Ville=@ville ; "

        Else

            If (nom <> "") And (Adresse <> "") And (Ville = "") Then
                sql = "select * from rh.partenaire where nom=@nom and adresse LIKE @adr ; "
            End If

            If (nom <> "") And (Adresse = "") And (Ville <> "") Then
                sql = "select * from rh.partenaire where nom=@nom and  Ville=@ville ; "
            End If

            If (nom <> "") And (Adresse = "") And (Ville = "") Then
                sql = "select * from rh.partenaire where nom=@nom ; "
            End If

            If (nom = "") And (Adresse <> "") And (Ville <> "") Then
                sql = "select * from rh.partenaire where  adresse LIKE @adr and Ville=@ville ; "
            End If

            If (nom = "") And (Adresse <> "") And (Ville = "") Then
                sql = "select * from rh.partenaire where adresse LIKE @adr ; "
            End If

            If (nom = "") And (Adresse = "") And (Ville <> "") Then
                sql = "select * from rh.partenaire where Ville=@ville ; "
            End If
        End If


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom
        cmd.Parameters.Add("@adr", MySqlDbType.VarChar).Value = "%" + Adresse + "%"
        cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = Ville

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp


    End Function

    Public Function RechPartenaireParAdresse(Adresse As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String


        sql = "select * from rh.partenaire where adresse LIKE @adr ; "



        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@adr", MySqlDbType.VarChar).Value = "%" + Adresse + "%"

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()

        Return adp


    End Function

    Public Function RechPartenaireParVille(Ville As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String

        sql = "select * from rh.partenaire where Ville=@ville ; "


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@ville", MySqlDbType.VarChar).Value = Ville

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp


    End Function

    Public Function RechPartenaireParNom(nom As String) As MySqlDataAdapter

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String

        sql = "select * from rh.partenaire where nom=@nom ; "




        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp


    End Function




    ' Get id pour le FireBase Insert
    Public Function getIDPartenaire() As String

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim res As String

        Dim sql As String
        'SQL STATEMENT
        sql = "SELECT code_partenaire FROM rh.partenaire ORDER BY code_partenaire DESC LIMIT 1 ;"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        res = Convert.ToString(cmd.ExecuteScalar())

        kon.Close()
        cmd.Dispose()
        Return res

    End Function









    ' *** SECTION MISSION_EMPLOYE ***


    ' Load Initial Mission Affecté
    Public Function Load_AffecteMission() As MySqlDataAdapter


        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter


        Dim sql As String
        'SQL STATEMENT
        sql = "select * from mission_employe"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()

        Return adp


    End Function




    'Ajouter Mission Affecté
    Public Function AjouterAffecteMission(DateM As Date,
                                          LibelleM As String,
                                          codeE As String,
                                          codeP As String,
                                          HD As String,
                                          HA As String,
                                          Objet As String,
                                          Adresse As String,
                                          PrixU As String,
                                          Unite As String,
                                          Info1 As String,
                                          Info2 As String,
                                          Info3 As String)

        kon.Open()
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim DateM2 As String
        DateM2 = Convert.ToString(DateM.Day) + "/" + Convert.ToString(DateM.Month) + "/" + Convert.ToString(DateM.Year)
        DateM = Convert.ToDateTime(DateM2)
        LibelleM = Convert.ToInt32(LibelleM)
        codeE = Convert.ToInt32(codeE)
        codeP = Convert.ToInt32(codeP)




        sql = "INSERT INTO `rh`.`mission_employe` (`date_mission`, `code_mission`, `code_employe`, `code_partenaire`, `heure_depart`, `heure_arrive`, `objet`, `adresse_mission`, `prix_unitaire`, `unite`, `info1`, `info2`, `info3`) VALUES (@dateM , @codeM , @codeE , @codeP , @hd , @ha , @objet , @adresse , @prixu , @unite , @info1 , @info2 , @info3); "


        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@dateM", MySqlDbType.Date).Value = DateM
        cmd.Parameters.Add("@codeM", MySqlDbType.Int32).Value = LibelleM
        cmd.Parameters.Add("@codeE", MySqlDbType.Int32).Value = codeE
        cmd.Parameters.Add("@codeP", MySqlDbType.Int32).Value = codeP
        cmd.Parameters.Add("@hd", MySqlDbType.VarChar).Value = HD
        cmd.Parameters.Add("@ha", MySqlDbType.VarChar).Value = HA
        cmd.Parameters.Add("@objet", MySqlDbType.VarChar).Value = Objet
        cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = Adresse
        cmd.Parameters.Add("@prixu", MySqlDbType.VarChar).Value = PrixU
        cmd.Parameters.Add("@unite", MySqlDbType.VarChar).Value = Unite
        cmd.Parameters.Add("@info1", MySqlDbType.VarChar).Value = Info1
        cmd.Parameters.Add("@info2", MySqlDbType.VarChar).Value = Info2
        cmd.Parameters.Add("@info3", MySqlDbType.VarChar).Value = Info3
        If cmd.ExecuteNonQuery() = 1 Then

            res = "Mission Ajoute avec Succes"
        Else
            res = "Echec d'ajout d'une Mission "


        End If


        cmd.Dispose()
        kon.Close()
        Return res



    End Function




    'Modifier Mission Affecté
    Public Function ModifierAffecteMission(DateM As Date,
                                           codeM As String,
                                           codeE As String,
                                           codeP As String,
                                           HD As String,
                                           HA As String,
                                           Objet As String,
                                           Adresse As String,
                                           PrixU As String,
                                           Unite As String,
                                           Info1 As String,
                                           Info2 As String,
                                           Info3 As String)

        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim DateM2 As String = Convert.ToString(DateM.Day) + "/" + Convert.ToString(DateM.Month) + "/" + Convert.ToString(DateM.Year)
        DateM = Convert.ToDateTime(DateM2)

        'SQL STATEMENT
        sql = "UPDATE `rh`.`mission_employe` SET `heure_depart` = @hd, `heure_arrive` = @ha, `objet` = @objet, `adresse_mission` = @adresse, `prix_unitaire` = @prixu, `unite` = @unite, `info1` = @info1, `info2` = @info2, `info3` = @info3 WHERE (`date_mission` = @dateM) and (`code_mission` = @codeM) and (`code_employe` = @codeE) and (`code_partenaire` = @codeP);"


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@dateM", MySqlDbType.Date).Value = DateM
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = codeM
        cmd.Parameters.Add("@codeE", MySqlDbType.VarChar).Value = codeE
        cmd.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = codeP
        cmd.Parameters.Add("@hd", MySqlDbType.VarChar).Value = HD
        cmd.Parameters.Add("@ha", MySqlDbType.VarChar).Value = HA
        cmd.Parameters.Add("@objet", MySqlDbType.VarChar).Value = Objet
        cmd.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = Adresse
        cmd.Parameters.Add("@prixu", MySqlDbType.VarChar).Value = PrixU
        cmd.Parameters.Add("@unite", MySqlDbType.VarChar).Value = Unite
        cmd.Parameters.Add("@info1", MySqlDbType.VarChar).Value = Info1
        cmd.Parameters.Add("@info2", MySqlDbType.VarChar).Value = Info2
        cmd.Parameters.Add("@info3", MySqlDbType.VarChar).Value = Info3



        If cmd.ExecuteNonQuery() = 1 Then

            res = "Mission Modifié avec succes"
        Else
            res = "Erreur de Modification  "


        End If

        cmd.Dispose()
        kon.Close()
        Return res



    End Function




    'Supprimer Mission Affecté
    Public Function SuppAffecteMission(codePartenaire As String,
                                       codeEmploye As String,
                                       codeMission As String,
                                       DateMission As Date) As String
        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim DM As String


        Dim DateM2 As String = Convert.ToString(DateMission.Day) + "/" + Convert.ToString(DateMission.Month) + "/" + Convert.ToString(DateMission.Year)
        Dim DateM3 As Date = Convert.ToDateTime(DateM2)

        'SQL STATEMENT
        sql = "DELETE FROM `rh`.`mission_employe` WHERE (`date_mission` = @dateM ) and (`code_mission` = @codeM) and (`code_employe` = @codeE) and (`code_partenaire` = @codeP);"


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeE", MySqlDbType.VarChar).Value = codeEmploye
        cmd.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = codePartenaire
        cmd.Parameters.Add("@codeM", MySqlDbType.VarChar).Value = codeMission
        cmd.Parameters.Add("@dateM", MySqlDbType.Date).Value = DateM3



        If cmd.ExecuteNonQuery() = 1 Then

            res = "Mission supprimé avec succes"
        Else
            res = "Erreur de suppression  "


        End If

        cmd.Dispose()
        kon.Close()
        Return res



    End Function




    ' Rechercher Une Mission_Employe (Par Code Employé , Code Partenaire , Code Mission , Date Mission ou tout ensemble )
    Public Function RechAffecteMission(CodeE As String,
                                       CodeP As String,
                                       codeMS As String,
                                       dateM As Date) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim DateM2 As String = Convert.ToString(dateM.Day) + "/" + Convert.ToString(dateM.Month) + "/" + Convert.ToString(dateM.Year)
        dateM = Convert.ToDateTime(DateM2)
        Dim sql As String = "select * from rh.mission_employe ; "



        If (CodeE <> "") And (CodeP <> "") And (codeMS <> "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_partenaire=@codeP and code_mission=@codeMS and code_employe=@codeE and date_mission=@date ; "
        End If

        ' Les Posibilities codeE

        If (CodeE <> "") And (CodeP <> "") And (codeMS <> "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_mission=@codeMS and code_employe=@codeE and code_partenaire=@codeP ; "
        End If

        If (CodeE <> "") And (CodeP <> "") And (codeMS = "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_employe=@codeE and code_partenaire=@codeP ; "
        End If

        If (CodeE <> "") And (CodeP = "") And (codeMS <> "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_employe=@codeE and code_mission=@codeMS ; "
        End If

        If (CodeE <> "") And (CodeP = "") And (codeMS = "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_employe=@codeE and date_mission=@date ; "
        End If

        If (CodeE <> "") And (CodeP = "") And (codeMS = "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where  code_employe=@codeE ; "
        End If

        ' Les Posbilities codeP

        If (CodeE = "") And (CodeP <> "") And (codeMS = "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_partenaire=@codeP ; "
        End If

        If (CodeE = "") And (CodeP <> "") And (codeMS <> "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_partenaire=@codeP and code_mission=@codeMS ; "
        End If

        If (CodeE = "") And (CodeP <> "") And (codeMS <> "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_partenaire=@codeP and code_mission=@codeMS and date_mission=@date ; "
        End If

        If (CodeE = "") And (CodeP <> "") And (codeMS = "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_partenaire=@codeP and date_mission=@date ; "
        End If

        ' Les Posibilities codeMS

        If (CodeE = "") And (CodeP = "") And (codeMS <> "") And (dateM = "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_mission=@codeMS ; "
        End If

        If (CodeE = "") And (CodeP = "") And (codeMS <> "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where code_mission=@codeMS and date_mission=@date ; "
        End If


        ' Les Posibilities de dateM

        If (CodeE = "") And (CodeP = "") And (codeMS = "") And (dateM <> "01/01/2000") Then
            sql = "select * from rh.mission_employe where date_mission=@date ; "
        End If


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeE", MySqlDbType.VarChar).Value = CodeE
        cmd.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = CodeP
        cmd.Parameters.Add("@codeMS", MySqlDbType.VarChar).Value = codeMS
        cmd.Parameters.Add("@date", MySqlDbType.Date).Value = dateM

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp
    End Function
    Public Function RechAffecteMissionParCodePartenaire(CodeP As String) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String

        sql = "select * from rh.mission_employe where code_mission=@codeP ; "


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeP", MySqlDbType.VarChar).Value = CodeP

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp
    End Function
    Public Function RechAffecteMissionParCodeEmploye(CodeE As String) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String


        sql = "select * from rh.mission_employe where code_employe=@codeE ; "


        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@codeE", MySqlDbType.VarChar).Value = CodeE


        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp
    End Function
    Public Function RechAffecteMissionParCodeMission(codeMS As String) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String


        sql = "select * from rh.mission_employe where code_mission=@codeMS ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)

        cmd.Parameters.Add("@codeMS", MySqlDbType.VarChar).Value = codeMS

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp
    End Function
    Public Function RechAffecteMissionParDateMission(dateM As String) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim sql As String


        sql = "select * from rh.mission_employe where date_mission=@dateMS ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)

        cmd.Parameters.Add("@codeMS", MySqlDbType.VarChar).Value = dateM

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp
    End Function









    ' *** SECTION EMPLOYE ***

    ' Load Initial Employé
    Public Function Load_Employe() As MySqlDataAdapter


        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter


        Dim sql As String
        'SQL STATEMENT
        sql = "select * from employe"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp


    End Function




    'Ajouter un Employé
    Public Function AjouterEmploye(NomEmploye As String, PrenomEmploye As String) As String

        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = "INSERT INTO `rh`.`employe` (`nom`, `prenom`) VALUES (@nom, @prenom);"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = NomEmploye
        cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = PrenomEmploye


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Employe ajouté avec succes"
        Else
            res = "Erreur d'ajout de l'employe"


        End If


        cmd.Dispose()
        kon.Close()
        Return res





    End Function




    'Modifier un Employé
    Public Function ModifIerEmploye(MatriculeEmploye As String, NomEmploye As String, PrenomEmploye As String) As String

        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = "UPDATE `rh`.`employe` SET `nom` = @nom, `prenom` = @prenom WHERE (`code_employe` = @mat);"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@mat", MySqlDbType.VarChar).Value = MatriculeEmploye
        cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = NomEmploye
        cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = PrenomEmploye


        If cmd.ExecuteNonQuery() = 1 Then

            res = "Employe modifié avec succes"
        Else
            res = "Erreur de modification"


        End If


        cmd.Dispose()
        kon.Close()
        Return res



    End Function




    'Supprimer un Employé 
    Public Function SuppEmploye(MatriculeEmploye As String) As String

        Dim res As String
        Dim cmd As MySqlCommand
        Dim sql As String
        'SQL STATEMENT
        sql = "delete from `rh`.`employe` where code_employe = @mat ;"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@mat", MySqlDbType.VarChar).Value = MatriculeEmploye




        If cmd.ExecuteNonQuery() = 1 Then

            res = "Employe supprimé avec succes"
        Else
            res = "Erreur de suppression"


        End If


        cmd.Dispose()
        kon.Close()
        Return res


    End Function




    'Rechercher un Employé (Par Code)
    Public Function RechEmploye(Matricule As String) As MySqlDataAdapter
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim adp As New MySqlDataAdapter
        sql = "SELECT * FROM rh.employe where code_employe = @mat ; "

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        cmd.Parameters.Add("@mat", MySqlDbType.VarChar).Value = Matricule

        adp.SelectCommand = cmd
        kon.Close()
        cmd.Dispose()
        Return adp

    End Function




    ' Get id pour le FireBase Insert
    Public Function getIDEmploye() As String

        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim res As String

        Dim sql As String
        'SQL STATEMENT
        sql = "SELECT code_employe FROM rh.employe ORDER BY code_employe DESC LIMIT 1 ;"

        kon.Open()
        cmd = New MySqlCommand(sql, kon)
        res = Convert.ToString(cmd.ExecuteScalar())

        kon.Close()
        cmd.Dispose()
        Return res

    End Function

End Class
