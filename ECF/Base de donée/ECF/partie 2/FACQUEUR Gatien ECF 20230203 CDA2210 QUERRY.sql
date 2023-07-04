--1. S�lectionner tous les micro-processeur tri�s par valeur commerciale (product_value).

SELECT 
	P.product_id
	,P.product_name
	,P.product_value
FROM PRODUCTS AS P
ORDER BY P.product_value ASC;


--2. S�lectionner les CPUs dont le nom se termine par la lettre << X >>.

SELECT 
	P.product_id
	,P.product_name
FROM PRODUCTS AS P
WHERE P.product_name LIKE '%X';


--3. S�lectionner les lignes de production dont le libell� contient la chaine << PR >>.

SELECT 
	PL.line_id
	,PL.line_label
FROM PRODUCTION_LINES AS PL
WHERE PL.line_label LIKE '%PR%';


--4. S�lectionnez le nom, le prix detous les microprocesseurs. Pour chaque CPU list�, on doit connaitre le libell� de la ligne de production associ�e.

SELECT 
	P.product_name
	,P.product_value
	,PL.line_label
FROM PRODUCTS AS P
JOIN PRODUCTION_LINES AS PL ON PL.product_id = P.product_id
ORDER BY P.product_value ASC;


--5. S�lectionner les productions termin�es dont le nombre de CPU produits d�passe 20. La requ�te doit retourner le nom du CPU, son prix, le libell� de la ligne de production et le nombre d'unit�s produites.

SELECT 
	PD.forge_id
	,P.product_name
	,P.product_value
	,PL.line_label
	,PD.forge_quantity
FROM PRODUCTION_DONE AS PD
JOIN PRODUCTS AS P ON PD.product_id = P.product_id
JOIN PRODUCTION_LINES AS PL ON PL.product_id = P.product_id
WHERE PD.forge_quantity >20;


--6. S�lectionner toutes les lignes de productions (identifiant, libell�) avec le nombre TOTAL d'unit�s produites par ligne de production ainsi que l'identifiant du CPU associ�.

SELECT 
	PL.line_id
	,PL.line_label
	,SUM(PD.forge_quantity) AS 'Nombre total d''unit� produite par ligne'
	,P.product_id
FROM PRODUCTION_LINES AS PL
LEFT JOIN PRODUCTION_DONE AS PD ON PD.line_id = PL.line_id
LEFT JOIN PRODUCTS AS P ON P.product_id = PD.product_id
GROUP BY 	
	PL.line_id
	,PL.line_label
	,P.product_id;

--7. M�me requ�te que la pr�c�dente mais en ne s�lectionnant que les lignes de production qui ont produit au moins 1 unit�.

SELECT 
	PL.line_id
	,PL.line_label
	,P.product_id
	,SUM(PD.forge_quantity) AS 'Nombre total d''unit� produite par ligne'
FROM PRODUCTION_LINES AS PL
JOIN PRODUCTION_DONE AS PD ON PD.line_id = PL.line_id
JOIN PRODUCTS AS P ON P.product_id = PD.product_id
GROUP BY 	
	PL.line_id
	,PL.line_label
	,P.product_id;

-- ALTERNATIVE

SELECT 
	PL.line_id
	,PL.line_label
	,P.product_id
	,SUM(PD.forge_quantity) AS 'Nombre total d''unit� produite par ligne'
FROM PRODUCTION_LINES AS PL
LEFT JOIN PRODUCTION_DONE AS PD ON PD.line_id = PL.line_id
LEFT JOIN PRODUCTS AS P ON P.product_id = PD.product_id
WHERE PD.forge_quantity > 0
GROUP BY 	
	PL.line_id
	,PL.line_label
	,P.product_id;


--8. Afficher la valeur total de tous les CPUs d�j� produits avec le nom du CPU ayant rapport� le plus, toutes productions confondues.

SELECT 
	SUM(PD.forge_quantity*P.product_value) AS 'PRODS_TOTAL_VALUE' 
	,
	(SELECT TOP 1
			P.product_name
		FROM PRODUCTION_LINES AS PL
		JOIN PRODUCTION_DONE AS PD ON PD.line_id = PL.line_id
		JOIN PRODUCTS AS P ON P.product_id = PD.product_id
		GROUP BY 	
			PL.line_id
			,PL.line_label
			,P.product_name
			,P.product_value
		ORDER BY (SUM(PD.forge_quantity)*P.product_value) DESC
	) AS 'MOST_PROFITABLE_ITEM'
FROM PRODUCTION_LINES AS PL
JOIN PRODUCTION_DONE AS PD ON PD.line_id = PL.line_id
JOIN PRODUCTS AS P ON P.product_id = PD.product_id;