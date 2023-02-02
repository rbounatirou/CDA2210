INSERT INTO CHEVAUX(cheval_nom)
VALUES
('Poney fringuant'),('Fleur des près'),('monsieur cheval'),('Rocky'),('Mozart'),('Bethoven'),('Cliford'),('Rocco'),('Looping'),('Eclipse'),('InteliJ'),('Maria'),('Transact'),('Microsoft'),('Nintendo'),('Sony'),('Naruto'),('Sasuke'),('Sakura');

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

/*
SELECT * From participants WHERE course_id = (SELECT course_id FROM courses WHERE course_nom LIKE 'Paris');
*/