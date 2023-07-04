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
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Parking parking = new Parking ("12 rue de la république", 25, 5);
        parking.selectionVoiture();
        Random random = new Random();
       

    }
    
}
