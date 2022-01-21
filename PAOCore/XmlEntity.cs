// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System.Xml.Serialization;

namespace PAOCore
{   
    public class Base
    {
        #region Public and private fields and properties

        public DataHelper Data { get; private set; } = DataHelper.Instance;

        #endregion
    }

    [XmlRoot("Authority")]
    public class XmlEntity: Base
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
        public string AuthorityNo { get { return Data.AuthorityNo; } set { } }

        public string AuthorityDate { get { return Data.AuthorityDate; } set { } }
    }

    public class AuthorityHeader: Base
    {
        public string ClientName { get { return Data.ClientName; } set { } }

        public string ClientINN { get { return Data.ClientInn; } set { } }

        public string ClientKPP { get { return Data.ClientKpp; } set { } }

        [XmlElement("ClientAddress")]
        public ClientAddress Address { get { return new ClientAddress(); } set { } }

        [XmlElement("ClientPerson")]
        public ClientPerson Person { get { return new ClientPerson(); } set { } }

        public string ClientBasedOn { get { return Data.ClientBasedOn; } set { } }
    }

    public class ClientPerson : Base
    {

        public string LastName { get { return Data.LastName; } set { } }

        public string FirstName { get { return Data.FirstName; } set { } }

        public string MiddleName { get { return Data.MiddleName; } set { } }
    }

    public class ClientAddress : Base
    {
        public string Index { get { return Data.Index; } set { } }

        public string CodeRegion { get { return Data.CodeRegion; } set { } }

        public string District { get { return Data.District; } set { } }

        public string Street { get { return Data.Street; } set { } }

        public string Build { get { return Data.Build; } set { } }

        public string Housing { get { return Data.Housing; } set { } }

        public string Apartment { get { return Data.Apartment; } set { } }
    }

    public class AuthorityFooter: Base
    {
        public string FooterText1 { get { return "Доверенность выдана без права передоверия сроком до"; } set { } }

        public string DateEndOfValidity { get { return Data.NumberEnd; } set { } }

        public string FooterText2 { get { return "(Включительно)"; } set { } }
    }
}
