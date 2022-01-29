﻿CREATE TABLE [dbo].[DirectorOfCompany]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FIRST_NAME] NCHAR(30) NOT NULL, 
    [LAST_NAME] NCHAR(30) NOT NULL, 
    [MIDDLE_NAME] NCHAR(30) NULL, 
    [COMPANY_ID] INT NOT NULL,
    CONSTRAINT [FK_DirectorOfCompany_Company] FOREIGN KEY ([COMPANY_ID]) REFERENCES [COMPANY]([ID]),
    UNIQUE(COMPANY_ID)
)
