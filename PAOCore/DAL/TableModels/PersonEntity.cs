// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOCore.DAL.Models;

namespace PAOCore.DAL.TableModels
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
        public virtual string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Фамилия.
        /// </summary>
        public virtual string LastName { get; set; } = string.Empty;
        /// <summary>
        /// Отчество.
        /// </summary>
        public virtual string MiddleName { get; set; } = string.Empty;
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
