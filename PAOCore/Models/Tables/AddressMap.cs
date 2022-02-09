// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

 using FluentNHibernate.Mapping;

namespace PAOCore.Models.Tables
{
    public class AddressMap : ClassMap<AddressEntity>
    {
        public AddressMap()
        {
            Table("[db_scales].[ADDRESS]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Index).CustomSqlType("NVARCHAR(6)").Column("INDEX").Length(6).Not.Nullable();
            Map(x => x.CodeRegion).CustomSqlType("NVARCHAR(3)").Column("CODE_REGION").Length(3).Not.Nullable();
            Map(x => x.District).CustomSqlType("NVARCHAR(30)").Column("DISTRICT").Length(30).Not.Nullable();
            Map(x => x.City).CustomSqlType("NVARCHAR(30)").Column("CITY").Length(30).Nullable();
            Map(x => x.Settlement).CustomSqlType("NVARCHAR(30)").Column("SETTLEMENT").Length(30).Nullable();
            Map(x => x.Street).CustomSqlType("NVARCHAR(30)").Column("STREET").Length(30).Not.Nullable();
            Map(x => x.Build).CustomSqlType("NVARCHAR(5)").Column("BUILD").Length(5).Not.Nullable();
            Map(x => x.Housing).CustomSqlType("NVARCHAR(4)").Column("SETTLEMENT").Length(4).Not.Nullable();
            Map(x => x.Apartment).CustomSqlType("NVARCHAR(3)").Column("APARTMENT").Length(3).Not.Nullable();

            References(x => x.Company).Column("COMPANY_UID").Not.Nullable().Unique();
        }
    }
}
