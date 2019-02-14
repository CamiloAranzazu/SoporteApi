
/****** Object:  StoredProcedure [SOPORTE].[CAP_AuditoriaComponentes]    Script Date: 14/02/2019 2:01:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Camilo Aranzazu>
-- Create date: <SOPORTE.AuditoriaComponentes>
-- Description:	<Auditoria de componentes>
-- =============================================
ALTER PROCEDURE [SOPORTE].[CAP_AuditoriaComponentes]
	

AS
BEGIN
	SET NOCOUNT ON;


	SELECT
					id 
					,Opcion
					,Proyecto
					,Ruta
					,EsquemaComponente
					,NombreComponente
					,TipoComponente
					,Observacion 
	FROM		
					SOPORTE.auditoriacomponentes

END
