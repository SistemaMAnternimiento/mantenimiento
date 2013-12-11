USE [dbMantenimiento]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[id] [int] NOT NULL,
	[empresa] [varchar](250) NOT NULL,
	[contacto] [varchar](250) NOT NULL,
	[direccion] [varchar](450) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[id] [int] NOT NULL,
	[nombre] [varchar](150) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[__orm__]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__orm__](
	[databaseguid] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[linea_produccion]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[linea_produccion](
	[id] [int] NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[descripcion] [varchar](350) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_linea_produccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[funcion]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[funcion](
	[id] [int] NOT NULL,
	[nombre] [varchar](250) NOT NULL,
 CONSTRAINT [PK_funcion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[id] [int] NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[rubro] [varchar](250) NOT NULL,
	[direccion] [varchar](250) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[imagen] [image] NULL,
 CONSTRAINT [PK_empresa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[componente]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[componente](
	[id] [varchar](50) NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[marca] [varchar](250) NOT NULL,
	[idproveedor] [int] NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_componente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[material_herramienta]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[material_herramienta](
	[id] [int] NOT NULL,
	[nombre] [varchar](250) NULL,
	[marca] [varchar](50) NULL,
	[idproveedor] [int] NOT NULL,
	[precio] [float] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_material_herramienta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[maquina]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[maquina](
	[id] [varchar](50) NOT NULL,
	[nombre] [varchar](250) NOT NULL,
	[marca] [varchar](250) NOT NULL,
	[anho] [int] NULL,
	[industria] [varchar](250) NULL,
	[funcion] [varchar](450) NULL,
	[caracteristicas] [varchar](50) NULL,
	[idlinea] [int] NULL,
	[estado] [varchar](50) NULL,
	[estado2] [bit] NULL,
 CONSTRAINT [PK_maquina] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[privilegio]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[privilegio](
	[id] [int] NOT NULL,
	[idrol] [int] NOT NULL,
	[idfuncion] [int] NOT NULL,
 CONSTRAINT [PK_privilegio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[idrol] [int] NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[recomendacion]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recomendacion](
	[id] [int] NOT NULL,
	[idmaquina] [varchar](50) NOT NULL,
	[recomendacion] [text] NOT NULL,
	[tipo] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_recomendacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[problema]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[problema](
	[id] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[idmaquina] [varchar](50) NULL,
	[motivo] [varchar](450) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_problema] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[solicitud]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[solicitud](
	[id] [int] NOT NULL,
	[idusuario] [int] NULL,
	[fecha] [datetime] NULL,
	[observacion] [varchar](550) NULL,
	[estado] [bit] NULL,
	[tipo] [varchar](50) NULL,
	[idMaquina] [varchar](50) NULL,
	[estado_solicitud] [varchar](50) NULL,
 CONSTRAINT [PK_mantenimiento] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[id] [int] NOT NULL,
	[idmaterial] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_reparo]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_reparo](
	[idmaquina] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[id] [int] NOT NULL,
	[idusuario] [int] NULL,
	[idproblema] [int] NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_detalle_reparo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aprobacion]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aprobacion](
	[id] [int] NOT NULL,
	[idMantenimiento] [int] NULL,
	[fecha] [date] NULL,
	[idusuario] [int] NULL,
 CONSTRAINT [PK_aprobacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materialusado]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materialusado](
	[id] [int] NOT NULL,
	[idmaterial] [int] NULL,
	[cantidad] [int] NULL,
	[id_reparo] [int] NULL,
 CONSTRAINT [PK_materialusado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleComponente]    Script Date: 12/10/2013 19:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleComponente](
	[id_componente] [varchar](50) NULL,
	[id_reparo] [int] NULL,
	[cantidad] [int] NULL,
	[monto] [float] NULL,
	[id] [int] NOT NULL,
 CONSTRAINT [PK_detalleComponente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_rol_estado]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[rol] ADD  CONSTRAINT [DF_rol_estado]  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF_Usuario_estado]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_estado]  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  ForeignKey [FK_aprobacion_mantenimiento]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[aprobacion]  WITH CHECK ADD  CONSTRAINT [FK_aprobacion_mantenimiento] FOREIGN KEY([idMantenimiento])
REFERENCES [dbo].[solicitud] ([id])
GO
ALTER TABLE [dbo].[aprobacion] CHECK CONSTRAINT [FK_aprobacion_mantenimiento]
GO
/****** Object:  ForeignKey [FK_aprobacion_Usuario]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[aprobacion]  WITH CHECK ADD  CONSTRAINT [FK_aprobacion_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[aprobacion] CHECK CONSTRAINT [FK_aprobacion_Usuario]
GO
/****** Object:  ForeignKey [FK_componente_proveedor]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[componente]  WITH CHECK ADD  CONSTRAINT [FK_componente_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([id])
GO
ALTER TABLE [dbo].[componente] CHECK CONSTRAINT [FK_componente_proveedor]
GO
/****** Object:  ForeignKey [FK_detalle_reparo_maquina]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[detalle_reparo]  WITH CHECK ADD  CONSTRAINT [FK_detalle_reparo_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalle_reparo] CHECK CONSTRAINT [FK_detalle_reparo_maquina]
GO
/****** Object:  ForeignKey [FK_detalle_reparo_problema1]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[detalle_reparo]  WITH CHECK ADD  CONSTRAINT [FK_detalle_reparo_problema1] FOREIGN KEY([idproblema])
REFERENCES [dbo].[problema] ([id])
GO
ALTER TABLE [dbo].[detalle_reparo] CHECK CONSTRAINT [FK_detalle_reparo_problema1]
GO
/****** Object:  ForeignKey [FK_detalle_reparo_Usuario]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[detalle_reparo]  WITH CHECK ADD  CONSTRAINT [FK_detalle_reparo_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[detalle_reparo] CHECK CONSTRAINT [FK_detalle_reparo_Usuario]
GO
/****** Object:  ForeignKey [FK_detalleComponente_componente1]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[detalleComponente]  WITH CHECK ADD  CONSTRAINT [FK_detalleComponente_componente1] FOREIGN KEY([id_componente])
REFERENCES [dbo].[componente] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalleComponente] CHECK CONSTRAINT [FK_detalleComponente_componente1]
GO
/****** Object:  ForeignKey [FK_detalleComponente_detalle_reparo]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[detalleComponente]  WITH CHECK ADD  CONSTRAINT [FK_detalleComponente_detalle_reparo] FOREIGN KEY([id_reparo])
REFERENCES [dbo].[detalle_reparo] ([id])
GO
ALTER TABLE [dbo].[detalleComponente] CHECK CONSTRAINT [FK_detalleComponente_detalle_reparo]
GO
/****** Object:  ForeignKey [FK_inventario_material_herramienta]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [FK_inventario_material_herramienta] FOREIGN KEY([idmaterial])
REFERENCES [dbo].[material_herramienta] ([id])
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [FK_inventario_material_herramienta]
GO
/****** Object:  ForeignKey [FK_maquina_linea_produccion]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[maquina]  WITH CHECK ADD  CONSTRAINT [FK_maquina_linea_produccion] FOREIGN KEY([idlinea])
REFERENCES [dbo].[linea_produccion] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[maquina] CHECK CONSTRAINT [FK_maquina_linea_produccion]
GO
/****** Object:  ForeignKey [FK_material_herramienta_proveedor]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[material_herramienta]  WITH CHECK ADD  CONSTRAINT [FK_material_herramienta_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([id])
GO
ALTER TABLE [dbo].[material_herramienta] CHECK CONSTRAINT [FK_material_herramienta_proveedor]
GO
/****** Object:  ForeignKey [FK_materialusado_detalle_reparo]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[materialusado]  WITH CHECK ADD  CONSTRAINT [FK_materialusado_detalle_reparo] FOREIGN KEY([id_reparo])
REFERENCES [dbo].[detalle_reparo] ([id])
GO
ALTER TABLE [dbo].[materialusado] CHECK CONSTRAINT [FK_materialusado_detalle_reparo]
GO
/****** Object:  ForeignKey [FK_materialusado_inventario]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[materialusado]  WITH CHECK ADD  CONSTRAINT [FK_materialusado_inventario] FOREIGN KEY([idmaterial])
REFERENCES [dbo].[inventario] ([id])
GO
ALTER TABLE [dbo].[materialusado] CHECK CONSTRAINT [FK_materialusado_inventario]
GO
/****** Object:  ForeignKey [FK_privilegio_funcion]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[privilegio]  WITH CHECK ADD  CONSTRAINT [FK_privilegio_funcion] FOREIGN KEY([idfuncion])
REFERENCES [dbo].[funcion] ([id])
GO
ALTER TABLE [dbo].[privilegio] CHECK CONSTRAINT [FK_privilegio_funcion]
GO
/****** Object:  ForeignKey [FK_privilegio_rol]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[privilegio]  WITH CHECK ADD  CONSTRAINT [FK_privilegio_rol] FOREIGN KEY([idrol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[privilegio] CHECK CONSTRAINT [FK_privilegio_rol]
GO
/****** Object:  ForeignKey [FK_problema_maquina]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[problema]  WITH CHECK ADD  CONSTRAINT [FK_problema_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[problema] CHECK CONSTRAINT [FK_problema_maquina]
GO
/****** Object:  ForeignKey [FK_recomendacion_maquina]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[recomendacion]  WITH CHECK ADD  CONSTRAINT [FK_recomendacion_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[recomendacion] CHECK CONSTRAINT [FK_recomendacion_maquina]
GO
/****** Object:  ForeignKey [FK_solicitud_maquina]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[solicitud]  WITH CHECK ADD  CONSTRAINT [FK_solicitud_maquina] FOREIGN KEY([idMaquina])
REFERENCES [dbo].[maquina] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[solicitud] CHECK CONSTRAINT [FK_solicitud_maquina]
GO
/****** Object:  ForeignKey [FK_solicitud_Usuario]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[solicitud]  WITH CHECK ADD  CONSTRAINT [FK_solicitud_Usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[solicitud] CHECK CONSTRAINT [FK_solicitud_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_rol1]    Script Date: 12/10/2013 19:11:16 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_rol1] FOREIGN KEY([idrol])
REFERENCES [dbo].[rol] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_rol1]
GO
-- Standard syntax
INSERT dbo.rol (id, nombre, estado)
    VALUES (1, 'administrador', 'true')
GO

-- Standard syntax
INSERT dbo.Usuario (id,usuario,password,idrol,estado)
    VALUES (1, 'admin', 'admin',1,'true')
INSERT dbo.funcion (id,nombre)
    VALUES (2, 'GESTIONAR ACCESO')	
	INSERT dbo.funcion (id,nombre)
    VALUES (3, 'GESTIONAR MAQUINARIA')	
	INSERT dbo.funcion (id,nombre)
    VALUES (4, 'GESTIONAR INVENTARIO')	
	INSERT dbo.funcion (id,nombre)
    VALUES (5, 'GESTIONAR PERMISOS')	
	INSERT dbo.funcion (id,nombre)
    VALUES (6, 'REGISTRO MANTENIMIENTO')	
	INSERT dbo.funcion (id,nombre)
    VALUES (7, 'REPORTES')	
	INSERT dbo.funcion (id,nombre)
    VALUES (1, 'CONFIGURACION')	
	
INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (1,1,1)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (2,1,2)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (3,1,3)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (4,1,4)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (5,1,5)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (6,1,6)
	INSERT dbo.privilegio (id,idrol,idfuncion)
    VALUES (7,1,7)
GO