CREATE DATABASE sisenterprise;

USE sisenterprise;

/*-- Drop das tabelas se existirem*/
IF OBJECT_ID('Cadastro_Departamento', 'U') IS NOT NULL
    DROP TABLE Cadastro_Departamento;

IF OBJECT_ID('Cadastro_Funcionario', 'U') IS NOT NULL
    DROP TABLE Cadastro_Funcionario;

IF OBJECT_ID('Marcacao_de_ponto', 'U') IS NOT NULL
    DROP TABLE Marcacao_de_ponto;

IF OBJECT_ID('Cadastro_Ferias', 'U') IS NOT NULL
    DROP TABLE Cadastro_Ferias;

IF OBJECT_ID('Log_calculo_ferias', 'U') IS NOT NULL
    DROP TABLE log_calculo_ferias;

IF OBJECT_ID('Log_calculo_13', 'U') IS NOT NULL
    DROP TABLE log_calculo_13;

IF OBJECT_ID('Login_Usuario', 'U') IS NOT NULL
    DROP TABLE Usuario;

/*-- Criar a tabela Cadastro_Funcionario*/

CREATE TABLE Cadastro_Funcionario (
    id_funcionario INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255),
    cpf VARCHAR(14),
    endereco VARCHAR(255),
    data_nascimento DATE,
    salario DECIMAL(10, 2),
    email VARCHAR(255),
    id_departamento INT,
    telefone VARCHAR(20),
    data_admissao DATE,
    data_alteracao DATETIME,
    data_cadastro DATETIME,
    path_foto3x4 VARCHAR(255),
    qtd_dependentes INT,
    qtd_horas_trabalhadas DECIMAL(5, 2)
);

/*-- Criar a tabela Marcacao_de_ponto*/
CREATE TABLE Marcacao_de_ponto (
    id_marcacao_ponto INT IDENTITY(1,1) PRIMARY KEY,
    id_funcionario INT,
    data_horario_entrada DATETIME,
    data_horario_saida DATETIME,
    local VARCHAR(255),
    status VARCHAR(50)
);

/*-- Criar a tabela Cadastro_Departamento*/
CREATE TABLE Cadastro_Departamento (
    id_departamento INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255),
    gerente VARCHAR(255),
    supervisor VARCHAR(255)
);

/*-- Criar a tabela Cadastro_Ferias*/
CREATE TABLE Cadastro_Ferias (
    id_ferias INT IDENTITY(1,1) PRIMARY KEY,
    id_funcionario INT,
    qtd_dias INT,
    data_cadastro DATETIME
);

/*-- Criar a tabela log_calculo_ferias*/
CREATE TABLE Log_calculo_ferias (
    id_log_ferias INT IDENTITY(1,1) PRIMARY KEY,
    id_funcionario INT,
    valor_calculado DECIMAL(10, 2),
    data_calculo DATETIME
);

/*-- Criar a tabela log_calculo_13*/
CREATE TABLE Log_calculo_13 (
    id_log_13 INT IDENTITY(1,1) PRIMARY KEY,
    id_funcionario INT,
    valor_calculado DECIMAL(10, 2),
    data_calculo DATETIME
);

/*-- Criar a tabela Usuario*/
CREATE TABLE Login_Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(255),
    login VARCHAR(50),
    pass VARCHAR(255),
    tipo VARCHAR(50),
    ativo BIT
);

/*-- Adicionar chaves estrangeiras para manter relacionamentos*/
ALTER TABLE Marcacao_de_ponto
ADD CONSTRAINT FK_Marcacao_Funcionario FOREIGN KEY (id_funcionario)
REFERENCES Cadastro_Funcionario(id_funcionario);

ALTER TABLE Cadastro_Ferias
ADD CONSTRAINT FK_Ferias_Funcionario FOREIGN KEY (id_funcionario)
REFERENCES Cadastro_Funcionario(id_funcionario);

ALTER TABLE Log_calculo_ferias
ADD CONSTRAINT FK_LogFerias_Funcionario FOREIGN KEY (id_funcionario)
REFERENCES Cadastro_Funcionario(id_funcionario);

ALTER TABLE Log_calculo_13
ADD CONSTRAINT FK_Log13_Funcionario FOREIGN KEY (id_funcionario)
REFERENCES Cadastro_Funcionario(id_funcionario);

ALTER TABLE Cadastro_Funcionario
ADD CONSTRAINT FK_Dept_Funcionario FOREIGN KEY (id_departamento)
REFERENCES Cadastro_Departamento(id_departamento);

/*-- Final do script*/