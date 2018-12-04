USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Modificar_Tipo_Empleados
(
	@IdTipoEmpleado INT,
	@DescTipo VARCHAR(150),
	@IdEstado CHAR(1)
)
AS

BEGIN

UPDATE [dbo].[T_TiposEmpleados]
   SET [DescTipo] = @DescTipo
      ,[IdEstado] = @IdEstado
  WHERE  [IdTipoEmpleado] = @IdTipoEmpleado

  SELECT MAX ([IdTipoEmpleado]) FROM [dbo].[T_TiposEmpleados]

 END
GO


