USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
ALTER PROCEDURE sp_Filtrar_Horarios
(@DescHorario VARCHAR(25))
AS
BEGIN
SELECT [IdHorario]
      ,[DescHorario]
      ,[CantHoras]
      ,[Entrada]
      ,[Salida]
      ,[IdEstado]
  FROM [dbo].[T_Horarios]
  WHERE DescHorario LIKE '%'+@DescHorario+'%'
 END
GO


