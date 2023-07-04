--#########---DROP---##########--
DROP TABLE IF EXISTS evaluations ;
DROP TABLE IF EXISTS trips_themes ;
DROP TABLE IF EXISTS services_trips ;
DROP TABLE IF EXISTS steps ;
DROP TABLE IF EXISTS orders ;
DROP TABLE IF EXISTS services ;
DROP TABLE IF EXISTS clients ;
DROP TABLE IF EXISTS cities ;
DROP TABLE IF EXISTS countries ;
DROP TABLE IF EXISTS coms ;
DROP TABLE IF EXISTS themes ;
DROP TABLE IF EXISTS trips CASCADE;

--#########---CREATE---##########--
CREATE TABLE coms(
    com_code CHAR(5) PRIMARY KEY
    ,com_name VARCHAR(64) NOT NULL
    ,com_password VARCHAR(60) NOT NULL
    ,com_code_next CHAR(5) NULL
	--,FOREIGN KEY(com_code_next) REFERENCES coms(com_code)
);

CREATE TABLE countries(
    country_code CHAR(2) PRIMARY KEY
    ,country_name VARCHAR(128) NOT NULL
);

CREATE TABLE cities(
    city_code SERIAL PRIMARY KEY
    ,city_name VARCHAR(128) NOT NULL
    ,country_code CHAR(2) NOT NULL
	--,FOREIGN KEY(country_code) REFERENCES countries(country_code)
);

CREATE TABLE trips(
    trip_code SERIAL PRIMARY KEY
    ,trip_title VARCHAR(128) NOT NULL
    ,trip_available INT NOT NULL 
    ,trip_start TIMESTAMP NOT NULL --TO MODIFY (CHECK DATE HIGHER THAN TODAY)
    ,trip_end TIMESTAMP NOT NULL --TO MODIFY (CHECK DATE HIGHER THAN trip_start and HIGHER THAN step_end(last step))
    ,trip_price DECIMAL(7,2) NOT NULL --TO MODIFY (CALCULATE DATA)
    ,trip_owerview TEXT NOT NULL 
    ,trip_description TEXT NULL
);

CREATE TABLE themes(
    theme_code SERIAL PRIMARY KEY
    ,theme_name VARCHAR(32) NOT NULL
    ,theme_description TEXT NULL
);

CREATE TABLE services(
    service_code SERIAL PRIMARY KEY
    ,service_name VARCHAR(32) NOT NULL
    ,service_description TEXT NULL
);

CREATE TABLE clients(
    client_id SERIAL PRIMARY KEY
    ,client_lastname VARCHAR(32) NOT NULL
    ,client_firstname VARCHAR(32) NOT NULL
    ,client_email VARCHAR(128) NOT NULL CHECK (client_email LIKE '^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$') --MODIFY (CONSTRAINT)
    ,client_phone CHAR(16) NOT NULL --TO MODIFY (ADD CHECK FORMAT)
    ,client_added DATE NOT NULL --TO MODIFY (CHECK DATE TODAY)
    ,client_password VARCHAR(60) NOT NULL 
    ,com_code CHAR(5) NOT NULL 
	--,FOREIGN KEY(com_code) REFERENCES coms(com_code)
);
--TO MODIFY (CHECK DATE HIGHER THAN TODAY)
CREATE TABLE steps(
    city_code INT
    ,trip_code INT
    ,step_start TIMESTAMP NOT NULL --TO MODIFY (CHECK DATE HIGHER THAN trip_start and LESS THAN step_end)
    ,step_end TIMESTAMP NOT NULL--TO MODIFY (CHECK DATE LESS THAN trip_end and HIGHER THAN step_start)
 	--,PRIMARY KEY(city_code, trip_code)
	--,FOREIGN KEY(city_code) REFERENCES cities(city_code)
	--,FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
);

CREATE TABLE trips_themes(
    trip_code INT
    ,theme_code INT
	--,PRIMARY KEY(trip_code, theme_code),
    --,FOREIGN KEY(trip_code) REFERENCES trips(trip_code),
    --,FOREIGN KEY(theme_code) REFERENCES themes(theme_code)
);

