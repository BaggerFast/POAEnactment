// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOCore.DAL.Models;

namespace PAOCore.DAL.TableModels
{
    /// <summary>
    /// Таблица "Адрес компании".
    /// </summary>
    public class AddressEntity : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Индекс.
        /// </summary>
        public virtual string Index { get; set; } = string.Empty;
        /// <summary>
        /// Код региона.
        /// </summary>
        public virtual string CodeRegion { get; set; } = string.Empty;
        /// <summary>
        /// Район.
        /// </summary>
        public virtual string District { get; set; } = string.Empty;
        /// <summary>
        /// Город.
        /// </summary>
        public virtual string City { get; set; } = string.Empty;
        /// <summary>
        /// Населенный пункт.
        /// </summary>
        public virtual string Settlement { get; set; } = string.Empty;
        /// <summary>
        /// Улица.
        /// </summary>
        public virtual string Street { get; set; } = string.Empty;
        /// <summary>
        /// Дом.
        /// </summary>
        public virtual string Build { get; set; } = string.Empty;
        /// <summary>
        /// Корпус.
        /// </summary>
        public virtual string Housing { get; set; } = string.Empty;
        /// <summary>
        /// Квартира.
        /// </summary>
        public virtual string Apartment { get; set; } = string.Empty;
        /// <summary>
        /// Компания.
        /// </summary>
        public virtual CompanyEntity Company { get; set; } = new CompanyEntity();

        #endregion

        #region Public and private methods

        public override string ToString()
        {
            return base.ToString() +
                $"{nameof(Index)}: {Index}. " +
                $"{nameof(CodeRegion)}: {CodeRegion}. " +
                $"{nameof(District)}: {District}. " +
                $"{nameof(City)}: {City}. " +
                $"{nameof(Settlement)}: {Settlement}. " +
                $"{nameof(Street)}: {Street}. " +
                $"{nameof(Build)}: {Build}. " +
                $"{nameof(Housing)}: {Housing}. " +
                $"{nameof(Apartment)}: {Apartment}. " +
                $"{nameof(Company)}: {Company}. ";
        }

        #endregion
    }
}
