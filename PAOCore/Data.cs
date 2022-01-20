// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace PAOCore
{
    public sealed class Data
    {

        private static Data _instance;
        public static Data Instance => LazyInitializer.EnsureInitialized(ref _instance);

        [Required(ErrorMessage = "Необходимо заполнить поле ИНН")]
        [LengthInArrayAttribute(new int[] { 9, 12 }, ErrorMessage = "Поле ИНН должно содержать 10 или 12 символов")]
        public string ClientInn { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле КПП")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Поле КПП должно состоять из 9 символов")]
        public string ClientKpp { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле ОРГАНИЗАЦИЯ")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле ИМЯ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле ФАМИЛИЯ")]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле ИНДЕКС")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Поле ИНДЕКС должно состоять из 6 символов")]
        public string Index { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле КОД РЕГИОНА")]
        [StringLength(3, MinimumLength = 2, ErrorMessage = "Поле КОД РЕГИОНА должно состоять из 2-3 символов")]
        public string CodeRegion { get; set; }

        //[Required(ErrorMessage = "Необходимо заполнить поле ГОРОД")]
        [SyncTwoAttribute("Settlement", ErrorMessage="Заполните поле ГОРОД или НАСЕЛЕННЫЙ ПУНКТ")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Необходимо заполнить поле НАСЕЛЕНЫЙ ПУНКТ")]
        public string Settlement { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле РАЙОН/КРАЙ/ОБЛАСТЬ")]
        public string District { get; set; }
        
        [Required(ErrorMessage = "Необходимо заполнить поле ДОМ")]
        public string Build { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле УЛИЦА")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле КВАРТИРА")]
        [Range(1, 1000, ErrorMessage = "Поле КВАРТИРА должно быть от 1-1000")]
        public string Apartment { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле КОРПУС")]
        public string Housing { get; set; }

        //[Required(ErrorMessage = "Необходимо заполнить поле НОМЕР ДОВЕРЕННОСТИ")]
        public string AuthorityNo { get; set; }

        [Required(ErrorMessage = "Необходимо заполнить поле ОСНОВАНИЕ ПОЛНОМОЧИЙ")]
        public string ClientBasedOn { get; set; }

        //[Required(ErrorMessage = "Необходимо заполнить поле ДАТА ОКОНЧАНИЯ ДОВЕРЕННОСТИ")]
        public string NumberEnd { get; set; }

        //[Required(ErrorMessage = "Необходимо заполнить поле ДАТА НАЧАЛА ДОВЕРЕННОСТИ")]
        public string AuthorityDate { get; set; }

        public string Director { get => $"{LastName} {FirstName} {MiddleName}"; }
    }
}
