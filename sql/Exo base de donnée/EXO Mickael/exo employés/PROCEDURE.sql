CREATE OR REPLACE PROCEDURE insert_employees
(
	lastname VARCHAR(50),
	firstname VARCHAR(50),
	salary INT,
	hiredate DATE
)

LANGUAGE plpgsql
AS $$

BEGIN
	INSERT INTO EMPLOYEES
	(emp_lastname , emp_firstname , emp_salary , emp_hiredate)
	VALUES
	(lastname , firstname , salary , hiredate );
END$$;

CREATE OR REPLACE PROCEDURE add_manager
(
	_emp_id	INT,
	_manager_id INT
)

LANGUAGE plpgsql
AS $$

BEGIN
	UPDATE EMPLOYEES 
	SET emp_manager_id = _manager_id 
	WHERE emp_id = _emp_id;
END$$;