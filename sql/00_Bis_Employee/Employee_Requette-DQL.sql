--1.Sélectionner le nom, prénom et salairede tous les employés triés par date d’embauche de la plus ancienneà laplus récente.
SELECT 
	E.emp_lastname
	,E.emp_firstname
	,E.emp_salary
FROM employees AS E
ORDER BY E.emp_hiredate ASC;

--2.Sélectionner le nom, salaire, date d’embauchede tous les employés triés par identifiant de manager (croissant) puis par nom (ordre alphabétique).
SELECT
	E.emp_lastname
	,E.emp_salary
	,E.emp_hiredate
FROM employees AS E
ORDER BY E.emp_manager_id ASC , E.emp_lastname ASC;

--3.Sélectionner le nom, prénom, salaire, date d’embauche, nom et prénom du manager de tous les employés.Trier la liste par nom de manager (ordre croissant) puis par date d’embauche de la plus récente à la plus ancienne.
SELECT 
	E.emp_lastname AS employees_lastname
	,E.emp_firstname AS employees_firstname
	,E.emp_salary AS employees_salary
	,E.emp_hiredate AS employees_hiredate
	,M.emp_lastname AS manager_lastname
	,M.emp_firstname AS manager_firstname
 FROM employees AS E
 LEFT JOIN employees AS M ON M.emp_id = E.emp_manager_id
 ORDER BY M.emp_lastname ASC , E.emp_hiredate DESC;

--4.Sélectionner les employés sans manager.
SELECT 
	*
FROM employees AS E
WHERE E.emp_manager_id IS NULL;

--5.Sélectionner le prénom et nom de tous les managers avec, pour chacun,le nombre de leur subordonnés.Les managers avec le moinsde subordonnés apparaissent en 1er.
 SELECT 
	M.emp_lastname AS manager_lastname
	,M.emp_firstname AS manager_firstname
	,COUNT (*) AS nb_emp
FROM employees AS M
JOIN employees AS E ON E.emp_manager_id = M.emp_id
GROUP BY 
	M.emp_lastname
	,M.emp_firstname
ORDER BY nb_emp ASC;

--Alternative
 SELECT 
	M.emp_lastname AS manager_lastname
	,M.emp_firstname AS manager_firstname
	,(SELECT 
		COUNT(*) 
	FROM employees AS E2 
	WHERE E2.emp_manager_id = E.emp_manager_id
	) AS nb_emp
FROM employees AS M
JOIN employees AS E ON E.emp_manager_id = M.emp_id
GROUP BY 
	M.emp_lastname
	,M.emp_firstname
	,E.emp_manager_id
ORDER BY nb_emp ASC;

--6.Sélectionner le nom de tous les managers avec, pour chacun,la moyenne des salaires de leur subordonnés.Trier le résultat selon la valeur de la moyenne par ordre décroissant.
 SELECT 
	M.emp_lastname AS manager_lastname
	,M.emp_firstname AS manager_firstname
	,AVG (E.emp_salary) AS average_salary_emp
FROM employees AS M
JOIN employees AS E ON E.emp_manager_id = M.emp_id
GROUP BY 
	M.emp_lastname
	,M.emp_firstname
ORDER BY average_salary_emp DESC;

SELECT
	*
FROM employees AS E
ORDER BY E.emp_salary;

--Alternative
 SELECT 
	M.emp_lastname AS manager_lastname
	,M.emp_firstname AS manager_firstname
	,(SELECT 
		AVG(E2.emp_salary) 
	FROM employees AS E2 
	WHERE E2.emp_manager_id = M.emp_id
	) AS salary_average
FROM employees AS M
JOIN employees AS E ON E.emp_manager_id = M.emp_id
GROUP BY 
	M.emp_lastname
	,M.emp_firstname
	,E.emp_manager_id
	,M.emp_id
ORDER BY salary_average DESC;

--7.Créer la requête SELECT correspondant au résultatsuivant:(voir pdf)
SELECT 
	M.emp_id AS 'Employee Id'
	,M.emp_lastname AS Lastname
	,M.emp_firstname AS Firstname
	,M.emp_salary AS Salary
	,M.emp_hiredate AS Hiredate
	,COUNT (*) AS 'Number of Employees'
	,SUM (E.emp_salary) AS 'Total Salary'
	,AVG (E.emp_salary) AS 'Average Salary'
FROM employees AS M
JOIN employees AS E ON 1 = M.emp_id
WHERE E.emp_id <> 1
GROUP BY 	
	M.emp_id
	,M.emp_lastname
	,M.emp_firstname
	,M.emp_salary
	,M.emp_hiredate;


SELECT 
	M.emp_id AS 'Employee Id'
	,M.emp_lastname AS Lastname
	,M.emp_firstname AS Firstname
	,M.emp_salary AS Salary
	,M.emp_hiredate AS Hiredate
	,COUNT (*) AS 'Number of Employees'
	,SUM (E.emp_salary) AS 'Total Salary'
	,AVG (E.emp_salary) AS 'Average Salary'
FROM employees AS M
JOIN employees AS E ON (SELECT D.emp_id FROM employees AS D WHERE D.emp_manager_id IS NULL) = M.emp_id
WHERE E.emp_id <> (SELECT D.emp_id FROM employees AS D WHERE D.emp_manager_id IS NULL)
GROUP BY 	
	M.emp_id
	,M.emp_lastname
	,M.emp_firstname
	,M.emp_salary
	,M.emp_hiredate;

