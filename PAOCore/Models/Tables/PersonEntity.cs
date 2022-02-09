// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Директор компании"
    /// </summary>
    public class PersonEntity : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Имя.
        /// </summary>
        public virtual string FirstName { get; set; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public virtual string LastName { get; set; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public virtual string MiddleName { get; set; }
        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                   $"{nameof(FirstName)}: {FirstName}. " +
                   $"{nameof(LastName)}: {LastName}. " +
                   $"{nameof(MiddleName)}: {MiddleName}. ";
        }

        #endregion
    }

}
