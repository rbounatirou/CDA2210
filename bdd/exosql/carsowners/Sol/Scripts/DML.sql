INSERT INTO owners
(owner_lastname, owner_firstname)
VALUES
('Petit','Annie'),
('Marsfall','Bénédicte'),
('Doe','John'),
('Bouchra', 'Amine'),
('Jones','Steeven');

INSERT INTO brands
(brand_name)
VALUES
('Chevrolet'),('Audi'),('Toyota'),('Peugeot'),('AMC');

INSERT INTO cars
(car_id, car_name, brand_id)
VALUES
(12,'Chevelle Concours',1),
(16,'A6 Break',2),
(21,'Corolla',3),
(19,'Monte Carlo',1),
(27,'504',4),
(30,'Q8',2),
(28,'100 LS',2),
(23,'Hornet', 5),
(26,'3008', 4);

INSERT INTO cars_owners
(car_registration, car_owner_id, car_id)
VALUES
('AA-123-AA',1,12),
('BB-274-BB',5,16),
('CA-789-BA',2,21),
('CC-546-FV',4,19),
('CG-274-ZG',4,27),
('ER-355-GX',3,30),
('FV-313-FT',5,28),
('DE-228-KS',5,23),
('CF-614-PM',5,26);

/*INSERT INTO cars_owners
(car_registration, car_owner_id, car_id)
VALUES
('AA-123-AB',1,19);*/