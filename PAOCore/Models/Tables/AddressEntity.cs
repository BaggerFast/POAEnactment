// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOСore;

namespace PAOCore.Models.Tables
{
    /// <summary>
    /// Таблица "Адрес компании".
    /// </summary>
    public class AddressEntity: BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// Индекс.
        /// </summary>
        public virtual string Index { get; set; }
        /// <summary>
        /// Код региона.
        /// </summary>
        public virtual string CodeRegion { get; set; }
        /// <summary>
        /// Район.
        /// </summary>
        public virtual string District { get; set; }
        /// <summary>
        /// Город.
        /// </summary>
        public virtual string City { get; set; }
        /// <summary>
        /// Населенный пункт.
        /// </summary>
        public virtual string Settlement { get; set; }
        /// <summary>
        /// Улица.
        /// </summary>
        public virtual string Street { get; set; }
        /// <summary>
        /// Дом.
        /// </summary>
        public virtual string Build { get; set; }
        /// <summary>
        /// Корпус.
        /// </summary>
        public virtual string Housing { get; set; }
        /// <summary>
        /// Квартира.
        /// </summary>
        public virtual string Apartment { get; set; }
        /// <summary>
        /// Компания.
        /// </summary>
        public virtual CompanyEntity Company { get; set; }

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
