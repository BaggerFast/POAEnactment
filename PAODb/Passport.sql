﻿CREATE TABLE [dbo].[PASSPORT]
(
	[UID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [SERIES] NVARCHAR(4) NOT NULL, 
    [NUMBER] NVARCHAR(6) NOT NULL, 
    [DATE_ISSUE] DATE NOT NULL, 
    [PLACE_ISSUE] NVARCHAR(100) NOT NULL, 
    [MANAGER_UID] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Passport_Manager] FOREIGN KEY ([MANAGER_UID]) REFERENCES [Manager]([UID]),
    UNIQUE(MANAGER_UID)
)
