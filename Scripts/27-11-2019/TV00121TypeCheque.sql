USE [BD_VET]
GO

/****** Object:  UserDefinedTableType [dbo].[TV00121TypeCheque]    Script Date: 20/09/2019 5:06:23 ******/
CREATE TYPE [dbo].[TV00121TypeCheque] AS TABLE(
	[tdnumi] [int] NULL,
	[tdtv12numi] [int] NULL,
	[tdtv13numi] [int] NULL,
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


