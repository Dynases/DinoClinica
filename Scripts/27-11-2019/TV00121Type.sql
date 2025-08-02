USE [BD_VET] 
GO

/****** Object:  UserDefinedTableType [dbo].[TV00121Type]    Script Date: 20/09/2019 5:39:36 ******/
CREATE TYPE [dbo].[TV00121Type] AS TABLE(
	[tdnumi] [int] NULL,
	[tdtv12numi] [int] NULL,
	[tdnrodoc] [nvarchar](20) NULL,
	[tdfechaPago] [date] NULL,
	[tdmonto] [decimal](18, 2) NULL,
	[tdnrorecibo] [nvarchar](20) NULL,
	[tdfact] [date] NULL,
	[tdhact] [nvarchar](5) NULL,
	[tduact] [nvarchar](10) NULL,
	[img] [image] NULL
)
GO


