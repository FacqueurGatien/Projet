SET FOREIGN_KEY_CHECKS = 0;
truncate table adresses ;
ALTER TABLE adresses AUTO_INCREMENT = 1;
SET FOREIGN_KEY_CHECKS = 1;

insert into adresses
(adresse_numero , adresse_voie, adresse_cp,adresse_ville )
values
(2,"rte des fenesse","88160","Le menil"),
(4,"rue anatole france","57270","uckange"),
(8,"rue de la paix","92000","Paris");

SET FOREIGN_KEY_CHECKS = 0;
truncate table clients ;
ALTER TABLE clients AUTO_INCREMENT = 1;


insert into clients
(client_nom , client_caution,client_prenom, adresse_id )
values
("Facqueur",60,"Gatien",1),
("Cesar",50,"Jule",2),
("Parks",70,"Rosa",52);

SET FOREIGN_KEY_CHECKS = 1;

SET FOREIGN_KEY_CHECKS = 0;
truncate table auteurs ;
ALTER TABLE auteurs AUTO_INCREMENT = 1;
SET FOREIGN_KEY_CHECKS = 1;

insert into auteurs
(auteur_nom,auteur_prenom)
values
("Rolling","JK"),
("Verne","Jule"),
("Tolkiene",null);

SET FOREIGN_KEY_CHECKS = 0;
truncate table editeurs ;
ALTER TABLE editeurs AUTO_INCREMENT = 1;
SET FOREIGN_KEY_CHECKS = 1;

insert into editeurs
(editeur_nom)
values
("Glenat"),
("CLAMP"),
("J'aime lire");

SET FOREIGN_KEY_CHECKS = 0;
truncate table etats ;
ALTER TABLE etats AUTO_INCREMENT = 1;
SET FOREIGN_KEY_CHECKS = 1;

insert into etats
(etat_libelle)
values
("neuf"),
("abimé"),
("detruit");

SET FOREIGN_KEY_CHECKS = 0;
truncate table livres ;
ALTER TABLE livres AUTO_INCREMENT = 1;
SET FOREIGN_KEY_CHECKS = 1;

insert into livres
(livre_isbn,livre_titre,livre_date_achat,etat_id)
values
("972-69-874-5632-1","Harry Potter et le prisonier d'azkaban","2010-02-06",1),
("972-66-844-5452-2","Seigneur des anneaux les deux tours","2010-05-05",1),
("972-62-234-5224-6","La vie en rose","2015-07-12",2);

SET FOREIGN_KEY_CHECKS = 0;
truncate table EDITEURS_LIVRE ;
SET FOREIGN_KEY_CHECKS = 1;

insert into EDITEURS_LIVRE
(livre_isbn,editeur_id,date_parution)
values
("972-69-874-5632-1",1,"2020-06-06"),
("972-66-844-5452-2",2,"2021-04-03"),
("972-62-234-5224-6",3,"2022-01-11");

SET FOREIGN_KEY_CHECKS = 0;
truncate table AUTEURS_LIVRE ;
SET FOREIGN_KEY_CHECKS = 1;

insert into AUTEURS_LIVRE
(livre_isbn,auteur_id,date_finalisation)
values
("972-69-874-5632-1",1,"2010-03-08"),
("972-66-844-5452-2",3,"2010-09-06"),
("972-62-234-5224-6",2,"2016-02-01");

SET FOREIGN_KEY_CHECKS = 0;
truncate table EMPRUNTS ;
SET FOREIGN_KEY_CHECKS = 1;

insert into EMPRUNTS
(emprunt_date_pret,livre_isbn,client_id,emprunt_date_retour)
values
("2022-11-12","972-69-874-5632-1",1,"2022-11-16"),
("2022-09-05","972-62-234-5224-6",1,"2022-09-08"),
("2022-11-03","972-66-844-5452-2",2,"2022-11-05"),
("2023-11-02","972-62-234-5224-6",3,"2022-11-06");