CREATE PROCEDURE [dbo].[TituloObtener]
	@Id_Titulo INT = NULL
AS
	BEGIN 
	SET NOCOUNT ON

	SELECT 
	    Descripcion
	  , Estado
	FROM Titulos
	WHERE (@Id_Titulo IS NULL OR Id_Titulo = @Id_Titulo)

	END