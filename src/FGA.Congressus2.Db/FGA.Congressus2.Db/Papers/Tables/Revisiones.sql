CREATE TABLE [Papers].[Revisiones] (
    [RevisionId] INT            IDENTITY (1, 1) NOT NULL,
    [Estado]     NVARCHAR (MAX) NULL,
    [Comentario] NVARCHAR (MAX) NULL,
    [ArchivoId]  INT            NULL,
    [PaperId]    INT            NULL,
    CONSTRAINT [PK_dbo.Revisiones] PRIMARY KEY CLUSTERED ([RevisionId] ASC),
    CONSTRAINT [FK_dbo.Revisiones_dbo.Paper_Paper_Id] FOREIGN KEY ([PaperId]) REFERENCES [Papers].[Paper] ([PaperId]),
    CONSTRAINT [FK_Revisiones_Archivos] FOREIGN KEY ([ArchivoId]) REFERENCES [dbo].[Archivos] ([ArchivoId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Paper_Id]
    ON [Papers].[Revisiones]([PaperId] ASC);

