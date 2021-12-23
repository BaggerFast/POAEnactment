// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System.Xml.Serialization;

namespace PAOCore
{   
    public class Base
    {
        protected Data data = Data.Instance;
    }

    [XmlRoot("Authority")]
    public class Xml: Base
    {
        public double DocumentVersion { get { return 1.5; } set { } }

        [XmlElement("AuthorityProperties")]
        public AuthorityProperties AuthorityProp { get { return new AuthorityProperties(); } set { } }

        [XmlElement("AuthorityHeader")]
        public AuthorityHeader Header { get { return new AuthorityHeader(); } set { } }

        [XmlElement("AuthorityFooter")]
        public AuthorityFooter Footer { get { return new AuthorityFooter(); } set { } }
    }

    public class AuthorityProperties : Base
    {
        public string AuthorityNo { get { return data.AuthorityNo; } set { } }

        public string AuthorityDate { get { return data.AuthorityDate; } set { } }
    }

    public class AuthorityHeader: Base
    {
        public string ClientName { get { return data.ClientName; } set { } }

        public string ClientINN { get { return data.ClientInn; } set { } }

        public string ClientKPP { get { return data.ClientKpp; } set { } }

        [XmlElement("ClientAddress")]
        public ClientAddress Address { get { return new ClientAddress(); } set { } }

        [XmlElement("ClientPerson")]
        public ClientPerson Person { get { return new ClientPerson(); } set { } }

        public string ClientBasedOn { get { return data.ClientBasedOn; } set { } }
    }

    public class ClientPerson : Base
    {

        public string LastName { get { return data.LastName; } set { } }

        public string FirstName { get { return data.FirstName; } set { } }

        public string MiddleName { get { return data.MiddleName; } set { } }
    }

    public class ClientAddress : Base
    {
        public string Index { get { return data.Index; } set { } }

        public string CodeRegion { get { return data.CodeRegion; } set { } }

        public string District { get { return data.District; } set { } }

        public string Street { get { return data.Street; } set { } }

        public string Build { get { return data.Build; } set { } }

        public string Housing { get { return data.Housing; } set { } }

        public string Apartment { get { return data.Apartment; } set { } }
    }

    public class AuthorityFooter: Base
    {
        public string FooterText1 { get { return "Доверенность выдана без права передоверия сроком до"; } set { } }

        public string DateEndOfValidity { get { return data.NumberEnd; } set { } }

        public string FooterText2 { get { return "(Включительно)"; } set { } }
    }
}
