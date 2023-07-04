--#### PROCEDURE insert_resident
CREATE OR REPLACE PROCEDURE insert_resident
(	p_id INT,
	lastname VARCHAR(255),
	firstname VARCHAR(50),
	birthdate DATE,
	arrivaldate TIMESTAMP,
 	leavedate TIMESTAMP,
	doctor INT
)

LANGUAGE plpgsql
AS $$

BEGIN
INSERT INTO PEOPLE 
(person_id , person_lastname , person_firstname , person_birthdate , role_id)
VALUES
(p_id , lastname , firstname , birthdate , 0);

INSERT INTO RESIDENTS
(person_id , resident_arrival_date , resident_leave_date , doctor_id)
VALUES
(p_id , arrivaldate , leavedate , doctor);
END $$;

--#### TRIGGER check_educator
CREATE OR REPLACE FUNCTION check_educator() RETURNS trigger AS $test$
    BEGIN
        -- Verifie que l'id de la personne choisi tet bien celui de l'educateur
        IF (SELECT role_id FROM PEOPLE WHERE person_id = NEW.educator_id) <> (SELECT role_id FROM roles WHERE role_name = 'éducateur') THEN
            RAISE EXCEPTION 'La personne choisit pour l organisation de l_activité n est pas un éducateur';
        END IF;
	RETURN NEW;
    END;
$test$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_educ 
BEFORE INSERT OR UPDATE ON EVENTS
    FOR EACH ROW 
	EXECUTE FUNCTION check_educator();

--#### TRIGGER check_register_capacity
CREATE OR REPLACE FUNCTION check_register_capacity() RETURNS trigger AS $test$
    BEGIN
        --Verifie que le nombre de personne inscrit à l'activité ne dépasse pas le maximum autorisé
        IF (SELECT COUNT (*) FROM REGISTER WHERE event_id = NEW.event_id ) >= (SELECT DISTINCT event_cap_max FROM EVENTS WHERE event_id = NEW.event_id)
		THEN
            RAISE EXCEPTION 'L activité est complette';
        END IF;
	RETURN NEW;
    END;
$test$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_reg_cap 
BEFORE INSERT OR UPDATE ON REGISTER
    FOR EACH ROW 
	EXECUTE FUNCTION check_register_capacity();

--#### TRIGGER 