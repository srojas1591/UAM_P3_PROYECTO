USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Eliminar_Horarios
(

	@IdHorario INT

)
AS
BEGIN
DELETE FROM [dbo].[T_Horarios]
      WHERE IdHorario = @IdHorario
END
GO


