USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
create procedure sp_Modificar_Estados
(
            @IdEstado char(1),
           @Descripcion varchar(25)
)
as
begin

UPDATE [dbo].[T_Estados]
   SET 
     [Descripcion] = @Descripcion 
 WHERE [IdEstado] = @IdEstado
 end
GO


