CREATE TABLE [dbo].[Archivos] (
    [ArchivoId]   INT             IDENTITY (1, 1) NOT NULL,
    [Titulo]      NVARCHAR (MAX)  NULL,
    [ContentType] NVARCHAR (MAX)  NULL,
    [Nombre]      NVARCHAR (MAX)  NULL,
    [Bytes]       VARBINARY (MAX) NULL,
    CONSTRAINT [PK_dbo.Archivos] PRIMARY KEY CLUSTERED ([ArchivoId] ASC)
);

