--Sélectionner le nom, prénom et salaire de tous les employés 
--triés par date d’embauche de la plus ancienne à la plus récente
SELECT emp_lastname , emp_firstname , emp_salary
FROM EMPLOYEES
ORDER BY emp_hiredate ASC;

--Sélectionner le nom, salaire, date d’embauche de tous les employés 
--triés par identifiant de manager (croissant) puis par nom (ordre alphabétique).
SELECT emp_lastname , emp_salary , emp_hiredate
FROM EMPLOYEES
ORDER BY emp_manager_id ASC , emp_lastname ASC;

--Sélectionner le nom, prénom, salaire, date d’embauche, nom et prénom du manager de tous les employés. 
--Trier la liste par nom de manager (ordre croissant) 
--puis par date d’embauche de la plus réceusnte à la plus ancienne.
SELECT 
	EMPLOYEES.emp_lastname , EMPLOYEES.emp_firstname , EMPLOYEES.emp_salary , EMPLOYEES.emp_hiredate , 
	MANAGER.emp_lastname , MANAGER.emp_firstname
FROM EMPLOYEES 
INNER JOIN EMPLOYEES AS MANAGER ON EMPLOYEES.emp_manager_id = MANAGER.emp_id;

--Sélectionner les employés sans manager
SELECT * 
FROM EMPLOYEES 
WHERE emp_manager_id IS NULL;

--Sélectionner le prénom et nom de tous les managers avec, pour chacun, le nombre de leur subordonnés. 
--Les managers avec le moins de subordonnés apparaissent en 1er
SELECT MANAGER.emp_lastname , MANAGER.emp_firstname , COUNT (EMPLOYEES.emp_id) AS nb_sub
FROM EMPLOYEES AS MANAGER
INNER JOIN EMPLOYEES ON EMPLOYEES.emp_manager_id = MANAGER.emp_id
GROUP BY  MANAGER.emp_lastname , MANAGER.emp_firstname
ORDER BY nb_sub ASC;

--Sélectionner le nom de tous les managers avec, pour chacun, la moyenne des salaires de leur subordonnés. 
--Trier le résultat selon la valeur de la moyenne par ordre décroissant.
SELECT MANAGER.emp_lastname , MANAGER.emp_firstname AS nb_sub, AVG(EMPLOYEES.emp_salary)
FROM EMPLOYEES AS MANAGER
INNER JOIN EMPLOYEES ON EMPLOYEES.emp_manager_id = MANAGER.emp_id
GROUP BY  MANAGER.emp_lastname , MANAGER.emp_firstname
ORDER BY nb_sub ASC;

--Créer la requête SELECT correspondant au résultat suivant :
SELECT 
	EMPLOYEES.emp_id,EMPLOYEES.emp_lastname ,EMPLOYEES.emp_firstname ,EMPLOYEES.emp_salary,EMPLOYEES.emp_hiredate, 
	(SELECT COUNT(*) AS nb FROM EMPLOYEES WHERE emp_manager_id IS NOT NULL),
	(SELECT SUM(emp_salary) AS total_salary FROM EMPLOYEES WHERE emp_manager_id IS NOT NULL),
	(SELECT AVG(emp_salary) AS average_salary FROM EMPLOYEES WHERE emp_manager_id IS NOT NULL)
FROM EMPLOYEES
WHERE EMPLOYEES.emp_manager_id IS NULL
GROUP BY EMPLOYEES.emp_id;

--Créer la requête SELECT correspondant au résultat suivant :
--ALTERNATIVE
SELECT 
	DIRECTOR.emp_id,DIRECTOR.emp_lastname,DIRECTOR.emp_firstname,DIRECTOR.emp_salary, DIRECTOR.emp_hiredate,COUNT(EMPLOYEES.*),SUM(EMPLOYEES.emp_salary),AVG(EMPLOYEES.emp_salary)
FROM EMPLOYEES AS DIRECTOR 
INNER JOIN EMPLOYEES ON EMPLOYEES.emp_id <> DIRECTOR.emp_id
WHERE DIRECTOR.emp_manager_id IS NULL
GROUP BY DIRECTOR.emp_id;