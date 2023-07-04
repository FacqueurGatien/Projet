DROP TABLE IF EXISTS planes CASCADE;
DROP TABLE IF EXISTS manufacturers CASCADE;

CREATE TABLE planes
(
	plane_ref CHAR(5) PRIMARY KEY
	,plane_capacity INT NOT NULL
	,plane_autonomy INT NOT NULL
	,plane_speed INT NOT NULL
	,plane_date DATE NOT NULL
	,plane_maker_id INT NOT NULL
);

CREATE TABLE manufacturers
(
	plane_maker_id SERIAL PRIMARY KEY
	,plane_maker VARCHAR(50) NOT NULL UNIQUE
);


ALTER TABLE planes
	ADD CONSTRAINT FK_planes_manufacturers FOREIGN KEY (plane_maker_id) REFERENCES manufacturers (plane_maker_id);