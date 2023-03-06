
ALTER TABLE commande ADD category TINYINT;

UPDATE commande
SET category = CASE WHEN commande.cache_prix_total < 200 THEN 1
WHEN cache_prix_total >= 200 AND cache_prix_total < 500 THEN 2
WHEN cache_prix_total >= 500 AND cache_prix_total < 1000 THEN 3
ELSE 4 END

-- TABLE commande_category --
DROP TABLE IF EXISTS commande_category;

CREATE TABLE commande_category
(id TINYINT NOT NULL,
desciption varchar(100)	NOT NULL,
PRIMARY KEY(id));

INSERT INTO 
commande_category(id, desciption)
VALUES
(1,'commandes dont le prix est strictemet inferieur à 200€'),
(2,'commandes dont le prix est entre 200€ inclus et 500€(exclus)'),
(3,'commandes dont le prix est entre 500€ inclus et 1000€(exclus)'),
(4,'commandes dont le prix est suppérieur ou égal à 1000€');

-- ENLEVER LES DONNEES ANTERIEUR AU 1 FEVRIER 2019 --
/*DELETE 
FROM commande_ligne
FROM commande
WHERE commande.date_achat < '01-02-2019' AND commande.id = commande_ligne.commande_id;*/

 -- VERSION JOINTURE --
 
DELETE cl
FROM commande_ligne as cl
    INNER JOIN commande as c  
    ON (cl.commande_id = c.id)
    WHERE c.date_achat < '01-02-2019';  
/*
-- meme resultat --
DELETE FROM commande_ligne
WHERE commande_id IN (SELECT id FROM commande WHERE date_achat < '01-02-2019');
----
*/
DELETE FROM commande
WHERE commande.date_achat < '01-02-2019';



/*SELECT *
FROM commande_ligne
RIGHT JOIN commande ON commande.id = commande_ligne.commande_id;*/

-- AJOUT CLE ETRANGERE MANQUANTE --
ALTER TABLE commande ADD CONSTRAINT fk_commande_client FOREIGN KEY(client_id) REFERENCES client(id);

ALTER TABLE commande_ligne ADD CONSTRAINT fk_commande_ligne_commande FOREIGN KEY(commande_id) REFERENCES commande(id);

ALTER TABLE commande ADD CONSTRAINT fk_commande_commande_category FOREIGN KEY (category) REFERENCES commande_category(id);