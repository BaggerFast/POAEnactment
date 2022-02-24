// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOCore.DAL.Models;

namespace PAOCore.DAL.TableModels
{
    /// <summary>
    /// Таблица "Компания".
    /// </summary>
    public class CompanyEntity : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Название.
        /// </summary>
        public virtual string Name { get; set; } = string.Empty;
        /// <summary>
        /// Кпп.
        /// </summary>
        public virtual string Kpp { get; set; } = string.Empty;
        /// <summary>
        /// Инн.
        /// </summary>
        public virtual string Inn { get; set; } = string.Empty;
        /// <summary>
        /// Директор.
        /// </summary>
        public virtual PersonEntity Director { get; set; } = new PersonEntity();
        /// <summary>
        /// Основания полномочий.
        /// </summary>
        public virtual string ClientBasedOn { get; set; } = string.Empty;

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Name)}: {Name}. " +
                $"{nameof(Kpp)}: {Kpp}. " +
                $"{nameof(Inn)}: {Inn}. " +
                $"{nameof(Director)}: {Director}. " +
                $"{nameof(ClientBasedOn)}: {ClientBasedOn}. ";
        }

        #endregion
    }
}
