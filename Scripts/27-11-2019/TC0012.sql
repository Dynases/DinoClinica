USE [BD_VET] 
GO

/****** Object:  Table [dbo].[TC0012]    Script Date: 27/11/2019 6:38:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TC0012](
	[tcnumi] [int] NULL,
	[tctc1numi] [int] NULL,
	[tcty4prov] [int] NULL,
	[tcfvencre] [date] NULL,
	[tcnotaentre] [nvarchar](20) NULL,
	[tcnrofact] [nvarchar](20) NULL,
	[tctotcre] [decimal](18, 2) NULL,
	[tcfdoc] [date] NULL,
	[tcfact] [date] NULL,
	[tchact] [nvarchar](5) NULL,
	[tcuact] [nvarchar](10) NULL
) ON [PRIMARY]

GO


