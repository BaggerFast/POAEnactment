// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Mapping;

namespace PAOCore.DAL.TableModels
{
    public class AuthorityMap : ClassMap<AuthorityEntity>
    {
        public AuthorityMap()
        {
            Table("[AUTHORITY]");
            LazyLoad();

            Id(x => x.Uid).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Start).CustomSqlType("DATE").Column("START").Not.Nullable();
            Map(x => x.End).CustomSqlType("DATE").Column("END").Not.Nullable();
            Map(x => x.Number).CustomSqlType("NVARCHAR(5)").Column("NUMBER").Length(5).Not.Nullable();

            References(x => x.Company).Column("COMPANY_UID").Not.Nullable().Unique();
        }
    }
}
