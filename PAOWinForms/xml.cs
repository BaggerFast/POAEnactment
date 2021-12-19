using System.Xml.Serialization;

namespace PAOWinForms
{
    [XmlRoot("Authority")]
    public class Xml
    {
        public double DocumentVersion { get { return 1.5; } set { } }

        [XmlElement("AuthorityProperties")]
        public AuthorityProperties AuthorityProp { get { return new AuthorityProperties(); } set { } }

        [XmlElement("AuthorityHeader")]
        public AuthorityHeader Header { get { return new AuthorityHeader(); } set { } }

        [XmlElement("AuthorityFooter")]
        public AuthorityFooter Footer { get { return new AuthorityFooter(); } set { } }
    }

    public class AuthorityProperties
    {
        public string AuthorityNo { get { return Data.authorityNo; } set { } }

        public string AuthorityDate { get { return Data.authorityDate; } set { } }
    }

    public class AuthorityHeader
    {
        public string ClientName { get { return Data.clientName; } set { } }

        public string ClientINN { get { return Data.clientInn; } set { } }

        public string ClientKPP { get { return Data.clientKpp; } set { } }

        [XmlElement("ClientAddress")]
        public ClientAddress Address { get { return new ClientAddress(); } set { } }

        [XmlElement("ClientPerson")]
        public ClientPerson Person { get { return new ClientPerson(); } set { } }

        public string ClientBasedOn { get { return Data.clientBasedOn; } set { } }
    }

    public class ClientPerson
    {

        public string LastName { get { return Data.lastName; } set { } }

        public string FirstName { get { return Data.firstName; } set { } }

        public string MiddleName { get { return Data.middleName; } set { } }
    }

    public class ClientAddress
    {
        public string Index { get { return Data.index; } set { } }

        public string CodeRegion { get { return Data.codeRegion; } set { } }

        public string District { get { return Data.district; } set { } }

        public string Street { get { return Data.street; } set { } }

        public string Build { get { return Data.build; } set { } }

        public string Housing { get { return Data.housing; } set { } }

        public string Apartment { get { return Data.apartment; } set { } }
    }

    public class AuthorityFooter
    {
        public string FooterText1 { get { return "Доверенность выдана без права передоверия сроком до"; } set { } }

        public string DateEndOfValidity { get { return Data.numberEnd; } set { } }

        public string FooterText2 { get { return "(Включительно)"; } set { } }
    }
}
