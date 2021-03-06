USE [master]
GO
/****** Object:  Database [LinQToSql]    Script Date: 30/07/2021 16:19:35 ******/
CREATE DATABASE [LinQToSql] ON  PRIMARY 
( NAME = N'LinQToSql', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSVANESA\MSSQL\DATA\LinQToSql.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LinQToSql_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSVANESA\MSSQL\DATA\LinQToSql_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LinQToSql] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LinQToSql].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LinQToSql] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LinQToSql] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LinQToSql] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LinQToSql] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LinQToSql] SET ARITHABORT OFF 
GO
ALTER DATABASE [LinQToSql] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LinQToSql] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LinQToSql] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LinQToSql] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LinQToSql] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LinQToSql] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LinQToSql] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LinQToSql] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LinQToSql] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LinQToSql] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LinQToSql] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LinQToSql] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LinQToSql] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LinQToSql] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LinQToSql] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LinQToSql] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LinQToSql] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LinQToSql] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LinQToSql] SET  MULTI_USER 
GO
ALTER DATABASE [LinQToSql] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LinQToSql] SET DB_CHAINING OFF 
GO
USE [LinQToSql]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Nombre] [varchar](50) NULL,
	[Apellido1] [varchar](50) NULL,
	[Apellido2] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Nombre], [Apellido1], [Apellido2], [Telefono]) VALUES (N'PEPE', N'PEREZ', N'PERNIA', N'44322343')
INSERT [dbo].[Clientes] ([Nombre], [Apellido1], [Apellido2], [Telefono]) VALUES (N'PACO', N'LOPEZ', N'PEREZ', N'9864655221')
INSERT [dbo].[Clientes] ([Nombre], [Apellido1], [Apellido2], [Telefono]) VALUES (N'MANOLO', N'LOPEZ', N'FERNANDEZ', N'67623498')
GO
/****** Object:  StoredProcedure [dbo].[buscarcliente]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarcliente]
@Nombre varchar(50)
AS
SELECT * from Clientes
where Nombre LIKE '%'+@Nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarCliente]
@Nombre varchar(50)
AS
Delete from Clientes
WHERE @Nombre=Nombre
GO
/****** Object:  StoredProcedure [dbo].[insertarcliente]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarcliente]
@nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO Clientes(Nombre, Apellido1, Apellido2, Telefono)
VALUES(@nombre, @Apellido1, @Apellido2,@telefono)
GO
/****** Object:  StoredProcedure [dbo].[ListarClientes]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarClientes]
AS
SELECT * FROM Clientes;
GO
/****** Object:  StoredProcedure [dbo].[modificarcliente]    Script Date: 30/07/2021 16:19:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modificarcliente]
@nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
UPDATE Clientes
SET Nombre=@nombre, Apellido1=@Apellido1, @Apellido2=@Apellido2, Telefono=@telefono
WHERE Nombre=@nombre
GO
USE [master]
GO
ALTER DATABASE [LinQToSql] SET  READ_WRITE 
GO
