CREATE TABLE [Papers].[Paper] (
    [PaperId]          INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]           NVARCHAR (MAX) NULL,
    [Fecha]            DATETIME       NOT NULL,
    [Descripcion]      NVARCHAR (MAX) NULL,
    [Estado]           NVARCHAR (MAX) NULL,
    [AreaCientificaId] INT            NULL,
    [EvaluadorId]      INT            NULL,
    [EventoId]         INT            NULL,
    [ArchivoId]        INT            NULL,
    CONSTRAINT [PK_dbo.Paper] PRIMARY KEY CLUSTERED ([PaperId] ASC),
    CONSTRAINT [FK_dbo.Paper_dbo.Archivos_Documento_Id] FOREIGN KEY ([ArchivoId]) REFERENCES [dbo].[Archivos] ([ArchivoId]),
    CONSTRAINT [FK_dbo.Paper_dbo.AreasCientificas_AreaCientifica_Id] FOREIGN KEY ([AreaCientificaId]) REFERENCES [Eventos].[AreasCientificas] ([AreaCientificaId]),
    CONSTRAINT [FK_dbo.Paper_dbo.Eventos_Evento_Id] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Evento_Id]
    ON [Papers].[Paper]([EventoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Evaluador_Id]
    ON [Papers].[Paper]([EvaluadorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Documento_Id]
    ON [Papers].[Paper]([ArchivoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AreaCientifica_Id]
    ON [Papers].[Paper]([AreaCientificaId] ASC);

