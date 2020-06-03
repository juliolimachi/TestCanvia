USE [Test]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 2/06/2020 22:33:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[NroDocumento] [varchar](12) NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NULL,
	[Domicilio] [varchar](200) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([IdPersona], [NroDocumento], [Nombres], [Apellidos], [Domicilio]) VALUES (1, N'8900922', N'Julio', N'Limachi Hualli', N'Av colectora')
SET IDENTITY_INSERT [dbo].[Persona] OFF
/****** Object:  StoredProcedure [dbo].[GetPersonas]    Script Date: 2/06/2020 22:33:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPersonas]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Persona
END
GO
/****** Object:  StoredProcedure [dbo].[MasterinsertPersona]    Script Date: 2/06/2020 22:33:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MasterinsertPersona]      (  
                                          @NroDocumento    VARCHAR(12),  
                                          @Nombres     VARCHAR(100),  
                                          @Apellidos        VARCHAR(100),  
                                          @Domicilio          VARCHAR(200),  
                                          @StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
  SET IDENTITY_INSERT Persona OFF



      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO Persona  
                        (
                         NroDocumento,  
                         Nombres,  
                         Apellidos,  
                         Domicilio)  
            VALUES     ( 
                         @NroDocumento,  
                         @Nombres,  
                         @Apellidos,  
                         @Domicilio)  
        END  
 

  END  
GO
