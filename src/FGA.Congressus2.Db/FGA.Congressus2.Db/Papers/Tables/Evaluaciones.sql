CREATE TABLE [Papers].[Evaluaciones] (
    [EvaluacionId] INT            NOT NULL,
    [Calificacion] INT            NOT NULL,
    [PerfilId]     NVARCHAR (128) NOT NULL,
    [PaperId]      INT            NOT NULL,
    [Comentario]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Evaluaciones] PRIMARY KEY CLUSTERED ([EvaluacionId] ASC),
    CONSTRAINT [FK_Evaluaciones_Paper] FOREIGN KEY ([PaperId]) REFERENCES [Papers].[Paper] ([PaperId]),
    CONSTRAINT [FK_Evaluaciones_Perfil] FOREIGN KEY ([PerfilId]) REFERENCES [dbo].[Perfil] ([UserId])
);


GO
CREATE NONCLUSTERED INDEX [IX_Id]
    ON [Papers].[Evaluaciones]([EvaluacionId] ASC);

