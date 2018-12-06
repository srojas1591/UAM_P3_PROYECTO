USE [DB_BANCO_ELECTRONICO_PROGRA_III]
GO

CREATE PROCEDURE [dbo].[sp_Listar_Empleados]
AS
BEGIN
	SELECT [IdEmpleado]
      ,[Cedula]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Edad]
      ,[Telefono_Casa]
      ,[Telefono_Referencia]
      ,[Celular]
      ,[Salario]
      ,[IdTipoEmpleado]
      ,[IdDepartamento]
      ,[IdHorario]
      ,[IdEstado]
  FROM [dbo].[T_Empleados]
END
GO

CREATE PROCEDURE [dbo].[sp_Filtrar_Empleados]
(
	@Filtro as varchar(150)
)
AS
BEGIN
	SELECT [IdEmpleado]
      ,[Cedula]
      ,[Nombre]
      ,[Apellidos]
      ,[Direccion]
      ,[Edad]
      ,[Telefono_Casa]
      ,[Telefono_Referencia]
      ,[Celular]
      ,[Salario]
      ,[IdTipoEmpleado]
      ,[IdDepartamento]
      ,[IdHorario]
      ,[IdEstado]
  FROM [dbo].[T_Empleados]
END
GO

CREATE PROCEDURE [dbo].[sp_Eliminar_Empleado]
(
	@IdEmpleado VARCHAR(7)
 )
AS
BEGIN	
	DELETE FROM [dbo].[T_Empleados]
      WHERE [IdEmpleado] = @IdEmpleado
END
GO

CREATE PROCEDURE [dbo].[sp_Modificar_Empleado]
(
		   @IdEmpleado  varchar(7)
		  ,@Cedula varchar(11)
		  ,@Nombre varchar(25)
		  ,@Apellidos varchar(150)
		  ,@Direccion varchar(150)
		  ,@Edad int
		  ,@Telefono_Casa varchar(9)
		  ,@Telefono_Referencia varchar(9)
		  ,@Celular varchar(9)
		  ,@Salario decimal(18,2)
		  ,@IdTipoEmpleado int
		  ,@IdDepartamento char(5)
		  ,@IdHorario int
		  ,@IdEstado char(1)
)
AS
BEGIN
	  UPDATE [dbo].[T_Empleados]
	   SET [Cedula] = @Cedula
		  ,[Nombre] = @Nombre
		  ,[Apellidos] = @Apellidos
		  ,[Direccion] = @Direccion
		  ,[Edad] = @Edad
		  ,[Telefono_Casa] = @Telefono_Casa
		  ,[Telefono_Referencia] = @Telefono_Referencia
		  ,[Celular] = @Celular
		  ,[Salario] = @Salario
		  ,[IdTipoEmpleado] = @IdTipoEmpleado
		  ,[IdDepartamento] = @IdDepartamento
		  ,[IdHorario] = @IdHorario
		  ,[IdEstado] = @IdEstado
	 WHERE [IdEmpleado] = @IdEmpleado
END	  
GO

CREATE PROCEDURE [dbo].[sp_Insertar_Empleado]
(
		   @IdEmpleado  varchar(7)
		  ,@Cedula varchar(11)
		  ,@Nombre varchar(25)
		  ,@Apellidos varchar(150)
		  ,@Direccion varchar(150)
		  ,@Edad int
		  ,@Telefono_Casa varchar(9)
		  ,@Telefono_Referencia varchar(9)
		  ,@Celular varchar(9)
		  ,@Salario decimal(18,2)
		  ,@IdTipoEmpleado int
		  ,@IdDepartamento char(5)
		  ,@IdHorario int
		  ,@IdEstado char(1)
)
AS
BEGIN
	
	INSERT INTO [dbo].[T_Empleados]
			   ([IdEmpleado]
			   ,[Cedula]
			   ,[Nombre]
			   ,[Apellidos]
			   ,[Direccion]
			   ,[Edad]
			   ,[Telefono_Casa]
			   ,[Telefono_Referencia]
			   ,[Celular]
			   ,[Salario]
			   ,[IdTipoEmpleado]
			   ,[IdDepartamento]
			   ,[IdHorario]
			   ,[IdEstado])
		 VALUES
			   (@IdEmpleado 
			  ,@Cedula 
			  ,@Nombre
			  ,@Apellidos 
			  ,@Direccion 
			  ,@Edad 
			  ,@Telefono_Casa 
			  ,@Telefono_Referencia 
			  ,@Celular 
			  ,@Salario 
			  ,@IdTipoEmpleado 
			  ,@IdDepartamento 
			  ,@IdHorario 
			  ,@IdEstado) 

END
GO

