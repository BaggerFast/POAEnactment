// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;
using System;

namespace PAOCore.Models.Company
{
    /// <summary>
    /// Таблица "Доверенность"
    /// </summary>
    public class Authority : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Дата начала
        /// </summary>
        public virtual DateTime Start { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public virtual DateTime End { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public virtual string Number { get; set; }
        /// <summary>
        /// Компания
        /// </summary>
        public virtual Company Company { get; set; }

        #endregion
    }
}
