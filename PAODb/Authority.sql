﻿CREATE TABLE [dbo].[AUTHORITY]
(
	[UID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [START] DATE NOT NULL, 
    [END] DATE NOT NULL, 
    [NUMBER] NVARCHAR(30) NOT NULL, 
    [COMPANY_UID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [FK_Authority_Company] FOREIGN KEY ([COMPANY_UID]) REFERENCES [COMPANY]([UID]),
    UNIQUE(COMPANY_UID)
)
