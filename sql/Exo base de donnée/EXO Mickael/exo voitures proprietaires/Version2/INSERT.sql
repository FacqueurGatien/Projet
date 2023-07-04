TRUNCATE TABLE POSSESS RESTART IDENTITY CASCADE;
TRUNCATE TABLE CARS RESTART IDENTITY CASCADE;
TRUNCATE TABLE BRANDS RESTART IDENTITY CASCADE;
TRUNCATE TABLE OWNERS RESTART IDENTITY CASCADE;

CALL insert_brand('Chevrolet');
CALL insert_brand('Audi');
CALL insert_brand('Toyota');
CALL insert_brand('Peugeot');
CALL insert_brand('AMC');

CALL insert_owner('Petit','Annie');
CALL insert_owner('Marsfall','Bénédicte');
CALL insert_owner('Doe','John');
CALL insert_owner('Bouchra','Amine');
CALL insert_owner('Jones','Steeven');

CALL insert_car(12,'Chevelle Concours',1);
CALL insert_car(16,'A6 Break',2);
CALL insert_car(21,'Corolla',3);
CALL insert_car(19,'MONTE CARLO',1);
CALL insert_car(27,'504',4);
CALL insert_car(30,'Q8',2);
CALL insert_car(28,'100 LS',2);
CALL insert_car(23,'Hornet',5);
CALL insert_car(26,'3008',4);

CALL insert_possess(12,1,'AA-123-AA');
CALL insert_possess(16,5,'BB-274-BB');
CALL insert_possess(21,2,'CA-789-BA');
CALL insert_possess(19,4,'CC-546-FV');
CALL insert_possess(27,4,'CG-274-ZG');
CALL insert_possess(30,3,'ER-355-GX');
CALL insert_possess(28,5,'FV-313-FT');
CALL insert_possess(23,5,'DE-228-KS');
CALL insert_possess(26,5,'CF-614-PM');

/*INSERT INTO cars
(car_registration , car_name , brand_id , owner_id)
VALUES 
('CY-624-PL','Yaris',3,NULL);*/