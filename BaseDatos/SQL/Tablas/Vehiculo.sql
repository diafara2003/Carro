IF OBJECT_ID(N'dbo.Vehiculo',N'U') IS NULL BEGIN
	CREATE TABLE dbo.Vehiculo(
	VehId int primary key identity,
	VehTipoVehiculo int,
	VehModelo int,
	VehFecha int,
	VehCilindraje numeric(25,10),
	VehMarca int,
	
	)
END
GO

IF COL_LENGTH('dbo.Vehiculo','VehId') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehId int IDENTITY(1,1) NOT NULL 
END
GO
IF COL_LENGTH('dbo.Vehiculo','VehTipoVehiculo') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehTipoVehiculo int 
END
GO
IF COL_LENGTH('dbo.Vehiculo','VehModelo') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehModelo int 
END
GO
IF COL_LENGTH('dbo.Vehiculo','VehFecha') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehFecha int
END
GO
IF COL_LENGTH('dbo.Vehiculo','VehCilindraje') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehCilindraje numeric(25,10)
END
GO
IF COL_LENGTH('dbo.Vehiculo','VehMarca') IS NULL AND OBJECT_ID(N'dbo.Vehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.Vehiculo ADD VehMarca int 
END
GO