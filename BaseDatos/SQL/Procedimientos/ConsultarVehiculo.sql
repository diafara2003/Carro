SET XACT_ABORT ON;
IF OBJECT_ID('dbo.ConsultarVehiculo',N'P') IS NOT NULL BEGIN
	DROP PROCEDURE dbo.ConsultarVehiculo
END 
GO
-- =============================================
-- Author:		JHONNATAN ANDRES URUEÑA DIAZ
-- Create date: 30/12/2020
-- Description:	PERMITE CONSULTAR TODOS LOS VEHICULOS DEL SISTEMA
-- =============================================
CREATE PROCEDURE dbo.ConsultarVehiculo
	@tipo int=1
AS
BEGIN
	IF(@tipo=1)BEGIN

		SELECT	VehId,VehModelo,VehFecha,VehCilindraje,
				MarNombre,TipVehNombre,TipVehDescripcion
		FROM	dbo.VEHICULO
				INNER JOIN dbo.MARCA ON MarId=VehMarca
				INNER JOIN dbo.TIPOVEHICULO ON TipVehId=VehTipoVehiculo
	END
	ELSE IF(@TIPO=2) BEGIN
		SELECT	MarId,MarNombre
		FROM	dbo.MARCA
	END
	ELSE IF(@TIPO=3) BEGIN
		SELECT	TipVehId,TipVehNombre
		FROM	dbo.TIPOVEHICULO
	END
	
END
GO
