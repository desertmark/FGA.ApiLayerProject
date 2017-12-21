CREATE TABLE [Eventos].[Conferencia] (
    [ConferenciaId] INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]        NVARCHAR (MAX) NULL,
    [Descripcion]   NVARCHAR (MAX) NULL,
    [Tipo]          NVARCHAR (MAX) NULL,
    [Cupo]          INT            NOT NULL,
    [FechaHora]     DATETIME       NULL,
    [Lugar]         NVARCHAR (MAX) NULL,
    [EventoId]      INT            NOT NULL,
    [PaperId]       INT            NULL,
    CONSTRAINT [PK_dbo.Charlas] PRIMARY KEY CLUSTERED ([ConferenciaId] ASC),
    CONSTRAINT [FK_dbo.Charlas_dbo.Eventos_Evento_Id] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId]),
    CONSTRAINT [FK_dbo.Charlas_dbo.Paper_paper_Id] FOREIGN KEY ([PaperId]) REFERENCES [Papers].[Paper] ([PaperId])
);


GO
CREATE NONCLUSTERED INDEX [IX_paper_Id]
    ON [Eventos].[Conferencia]([PaperId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Evento_Id]
    ON [Eventos].[Conferencia]([EventoId] ASC);

