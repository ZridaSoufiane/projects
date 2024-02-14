
USE [LaMangaCar]
GO

/****** Object:  Table [dbo].[assurance]    Script Date: 26/04/2021 23:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[assurance](
	[assurance] [int] NOT NULL,
	[voiture] [int] NOT NULL,
	[mantant] [money] NULL,
	[datePayement] [date] NULL,
	[etat] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[assurance] ASC,
	[voiture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 26/04/2021 23:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[CIN] [nvarchar](10) NOT NULL,
	[nom] [nvarchar](25) NULL,
	[prenom] [nvarchar](25) NULL,
	[permise] [nvarchar](50) NULL,
	[adresse] [nvarchar](250) NULL,
	[tel] [nvarchar](12) NULL,
	[dateNaissance] [date] NULL,
	[nationalite] [nvarchar](25) NULL,
	[passport] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dépenses]    Script Date: 26/04/2021 23:29:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dépenses](
	[numDep] [int] IDENTITY(1,1) NOT NULL,
	[banc] [nvarchar](25) NULL,
	[montant] [money] NULL,
	[dateCredit] [date] NULL,
	[datePayer] [date] NULL,
	[etat] [nvarchar](20) NULL,
	[MontantAPayer] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[numDep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facture]    Script Date: 26/04/2021 23:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[numF] [int] NOT NULL,
	[dateFacture] [date] NULL,
	[numC] [int] NULL,
	[DureeLoc] [int] NULL,
	[PrixHunitaireHT] [money] NULL,
	[prixTotalHT] [money] NULL,
	[TotalNet] [money] NULL,
	[TVA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[numF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[louerVoiture]    Script Date: 26/04/2021 23:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[louerVoiture](
	[numContrat] [int] IDENTITY(1,1) NOT NULL,
	[client] [nvarchar](10) NULL,
	[voiture] [int] NULL,
	[dateLivraison] [date] NULL,
	[dateReprise] [date] NULL,
	[MontantTotal] [money] NULL,
	[avance] [money] NULL,
	[DelivreLe] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[numContrat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 26/04/2021 23:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[numero] [int] NOT NULL,
	[nomuser] [nvarchar](100) NULL,
	[motDePasse] [nvarchar](100) NULL,
	[tele] [nvarchar](14) NULL,
	[question] [nvarchar](200) NULL,
	[repense] [nvarchar](200) NULL,
	[motDePasseSecours] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[voiture]    Script Date: 26/04/2021 23:29:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voiture](
	[numV] [int] IDENTITY(1,1) NOT NULL,
	[marque] [nvarchar](25) NULL,
	[visiteTechnique] [date] NULL,
	[vidange] [int] NULL,
	[TypeV] [nvarchar](50) NULL,
	[kilometrage] [int] NULL,
	[photo] [image] NULL,
	[region] [int] NULL,
	[lettre] [nvarchar](20) NULL,
	[numMatricule] [int] NULL,
	[nomV] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[numV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[assurance]  WITH CHECK ADD FOREIGN KEY([assurance])
REFERENCES [dbo].[Dépenses] ([numDep])
GO
ALTER TABLE [dbo].[assurance]  WITH CHECK ADD FOREIGN KEY([voiture])
REFERENCES [dbo].[voiture] ([numV])
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD FOREIGN KEY([numC])
REFERENCES [dbo].[louerVoiture] ([numContrat])
GO
ALTER TABLE [dbo].[louerVoiture]  WITH CHECK ADD FOREIGN KEY([client])
REFERENCES [dbo].[Client] ([CIN])
GO
ALTER TABLE [dbo].[louerVoiture]  WITH CHECK ADD FOREIGN KEY([voiture])
REFERENCES [dbo].[voiture] ([numV])
GO
