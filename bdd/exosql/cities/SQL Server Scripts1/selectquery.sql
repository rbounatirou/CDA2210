USE TestDb;
-- 1 --

SELECT city_name FROM cities;

-- 2 --

SELECT city_id, city_name FROM cities ORDER BY city_name ASC;

-- 3 --

SELECT city_id, city_name, country_name FROM cities INNER JOIN countries ON cities.country_code = countries.country_code;

-- 4 --

SELECT  cities.country_code,countries.country_name, COUNT(*) AS 'Number of cities' 
FROM cities 
INNER JOIN countries ON cities.country_code = countries.country_code
GROUP BY cities.country_code ,countries.country_name
ORDER BY 'Number of cities' ASC;

-- 5 --

SELECT cities.*, countries.country_name, c.nbCities AS 'Number of cities' FROM cities 
INNER JOIN countries ON countries.country_code = cities.country_code
INNER JOIN (SELECT cities.country_code, COUNT(*) AS nbCities 
FROM cities 
INNER JOIN countries ON cities.country_code = countries.country_code 
GROUP BY cities.country_code) AS c 
ON cities.country_code = c.country_code
ORDER BY cities.city_id ASC;