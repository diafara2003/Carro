-- =============================================
-- Author:		JHONNATAN ANDRES URUEÑA DIAZ
-- Create date: 30/12/2020
-- Description:	SCRIPT INICIAL
-- =============================================


TRUNCATE TABLE dbo.[Marca]
TRUNCATE TABLE dbo.[TipoVehiculo]
GO

INSERT dbo.[Marca] ([MarNombre]) VALUES ( N'Ford')
GO
INSERT dbo.[Marca] ([MarNombre]) VALUES ( N'Chevrolet')
GO
INSERT dbo.[Marca] ([MarNombre]) VALUES ( N'Mazda')
GO
INSERT dbo.[TipoVehiculo] ([TipVehNombre], [TipVehDescripcion]) VALUES ( N'Automovil', N'4 pasajeros')
GO
INSERT dbo.[TipoVehiculo] ([TipVehNombre], [TipVehDescripcion]) VALUES ( N'Camion', N'Bus intermunisipal')
