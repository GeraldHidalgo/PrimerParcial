CREATE PROCEDURE [dbo].[DepartamentoEliminar]
	@Id_Departamento INT
AS
	BEGIN
		SET NOCOUNT ON
		BEGIN TRANSACTION TRASA
		BEGIN TRY

			DELETE FROM Departamentos
			WHERE Id_Departamento = @Id_Departamento
			
			COMMIT TRANSACTION
			
			SELECT 0 AS CodeError, '' AS msgError
		END TRY
		BEGIN CATCH
			SELECT
				ERROR_NUMBER() AS CodeError
				, ERROR_NUMBER() AS MsgError
			ROLLBACK TRANSACTION TRASA
		END CATCH

	END
