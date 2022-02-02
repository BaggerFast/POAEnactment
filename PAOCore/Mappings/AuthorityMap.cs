using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class AuthorityMap: ClassMap<AuthorityEntity>
    {
        public AuthorityMap() {
            Table("[db_scales].[AUTHORITY]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Start).CustomSqlType("DATE").Column("START_ISSUE").Not.Nullable();
            Map(x => x.End).CustomSqlType("DATE").Column("END_ISSUE").Not.Nullable();
            Map(x => x.Number).CustomSqlType("NVARCHAR(5)").Column("NUMBER").Length(5).Not.Nullable();

            References(x => x.Company).Column("COMPANY_UID").Not.Nullable().Unique();
        }
    }
}
