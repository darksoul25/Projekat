USE [master]
GO
/****** Object:  Database [PROJEKAT]    Script Date: 27.2.2024. 19:20:12 ******/
CREATE DATABASE [PROJEKAT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROJEKAT', FILENAME = N'C:\Users\pavic\PROJEKAT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROJEKAT_log', FILENAME = N'C:\Users\pavic\PROJEKAT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PROJEKAT] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJEKAT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJEKAT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJEKAT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJEKAT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJEKAT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJEKAT] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJEKAT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROJEKAT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJEKAT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJEKAT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJEKAT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJEKAT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJEKAT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJEKAT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJEKAT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJEKAT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PROJEKAT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJEKAT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJEKAT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJEKAT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJEKAT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJEKAT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJEKAT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJEKAT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROJEKAT] SET  MULTI_USER 
GO
ALTER DATABASE [PROJEKAT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJEKAT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROJEKAT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROJEKAT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROJEKAT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROJEKAT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PROJEKAT] SET QUERY_STORE = OFF
GO
USE [PROJEKAT]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[KorisnickoIme] [varchar](20) NOT NULL,
	[Lozinka] [varchar](20) NOT NULL,
	[Ime] [varchar](20) NOT NULL,
	[Prezime] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[KorisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nastavnik]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nastavnik](
	[JMBG] [char](13) NOT NULL,
	[Ime] [varchar](20) NOT NULL,
	[Prezime] [varchar](20) NOT NULL,
	[Pol] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Nastavnik] PRIMARY KEY CLUSTERED 
