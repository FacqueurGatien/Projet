insert into ADRESSES
(adresse_numero , adresse_voie, adresse_cp,adresse_ville )
values
(2,'rte des fenesse','88160','Le menil'),
(4,'rue anatole france','57270','uckange'),
(8,'rue de la paix','92000','Paris');

insert into CLIENTS
(client_nom , client_caution,client_prenom, adresse_id )
values
('Facqueur',60,'Gatien',1),
('Cesar',50,'Jule',2),
('Parks',70,'Rosa',3);

insert into AUTEURS
(auteur_nom,auteur_prenom)
values
('Rolling','JK'),
('Verne','Jule'),
('Tolkiene',null);

insert into EDITEURS
(editeur_nom)
values
('Glenat'),
('CLAMP'),
('J''aime lire');

insert into ETATS
(etat_libelle)
values
('neuf'),
('abimé'),
('detruit');

insert into LIVRES
(livre_isbn , livre_titre , livre_date_achat , etat_id , editeur_id)
values
('972-69-874-5632-1','Harry Potter et le prisonier d''azkaban','2010-02-06',1,1),
('972-66-844-5452-2','Seigneur des anneaux les deux tours','2010-05-05',1,2),
('972-62-234-5224-6','La vie en rose','2015-07-12',2,3);

insert into AUTEURS_LIVRE
(livre_id,auteur_id,date_finalisation)
values
(1,1,'2010-03-08'),
(2,3,'2010-09-06'),
(3,2,'2016-02-01');

insert into EMPRUNTS
(emprunt_date_pret,livre_id,client_id,emprunt_date_retour)
values
('2022-11-12',1,1,'2022-11-16'),
('2022-09-05',3,1,'2022-09-08'),
('2022-11-03',2,2,'2022-11-05'),
('2023-11-02',3,3,'2022-11-06');