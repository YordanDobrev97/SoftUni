UPDATE employees
SET salary = salary * 1.12
WHERE department_id in (1, 2, 4, 11);

SELECT salary FROM employees;