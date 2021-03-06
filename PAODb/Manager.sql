CREATE TABLE [dbo].[MANAGER]
(
	[UID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(),
    [FIO_UID] UNIQUEIDENTIFIER NOT NULL,
    [PHONE] NVARCHAR(11) NOT NULL,
    CONSTRAINT [FK_Manager_Person] FOREIGN KEY ([FIO_UID]) REFERENCES [PERSON]([UID]),
    UNIQUE([FIO_UID])
)
