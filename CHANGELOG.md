# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]
-

## [0.03.010] - 2022-02-24
### Added
- Microsoft.Data.SqlClient NuGet package
- PAOCore: DAL.Models
- PAOCore: DAL.TableModels
- PAOCoreTests: DAL.TableModels.CompanyEntityTests

## [0.02.060] - 2022-02-09
### Added
- PAOCoreTests v.0.02.060
  - add test for sql configuration
### Changed
- PAOSQLScripts v.0.02.060
  - fix bug in SqlFill
- CoreTests v.0.02.060
  - remove this project
- PAOCore v.0.02.060
  - Move TableMap to another files
- PAOWinForms v.0.02.060

## [0.02.050] - 2022-01-31
### Added
- PAOSQLScripts v.0.02.050
  - add important SQL scripts for tests
### Changed
- PAOCore v.0.02.050
  - Rewritten models of SQL tables
- PAODb v.0.02.050
  - Some changes in models of SQL tables (Manager, Person, Company)
- PAOCoreTests v.0.02.050
- PAOWinForms v.0.02.050

## [0.02.040] - 2022-01-31
### Added
- Sql tables
- Models classes for sql tables
- CoreTests v.0.02.040
- PAOSQLScripts v.0.02.040
### Changed
- PAOCore v.0.02.030
  - Moved models classes to another namespace
  - Rewritten validation of DataHelper class
- PAODb v.0.02.030
- PAOCoreTests v.0.02.040
- PAOWinForms v.0.02.030

## [0.02.010] - 2022-01-21
### Added
- Added regions
### Changed
- PAOCore v.0.02.010
  - Renamed Data into DataHelper
  - Renamed Xml into XmlEntity
- PAOTests v.0.02.010
- PAOWinForms v.0.02.010
