package com.example.mcgrhpfe_2021;

public class Partenaire {


    private String adresse ;
    private String codePartenaire ;
    private String info1 ;
    private String info2 ;
    private String info3 ;
    private String mobile ;
    private String nom ;
    private String pays ;
    private String telephone ;
    private String type ;
    private String ville ;

    Partenaire(){ }


    public Partenaire(String adresse, String codePartenaire, String info1, String info2, String info3, String mobile, String nom, String pays, String telephone, String type, String ville) {
        this.adresse = adresse;
        this.codePartenaire = codePartenaire;
        this.info1 = info1;
        this.info2 = info2;
        this.info3 = info3;
        this.mobile = mobile;
        this.nom = nom;
        this.pays = pays;
        this.telephone = telephone;
        this.type = type;
        this.ville = ville;
    }

    public String getAdresse() {
        return adresse;
    }

    public void setAdresse(String adresse) {
        this.adresse = adresse;
    }

    public String getCodePartenaire() {
        return codePartenaire;
    }

    public void setCodePartenaire(String codePartenaire) {
        this.codePartenaire = codePartenaire;
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

    public String getMobile() {
        return mobile;
    }

    public void setMobile(String mobile) {
        this.mobile = mobile;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPays() {
        return pays;
    }

    public void setPays(String pays) {
        this.pays = pays;
    }

    public String getTelephone() {
        return telephone;
    }

    public void setTelephone(String telephone) {
        this.telephone = telephone;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String getVille() {
        return ville;
    }

    public void setVille(String ville) {
        this.ville = ville;
    }
}
