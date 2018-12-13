USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Listar_Tipo_Empleados
AS
BEGIN
SELECT [IdTipoEmpleado]
      ,[DescTipo]
      ,[IdEstado]
  FROM [dbo].[T_TiposEmpleados]
 END
GO


