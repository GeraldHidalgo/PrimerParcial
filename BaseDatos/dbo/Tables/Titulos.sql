﻿CREATE TABLE [dbo].[Titulos]
(
	Id_Titulo INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Titulo PRIMARY KEY CLUSTERED(Id_Titulo)
	,Descripcion VARCHAR(250) NOT NULL
	,Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION = PAGE)
GO

CREATE UNIQUE NONCLUSTERED INDEX IDX_Titulo
ON dbo.Titulos(Id_Titulo)
WITH (DATA_COMPRESSION = PAGE)
GO
