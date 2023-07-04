SELECT 
	C.cassette_id,
	F.film_titre,
	S.magasin_id,
	A.acteur_nom,
	A.acteur_prenom,
	P.personnage_nom,
	P.personnage_prenom
FROM CASSETTES AS C
INNER JOIN FILMS AS F ON F.film_id = C.film_id
INNER JOIN STOCKES AS S ON S.cassette_id = C.cassette_id
INNER JOIN PERSONNAGES AS P ON P.film_id = F.film_id
INNER JOIN ACTEURS AS A ON A.acteur_id = P.acteur_id
WHERE S.magasin_id = 2 OR S.magasin_id = 5;

SELECT 
	C.client_nom,
	C.client_prenom,
	A.adresse_num,
	A.adresse_voie,
	A.adresse_cp,
	A.adresse_ville,
	F.film_titre
FROM CLIENTS AS C
INNER JOIN EMPRUNTS AS E ON C.client_id = E.client_id
INNER JOIN CASSETTES AS CA ON CA.cassette_id = E.cassette_id
INNER JOIN FILMS AS F ON F.film_id = CA.film_id
INNER JOIN ADRESSES AS A ON A.adresse_id = C.adresse_id
ORDER BY C.client_nom ASC;