// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Mapping;

namespace PAOCore.DAL.TableModels
{
    public class CompanyMap : ClassMap<CompanyEntity>
    {
        public CompanyMap()
        {
            Table("[COMPANY]");
            LazyLoad();

            Id(x => x.Uid).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Name).CustomSqlType("NVARCHAR(40)").Column("NAME").Length(40).Not.Nullable();
            Map(x => x.Kpp).CustomSqlType("NVARCHAR(12)").Column("KPP").Length(12).Not.Nullable();
            Map(x => x.Inn).CustomSqlType("NVARCHAR(9)").Column("INN").Length(9).Not.Nullable();
            Map(x => x.ClientBasedOn).CustomSqlType("NVARCHAR(10)").Column("CLIENT_BASE_ON").Length(10).Not.Nullable();

            //References(x => x.Director).Column("DIRECTOR_UID").Not.Nullable().Unique();
            References(x => x.Director).Column("DIRECTOR_UID").Not.Nullable();
        }
    }
}
