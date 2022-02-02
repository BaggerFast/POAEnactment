using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class ManagerMap: ClassMap<ManagerEntity>
    {
        public ManagerMap() {
            Table("[db_scales].[MANAGER]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Phone).CustomSqlType("NVARCHAR(11)").Column("PHONE").Length(11).Not.Nullable();
            References(x => x.Fio).Column("FIO_UID").Not.Nullable().Unique();
        }
    }
}
