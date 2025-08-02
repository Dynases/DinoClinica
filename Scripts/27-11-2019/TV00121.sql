USE [BD_VET]
GO

/****** Object:  Table [dbo].[TV00121]    Script Date: 20/09/2019 5:07:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TV00121](
	[tdnumi] [int] IDENTITY(1,1) NOT NULL,
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
	[tduact] [nvarchar](10) NULL
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de Factura' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TV00121', @level2type=N'COLUMN',@level2name=N'tdnrodoc'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'monto de pago' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TV00121', @level2type=N'COLUMN',@level2name=N'tdmonto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nro de recibo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TV00121', @level2type=N'COLUMN',@level2name=N'tdnrorecibo'
GO


