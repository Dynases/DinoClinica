USE [BD_VET]
GO

/****** Object:  Trigger [dbo].[Tr_Mam_Insert_Compra_Insert]    Script Date: 27/11/2019 6:52:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

----drop TRIGGER Tr_Mam_UpdateInsert_Compra_Insert
CREATE TRIGGER [dbo].[Tr_Mam_Insert_Compra_Insert] ON [dbo].[TC001]
AFTER INSERT
AS
BEGIN
Declare 
		@canumi int ,@caalm int,@cafdoc date, @caven int,@caty4prov int,
		@catven int,@cafvcr date ,@caclpr int,@caest int,@cadesc decimal(18,2) ,@caice int,	
		@ingreso int, @salida int,@cancact decimal(18,2)
		,@maxid1 int,@fact date,@maxid2 int,@deposito int,@catotal decimal(18,2)
		,@tocal decimal(18,2),@descuento decimal(18,2),@cantDecalle decimal(18,2)
		,@cafact date ,@cahact nvarchar(5),@cauact nvarchar(10)
		set @salida = 4

--Declarando el cursor
declare MiCursor Cursor
	for Select a.canumi  ,a.caalm ,a.cafdoc ,a.caty4prov  ,a.catven ,a.cafvcr,a.caest ,
	a.cadesc ,a.catotal ,a.cafact ,a.cahact ,a.cauact       --, a.chhact, a.chuact, b.cpmov, b.cpdesc
				From inserted a where a.catven=0  --INNER JOIN TCI001 b ON a.chtmov=b.cpnumi
--Abrir el cursor
open MiCursor
-- Navegar
Fetch MiCursor into  @canumi   ,@caalm ,@cafdoc , @caty4prov ,
		@catven ,@cafvcr  ,@caest ,@cadesc ,@catotal,@cafact  ,@cahact ,@cauact 
while (@@FETCH_StaTUS = 0)
begin
				begin try
					begin tran Tr_UpdateTI001
						--Obtener la cantidad actual
					--  set @cancact = (select TI001.iacant from TI001 where TI001.iacprod = convert(int, @cpcom))
						
					set @maxid1 = iif((select COUNT(a.tcnumi) from TC0012 a) = 0, 0, (select max(a.tcnumi) from TC0012 a))
					insert into TC0012 values(@maxid1+1 ,@canumi ,@caty4prov ,@cafvcr ,'0','0',@catotal ,@cafdoc ,@cafact ,@cahact ,@cauact)

					commit tran Tr_UpdateTI001
					print concat('Se actualizo el saldo del producto con codigo: ', @canumi)
				end try
				begin catch
					rollback tran Tr_UpdateTI001
					print concat('No se pudo actualizo el saldo del producto con codigo: ', @canumi)
				end catch
		
			
	Fetch MiCursor into @canumi   ,@caalm ,@cafdoc , @caty4prov ,
		@catven ,@cafvcr  ,@caest ,@cadesc ,@catotal,@cafact  ,@cahact ,@cauact 
end

--Cerrar el Cursor
close MiCursor
--Liberar la memoria
deallocate MiCursor
END

GO


