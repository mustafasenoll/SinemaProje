USE [master]
GO
/****** Object:  Database [SinemaProje]    Script Date: 19.4.2020 22:29:42 ******/
CREATE DATABASE [SinemaProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SinemaProje', FILENAME = N'C:\ssq\SinemaProje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SinemaProje_log', FILENAME = N'C:\ssq\SinemaProje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SinemaProje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SinemaProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SinemaProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SinemaProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SinemaProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SinemaProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SinemaProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [SinemaProje] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SinemaProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SinemaProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SinemaProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SinemaProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SinemaProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SinemaProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SinemaProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SinemaProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SinemaProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SinemaProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SinemaProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SinemaProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SinemaProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SinemaProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SinemaProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SinemaProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SinemaProje] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SinemaProje] SET  MULTI_USER 
GO
ALTER DATABASE [SinemaProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SinemaProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SinemaProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SinemaProje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SinemaProje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SinemaProje] SET QUERY_STORE = OFF
GO
USE [SinemaProje]
GO
/****** Object:  Table [dbo].[Biletler]    Script Date: 19.4.2020 22:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biletler](
	[BiletId] [int] IDENTITY(1,1) NOT NULL,
	[BiletAd] [nvarchar](50) NULL,
	[KoltukAd] [nvarchar](50) NULL,
	[BiletFilmAd] [nvarchar](100) NULL,
 CONSTRAINT [PK_Biletler] PRIMARY KEY CLUSTERED 
(
	[BiletId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Filmler]    Script Date: 19.4.2020 22:29:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Filmler](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAd] [nvarchar](100) NULL,
 CONSTRAINT [PK_Filmler] PRIMARY KEY CLUSTERED 
(
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Biletler] ON 

INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (1, N'Hakan', N'Koltuk3', N'Yüzükler Efendisi
Yüzükler Efendisi')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (2, N'Salih', N'Koltuk13', N'Harry Potter')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (3, N'Mehmet', N'Koltuk11', N'Yüzükler Efendisi
Yüzükler Efendisi')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (4, N'Hakan', N'Koltuk3', N'Harry Potter')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (5, N'Hakan', N'Koltuk1', N'İnception')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (6, N'Osman', N'Koltuk4', N'İnception')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (7, N'Betül', N'Koltuk11', N'İnception')
INSERT [dbo].[Biletler] ([BiletId], [BiletAd], [KoltukAd], [BiletFilmAd]) VALUES (8, N'Esma', N'Koltuk17', N'Yüzükler Efendisi
Yüzükler Efendisi')
SET IDENTITY_INSERT [dbo].[Biletler] OFF
GO
SET IDENTITY_INSERT [dbo].[Filmler] ON 

INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (1, N'Yüzükler Efendisi
Yüzükler Efendisi')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (2, N'Harry Potter')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (3, N'İnception')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (4, N'')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (5, N'')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (6, N'')
INSERT [dbo].[Filmler] ([FilmId], [FilmAd]) VALUES (7, N'')
SET IDENTITY_INSERT [dbo].[Filmler] OFF
GO
USE [master]
GO
ALTER DATABASE [SinemaProje] SET  READ_WRITE 
GO
