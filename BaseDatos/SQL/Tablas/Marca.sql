IF OBJECT_ID(N'dbo.Marca',N'U') IS NULL BEGIN
	CREATE TABLE dbo.Marca(
	MarId int primary key identity,
	MarNombre varchar(200)
	)
END
GO

IF COL_LENGTH('dbo.Marca','MarId') IS NULL AND OBJECT_ID(N'dbo.Marca') IS NOT NULL BEGIN
	ALTER TABLE Marca ADD MarId int IDENTITY(1,1) NOT NULL 
END
GO
IF COL_LENGTH('dbo.Marca','MarNombre') IS NULL AND OBJECT_ID(N'dbo.Marca') IS NOT NULL BEGIN
	ALTER TABLE Marca ADD MarNombre varchar(200) 
END
GO
