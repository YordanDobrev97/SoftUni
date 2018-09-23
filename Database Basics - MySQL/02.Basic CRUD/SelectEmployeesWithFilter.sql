SELECT id, first_name,last_name,salary, job_title,
CONCAT(`first_name`, ' ', `last_name`) 
AS 'full_name'
FROM employees
WHERE salary > 1000;