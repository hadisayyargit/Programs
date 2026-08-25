
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/12/2016 21:09:00
-- Generated from EDMX file: D:\Documents\Hadi\Projects\Programs\TuAnbar\shahriarco.Anbar\Models\AnbarModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TAnb94];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TKala_TAnb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TKala] DROP CONSTRAINT [FK_TKala_TAnb];
GO
IF OBJECT_ID(N'[dbo].[FK_TMad_TAnb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMad] DROP CONSTRAINT [FK_TMad_TAnb];
GO
IF OBJECT_ID(N'[dbo].[FK_THesKala_TKala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[THesKala] DROP CONSTRAINT [FK_THesKala_TKala];
GO
IF OBJECT_ID(N'[dbo].[FK_THesMad_TMadItm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[THesMad] DROP CONSTRAINT [FK_THesMad_TMadItm];
GO
IF OBJECT_ID(N'[dbo].[FK_THesMar_TMar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[THesMar] DROP CONSTRAINT [FK_THesMar_TMar];
GO
IF OBJECT_ID(N'[dbo].[FK_TMarKala_TKala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMarKala] DROP CONSTRAINT [FK_TMarKala_TKala];
GO
IF OBJECT_ID(N'[dbo].[FK_TMadItm_TMad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMadItm] DROP CONSTRAINT [FK_TMadItm_TMad];
GO
IF OBJECT_ID(N'[dbo].[FK_TMadIEnt_TMadEnt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMadIEnt] DROP CONSTRAINT [FK_TMadIEnt_TMadEnt];
GO
IF OBJECT_ID(N'[dbo].[FK_TMadItm_TMarKala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMadItm] DROP CONSTRAINT [FK_TMadItm_TMarKala];
GO
IF OBJECT_ID(N'[dbo].[FK_TMahD_TMah]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMahD] DROP CONSTRAINT [FK_TMahD_TMah];
GO
IF OBJECT_ID(N'[dbo].[FK_TProjectD_TMah]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TProjectD] DROP CONSTRAINT [FK_TProjectD_TMah];
GO
IF OBJECT_ID(N'[dbo].[FK_TMarKala_TMar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TMarKala] DROP CONSTRAINT [FK_TMarKala_TMar];
GO
IF OBJECT_ID(N'[dbo].[FK_TProjectD_TProject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TProjectD] DROP CONSTRAINT [FK_TProjectD_TProject];
GO
IF OBJECT_ID(N'[dbo].[FK_TProjectDItm_TProjectD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TProjectDItm] DROP CONSTRAINT [FK_TProjectDItm_TProjectD];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TAnb]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TAnb];
GO
IF OBJECT_ID(N'[dbo].[TCurrent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TCurrent];
GO
IF OBJECT_ID(N'[dbo].[THes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THes];
GO
IF OBJECT_ID(N'[dbo].[THesAnb]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THesAnb];
GO
IF OBJECT_ID(N'[dbo].[THesKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THesKala];
GO
IF OBJECT_ID(N'[dbo].[THesMad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THesMad];
GO
IF OBJECT_ID(N'[dbo].[THesMar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THesMar];
GO
IF OBJECT_ID(N'[dbo].[TKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TKala];
GO
IF OBJECT_ID(N'[dbo].[TMad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMad];
GO
IF OBJECT_ID(N'[dbo].[TMadEnt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMadEnt];
GO
IF OBJECT_ID(N'[dbo].[TMadIEnt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMadIEnt];
GO
IF OBJECT_ID(N'[dbo].[TMadItm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMadItm];
GO
IF OBJECT_ID(N'[dbo].[TMah]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMah];
GO
IF OBJECT_ID(N'[dbo].[TMahD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMahD];
GO
IF OBJECT_ID(N'[dbo].[TMar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMar];
GO
IF OBJECT_ID(N'[dbo].[TMarKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMarKala];
GO
IF OBJECT_ID(N'[dbo].[TMedia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMedia];
GO
IF OBJECT_ID(N'[dbo].[TMediaKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMediaKala];
GO
IF OBJECT_ID(N'[dbo].[TMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMenu];
GO
IF OBJECT_ID(N'[dbo].[TMenuD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TMenuD];
GO
IF OBJECT_ID(N'[dbo].[TProject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TProject];
GO
IF OBJECT_ID(N'[dbo].[TProjectD]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TProjectD];
GO
IF OBJECT_ID(N'[dbo].[TProjectDItm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TProjectDItm];
GO
IF OBJECT_ID(N'[dbo].[TUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TUser];
GO
IF OBJECT_ID(N'[dbo].[TUserAccess]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TUserAccess];
GO
IF OBJECT_ID(N'[dbo].[TVahed]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TVahed];
GO
IF OBJECT_ID(N'[dbo].[THavRez]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THavRez];
GO
IF OBJECT_ID(N'[dbo].[THavRezItm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[THavRezItm];
GO
IF OBJECT_ID(N'[dbo].[TParmtr]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TParmtr];
GO
IF OBJECT_ID(N'[dbo].[TSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TSet];
GO
IF OBJECT_ID(N'[dbo].[QAnbar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QAnbar];
GO
IF OBJECT_ID(N'[dbo].[QAnbarKalaCode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QAnbarKalaCode];
GO
IF OBJECT_ID(N'[dbo].[QAnbarValid]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QAnbarValid];
GO
IF OBJECT_ID(N'[dbo].[QCardex]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QCardex];
GO
IF OBJECT_ID(N'[dbo].[QCardex_THav]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QCardex_THav];
GO
IF OBJECT_ID(N'[dbo].[QCardexAK]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QCardexAK];
GO
IF OBJECT_ID(N'[dbo].[QCardexM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QCardexM];
GO
IF OBJECT_ID(N'[dbo].[QDarkhast]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QDarkhast];
GO
IF OBJECT_ID(N'[dbo].[QDCardex_AvalDoreh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QDCardex_AvalDoreh];
GO
IF OBJECT_ID(N'[dbo].[QDCardex_Ghabz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QDCardex_Ghabz];
GO
IF OBJECT_ID(N'[dbo].[QDCardex_Havaleh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QDCardex_Havaleh];
GO
IF OBJECT_ID(N'[dbo].[QGardesh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardesh];
GO
IF OBJECT_ID(N'[dbo].[QGardeshIn]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardeshIn];
GO
IF OBJECT_ID(N'[dbo].[QGardeshNM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardeshNM];
GO
IF OBJECT_ID(N'[dbo].[QGardeshNMIn]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardeshNMIn];
GO
IF OBJECT_ID(N'[dbo].[QGardeshNMOut]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardeshNMOut];
GO
IF OBJECT_ID(N'[dbo].[QGardeshOut]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QGardeshOut];
GO
IF OBJECT_ID(N'[dbo].[QHavaleh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHavaleh];
GO
IF OBJECT_ID(N'[dbo].[QHavalehMoujod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHavalehMoujod];
GO
IF OBJECT_ID(N'[dbo].[QHavHavItm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHavHavItm];
GO
IF OBJECT_ID(N'[dbo].[QHavItm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHavItm];
GO
IF OBJECT_ID(N'[dbo].[QHesab]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHesab];
GO
IF OBJECT_ID(N'[dbo].[QHesabAnbar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHesabAnbar];
GO
IF OBJECT_ID(N'[dbo].[QHesabKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHesabKala];
GO
IF OBJECT_ID(N'[dbo].[QHesabMarkaz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QHesabMarkaz];
GO
IF OBJECT_ID(N'[dbo].[QKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QKala];
GO
IF OBJECT_ID(N'[dbo].[QKalaAnbar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QKalaAnbar];
GO
IF OBJECT_ID(N'[dbo].[QMadrak]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QMadrak];
GO
IF OBJECT_ID(N'[dbo].[QMadrakItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QMadrakItem];
GO
IF OBJECT_ID(N'[dbo].[QMadrakItem2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QMadrakItem2];
GO
IF OBJECT_ID(N'[dbo].[QMadrakMadrakItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QMadrakMadrakItem];
GO
IF OBJECT_ID(N'[dbo].[QMarkazKalaUnValid]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QMarkazKalaUnValid];
GO
IF OBJECT_ID(N'[dbo].[QRaked]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QRaked];
GO
IF OBJECT_ID(N'[dbo].[QRHesabKala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QRHesabKala];
GO
IF OBJECT_ID(N'[dbo].[QRHesabMarkaz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QRHesabMarkaz];
GO
IF OBJECT_ID(N'[dbo].[QSanad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSanad];
GO
IF OBJECT_ID(N'[dbo].[QSanadNonUpdatable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSanadNonUpdatable];
GO
IF OBJECT_ID(N'[dbo].[QSefPoint]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSefPoint];
GO
IF OBJECT_ID(N'[dbo].[QShomaresh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QShomaresh];
GO
IF OBJECT_ID(N'[dbo].[QSumAvalDoreh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumAvalDoreh];
GO
IF OBJECT_ID(N'[dbo].[QSumAvaldorehNM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumAvaldorehNM];
GO
IF OBJECT_ID(N'[dbo].[QSumAvalDorehNMR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumAvalDorehNMR];
GO
IF OBJECT_ID(N'[dbo].[QSumGhabz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumGhabz];
GO
IF OBJECT_ID(N'[dbo].[QSumGhabzNM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumGhabzNM];
GO
IF OBJECT_ID(N'[dbo].[QSumGhabzNMR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumGhabzNMR];
GO
IF OBJECT_ID(N'[dbo].[QSumGhabzNMT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumGhabzNMT];
GO
IF OBJECT_ID(N'[dbo].[QSumHavaleh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumHavaleh];
GO
IF OBJECT_ID(N'[dbo].[QSumHavalehNM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumHavalehNM];
GO
IF OBJECT_ID(N'[dbo].[QSumHavalehNMR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumHavalehNMR];
GO
IF OBJECT_ID(N'[dbo].[QSumHavalehNMT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QSumHavalehNMT];
GO
IF OBJECT_ID(N'[dbo].[QtempDarkhast]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QtempDarkhast];
GO
IF OBJECT_ID(N'[dbo].[QUpdate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QUpdate];
GO
IF OBJECT_ID(N'[dbo].[QUpdate_THav]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QUpdate_THav];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TAnb'
CREATE TABLE [dbo].[TAnb] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL
);
GO

-- Creating table 'TCurrent'
CREATE TABLE [dbo].[TCurrent] (
    [SalMali] nvarchar(50)  NOT NULL,
    [CoName] nvarchar(150)  NULL,
    [FEndReport] nvarchar(250)  NULL,
    [FEndReport1] nvarchar(50)  NULL,
    [FEndReport2] nvarchar(50)  NULL,
    [FEndReport3] nvarchar(50)  NULL,
    [FEndPage1] nvarchar(50)  NULL,
    [FEndPage2] nvarchar(50)  NULL,
    [FEndPage3] nvarchar(50)  NULL
);
GO

-- Creating table 'THes'
CREATE TABLE [dbo].[THes] (
    [Radif] int  NULL,
    [SalMali] nvarchar(50)  NULL,
    [Kol] int  NOT NULL,
    [Moein] int  NOT NULL,
    [Tafzili] int  NOT NULL,
    [Joz] int  NOT NULL,
    [Sharh] nvarchar(150)  NULL,
    [Type] tinyint  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'THesAnb'
CREATE TABLE [dbo].[THesAnb] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [Kol] int  NOT NULL,
    [Moein] int  NOT NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'THesKala'
CREATE TABLE [dbo].[THesKala] (
    [SalMali] nvarchar(50)  NULL,
    [KalaCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'THesMad'
CREATE TABLE [dbo].[THesMad] (
    [SalMali] nvarchar(50)  NOT NULL,
    [MadrakCode] int  NULL,
    [MadrakRadif] int  NULL,
    [MadrakType] tinyint  NULL,
    [AnbarCode] int  NOT NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Meghdar] float  NULL,
    [Bed] float  NULL,
    [Bes] float  NULL,
    [IsSanad] bit  NOT NULL,
    [SanadID] int  NULL,
    [SanadRadif] int  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'THesMar'
CREATE TABLE [dbo].[THesMar] (
    [SalMali] nvarchar(50)  NULL,
    [MarkazCode] int  NOT NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'TKala'
CREATE TABLE [dbo].[TKala] (
    [SalMali] nvarchar(50)  NOT NULL,
    [KalaCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaVahedCode] int  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [KalaEst1] int  NULL,
    [KalaEst2] int  NULL,
    [KalaEst3] int  NULL,
    [KalaEst4] int  NULL,
    [KalaEst5] int  NULL,
    [KalaEst6] int  NULL,
    [KalaEst7] int  NULL,
    [KalaEst8] int  NULL,
    [KalaEst9] int  NULL,
    [KalaEst10] int  NULL,
    [KalaEst11] int  NULL,
    [KalaEst12] int  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaMomaiez] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaZaribVahed] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [Darkhast] int  NULL,
    [SharhDarkhast] nvarchar(150)  NULL,
    [Shomaresh1] float  NULL,
    [Shomaresh2] float  NULL,
    [Shomaresh3] float  NULL,
    [ShomareshNahaei] float  NULL
);
GO

-- Creating table 'TMad'
CREATE TABLE [dbo].[TMad] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakActive] tinyint  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'TMadEnt'
CREATE TABLE [dbo].[TMadEnt] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakActive] tinyint  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'TMadIEnt'
CREATE TABLE [dbo].[TMadIEnt] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] int  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [MojodiMeghdari] float  NULL,
    [MojodiRiali] float  NULL
);
GO

-- Creating table 'TMadItm'
CREATE TABLE [dbo].[TMadItm] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] int  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [MojodiMeghdari] float  NULL,
    [MojodiRiali] float  NULL
);
GO

-- Creating table 'TMah'
CREATE TABLE [dbo].[TMah] (
    [SalMali] nvarchar(50)  NULL,
    [IDMah] int  NOT NULL,
    [MahName] nvarchar(50)  NULL
);
GO

-- Creating table 'TMahD'
CREATE TABLE [dbo].[TMahD] (
    [SalMali] nvarchar(50)  NULL,
    [IDMah] int  NOT NULL,
    [Radif] int  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NULL,
    [MarkazCode] int  NULL,
    [Jence] nvarchar(50)  NULL,
    [Moshakhasat] nvarchar(50)  NULL,
    [CMeghdar] float  NULL,
    [Tedad] float  NULL
);
GO

-- Creating table 'TMar'
CREATE TABLE [dbo].[TMar] (
    [SalMali] nvarchar(50)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL
);
GO

-- Creating table 'TMarKala'
CREATE TABLE [dbo].[TMarKala] (
    [SalMali] nvarchar(50)  NULL,
    [KalaCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] int  NOT NULL
);
GO

-- Creating table 'TMedia'
CREATE TABLE [dbo].[TMedia] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(500)  NULL,
    [Media] varbinary(max)  NOT NULL,
    [FileType] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TMediaKala'
CREATE TABLE [dbo].[TMediaKala] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MediaID] int  NOT NULL,
    [SalMali] nvarchar(50)  NOT NULL,
    [KalaCode] bigint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [Sequence] int  NOT NULL,
    [Description] nvarchar(50)  NULL
);
GO

-- Creating table 'TMenu'
CREATE TABLE [dbo].[TMenu] (
    [IDMenu] int  NOT NULL,
    [MenuName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TMenuD'
CREATE TABLE [dbo].[TMenuD] (
    [IDMenu] int  NOT NULL,
    [Radif] int  NOT NULL,
    [Item] varchar(100)  NOT NULL
);
GO

-- Creating table 'TProject'
CREATE TABLE [dbo].[TProject] (
    [SalMali] nvarchar(50)  NULL,
    [PRJ_ID] int  NOT NULL,
    [PrjName] nvarchar(50)  NOT NULL,
    [Karfarma] nvarchar(50)  NULL,
    [PDate] nvarchar(50)  NOT NULL,
    [PTahiye] nvarchar(50)  NULL
);
GO

-- Creating table 'TProjectD'
CREATE TABLE [dbo].[TProjectD] (
    [SalMali] nvarchar(50)  NULL,
    [PRJ_ID] int  NOT NULL,
    [Radif] int  NOT NULL,
    [IDMah] int  NOT NULL,
    [Tedad] float  NOT NULL,
    [Tozihat] nvarchar(100)  NOT NULL,
    [Mojodi] float  NULL,
    [MojodiManfi] float  NULL
);
GO

-- Creating table 'TProjectDItm'
CREATE TABLE [dbo].[TProjectDItm] (
    [SalMali] nvarchar(50)  NULL,
    [PRJ_ID] int  NOT NULL,
    [Radif] int  NOT NULL,
    [IDMah] int  NOT NULL,
    [RadifM] int  NOT NULL,
    [Tedad] float  NOT NULL,
    [Mojodi] float  NULL,
    [MojodiManfi] float  NULL,
    [Havaleh] bit  NULL,
    [Havaleh_NO] int  NULL
);
GO

-- Creating table 'TUser'
CREATE TABLE [dbo].[TUser] (
    [IDUser] int  NOT NULL,
    [LoginName] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(15)  NOT NULL,
    [LastName] nvarchar(25)  NOT NULL,
    [Display] nvarchar(50)  NOT NULL,
    [BirthDate] nvarchar(50)  NOT NULL,
    [Sex] tinyint  NOT NULL,
    [Tel] nvarchar(50)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Semat] nvarchar(50)  NOT NULL,
    [IsOnline] bit  NULL
);
GO

-- Creating table 'TUserAccess'
CREATE TABLE [dbo].[TUserAccess] (
    [IDUser] int  NOT NULL,
    [Radif] int  NOT NULL,
    [Item] nvarchar(20)  NOT NULL,
    [aRead] tinyint  NOT NULL,
    [aCreate] tinyint  NOT NULL,
    [aUpdate] tinyint  NOT NULL,
    [aDelete] tinyint  NOT NULL
);
GO

-- Creating table 'TVahed'
CREATE TABLE [dbo].[TVahed] (
    [VahedCode] int  NOT NULL,
    [SalMali] nvarchar(50)  NULL,
    [VahedName] nvarchar(150)  NULL
);
GO

-- Creating table 'THavRez'
CREATE TABLE [dbo].[THavRez] (
    [salMali] nvarchar(50)  NULL,
    [HavalehDate] nvarchar(50)  NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehType] tinyint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [HavalehActive] tinyint  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'THavRezItm'
CREATE TABLE [dbo].[THavRezItm] (
    [SalMali] nvarchar(50)  NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehRadif] int  NOT NULL,
    [HavalehType] tinyint  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] char(10)  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [MojodiMeghdari] float  NULL,
    [MojodiRiali] float  NULL
);
GO

-- Creating table 'TParmtr'
CREATE TABLE [dbo].[TParmtr] (
    [Date1] nvarchar(50)  NULL,
    [Date2] nvarchar(50)  NULL,
    [Markaz1] int  NOT NULL,
    [Markaz2] int  NOT NULL
);
GO

-- Creating table 'TSet'
CREATE TABLE [dbo].[TSet] (
    [CompanyName] varchar(50)  NULL,
    [pyear] char(2)  NOT NULL,
    [StartDate] char(8)  NULL
);
GO

-- Creating table 'QAnbar'
CREATE TABLE [dbo].[QAnbar] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [TedadKala] int  NULL
);
GO

-- Creating table 'QAnbarKalaCode'
CREATE TABLE [dbo].[QAnbarKalaCode] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL
);
GO

-- Creating table 'QAnbarValid'
CREATE TABLE [dbo].[QAnbarValid] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL
);
GO

-- Creating table 'QCardex'
CREATE TABLE [dbo].[QCardex] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MarkazCode] int  NOT NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'QCardex_THav'
CREATE TABLE [dbo].[QCardex_THav] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MarkazCode] int  NOT NULL,
    [HavalehDate] nvarchar(50)  NULL,
    [HavalehType] tinyint  NOT NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'QCardexAK'
CREATE TABLE [dbo].[QCardexAK] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarType] nvarchar(10)  NULL
);
GO

-- Creating table 'QCardexM'
CREATE TABLE [dbo].[QCardexM] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL
);
GO

-- Creating table 'QDarkhast'
CREATE TABLE [dbo].[QDarkhast] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaMinD] int  NOT NULL,
    [KalaSefPointD] int  NOT NULL,
    [KalaMaxD] int  NOT NULL,
    [SumTedadAV] float  NOT NULL,
    [SumTedadGH] float  NOT NULL,
    [SumTedadHavaleh] float  NOT NULL,
    [Cardex] float  NOT NULL,
    [DarkhastSys] float  NULL,
    [Darkhast] int  NULL,
    [SharhDarkhast] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'QDCardex_AvalDoreh'
CREATE TABLE [dbo].[QDCardex_AvalDoreh] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MadrakType] tinyint  NOT NULL,
    [SumTedad] float  NULL
);
GO

-- Creating table 'QDCardex_Ghabz'
CREATE TABLE [dbo].[QDCardex_Ghabz] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MadrakType] tinyint  NOT NULL,
    [SumTedad] float  NULL
);
GO

-- Creating table 'QDCardex_Havaleh'
CREATE TABLE [dbo].[QDCardex_Havaleh] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MadrakType] tinyint  NOT NULL,
    [SumTedad] float  NULL
);
GO

-- Creating table 'QGardesh'
CREATE TABLE [dbo].[QGardesh] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadAvalDoreh] float  NOT NULL,
    [MaxTedadGhabz] float  NOT NULL,
    [MaxTedadHavaleh] float  NOT NULL,
    [MaxRialAvalDoreh] float  NOT NULL,
    [MaxRialGhabz] float  NOT NULL,
    [MaxRialHavaleh] float  NOT NULL
);
GO

-- Creating table 'QGardeshIn'
CREATE TABLE [dbo].[QGardeshIn] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadGhabz] float  NOT NULL,
    [MaxRialGhabz] float  NOT NULL
);
GO

-- Creating table 'QGardeshNM'
CREATE TABLE [dbo].[QGardeshNM] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadAvalDoreh] float  NOT NULL,
    [MaxTedadGhabz] float  NOT NULL,
    [MaxTedadHavaleh] float  NOT NULL,
    [MaxRialAvalDoreh] float  NOT NULL,
    [MaxRialGhabz] float  NOT NULL,
    [MaxRialHavaleh] float  NOT NULL
);
GO

-- Creating table 'QGardeshNMIn'
CREATE TABLE [dbo].[QGardeshNMIn] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadGhabz] float  NOT NULL,
    [MaxRialGhabz] float  NOT NULL
);
GO

-- Creating table 'QGardeshNMOut'
CREATE TABLE [dbo].[QGardeshNMOut] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadHavaleh] float  NOT NULL,
    [MaxRialHavaleh] float  NOT NULL
);
GO

-- Creating table 'QGardeshOut'
CREATE TABLE [dbo].[QGardeshOut] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadHavaleh] float  NOT NULL,
    [MaxRialHavaleh] float  NOT NULL
);
GO

-- Creating table 'QHavaleh'
CREATE TABLE [dbo].[QHavaleh] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QHavalehMoujod'
CREATE TABLE [dbo].[QHavalehMoujod] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL
);
GO

-- Creating table 'QHavHavItm'
CREATE TABLE [dbo].[QHavHavItm] (
    [salMali] nvarchar(50)  NULL,
    [HavalehDate] nvarchar(50)  NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehRadif] int  NOT NULL,
    [HavalehType] tinyint  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] char(10)  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QHavItm'
CREATE TABLE [dbo].[QHavItm] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [HavalehType] tinyint  NOT NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehRadif] int  NOT NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedKala] nvarchar(150)  NOT NULL,
    [MarkazCode] char(10)  NULL,
    [MarkazName] nvarchar(150)  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QHesab'
CREATE TABLE [dbo].[QHesab] (
    [Radif] int  NULL,
    [SalMali] nvarchar(50)  NULL,
    [Kol] int  NOT NULL,
    [Moein] int  NOT NULL,
    [Tafzili] int  NOT NULL,
    [Joz] int  NOT NULL,
    [Sharh] nvarchar(150)  NULL,
    [Type] tinyint  NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'QHesabAnbar'
CREATE TABLE [dbo].[QHesabAnbar] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int  NULL
);
GO

-- Creating table 'QHesabKala'
CREATE TABLE [dbo].[QHesabKala] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaVahedCode] int  NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int  NULL
);
GO

-- Creating table 'QHesabMarkaz'
CREATE TABLE [dbo].[QHesabMarkaz] (
    [SalMali] nvarchar(50)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [id] int  NULL
);
GO

-- Creating table 'QKala'
CREATE TABLE [dbo].[QKala] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaVahedCode] int  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [KalaEst1] int  NULL,
    [KalaEst2] int  NULL,
    [KalaEst3] int  NULL,
    [KalaEst4] int  NULL,
    [KalaEst5] int  NULL,
    [KalaEst6] int  NULL,
    [KalaEst7] int  NULL,
    [KalaEst8] int  NULL,
    [KalaEst9] int  NULL,
    [KalaEst10] int  NULL,
    [KalaEst11] int  NULL,
    [KalaEst12] int  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaMomaiez] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaZaribVahed] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [Darkhast] int  NULL,
    [SharhDarkhast] nvarchar(150)  NULL,
    [Shomaresh1] float  NULL,
    [Shomaresh2] float  NULL,
    [Shomaresh3] float  NULL,
    [ShomareshNahaei] float  NULL
);
GO

-- Creating table 'QKalaAnbar'
CREATE TABLE [dbo].[QKalaAnbar] (
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [SalMali] nvarchar(50)  NOT NULL,
    [KalaCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaVahedCode] int  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [KalaEst1] int  NULL,
    [KalaEst2] int  NULL,
    [KalaEst3] int  NULL,
    [KalaEst4] int  NULL,
    [KalaEst5] int  NULL,
    [KalaEst6] int  NULL,
    [KalaEst7] int  NULL,
    [KalaEst8] int  NULL,
    [KalaEst9] int  NULL,
    [KalaEst10] int  NULL,
    [KalaEst11] int  NULL,
    [KalaEst12] int  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaMomaiez] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaZaribVahed] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [Darkhast] int  NULL,
    [SharhDarkhast] nvarchar(150)  NULL,
    [Shomaresh1] float  NULL,
    [Shomaresh2] float  NULL,
    [Shomaresh3] float  NULL,
    [ShomareshNahaei] float  NULL
);
GO

-- Creating table 'QMadrak'
CREATE TABLE [dbo].[QMadrak] (
    [Expr1] nvarchar(50)  NULL,
    [Expr2] int  NOT NULL,
    [Expr3] tinyint  NOT NULL,
    [Expr4] int  NOT NULL,
    [Expr5] nvarchar(50)  NULL,
    [Expr6] tinyint  NULL,
    [Expr7] nvarchar(150)  NULL,
    [SalMali] nvarchar(50)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakActive] tinyint  NULL,
    [MadrakDescription] nvarchar(150)  NULL
);
GO

-- Creating table 'QMadrakItem'
CREATE TABLE [dbo].[QMadrakItem] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedKala] nvarchar(150)  NOT NULL,
    [MarkazCode] int  NULL,
    [MarkazName] nvarchar(150)  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QMadrakItem2'
CREATE TABLE [dbo].[QMadrakItem2] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakActive] tinyint  NULL,
    [MadrakDescription] nvarchar(150)  NULL,
    [MadrakRadif] int  NULL,
    [KalaCode] int  NULL,
    [MarkazCode] int  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL,
    [MojodiMeghdari] float  NULL,
    [MojodiRiali] float  NULL,
    [KalaName] nvarchar(150)  NULL,
    [MarkazName] nvarchar(150)  NULL
);
GO

-- Creating table 'QMadrakMadrakItem'
CREATE TABLE [dbo].[QMadrakMadrakItem] (
    [SalMali] nvarchar(50)  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [MadrakType] tinyint  NOT NULL,
    [KalaCode] int  NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] int  NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QMarkazKalaUnValid'
CREATE TABLE [dbo].[QMarkazKalaUnValid] (
    [SalMali] nvarchar(50)  NULL,
    [KalaCode] int  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MarkazCode] int  NOT NULL
);
GO

-- Creating table 'QRaked'
CREATE TABLE [dbo].[QRaked] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [MaxTedadAvalDoreh] float  NOT NULL,
    [MaxTedadGhabz] float  NOT NULL,
    [MaxTedadHavaleh] float  NOT NULL,
    [MaxRialAvalDoreh] float  NOT NULL,
    [MaxRialGhabz] float  NOT NULL,
    [MaxRialHavaleh] float  NOT NULL,
    [LastDateAV] nvarchar(50)  NULL,
    [LastDateG] nvarchar(50)  NULL,
    [LastDateH] nvarchar(50)  NULL
);
GO

-- Creating table 'QRHesabKala'
CREATE TABLE [dbo].[QRHesabKala] (
    [Radif] int  NULL,
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NOT NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL
);
GO

-- Creating table 'QRHesabMarkaz'
CREATE TABLE [dbo].[QRHesabMarkaz] (
    [Radif] int  NULL,
    [MarkazCode] int  NOT NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [SalMali] nvarchar(50)  NULL
);
GO

-- Creating table 'QSanad'
CREATE TABLE [dbo].[QSanad] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakType] tinyint  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NULL,
    [MadrakRadif] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [MarkazCode] int  NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [Meghdar] float  NULL,
    [Bed] float  NULL,
    [Bes] float  NULL,
    [IsSanad] bit  NOT NULL,
    [SanadID] int  NULL,
    [SanadRadif] int  NULL
);
GO

-- Creating table 'QSanadNonUpdatable'
CREATE TABLE [dbo].[QSanadNonUpdatable] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [MadrakType] tinyint  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakCode] int  NULL,
    [MadrakRadif] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NULL,
    [KalaName] nvarchar(150)  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [Kol] int  NULL,
    [Moein] int  NULL,
    [Tafzili] int  NULL,
    [Joz] int  NULL,
    [Sharh] nvarchar(150)  NULL,
    [Meghdar] float  NULL,
    [Bed] float  NULL,
    [Bes] float  NULL,
    [IsSanad] bit  NOT NULL,
    [SanadID] int  NULL,
    [SanadRadif] int  NULL
);
GO

-- Creating table 'QSefPoint'
CREATE TABLE [dbo].[QSefPoint] (
    [SalMali] nvarchar(50)  NOT NULL,
    [AnbarCode] int  NOT NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedName] nvarchar(150)  NULL,
    [KalaMin] int  NULL,
    [KalaMax] int  NULL,
    [KalaSefPoint] int  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaZaribVahed] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [Moujodi] int  NOT NULL
);
GO

-- Creating table 'QShomaresh'
CREATE TABLE [dbo].[QShomaresh] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [SumTedadAV] float  NOT NULL,
    [SumTedadGH] float  NOT NULL,
    [SumTedadHavaleh] float  NOT NULL,
    [Cardex] float  NOT NULL,
    [Shomaresh1] float  NULL,
    [Shomaresh2] float  NULL,
    [Shomaresh3] float  NULL,
    [ShomareshNahaei] float  NULL
);
GO

-- Creating table 'QSumAvalDoreh'
CREATE TABLE [dbo].[QSumAvalDoreh] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [MaxTedadAvalDoreh] float  NULL,
    [MaxRialAvalDoreh] float  NULL
);
GO

-- Creating table 'QSumAvaldorehNM'
CREATE TABLE [dbo].[QSumAvaldorehNM] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadAvalDoreh] float  NULL,
    [MaxRialAvalDoreh] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumAvalDorehNMR'
CREATE TABLE [dbo].[QSumAvalDorehNMR] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadAvalDoreh] float  NULL,
    [MaxRialAvalDoreh] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumGhabz'
CREATE TABLE [dbo].[QSumGhabz] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [MaxTedadGhabz] float  NULL,
    [MaxRialGhabz] float  NULL
);
GO

-- Creating table 'QSumGhabzNM'
CREATE TABLE [dbo].[QSumGhabzNM] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadGhabz] float  NULL,
    [MaxRialGhabz] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumGhabzNMR'
CREATE TABLE [dbo].[QSumGhabzNMR] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadGhabz] float  NULL,
    [MaxRialGhabz] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumGhabzNMT'
CREATE TABLE [dbo].[QSumGhabzNMT] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadGhabz] float  NULL,
    [MaxRialGhabz] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumHavaleh'
CREATE TABLE [dbo].[QSumHavaleh] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MarkazCode] int  NOT NULL,
    [MarkazName] nvarchar(150)  NULL,
    [MaxTedadHavaleh] float  NULL,
    [MaxRialHavaleh] float  NULL
);
GO

-- Creating table 'QSumHavalehNM'
CREATE TABLE [dbo].[QSumHavalehNM] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadHavaleh] float  NULL,
    [MaxRialHavaleh] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumHavalehNMR'
CREATE TABLE [dbo].[QSumHavalehNMR] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadHavaleh] float  NULL,
    [MaxRialHavaleh] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QSumHavalehNMT'
CREATE TABLE [dbo].[QSumHavalehNMT] (
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MaxTedadHavaleh] float  NULL,
    [MaxRialHavaleh] float  NULL,
    [MadrakDate] nvarchar(50)  NULL
);
GO

-- Creating table 'QtempDarkhast'
CREATE TABLE [dbo].[QtempDarkhast] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NULL,
    [AnbarName] nvarchar(150)  NULL,
    [AnbarType] nvarchar(10)  NULL,
    [KalaCode] int  NOT NULL,
    [KalaName] nvarchar(150)  NULL,
    [VahedCode] int  NULL,
    [VahedName] nvarchar(150)  NULL,
    [KalaEsteghrar] nvarchar(150)  NULL,
    [KalaGhesmat] nvarchar(150)  NULL,
    [KalaProperty] nvarchar(150)  NULL,
    [KalaShomareh] nvarchar(150)  NULL,
    [KalaArzType] nvarchar(150)  NULL,
    [KalaMinD] int  NOT NULL,
    [KalaSefPointD] int  NOT NULL,
    [KalaMaxD] int  NOT NULL,
    [SumTedadAV] float  NOT NULL,
    [SumTedadGH] float  NOT NULL,
    [SumTedadHavaleh] float  NOT NULL,
    [Cardex] float  NOT NULL,
    [DarkhastSys] float  NULL,
    [Darkhast] int  NULL,
    [SharhDarkhast] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'QUpdate'
CREATE TABLE [dbo].[QUpdate] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [MadrakDate] nvarchar(50)  NULL,
    [MadrakType] tinyint  NOT NULL,
    [MadrakCode] int  NOT NULL,
    [MadrakRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- Creating table 'QUpdate_THav'
CREATE TABLE [dbo].[QUpdate_THav] (
    [SalMali] nvarchar(50)  NULL,
    [AnbarCode] int  NOT NULL,
    [KalaCode] int  NULL,
    [HavalehDate] nvarchar(50)  NULL,
    [HavalehType] tinyint  NOT NULL,
    [HavalehCode] int  NOT NULL,
    [HavalehRadif] int  NOT NULL,
    [Tedad] float  NULL,
    [Nerkh] float  NULL,
    [Rial] float  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AnbarCode] in table 'TAnb'
ALTER TABLE [dbo].[TAnb]
ADD CONSTRAINT [PK_TAnb]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [SalMali] in table 'TCurrent'
ALTER TABLE [dbo].[TCurrent]
ADD CONSTRAINT [PK_TCurrent]
    PRIMARY KEY CLUSTERED ([SalMali] ASC);
GO

-- Creating primary key on [id] in table 'THes'
ALTER TABLE [dbo].[THes]
ADD CONSTRAINT [PK_THes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'THesAnb'
ALTER TABLE [dbo].[THesAnb]
ADD CONSTRAINT [PK_THesAnb]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'THesKala'
ALTER TABLE [dbo].[THesKala]
ADD CONSTRAINT [PK_THesKala]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'THesMad'
ALTER TABLE [dbo].[THesMad]
ADD CONSTRAINT [PK_THesMad]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'THesMar'
ALTER TABLE [dbo].[THesMar]
ADD CONSTRAINT [PK_THesMar]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [KalaCode], [AnbarCode] in table 'TKala'
ALTER TABLE [dbo].[TKala]
ADD CONSTRAINT [PK_TKala]
    PRIMARY KEY CLUSTERED ([KalaCode], [AnbarCode] ASC);
GO

-- Creating primary key on [MadrakCode], [MadrakType], [AnbarCode] in table 'TMad'
ALTER TABLE [dbo].[TMad]
ADD CONSTRAINT [PK_TMad]
    PRIMARY KEY CLUSTERED ([MadrakCode], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [MadrakCode], [MadrakType], [AnbarCode] in table 'TMadEnt'
ALTER TABLE [dbo].[TMadEnt]
ADD CONSTRAINT [PK_TMadEnt]
    PRIMARY KEY CLUSTERED ([MadrakCode], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] in table 'TMadIEnt'
ALTER TABLE [dbo].[TMadIEnt]
ADD CONSTRAINT [PK_TMadIEnt]
    PRIMARY KEY CLUSTERED ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] in table 'TMadItm'
ALTER TABLE [dbo].[TMadItm]
ADD CONSTRAINT [PK_TMadItm]
    PRIMARY KEY CLUSTERED ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [IDMah] in table 'TMah'
ALTER TABLE [dbo].[TMah]
ADD CONSTRAINT [PK_TMah]
    PRIMARY KEY CLUSTERED ([IDMah] ASC);
GO

-- Creating primary key on [IDMah], [Radif] in table 'TMahD'
ALTER TABLE [dbo].[TMahD]
ADD CONSTRAINT [PK_TMahD]
    PRIMARY KEY CLUSTERED ([IDMah], [Radif] ASC);
GO

-- Creating primary key on [MarkazCode] in table 'TMar'
ALTER TABLE [dbo].[TMar]
ADD CONSTRAINT [PK_TMar]
    PRIMARY KEY CLUSTERED ([MarkazCode] ASC);
GO

-- Creating primary key on [KalaCode], [AnbarCode], [MarkazCode] in table 'TMarKala'
ALTER TABLE [dbo].[TMarKala]
ADD CONSTRAINT [PK_TMarKala]
    PRIMARY KEY CLUSTERED ([KalaCode], [AnbarCode], [MarkazCode] ASC);
GO

-- Creating primary key on [ID] in table 'TMedia'
ALTER TABLE [dbo].[TMedia]
ADD CONSTRAINT [PK_TMedia]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TMediaKala'
ALTER TABLE [dbo].[TMediaKala]
ADD CONSTRAINT [PK_TMediaKala]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDMenu] in table 'TMenu'
ALTER TABLE [dbo].[TMenu]
ADD CONSTRAINT [PK_TMenu]
    PRIMARY KEY CLUSTERED ([IDMenu] ASC);
GO

-- Creating primary key on [IDMenu], [Radif] in table 'TMenuD'
ALTER TABLE [dbo].[TMenuD]
ADD CONSTRAINT [PK_TMenuD]
    PRIMARY KEY CLUSTERED ([IDMenu], [Radif] ASC);
GO

-- Creating primary key on [PRJ_ID] in table 'TProject'
ALTER TABLE [dbo].[TProject]
ADD CONSTRAINT [PK_TProject]
    PRIMARY KEY CLUSTERED ([PRJ_ID] ASC);
GO

-- Creating primary key on [PRJ_ID], [Radif], [IDMah] in table 'TProjectD'
ALTER TABLE [dbo].[TProjectD]
ADD CONSTRAINT [PK_TProjectD]
    PRIMARY KEY CLUSTERED ([PRJ_ID], [Radif], [IDMah] ASC);
GO

-- Creating primary key on [PRJ_ID], [Radif], [IDMah], [RadifM] in table 'TProjectDItm'
ALTER TABLE [dbo].[TProjectDItm]
ADD CONSTRAINT [PK_TProjectDItm]
    PRIMARY KEY CLUSTERED ([PRJ_ID], [Radif], [IDMah], [RadifM] ASC);
GO

-- Creating primary key on [IDUser] in table 'TUser'
ALTER TABLE [dbo].[TUser]
ADD CONSTRAINT [PK_TUser]
    PRIMARY KEY CLUSTERED ([IDUser] ASC);
GO

-- Creating primary key on [IDUser], [Radif] in table 'TUserAccess'
ALTER TABLE [dbo].[TUserAccess]
ADD CONSTRAINT [PK_TUserAccess]
    PRIMARY KEY CLUSTERED ([IDUser], [Radif] ASC);
GO

-- Creating primary key on [VahedCode] in table 'TVahed'
ALTER TABLE [dbo].[TVahed]
ADD CONSTRAINT [PK_TVahed]
    PRIMARY KEY CLUSTERED ([VahedCode] ASC);
GO

-- Creating primary key on [HavalehCode], [HavalehType], [AnbarCode] in table 'THavRez'
ALTER TABLE [dbo].[THavRez]
ADD CONSTRAINT [PK_THavRez]
    PRIMARY KEY CLUSTERED ([HavalehCode], [HavalehType], [AnbarCode] ASC);
GO

-- Creating primary key on [HavalehCode], [HavalehRadif], [HavalehType], [AnbarCode] in table 'THavRezItm'
ALTER TABLE [dbo].[THavRezItm]
ADD CONSTRAINT [PK_THavRezItm]
    PRIMARY KEY CLUSTERED ([HavalehCode], [HavalehRadif], [HavalehType], [AnbarCode] ASC);
GO

-- Creating primary key on [Markaz1], [Markaz2] in table 'TParmtr'
ALTER TABLE [dbo].[TParmtr]
ADD CONSTRAINT [PK_TParmtr]
    PRIMARY KEY CLUSTERED ([Markaz1], [Markaz2] ASC);
GO

-- Creating primary key on [pyear] in table 'TSet'
ALTER TABLE [dbo].[TSet]
ADD CONSTRAINT [PK_TSet]
    PRIMARY KEY CLUSTERED ([pyear] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode] in table 'QAnbar'
ALTER TABLE [dbo].[QAnbar]
ADD CONSTRAINT [PK_QAnbar]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode] in table 'QAnbarKalaCode'
ALTER TABLE [dbo].[QAnbarKalaCode]
ADD CONSTRAINT [PK_QAnbarKalaCode]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode] in table 'QAnbarValid'
ALTER TABLE [dbo].[QAnbarValid]
ADD CONSTRAINT [PK_QAnbarValid]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [MadrakType], [MadrakCode], [MadrakRadif] in table 'QCardex'
ALTER TABLE [dbo].[QCardex]
ADD CONSTRAINT [PK_QCardex]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [MadrakType], [MadrakCode], [MadrakRadif] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [HavalehType], [HavalehCode], [HavalehRadif] in table 'QCardex_THav'
ALTER TABLE [dbo].[QCardex_THav]
ADD CONSTRAINT [PK_QCardex_THav]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [HavalehType], [HavalehCode], [HavalehRadif] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QCardexAK'
ALTER TABLE [dbo].[QCardexAK]
ADD CONSTRAINT [PK_QCardexAK]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [MadrakType], [MadrakCode], [MadrakRadif] in table 'QCardexM'
ALTER TABLE [dbo].[QCardexM]
ADD CONSTRAINT [PK_QCardexM]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [MadrakType], [MadrakCode], [MadrakRadif] ASC);
GO

-- Creating primary key on [KalaCode], [KalaMinD], [KalaSefPointD], [KalaMaxD], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex], [SharhDarkhast] in table 'QDarkhast'
ALTER TABLE [dbo].[QDarkhast]
ADD CONSTRAINT [PK_QDarkhast]
    PRIMARY KEY CLUSTERED ([KalaCode], [KalaMinD], [KalaSefPointD], [KalaMaxD], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex], [SharhDarkhast] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType] in table 'QDCardex_AvalDoreh'
ALTER TABLE [dbo].[QDCardex_AvalDoreh]
ADD CONSTRAINT [PK_QDCardex_AvalDoreh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType] in table 'QDCardex_Ghabz'
ALTER TABLE [dbo].[QDCardex_Ghabz]
ADD CONSTRAINT [PK_QDCardex_Ghabz]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType] in table 'QDCardex_Havaleh'
ALTER TABLE [dbo].[QDCardex_Havaleh]
ADD CONSTRAINT [PK_QDCardex_Havaleh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] in table 'QGardesh'
ALTER TABLE [dbo].[QGardesh]
ADD CONSTRAINT [PK_QGardesh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [MaxTedadGhabz], [MaxRialGhabz] in table 'QGardeshIn'
ALTER TABLE [dbo].[QGardeshIn]
ADD CONSTRAINT [PK_QGardeshIn]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [MaxTedadGhabz], [MaxRialGhabz] ASC);
GO

-- Creating primary key on [AnbarCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] in table 'QGardeshNM'
ALTER TABLE [dbo].[QGardeshNM]
ADD CONSTRAINT [PK_QGardeshNM]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] ASC);
GO

-- Creating primary key on [AnbarCode], [MaxTedadGhabz], [MaxRialGhabz] in table 'QGardeshNMIn'
ALTER TABLE [dbo].[QGardeshNMIn]
ADD CONSTRAINT [PK_QGardeshNMIn]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MaxTedadGhabz], [MaxRialGhabz] ASC);
GO

-- Creating primary key on [AnbarCode], [MaxTedadHavaleh], [MaxRialHavaleh] in table 'QGardeshNMOut'
ALTER TABLE [dbo].[QGardeshNMOut]
ADD CONSTRAINT [PK_QGardeshNMOut]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MaxTedadHavaleh], [MaxRialHavaleh] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode], [MaxTedadHavaleh], [MaxRialHavaleh] in table 'QGardeshOut'
ALTER TABLE [dbo].[QGardeshOut]
ADD CONSTRAINT [PK_QGardeshOut]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode], [MaxTedadHavaleh], [MaxRialHavaleh] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif] in table 'QHavaleh'
ALTER TABLE [dbo].[QHavaleh]
ADD CONSTRAINT [PK_QHavaleh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif] ASC);
GO

-- Creating primary key on [MadrakType], [AnbarCode], [MadrakCode], [MadrakRadif] in table 'QHavalehMoujod'
ALTER TABLE [dbo].[QHavalehMoujod]
ADD CONSTRAINT [PK_QHavalehMoujod]
    PRIMARY KEY CLUSTERED ([MadrakType], [AnbarCode], [MadrakCode], [MadrakRadif] ASC);
GO

-- Creating primary key on [HavalehCode], [HavalehRadif], [HavalehType], [AnbarCode] in table 'QHavHavItm'
ALTER TABLE [dbo].[QHavHavItm]
ADD CONSTRAINT [PK_QHavHavItm]
    PRIMARY KEY CLUSTERED ([HavalehCode], [HavalehRadif], [HavalehType], [AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [HavalehType], [HavalehCode], [HavalehRadif], [VahedKala] in table 'QHavItm'
ALTER TABLE [dbo].[QHavItm]
ADD CONSTRAINT [PK_QHavItm]
    PRIMARY KEY CLUSTERED ([AnbarCode], [HavalehType], [HavalehCode], [HavalehRadif], [VahedKala] ASC);
GO

-- Creating primary key on [Kol], [Moein], [Tafzili], [Joz], [id] in table 'QHesab'
ALTER TABLE [dbo].[QHesab]
ADD CONSTRAINT [PK_QHesab]
    PRIMARY KEY CLUSTERED ([Kol], [Moein], [Tafzili], [Joz], [id] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode] in table 'QHesabAnbar'
ALTER TABLE [dbo].[QHesabAnbar]
ADD CONSTRAINT [PK_QHesabAnbar]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode], [KalaCode] in table 'QHesabKala'
ALTER TABLE [dbo].[QHesabKala]
ADD CONSTRAINT [PK_QHesabKala]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode], [KalaCode] ASC);
GO

-- Creating primary key on [MarkazCode] in table 'QHesabMarkaz'
ALTER TABLE [dbo].[QHesabMarkaz]
ADD CONSTRAINT [PK_QHesabMarkaz]
    PRIMARY KEY CLUSTERED ([MarkazCode] ASC);
GO

-- Creating primary key on [KalaCode] in table 'QKala'
ALTER TABLE [dbo].[QKala]
ADD CONSTRAINT [PK_QKala]
    PRIMARY KEY CLUSTERED ([KalaCode] ASC);
GO

-- Creating primary key on [SalMali], [KalaCode], [AnbarCode] in table 'QKalaAnbar'
ALTER TABLE [dbo].[QKalaAnbar]
ADD CONSTRAINT [PK_QKalaAnbar]
    PRIMARY KEY CLUSTERED ([SalMali], [KalaCode], [AnbarCode] ASC);
GO

-- Creating primary key on [Expr2], [Expr3], [Expr4], [MadrakCode], [MadrakType], [AnbarCode] in table 'QMadrak'
ALTER TABLE [dbo].[QMadrak]
ADD CONSTRAINT [PK_QMadrak]
    PRIMARY KEY CLUSTERED ([Expr2], [Expr3], [Expr4], [MadrakCode], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif], [VahedKala] in table 'QMadrakItem'
ALTER TABLE [dbo].[QMadrakItem]
ADD CONSTRAINT [PK_QMadrakItem]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif], [VahedKala] ASC);
GO

-- Creating primary key on [MadrakType], [MadrakCode], [AnbarCode] in table 'QMadrakItem2'
ALTER TABLE [dbo].[QMadrakItem2]
ADD CONSTRAINT [PK_QMadrakItem2]
    PRIMARY KEY CLUSTERED ([MadrakType], [MadrakCode], [AnbarCode] ASC);
GO

-- Creating primary key on [MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] in table 'QMadrakMadrakItem'
ALTER TABLE [dbo].[QMadrakMadrakItem]
ADD CONSTRAINT [PK_QMadrakMadrakItem]
    PRIMARY KEY CLUSTERED ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] ASC);
GO

-- Creating primary key on [KalaCode], [AnbarCode], [MarkazCode] in table 'QMarkazKalaUnValid'
ALTER TABLE [dbo].[QMarkazKalaUnValid]
ADD CONSTRAINT [PK_QMarkazKalaUnValid]
    PRIMARY KEY CLUSTERED ([KalaCode], [AnbarCode], [MarkazCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] in table 'QRaked'
ALTER TABLE [dbo].[QRaked]
ADD CONSTRAINT [PK_QRaked]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MaxTedadAvalDoreh], [MaxTedadGhabz], [MaxTedadHavaleh], [MaxRialAvalDoreh], [MaxRialGhabz], [MaxRialHavaleh] ASC);
GO

-- Creating primary key on [AnbarCode], [KalaCode] in table 'QRHesabKala'
ALTER TABLE [dbo].[QRHesabKala]
ADD CONSTRAINT [PK_QRHesabKala]
    PRIMARY KEY CLUSTERED ([AnbarCode], [KalaCode] ASC);
GO

-- Creating primary key on [MarkazCode] in table 'QRHesabMarkaz'
ALTER TABLE [dbo].[QRHesabMarkaz]
ADD CONSTRAINT [PK_QRHesabMarkaz]
    PRIMARY KEY CLUSTERED ([MarkazCode] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode], [IsSanad] in table 'QSanad'
ALTER TABLE [dbo].[QSanad]
ADD CONSTRAINT [PK_QSanad]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode], [IsSanad] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode], [MarkazCode], [IsSanad] in table 'QSanadNonUpdatable'
ALTER TABLE [dbo].[QSanadNonUpdatable]
ADD CONSTRAINT [PK_QSanadNonUpdatable]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode], [MarkazCode], [IsSanad] ASC);
GO

