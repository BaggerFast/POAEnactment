// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Mapping;


namespace PAOCore.Models.Tables
{
    public class PassportMap : ClassMap<PassportEntity>
    {
        public PassportMap()
        {
            Table("[db_scales].[PASSPORT]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Series).CustomSqlType("NVARCHAR(4)").Column("SERIES").Length(4).Not.Nullable();
            Map(x => x.Number).CustomSqlType("NVARCHAR(6)").Column("NUMBER").Length(6).Not.Nullable();
            Map(x => x.DateIssue).CustomSqlType("DATE").Column("DATE_ISSUE").Not.Nullable();
            Map(x => x.PlaceIssue).CustomSqlType("NVARCHAR(60)").Column("PLACE_ISSUE").Length(60).Not.Nullable();

            References(x => x.Manager).Column("MANAGER_UID").Not.Nullable().Unique();
        }
    }
}
