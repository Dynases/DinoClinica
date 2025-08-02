USE BD_VET 
GO

/****** Object:  StoredProcedure [dbo].[sp_Mam_TC00121Cheque]    Script Date: 27/11/2019 6:39:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





--drop procedure sp_Mam_TV00121Cheque
CREATE PROCEDURE [dbo].[sp_Mam_TC00121Cheque] (@tipo int,@tenumi int=-1,@tefdoc date=null,
@tety4vend int=-1,@teobs nvarchar(100)='',@tdnumi int=-1,@teuact nvarchar(10)='',@TC00121 TC00121TypeCheque ReadOnly,
@credito int=-1)

AS
BEGIN
	DECLARE @codProv int			
	DECLARE @nomcliprov nvarchar(200)
	DECLARE @caemision int
	DECLARE @montot decimal (18,2)
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))	
	DECLARE @newFecha date
	set @newFecha=GETDATE()
	declare @contabilizo int

	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY

		DELETE FROM TC00121  WHERE tdtc13numi =@tenumi 
		delete from TC0013 where tenumi=@tenumi 

		
		select @tenumi as newNumi  --Consultar que hace newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@teuact)
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO
	BEGIN
		BEGIN TRY 

		      set @tenumi=IIF((select COUNT(tenumi) from TC0013)=0,0,(select MAX(tenumi) from TC0013))+1
			  insert into TC0013 values(@tenumi ,@tefdoc,@tety4vend ,@teobs ,@newFecha ,@newHora ,@teuact )
		----INSERTO EL DETALLE
				INSERT INTO TC00121 (tdtc12numi,tdtc13numi  ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo,tdty3banco ,
				tdnrocheque ,tdfact ,tdhact ,tduact)

			SELECT td.tdtc12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
			td.tdnrocheque, @newFecha  ,@newHora  ,@teuact 
			FROM @TC00121 AS td where td.estado =0

		
			select @tdnumi as newNumi

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

		IF @tipo=2 --MODIFICAR REGISTRO
	BEGIN
		BEGIN TRY 

			  update TC0013 set tefdoc =@tefdoc ,
			  tety4vend =@tety4vend ,teobs=@teobs,
			  tefact =@newFecha ,tehact =@newHora ,teuact =@teuact  
			  where tenumi =@tenumi 
		----INSERTO EL DETALLE
				INSERT INTO TC00121 (tdtc12numi ,tdtc13numi ,tdnrodoc ,tdfechaPago ,tdmonto ,tdnrorecibo,tdty3banco ,
				tdnrocheque ,tdfact ,tdhact ,tduact)
			SELECT td.tdtc12numi,@tenumi  ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
			td.tdnrocheque, @newFecha  ,@newHora  ,@teuact 
			FROM @TC00121 AS td where td.estado =0

		    UPDATE TC00121 
			SET tdmonto=td.tdmonto ,tdnrorecibo =td.tdnrorecibo ,
			tdty3banco =td.tdty3banco ,tdnrocheque =td.tdnrocheque  
			FROM TC00121  INNER JOIN @TC00121 AS td
			ON TC00121.tdnumi     = td.tdnumi   and td.estado=2;

				--ELIMINO LOS REGISTROS
			DELETE FROM TC00121 WHERE tdnumi   in (SELECT td.tdnumi   FROM @TC00121 AS td WHERE td.estado=-1)



			

			select @tdnumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

		IF @tipo=3
	BEGIN
		BEGIN TRY 
		select a.tenumi,detalle.tdnrodoc,a.tefdoc ,a.tety4vend,vendedor .yddesc as vendedor,
		a.teobs ,a.tefact ,a.tehact ,a.teuact  ,Sum(detalle .tdmonto) as total 
		from TC0013 as a
		left join TY004 as vendedor on vendedor .ydnumi =a.tety4vend 
		inner join TC00121 as detalle on detalle .tdtc13numi =a.tenumi 
		group by a.tenumi,detalle.tdnrodoc,a.tefdoc ,a.tety4vend,vendedor .yddesc,
		a.teobs ,a.tefact ,a.tehact ,a.teuact  
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
		IF @tipo=4
	BEGIN
		BEGIN TRY 
	select  detalle .tdnumi as numidetalle,proveedor.yddesc as proveedor,compra.canumi NroDoc,
	a.tcnumi as numiCredito,cobranza .tenumi as numiCobranza
	,a.tctc1numi ,a.tcty4prov  ,detalle.tdfechaPago,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TC00121 as detalle where detalle .tdtc12numi =a.tcnumi ))
	 as pendiente,detalle .tdmonto  as PagoAc,detalle .tdnrorecibo  as NumeroRecibo,
    concat (banco .canombre,' ',IIF(banco.canumi=1,'',banco.canrocuenta ))   as DescBanco,detalle .tdty3banco as banco, detalle.tdnrocheque,Cast('' as image)as img ,1 as estado 
	from TC0012 as a inner join TY004 as proveedor
	on proveedor .ydnumi =a.tcty4prov 
	inner join TC001 as compra on compra.canumi =a.tctc1numi 
	inner join TA001 as sucursal on sucursal.aanumi =compra .caalm 
	inner join TC00121 as detalle on detalle .tdtc12numi =a.tcnumi 
	inner join TC0013 as cobranza on cobranza .tenumi =detalle .tdtc13numi 
	left join BDDiconDinoEco.dbo.BA001   as banco on banco.canumi =detalle .tdty3banco  
	where cobranza.tenumi =@tenumi 
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
	IF @tipo=5
	BEGIN
		BEGIN TRY 
	select a.tdnumi ,a.tdtc12numi ,a.tdnrodoc ,a.tdfechaPago ,a.tdmonto ,a.tdnrorecibo ,a.tdfact ,a.tdhact
	,a.tduact
	from TC00121 as a
	where a.tdtc12numi =@credito
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

			IF @tipo=6  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	--select a.tcnumi,sucursal .aabdes as sucursal,Concat(compra.taidcore ,'-',Year(a.tcfdoc)) NroDoc
	--,a.tctc1numi ,a.tcty4prov  , proveedor.yddesc as proveedor,a.tcfdoc ,tctotcre as totalfactura,
	--(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TC00121 as detalle where detalle .tdtc12numi =a.tcnumi ))as pendiente
	--,Cast(0 as decimal(18,2)) as PagoAc,'' as NumeroRecibo
	--from TC0012 as a inner join TY004 as proveedor
	--on proveedor .ydnumi =a.tcty4prov 
	--inner join TV001 as compra on compra.tanumi =a.tctc1numi 
	--inner join TA001 as sucursal on sucursal.aanumi =compra .taalm 
	--	where (tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TC00121 as detalle where detalle .tdtc12numi =a.tcnumi ))>0
	--order by a.tcnumi asc

	--Concat(compra.canumi ,'-',Year(a.tcfdoc)) NroDoc

	select a.tcnumi,sucursal .aabdes as sucursal,compra.canumi  NroDoc
	,a.tctc1numi ,a.tcty4prov  , proveedor.yddesc as proveedor,a.tcfdoc ,tctotcre as totalfactura,
	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TC00121 as detalle where detalle .tdtc12numi =a.tcnumi ))as pendiente
	,Cast(0 as decimal(18,2)) as PagoAc,'' as NumeroRecibo
	from TC0012 as a inner join TY004 as proveedor
	on proveedor .ydnumi =a.tcty4prov 
	inner join TC001 as compra on compra.canumi =a.tctc1numi 
	inner join TA001 as sucursal on sucursal.aanumi =compra.caalm 
		where (tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TC00121 as detalle where detalle .tdtc12numi =a.tcnumi ))>0
	order by a.tcnumi asc
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

	
			IF @tipo=7  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	select a.tdnumi ,a.tdtc12numi ,a.tdtc13numi ,a.tdnrodoc ,a.tdfechaPago ,a.tdmonto ,a.tdnrorecibo ,a.tdty3banco ,
	a.tdnrocheque ,a.tdfact ,a.tdhact ,a.tduact,Cast('' as image) as img,1 as estado
	from TC00121 as a where a.tdnumi =@tdnumi 

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END

		IF @tipo=8  ---------LISTAR DEUDAS PENDIENTES
	BEGIN
		BEGIN TRY 
	
SELECT cobranza.tenumi AS numiCobranza, a.tcty4prov  numiproveedor, proveedor.yddesc AS proveedor, 
FORMAT (cobranza.tefdoc, 'dd-MM-yyyy') AS fechaPago, Concat(compra.canumi , '-', Year(a.tcfdoc)) 
                  NroDoccompra, sucursal.aabdes AS sucursal, detalle.tdmonto AS importe, detalle.tdnrorecibo AS nroRecibo, banco.ycdes3 AS banco, detalle.tdnrocheque AS NroCheque, IIF
                      ((SELECT Sum(auxdetallepago.tdmonto)
                        FROM      TC00121 AS auxdetallepago
                        WHERE   auxdetallepago.tdtc12numi = a.tcnumi) = a.tctotcre, IIF
                      ((SELECT Max(ayuda.tdnumi)
                        FROM      TC00121 ayuda
                        WHERE   ayuda.tdtc12numi = a.tcnumi) = detalle.tdnumi, 'CANCELACION TOTAL', 'CANCELACION PARCIAL'), 'CANCELACION PARCIAL') AS observacion, cobranza.teobs AS glosa
FROM     TC0012 AS a INNER JOIN
                  TY004 AS proveedor ON proveedor.ydnumi = a.tcty4prov  INNER JOIN
                  TC001 AS compra ON compra.canumi  = a.tctc1numi INNER JOIN
                  TA001 AS sucursal ON sucursal.aanumi = compra.caalm  INNER JOIN
                  TC00121 AS detalle ON detalle.tdtc12numi = a.tcnumi INNER JOIN
                  TC0013 AS cobranza ON cobranza.tenumi = detalle.tdtc13numi INNER JOIN
                  TY0031 AS banco ON banco.yccod1 = 6 AND banco.yccod2 = 1 AND banco.yccod3 = detalle.tdty3banco AND cobranza.tenumi = @tenumi 
	order by a.tcnumi asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@teuact)
		END CATCH
	END
	IF @tipo=9 --Verificar si el Pago de las Compras a Crédito ya fue contabilizada
	BEGIN	
		BEGIN TRY	
			select *
			from BDDiconDinoEco.dbo.TPA001 as a 
			where a.aanumipadre=@tenumi and aatipo=3 and aanumiasiento>0	
		END TRY
		BEGIN CATCH	
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
			VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@teuact)
		END CATCH
	END
	
End











GO