-- Creating primary key on [SalMali], [AnbarCode], [KalaCode], [Moujodi] in table 'QSefPoint'
ALTER TABLE [dbo].[QSefPoint]
ADD CONSTRAINT [PK_QSefPoint]
    PRIMARY KEY CLUSTERED ([SalMali], [AnbarCode], [KalaCode], [Moujodi] ASC);
GO

-- Creating primary key on [KalaCode], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex] in table 'QShomaresh'
ALTER TABLE [dbo].[QShomaresh]
ADD CONSTRAINT [PK_QShomaresh]
    PRIMARY KEY CLUSTERED ([KalaCode], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode] in table 'QSumAvalDoreh'
ALTER TABLE [dbo].[QSumAvalDoreh]
ADD CONSTRAINT [PK_QSumAvalDoreh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumAvaldorehNM'
ALTER TABLE [dbo].[QSumAvaldorehNM]
ADD CONSTRAINT [PK_QSumAvaldorehNM]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumAvalDorehNMR'
ALTER TABLE [dbo].[QSumAvalDorehNMR]
ADD CONSTRAINT [PK_QSumAvalDorehNMR]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode] in table 'QSumGhabz'
ALTER TABLE [dbo].[QSumGhabz]
ADD CONSTRAINT [PK_QSumGhabz]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumGhabzNM'
ALTER TABLE [dbo].[QSumGhabzNM]
ADD CONSTRAINT [PK_QSumGhabzNM]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumGhabzNMR'
ALTER TABLE [dbo].[QSumGhabzNMR]
ADD CONSTRAINT [PK_QSumGhabzNMR]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumGhabzNMT'
ALTER TABLE [dbo].[QSumGhabzNMT]
ADD CONSTRAINT [PK_QSumGhabzNMT]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode], [MarkazCode] in table 'QSumHavaleh'
ALTER TABLE [dbo].[QSumHavaleh]
ADD CONSTRAINT [PK_QSumHavaleh]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MarkazCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumHavalehNM'
ALTER TABLE [dbo].[QSumHavalehNM]
ADD CONSTRAINT [PK_QSumHavalehNM]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumHavalehNMR'
ALTER TABLE [dbo].[QSumHavalehNMR]
ADD CONSTRAINT [PK_QSumHavalehNMR]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [AnbarCode] in table 'QSumHavalehNMT'
ALTER TABLE [dbo].[QSumHavalehNMT]
ADD CONSTRAINT [PK_QSumHavalehNMT]
    PRIMARY KEY CLUSTERED ([AnbarCode] ASC);
