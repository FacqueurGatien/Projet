CREATE OR REPLACE PROCEDURE insert_brand
(
	_brand_name VARCHAR(50)
)

LANGUAGE plpgsql
AS $$

BEGIN
	INSERT INTO BRANDS
	(brand_name)
	VALUES
	(_brand_name);
END$$;

CREATE OR REPLACE PROCEDURE insert_owner
(
	_owner_lastname VARCHAR(50),
	_owner_firstname VARCHAR(50)
)

LANGUAGE plpgsql
AS $$

BEGIN
	INSERT INTO OWNERS
	(owner_lastname , owner_firstname)
	VALUES
	(_owner_lastname , _owner_firstname);
END$$;

CREATE OR REPLACE PROCEDURE insert_car
(
	_car_id INT,
	_car_registration CHAR(9),
	_car_name VARCHAR(100),
	_brand_id INT,
	_owner_id INT 
)

LANGUAGE plpgsql
AS $$

BEGIN
	INSERT INTO CARS
	(car_id , car_registration , car_name , brand_id , owner_id)
	VALUES
	(_car_id , _car_registration , _car_name , _brand_id , _owner_id);
END$$;