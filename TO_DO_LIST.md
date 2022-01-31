# To do list

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
