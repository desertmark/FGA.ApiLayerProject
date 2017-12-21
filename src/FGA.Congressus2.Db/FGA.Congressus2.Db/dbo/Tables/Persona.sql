CREATE TABLE [dbo].[Persona] (
    [PersonaId]      INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]         VARCHAR (150) NOT NULL,
    [Apellido]       VARCHAR (150) NOT NULL,
    [DNI]            INT           NOT NULL,
    [Email]          VARCHAR (150) NOT NULL,
    [Telefono]       VARCHAR (150) NULL,
    [Direccion]      VARCHAR (150) NULL,
    [NacionalidadId] INT           NULL,
    CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED ([PersonaId] ASC),
    CONSTRAINT [FK_Persona_Paises] FOREIGN KEY ([NacionalidadId]) REFERENCES [dbo].[Paises] ([PaisId])
);

