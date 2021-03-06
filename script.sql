USE [BD_SAGA]
GO
/****** Object:  Table [dbo].[tblEvaluacionDesempeño]    Script Date: 05/03/2018 6:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEvaluacionDesempeño](
	[evades_intId] [int] IDENTITY(1,1) NOT NULL,
	[evades_strPregunta] [varchar](max) NOT NULL,
	[evades_strTipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblEvaluacionDesempeño] PRIMARY KEY CLUSTERED 
(
	[evades_intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEvaluacionDesempeñoOpciones]    Script Date: 05/03/2018 6:59:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEvaluacionDesempeñoOpciones](
	[evadesopc_intId] [int] IDENTITY(1,1) NOT NULL,
	[evadesopc_Texto] [varchar](max) NOT NULL,
	[evadesopc_fkIdevades] [int] NOT NULL,
 CONSTRAINT [PK_tblEvaluacionDesempeñoOpciones] PRIMARY KEY CLUSTERED 
(
	[evadesopc_intId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblEvaluacionDesempeño] ON 

INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (1, N'Como gerente mis planeación serian?', N'Gerencial')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (2, N'Como gerente  a poner en práctica las decisiones?', N'Gerencial')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (3, N'Como gerente  yo controlaría el trabajo?', N'Gerencial')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (4, N'Los problemas generalmente se resuelven?', N'Mandos medios')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (5, N'Genera recompensa?', N'Mandos medios')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (6, N'Resultados obtenidos', N'Mandos medios')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (7, N'Habilidades', N'Cargos Operativos')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (8, N'Puesta en practica', N'Cargos Operativos')
INSERT [dbo].[tblEvaluacionDesempeño] ([evades_intId], [evades_strPregunta], [evades_strTipo]) VALUES (9, N'Resultados obtenidos', N'Cargos Operativos')
SET IDENTITY_INSERT [dbo].[tblEvaluacionDesempeño] OFF
SET IDENTITY_INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ON 

INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (3, N'Innovadoras', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (4, N'Técnicas', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (5, N'Políticas', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (6, N'orientadas al personal', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (7, N'Consistentes', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (8, N'Autónomas', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (9, N'Cautelosas', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (10, N'Generales', 1)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (11, N'Con tacto', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (12, N'Administrativamente', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (13, N'para el personal', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (14, N'Rompiendo las reglas', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (15, N'Abiertamente', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (16, N'Encubiertamente', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (17, N'autónomamente', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (18, N'A través de equipos', 2)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (19, N'Reglas', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (20, N'Flexiblemente', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (21, N'Administrativamente', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (22, N'Conocimiento', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (23, N'Por producido fina', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (24, N'Resultados', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (25, N'Discretamente', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (26, N'Por mis propias reglas', 3)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (27, N'Creativamente', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (28, N'Seguridad', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (29, N'Sagazmente', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (30, N'apolíticamente ', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (31, N'para el futuro', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (32, N'por necesidad inmediata', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (33, N'por proceso', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (34, N'por resultado', 4)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (35, N'nuevas ideas', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (36, N'servicio leal', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (37, N'destrezas técnicas', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (38, N'discreción ', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (39, N'trabajo en equipo', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (40, N'Individualidad', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (41, N'seguimiento de logros', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (42, N'resultados inmediatos', 5)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (43, N'mantener el status', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (44, N'Innovar', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (45, N'Internos', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (46, N'Agregar más negocios', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (47, N'ser tangibles', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (48, N'ser intangibles', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (49, N'Predecibles', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (50, N'Improvisados', 6)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (51, N'Inescrupuloso', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (52, N'Empatía', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (53, N'toma de decisiones', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (54, N'Individualismo', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (55, N'Análisis', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (56, N'Obstinado', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (57, N'Delegación', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (58, N'Manejo de estrés', 7)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (59, N'planeación y organización', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (60, N'control gerencia', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (61, N'tolerancia de la tensión', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (62, N'fallo continuo', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (63, N'Adaptabilidad', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (64, N'estándares de trabajo', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (65, N'Impuntualidad', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (66, N'Planeación acelerada', 8)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (67, N'juicio critico', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (68, N'ambición de carrera', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (69, N'manejo del personal', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (70, N'cierre de procesos', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (71, N'destreza técnica', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (72, N'Metas propuestas', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (73, N'minimización  de recursos', 9)
INSERT [dbo].[tblEvaluacionDesempeñoOpciones] ([evadesopc_intId], [evadesopc_Texto], [evadesopc_fkIdevades]) VALUES (74, N'Fallo de metas', 9)
SET IDENTITY_INSERT [dbo].[tblEvaluacionDesempeñoOpciones] OFF
/****** Object:  StoredProcedure [dbo].[spEvaluacionDesempeño]    Script Date: 05/03/2018 6:59:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEvaluacionDesempeño](
	@strTipoAccion varchar(max)='',
    @evades_intId int=0,
    @evades_strPregunta varchar(max)='',
    @evades_strTipo varchar(50)='')
AS
BEGIN

	/*Consulta que devuelve datos para el DataGridView*/
	IF (@strTipoAccion='SeleccionarTodoGrid')
	BEGIN
		SELECT ED.evades_intId Id,
			ED.evades_strPregunta Pregunta,
			ED.evades_strTipo Tipo,
			(SELECT COUNT(*) FROM tblEvaluacionDesempeñoOpciones EDO WHERE EDO.evadesopc_fkIdevades=ED.evades_intId )  Opciones
		 FROM tblEvaluacionDesempeño ED
	END
	
	/*Devuelve un registro*/
	IF (@strTipoAccion='SeleccionaUno')
	BEGIN
		SELECT *
		FROM tblEvaluacionDesempeño
		WHERE evades_intId=@evades_intId
	END

	/*Guardar nuevos registros*/
	IF (@strTipoAccion='Guardar')
	BEGIN
		INSERT INTO tblEvaluacionDesempeño
		(evades_strPregunta, evades_strTipo)		 
		VALUES (@evades_strPregunta, @evades_strTipo)		 
	END

	/*Editar registros*/
	IF (@strTipoAccion='Editar')
	BEGIN
		UPDATE tblEvaluacionDesempeño SET
		evades_strPregunta=@evades_strPregunta, 
		evades_strTipo=@evades_strTipo
		WHERE evades_intId=@evades_intId
	END

	/*Retorna el ultimo Id*/
	IF (@strTipoAccion='MaxId')
	BEGIN
		SELECT MAX(evades_intId)
		 FROM tblEvaluacionDesempeño 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[spEvaluacionDesempeñoOpciones]    Script Date: 05/03/2018 6:59:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEvaluacionDesempeñoOpciones](
	@strTipoAccion varchar(max)='',
    @evadesopc_intId int=0,
    @evadesopc_strTexto varchar(max)='',
    @evadesopc_fkIdEvaDes int=0)
