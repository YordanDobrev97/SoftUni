CREATE TABLE users (
    id int primary key auto_increment,
    username varchar(30) not null,
    password varchar(26) not null,
    profile_picture mediumblob,
    last_login_time datetime,
    is_deleted bit
);

insert into users (username, password)
values
('Pesho', '123'),
('Niki', '101010'),
('Stoyan', 'akdsakldas'),
('Ivan', 'mariika'),
('Pencho', 'i am the best')