create table cliente(id_cliente int(8) auto_increment, nome_cliente varchar(45), cpf int(14) not null, telefone int(17), primary key(id_cliente));
create table pet(id_pet int(20) auto_increment, id_cliente int(8) ,nome_pet varchar(45), idade_pet int(2), tipo_pet varchar(45), valor_consulta double not null, caracteristica_pet varchar(50) , primary key(id_pet), foreign key(id_cliente) references cliente(id_cliente));

insert into cliente values(0,'davi moises','2342434345','33454433');
insert into pet values(1,'2','jubileu','11','chuaua','122.33','doente');
alter table cliente modify cpf varchar(12);
select * from cliente;
describe cliente;