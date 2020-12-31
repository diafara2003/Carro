IF OBJECT_ID(N'dbo.TipoVehiculo',N'U') IS NULL BEGIN
	CREATE TABLE dbo.TipoVehiculo(
	TipVehId int primary key identity,
	TipVehNombre varchar(200),
	TipVehDescripcion varchar(200)
	)
END
GO

IF COL_LENGTH('dbo.TipoVehiculo','TipVehId') IS NULL AND OBJECT_ID(N'dbo.TipoVehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.TipoVehiculo ADD TipVehId int IDENTITY(1,1) NOT NULL 
END
GO
IF COL_LENGTH('dbo.TipoVehiculo','TipVehNombre') IS NULL AND OBJECT_ID(N'dbo.TipoVehiculo') IS NOT NULL BEGIN
	ALTER TABLE TipoVehiculo ADD TipVehNombre varchar(200) 
END
GO
IF COL_LENGTH('dbo.TipoVehiculo','TipVehDescripcion') IS NULL AND OBJECT_ID(N'dbo.TipoVehiculo') IS NOT NULL BEGIN
	ALTER TABLE dbo.TipoVehiculo ADD TipVehDescripcion varchar(200) 
END
GO
