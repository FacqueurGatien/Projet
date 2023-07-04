--1. Obtenir l’utilisateur ayant le prénom “Muriel” et le mot de passe “test11”, sachant que l’encodage du mot de passe est 
-- effectué avec l’algorithme Sha1.

SELECT 
	*
FROM CLIENT AS C
WHERE C.prenom='Muriel' AND C.[password]=CONVERT(VARCHAR(255),HASHBYTES('SHA1','test11'),2);


-- 2. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes.

SELECT
	CL.nom
FROM COMMANDE_LIGNE AS CL
JOIN COMMANDE AS C ON C.id = CL.commande_id
GROUP BY CL.nom
HAVING COUNT(*) > 1
ORDER BY CL.nom ASC;


-- 3. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes et y ajouter une colonne qui liste les 
-- identifiants des commandes associées.

SELECT
	CL.nom
	,COUNT(*) AS 'Nombre d''occurence'
	,STRING_AGG(CL.id,';')
FROM COMMANDE_LIGNE AS CL
JOIN COMMANDE AS C ON C.id = CL.commande_id
GROUP BY CL.nom
HAVING COUNT(*) > 1
ORDER BY CL.nom ASC;

-- ALTERNATIVE
SELECT 
    DISTINCT(CL.nom)
	,(SELECT COUNT (*) FROM COMMANDE_LIGNE AS CLT JOIN COMMANDE AS CT ON CLT.commande_id = CT.id WHERE CLT.nom=CL.nom GROUP BY CLT.nom) AS nombre_occurence
	,CL.id
FROM COMMANDE AS C
JOIN COMMANDE_LIGNE AS CL ON C.id = CL.commande_id
GROUP BY CL.nom , CL.id
HAVING((SELECT COUNT (*) FROM COMMANDE_LIGNE AS CLT JOIN COMMANDE AS CT ON CLT.commande_id = CT.id WHERE CLT.nom=CL.nom GROUP BY CLT.nom))>1
ORDER BY CL.nom ASC;


-- 4. Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité.

UPDATE COMMANDE_LIGNE
SET COMMANDE_LIGNE.prix_total = COMMANDE_LIGNE.quantite * COMMANDE_LIGNE.prix_unitaire


-- 5. Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le 
-- prénom et nom du client associé.

SELECT
	C.id
	,C.date_achat
	,C.reference
	,CLI.prenom
	,CLI.nom;
	,SUM(CL.prix_total) AS 'Prix de la commande'
FROM COMMANDE AS C
JOIN COMMANDE_LIGNE AS CL ON CL.commande_id = C.id
JOIN CLIENT AS CLI ON CLI.id = C.client_id
GROUP BY 
	C.id
	,C.date_achat
	,C.reference
	,CLI.prenom
	,CLI.nom;


-- 6. (Difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”.

UPDATE COMMANDE
SET COMMANDE.cache_prix_total = (SELECT SUM(CL.prix_total) FROM COMMANDE_LIGNE AS CL WHERE CL.commande_id=COMMANDE.id)


-- 7. Obtenir le montant global de toutes les commandes, pour chaque mois.

SELECT 
	YEAR(C.date_achat)
	,DATENAME(MONTH,C.date_achat)
	,SUM(C.cache_prix_total) AS 'Prix total des commandes'
FROM COMMANDE AS C
GROUP BY 
	YEAR(C.date_achat)
	,MONTH(C.date_achat)
	,DATENAME(MONTH,C.date_achat)
ORDER BY MONTH(C.date_achat) ASC;


-- 8. Obtenir la liste des 10 clients qui ont effectué le plus grand montant de commandes, et obtenir ce montant total pour 
-- chaque client.

SELECT TOP(10)
	CLI.nom
	,CLI.prenom
	,C.cache_prix_total
FROM COMMANDE AS C
JOIN CLIENT AS CLI ON CLI.id = C.client_id
ORDER BY C.cache_prix_total DESC;


-- 9. Obtenir le montant total des commandes pour chaque date.SELECT 
	C.date_achat
	,SUM(C.cache_prix_total) AS 'Prix total des commandes'
	,STRING_AGG(C.id , ';')
FROM COMMANDE AS CGROUP BY C.date_achatORDER BY C.date_achat;