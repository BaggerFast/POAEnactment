------------------------------------------------------------------------------------------------------------------------
-- Table clear
------------------------------------------------------------------------------------------------------------------------
DECLARE @DELETE_PERSON BIT = 0
DECLARE @DELETE_MANAGER BIT = 0
DECLARE @DELETE_PASSPORT BIT = 0
DECLARE @DELETE_COMPANY BIT = 0
DECLARE @DELETE_AUTHORITY BIT = 0
DECLARE @DELETE_ADDRESS BIT = 0
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_PASSPORT = 1) 
BEGIN
	DELETE FROM [PASSPORT]
	TRUNCATE TABLE [PASSPORT]
END
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_MANAGER = 1) 
BEGIN
	DELETE FROM [MANAGER]
	TRUNCATE TABLE [MANAGER]
END
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_PERSON = 1) 
BEGIN
	DELETE FROM [PERSON]
	TRUNCATE TABLE [PERSON]
END
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_AUTHORITY = 1) 
BEGIN
	DELETE FROM [AUTHORITY]
	TRUNCATE TABLE [AUTHORITY]
END
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_ADDRESS = 1) 
BEGIN
	DELETE FROM [ADDRESS]
	TRUNCATE TABLE [ADDRESS]
END
------------------------------------------------------------------------------------------------------------------------
IF (@DELETE_COMPANY = 1) 
BEGIN
	DELETE FROM [COMPANY]
	TRUNCATE TABLE [COMPANY]
END
------------------------------------------------------------------------------------------------------------------------