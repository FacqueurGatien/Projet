INSERT INTO TYPES_DE_PARI
(type_de_pari_designation)
VALUES
('Couplé'),
('Tiercé'),
('Quarté'),
('Quinté');

INSERT INTO COURSES
(course_nom , course_debut)
VALUES
('Toto','2022-01-15 10:50:00'),
('Tata','2022-01-16 10:30:00'),
('Titi','2022-01-17 12:00:00'),
('Tutu','2022-01-18 13:15:00'),
('Toutou','2022-01-19 09:50:00'),
('Tete','2022-01-20 18:45:00'),
('Tyty','2022-01-21 19:12:00'),
('Tarte','2022-01-22 16:25:00');

INSERT INTO CHEVAUX
(cheval_nom)
VALUES
('Poney fringant'),
('Joly jumper'),
('Poney qui tousse'),
('Fluffle puff'),
('Raimbow dash'),
('Etalon du cul'),
('Grand dada'),
('Cheval blanc'),
('Ixion'),
('Pegase'),
('Kirin'),
('Ponyta'),
('Galopa'),
('Lievre rouge'),
('Tonerre'),
('Spirit');

INSERT INTO PARIS
(pari_date,pari_montant,type_de_pari_id,course_id)
VALUES
('2022-01-15 09:00:00',50,1,1),
('2022-01-15 09:00:00',50,2,1),
('2022-01-21 09:00:00',50,1,7),
('2022-01-17 09:00:00',70,1,3),
('2022-01-18 09:00:00',80,4,4),
('2022-01-19 09:00:00',90,1,5),
('2022-01-20 09:00:00',100,1,6),
('2022-01-16 09:00:00',200,1,2),
('2022-01-22 09:00:00',200,1,8);

INSERT INTO PARTICIPANTS
(course_id,cheval_id,participant_numero,participant_position_final)
VALUES
(1,1,1,1),
(1,2,2,3),
(1,3,3,5),
(1,4,4,2),
(1,5,5,4),
(2,6,1,2),
(2,7,2,3),
(2,8,3,1),
(2,9,4,4),
(2,10,5,5),
(3,11,1,5),
(3,12,2,1),
(3,13,3,2),
(3,14,4,3),
(3,15,5,4),
(4,1,5,4),
(4,3,4,1),
(4,5,3,2),
(4,7,2,5),
(4,9,1,3),
(5,11,1,1),
(5,13,3,5),
(5,15,5,4),
(5,16,2,2),
(5,5,4,3),
(6,1,1,3),
(6,5,2,2),
(6,10,5,1),
(6,15,4,5),
(6,6,3,4),
(7,3,1,3),
(7,6,2,1),
(7,9,3,2),
(7,12,4,4),
(7,15,5,5),
(8,4,1,1),
(8,8,2,2),
(8,12,3,3),
(8,16,4,4),
(8,1,5,5);

INSERT INTO PRONOSTIQUES
(pari_id,cheval_id,pronostique_position_cheval)
VALUES
(1,1,1),
(1,2,2),
(2,2,1),
(2,3,2),
(2,5,3),
(3,3,1),
(3,15,2),
(4,11,1),
(4,13,2),
(5,9,1),
(5,3,2),
(5,1,3),
(5,5,4),
(5,7,5),
(6,13,1),
(6,5,2),
(7,15,1),
(7,10,2),
(8,9,1),
(8,7,2),
(9,4,1),
(9,12,2);