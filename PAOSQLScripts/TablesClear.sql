------------------------------------------------------------------------------------------------------------------------
-- Table clear
------------------------------------------------------------------------------------------------------------------------
DECLARE @DELETE_FLAG BIT = 1 -- флаг для удаление тестовых данных в таблице - по умолчанию 0
DECLARE @COMPANY_UID UNIQUEIDENTIFIER = (SELECT [UID] FROM [COMPANY] WHERE [NAME] = N'Владимирскииииий стандартттт')
DECLARE @MANAGER_UID UNIQUEIDENTIFIER = (SELECT [UID] FROM [MANAGER] WHERE [FIRST_NAME] = N'Дмитриййййййй')
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_FLAG = 1) BEGIN
	PRINT N'[ ] START'
	IF (EXISTS (SELECT 1 FROM [PASSPORT] WHERE [MANAGER_UID] = @MANAGER_UID)) BEGIN 
		DELETE FROM [PASSPORT] WHERE [MANAGER_UID] = @MANAGER_UID
		--TRUNCATE TABLE [PASSPORT]
		PRINT N'[+] DELETE INTO PASSPORT SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (EXISTS (SELECT 1 FROM [MANAGER] WHERE [UID] = @MANAGER_UID)) BEGIN
		DELETE FROM [MANAGER] WHERE [UID] = @MANAGER_UID
		PRINT N'[+] DELETE INTO MANAGER SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (EXISTS (SELECT 1 FROM [PERSON] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		DELETE FROM [PERSON] WHERE [COMPANY_UID]=@COMPANY_UID
		PRINT N'[+] DELETE INTO PERSON SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (EXISTS (SELECT 1 FROM [AUTHORITY] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		DELETE FROM [AUTHORITY] WHERE [COMPANY_UID]=@COMPANY_UID
		PRINT N'[+] DELETE INTO AUTHORITY SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (EXISTS (SELECT 1 FROM [ADDRESS] WHERE [COMPANY_UID]=@COMPANY_UID)) BEGIN
		DELETE FROM [ADDRESS] WHERE [COMPANY_UID]=@COMPANY_UID
		PRINT N'[+] DELETE INTO ADDRESS SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF EXISTS (SELECT 1 FROM [COMPANY] WHERE [UID]=@COMPANY_UID) BEGIN
		DELETE FROM [COMPANY] WHERE [UID]=@COMPANY_UID
		PRINT N'[+] DELETE INTO COMPANY SUCCESS'
	END
	PRINT N'[ ] END'
------------------------------------------------------------------------------------------------------------------------
END ELSE BEGIN
	PRINT N'[ ] DELETE TEST DATA IN TABLES IS DISABLED'
END
	