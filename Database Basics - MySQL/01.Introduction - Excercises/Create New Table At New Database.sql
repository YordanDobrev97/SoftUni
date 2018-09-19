CREATE TABLE `minions` (
	`id` INT NULL AUTO_INCREMENT,
	`name` VARCHAR(50) NULL DEFAULT NULL,
	`age` INT NULL
)
COLLATE='latin1_swedish_ci'
;
/* SQL Error (1075): Incorrect table definition; there can be only one auto column and it must be defined as a key */
CREATE TABLE `minions` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`name` VARCHAR(50) NULL DEFAULT NULL,
	`age` INT NULL,
	UNIQUE INDEX `id` (`id`),
	PRIMARY KEY (`id`)
)
COLLATE='latin1_swedish_ci'
;
SELECT `DEFAULT_COLLATION_NAME` FROM `information_schema`.`SCHEMATA` WHERE `SCHEMA_NAME`='minions';
SHOW TABLE STATUS FROM `minions`;
SHOW FUNCTION STATUS WHERE `Db`='minions';
SHOW PROCEDURE STATUS WHERE `Db`='minions';
SHOW TRIGGERS FROM `minions`;
SELECT *, EVENT_SCHEMA AS `Db`, EVENT_NAME AS `Name` FROM information_schema.`EVENTS` WHERE `EVENT_SCHEMA`='minions';
SHOW CREATE TABLE `minions`.`minions`;
/* Entering session "Unnamed" */
SHOW CREATE TABLE `minions`.`minions`;