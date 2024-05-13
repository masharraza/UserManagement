/****** Object:  Table [dbo].[Users]    Script Date: 5/14/2024 4:17:35 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
/****** Object:  Database [UserManagementSystem]    Script Date: 5/14/2024 4:17:35 AM ******/
DROP DATABASE [UserManagementSystem]
GO
/****** Object:  Database [UserManagementSystem]    Script Date: 5/14/2024 4:17:35 AM ******/
CREATE DATABASE [UserManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UserManagementSystem', FILENAME = N'C:\UserManagementDatabase\UserManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UserManagementSystem_log', FILENAME = N'C:\UserManagementDatabase\UserManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UserManagementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UserManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UserManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UserManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UserManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UserManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UserManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [UserManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UserManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UserManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UserManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UserManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UserManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UserManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UserManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UserManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UserManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UserManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UserManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UserManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UserManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UserManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UserManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UserManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UserManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [UserManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [UserManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UserManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UserManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UserManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UserManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UserManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'UserManagementSystem', N'ON'
GO
ALTER DATABASE [UserManagementSystem] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/14/2024 4:17:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER DATABASE [UserManagementSystem] SET  READ_WRITE 
GO
