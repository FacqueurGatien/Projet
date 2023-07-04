SET FOREIGN_KEY_CHECKS = 0;
DROP TABLE IF EXISTS ADRESSES;
DROP TABLE IF EXISTS auteurs;
DROP TABLE IF EXISTS clients;
DROP TABLE IF EXISTS editeurs;
DROP TABLE IF EXISTS etats;
DROP TABLE IF EXISTS livres;
DROP TABLE IF EXISTS emprunts;
DROP TABLE IF EXISTS EDITEURS_LIVRE;
DROP TABLE IF EXISTS AUTEURS_LIVRE;
SET FOREIGN_KEY_CHECKS = 1;


CREATE TABLE ADRESSES(
   adresse_id INT AUTO_INCREMENT,
   adresse_numero SMALLINT NOT NULL,
   adresse_ext_num CHAR(10),
   adresse_voie VARCHAR(50) NOT NULL,
   adresse_complement VARCHAR(100),
   adresse_ville VARCHAR(50) NOT NULL,
   adresse_cp CHAR(5) NOT NULL,
   PRIMARY KEY(adresse_id)
);

CREATE TABLE AUTEURS(
   auteur_id INT AUTO_INCREMENT,
   auteur_nom VARCHAR(100) NOT NULL,
   auteur_prenom VARCHAR(100),
   PRIMARY KEY(auteur_id)
);

CREATE TABLE EDITEURS(
   editeur_id INT AUTO_INCREMENT,
   editeur_nom VARCHAR(100) NOT NULL,
   PRIMARY KEY(editeur_id)
);

CREATE TABLE ETATS(
   etat_id INT AUTO_INCREMENT,
   etat_libelle VARCHAR(20) NOT NULL,
   PRIMARY KEY(etat_id)
);

CREATE TABLE CLIENTS(
   client_id INT AUTO_INCREMENT,
   client_nom VARCHAR(100) NOT NULL,
   client_prenom VARCHAR(100) NOT NULL,
   client_caution DECIMAL(5,2) NOT NULL,
   adresse_id INT NOT NULL,
   PRIMARY KEY(client_id),
   FOREIGN KEY(adresse_id) REFERENCES ADRESSES(adresse_id)
);

CREATE TABLE LIVRES(
   livre_isbn CHAR(17),
   livre_titre VARCHAR(255) NOT NULL,
   livre_etat_commentaire TEXT,
   livre_date_achat DATE NOT NULL,
   etat_id INT NOT NULL,
   PRIMARY KEY(livre_isbn),
   FOREIGN KEY(etat_id) REFERENCES ETATS(etat_id)
);

CREATE TABLE EMPRUNTS(
   client_id INT,
   livre_isbn CHAR(17),
   emprunt_date_pret DATETIME,
   emprunt_date_retour DATE,
   PRIMARY KEY(client_id, livre_isbn, emprunt_date_pret),
   FOREIGN KEY(client_id) REFERENCES CLIENTS(client_id),
   FOREIGN KEY(livre_isbn) REFERENCES LIVRES(livre_isbn)
);

CREATE TABLE AUTEURS_LIVRE(
   livre_isbn CHAR(17),
   auteur_id INT,
   date_finalisation DATE,
   PRIMARY KEY(livre_isbn, auteur_id),
   FOREIGN KEY(livre_isbn) REFERENCES LIVRES(livre_isbn),
   FOREIGN KEY(auteur_id) REFERENCES AUTEURS(auteur_id)
);

CREATE TABLE EDITEURS_LIVRE(
   livre_isbn CHAR(17),
   editeur_id INT,
   date_parution DATE,
   PRIMARY KEY(livre_isbn, editeur_id),
   FOREIGN KEY(livre_isbn) REFERENCES LIVRES(livre_isbn),
   FOREIGN KEY(editeur_id) REFERENCES EDITEURS(editeur_id)
);
