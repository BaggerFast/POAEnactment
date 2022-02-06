// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using FluentNHibernate.Mapping;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Адрес компании".
    /// </summary>
    public class AddressEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Индекс.
        /// </summary>
        public virtual string Index { get; set; }
        /// <summary>
        /// Код региона.
        /// </summary>
        public virtual string CodeRegion { get; set; }
        /// <summary>
        /// Район.
        /// </summary>
        public virtual string District { get; set; }
        /// <summary>
        /// Город.
        /// </summary>
        public virtual string City { get; set; }
        /// <summary>
        /// Населенный пункт.
        /// </summary>
        public virtual string Settlement { get; set; }
        /// <summary>
        /// Улица.
        /// </summary>
        public virtual string Street { get; set; }
        /// <summary>
        /// Дом.
        /// </summary>
        public virtual string Build { get; set; }
        /// <summary>
        /// Корпус.
        /// </summary>
        public virtual string Housing { get; set; }
        /// <summary>
        /// Квартира.
        /// </summary>
        public virtual string Apartment { get; set; }
        /// <summary>
        /// Компания.
        /// </summary>
        public virtual CompanyEntity Company { get; set; }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Index)}: {Index}. " +
                $"{nameof(CodeRegion)}: {CodeRegion}. " +
                $"{nameof(District)}: {District}. " +
                $"{nameof(City)}: {City}. " +
                $"{nameof(Settlement)}: {Settlement}. " +
                $"{nameof(Street)}: {Street}. " +
                $"{nameof(Build)}: {Build}. " +
                $"{nameof(Housing)}: {Housing}. " +
                $"{nameof(Apartment)}: {Apartment}. " +
                $"{nameof(Company)}: {Company}. ";
        }

        #endregion
    }

    public class AddressMap : ClassMap<AddressEntity>
    {
        public AddressMap()
        {
            Table("[db_scales].[ADDRESS]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Index).CustomSqlType("NVARCHAR(6)").Column("INDEX").Length(6).Not.Nullable();
            Map(x => x.CodeRegion).CustomSqlType("NVARCHAR(3)").Column("CODE_REGION").Length(3).Not.Nullable();
            Map(x => x.District).CustomSqlType("NVARCHAR(30)").Column("DISTRICT").Length(30).Not.Nullable();
            Map(x => x.City).CustomSqlType("NVARCHAR(30)").Column("CITY").Length(30).Nullable();
            Map(x => x.Settlement).CustomSqlType("NVARCHAR(30)").Column("SETTLEMENT").Length(30).Nullable();
            Map(x => x.Street).CustomSqlType("NVARCHAR(30)").Column("STREET").Length(30).Not.Nullable();
            Map(x => x.Build).CustomSqlType("NVARCHAR(5)").Column("BUILD").Length(5).Not.Nullable();
            Map(x => x.Housing).CustomSqlType("NVARCHAR(4)").Column("SETTLEMENT").Length(4).Not.Nullable();
            Map(x => x.Apartment).CustomSqlType("NVARCHAR(3)").Column("APARTMENT").Length(3).Not.Nullable();

            References(x => x.Company).Column("COMPANY_UID").Not.Nullable().Unique();
        }
    }
}
