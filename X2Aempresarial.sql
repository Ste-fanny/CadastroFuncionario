create database X2Aempresarial;
use X2Aempresarial;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar(200),
data_nas_fun date,
cpf_fun varchar(200),
rg_fun varchar(200),
telefone_fun varchar(200), 
email_fun varchar(200),
rua_fun varchar(200),
bairro_fun varchar(200),
numero_fun int,
estado_civil_fun varchar(200),
funcao_fun varchar(200),
salario_fun double,
estado_fun varchar(200),
cidade_fun varchar(200),
complemento_fun varchar(200)
);

select * from funcionario;