CREATE TABLE orders(
    client_id INT
    ,trip_code INT
    ,order_quantity SMALLINT NOT NULL --TO MODIFY (CHECK NOT NEG)
    ,order_paid BOOLEAN NOT NULL
	--PRIMARY KEY(client_id, trip_code)
    --,FOREIGN KEY(client_id) REFERENCES clients(client_id)
    --,FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
);

CREATE TABLE evaluations(
   client_id INT
   ,trip_code INT
   ,service_code INT
   ,service_score SMALLINT --TO MODIFY (TRIGGER CHECK IF trip_start PASSED AND client_paid TRUE)
	--,PRIMARY KEY(client_id, trip_code, service_code)
    --,FOREIGN KEY(client_id) REFERENCES clients(client_id)
    --,FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
    --,FOREIGN KEY(service_code) REFERENCES services(service_code)
);

CREATE TABLE services_trips(
   trip_code INT
   ,service_code INT
   ,service_commentaire VARCHAR(255) --TO MODIFY (TRIGGER service_score DEFINED)
	--,PRIMARY KEY(trip_code, service_code)
	--,FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
	--,FOREIGN KEY(service_code) REFERENCES services(service_code)
);

--#########---ALTER---##########--
ALTER TABLE coms
	ADD CONSTRAINT FK_coms_coms2 FOREIGN KEY(com_code_next) REFERENCES coms(com_code);
	
ALTER TABLE cities
	ADD CONSTRAINT FK_CITIES_COUNTRIES FOREIGN KEY(country_code) REFERENCES countries(country_code);
	
ALTER TABLE clients
	ADD CONSTRAINT FK_CLIENTS_COMS FOREIGN KEY(com_code) REFERENCES coms(com_code);

ALTER TABLE steps
	ADD CONSTRAINT PK_STEPS_CITIES_TRIPS PRIMARY KEY(city_code, trip_code)
	,ADD CONSTRAINT FK_STEPS_CITY FOREIGN KEY(city_code) REFERENCES cities(city_code)
	,ADD CONSTRAINT FK_STEPS_TRIPS FOREIGN KEY(trip_code) REFERENCES trips(trip_code);

ALTER TABLE trips_themes
	ADD CONSTRAINT PK_TRIPS_THEMES PRIMARY KEY(trip_code, theme_code),
    ADD CONSTRAINT FK_TRIPS_THEME_TRIPS FOREIGN KEY(trip_code) REFERENCES trips(trip_code),
    ADD CONSTRAINT FK_TRIPS_THEME_THEMES FOREIGN KEY(theme_code) REFERENCES themes(theme_code);
  
ALTER TABLE orders
	ADD CONSTRAINT PK_ORDERS_CLIENTS_TRIPS  PRIMARY KEY(client_id, trip_code)
    ,ADD CONSTRAINT FK_ORDERS_CLIENTS FOREIGN KEY(client_id) REFERENCES clients(client_id)
    ,ADD CONSTRAINT FK_ORDERS_TRIPS FOREIGN KEY(trip_code) REFERENCES trips(trip_code);

ALTER TABLE evaluations
	ADD CONSTRAINT PK_EVALUATIONS_CLIENTS_TRIPS_SERVICES PRIMARY KEY(client_id, trip_code, service_code)
    ,ADD CONSTRAINT FK_EVALUATIONS_CLIENTS FOREIGN KEY(client_id) REFERENCES clients(client_id)
    ,ADD CONSTRAINT FK_EVALUATIONS_TRIPS FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
    ,ADD CONSTRAINT FK_EVALUATIONS_SERVICES FOREIGN KEY(service_code) REFERENCES services(service_code);

ALTER TABLE services_trips
	ADD CONSTRAINT PK_SERVICES_TRIPS PRIMARY KEY(trip_code, service_code)
	,ADD CONSTRAINT FK_SERVICES_TRIPS_TRIPS FOREIGN KEY(trip_code) REFERENCES trips(trip_code)
	,ADD CONSTRAINT FK_SERVICES_TRIPS_SERVICES FOREIGN KEY(service_code) REFERENCES services(service_code);
