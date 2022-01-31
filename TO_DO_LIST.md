# To do list

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
