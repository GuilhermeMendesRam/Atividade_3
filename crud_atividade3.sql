USE [crud_atividade3]
GO
CREATE USER [root] FOR LOGIN [root] WITH DEFAULT_SCHEMA=[dbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabricante](
	[idfabricante] [int] NULL,
	[descricao] [varchar](50) NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veiculo](
	[idveiculos] [int] NULL,
	[modelo] [varchar](50) NULL,
	[ano] [int] NULL,
	[preco] [real] NULL,
	[idfabricante] [int] NULL
) ON [PRIMARY]
GO
