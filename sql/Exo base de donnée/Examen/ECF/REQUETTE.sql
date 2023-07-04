--1. Sélectionner toutes les informations des legumes triés par nom du légume (ordre alphabetique).
SELECT 
	VegId 
	, Name 
	, Variety 
	, PrimaryColor 
	, LifeTime 
	, Fresh
FROM VEGETABLES
ORDER BY Name;
;

--2. Sélectionner les nom et le prix des legumes.
-- Pour chaque variété de legume, afficher le nombre de ventes ainsi que le poids total vendu.
-- Les légumes sont triés par nombre de ventes.
SELECT 
	VEGETABLES.Name
	, SALES.SaleUnitPrice
	, COUNT (SALES.SaleId) AS Total_sales
	, COUNT (VEGETABLES.variety) AS Total_variety
	, SUM (SALES.SaleWeight) AS Total_weight
FROM VEGETABLES
NATURAL LEFT JOIN SALES
INNER JOIN VEGETABLES AS V2 ON V2.variety = VEGETABLES.variety
GROUP BY VEGETABLES.VegId , SALES.SaleUnitPrice
;

--3. Sélectionner toutes les information des légumes
-- -a. Dont le nom contient la chaine << on >> 
--	OU
-- -b. Dont la couleur principale est verte (green).
SELECT 
	VegId 
	, Name 
	, Variety 
	, PrimaryColor 
	, LifeTime 
	, Fresh
FROM VEGETABLES
WHERE Name Like '%on%' AND PrimaryColor != 'green' OR Name NOT Like '%on%' AND PrimaryColor = 'green'
;


--4. Sélectionner pour chaque légume:
--	-a. Son nom. -b. Sa variété. 
--	-c. La somme total des ventes pour la variété de ce légume. 
--	-d. Le poids moyen d'une vente. 
--	-e. Le poids et le prix de la vente la plus élévée.
SELECT
	DISTINCT ON (Name)
	Name 
	,VEGETABLES.vegid
	, Variety 
	, SUM(S1.SaleWeight * S1.SaleUnitPrice) AS tot_price_sell
	, AVG (S1.SaleWeight) AS avg_weight_sale
	, S2.SaleWeight AS best_weight_sale 
	, MAX (S2.SaleWeight * S1.SaleUnitPrice)  AS best_sell_price
	,S1.SaleUnitPrice
FROM VEGETABLES
NATURAL JOIN SALES AS S1
INNER JOIN SALES AS S2 ON S2.vegid = VEGETABLES.vegid
GROUP BY VEGETABLES.VegId , S2.SaleWeight , S1.SaleUnitPrice
ORDER BY Name ASC,(S1.SaleUnitPrice*S2.SaleWeight) DESC
;
