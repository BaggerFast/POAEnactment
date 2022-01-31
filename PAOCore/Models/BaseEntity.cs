// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;

namespace PAOСore
{   
    /// <summary>
    /// Базовое представление модели базы данных.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Уникальный идентификатор (id).
        /// </summary>
        public virtual Guid ID { get; set; }
    }
}
