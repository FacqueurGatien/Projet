USE Editeur;

DROP TABLE IF EXISTS RECOMPENSES;
DROP TABLE IF EXISTS AUTEURS_LIVRE;
DROP TABLE IF EXISTS COMMANDES_EDITION;
DROP TABLE IF EXISTS COMMANDES;
DROP TABLE IF EXISTS LIBRAIRES;
DROP TABLE IF EXISTS EDITIONS;
DROP TABLE IF EXISTS PRIX;
DROP TABLE IF EXISTS AUTEURS;
DROP TABLE IF EXISTS ADRESSES;
DROP TABLE IF EXISTS LIVRES;

CREATE TABLE LIVRES(
   livre_id INT IDENTITY,
   livre_titre VARCHAR(50) NOT NULL,
   PRIMARY KEY(livre_id)
);

CREATE TABLE ADRESSES(
   adresse_id INT IDENTITY,
   adresse_numero SMALLINT NOT NULL,
   adresse_ext_num CHAR(10),
   adresse_voie VARCHAR(50) NOT NULL,
   adresse_ville VARCHAR(50) NOT NULL,
   adresse_cp CHAR(5) NOT NULL,
   adresse_complement VARCHAR(max),
   PRIMARY KEY(adresse_id)
);

CREATE TABLE AUTEURS(
   auteur_id INT IDENTITY,
   auteur_nom VARCHAR(50) NOT NULL,
   auteur_prenom VARCHAR(50),
   PRIMARY KEY(auteur_id)
);

CREATE TABLE PRIX(
   prix_id INT IDENTITY,
   prix_description VARCHAR(255) NOT NULL,
   PRIMARY KEY(prix_id)
);

CREATE TABLE EDITIONS(
   edition_isbn CHAR(17),
   edition_titre VARCHAR(50) NOT NULL,
   edition_prix_unitaire DECIMAL(5,2) NOT NULL,
   edition_nb_exemplaire INT NOT NULL,
   livre_id INT NOT NULL,
   PRIMARY KEY(edition_isbn),
   FOREIGN KEY(livre_id) REFERENCES LIVRES(livre_id)
);

CREATE TABLE LIBRAIRES(
   libraire_id INT IDENTITY,
   libraire_nom VARCHAR(50) NOT NULL,
   adresse_id INT NOT NULL,
   PRIMARY KEY(libraire_id),
   FOREIGN KEY(adresse_id) REFERENCES ADRESSES(adresse_id)
);

CREATE TABLE COMMANDES(
   commande_id INT IDENTITY,
   commande_date DATETIME2 NOT NULL,
   libraire_id INT NOT NULL,
   PRIMARY KEY(commande_id),
   FOREIGN KEY(libraire_id) REFERENCES LIBRAIRES(libraire_id)
);

CREATE TABLE COMMANDES_EDITION(
   commande_id INT,
   edition_isbn CHAR(17),
   commande_edition_nb_edition INT NOT NULL,
   commande_edition_prix_de_vente DECIMAL(6,2) NOT NULL,
   PRIMARY KEY(commande_id, edition_isbn),
   FOREIGN KEY(commande_id) REFERENCES COMMANDES(commande_id),
   FOREIGN KEY(edition_isbn) REFERENCES EDITIONS(edition_isbn)
);

CREATE TABLE AUTEURS_LIVRE(
   livre_id INT,
   auteur_id INT,
   auteur_livre_date_finalisation_ecrit VARCHAR(50) NOT NULL,
   auteur_livre_pourcentage_remuneration TINYINT NOT NULL,
   PRIMARY KEY(livre_id, auteur_id),
   FOREIGN KEY(livre_id) REFERENCES LIVRES(livre_id),
   FOREIGN KEY(auteur_id) REFERENCES AUTEURS(auteur_id)
);

CREATE TABLE RECOMPENSES(
   livre_id INT,
   prix_id INT,
   recompense_date DATE NOT NULL,
   PRIMARY KEY(livre_id, prix_id),
   FOREIGN KEY(livre_id) REFERENCES LIVRES(livre_id),
   FOREIGN KEY(prix_id) REFERENCES PRIX(prix_id)
);
