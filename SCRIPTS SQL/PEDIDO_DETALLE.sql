USE [PruebaEcop]
GO

/****** Object:  Table [dbo].[PEDIDO_DETALLE]    Script Date: 26/5/2024 22:50:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PEDIDO_DETALLE](
	[DETALLE_ID] [int] IDENTITY(1,1) NOT NULL,
	[PEDIDO_ID] [int] NULL,
	[PRODUCTO_ID] [int] NULL,
	[PRECIO] [decimal](18, 0) NULL,
	[CANTIDAD] [float] NULL,
	[PRODUCTO_DESCRIPCION] [varchar](200) NULL,
 CONSTRAINT [PK_PEDIDO_DETALLE] PRIMARY KEY CLUSTERED 
(
	[DETALLE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


