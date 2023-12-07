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

create table Empresa(
id_emp int primary key auto_increment,
cnpj_emp varchar(200),
razao_social_emp varchar(200),
nome_fantasia_emp varchar(200),
situacao_cadastral_emp varchar(200),
data_inicio_emp date,
capital_social_emp varchar(200),
telefone_emp varchar(200),
natureza_juridica_emp varchar(200),
nome_prop_emp varchar(200),
cpf_prop_emp varchar(200),
rua_emp varchar(200),
numero_emp int,
bairro_emp varchar(200),
cidade_emp varchar(200),
estado_emp varchar(200),
regime_tributario_emp varchar(200),
tipo_emp varchar(200),
porte_empresa_emp varchar(200)
)