(
	[JMBG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NastavnikPredmet]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NastavnikPredmet](
	[JMBGNastavnika] [char](13) NOT NULL,
	[NazivPredmeta] [varchar](20) NOT NULL,
	[Iskustvo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NastavnikPredmet] PRIMARY KEY CLUSTERED 
(
	[JMBGNastavnika] ASC,
	[NazivPredmeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predmet](
	[NazivPredmeta] [varchar](20) NOT NULL,
	[VrstaPredmeta] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Predmet] PRIMARY KEY CLUSTERED 
(
	[NazivPredmeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RasporedNastave]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RasporedNastave](
	[IDRasporeda] [int] IDENTITY(1,1) NOT NULL,
	[SkolskaGodina] [char](7) NOT NULL,
	[Polugodiste] [varchar](10) NOT NULL,
	[JMBGNastavnika] [char](13) NOT NULL,
 CONSTRAINT [PK_RasporedNastave] PRIMARY KEY CLUSTERED 
(
	[IDRasporeda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaRasporeda]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaRasporeda](
	[IDRasporeda] [int] NOT NULL,
	[RedniBroj] [int] NOT NULL,
	[TrajanjeMinuti] [int] NOT NULL,
	[Datum] [date] NOT NULL,
	[VremePocetka] [time](7) NOT NULL,
	[NazivPredmeta] [varchar](20) NOT NULL,
	[BrojUcionice] [int] NOT NULL,
 CONSTRAINT [PK_StavkaRasporeda] PRIMARY KEY CLUSTERED 
(
	[IDRasporeda] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucionica]    Script Date: 27.2.2024. 19:20:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucionica](
	[BrojUcionice] [int] NOT NULL,
	[Kapacitet] [int] NOT NULL,
 CONSTRAINT [PK_Ucionica] PRIMARY KEY CLUSTERED 
(
	[BrojUcionice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administrator] ([KorisnickoIme], [Lozinka], [Ime], [Prezime]) VALUES (N'nikola', N'nikola', N'Nikola', N'Pavic')
INSERT [dbo].[Administrator] ([KorisnickoIme], [Lozinka], [Ime], [Prezime]) VALUES (N'pera', N'pera', N'Pera', N'Peric')
GO
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'0902004770017', N'Sanja', N'Pavic', N'Zensko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2507001770016', N'M', N'M', N'Musko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2507001770017', N'Nikola', N'Pavic', N'Zensko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2507001770018', N'Nikola', N'Kurdz', N'Zensko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2507001778895', N'Nikola', N'Pevke', N'Musko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2507002770012', N'Srdjan', N'Srki', N'Musko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2901003770011', N'iva', N'todoroviv', N'Zensko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'2901003770017', N'Iva', N'todorovic', N'Zensko')
INSERT [dbo].[Nastavnik] ([JMBG], [Ime], [Prezime], [Pol]) VALUES (N'7894563698521', N'Kure', N'Mude', N'Zensko')
GO
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'0902004770017', N'Biologija', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'0902004770017', N'Engleski', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'0902004770017', N'Fizicko', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770016', N'Tehnicko', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770016', N'Veronauka', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770017', N'Fizicko', N'Veliko')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770017', N'Gradjanksko', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770017', N'Matematika', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770018', N'Likovno', N'Srednje')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507001770018', N'Veronauka', N'Veliko')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507002770012', N'Engleski', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2507002770012', N'Fizicko', N'Srednje')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770011', N'Biologija', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770011', N'Engleski', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770011', N'Matematika', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770011', N'Tehnicko', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770017', N'Biologija', N'Veliko')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'2901003770017', N'Fizicko', N'Veliko')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'7894563698521', N'Biologija', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'7894563698521', N'Fizicko', N'Srednje')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'7894563698521', N'Geografija', N'Malo')
INSERT [dbo].[NastavnikPredmet] ([JMBGNastavnika], [NazivPredmeta], [Iskustvo]) VALUES (N'7894563698521', N'Istorija', N'Srednje')
GO
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Arzebejzanski', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Biologija', N'PrirodneNauke')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Engleski', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Fizicko', N'Umetnicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Fizika', N'PrirodneNauke')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Francuski', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Geografija', N'DrustveneNauke')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Gradjanksko', N'Izborni')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Istorija', N'DrustveneNauke')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Likovno', N'Umetnicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Matematika', N'Matematicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Matematika2', N'Matematicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Muzicko', N'Umetnicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Spanksi', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Srpski', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Tehnicko', N'Tehnicki')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'turski', N'Jezici')
INSERT [dbo].[Predmet] ([NazivPredmeta], [VrstaPredmeta]) VALUES (N'Veronauka', N'Izborni')
GO
SET IDENTITY_INSERT [dbo].[RasporedNastave] ON 

