Imports FireSharp.Interfaces
Imports FireSharp.Config

Public Class Firebase




    Dim mm As New GestionBD.idFirebase()
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = mm.firebase1(),
        .BasePath = mm.firebase2()
        }

    Private client As IFirebaseClient = New FireSharp.FirebaseClient(fcon)






    ' *** SECTION MISSION ***

    ' L'ajout d'une mission

    Public Function ajoutermission(CodeMission As String, LibelleMission As String, TypeMission As String, Inf1Mission As String, Inf2Mission As String, Inf3Mission As String) As String

        Dim mission As New GestionBD.Mission() With
                {
             .codemission = CodeMission,
             .libelle = LibelleMission,
             .type = TypeMission,
             .info1 = Inf1Mission,
             .info2 = Inf2Mission,
             .info3 = Inf3Mission
            }

        ' enregistrement dans firebase
        Dim reponse = client.Set("Liste_Missions/" + CodeMission, mission)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Mission Ajouté avec succes dans le FireBase"

        Else
            Return "Mission n'a pas été ajouté dans le Firebase"

        End If
    End Function

    ' Modifier une Mission

    Public Function modifierMission(CodeMission As String, LibelleMission As String, TypeMission As String, Inf1Mission As String, Inf2Mission As String, Inf3Mission As String) As String

        Dim mission As New GestionBD.Mission() With
                {
             .codemission = CodeMission,
             .libelle = LibelleMission,
             .type = TypeMission,
             .info1 = Inf1Mission,
             .info2 = Inf2Mission,
             .info3 = Inf3Mission
            }

        ' enregistrement dans firebase
        Dim reponse = client.Update("Liste_Missions/" + CodeMission, mission)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then

            Return "Mission update avec succes dans le FireBase"


        Else
            Return "Mission n'a pas été modifié dans le Firebase"

        End If

    End Function

    'Supprimer Une Mission
    Public Function SuppMission(CodeMission As String)


        ' enregistrement dans firebase
        Dim reponse = client.Delete("Liste_Missions/" + CodeMission)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then

            Return "Mission supprimé avec succes dans le FireBase"


        Else
            Return "Mission n'a pas été supprimé dans le Firebase"

        End If

    End Function






    ' *** SECTION PARTENAIRE ***

    ' L'ajout d'un Partenaire

    Public Function ajouterPartenaire(codePartenaire As String, TypePartenaire As String, AdressePartenaire As String, NomPartenaire As String, MobilePartenaire As String, TelephonePartenaire As String, VillePartenaire As String, PaysPartenaire As String, Inf1 As String, Inf2 As String, Inf3 As String)

        Dim partenaire As New GestionBD.Partenaire() With
                {
             .codePartenaire = codePartenaire,
             .type = TypePartenaire,
             .adresse = AdressePartenaire,
             .nom = NomPartenaire,
             .mobile = MobilePartenaire,
             .telephone = TelephonePartenaire,
             .ville = VillePartenaire,
             .pays = PaysPartenaire,
             .info1 = Inf1,
             .info2 = Inf2,
             .info3 = Inf3
            }

        ' enregistrement dans firebase
        Dim reponse = client.Set("Liste_Partenaires/" + codePartenaire, partenaire)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Partenaire Ajouté avec succes dans le FireBase"


        Else
            Return "Partenaire n'a pas été ajouté dans le Firebase"

        End If

    End Function

    ' Modifier un Partenaire

    Public Function ModifierPartenaire(codePartenaire As String, TypePartenaire As String, AdressePartenaire As String, NomPartenaire As String, MobilePartenaire As String, TelephonePartenaire As String, VillePartenaire As String, PaysPartenaire As String, Inf1 As String, Inf2 As String, Inf3 As String)

        Dim partenaire As New GestionBD.Partenaire() With
                {
             .codePartenaire = codePartenaire,
             .type = TypePartenaire,
             .adresse = AdressePartenaire,
             .nom = NomPartenaire,
             .mobile = MobilePartenaire,
             .telephone = TelephonePartenaire,
             .ville = VillePartenaire,
             .pays = PaysPartenaire,
             .info1 = Inf1,
             .info2 = Inf2,
             .info3 = Inf3
            }

        ' enregistrement dans firebase
        Dim reponse = client.Update("Liste_Partenaires/" + codePartenaire, partenaire)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Partenaire Modifié avec succes dans le FireBase"


        Else
            Return "Partenaire n'a pas été Modifié dans le Firebase"

        End If

    End Function

    ' Supprimer un Partenaire

    Public Function SuppPartenaire(codePartenaire As String)

        Dim reponse = client.Delete("Liste_Partenaires/" + codePartenaire)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Partenaire Supprimé avec succes dans le FireBase"


        Else
            Return "Partenaire n'a pas été Supprimé dans le Firebase"

        End If

    End Function






    ' *** SECTION EMPLOYE ***

    ' L'ajout d'un Employe

    Public Function AjouterEmploye(codeEmploye As String, Nom As String, Prenom As String)

        Dim Employe As New GestionBD.Employe() With
                {
             .codeemploye = codeEmploye,
             .nom = Nom,
             .prenom = Prenom
            }

        ' enregistrement dans firebase
        Dim reponse = client.Set("Liste_Employes/" + codeEmploye, Employe)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Employé Ajouté avec succes dans le FireBase"


        Else
            Return "Employé n'a pas été ajouté dans le Firebase"

        End If

    End Function


    ' Modifier un Employé

    Public Function ModifierEmploye(codeEmploye As String, Nom As String, Prenom As String)

        Dim Employe As New GestionBD.Employe() With
                {
             .codeemploye = codeEmploye,
             .nom = Nom,
             .prenom = Prenom
            }

        ' enregistrement dans firebase
        Dim reponse = client.Update("Liste_Employes/" + codeEmploye, Employe)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Employé Modifié avec succes dans le FireBase"


        Else
            Return "Employé n'a pas été Modifié dans le Firebase"

        End If

    End Function

    'Supprimer un Employé

    Public Function SuppEmploye(codeEmploye As String)

        Dim reponse = client.Delete("Liste_Employes/" + codeEmploye)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Employé Supprimé avec succes dans le FireBase"


        Else
            Return "Employé n'a pas été Supprimé dans le Firebase"

        End If


    End Function






    ' *** SECTION AFFECTEMISSION ***

    ' L'ajout d'un mission_employe

    Public Function AjouterAffecteMission(DateMission As Date,
                                           LibelleMission As String,
                                           codeEmploye As String,
                                           codePartenaire As String,
                                           HeureDepartMission As String,
                                           HeureArriveMission As String,
                                           ObjetMission As String,
                                           AdresseMission As String,
                                           PrixUniMission As String,
                                           UniteMission As String,
                                           Info1 As String,
                                           Info2 As String,
                                           Info3 As String) As String

        Dim DateM2 As String = Convert.ToString(DateMission.Day) + "/" + Convert.ToString(DateMission.Month) + "/" + Convert.ToString(DateMission.Year)
        DateMission = Convert.ToDateTime(DateM2)

        Dim missionemploye As New GestionBD.MissionEmploye() With
                {
             .Datemission = DateMission,
             .codemission = LibelleMission,
             .codeemploye = codeEmploye,
             .codepartenaire = codePartenaire,
             .heuredepart = HeureDepartMission,
             .heurearrive = HeureArriveMission,
             .objet = ObjetMission,
             .adresse = AdresseMission,
             .prixu = PrixUniMission,
             .unite = UniteMission,
             .info1 = Info1,
             .info2 = Info2,
             .info3 = Info3
            }


        Dim ID, Year, Month, Day As String
        Year = DateMission.Year
        Month = DateMission.Month
        Day = DateMission.Day



        ID = "CE" + codeEmploye + "CP" + codePartenaire + "LM" + LibelleMission + "DM" + Year + Month + Day + "ID"



        ' enregistrement dans firebase
        Dim reponse = client.Set("Liste_AffecteMissions/" + ID, missionemploye)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Mission affecté  avec succes dans le FireBase avec ID : " + ID


        Else
            Return "Mission n'a pas été affecté dans le Firebase"

        End If

    End Function


    ' Modifier un mission_employe

    Public Function ModifierAffecteMission(DateMission As Date,
                                           LibelleMission As String,
                                           codeEmploye As String,
                                           codePartenaire As String,
                                           HeureDepartMission As String,
                                           HeureArriveMission As String,
                                           ObjetMission As String,
                                           AdresseMission As String,
                                           PrixUniMission As String,
                                           UniteMission As String,
                                           Info1 As String,
                                           Info2 As String,
                                           Info3 As String) As String


        Dim DateM2 As String = Convert.ToString(DateMission.Day) + "/" + Convert.ToString(DateMission.Month) + "/" + Convert.ToString(DateMission.Year)
        DateMission = Convert.ToDateTime(DateM2)

        Dim missionemploye As New GestionBD.MissionEmploye() With
                {
             .Datemission = DateMission,
             .codemission = LibelleMission,
             .codeemploye = codeEmploye,
             .codepartenaire = codePartenaire,
             .heuredepart = HeureDepartMission,
             .heurearrive = HeureArriveMission,
             .objet = ObjetMission,
             .adresse = AdresseMission,
             .prixu = PrixUniMission,
             .unite = UniteMission,
             .info1 = Info1,
             .info2 = Info2,
             .info3 = Info3
            }


        Dim ID, Year, Month, Day As String
        Year = DateMission.Year
        Month = DateMission.Month
        Day = DateMission.Day



        ID = "CE" + codeEmploye + "CP" + codePartenaire + "LM" + LibelleMission + "DM" + Year + Month + Day + "ID"



        ' enregistrement dans firebase
        Dim reponse = client.Update("Liste_AffecteMissions/" + ID, missionemploye)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Mission affecté modifié  avec succes dans le FireBase"


        Else
            Return "Mission affecté n'a pas été modifié dans le Firebase"

        End If

    End Function

    ' Supprimer un mission_employe
    Public Function SuppAffecteMission(codeEmploye As String, codePartenaire As String, LibelleMission As String, DateMission As Date)


        Dim ID, Year, Month, Day As String
        Year = DateMission.Year
        Month = DateMission.Month
        Day = DateMission.Day



        ID = "CE" + codeEmploye + "CP" + codePartenaire + "LM" + LibelleMission + "DM" + Year + Month + Day + "ID"


        Dim reponse = client.Delete("Liste_AffecteMissions/" + ID)
        'elle permet de creer une nouvelle instance de mission sur firebase tout en generant automaiquement un identifiant
        Dim status = reponse.StatusCode
        ' verifier si la requête a été effectuée avec succès
        If status.ToString.Equals("OK") Then


            Return "Mission affecté a été Supprimé  avec succes dans le FireBase"


        Else
            Return "Mission affecté n'a pas été Supprimé dans le Firebase"

        End If


    End Function


End Class
