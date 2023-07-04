DROP TABLE IF EXISTS peintres;

CREATE TABLE IF NOT EXISTS peintres
(
	id INT PRIMARY KEY,
	nom VARCHAR(100) NOT NULL,
	prenom VARCHAR(50) DEFAULT 'N/A',
	date_de_naissance DATE NOT NULL,
	date_de_deces DATE,
	total_oeuvres INT CHECK(total_oeuvres >= 0) NOT NULL DEFAULT 1,
	apreciation DECIMAL(3,2)
);

INSERT INTO peintres
( id , nom , prenom , date_de_naissance , date_de_deces , total_oeuvres , apreciation)
VALUES
(1,'picasso','pablo','1881-10-25','1973-04-08',50000,4.9),
(2,'miloudi','moustapha','1980-05-07',NULL,20,4.2),
(3,'lisrin','bastien','1991-02-14',NULL,5,0.7);

SELECT * FROM peintres