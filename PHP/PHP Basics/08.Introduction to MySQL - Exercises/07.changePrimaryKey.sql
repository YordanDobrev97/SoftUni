alter table users
drop primary key,
add constraint pk_users primary key (id, username);