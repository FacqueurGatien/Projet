--Selectionner, l'identifiant de la personne, l'identifiant du role, le nom et prenom de la personne
--à partir de la table "people" où le role_id est égal à 5.

--Sélectionner tous les éducateurs.
SELECT person_id , person_lastname , person_firstname , person_birthdate , role_id 
FROM PEOPLE 
WHERE role_id=5;

--Sélectionner tous les employés autre que le directeur.
SELECT person_id , person_lastname , person_firstname , person_birthdate , role_id
FROM PEOPLE
WHERE role_id NOT IN (1)
--WHERE role_id !=1;
ORDER BY role_id;

--Sélectionner toutes les personnes triées par rôle puis par nom.
SELECT * 
FROM PEOPLE
ORDER BY role_id , person_lastname;

--Sélectionner tous les rôles avec le nombre de personnes associées à chaque rôle.
SELECT ROLES.role_id , role_name , COUNT (role_name) AS nb
FROM ROLES
NATURAL JOIN PEOPLE
GROUP BY role_name,ROLES.role_id
ORDER BY nb , ROLES.role_id;

SELECT 
	residents.person_id ,
	people_person.person_firstname as person_name,
	roles_person.role_name as person_role, 
	residents.doctor_id , 
	people_doctor.person_firstname as doctor_name ,
	people_doctor.person_lastname,
	roles_doctor.role_name as doctor_role
FROM residents
LEFT JOIN people as people_doctor ON residents.doctor_id = people_doctor.person_id
LEFT JOIN roles as roles_doctor on people_doctor.role_id = roles_doctor.role_id
LEFT JOIN people as people_person ON residents.person_id = people_person.person_id
LEFT JOIN roles as roles_person on people_person.role_id = roles_person.role_id
ORDER BY person_name ASC;


--##### Requette demandé par MICKAEL
--1 Sélectionner tous les résidents actifs du plus jeune au plus âgé
SELECT *
FROM RESIDENTS
WHERE resident_leave_date IS NOT NULL;

--2 Sélectionner tous les résidents suivis par un médecin avec nom et prénom du médecin attiré
SELECT 
	P_RE.person_id AS id_du_resident
	, P_RE.person_lastname AS nom_du_resident
	, P_RE.person_firstname AS prenom_du_resident
	, RE.resident_arrival_date AS date_d_arrive_du_resident
	, P_DR.person_id AS id_du_docteur
	, P_DR.person_lastname AS nom_du_docteur
	, P_DR.person_firstname AS prenom_du_docteur
FROM RESIDENTS AS RE
INNER JOIN PEOPLE AS P_RE ON P_RE.person_id = RE.person_id
INNER JOIN PEOPLE AS P_DR ON P_DR.person_id = RE.doctor_id;

--3 Sélectionner tous les médecins avec le nombre de résidents qu'ils suivent.
SELECT 
	DR.* 
	, COUNT (RE.*) AS nombre_de_residant_suivit_par_ce_medecin
FROM PEOPLE AS DR 
INNER JOIN RESIDENTS AS RE ON RE.doctor_id = DR.person_id
WHERE DR.role_id = (SELECT DISTINCT role_id FROM ROLES WHERE role_name = 'médecin')
GROUP BY DR.person_id;

--4 Sélectionner les activités en cours.
SELECT 
	event_id
	--, activity_label
	, event_activity_start
	, event_activity_end
	, event_state
FROM EVENTS
--NATURAL JOIN ACTIVITIES
WHERE event_state = true 
	AND event_date_activity = CURRENT_DATE
	AND event_activity_start  < CURRENT_TIME 
	AND event_activity_end > CURRENT_TIME;

--5 Sélectionner les activités dont le nombre d'inscription a atteint le maximum.


--6 Sélectionner les activités dont le nombre d'inscription est inferieur au minimum requis.


--7 Sélectionner les activités dont le nombre de places disponibles est inferieur au quart du maximum.


--8 Sélectionner les activités futures avec le nombre d'inscits par activité.

