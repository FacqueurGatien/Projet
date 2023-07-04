SELECT 
	F.film_titre,
	R.realisateur_nom,
	R.realisateur_prenom,
	A.acteur_nom,
	A.acteur_prenom,
	P.personnage_nom,
	P.personnage_prenom,
	COUNT (P2.film_id)
FROM FILMS AS F
INNER JOIN PERSONNAGES AS P2 ON P2.film_id = F.film_id
INNER JOIN REALISATEURS AS R ON R.realisateur_id = F.realisateur_id
INNER JOIN PERSONNAGES AS P ON P.film_id = F.film_id
INNER JOIN ACTEURS AS A ON A.acteur_id = P.acteur_id
GROUP BY F.film_titre,R.realisateur_nom,R.realisateur_prenom,A.acteur_nom,A.acteur_prenom,P.personnage_nom,P.personnage_prenom;

SELECT 
	F.film_titre,
	R.realisateur_nom,
	R.realisateur_prenom,
	COUNT (P2.acteur_id) AS nb_acteur
FROM FILMS AS F
INNER JOIN PERSONNAGES AS P2 ON P2.film_id = F.film_id
INNER JOIN REALISATEURS AS R ON R.realisateur_id = F.realisateur_id
INNER JOIN PERSONNAGES AS P ON P.film_id = F.film_id
INNER JOIN ACTEURS AS A ON A.acteur_id = P.acteur_id
WHERE P2.acteur_id = A.acteur_id
GROUP BY F.film_titre,R.realisateur_nom,R.realisateur_prenom;