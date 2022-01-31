// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using System;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Паспорт".
    /// </summary>
    public class PassportEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Серия паспорта.
        /// </summary>
        public virtual string Series { get; set; }
        /// <summary>
        /// Номер пасспорта.
        /// </summary>
        public virtual string Number { get; set; }
        /// <summary>
        /// Дата получения.
        /// </summary>
        public virtual DateTime DateIssue { get; set; }
        /// <summary>
        /// Место получения.
        /// </summary>
        public virtual string PlaceIssue { get; set; }
        /// <summary>
        /// Уполномоченное лицо.
        /// </summary>
        public virtual ManagerEntity Manager{ get; set; }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Series)}: {Series}. " +
                $"{nameof(Number)}: {Number}. " +
                $"{nameof(DateIssue)}: {DateIssue}. " +
                $"{nameof(PlaceIssue)}: {PlaceIssue}. " +
                $"{nameof(Manager)}: {Manager}. ";
        }

        #endregion
    }
}
