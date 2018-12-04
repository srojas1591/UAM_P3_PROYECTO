USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
CREATE PROCEDURE sp_Insertar_Horarios
(

	@IdEstado AS CHAR(1),
	@DescHorario AS VARCHAR(150),
	@CantHoras AS INT,
	@Entrada VARCHAR(8),
	@Salida VARCHAR(8)

)
AS
	BEGIN

INSERT INTO [dbo].[T_Horarios]
           ([DescHorario]
           ,[CantHoras]
           ,[Entrada]
           ,[Salida]
           ,[IdEstado])
     VALUES
           (@IdEstado, @DescHorario  ,@CantHoras ,@Entrada  ,@Salida)

	SELECT MAX ([IdHorario])
	FROM [dbo].[T_Horarios]

	END
GO


