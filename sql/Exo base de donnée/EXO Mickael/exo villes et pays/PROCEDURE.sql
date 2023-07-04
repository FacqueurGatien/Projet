
CREATE OR REPLACE PROCEDURE insert_country
(
	_country_code CHAR(2),
	_country_name VARCHAR(100)
)

LANGUAGE plpgsql
AS $$

BEGIN
INSERT INTO COUNTRIES 
(country_code , country_name)
VALUES
(_country_code , _country_name);

END $$;

CREATE OR REPLACE PROCEDURE insert_city
(
	_city_name VARCHAR(100),
	_country_code CHAR(2)
)

LANGUAGE plpgsql
AS $$

BEGIN
INSERT INTO CITIES 
(city_name , country_code)
VALUES
(_city_name , _country_code);

END $$;
