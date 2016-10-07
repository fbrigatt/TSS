alter table config add column versao decimal(10, 2) not null after tipos_servico_id;
create table campanhas
(
	id int not null AUTO_INCREMENT,
	descricao varchar(100) not null,
	primary key(id)
)ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;
alter table clientes add column campanha_id int after dataCadastro;
update clientes set campanha_id = 0 where id > 0;
update config set versao = 1.3 where id = 1;
alter table contas_receber add column parcela varchar(10) after movimentos_id;
alter table contas_pagar add column parcela varchar(10) after movimentos_id;
update contas_pagar set parcela = ' ' where id > 0;
update contas_receber set parcela = ' ' where id > 0;

insert into campanhas(descricao) values ('Site');
insert into campanhas(descricao) values ('Facebook');
insert into campanhas(descricao) values ('Youtube');
insert into campanhas(descricao) values ('Twiter');
insert into campanhas(descricao) values ('Indicação');
insert into campanhas(descricao) values ('Viu o estúdio / passou perto');
insert into campanhas(descricao) values ('Anúncio');
insert into campanhas(descricao) values ('Email');