USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Listar_ESTADOS
AS
BEGIN
SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
END
GO


