// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;

namespace PAOСore
{   
    /// <summary>
    /// Базовое представление модели базы данных.
    /// </summary>
    public class BaseEntity
    {
        #region Public and private fields and properties

        /// <summary>
        /// Уникальный идентификатор (id).
        /// </summary>
        public virtual Guid UID { get; set; }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return $"{nameof(UID)}: {UID}. ";
        }

        #endregion
    }
}
