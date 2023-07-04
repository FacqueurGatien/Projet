DROP TABLE IF EXISTS EMPLOYEES;

CREATE TABLE employees
(
	emp_id INT IDENTITY
	,emp_lastname VARCHAR(50) NOT NULL
	,emp_firstname VARCHAR(50) NOT NULL
	,emp_salary INT NOT NULL CHECK( emp_salary > 0 )
	,emp_hiredate DATE NOT NULL
	,emp_manager_id INT
);

ALTER TABLE employees
	ADD CONSTRAINT PK_emp PRIMARY KEY (emp_id)
	,CONSTRAINT FK_emp FOREIGN KEY (emp_manager_id) REFERENCES employees (emp_id);