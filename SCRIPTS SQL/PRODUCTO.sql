USE [PruebaEcop]
GO

/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 26/5/2024 22:50:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRODUCTO](
	[PRODUCTO_ID] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO] [varchar](50) NULL,
	[DESCRIPCION] [varchar](200) NULL,
	[CANTIDAD] [float] NULL,
	[PRECIO1] [decimal](18, 0) NULL,
	[FECHA_INGRESO] [date] NULL,
	[UNIDAD_MEDIDA] [varchar](50) NULL,
 CONSTRAINT [PK_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[PRODUCTO_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


