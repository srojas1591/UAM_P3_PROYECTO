USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO
create procedure sp_Listar_Usuarios
as
begin
SELECT [Username] as [Nombre Usuario]
      ,[Password] as [Contraseña]
      ,[IdEmpleado]
      ,[IdEstado]
  FROM [dbo].[T_Usuarios]
  end
GO


