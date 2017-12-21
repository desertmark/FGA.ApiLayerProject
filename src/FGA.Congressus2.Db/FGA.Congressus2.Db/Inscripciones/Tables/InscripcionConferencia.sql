CREATE TABLE [Inscripciones].[InscripcionConferencia] (
    [InscripcionConferenciaId] INT      IDENTITY (1, 1) NOT NULL,
    [ConferenciaId]            INT      NOT NULL,
    [Fecha]                    DATETIME NOT NULL,
    CONSTRAINT [PK_dbo.InscripcionCharlas] PRIMARY KEY CLUSTERED ([InscripcionConferenciaId] ASC),
    CONSTRAINT [FK_InscripcionConferencia_Conferencia] FOREIGN KEY ([ConferenciaId]) REFERENCES [Eventos].[Conferencia] ([ConferenciaId])
);

