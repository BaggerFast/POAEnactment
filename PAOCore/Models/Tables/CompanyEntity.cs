// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;


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
        public virtual DirectorEntity Director { get; set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public virtual AddressEntity Address { get; set; }
        /// <summary>
        /// Основания полномочий.
        /// </summary>
        public virtual string ClientBasedOn { get; set; }

        #endregion
    }
}
