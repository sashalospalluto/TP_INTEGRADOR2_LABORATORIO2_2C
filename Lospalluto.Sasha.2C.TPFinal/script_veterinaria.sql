USE [master]
GO
/****** Object:  Database [tp_final]    Script Date: 23/11/2023 9:36:00 ******/
CREATE DATABASE [tp_final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tp_final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tp_final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tp_final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tp_final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [tp_final] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tp_final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tp_final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tp_final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tp_final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tp_final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tp_final] SET ARITHABORT OFF 
GO
ALTER DATABASE [tp_final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tp_final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tp_final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tp_final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tp_final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tp_final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tp_final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tp_final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tp_final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tp_final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tp_final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tp_final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tp_final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tp_final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tp_final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tp_final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tp_final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tp_final] SET RECOVERY FULL 
GO
ALTER DATABASE [tp_final] SET  MULTI_USER 
GO
ALTER DATABASE [tp_final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tp_final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tp_final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tp_final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tp_final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tp_final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'tp_final', N'ON'
GO
ALTER DATABASE [tp_final] SET QUERY_STORE = OFF
GO
USE [tp_final]
GO
/****** Object:  Table [dbo].[doctores]    Script Date: 23/11/2023 9:36:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [int] NULL,
 CONSTRAINT [PK_doctores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascotas]    Script Date: 23/11/2023 9:36:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascotas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_mascota] [varchar](50) NULL,
	[edad] [int] NULL,
	[tipo] [varchar](50) NULL,
	[peso] [float] NULL,
	[nombre_tutor] [varchar](50) NULL,
	[dni_tutor] [int] NULL,
	[IMC] [float] NULL,
 CONSTRAINT [PK_mascotas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veterinaria]    Script Date: 23/11/2023 9:36:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veterinaria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_doctor] [int] NULL,
	[id_mascota] [int] NULL,
	[hora_consulta] [varchar](50) NULL,
 CONSTRAINT [PK_veterinaria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[doctores] ON 

INSERT [dbo].[doctores] ([id], [nombre], [apellido], [dni]) VALUES (1, N'pablo', N'echarri', 21439586)
INSERT [dbo].[doctores] ([id], [nombre], [apellido], [dni]) VALUES (4, N'Joaquin', N'Furriel', 12312312)
INSERT [dbo].[doctores] ([id], [nombre], [apellido], [dni]) VALUES (5, N'Mauricio', N'Macri', 21439588)
SET IDENTITY_INSERT [dbo].[doctores] OFF
GO
SET IDENTITY_INSERT [dbo].[mascotas] ON 

INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (1, N'max', 5, N'Perro', 30, N'Sasha', 40422602, 0.01875)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (2, N'Nube', 4, N'Perro', 20, N'Jaim', 50142659, NULL)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (3, N'Lucy', 3, N'Gato', 12, N'Ailen', 41695321, NULL)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (5, N'raul', 12, N'Gato', 3, N'rosana', 10123123, 0.0014177693761814746)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (6, N'lolo', 4, N'Perro', 12, N'luis', 10444333, 0)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (10, N'dv', 48, N'Perro', 26, N'fgfdgd', 12345678, NULL)
INSERT [dbo].[mascotas] ([id], [nombre_mascota], [edad], [tipo], [peso], [nombre_tutor], [dni_tutor], [IMC]) VALUES (11, N'kuki', 11, N'Perro', 9, N'Mabel', 70111222, 0.0022675736961451248)
SET IDENTITY_INSERT [dbo].[mascotas] OFF
GO
USE [master]
GO
ALTER DATABASE [tp_final] SET  READ_WRITE 
GO
