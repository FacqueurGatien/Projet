DROP TABLE IF EXISTS STOCKES;
DROP TABLE IF EXISTS PERSONNAGES;
DROP TABLE IF EXISTS EMPRUNTS;
DROP TABLE IF EXISTS CASSETTES;
DROP TABLE IF EXISTS CLIENTS;
DROP TABLE IF EXISTS MAGASINS;
DROP TABLE IF EXISTS ADRESSES;
DROP TABLE IF EXISTS ACTEURS;
DROP TABLE IF EXISTS FILMS;
DROP TABLE IF EXISTS GENRES;
DROP TABLE IF EXISTS REALISATEURS;
DROP TABLE IF EXISTS ETATS;

CREATE TABLE ETATS(
   etat_id INT IDENTITY,
   etat_libelle VARCHAR(20) NOT NULL,
   PRIMARY KEY(etat_id)
);

CREATE TABLE REALISATEURS(
   realisateur_id INT IDENTITY,
   realisateur_nom VARCHAR(100) NOT NULL,
   realisateur_prenom VARCHAR(100),
   PRIMARY KEY(realisateur_id)
);

CREATE TABLE ACTEURS(
   acteur_id INT IDENTITY,
   acteur_nom VARCHAR(100) NOT NULL,
   acteur_prenom VARCHAR(100),
   PRIMARY KEY(acteur_id)
);

CREATE TABLE GENRES(
   genre_id INT IDENTITY,
   genre_libelle VARCHAR(50) NOT NULL,
   PRIMARY KEY(genre_id)
);

CREATE TABLE ADRESSES(
   adresse_id INT IDENTITY,
   adresse_num SMALLINT NOT NULL,
   adresse_ext_num VARCHAR(10),
   adresse_voie VARCHAR(100) NOT NULL,
   adresse_complement VARCHAR(255),
   adresse_cp CHAR(5) NOT NULL,
   adresse_ville VARCHAR(50) NOT NULL,
   PRIMARY KEY(adresse_id)
);

CREATE TABLE MAGASINS(
   magasin_id INT IDENTITY,
   adresse_id INT NOT NULL,
   PRIMARY KEY(magasin_id),
   UNIQUE(adresse_id),
   FOREIGN KEY(adresse_id) REFERENCES ADRESSES(adresse_id)
);

CREATE TABLE CLIENTS(
   client_id INT IDENTITY,
   client_nom VARCHAR(100) NOT NULL,
   client_prenom VARCHAR(100) NOT NULL,
   client_caution DECIMAL(5,2) NOT NULL,
   adresse_id INT NOT NULL,
   PRIMARY KEY(client_id),
   FOREIGN KEY(adresse_id) REFERENCES ADRESSES(adresse_id)
);

CREATE TABLE FILMS(
   film_id INT IDENTITY,
   film_titre VARCHAR(100) NOT NULL,
   film_duree TIME NOT NULL,
   genre_id INT NOT NULL,
   realisateur_id INT NOT NULL,
   PRIMARY KEY(film_id),
   FOREIGN KEY(genre_id) REFERENCES GENRES(genre_id),
   FOREIGN KEY(realisateur_id) REFERENCES REALISATEURS(realisateur_id)
);

CREATE TABLE CASSETTES(
   cassette_id INT IDENTITY,
   cassette_date_mise_en_service DATE NOT NULL,
   casette_etat_description VARCHAR(255) NULL,
   film_id INT NOT NULL,
   etat_id INT NOT NULL,
   PRIMARY KEY(cassette_id),
   FOREIGN KEY(film_id) REFERENCES FILMS(film_id),
   FOREIGN KEY(etat_id) REFERENCES ETATS(etat_id)
);

CREATE TABLE EMPRUNTS(
   cassette_id INT,
   emprunt_id INT,
   emprunt_date DATETIME2 NOT NULL,
   client_id INT NOT NULL,
   PRIMARY KEY(cassette_id, emprunt_id),
   FOREIGN KEY(cassette_id) REFERENCES CASSETTES(cassette_id),
   FOREIGN KEY(client_id) REFERENCES CLIENTS(client_id)
);

CREATE TABLE PERSONNAGES(
   film_id INT,
   acteur_id INT,
   personnage_nom VARCHAR(100) NOT NULL,
   personnage_prenom VARCHAR(100),
   PRIMARY KEY(film_id, acteur_id),
   FOREIGN KEY(film_id) REFERENCES FILMS(film_id),
   FOREIGN KEY(acteur_id) REFERENCES ACTEURS(acteur_id)
);

CREATE TABLE STOCKES(
   cassette_id INT,
   magasin_id INT,
   stockage_date DATETIME2 NOT NULL,
   PRIMARY KEY(cassette_id, magasin_id),
   FOREIGN KEY(cassette_id) REFERENCES CASSETTES(cassette_id),
   FOREIGN KEY(magasin_id) REFERENCES MAGASINS(magasin_id)
);
