use commandes_db;

-- 1 --

--SELECT * FROM client WHERE prenom = 'Muriel'  AND password LIKE CONCAT('0x',UPPER(HASHBYTES('SHA1', 'test11')));
SELECT * FROM client WHERE prenom = 'Muriel'  AND password = HASHBYTES('SHA1', 'test11');

SELECT password FROM client;