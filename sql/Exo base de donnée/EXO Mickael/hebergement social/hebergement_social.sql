DROP TABLE IF EXISTS people;
DROP TABLE IF EXISTS roles;

CREATE TABLE roles
(
	role_id INT,
	role_name VARCHAR(50) NOT NULL,
	PRIMARY KEY(role_id)
);

CREATE TABLE people
(
	person_id INT,
    person_lastname VARCHAR(255) NOT NULL,
    person_firstname VARCHAR(50) NOT NULL,
    person_birthdate DATE NOT NULL,
    person_hiredate DATE NULL,
    person_active BOOLEAN NOT NULL,
	role_id INT NOT NULL,
	PRIMARY KEY(person_id),
	FOREIGN KEY (role_id)REFERENCES roles(role_id)
);

INSERT INTO roles
(role_id,role_name)
VALUES
(1,'directeur'),
(2,'gardien'),
(3,'cuisinier'),
(4,'technicien'),
(5,'éducateur'),
(6,'médecin'),
(7,'résident');

INSERT INTO people 
VALUES 
(1,'DEV','MIKE','1980-02-23','2017-08-27', true, 1),
(2,'DIN','ALFRED','1985-03-25',NULL, true, 3),
(3,'TOOT','HELENE','1990-01-30',NULL, true, 2);

SELECT person_lastname, person_firstname,role_name 
FROM people
--INNER JOIN roles ON people.role_id = roles.role_id
NATURAL JOIN roles
WHERE role_id<3