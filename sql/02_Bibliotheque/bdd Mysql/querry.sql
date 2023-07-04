SELECT 
	C1.*,
	E1.*,
    COUNT(E2.client_id) AS nb_emprunt
FROM CLIENTS AS C1
NATURAL JOIN EMPRUNTS AS E1
INNER JOIN EMPRUNTS AS E2 ON C1.client_id = E2.client_id
GROUP BY C1.client_id,E1.emprunt_date_pret,E1.client_id,E1.livre_isbn;