GO

-- Creating primary key on [KalaCode], [KalaMinD], [KalaSefPointD], [KalaMaxD], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex], [SharhDarkhast] in table 'QtempDarkhast'
ALTER TABLE [dbo].[QtempDarkhast]
ADD CONSTRAINT [PK_QtempDarkhast]
    PRIMARY KEY CLUSTERED ([KalaCode], [KalaMinD], [KalaSefPointD], [KalaMaxD], [SumTedadAV], [SumTedadGH], [SumTedadHavaleh], [Cardex], [SharhDarkhast] ASC);
GO

-- Creating primary key on [AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif] in table 'QUpdate'
ALTER TABLE [dbo].[QUpdate]
ADD CONSTRAINT [PK_QUpdate]
    PRIMARY KEY CLUSTERED ([AnbarCode], [MadrakType], [MadrakCode], [MadrakRadif] ASC);
GO

-- Creating primary key on [AnbarCode], [HavalehType], [HavalehCode], [HavalehRadif] in table 'QUpdate_THav'
ALTER TABLE [dbo].[QUpdate_THav]
ADD CONSTRAINT [PK_QUpdate_THav]
    PRIMARY KEY CLUSTERED ([AnbarCode], [HavalehType], [HavalehCode], [HavalehRadif] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AnbarCode] in table 'TKala'
