USE [C:\USERS\RAPTO\WORKBENCH\MIPROYECTO\INSCRIPCION_MT\INSCRIPCION2\CAPADATOS\CAPADATOS.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[TutorInsertar]
		@pNombre = N'Kevin',
		@pApellidos = N'Beam',
		@pTelefono = N'809-423-1234',
		@pCedula = N'1234123234',
		@pDireccion = N'1234',
		@pEstado = N'Activo'

SELECT	@return_value as 'Return Value'

GO
