USE employe_db;

DROP TABLE IF EXISTS employees;

Create table employees
(emp_id INT IDENTITY(1,1),
emp_lastname varchar(50) NOT NULL,
emp_firstname VARCHAR(50) NOT NULL,
emp_salary INT NOT NULL,
emp_hiredate DATE NOT NULL,
emp_manager_id INT);

ALTER TABLE employees ADD CONSTRAINT pk_employes PRIMARY KEY(emp_id);

ALTER TABLE employees ADD CONSTRAINT fk_employees FOREIGN KEY(emp_manager_id) REFERENCES employees(emp_id);