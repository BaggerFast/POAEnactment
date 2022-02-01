------------------------------------------------------------------------------------------------------------------------
-- Table Fill
------------------------------------------------------------------------------------------------------------------------
DECLARE @INSERT_ADDRESS BIT = 0
DECLARE @INSERT_AUTHORITY BIT = 0
DECLARE @INSERT_COMPANY BIT = 0
DECLARE @INSERT_MANAGER BIT = 0
DECLARE @INSERT_PASSPORT BIT = 0
DECLARE @INSERT_PERSON BIT = 0

DECLARE @COMPANY_NAME NVARCHAR(255) = N'Владимирский стандарт'
DECLARE @COMPANY_UID UNIQUEIDENTIFIER = NULL

DECLARE @MANAGER_NAME NVARCHAR(255) = N'Дмитрий'
DECLARE @MANAGER_UID UNIQUEIDENTIFIER = NULL

------------------------------------------------------------------------------------------------------------------------
IF (@INSERT_COMPANY = 1) BEGIN
	PRINT N'[+] INSERT DATA IN TABLE COMPANY IS ENABLED'
	IF NOT EXISTS (SELECT 1 FROM [COMPANY] WHERE [NAME]=@COMPANY_NAME) BEGIN
		INSERT INTO [COMPANY] ([UID],[NAME],[KPP],[INN],[CLIENT_BASE_ON])
		VALUES (NEWID(),@COMPANY_NAME,'123456789','123456789','Устав')
	END
END ELSE BEGIN
	PRINT N'[ ] INSERT DATA IN TABLE COMPANY IS DISABLED'
END
SET @COMPANY_UID = (SELECT [UID] FROM COMPANY WHERE [NAME]=@COMPANY_NAME)
------------------------------------------------------------------------------------------------------------------------
IF (@COMPANY_UID IS NOT NULL) BEGIN
	IF (@INSERT_ADDRESS = 1) BEGIN
		PRINT N'[+] INSERT DATA IN TABLE ADDRESS IS ENABLED'
		INSERT INTO [ADDRESS] ([UID],[INDEX],[CODE_REGION],[DISTRICT], [CITY], [STREET], [BUILD], [HOUSING], [APARTMENT], [COMPANY_UID])
		VALUES (NEWID(), 600018, 33, 'Владимир','Владимир', 'Площадь Ленина', '22', 'Г', 129, @COMPANY_UID)
	END ELSE BEGIN
		PRINT N'[ ] INSERT DATA IN TABLE ADDRESS IS DISABLED'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (@INSERT_AUTHORITY = 1) BEGIN
		PRINT N'[+] INSERT DATA IN TABLE AUTHORITY IS ENABLED'
		INSERT INTO [AUTHORITY] ([UID],[START],[END],[NUMBER], [COMPANY_UID])
		VALUES (NEWID(), getdate(), getdate(),'123456789', @COMPANY_UID)
	END ELSE BEGIN
		PRINT N'[ ] INSERT DATA IN TABLE AUTHORITY IS DISABLED'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (@INSERT_PERSON = 1) BEGIN
		PRINT N'[+] INSERT DATA IN TABLE PERSON IS ENABLED'
		INSERT INTO [PERSON] ([UID],[FIRST_NAME],[LAST_NAME],[MIDDLE_NAME],[COMPANY_UID])
		VALUES (NEWID(),'Даниил','Александров','Дмитриевич',@COMPANY_UID)
	END ELSE BEGIN
		PRINT N'[ ] INSERT DATA IN TABLE PERSON IS DISABLED'
	END
END 
------------------------------------------------------------------------------------------------------------------------
IF (@INSERT_MANAGER = 1) BEGIN
	PRINT N'[+] INSERT DATA IN TABLE MANAGER IS ENABLED'
	IF NOT EXISTS (SELECT 1 FROM [MANAGER] WHERE [FIRST_NAME]=@MANAGER_NAME) BEGIN
		INSERT INTO [MANAGER] ([UID],[FIRST_NAME],[LAST_NAME],[MIDDLE_NAME],[PHONE])
		VALUES (NEWID(),@MANAGER_NAME,'Иванов','Игнатьев','89004930393')
	END
END ELSE BEGIN
	PRINT N'[ ] INSERT DATA IN TABLE MANAGER IS DISABLED'
END
SET @MANAGER_UID = (SELECT [UID] FROM COMPANY WHERE [NAME]=@MANAGER_NAME)
------------------------------------------------------------------------------------------------------------------------
IF (@INSERT_PASSPORT = 1 and @MANAGER_UID IS NOT NULL) BEGIN
	PRINT N'[+] INSERT DATA IN TABLE PASSPORT IS ENABLED'
	INSERT INTO [PASSPORT] ([UID], [SERIES], [NUMBER], [DATE_ISSUE], [PLACE_ISSUE], [MANAGER_UID])
	VALUES (NEWID(),'1717','548565', getdate(),'МФЦ Владимир', @MANAGER_UID)
END ELSE BEGIN
	PRINT N'[ ] INSERT DATA IN TABLE PASSPORT IS DISABLED'
END
------------------------------------------------------------------------------------------------------------------------