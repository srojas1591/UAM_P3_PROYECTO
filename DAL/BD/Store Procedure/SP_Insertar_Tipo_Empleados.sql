USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Insertar_Tipos_Empleados
(
	@DescTipo VARCHAR(150),
	@IdEstado CHAR(1)
)
AS
BEGIN
INSERT INTO [dbo].[T_TiposEmpleados]
           ([DescTipo]
           ,[IdEstado])
     VALUES
           (@DescTipo,@IdEstado)

	SELECT MAX([IdTipoEmpleado])
	FROM [dbo].[T_TiposEmpleados]
END
GO


