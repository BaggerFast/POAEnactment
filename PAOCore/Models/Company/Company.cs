using System;
using System.Collections.Generic;
using System.Text;

namespace PAOСore
{
    public class Company: BaseEntity
    {
        #region public and private fields and properties

        public virtual string Name { get; set; }

        public virtual string Kpp { get; set; }

        public virtual string Inn { get; set; }

        public virtual DirectorOfCompany Director { get; set; }

        public virtual AddressOfCompany Address{ get; set; }

        public virtual string ClientBasedOn { get; set; }

        #endregion
    }

    public class DirectorOfCompany: BaseEntity
    {
        #region public and private fields and properties

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string MiddleName { get; set; }

        public virtual Company Company { get; set; }

        #endregion

    }

    public class AddressOfCompany: BaseEntity
    {
        #region public and private fields and properties
        
        public virtual string Index { get; set; }

        public virtual string CodeRegion { get; set; }

        public virtual string District { get; set; }

        public virtual string City { get; set; }

        public virtual string Settlement { get; set; }

        public virtual string Street { get; set; }

        public virtual string Build { get; set; }

        public virtual string Housing { get; set; }

        public virtual string Apartment { get; set; }

        public virtual Company Company { get; set; }

        #endregion
    }

    public class Authority: BaseEntity
    {
        #region public and private fields and properties

        public virtual DateTime Start { get; set; }

        public virtual DateTime End { get; set; }

        public virtual string District { get; set; }

        public virtual Company Company { get; set; }

        #endregion
    }



}
