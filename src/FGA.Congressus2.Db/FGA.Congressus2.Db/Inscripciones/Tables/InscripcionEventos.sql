CREATE TABLE [Inscripciones].[InscripcionEventos] (
    [InscripcionEventoId] INT            IDENTITY (1, 1) NOT NULL,
    [FechaInscripcion]    DATETIME       NOT NULL,
    [FechaPago]           DATETIME       NULL,
    [Pago]                BIT            NOT NULL,
    [MontoPago]           FLOAT (53)     NULL,
    [EventoId]            INT            NULL,
    [PerfilId]            NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.InscripcionEventos] PRIMARY KEY CLUSTERED ([InscripcionEventoId] ASC),
    CONSTRAINT [FK_dbo.InscripcionEventos_dbo.Eventos_Evento_Id] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId]),
    CONSTRAINT [FK_InscripcionEventos_Perfil] FOREIGN KEY ([PerfilId]) REFERENCES [dbo].[Perfil] ([UserId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Evento_Id]
    ON [Inscripciones].[InscripcionEventos]([EventoId] ASC);

