package com.example.mcgrhpfe_2021;


import android.content.pm.PermissionInfo;

public class MissionEmploye {
    private String adresse ;
    private String codeemploye ;
    private String codemission ;
    private String codepartenaire ;
    private String datemission ;
    private String heurearrive ;
    private String heuredepart ;
    private String objet ;
    private String prixu ;
    private String unite ;
    private String info1 ;
    private String info2 ;
    private String info3 ;

    MissionEmploye()
    {


    }

    public MissionEmploye(String adresse, String codeemploye, String codemission, String codepartenaire, String datemission, String heurearrive, String heuredepart, String objet, String prixu, String unite, String info1, String info2, String info3) {
        this.adresse = adresse;
        this.codeemploye = codeemploye;
        this.codemission = codemission;
        this.codepartenaire = codepartenaire;
        this.datemission = datemission;
        this.heurearrive = heurearrive;
        this.heuredepart = heuredepart;
        this.objet = objet;
        this.prixu = prixu;
        this.unite = unite;
        this.info1 = info1;
        this.info2 = info2;
        this.info3 = info3;
    }

    public String getInfo1() {
        return info1;
    }

    public void setInfo1(String info1) {
        this.info1 = info1;
    }

    public String getInfo2() {
        return info2;
    }

    public void setInfo2(String info2) {
        this.info2 = info2;
    }

    public String getInfo3() {
        return info3;
    }

    public void setInfo3(String info3) {
        this.info3 = info3;
    }

    public String getAdresse() {
        return adresse;
    }

    public void setAdresse(String adresse) {
        this.adresse = adresse;
    }

    public String getCodeemploye() {
        return codeemploye;
    }

    public void setCodeemploye(String codeemploye) {
        this.codeemploye = codeemploye;
    }

    public String getCodemission() {
        return codemission;
    }

    public void setCodemission(String codemission) {
        this.codemission = codemission;
    }

    public String getCodepartenaire() {
        return codepartenaire;
    }

    public void setCodepartenaire(String codepartenaire) {
        this.codepartenaire = codepartenaire;
    }

    public String getDatemission() {
        return datemission;
    }

    public void setDatemission(String datemission) {
        this.datemission = datemission;
    }

    public String getHeurearrive() {
        return heurearrive;
    }

    public void setHeurearrive(String heurearrive) {
        this.heurearrive = heurearrive;
    }

    public String getHeuredepart() {
        return heuredepart;
    }

    public void setHeuredepart(String heuredepart) {
        this.heuredepart = heuredepart;
    }

    public String getObjet() {
        return objet;
    }

    public void setObjet(String objet) {
        this.objet = objet;
    }

    public String getPrixu() {
        return prixu;
    }

    public void setPrixu(String prixu) {
        this.prixu = prixu;
    }

    public String getUnite() {
        return unite;
    }

    public void setUnite(String unite) {
        this.unite = unite;
    }
}
