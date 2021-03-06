USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
/****** Object:  StoredProcedure [dbo].[sp_Modificar_Horarios]    Script Date: 3/12/2018 08:42:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_Modificar_Horarios]
(
	@IdHorario INT,
	@IdEstado CHAR(1),
	@DescHorario VARCHAR(150),
	@CantHoras INT,
    @Entrada VARCHAR(8),
	@Salida VARCHAR(8)

)
AS
BEGIN
UPDATE [dbo].[T_Horarios]
   SET [DescHorario] = @DescHorario
      ,[CantHoras] = @CantHoras
      ,[Entrada] = @Entrada
      ,[Salida] = @Salida
      ,[IdEstado] = @IdEstado
 WHERE IdHorario = @IdHorario

 SELECT MAX([IdHorario])
 FROM [dbo].[T_Horarios]

 END
