--###### Avec sous requete
SELECT  plane_maker , plan_cap.plane_ref, MAX(plan_cap.plane_capacity) AS capacity , plan_aut.plane_ref, MAX(plan_aut.plane_autonomy) AS autonomy
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
HAVING  MAX(p1.plane_capacity)=p1.plane_capacity AND  p2.plane_autonomy=MAX(p2.plane_autonomy)
ORDER BY plane_maker ASC, p1.plane_capacity DESC, p2.plane_autonomy DESC;