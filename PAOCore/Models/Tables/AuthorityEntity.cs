// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using System;

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
}
