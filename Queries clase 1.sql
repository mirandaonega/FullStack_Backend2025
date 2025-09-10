USE [EntidadBancaria]
GO

CREATE TABLE [dbo].[Cuentas](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Descripcion] [varchar](50) NOT NULL,
	[Saldo] [decimal](18, 0) NOT NULL,
)

ALTER TABLE Cuentas
add Nombre varchar(50)

ALTER TABLE Cuentas
alter column Nombre varchar(70)

ALTER TABLE [dbo].[Transacciones]
DROP COLUMN [DescripcionMotivo]

