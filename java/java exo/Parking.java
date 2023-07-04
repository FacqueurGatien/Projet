/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.parking;

import java.util.Random;

/**
 *
 * @author FG-USER-02
 */
public class Parking {

    private String[] listeVoiture;
    private String adresseParking;
    private int tailleParking;
    private Place[] places;
    private int nombreGrandePlace;
    private int heureOuverture;
    private int heureFermeture;
    
    
    //__________________________Constructeur____________________
    
    public Parking(String adresseParking, int tailleParking, int nombreGrandePlace ) {
        this.listeVoiture=new String[]{"Nissan","Mazda","Tesla"};
        this.adresseParking = adresseParking;
        this.tailleParking = tailleParking;
        this.nombreGrandePlace = nombreGrandePlace;
        this.heureOuverture = 8;
        this.heureFermeture = 22;
        this.places=new Place[tailleParking];
        for (int i=0; i< nombreGrandePlace; i++){
            this.places[i]=new Place(2,10);
        }
        for (int i=nombreGrandePlace; i< tailleParking; i++){
            this.places[i]=new Place(1,8);
        }
    }    
    
    //__________________________Methode_________________________
    
    public void affichageParking(){
        for (int i=0; i<places.length ; i++){
            System.out.println("Place n°"+(i+1)+": | Taille de la place: "+ places[i].getTaille() + " | PPrix de la place: "+places[i].getPrix()+" |");
        }
    }
   
    public int randomize(int min, int max){
        return (int) ((Math.random() * (max+1 - min)) + min);
    }
    
    public void selectionVoiture(){
        for (int i=randomize(1,10);i>0;i--){
        Voiture car = new Voiture( this.listeVoiture[this.randomize(0,listeVoiture.length-1)],  this.randomize(1,2),  this.randomize(1,this.heureFermeture-this.heureOuverture));
        System.out.println(car.getMarqueVoiture()+" : "+car.getDuréeStationnement()+" : "+car.getTailleVoiture());
        }
    }
    
    //__________________________Getteur_________________________
    
    public String getAdresseParking() {
        return adresseParking;
    }

    public int getTailleParking() {
        return tailleParking;
    }

    public Place[] getPlaces() {
        return places;
    }
    
    public int getNombreGrandePlace() {
        return nombreGrandePlace;
    }
    
    public String[] getListeVoiture() {
        return listeVoiture;
    }
    
    public int getHeureOuverture(){
        return heureOuverture;
    }
             
    public int getHeureFermeture(){
        return heureFermeture;
    }
    
    //__________________________Setteur_________________________

    public void setAdresseParking(String adresseParking) {
        this.adresseParking = adresseParking;
    }

    public void setTailleParking(int tailleParking) {
        this.tailleParking = tailleParking;
    }

    public void setPlaces(Place[] places) {
        this.places = places;
    }
    
    public void setNombreGrandePlace(int nombreGrandePlace) {
        this.nombreGrandePlace = nombreGrandePlace;
    }

    public void setListeVoiture(String[] listeVoiture) {
        this.listeVoiture = listeVoiture;
    }
    
    public void setHeureOuverture(int heureOuverture) {
        this.heureOuverture = heureOuverture;
    }
    
    public void setHeureFermeture(int heureFermeure) {
        this.heureFermeture = heureFermeture;
    }
    
}
