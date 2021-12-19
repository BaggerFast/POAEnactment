namespace PAOWinForms
{
    static class Data
    {
        public static string clientInn; // Инн
        public static string clientKpp; // Кпп
        public static string clientName; // организация

        public static string firstName; // имя
        public static string lastName; // фамиилия
        public static string middleName; // отчество
        public static string index; // индекс
        public static string codeRegion; // регион
        
        public static string city; //город
       
        public static string settlement; // насееленный пункт
        public static string district; //район

        public static string build; //дом
        public static string street; //улица
        public static string apartment; //квартира
        public static string housing; //подьезд

        public static string director { get => $"{lastName} {firstName} {middleName}"; }

        public static string authorityNo; // номер доверенности

        public static string clientBasedOn;
        public static string numberEnd;
        public static string authorityDate;
    }
}
