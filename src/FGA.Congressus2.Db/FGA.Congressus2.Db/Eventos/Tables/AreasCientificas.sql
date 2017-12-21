CREATE TABLE [Eventos].[AreasCientificas] (
    [AreaCientificaId] INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion]      NVARCHAR (MAX) NULL,
    [OrganizadorId]    NVARCHAR (128) NULL,
    [EventoId]         INT            NULL,
    CONSTRAINT [PK_dbo.AreasCientificas] PRIMARY KEY CLUSTERED ([AreaCientificaId] ASC),
    CONSTRAINT [FK_AreasCientificas_Perfil] FOREIGN KEY ([OrganizadorId]) REFERENCES [dbo].[Perfil] ([UserId]),
    CONSTRAINT [FK_dbo.AreasCientificas_dbo.Eventos_Evento_Id] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Evento_Id]
    ON [Eventos].[AreasCientificas]([EventoId] ASC);

