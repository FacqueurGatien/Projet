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
SELECT planes.* --, manufacturers.plane_maker
FROM planes
NATURAL JOIN manufacturers
WHERE plane_maker LIKE 'B%';

--d. Sélectionner toutes les informations des avions dont la vitesse est supérieur à 1000 kms/h et dont la capacité dépasse 10 passagers.
SELECT planes.* --, manufacturers.plane_maker
FROM planes
NATURAL JOIN manufacturers
WHERE plane_speed > 1000 AND plane_capacity > 10;

--e. Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, le nombre d'avions et la vitesse moyenne de la flotte.
-- Les fabricants poss'dant le moin d'avions apparaissent en premier.
SELECT plane_maker , COUNT (plane_ref) AS nombre_d_avion , AVG (plane_speed) AS vitesse_moyenne_de_la_flotte
FROM manufacturers
NATURAL JOIN planes
GROUP BY plane_maker;

--f. Sélectionner le nom de tous les fabricants avec, pour chacun d'entre eux, 
-- le nom et la capacité de l'avion pouvant accueillir le plus de passagers 
-- ainsi que le nom et l'autonomie de l'avion pouvant parcourir le plus de kilomètres.

SELECT plane_maker, planes.plane_ref , MAX (planes.plane_capacity) AS capacity, MAX (planes.plane_autonomy) AS autonomy
FROM manufacturers
NATURAL JOIN planes
INNER JOIN planes AS planes2 ON planes.plane_maker_id = planes2.plane_maker_id
WHERE planes.plane_autonomy= (SELECT MAX(plane_autonomy) FROM planes WHERE planes.plane_maker_id = planes2.plane_maker_id)	
OR planes.plane_capacity= (SELECT MAX(plane_capacity) FROM planes WHERE planes.plane_maker_id = planes2.plane_maker_id)		
GROUP BY plane_maker, planes.plane_ref
;

s