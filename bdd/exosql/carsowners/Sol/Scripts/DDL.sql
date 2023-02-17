USE carowner_db;

DROP TABLE IF EXISTS cars_owners;
DROP TABLE IF EXISTS cars;
DROP TABLE IF EXISTS owners;
DROP TABLE IF EXISTS brands;

CREATE TABLE brands
(
	brand_id INT IDENTITY(1,1),
	brand_name VARCHAR(50) NOT NULL UNIQUE,
	brand_slogan VARCHAR(255),
	PRIMARY KEY(brand_id)
);

CREATE TABLE owners
(
	owner_id INT IDENTITY(1,1),
	owner_lastname VARCHAR(50) NOT NULL,
	owner_firstname VARCHAR(50) NOT NULL,
	PRIMARY KEY(owner_id)
);

CREATE TABLE cars(
	car_id INT NOT NULL,
	car_name VARCHAR(100) NOT NULL,
	brand_id INT NOT NULL,
	PRIMARY KEY(car_id)
);

CREATE TABLE cars_owners(
	car_registration CHAR(9) NOT NULL,
	car_owner_id INT NOT NULL,
	car_id INT NOT NULL,
	PRIMARY KEY(car_owner_id, car_id)
);

ALTER TABLE cars ADD CONSTRAINT fk_brand_id FOREIGN KEY(brand_id) REFERENCES brands(brand_id);

ALTER TABLE cars_owners ADD CONSTRAINT fk_car_owner_id FOREIGN KEY(car_owner_id) REFERENCES owners(owner_id);

ALTER TABLE cars_owners ADD CONSTRAINT fk_car_id FOREIGN KEY (car_id) REFERENCES cars(car_id);

ALTER TABLE cars_owners 
ADD CONSTRAINT chk_car_registration 
CHECK (car_registration LIKE '[A-Z][A-Z]-[0-9][0-9][0-9]-[A-Z][A-Z]');

