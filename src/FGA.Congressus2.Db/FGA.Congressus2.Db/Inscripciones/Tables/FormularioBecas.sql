CREATE TABLE [Inscripciones].[FormularioBecas] (
    [FormularioBecaId]     INT            IDENTITY (1, 1) NOT NULL,
    [EventoId]             INT            NOT NULL,
    [NombreCompleto]       NVARCHAR (MAX) NOT NULL,
    [Domicilio]            NVARCHAR (MAX) NOT NULL,
    [CodigoPostal]         INT            NOT NULL,
    [Localidad]            NVARCHAR (MAX) NOT NULL,
    [Provincia]            NVARCHAR (MAX) NOT NULL,
    [Pais]                 NVARCHAR (MAX) NOT NULL,
    [Telefono]             NVARCHAR (MAX) NOT NULL,
    [Email]                NVARCHAR (MAX) NOT NULL,
    [PresentaTrabajo]      BIT            NOT NULL,
    [AreaCientificaId]     INT            NULL,
    [CategoriaId]          INT            NOT NULL,
    [Universidad]          NVARCHAR (MAX) NULL,
    [Carrera]              NVARCHAR (MAX) NULL,
    [PorcentajeCarrera]    INT            NOT NULL,
    [PromedioParcial]      FLOAT (53)     NOT NULL,
    [TituloGrado]          NVARCHAR (MAX) NULL,
    [AñoGrado]             INT            NOT NULL,
    [TituloPosgrado]       NVARCHAR (MAX) NULL,
    [AñoPosgrado]          INT            NOT NULL,
    [PorcentajePosgrado]   INT            NOT NULL,
    [DirectorPosgrado]     NVARCHAR (MAX) NULL,
    [LugarTrabajoPosgrado] NVARCHAR (MAX) NULL,
    [PosicionActual]       NVARCHAR (MAX) NULL,
    [Puesto]               NVARCHAR (MAX) NULL,
    [AsistenteId]          INT            NOT NULL,
    CONSTRAINT [PK_dbo.FormularioBecas] PRIMARY KEY CLUSTERED ([FormularioBecaId] ASC),
    CONSTRAINT [FK_dbo.FormularioBecas_dbo.AreasCientificas_AreaCientificaId] FOREIGN KEY ([AreaCientificaId]) REFERENCES [Eventos].[AreasCientificas] ([AreaCientificaId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.FormularioBecas_dbo.Eventos_EventoId] FOREIGN KEY ([EventoId]) REFERENCES [Eventos].[Eventos] ([EventoId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_EventoId]
    ON [Inscripciones].[FormularioBecas]([EventoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AreaCientificaId]
    ON [Inscripciones].[FormularioBecas]([AreaCientificaId] ASC);

