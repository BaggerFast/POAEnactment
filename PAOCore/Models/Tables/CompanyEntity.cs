// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using FluentNHibernate.Mapping;


namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Компания".
    /// </summary>
    public class CompanyEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Название.
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Кпп.
        /// </summary>
        public virtual string Kpp { get; set; }
        /// <summary>
        /// Инн.
        /// </summary>
        public virtual string Inn { get; set; }
        /// <summary>
        /// Директор.
        /// </summary>
        public virtual PersonEntity Director { get; set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public virtual AddressEntity Address { get; set; }
        /// <summary>
        /// Основания полномочий.
        /// </summary>
        public virtual string ClientBasedOn { get; set; }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Name)}: {Name}. " +
                $"{nameof(Kpp)}: {Kpp}. " +
                $"{nameof(Inn)}: {Inn}. " +
                $"{nameof(Director)}: {Director}. " +
                $"{nameof(Address)}: {Address}. " +
                $"{nameof(ClientBasedOn)}: {ClientBasedOn}. ";
        }

        #endregion
    }

    public class CompanyMap : ClassMap<CompanyEntity>
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
