using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class AuthorityMap: ClassMap<AuthorityEntity>
    {
        public AuthorityMap() {
            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Start).CustomSqlType("DATE").Column("START_ISSUE").Not.Nullable();
            Map(x => x.End).CustomSqlType("DATE").Column("END_ISSUE").Not.Nullable();
            Map(x => x.Number).CustomSqlType("NVARCHAR(5)").Column("NUMBER").Length(5).Not.Nullable();
        }
    }
}
