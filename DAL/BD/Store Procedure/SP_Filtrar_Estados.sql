USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Filtrar_ESTADOS
(
	@Descripcion VARCHAR(25)
)
AS
BEGIN
SELECT [IdEstado]
      ,[Descripcion]
  FROM [dbo].[T_Estados]
  WHERE Descripcion LIKE '%'+@Descripcion+'%'
 END
GO


