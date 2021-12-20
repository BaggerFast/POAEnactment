namespace PAOCore
{
    public static class Data
    {
        public static string ClientInn { get; set; }
      
        public static string ClientKpp { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public static string ClientName { get; set; } 

        public static string FirstName { get; set; } 
        public static string LastName { get; set; } 

        /// <summary>
        /// Отчество
        /// </summary>
        public static string MiddleName { get; set; }
        public static string Index { get; set; } 
        public static string CodeRegion { get; set; }
        public static string City { get; set; }

        /// <summary>
        /// Населенный пункт
        /// </summary>
        public static string Settlement { get; set; }

        /// <summary>
        /// Район
        /// </summary>
        public static string District { get; set; } 

        /// <summary>
        /// Дом
        /// </summary>
        public static string Build { get; set; } 
        public static string Street { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public static string Apartment { get; set; }

        /// <summary>
        /// Подьезд
        /// </summary>
        public static string Housing { get; set; } 
        public static string Director { get => $"{LastName} {FirstName} {MiddleName}"; } 

        /// <summary>
        /// Номер доверенности
        /// </summary>
        public static string AuthorityNo { get; set; } 

        /// <summary>
        /// Основание полномочий
        /// </summary>
        public static string ClientBasedOn { get; set; }  
        
        /// <summary>
        /// Дата окончания доверенности
        /// </summary>
        public static string NumberEnd { get; set; }

        /// <summary>
        /// Дата начала доверенности
        /// </summary>
        public static string AuthorityDate { get; set; }
    }
}
