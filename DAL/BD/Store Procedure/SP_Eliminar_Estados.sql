USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Eliminar_Estados
(@IdEstado CHAR(1))
AS
BEGIN
DELETE FROM [dbo].[T_Estados]
      WHERE IdEstado = @IdEstado
END
GO


