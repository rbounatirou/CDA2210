USE carowner_db;

-- 1 --
SELECT CO.car_registration, cars.car_name
FROM cars_owners AS CO
INNER JOIN cars ON CO.car_id = cars.car_id
ORDER BY CO.car_registration ASC;


-- 2 --
SELECT
cars.car_id,
cars_owners.car_registration,
cars.car_name,
brands.brand_name,
owners.owner_firstname,
owners.owner_lastname
FROM cars_owners 
INNER JOIN owners on cars_owners.car_owner_id = owners.owner_id
INNER JOIN cars on cars_owners.car_id = cars.car_id
INNER JOIN brands on brands.brand_id = cars.brand_id
ORDER BY brands.brand_name ASC, owners.owner_lastname ASC;


-- 3 --
SELECT brands.brand_name,
COUNT(*) AS 'nbVehicules'
FROM brands
INNER JOIN cars ON cars.brand_id = brands.brand_id
GROUP BY brands.brand_name

-- 4 --
SELECT  brands.brand_name, COUNT(DISTINCT CO.car_owner_id)
FROM brands 
INNER JOIN cars C ON C.brand_id = brands.brand_id
INNER JOIN cars_owners CO ON C.car_id = CO.car_id
GROUP BY brand_name
ORDER BY brand_name ASC;

-- 5 --
SELECT owners.*
FROM owners
WHERE owners.owner_firstname LIKE 'A%';

-- 6 --
SELECT owners.owner_firstname, owners.owner_lastname
FROM owners
WHERE LEN(owners.owner_firstname) >= 5;

-- 7 --
SELECT owners.owner_firstname, owners.owner_lastname, COUNT(CO.car_owner_id) AS nbVehicules
FROM owners
INNER JOIN cars_owners AS CO ON CO.car_owner_id = owners.owner_id
GROUP BY owners.owner_firstname, owners.owner_lastname
HAVING COUNT(CO.car_owner_id) > 1
ORDER BY nbVehicules DESC;

-- 8 --
SELECT owners.owner_firstname, owners.owner_lastname, B.brand_name, COUNT(C.brand_id) AS nbVehicules
FROM owners
INNER JOIN cars_owners AS CO ON CO.car_owner_id = owners.owner_id
INNER JOIN cars AS C ON C.car_id = CO.car_id
INNER JOIN brands AS B ON B.brand_id = C.brand_id
GROUP BY owners.owner_firstname, owners.owner_lastname, B.brand_name
HAVING COUNT(CO.car_owner_id) > 1
ORDER BY nbVehicules DESC;