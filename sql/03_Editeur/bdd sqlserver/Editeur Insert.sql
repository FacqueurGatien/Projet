USE Editeur;

INSERT INTO AUTEURS
(auteur_nom,auteur_prenom)
VALUES
('Verne','Jules'),
('Rolling','JK'),
('Hugo','Victor'),
('La Fontaine',null),
('Tolkienne','JR');

INSERT INTO PRIX
(prix_description)
VALUES
('Goncourt'),
('Femina'),
('Renaudot'),
('Médicis'),
('étoiles Librinova');

INSERT INTO LIVRES
(livre_titre)
VALUES
('Harry Potter et le prisonier d''Azkaban'),
('Le seigneur des anneaux, les deux tours'),
('Les fables de la fontaine'),
('Voyage au centre de la terre'),
('Les miserables');

INSERT INTO EDITIONS
(edition_isbn,edition_titre,edition_prix_unitaire,edition_nb_exemplaire,livre_id)
VALUES
('123-5678-1012-000','Harry Potter et le prisonier d''Azkaban',6.5,1500000,1),
('123-5678-1012-010','Le seigneur des anneaux, les deux tours',7,1700000,2),
('123-5678-1012-020','Les fables de la fontaine',6,500000,3),
('123-5678-1012-030','Voyage au centre de la terre',5,1000000,4),
('123-5678-1012-040','Les miserables',5.4,900000,5),
('123-5678-1012-001','Harry Potter and Azkaban''s prisonner',10.5,950000,1),
('123-5678-1012-011','The lord of the ring, two towers',10,830000,2),
('123-5678-1012-021','the fables of the fountain',6,180000,3),
('123-5678-1012-031','A Journey to the Center of the Earth',8.3,750000,4),
('123-5678-1012-041','The Miserable',4.5,65000,5);

INSERT INTO ADRESSES
(adresse_numero,adresse_voie,adresse_ville,adresse_cp)
VALUES
(3,'rue Anatole France','Metz','57000'),
(14,'Rue Calmette','Strasbourg','67000'),
(9,'avenue du génerale Degaulle','Mulhouse','68000'),
(87,'square Francois Miterrand','Paris','92000'),
(32,'rue de la gare','Nancy','54000'),
(6,'rue de la republique','Lille','59000');

INSERT INTO LIBRAIRES
(libraire_nom,adresse_id)
VALUES
('Fnac',1),
('Cultura',3),
('Hisler',5),
('Boukin',2),
('France loisirs',4);

INSERT INTO COMMANDES
(commande_date,libraire_id)
VALUES
('2022-06-12',1),
('2022-06-14',4),
('2022-06-15',4),
('2022-06-15',3),
('2022-06-16',2),
('2022-06-16',2),
('2022-06-16',1),
('2022-06-17',3),
('2022-06-17',4),
('2022-06-18',2),
('2022-06-19',1),
('2022-06-20',4);

INSERT INTO AUTEURS_LIVRE
(livre_id,auteur_id,auteur_livre_date_finalisation_ecrit,auteur_livre_pourcentage_remuneration)
VALUES
(1,2,'1999-07-08',40),
(2,5,'1954-11-11',45),
(3,4,'1668-05-09',10),
(4,1,'1864-09-01',15),
(5,3,'1890-11-12',20);

INSERT INTO RECOMPENSES
(livre_id,prix_id,recompense_date)
VALUES
(1,1,'2004-06-09'),
(2,1,'2006-12-12'),
(3,3,'1960-03-21'),
(4,4,'1996-09-25'),
(5,5,'2000-02-03'),
(1,2,'2004-07-10'),
(2,5,'2006-12-25');

INSERT INTO COMMANDES_EDITION
(commande_id,edition_isbn,commande_edition_nb_edition,commande_edition_prix_de_vente)
VALUES
(1,'123-5678-1012-000',50,425),
(1,'123-5678-1012-010',63,601.5),
(1,'123-5678-1012-031',12,63.5),
(2,'123-5678-1012-000',98,1215.25),
(2,'123-5678-1012-001',125,1200),
(3,'123-5678-1012-000',12,111.5),
(3,'123-5678-1012-030',5,30),
(3,'123-5678-1012-040',36,232.05),
(4,'123-5678-1012-021',32,265.5),
(4,'123-5678-1012-010',25,200);