AS
BEGIN

	/*Consulta que devuelve datos para el DataGridView*/
	IF (@strTipoAccion='SeleccionarTodoGrid')
	BEGIN
		SELECT *
		 FROM tblEvaluacionDesempeñoOpciones
		 WHERE evadesopc_fkIdevades=@evadesopc_fkIdEvaDes
	END

	/*Devuelve un un registro segun su Id y IdPregunta*/
	IF (@strTipoAccion='SeleccionaUno')
	BEGIN
		SELECT *
		FROM tblEvaluacionDesempeñoOpciones
		WHERE evadesopc_fkIdevades=@evadesopc_fkIdEvaDes
		AND evadesopc_intId=@evadesopc_intId
	END
	/*Guardar nuevos registros*/
	IF (@strTipoAccion='Guardar')
	BEGIN
		INSERT INTO tblEvaluacionDesempeñoOpciones
		(evadesopc_Texto, evadesopc_fkIdEvaDes)		 
		VALUES (@evadesopc_strTexto, @evadesopc_fkIdEvaDes)		 
	END

	/*Eliminar registros por IdPregunta*/
	IF (@strTipoAccion='EliminarTodos')
	BEGIN
		DELETE FROM tblEvaluacionDesempeñoOpciones
		WHERE evadesopc_fkIdEvaDes=@evadesopc_fkIdEvaDes
	END

	/*Retorna el ultimo Id*/
	IF (@strTipoAccion='MaxId')
	BEGIN
		SELECT MAX(evadesopc_intId)
		 FROM tblEvaluacionDesempeñoOpciones 
	END
END
GO
