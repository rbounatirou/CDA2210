-- 1 --

SELECT TOP(10) *
FROM villes_france_free
ORDER BY ville_population_2012 DESC;

-- 2 --

SELECT TOP(50) *
FROM villes_france_free
ORDER BY ville_surface ASC;

-- 3 --

SELECT *
FROM departement
WHERE departement_code LIKE '97%';

-- 4 --
SELECT TOP(10) v.ville_nom, d.departement_nom
FROM villes_france_free AS v
INNER JOIN departement  AS d ON v.ville_departement = d.departement_code
ORDER BY ville_population_2012 DESC;

-- 5 --
SELECT departement_nom, departement_code, COUNT(v.ville_id) AS 'nb_communes'
FROM departement
INNER JOIN villes_france_free AS v ON v.ville_departement = departement.departement_code
GROUP BY departement_nom, departement_code
ORDER by 'nb_communes' DESC;

-- 6 --
SELECT TOP(10) departement_nom, departement_code, COUNT(v.ville_id) AS 'nb_communes', SUM(v.ville_surface) AS 'dep_surface'
FROM departement
INNER JOIN villes_france_free AS v ON v.ville_departement = departement.departement_code
GROUP BY departement_nom, departement_code
ORDER BY 'dep_surface' DESC;

-- 7 --
SELECT COUNT(ville_id) FROM villes_france_free WHERE ville_nom LIKE 'Saint%';

-- 8 --
SELECT v1.ville_nom, COUNT(v1.ville_id) AS 'nbUtilisations'
FROM villes_france_free AS v1
GROUP BY v1.ville_nom
HAVING COUNT(v1.ville_id) >= 2
ORDER BY 'nbUtilisations' DESC;

-- 9 --
/*
SELECT ville_nom, ville_surface
FROM villes_france_free
GROUP BY ville_nom, ville_surface
HAVING ville_surface >= (SELECT AVG(ville_surface) FROM villes_france_free)
ORDER BY ville_surface ASC;
*/

SELECT v1.ville_nom, v1.ville_surface
FROM villes_france_free AS v1, villes_france_free AS v2
GROUP BY v1.ville_nom, v1.ville_surface
HAVING v1.ville_surface >= AVG(v2.ville_surface)
ORDER BY v1.ville_surface ASC;

-- 10 --
SELECT d.departement_nom
FROM departement as d
INNER JOIN villes_france_free as v ON d.departement_nom = v.ville_departement
GROUP BY d.departement_nom,v.ville_population_2012
HAVING SUM(v.ville_population_2012) >= 2000000;


