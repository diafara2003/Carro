SET XACT_ABORT ON;
IF OBJECT_ID('dbo.IngresarVehiculo',N'P') IS NOT NULL BEGIN
	DROP PROCEDURE dbo.IngresarVehiculo
END 
GO
-- =============================================
-- Author:		JHONNATAN ANDRES URUEÑA DIAZ
-- Create date: 30/12/2020
-- Description:	PERMITE CREAR UN VEHICULO
-- =============================================
CREATE PROCEDURE dbo.IngresarVehiculo
	@VehModelo varchar(200) ,@VehFecha int,@VehCilindraje NUMERIC(25,5),
	@VehTipoVehiculo INT,@VehMarca INT
AS
BEGIN
		
		INSERT INTO dbo.VEHICULO
					(VehModelo,VehFecha,VehCilindraje,
					 VehTipoVehiculo,VehMarca)
		VALUES		(@VehModelo,@VehFecha,@VehCilindraje,
					 @VehTipoVehiculo,@VehMarca)
END
GO
