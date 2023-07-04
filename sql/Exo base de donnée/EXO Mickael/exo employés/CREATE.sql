DROP TABLE IF EXISTS EMPLOYEES;

CREATE TABLE EMPLOYEES
(
	emp_id SERIAL PRIMARY KEY,
	emp_lastname VARCHAR(50) NOT NULL,
	emp_firstname VARCHAR(50) NOT NULL,
	emp_salary INT NOT NULL CHECK (emp_salary > 0),
	emp_hiredate DATE NOT NULL,
	emp_manager_id INT NULL
);

ALTER TABLE EMPLOYEES
ADD CONSTRAINT FK_EMPLOYEES_employees_EMPLOYEES_manager
FOREIGN KEY (emp_manager_id) 
REFERENCES EMPLOYEES (emp_id);
