USE [PONTOSIMPLES]
GO
/****** Object:  Table [dbo].[funcionarios]    Script Date: 27/03/2019 19:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionarios](
	[id_func] [int] IDENTITY(1,1) NOT NULL,
	[matr_func] [int] NULL,
	[nome_func] [nvarchar](max) NULL,
	[id_setor] [int] NOT NULL,
	[pis_func] [int] NULL,
	[id_horario] [int] NOT NULL,
 CONSTRAINT [PK_funcionario] PRIMARY KEY CLUSTERED 
(
	[id_func] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horarios]    Script Date: 27/03/2019 19:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horarios](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[cod_horario] [nchar](50) NOT NULL,
	[desc_horario] [nvarchar](max) NOT NULL,
	[hora_inicio] [datetime] NOT NULL,
	[inicio_almoco] [datetime] NULL,
	[fim_almoco] [datetime] NULL,
	[hora_fim] [datetime] NOT NULL,
 CONSTRAINT [PK_horarios] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ponto]    Script Date: 27/03/2019 19:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ponto](
	[idPonto] [int] IDENTITY(1,1) NOT NULL,
	[id_func] [int] NOT NULL,
	[marc_ponto] [datetime] NOT NULL,
 CONSTRAINT [PK_ponto] PRIMARY KEY CLUSTERED 
(
	[idPonto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[setores]    Script Date: 27/03/2019 19:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[setores](
	[id_setor] [int] IDENTITY(1,1) NOT NULL,
	[cod_setor] [nchar](50) NULL,
	[nome_setor] [nvarchar](50) NULL,
 CONSTRAINT [PK_Setores] PRIMARY KEY CLUSTERED 
(
	[id_setor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[funcionarios]  WITH CHECK ADD  CONSTRAINT [FK_funcionario_setor] FOREIGN KEY([id_setor])
REFERENCES [dbo].[setores] ([id_setor])
GO
ALTER TABLE [dbo].[funcionarios] CHECK CONSTRAINT [FK_funcionario_setor]
GO
ALTER TABLE [dbo].[funcionarios]  WITH CHECK ADD  CONSTRAINT [FK_funcionarios_horarios] FOREIGN KEY([id_horario])
REFERENCES [dbo].[horarios] ([id_horario])
GO
ALTER TABLE [dbo].[funcionarios] CHECK CONSTRAINT [FK_funcionarios_horarios]
GO
ALTER TABLE [dbo].[horarios]  WITH CHECK ADD  CONSTRAINT [FK_horarios_horarios] FOREIGN KEY([id_horario])
REFERENCES [dbo].[horarios] ([id_horario])
GO
ALTER TABLE [dbo].[horarios] CHECK CONSTRAINT [FK_horarios_horarios]
GO
ALTER TABLE [dbo].[ponto]  WITH CHECK ADD  CONSTRAINT [FK_ponto_funcionarios] FOREIGN KEY([id_func])
REFERENCES [dbo].[funcionarios] ([id_func])
GO
ALTER TABLE [dbo].[ponto] CHECK CONSTRAINT [FK_ponto_funcionarios]
GO
