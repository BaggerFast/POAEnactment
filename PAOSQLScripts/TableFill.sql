------------------------------------------------------------------------------------------------------------------------
-- Table Fill
------------------------------------------------------------------------------------------------------------------------
DECLARE @INSERT_FLAG BIT = 1 -- флаг для создания тестовых данных в таблице - по умолчанию 0

DECLARE @COMPANY_NAME NVARCHAR(255) = N'Владимирскииииий стандартттт'
DECLARE @COMPANY_UID UNIQUEIDENTIFIER = NULL

DECLARE @MANAGER_NAME NVARCHAR(255) = N'Дмитриййййййй'
DECLARE @MANAGER_UID UNIQUEIDENTIFIER = NULL

------------------------------------------------------------------------------------------------------------------------
IF (@INSERT_FLAG = 1) BEGIN
	PRINT N'[ ] START'
	IF NOT EXISTS (SELECT 1 FROM [COMPANY] WHERE [NAME]=@COMPANY_NAME) BEGIN
		INSERT INTO [COMPANY] ([UID],[NAME],[KPP],[INN],[CLIENT_BASE_ON])
		VALUES (NEWID(),@COMPANY_NAME,'123456789','123456789','Устав')
		PRINT N'[+] INSERT INTO COMPANY SUCCESS'
	END

	SET @COMPANY_UID = (SELECT [UID] FROM [COMPANY] WHERE [NAME]=@COMPANY_NAME)

------------------------------------------------------------------------------------------------------------------------
	IF (NOT EXISTS (SELECT 1 FROM [ADDRESS] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		INSERT INTO [ADDRESS] ([UID],[INDEX],[CODE_REGION],[DISTRICT], [CITY], [STREET], [BUILD], [HOUSING], [APARTMENT], [COMPANY_UID])
		VALUES (NEWID(), 600018, 33, 'Владимир','Владимир', 'Площадь Ленина', '22', 'Г', 129, @COMPANY_UID)
		PRINT N'[+] INSERT INTO ADDRESS SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (NOT EXISTS (SELECT 1 FROM [AUTHORITY] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		INSERT INTO [AUTHORITY] ([UID],[START],[END],[NUMBER], [COMPANY_UID])
		VALUES (NEWID(), getdate(), getdate(),'123456789', @COMPANY_UID)
		PRINT N'[+] INSERT INTO AUTHORITY SUCCESS'
	END 
------------------------------------------------------------------------------------------------------------------------
	IF (NOT EXISTS (SELECT 1 FROM [PERSON] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		INSERT INTO [PERSON] ([UID],[FIRST_NAME],[LAST_NAME],[MIDDLE_NAME],[COMPANY_UID])
		VALUES (NEWID(),'Даниил','Александров','Дмитриевич',@COMPANY_UID)
		PRINT N'[+] INSERT INTO PERSON SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF NOT EXISTS (SELECT 1 FROM [MANAGER] WHERE [FIRST_NAME]=@MANAGER_NAME) BEGIN
		INSERT INTO [MANAGER] ([UID],[FIRST_NAME],[LAST_NAME],[MIDDLE_NAME], [PHONE])
		VALUES (NEWID(),@MANAGER_NAME,'Иванов','Игнатьев','89004930393')
		PRINT N'[+] INSERT INTO MANAGER SUCCESS'
	END
	
	SET @MANAGER_UID = (SELECT [UID] FROM MANAGER WHERE [FIRST_NAME]=@MANAGER_NAME)
------------------------------------------------------------------------------------------------------------------------
	IF (NOT EXISTS (SELECT 1 FROM [PASSPORT] WHERE [MANAGER_UID]=@MANAGER_UID)) BEGIN
		INSERT INTO [PASSPORT] ([UID], [SERIES], [NUMBER], [DATE_ISSUE], [PLACE_ISSUE], [MANAGER_UID])
		VALUES (NEWID(),'1717','548565', getdate(),'МФЦ Владимир', @MANAGER_UID)
		PRINT N'[+] INSERT INTO PASSPORT SUCCESS'
		END
	PRINT N'[ ] END'
------------------------------------------------------------------------------------------------------------------------
END ELSE BEGIN
	PRINT N'[ ] INSERT TEST DATA IN TABLES IS DISABLED'
END