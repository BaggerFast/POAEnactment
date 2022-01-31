﻿CREATE TABLE [dbo].[ADDRESS]
(
	[UID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [INDEX] NVARCHAR(6) NOT NULL, 
    [CODE_REGION] NVARCHAR(3) NOT NULL, 
    [DISTRICT] NVARCHAR(30) NOT NULL, 
    [CITY] NVARCHAR(30) NULL, 
    [SETTLEMENT] NVARCHAR(30) NULL, 
    [STREET] NVARCHAR(30) NOT NULL, 
    [BUILD] NVARCHAR(5) NOT NULL, 
    [HOUSING] NVARCHAR(4) NULL, 
    [APARTMENT] NVARCHAR(3) NOT NULL, 
    [COMPANY_UID] UNIQUEIDENTIFIER NOT NULL
    CONSTRAINT [FK_Address_Company] FOREIGN KEY ([COMPANY_UID]) REFERENCES [COMPANY]([UID]) ON DELETE CASCADE,
    UNIQUE(COMPANY_UID)
)
