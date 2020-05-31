CREATE TABLE people (
    id int primary key auto_increment,
    name varchar (200) not null,
    picture mediumblob,
    height float (6, 2),
    weight float (6, 2),
    gender enum ('m', 'f') not null,
    birthdate date not null,
    biography text
);

insert into people (name, picture, height, weight, gender, birthdate, biography)
values
('Niki ', null, 175.35, 70.50, 'm', '1980-12-05', '' ),
('Penka ', null, 175.35, 70.50, 'f', '1980-12-05', '' ),
('Pavel ', null, 175.35, 70.50, 'm', '1980-12-05', '' ),
('Nakov ', null, 175.35, 70.50, 'f', '1980-12-05', '' ),
('Stoyan ', null, 175.35, 70.50, 'm', '1980-12-05', '' );