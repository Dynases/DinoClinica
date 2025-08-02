USE [BD_VET] 
GO

/****** Object:  UserDefinedTableType [dbo].[TC00121TypeCheque]    Script Date: 27/11/2019 6:33:20 ******/
CREATE TYPE [dbo].[TC00121TypeCheque] AS TABLE(
	[tdnumi] [int] NULL,
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
	[tduact] [nvarchar](10) NULL,
	[img] [image] NULL,
	[estado] [int] NULL
)
GO


