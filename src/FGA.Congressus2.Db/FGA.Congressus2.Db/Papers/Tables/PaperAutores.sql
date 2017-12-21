CREATE TABLE [Papers].[PaperAutores] (
    [PaperId]  INT            NOT NULL,
    [PerfilId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_PaperAutores] PRIMARY KEY CLUSTERED ([PaperId] ASC, [PerfilId] ASC),
    CONSTRAINT [FK_PaperAutores_Paper] FOREIGN KEY ([PaperId]) REFERENCES [Papers].[Paper] ([PaperId]),
    CONSTRAINT [FK_PaperAutores_Perfil] FOREIGN KEY ([PerfilId]) REFERENCES [dbo].[Perfil] ([UserId])
);

