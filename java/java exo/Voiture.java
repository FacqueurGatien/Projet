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
public class Voiture {
    private String marqueVoiture;
    private int tailleVoiture;
    private int duréeStationnement;

    //__________________________Constructeur___________________
    
    public Voiture(String marqueVoiture, int tailleVoiture, int duréeStationnement) {
        this.marqueVoiture = marqueVoiture;
        this.tailleVoiture = tailleVoiture;
        this.duréeStationnement = duréeStationnement;
    }
    //__________________________Methode_________________________


    
    public void affichageVoiture(){
        System.out.println("Model: "+ this.getMarqueVoiture()+ " | Taille: " + this.getTailleVoiture() + " | Durée de stationnement: " + this.getDuréeStationnement() +" !");
    }
    
    //__________________________Getteur_________________________
    
    public String getMarqueVoiture() {
        return marqueVoiture;
    }

    public int getTailleVoiture() {
        return tailleVoiture;
    }

    public int getDuréeStationnement() {
        return duréeStationnement;
    }
    
    //__________________________Setteuur________________________

    public void setMarqueVoiture(String marqueVoiture) {
        this.marqueVoiture = marqueVoiture;
    }

    public void setTailleVoiture(int tailleVoiture) {
        this.tailleVoiture = tailleVoiture;
    }

    public void setDuréeStationnement(int duréeStationnement) {
        this.duréeStationnement = duréeStationnement;
    }
    
}
