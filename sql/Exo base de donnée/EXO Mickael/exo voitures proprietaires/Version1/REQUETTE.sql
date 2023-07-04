--Sélectionner le nom et le numéro d’immatriculation de toutes les voitures triées par immatriculation (ordre croissant).
SELECT car_name , car_registration
FROM CARS
ORDER BY car_registration ASC;

--Sélectionner toutes les informations de toutes les voitures, incluant le nom de la marque ainsi que le nom et prénom du propriétaire. 
--Trier la liste par nom de marque (ordre croissant) puis par nom de propriétaire (ordre croissant).
SELECT *
FROM CARS
NATURAL JOIN OWNERS
NATURAL JOIN BRANDS
ORDER BY brand_name ASC , owner_lastname ASC;

--Sélectionner le nom de toutes les marques incluant le nombre de voitures de chaque marque
SELECT brand_name , COUNT (brand_name) AS nb
FROM BRANDS
NATURAL JOIN CARS
GROUP BY brand_name
ORDER BY nb;

--Sélectionner le nom de toutes les marques incluant le nombre de propriétaires de chaque marque
SELECT  brand_name ,  COUNT (DISTINCT OWNERS.owner_id) AS nb
FROM BRANDS
NATURAL JOIN CARS
NATURAL JOIN OWNERS
GROUP BY brand_name
ORDER BY nb;


--Sélectionner les prénoms des propriétaires dont le prénom commence par la lettre A.
SELECT owner_firstname
FROM OWNERS
WHERE owner_firstname LIKE 'A%';

--Sélectionner le noms et prénom des propriétaires dont le prénom contient plus de 5 lettres.
SELECT owner_lastname , owner_firstname
FROM OWNERS
WHERE LENGTH (owner_firstname) > 5;

--Sélectionner les noms et prénoms des propriétaires possédant plus d’une voiture avec le nombre de voitures possédées par propriétaire. 
--Trier la liste par nombre de voitures possédées. 
--Les propriétaires possédant le plus de voitures apparaissent en 1er.
SELECT owner_lastname , owner_firstname , COUNT (car_id) AS nb
FROM OWNERS
NATURAL JOIN CARS
GROUP BY owner_id
HAVING COUNT (car_id) > 1
ORDER BY nb DESC;

--Sélectionner les noms et prénoms des propriétaires possédant plus d’une voiture de même marque. 
--Pour chaque marque de voiture trouvée, afficher le nom de la marque et le nombre de voiture possédées pour cette marque.
SELECT owner_lastname , owner_firstname , brand_name , COUNT (car_name) AS nb
FROM BRANDS
NATURAL JOIN OWNERS
NATURAL JOIN CARS 
GROUP BY brand_id , owner_id
HAVING COUNT (car_name) > 1
ORDER BY nb DESC;

