// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using FluentNHibernate.Mapping;

namespace PAOCore.DAL.TableModels
{
    public class PersonMap : ClassMap<PersonEntity>
    {
        public PersonMap()
        {
            Table("[PERSON]");
            LazyLoad();

            Id(x => x.Uid).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.FirstName).CustomSqlType("NVARCHAR(20)").Column("FIRST_NAME").Length(20).Not.Nullable();
            Map(x => x.LastName).CustomSqlType("NVARCHAR(20)").Column("LAST_NAME").Length(20).Not.Nullable();
            Map(x => x.MiddleName).CustomSqlType("NVARCHAR(20)").Column("MIDDLE_NAME").Length(20).Nullable();
        }
    }
}
