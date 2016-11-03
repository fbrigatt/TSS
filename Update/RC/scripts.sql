alter table config add column versao decimal(10, 2) not null after tipos_servico_id;

create table campanhas
(
	id int not null auto_increment,
	descricao varchar(100) not null,
	primary key(id)
)ENGINE=InnoDB DEFAULT CHARSET=latin1 auto_increment=1;

create table estilos
(
	id   int          not null auto_increment,
    nome varchar(100) not null,
    primary key(id)
)ENGINE=InnoDB default charset=latin1 auto_increment=1;

alter table servicos       add column estilo_id     int         not null default 0   after data_servico;
alter table clientes       add column campanha_id   int         not null default 0   after dataCadastro;
alter table contas_receber add column parcela       varchar(10)                      after movimentos_id;
alter table contas_pagar   add column parcela       varchar(10)                      after movimentos_id;
update contas_pagar   set parcela = ' ' where id > 0;
update contas_receber set parcela = ' ' where id > 0;

insert into campanhas(descricao) values ('Site');
insert into campanhas(descricao) values ('Facebook');
insert into campanhas(descricao) values ('Youtube');
insert into campanhas(descricao) values ('Twiter');
insert into campanhas(descricao) values ('Indicação');
insert into campanhas(descricao) values ('Viu o estúdio / passou perto');
insert into campanhas(descricao) values ('Anúncio');
insert into campanhas(descricao) values ('Email');

insert into estilos(nome) values ('Old School/Tradicional');
insert into estilos(nome) values ('New School');
insert into estilos(nome) values ('Geométrico');
insert into estilos(nome) values ('Pontilhismo');
insert into estilos(nome) values ('Fotorrealismo');
insert into estilos(nome) values ('Biomecânico');
insert into estilos(nome) values ('Tribal');
insert into estilos(nome) values ('Maori');
insert into estilos(nome) values ('Oriental');
insert into estilos(nome) values ('Bold line');

update config set versao = 1.3 where id = 1;