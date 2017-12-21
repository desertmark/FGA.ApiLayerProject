CREATE TABLE [dbo].[Perfil] (
    [UserId]    NVARCHAR (128) NOT NULL,
    [PersonaId] INT            NOT NULL,
    CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Perfil_Persona] FOREIGN KEY ([PersonaId]) REFERENCES [dbo].[Persona] ([PersonaId]),
    CONSTRAINT [FK_Perfil_Users] FOREIGN KEY ([UserId]) REFERENCES [Identity].[Users] ([UserId])
);

