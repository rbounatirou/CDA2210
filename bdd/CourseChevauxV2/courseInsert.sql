DROP TABLE IF EXISTS participants;
DROP TABLE IF EXISTS mises;
DROP TABLE IF EXISTS paris;
DROP TABLE IF EXISTS typeparis;
DROP TABLE IF EXISTS chevaux;
DROP TABLE IF EXISTS courses;

CREATE TABLE courses(
   course_id INT IDENTITY,
   course_nom VARCHAR(50) NOT NULL,
   course_date DATETIME2 NOT NULL,
   PRIMARY KEY(course_id)
);

CREATE TABLE chevaux(
   cheval_id INT IDENTITY,
   cheval_nom VARCHAR(50) NOT NULL,
   PRIMARY KEY(cheval_id)
);

CREATE TABLE typeparis(
   typepari_id INT IDENTITY,
   typepari_nom VARCHAR(50) NOT NULL,
   typepari_coefficient DECIMAL(4,2),
   PRIMARY KEY(typepari_id),
   UNIQUE(typepari_nom)
);

CREATE TABLE paris(
   pari_id INT IDENTITY,
   pari_gain DECIMAL(12,2),
   typepari_id INT NOT NULL,
   PRIMARY KEY(pari_id),
   FOREIGN KEY(typepari_id) REFERENCES typeparis(typepari_id)
);

CREATE TABLE mises(
   course_id INT,
   cheval_id INT,
   pari_id INT,
   mise_ordrepari TINYINT NOT NULL,
   PRIMARY KEY(course_id, cheval_id, pari_id),
   FOREIGN KEY(course_id) REFERENCES courses(course_id) ON DELETE CASCADE ON UPDATE CASCADE, 
   FOREIGN KEY(cheval_id) REFERENCES chevaux(cheval_id) ON DELETE CASCADE,
   FOREIGN KEY(pari_id) REFERENCES paris(pari_id) 
);

CREATE TABLE participants(
   course_id INT,
   cheval_id INT,
   participant_positionfinale TINYINT,
   participant_numero TINYINT,
   PRIMARY KEY(course_id, cheval_id),
   FOREIGN KEY(course_id) REFERENCES courses(course_id),
   FOREIGN KEY(cheval_id) REFERENCES chevaux(cheval_id)
);

--

INSERT INTO CHEVAUX(cheval_nom)
VALUES
('Poney fringuant'),('Fleur des pr√®s'),('monsieur cheval'),('Rocky'),('Mozart'),('Bethoven'),('Cliford'),('Rocco'),('Looping'),('Eclipse'),('InteliJ'),('Maria'),('Transact'),('Microsoft'),('Nintendo'),('Sony'),('Naruto'),('Sasuke'),('Sakura');

insert into courses(course_nom, course_date)
values ('paris', '20230201'), ('mulhouse','20230202'),('nantes','20230203');

insert into typeparis(typepari_nom,typepari_coefficient) VALUES
('tierce',3),('duo',2);

insert into participants(course_id, cheval_id, participant_positionfinale, participant_numero)
VALUES
((SELECT course_id FROM courses WHERE course_nom LIKE 'Paris'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Rocco'),
1,
1),
((SELECT course_id FROM courses WHERE course_nom LIKE 'Paris'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Rocky'),
2,
2),
((SELECT course_id FROM courses WHERE course_nom LIKE 'Paris'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Mozart'),
3,
3),
((SELECT course_id FROM courses WHERE course_nom LIKE 'Paris'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Cliford'),
4,

4);

insert into participants(course_id, cheval_id, participant_positionfinale, participant_numero)
VALUES
((SELECT course_id FROM courses WHERE course_nom LIKE 'Mulhouse'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Rocco'),
1,
1),
((SELECT course_id FROM courses WHERE course_nom LIKE 'Mulhouse'),
(SELECT cheval_id FROM chevaux WHERE cheval_nom LIKE 'Rocky'),
2,
2);


insert into paris(pari_gain, typepari_id) VALues
(null, (SELECT typepari_id FROM typeparis WHERE typepari_nom LIKE 'tierce'));
/*
SELECT * From participants WHERE course_id = (SELECT course_id FROM courses WHERE course_nom LIKE 'Paris');
*/
/*CREATE TRIGGER insert_mises_trigger
ON mises
AFTER INSERT
AS
	IF((SELECT COUNT(pari_id) FROM mises WHERE pari_id <> (SELECT pari_id FROM inserted)) > 0)
	BEGIN
		RAISERROR('Un pari ne peut concerner qu''une course ‡ la fois',10,1);
		ROLLBACK TRAN;
	END
GO*/

CREATE TRIGGER insert_mises_trigger
ON mises
AFTER INSERT
AS
BEGIN
	DECLARE @toto INT;
	DECLARE @tata INT;

	SELECT @toto = COUNT(*) FROM participants JOIN inserted ON participants.cheval_id = inserted.cheval_id AND participants.course_id = inserted.course_id;

	SELECT @tata = COUNT(*) FROM mises Join inserted ON mises.pari_id = inserted.pari_id AND mises.course_id <> inserted.course_id;

	IF (@toto > 1 OR @tata > 0)
		RAISERROR('Probleme insertion impossible', 10,1);
		ROLLBACK TRAN;
	END

-- devrait marcher
insert into mises(course_id, cheval_id, pari_id, mise_ordrepari)
VALUES
(1,4,1,1),
(1,5,1,2);

-- ne devrait pas marcher
insert into mises(course_id, cheval_id, pari_id, mise_ordrepari)
VALUES
(2,4,1,3);

/* 
CREATE TRIGGER insert_mises_trigger
ON mises
AFTER INSERT
AS
BEGIN
	Declare selected CURSOR FOR
	SELECT course_id, cheval_id, pari_id FROM inserted;
	OPEN selected;

	Declare @courseid INT;
	Declare @chevalid INT;
	Declare @pariid INT;


	FETCH NEXT FROM selected INTO @courseid, @chevalid, @pariid;
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		DECLARE @toto INT;
		DECLARE @tata INT;

		SELECT @toto = COUNT(*) FROM participants WHERE participants.cheval_id = @chevalid AND participants.course_id = @courseid;

		SELECT @tata = COUNT(*) FROM mises WHERE  mises.pari_id = @pariid AND mises.course_id <> @courseid;

		IF (@toto > 1 OR @tata > 0)
		BEGIN
			RAISERROR('Probleme insertion impossible', 10,1);
			ROLLBACK TRAN;
		END
		FETCH NEXT FROM selected INTO @courseid, @chevalid, @pariid;
	END
	CLOSE selected;
	DEALLOCATE selected;
END;
		*/