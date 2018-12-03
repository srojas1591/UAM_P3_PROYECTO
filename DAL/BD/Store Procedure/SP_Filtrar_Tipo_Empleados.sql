USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Filtrar_Tipo_Empleados
(@DescTipo VARCHAR(150))
AS
BEGIN
SELECT [IdTipoEmpleado]
      ,[DescTipo]
      ,[IdEstado]
  FROM [dbo].[T_TiposEmpleados]
  WHERE DescTipo LIKE '%'+ @DescTipo+'%'
 END
GO
