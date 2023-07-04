DROP TABLE IF EXISTS PRONOSTIQUES;
DROP TABLE IF EXISTS PARTICIPANTS;
DROP TABLE IF EXISTS PARIS;
DROP TABLE IF EXISTS TYPES_DE_PARI;
DROP TABLE IF EXISTS CHEVAUX;
DROP TABLE IF EXISTS COURSES;

CREATE TABLE COURSES(
   course_id INT IDENTITY,
   course_nom VARCHAR(50) NOT NULL UNIQUE,
   course_debut DATETIME2 NOT NULL,
   PRIMARY KEY(course_id)
);

CREATE TABLE CHEVAUX(
   cheval_id INT IDENTITY,
   cheval_nom VARCHAR(50) NOT NULL UNIQUE,
   PRIMARY KEY(cheval_id)
);

CREATE TABLE TYPES_DE_PARI(
   type_de_pari_id INT IDENTITY,
   type_de_pari_designation VARCHAR(50) NOT NULL,
   PRIMARY KEY(type_de_pari_id)
);

CREATE TABLE PARIS(
   pari_id INT IDENTITY,
   pari_date DATETIME2 NOT NULL,
   pari_montant DECIMAL(7,2) NOT NULL,
   course_id INT NOT NULL,
   type_de_pari_id INT NOT NULL,
   PRIMARY KEY(pari_id),
   FOREIGN KEY(course_id) REFERENCES COURSES(course_id),
   FOREIGN KEY(type_de_pari_id) REFERENCES TYPES_DE_PARI(type_de_pari_id)
);

CREATE TABLE PARTICIPANTS(
   course_id INT,
   cheval_id INT,
   participant_numero TINYINT NOT NULL,
   participant_position_final TINYINT NOT NULL,
   PRIMARY KEY(course_id, cheval_id),
   FOREIGN KEY(course_id) REFERENCES COURSES(course_id),
   FOREIGN KEY(cheval_id) REFERENCES CHEVAUX(cheval_id)
);

CREATE TABLE PRONOSTIQUES(
   cheval_id INT,
   pari_id INT,
   pronostique_position_cheval TINYINT,
   PRIMARY KEY(cheval_id, pari_id),
   FOREIGN KEY(cheval_id) REFERENCES CHEVAUX(cheval_id),
   FOREIGN KEY(pari_id) REFERENCES PARIS(pari_id)
);
