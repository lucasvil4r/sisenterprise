/****** Object:  Database [sisenterprise]    Script Date: 04/10/2023 14:53:05 ******/
CREATE DATABASE [sisenterprise]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 2 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [sisenterprise] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [sisenterprise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sisenterprise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sisenterprise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sisenterprise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sisenterprise] SET ARITHABORT OFF 
GO
ALTER DATABASE [sisenterprise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sisenterprise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sisenterprise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sisenterprise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sisenterprise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sisenterprise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sisenterprise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sisenterprise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sisenterprise] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [sisenterprise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sisenterprise] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [sisenterprise] SET  MULTI_USER 
GO
ALTER DATABASE [sisenterprise] SET ENCRYPTION ON
GO
ALTER DATABASE [sisenterprise] SET QUERY_STORE = ON
GO
ALTER DATABASE [sisenterprise] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** Os scripts das configurações no escopo do banco de dados no Azure devem ser executados dentro da conexão de banco de dados de destino. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cadastro_Departamento]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadastro_Departamento](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nome_departamento] [varchar](255) NULL,
	[gerente] [varchar](255) NULL,
	[supervisor] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cadastro_Ferias]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadastro_Ferias](
	[id_ferias] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NULL,
	[qtd_dias] [int] NULL,
	[data_cadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ferias] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cadastro_Funcionario]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cadastro_Funcionario](
	[id_funcionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[cpf] [varchar](14) NULL,
	[endereco] [varchar](255) NULL,
	[data_nascimento] [date] NULL,
	[salario] [decimal](10, 2) NULL,
	[email] [varchar](255) NULL,
	[id_departamento] [int] NULL,
	[telefone] [varchar](20) NULL,
	[data_admissao] [date] NULL,
	[data_alteracao] [datetime] NULL,
	[data_cadastro] [datetime] NULL,
	[path_foto3x4] [varchar](255) NULL,
	[qtd_dependentes] [int] NULL,
	[qtd_horas_trabalhadas] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_funcionario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionarios]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Salario] [decimal](18, 2) NULL,
	[Ativo] [bit] NULL,
	[CPF] [varchar](50) NULL,
	[NomeMeio] [varchar](50) NULL,
	[Telefone] [varchar](50) NULL,
	[DataAdmissao] [date] NULL,
	[Endereco] [nvarchar](50) NULL,
	[Matricula] [int] NOT NULL,
	[SobreNome] [varchar](50) NULL,
	[DataNascimento] [date] NULL,
	[Email] [varchar](50) NULL,
	[RG] [varchar](50) NULL,
	[DataAlteracao] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Funcionarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log_calculo_13]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log_calculo_13](
	[id_log_13] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NULL,
	[valor_calculado] [decimal](10, 2) NULL,
	[data_calculo] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_log_13] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log_calculo_ferias]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log_calculo_ferias](
	[id_log_ferias] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NULL,
	[valor_calculado] [decimal](10, 2) NULL,
	[data_calculo] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_log_ferias] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login_Usuario]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NULL,
	[login] [varchar](50) NULL,
	[pass] [varchar](255) NULL,
	[tipo] [varchar](50) NULL,
	[ativo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcacao_de_ponto]    Script Date: 04/10/2023 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcacao_de_ponto](
	[id_marcacao_ponto] [int] IDENTITY(1,1) NOT NULL,
	[id_funcionario] [int] NULL,
	[data_horario_entrada] [datetime] NULL,
	[data_horario_saida] [datetime] NULL,
	[local] [varchar](255) NULL,
	[status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_marcacao_ponto] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cadastro_Ferias]  WITH CHECK ADD  CONSTRAINT [FK_Ferias_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Cadastro_Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Cadastro_Ferias] CHECK CONSTRAINT [FK_Ferias_Funcionario]
GO
ALTER TABLE [dbo].[Cadastro_Funcionario]  WITH CHECK ADD  CONSTRAINT [FK_Dept_Funcionario] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[Cadastro_Departamento] ([id_departamento])
GO
ALTER TABLE [dbo].[Cadastro_Funcionario] CHECK CONSTRAINT [FK_Dept_Funcionario]
GO
ALTER TABLE [dbo].[Log_calculo_13]  WITH CHECK ADD  CONSTRAINT [FK_Log13_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Cadastro_Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Log_calculo_13] CHECK CONSTRAINT [FK_Log13_Funcionario]
GO
ALTER TABLE [dbo].[Log_calculo_ferias]  WITH CHECK ADD  CONSTRAINT [FK_LogFerias_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Cadastro_Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Log_calculo_ferias] CHECK CONSTRAINT [FK_LogFerias_Funcionario]
GO
ALTER TABLE [dbo].[Marcacao_de_ponto]  WITH CHECK ADD  CONSTRAINT [FK_Marcacao_Funcionario] FOREIGN KEY([id_funcionario])
REFERENCES [dbo].[Cadastro_Funcionario] ([id_funcionario])
GO
ALTER TABLE [dbo].[Marcacao_de_ponto] CHECK CONSTRAINT [FK_Marcacao_Funcionario]
GO
ALTER DATABASE [sisenterprise] SET  READ_WRITE 
GO
