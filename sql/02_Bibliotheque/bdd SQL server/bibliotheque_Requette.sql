SELECT 
	C1.*,
	E1.*,
    COUNT(E2.client_id) AS nb_emprunt
FROM CLIENTS AS C1
INNER JOIN EMPRUNTS AS E1 ON E1.client_id = C1.client_id
INNER JOIN EMPRUNTS AS E2 ON C1.client_id = E2.client_id
GROUP BY C1.client_id,E1.emprunt_date_pret,E1.client_id,E1.livre_id,C1.client_nom,C1.client_prenom,C1.client_caution,C1.adresse_id,E1.emprunt_date_retour;