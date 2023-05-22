USE [DBb3]
GO
/****** Object:  Table [dbo].[Aportes]    Script Date: 22/05/2023 07:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aportes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AtivoId] [int] NOT NULL,
	[QtdCotas] [int] NOT NULL,
	[DtCompra] [date] NOT NULL,
	[VlUnitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Aportes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ativos]    Script Date: 22/05/2023 07:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ativos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ticker] [varchar](10) NOT NULL,
	[CNPJ] [varchar](20) NOT NULL,
	[Tipo] [int] NOT NULL,
	[QtdTotal] [int] NOT NULL,
	[TotalInvestido] [decimal](18, 2) NOT NULL,
	[PrecoMedio] [decimal](18, 2) NOT NULL,
	[TotalProventos] [decimal](18, 2) NOT NULL,
	[TotalResgatado] [decimal](18, 2) NOT NULL,
	[SaldoAtual] [decimal](18, 2) NOT NULL,
	[EhAtivo] [bit] NOT NULL,
 CONSTRAINT [PK_Ativos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proventos]    Script Date: 22/05/2023 07:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proventos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AtivoId] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[QtdCotas] [int] NOT NULL,
	[VlUnitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Proventos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 22/05/2023 07:25:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AtivoId] [int] NOT NULL,
	[QtdCotas] [int] NOT NULL,
	[DtVenda] [date] NOT NULL,
	[VlUnitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ativos] ADD  CONSTRAINT [DF_Ativos_TotalResgatado]  DEFAULT ((0)) FOR [TotalResgatado]
GO
ALTER TABLE [dbo].[Ativos] ADD  DEFAULT ((0)) FOR [SaldoAtual]
GO
ALTER TABLE [dbo].[Ativos] ADD  DEFAULT ((1)) FOR [EhAtivo]
GO
ALTER TABLE [dbo].[Aportes]  WITH CHECK ADD  CONSTRAINT [FK_Aportes_Ativos_AtivoId] FOREIGN KEY([AtivoId])
REFERENCES [dbo].[Ativos] ([Id])
GO
ALTER TABLE [dbo].[Aportes] CHECK CONSTRAINT [FK_Aportes_Ativos_AtivoId]
GO
ALTER TABLE [dbo].[Proventos]  WITH CHECK ADD  CONSTRAINT [FK_Proventos_Ativos] FOREIGN KEY([AtivoId])
REFERENCES [dbo].[Ativos] ([Id])
GO
ALTER TABLE [dbo].[Proventos] CHECK CONSTRAINT [FK_Proventos_Ativos]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Ativos] FOREIGN KEY([AtivoId])
REFERENCES [dbo].[Ativos] ([Id])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Ativos]
GO
