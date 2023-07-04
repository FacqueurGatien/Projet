CREATE OR REPLACE FUNCTION emp_stamp() RETURNS trigger AS $test$
    BEGIN
        -- Verifie que nom_employe et salary sont donnés
        IF NEW.emp_salary <20000 THEN
            RAISE EXCEPTION 'Le salaire ne peut etre en dessous de 20 000';
        END IF;
	RETURN NEW;
    END;
$test$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER emp_stamp 
BEFORE INSERT OR UPDATE ON EMPLOYEES
    FOR EACH ROW 
	EXECUTE FUNCTION emp_stamp();
/*
UPDATE EMPLOYEES
SET emp_salary = 85000
WHERE emp_id = 13;

INSERT INTO employees
(emp_lastname , emp_firstname , emp_salary , emp_hiredate, emp_manager_id)
VALUES
('tom','jerry',63000,'2022-01-01',1);

SELECT * FROM EMPLOYEES ORDER BY emp_id;
*/