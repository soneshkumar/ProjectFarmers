CREATE DATABASE [FreshoFarmTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FreshoFarmTest', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FreshoFarmTest.mdf' , SIZE = 1024000KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FreshoFarmTest_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FreshoFarmTest_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FreshoFarmTest] SET COMPATIBILITY_LEVEL = 110
GO
ALTER DATABASE [FreshoFarmTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FreshoFarmTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FreshoFarmTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FreshoFarmTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FreshoFarmTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FreshoFarmTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FreshoFarmTest] SET  READ_WRITE 
GO
ALTER DATABASE [FreshoFarmTest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FreshoFarmTest] SET  MULTI_USER 
GO
ALTER DATABASE [FreshoFarmTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FreshoFarmTest] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FreshoFarmTest]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [FreshoFarmTest] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
