USE [master]
GO

/****** Object:  Database [ContosoUniversity]    Script Date: 10/5/2017 13:38:47 ******/
CREATE DATABASE [ContosoUniversity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ContosoUniversity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ContosoUniversity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ContosoUniversity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ContosoUniversity_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [ContosoUniversity] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ContosoUniversity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ContosoUniversity] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ContosoUniversity] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ContosoUniversity] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ContosoUniversity] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ContosoUniversity] SET ARITHABORT OFF 
GO

ALTER DATABASE [ContosoUniversity] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ContosoUniversity] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ContosoUniversity] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ContosoUniversity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ContosoUniversity] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ContosoUniversity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ContosoUniversity] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ContosoUniversity] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ContosoUniversity] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ContosoUniversity] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ContosoUniversity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ContosoUniversity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ContosoUniversity] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ContosoUniversity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ContosoUniversity] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ContosoUniversity] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ContosoUniversity] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ContosoUniversity] SET RECOVERY FULL 
GO

ALTER DATABASE [ContosoUniversity] SET  MULTI_USER 
GO

ALTER DATABASE [ContosoUniversity] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ContosoUniversity] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ContosoUniversity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ContosoUniversity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ContosoUniversity] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ContosoUniversity] SET QUERY_STORE = OFF
GO

USE [ContosoUniversity]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [ContosoUniversity] SET  READ_WRITE 
GO

