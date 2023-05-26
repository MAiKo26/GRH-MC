package com.example.mcgrhpfe_2021;

public class Employe {

    private String codeemploye;
    private String nom;
    private String prenom;

    Employe() {
    }

    public Employe(String codeemploye, String nom, String prenom) {
        this.codeemploye = codeemploye;
        this.nom = nom;
        this.prenom = prenom;
    }

    public String getCodeemploye() {
        return codeemploye;
    }

    public void setCodeemploye(String codeemploye) {
        this.codeemploye = codeemploye;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }
}


