/****** Object:  Table [SOPORTE].[AuditoriaComponentes]    Script Date: 14/02/2019 2:05:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [SOPORTE].[AuditoriaComponentes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Opcion] [varchar](100) NULL,
	[Proyecto] [varchar](100) NULL,
	[Ruta] [varchar](100) NULL,
	[EsquemaComponente] [varchar](50) NULL,
	[NombreComponente] [varchar](100) NULL,
	[TipoComponente] [varchar](50) NULL,
	[Observacion] [varchar](300) NULL,
 CONSTRAINT [PK_AuditoriaComponentes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [SOPORTE].[AuditoriaComponentes] ON 

INSERT [SOPORTE].[AuditoriaComponentes] ([id], [Opcion], [Proyecto], [Ruta], [EsquemaComponente], [NombreComponente], [TipoComponente], [Observacion]) VALUES (1, N'Registrar comprobante de ingreso', N'Facturación', N'FRO>Facturación>COMPROBANTES DE INGRESO>Registrar comprobante de ingreso', N'dbo', N'AG_FacturasCI', N'SP', N'Es el procedimiento se encarga de consultar las facturas según el tercero que se seleccione y carga la etiqueta HTML con el identificador unico #factCB1.')
INSERT [SOPORTE].[AuditoriaComponentes] ([id], [Opcion], [Proyecto], [Ruta], [EsquemaComponente], [NombreComponente], [TipoComponente], [Observacion]) VALUES (2, N'INMUEBLES ARRENDADOS', N'ABR', N'ABR>ADMINISTRACIÓN>INFORMES>INFORMES DE ADMINISTRACIÓN', N'ABR', N'FGR_INF_ConsultaArrendamientos', N'SP', N'Procedimiento de consulta INMUEBLES ARRENDADOS')
INSERT [SOPORTE].[AuditoriaComponentes] ([id], [Opcion], [Proyecto], [Ruta], [EsquemaComponente], [NombreComponente], [TipoComponente], [Observacion]) VALUES (3, N'INFORMACIÓN GENERAL', N'ABR', N'ABR>TRAMITACIÓN>ESTRUCTURACIÓN DEL NEGOCIO ficha INFORMACIÓN GENERAL', N'ABR', N'MAU_CreaSolicitudesArrendamiento', N'SP', N'Este procedimiento es para la creacion de Solicitudes de arrendamiento')
INSERT [SOPORTE].[AuditoriaComponentes] ([id], [Opcion], [Proyecto], [Ruta], [EsquemaComponente], [NombreComponente], [TipoComponente], [Observacion]) VALUES (4, N'INFORMACIÓN GENERAL', N'ABR', N'ABR>TRAMITACIÓN>ESTRUCTURACIÓN DEL NEGOCIO ficha INFORMACIÓN GENERAL', N'ABR', N'MAU_CrearArrendatarios', N'SP', N'Este procedimineto es llamado del procedimine anterior para crear arrendatarios')
SET IDENTITY_INSERT [SOPORTE].[AuditoriaComponentes] OFF
