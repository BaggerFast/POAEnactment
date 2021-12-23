// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/
using System.Threading;

namespace PAOCore
{
    public sealed class Data
    {

        private static Data _instance;
        public static Data Instance => LazyInitializer.EnsureInitialized(ref _instance);

        #region private var
        private string clientName;
        private string clientKpp;
        private string clientInn;
        private string index;
        private string codeRegion;
        private string city;
        private string settlement;
        private string district;
        private string build;
        private string street;
        private string apartment;
        private string housing;
        private string authorityNo;
        private string clientBasedOn;
        private string numberEnd;
        private string authorityDate;
        private string firstName;
        private string lastName;
        #endregion

        public string ClientInn
        {
            get => clientInn;
            set
            {
                CheckEmptyField(value, "ИНН");
                if (value.Length == 10 || value.Length == 12)
                    clientInn = value;
            }
        }
        public string ClientKpp
        {
            get => clientKpp;
            set
            {
                CheckEmptyField(value, "КПП");
                if (value.Length == 9)
                    clientKpp = value;
            }
        }

        /// <summary>
        /// Организация
        /// </summary>
        public string ClientName
        {
            get => clientName;
            set
            {
                CheckEmptyField(value, "Название юридического лица");
                clientName = value;
            }
        }
        public string FirstName
        {
            get => firstName;
            set 
            {
                CheckEmptyField(value, "Имя");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                CheckEmptyField(value, "Фамилия");
                lastName = value;
            }
        }
        public string MiddleName { get; set; }
        public string Index
        {
            get => index;
            set
            {
                CheckEmptyField(value, "индекс");
                if (value.Length == 6)
                    index = value;
            }
        }
        public string CodeRegion
        {
            get => codeRegion;
            set
            {
                CheckEmptyField(value, "Код Региона");
                if (value.Length == 2 || value.Length == 3)
                    codeRegion = value;
            }
        }
        public string City { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string Settlement { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public string District
        {
            get => district;
            set
            {
                CheckEmptyField(value, "Район/Край/Область");
                district = value;
            }
        }
        public string Build
        {
            get => build;
            set
            {
                CheckEmptyField(value, "Дом");
                build = value;
            }
        }
        public string Street
        {
            get => street;
            set
            {
                CheckEmptyField(value, "Улица");
                street = value;
            }
        }
        public string Apartment
        {
            get => apartment;
            set
            {
                CheckEmptyField(value, "квартира");
                apartment = value;
            }
        }

        /// <summary>
        /// Корпус
        /// </summary>
        public string Housing {
            get => housing;
            set
            {
                CheckEmptyField(value, "корпус");
                housing = value;
            }
        }
        public string Director { get => $"{LastName} {FirstName} {MiddleName}"; }

        /// <summary>
        /// Номер доверенности
        /// </summary>
        public string AuthorityNo
        {
            get => authorityNo;
            set
            {
                CheckEmptyField(value, "Номер доверенности");
                authorityNo = value;
            }
        }

        /// <summary>
        /// Основание полномочий
        /// </summary>
        public string ClientBasedOn
        {
            get => clientBasedOn;
            set
            {
                CheckEmptyField(value, "Основание полномочий");
                clientBasedOn = value;
            }
        }

        /// <summary>
        /// Дата окончания доверенности
        /// </summary>
        public string NumberEnd
        {
            get => numberEnd;
            set
            {
                CheckEmptyField(value, "Дата окончания доверенности");
                numberEnd = value;
            }
        }

        /// <summary>
        /// Дата начала доверенности
        /// </summary>
        public string AuthorityDate 
        {
            get => authorityDate;
            set
            {
                CheckEmptyField(value, "Дата начала доверенности");
                authorityDate = value;
            }
        }

        private void CheckEmptyField(string value, string fieldName)
        {
            if (value.Length == 0)
                throw new EmptyFieldException(fieldName);
        }
    }
}
