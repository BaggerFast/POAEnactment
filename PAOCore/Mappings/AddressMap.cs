using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class AddressMap: ClassMap<AddressEntity>
    {
        public AddressMap() {
            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Index).CustomSqlType("NCHAR(6)").Column("INDEX").Length(6).Not.Nullable();
            Map(x => x.CodeRegion).CustomSqlType("NCHAR(3)").Column("CODE_REGION").Length(3).Not.Nullable();
            Map(x => x.District).CustomSqlType("NCHAR(30)").Column("DISTRICT").Length(30).Not.Nullable();
            Map(x => x.City).CustomSqlType("NCHAR(30)").Column("DISTRICT").Length(30).Not.Nullable();
            Map(x => x.Settlement).CustomSqlType("NCHAR(30)").Column("DISTRICT").Length(30).Not.Nullable(); ;
            Map(x => x.Street).Not.Nullable();
            Map(x => x.Build).Not.Nullable();
            Map(x => x.Housing).Not.Nullable();
            Map(x => x.Apartment).Not.Nullable();
        }
    }
}
