INSERT INTO `gamebar`.`employees` (`first_name`, `last_name`, `salary`, `position`) 
VALUES ('Ivan', 'Ivanov', '2000', 'Develper');
SELECT LAST_INSERT_ID();
SELECT `employee_id`, `first_name`, `last_name`, `salary`, `salary_id`, `position` 
FROM `gamebar`.`employees` 
WHERE  `employee_id`=2;
UPDATE `gamebar`.`employees` 
SET `position`='Develper' 
WHERE  `employee_id`=1;
SELECT `employee_id`, `first_name`, `last_name`, `salary`, `salary_id`, `position` 
FROM `gamebar`.`employees` 
WHERE  `employee_id`=1;