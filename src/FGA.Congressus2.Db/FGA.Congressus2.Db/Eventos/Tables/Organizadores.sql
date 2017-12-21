CREATE TABLE [Eventos].[Organizadores] (
    [EventoId] INT            NOT NULL,
    [PerfilId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_Organizadores] PRIMARY KEY CLUSTERED ([EventoId] ASC, [PerfilId] ASC),
    CONSTRAINT [FK_Organizadores_Eventos] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId]),
    CONSTRAINT [FK_Organizadores_Perfil] FOREIGN KEY ([PerfilId]) REFERENCES [dbo].[Perfil] ([UserId])
);

