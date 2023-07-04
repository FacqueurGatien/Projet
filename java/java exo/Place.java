/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.parking;

/**
 *
 * @author FG-USER-02
 */
public class Place {
    private int taille;
    private int prix;
    private Boolean dispoPlace;
    
    //__________________________Constructeur____________________
    
    public Place(int taille, int prix) {
        this.taille = taille;
        this.prix = prix;
        this.dispoPlace = true;
    }
    //__________________________Getteur_________________________
    
    public int getTaille() {
        return taille;
    }

    public int getPrix() {
        return prix;
    }    
    
    public Boolean getDispoPlace() {
        return dispoPlace;
    }
    
    //__________________________Setteur_________________________

    public void setTaille(int taille) {
        this.taille = taille;
    }

    public void setPrix(int prix) {
        this.prix = prix;
    }
    
    public void setDispoPlace(Boolean dispoPlace) {
        this.dispoPlace = dispoPlace;
    }

}
