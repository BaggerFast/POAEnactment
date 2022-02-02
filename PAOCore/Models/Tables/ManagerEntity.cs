// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Уполномоченное лицо".
    /// </summary>
    public class ManagerEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Персональ
        /// </summary>
        public virtual PersonEntity Fio { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// Пасспорт
        /// </summary>
        public virtual PassportEntity Passport { get; set; }

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Fio)}: {Fio}. " +
                $"{nameof(Phone)}: {Passport}. " +
                $"{nameof(Passport)}: {Passport}. ";
        }

        #endregion
    }
}