INSERT [dbo].[RasporedNastave] ([IDRasporeda], [SkolskaGodina], [Polugodiste], [JMBGNastavnika]) VALUES (21, N'2024/25', N'Prvo', N'2507001770017')
INSERT [dbo].[RasporedNastave] ([IDRasporeda], [SkolskaGodina], [Polugodiste], [JMBGNastavnika]) VALUES (22, N'2029/30', N'Prvo', N'2507001770017')
INSERT [dbo].[RasporedNastave] ([IDRasporeda], [SkolskaGodina], [Polugodiste], [JMBGNastavnika]) VALUES (26, N'2031/32', N'Drugo', N'0902004770017')
INSERT [dbo].[RasporedNastave] ([IDRasporeda], [SkolskaGodina], [Polugodiste], [JMBGNastavnika]) VALUES (27, N'2028/29', N'Prvo', N'2507001770017')
INSERT [dbo].[RasporedNastave] ([IDRasporeda], [SkolskaGodina], [Polugodiste], [JMBGNastavnika]) VALUES (1002, N'2024/25', N'Prvo', N'0902004770017')
SET IDENTITY_INSERT [dbo].[RasporedNastave] OFF
GO
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (21, 1, 30, CAST(N'2024-12-13' AS Date), CAST(N'20:00:00' AS Time), N'Fizicko', 1)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (21, 2, 30, CAST(N'2024-12-13' AS Date), CAST(N'19:00:00' AS Time), N'Fizicko', 1)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (22, 1, 60, CAST(N'2029-12-12' AS Date), CAST(N'15:00:00' AS Time), N'Fizicko', 5)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (22, 2, 60, CAST(N'2029-12-12' AS Date), CAST(N'16:00:00' AS Time), N'Fizicko', 5)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (26, 1, 30, CAST(N'2032-05-05' AS Date), CAST(N'12:00:00' AS Time), N'Biologija', 1)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (26, 2, 30, CAST(N'2032-05-05' AS Date), CAST(N'16:00:00' AS Time), N'Biologija', 5)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (26, 3, 90, CAST(N'2032-05-05' AS Date), CAST(N'15:00:00' AS Time), N'Biologija', 1)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (27, 1, 30, CAST(N'2028-10-12' AS Date), CAST(N'12:00:00' AS Time), N'Fizicko', 1)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (1002, 1, 60, CAST(N'2024-09-02' AS Date), CAST(N'08:00:00' AS Time), N'Biologija', 3)
INSERT [dbo].[StavkaRasporeda] ([IDRasporeda], [RedniBroj], [TrajanjeMinuti], [Datum], [VremePocetka], [NazivPredmeta], [BrojUcionice]) VALUES (1002, 2, 60, CAST(N'2024-09-01' AS Date), CAST(N'08:00:00' AS Time), N'Biologija', 3)
GO
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (1, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (2, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (3, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (4, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (5, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (6, 35)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (7, 40)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (8, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (9, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (10, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (11, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (12, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (13, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (14, 20)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (15, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (16, 25)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (17, 32)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (18, 30)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (19, 20)
INSERT [dbo].[Ucionica] ([BrojUcionice], [Kapacitet]) VALUES (20, 35)
GO
ALTER TABLE [dbo].[NastavnikPredmet]  WITH CHECK ADD  CONSTRAINT [FK_NastavnikPredmet_Nastavnik] FOREIGN KEY([JMBGNastavnika])
REFERENCES [dbo].[Nastavnik] ([JMBG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NastavnikPredmet] CHECK CONSTRAINT [FK_NastavnikPredmet_Nastavnik]
GO
ALTER TABLE [dbo].[NastavnikPredmet]  WITH CHECK ADD  CONSTRAINT [FK_NastavnikPredmet_Predmet] FOREIGN KEY([NazivPredmeta])
REFERENCES [dbo].[Predmet] ([NazivPredmeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NastavnikPredmet] CHECK CONSTRAINT [FK_NastavnikPredmet_Predmet]
GO
ALTER TABLE [dbo].[RasporedNastave]  WITH CHECK ADD  CONSTRAINT [FK_RasporedNastave_Nastavnik] FOREIGN KEY([JMBGNastavnika])
REFERENCES [dbo].[Nastavnik] ([JMBG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[RasporedNastave] CHECK CONSTRAINT [FK_RasporedNastave_Nastavnik]
GO
ALTER TABLE [dbo].[StavkaRasporeda]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRasporeda_Predmet] FOREIGN KEY([NazivPredmeta])
REFERENCES [dbo].[Predmet] ([NazivPredmeta])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaRasporeda] CHECK CONSTRAINT [FK_StavkaRasporeda_Predmet]
GO
ALTER TABLE [dbo].[StavkaRasporeda]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRasporeda_RasporedNastave] FOREIGN KEY([IDRasporeda])
REFERENCES [dbo].[RasporedNastave] ([IDRasporeda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaRasporeda] CHECK CONSTRAINT [FK_StavkaRasporeda_RasporedNastave]
GO
ALTER TABLE [dbo].[StavkaRasporeda]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRasporeda_Ucionica1] FOREIGN KEY([BrojUcionice])
REFERENCES [dbo].[Ucionica] ([BrojUcionice])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaRasporeda] CHECK CONSTRAINT [FK_StavkaRasporeda_Ucionica1]
GO
USE [master]
GO
ALTER DATABASE [PROJEKAT] SET  READ_WRITE 
GO
