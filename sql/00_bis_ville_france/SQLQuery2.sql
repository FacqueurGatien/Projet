--Obtenir la liste des 10 villes les plus peupl�es en 2012

SELECT TOP(10)
	ville_id
	,ville_nom
	,ville_population_2012
FROM VILLES_FRANCE_FREE
ORDER BY ville_population_2012 DESC;


--2. Obtenir la liste des 50 villes ayant la plus faible superficie

SELECT TOP(50)
	ville_id
	,ville_nom
	,ville_surface
FROM VILLES_FRANCE_FREE
ORDER BY ville_surface ASC;


--3. Obtenir la liste des d�partements d�outres-mer, c�est-�-dire ceux dont le num�ro de d�partement commencent par �97�

SELECT
	departement_id
	,departement_nom
	,departement_code
FROM DEPARTEMENT
WHERE departement_code LIKE '97%';


--4. Obtenir le nom des 10 villes les plus peupl�es en 2012, ainsi que le nom du d�partement associ�

SELECT TOP(10)
	V.ville_id
	,V.ville_nom
	,V.ville_population_2012
	,D.departement_code
	,V.ville_code_commune
	,D.departement_nom
FROM VILLES_FRANCE_FREE AS V
JOIN DEPARTEMENT AS D ON D.departement_code = V.ville_departement
ORDER BY ville_population_2012 DESC;


--5. Obtenir la liste du nom de chaque d�partement, associ� � son code et du nombre de commune au sein de ces 
-- d�partement, en triant afin d�obtenir en priorit� les d�partements qui poss�dent le plus de communes

SELECT 
	D.departement_id
	,D.departement_nom
	,COUNT(*) AS 'nombre de ville'
FROM DEPARTEMENT AS D
JOIN VILLES_FRANCE_FREE AS V ON D.departement_code = V.ville_departement
GROUP BY 	
	D.departement_id
	,D.departement_nom
ORDER BY D.departement_id;


--6. Obtenir la liste des 10 plus grands d�partements, en termes de superficie

SELECT TOP(10)
	D.departement_id
	,D.departement_nom
	,SUM(V.ville_surface) AS 'superficie departement'
FROM DEPARTEMENT AS D
JOIN VILLES_FRANCE_FREE AS V ON D.departement_code = V.ville_departement
GROUP BY
	D.departement_id
	,D.departement_nom
ORDER BY 'superficie departement' DESC;

--7. Compter le nombre de villes dont le nom commence par �Saint�

SELECT 
	COUNT(*) AS 'nombre de ville commencant par SAINT'
FROM VILLES_FRANCE_FREE AS V
WHERE V.ville_nom LIKE 'SAINT%';


--8. Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d�obtenir en premier celles dont le nom est 
-- le plus souvent utilis� par plusieurs communes

SELECT 
	V.ville_nom
	,COUNT(*) AS 'nombre d''occurence'
FROM  VILLES_FRANCE_FREE AS V
GROUP BY ville_nom
HAVING COUNT(*) > 1
ORDER BY 'nombre d''occurence' DESC;


--9. Obtenir en une seule requ�te SQL la liste des villes dont la superficie est sup�rieur � la superficie moyenne

SELECT
	V.ville_nom
	,V.ville_surface
FROM VILLES_FRANCE_FREE AS V , VILLES_FRANCE_FREE AS V2
GROUP BY V.ville_surface , V.ville_nom
HAVING AVG(V2.ville_surface) < V.ville_surface
ORDER BY V.ville_surface DESC;


--10. Obtenir la liste des d�partements qui poss�dent plus de 2 millions d�habitants

SELECT 
	D.departement_nom
	,SUM(V.ville_population_2012) AS 'nombre d''habitant'
FROM DEPARTEMENT AS D
JOIN VILLES_FRANCE_FREE AS V ON D.departement_code = V.ville_departement
GROUP BY D.departement_nom
HAVING SUM(V.ville_population_2012) > 2000000;


--11. Remplacez les tirets par un espace vide, pour toutes les villes commen�ant par �SAINT-� (dans la colonne qui contient 
-- les noms en majuscule).

SELECT 
	REPLACE(V.ville_nom,'SAINT-','SAINT ')
FROM VILLES_FRANCE_FREE AS V
WHERE V.ville_nom LIKE 'SAINT%';