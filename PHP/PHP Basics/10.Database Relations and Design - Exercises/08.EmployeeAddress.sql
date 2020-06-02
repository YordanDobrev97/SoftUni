SELECT employee_id,
       job_title,
       a.address_id,
       a.address_text
FROM employees
         JOIN addresses AS a on employees.address_id = a.address_id
ORDER BY address_id
LIMIT 5;