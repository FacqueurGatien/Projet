TRUNCATE TABLE CARS CASCADE;
TRUNCATE TABLE BRANDS RESTART IDENTITY CASCADE;
TRUNCATE TABLE OWNERS RESTART IDENTITY CASCADE;

CALL insert_brand('Chevrolet');
CALL insert_brand('Audi');
CALL insert_brand('Toyota');
CALL insert_brand('Peugeot');
CALL insert_brand('AMC');
SELECT * FROM BRANDS;

CALL insert_owner('Petit','Annie');
CALL insert_owner('Marsfall','Bénédicte');
CALL insert_owner('Doe','John');
CALL insert_owner('Bouchra','Amine');
CALL insert_owner('Jones','Steeven');
SELECT * FROM CARS;

CALL insert_car(12,'AA-123-AA','Chevelle Concours',1,1);
CALL insert_car(16,'BB-274-BB','A6 Break',2,5);
CALL insert_car(21,'CA-789-BA','Corolla',3,2);
CALL insert_car(19,'CC-546-FV','MONTE CARLO',1,4);
CALL insert_car(27,'CG-274-ZG','504',4,4);
CALL insert_car(30,'ER-355-GX','Q8',2,3);
CALL insert_car(28,'FV-313-FT','100 LS',2,5);
CALL insert_car(23,'DE-228-KS','Hornet',5,5);
CALL insert_car(26,'CF-614-PM','3008',4,5);

/*INSERT INTO cars
(car_registration , car_name , brand_id , owner_id)
VALUES 
('CY-624-PL','Yaris',3,NULL);*/