ALTER TABLE `employees`
	CHANGE COLUMN `employee_id` `employee_id` INT(11) NOT NULL AUTO_INCREMENT FIRST,
	ADD PRIMARY KEY (`employee_id`);