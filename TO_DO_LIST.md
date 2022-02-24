# To do list

## 2022-02-24
### Do it
- SHARP-T-18. PAOCoreTests. Add tests for TableModels. �������� ����� ��� ���� ������.

## 2022-02-09
### Do it
- SHARP-T-9. ORM Framework NHibernate & mapping FluentNHibernate
- CoreTests ��������� � PAOCoreTests.
- PAOCore. ��������� �� ������ ������ ������� ������ � ���������.
- PAOCore. ������� �������� AppSettingsHelper � Models.
  - �������� ���� ���� JsonSettingsEntity.
  - �������� ����� �������� ���������� JsonSettingsEntity. public void SetupJsonSettings(JsonSettingsEntity jsonAppSettings)
- PAOCoreTests. ������� ����� �� �������� � ��������� JsonSettingsEntity.
- PAOCore. ������� ����� DataAccessEntity � Models.
- ������� Database configuration
  https://github.com/nhibernate/fluent-nhibernate/wiki/Database-configuration
### Fix it
- SHARP-T-10. PAOWinForms exception XmlSerializer

## 2022-02-03
### Fix it
- PAOCore. ������ ���������. ��������� � PAOCore.Models.Tables.
- PAOCore. ������ ���������. ������� � ����� ���� Nullable(), ��� ��� ���������.
- PAOCore. �������� NuGet-����� Microsoft.Extensions.Configuration.
- PAOCore. ������� �� ��� ����� JsonSettingsEntity.
- PAOCore. �������� �������� �������� �� ����� appsettings.json.
- PAOCoreTests. �������� NuGet-����� Microsoft.Extensions.Configuration.
- PAOCoreTests. �������� ���� ������ JsonSettingsEntity. ��������� �������� ������ �� �����.
- PAOScripts. TableFill. @INSERT_FLAG ��-��������� ������ ���� ����� 0.
- PAOScripts. TableFill. ��������� ������ ���������� �������.
- PAOScripts. TablesClear. @DELETE_FLAG ��-��������� ������ ���� ����� 0.
- PAOScripts. TablesClear. ��������� ������ ���������� �������.
- CHANGELOG. ��������.

## 2022-02-02
### Fix it
- PAOSQLScripts. TableFill.sql: �������� ������ ����� �� ���� ����.
- PAOSQLScripts. TableFill.sql: �������� ���������� ��� ������.
  - �������� �������� �� �������������.
  Violation of UNIQUE KEY constraint 'UQ__ADDRESS__E36535483BCEA221'.
  Violation of UNIQUE KEY constraint 'UQ__AUTHORIT__E365354862296C04'.
  Violation of UNIQUE KEY constraint 'UQ__PERSON__E36535485061ADBE'.
- PAOSQLScripts. TablesClear.sql: �������� ������ ����� �� ���� ����.
- PAOSQLScripts. TablesClear.sql: �������� ���������� ��� ������. 
  - �������� �������� �� �������������.
  - �������� ������� �������� ������..
  Cannot truncate table 'MANAGER' because it is being referenced by a FOREIGN KEY constraint.
- PAODb. ������� [dbo].[PERSON]: ���� [COMPANY_UID] ������� ��������������.
- PAODb. ������� [dbo].[PERSON] � [dbo].[MANAGER]: �������� � ������������ ����� � ���� ����� [FIRST_NAME], [LAST_NAME], [MIDDLE_NAME].
- JetBrains space. ��������� ����������� � ��������� ������������ �����.

## 2022-02-01
### Fix it
- PAODb. �������� ��� NCHAR �� NVARCHAR.
- PAODb. ��������� �������� �������. ����� ������������� ������ ������.
- PAODb. ���� UID. �������� �������� �� ���������.
  [UID] uniqueidentifier not null primary key default newid(),
- PAOCore. ������������ � ��������������� �������� �������.
  ��������: CompanyEntity � PersonEntity
	- ���� CompanyEntity �������� PersonEntity
	- ���� PersonEntity �������� CompanyEntity
  ��������� ������ ������ ������ ��������� ��������� ��.
- PAOSQLScripts. �������� �������:
  - Tables fill.sql
  - Tables clear.sql

## 2022-01-31
### Fix it
- �� �������������� ���� CHANGELOG.md.
- ������ ����� BaseEntity �������� ID ���� GUID, � �� �����, ��� ������� ��������� ID ���� int? 
  ������� �������� � ������� ����: C# int + SQL int ���� C# GUID + SQL uniqueidentifier.
  ��� ���� int ���� ������� ID.
  ��� ���� GUID ���� ������� UID.
- PAODb. ������� AddressOfCompany ������������� � ADDRESS.
- PAODb. ������� DirectorOfCompany ������������� � PERSON.
- PAODb. ������� Manager ���������� � PERSON.
- PAODb. ������� ManagerPassport ������������� � PASSPORT.
- PAOCore. ������ AddressOfCompany ������������� � AddressEntity.
- PAOCore. ������ Authority ������������� � AuthorityEntity.
- PAOCore. ������ Company ������������� � CompanyEntity.
- PAOCore. ������ DirectorOfCompany ������������� � PersonEntity.
- PAOCore. ������ Manager ���������� � PersonEntity.
- PAOCore. ������ ManagerPassport ������������� � PassportEntity.
### Think about it
- PAODb. ����� ������ �������� � UPPER_CASE.
- PAODb. ����� ������� ID �������� � UPPER_CASE.
