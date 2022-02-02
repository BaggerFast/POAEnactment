using FluentNHibernate.Mapping;
using PAOCore.Models.Tables;

namespace PAOCore.Mappings
{
    class PersonMap: ClassMap<PersonEntity>
    {
        public PersonMap()
        {
            Table("[db_scales].[PERSON]");
            LazyLoad();
            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.FirstName).CustomSqlType("NVARCHAR(20)").Column("FIRST_NAME").Length(20).Not.Nullable();
            Map(x => x.LastName).CustomSqlType("NVARCHAR(20)").Column("LAST_NAME").Length(20).Not.Nullable();
            Map(x => x.MiddleName).CustomSqlType("NVARCHAR(20)").Column("MIDDLE_NAME").Length(20);
        }
    }
}
