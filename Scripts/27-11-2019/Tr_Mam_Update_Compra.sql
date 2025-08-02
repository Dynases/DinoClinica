USE [BD_VET]
GO

/****** Object:  Trigger [dbo].[Tr_Mam_Update_Compra]    Script Date: 27/11/2019 6:52:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Tr_Mam_Update_Compra] ON [dbo].[TC001]
AFTER update
AS
BEGIN

Declare 
		@canumi int ,@caalm int,@cafdoc date, @caven int,@caty4prov int,
		@catven int,@cafvcr date ,@caclpr int,@caest int,@cadesc decimal(18,2) ,@caice int,	
		@ingreso int, @salida int,@cancact decimal(18,2)
		,@maxid1 int,@fact date,@maxid2 int,@deposito int,@catotal decimal(18,2)
		,@tocal decimal(18,2),@descuento decimal(18,2),@cantDecalle decimal(18,2)
		,@cafact date ,@cahact nvarchar(5),@cauact nvarchar(10),@tatotinsert decimal(18,2)
		
			-------------------------------------------Venta TV001--------
		,@lcfpag date,@estTipoVenta int,@estTipoVentaDelete int,@numi int,
		@est int
		set @ingreso = 1
		set @salida = 2
		set @lcfpag=GETDATE ()
		set @salida = 4
		set @ingreso = 1
		set @salida = 2
		set @estTipoVenta =(select top (1) a.catven    from inserted a)
		set @estTipoVentaDelete=(select top (1) a.catven   from deleted  a)
		set @numi=(select top(1) a.canumi  from inserted a)
		set @est=(select top(1) a.caest  from inserted a)
	

-------------------------------------------------Else--------------
if(@estTipoVenta <>@estTipoVentaDelete )
			begin
			        if(@estTipoVenta =1)
					begin
					begin try
				begin tran Tr_UpdateTY0041
					
		set @canumi =(select top(1) a.canumi    from inserted a)
	
					delete from TC0012 where TC0012 .tctc1numi  =@canumi  
					commit tran Tr_UpdateTY0041
								print concat('se actualizo la deuda del cliente', @canumi)
							end try
							begin catch
								rollback tran Tr_UpdateTY0041
								print concat('No se pudo actualizo el saldo del producto con codigo: ', @canumi)
							end catch
					end

					 if(@estTipoVenta =0)
					begin
					 
					 declare MiCursor Cursor
	for Select a.canumi  ,a.caalm ,a.cafdoc ,a.caty4prov  ,a.catven ,a.cafvcr,a.caest ,
	a.cadesc ,a.catotal ,a.cafact ,a.cahact ,a.cauact       --, a.chhact, a.chuact, b.cpmov, b.cpdesc
				From inserted a where a.catven=0  --INNER JOIN TCI001 b ON a.chtmov=b.cpnumi
--Abrir el cursor
open MiCursor
-- Navegar
Fetch MiCursor into @canumi   ,@caalm ,@cafdoc , @caty4prov ,
		@catven ,@cafvcr  ,@caest ,@cadesc ,@catotal,@cafact  ,@cahact ,@cauact 
while (@@FETCH_STATUS = 0)
begin

		
				begin try
					begin tran Tr_InsertTI001
						--Insertar Saldo Inventario
					
				
					set @maxid1 = iif((select COUNT(a.tcnumi) from TC0012 a) = 0, 0, (select max(a.tcnumi) from TC0012 a))
					insert into TC0012 values(@maxid1+1 ,@canumi ,@caty4prov ,@cafvcr ,'0','0',@catotal ,@cafdoc ,@cafact ,@cahact ,@cauact)
                   commit tran Tr_InsertTI001
					print concat('Se grabo el saldo del producto con codigo: ', @canumi)
				end try
				begin catch
					rollback tran Tr_InsertTI001
					print concat('No se grabo el saldo del producto con codigo: ', @canumi)
				end catch
			
		
			
		
	Fetch MiCursor into @canumi   ,@caalm ,@cafdoc , @caty4prov ,
		@catven ,@cafvcr  ,@caest ,@cadesc ,@catotal,@cafact  ,@cahact ,@cauact 
end

--Cerrar el Cursor
close MiCursor
--Liberar la memoria
deallocate MiCursor
					end
			end
-----------------------------------------------------------
else
begin
	begin try
								begin tran Tr_UpdateTY0041

				
					set @tatotinsert=(select top(1) a.catotal from inserted  a)
		
		set @canumi =(select top(1) a.canumi   from inserted a)
	
		
					update TC0012 set TC0012.tctotcre=@tatotinsert
					where TC0012.tctc1numi =@canumi 
					commit tran Tr_UpdateTY0041
								print concat('se actualizo la deuda del cliente', @canumi)
							end try
							begin catch
								rollback tran Tr_UpdateTY0041
								print concat('No se pudo actualizo el saldo del producto con codigo: ', @canumi)
							end catch
end
		end

GO


