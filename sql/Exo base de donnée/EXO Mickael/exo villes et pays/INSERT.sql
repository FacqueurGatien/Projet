/*
TRUNCATE CITIES CASCADE;
TRUNCATE COUNTRIES CASCADE;

CALL insert_country('FR','France');
CALL insert_country('US','United States');
CALL insert_country('RU','Russian Federation');

CALL insert_city('Paris','FR');
CALL insert_city('Lyon','FR');
CALL insert_city('Toulouse','FR');
CALL insert_city('Marseille','FR');
CALL insert_city('Mulhouse','FR');
CALL insert_city('Boston','US');
CALL insert_city('Los Angeles','US');
CALL insert_city('Washinton','US');
CALL insert_city('New York','US');
CALL insert_city('Moscou','RU');
CALL insert_city('Saint-Pétersbourg','RU');
*/

TRUNCATE COUNTRIES CASCADE;
TRUNCATE CITIES;

INSERT INTO COUNTRIES 
VALUES 
('FR','France')
,('US','United States')
,('RU','Russian Federation');

INSERT INTO CITIES(city_name , country_code) 
VALUES 
('Paris','FR')
,('Lyon','FR')
,('Toulouse','FR')
,('Marseille','FR')
,('Mulhouse','FR')
,('Boston','US')
,('Los Angeles','US')
,('Washinton','US')
,('New York','US')
,('Moscou','RU')
,('Saint-Pétersbourg','RU');