use commandes_db;

-- 1 --

--SELECT * FROM client WHERE prenom = 'Muriel'  AND password LIKE CONCAT('0x',UPPER(HASHBYTES('SHA1', 'test11')));


SELECT * FROM client WHERE  UPPER(password) LIKE CONVERT(NVARCHAR(32),HASHBYTES('SHA1', 'test11'));

SELECT *
FROM client 
WHERE prenom='Muriel'
AND password = CONVERT(VARCHAR(64),HASHBYTES('SHA1', 'test11'),2); 

-- 2 --
SELECT cl.nom, COUNT(cl.id) AS 'nbCommandes'
FROM commande_ligne as cl
GROUP BY cl.nom
HAVING COUNT(cl.nom) > 1
ORDER BY 'nbCommandes' ASC;

-- OU --
SELECT cl.nom, COUNT(cl.id) AS 'nbCommandes'
FROM commande_ligne as cl
JOIN commande as c ON cl.commande_id = c.id
GROUP BY cl.nom
HAVING COUNT(cl.nom) > 1
ORDER BY 'nbCommandes' ASC;

-- OU --
SELECT distinct(cl.nom), COUNT(cl.id) AS 'nbCommandes'
FROM commande_ligne as cl
GROUP BY cl.nom
HAVING COUNT(cl.nom) > 1
ORDER BY 'nbCommandes' ASC;

-- OU --
SELECT distinct cl.nom
FROM commande_ligne as cl
JOIN commande_ligne as c ON cl.nom = c.nom AND cl.commande_id <> c.commande_id
ORDER BY cl.nom ASC;

-- 3 --

SELECT cl.nom, STRING_AGG(c.id , ',')
FROM commande_ligne as cl
JOIN commande as c ON cl.commande_id = c.id
GROUP BY cl.nom
HAVING COUNT(cl.nom) > 1
ORDER BY cl.nom ASC;


-- 4 --
-- Requete DML --
UPDATE commande_ligne
SET prix_total = (prix_unitaire*quantite);


-- 5 --
SELECT distinct(co.id) , co.date_achat, cl.nom, cl.prenom, SUM(col.prix_total) AS 'prix'
FROM commande as co
JOIN commande_ligne as col ON col.commande_id = co.id
JOIN client as cl ON co.client_id = cl.id
GROUP BY co.id, co.date_achat, cl.nom, cl.prenom;

-- 6 --
-- DML --
UPDATE commande
SET cache_prix_total = (SELECT SUM(prix_total) FROM commande_ligne WHERE commande.id = commande_ligne.commande_id);

-- 7 --

SELECT distinct (MONTH(commande.date_achat)), SUM(commande.cache_prix_total)
FROM commande
GROUP BY MONTH(commande.date_achat);

-- 8 --

SELECT top(10) cl.id, cl.nom, cl.prenom, SUM(co.cache_prix_total) as 'depensesTotal'
FROM client as cl
JOIN commande as co ON co.client_id = cl.id
GROUP BY cl.id, cl.nom, cl.prenom
ORDER BY 'depensesTotal' DESC;

-- 9 --
SELECT distinct(co.date_achat), SUM(co.cache_prix_total) as 'depensesJournalieres'
FROM commande as co
GROUP BY co.date_achat;
/*
SELECT commande.cache_prix_total
FROM commande
WHERE date_achat LIKE '2019-02-02';
*/

/*SELECT distinct(commande.id)
FROM commande;

SELECT distinct(commande.id)
FROM commande
JOIN commande_ligne ON commande.id = commande_ligne.commande_id
GROUP BY commande.id;*/