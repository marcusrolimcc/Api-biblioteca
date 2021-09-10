create database biblioteca
use biblioteca

create table cidade(
	idcidade int not null primary key identity(1,1),
	nome varchar(50) not null,
	uf varchar(50) not null
)

create table amigo(
	idamigo int not null primary key identity(1,1),
	nome varchar(50) not null, 
	idcidade int not null references cidade(idcidade)
)

create table livro (
	idlivro int not null primary key identity(1,1),
	nome varchar(50) not null,
	autor varchar(50) not null,
	idamigo int not null references amigo(idamigo)
)

insert cidade(nome, uf) values ('Campo Grande', 'MS')
insert cidade(nome, uf) values ('Rio de Janeiro', 'RJ')
insert cidade(nome, uf) values ('São Paulo', 'SP')
insert cidade(nome, uf) values ('Florianopolis', 'SC')
insert cidade(nome, uf) values ('Cuiaba', 'MT')

insert amigo(nome, idcidade) values ('Marcus', 1)
insert amigo(nome, idcidade) values ('Douglas', 2)
insert amigo(nome, idcidade) values ('Lucas', 3)
insert amigo(nome, idcidade) values ('Misael', 4)
insert amigo(nome, idcidade) values ('Tiago', 5)

insert livro(nome, autor, idamigo) values ('A forca do hábito', 'XX', 1)
insert livro(nome, autor, idamigo) values ('Steve Jobs', 'XX', 2)
insert livro(nome, autor, idamigo) values ('O monge e o executivo', 'XX', 3)
insert livro(nome, autor, idamigo) values ('HTML', 'XX', 4)
insert livro(nome, autor, idamigo) values ('Engenharia de software', 'XX', 5)


select * from amigo
select * from cidade
select * from livro