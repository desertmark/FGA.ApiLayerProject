CREATE TABLE [Eventos].[Eventos] (
    [EventoId]                      INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]                        NVARCHAR (MAX) NULL,
    [FechaFinTrabajos]              DATETIME       NOT NULL,
    [FechaFinInscripcion]           DATETIME       NOT NULL,
    [FechaFinInscripcionTemprana]   DATETIME       NOT NULL,
    [FechaInicio]                   DATETIME       NOT NULL,
    [FechaFin]                      DATETIME       NOT NULL,
    [Lugar]                         NVARCHAR (MAX) NULL,
    [Tema]                          NVARCHAR (MAX) NULL,
    [EmailContacto]                 NVARCHAR (MAX) NULL,
    [Direccion]                     NVARCHAR (MAX) NULL,
    [HabilitarDescargaCertificados] BIT            NOT NULL,
    [LogoId]                        INT            NULL,
    [TextoBienvenida]               NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Eventos] PRIMARY KEY CLUSTERED ([EventoId] ASC),
    CONSTRAINT [FK_Eventos_Archivos1] FOREIGN KEY ([LogoId]) REFERENCES [dbo].[Archivos] ([ArchivoId])
);

