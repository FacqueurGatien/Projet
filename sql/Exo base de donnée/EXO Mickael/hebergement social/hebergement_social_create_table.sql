DROP TABLE IF EXISTS REGISTER;
DROP TABLE IF EXISTS EVENTS;
DROP TABLE IF EXISTS ACTIVITIES;
DROP TABLE IF EXISTS NEED;
DROP TABLE IF EXISTS MEDICAL_NEEDS;
DROP TABLE IF EXISTS RESIDENTS;
DROP TABLE IF EXISTS PEOPLE;
DROP TABLE IF EXISTS ROLES;

CREATE TABLE ROLES(
   role_id SERIAL,
   role_name VARCHAR(50) NOT NULL UNIQUE,
   PRIMARY KEY(role_id)
);

CREATE TABLE PEOPLE(
   person_id SERIAL,
   person_lastname VARCHAR(255) NOT NULL,
   person_firstname VARCHAR(50) NOT NULL,
   person_birthdate DATE NOT NULL,
   role_id INTEGER NOT NULL,
   PRIMARY KEY(person_id),
   FOREIGN KEY(role_id) REFERENCES ROLES(role_id)
);

CREATE TABLE RESIDENTS(
   person_id INTEGER,
   resident_arrival_date TIMESTAMP NOT NULL,
   resident_leave_date TIMESTAMP NULL,
   doctor_id INTEGER NULL,
   PRIMARY KEY(person_id),
   FOREIGN KEY(person_id) REFERENCES PEOPLE(person_id),
   FOREIGN KEY(doctor_id) REFERENCES PEOPLE(person_id)
);

CREATE TABLE MEDICAL_NEEDS(
   medical_need_id SERIAL,
   medical_need_label VARCHAR(255) NOT NULL,
   PRIMARY KEY(medical_need_id)
);

CREATE TABLE ACTIVITIES(
   activity_id SERIAL,
   activity_label VARCHAR(255) NOT NULL,
   PRIMARY KEY(activity_id)
);

CREATE TABLE EVENTS(
   event_id SERIAL,
   event_date_activity DATE NOT NULL,
   event_activity_start TIME NOT NULL,
   event_activity_end TIME NOT NULL CHECK (event_activity_end > event_activity_start),
   event_cap_min SMALLINT NOT NULL CHECK (event_cap_min > 3),
   event_cap_max SMALLINT NOT NULL CHECK (event_cap_max >= event_cap_min AND event_cap_max < 20),
   event_state BOOLEAN NOT NULL,
   activity_id INTEGER NOT NULL,
   educator_id INTEGER NOT NULL,
   PRIMARY KEY(event_id),
   FOREIGN KEY(activity_id) REFERENCES ACTIVITIES(activity_id),
   FOREIGN KEY(educator_id) REFERENCES PEOPLE(person_id)
);

CREATE TABLE NEED(
   person_id INTEGER,
   medical_need_id INTEGER,
   PRIMARY KEY(person_id, medical_need_id),
   FOREIGN KEY(person_id) REFERENCES RESIDENTS(person_id),
   FOREIGN KEY(medical_need_id) REFERENCES MEDICAL_NEEDS(medical_need_id)
);

CREATE TABLE REGISTER(
   person_id INTEGER,
   event_id INTEGER,
   PRIMARY KEY(person_id, event_id),
   FOREIGN KEY(person_id) REFERENCES RESIDENTS(person_id),
   FOREIGN KEY(event_id) REFERENCES EVENTS(event_id)
);

