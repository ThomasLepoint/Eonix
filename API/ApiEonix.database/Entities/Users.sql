CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT newsequentialid() , 
    [Name] NVARCHAR(50) NULL, 
    [Lastname] NVARCHAR(50) NULL,
)
