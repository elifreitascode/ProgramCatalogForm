--create database db_tds_ds
--go

--use db_tds_ds
--go

--drop table tb_agenda
--go

/*
create table tb_agenda (
	codigo int constraint pk_agenda primary key identity(1,1),
	nome varchar(100) not null, 
	apelido varchar(100),
	nascimento datetime,
	telefones varchar(100) not null,
	email varchar(100)
)
go

insert into tb_agenda (nome, apelido, nascimento, telefones, email)
values ('Samuel', 'Samuka', '1970-09-29', '9990-9900', 'samuka@example.com'),
       ('Cristiano', 'Cris', '1969-09-18', '9991-9911', 'cristiano@example.com'),
       ('Eduardo', 'Dudu', '2001-12-04', '9992-9922', 'dudu@example.com'),
       ('Maria', 'Mariah', '1999-11-10', '9993-9933', 'mariah@example.com')
go
*/

select * from tb_agenda
go