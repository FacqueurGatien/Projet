--a. Sélectionner la référence, l'autonomie et la vitesse de tous les avions, triés du plus rapide au plus lent.
SELECT plane_ref , plane_autonomy , plane_speed
FROM planes
ORDER BY plane_speed ASC;

--b. Sélectionner la référence, la capacité, l'autonomie et le nom du fabricant de tous les avions.
-- Les avions sont triés par fabricant (croissant) puis par autonomie (décroissant).
SELECT plane_ref , plane_capacity , plane_autonomy , plane_maker
FROM planes
NATURAL JOIN manufacturers
ORDER BY plane_maker ASC , plane_autonomy DESC;

--c. Sélectionner toutes les informations des avions dont le nom du fabricant commence par la lettre << B >>.
SELECT planes.* , manufacturers.plane_maker
FROM planes
NATURAL JOIN manufacturers
WHERE plane_maker LIKE 'B%';

--d. Sélectionner toutes les informations des avions dont la vitesse est supérieur à 1000 kms/h et dont la capacité dépasse 10 passagers.
SELECT planes.* --, manufacturers.plane_maker
FROM planes
--NATURAL JOIN manufacturers
WHERE plane_speed > 1000 AND plane_capacity > 10;

--e. Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, le nombre d'avions et la vitesse moyenne de la flotte.
-- Les fabricants possedant le moin d'avions apparaissent en premier.
--###### Avec jointure
SELECT plane_maker , COUNT (plane_ref) AS nb_planes , AVG (plane_speed) AS speed_average
FROM manufacturers
NATURAL JOIN planes
GROUP BY plane_maker
ORDER BY plane_maker;

--###### Sans jointure
SELECT manufacturers.plane_maker_id , plane_maker , COUNT (plane_ref) AS nb_planes , AVG (plane_speed) AS speed_average
FROM manufacturers,planes
WHERE manufacturers.plane_maker_id = planes.plane_maker_id
GROUP BY manufacturers.plane_maker_id
ORDER BY nb_planes ASC;

--f. Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, 
-- le nom et la capacité de l'avion pouvant accueillir le plus de passagers 
-- ainsi que le nom et l'autonomie de l'avion pouvant parcourir le plus de kilomètres.

--###### Pas dans la meme colonne
SELECT plane_maker, planes.plane_ref , MAX (planes.plane_capacity) AS capacity_plane, MAX (planes.plane_autonomy) AS autonomy_plane
FROM manufacturers
NATURAL JOIN planes
INNER JOIN planes AS planes2 ON planes.plane_maker_id = planes2.plane_maker_id
WHERE planes.plane_autonomy= (SELECT MAX(plane_autonomy) FROM planes WHERE planes.plane_maker_id = planes2.plane_maker_id)	
OR planes.plane_capacity= (SELECT MAX(plane_capacity) FROM planes WHERE planes.plane_maker_id = planes2.plane_maker_id)		
GROUP BY plane_maker, planes.plane_ref;

--###### Avec sous requete
SELECT DISTINCT ON (plan_cap.plane_ref) plane_maker , plan_cap.plane_ref, MAX(plan_cap.plane_capacity) AS capacity , plan_aut.plane_ref, MAX(plan_aut.plane_autonomy) AS autonomy
FROM manufacturers
INNER JOIN planes AS plan_cap ON plan_cap.plane_maker_id = manufacturers.plane_maker_id
INNER JOIN planes AS plan_aut ON plan_aut.plane_maker_id = manufacturers.plane_maker_id
	WHERE plan_cap.plane_capacity = (SELECT MAX(plane_capacity) FROM planes WHERE plan_cap.plane_maker_id = planes.plane_maker_id) 
	AND plan_aut.plane_autonomy = (SELECT MAX(plane_autonomy) FROM planes WHERE plan_aut.plane_maker_id = planes.plane_maker_id)
GROUP BY plane_maker , plan_cap.plane_ref , plan_aut.plane_ref;

--###### Sans sous requete
SELECT DISTINCT ON
(plane_maker) plane_maker , p1.plane_ref , p1.plane_capacity , p2.plane_ref , p2.plane_autonomy
FROM manufacturers AS m1
INNER JOIN planes AS p1 ON p1.plane_maker_id = m1.plane_maker_id
INNER JOIN planes AS p2 ON p2.plane_maker_id = m1.plane_maker_id
GROUP BY plane_maker,p1.plane_ref,p2.plane_ref
--HAVING  MAX(p1.plane_capacity)=p1.plane_capacity AND  p2.plane_autonomy=MAX(p2.plane_autonomy)
ORDER BY plane_maker ASC, p1.plane_capacity DESC, p2.plane_autonomy DESC;

