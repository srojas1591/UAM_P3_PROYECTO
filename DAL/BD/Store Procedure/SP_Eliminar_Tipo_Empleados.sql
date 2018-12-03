USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Eliminar_Tipo_Empleados
(@IdTipoEmpleado INT)
AS
BEGIN
DELETE FROM [dbo].[T_TiposEmpleados]
      WHERE IdTipoEmpleado = @IdTipoEmpleado
END
GO


