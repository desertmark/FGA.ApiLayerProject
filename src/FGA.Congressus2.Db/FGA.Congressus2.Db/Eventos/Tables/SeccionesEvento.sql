CREATE TABLE [Eventos].[SeccionesEvento] (
    [SeccionEventoId] INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (MAX) NULL,
    [Titulo]          NVARCHAR (MAX) NULL,
    [Cuerpo]          NVARCHAR (MAX) NULL,
    [EventoId]        INT            NULL,
    CONSTRAINT [PK_dbo.SeccionesEvento] PRIMARY KEY CLUSTERED ([SeccionEventoId] ASC),
    CONSTRAINT [FK_dbo.SeccionesEvento_dbo.Eventos_Evento_Id] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Evento_Id]
    ON [Eventos].[SeccionesEvento]([EventoId] ASC);

