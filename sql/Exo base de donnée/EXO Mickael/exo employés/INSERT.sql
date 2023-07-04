/*TRUNCATE EMPLOYEES CASCADE;

CALL insert_employees ('Holems','Cathy',100000,'2010-01-09');
CALL insert_employees ('Mannheim','Luc',87500,'2017-06-17');
CALL insert_employees ('Kipré','Abdou',42800,'2017-10-09');
CALL insert_employees ('Martin','Valérie',39500,'2018-03-30');
CALL insert_employees ('Slezak','Daniel',75000,'2011-09-09');
CALL insert_employees ('Bahl','Tarik',60000,'2014-04-08');
CALL insert_employees ('Armanetti','Michaël',60000,'2014-05-06');
CALL insert_employees ('Goldman','Estelle',55000,'2016-04-20');
CALL insert_employees ('Durand','Gabriel',55000,'2016-12-02');
CALL insert_employees ('Morel','Audrey',46500,'2012-07-01');
CALL insert_employees ('Carpentier','Guillaume',58500,'2010-02-03');
CALL insert_employees ('Lefebvre','Hugo',42000,'2015-10-11');
CALL insert_employees ('Sharif','Sonia',54500,'2011-01-23');
CALL insert_employees ('Fournier','Sabrina',42000,'2017-10-27');
CALL insert_employees ('Bower','Sarah',49500,'2018-05-22');
CALL insert_employees ('Dimario','Jordan',32500,'2019-06-30');
CALL insert_employees ('Macdowel','Cindy',32500,'2019-11-04');

CALL add_manager (1,NULL);
CALL add_manager (2,1);
CALL add_manager (3,2);
CALL add_manager (4,2);
CALL add_manager (5,1);
CALL add_manager (6,5);
CALL add_manager (7,5);
CALL add_manager (8,5);
CALL add_manager (9,5);
CALL add_manager (10,8);
CALL add_manager (11,8);
CALL add_manager (12,9);
CALL add_manager (13,9);
CALL add_manager (14,15);
CALL add_manager (15,5);
CALL add_manager (16,8);
CALL add_manager (17,9);
*/
TRUNCATE EMPLOYEES RESTART IDENTITY CASCADE;

INSERT INTO EMPLOYEES 
(emp_lastname , emp_firstname , emp_salary , emp_hiredate , emp_manager_id)
VALUES
('Holems','Cathy',100000,'2010-01-09',NULL),
('Mannheim','Luc',87500,'2017-06-17',1),
('Kipré','Abdou',42800,'2017-10-09',2),
('Martin','Valérie',39500,'2018-03-30',2),
('Slezak','Daniel',75000,'2011-09-09',1),
('Bahl','Tarik',60000,'2014-04-08',5),
('Armanetti','Michaël',60000,'2014-05-06',5),
('Goldman','Estelle',55000,'2016-04-20',5),
('Durand','Gabriel',55000,'2016-12-02',5),
('Morel','Audrey',46500,'2012-07-01',8),
('Carpentier','Guillaume',58500,'2010-02-03',8),
('Lefebvre','Hugo',42000,'2015-10-11',9),
('Sharif','Sonia',54500,'2011-01-23',9),
('Fournier','Sabrina',42000,'2017-10-27',NULL),
('Bower','Sarah',49500,'2018-05-22',5),
('Dimario','Jordan',32500,'2019-06-30',8),
('Macdowel','Cindy',32500,'2019-11-04',9);

UPDATE EMPLOYEES 
SET emp_manager_id = 15 
WHERE emp_id = 14;
