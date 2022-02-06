// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using System;
using FluentNHibernate.Mapping;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Доверенность".
    /// </summary>
    public class AuthorityEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Дата начала.
        /// </summary>
        public virtual DateTime Start { get; set; }
        /// <summary>
        /// Дата окончания.
        /// </summary>
        public virtual DateTime End { get; set; }
        /// <summary>
        /// Номер.
        /// </summary>
        public virtual string Number { get; set; }
        /// <summary>
        /// Компания.
        /// </summary>
        public virtual CompanyEntity Company { get; set; }

        #endregion


        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Start)}: {Start}. " +
                $"{nameof(End)}: {End}. " +
                $"{nameof(Number)}: {Number}. " +
                $"{nameof(Company)}: {Company}. ";
        }

        #endregion
    }

    public class AuthorityMap : ClassMap<AuthorityEntity>
    {
        public AuthorityMap()
        {
            Table("[db_scales].[AUTHORITY]");
            LazyLoad();

            Id(x => x.UID).CustomSqlType("UNIQUEIDENTIFIER").Column("UID").Unique().GeneratedBy.Guid().Not.Nullable();
            Map(x => x.Start).CustomSqlType("DATE").Column("START_ISSUE").Not.Nullable();
            Map(x => x.End).CustomSqlType("DATE").Column("END_ISSUE").Not.Nullable();
            Map(x => x.Number).CustomSqlType("NVARCHAR(5)").Column("NUMBER").Length(5).Not.Nullable();

            References(x => x.Company).Column("COMPANY_UID").Not.Nullable().Unique();
        }
    }
}
