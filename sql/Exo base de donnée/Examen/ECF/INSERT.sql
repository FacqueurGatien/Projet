TRUNCATE TABLE VEGETABLES RESTART IDENTITY CASCADE; 
TRUNCATE TABLE SALES RESTART IDENTITY CASCADE; 

INSERT INTO VEGETABLES
(VegId , Name , Variety , PrimaryColor , LifeTime , Fresh)
VALUES
(1,'apple','golden','green',90,0)
,(2,'banana','cavendish','yellow',10,0)
,(3,'blueberries','bluecrop','green',8,0)
,(4,'cabbage','broccoli','green',60,0)
,(5,'carrot','de Colmar','orange',60,0)
,(6,'cherry','moreau','darkred',20,0)
,(7,'coconut','palmyre','brown',30,0)
,(8,'grape','aladin','green',10,0)
,(9,'kiwi','hayward','green',40,0)
,(10,'lemon','eureka','green',30,0)
,(11,'onion','Stuttgart','white',90,0)
;

INSERT INTO SALES
(SaleDate , SaleWeight , SaleUnitPrice , SaleActive , VegId )
VALUES
('2022-01-01',5,2.5,1,1)
,('2022-02-02',10,3.99,1,2)
,('2022-03-03',7,2.99,1,3)
,('2022-04-04',9,1.49,1,4)
,('2022-05-05',4,1.59,1,5)
,('2022-06-06',3,1.99,1,6)
,('2022-07-07',8,3.95,1,7)
,('2022-08-08',8,1.95,1,8)
,('2022-09-09',11,2.45,1,9)
,('2022-10-10',11,3.15,0,10)
,('2022-10-10',6,1.25,0,11)
,('2022-11-11',20,1.95,0,8)
;

