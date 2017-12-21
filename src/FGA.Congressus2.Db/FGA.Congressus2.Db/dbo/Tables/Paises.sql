CREATE TABLE [dbo].[Paises] (
    [PaisId]       INT            IDENTITY (1, 1) NOT NULL,
    [Nacionalidad] NVARCHAR (MAX) NULL,
    [Pais]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Paises] PRIMARY KEY CLUSTERED ([PaisId] ASC)
);

