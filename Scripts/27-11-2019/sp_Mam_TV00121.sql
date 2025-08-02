USE [BD_VET]
GO

/****** Object:  StoredProcedure [dbo].[sp_Mam_TV00121]    Script Date: 20/09/2019 5:42:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


--drop procedure sp_Mam_TV00121
CREATE PROCEDURE [dbo].[sp_Mam_TV00121] (@tipo int,@tdnumi int=-1,@tduact nvarchar(10)='',@TV00121 TV00121Type ReadOnly,
@credito int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()

	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY
		DELETE FROM TV00121  WHERE tdnumi =@tdnumi 
			select @tdnumi as newNumi  --Consultar que hace newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@tduact)
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 
		----INSERTO EL DETALLE
				INSERT INTO TV00121 (tdtv12numi ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo ,tdfact ,tdhact ,tduact)

			SELECT td.tdtv12numi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo , @newFecha  ,@newHora  ,@tduact 
			FROM @TV00121 AS td

			select @tdnumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@tduact)
		END CATCH
	END
		IF @tipo=3 
	BEGIN
		BEGIN TRY 
		select a.tcnumi,sucursal .aabdes as sucursal,Concat(venta.vaId  ,'-',Year(a.tcfdoc)) NroDoc,
	'S/F' as factura
	,a.tctv1numi ,a.tcty4clie , concat(cliente.canomb,' ',cliente.caapell ) as cliente,a.tcty4vend,
	vendedor.ecNomb  as vendedor,a.tcfdoc ,tctotcre as totalfactura,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))as pendiente
	,Cast(0 as decimal(18,2)) as PagoAc,'' as NumeroRecibo
	from TV0012 as a inner join REG.CLI001 as cliente
	on cliente .caid =a.tcty4clie 
	inner join REG.EMP002 as vendedor on vendedor .ecId =a.tcty4vend 
	inner join VEN.VEN001 as venta on venta.vaId =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .vaAlm 
		where (tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi ))>0
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@tduact)
		END CATCH
	END
	IF @tipo=4
	BEGIN
		BEGIN TRY 
	select a.tdnumi ,a.tdtv12numi ,a.tdnrodoc ,a.tdfechaPago ,a.tdmonto ,a.tdnrorecibo ,a.tdfact ,a.tdhact
	,a.tduact
	from TV00121 as a
	where a.tdtv12numi =@credito
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@tduact)
		END CATCH
	END
	
End










GO


