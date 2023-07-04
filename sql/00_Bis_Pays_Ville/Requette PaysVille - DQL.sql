SELECT 
	ci.city_name
FROM cities AS ci

SELECT 
	ci.city_id
	,ci.city_name
FROM cities AS ci
ORDER BY ci.city_name;

SELECT 
	ci.city_name AS 'Nom de la ville'
	,co.country_name AS 'Nom du pays'
	,co.country_code AS 'Code ISO du pays'
FROM cities AS ci
JOIN countries AS co ON co.country_code = ci.country_code
ORDER BY co.country_code DESC;

SELECT 
	co.country_code
	,co.country_name
	,COUNT (*) AS 'nb country'
FROM countries AS co
JOIN cities AS ci ON ci.country_code = co.country_code
GROUP BY 	
	co.country_code
	,co.country_name
ORDER BY 'nb country';
