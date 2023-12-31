DROP TABLE IF EXISTS PRODUCTION_LINES;
DROP TABLE IF EXISTS PRODUCTION_DONE;
DROP TABLE IF EXISTS PRODUCTS;

CREATE TABLE PRODUCTS
(
	product_id INT PRIMARY KEY
	,product_name VARCHAR(128) UNIQUE
	,product_value INT
);

CREATE TABLE PRODUCTION_LINES
(
	line_id CHAR(3) PRIMARY KEY
	,line_label VARCHAR(50)
	,product_id INT
	,FOREIGN KEY(product_id)REFERENCES PRODUCTS(product_id) 
);

CREATE TABLE PRODUCTION_DONE
(
	forge_id INT PRIMARY KEY
	,forge_date DATE
	,forge_quantity INT
	,line_id CHAR(3)
	,product_id INT
	,FOREIGN KEY(line_id)REFERENCES PRODUCTION_LINES(line_id)
	,FOREIGN KEY(product_id)REFERENCES PRODUCTS(product_id)
);
