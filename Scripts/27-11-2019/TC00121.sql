USE [BD_VET] 
GO

/****** Object:  Table [dbo].[TC00121]    Script Date: 27/11/2019 6:34:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TC00121](
	[tdnumi] [int] IDENTITY(1,1) NOT NULL,
	[tdtc12numi] [int] NULL,
	[tdtc13numi] [int] NULL,
	[tdnrodoc] [nvarchar](20) NULL,
	[tdfechaPago] [date] NULL,
	[tdmonto] [decimal](18, 2) NULL,
	[tdnrorecibo] [nvarchar](20) NULL,
	[tdty3banco] [int] NULL,
	[tdnrocheque] [nvarchar](30) NULL,
	[tdfact] [date] NULL,
	[tdhact] [nvarchar](5) NULL,
	[tduact] [nvarchar](10) NULL
) ON [PRIMARY]

GO


