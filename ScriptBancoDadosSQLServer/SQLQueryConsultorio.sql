USE [master]
GO
/****** Object:  Database [Consultorio]    Script Date: 18/05/2023 21:11:53 ******/
CREATE DATABASE [Consultorio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Consultorio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Consultorio.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Consultorio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Consultorio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Consultorio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Consultorio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Consultorio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Consultorio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Consultorio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Consultorio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Consultorio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Consultorio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Consultorio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Consultorio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Consultorio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Consultorio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Consultorio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Consultorio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Consultorio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Consultorio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Consultorio] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Consultorio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Consultorio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Consultorio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Consultorio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Consultorio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Consultorio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Consultorio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Consultorio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Consultorio] SET  MULTI_USER 
GO
ALTER DATABASE [Consultorio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Consultorio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Consultorio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Consultorio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Consultorio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Consultorio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Consultorio] SET QUERY_STORE = ON
GO
ALTER DATABASE [Consultorio] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Consultorio]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[IDconsulta] [int] IDENTITY(1,1) NOT NULL,
	[NomeMedico] [varchar](100) NOT NULL,
	[NomePaciente] [varchar](100) NOT NULL,
	[Data] [varchar](20) NOT NULL,
	[Horario] [varchar](20) NOT NULL,
	[Retorno] [varchar](10) NOT NULL,
	[idMedico] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDconsulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[IDmedico] [int] IDENTITY(1,1) NOT NULL,
	[NomeMedico] [varchar](100) NOT NULL,
	[TelefoneMedico] [varchar](20) NOT NULL,
	[ValorConsulta] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDmedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IDpaciente] [int] IDENTITY(1,1) NOT NULL,
	[NomePaciente] [varchar](100) NOT NULL,
	[Endereco] [varchar](200) NOT NULL,
	[Numero] [int] NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Cep] [varchar](20) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Calular] [varchar](20) NOT NULL,
	[Sexo] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDpaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [FK_medico] FOREIGN KEY([idMedico])
