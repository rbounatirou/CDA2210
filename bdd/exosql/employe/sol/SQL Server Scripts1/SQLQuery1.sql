SELECT * FROM employees;

-- 1 -- 

SELECT employees.emp_firstname, employees.emp_lastname, employees.emp_salary FROM employees ORDER BY employees.emp_hiredate ASC;

-- 2 --
SELECT employees.emp_firstname, employees.emp_lastname, employees.emp_hiredate
FROM employees 
JOIN employees AS manager ON manager.emp_id = employees.emp_manager_id
ORDER BY manager.emp_id ASC;

SELECT employees.emp_firstname, employees.emp_lastname, employees.emp_hiredate
FROM employees 
JOIN employees AS manager ON manager.emp_id = employees.emp_manager_id
ORDER BY manager.emp_firstname ASC;

-- 3 --

-- 4 -- 
SELECT employees.emp_id, employees.emp_lastname, employees.emp_firstname, employees.emp_salary, employees.emp_hiredate, employees.emp_manager_id
FROM employees
WHERE employees.emp_manager_id IS NULL;


-- 5 --
SELECT employeur.emp_lastname, employeur.emp_firstname, COUNT(*) AS nbSousFifre
FROM employees AS employeur
INNER JOIN employees ON employees.emp_manager_id = employeur.emp_id
GROUP BY employeur.emp_lastname, employeur.emp_firstname;

-- 6 --

SELECT employeur.emp_id, employeur.emp_lastname, employeur.emp_firstname, AVG(employees.emp_salary) AS salaireMoyen
FROM employees AS employeur
INNER JOIN employees  ON employees.emp_manager_id = employeur.emp_id
GROUP BY employeur.emp_id, employeur.emp_lastname, employeur.emp_firstname
ORDER BY salaireMoyen ASC;


-- 7 --
SELECT 
boss.emp_id, 
boss.emp_firstname, 
boss.emp_lastname, 
boss.emp_salary,
boss.emp_hiredate,
COUNT(employees.emp_id) as 'Number of employees',
SUM(employees.emp_salary) as 'Total salary',
AVG(employees.emp_salary) as 'Average salary'
FROM employees AS boss
INNER JOIN employees ON employees.emp_id <> boss.emp_id AND employees.emp_manager_id IS NOT NULL
WHERE boss.emp_manager_id IS NULL 
GROUP BY
boss.emp_id, 
boss.emp_firstname, 
boss.emp_lastname, 
boss.emp_salary,
boss.emp_hiredate;