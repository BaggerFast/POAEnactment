using System;
using System.Collections.Generic;
using System.Text;

namespace PAOСore
{
    /// <summary>
    /// Таблица "Уполномоченное лицо"
    /// </summary>
    public class Manager : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Имя
        /// </summary>
        public virtual string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public virtual string LastName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public virtual string MiddleName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// Пасспорт
        /// </summary>
        public virtual ManagerPassport Passport{ get; set; }
        
        #endregion

    }

}
