USE TestDb;

DROP TABLE IF EXISTS cities;
DROP TABLE IF EXISTS countries;

CREATE TABLE countries
(country_code CHAR(2) PRIMARY KEY,
country_name varchar(100) NOT NULL);

CREATE TABLE cities
(city_id INT IDENTITY(1,1) PRIMARY KEY,
city_name varchar(100) NOT NULL,
country_code CHAR(2) NOT NULL);

ALTER TABLE cities ADD CONSTRAINT fk_cities_country_code FOREIGN KEY (country_code) REFERENCES countries(country_code);

