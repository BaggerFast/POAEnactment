# To do list

## 2022-02-24
### Do it
- SHARP-T-18. PAOCoreTests. Add tests for TableModels. Добавить тесты для всех таблиц.

## 2022-02-09
### Do it
- SHARP-T-9. ORM Framework NHibernate & mapping FluentNHibernate
- CoreTests перенести в PAOCoreTests.
- PAOCore. Разделить по файлам классы моделей данных и маппингов.
- PAOCore. Создать синглтон AppSettingsHelper в Models.
  - Добавить поле типа JsonSettingsEntity.
  - Добавить метод загрузки экземпляра JsonSettingsEntity. public void SetupJsonSettings(JsonSettingsEntity jsonAppSettings)
- PAOCoreTests. Создать тесты на загрузку и обработку JsonSettingsEntity.
- PAOCore. Создать класс DataAccessEntity в Models.
- Изучить Database configuration
  https://github.com/nhibernate/fluent-nhibernate/wiki/Database-configuration
### Fix it
- SHARP-T-10. PAOWinForms exception XmlSerializer

## 2022-02-03
### Fix it
- PAOCore. Классы маппингов. Перенести в PAOCore.Models.Tables.
- PAOCore. Классы маппингов. Указать в явном виде Nullable(), там где требуется.
- PAOCore. Добавить NuGet-пакет Microsoft.Extensions.Configuration.
- PAOCore. Довести до ума класс JsonSettingsEntity.
- PAOCore. Добавить загрузку настроек из файла appsettings.json.
- PAOCoreTests. Добавить NuGet-пакет Microsoft.Extensions.Configuration.
- PAOCoreTests. Добавить тест класса JsonSettingsEntity. Проверить загрузку данных из файла.
- PAOScripts. TableFill. @INSERT_FLAG по-умолчанию должен быть равен 0.
- PAOScripts. TableFill. Устранить ошибку выполнения скрипта.
- PAOScripts. TablesClear. @DELETE_FLAG по-умолчанию должен быть равен 0.
- PAOScripts. TablesClear. Устранить ошибку выполнения скрипта.
- CHANGELOG. Обновить.

## 2022-02-02
### Fix it
- PAOSQLScripts. TableFill.sql: заменить булевы флаги на один флаг.
- PAOSQLScripts. TableFill.sql: добиться выполнения без ошибок.
  - Добавить проверки на существование.
  Violation of UNIQUE KEY constraint 'UQ__ADDRESS__E36535483BCEA221'.
  Violation of UNIQUE KEY constraint 'UQ__AUTHORIT__E365354862296C04'.
  Violation of UNIQUE KEY constraint 'UQ__PERSON__E36535485061ADBE'.
- PAOSQLScripts. TablesClear.sql: заменить булевы флаги на один флаг.
- PAOSQLScripts. TablesClear.sql: добиться выполнения без ошибок. 
  - Добавить проверки на существование.
  - Поменять порядок удаления данных..
  Cannot truncate table 'MANAGER' because it is being referenced by a FOREIGN KEY constraint.
- PAODb. Таблица [dbo].[PERSON]: Поле [COMPANY_UID] сделать необязательным.
- PAODb. Таблицы [dbo].[PERSON] и [dbo].[MANAGER]: Привести в соответствие длины и типы полей [FIRST_NAME], [LAST_NAME], [MIDDLE_NAME].
- JetBrains space. Заполнить комментарии и прогрессс поставленных задач.

## 2022-02-01
### Fix it
- PAODb. Заменить тип NCHAR на NVARCHAR.
- PAODb. Каскадное удаление удалить. Этого категорически делать нельзя.
- PAODb. Поле UID. Добавить значение по умолчанию.
  [UID] uniqueidentifier not null primary key default newid(),
- PAOCore. Определиться с принадлежностью входящих классов.
  Например: CompanyEntity и PersonEntity
	- либо CompanyEntity содержит PersonEntity
	- либо PersonEntity содержит CompanyEntity
  Объектная модель данных должна повторять структуру БД.
- PAOSQLScripts. Добавить скрипты:
  - Tables fill.sql
  - Tables clear.sql

## 2022-01-31
### Fix it
- Не актуализирован файл CHANGELOG.md.
- Почему класс BaseEntity содержит ID типа GUID, в то время, как таблицы содержать ID типа int? 
  Следует привести к единому типу: C# int + SQL int либо C# GUID + SQL uniqueidentifier.
  Для типа int поле назвать ID.
  Для типа GUID поле назвать UID.
- PAODb. Таблицу AddressOfCompany переименовать в ADDRESS.
- PAODb. Таблицу DirectorOfCompany переименовать в PERSON.
- PAODb. Таблицу Manager объединить с PERSON.
- PAODb. Таблицу ManagerPassport переименовать в PASSPORT.
- PAOCore. Модель AddressOfCompany переименовать в AddressEntity.
- PAOCore. Модель Authority переименовать в AuthorityEntity.
- PAOCore. Модель Company переименовать в CompanyEntity.
- PAOCore. Модель DirectorOfCompany переименовать в PersonEntity.
- PAOCore. Модель Manager объединить с PersonEntity.
- PAOCore. Модель ManagerPassport переименовать в PassportEntity.
### Think about it
- PAODb. Имена таблиц привести к UPPER_CASE.
- PAODb. Имена колонок ID привести к UPPER_CASE.
