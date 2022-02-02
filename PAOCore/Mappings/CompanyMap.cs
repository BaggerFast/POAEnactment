using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class CompanyMap : ClassMap<CompanyEntity>
    {
        public CompanyMap()
        {
            Table("[db_scales].[COMPANY]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Name).CustomSqlType("NVARCHAR(40)").Column("NAME").Length(40).Not.Nullable();
            Map(x => x.Kpp).CustomSqlType("NVARCHAR(12)").Column("KPP").Length(12).Not.Nullable();
            Map(x => x.Inn).CustomSqlType("NVARCHAR(9)").Column("INN").Length(9).Not.Nullable();
            Map(x => x.ClientBasedOn).CustomSqlType("NVARCHAR(10)").Column("CLIENT_BASE_ON").Length(10).Not.Nullable();

            References(x => x.Director).Column("DIRECTOR_UID").Not.Nullable().Unique();
        }
    }
}
