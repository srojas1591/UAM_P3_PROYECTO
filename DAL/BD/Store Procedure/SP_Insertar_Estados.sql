USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
create procedure sp_Insertar_Estados
(
            @IdEstado char(1),
           @Descripcion varchar(25)
)
as
begin
INSERT INTO [dbo].[T_Estados]
           ([IdEstado]
           ,[Descripcion])
     VALUES
           (@IdEstado, @Descripcion)
		   end
GO


