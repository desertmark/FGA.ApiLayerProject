CREATE TABLE [Identity].[Roles] (
    [RoleId]        NVARCHAR (128) NOT NULL,
    [Name]          NVARCHAR (256) NOT NULL,
    [Description]   VARCHAR (150)  NULL,
    [Discriminator] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex]
    ON [Identity].[Roles]([Name] ASC);