REFERENCES [dbo].[Medico] ([IDmedico])
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [FK_medico]
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [FK_paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([IDpaciente])
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [FK_paciente]
GO
/****** Object:  StoredProcedure [dbo].[proMedicoInserir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proMedicoInserir]
 @NomeMedico varchar(100),
 @TelefoneMedico varchar(20),
 @ValorConsulta varchar(20)


as
begin
	INSERT INTO Medico
	(
		NomeMedico,
		TelefoneMedico,
		ValorConsulta
		

	)
	VALUES
	(
		@NomeMedico,
		@TelefoneMedico,
		@ValorConsulta
		
	)
	SELECT @@IDENTITY AS Retorno

end
GO
/****** Object:  StoredProcedure [dbo].[usConsultaAlterar]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usConsultaAlterar]
	@IDconsulta int,
     @NomeMedico varchar(100),
	 @NomePaciente varchar(100),
	 @Data varchar(20),
	 @Horario varchar(20),
	 @Retorno varchar(10),
	 @idMedico int,
	 @idPaciente int

as
begin
	update Consultas
		SET

	    NomeMedico = @NomeMedico,
		NomePaciente = @NomePaciente,
		Data = @Data,
		Horario = @Horario,
		Retorno = @Retorno,
		idMedico = @idMedico,
		idPaciente = @idPaciente
		

		WHERE 
			IDconsulta = @IDconsulta

		SELECT @IDconsulta AS Retorno
end


GO
/****** Object:  StoredProcedure [dbo].[usConsultaConsultarPorID]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usConsultaConsultarPorID]
		@IDconsulta int
as
begin
	SELECT	 
		IDconsulta,
		NomeMedico,
		NomePaciente,
		Data,
		Horario,
		Retorno,
		idMedico,
		idPaciente
		

		FROM Consultas

		WHERE
		IDconsulta = @IDconsulta

end
GO
/****** Object:  StoredProcedure [dbo].[usConsultaConsultarPorNomePaciente]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usConsultaConsultarPorNomePaciente]
		@NomePaciente varchar(100)
as
begin
	SELECT	 
		IDconsulta,
		NomeMedico,
		NomePaciente,
		Data,
		Horario,
		Retorno,
		idMedico,
		idPaciente
		

		FROM Consultas

		WHERE
		NomePaciente LIKE '%' + @NomePaciente + '%'

end
GO
/****** Object:  StoredProcedure [dbo].[usConsultaExcluir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usConsultaExcluir]
	@IDconsulta int
as
begin
	DELETE FROM Consultas

	where
	IDconsulta = @IDconsulta

	SELECT
	@IDconsulta AS Retorno

end
GO
/****** Object:  StoredProcedure [dbo].[usConsultaInserir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usConsultaInserir]
     @NomeMedico varchar(100),
	  @NomePaciente varchar(100),
	 @Data varchar(20),
	 @Horario varchar(20),
	 @Retorno varchar(10),
	 @idMedico int,
	 @idPaciente int
	

as
begin
	Insert into Consultas
	(
		NomeMedico,
		NomePaciente,
		Data,
		Horario,
		Retorno,
		idMedico,
		idPaciente
		
	)
	VALUES
	(
		@NomeMedico,
		@NomePaciente,
		@Data,
		@Horario,
		@Retorno,
		@idMedico,
		@idPaciente
	
	)
	SELECT @@IDENTITY AS Retorno
end
GO
/****** Object:  StoredProcedure [dbo].[usPacienteInserir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usPacienteInserir]
    @NomePaciente varchar(100),
	@Endereco varchar(200),
	@Numero int,
	@Bairro varchar(50),
	@Cidade varchar(50),
	@Cep varchar(20),
	@Telefone varchar(20),
	@Calular varchar(20),
	@Sexo varchar(10)
	
as
begin

insert into Paciente
	(
		
	NomePaciente,
	Endereco,
	Numero,
	Bairro,
	Cidade,
	Cep,
	Telefone,
	Calular,
	Sexo

	)
Values
	(
		@NomePaciente,
		@Endereco,
		@Numero,
		@Bairro,
		@Cidade,
		@Cep,
		@Telefone,
		@Calular,
		@Sexo
	)
	
SELECT @@IDENTITY as Retorno
	
end
GO
/****** Object:  StoredProcedure [dbo].[uspMedicoAlterar]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspMedicoAlterar]
	@IDmedico int,
	@NomeMedico nchar(100),
	@TelefoneMedico varchar(20),
	@ValorConsulta varbinary(20)

as
begin

	update Medico
	set 
		NomeMedico = @IDmedico,
		TelefoneMedico = @TelefoneMedico,
		ValorConsulta = @ValorConsulta

	where 
		IDmedico = @IDmedico

	select @IDmedico AS Retorno

end
GO
/****** Object:  StoredProcedure [dbo].[uspMedicoConsultarPorID]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspMedicoConsultarPorID]
	@IDmedico int
AS
BEGIN

	SELECT 
		IDmedico,
		TelefoneMedico,
		ValorConsulta
		
	FROM
	  Medico
	WHERE
	  IDmedico = @IDmedico

END
GO
/****** Object:  StoredProcedure [dbo].[uspMedicoConsultarPorNome]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspMedicoConsultarPorNome]
	@NomeMedico varchar(100)
AS
BEGIN

	SELECT 
		IDmedico,
		NomeMedico,
		TelefoneMedico,
		ValorConsulta
		
	FROM
	  Medico
	WHERE
	  NomeMedico LIKE '%' + @NomeMedico + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[uspMedicoExcluir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspMedicoExcluir]
	@IDmedico int
as
begin
	DELETE FROM 
		Medico
	Where
		IDmedico = @IDmedico

	SELECT @IDmedico as Retorno
end
GO
/****** Object:  StoredProcedure [dbo].[uspPacienteAlterar]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPacienteAlterar]
	@IDpaciente int,
	@NomePaciente varchar(100),
	@Endereco varchar(200),
	@Numero int,
	@Bairro varchar(50),
	@Cidade varchar(50),
	@Cep varchar(20),
	@Telefone varchar(20),
	@Calular varchar(20),
	@Sexo varchar(10)
	
	
as 
begin
	update Paciente 
	set 
	NomePaciente = @NomePaciente,
	Endereco = @Endereco,
	Numero = @Numero,
	Bairro = @Bairro,
	Cidade = @Cidade,
	Cep = @Cep,
	Telefone = @Telefone,
	Calular = @Calular,
	Sexo = @Sexo
	
	
	WHERE IDpaciente = @IDpaciente

	SELECT @IDpaciente as Retorno


end
GO
/****** Object:  StoredProcedure [dbo].[uspPacienteConsultarPorID]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPacienteConsultarPorID]
	@IDpaciente int
AS
BEGIN
	SELECT 
		IDpaciente,
		NomePaciente,
		Endereco,
		Numero,
		Bairro,
		Cidade,
		Cep,
		Telefone,
		Calular,
		Sexo
		
		

	from Paciente
	WHERE IDpaciente = @IDpaciente
END
GO
/****** Object:  StoredProcedure [dbo].[uspPacienteConsultarPorNome]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPacienteConsultarPorNome]
	@NomePaciente varchar(100)
as
begin

select
	IDpaciente,
	NomePaciente,
	Endereco,
	Numero,
	Bairro,
	Cidade,
	Cep,
	Telefone,
	Calular,
	Sexo

	
FROM
	Paciente
WHERE
	NomePaciente LIKE '%' + @NomePaciente + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspPacienteExcluir]    Script Date: 18/05/2023 21:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPacienteExcluir]
	@IDpaciente int
as
begin
	delete from Paciente

	where IDpaciente = @IDpaciente
	select @IDpaciente as Retorno

end
GO
EXEC [Consultorio].sys.sp_addextendedproperty @name=N'IDpaciente', @value=N'int null' 
GO
USE [master]
GO
ALTER DATABASE [Consultorio] SET  READ_WRITE 
GO
