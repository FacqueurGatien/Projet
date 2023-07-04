--Sélectionner le nom de toutes les villes
SELECT city_name 
FROM CITIES;

--Sélectionner l’identifiant et le nom de toutes les villes triées par nom de ville et par ordre alphabétique.
SELECT city_id , city_name
FROM CITIES
ORDER BY city_name;

--Sélectionner toutes les villes avec le nom du pays associé à chaque ville. 
--Trier la liste par code pays et par ordre alphabétique inverse.
SELECT city_name , country_name , CITIES.country_code
FROM CITIES
LEFT JOIN COUNTRIES ON COUNTRIES.country_code = CITIES.country_code
ORDER BY country_code DESC;

--Sélectionner le code ISO et le nom de tous les pays avec le nombre de villes par pays. 
--Les pays avec le moins de villes apparaissent en 1er.
SELECT COUNTRIES.country_code, country_name , COUNT (country_name) AS nb_city
FROM COUNTRIES
LEFT JOIN CITIES ON CITIES.country_code = COUNTRIES.country_code
GROUP BY COUNTRIES.country_code , country_name
ORDER BY nb_city ASC;

--Créer la requête SELECT correspondant au résultat suivant : (cf pdf)
SELECT city_id , city_name , COUNTRY.country_code , COUNTRY.country_name , 
		(SELECT COUNT (country_name) FROM COUNTRIES NATURAL JOIN CITIES WHERE COUNTRIES.country_code = COUNTRY.country_code)
FROM COUNTRIES AS COUNTRY
INNER JOIN CITIES ON COUNTRY.country_code = CITIES.country_code
GROUP BY city_id , COUNTRY.country_code
ORDER BY city_id ASC;

--Créer la requête SELECT correspondant au résultat suivant : (cf pdf)
--ALTERNATIVE
SELECT CITIES.city_id , CITIES.city_name , CITIES.country_code, country_name , COUNT (CITIES.country_code) AS nb_city
FROM COUNTRIES
NATURAL JOIN CITIES
INNER JOIN CITIES AS CITIES2 ON CITIES2.country_code = CITIES.country_code
GROUP BY CITIES.city_id , COUNTRIES.country_code
ORDER BY CITIES.city_id ASC;

--requette pour la question sur sql
SELECT COUNTRIES.country_code , country_name , COUNT (COUNTRIES.country_code) AS nb_city
FROM COUNTRIES
INNER JOIN CITIES ON CITIES.country_code = COUNTRIES.country_code 
GROUP BY COUNTRIES.country_code
HAVING COUNT (COUNTRIES.country_code) >2
ORDER BY nb_city DESC;