ALTER TABLE [dbo].[TKala]
ADD CONSTRAINT [FK_TKala_TAnb]
    FOREIGN KEY ([AnbarCode])
    REFERENCES [dbo].[TAnb]
        ([AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TKala_TAnb'
CREATE INDEX [IX_FK_TKala_TAnb]
ON [dbo].[TKala]
    ([AnbarCode]);
GO

-- Creating foreign key on [AnbarCode] in table 'TMad'
ALTER TABLE [dbo].[TMad]
ADD CONSTRAINT [FK_TMad_TAnb]
    FOREIGN KEY ([AnbarCode])
    REFERENCES [dbo].[TAnb]
        ([AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMad_TAnb'
CREATE INDEX [IX_FK_TMad_TAnb]
ON [dbo].[TMad]
    ([AnbarCode]);
GO

-- Creating foreign key on [KalaCode], [AnbarCode] in table 'THesKala'
ALTER TABLE [dbo].[THesKala]
ADD CONSTRAINT [FK_THesKala_TKala]
    FOREIGN KEY ([KalaCode], [AnbarCode])
    REFERENCES [dbo].[TKala]
        ([KalaCode], [AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_THesKala_TKala'
CREATE INDEX [IX_FK_THesKala_TKala]
ON [dbo].[THesKala]
    ([KalaCode], [AnbarCode]);
GO

-- Creating foreign key on [MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode] in table 'THesMad'
ALTER TABLE [dbo].[THesMad]
ADD CONSTRAINT [FK_THesMad_TMadItm]
    FOREIGN KEY ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode])
    REFERENCES [dbo].[TMadItm]
        ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_THesMad_TMadItm'
CREATE INDEX [IX_FK_THesMad_TMadItm]
ON [dbo].[THesMad]
    ([MadrakCode], [MadrakRadif], [MadrakType], [AnbarCode]);
GO

-- Creating foreign key on [MarkazCode] in table 'THesMar'
ALTER TABLE [dbo].[THesMar]
ADD CONSTRAINT [FK_THesMar_TMar]
    FOREIGN KEY ([MarkazCode])
    REFERENCES [dbo].[TMar]
        ([MarkazCode])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_THesMar_TMar'
CREATE INDEX [IX_FK_THesMar_TMar]
ON [dbo].[THesMar]
    ([MarkazCode]);
GO

-- Creating foreign key on [KalaCode], [AnbarCode] in table 'TMarKala'
ALTER TABLE [dbo].[TMarKala]
ADD CONSTRAINT [FK_TMarKala_TKala]
    FOREIGN KEY ([KalaCode], [AnbarCode])
    REFERENCES [dbo].[TKala]
        ([KalaCode], [AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MadrakCode], [MadrakType], [AnbarCode] in table 'TMadItm'
ALTER TABLE [dbo].[TMadItm]
ADD CONSTRAINT [FK_TMadItm_TMad]
    FOREIGN KEY ([MadrakCode], [MadrakType], [AnbarCode])
    REFERENCES [dbo].[TMad]
        ([MadrakCode], [MadrakType], [AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMadItm_TMad'
CREATE INDEX [IX_FK_TMadItm_TMad]
ON [dbo].[TMadItm]
    ([MadrakCode], [MadrakType], [AnbarCode]);
GO

-- Creating foreign key on [MadrakCode], [MadrakType], [AnbarCode] in table 'TMadIEnt'
ALTER TABLE [dbo].[TMadIEnt]
ADD CONSTRAINT [FK_TMadIEnt_TMadEnt]
    FOREIGN KEY ([MadrakCode], [MadrakType], [AnbarCode])
    REFERENCES [dbo].[TMadEnt]
        ([MadrakCode], [MadrakType], [AnbarCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMadIEnt_TMadEnt'
CREATE INDEX [IX_FK_TMadIEnt_TMadEnt]
ON [dbo].[TMadIEnt]
    ([MadrakCode], [MadrakType], [AnbarCode]);
GO

-- Creating foreign key on [KalaCode], [AnbarCode], [MarkazCode] in table 'TMadItm'
ALTER TABLE [dbo].[TMadItm]
ADD CONSTRAINT [FK_TMadItm_TMarKala]
    FOREIGN KEY ([KalaCode], [AnbarCode], [MarkazCode])
    REFERENCES [dbo].[TMarKala]
        ([KalaCode], [AnbarCode], [MarkazCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMadItm_TMarKala'
CREATE INDEX [IX_FK_TMadItm_TMarKala]
ON [dbo].[TMadItm]
    ([KalaCode], [AnbarCode], [MarkazCode]);
GO

-- Creating foreign key on [IDMah] in table 'TMahD'
ALTER TABLE [dbo].[TMahD]
ADD CONSTRAINT [FK_TMahD_TMah]
    FOREIGN KEY ([IDMah])
    REFERENCES [dbo].[TMah]
        ([IDMah])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IDMah] in table 'TProjectD'
ALTER TABLE [dbo].[TProjectD]
ADD CONSTRAINT [FK_TProjectD_TMah]
    FOREIGN KEY ([IDMah])
    REFERENCES [dbo].[TMah]
        ([IDMah])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TProjectD_TMah'
CREATE INDEX [IX_FK_TProjectD_TMah]
ON [dbo].[TProjectD]
    ([IDMah]);
GO

-- Creating foreign key on [MarkazCode] in table 'TMarKala'
ALTER TABLE [dbo].[TMarKala]
ADD CONSTRAINT [FK_TMarKala_TMar]
    FOREIGN KEY ([MarkazCode])
    REFERENCES [dbo].[TMar]
        ([MarkazCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TMarKala_TMar'
CREATE INDEX [IX_FK_TMarKala_TMar]
ON [dbo].[TMarKala]
    ([MarkazCode]);
GO

-- Creating foreign key on [PRJ_ID] in table 'TProjectD'
ALTER TABLE [dbo].[TProjectD]
ADD CONSTRAINT [FK_TProjectD_TProject]
    FOREIGN KEY ([PRJ_ID])
    REFERENCES [dbo].[TProject]
        ([PRJ_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PRJ_ID], [Radif], [IDMah] in table 'TProjectDItm'
ALTER TABLE [dbo].[TProjectDItm]
ADD CONSTRAINT [FK_TProjectDItm_TProjectD]
    FOREIGN KEY ([PRJ_ID], [Radif], [IDMah])
    REFERENCES [dbo].[TProjectD]
        ([PRJ_ID], [Radif], [IDMah])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------