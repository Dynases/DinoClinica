USE [BD_VET]
GO

/****** Object:  StoredProcedure [dbo].[Sp_Mam_ReporteVentasVsCostos]    Script Date: 20/09/2019 5:04:44 ******/
DROP PROCEDURE [dbo].[Sp_Mam_ReporteVentasVsCostos]
GO

/****** Object:  StoredProcedure [dbo].[Sp_Mam_ReporteVentasVsCostos]    Script Date: 20/09/2019 5:04:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




--drop procedure Sp_Mam_ReporteVentas
CREATE PROCEDURE [dbo].[Sp_Mam_ReporteVentasVsCostos] (@tipo int,@numi int=-1,@fechaI date=null,@fechaF date=null,@uact nvarchar(10)='',
@vendedor int=-1,@almacen int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()


		IF @tipo=11 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 


select a.tcnumi,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc ,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie ,cliente.caid as ydcod, CONCAT (cliente .canomb ,' ',cliente.caapell)   as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,FORMAT ((detalle.tdfechaPago), 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,
	0 as pendiente	
	,	detalle.tdmonto as Pagado,0 as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join REG.CLI001  as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002  as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001  as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	and detalle .tdfechaPago >=@fechai and detalle .tdfechaPago <=@fechaf
		where    venta.vaEst<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi
	and detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
	order by  cliente.canomb asc

	

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
	IF @tipo=22 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
				
select a.tcnumi,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc ,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie ,cliente.caid as ydcod, CONCAT (cliente .canomb ,' ',cliente.caapell)   as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,FORMAT ((detalle.tdfechaPago), 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,
	0 as pendiente	
	,	detalle.tdmonto as Pagado,0 as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join REG.CLI001  as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002  as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001  as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	and detalle .tdfechaPago >=@fechai and detalle .tdfechaPago <=@fechaf
		where    venta.vaEst<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi
	and detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and vendedor .ecId  =@vendedor
		--and venta.tafdoc =@tefdoc 
	order by  cliente.canomb  asc



		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
		IF @tipo=33 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 

	select a.tcnumi,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc ,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie ,cliente.caid as ydcod, CONCAT (cliente .canomb ,' ',cliente.caapell)   as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,FORMAT ((detalle.tdfechaPago), 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,
	0 as pendiente	
	,	detalle.tdmonto as Pagado,0 as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join REG.CLI001  as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002  as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001  as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	and detalle .tdfechaPago >=@fechai and detalle .tdfechaPago <=@fechaf
		where    venta.vaEst<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi
	and detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and venta.vaAlm  =@almacen 
		--and venta.tafdoc =@tefdoc 
	order by  cliente.canomb  asc
			

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=44 --Reporte Ventas Atendidas General Sucursal con Vendedor 
	BEGIN
		BEGIN TRY 

select a.tcnumi,Concat(venta.vaId ,'-',Year(a.tcfdoc)) NroDoc ,
	'0' as factura
	,a.tctv1numi ,a.tcty4clie ,cliente.caid as ydcod, CONCAT (cliente .canomb ,' ',cliente.caapell)   as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,FORMAT ((detalle.tdfechaPago), 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.vaFechaDoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,
	0 as pendiente	
	,	detalle.tdmonto as Pagado,0 as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join REG.CLI001  as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002  as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001  as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm  
	inner join TV00121 as detalle on detalle .tdtv12numi =a.tcnumi 
	and detalle .tdfechaPago >=@fechai and detalle .tdfechaPago <=@fechaf
		where    venta.vaEst<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi
	and detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and venta.vaAlm =@almacen  and vendedor .ecId  =@vendedor  
		--and venta.tafdoc =@tefdoc 
	order by  cliente.canomb  asc
				
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
End








GO


