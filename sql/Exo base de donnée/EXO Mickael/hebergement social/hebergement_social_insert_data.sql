TRUNCATE TABLE RESIDENTS RESTART IDENTITY CASCADE;
TRUNCATE TABLE PEOPLE RESTART IDENTITY CASCADE;
TRUNCATE TABLE NEED RESTART IDENTITY CASCADE;
TRUNCATE TABLE ROLES RESTART IDENTITY CASCADE;
TRUNCATE TABLE MEDICAL_NEEDS RESTART IDENTITY CASCADE;
TRUNCATE TABLE EVENTS RESTART IDENTITY CASCADE;
TRUNCATE TABLE ACTIVITIES RESTART IDENTITY CASCADE;
TRUNCATE TABLE REGISTER RESTART IDENTITY CASCADE;


INSERT INTO ROLES
(role_id,role_name)
VALUES
(0,'résident'),
(1,'directeur'),
(2,'gardien'),
(3,'cuisinier'),
(4,'technicien'),
(5,'éducateur'),
(6,'médecin');

INSERT INTO PEOPLE 
(person_id , person_lastname , person_firstname , person_birthdate , role_id)
VALUES 
(1,'dev','mike','1980-02-23',1),
(2,'freeman','gordon','1978-11-19',4),
(3,'anderson','thomas','1970-06-26',5),
(4,'logan','gabriel','1962-11-03',6),
(5,'fisher','sam','1957-08-08',5),
(6,'solid','snake','1972-07-13',5),
(7,'mils','bryan','1957-06-15',2),
(8,'gibbs','jhetro','1954-11-21',6),
(9,'dinozo','tony','1972-07-08',3),
(10,'macclane','john','1955-05-23',6),
(11,'mccall','robert','1954-12-28',2),
(12,'wick','john','1964-09-12',5);


UPDATE PEOPLE 
SET person_lastname = 'devolder' 
WHERE person_id=1;

SELECT * FROM PEOPLE;

CALL insert_resident (100,'jeanjean','pierre','1995-06-23','2014-02-15',null,null);
CALL insert_resident (101 , 'larson' , 'nicky' , '1975-03-26' , '2014-02-15',null,null);
CALL insert_resident (102 , 'kao' , 'laura' , '1985-03-26' ,'2014-02-15' ,null, 10);
CALL insert_resident (103,'helene','coby','1995-06-23','2014-02-15','2020-03-04',null);
CALL insert_resident (104 , 'jeane' , 'estere' , '1975-03-26' , '2014-02-15',null,4);
CALL insert_resident (105 , 'rick' , 'holmes' , '1985-03-26' ,'2014-02-15' ,null, null);
CALL insert_resident (106,'call','wu','1995-06-23','2014-02-15','2018-03-25',null);
CALL insert_resident (107 , 'sisi' , 'ossman' , '1975-03-26' , '2014-02-15',null,null);
CALL insert_resident (108 , 'chuck' , 'milles' , '1985-03-26' ,'2014-02-15' ,null, 10);
CALL insert_resident (109,'dona','meyer','1995-06-23','2014-02-15',null,null);

INSERT INTO MEDICAL_NEEDS 
(medical_need_label)
VALUES
('vegetalien')
,('vegetarien')
,('sans gluten')
,('alergie')
,('intolerent')
,('chaise roulante')
,('canne')
,('bureau avec vérin')
,('attelle')
,('collier cervical');

INSERT INTO ACTIVITIES 
(activity_label)
VALUES 
('football'),('basket ball');

INSERT INTO EVENTS
VALUES
(1,'2022-09-21','10:00:00','23:00:00',5,7,true,1,3);

INSERT INTO REGISTER
(person_id , event_id)
VALUES
(100,1)
,(101,1)
,(102,1)
,(103,1)
,(104,1)
,(105,1)
,(106,1)
--,(107,1)
;
/*INSERT INTO EVENTS
VALUES
(2,'2022-09-21','10:00:00','23:00:00',5,15,true,1,2);*/
