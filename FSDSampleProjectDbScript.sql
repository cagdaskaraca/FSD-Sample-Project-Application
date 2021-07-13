USE [FSDSampleProjectdb]
GO

/****** Object:  Table [dbo].[FSDSampleProjectdb]    Script Date: 13.07.2021 13:18:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FSDSampleProjectdb](
	[Id] [int] NOT NULL,
	[UrunAciklama] [nvarchar](50) NULL,
	[TextKod] [nvarchar](10) NULL,
	[Sira] [int] NULL,
	[Agirlik] [int] NULL,
	[Ad] [nvarchar](15) NULL,
	[KisaAd] [nvarchar](10) NULL,
	[GrupKod] [int] NULL,
	[EkGrupKod] [int] NULL,
	[UreticiKod] [nvarchar](5) NULL,
	[Birim] [nvarchar](10) NULL,
	[KdvOran] [int] NULL,
	[UrunTip] [int] NULL,
	[Durum] [int] NULL,
	[UretimTarihi] [datetime] NULL,
	[SeriTakip] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

