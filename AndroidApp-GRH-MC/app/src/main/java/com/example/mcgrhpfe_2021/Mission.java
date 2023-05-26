package com.example.mcgrhpfe_2021;

public class Mission {

    private String codemission ;
    private String info1 ;
    private String info2 ;
    private String info3 ;
    private String libelle ;
    private String type ;

    Mission(){}


    public Mission(String codemission, String info1, String info2, String info3, String libelle, String type) {
        this.codemission = codemission;
        this.info1 = info1;
        this.info2 = info2;
        this.info3 = info3;
        this.libelle = libelle;
        this.type = type;
    }

    public String getCodemission() {
        return codemission;
    }

    public void setCodemission(String codemission) {
        this.codemission = codemission;
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

    public String getLibelle() {
        return libelle;
    }

    public void setLibelle(String libelle) {
        this.libelle = libelle;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }
}
