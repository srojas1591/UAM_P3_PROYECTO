USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
create procedure sp_Listar_Productos
as
begin
SELECT [IdProducto]
      ,[NombreProducto]
      ,[IdMoneda]
      ,[IdEstado]
  FROM [dbo].[T_Productos]
  end
GO


