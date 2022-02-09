// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Mapping;

namespace PAOCore.Models.Tables
{
    public class ManagerMap : ClassMap<ManagerEntity>
    {
        public ManagerMap()
        {
            Table("[db_scales].[MANAGER]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Phone).CustomSqlType("NVARCHAR(11)").Column("PHONE").Length(11).Not.Nullable();
            References(x => x.Fio).Column("FIO_UID").Not.Nullable().Unique();
        }
    }
}
