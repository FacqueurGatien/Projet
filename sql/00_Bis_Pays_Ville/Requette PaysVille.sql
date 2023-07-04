SELECT 
	ci.city_name
FROM cities AS ci

SELECT 
	ci.city_id
	,ci.city_name
FROM cities AS ci
ORDER BY ci.city_name;

SELECT 
	ci.city_name AS 'nom_de_la_ville'
	,co.country_name AS 'nom_du_pays'
	,co.country_code AS 'code_ISO_du_pays'
FROM cities AS ci
JOIN countries AS co ON co.country_code = ci.country_code
ORDER BY co.country_code DESC;

SELECT 
	co.country_code
	,co.country_name
	,COUNT (ci.city_id) AS 'nb_country'
FROM countries AS co
JOIN cities AS ci ON ci.country_code = co.country_code
GROUP BY 	
	co.country_code
	,co.country_name
ORDER BY 'nb_country';

SELECT 
	co.country_code
	,co.country_name
	,ci1.city_name
--	,ci2.city_name --decomenter pour voir les doublon
	,COUNT (ci1.country_code) AS 'nb_country'
FROM countries AS co
JOIN cities AS ci1 ON ci1.country_code = co.country_code
JOIN cities AS ci2 ON ci2.country_code = co.country_code --Cree des doublon
--JOIN cities AS ci3 ON ci3.country_code = co.country_code --Permet de multiplier par le carré en recréant des doublon
GROUP BY 	
	co.country_code
	,co.country_name
	,ci1.city_name
--	,ci2.city_name --decomenter pour voir les doublon 
ORDER BY 'nb_country' DESC;

--Sous requette de Rodolphe
SELECT cities.*, countries.country_name, c.nbCities AS 'Number of cities' FROM cities 
INNER JOIN countries ON countries.country_code = cities.country_code
INNER JOIN (
	SELECT cities.country_code, COUNT(*) AS nbCities 
	FROM cities 
	INNER JOIN countries ON cities.country_code = countries.country_code 
	GROUP BY cities.country_code) 
AS c ON cities.country_code = c.country_code
ORDER BY nbCities DESC;