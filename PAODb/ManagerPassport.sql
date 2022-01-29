﻿CREATE TABLE [dbo].[ManagerPassport]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SERIES] NCHAR(4) NOT NULL, 
    [NUMBER] NCHAR(6) NOT NULL, 
    [DATE_ISSUE] DATE NOT NULL, 
    [PLACE_ISSUE] NCHAR(100) NOT NULL, 
    [MANAGER_ID] INT NOT NULL, 
    CONSTRAINT [FK_ManagerPassport_Manager] FOREIGN KEY ([MANAGER_ID]) REFERENCES [Manager]([Id]) ON DELETE CASCADE,
    UNIQUE(MANAGER_ID)
)