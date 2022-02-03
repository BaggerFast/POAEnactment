------------------------------------------------------------------------------------------------------------------------
-- Table clear
------------------------------------------------------------------------------------------------------------------------
DECLARE @DELETE_FLAG BIT = 1 -- флаг для удаление тестовых данных в таблице - по умолчанию 0
DECLARE @COMPANY_UID UNIQUEIDENTIFIER = (SELECT [UID] FROM [COMPANY] WHERE [NAME] = N'Владимирскииииий стандартттт')
DECLARE @MANAGER_UID UNIQUEIDENTIFIER = (SELECT [UID] FROM [MANAGER] WHERE [PHONE] = N'89004930393')
DECLARE @TEMP_UID UNIQUEIDENTIFIER = NULL
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_FLAG = 1) BEGIN
	PRINT N'[ ] START'
	IF (EXISTS (SELECT 1 FROM [PASSPORT] WHERE [MANAGER_UID] = @MANAGER_UID)) BEGIN 
		DELETE FROM [PASSPORT] WHERE [MANAGER_UID] = @MANAGER_UID
		PRINT N'[+] DELETE INTO PASSPORT SUCCESS'
	END
------------------------------------------------------------------------------------------------------------------------
	IF (EXISTS (SELECT 1 FROM [MANAGER] WHERE [UID] = @MANAGER_UID)) BEGIN
		SET @TEMP_UID = (SELECT [FIO_UID] from [MANAGER] WHERE [UID] = @MANAGER_UID)
		DELETE FROM [MANAGER] WHERE [UID] = @MANAGER_UID
		PRINT N'[+] DELETE INTO MANAGER SUCCESS'

		DELETE FROM [PERSON] WHERE [UID] = @TEMP_UID
		PRINT N'[+] DELETE INTO PERSON № 1 SUCCESS'
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
		SET @TEMP_UID = (SELECT [DIRECTOR_UID] from [COMPANY] WHERE [UID] = @COMPANY_UID)
		DELETE FROM [COMPANY] WHERE [UID]=@COMPANY_UID
		PRINT N'[+] DELETE INTO COMPANY SUCCESS'

		DELETE FROM [PERSON] WHERE [UID] = @TEMP_UID
		PRINT N'[+] DELETE INTO PERSON № 2 SUCCESS'
	END
	PRINT N'[ ] END'
------------------------------------------------------------------------------------------------------------------------
END ELSE BEGIN
	PRINT N'[ ] DELETE TEST DATA IN TABLES IS DISABLED'
END
	