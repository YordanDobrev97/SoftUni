CREATE DATABASE minions;

CREATE TABLE `minions`
(
    `id` int primary key auto_increment,
    `name` varchar(200) not null,
    `age`  int null default '0',
    `town_id` int not null default '0'
);

CREATE TABLE `towns`
(
    `id` int primary key auto_increment,
    `name` varchar(100) null default null
);