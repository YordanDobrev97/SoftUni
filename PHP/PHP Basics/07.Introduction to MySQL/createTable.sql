CREATE TABLE students (
   id int primary key auto_increment,
   first_name varchar (50) not null,
   last_name varchar (50) not null,
   number int not null,
   phone char (10),
   record_date date not null,
   is_active bit not null
);