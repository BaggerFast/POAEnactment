﻿CREATE TABLE [dbo].[COMPANY]
(
	[UID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [NAME] NVARCHAR(30) NOT NULL, 
    [KPP] NVARCHAR(12) NOT NULL, 
    [INN] NVARCHAR(9) NOT NULL, 
    [CLIENT_BASE_ON] NVARCHAR(10) NOT NULL
)
